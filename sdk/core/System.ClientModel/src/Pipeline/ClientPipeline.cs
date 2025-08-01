﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Internal;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace System.ClientModel.Primitives;

/// <summary>
/// Represents an extensible pipeline used by clients that call cloud services
/// to send and receive HTTP request and responses. Creators of
/// <see cref="ClientPipeline"/> can modify how it process a
/// <see cref="PipelineMessage"/> by adding <see cref="PipelinePolicy"/>
/// instances at various points in the default pipeline.
/// </summary>
public sealed partial class ClientPipeline
{
    internal static TimeSpan DefaultNetworkTimeout { get; } = TimeSpan.FromSeconds(100);

    private readonly int _perCallIndex;
    private readonly int _perTryIndex;
    private readonly int _beforeTransportIndex;

    private readonly ReadOnlyMemory<PipelinePolicy> _policies;
    private readonly PipelineTransport _transport;
    private readonly bool _enableLogging;

    private readonly TimeSpan _networkTimeout;

    private ClientPipeline(ReadOnlyMemory<PipelinePolicy> policies, TimeSpan networkTimeout, int perCallIndex, int perTryIndex, int beforeTransportIndex, bool enableLogging)
    {
        if (policies.Span[policies.Length - 1] is not PipelineTransport)
        {
            throw new ArgumentException("The last policy must be of type 'PipelineTransport'.", nameof(policies));
        }

        Debug.Assert(perCallIndex <= perTryIndex);
        Debug.Assert(perTryIndex <= beforeTransportIndex);

        _transport = (PipelineTransport)policies.Span[policies.Length - 1];
        _policies = policies;

        _perCallIndex = perCallIndex;
        _perTryIndex = perTryIndex;
        _beforeTransportIndex = beforeTransportIndex;

        _networkTimeout = networkTimeout;
        _enableLogging = enableLogging;
    }

    #region Factory methods for creating a pipeline instance

    /// <summary>
    /// Create an instance of a <see cref="ClientPipeline"/> from the provided
    /// <see cref="ClientPipelineOptions"/>.
    /// </summary>
    /// <param name="options">If provided, the
    /// <see cref="ClientPipelineOptions"/> to use to construct the
    /// <see cref="ClientPipeline"/>.</param>
    /// <returns>The created <see cref="ClientPipeline"/> instance.</returns>
    public static ClientPipeline Create(ClientPipelineOptions? options = default)
        => Create(options ?? ClientPipelineOptions.Default,
            ReadOnlySpan<PipelinePolicy>.Empty,
            ReadOnlySpan<PipelinePolicy>.Empty,
            ReadOnlySpan<PipelinePolicy>.Empty);

    /// <summary>
    /// Create an instance of a <see cref="ClientPipeline"/> from the provided
    /// <see cref="ClientPipelineOptions"/> and <see cref="PipelinePolicy"/>
    /// collections.
    /// </summary>
    /// <param name="options"> The <see cref="ClientPipelineOptions"/> to use to
    /// construct the <see cref="ClientPipeline"/>.</param>
    /// <param name="perCallPolicies">A collection of <see cref="PipelinePolicy"/>
    /// instances to add to the default pipeline before the pipeline's retry
    /// policy.</param>
    /// <param name="perTryPolicies">A collection of <see cref="PipelinePolicy"/>
    /// instances to add to the default pipeline after the pipeline's retry
    /// policy.</param>
    /// <param name="beforeTransportPolicies">A collection of
    /// <see cref="PipelinePolicy"/> instances to add to the default pipeline
    /// before the pipeline's transport.</param>
    /// <returns>The created <see cref="ClientPipeline"/> instance.</returns>
    /// <remarks>Policies provided in <paramref name="options"/> are intended
    /// to come from the end-user of a client who has passed the
    /// <see cref="ClientPipelineOptions"/> instance to the client's
    /// constructor. The client constructor implementation is intended to pass
    /// client-specific policies using the <paramref name="perCallPolicies"/>,
    /// <paramref name="perTryPolicies"/>, and
    /// <paramref name="beforeTransportPolicies"/> parameters and should not
    /// modify the <see cref="ClientPipelineOptions"/> provided by the client
    /// user.
    /// </remarks>
    public static ClientPipeline Create(
        ClientPipelineOptions options,
        ReadOnlySpan<PipelinePolicy> perCallPolicies,
        ReadOnlySpan<PipelinePolicy> perTryPolicies,
        ReadOnlySpan<PipelinePolicy> beforeTransportPolicies)
    {
        Argument.AssertNotNull(options, nameof(options));

        options.Freeze();
        options.ClientLoggingOptions?.ValidateOptions();

        // Add length of client-specific policies.
        int pipelineLength = perCallPolicies.Length + perTryPolicies.Length + beforeTransportPolicies.Length;

        // Add length of end-user provided policies.
        pipelineLength += options.PerTryPolicies?.Length ?? 0;
        pipelineLength += options.PerCallPolicies?.Length ?? 0;
        pipelineLength += options.BeforeTransportPolicies?.Length ?? 0;

        pipelineLength++; // for retry policy
        pipelineLength += options.AddMessageLoggingPolicy ? 1 : 0; // for message logging policy
        pipelineLength++; // for transport

        PipelinePolicy[] policies = new PipelinePolicy[pipelineLength];

        int index = 0;

        // Per call policies come before the retry policy.
        perCallPolicies.CopyTo(policies.AsSpan(index));
        index += perCallPolicies.Length;

        if (options.PerCallPolicies != null)
        {
            options.PerCallPolicies.CopyTo(policies.AsSpan(index));
            index += options.PerCallPolicies.Length;
        }

        int perCallIndex = index;

        // Add retry policy.
        policies[index++] = options.RetryPolicy ?? options.GetClientRetryPolicy();

        // Per try policies come after the retry policy.
        perTryPolicies.CopyTo(policies.AsSpan(index));
        index += perTryPolicies.Length;

        if (options.PerTryPolicies != null)
        {
            options.PerTryPolicies.CopyTo(policies.AsSpan(index));
            index += options.PerTryPolicies.Length;
        }

        int perTryIndex = index;

        // Add logging policy just before the transport.

        if (options.AddMessageLoggingPolicy)
        {
            policies[index++] = options.MessageLoggingPolicy ?? options.GetMessageLoggingPolicy();
        }

        // Before transport policies come before the transport.
        beforeTransportPolicies.CopyTo(policies.AsSpan(index));
        index += beforeTransportPolicies.Length;

        if (options.BeforeTransportPolicies != null)
        {
            options.BeforeTransportPolicies.CopyTo(policies.AsSpan(index));
            index += options.BeforeTransportPolicies.Length;
        }

        int beforeTransportIndex = index;

        // Add the transport.
        policies[index++] = options.Transport ?? options.GetHttpClientPipelineTransport();

        bool enableLogging = options.ClientLoggingOptions?.EnableLogging ?? ClientLoggingOptions.DefaultEnableLogging;

        return new ClientPipeline(policies,
            options.NetworkTimeout ?? DefaultNetworkTimeout,
            perCallIndex, perTryIndex, beforeTransportIndex, enableLogging);
    }

    #endregion

    /// <summary>
    /// Creates a <see cref="PipelineMessage"/> that can be sent using this
    /// pipeline instance.
    /// </summary>
    /// <returns>The created <see cref="PipelineMessage"/>.</returns>
    public PipelineMessage CreateMessage()
    {
        PipelineMessage message = _transport.CreateMessage();
        message.NetworkTimeout = _networkTimeout;
        return message;
    }

    /// <summary>
    /// Creates a <see cref="PipelineMessage"/> that can be sent using this
    /// pipeline instance with the specified URI, HTTP method, and response
    /// classifier.
    /// </summary>
    /// <param name="uri">The <see cref="Uri"/> for the HTTP request.</param>
    /// <param name="method">The HTTP method for the request.</param>
    /// <param name="classifier">The <see cref="PipelineMessageClassifier"/>
    /// to use for determining response success and retry behavior. If not provided,
    /// <see cref="PipelineMessageClassifier.Default"/> will be used.</param>
    /// <returns>The created <see cref="PipelineMessage"/> with the specified
    /// URI, method, and classifier configured.</returns>
    public PipelineMessage CreateMessage(Uri uri, string method, PipelineMessageClassifier? classifier = default)
    {
        Argument.AssertNotNull(uri, nameof(uri));
        Argument.AssertNotNull(method, nameof(method));

        PipelineMessage message = CreateMessage();
        message.Request.Uri = uri;
        message.Request.Method = method;
        message.ResponseClassifier = classifier ?? PipelineMessageClassifier.Default;
        return message;
    }

    /// <summary>
    /// Send the provided <see cref="PipelineMessage"/>.
    /// </summary>
    /// <param name="message">The <see cref="PipelineMessage"/> to send.</param>
    /// <exception cref="ClientResultException">Thrown if an error other than
    /// the service responding with an error response occurred while sending
    /// the HTTP request.</exception>
    /// <remarks>
    /// All necessary values on <see cref="PipelineMessage.Request"/> should be
    /// set prior to calling <see cref="Send(PipelineMessage)"/>.  After the
    /// method returns, <see cref="PipelineMessage.Response"/> will be populated
    /// with the details of the service response.
    /// </remarks>
    public void Send(PipelineMessage message)
    {
        Argument.AssertNotNull(message, nameof(message));
        message.Request.ClientRequestId = Activity.Current?.Id ?? Guid.NewGuid().ToString();

        IReadOnlyList<PipelinePolicy> policies = GetProcessor(message);

        policies[0].Process(message, policies, 0);
    }

    /// <summary>
    /// Send the provided <see cref="PipelineMessage"/>.
    /// </summary>
    /// <param name="message">The <see cref="PipelineMessage"/> to send.</param>
    /// <exception cref="ClientResultException">Thrown if an error other than
    /// the service responding with an error response occurred while sending
    /// the HTTP request.</exception>
    /// <remarks>
    /// All necessary values on <see cref="PipelineMessage.Request"/> should be
    /// set prior to calling <see cref="Send(PipelineMessage)"/>.  After the
    /// method returns, <see cref="PipelineMessage.Response"/> will be populated
    /// with the details of the service response.
    /// </remarks>
    public async ValueTask SendAsync(PipelineMessage message)
    {
        Argument.AssertNotNull(message, nameof(message));
        message.Request.ClientRequestId = Activity.Current?.Id ?? Guid.NewGuid().ToString();

        IReadOnlyList<PipelinePolicy> policies = GetProcessor(message);

        await policies[0].ProcessAsync(message, policies, 0).ConfigureAwait(false);
    }

    private IReadOnlyList<PipelinePolicy> GetProcessor(PipelineMessage message)
    {
        if (message.UseCustomRequestPipeline)
        {
            return new RequestOptionsProcessor(_policies,
                message.PerCallPolicies,
                message.PerTryPolicies,
                message.BeforeTransportPolicies,
                _perCallIndex,
                _perTryIndex,
                _beforeTransportIndex);
        }

        return new PipelineProcessor(_policies);
    }

    private struct PipelineProcessor : IReadOnlyList<PipelinePolicy>
    {
        private readonly ReadOnlyMemory<PipelinePolicy> _policies;
        private PolicyEnumerator? _enumerator;

        public PipelineProcessor(ReadOnlyMemory<PipelinePolicy> policies)
            => _policies = policies;

        public PipelinePolicy this[int index] => _policies.Span[index];

        public int Count => _policies.Length;

        public IEnumerator<PipelinePolicy> GetEnumerator()
            => _enumerator ??= new(this);

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }

    private class PolicyEnumerator : IEnumerator<PipelinePolicy>
    {
        private readonly IReadOnlyList<PipelinePolicy> _policies;
        private int _current;

        public PolicyEnumerator(IReadOnlyList<PipelinePolicy> policies)
        {
            _policies = policies;
            _current = -1;
        }

        public PipelinePolicy Current
        {
            get
            {
                if (_current >= 0 && _current < _policies.Count)
                {
                    return _policies[_current];
                }

                throw new InvalidOperationException("'Current' is outside the bounds of the policy collection.");
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext() => ++_current < _policies.Count;

        public void Reset() => _current = -1;

        public void Dispose() { }
    }
}

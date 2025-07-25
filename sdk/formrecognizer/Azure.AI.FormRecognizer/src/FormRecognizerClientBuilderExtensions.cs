﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics.CodeAnalysis;
using Azure;
using Azure.AI.FormRecognizer;
using Azure.Core.Extensions;

namespace Microsoft.Extensions.Azure
{
    /// <summary>
    /// Extension methods to add the <see cref="FormRecognizerClient"/> to clients builder.
    /// </summary>
    public static class FormRecognizerClientBuilderExtensions
    {
        /// <summary>
        /// Registers a <see cref="FormRecognizerClient"/> instance with the provided <paramref name="endpoint"/>.
        /// </summary>
        public static IAzureClientBuilder<FormRecognizerClient, FormRecognizerClientOptions> AddFormRecognizerClient<TBuilder>(this TBuilder builder, Uri endpoint)
            where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<FormRecognizerClient, FormRecognizerClientOptions>((options, credential) => new FormRecognizerClient(endpoint, credential, options));
        }

        /// <summary>
        /// Registers a <see cref="FormRecognizerClient"/> instance with the provided <paramref name="endpoint"/> and <paramref name="credential"/>.
        /// </summary>
        public static IAzureClientBuilder<FormRecognizerClient, FormRecognizerClientOptions> AddFormRecognizerClient<TBuilder>(this TBuilder builder, Uri endpoint, AzureKeyCredential credential)
            where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<FormRecognizerClient, FormRecognizerClientOptions>(options => new FormRecognizerClient(endpoint, credential, options));
        }

        /// <summary>
        /// Registers a <see cref="FormRecognizerClient"/> instance with connection options loaded from the provided <paramref name="configuration"/> instance.
        /// </summary>
        [RequiresUnreferencedCode("Binding strongly typed objects to configuration values is not supported with trimming. Use the Configuration Binder Source Generator (EnableConfigurationBindingGenerator=true) instead.")]
        [RequiresDynamicCode("Binding strongly typed objects to configuration values requires generating dynamic code at runtime, for example instantiating generic types. Use the Configuration Binder Source Generator (EnableConfigurationBindingGenerator=true) instead.")]
        public static IAzureClientBuilder<FormRecognizerClient, FormRecognizerClientOptions> AddFormRecognizerClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
            where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<FormRecognizerClient, FormRecognizerClientOptions>(configuration);
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.OracleDatabase
{
    /// <summary>
    /// A class representing a collection of <see cref="ExascaleDBNodeResource"/> and their operations.
    /// Each <see cref="ExascaleDBNodeResource"/> in the collection will belong to the same instance of <see cref="ExadbVmClusterResource"/>.
    /// To get an <see cref="ExascaleDBNodeCollection"/> instance call the GetExascaleDBNodes method from an instance of <see cref="ExadbVmClusterResource"/>.
    /// </summary>
    public partial class ExascaleDBNodeCollection : ArmCollection, IEnumerable<ExascaleDBNodeResource>, IAsyncEnumerable<ExascaleDBNodeResource>
    {
        private readonly ClientDiagnostics _exascaleDBNodeExascaleDbNodesClientDiagnostics;
        private readonly ExascaleDbNodesRestOperations _exascaleDBNodeExascaleDbNodesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExascaleDBNodeCollection"/> class for mocking. </summary>
        protected ExascaleDBNodeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExascaleDBNodeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExascaleDBNodeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _exascaleDBNodeExascaleDbNodesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OracleDatabase", ExascaleDBNodeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExascaleDBNodeResource.ResourceType, out string exascaleDBNodeExascaleDbNodesApiVersion);
            _exascaleDBNodeExascaleDbNodesRestClient = new ExascaleDbNodesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, exascaleDBNodeExascaleDbNodesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ExadbVmClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ExadbVmClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a ExascaleDbNode
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/exadbVmClusters/{exadbVmClusterName}/dbNodes/{exascaleDbNodeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExascaleDbNode_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExascaleDBNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exascaleDbNodeName"> The name of the ExascaleDbNode. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exascaleDbNodeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exascaleDbNodeName"/> is null. </exception>
        public virtual async Task<Response<ExascaleDBNodeResource>> GetAsync(string exascaleDbNodeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exascaleDbNodeName, nameof(exascaleDbNodeName));

            using var scope = _exascaleDBNodeExascaleDbNodesClientDiagnostics.CreateScope("ExascaleDBNodeCollection.Get");
            scope.Start();
            try
            {
                var response = await _exascaleDBNodeExascaleDbNodesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, exascaleDbNodeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExascaleDBNodeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a ExascaleDbNode
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/exadbVmClusters/{exadbVmClusterName}/dbNodes/{exascaleDbNodeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExascaleDbNode_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExascaleDBNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exascaleDbNodeName"> The name of the ExascaleDbNode. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exascaleDbNodeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exascaleDbNodeName"/> is null. </exception>
        public virtual Response<ExascaleDBNodeResource> Get(string exascaleDbNodeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exascaleDbNodeName, nameof(exascaleDbNodeName));

            using var scope = _exascaleDBNodeExascaleDbNodesClientDiagnostics.CreateScope("ExascaleDBNodeCollection.Get");
            scope.Start();
            try
            {
                var response = _exascaleDBNodeExascaleDbNodesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, exascaleDbNodeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExascaleDBNodeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List ExascaleDbNode resources by ExadbVmCluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/exadbVmClusters/{exadbVmClusterName}/dbNodes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExascaleDbNode_ListByParent</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExascaleDBNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExascaleDBNodeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExascaleDBNodeResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _exascaleDBNodeExascaleDbNodesRestClient.CreateListByParentRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _exascaleDBNodeExascaleDbNodesRestClient.CreateListByParentNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ExascaleDBNodeResource(Client, ExascaleDBNodeData.DeserializeExascaleDBNodeData(e)), _exascaleDBNodeExascaleDbNodesClientDiagnostics, Pipeline, "ExascaleDBNodeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List ExascaleDbNode resources by ExadbVmCluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/exadbVmClusters/{exadbVmClusterName}/dbNodes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExascaleDbNode_ListByParent</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExascaleDBNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExascaleDBNodeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExascaleDBNodeResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _exascaleDBNodeExascaleDbNodesRestClient.CreateListByParentRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _exascaleDBNodeExascaleDbNodesRestClient.CreateListByParentNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ExascaleDBNodeResource(Client, ExascaleDBNodeData.DeserializeExascaleDBNodeData(e)), _exascaleDBNodeExascaleDbNodesClientDiagnostics, Pipeline, "ExascaleDBNodeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/exadbVmClusters/{exadbVmClusterName}/dbNodes/{exascaleDbNodeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExascaleDbNode_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExascaleDBNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exascaleDbNodeName"> The name of the ExascaleDbNode. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exascaleDbNodeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exascaleDbNodeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string exascaleDbNodeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exascaleDbNodeName, nameof(exascaleDbNodeName));

            using var scope = _exascaleDBNodeExascaleDbNodesClientDiagnostics.CreateScope("ExascaleDBNodeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _exascaleDBNodeExascaleDbNodesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, exascaleDbNodeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/exadbVmClusters/{exadbVmClusterName}/dbNodes/{exascaleDbNodeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExascaleDbNode_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExascaleDBNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exascaleDbNodeName"> The name of the ExascaleDbNode. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exascaleDbNodeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exascaleDbNodeName"/> is null. </exception>
        public virtual Response<bool> Exists(string exascaleDbNodeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exascaleDbNodeName, nameof(exascaleDbNodeName));

            using var scope = _exascaleDBNodeExascaleDbNodesClientDiagnostics.CreateScope("ExascaleDBNodeCollection.Exists");
            scope.Start();
            try
            {
                var response = _exascaleDBNodeExascaleDbNodesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, exascaleDbNodeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/exadbVmClusters/{exadbVmClusterName}/dbNodes/{exascaleDbNodeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExascaleDbNode_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExascaleDBNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exascaleDbNodeName"> The name of the ExascaleDbNode. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exascaleDbNodeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exascaleDbNodeName"/> is null. </exception>
        public virtual async Task<NullableResponse<ExascaleDBNodeResource>> GetIfExistsAsync(string exascaleDbNodeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exascaleDbNodeName, nameof(exascaleDbNodeName));

            using var scope = _exascaleDBNodeExascaleDbNodesClientDiagnostics.CreateScope("ExascaleDBNodeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _exascaleDBNodeExascaleDbNodesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, exascaleDbNodeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ExascaleDBNodeResource>(response.GetRawResponse());
                return Response.FromValue(new ExascaleDBNodeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/exadbVmClusters/{exadbVmClusterName}/dbNodes/{exascaleDbNodeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExascaleDbNode_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExascaleDBNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exascaleDbNodeName"> The name of the ExascaleDbNode. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exascaleDbNodeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exascaleDbNodeName"/> is null. </exception>
        public virtual NullableResponse<ExascaleDBNodeResource> GetIfExists(string exascaleDbNodeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exascaleDbNodeName, nameof(exascaleDbNodeName));

            using var scope = _exascaleDBNodeExascaleDbNodesClientDiagnostics.CreateScope("ExascaleDBNodeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _exascaleDBNodeExascaleDbNodesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, exascaleDbNodeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ExascaleDBNodeResource>(response.GetRawResponse());
                return Response.FromValue(new ExascaleDBNodeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExascaleDBNodeResource> IEnumerable<ExascaleDBNodeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExascaleDBNodeResource> IAsyncEnumerable<ExascaleDBNodeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

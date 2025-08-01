﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Samples.Models;

namespace Samples
{
    internal partial class CatClientGetCatsAsyncCollectionResultOfT : global::Azure.AsyncPageable<global::Samples.Models.Cat>
    {
        private readonly global::Samples.CatClient _client;
        private readonly string _myToken;
        private readonly global::Azure.RequestContext _context;

        /// <summary> Initializes a new instance of CatClientGetCatsAsyncCollectionResultOfT, which is used to iterate over the pages of a collection. </summary>
        /// <param name="client"> The CatClient client used to send requests. </param>
        /// <param name="myToken"> myToken description. </param>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="global::System.ArgumentNullException"> <paramref name="myToken"/> is null. </exception>
        /// <exception cref="global::System.ArgumentException"> <paramref name="myToken"/> is an empty string, and was expected to be non-empty. </exception>
        public CatClientGetCatsAsyncCollectionResultOfT(global::Samples.CatClient client, string myToken, global::Azure.RequestContext context) : base((context?.CancellationToken ?? default))
        {
            global::Samples.Argument.AssertNotNullOrEmpty(myToken, nameof(myToken));

            _client = client;
            _myToken = myToken;
            _context = context;
        }

        /// <summary> Gets the pages of CatClientGetCatsAsyncCollectionResultOfT as an enumerable collection. </summary>
        /// <param name="continuationToken"> A continuation token indicating where to resume paging. </param>
        /// <param name="pageSizeHint"> The number of items per page. </param>
        /// <returns> The pages of CatClientGetCatsAsyncCollectionResultOfT as an enumerable collection. </returns>
        public override async global::System.Collections.Generic.IAsyncEnumerable<global::Azure.Page<global::Samples.Models.Cat>> AsPages(string continuationToken, int? pageSizeHint)
        {
            string nextPage = (continuationToken ?? _myToken);
            do
            {
                global::Azure.Response response = await this.GetNextResponse(pageSizeHint, nextPage).ConfigureAwait(false);
                if ((response is null))
                {
                    yield break;
                }
                global::Samples.Models.Page responseWithType = ((global::Samples.Models.Page)response);
                nextPage = response.Headers.TryGetValue("nextPage", out string value) ? value : null;
                yield return global::Azure.Page<global::Samples.Models.Cat>.FromValues(((global::System.Collections.Generic.IReadOnlyList<global::Samples.Models.Cat>)responseWithType.Cats), nextPage, response);
            }
            while (!string.IsNullOrEmpty(nextPage));
        }

        /// <summary> Get next page. </summary>
        /// <param name="pageSizeHint"> The number of items per page. </param>
        /// <param name="continuationToken"> A continuation token indicating where to resume paging. </param>
        private async global::System.Threading.Tasks.ValueTask<global::Azure.Response> GetNextResponse(int? pageSizeHint, string continuationToken)
        {
            global::Azure.Core.HttpMessage message = _client.CreateGetCatsRequest(continuationToken, _context);
            using global::Azure.Core.Pipeline.DiagnosticScope scope = _client.ClientDiagnostics.CreateScope("CatClient.GetCats");
            scope.Start();
            try
            {
                return await _client.Pipeline.ProcessMessageAsync(message, _context).ConfigureAwait(false);
            }
            catch (global::System.Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

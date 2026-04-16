// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;

namespace Azure.AI.Language.Documents.Tests
{
    /// <summary>
    /// Test environment settings for the Analyze Documents SDK.
    /// </summary>
    public class DocumentsTestEnvironment : TestEnvironment
    {
        /// <summary>
        /// Gets the endpoint.
        /// </summary>
        public string Endpoint => GetRecordedVariable("DOCUMENTS_ENDPOINT");

        /// <summary>
        /// Gets the source Azure Blob URL for the input document.
        /// </summary>
        public string SourceBlobUrl => GetRecordedVariable("DOCUMENTS_SOURCE_BLOB_URL");

        /// <summary>
        /// Gets the target Azure Blob URL for the output location.
        /// </summary>
        public string TargetBlobUrl => GetRecordedVariable("DOCUMENTS_TARGET_BLOB_URL");
    }
}

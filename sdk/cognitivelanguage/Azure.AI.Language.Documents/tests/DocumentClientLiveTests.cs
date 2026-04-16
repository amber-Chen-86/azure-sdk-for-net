// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.AI.Language.Documents;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.AI.Language.Documents.Tests
{
    public class DocumentClientLiveTests : RecordedTestBase<DocumentsTestEnvironment>
    {
        public DocumentClientLiveTests(bool isAsync)
            : base(isAsync, null /* RecordedTestMode.Record /* to record */)
        {
            CompareBodies = false;
            SanitizedHeaders.Add("Authorization");
        }

        private AnalyzeDocumentsClient CreateDocumentsClient()
        {
            AnalyzeDocumentsClientOptions options = InstrumentClientOptions(new AnalyzeDocumentsClientOptions());
            DefaultAzureCredential credential = new DefaultAzureCredential();

            return InstrumentClient(
                new AnalyzeDocumentsClient(
                    TestEnvironment.Endpoint,
                    credential,
                    options));
        }

        [RecordedTest]
        public async Task AnalyzeDocuments_PiiEntityRecognition_WithEntityMaskPolicy()
        {
            // Arrange
            AnalyzeDocumentsClient client = CreateDocumentsClient();

            MultiLanguageDocumentInput documentsInput = new MultiLanguageDocumentInput();
            documentsInput.Documents.Add(new MultiLanguageInput(
                id: "1",
                source: new AzureBlobDocumentLocation(TestEnvironment.SourceBlobUrl),
                target: new AzureBlobDocumentLocation(TestEnvironment.TargetBlobUrl))
            {
                Language = "en"
            });

            EntityMaskPolicy redactionPolicy = new EntityMaskPolicy
            {
                PolicyName = "defaultPolicy",
                IsDefault = true
            };

            PiiActionContent parameters = new PiiActionContent();
            parameters.RedactionPolicies.Add(redactionPolicy);

            List<AnalyzeDocumentsOperationAction> actions = new List<AnalyzeDocumentsOperationAction>
            {
                new PiiLROTask
                {
                    Parameters = parameters,
                    Name = "PiiEntityRecognition"
                }
            };

            AnalyzeDocumentsOperationInput operationInput = new AnalyzeDocumentsOperationInput(documentsInput, actions)
            {
                DisplayName = "Document Analysis."
            };

            // Act
            Operation operation = await client.AnalyzeDocumentsSubmitOperationAsync(
                WaitUntil.Completed,
                operationInput);

            Assert.IsNotNull(operation);
            Assert.IsTrue(operation.HasCompleted);

            // Get job status from the operation location header
            string operationLocation = operation.GetRawResponse().Headers.TryGetValue("operation-location", out string location)
                ? location
                : null;

            Assert.IsNotNull(operationLocation, "Expected an operation-location header in the response.");

            // Extract the job ID from the operation location URL
            Uri operationUri = new Uri(operationLocation);
            string[] segments = operationUri.AbsolutePath.Split('/');
            string jobIdString = segments[segments.Length - 1];
            Guid jobId = Guid.Parse(jobIdString);

            // Get the job result
            Response<AnalyzeDocumentsJobState> jobResponse = await client.GetAnalyzeDocumentsJobStatusAsync(jobId);

            // Assert - main object
            Assert.IsNotNull(jobResponse);
            Assert.IsNotNull(jobResponse.Value);

            AnalyzeDocumentsJobState jobState = jobResponse.Value;
            Assert.AreEqual("Document Analysis.", jobState.DisplayName);
            Assert.AreEqual("succeeded", jobState.Status.ToString());
            Assert.IsEmpty(jobState.Errors);

            // Assert - tasks
            Assert.IsNotNull(jobState.Tasks);
            Assert.AreEqual(1, jobState.Tasks.Total);
            Assert.AreEqual(1, jobState.Tasks.Completed);
            Assert.AreEqual(0, jobState.Tasks.Failed);
            Assert.IsNotEmpty(jobState.Tasks.Items);

            // Assert - PII task result
            foreach (AnalyzeDocumentsLROResult taskResult in jobState.Tasks.Items)
            {
                Assert.AreEqual("succeeded", taskResult.Status.ToString());

                if (taskResult is PiiEntityRecognitionOperationResult piiResult)
                {
                    Assert.IsNotNull(piiResult.Results);
                    Assert.IsNotEmpty(piiResult.Results.Documents);
                    Assert.IsEmpty(piiResult.Results.Errors);
                    Assert.IsNotNull(piiResult.Results.ModelVersion);

                    foreach (DocumentAnalysisDocumentResult doc in piiResult.Results.Documents)
                    {
                        Assert.IsNotNull(doc);
                        Console.WriteLine($"Document id: {doc.Id}");
                        Console.WriteLine($"Source: {(doc.Source as AzureBlobDocumentLocation)?.Location}");

                        foreach (DocumentLocation target in doc.Targets)
                        {
                            Console.WriteLine($"Target: {(target as AzureBlobDocumentLocation)?.Location}");
                        }
                    }
                }
            }
        }
    }
}

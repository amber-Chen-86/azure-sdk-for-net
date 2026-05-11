// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Reflection;
using NUnit.Framework;

namespace Azure.AI.Language.Text.Tests
{
    public class AnalyzeTextErrorCodeTests
    {
        [Test]
        public void AnalyzeTextErrorCode_DoesNotExposeWarningCode()
        {
            PropertyInfo warningProperty = typeof(AnalyzeTextErrorCode).GetProperty("Warning", BindingFlags.Public | BindingFlags.Static);

            Assert.IsNull(warningProperty);
        }
    }
}

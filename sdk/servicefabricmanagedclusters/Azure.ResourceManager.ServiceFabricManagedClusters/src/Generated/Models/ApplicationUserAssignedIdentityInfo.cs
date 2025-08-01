// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> User assigned identity for the application. </summary>
    public partial class ApplicationUserAssignedIdentityInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationUserAssignedIdentityInfo"/>. </summary>
        /// <param name="name"> The friendly name of user assigned identity. </param>
        /// <param name="principalId"> The principal id of user assigned identity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="principalId"/> is null. </exception>
        public ApplicationUserAssignedIdentityInfo(string name, string principalId)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(principalId, nameof(principalId));

            Name = name;
            PrincipalId = principalId;
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationUserAssignedIdentityInfo"/>. </summary>
        /// <param name="name"> The friendly name of user assigned identity. </param>
        /// <param name="principalId"> The principal id of user assigned identity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationUserAssignedIdentityInfo(string name, string principalId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            PrincipalId = principalId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationUserAssignedIdentityInfo"/> for deserialization. </summary>
        internal ApplicationUserAssignedIdentityInfo()
        {
        }

        /// <summary> The friendly name of user assigned identity. </summary>
        public string Name { get; set; }
        /// <summary> The principal id of user assigned identity. </summary>
        public string PrincipalId { get; set; }
    }
}

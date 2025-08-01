// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Event data for Microsoft.EventGrid.MQTTClientDeleted event. </summary>
    public partial class EventGridMqttClientDeletedEventData : EventGridMqttClientEventData
    {
        /// <summary> Initializes a new instance of <see cref="EventGridMqttClientDeletedEventData"/>. </summary>
        /// <param name="clientAuthenticationName">
        /// Unique identifier for the MQTT client that the client presents to the service
        /// for authentication. This case-sensitive string can be up to 128 characters
        /// long, and supports UTF-8 characters.
        /// </param>
        /// <param name="namespaceName"> Name of the Event Grid namespace where the MQTT client was created or updated. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientAuthenticationName"/> or <paramref name="namespaceName"/> is null. </exception>
        internal EventGridMqttClientDeletedEventData(string clientAuthenticationName, string namespaceName) : base(clientAuthenticationName, namespaceName)
        {
            Argument.AssertNotNull(clientAuthenticationName, nameof(clientAuthenticationName));
            Argument.AssertNotNull(namespaceName, nameof(namespaceName));
        }

        /// <summary> Initializes a new instance of <see cref="EventGridMqttClientDeletedEventData"/>. </summary>
        /// <param name="clientAuthenticationName">
        /// Unique identifier for the MQTT client that the client presents to the service
        /// for authentication. This case-sensitive string can be up to 128 characters
        /// long, and supports UTF-8 characters.
        /// </param>
        /// <param name="clientName"> Name of the client resource in the Event Grid namespace. </param>
        /// <param name="namespaceName"> Name of the Event Grid namespace where the MQTT client was created or updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventGridMqttClientDeletedEventData(string clientAuthenticationName, string clientName, string namespaceName, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(clientAuthenticationName, clientName, namespaceName, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventGridMqttClientDeletedEventData"/> for deserialization. </summary>
        internal EventGridMqttClientDeletedEventData()
        {
        }
    }
}

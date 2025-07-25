// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeDeviceNetworkSettings : IUtf8JsonSerializable, IJsonModel<DataBoxEdgeDeviceNetworkSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxEdgeDeviceNetworkSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataBoxEdgeDeviceNetworkSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeDeviceNetworkSettings)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(NetworkAdapters))
            {
                writer.WritePropertyName("networkAdapters"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkAdapters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        DataBoxEdgeDeviceNetworkSettings IJsonModel<DataBoxEdgeDeviceNetworkSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeDeviceNetworkSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeDeviceNetworkSettings(document.RootElement, options);
        }

        internal static DataBoxEdgeDeviceNetworkSettings DeserializeDataBoxEdgeDeviceNetworkSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IReadOnlyList<DataBoxEdgeNetworkAdapter> networkAdapters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerDataBoxEdgeContext.Default);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("networkAdapters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxEdgeNetworkAdapter> array = new List<DataBoxEdgeNetworkAdapter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxEdgeNetworkAdapter.DeserializeDataBoxEdgeNetworkAdapter(item, options));
                            }
                            networkAdapters = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataBoxEdgeDeviceNetworkSettings(
                id,
                name,
                type,
                systemData,
                networkAdapters ?? new ChangeTrackingList<DataBoxEdgeNetworkAdapter>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxEdgeDeviceNetworkSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataBoxEdgeContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeDeviceNetworkSettings)} does not support writing '{options.Format}' format.");
            }
        }

        DataBoxEdgeDeviceNetworkSettings IPersistableModel<DataBoxEdgeDeviceNetworkSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataBoxEdgeDeviceNetworkSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeDeviceNetworkSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxEdgeDeviceNetworkSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class CentralServerVmDetails : IUtf8JsonSerializable, IJsonModel<CentralServerVmDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CentralServerVmDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CentralServerVmDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CentralServerVmDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CentralServerVmDetails)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(VirtualMachineType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(VirtualMachineType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(VirtualMachineId))
            {
                writer.WritePropertyName("virtualMachineId"u8);
                writer.WriteStringValue(VirtualMachineId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(StorageDetails))
            {
                writer.WritePropertyName("storageDetails"u8);
                writer.WriteStartArray();
                foreach (var item in StorageDetails)
                {
                    ((IJsonModel<SubResource>)item).Write(writer, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        CentralServerVmDetails IJsonModel<CentralServerVmDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CentralServerVmDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CentralServerVmDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCentralServerVmDetails(document.RootElement, options);
        }

        internal static CentralServerVmDetails DeserializeCentralServerVmDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CentralServerVirtualMachineType? type = default;
            ResourceIdentifier virtualMachineId = default;
            IReadOnlyList<SubResource> storageDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new CentralServerVirtualMachineType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SubResource> array = new List<SubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ModelReaderWriter.Read<SubResource>(new BinaryData(Encoding.UTF8.GetBytes(item.GetRawText())), options, AzureResourceManagerWorkloadsContext.Default));
                    }
                    storageDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CentralServerVmDetails(type, virtualMachineId, storageDetails ?? new ChangeTrackingList<SubResource>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CentralServerVmDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CentralServerVmDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerWorkloadsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(CentralServerVmDetails)} does not support writing '{options.Format}' format.");
            }
        }

        CentralServerVmDetails IPersistableModel<CentralServerVmDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CentralServerVmDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCentralServerVmDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CentralServerVmDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CentralServerVmDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

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
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    public partial class VMwareResourcePoolData : IUtf8JsonSerializable, IJsonModel<VMwareResourcePoolData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareResourcePoolData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VMwareResourcePoolData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareResourcePoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareResourcePoolData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                ((IJsonModel<ExtendedLocation>)ExtendedLocation).Write(writer, options);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Uuid))
            {
                writer.WritePropertyName("uuid"u8);
                writer.WriteStringValue(Uuid);
            }
            if (Optional.IsDefined(VCenterId))
            {
                writer.WritePropertyName("vCenterId"u8);
                writer.WriteStringValue(VCenterId);
            }
            if (Optional.IsDefined(MoRefId))
            {
                writer.WritePropertyName("moRefId"u8);
                writer.WriteStringValue(MoRefId);
            }
            if (Optional.IsDefined(InventoryItemId))
            {
                writer.WritePropertyName("inventoryItemId"u8);
                writer.WriteStringValue(InventoryItemId);
            }
            if (options.Format != "W" && Optional.IsDefined(MoName))
            {
                writer.WritePropertyName("moName"u8);
                writer.WriteStringValue(MoName);
            }
            if (options.Format != "W" && Optional.IsDefined(CpuSharesLevel))
            {
                writer.WritePropertyName("cpuSharesLevel"u8);
                writer.WriteStringValue(CpuSharesLevel);
            }
            if (options.Format != "W" && Optional.IsDefined(CpuReservationMHz))
            {
                writer.WritePropertyName("cpuReservationMHz"u8);
                writer.WriteNumberValue(CpuReservationMHz.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CpuLimitMHz))
            {
                writer.WritePropertyName("cpuLimitMHz"u8);
                writer.WriteNumberValue(CpuLimitMHz.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MemSharesLevel))
            {
                writer.WritePropertyName("memSharesLevel"u8);
                writer.WriteStringValue(MemSharesLevel);
            }
            if (options.Format != "W" && Optional.IsDefined(MemReservationMB))
            {
                writer.WritePropertyName("memReservationMB"u8);
                writer.WriteNumberValue(MemReservationMB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MemLimitMB))
            {
                writer.WritePropertyName("memLimitMB"u8);
                writer.WriteNumberValue(MemLimitMB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MemOverallUsageGB))
            {
                writer.WritePropertyName("memOverallUsageGB"u8);
                writer.WriteNumberValue(MemOverallUsageGB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MemCapacityGB))
            {
                writer.WritePropertyName("memCapacityGB"u8);
                writer.WriteNumberValue(MemCapacityGB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CpuOverallUsageMHz))
            {
                writer.WritePropertyName("cpuOverallUsageMHz"u8);
                writer.WriteNumberValue(CpuOverallUsageMHz.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CpuCapacityMHz))
            {
                writer.WritePropertyName("cpuCapacityMHz"u8);
                writer.WriteNumberValue(CpuCapacityMHz.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CustomResourceName))
            {
                writer.WritePropertyName("customResourceName"u8);
                writer.WriteStringValue(CustomResourceName);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DatastoreIds))
            {
                writer.WritePropertyName("datastoreIds"u8);
                writer.WriteStartArray();
                foreach (var item in DatastoreIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(NetworkIds))
            {
                writer.WritePropertyName("networkIds"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Statuses))
            {
                writer.WritePropertyName("statuses"u8);
                writer.WriteStartArray();
                foreach (var item in Statuses)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        VMwareResourcePoolData IJsonModel<VMwareResourcePoolData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareResourcePoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareResourcePoolData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareResourcePoolData(document.RootElement, options);
        }

        internal static VMwareResourcePoolData DeserializeVMwareResourcePoolData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            string kind = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string uuid = default;
            string vCenterId = default;
            string moRefId = default;
            string inventoryItemId = default;
            string moName = default;
            string cpuSharesLevel = default;
            long? cpuReservationMHz = default;
            long? cpuLimitMHz = default;
            string memSharesLevel = default;
            long? memReservationMB = default;
            long? memLimitMB = default;
            long? memOverallUsageGB = default;
            long? memCapacityGB = default;
            long? cpuOverallUsageMHz = default;
            long? cpuCapacityMHz = default;
            string customResourceName = default;
            IReadOnlyList<string> datastoreIds = default;
            IReadOnlyList<string> networkIds = default;
            IReadOnlyList<VMwareResourceStatus> statuses = default;
            VMwareResourceProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = ModelReaderWriter.Read<ExtendedLocation>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), options, AzureResourceManagerConnectedVMwarevSphereContext.Default);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerConnectedVMwarevSphereContext.Default);
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
                        if (property0.NameEquals("uuid"u8))
                        {
                            uuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vCenterId"u8))
                        {
                            vCenterId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("moRefId"u8))
                        {
                            moRefId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("inventoryItemId"u8))
                        {
                            inventoryItemId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("moName"u8))
                        {
                            moName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cpuSharesLevel"u8))
                        {
                            cpuSharesLevel = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cpuReservationMHz"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cpuReservationMHz = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("cpuLimitMHz"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cpuLimitMHz = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("memSharesLevel"u8))
                        {
                            memSharesLevel = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("memReservationMB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            memReservationMB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("memLimitMB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            memLimitMB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("memOverallUsageGB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            memOverallUsageGB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("memCapacityGB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            memCapacityGB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("cpuOverallUsageMHz"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cpuOverallUsageMHz = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("cpuCapacityMHz"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cpuCapacityMHz = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("customResourceName"u8))
                        {
                            customResourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("datastoreIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            datastoreIds = array;
                            continue;
                        }
                        if (property0.NameEquals("networkIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            networkIds = array;
                            continue;
                        }
                        if (property0.NameEquals("statuses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VMwareResourceStatus> array = new List<VMwareResourceStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VMwareResourceStatus.DeserializeVMwareResourceStatus(item, options));
                            }
                            statuses = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new VMwareResourceProvisioningState(property0.Value.GetString());
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
            return new VMwareResourcePoolData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                extendedLocation,
                kind,
                uuid,
                vCenterId,
                moRefId,
                inventoryItemId,
                moName,
                cpuSharesLevel,
                cpuReservationMHz,
                cpuLimitMHz,
                memSharesLevel,
                memReservationMB,
                memLimitMB,
                memOverallUsageGB,
                memCapacityGB,
                cpuOverallUsageMHz,
                cpuCapacityMHz,
                customResourceName,
                datastoreIds ?? new ChangeTrackingList<string>(),
                networkIds ?? new ChangeTrackingList<string>(),
                statuses ?? new ChangeTrackingList<VMwareResourceStatus>(),
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VMwareResourcePoolData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareResourcePoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerConnectedVMwarevSphereContext.Default);
                default:
                    throw new FormatException($"The model {nameof(VMwareResourcePoolData)} does not support writing '{options.Format}' format.");
            }
        }

        VMwareResourcePoolData IPersistableModel<VMwareResourcePoolData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareResourcePoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVMwareResourcePoolData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareResourcePoolData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareResourcePoolData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

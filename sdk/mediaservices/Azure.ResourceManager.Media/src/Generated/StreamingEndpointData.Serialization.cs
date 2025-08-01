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
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    public partial class StreamingEndpointData : IUtf8JsonSerializable, IJsonModel<StreamingEndpointData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingEndpointData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StreamingEndpointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingEndpointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingEndpointData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ScaleUnits))
            {
                writer.WritePropertyName("scaleUnits"u8);
                writer.WriteNumberValue(ScaleUnits.Value);
            }
            if (Optional.IsDefined(AvailabilitySetName))
            {
                writer.WritePropertyName("availabilitySetName"u8);
                writer.WriteStringValue(AvailabilitySetName);
            }
            if (Optional.IsDefined(AccessControl))
            {
                if (AccessControl != null)
                {
                    writer.WritePropertyName("accessControl"u8);
                    writer.WriteObjectValue(AccessControl, options);
                }
                else
                {
                    writer.WriteNull("accessControl");
                }
            }
            if (Optional.IsDefined(MaxCacheAge))
            {
                if (MaxCacheAge != null)
                {
                    writer.WritePropertyName("maxCacheAge"u8);
                    writer.WriteNumberValue(MaxCacheAge.Value);
                }
                else
                {
                    writer.WriteNull("maxCacheAge");
                }
            }
            if (Optional.IsCollectionDefined(CustomHostNames))
            {
                writer.WritePropertyName("customHostNames"u8);
                writer.WriteStartArray();
                foreach (var item in CustomHostNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(IsCdnEnabled))
            {
                writer.WritePropertyName("cdnEnabled"u8);
                writer.WriteBooleanValue(IsCdnEnabled.Value);
            }
            if (Optional.IsDefined(CdnProvider))
            {
                writer.WritePropertyName("cdnProvider"u8);
                writer.WriteStringValue(CdnProvider);
            }
            if (Optional.IsDefined(CdnProfile))
            {
                writer.WritePropertyName("cdnProfile"u8);
                writer.WriteStringValue(CdnProfile);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceState))
            {
                writer.WritePropertyName("resourceState"u8);
                writer.WriteStringValue(ResourceState.Value.ToString());
            }
            if (Optional.IsDefined(CrossSiteAccessPolicies))
            {
                if (CrossSiteAccessPolicies != null)
                {
                    writer.WritePropertyName("crossSiteAccessPolicies"u8);
                    writer.WriteObjectValue(CrossSiteAccessPolicies, options);
                }
                else
                {
                    writer.WriteNull("crossSiteAccessPolicies");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(FreeTrialEndOn))
            {
                writer.WritePropertyName("freeTrialEndTime"u8);
                writer.WriteStringValue(FreeTrialEndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("created"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModified"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            writer.WriteEndObject();
        }

        StreamingEndpointData IJsonModel<StreamingEndpointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingEndpointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingEndpointData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingEndpointData(document.RootElement, options);
        }

        internal static StreamingEndpointData DeserializeStreamingEndpointData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StreamingEndpointCurrentSku sku = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string description = default;
            int? scaleUnits = default;
            string availabilitySetName = default;
            StreamingEndpointAccessControl accessControl = default;
            long? maxCacheAge = default;
            IList<string> customHostNames = default;
            string hostName = default;
            bool? cdnEnabled = default;
            string cdnProvider = default;
            string cdnProfile = default;
            string provisioningState = default;
            StreamingEndpointResourceState? resourceState = default;
            CrossSiteAccessPolicies crossSiteAccessPolicies = default;
            DateTimeOffset? freeTrialEndTime = default;
            DateTimeOffset? created = default;
            DateTimeOffset? lastModified = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = StreamingEndpointCurrentSku.DeserializeStreamingEndpointCurrentSku(property.Value, options);
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerMediaContext.Default);
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scaleUnits"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scaleUnits = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("availabilitySetName"u8))
                        {
                            availabilitySetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accessControl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                accessControl = null;
                                continue;
                            }
                            accessControl = StreamingEndpointAccessControl.DeserializeStreamingEndpointAccessControl(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("maxCacheAge"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                maxCacheAge = null;
                                continue;
                            }
                            maxCacheAge = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("customHostNames"u8))
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
                            customHostNames = array;
                            continue;
                        }
                        if (property0.NameEquals("hostName"u8))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cdnEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cdnEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("cdnProvider"u8))
                        {
                            cdnProvider = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cdnProfile"u8))
                        {
                            cdnProfile = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new StreamingEndpointResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("crossSiteAccessPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                crossSiteAccessPolicies = null;
                                continue;
                            }
                            crossSiteAccessPolicies = CrossSiteAccessPolicies.DeserializeCrossSiteAccessPolicies(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("freeTrialEndTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            freeTrialEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModified"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModified = property0.Value.GetDateTimeOffset("O");
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
            return new StreamingEndpointData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                sku,
                description,
                scaleUnits,
                availabilitySetName,
                accessControl,
                maxCacheAge,
                customHostNames ?? new ChangeTrackingList<string>(),
                hostName,
                cdnEnabled,
                cdnProvider,
                cdnProfile,
                provisioningState,
                resourceState,
                crossSiteAccessPolicies,
                freeTrialEndTime,
                created,
                lastModified,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamingEndpointData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingEndpointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMediaContext.Default);
                default:
                    throw new FormatException($"The model {nameof(StreamingEndpointData)} does not support writing '{options.Format}' format.");
            }
        }

        StreamingEndpointData IPersistableModel<StreamingEndpointData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingEndpointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStreamingEndpointData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingEndpointData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingEndpointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

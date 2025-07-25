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

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class RoutingRuleData : IUtf8JsonSerializable, IJsonModel<RoutingRuleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoutingRuleData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RoutingRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingRuleData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(FrontendEndpoints))
            {
                writer.WritePropertyName("frontendEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in FrontendEndpoints)
                {
                    ((IJsonModel<WritableSubResource>)item).Write(writer, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AcceptedProtocols))
            {
                writer.WritePropertyName("acceptedProtocols"u8);
                writer.WriteStartArray();
                foreach (var item in AcceptedProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PatternsToMatch))
            {
                writer.WritePropertyName("patternsToMatch"u8);
                writer.WriteStartArray();
                foreach (var item in PatternsToMatch)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState"u8);
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            if (Optional.IsDefined(RouteConfiguration))
            {
                writer.WritePropertyName("routeConfiguration"u8);
                writer.WriteObjectValue(RouteConfiguration, options);
            }
            if (Optional.IsDefined(RulesEngine))
            {
                writer.WritePropertyName("rulesEngine"u8);
                ((IJsonModel<WritableSubResource>)RulesEngine).Write(writer, options);
            }
            if (Optional.IsDefined(WebApplicationFirewallPolicyLink))
            {
                writer.WritePropertyName("webApplicationFirewallPolicyLink"u8);
                ((IJsonModel<WritableSubResource>)WebApplicationFirewallPolicyLink).Write(writer, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceState))
            {
                writer.WritePropertyName("resourceState"u8);
                writer.WriteStringValue(ResourceState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        RoutingRuleData IJsonModel<RoutingRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingRuleData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoutingRuleData(document.RootElement, options);
        }

        internal static RoutingRuleData DeserializeRoutingRuleData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            IList<WritableSubResource> frontendEndpoints = default;
            IList<FrontDoorProtocol> acceptedProtocols = default;
            IList<string> patternsToMatch = default;
            RoutingRuleEnabledState? enabledState = default;
            RouteConfiguration routeConfiguration = default;
            WritableSubResource rulesEngine = default;
            WritableSubResource webApplicationFirewallPolicyLink = default;
            FrontDoorResourceState? resourceState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("frontendEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(item.GetRawText())), options, AzureResourceManagerFrontDoorContext.Default));
                            }
                            frontendEndpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("acceptedProtocols"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FrontDoorProtocol> array = new List<FrontDoorProtocol>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new FrontDoorProtocol(item.GetString()));
                            }
                            acceptedProtocols = array;
                            continue;
                        }
                        if (property0.NameEquals("patternsToMatch"u8))
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
                            patternsToMatch = array;
                            continue;
                        }
                        if (property0.NameEquals("enabledState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabledState = new RoutingRuleEnabledState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("routeConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routeConfiguration = RouteConfiguration.DeserializeRouteConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("rulesEngine"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rulesEngine = ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(property0.Value.GetRawText())), options, AzureResourceManagerFrontDoorContext.Default);
                            continue;
                        }
                        if (property0.NameEquals("webApplicationFirewallPolicyLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            webApplicationFirewallPolicyLink = ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(property0.Value.GetRawText())), options, AzureResourceManagerFrontDoorContext.Default);
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new FrontDoorResourceState(property0.Value.GetString());
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
            return new RoutingRuleData(
                id,
                name,
                type,
                serializedAdditionalRawData,
                frontendEndpoints ?? new ChangeTrackingList<WritableSubResource>(),
                acceptedProtocols ?? new ChangeTrackingList<FrontDoorProtocol>(),
                patternsToMatch ?? new ChangeTrackingList<string>(),
                enabledState,
                routeConfiguration,
                rulesEngine,
                webApplicationFirewallPolicyLink,
                resourceState);
        }

        BinaryData IPersistableModel<RoutingRuleData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerFrontDoorContext.Default);
                default:
                    throw new FormatException($"The model {nameof(RoutingRuleData)} does not support writing '{options.Format}' format.");
            }
        }

        RoutingRuleData IPersistableModel<RoutingRuleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRoutingRuleData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoutingRuleData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoutingRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

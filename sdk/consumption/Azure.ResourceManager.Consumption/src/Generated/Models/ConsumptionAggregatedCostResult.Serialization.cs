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

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionAggregatedCostResult : IUtf8JsonSerializable, IJsonModel<ConsumptionAggregatedCostResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionAggregatedCostResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConsumptionAggregatedCostResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionAggregatedCostResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionAggregatedCostResult)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(BillingPeriodId))
            {
                writer.WritePropertyName("billingPeriodId"u8);
                writer.WriteStringValue(BillingPeriodId);
            }
            if (options.Format != "W" && Optional.IsDefined(UsageStartOn))
            {
                writer.WritePropertyName("usageStart"u8);
                writer.WriteStringValue(UsageStartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(UsageEndOn))
            {
                writer.WritePropertyName("usageEnd"u8);
                writer.WriteStringValue(UsageEndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(AzureCharges))
            {
                writer.WritePropertyName("azureCharges"u8);
                writer.WriteNumberValue(AzureCharges.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MarketplaceCharges))
            {
                writer.WritePropertyName("marketplaceCharges"u8);
                writer.WriteNumberValue(MarketplaceCharges.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ChargesBilledSeparately))
            {
                writer.WritePropertyName("chargesBilledSeparately"u8);
                writer.WriteNumberValue(ChargesBilledSeparately.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Currency))
            {
                writer.WritePropertyName("currency"u8);
                writer.WriteStringValue(Currency);
            }
            if (Optional.IsCollectionDefined(Children))
            {
                writer.WritePropertyName("children"u8);
                writer.WriteStartArray();
                foreach (var item in Children)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IncludedSubscriptions))
            {
                writer.WritePropertyName("includedSubscriptions"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedSubscriptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExcludedSubscriptions))
            {
                writer.WritePropertyName("excludedSubscriptions"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedSubscriptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        ConsumptionAggregatedCostResult IJsonModel<ConsumptionAggregatedCostResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionAggregatedCostResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionAggregatedCostResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionAggregatedCostResult(document.RootElement, options);
        }

        internal static ConsumptionAggregatedCostResult DeserializeConsumptionAggregatedCostResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            IReadOnlyDictionary<string, string> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string billingPeriodId = default;
            DateTimeOffset? usageStart = default;
            DateTimeOffset? usageEnd = default;
            decimal? azureCharges = default;
            decimal? marketplaceCharges = default;
            decimal? chargesBilledSeparately = default;
            string currency = default;
            IReadOnlyList<ConsumptionAggregatedCostResult> children = default;
            IReadOnlyList<string> includedSubscriptions = default;
            IReadOnlyList<string> excludedSubscriptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerConsumptionContext.Default);
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
                        if (property0.NameEquals("billingPeriodId"u8))
                        {
                            billingPeriodId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("usageStart"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usageStart = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("usageEnd"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usageEnd = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("azureCharges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureCharges = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("marketplaceCharges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            marketplaceCharges = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("chargesBilledSeparately"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            chargesBilledSeparately = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("currency"u8))
                        {
                            currency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("children"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConsumptionAggregatedCostResult> array = new List<ConsumptionAggregatedCostResult>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeConsumptionAggregatedCostResult(item, options));
                            }
                            children = array;
                            continue;
                        }
                        if (property0.NameEquals("includedSubscriptions"u8))
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
                            includedSubscriptions = array;
                            continue;
                        }
                        if (property0.NameEquals("excludedSubscriptions"u8))
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
                            excludedSubscriptions = array;
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
            return new ConsumptionAggregatedCostResult(
                id,
                name,
                type,
                systemData,
                billingPeriodId,
                usageStart,
                usageEnd,
                azureCharges,
                marketplaceCharges,
                chargesBilledSeparately,
                currency,
                children ?? new ChangeTrackingList<ConsumptionAggregatedCostResult>(),
                includedSubscriptions ?? new ChangeTrackingList<string>(),
                excludedSubscriptions ?? new ChangeTrackingList<string>(),
                etag,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConsumptionAggregatedCostResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionAggregatedCostResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerConsumptionContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionAggregatedCostResult)} does not support writing '{options.Format}' format.");
            }
        }

        ConsumptionAggregatedCostResult IPersistableModel<ConsumptionAggregatedCostResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionAggregatedCostResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConsumptionAggregatedCostResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConsumptionAggregatedCostResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionAggregatedCostResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

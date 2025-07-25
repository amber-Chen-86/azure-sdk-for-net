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
    public partial class StreamingPolicyData : IUtf8JsonSerializable, IJsonModel<StreamingPolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingPolicyData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StreamingPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingPolicyData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("created"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(DefaultContentKeyPolicyName))
            {
                writer.WritePropertyName("defaultContentKeyPolicyName"u8);
                writer.WriteStringValue(DefaultContentKeyPolicyName);
            }
            if (Optional.IsDefined(EnvelopeEncryption))
            {
                writer.WritePropertyName("envelopeEncryption"u8);
                writer.WriteObjectValue(EnvelopeEncryption, options);
            }
            if (Optional.IsDefined(CommonEncryptionCenc))
            {
                writer.WritePropertyName("commonEncryptionCenc"u8);
                writer.WriteObjectValue(CommonEncryptionCenc, options);
            }
            if (Optional.IsDefined(CommonEncryptionCbcs))
            {
                writer.WritePropertyName("commonEncryptionCbcs"u8);
                writer.WriteObjectValue(CommonEncryptionCbcs, options);
            }
            if (Optional.IsDefined(NoEncryption))
            {
                writer.WritePropertyName("noEncryption"u8);
                writer.WriteObjectValue(NoEncryption, options);
            }
            writer.WriteEndObject();
        }

        StreamingPolicyData IJsonModel<StreamingPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingPolicyData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingPolicyData(document.RootElement, options);
        }

        internal static StreamingPolicyData DeserializeStreamingPolicyData(JsonElement element, ModelReaderWriterOptions options = null)
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
            DateTimeOffset? created = default;
            string defaultContentKeyPolicyName = default;
            EnvelopeEncryption envelopeEncryption = default;
            CommonEncryptionCenc commonEncryptionCenc = default;
            CommonEncryptionCbcs commonEncryptionCbcs = default;
            NoEncryption noEncryption = default;
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
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("defaultContentKeyPolicyName"u8))
                        {
                            defaultContentKeyPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("envelopeEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            envelopeEncryption = EnvelopeEncryption.DeserializeEnvelopeEncryption(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("commonEncryptionCenc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            commonEncryptionCenc = CommonEncryptionCenc.DeserializeCommonEncryptionCenc(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("commonEncryptionCbcs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            commonEncryptionCbcs = CommonEncryptionCbcs.DeserializeCommonEncryptionCbcs(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("noEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            noEncryption = NoEncryption.DeserializeNoEncryption(property0.Value, options);
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
            return new StreamingPolicyData(
                id,
                name,
                type,
                systemData,
                created,
                defaultContentKeyPolicyName,
                envelopeEncryption,
                commonEncryptionCenc,
                commonEncryptionCbcs,
                noEncryption,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamingPolicyData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMediaContext.Default);
                default:
                    throw new FormatException($"The model {nameof(StreamingPolicyData)} does not support writing '{options.Format}' format.");
            }
        }

        StreamingPolicyData IPersistableModel<StreamingPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStreamingPolicyData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingPolicyData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class RestoreRequestInfo : IUtf8JsonSerializable, IJsonModel<RestoreRequestInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestoreRequestInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RestoreRequestInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreRequestInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestoreRequestInfo)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccountUri))
            {
                writer.WritePropertyName("storageAccountUrl"u8);
                writer.WriteStringValue(StorageAccountUri.AbsoluteUri);
            }
            if (Optional.IsDefined(BlobName))
            {
                writer.WritePropertyName("blobName"u8);
                writer.WriteStringValue(BlobName);
            }
            if (Optional.IsDefined(CanOverwrite))
            {
                writer.WritePropertyName("overwrite"u8);
                writer.WriteBooleanValue(CanOverwrite.Value);
            }
            if (Optional.IsDefined(SiteName))
            {
                writer.WritePropertyName("siteName"u8);
                writer.WriteStringValue(SiteName);
            }
            if (Optional.IsCollectionDefined(Databases))
            {
                writer.WritePropertyName("databases"u8);
                writer.WriteStartArray();
                foreach (var item in Databases)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IgnoreConflictingHostNames))
            {
                writer.WritePropertyName("ignoreConflictingHostNames"u8);
                writer.WriteBooleanValue(IgnoreConflictingHostNames.Value);
            }
            if (Optional.IsDefined(IgnoreDatabases))
            {
                writer.WritePropertyName("ignoreDatabases"u8);
                writer.WriteBooleanValue(IgnoreDatabases.Value);
            }
            if (Optional.IsDefined(AppServicePlan))
            {
                writer.WritePropertyName("appServicePlan"u8);
                writer.WriteStringValue(AppServicePlan);
            }
            if (Optional.IsDefined(OperationType))
            {
                writer.WritePropertyName("operationType"u8);
                writer.WriteStringValue(OperationType.Value.ToSerialString());
            }
            if (Optional.IsDefined(AdjustConnectionStrings))
            {
                writer.WritePropertyName("adjustConnectionStrings"u8);
                writer.WriteBooleanValue(AdjustConnectionStrings.Value);
            }
            if (Optional.IsDefined(HostingEnvironment))
            {
                writer.WritePropertyName("hostingEnvironment"u8);
                writer.WriteStringValue(HostingEnvironment);
            }
            writer.WriteEndObject();
        }

        RestoreRequestInfo IJsonModel<RestoreRequestInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreRequestInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestoreRequestInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestoreRequestInfo(document.RootElement, options);
        }

        internal static RestoreRequestInfo DeserializeRestoreRequestInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Uri storageAccountUrl = default;
            string blobName = default;
            bool? overwrite = default;
            string siteName = default;
            IList<AppServiceDatabaseBackupSetting> databases = default;
            bool? ignoreConflictingHostNames = default;
            bool? ignoreDatabases = default;
            string appServicePlan = default;
            BackupRestoreOperationType? operationType = default;
            bool? adjustConnectionStrings = default;
            string hostingEnvironment = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerAppServiceContext.Default);
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
                        if (property0.NameEquals("storageAccountUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("blobName"u8))
                        {
                            blobName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("overwrite"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            overwrite = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("siteName"u8))
                        {
                            siteName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("databases"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AppServiceDatabaseBackupSetting> array = new List<AppServiceDatabaseBackupSetting>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AppServiceDatabaseBackupSetting.DeserializeAppServiceDatabaseBackupSetting(item, options));
                            }
                            databases = array;
                            continue;
                        }
                        if (property0.NameEquals("ignoreConflictingHostNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ignoreConflictingHostNames = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ignoreDatabases"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ignoreDatabases = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("appServicePlan"u8))
                        {
                            appServicePlan = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            operationType = property0.Value.GetString().ToBackupRestoreOperationType();
                            continue;
                        }
                        if (property0.NameEquals("adjustConnectionStrings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            adjustConnectionStrings = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hostingEnvironment"u8))
                        {
                            hostingEnvironment = property0.Value.GetString();
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
            return new RestoreRequestInfo(
                id,
                name,
                type,
                systemData,
                storageAccountUrl,
                blobName,
                overwrite,
                siteName,
                databases ?? new ChangeTrackingList<AppServiceDatabaseBackupSetting>(),
                ignoreConflictingHostNames,
                ignoreDatabases,
                appServicePlan,
                operationType,
                adjustConnectionStrings,
                hostingEnvironment,
                kind,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Kind))
                {
                    builder.Append("  kind: ");
                    if (Kind.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Kind}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Kind}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StorageAccountUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    storageAccountUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StorageAccountUri))
                {
                    builder.Append("    storageAccountUrl: ");
                    builder.AppendLine($"'{StorageAccountUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BlobName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    blobName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BlobName))
                {
                    builder.Append("    blobName: ");
                    if (BlobName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{BlobName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{BlobName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CanOverwrite), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    overwrite: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CanOverwrite))
                {
                    builder.Append("    overwrite: ");
                    var boolValue = CanOverwrite.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SiteName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    siteName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SiteName))
                {
                    builder.Append("    siteName: ");
                    if (SiteName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SiteName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SiteName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Databases), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    databases: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Databases))
                {
                    if (Databases.Any())
                    {
                        builder.Append("    databases: ");
                        builder.AppendLine("[");
                        foreach (var item in Databases)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    databases: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IgnoreConflictingHostNames), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    ignoreConflictingHostNames: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IgnoreConflictingHostNames))
                {
                    builder.Append("    ignoreConflictingHostNames: ");
                    var boolValue = IgnoreConflictingHostNames.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IgnoreDatabases), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    ignoreDatabases: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IgnoreDatabases))
                {
                    builder.Append("    ignoreDatabases: ");
                    var boolValue = IgnoreDatabases.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AppServicePlan), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    appServicePlan: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AppServicePlan))
                {
                    builder.Append("    appServicePlan: ");
                    if (AppServicePlan.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AppServicePlan}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AppServicePlan}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OperationType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    operationType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OperationType))
                {
                    builder.Append("    operationType: ");
                    builder.AppendLine($"'{OperationType.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AdjustConnectionStrings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    adjustConnectionStrings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AdjustConnectionStrings))
                {
                    builder.Append("    adjustConnectionStrings: ");
                    var boolValue = AdjustConnectionStrings.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HostingEnvironment), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    hostingEnvironment: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HostingEnvironment))
                {
                    builder.Append("    hostingEnvironment: ");
                    if (HostingEnvironment.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{HostingEnvironment}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{HostingEnvironment}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<RestoreRequestInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreRequestInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppServiceContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RestoreRequestInfo)} does not support writing '{options.Format}' format.");
            }
        }

        RestoreRequestInfo IPersistableModel<RestoreRequestInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestoreRequestInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRestoreRequestInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RestoreRequestInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestoreRequestInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

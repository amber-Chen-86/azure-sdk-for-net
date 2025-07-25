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
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsSourceControlData : IUtf8JsonSerializable, IJsonModel<SecurityInsightsSourceControlData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsSourceControlData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecurityInsightsSourceControlData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsSourceControlData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsSourceControlData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(SourceControlId))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(SourceControlId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version.Value.ToString());
            }
            writer.WritePropertyName("displayName"u8);
            writer.WriteStringValue(DisplayName);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("repoType"u8);
            writer.WriteStringValue(RepoType.ToString());
            writer.WritePropertyName("contentTypes"u8);
            writer.WriteStartArray();
            foreach (var item in ContentTypes)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            writer.WritePropertyName("repository"u8);
            writer.WriteObjectValue(Repository, options);
            if (Optional.IsDefined(ServicePrincipal))
            {
                writer.WritePropertyName("servicePrincipal"u8);
                writer.WriteObjectValue(ServicePrincipal, options);
            }
            if (Optional.IsDefined(RepositoryAccess))
            {
                writer.WritePropertyName("repositoryAccess"u8);
                writer.WriteObjectValue(RepositoryAccess, options);
            }
            if (Optional.IsDefined(RepositoryResourceInfo))
            {
                writer.WritePropertyName("repositoryResourceInfo"u8);
                writer.WriteObjectValue(RepositoryResourceInfo, options);
            }
            if (options.Format != "W" && Optional.IsDefined(LastDeploymentInfo))
            {
                writer.WritePropertyName("lastDeploymentInfo"u8);
                writer.WriteObjectValue(LastDeploymentInfo, options);
            }
            if (options.Format != "W" && Optional.IsDefined(PullRequest))
            {
                writer.WritePropertyName("pullRequest"u8);
                writer.WriteObjectValue(PullRequest, options);
            }
            writer.WriteEndObject();
        }

        SecurityInsightsSourceControlData IJsonModel<SecurityInsightsSourceControlData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsSourceControlData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsSourceControlData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsSourceControlData(document.RootElement, options);
        }

        internal static SecurityInsightsSourceControlData DeserializeSecurityInsightsSourceControlData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Guid? id0 = default;
            SourceControlVersion? version = default;
            string displayName = default;
            string description = default;
            SourceControlRepoType repoType = default;
            IList<SourceControlContentType> contentTypes = default;
            SourceControlRepository repository = default;
            SourceControlServicePrincipal servicePrincipal = default;
            RepositoryAccess repositoryAccess = default;
            RepositoryResourceInfo repositoryResourceInfo = default;
            SourceControlDeploymentInfo lastDeploymentInfo = default;
            PullRequestInfo pullRequest = default;
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerSecurityInsightsContext.Default);
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
                        if (property0.NameEquals("id"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            id0 = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            version = new SourceControlVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("repoType"u8))
                        {
                            repoType = new SourceControlRepoType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("contentTypes"u8))
                        {
                            List<SourceControlContentType> array = new List<SourceControlContentType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SourceControlContentType(item.GetString()));
                            }
                            contentTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("repository"u8))
                        {
                            repository = SourceControlRepository.DeserializeSourceControlRepository(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipal"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipal = SourceControlServicePrincipal.DeserializeSourceControlServicePrincipal(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("repositoryAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            repositoryAccess = RepositoryAccess.DeserializeRepositoryAccess(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("repositoryResourceInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            repositoryResourceInfo = RepositoryResourceInfo.DeserializeRepositoryResourceInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("lastDeploymentInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastDeploymentInfo = SourceControlDeploymentInfo.DeserializeSourceControlDeploymentInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("pullRequest"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pullRequest = PullRequestInfo.DeserializePullRequestInfo(property0.Value, options);
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
            return new SecurityInsightsSourceControlData(
                id,
                name,
                type,
                systemData,
                id0,
                version,
                displayName,
                description,
                repoType,
                contentTypes,
                repository,
                servicePrincipal,
                repositoryAccess,
                repositoryResourceInfo,
                lastDeploymentInfo,
                pullRequest,
                etag,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ETag), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  etag: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ETag))
                {
                    builder.Append("  etag: ");
                    builder.AppendLine($"'{ETag.Value.ToString()}'");
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
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourceControlId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SourceControlId))
                {
                    builder.Append("    id: ");
                    builder.AppendLine($"'{SourceControlId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Version), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    version: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Version))
                {
                    builder.Append("    version: ");
                    builder.AppendLine($"'{Version.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    displayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DisplayName))
                {
                    builder.Append("    displayName: ");
                    if (DisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("    description: ");
                    if (Description.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Description}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Description}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RepoType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    repoType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("    repoType: ");
                builder.AppendLine($"'{RepoType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ContentTypes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    contentTypes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ContentTypes))
                {
                    if (ContentTypes.Any())
                    {
                        builder.Append("    contentTypes: ");
                        builder.AppendLine("[");
                        foreach (var item in ContentTypes)
                        {
                            builder.AppendLine($"      '{item.ToString()}'");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Repository), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    repository: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Repository))
                {
                    builder.Append("    repository: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Repository, options, 4, false, "    repository: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ServicePrincipal), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    servicePrincipal: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ServicePrincipal))
                {
                    builder.Append("    servicePrincipal: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ServicePrincipal, options, 4, false, "    servicePrincipal: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RepositoryAccess), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    repositoryAccess: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RepositoryAccess))
                {
                    builder.Append("    repositoryAccess: ");
                    BicepSerializationHelpers.AppendChildObject(builder, RepositoryAccess, options, 4, false, "    repositoryAccess: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RepositoryResourceInfo), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    repositoryResourceInfo: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RepositoryResourceInfo))
                {
                    builder.Append("    repositoryResourceInfo: ");
                    BicepSerializationHelpers.AppendChildObject(builder, RepositoryResourceInfo, options, 4, false, "    repositoryResourceInfo: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastDeploymentInfo), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    lastDeploymentInfo: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastDeploymentInfo))
                {
                    builder.Append("    lastDeploymentInfo: ");
                    BicepSerializationHelpers.AppendChildObject(builder, LastDeploymentInfo, options, 4, false, "    lastDeploymentInfo: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PullRequest), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    pullRequest: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PullRequest))
                {
                    builder.Append("    pullRequest: ");
                    BicepSerializationHelpers.AppendChildObject(builder, PullRequest, options, 4, false, "    pullRequest: ");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SecurityInsightsSourceControlData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsSourceControlData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityInsightsContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsSourceControlData)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityInsightsSourceControlData IPersistableModel<SecurityInsightsSourceControlData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsSourceControlData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSecurityInsightsSourceControlData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsSourceControlData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsSourceControlData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

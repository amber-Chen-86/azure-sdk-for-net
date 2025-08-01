// <auto-generated/>

using Azure.ResourceManager.Models;
using Azure.ResourceManager.MySql;
using Azure.ResourceManager.MySql.FlexibleServers;
using Azure.ResourceManager.MySql.FlexibleServers.Models;
using Azure.ResourceManager.MySql.Models;
using System.ClientModel.Primitives;

namespace Azure.ResourceManager.MySql;

[ModelReaderWriterBuildable(typeof(MySqlServerData))]
[ModelReaderWriterBuildable(typeof(MySqlAdvisorData))]
[ModelReaderWriterBuildable(typeof(MySqlAdvisorResource))]
[ModelReaderWriterBuildable(typeof(MySqlConfigurationData))]
[ModelReaderWriterBuildable(typeof(MySqlConfigurationResource))]
[ModelReaderWriterBuildable(typeof(MySqlDatabaseData))]
[ModelReaderWriterBuildable(typeof(MySqlDatabaseResource))]
[ModelReaderWriterBuildable(typeof(MySqlFirewallRuleData))]
[ModelReaderWriterBuildable(typeof(MySqlFirewallRuleResource))]
[ModelReaderWriterBuildable(typeof(MySqlPrivateEndpointConnectionData))]
[ModelReaderWriterBuildable(typeof(MySqlPrivateEndpointConnectionResource))]
[ModelReaderWriterBuildable(typeof(MySqlPrivateLinkResource))]
[ModelReaderWriterBuildable(typeof(MySqlPrivateLinkResourceData))]
[ModelReaderWriterBuildable(typeof(MySqlQueryStatisticData))]
[ModelReaderWriterBuildable(typeof(MySqlQueryStatisticResource))]
[ModelReaderWriterBuildable(typeof(MySqlQueryTextData))]
[ModelReaderWriterBuildable(typeof(MySqlQueryTextResource))]
[ModelReaderWriterBuildable(typeof(MySqlRecommendationActionData))]
[ModelReaderWriterBuildable(typeof(MySqlRecommendationActionResource))]
[ModelReaderWriterBuildable(typeof(MySqlServerAdministratorData))]
[ModelReaderWriterBuildable(typeof(MySqlServerAdministratorResource))]
[ModelReaderWriterBuildable(typeof(MySqlServerKeyData))]
[ModelReaderWriterBuildable(typeof(MySqlServerKeyResource))]
[ModelReaderWriterBuildable(typeof(MySqlServerResource))]
[ModelReaderWriterBuildable(typeof(MySqlServerSecurityAlertPolicyData))]
[ModelReaderWriterBuildable(typeof(MySqlServerSecurityAlertPolicyResource))]
[ModelReaderWriterBuildable(typeof(MySqlVirtualNetworkRuleData))]
[ModelReaderWriterBuildable(typeof(MySqlVirtualNetworkRuleResource))]
[ModelReaderWriterBuildable(typeof(MySqlWaitStatisticData))]
[ModelReaderWriterBuildable(typeof(MySqlWaitStatisticResource))]
[ModelReaderWriterBuildable(typeof(AdvancedThreatProtectionData))]
[ModelReaderWriterBuildable(typeof(AdvancedThreatProtectionResource))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerAadAdministratorData))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerAadAdministratorResource))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerBackupData))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerBackupResource))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerBackupV2Data))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerBackupV2Resource))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerConfigurationData))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerConfigurationResource))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerData))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerDatabaseData))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerDatabaseResource))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerFirewallRuleData))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerFirewallRuleResource))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerMaintenanceData))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerMaintenanceResource))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerResource))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServersCapabilityData))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServersCapabilityResource))]
[ModelReaderWriterBuildable(typeof(AdvancedThreatProtectionListResult))]
[ModelReaderWriterBuildable(typeof(AdvancedThreatProtectionPatch))]
[ModelReaderWriterBuildable(typeof(CapabilitySetsList))]
[ModelReaderWriterBuildable(typeof(HighAvailabilityValidationEstimation))]
[ModelReaderWriterBuildable(typeof(ImportSourceProperties))]
[ModelReaderWriterBuildable(typeof(MaintenanceListResult))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerAadAdministratorListResult))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerBackupAndExportContent))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerBackupAndExportResult))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerBackupContentBase))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerBackupListResult))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerBackupProperties))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerBackupSettings))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerBackupStoreDetails))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerCapabilitiesListResult))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerCapabilityProperties))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerConfigurationForBatchUpdate))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerConfigurationListForBatchUpdate))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerConfigurationListResult))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerConfigurations))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerDatabaseListResult))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerDataEncryption))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerDelegatedSubnetUsage))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerEditionCapability))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerFirewallRuleListResult))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerFullBackupStoreDetails))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerGtidSetContent))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerHighAvailability))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerListResult))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerLogFile))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerLogFileListResult))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerMaintenancePatch))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerMaintenanceWindow))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerNameAvailabilityContent))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerNameAvailabilityResult))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerNetwork))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerPatch))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerPrivateDnsZoneSuffixResponse))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerRestartParameter))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerServerVersionCapability))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerSku))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerSkuCapability))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServersPrivateEndpointConnection))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServersPrivateLinkServiceConnectionState))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerStorage))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerStorageEditionCapability))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerValidateBackupResult))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerVirtualNetworkSubnetUsageParameter))]
[ModelReaderWriterBuildable(typeof(MySqlFlexibleServerVirtualNetworkSubnetUsageResult))]
[ModelReaderWriterBuildable(typeof(OperationStatusExtendedResult))]
[ModelReaderWriterBuildable(typeof(Azure.ResourceManager.MySql.FlexibleServers.Models.OperationStatusResult))]
[ModelReaderWriterBuildable(typeof(ServerBackupV2ListResult))]
[ModelReaderWriterBuildable(typeof(ServerEditionCapabilityV2))]
[ModelReaderWriterBuildable(typeof(ServerVersionCapabilityV2))]
[ModelReaderWriterBuildable(typeof(SkuCapabilityV2))]
[ModelReaderWriterBuildable(typeof(UnknownBackupStoreDetails))]
[ModelReaderWriterBuildable(typeof(MySqlAdvisorListResult))]
[ModelReaderWriterBuildable(typeof(MySqlConfigurations))]
[ModelReaderWriterBuildable(typeof(MySqlDatabaseListResult))]
[ModelReaderWriterBuildable(typeof(MySqlFirewallRuleListResult))]
[ModelReaderWriterBuildable(typeof(MySqlLogFile))]
[ModelReaderWriterBuildable(typeof(MySqlLogFileListResult))]
[ModelReaderWriterBuildable(typeof(MySqlNameAvailabilityContent))]
[ModelReaderWriterBuildable(typeof(MySqlNameAvailabilityResult))]
[ModelReaderWriterBuildable(typeof(MySqlPerformanceTier))]
[ModelReaderWriterBuildable(typeof(MySqlPerformanceTierListResult))]
[ModelReaderWriterBuildable(typeof(MySqlPerformanceTierServiceLevelObjectives))]
[ModelReaderWriterBuildable(typeof(MySqlPrivateEndpointConnectionListResult))]
[ModelReaderWriterBuildable(typeof(MySqlPrivateEndpointConnectionPatch))]
[ModelReaderWriterBuildable(typeof(MySqlPrivateLinkResourceListResult))]
[ModelReaderWriterBuildable(typeof(MySqlPrivateLinkResourceProperties))]
[ModelReaderWriterBuildable(typeof(MySqlPrivateLinkServiceConnectionStateProperty))]
[ModelReaderWriterBuildable(typeof(MySqlQueryPerformanceInsightResetDataResult))]
[ModelReaderWriterBuildable(typeof(MySqlQueryTextListResult))]
[ModelReaderWriterBuildable(typeof(MySqlRecommendationActionListResult))]
[ModelReaderWriterBuildable(typeof(MySqlRecoverableServerResourceData))]
[ModelReaderWriterBuildable(typeof(MySqlServerAdministratorListResult))]
[ModelReaderWriterBuildable(typeof(MySqlServerCreateOrUpdateContent))]
[ModelReaderWriterBuildable(typeof(MySqlServerKeyListResult))]
[ModelReaderWriterBuildable(typeof(MySqlServerListResult))]
[ModelReaderWriterBuildable(typeof(MySqlServerPatch))]
[ModelReaderWriterBuildable(typeof(MySqlServerPrivateEndpointConnection))]
[ModelReaderWriterBuildable(typeof(MySqlServerPrivateEndpointConnectionProperties))]
[ModelReaderWriterBuildable(typeof(MySqlServerPrivateLinkServiceConnectionStateProperty))]
[ModelReaderWriterBuildable(typeof(MySqlServerPropertiesForCreate))]
[ModelReaderWriterBuildable(typeof(MySqlServerPropertiesForDefaultCreate))]
[ModelReaderWriterBuildable(typeof(MySqlServerPropertiesForGeoRestore))]
[ModelReaderWriterBuildable(typeof(MySqlServerPropertiesForReplica))]
[ModelReaderWriterBuildable(typeof(MySqlServerPropertiesForRestore))]
[ModelReaderWriterBuildable(typeof(MySqlServerSecurityAlertPolicyListResult))]
[ModelReaderWriterBuildable(typeof(MySqlServerUpgradeContent))]
[ModelReaderWriterBuildable(typeof(MySqlSku))]
[ModelReaderWriterBuildable(typeof(MySqlStorageProfile))]
[ModelReaderWriterBuildable(typeof(MySqlTopQueryStatisticsInput))]
[ModelReaderWriterBuildable(typeof(MySqlTopQueryStatisticsListResult))]
[ModelReaderWriterBuildable(typeof(MySqlVirtualNetworkRuleListResult))]
[ModelReaderWriterBuildable(typeof(MySqlWaitStatisticsInput))]
[ModelReaderWriterBuildable(typeof(MySqlWaitStatisticsListResult))]
[ModelReaderWriterBuildable(typeof(UnknownServerPropertiesForCreate))]
[ModelReaderWriterBuildable(typeof(SystemData))]
public partial class AzureResourceManagerMySqlContext
{
}

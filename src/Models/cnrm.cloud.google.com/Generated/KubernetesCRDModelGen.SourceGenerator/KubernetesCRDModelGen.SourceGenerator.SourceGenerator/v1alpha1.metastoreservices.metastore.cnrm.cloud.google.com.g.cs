#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.metastore.cnrm.cloud.google.com;
/// <summary>MetastoreService is the Schema for the MetastoreService API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MetastoreServiceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MetastoreService>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MetastoreServiceList";
    public const string KubeGroup = "metastore.cnrm.cloud.google.com";
    public const string KubePluralName = "metastoreservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "metastore.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetastoreServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1MetastoreService objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1MetastoreService> Items { get; set; }
}

/// <summary>Immutable. The database type that the Metastore service stores its data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MetastoreServiceSpecDatabaseTypeEnum>))]
public enum V1alpha1MetastoreServiceSpecDatabaseTypeEnum
{
    [EnumMember(Value = "MYSQL"), JsonStringEnumMemberName("MYSQL")]
    MYSQL,
    [EnumMember(Value = "SPANNER"), JsonStringEnumMemberName("SPANNER")]
    SPANNER
}

/// <summary>The fully qualified customer provided Cloud KMS key name to use for customer data encryption</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceSpecEncryptionConfigKmsKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Information used to configure the Dataproc Metastore service to encrypt customer data at rest. Cannot be updated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceSpecEncryptionConfig
{
    /// <summary>The fully qualified customer provided Cloud KMS key name to use for customer data encryption</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1MetastoreServiceSpecEncryptionConfigKmsKeyRef? KmsKeyRef { get; set; }
}

/// <summary>The relative resource name of a Secret Manager secret version</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceSpecHiveMetastoreConfigKerberosConfigKeytabSecretRef
{
    /// <summary>A reference to an externally managed SecretManagerSecret resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secrets/{{secretID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A Kerberos keytab file that can be used to authenticate a service principal with a Kerberos Key Distribution Center (KDC).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceSpecHiveMetastoreConfigKerberosConfigKeytab
{
    /// <summary>The relative resource name of a Secret Manager secret version</summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1MetastoreServiceSpecHiveMetastoreConfigKerberosConfigKeytabSecretRef? SecretRef { get; set; }
}

/// <summary>Information used to configure the Hive metastore service as a service principal in a Kerberos realm. To disable Kerberos, use the `UpdateService` method and specify this field&apos;s path (`hive_metastore_config.kerberos_config`) in the request&apos;s `update_mask` while omitting this field from the request&apos;s `service`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceSpecHiveMetastoreConfigKerberosConfig
{
    /// <summary>A Kerberos keytab file that can be used to authenticate a service principal with a Kerberos Key Distribution Center (KDC).</summary>
    [JsonPropertyName("keytab")]
    public V1alpha1MetastoreServiceSpecHiveMetastoreConfigKerberosConfigKeytab? Keytab { get; set; }

    /// <summary>A Cloud Storage URI that specifies the path to a krb5.conf file. It is of the form `gs://{bucket_name}/path/to/krb5.conf`, although the file does not need to be named krb5.conf explicitly.</summary>
    [JsonPropertyName("krb5ConfigGCSURI")]
    public string? Krb5ConfigGCSURI { get; set; }

    /// <summary>A Kerberos principal that exists in the both the keytab the KDC to authenticate as. A typical principal is of the form `primary/instance@REALM`, but there is no exact format.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}

/// <summary>Configuration information specific to running Hive metastore software as the metastore service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceSpecHiveMetastoreConfig
{
    /// <summary>A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore (configured in `hive-site.xml`). The mappings override system defaults (some keys cannot be overridden). These overrides are also applied to auxiliary versions and can be further customized in the auxiliary version&apos;s `AuxiliaryVersionConfig`.</summary>
    [JsonPropertyName("configOverrides")]
    public IDictionary<string, string>? ConfigOverrides { get; set; }

    /// <summary>The protocol to use for the metastore service endpoint. If unspecified, defaults to `THRIFT`.</summary>
    [JsonPropertyName("endpointProtocol")]
    public string? EndpointProtocol { get; set; }

    /// <summary>Information used to configure the Hive metastore service as a service principal in a Kerberos realm. To disable Kerberos, use the `UpdateService` method and specify this field&apos;s path (`hive_metastore_config.kerberos_config`) in the request&apos;s `update_mask` while omitting this field from the request&apos;s `service`.</summary>
    [JsonPropertyName("kerberosConfig")]
    public V1alpha1MetastoreServiceSpecHiveMetastoreConfigKerberosConfig? KerberosConfig { get; set; }

    /// <summary>Immutable. The Hive metastore schema version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>The hour of day (0-23) when the window starts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceSpecMaintenanceWindowHourOfDay
{
    /// <summary>The int32 value.</summary>
    [JsonPropertyName("value")]
    public int? Value { get; set; }
}

/// <summary>The one hour maintenance window of the metastore service. This specifies when the service can be restarted for maintenance purposes in UTC time. Maintenance window is not needed for services with the SPANNER database type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceSpecMaintenanceWindow
{
    /// <summary>The day of week, when the window starts.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The hour of day (0-23) when the window starts.</summary>
    [JsonPropertyName("hourOfDay")]
    public V1alpha1MetastoreServiceSpecMaintenanceWindowHourOfDay? HourOfDay { get; set; }
}

/// <summary>Immutable. The subnetwork of the customer project from which an IP address is reserved and used as the Dataproc Metastore service&apos;s endpoint. It is accessible to hosts in the subnet and to all hosts in a subnet in the same region and same network. There must be at least one IP address available in the subnet&apos;s primary range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceSpecNetworkConfigConsumersSubnetworkRef
{
    /// <summary>The ComputeSubnetwork selflink of form &quot;projects/{{project}}/regions/{{region}}/subnetworks/{{name}}&quot;, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceSpecNetworkConfigConsumers
{
    /// <summary>Immutable. The subnetwork of the customer project from which an IP address is reserved and used as the Dataproc Metastore service&apos;s endpoint. It is accessible to hosts in the subnet and to all hosts in a subnet in the same region and same network. There must be at least one IP address available in the subnet&apos;s primary range.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1alpha1MetastoreServiceSpecNetworkConfigConsumersSubnetworkRef? SubnetworkRef { get; set; }
}

/// <summary>The configuration specifying the network settings for the Dataproc Metastore service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceSpecNetworkConfig
{
    /// <summary>Immutable. The consumer-side network configuration for the Dataproc Metastore instance.</summary>
    [JsonPropertyName("consumers")]
    public IList<V1alpha1MetastoreServiceSpecNetworkConfigConsumers>? Consumers { get; set; }
}

/// <summary>Immutable. The relative resource name of the VPC network on which the instance can be accessed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceSpecNetworkRef
{
    /// <summary>The value of an externally managed ComputeNetwork resource. Should be in the format &quot;https://www.googleapis.com/compute/{{version}}/projects/{{projectId}}/global/networks/{{networkId}}&quot; or &quot;projects/{{projectId}}/global/networks/{{networkId}}&quot;</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeNetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeNetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The release channel of the service. If unspecified, defaults to `STABLE`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MetastoreServiceSpecReleaseChannelEnum>))]
public enum V1alpha1MetastoreServiceSpecReleaseChannelEnum
{
    [EnumMember(Value = "STABLE"), JsonStringEnumMemberName("STABLE")]
    STABLE,
    [EnumMember(Value = "CANARY"), JsonStringEnumMemberName("CANARY")]
    CANARY
}

/// <summary>Scaling configuration of the metastore service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceSpecScalingConfig
{
    /// <summary>An enum of readable instance sizes, with each instance size mapping to a float value (e.g. InstanceSize.EXTRA_SMALL = scaling_factor(0.1))</summary>
    [JsonPropertyName("instanceSize")]
    public string? InstanceSize { get; set; }

    /// <summary>Scaling factor, increments of 0.1 for values less than 1.0, and increments of 1.0 for values greater than 1.0.</summary>
    [JsonPropertyName("scalingFactor")]
    public double? ScalingFactor { get; set; }
}

/// <summary>The configuration specifying telemetry settings for the Dataproc Metastore service. If unspecified defaults to `JSON`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceSpecTelemetryConfig
{
    /// <summary>The output format of the Dataproc Metastore service&apos;s logs.</summary>
    [JsonPropertyName("logFormat")]
    public string? LogFormat { get; set; }
}

/// <summary>The tier of the service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MetastoreServiceSpecTierEnum>))]
public enum V1alpha1MetastoreServiceSpecTierEnum
{
    [EnumMember(Value = "DEVELOPER"), JsonStringEnumMemberName("DEVELOPER")]
    DEVELOPER,
    [EnumMember(Value = "ENTERPRISE"), JsonStringEnumMemberName("ENTERPRISE")]
    ENTERPRISE
}

/// <summary>MetastoreServiceSpec defines the desired state of MetastoreService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceSpec
{
    /// <summary>Immutable. The database type that the Metastore service stores its data.</summary>
    [JsonPropertyName("databaseType")]
    public V1alpha1MetastoreServiceSpecDatabaseTypeEnum? DatabaseType { get; set; }

    /// <summary>Immutable. Information used to configure the Dataproc Metastore service to encrypt customer data at rest. Cannot be updated.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1alpha1MetastoreServiceSpecEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>Configuration information specific to running Hive metastore software as the metastore service.</summary>
    [JsonPropertyName("hiveMetastoreConfig")]
    public V1alpha1MetastoreServiceSpecHiveMetastoreConfig? HiveMetastoreConfig { get; set; }

    /// <summary>User-defined labels for the metastore service.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The one hour maintenance window of the metastore service. This specifies when the service can be restarted for maintenance purposes in UTC time. Maintenance window is not needed for services with the SPANNER database type.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1alpha1MetastoreServiceSpecMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>The configuration specifying the network settings for the Dataproc Metastore service.</summary>
    [JsonPropertyName("networkConfig")]
    public V1alpha1MetastoreServiceSpecNetworkConfig? NetworkConfig { get; set; }

    /// <summary>Immutable. The relative resource name of the VPC network on which the instance can be accessed.</summary>
    [JsonPropertyName("networkRef")]
    public V1alpha1MetastoreServiceSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>The TCP port at which the metastore service is reached. Default: 9083.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1MetastoreServiceSpecProjectRef? ProjectRef { get; set; }

    /// <summary>Immutable. The release channel of the service. If unspecified, defaults to `STABLE`.</summary>
    [JsonPropertyName("releaseChannel")]
    public V1alpha1MetastoreServiceSpecReleaseChannelEnum? ReleaseChannel { get; set; }

    /// <summary>The MetastoreService name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Scaling configuration of the metastore service.</summary>
    [JsonPropertyName("scalingConfig")]
    public V1alpha1MetastoreServiceSpecScalingConfig? ScalingConfig { get; set; }

    /// <summary>The configuration specifying telemetry settings for the Dataproc Metastore service. If unspecified defaults to `JSON`.</summary>
    [JsonPropertyName("telemetryConfig")]
    public V1alpha1MetastoreServiceSpecTelemetryConfig? TelemetryConfig { get; set; }

    /// <summary>The tier of the service.</summary>
    [JsonPropertyName("tier")]
    public V1alpha1MetastoreServiceSpecTierEnum? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceStatusObservedStateMetadataManagementActivityMetadataExports
{
    /// <summary>Output only. The type of the database dump.</summary>
    [JsonPropertyName("databaseDumpType")]
    public string? DatabaseDumpType { get; set; }

    /// <summary>Output only. A Cloud Storage URI of a folder that metadata are exported to, in the form of `gs://&lt;bucket_name&gt;/&lt;path_inside_bucket&gt;/&lt;export_folder&gt;`, where `&lt;export_folder&gt;` is automatically generated.</summary>
    [JsonPropertyName("destinationGCSURI")]
    public string? DestinationGCSURI { get; set; }

    /// <summary>Output only. The time when the export ended.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Output only. The time when the export started.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Output only. The current state of the export.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceStatusObservedStateMetadataManagementActivityRestores
{
    /// <summary>
    /// Output only. The relative resource name of the metastore service backup to
    ///  restore from, in the following form:
    /// 
    ///  `projects/{project_id}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
    /// </summary>
    [JsonPropertyName("backup")]
    public string? Backup { get; set; }

    /// <summary>Output only. The restore details containing the revision of the service to be restored to, in format of JSON.</summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary>Output only. The time when the restore ended.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Output only. The time when the restore started.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Output only. The current state of the restore.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The type of restore.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Output only. The metadata management activities of the metastore service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceStatusObservedStateMetadataManagementActivity
{
    /// <summary>Output only. The latest metadata exports of the metastore service.</summary>
    [JsonPropertyName("metadataExports")]
    public IList<V1alpha1MetastoreServiceStatusObservedStateMetadataManagementActivityMetadataExports>? MetadataExports { get; set; }

    /// <summary>Output only. The latest restores of the metastore service.</summary>
    [JsonPropertyName("restores")]
    public IList<V1alpha1MetastoreServiceStatusObservedStateMetadataManagementActivityRestores>? Restores { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceStatusObservedStateNetworkConfigConsumers
{
    /// <summary>Output only. The location of the endpoint URI. Format: `projects/{project}/locations/{location}`.</summary>
    [JsonPropertyName("endpointLocation")]
    public string? EndpointLocation { get; set; }

    /// <summary>Output only. The URI of the endpoint used to access the metastore service.</summary>
    [JsonPropertyName("endpointURI")]
    public string? EndpointURI { get; set; }
}

/// <summary>The configuration specifying the network settings for the Dataproc Metastore service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceStatusObservedStateNetworkConfig
{
    /// <summary>Immutable. The consumer-side network configuration for the Dataproc Metastore instance.</summary>
    [JsonPropertyName("consumers")]
    public IList<V1alpha1MetastoreServiceStatusObservedStateNetworkConfigConsumers>? Consumers { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceStatusObservedState
{
    /// <summary>Output only. A Cloud Storage URI (starting with `gs://`) that specifies where artifacts related to the metastore service are stored.</summary>
    [JsonPropertyName("artifactGCSURI")]
    public string? ArtifactGCSURI { get; set; }

    /// <summary>Output only. The time when the metastore service was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The URI of the endpoint used to access the metastore service.</summary>
    [JsonPropertyName("endpointURI")]
    public string? EndpointURI { get; set; }

    /// <summary>Output only. The metadata management activities of the metastore service.</summary>
    [JsonPropertyName("metadataManagementActivity")]
    public V1alpha1MetastoreServiceStatusObservedStateMetadataManagementActivity? MetadataManagementActivity { get; set; }

    /// <summary>The configuration specifying the network settings for the Dataproc Metastore service.</summary>
    [JsonPropertyName("networkConfig")]
    public V1alpha1MetastoreServiceStatusObservedStateNetworkConfig? NetworkConfig { get; set; }

    /// <summary>Output only. The current state of the metastore service.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Additional information about the current state of the metastore service, if available.</summary>
    [JsonPropertyName("stateMessage")]
    public string? StateMessage { get; set; }

    /// <summary>Output only. The globally unique resource identifier of the metastore service.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The time when the metastore service was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>MetastoreServiceStatus defines the config connector machine state of MetastoreService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetastoreServiceStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MetastoreServiceStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the MetastoreService resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1MetastoreServiceStatusObservedState? ObservedState { get; set; }
}

/// <summary>MetastoreService is the Schema for the MetastoreService API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MetastoreService : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MetastoreServiceSpec>, IStatus<V1alpha1MetastoreServiceStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MetastoreService";
    public const string KubeGroup = "metastore.cnrm.cloud.google.com";
    public const string KubePluralName = "metastoreservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "metastore.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetastoreService";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MetastoreServiceSpec defines the desired state of MetastoreService</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1MetastoreServiceSpec Spec { get; set; }

    /// <summary>MetastoreServiceStatus defines the config connector machine state of MetastoreService</summary>
    [JsonPropertyName("status")]
    public V1alpha1MetastoreServiceStatus? Status { get; set; }
}
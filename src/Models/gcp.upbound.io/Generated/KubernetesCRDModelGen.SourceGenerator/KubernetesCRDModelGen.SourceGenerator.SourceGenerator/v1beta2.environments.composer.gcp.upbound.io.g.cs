#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.composer.gcp.upbound.io;
/// <summary>Environment is the Schema for the Environments API. An environment for running orchestration tasks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2EnvironmentList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Environment>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "EnvironmentList";
    public const string KubeGroup = "composer.gcp.upbound.io";
    public const string KubePluralName = "environments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "composer.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EnvironmentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Environment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Environment> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecDeletionPolicyEnum>))]
public enum V1beta2EnvironmentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigDataRetentionConfigAirflowMetadataRetentionConfig
{
    /// <summary>How many days data should be retained for.</summary>
    [JsonPropertyName("retentionDays")]
    public double? RetentionDays { get; set; }

    /// <summary>
    /// Retention can be either enabled or disabled. Values for retention_mode are
    /// RETENTION_MODE_ENABLED to enable retention and RETENTION_MODE_DISABLED
    /// to disable retention.
    /// </summary>
    [JsonPropertyName("retentionMode")]
    public string? RetentionMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigDataRetentionConfigTaskLogsRetentionConfig
{
    /// <summary>
    /// The mode of storage for Airflow workers task logs. Values for storage mode are
    /// CLOUD_LOGGING_ONLY to only store logs in cloud logging and
    /// CLOUD_LOGGING_AND_CLOUD_STORAGE to store logs in cloud logging and cloud storage.
    /// </summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }
}

/// <summary>
/// Configuration setting for airflow data rentention mechanism. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigDataRetentionConfig
{
    /// <summary>
    /// The retention policy for airflow metadata database. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("airflowMetadataRetentionConfig")]
    public IList<V1beta2EnvironmentSpecForProviderConfigDataRetentionConfigAirflowMetadataRetentionConfig>? AirflowMetadataRetentionConfig { get; set; }

    /// <summary>
    /// The configuration setting for Task Logs. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("taskLogsRetentionConfig")]
    public IList<V1beta2EnvironmentSpecForProviderConfigDataRetentionConfigTaskLogsRetentionConfig>? TaskLogsRetentionConfig { get; set; }
}

/// <summary>
/// The configuration settings for Cloud SQL instance used internally
/// by Apache Airflow software.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigDatabaseConfig
{
    /// <summary>
    /// Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2,
    /// composer-n1-webserver-4 or composer-n1-webserver-8.
    /// Value custom is returned only in response, if Airflow web server parameters were
    /// manually changed to a non-standard values.
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// The Compute Engine zone in which to deploy the VMs running the
    /// Apache Airflow software, specified as the zone name or
    /// relative resource name (e.g. &quot;projects/{project}/zones/{zone}&quot;). Must
    /// belong to the enclosing environment&apos;s project and region.
    /// </summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>
/// The encryption options for the Cloud Composer environment and its
/// dependencies.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigEncryptionConfig
{
    /// <summary>
    /// Customer-managed Encryption Key available through Google&apos;s Key Management Service. It must
    /// be the fully qualified resource name,
    /// i.e. projects/project-id/locations/location/keyRings/keyring/cryptoKeys/key. Cannot be updated.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>The configuration settings for Cloud Composer maintenance windows.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigMaintenanceWindow
{
    /// <summary>
    /// Maintenance window end time. It is used only to calculate the duration of the maintenance window.
    /// The value for end-time must be in the future, relative to &apos;start_time&apos;.
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// Maintenance window recurrence. Format is a subset of RFC-5545 (https://tools.ietf.org/html/rfc5545) &apos;RRULE&apos;.
    /// The only allowed values for &apos;FREQ&apos; field are &apos;FREQ=DAILY&apos; and &apos;FREQ=WEEKLY;BYDAY=...&apos;.
    /// Example values: &apos;FREQ=WEEKLY;BYDAY=TU,WE&apos;, &apos;FREQ=DAILY&apos;.
    /// </summary>
    [JsonPropertyName("recurrence")]
    public string? Recurrence { get; set; }

    /// <summary>Start time of the first recurrence of the maintenance window.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigMasterAuthorizedNetworksConfigCidrBlocks
{
    /// <summary>cidr_block must be specified in CIDR notation.</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>display_name is a field for users to identify CIDR blocks.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}

/// <summary>
/// Configuration options for the master authorized networks feature. Enabled
/// master authorized networks will disallow all external traffic to access
/// Kubernetes master through HTTPS except traffic from the given CIDR blocks,
/// Google Compute Engine Public IPs and Google Prod IPs. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigMasterAuthorizedNetworksConfig
{
    /// <summary>cidr_blocks define up to 50 external networks that could access Kubernetes master through HTTPS. Structure is documented below.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<V1beta2EnvironmentSpecForProviderConfigMasterAuthorizedNetworksConfigCidrBlocks>? CidrBlocks { get; set; }

    /// <summary>When enabled, Cloud Composer periodically saves snapshots of your environment to a Cloud Storage bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Configuration for controlling how IPs are allocated in the GKE cluster.
/// Structure is documented below.
/// Cannot be updated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigNodeConfigIpAllocationPolicy
{
    /// <summary>
    /// The IP address range used to allocate IP addresses to pods in the cluster.
    /// For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true.
    /// Set to blank to have GKE choose a range with the default size.
    /// Set to /netmask (e.g. /14) to have GKE choose a range with a specific netmask.
    /// Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks
    /// (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.
    /// Specify either cluster_secondary_range_name or cluster_ipv4_cidr_block but not both.
    /// </summary>
    [JsonPropertyName("clusterIpv4CidrBlock")]
    public string? ClusterIpv4CidrBlock { get; set; }

    /// <summary>
    /// The name of the cluster&apos;s secondary range used to allocate IP addresses to pods.
    /// Specify either cluster_secondary_range_name or cluster_ipv4_cidr_block but not both.
    /// For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true.
    /// </summary>
    [JsonPropertyName("clusterSecondaryRangeName")]
    public string? ClusterSecondaryRangeName { get; set; }

    /// <summary>
    /// The IP address range used to allocate IP addresses in this cluster.
    /// For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true.
    /// Set to blank to have GKE choose a range with the default size.
    /// Set to /netmask (e.g. /14) to have GKE choose a range with a specific netmask.
    /// Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks
    /// (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.
    /// Specify either services_secondary_range_name or services_ipv4_cidr_block but not both.
    /// </summary>
    [JsonPropertyName("servicesIpv4CidrBlock")]
    public string? ServicesIpv4CidrBlock { get; set; }

    /// <summary>
    /// The name of the services&apos; secondary range used to allocate IP addresses to the cluster.
    /// Specify either services_secondary_range_name or services_ipv4_cidr_block but not both.
    /// For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true.
    /// </summary>
    [JsonPropertyName("servicesSecondaryRangeName")]
    public string? ServicesSecondaryRangeName { get; set; }

    /// <summary>
    /// Whether or not to enable Alias IPs in the GKE cluster. If true, a VPC-native cluster is created.
    /// Defaults to true if the ip_allocation_policy block is present in config.
    /// </summary>
    [JsonPropertyName("useIpAliases")]
    public bool? UseIpAliases { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkRefPolicyResolutionEnum>))]
public enum V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkRefPolicyResolveEnum>))]
public enum V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkSelectorPolicyResolveEnum>))]
public enum V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountRefPolicyResolutionEnum>))]
public enum V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountRefPolicyResolveEnum>))]
public enum V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelectorPolicyResolutionEnum>))]
public enum V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelectorPolicyResolveEnum>))]
public enum V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkRefPolicyResolutionEnum>))]
public enum V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkRefPolicyResolveEnum>))]
public enum V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelectorPolicyResolveEnum>))]
public enum V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>The configuration used for the Kubernetes Engine cluster.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigNodeConfig
{
    /// <summary>
    /// /20 IPv4 cidr range that will be used by Composer internal components.
    /// Cannot be updated.
    /// </summary>
    [JsonPropertyName("composerInternalIpv4CidrBlock")]
    public string? ComposerInternalIpv4CidrBlock { get; set; }

    /// <summary>
    /// PSC (Private Service Connect) Network entry point. Customers can pre-create the Network Attachment
    /// and point Cloud Composer environment to use. It is possible to share network attachment among many environments,
    /// provided enough IP addresses are available.
    /// </summary>
    [JsonPropertyName("composerNetworkAttachment")]
    public string? ComposerNetworkAttachment { get; set; }

    /// <summary>
    /// The disk size in GB used for node VMs. Minimum size is 20GB.
    /// If unspecified, defaults to 100GB. Cannot be updated.
    /// </summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>
    /// Deploys &apos;ip-masq-agent&apos; daemon set in the GKE cluster and defines
    /// nonMasqueradeCIDRs equals to pod IP range so IP masquerading is used for
    /// all destination addresses, except between pods traffic.
    /// See the documentation.
    /// </summary>
    [JsonPropertyName("enableIpMasqAgent")]
    public bool? EnableIpMasqAgent { get; set; }

    /// <summary>
    /// Configuration for controlling how IPs are allocated in the GKE cluster.
    /// Structure is documented below.
    /// Cannot be updated.
    /// </summary>
    [JsonPropertyName("ipAllocationPolicy")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigIpAllocationPolicy? IpAllocationPolicy { get; set; }

    /// <summary>
    /// Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2,
    /// composer-n1-webserver-4 or composer-n1-webserver-8.
    /// Value custom is returned only in response, if Airflow web server parameters were
    /// manually changed to a non-standard values.
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// The Compute Engine network to be used for machine
    /// communications, specified as a self-link, relative resource name
    /// (for example &quot;projects/{project}/global/networks/{network}&quot;), by name.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigNetworkSelector? NetworkSelector { get; set; }

    /// <summary>
    /// The set of Google API scopes to be made available on all node
    /// VMs. Cannot be updated. If empty, defaults to
    /// [&quot;https://www.googleapis.com/auth/cloud-platform&quot;].
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the
    /// node VMs. If a service account is not specified, the &quot;default&quot;
    /// Compute Engine service account is used. Cannot be updated. If given,
    /// note that the service account must have roles/composer.worker
    /// for any GCP resources created under the Cloud Composer Environment.
    /// </summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>
    /// The Compute Engine subnetwork to be used for machine
    /// communications, specified as a self-link, relative resource name (for example,
    /// &quot;projects/{project}/regions/{region}/subnetworks/{subnetwork}&quot;), or by name. If subnetwork is provided,
    /// network must also be provided and the subnetwork must belong to the enclosing environment&apos;s project and region.
    /// </summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfigSubnetworkSelector? SubnetworkSelector { get; set; }

    /// <summary>
    /// The list of instance tags applied to all node VMs. Tags are
    /// used to identify valid sources or targets for network
    /// firewalls. Each tag within the list must comply with RFC1035.
    /// Cannot be updated.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>
    /// The Compute Engine zone in which to deploy the VMs running the
    /// Apache Airflow software, specified as the zone name or
    /// relative resource name (e.g. &quot;projects/{project}/zones/{zone}&quot;). Must
    /// belong to the enclosing environment&apos;s project and region.
    /// </summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>The configuration used for the Private IP Cloud Composer environment. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigPrivateEnvironmentConfig
{
    /// <summary>
    /// When specified, the environment will use Private Service Connect instead of VPC peerings to connect
    /// to Cloud SQL in the Tenant Project, and the PSC endpoint in the Customer Project will use an IP
    /// address from this subnetwork. This field is supported for Cloud Composer environments in
    /// versions composer-2.*.*-airflow-*.*.* and newer.
    /// </summary>
    [JsonPropertyName("cloudComposerConnectionSubnetwork")]
    public string? CloudComposerConnectionSubnetwork { get; set; }

    [JsonPropertyName("cloudComposerNetworkIpv4CidrBlock")]
    public string? CloudComposerNetworkIpv4CidrBlock { get; set; }

    /// <summary>The CIDR block from which IP range in tenant project will be reserved for Cloud SQL. Needs to be disjoint from web_server_ipv4_cidr_block</summary>
    [JsonPropertyName("cloudSqlIpv4CidrBlock")]
    public string? CloudSqlIpv4CidrBlock { get; set; }

    /// <summary>
    /// Mode of internal communication within the Composer environment. Must be one
    /// of &quot;VPC_PEERING&quot; or &quot;PRIVATE_SERVICE_CONNECT&quot;.
    /// </summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>
    /// If true, access to the public endpoint of the GKE cluster is denied.
    /// If this field is set to true, the ip_allocation_policy.use_ip_aliases field must
    /// also be set to true for Cloud Composer 1 environments.
    /// </summary>
    [JsonPropertyName("enablePrivateEndpoint")]
    public bool? EnablePrivateEndpoint { get; set; }

    /// <summary>
    /// When enabled, IPs from public (non-RFC1918) ranges can be used for
    /// ip_allocation_policy.cluster_ipv4_cidr_block and ip_allocation_policy.service_ipv4_cidr_block.
    /// </summary>
    [JsonPropertyName("enablePrivatelyUsedPublicIps")]
    public bool? EnablePrivatelyUsedPublicIps { get; set; }

    /// <summary>
    /// The IP range in CIDR notation to use for the hosted master network. This range is used
    /// for assigning internal IP addresses to the cluster master or set of masters and to the
    /// internal load balancer virtual IP. This range must not overlap with any other ranges
    /// in use within the cluster&apos;s network.
    /// If left blank, the default value of is used. See documentation for default values per region.
    /// </summary>
    [JsonPropertyName("masterIpv4CidrBlock")]
    public string? MasterIpv4CidrBlock { get; set; }

    /// <summary>The CIDR block from which IP range for web server will be reserved. Needs to be disjoint from master_ipv4_cidr_block and cloud_sql_ipv4_cidr_block.</summary>
    [JsonPropertyName("webServerIpv4CidrBlock")]
    public string? WebServerIpv4CidrBlock { get; set; }
}

/// <summary>The recovery configuration settings for the Cloud Composer environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigRecoveryConfigScheduledSnapshotsConfig
{
    /// <summary>When enabled, Cloud Composer periodically saves snapshots of your environment to a Cloud Storage bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Snapshot schedule, in the unix-cron format.</summary>
    [JsonPropertyName("snapshotCreationSchedule")]
    public string? SnapshotCreationSchedule { get; set; }

    /// <summary>The URI of a bucket folder where to save the snapshot.</summary>
    [JsonPropertyName("snapshotLocation")]
    public string? SnapshotLocation { get; set; }

    /// <summary>A time zone for the schedule. This value is a time offset and does not take into account daylight saving time changes. Valid values are from UTC-12 to UTC+12. Examples: UTC, UTC-01, UTC+03.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>The configuration settings for recovery. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigRecoveryConfig
{
    /// <summary>The recovery configuration settings for the Cloud Composer environment.</summary>
    [JsonPropertyName("scheduledSnapshotsConfig")]
    public V1beta2EnvironmentSpecForProviderConfigRecoveryConfigScheduledSnapshotsConfig? ScheduledSnapshotsConfig { get; set; }
}

/// <summary>
/// The configuration for Cloud Data Lineage integration. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigSoftwareConfigCloudDataLineageIntegration
{
    /// <summary>When enabled, Cloud Composer periodically saves snapshots of your environment to a Cloud Storage bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The configuration settings for software inside the environment.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigSoftwareConfig
{
    /// <summary>
    /// Apache Airflow configuration properties to override. Property keys contain the section and property names,
    /// separated by a hyphen, for example &quot;core-dags_are_paused_at_creation&quot;.
    /// </summary>
    [JsonPropertyName("airflowConfigOverrides")]
    public IDictionary<string, string>? AirflowConfigOverrides { get; set; }

    /// <summary>
    /// The configuration for Cloud Data Lineage integration. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("cloudDataLineageIntegration")]
    public V1beta2EnvironmentSpecForProviderConfigSoftwareConfigCloudDataLineageIntegration? CloudDataLineageIntegration { get; set; }

    /// <summary>
    /// Additional environment variables to provide to the Apache Airflow scheduler, worker, and webserver processes.
    /// Environment variable names must match the regular expression [a-zA-Z_][a-zA-Z0-9_]*.
    /// They cannot specify Apache Airflow software configuration overrides (they cannot match the regular expression
    /// AIRFLOW__[A-Z0-9_]+__[A-Z0-9_]+), and they cannot match any of the following reserved names:
    /// </summary>
    [JsonPropertyName("envVariables")]
    public IDictionary<string, string>? EnvVariables { get; set; }

    /// <summary>In Composer 1, use a specific Composer 1 version in this parameter. If omitted, the default is the latest version of Composer 2.</summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>
    /// Custom Python Package Index (PyPI) packages to be installed
    /// in the environment. Keys refer to the lowercase package name (e.g. &quot;numpy&quot;). Values are the lowercase extras and
    /// version specifier (e.g. &quot;==1.12.0&quot;, &quot;[devel,gcp_api]&quot;, &quot;[devel]&gt;=1.8.2, &lt;1.9.2&quot;). To specify a package without
    /// pinning it to a version specifier, use the empty string as the value.
    /// </summary>
    [JsonPropertyName("pypiPackages")]
    public IDictionary<string, string>? PypiPackages { get; set; }

    /// <summary>
    /// The major version of Python used to run the Apache Airflow scheduler, worker, and webserver processes.
    /// Can be set to &apos;2&apos; or &apos;3&apos;. If not specified, the default is &apos;3&apos;.
    /// </summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>The number of schedulers for Airflow.</summary>
    [JsonPropertyName("schedulerCount")]
    public double? SchedulerCount { get; set; }

    /// <summary>Web server plugins configuration. Can be either &apos;ENABLED&apos; or &apos;DISABLED&apos;. Defaults to &apos;ENABLED&apos;.</summary>
    [JsonPropertyName("webServerPluginsMode")]
    public string? WebServerPluginsMode { get; set; }
}

/// <summary>The configuration settings for the Airflow web server App Engine instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigWebServerConfig
{
    /// <summary>
    /// Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2,
    /// composer-n1-webserver-4 or composer-n1-webserver-8.
    /// Value custom is returned only in response, if Airflow web server parameters were
    /// manually changed to a non-standard values.
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigWebServerNetworkAccessControlAllowedIpRange
{
    /// <summary>A description of this ip range.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// IP address or range, defined using CIDR notation, of requests that this rule applies to.
    /// Examples: 192.168.1.1 or 192.168.0.0/16 or 2001:db8::/32 or 2001:0db8:0000:0042:0000:8a2e:0370:7334.
    /// IP range prefixes should be properly truncated. For example,
    /// 1.2.3.4/24 should be truncated to 1.2.3.0/24. Similarly, for IPv6, 2001:db8::1/32 should be truncated to 2001:db8::/32.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The network-level access control policy for the Airflow web server.
/// If unspecified, no network-level access restrictions are applied.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigWebServerNetworkAccessControl
{
    /// <summary>A collection of allowed IP ranges with descriptions. Structure is documented below.</summary>
    [JsonPropertyName("allowedIpRange")]
    public IList<V1beta2EnvironmentSpecForProviderConfigWebServerNetworkAccessControlAllowedIpRange>? AllowedIpRange { get; set; }
}

/// <summary>Configuration for resources used by DAG processor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigWorkloadsConfigDagProcessor
{
    /// <summary>The number of Airflow triggerers.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>The amount of storage (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

/// <summary>Configuration for resources used by Airflow schedulers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigWorkloadsConfigScheduler
{
    /// <summary>The number of Airflow triggerers.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>The amount of storage (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

/// <summary>Configuration for resources used by Airflow triggerer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigWorkloadsConfigTriggerer
{
    /// <summary>The number of Airflow triggerers.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }
}

/// <summary>Configuration for resources used by Airflow web server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigWorkloadsConfigWebServer
{
    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>The amount of storage (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

/// <summary>Configuration for resources used by Airflow workers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigWorkloadsConfigWorker
{
    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>
    /// The maximum number of Airflow workers that the environment can run. The number of workers in the
    /// environment does not go above this number, even if a higher number of workers is required to
    /// handle the load.
    /// </summary>
    [JsonPropertyName("maxCount")]
    public double? MaxCount { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>
    /// The minimum number of Airflow workers that the environment can run. The number of workers in the
    /// environment does not go below this number, even if a lower number of workers can handle the load.
    /// </summary>
    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    /// <summary>The amount of storage (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

/// <summary>
/// The Kubernetes workloads configuration for GKE cluster associated with the
/// Cloud Composer environment.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfigWorkloadsConfig
{
    /// <summary>Configuration for resources used by DAG processor.</summary>
    [JsonPropertyName("dagProcessor")]
    public V1beta2EnvironmentSpecForProviderConfigWorkloadsConfigDagProcessor? DagProcessor { get; set; }

    /// <summary>Configuration for resources used by Airflow schedulers.</summary>
    [JsonPropertyName("scheduler")]
    public V1beta2EnvironmentSpecForProviderConfigWorkloadsConfigScheduler? Scheduler { get; set; }

    /// <summary>Configuration for resources used by Airflow triggerer.</summary>
    [JsonPropertyName("triggerer")]
    public V1beta2EnvironmentSpecForProviderConfigWorkloadsConfigTriggerer? Triggerer { get; set; }

    /// <summary>Configuration for resources used by Airflow web server.</summary>
    [JsonPropertyName("webServer")]
    public V1beta2EnvironmentSpecForProviderConfigWorkloadsConfigWebServer? WebServer { get; set; }

    /// <summary>Configuration for resources used by Airflow workers.</summary>
    [JsonPropertyName("worker")]
    public V1beta2EnvironmentSpecForProviderConfigWorkloadsConfigWorker? Worker { get; set; }
}

/// <summary>Configuration parameters for this environment  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderConfig
{
    /// <summary>
    /// Configuration setting for airflow data rentention mechanism. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("dataRetentionConfig")]
    public V1beta2EnvironmentSpecForProviderConfigDataRetentionConfig? DataRetentionConfig { get; set; }

    /// <summary>
    /// The configuration settings for Cloud SQL instance used internally
    /// by Apache Airflow software.
    /// </summary>
    [JsonPropertyName("databaseConfig")]
    public V1beta2EnvironmentSpecForProviderConfigDatabaseConfig? DatabaseConfig { get; set; }

    /// <summary>
    /// If true, builds performed during operations that install Python packages have only private connectivity to Google services.
    /// If false, the builds also have access to the internet.
    /// </summary>
    [JsonPropertyName("enablePrivateBuildsOnly")]
    public bool? EnablePrivateBuildsOnly { get; set; }

    /// <summary>If true, a private Composer environment will be created.</summary>
    [JsonPropertyName("enablePrivateEnvironment")]
    public bool? EnablePrivateEnvironment { get; set; }

    /// <summary>
    /// The encryption options for the Cloud Composer environment and its
    /// dependencies.
    /// </summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta2EnvironmentSpecForProviderConfigEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>
    /// The environment size controls the performance parameters of the managed
    /// Cloud Composer infrastructure that includes the Airflow database. Values for
    /// environment size are ENVIRONMENT_SIZE_SMALL, ENVIRONMENT_SIZE_MEDIUM,
    /// and ENVIRONMENT_SIZE_LARGE.
    /// </summary>
    [JsonPropertyName("environmentSize")]
    public string? EnvironmentSize { get; set; }

    /// <summary>The configuration settings for Cloud Composer maintenance windows.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta2EnvironmentSpecForProviderConfigMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>
    /// Configuration options for the master authorized networks feature. Enabled
    /// master authorized networks will disallow all external traffic to access
    /// Kubernetes master through HTTPS except traffic from the given CIDR blocks,
    /// Google Compute Engine Public IPs and Google Prod IPs. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("masterAuthorizedNetworksConfig")]
    public V1beta2EnvironmentSpecForProviderConfigMasterAuthorizedNetworksConfig? MasterAuthorizedNetworksConfig { get; set; }

    /// <summary>The configuration used for the Kubernetes Engine cluster.  Structure is documented below.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta2EnvironmentSpecForProviderConfigNodeConfig? NodeConfig { get; set; }

    /// <summary>The number of nodes in the Kubernetes Engine cluster of the environment.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The configuration used for the Private IP Cloud Composer environment. Structure is documented below.</summary>
    [JsonPropertyName("privateEnvironmentConfig")]
    public V1beta2EnvironmentSpecForProviderConfigPrivateEnvironmentConfig? PrivateEnvironmentConfig { get; set; }

    /// <summary>The configuration settings for recovery. Structure is documented below.</summary>
    [JsonPropertyName("recoveryConfig")]
    public V1beta2EnvironmentSpecForProviderConfigRecoveryConfig? RecoveryConfig { get; set; }

    /// <summary>
    /// The resilience mode states whether high resilience is enabled for
    /// the environment or not. Values for resilience mode are HIGH_RESILIENCE
    /// for high resilience and STANDARD_RESILIENCE for standard
    /// resilience.
    /// </summary>
    [JsonPropertyName("resilienceMode")]
    public string? ResilienceMode { get; set; }

    /// <summary>The configuration settings for software inside the environment.  Structure is documented below.</summary>
    [JsonPropertyName("softwareConfig")]
    public V1beta2EnvironmentSpecForProviderConfigSoftwareConfig? SoftwareConfig { get; set; }

    /// <summary>The configuration settings for the Airflow web server App Engine instance.</summary>
    [JsonPropertyName("webServerConfig")]
    public V1beta2EnvironmentSpecForProviderConfigWebServerConfig? WebServerConfig { get; set; }

    /// <summary>
    /// The network-level access control policy for the Airflow web server.
    /// If unspecified, no network-level access restrictions are applied.
    /// </summary>
    [JsonPropertyName("webServerNetworkAccessControl")]
    public V1beta2EnvironmentSpecForProviderConfigWebServerNetworkAccessControl? WebServerNetworkAccessControl { get; set; }

    /// <summary>
    /// The Kubernetes workloads configuration for GKE cluster associated with the
    /// Cloud Composer environment.
    /// </summary>
    [JsonPropertyName("workloadsConfig")]
    public V1beta2EnvironmentSpecForProviderConfigWorkloadsConfig? WorkloadsConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecForProviderProjectRefPolicyResolutionEnum>))]
public enum V1beta2EnvironmentSpecForProviderProjectRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecForProviderProjectRefPolicyResolveEnum>))]
public enum V1beta2EnvironmentSpecForProviderProjectRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderProjectRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EnvironmentSpecForProviderProjectRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EnvironmentSpecForProviderProjectRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderProjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EnvironmentSpecForProviderProjectRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecForProviderProjectSelectorPolicyResolutionEnum>))]
public enum V1beta2EnvironmentSpecForProviderProjectSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecForProviderProjectSelectorPolicyResolveEnum>))]
public enum V1beta2EnvironmentSpecForProviderProjectSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderProjectSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EnvironmentSpecForProviderProjectSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EnvironmentSpecForProviderProjectSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderProjectSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EnvironmentSpecForProviderProjectSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration options for storage used by Composer environment. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProviderStorageConfig
{
    /// <summary>Name of an existing Cloud Storage bucket to be used by the environment.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecForProvider
{
    /// <summary>Configuration parameters for this environment  Structure is documented below.</summary>
    [JsonPropertyName("config")]
    public V1beta2EnvironmentSpecForProviderConfig? Config { get; set; }

    /// <summary>
    /// User-defined labels for this environment. The labels map can contain
    /// no more than 64 entries. Entries of the labels map are UTF8 strings
    /// that comply with the following restrictions:
    /// Label keys must be between 1 and 63 characters long and must conform
    /// to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?.
    /// Label values must be between 0 and 63 characters long and must
    /// conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?.
    /// No more than 64 labels can be associated with a given environment.
    /// Both keys and values must be &lt;= 128 bytes in size.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta2EnvironmentSpecForProviderProjectRef? ProjectRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectSelector")]
    public V1beta2EnvironmentSpecForProviderProjectSelector? ProjectSelector { get; set; }

    /// <summary>The location or Compute Engine region for the environment.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Configuration options for storage used by Composer environment. Structure is documented below.</summary>
    [JsonPropertyName("storageConfig")]
    public V1beta2EnvironmentSpecForProviderStorageConfig? StorageConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigDataRetentionConfigAirflowMetadataRetentionConfig
{
    /// <summary>How many days data should be retained for.</summary>
    [JsonPropertyName("retentionDays")]
    public double? RetentionDays { get; set; }

    /// <summary>
    /// Retention can be either enabled or disabled. Values for retention_mode are
    /// RETENTION_MODE_ENABLED to enable retention and RETENTION_MODE_DISABLED
    /// to disable retention.
    /// </summary>
    [JsonPropertyName("retentionMode")]
    public string? RetentionMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigDataRetentionConfigTaskLogsRetentionConfig
{
    /// <summary>
    /// The mode of storage for Airflow workers task logs. Values for storage mode are
    /// CLOUD_LOGGING_ONLY to only store logs in cloud logging and
    /// CLOUD_LOGGING_AND_CLOUD_STORAGE to store logs in cloud logging and cloud storage.
    /// </summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }
}

/// <summary>
/// Configuration setting for airflow data rentention mechanism. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigDataRetentionConfig
{
    /// <summary>
    /// The retention policy for airflow metadata database. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("airflowMetadataRetentionConfig")]
    public IList<V1beta2EnvironmentSpecInitProviderConfigDataRetentionConfigAirflowMetadataRetentionConfig>? AirflowMetadataRetentionConfig { get; set; }

    /// <summary>
    /// The configuration setting for Task Logs. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("taskLogsRetentionConfig")]
    public IList<V1beta2EnvironmentSpecInitProviderConfigDataRetentionConfigTaskLogsRetentionConfig>? TaskLogsRetentionConfig { get; set; }
}

/// <summary>
/// The configuration settings for Cloud SQL instance used internally
/// by Apache Airflow software.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigDatabaseConfig
{
    /// <summary>
    /// Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2,
    /// composer-n1-webserver-4 or composer-n1-webserver-8.
    /// Value custom is returned only in response, if Airflow web server parameters were
    /// manually changed to a non-standard values.
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// The Compute Engine zone in which to deploy the VMs running the
    /// Apache Airflow software, specified as the zone name or
    /// relative resource name (e.g. &quot;projects/{project}/zones/{zone}&quot;). Must
    /// belong to the enclosing environment&apos;s project and region.
    /// </summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>
/// The encryption options for the Cloud Composer environment and its
/// dependencies.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigEncryptionConfig
{
    /// <summary>
    /// Customer-managed Encryption Key available through Google&apos;s Key Management Service. It must
    /// be the fully qualified resource name,
    /// i.e. projects/project-id/locations/location/keyRings/keyring/cryptoKeys/key. Cannot be updated.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>The configuration settings for Cloud Composer maintenance windows.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigMaintenanceWindow
{
    /// <summary>
    /// Maintenance window end time. It is used only to calculate the duration of the maintenance window.
    /// The value for end-time must be in the future, relative to &apos;start_time&apos;.
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// Maintenance window recurrence. Format is a subset of RFC-5545 (https://tools.ietf.org/html/rfc5545) &apos;RRULE&apos;.
    /// The only allowed values for &apos;FREQ&apos; field are &apos;FREQ=DAILY&apos; and &apos;FREQ=WEEKLY;BYDAY=...&apos;.
    /// Example values: &apos;FREQ=WEEKLY;BYDAY=TU,WE&apos;, &apos;FREQ=DAILY&apos;.
    /// </summary>
    [JsonPropertyName("recurrence")]
    public string? Recurrence { get; set; }

    /// <summary>Start time of the first recurrence of the maintenance window.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigMasterAuthorizedNetworksConfigCidrBlocks
{
    /// <summary>cidr_block must be specified in CIDR notation.</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>display_name is a field for users to identify CIDR blocks.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}

/// <summary>
/// Configuration options for the master authorized networks feature. Enabled
/// master authorized networks will disallow all external traffic to access
/// Kubernetes master through HTTPS except traffic from the given CIDR blocks,
/// Google Compute Engine Public IPs and Google Prod IPs. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigMasterAuthorizedNetworksConfig
{
    /// <summary>cidr_blocks define up to 50 external networks that could access Kubernetes master through HTTPS. Structure is documented below.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<V1beta2EnvironmentSpecInitProviderConfigMasterAuthorizedNetworksConfigCidrBlocks>? CidrBlocks { get; set; }

    /// <summary>When enabled, Cloud Composer periodically saves snapshots of your environment to a Cloud Storage bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Configuration for controlling how IPs are allocated in the GKE cluster.
/// Structure is documented below.
/// Cannot be updated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigNodeConfigIpAllocationPolicy
{
    /// <summary>
    /// The IP address range used to allocate IP addresses to pods in the cluster.
    /// For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true.
    /// Set to blank to have GKE choose a range with the default size.
    /// Set to /netmask (e.g. /14) to have GKE choose a range with a specific netmask.
    /// Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks
    /// (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.
    /// Specify either cluster_secondary_range_name or cluster_ipv4_cidr_block but not both.
    /// </summary>
    [JsonPropertyName("clusterIpv4CidrBlock")]
    public string? ClusterIpv4CidrBlock { get; set; }

    /// <summary>
    /// The name of the cluster&apos;s secondary range used to allocate IP addresses to pods.
    /// Specify either cluster_secondary_range_name or cluster_ipv4_cidr_block but not both.
    /// For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true.
    /// </summary>
    [JsonPropertyName("clusterSecondaryRangeName")]
    public string? ClusterSecondaryRangeName { get; set; }

    /// <summary>
    /// The IP address range used to allocate IP addresses in this cluster.
    /// For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true.
    /// Set to blank to have GKE choose a range with the default size.
    /// Set to /netmask (e.g. /14) to have GKE choose a range with a specific netmask.
    /// Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks
    /// (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.
    /// Specify either services_secondary_range_name or services_ipv4_cidr_block but not both.
    /// </summary>
    [JsonPropertyName("servicesIpv4CidrBlock")]
    public string? ServicesIpv4CidrBlock { get; set; }

    /// <summary>
    /// The name of the services&apos; secondary range used to allocate IP addresses to the cluster.
    /// Specify either services_secondary_range_name or services_ipv4_cidr_block but not both.
    /// For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true.
    /// </summary>
    [JsonPropertyName("servicesSecondaryRangeName")]
    public string? ServicesSecondaryRangeName { get; set; }

    /// <summary>
    /// Whether or not to enable Alias IPs in the GKE cluster. If true, a VPC-native cluster is created.
    /// Defaults to true if the ip_allocation_policy block is present in config.
    /// </summary>
    [JsonPropertyName("useIpAliases")]
    public bool? UseIpAliases { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkRefPolicyResolutionEnum>))]
public enum V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkRefPolicyResolveEnum>))]
public enum V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkSelectorPolicyResolveEnum>))]
public enum V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRefPolicyResolutionEnum>))]
public enum V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRefPolicyResolveEnum>))]
public enum V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelectorPolicyResolutionEnum>))]
public enum V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelectorPolicyResolveEnum>))]
public enum V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRefPolicyResolutionEnum>))]
public enum V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRefPolicyResolveEnum>))]
public enum V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelectorPolicyResolveEnum>))]
public enum V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>The configuration used for the Kubernetes Engine cluster.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigNodeConfig
{
    /// <summary>
    /// /20 IPv4 cidr range that will be used by Composer internal components.
    /// Cannot be updated.
    /// </summary>
    [JsonPropertyName("composerInternalIpv4CidrBlock")]
    public string? ComposerInternalIpv4CidrBlock { get; set; }

    /// <summary>
    /// PSC (Private Service Connect) Network entry point. Customers can pre-create the Network Attachment
    /// and point Cloud Composer environment to use. It is possible to share network attachment among many environments,
    /// provided enough IP addresses are available.
    /// </summary>
    [JsonPropertyName("composerNetworkAttachment")]
    public string? ComposerNetworkAttachment { get; set; }

    /// <summary>
    /// The disk size in GB used for node VMs. Minimum size is 20GB.
    /// If unspecified, defaults to 100GB. Cannot be updated.
    /// </summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>
    /// Deploys &apos;ip-masq-agent&apos; daemon set in the GKE cluster and defines
    /// nonMasqueradeCIDRs equals to pod IP range so IP masquerading is used for
    /// all destination addresses, except between pods traffic.
    /// See the documentation.
    /// </summary>
    [JsonPropertyName("enableIpMasqAgent")]
    public bool? EnableIpMasqAgent { get; set; }

    /// <summary>
    /// Configuration for controlling how IPs are allocated in the GKE cluster.
    /// Structure is documented below.
    /// Cannot be updated.
    /// </summary>
    [JsonPropertyName("ipAllocationPolicy")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigIpAllocationPolicy? IpAllocationPolicy { get; set; }

    /// <summary>
    /// Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2,
    /// composer-n1-webserver-4 or composer-n1-webserver-8.
    /// Value custom is returned only in response, if Airflow web server parameters were
    /// manually changed to a non-standard values.
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// The Compute Engine network to be used for machine
    /// communications, specified as a self-link, relative resource name
    /// (for example &quot;projects/{project}/global/networks/{network}&quot;), by name.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigNetworkSelector? NetworkSelector { get; set; }

    /// <summary>
    /// The set of Google API scopes to be made available on all node
    /// VMs. Cannot be updated. If empty, defaults to
    /// [&quot;https://www.googleapis.com/auth/cloud-platform&quot;].
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the
    /// node VMs. If a service account is not specified, the &quot;default&quot;
    /// Compute Engine service account is used. Cannot be updated. If given,
    /// note that the service account must have roles/composer.worker
    /// for any GCP resources created under the Cloud Composer Environment.
    /// </summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>
    /// The Compute Engine subnetwork to be used for machine
    /// communications, specified as a self-link, relative resource name (for example,
    /// &quot;projects/{project}/regions/{region}/subnetworks/{subnetwork}&quot;), or by name. If subnetwork is provided,
    /// network must also be provided and the subnetwork must belong to the enclosing environment&apos;s project and region.
    /// </summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfigSubnetworkSelector? SubnetworkSelector { get; set; }

    /// <summary>
    /// The list of instance tags applied to all node VMs. Tags are
    /// used to identify valid sources or targets for network
    /// firewalls. Each tag within the list must comply with RFC1035.
    /// Cannot be updated.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>
    /// The Compute Engine zone in which to deploy the VMs running the
    /// Apache Airflow software, specified as the zone name or
    /// relative resource name (e.g. &quot;projects/{project}/zones/{zone}&quot;). Must
    /// belong to the enclosing environment&apos;s project and region.
    /// </summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>The configuration used for the Private IP Cloud Composer environment. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigPrivateEnvironmentConfig
{
    /// <summary>
    /// When specified, the environment will use Private Service Connect instead of VPC peerings to connect
    /// to Cloud SQL in the Tenant Project, and the PSC endpoint in the Customer Project will use an IP
    /// address from this subnetwork. This field is supported for Cloud Composer environments in
    /// versions composer-2.*.*-airflow-*.*.* and newer.
    /// </summary>
    [JsonPropertyName("cloudComposerConnectionSubnetwork")]
    public string? CloudComposerConnectionSubnetwork { get; set; }

    [JsonPropertyName("cloudComposerNetworkIpv4CidrBlock")]
    public string? CloudComposerNetworkIpv4CidrBlock { get; set; }

    /// <summary>The CIDR block from which IP range in tenant project will be reserved for Cloud SQL. Needs to be disjoint from web_server_ipv4_cidr_block</summary>
    [JsonPropertyName("cloudSqlIpv4CidrBlock")]
    public string? CloudSqlIpv4CidrBlock { get; set; }

    /// <summary>
    /// Mode of internal communication within the Composer environment. Must be one
    /// of &quot;VPC_PEERING&quot; or &quot;PRIVATE_SERVICE_CONNECT&quot;.
    /// </summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>
    /// If true, access to the public endpoint of the GKE cluster is denied.
    /// If this field is set to true, the ip_allocation_policy.use_ip_aliases field must
    /// also be set to true for Cloud Composer 1 environments.
    /// </summary>
    [JsonPropertyName("enablePrivateEndpoint")]
    public bool? EnablePrivateEndpoint { get; set; }

    /// <summary>
    /// When enabled, IPs from public (non-RFC1918) ranges can be used for
    /// ip_allocation_policy.cluster_ipv4_cidr_block and ip_allocation_policy.service_ipv4_cidr_block.
    /// </summary>
    [JsonPropertyName("enablePrivatelyUsedPublicIps")]
    public bool? EnablePrivatelyUsedPublicIps { get; set; }

    /// <summary>
    /// The IP range in CIDR notation to use for the hosted master network. This range is used
    /// for assigning internal IP addresses to the cluster master or set of masters and to the
    /// internal load balancer virtual IP. This range must not overlap with any other ranges
    /// in use within the cluster&apos;s network.
    /// If left blank, the default value of is used. See documentation for default values per region.
    /// </summary>
    [JsonPropertyName("masterIpv4CidrBlock")]
    public string? MasterIpv4CidrBlock { get; set; }

    /// <summary>The CIDR block from which IP range for web server will be reserved. Needs to be disjoint from master_ipv4_cidr_block and cloud_sql_ipv4_cidr_block.</summary>
    [JsonPropertyName("webServerIpv4CidrBlock")]
    public string? WebServerIpv4CidrBlock { get; set; }
}

/// <summary>The recovery configuration settings for the Cloud Composer environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigRecoveryConfigScheduledSnapshotsConfig
{
    /// <summary>When enabled, Cloud Composer periodically saves snapshots of your environment to a Cloud Storage bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Snapshot schedule, in the unix-cron format.</summary>
    [JsonPropertyName("snapshotCreationSchedule")]
    public string? SnapshotCreationSchedule { get; set; }

    /// <summary>The URI of a bucket folder where to save the snapshot.</summary>
    [JsonPropertyName("snapshotLocation")]
    public string? SnapshotLocation { get; set; }

    /// <summary>A time zone for the schedule. This value is a time offset and does not take into account daylight saving time changes. Valid values are from UTC-12 to UTC+12. Examples: UTC, UTC-01, UTC+03.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>The configuration settings for recovery. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigRecoveryConfig
{
    /// <summary>The recovery configuration settings for the Cloud Composer environment.</summary>
    [JsonPropertyName("scheduledSnapshotsConfig")]
    public V1beta2EnvironmentSpecInitProviderConfigRecoveryConfigScheduledSnapshotsConfig? ScheduledSnapshotsConfig { get; set; }
}

/// <summary>
/// The configuration for Cloud Data Lineage integration. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigSoftwareConfigCloudDataLineageIntegration
{
    /// <summary>When enabled, Cloud Composer periodically saves snapshots of your environment to a Cloud Storage bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The configuration settings for software inside the environment.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigSoftwareConfig
{
    /// <summary>
    /// Apache Airflow configuration properties to override. Property keys contain the section and property names,
    /// separated by a hyphen, for example &quot;core-dags_are_paused_at_creation&quot;.
    /// </summary>
    [JsonPropertyName("airflowConfigOverrides")]
    public IDictionary<string, string>? AirflowConfigOverrides { get; set; }

    /// <summary>
    /// The configuration for Cloud Data Lineage integration. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("cloudDataLineageIntegration")]
    public V1beta2EnvironmentSpecInitProviderConfigSoftwareConfigCloudDataLineageIntegration? CloudDataLineageIntegration { get; set; }

    /// <summary>
    /// Additional environment variables to provide to the Apache Airflow scheduler, worker, and webserver processes.
    /// Environment variable names must match the regular expression [a-zA-Z_][a-zA-Z0-9_]*.
    /// They cannot specify Apache Airflow software configuration overrides (they cannot match the regular expression
    /// AIRFLOW__[A-Z0-9_]+__[A-Z0-9_]+), and they cannot match any of the following reserved names:
    /// </summary>
    [JsonPropertyName("envVariables")]
    public IDictionary<string, string>? EnvVariables { get; set; }

    /// <summary>In Composer 1, use a specific Composer 1 version in this parameter. If omitted, the default is the latest version of Composer 2.</summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>
    /// Custom Python Package Index (PyPI) packages to be installed
    /// in the environment. Keys refer to the lowercase package name (e.g. &quot;numpy&quot;). Values are the lowercase extras and
    /// version specifier (e.g. &quot;==1.12.0&quot;, &quot;[devel,gcp_api]&quot;, &quot;[devel]&gt;=1.8.2, &lt;1.9.2&quot;). To specify a package without
    /// pinning it to a version specifier, use the empty string as the value.
    /// </summary>
    [JsonPropertyName("pypiPackages")]
    public IDictionary<string, string>? PypiPackages { get; set; }

    /// <summary>
    /// The major version of Python used to run the Apache Airflow scheduler, worker, and webserver processes.
    /// Can be set to &apos;2&apos; or &apos;3&apos;. If not specified, the default is &apos;3&apos;.
    /// </summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>The number of schedulers for Airflow.</summary>
    [JsonPropertyName("schedulerCount")]
    public double? SchedulerCount { get; set; }

    /// <summary>Web server plugins configuration. Can be either &apos;ENABLED&apos; or &apos;DISABLED&apos;. Defaults to &apos;ENABLED&apos;.</summary>
    [JsonPropertyName("webServerPluginsMode")]
    public string? WebServerPluginsMode { get; set; }
}

/// <summary>The configuration settings for the Airflow web server App Engine instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigWebServerConfig
{
    /// <summary>
    /// Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2,
    /// composer-n1-webserver-4 or composer-n1-webserver-8.
    /// Value custom is returned only in response, if Airflow web server parameters were
    /// manually changed to a non-standard values.
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigWebServerNetworkAccessControlAllowedIpRange
{
    /// <summary>A description of this ip range.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// IP address or range, defined using CIDR notation, of requests that this rule applies to.
    /// Examples: 192.168.1.1 or 192.168.0.0/16 or 2001:db8::/32 or 2001:0db8:0000:0042:0000:8a2e:0370:7334.
    /// IP range prefixes should be properly truncated. For example,
    /// 1.2.3.4/24 should be truncated to 1.2.3.0/24. Similarly, for IPv6, 2001:db8::1/32 should be truncated to 2001:db8::/32.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The network-level access control policy for the Airflow web server.
/// If unspecified, no network-level access restrictions are applied.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigWebServerNetworkAccessControl
{
    /// <summary>A collection of allowed IP ranges with descriptions. Structure is documented below.</summary>
    [JsonPropertyName("allowedIpRange")]
    public IList<V1beta2EnvironmentSpecInitProviderConfigWebServerNetworkAccessControlAllowedIpRange>? AllowedIpRange { get; set; }
}

/// <summary>Configuration for resources used by DAG processor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigWorkloadsConfigDagProcessor
{
    /// <summary>The number of Airflow triggerers.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>The amount of storage (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

/// <summary>Configuration for resources used by Airflow schedulers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigWorkloadsConfigScheduler
{
    /// <summary>The number of Airflow triggerers.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>The amount of storage (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

/// <summary>Configuration for resources used by Airflow triggerer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigWorkloadsConfigTriggerer
{
    /// <summary>The number of Airflow triggerers.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }
}

/// <summary>Configuration for resources used by Airflow web server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigWorkloadsConfigWebServer
{
    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>The amount of storage (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

/// <summary>Configuration for resources used by Airflow workers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigWorkloadsConfigWorker
{
    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>
    /// The maximum number of Airflow workers that the environment can run. The number of workers in the
    /// environment does not go above this number, even if a higher number of workers is required to
    /// handle the load.
    /// </summary>
    [JsonPropertyName("maxCount")]
    public double? MaxCount { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>
    /// The minimum number of Airflow workers that the environment can run. The number of workers in the
    /// environment does not go below this number, even if a lower number of workers can handle the load.
    /// </summary>
    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    /// <summary>The amount of storage (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

/// <summary>
/// The Kubernetes workloads configuration for GKE cluster associated with the
/// Cloud Composer environment.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfigWorkloadsConfig
{
    /// <summary>Configuration for resources used by DAG processor.</summary>
    [JsonPropertyName("dagProcessor")]
    public V1beta2EnvironmentSpecInitProviderConfigWorkloadsConfigDagProcessor? DagProcessor { get; set; }

    /// <summary>Configuration for resources used by Airflow schedulers.</summary>
    [JsonPropertyName("scheduler")]
    public V1beta2EnvironmentSpecInitProviderConfigWorkloadsConfigScheduler? Scheduler { get; set; }

    /// <summary>Configuration for resources used by Airflow triggerer.</summary>
    [JsonPropertyName("triggerer")]
    public V1beta2EnvironmentSpecInitProviderConfigWorkloadsConfigTriggerer? Triggerer { get; set; }

    /// <summary>Configuration for resources used by Airflow web server.</summary>
    [JsonPropertyName("webServer")]
    public V1beta2EnvironmentSpecInitProviderConfigWorkloadsConfigWebServer? WebServer { get; set; }

    /// <summary>Configuration for resources used by Airflow workers.</summary>
    [JsonPropertyName("worker")]
    public V1beta2EnvironmentSpecInitProviderConfigWorkloadsConfigWorker? Worker { get; set; }
}

/// <summary>Configuration parameters for this environment  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderConfig
{
    /// <summary>
    /// Configuration setting for airflow data rentention mechanism. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("dataRetentionConfig")]
    public V1beta2EnvironmentSpecInitProviderConfigDataRetentionConfig? DataRetentionConfig { get; set; }

    /// <summary>
    /// The configuration settings for Cloud SQL instance used internally
    /// by Apache Airflow software.
    /// </summary>
    [JsonPropertyName("databaseConfig")]
    public V1beta2EnvironmentSpecInitProviderConfigDatabaseConfig? DatabaseConfig { get; set; }

    /// <summary>
    /// If true, builds performed during operations that install Python packages have only private connectivity to Google services.
    /// If false, the builds also have access to the internet.
    /// </summary>
    [JsonPropertyName("enablePrivateBuildsOnly")]
    public bool? EnablePrivateBuildsOnly { get; set; }

    /// <summary>If true, a private Composer environment will be created.</summary>
    [JsonPropertyName("enablePrivateEnvironment")]
    public bool? EnablePrivateEnvironment { get; set; }

    /// <summary>
    /// The encryption options for the Cloud Composer environment and its
    /// dependencies.
    /// </summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta2EnvironmentSpecInitProviderConfigEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>
    /// The environment size controls the performance parameters of the managed
    /// Cloud Composer infrastructure that includes the Airflow database. Values for
    /// environment size are ENVIRONMENT_SIZE_SMALL, ENVIRONMENT_SIZE_MEDIUM,
    /// and ENVIRONMENT_SIZE_LARGE.
    /// </summary>
    [JsonPropertyName("environmentSize")]
    public string? EnvironmentSize { get; set; }

    /// <summary>The configuration settings for Cloud Composer maintenance windows.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta2EnvironmentSpecInitProviderConfigMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>
    /// Configuration options for the master authorized networks feature. Enabled
    /// master authorized networks will disallow all external traffic to access
    /// Kubernetes master through HTTPS except traffic from the given CIDR blocks,
    /// Google Compute Engine Public IPs and Google Prod IPs. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("masterAuthorizedNetworksConfig")]
    public V1beta2EnvironmentSpecInitProviderConfigMasterAuthorizedNetworksConfig? MasterAuthorizedNetworksConfig { get; set; }

    /// <summary>The configuration used for the Kubernetes Engine cluster.  Structure is documented below.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta2EnvironmentSpecInitProviderConfigNodeConfig? NodeConfig { get; set; }

    /// <summary>The number of nodes in the Kubernetes Engine cluster of the environment.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The configuration used for the Private IP Cloud Composer environment. Structure is documented below.</summary>
    [JsonPropertyName("privateEnvironmentConfig")]
    public V1beta2EnvironmentSpecInitProviderConfigPrivateEnvironmentConfig? PrivateEnvironmentConfig { get; set; }

    /// <summary>The configuration settings for recovery. Structure is documented below.</summary>
    [JsonPropertyName("recoveryConfig")]
    public V1beta2EnvironmentSpecInitProviderConfigRecoveryConfig? RecoveryConfig { get; set; }

    /// <summary>
    /// The resilience mode states whether high resilience is enabled for
    /// the environment or not. Values for resilience mode are HIGH_RESILIENCE
    /// for high resilience and STANDARD_RESILIENCE for standard
    /// resilience.
    /// </summary>
    [JsonPropertyName("resilienceMode")]
    public string? ResilienceMode { get; set; }

    /// <summary>The configuration settings for software inside the environment.  Structure is documented below.</summary>
    [JsonPropertyName("softwareConfig")]
    public V1beta2EnvironmentSpecInitProviderConfigSoftwareConfig? SoftwareConfig { get; set; }

    /// <summary>The configuration settings for the Airflow web server App Engine instance.</summary>
    [JsonPropertyName("webServerConfig")]
    public V1beta2EnvironmentSpecInitProviderConfigWebServerConfig? WebServerConfig { get; set; }

    /// <summary>
    /// The network-level access control policy for the Airflow web server.
    /// If unspecified, no network-level access restrictions are applied.
    /// </summary>
    [JsonPropertyName("webServerNetworkAccessControl")]
    public V1beta2EnvironmentSpecInitProviderConfigWebServerNetworkAccessControl? WebServerNetworkAccessControl { get; set; }

    /// <summary>
    /// The Kubernetes workloads configuration for GKE cluster associated with the
    /// Cloud Composer environment.
    /// </summary>
    [JsonPropertyName("workloadsConfig")]
    public V1beta2EnvironmentSpecInitProviderConfigWorkloadsConfig? WorkloadsConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecInitProviderProjectRefPolicyResolutionEnum>))]
public enum V1beta2EnvironmentSpecInitProviderProjectRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecInitProviderProjectRefPolicyResolveEnum>))]
public enum V1beta2EnvironmentSpecInitProviderProjectRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderProjectRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EnvironmentSpecInitProviderProjectRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EnvironmentSpecInitProviderProjectRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderProjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EnvironmentSpecInitProviderProjectRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecInitProviderProjectSelectorPolicyResolutionEnum>))]
public enum V1beta2EnvironmentSpecInitProviderProjectSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecInitProviderProjectSelectorPolicyResolveEnum>))]
public enum V1beta2EnvironmentSpecInitProviderProjectSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderProjectSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EnvironmentSpecInitProviderProjectSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EnvironmentSpecInitProviderProjectSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderProjectSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EnvironmentSpecInitProviderProjectSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration options for storage used by Composer environment. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProviderStorageConfig
{
    /// <summary>Name of an existing Cloud Storage bucket to be used by the environment.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecInitProvider
{
    /// <summary>Configuration parameters for this environment  Structure is documented below.</summary>
    [JsonPropertyName("config")]
    public V1beta2EnvironmentSpecInitProviderConfig? Config { get; set; }

    /// <summary>
    /// User-defined labels for this environment. The labels map can contain
    /// no more than 64 entries. Entries of the labels map are UTF8 strings
    /// that comply with the following restrictions:
    /// Label keys must be between 1 and 63 characters long and must conform
    /// to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?.
    /// Label values must be between 0 and 63 characters long and must
    /// conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?.
    /// No more than 64 labels can be associated with a given environment.
    /// Both keys and values must be &lt;= 128 bytes in size.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta2EnvironmentSpecInitProviderProjectRef? ProjectRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectSelector")]
    public V1beta2EnvironmentSpecInitProviderProjectSelector? ProjectSelector { get; set; }

    /// <summary>Configuration options for storage used by Composer environment. Structure is documented below.</summary>
    [JsonPropertyName("storageConfig")]
    public V1beta2EnvironmentSpecInitProviderStorageConfig? StorageConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecManagementPoliciesEnum>))]
public enum V1beta2EnvironmentSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2EnvironmentSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EnvironmentSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2EnvironmentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EnvironmentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EnvironmentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EnvironmentSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>EnvironmentSpec defines the desired state of Environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentSpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta2EnvironmentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2EnvironmentSpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta2EnvironmentSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta2EnvironmentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2EnvironmentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2EnvironmentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigDataRetentionConfigAirflowMetadataRetentionConfig
{
    /// <summary>How many days data should be retained for.</summary>
    [JsonPropertyName("retentionDays")]
    public double? RetentionDays { get; set; }

    /// <summary>
    /// Retention can be either enabled or disabled. Values for retention_mode are
    /// RETENTION_MODE_ENABLED to enable retention and RETENTION_MODE_DISABLED
    /// to disable retention.
    /// </summary>
    [JsonPropertyName("retentionMode")]
    public string? RetentionMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigDataRetentionConfigTaskLogsRetentionConfig
{
    /// <summary>
    /// The mode of storage for Airflow workers task logs. Values for storage mode are
    /// CLOUD_LOGGING_ONLY to only store logs in cloud logging and
    /// CLOUD_LOGGING_AND_CLOUD_STORAGE to store logs in cloud logging and cloud storage.
    /// </summary>
    [JsonPropertyName("storageMode")]
    public string? StorageMode { get; set; }
}

/// <summary>
/// Configuration setting for airflow data rentention mechanism. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigDataRetentionConfig
{
    /// <summary>
    /// The retention policy for airflow metadata database. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("airflowMetadataRetentionConfig")]
    public IList<V1beta2EnvironmentStatusAtProviderConfigDataRetentionConfigAirflowMetadataRetentionConfig>? AirflowMetadataRetentionConfig { get; set; }

    /// <summary>
    /// The configuration setting for Task Logs. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("taskLogsRetentionConfig")]
    public IList<V1beta2EnvironmentStatusAtProviderConfigDataRetentionConfigTaskLogsRetentionConfig>? TaskLogsRetentionConfig { get; set; }
}

/// <summary>
/// The configuration settings for Cloud SQL instance used internally
/// by Apache Airflow software.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigDatabaseConfig
{
    /// <summary>
    /// Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2,
    /// composer-n1-webserver-4 or composer-n1-webserver-8.
    /// Value custom is returned only in response, if Airflow web server parameters were
    /// manually changed to a non-standard values.
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// The Compute Engine zone in which to deploy the VMs running the
    /// Apache Airflow software, specified as the zone name or
    /// relative resource name (e.g. &quot;projects/{project}/zones/{zone}&quot;). Must
    /// belong to the enclosing environment&apos;s project and region.
    /// </summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>
/// The encryption options for the Cloud Composer environment and its
/// dependencies.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigEncryptionConfig
{
    /// <summary>
    /// Customer-managed Encryption Key available through Google&apos;s Key Management Service. It must
    /// be the fully qualified resource name,
    /// i.e. projects/project-id/locations/location/keyRings/keyring/cryptoKeys/key. Cannot be updated.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}

/// <summary>The configuration settings for Cloud Composer maintenance windows.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigMaintenanceWindow
{
    /// <summary>
    /// Maintenance window end time. It is used only to calculate the duration of the maintenance window.
    /// The value for end-time must be in the future, relative to &apos;start_time&apos;.
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// Maintenance window recurrence. Format is a subset of RFC-5545 (https://tools.ietf.org/html/rfc5545) &apos;RRULE&apos;.
    /// The only allowed values for &apos;FREQ&apos; field are &apos;FREQ=DAILY&apos; and &apos;FREQ=WEEKLY;BYDAY=...&apos;.
    /// Example values: &apos;FREQ=WEEKLY;BYDAY=TU,WE&apos;, &apos;FREQ=DAILY&apos;.
    /// </summary>
    [JsonPropertyName("recurrence")]
    public string? Recurrence { get; set; }

    /// <summary>Start time of the first recurrence of the maintenance window.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigMasterAuthorizedNetworksConfigCidrBlocks
{
    /// <summary>cidr_block must be specified in CIDR notation.</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>display_name is a field for users to identify CIDR blocks.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}

/// <summary>
/// Configuration options for the master authorized networks feature. Enabled
/// master authorized networks will disallow all external traffic to access
/// Kubernetes master through HTTPS except traffic from the given CIDR blocks,
/// Google Compute Engine Public IPs and Google Prod IPs. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigMasterAuthorizedNetworksConfig
{
    /// <summary>cidr_blocks define up to 50 external networks that could access Kubernetes master through HTTPS. Structure is documented below.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<V1beta2EnvironmentStatusAtProviderConfigMasterAuthorizedNetworksConfigCidrBlocks>? CidrBlocks { get; set; }

    /// <summary>When enabled, Cloud Composer periodically saves snapshots of your environment to a Cloud Storage bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Configuration for controlling how IPs are allocated in the GKE cluster.
/// Structure is documented below.
/// Cannot be updated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigNodeConfigIpAllocationPolicy
{
    /// <summary>
    /// The IP address range used to allocate IP addresses to pods in the cluster.
    /// For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true.
    /// Set to blank to have GKE choose a range with the default size.
    /// Set to /netmask (e.g. /14) to have GKE choose a range with a specific netmask.
    /// Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks
    /// (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.
    /// Specify either cluster_secondary_range_name or cluster_ipv4_cidr_block but not both.
    /// </summary>
    [JsonPropertyName("clusterIpv4CidrBlock")]
    public string? ClusterIpv4CidrBlock { get; set; }

    /// <summary>
    /// The name of the cluster&apos;s secondary range used to allocate IP addresses to pods.
    /// Specify either cluster_secondary_range_name or cluster_ipv4_cidr_block but not both.
    /// For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true.
    /// </summary>
    [JsonPropertyName("clusterSecondaryRangeName")]
    public string? ClusterSecondaryRangeName { get; set; }

    /// <summary>
    /// The IP address range used to allocate IP addresses in this cluster.
    /// For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true.
    /// Set to blank to have GKE choose a range with the default size.
    /// Set to /netmask (e.g. /14) to have GKE choose a range with a specific netmask.
    /// Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks
    /// (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.
    /// Specify either services_secondary_range_name or services_ipv4_cidr_block but not both.
    /// </summary>
    [JsonPropertyName("servicesIpv4CidrBlock")]
    public string? ServicesIpv4CidrBlock { get; set; }

    /// <summary>
    /// The name of the services&apos; secondary range used to allocate IP addresses to the cluster.
    /// Specify either services_secondary_range_name or services_ipv4_cidr_block but not both.
    /// For Cloud Composer 1 environments, this field is applicable only when use_ip_aliases is true.
    /// </summary>
    [JsonPropertyName("servicesSecondaryRangeName")]
    public string? ServicesSecondaryRangeName { get; set; }

    /// <summary>
    /// Whether or not to enable Alias IPs in the GKE cluster. If true, a VPC-native cluster is created.
    /// Defaults to true if the ip_allocation_policy block is present in config.
    /// </summary>
    [JsonPropertyName("useIpAliases")]
    public bool? UseIpAliases { get; set; }
}

/// <summary>The configuration used for the Kubernetes Engine cluster.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigNodeConfig
{
    /// <summary>
    /// /20 IPv4 cidr range that will be used by Composer internal components.
    /// Cannot be updated.
    /// </summary>
    [JsonPropertyName("composerInternalIpv4CidrBlock")]
    public string? ComposerInternalIpv4CidrBlock { get; set; }

    /// <summary>
    /// PSC (Private Service Connect) Network entry point. Customers can pre-create the Network Attachment
    /// and point Cloud Composer environment to use. It is possible to share network attachment among many environments,
    /// provided enough IP addresses are available.
    /// </summary>
    [JsonPropertyName("composerNetworkAttachment")]
    public string? ComposerNetworkAttachment { get; set; }

    /// <summary>
    /// The disk size in GB used for node VMs. Minimum size is 20GB.
    /// If unspecified, defaults to 100GB. Cannot be updated.
    /// </summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>
    /// Deploys &apos;ip-masq-agent&apos; daemon set in the GKE cluster and defines
    /// nonMasqueradeCIDRs equals to pod IP range so IP masquerading is used for
    /// all destination addresses, except between pods traffic.
    /// See the documentation.
    /// </summary>
    [JsonPropertyName("enableIpMasqAgent")]
    public bool? EnableIpMasqAgent { get; set; }

    /// <summary>
    /// Configuration for controlling how IPs are allocated in the GKE cluster.
    /// Structure is documented below.
    /// Cannot be updated.
    /// </summary>
    [JsonPropertyName("ipAllocationPolicy")]
    public V1beta2EnvironmentStatusAtProviderConfigNodeConfigIpAllocationPolicy? IpAllocationPolicy { get; set; }

    /// <summary>
    /// Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2,
    /// composer-n1-webserver-4 or composer-n1-webserver-8.
    /// Value custom is returned only in response, if Airflow web server parameters were
    /// manually changed to a non-standard values.
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// The Compute Engine network to be used for machine
    /// communications, specified as a self-link, relative resource name
    /// (for example &quot;projects/{project}/global/networks/{network}&quot;), by name.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// The set of Google API scopes to be made available on all node
    /// VMs. Cannot be updated. If empty, defaults to
    /// [&quot;https://www.googleapis.com/auth/cloud-platform&quot;].
    /// </summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the
    /// node VMs. If a service account is not specified, the &quot;default&quot;
    /// Compute Engine service account is used. Cannot be updated. If given,
    /// note that the service account must have roles/composer.worker
    /// for any GCP resources created under the Cloud Composer Environment.
    /// </summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>
    /// The Compute Engine subnetwork to be used for machine
    /// communications, specified as a self-link, relative resource name (for example,
    /// &quot;projects/{project}/regions/{region}/subnetworks/{subnetwork}&quot;), or by name. If subnetwork is provided,
    /// network must also be provided and the subnetwork must belong to the enclosing environment&apos;s project and region.
    /// </summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>
    /// The list of instance tags applied to all node VMs. Tags are
    /// used to identify valid sources or targets for network
    /// firewalls. Each tag within the list must comply with RFC1035.
    /// Cannot be updated.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>
    /// The Compute Engine zone in which to deploy the VMs running the
    /// Apache Airflow software, specified as the zone name or
    /// relative resource name (e.g. &quot;projects/{project}/zones/{zone}&quot;). Must
    /// belong to the enclosing environment&apos;s project and region.
    /// </summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>The configuration used for the Private IP Cloud Composer environment. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigPrivateEnvironmentConfig
{
    /// <summary>
    /// When specified, the environment will use Private Service Connect instead of VPC peerings to connect
    /// to Cloud SQL in the Tenant Project, and the PSC endpoint in the Customer Project will use an IP
    /// address from this subnetwork. This field is supported for Cloud Composer environments in
    /// versions composer-2.*.*-airflow-*.*.* and newer.
    /// </summary>
    [JsonPropertyName("cloudComposerConnectionSubnetwork")]
    public string? CloudComposerConnectionSubnetwork { get; set; }

    [JsonPropertyName("cloudComposerNetworkIpv4CidrBlock")]
    public string? CloudComposerNetworkIpv4CidrBlock { get; set; }

    /// <summary>The CIDR block from which IP range in tenant project will be reserved for Cloud SQL. Needs to be disjoint from web_server_ipv4_cidr_block</summary>
    [JsonPropertyName("cloudSqlIpv4CidrBlock")]
    public string? CloudSqlIpv4CidrBlock { get; set; }

    /// <summary>
    /// Mode of internal communication within the Composer environment. Must be one
    /// of &quot;VPC_PEERING&quot; or &quot;PRIVATE_SERVICE_CONNECT&quot;.
    /// </summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>
    /// If true, access to the public endpoint of the GKE cluster is denied.
    /// If this field is set to true, the ip_allocation_policy.use_ip_aliases field must
    /// also be set to true for Cloud Composer 1 environments.
    /// </summary>
    [JsonPropertyName("enablePrivateEndpoint")]
    public bool? EnablePrivateEndpoint { get; set; }

    /// <summary>
    /// When enabled, IPs from public (non-RFC1918) ranges can be used for
    /// ip_allocation_policy.cluster_ipv4_cidr_block and ip_allocation_policy.service_ipv4_cidr_block.
    /// </summary>
    [JsonPropertyName("enablePrivatelyUsedPublicIps")]
    public bool? EnablePrivatelyUsedPublicIps { get; set; }

    /// <summary>
    /// The IP range in CIDR notation to use for the hosted master network. This range is used
    /// for assigning internal IP addresses to the cluster master or set of masters and to the
    /// internal load balancer virtual IP. This range must not overlap with any other ranges
    /// in use within the cluster&apos;s network.
    /// If left blank, the default value of is used. See documentation for default values per region.
    /// </summary>
    [JsonPropertyName("masterIpv4CidrBlock")]
    public string? MasterIpv4CidrBlock { get; set; }

    /// <summary>The CIDR block from which IP range for web server will be reserved. Needs to be disjoint from master_ipv4_cidr_block and cloud_sql_ipv4_cidr_block.</summary>
    [JsonPropertyName("webServerIpv4CidrBlock")]
    public string? WebServerIpv4CidrBlock { get; set; }
}

/// <summary>The recovery configuration settings for the Cloud Composer environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigRecoveryConfigScheduledSnapshotsConfig
{
    /// <summary>When enabled, Cloud Composer periodically saves snapshots of your environment to a Cloud Storage bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Snapshot schedule, in the unix-cron format.</summary>
    [JsonPropertyName("snapshotCreationSchedule")]
    public string? SnapshotCreationSchedule { get; set; }

    /// <summary>The URI of a bucket folder where to save the snapshot.</summary>
    [JsonPropertyName("snapshotLocation")]
    public string? SnapshotLocation { get; set; }

    /// <summary>A time zone for the schedule. This value is a time offset and does not take into account daylight saving time changes. Valid values are from UTC-12 to UTC+12. Examples: UTC, UTC-01, UTC+03.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>The configuration settings for recovery. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigRecoveryConfig
{
    /// <summary>The recovery configuration settings for the Cloud Composer environment.</summary>
    [JsonPropertyName("scheduledSnapshotsConfig")]
    public V1beta2EnvironmentStatusAtProviderConfigRecoveryConfigScheduledSnapshotsConfig? ScheduledSnapshotsConfig { get; set; }
}

/// <summary>
/// The configuration for Cloud Data Lineage integration. Structure is
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigSoftwareConfigCloudDataLineageIntegration
{
    /// <summary>When enabled, Cloud Composer periodically saves snapshots of your environment to a Cloud Storage bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The configuration settings for software inside the environment.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigSoftwareConfig
{
    /// <summary>
    /// Apache Airflow configuration properties to override. Property keys contain the section and property names,
    /// separated by a hyphen, for example &quot;core-dags_are_paused_at_creation&quot;.
    /// </summary>
    [JsonPropertyName("airflowConfigOverrides")]
    public IDictionary<string, string>? AirflowConfigOverrides { get; set; }

    /// <summary>
    /// The configuration for Cloud Data Lineage integration. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("cloudDataLineageIntegration")]
    public V1beta2EnvironmentStatusAtProviderConfigSoftwareConfigCloudDataLineageIntegration? CloudDataLineageIntegration { get; set; }

    /// <summary>
    /// Additional environment variables to provide to the Apache Airflow scheduler, worker, and webserver processes.
    /// Environment variable names must match the regular expression [a-zA-Z_][a-zA-Z0-9_]*.
    /// They cannot specify Apache Airflow software configuration overrides (they cannot match the regular expression
    /// AIRFLOW__[A-Z0-9_]+__[A-Z0-9_]+), and they cannot match any of the following reserved names:
    /// </summary>
    [JsonPropertyName("envVariables")]
    public IDictionary<string, string>? EnvVariables { get; set; }

    /// <summary>In Composer 1, use a specific Composer 1 version in this parameter. If omitted, the default is the latest version of Composer 2.</summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>
    /// Custom Python Package Index (PyPI) packages to be installed
    /// in the environment. Keys refer to the lowercase package name (e.g. &quot;numpy&quot;). Values are the lowercase extras and
    /// version specifier (e.g. &quot;==1.12.0&quot;, &quot;[devel,gcp_api]&quot;, &quot;[devel]&gt;=1.8.2, &lt;1.9.2&quot;). To specify a package without
    /// pinning it to a version specifier, use the empty string as the value.
    /// </summary>
    [JsonPropertyName("pypiPackages")]
    public IDictionary<string, string>? PypiPackages { get; set; }

    /// <summary>
    /// The major version of Python used to run the Apache Airflow scheduler, worker, and webserver processes.
    /// Can be set to &apos;2&apos; or &apos;3&apos;. If not specified, the default is &apos;3&apos;.
    /// </summary>
    [JsonPropertyName("pythonVersion")]
    public string? PythonVersion { get; set; }

    /// <summary>The number of schedulers for Airflow.</summary>
    [JsonPropertyName("schedulerCount")]
    public double? SchedulerCount { get; set; }

    /// <summary>Web server plugins configuration. Can be either &apos;ENABLED&apos; or &apos;DISABLED&apos;. Defaults to &apos;ENABLED&apos;.</summary>
    [JsonPropertyName("webServerPluginsMode")]
    public string? WebServerPluginsMode { get; set; }
}

/// <summary>The configuration settings for the Airflow web server App Engine instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigWebServerConfig
{
    /// <summary>
    /// Machine type on which Airflow web server is running. It has to be one of: composer-n1-webserver-2,
    /// composer-n1-webserver-4 or composer-n1-webserver-8.
    /// Value custom is returned only in response, if Airflow web server parameters were
    /// manually changed to a non-standard values.
    /// </summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigWebServerNetworkAccessControlAllowedIpRange
{
    /// <summary>A description of this ip range.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// IP address or range, defined using CIDR notation, of requests that this rule applies to.
    /// Examples: 192.168.1.1 or 192.168.0.0/16 or 2001:db8::/32 or 2001:0db8:0000:0042:0000:8a2e:0370:7334.
    /// IP range prefixes should be properly truncated. For example,
    /// 1.2.3.4/24 should be truncated to 1.2.3.0/24. Similarly, for IPv6, 2001:db8::1/32 should be truncated to 2001:db8::/32.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The network-level access control policy for the Airflow web server.
/// If unspecified, no network-level access restrictions are applied.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigWebServerNetworkAccessControl
{
    /// <summary>A collection of allowed IP ranges with descriptions. Structure is documented below.</summary>
    [JsonPropertyName("allowedIpRange")]
    public IList<V1beta2EnvironmentStatusAtProviderConfigWebServerNetworkAccessControlAllowedIpRange>? AllowedIpRange { get; set; }
}

/// <summary>Configuration for resources used by DAG processor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigWorkloadsConfigDagProcessor
{
    /// <summary>The number of Airflow triggerers.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>The amount of storage (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

/// <summary>Configuration for resources used by Airflow schedulers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigWorkloadsConfigScheduler
{
    /// <summary>The number of Airflow triggerers.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>The amount of storage (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

/// <summary>Configuration for resources used by Airflow triggerer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigWorkloadsConfigTriggerer
{
    /// <summary>The number of Airflow triggerers.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }
}

/// <summary>Configuration for resources used by Airflow web server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigWorkloadsConfigWebServer
{
    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>The amount of storage (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

/// <summary>Configuration for resources used by Airflow workers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigWorkloadsConfigWorker
{
    /// <summary>The number of CPUs for a single Airflow worker.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>
    /// The maximum number of Airflow workers that the environment can run. The number of workers in the
    /// environment does not go above this number, even if a higher number of workers is required to
    /// handle the load.
    /// </summary>
    [JsonPropertyName("maxCount")]
    public double? MaxCount { get; set; }

    /// <summary>The amount of memory (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("memoryGb")]
    public double? MemoryGb { get; set; }

    /// <summary>
    /// The minimum number of Airflow workers that the environment can run. The number of workers in the
    /// environment does not go below this number, even if a lower number of workers can handle the load.
    /// </summary>
    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    /// <summary>The amount of storage (GB) for a single Airflow worker.</summary>
    [JsonPropertyName("storageGb")]
    public double? StorageGb { get; set; }
}

/// <summary>
/// The Kubernetes workloads configuration for GKE cluster associated with the
/// Cloud Composer environment.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfigWorkloadsConfig
{
    /// <summary>Configuration for resources used by DAG processor.</summary>
    [JsonPropertyName("dagProcessor")]
    public V1beta2EnvironmentStatusAtProviderConfigWorkloadsConfigDagProcessor? DagProcessor { get; set; }

    /// <summary>Configuration for resources used by Airflow schedulers.</summary>
    [JsonPropertyName("scheduler")]
    public V1beta2EnvironmentStatusAtProviderConfigWorkloadsConfigScheduler? Scheduler { get; set; }

    /// <summary>Configuration for resources used by Airflow triggerer.</summary>
    [JsonPropertyName("triggerer")]
    public V1beta2EnvironmentStatusAtProviderConfigWorkloadsConfigTriggerer? Triggerer { get; set; }

    /// <summary>Configuration for resources used by Airflow web server.</summary>
    [JsonPropertyName("webServer")]
    public V1beta2EnvironmentStatusAtProviderConfigWorkloadsConfigWebServer? WebServer { get; set; }

    /// <summary>Configuration for resources used by Airflow workers.</summary>
    [JsonPropertyName("worker")]
    public V1beta2EnvironmentStatusAtProviderConfigWorkloadsConfigWorker? Worker { get; set; }
}

/// <summary>Configuration parameters for this environment  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderConfig
{
    /// <summary>
    /// The URI of the Apache Airflow Web UI hosted within this
    /// environment.
    /// </summary>
    [JsonPropertyName("airflowUri")]
    public string? AirflowUri { get; set; }

    /// <summary>
    /// The Cloud Storage prefix of the DAGs for this environment.
    /// Although Cloud Storage objects reside in a flat namespace, a
    /// hierarchical file tree can be simulated using &apos;/&apos;-delimited
    /// object name prefixes. DAG objects for this environment
    /// reside in a simulated directory with this prefix.
    /// </summary>
    [JsonPropertyName("dagGcsPrefix")]
    public string? DagGcsPrefix { get; set; }

    /// <summary>
    /// Configuration setting for airflow data rentention mechanism. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("dataRetentionConfig")]
    public V1beta2EnvironmentStatusAtProviderConfigDataRetentionConfig? DataRetentionConfig { get; set; }

    /// <summary>
    /// The configuration settings for Cloud SQL instance used internally
    /// by Apache Airflow software.
    /// </summary>
    [JsonPropertyName("databaseConfig")]
    public V1beta2EnvironmentStatusAtProviderConfigDatabaseConfig? DatabaseConfig { get; set; }

    /// <summary>
    /// If true, builds performed during operations that install Python packages have only private connectivity to Google services.
    /// If false, the builds also have access to the internet.
    /// </summary>
    [JsonPropertyName("enablePrivateBuildsOnly")]
    public bool? EnablePrivateBuildsOnly { get; set; }

    /// <summary>If true, a private Composer environment will be created.</summary>
    [JsonPropertyName("enablePrivateEnvironment")]
    public bool? EnablePrivateEnvironment { get; set; }

    /// <summary>
    /// The encryption options for the Cloud Composer environment and its
    /// dependencies.
    /// </summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta2EnvironmentStatusAtProviderConfigEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>
    /// The environment size controls the performance parameters of the managed
    /// Cloud Composer infrastructure that includes the Airflow database. Values for
    /// environment size are ENVIRONMENT_SIZE_SMALL, ENVIRONMENT_SIZE_MEDIUM,
    /// and ENVIRONMENT_SIZE_LARGE.
    /// </summary>
    [JsonPropertyName("environmentSize")]
    public string? EnvironmentSize { get; set; }

    /// <summary>The Kubernetes Engine cluster used to run this environment.</summary>
    [JsonPropertyName("gkeCluster")]
    public string? GkeCluster { get; set; }

    /// <summary>The configuration settings for Cloud Composer maintenance windows.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta2EnvironmentStatusAtProviderConfigMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>
    /// Configuration options for the master authorized networks feature. Enabled
    /// master authorized networks will disallow all external traffic to access
    /// Kubernetes master through HTTPS except traffic from the given CIDR blocks,
    /// Google Compute Engine Public IPs and Google Prod IPs. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("masterAuthorizedNetworksConfig")]
    public V1beta2EnvironmentStatusAtProviderConfigMasterAuthorizedNetworksConfig? MasterAuthorizedNetworksConfig { get; set; }

    /// <summary>The configuration used for the Kubernetes Engine cluster.  Structure is documented below.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta2EnvironmentStatusAtProviderConfigNodeConfig? NodeConfig { get; set; }

    /// <summary>The number of nodes in the Kubernetes Engine cluster of the environment.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The configuration used for the Private IP Cloud Composer environment. Structure is documented below.</summary>
    [JsonPropertyName("privateEnvironmentConfig")]
    public V1beta2EnvironmentStatusAtProviderConfigPrivateEnvironmentConfig? PrivateEnvironmentConfig { get; set; }

    /// <summary>The configuration settings for recovery. Structure is documented below.</summary>
    [JsonPropertyName("recoveryConfig")]
    public V1beta2EnvironmentStatusAtProviderConfigRecoveryConfig? RecoveryConfig { get; set; }

    /// <summary>
    /// The resilience mode states whether high resilience is enabled for
    /// the environment or not. Values for resilience mode are HIGH_RESILIENCE
    /// for high resilience and STANDARD_RESILIENCE for standard
    /// resilience.
    /// </summary>
    [JsonPropertyName("resilienceMode")]
    public string? ResilienceMode { get; set; }

    /// <summary>The configuration settings for software inside the environment.  Structure is documented below.</summary>
    [JsonPropertyName("softwareConfig")]
    public V1beta2EnvironmentStatusAtProviderConfigSoftwareConfig? SoftwareConfig { get; set; }

    /// <summary>The configuration settings for the Airflow web server App Engine instance.</summary>
    [JsonPropertyName("webServerConfig")]
    public V1beta2EnvironmentStatusAtProviderConfigWebServerConfig? WebServerConfig { get; set; }

    /// <summary>
    /// The network-level access control policy for the Airflow web server.
    /// If unspecified, no network-level access restrictions are applied.
    /// </summary>
    [JsonPropertyName("webServerNetworkAccessControl")]
    public V1beta2EnvironmentStatusAtProviderConfigWebServerNetworkAccessControl? WebServerNetworkAccessControl { get; set; }

    /// <summary>
    /// The Kubernetes workloads configuration for GKE cluster associated with the
    /// Cloud Composer environment.
    /// </summary>
    [JsonPropertyName("workloadsConfig")]
    public V1beta2EnvironmentStatusAtProviderConfigWorkloadsConfig? WorkloadsConfig { get; set; }
}

/// <summary>Configuration options for storage used by Composer environment. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProviderStorageConfig
{
    /// <summary>Name of an existing Cloud Storage bucket to be used by the environment.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusAtProvider
{
    /// <summary>Configuration parameters for this environment  Structure is documented below.</summary>
    [JsonPropertyName("config")]
    public V1beta2EnvironmentStatusAtProviderConfig? Config { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{region}}/environments/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// User-defined labels for this environment. The labels map can contain
    /// no more than 64 entries. Entries of the labels map are UTF8 strings
    /// that comply with the following restrictions:
    /// Label keys must be between 1 and 63 characters long and must conform
    /// to the following regular expression: [a-z]([-a-z0-9]*[a-z0-9])?.
    /// Label values must be between 0 and 63 characters long and must
    /// conform to the regular expression ([a-z]([-a-z0-9]*[a-z0-9])?)?.
    /// No more than 64 labels can be associated with a given environment.
    /// Both keys and values must be &lt;= 128 bytes in size.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The location or Compute Engine region for the environment.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration options for storage used by Composer environment. Structure is documented below.</summary>
    [JsonPropertyName("storageConfig")]
    public V1beta2EnvironmentStatusAtProviderStorageConfig? StorageConfig { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>EnvironmentStatus defines the observed state of Environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EnvironmentStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2EnvironmentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2EnvironmentStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Environment is the Schema for the Environments API. An environment for running orchestration tasks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Environment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2EnvironmentSpec>, IStatus<V1beta2EnvironmentStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Environment";
    public const string KubeGroup = "composer.gcp.upbound.io";
    public const string KubePluralName = "environments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "composer.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Environment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EnvironmentSpec defines the desired state of Environment</summary>
    [JsonPropertyName("spec")]
    public required V1beta2EnvironmentSpec Spec { get; set; }

    /// <summary>EnvironmentStatus defines the observed state of Environment.</summary>
    [JsonPropertyName("status")]
    public V1beta2EnvironmentStatus? Status { get; set; }
}
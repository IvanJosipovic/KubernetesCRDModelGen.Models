#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.gcp.upbound.io;
/// <summary>Bucket is the Schema for the Buckets API. Creates a new bucket in Google Cloud Storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BucketList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Bucket>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BucketList";
    public const string KubeGroup = "storage.gcp.upbound.io";
    public const string KubePluralName = "buckets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BucketList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Bucket objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Bucket> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketSpecDeletionPolicyEnum>))]
public enum V1beta2BucketSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>The bucket&apos;s Autoclass configuration.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecForProviderAutoclass
{
    /// <summary>While set to true, autoclass automatically transitions objects in your bucket to appropriate storage classes based on each object&apos;s access pattern.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The storage class that objects in the bucket eventually transition to if they are not read for a certain length of time. Supported values include: NEARLINE, ARCHIVE.</summary>
    [JsonPropertyName("terminalStorageClass")]
    public string? TerminalStorageClass { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecForProviderCors
{
    /// <summary>The value, in seconds, to return in the Access-Control-Max-Age header used in preflight responses.</summary>
    [JsonPropertyName("maxAgeSeconds")]
    public double? MaxAgeSeconds { get; set; }

    /// <summary>The list of HTTP methods on which to include CORS response headers, (GET, OPTIONS, POST, etc) Note: &quot;*&quot; is permitted in the list of methods, and means &quot;any method&quot;.</summary>
    [JsonPropertyName("method")]
    public IList<string>? Method { get; set; }

    /// <summary>The list of Origins eligible to receive CORS response headers. Note: &quot;*&quot; is permitted in the list of origins, and means &quot;any Origin&quot;.</summary>
    [JsonPropertyName("origin")]
    public IList<string>? Origin { get; set; }

    /// <summary>The list of HTTP headers other than the simple response headers to give permission for the user-agent to share across domains.</summary>
    [JsonPropertyName("responseHeader")]
    public IList<string>? ResponseHeader { get; set; }
}

/// <summary>The bucket&apos;s custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecForProviderCustomPlacementConfig
{
    /// <summary>The list of individual regions that comprise a dual-region bucket. See Cloud Storage bucket locations for a list of acceptable regions. Note: If any of the data_locations changes, it will recreate the bucket.</summary>
    [JsonPropertyName("dataLocations")]
    public IList<string>? DataLocations { get; set; }
}

/// <summary>The bucket&apos;s encryption configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecForProviderEncryption
{
    /// <summary>
    /// : The id of a Cloud KMS key that will be used to encrypt objects inserted into this bucket, if no encryption method is specified.
    /// You must pay attention to whether the crypto key is available in the location that this bucket is created in.
    /// See the docs for more details.
    /// </summary>
    [JsonPropertyName("defaultKmsKeyName")]
    public string? DefaultKmsKeyName { get; set; }
}

/// <summary>The bucket&apos;s hierarchical namespace policy, which defines the bucket capability to handle folders in logical structure. Structure is documented below. To use this configuration, uniform_bucket_level_access must be enabled on bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecForProviderHierarchicalNamespace
{
    /// <summary>Enables hierarchical namespace for the bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The public network IP address ranges that can access the bucket and its data. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecForProviderIpFilterPublicNetworkSource
{
    /// <summary>The list of public or private IPv4 and IPv6 CIDR ranges that can access the bucket.</summary>
    [JsonPropertyName("allowedIpCidrRanges")]
    public IList<string>? AllowedIpCidrRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecForProviderIpFilterVpcNetworkSources
{
    /// <summary>The list of public or private IPv4 and IPv6 CIDR ranges that can access the bucket.</summary>
    [JsonPropertyName("allowedIpCidrRanges")]
    public IList<string>? AllowedIpCidrRanges { get; set; }

    /// <summary>Name of the network. Format: projects/PROJECT_ID/global/networks/NETWORK_NAME</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }
}

/// <summary>The bucket IP filtering configuration. Specifies the network sources that can access the bucket, as well as its underlying objects. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecForProviderIpFilter
{
    /// <summary>While set true, allows all service agents to access the bucket regardless of the IP filter configuration.</summary>
    [JsonPropertyName("allowAllServiceAgentAccess")]
    public bool? AllowAllServiceAgentAccess { get; set; }

    /// <summary>While set true, allows cross-org VPCs in the bucket&apos;s IP filter configuration.</summary>
    [JsonPropertyName("allowCrossOrgVpcs")]
    public bool? AllowCrossOrgVpcs { get; set; }

    /// <summary>The state of the IP filter configuration. Valid values are Enabled and Disabled. When set to Enabled, IP filtering rules are applied to a bucket and all incoming requests to the bucket are evaluated against these rules. When set to Disabled, IP filtering rules are not applied to a bucket. Note: allow_all_service_agent_access must be supplied when mode is set to Enabled, it can be ommited for other values.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The public network IP address ranges that can access the bucket and its data. Structure is documented below.</summary>
    [JsonPropertyName("publicNetworkSource")]
    public V1beta2BucketSpecForProviderIpFilterPublicNetworkSource? PublicNetworkSource { get; set; }

    /// <summary>The list of VPC networks that can access the bucket. Structure is documented below.</summary>
    [JsonPropertyName("vpcNetworkSources")]
    public IList<V1beta2BucketSpecForProviderIpFilterVpcNetworkSources>? VpcNetworkSources { get; set; }
}

/// <summary>The Lifecycle Rule&apos;s action configuration. A single block of this type is supported. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecForProviderLifecycleRuleAction
{
    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>The type of the action of this Lifecycle Rule. Supported values include: Delete, SetStorageClass and AbortIncompleteMultipartUpload.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The Lifecycle Rule&apos;s condition configuration. A single block of this type is supported. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecForProviderLifecycleRuleCondition
{
    /// <summary>Minimum age of an object in days to satisfy this condition. Note To set 0 value of age, send_age_if_zero should be set true otherwise 0 value of age field will be ignored.</summary>
    [JsonPropertyName("age")]
    public double? Age { get; set; }

    /// <summary>A date in the RFC 3339 format YYYY-MM-DD. This condition is satisfied when an object is created before midnight of the specified date in UTC.</summary>
    [JsonPropertyName("createdBefore")]
    public string? CreatedBefore { get; set; }

    /// <summary>A date in the RFC 3339 format YYYY-MM-DD. This condition is satisfied when the customTime metadata for the object is set to an earlier date than the date used in this lifecycle condition.</summary>
    [JsonPropertyName("customTimeBefore")]
    public string? CustomTimeBefore { get; set; }

    /// <summary>Days since the date set in the customTime metadata for the object. This condition is satisfied when the current date and time is at least the specified number of days after the customTime. When set to 0 it will be ignored, and your state will treat it as though you supplied no days_since_custom_time condition.</summary>
    [JsonPropertyName("daysSinceCustomTime")]
    public double? DaysSinceCustomTime { get; set; }

    /// <summary>Relevant only for versioned objects. Number of days elapsed since the noncurrent timestamp of an object. When set to 0 it will be ignored, and your state will treat it as though you supplied no days_since_noncurrent_time condition.</summary>
    [JsonPropertyName("daysSinceNoncurrentTime")]
    public double? DaysSinceNoncurrentTime { get; set; }

    /// <summary>One or more matching name prefixes to satisfy this condition.</summary>
    [JsonPropertyName("matchesPrefix")]
    public IList<string>? MatchesPrefix { get; set; }

    /// <summary>Storage Class of objects to satisfy this condition. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE, DURABLE_REDUCED_AVAILABILITY.</summary>
    [JsonPropertyName("matchesStorageClass")]
    public IList<string>? MatchesStorageClass { get; set; }

    /// <summary>One or more matching name suffixes to satisfy this condition.</summary>
    [JsonPropertyName("matchesSuffix")]
    public IList<string>? MatchesSuffix { get; set; }

    /// <summary>Relevant only for versioned objects. The date in RFC 3339 (e.g. 2017-06-13) when the object became nonconcurrent. When set to 0 it will be ignored, and your state will treat it as though you supplied no noncurrent_time_before condition.</summary>
    [JsonPropertyName("noncurrentTimeBefore")]
    public string? NoncurrentTimeBefore { get; set; }

    /// <summary>Relevant only for versioned objects. The number of newer versions of an object to satisfy this condition. When set to 0 it will be ignored and your state will treat it as though you supplied no num_newer_versions condition.</summary>
    [JsonPropertyName("numNewerVersions")]
    public double? NumNewerVersions { get; set; }

    /// <summary>While set true, age value will be sent in the request even for zero value of the field. This field is only useful and required for setting 0 value to the age field. It can be used alone or together with age attribute. NOTE age attibute with 0 value will be ommitted from the API request if send_age_if_zero field is having false value.</summary>
    [JsonPropertyName("sendAgeIfZero")]
    public bool? SendAgeIfZero { get; set; }

    /// <summary>While set true, days_since_custom_time value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the days_since_custom_time field. It can be used alone or together with days_since_custom_time.</summary>
    [JsonPropertyName("sendDaysSinceCustomTimeIfZero")]
    public bool? SendDaysSinceCustomTimeIfZero { get; set; }

    /// <summary>While set true, days_since_noncurrent_time value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the days_since_noncurrent_time field. It can be used alone or together with days_since_noncurrent_time.</summary>
    [JsonPropertyName("sendDaysSinceNoncurrentTimeIfZero")]
    public bool? SendDaysSinceNoncurrentTimeIfZero { get; set; }

    /// <summary>While set true, num_newer_versions value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the num_newer_versions field. It can be used alone or together with num_newer_versions.</summary>
    [JsonPropertyName("sendNumNewerVersionsIfZero")]
    public bool? SendNumNewerVersionsIfZero { get; set; }

    /// <summary>Match to live and/or archived objects. Unversioned buckets have only live objects. Supported values include: &quot;LIVE&quot;, &quot;ARCHIVED&quot;, &quot;ANY&quot;.</summary>
    [JsonPropertyName("withState")]
    public string? WithState { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecForProviderLifecycleRule
{
    /// <summary>The Lifecycle Rule&apos;s action configuration. A single block of this type is supported. Structure is documented below.</summary>
    [JsonPropertyName("action")]
    public V1beta2BucketSpecForProviderLifecycleRuleAction? Action { get; set; }

    /// <summary>The Lifecycle Rule&apos;s condition configuration. A single block of this type is supported. Structure is documented below.</summary>
    [JsonPropertyName("condition")]
    public V1beta2BucketSpecForProviderLifecycleRuleCondition? Condition { get; set; }
}

/// <summary>The bucket&apos;s Access &amp; Storage Logs configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecForProviderLogging
{
    /// <summary>The bucket that will receive log objects.</summary>
    [JsonPropertyName("logBucket")]
    public string? LogBucket { get; set; }

    /// <summary>
    /// The object prefix for log objects. If it&apos;s not provided,
    /// by default GCS sets this to this bucket&apos;s name.
    /// </summary>
    [JsonPropertyName("logObjectPrefix")]
    public string? LogObjectPrefix { get; set; }
}

/// <summary>Configuration of the bucket&apos;s data retention policy for how long objects in the bucket should be retained. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecForProviderRetentionPolicy
{
    /// <summary>If set to true, the bucket will be locked and permanently restrict edits to the bucket&apos;s retention policy.  Caution: Locking a bucket is an irreversible action.</summary>
    [JsonPropertyName("isLocked")]
    public bool? IsLocked { get; set; }

    /// <summary>The period of time, in seconds, that objects in the bucket must be retained and cannot be deleted, overwritten, or archived. The value must be less than 2,147,483,647 seconds.</summary>
    [JsonPropertyName("retentionPeriod")]
    public double? RetentionPeriod { get; set; }
}

/// <summary>The bucket&apos;s soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecForProviderSoftDeletePolicy
{
    /// <summary>The duration in seconds that soft-deleted objects in the bucket will be retained and cannot be permanently deleted. Default value is 604800. The value must be in between 604800(7 days) and 7776000(90 days). Note: To disable the soft delete policy on a bucket, This field must be set to 0.</summary>
    [JsonPropertyName("retentionDurationSeconds")]
    public double? RetentionDurationSeconds { get; set; }
}

/// <summary>The bucket&apos;s Versioning configuration.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecForProviderVersioning
{
    /// <summary>While set to true, versioning is fully enabled for this bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration if the bucket acts as a website. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecForProviderWebsite
{
    /// <summary>
    /// Behaves as the bucket&apos;s directory index where
    /// missing objects are treated as potential directories.
    /// </summary>
    [JsonPropertyName("mainPageSuffix")]
    public string? MainPageSuffix { get; set; }

    /// <summary>
    /// The custom object to return when a requested
    /// resource is not found.
    /// </summary>
    [JsonPropertyName("notFoundPage")]
    public string? NotFoundPage { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecForProvider
{
    /// <summary>The bucket&apos;s Autoclass configuration.  Structure is documented below.</summary>
    [JsonPropertyName("autoclass")]
    public V1beta2BucketSpecForProviderAutoclass? Autoclass { get; set; }

    /// <summary>The bucket&apos;s Cross-Origin Resource Sharing (CORS) configuration. Multiple blocks of this type are permitted. Structure is documented below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta2BucketSpecForProviderCors>? Cors { get; set; }

    /// <summary>The bucket&apos;s custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty. Structure is documented below.</summary>
    [JsonPropertyName("customPlacementConfig")]
    public V1beta2BucketSpecForProviderCustomPlacementConfig? CustomPlacementConfig { get; set; }

    /// <summary>Whether or not to automatically apply an eventBasedHold to new objects added to the bucket.</summary>
    [JsonPropertyName("defaultEventBasedHold")]
    public bool? DefaultEventBasedHold { get; set; }

    /// <summary>Enables object retention on a storage bucket.</summary>
    [JsonPropertyName("enableObjectRetention")]
    public bool? EnableObjectRetention { get; set; }

    /// <summary>The bucket&apos;s encryption configuration. Structure is documented below.</summary>
    [JsonPropertyName("encryption")]
    public V1beta2BucketSpecForProviderEncryption? Encryption { get; set; }

    /// <summary>
    /// When deleting a bucket, this
    /// boolean option will delete all contained objects.
    /// </summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>The bucket&apos;s hierarchical namespace policy, which defines the bucket capability to handle folders in logical structure. Structure is documented below. To use this configuration, uniform_bucket_level_access must be enabled on bucket.</summary>
    [JsonPropertyName("hierarchicalNamespace")]
    public V1beta2BucketSpecForProviderHierarchicalNamespace? HierarchicalNamespace { get; set; }

    /// <summary>The bucket IP filtering configuration. Specifies the network sources that can access the bucket, as well as its underlying objects. Structure is documented below.</summary>
    [JsonPropertyName("ipFilter")]
    public V1beta2BucketSpecForProviderIpFilter? IpFilter { get; set; }

    /// <summary>A map of key/value label pairs to assign to the bucket.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The bucket&apos;s Lifecycle Rules configuration. Multiple blocks of this type are permitted. Structure is documented below.</summary>
    [JsonPropertyName("lifecycleRule")]
    public IList<V1beta2BucketSpecForProviderLifecycleRule>? LifecycleRule { get; set; }

    /// <summary>The GCS location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The bucket&apos;s Access &amp; Storage Logs configuration. Structure is documented below.</summary>
    [JsonPropertyName("logging")]
    public V1beta2BucketSpecForProviderLogging? Logging { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Prevents public access to a bucket. Acceptable values are &quot;inherited&quot; or &quot;enforced&quot;. If &quot;inherited&quot;, the bucket uses public access prevention only if the bucket is subject to the public access prevention organization policy constraint. Defaults to &quot;inherited&quot;.</summary>
    [JsonPropertyName("publicAccessPrevention")]
    public string? PublicAccessPrevention { get; set; }

    /// <summary>Enables Requester Pays on a storage bucket.</summary>
    [JsonPropertyName("requesterPays")]
    public bool? RequesterPays { get; set; }

    /// <summary>Configuration of the bucket&apos;s data retention policy for how long objects in the bucket should be retained. Structure is documented below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta2BucketSpecForProviderRetentionPolicy? RetentionPolicy { get; set; }

    /// <summary>The recovery point objective for cross-region replication of the bucket. Applicable only for dual and multi-region buckets. &quot;DEFAULT&quot; sets default replication. &quot;ASYNC_TURBO&quot; value enables turbo replication, valid for dual-region buckets only. See Turbo Replication for more information. If rpo is not specified at bucket creation, it defaults to &quot;DEFAULT&quot; for dual and multi-region buckets. NOTE If used with single-region bucket, It will throw an error.</summary>
    [JsonPropertyName("rpo")]
    public string? Rpo { get; set; }

    /// <summary>The bucket&apos;s soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. Structure is documented below.</summary>
    [JsonPropertyName("softDeletePolicy")]
    public V1beta2BucketSpecForProviderSoftDeletePolicy? SoftDeletePolicy { get; set; }

    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Enables Uniform bucket-level access access to a bucket.</summary>
    [JsonPropertyName("uniformBucketLevelAccess")]
    public bool? UniformBucketLevelAccess { get; set; }

    /// <summary>The bucket&apos;s Versioning configuration.  Structure is documented below.</summary>
    [JsonPropertyName("versioning")]
    public V1beta2BucketSpecForProviderVersioning? Versioning { get; set; }

    /// <summary>Configuration if the bucket acts as a website. Structure is documented below.</summary>
    [JsonPropertyName("website")]
    public V1beta2BucketSpecForProviderWebsite? Website { get; set; }
}

/// <summary>The bucket&apos;s Autoclass configuration.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecInitProviderAutoclass
{
    /// <summary>While set to true, autoclass automatically transitions objects in your bucket to appropriate storage classes based on each object&apos;s access pattern.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The storage class that objects in the bucket eventually transition to if they are not read for a certain length of time. Supported values include: NEARLINE, ARCHIVE.</summary>
    [JsonPropertyName("terminalStorageClass")]
    public string? TerminalStorageClass { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecInitProviderCors
{
    /// <summary>The value, in seconds, to return in the Access-Control-Max-Age header used in preflight responses.</summary>
    [JsonPropertyName("maxAgeSeconds")]
    public double? MaxAgeSeconds { get; set; }

    /// <summary>The list of HTTP methods on which to include CORS response headers, (GET, OPTIONS, POST, etc) Note: &quot;*&quot; is permitted in the list of methods, and means &quot;any method&quot;.</summary>
    [JsonPropertyName("method")]
    public IList<string>? Method { get; set; }

    /// <summary>The list of Origins eligible to receive CORS response headers. Note: &quot;*&quot; is permitted in the list of origins, and means &quot;any Origin&quot;.</summary>
    [JsonPropertyName("origin")]
    public IList<string>? Origin { get; set; }

    /// <summary>The list of HTTP headers other than the simple response headers to give permission for the user-agent to share across domains.</summary>
    [JsonPropertyName("responseHeader")]
    public IList<string>? ResponseHeader { get; set; }
}

/// <summary>The bucket&apos;s custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecInitProviderCustomPlacementConfig
{
    /// <summary>The list of individual regions that comprise a dual-region bucket. See Cloud Storage bucket locations for a list of acceptable regions. Note: If any of the data_locations changes, it will recreate the bucket.</summary>
    [JsonPropertyName("dataLocations")]
    public IList<string>? DataLocations { get; set; }
}

/// <summary>The bucket&apos;s encryption configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecInitProviderEncryption
{
    /// <summary>
    /// : The id of a Cloud KMS key that will be used to encrypt objects inserted into this bucket, if no encryption method is specified.
    /// You must pay attention to whether the crypto key is available in the location that this bucket is created in.
    /// See the docs for more details.
    /// </summary>
    [JsonPropertyName("defaultKmsKeyName")]
    public string? DefaultKmsKeyName { get; set; }
}

/// <summary>The bucket&apos;s hierarchical namespace policy, which defines the bucket capability to handle folders in logical structure. Structure is documented below. To use this configuration, uniform_bucket_level_access must be enabled on bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecInitProviderHierarchicalNamespace
{
    /// <summary>Enables hierarchical namespace for the bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The public network IP address ranges that can access the bucket and its data. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecInitProviderIpFilterPublicNetworkSource
{
    /// <summary>The list of public or private IPv4 and IPv6 CIDR ranges that can access the bucket.</summary>
    [JsonPropertyName("allowedIpCidrRanges")]
    public IList<string>? AllowedIpCidrRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecInitProviderIpFilterVpcNetworkSources
{
    /// <summary>The list of public or private IPv4 and IPv6 CIDR ranges that can access the bucket.</summary>
    [JsonPropertyName("allowedIpCidrRanges")]
    public IList<string>? AllowedIpCidrRanges { get; set; }

    /// <summary>Name of the network. Format: projects/PROJECT_ID/global/networks/NETWORK_NAME</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }
}

/// <summary>The bucket IP filtering configuration. Specifies the network sources that can access the bucket, as well as its underlying objects. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecInitProviderIpFilter
{
    /// <summary>While set true, allows all service agents to access the bucket regardless of the IP filter configuration.</summary>
    [JsonPropertyName("allowAllServiceAgentAccess")]
    public bool? AllowAllServiceAgentAccess { get; set; }

    /// <summary>While set true, allows cross-org VPCs in the bucket&apos;s IP filter configuration.</summary>
    [JsonPropertyName("allowCrossOrgVpcs")]
    public bool? AllowCrossOrgVpcs { get; set; }

    /// <summary>The state of the IP filter configuration. Valid values are Enabled and Disabled. When set to Enabled, IP filtering rules are applied to a bucket and all incoming requests to the bucket are evaluated against these rules. When set to Disabled, IP filtering rules are not applied to a bucket. Note: allow_all_service_agent_access must be supplied when mode is set to Enabled, it can be ommited for other values.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The public network IP address ranges that can access the bucket and its data. Structure is documented below.</summary>
    [JsonPropertyName("publicNetworkSource")]
    public V1beta2BucketSpecInitProviderIpFilterPublicNetworkSource? PublicNetworkSource { get; set; }

    /// <summary>The list of VPC networks that can access the bucket. Structure is documented below.</summary>
    [JsonPropertyName("vpcNetworkSources")]
    public IList<V1beta2BucketSpecInitProviderIpFilterVpcNetworkSources>? VpcNetworkSources { get; set; }
}

/// <summary>The Lifecycle Rule&apos;s action configuration. A single block of this type is supported. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecInitProviderLifecycleRuleAction
{
    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>The type of the action of this Lifecycle Rule. Supported values include: Delete, SetStorageClass and AbortIncompleteMultipartUpload.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The Lifecycle Rule&apos;s condition configuration. A single block of this type is supported. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecInitProviderLifecycleRuleCondition
{
    /// <summary>Minimum age of an object in days to satisfy this condition. Note To set 0 value of age, send_age_if_zero should be set true otherwise 0 value of age field will be ignored.</summary>
    [JsonPropertyName("age")]
    public double? Age { get; set; }

    /// <summary>A date in the RFC 3339 format YYYY-MM-DD. This condition is satisfied when an object is created before midnight of the specified date in UTC.</summary>
    [JsonPropertyName("createdBefore")]
    public string? CreatedBefore { get; set; }

    /// <summary>A date in the RFC 3339 format YYYY-MM-DD. This condition is satisfied when the customTime metadata for the object is set to an earlier date than the date used in this lifecycle condition.</summary>
    [JsonPropertyName("customTimeBefore")]
    public string? CustomTimeBefore { get; set; }

    /// <summary>Days since the date set in the customTime metadata for the object. This condition is satisfied when the current date and time is at least the specified number of days after the customTime. When set to 0 it will be ignored, and your state will treat it as though you supplied no days_since_custom_time condition.</summary>
    [JsonPropertyName("daysSinceCustomTime")]
    public double? DaysSinceCustomTime { get; set; }

    /// <summary>Relevant only for versioned objects. Number of days elapsed since the noncurrent timestamp of an object. When set to 0 it will be ignored, and your state will treat it as though you supplied no days_since_noncurrent_time condition.</summary>
    [JsonPropertyName("daysSinceNoncurrentTime")]
    public double? DaysSinceNoncurrentTime { get; set; }

    /// <summary>One or more matching name prefixes to satisfy this condition.</summary>
    [JsonPropertyName("matchesPrefix")]
    public IList<string>? MatchesPrefix { get; set; }

    /// <summary>Storage Class of objects to satisfy this condition. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE, DURABLE_REDUCED_AVAILABILITY.</summary>
    [JsonPropertyName("matchesStorageClass")]
    public IList<string>? MatchesStorageClass { get; set; }

    /// <summary>One or more matching name suffixes to satisfy this condition.</summary>
    [JsonPropertyName("matchesSuffix")]
    public IList<string>? MatchesSuffix { get; set; }

    /// <summary>Relevant only for versioned objects. The date in RFC 3339 (e.g. 2017-06-13) when the object became nonconcurrent. When set to 0 it will be ignored, and your state will treat it as though you supplied no noncurrent_time_before condition.</summary>
    [JsonPropertyName("noncurrentTimeBefore")]
    public string? NoncurrentTimeBefore { get; set; }

    /// <summary>Relevant only for versioned objects. The number of newer versions of an object to satisfy this condition. When set to 0 it will be ignored and your state will treat it as though you supplied no num_newer_versions condition.</summary>
    [JsonPropertyName("numNewerVersions")]
    public double? NumNewerVersions { get; set; }

    /// <summary>While set true, age value will be sent in the request even for zero value of the field. This field is only useful and required for setting 0 value to the age field. It can be used alone or together with age attribute. NOTE age attibute with 0 value will be ommitted from the API request if send_age_if_zero field is having false value.</summary>
    [JsonPropertyName("sendAgeIfZero")]
    public bool? SendAgeIfZero { get; set; }

    /// <summary>While set true, days_since_custom_time value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the days_since_custom_time field. It can be used alone or together with days_since_custom_time.</summary>
    [JsonPropertyName("sendDaysSinceCustomTimeIfZero")]
    public bool? SendDaysSinceCustomTimeIfZero { get; set; }

    /// <summary>While set true, days_since_noncurrent_time value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the days_since_noncurrent_time field. It can be used alone or together with days_since_noncurrent_time.</summary>
    [JsonPropertyName("sendDaysSinceNoncurrentTimeIfZero")]
    public bool? SendDaysSinceNoncurrentTimeIfZero { get; set; }

    /// <summary>While set true, num_newer_versions value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the num_newer_versions field. It can be used alone or together with num_newer_versions.</summary>
    [JsonPropertyName("sendNumNewerVersionsIfZero")]
    public bool? SendNumNewerVersionsIfZero { get; set; }

    /// <summary>Match to live and/or archived objects. Unversioned buckets have only live objects. Supported values include: &quot;LIVE&quot;, &quot;ARCHIVED&quot;, &quot;ANY&quot;.</summary>
    [JsonPropertyName("withState")]
    public string? WithState { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecInitProviderLifecycleRule
{
    /// <summary>The Lifecycle Rule&apos;s action configuration. A single block of this type is supported. Structure is documented below.</summary>
    [JsonPropertyName("action")]
    public V1beta2BucketSpecInitProviderLifecycleRuleAction? Action { get; set; }

    /// <summary>The Lifecycle Rule&apos;s condition configuration. A single block of this type is supported. Structure is documented below.</summary>
    [JsonPropertyName("condition")]
    public V1beta2BucketSpecInitProviderLifecycleRuleCondition? Condition { get; set; }
}

/// <summary>The bucket&apos;s Access &amp; Storage Logs configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecInitProviderLogging
{
    /// <summary>The bucket that will receive log objects.</summary>
    [JsonPropertyName("logBucket")]
    public string? LogBucket { get; set; }

    /// <summary>
    /// The object prefix for log objects. If it&apos;s not provided,
    /// by default GCS sets this to this bucket&apos;s name.
    /// </summary>
    [JsonPropertyName("logObjectPrefix")]
    public string? LogObjectPrefix { get; set; }
}

/// <summary>Configuration of the bucket&apos;s data retention policy for how long objects in the bucket should be retained. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecInitProviderRetentionPolicy
{
    /// <summary>If set to true, the bucket will be locked and permanently restrict edits to the bucket&apos;s retention policy.  Caution: Locking a bucket is an irreversible action.</summary>
    [JsonPropertyName("isLocked")]
    public bool? IsLocked { get; set; }

    /// <summary>The period of time, in seconds, that objects in the bucket must be retained and cannot be deleted, overwritten, or archived. The value must be less than 2,147,483,647 seconds.</summary>
    [JsonPropertyName("retentionPeriod")]
    public double? RetentionPeriod { get; set; }
}

/// <summary>The bucket&apos;s soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecInitProviderSoftDeletePolicy
{
    /// <summary>The duration in seconds that soft-deleted objects in the bucket will be retained and cannot be permanently deleted. Default value is 604800. The value must be in between 604800(7 days) and 7776000(90 days). Note: To disable the soft delete policy on a bucket, This field must be set to 0.</summary>
    [JsonPropertyName("retentionDurationSeconds")]
    public double? RetentionDurationSeconds { get; set; }
}

/// <summary>The bucket&apos;s Versioning configuration.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecInitProviderVersioning
{
    /// <summary>While set to true, versioning is fully enabled for this bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration if the bucket acts as a website. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecInitProviderWebsite
{
    /// <summary>
    /// Behaves as the bucket&apos;s directory index where
    /// missing objects are treated as potential directories.
    /// </summary>
    [JsonPropertyName("mainPageSuffix")]
    public string? MainPageSuffix { get; set; }

    /// <summary>
    /// The custom object to return when a requested
    /// resource is not found.
    /// </summary>
    [JsonPropertyName("notFoundPage")]
    public string? NotFoundPage { get; set; }
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
public partial class V1beta2BucketSpecInitProvider
{
    /// <summary>The bucket&apos;s Autoclass configuration.  Structure is documented below.</summary>
    [JsonPropertyName("autoclass")]
    public V1beta2BucketSpecInitProviderAutoclass? Autoclass { get; set; }

    /// <summary>The bucket&apos;s Cross-Origin Resource Sharing (CORS) configuration. Multiple blocks of this type are permitted. Structure is documented below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta2BucketSpecInitProviderCors>? Cors { get; set; }

    /// <summary>The bucket&apos;s custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty. Structure is documented below.</summary>
    [JsonPropertyName("customPlacementConfig")]
    public V1beta2BucketSpecInitProviderCustomPlacementConfig? CustomPlacementConfig { get; set; }

    /// <summary>Whether or not to automatically apply an eventBasedHold to new objects added to the bucket.</summary>
    [JsonPropertyName("defaultEventBasedHold")]
    public bool? DefaultEventBasedHold { get; set; }

    /// <summary>Enables object retention on a storage bucket.</summary>
    [JsonPropertyName("enableObjectRetention")]
    public bool? EnableObjectRetention { get; set; }

    /// <summary>The bucket&apos;s encryption configuration. Structure is documented below.</summary>
    [JsonPropertyName("encryption")]
    public V1beta2BucketSpecInitProviderEncryption? Encryption { get; set; }

    /// <summary>
    /// When deleting a bucket, this
    /// boolean option will delete all contained objects.
    /// </summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>The bucket&apos;s hierarchical namespace policy, which defines the bucket capability to handle folders in logical structure. Structure is documented below. To use this configuration, uniform_bucket_level_access must be enabled on bucket.</summary>
    [JsonPropertyName("hierarchicalNamespace")]
    public V1beta2BucketSpecInitProviderHierarchicalNamespace? HierarchicalNamespace { get; set; }

    /// <summary>The bucket IP filtering configuration. Specifies the network sources that can access the bucket, as well as its underlying objects. Structure is documented below.</summary>
    [JsonPropertyName("ipFilter")]
    public V1beta2BucketSpecInitProviderIpFilter? IpFilter { get; set; }

    /// <summary>A map of key/value label pairs to assign to the bucket.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The bucket&apos;s Lifecycle Rules configuration. Multiple blocks of this type are permitted. Structure is documented below.</summary>
    [JsonPropertyName("lifecycleRule")]
    public IList<V1beta2BucketSpecInitProviderLifecycleRule>? LifecycleRule { get; set; }

    /// <summary>The GCS location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The bucket&apos;s Access &amp; Storage Logs configuration. Structure is documented below.</summary>
    [JsonPropertyName("logging")]
    public V1beta2BucketSpecInitProviderLogging? Logging { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Prevents public access to a bucket. Acceptable values are &quot;inherited&quot; or &quot;enforced&quot;. If &quot;inherited&quot;, the bucket uses public access prevention only if the bucket is subject to the public access prevention organization policy constraint. Defaults to &quot;inherited&quot;.</summary>
    [JsonPropertyName("publicAccessPrevention")]
    public string? PublicAccessPrevention { get; set; }

    /// <summary>Enables Requester Pays on a storage bucket.</summary>
    [JsonPropertyName("requesterPays")]
    public bool? RequesterPays { get; set; }

    /// <summary>Configuration of the bucket&apos;s data retention policy for how long objects in the bucket should be retained. Structure is documented below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta2BucketSpecInitProviderRetentionPolicy? RetentionPolicy { get; set; }

    /// <summary>The recovery point objective for cross-region replication of the bucket. Applicable only for dual and multi-region buckets. &quot;DEFAULT&quot; sets default replication. &quot;ASYNC_TURBO&quot; value enables turbo replication, valid for dual-region buckets only. See Turbo Replication for more information. If rpo is not specified at bucket creation, it defaults to &quot;DEFAULT&quot; for dual and multi-region buckets. NOTE If used with single-region bucket, It will throw an error.</summary>
    [JsonPropertyName("rpo")]
    public string? Rpo { get; set; }

    /// <summary>The bucket&apos;s soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. Structure is documented below.</summary>
    [JsonPropertyName("softDeletePolicy")]
    public V1beta2BucketSpecInitProviderSoftDeletePolicy? SoftDeletePolicy { get; set; }

    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>Enables Uniform bucket-level access access to a bucket.</summary>
    [JsonPropertyName("uniformBucketLevelAccess")]
    public bool? UniformBucketLevelAccess { get; set; }

    /// <summary>The bucket&apos;s Versioning configuration.  Structure is documented below.</summary>
    [JsonPropertyName("versioning")]
    public V1beta2BucketSpecInitProviderVersioning? Versioning { get; set; }

    /// <summary>Configuration if the bucket acts as a website. Structure is documented below.</summary>
    [JsonPropertyName("website")]
    public V1beta2BucketSpecInitProviderWebsite? Website { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketSpecManagementPoliciesEnum>))]
public enum V1beta2BucketSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2BucketSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2BucketSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BucketSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>BucketSpec defines the desired state of Bucket</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketSpec
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
    public V1beta2BucketSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2BucketSpecForProvider ForProvider { get; set; }

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
    public V1beta2BucketSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2BucketSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2BucketSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2BucketSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The bucket&apos;s Autoclass configuration.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusAtProviderAutoclass
{
    /// <summary>While set to true, autoclass automatically transitions objects in your bucket to appropriate storage classes based on each object&apos;s access pattern.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The storage class that objects in the bucket eventually transition to if they are not read for a certain length of time. Supported values include: NEARLINE, ARCHIVE.</summary>
    [JsonPropertyName("terminalStorageClass")]
    public string? TerminalStorageClass { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusAtProviderCors
{
    /// <summary>The value, in seconds, to return in the Access-Control-Max-Age header used in preflight responses.</summary>
    [JsonPropertyName("maxAgeSeconds")]
    public double? MaxAgeSeconds { get; set; }

    /// <summary>The list of HTTP methods on which to include CORS response headers, (GET, OPTIONS, POST, etc) Note: &quot;*&quot; is permitted in the list of methods, and means &quot;any method&quot;.</summary>
    [JsonPropertyName("method")]
    public IList<string>? Method { get; set; }

    /// <summary>The list of Origins eligible to receive CORS response headers. Note: &quot;*&quot; is permitted in the list of origins, and means &quot;any Origin&quot;.</summary>
    [JsonPropertyName("origin")]
    public IList<string>? Origin { get; set; }

    /// <summary>The list of HTTP headers other than the simple response headers to give permission for the user-agent to share across domains.</summary>
    [JsonPropertyName("responseHeader")]
    public IList<string>? ResponseHeader { get; set; }
}

/// <summary>The bucket&apos;s custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusAtProviderCustomPlacementConfig
{
    /// <summary>The list of individual regions that comprise a dual-region bucket. See Cloud Storage bucket locations for a list of acceptable regions. Note: If any of the data_locations changes, it will recreate the bucket.</summary>
    [JsonPropertyName("dataLocations")]
    public IList<string>? DataLocations { get; set; }
}

/// <summary>The bucket&apos;s encryption configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusAtProviderEncryption
{
    /// <summary>
    /// : The id of a Cloud KMS key that will be used to encrypt objects inserted into this bucket, if no encryption method is specified.
    /// You must pay attention to whether the crypto key is available in the location that this bucket is created in.
    /// See the docs for more details.
    /// </summary>
    [JsonPropertyName("defaultKmsKeyName")]
    public string? DefaultKmsKeyName { get; set; }
}

/// <summary>The bucket&apos;s hierarchical namespace policy, which defines the bucket capability to handle folders in logical structure. Structure is documented below. To use this configuration, uniform_bucket_level_access must be enabled on bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusAtProviderHierarchicalNamespace
{
    /// <summary>Enables hierarchical namespace for the bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The public network IP address ranges that can access the bucket and its data. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusAtProviderIpFilterPublicNetworkSource
{
    /// <summary>The list of public or private IPv4 and IPv6 CIDR ranges that can access the bucket.</summary>
    [JsonPropertyName("allowedIpCidrRanges")]
    public IList<string>? AllowedIpCidrRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusAtProviderIpFilterVpcNetworkSources
{
    /// <summary>The list of public or private IPv4 and IPv6 CIDR ranges that can access the bucket.</summary>
    [JsonPropertyName("allowedIpCidrRanges")]
    public IList<string>? AllowedIpCidrRanges { get; set; }

    /// <summary>Name of the network. Format: projects/PROJECT_ID/global/networks/NETWORK_NAME</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }
}

/// <summary>The bucket IP filtering configuration. Specifies the network sources that can access the bucket, as well as its underlying objects. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusAtProviderIpFilter
{
    /// <summary>While set true, allows all service agents to access the bucket regardless of the IP filter configuration.</summary>
    [JsonPropertyName("allowAllServiceAgentAccess")]
    public bool? AllowAllServiceAgentAccess { get; set; }

    /// <summary>While set true, allows cross-org VPCs in the bucket&apos;s IP filter configuration.</summary>
    [JsonPropertyName("allowCrossOrgVpcs")]
    public bool? AllowCrossOrgVpcs { get; set; }

    /// <summary>The state of the IP filter configuration. Valid values are Enabled and Disabled. When set to Enabled, IP filtering rules are applied to a bucket and all incoming requests to the bucket are evaluated against these rules. When set to Disabled, IP filtering rules are not applied to a bucket. Note: allow_all_service_agent_access must be supplied when mode is set to Enabled, it can be ommited for other values.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The public network IP address ranges that can access the bucket and its data. Structure is documented below.</summary>
    [JsonPropertyName("publicNetworkSource")]
    public V1beta2BucketStatusAtProviderIpFilterPublicNetworkSource? PublicNetworkSource { get; set; }

    /// <summary>The list of VPC networks that can access the bucket. Structure is documented below.</summary>
    [JsonPropertyName("vpcNetworkSources")]
    public IList<V1beta2BucketStatusAtProviderIpFilterVpcNetworkSources>? VpcNetworkSources { get; set; }
}

/// <summary>The Lifecycle Rule&apos;s action configuration. A single block of this type is supported. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusAtProviderLifecycleRuleAction
{
    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>The type of the action of this Lifecycle Rule. Supported values include: Delete, SetStorageClass and AbortIncompleteMultipartUpload.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The Lifecycle Rule&apos;s condition configuration. A single block of this type is supported. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusAtProviderLifecycleRuleCondition
{
    /// <summary>Minimum age of an object in days to satisfy this condition. Note To set 0 value of age, send_age_if_zero should be set true otherwise 0 value of age field will be ignored.</summary>
    [JsonPropertyName("age")]
    public double? Age { get; set; }

    /// <summary>A date in the RFC 3339 format YYYY-MM-DD. This condition is satisfied when an object is created before midnight of the specified date in UTC.</summary>
    [JsonPropertyName("createdBefore")]
    public string? CreatedBefore { get; set; }

    /// <summary>A date in the RFC 3339 format YYYY-MM-DD. This condition is satisfied when the customTime metadata for the object is set to an earlier date than the date used in this lifecycle condition.</summary>
    [JsonPropertyName("customTimeBefore")]
    public string? CustomTimeBefore { get; set; }

    /// <summary>Days since the date set in the customTime metadata for the object. This condition is satisfied when the current date and time is at least the specified number of days after the customTime. When set to 0 it will be ignored, and your state will treat it as though you supplied no days_since_custom_time condition.</summary>
    [JsonPropertyName("daysSinceCustomTime")]
    public double? DaysSinceCustomTime { get; set; }

    /// <summary>Relevant only for versioned objects. Number of days elapsed since the noncurrent timestamp of an object. When set to 0 it will be ignored, and your state will treat it as though you supplied no days_since_noncurrent_time condition.</summary>
    [JsonPropertyName("daysSinceNoncurrentTime")]
    public double? DaysSinceNoncurrentTime { get; set; }

    /// <summary>One or more matching name prefixes to satisfy this condition.</summary>
    [JsonPropertyName("matchesPrefix")]
    public IList<string>? MatchesPrefix { get; set; }

    /// <summary>Storage Class of objects to satisfy this condition. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE, DURABLE_REDUCED_AVAILABILITY.</summary>
    [JsonPropertyName("matchesStorageClass")]
    public IList<string>? MatchesStorageClass { get; set; }

    /// <summary>One or more matching name suffixes to satisfy this condition.</summary>
    [JsonPropertyName("matchesSuffix")]
    public IList<string>? MatchesSuffix { get; set; }

    /// <summary>Relevant only for versioned objects. The date in RFC 3339 (e.g. 2017-06-13) when the object became nonconcurrent. When set to 0 it will be ignored, and your state will treat it as though you supplied no noncurrent_time_before condition.</summary>
    [JsonPropertyName("noncurrentTimeBefore")]
    public string? NoncurrentTimeBefore { get; set; }

    /// <summary>Relevant only for versioned objects. The number of newer versions of an object to satisfy this condition. When set to 0 it will be ignored and your state will treat it as though you supplied no num_newer_versions condition.</summary>
    [JsonPropertyName("numNewerVersions")]
    public double? NumNewerVersions { get; set; }

    /// <summary>While set true, age value will be sent in the request even for zero value of the field. This field is only useful and required for setting 0 value to the age field. It can be used alone or together with age attribute. NOTE age attibute with 0 value will be ommitted from the API request if send_age_if_zero field is having false value.</summary>
    [JsonPropertyName("sendAgeIfZero")]
    public bool? SendAgeIfZero { get; set; }

    /// <summary>While set true, days_since_custom_time value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the days_since_custom_time field. It can be used alone or together with days_since_custom_time.</summary>
    [JsonPropertyName("sendDaysSinceCustomTimeIfZero")]
    public bool? SendDaysSinceCustomTimeIfZero { get; set; }

    /// <summary>While set true, days_since_noncurrent_time value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the days_since_noncurrent_time field. It can be used alone or together with days_since_noncurrent_time.</summary>
    [JsonPropertyName("sendDaysSinceNoncurrentTimeIfZero")]
    public bool? SendDaysSinceNoncurrentTimeIfZero { get; set; }

    /// <summary>While set true, num_newer_versions value will be sent in the request even for zero value of the field. This field is only useful for setting 0 value to the num_newer_versions field. It can be used alone or together with num_newer_versions.</summary>
    [JsonPropertyName("sendNumNewerVersionsIfZero")]
    public bool? SendNumNewerVersionsIfZero { get; set; }

    /// <summary>Match to live and/or archived objects. Unversioned buckets have only live objects. Supported values include: &quot;LIVE&quot;, &quot;ARCHIVED&quot;, &quot;ANY&quot;.</summary>
    [JsonPropertyName("withState")]
    public string? WithState { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusAtProviderLifecycleRule
{
    /// <summary>The Lifecycle Rule&apos;s action configuration. A single block of this type is supported. Structure is documented below.</summary>
    [JsonPropertyName("action")]
    public V1beta2BucketStatusAtProviderLifecycleRuleAction? Action { get; set; }

    /// <summary>The Lifecycle Rule&apos;s condition configuration. A single block of this type is supported. Structure is documented below.</summary>
    [JsonPropertyName("condition")]
    public V1beta2BucketStatusAtProviderLifecycleRuleCondition? Condition { get; set; }
}

/// <summary>The bucket&apos;s Access &amp; Storage Logs configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusAtProviderLogging
{
    /// <summary>The bucket that will receive log objects.</summary>
    [JsonPropertyName("logBucket")]
    public string? LogBucket { get; set; }

    /// <summary>
    /// The object prefix for log objects. If it&apos;s not provided,
    /// by default GCS sets this to this bucket&apos;s name.
    /// </summary>
    [JsonPropertyName("logObjectPrefix")]
    public string? LogObjectPrefix { get; set; }
}

/// <summary>Configuration of the bucket&apos;s data retention policy for how long objects in the bucket should be retained. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusAtProviderRetentionPolicy
{
    /// <summary>If set to true, the bucket will be locked and permanently restrict edits to the bucket&apos;s retention policy.  Caution: Locking a bucket is an irreversible action.</summary>
    [JsonPropertyName("isLocked")]
    public bool? IsLocked { get; set; }

    /// <summary>The period of time, in seconds, that objects in the bucket must be retained and cannot be deleted, overwritten, or archived. The value must be less than 2,147,483,647 seconds.</summary>
    [JsonPropertyName("retentionPeriod")]
    public double? RetentionPeriod { get; set; }
}

/// <summary>The bucket&apos;s soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusAtProviderSoftDeletePolicy
{
    /// <summary>(Computed) Server-determined value that indicates the time from which the policy, or one with a greater retention, was effective. This value is in RFC 3339 format.</summary>
    [JsonPropertyName("effectiveTime")]
    public string? EffectiveTime { get; set; }

    /// <summary>The duration in seconds that soft-deleted objects in the bucket will be retained and cannot be permanently deleted. Default value is 604800. The value must be in between 604800(7 days) and 7776000(90 days). Note: To disable the soft delete policy on a bucket, This field must be set to 0.</summary>
    [JsonPropertyName("retentionDurationSeconds")]
    public double? RetentionDurationSeconds { get; set; }
}

/// <summary>The bucket&apos;s Versioning configuration.  Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusAtProviderVersioning
{
    /// <summary>While set to true, versioning is fully enabled for this bucket.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration if the bucket acts as a website. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusAtProviderWebsite
{
    /// <summary>
    /// Behaves as the bucket&apos;s directory index where
    /// missing objects are treated as potential directories.
    /// </summary>
    [JsonPropertyName("mainPageSuffix")]
    public string? MainPageSuffix { get; set; }

    /// <summary>
    /// The custom object to return when a requested
    /// resource is not found.
    /// </summary>
    [JsonPropertyName("notFoundPage")]
    public string? NotFoundPage { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusAtProvider
{
    /// <summary>The bucket&apos;s Autoclass configuration.  Structure is documented below.</summary>
    [JsonPropertyName("autoclass")]
    public V1beta2BucketStatusAtProviderAutoclass? Autoclass { get; set; }

    /// <summary>The bucket&apos;s Cross-Origin Resource Sharing (CORS) configuration. Multiple blocks of this type are permitted. Structure is documented below.</summary>
    [JsonPropertyName("cors")]
    public IList<V1beta2BucketStatusAtProviderCors>? Cors { get; set; }

    /// <summary>The bucket&apos;s custom location configuration, which specifies the individual regions that comprise a dual-region bucket. If the bucket is designated a single or multi-region, the parameters are empty. Structure is documented below.</summary>
    [JsonPropertyName("customPlacementConfig")]
    public V1beta2BucketStatusAtProviderCustomPlacementConfig? CustomPlacementConfig { get; set; }

    /// <summary>Whether or not to automatically apply an eventBasedHold to new objects added to the bucket.</summary>
    [JsonPropertyName("defaultEventBasedHold")]
    public bool? DefaultEventBasedHold { get; set; }

    /// <summary>A map of key/value label pairs to assign to the bucket.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Enables object retention on a storage bucket.</summary>
    [JsonPropertyName("enableObjectRetention")]
    public bool? EnableObjectRetention { get; set; }

    /// <summary>The bucket&apos;s encryption configuration. Structure is documented below.</summary>
    [JsonPropertyName("encryption")]
    public V1beta2BucketStatusAtProviderEncryption? Encryption { get; set; }

    /// <summary>
    /// When deleting a bucket, this
    /// boolean option will delete all contained objects.
    /// </summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>The bucket&apos;s hierarchical namespace policy, which defines the bucket capability to handle folders in logical structure. Structure is documented below. To use this configuration, uniform_bucket_level_access must be enabled on bucket.</summary>
    [JsonPropertyName("hierarchicalNamespace")]
    public V1beta2BucketStatusAtProviderHierarchicalNamespace? HierarchicalNamespace { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The bucket IP filtering configuration. Specifies the network sources that can access the bucket, as well as its underlying objects. Structure is documented below.</summary>
    [JsonPropertyName("ipFilter")]
    public V1beta2BucketStatusAtProviderIpFilter? IpFilter { get; set; }

    /// <summary>A map of key/value label pairs to assign to the bucket.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The bucket&apos;s Lifecycle Rules configuration. Multiple blocks of this type are permitted. Structure is documented below.</summary>
    [JsonPropertyName("lifecycleRule")]
    public IList<V1beta2BucketStatusAtProviderLifecycleRule>? LifecycleRule { get; set; }

    /// <summary>The GCS location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The bucket&apos;s Access &amp; Storage Logs configuration. Structure is documented below.</summary>
    [JsonPropertyName("logging")]
    public V1beta2BucketStatusAtProviderLogging? Logging { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    [JsonPropertyName("projectNumber")]
    public double? ProjectNumber { get; set; }

    /// <summary>Prevents public access to a bucket. Acceptable values are &quot;inherited&quot; or &quot;enforced&quot;. If &quot;inherited&quot;, the bucket uses public access prevention only if the bucket is subject to the public access prevention organization policy constraint. Defaults to &quot;inherited&quot;.</summary>
    [JsonPropertyName("publicAccessPrevention")]
    public string? PublicAccessPrevention { get; set; }

    /// <summary>Enables Requester Pays on a storage bucket.</summary>
    [JsonPropertyName("requesterPays")]
    public bool? RequesterPays { get; set; }

    /// <summary>Configuration of the bucket&apos;s data retention policy for how long objects in the bucket should be retained. Structure is documented below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public V1beta2BucketStatusAtProviderRetentionPolicy? RetentionPolicy { get; set; }

    /// <summary>The recovery point objective for cross-region replication of the bucket. Applicable only for dual and multi-region buckets. &quot;DEFAULT&quot; sets default replication. &quot;ASYNC_TURBO&quot; value enables turbo replication, valid for dual-region buckets only. See Turbo Replication for more information. If rpo is not specified at bucket creation, it defaults to &quot;DEFAULT&quot; for dual and multi-region buckets. NOTE If used with single-region bucket, It will throw an error.</summary>
    [JsonPropertyName("rpo")]
    public string? Rpo { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The bucket&apos;s soft delete policy, which defines the period of time that soft-deleted objects will be retained, and cannot be permanently deleted. Structure is documented below.</summary>
    [JsonPropertyName("softDeletePolicy")]
    public V1beta2BucketStatusAtProviderSoftDeletePolicy? SoftDeletePolicy { get; set; }

    /// <summary>The Storage Class of the new bucket. Supported values include: STANDARD, MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE.</summary>
    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }

    /// <summary>A map of key/value label pairs to assign to the bucket.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>(Computed) The creation time of the bucket in RFC 3339 format.</summary>
    [JsonPropertyName("timeCreated")]
    public string? TimeCreated { get; set; }

    /// <summary>Enables Uniform bucket-level access access to a bucket.</summary>
    [JsonPropertyName("uniformBucketLevelAccess")]
    public bool? UniformBucketLevelAccess { get; set; }

    /// <summary>(Computed) The time at which the bucket&apos;s metadata or IAM policy was last updated, in RFC 3339 format.</summary>
    [JsonPropertyName("updated")]
    public string? Updated { get; set; }

    /// <summary>The base URL of the bucket, in the format gs://&lt;bucket-name&gt;.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The bucket&apos;s Versioning configuration.  Structure is documented below.</summary>
    [JsonPropertyName("versioning")]
    public V1beta2BucketStatusAtProviderVersioning? Versioning { get; set; }

    /// <summary>Configuration if the bucket acts as a website. Structure is documented below.</summary>
    [JsonPropertyName("website")]
    public V1beta2BucketStatusAtProviderWebsite? Website { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatusConditions
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

/// <summary>BucketStatus defines the observed state of Bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2BucketStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2BucketStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Bucket is the Schema for the Buckets API. Creates a new bucket in Google Cloud Storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Bucket : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2BucketSpec>, IStatus<V1beta2BucketStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Bucket";
    public const string KubeGroup = "storage.gcp.upbound.io";
    public const string KubePluralName = "buckets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Bucket";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BucketSpec defines the desired state of Bucket</summary>
    [JsonPropertyName("spec")]
    public required V1beta2BucketSpec Spec { get; set; }

    /// <summary>BucketStatus defines the observed state of Bucket.</summary>
    [JsonPropertyName("status")]
    public V1beta2BucketStatus? Status { get; set; }
}
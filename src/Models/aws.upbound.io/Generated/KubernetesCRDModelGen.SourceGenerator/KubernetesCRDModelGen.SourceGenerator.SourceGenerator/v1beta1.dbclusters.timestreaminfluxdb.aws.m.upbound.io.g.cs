#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.timestreaminfluxdb.aws.m.upbound.io;
/// <summary>DBCluster is the Schema for the DBClusters API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DBClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DBCluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DBClusterList";
    public const string KubeGroup = "timestreaminfluxdb.aws.m.upbound.io";
    public const string KubePluralName = "dbclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "timestreaminfluxdb.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1DBCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1DBCluster> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolutionEnum>))]
public enum V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolveEnum>))]
public enum V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Configuration for S3 bucket log delivery.
/// Configuration for S3 bucket log delivery.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3Configuration
{
    /// <summary>
    /// Name of the S3 bucket to deliver logs to.
    /// The name of the S3 bucket to deliver logs to.
    /// </summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>
    /// Indicates whether log delivery to the S3 bucket is enabled.
    /// Indicates whether log delivery to the S3 bucket is enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Configuration for sending InfluxDB engine logs to a specified S3 bucket. This argument is updatable.
/// Configuration for sending InfluxDB engine logs to a specified S3 bucket.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecForProviderLogDeliveryConfiguration
{
    /// <summary>
    /// Configuration for S3 bucket log delivery.
    /// Configuration for S3 bucket log delivery.
    /// </summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DBClusterSpecForProviderLogDeliveryConfigurationS3Configuration? S3Configuration { get; set; }
}

/// <summary>
/// Password of the initial admin user created in InfluxDB. This password will allow you to access the InfluxDB UI to perform various administrative tasks and also use the InfluxDB CLI to create an operator token. Along with bucket, username, and organization, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group) as the AWS API rejects it.
/// Password of the initial admin user created in InfluxDB. This password will
/// allow you to access the InfluxDB UI to perform various administrative tasks and
/// also use the InfluxDB CLI to create an operator token. Along with bucket, username,
/// and organization, this argument will be stored in the secret referred to by the
/// influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters
/// (when using an InfluxDB V3 db parameter group) as the AWS API rejects it.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecForProviderPasswordSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsRefsPolicyResolutionEnum>))]
public enum V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsRefsPolicyResolveEnum>))]
public enum V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsSelectorPolicyResolveEnum>))]
public enum V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecForProviderVpcSubnetIdsRefsPolicyResolutionEnum>))]
public enum V1beta1DBClusterSpecForProviderVpcSubnetIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecForProviderVpcSubnetIdsRefsPolicyResolveEnum>))]
public enum V1beta1DBClusterSpecForProviderVpcSubnetIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecForProviderVpcSubnetIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBClusterSpecForProviderVpcSubnetIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBClusterSpecForProviderVpcSubnetIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecForProviderVpcSubnetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBClusterSpecForProviderVpcSubnetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecForProviderVpcSubnetIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1DBClusterSpecForProviderVpcSubnetIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecForProviderVpcSubnetIdsSelectorPolicyResolveEnum>))]
public enum V1beta1DBClusterSpecForProviderVpcSubnetIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecForProviderVpcSubnetIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBClusterSpecForProviderVpcSubnetIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBClusterSpecForProviderVpcSubnetIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate vpcSubnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecForProviderVpcSubnetIdsSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBClusterSpecForProviderVpcSubnetIdsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecForProvider
{
    /// <summary>
    /// Amount of storage in GiB (gibibytes). The minimum value is 20, the maximum value is 16384. The argument db_storage_type places restrictions on this argument&apos;s minimum value. The following is a list of db_storage_type values and the corresponding minimum value for allocated_storage: &quot;InfluxIOIncludedT1&quot;: 20, &quot;InfluxIOIncludedT2&quot; and &quot;InfluxIOIncludedT3&quot;: 400`. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// The amount of storage to allocate for your DB storage type in GiB (gibibytes).
    /// This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// </summary>
    [JsonPropertyName("allocatedStorage")]
    public double? AllocatedStorage { get; set; }

    /// <summary>
    /// Name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket. A bucket combines the concept of a database and a retention period (the duration of time that each data point persists). A bucket belongs to an organization. Along with organization, username, and password, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// Name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket.
    /// A bucket combines the concept of a database and a retention period (the duration of time
    /// that each data point persists). A bucket belongs to an organization. Along with organization,
    /// username, and password, this argument will be stored in the secret referred to by the
    /// influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters
    /// (when using an InfluxDB V3 db parameter group).
    /// </summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>
    /// Timestream for InfluxDB DB instance type to run InfluxDB on. Valid options are: &quot;db.influx.medium&quot;, &quot;db.influx.large&quot;, &quot;db.influx.xlarge&quot;, &quot;db.influx.2xlarge&quot;, &quot;db.influx.4xlarge&quot;, &quot;db.influx.8xlarge&quot;, &quot;db.influx.12xlarge&quot;, and &quot;db.influx.16xlarge&quot;. This argument is updatable.
    /// The Timestream for InfluxDB DB instance type to run InfluxDB on.
    /// </summary>
    [JsonPropertyName("dbInstanceType")]
    public string? DbInstanceType { get; set; }

    /// <summary>
    /// ID of the DB parameter group assigned to your cluster. This argument is updatable. If added to an existing Timestream for InfluxDB cluster or given a new value, will cause an in-place update to the cluster. However, if a cluster already has a value for db_parameter_group_identifier, removing db_parameter_group_identifier will cause the cluster to be destroyed and recreated.
    /// The ID of the DB parameter group to assign to your DB cluster.
    /// DB parameter groups specify how the database is configured. For example, DB parameter groups
    /// can specify the limit for query concurrency.
    /// </summary>
    [JsonPropertyName("dbParameterGroupIdentifier")]
    public string? DbParameterGroupIdentifier { get; set; }

    /// <summary>
    /// (Default &quot;InfluxIOIncludedT1&quot;) Timestream for InfluxDB DB storage type to read and write InfluxDB data. You can choose between 3 different types of provisioned Influx IOPS included storage according to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS, Influx IO Included 16000 IOPS. Valid options are: &quot;InfluxIOIncludedT1&quot;, &quot;InfluxIOIncludedT2&quot;, and &quot;InfluxIOIncludedT3&quot;. If you use &quot;InfluxIOIncludedT2&quot; or &quot;InfluxIOIncludedT3&quot;, the minimum value for allocated_storage` is 400.
    /// The Timestream for InfluxDB DB storage type to read and write InfluxDB data.
    /// You can choose between 3 different types of provisioned Influx IOPS included storage according
    /// to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS,
    /// Influx IO Included 16000 IOPS.
    /// </summary>
    [JsonPropertyName("dbStorageType")]
    public string? DbStorageType { get; set; }

    /// <summary>
    /// (Default &quot;MULTI_NODE_READ_REPLICAS&quot; for InfluxDB V2 clusters) Specifies the type of cluster to create. Valid options are: &quot;MULTI_NODE_READ_REPLICAS&quot;. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// Specifies the type of cluster to create. This field is forbidden for InfluxDB V3 clusters
    /// (when using an InfluxDB V3 db parameter group).
    /// </summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>
    /// (Default &quot;AUTOMATIC&quot;) Specifies the behavior of failure recovery when the primary node of the cluster fails. Valid options are: &quot;AUTOMATIC&quot; and &quot;NO_FAILOVER&quot;.
    /// Specifies the behavior of failure recovery when the primary node of the cluster
    /// fails.
    /// </summary>
    [JsonPropertyName("failoverMode")]
    public string? FailoverMode { get; set; }

    /// <summary>
    /// Configuration for sending InfluxDB engine logs to a specified S3 bucket. This argument is updatable.
    /// Configuration for sending InfluxDB engine logs to a specified S3 bucket.
    /// </summary>
    [JsonPropertyName("logDeliveryConfiguration")]
    public V1beta1DBClusterSpecForProviderLogDeliveryConfiguration? LogDeliveryConfiguration { get; set; }

    /// <summary>
    /// Name that uniquely identifies the DB cluster when interacting with the Amazon Timestream for InfluxDB API and CLI commands. This name will also be a prefix included in the endpoint. Cluster names must be unique per customer and per region. The argument must start with a letter, cannot contain consecutive hyphens (-) and cannot end with a hyphen.
    /// The name that uniquely identifies the DB cluster when interacting with the
    /// Amazon Timestream for InfluxDB API and CLI commands. This name will also be a
    /// prefix included in the endpoint. DB cluster names must be unique per customer
    /// and per region.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Specifies whether the network type of the Timestream for InfluxDB cluster is IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate over both IPv4 and IPv6 protocols.
    /// Specifies whether the networkType of the Timestream for InfluxDB cluster is
    /// IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate
    /// over both IPv4 and IPv6 protocols.
    /// </summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>
    /// Name of the initial organization for the initial admin user in InfluxDB. An InfluxDB organization is a workspace for a group of users. Along with bucket, username, and password, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// Name of the initial organization for the initial admin user in InfluxDB. An
    /// InfluxDB organization is a workspace for a group of users. Along with bucket, username,
    /// and password, this argument will be stored in the secret referred to by the
    /// influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters
    /// (when using an InfluxDB V3 db parameter group).
    /// </summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>
    /// Password of the initial admin user created in InfluxDB. This password will allow you to access the InfluxDB UI to perform various administrative tasks and also use the InfluxDB CLI to create an operator token. Along with bucket, username, and organization, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group) as the AWS API rejects it.
    /// Password of the initial admin user created in InfluxDB. This password will
    /// allow you to access the InfluxDB UI to perform various administrative tasks and
    /// also use the InfluxDB CLI to create an operator token. Along with bucket, username,
    /// and organization, this argument will be stored in the secret referred to by the
    /// influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters
    /// (when using an InfluxDB V3 db parameter group) as the AWS API rejects it.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1DBClusterSpecForProviderPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// (Default 8086) The port on which the cluster accepts connections. Valid values: 1024-65535. Cannot be 2375-2376, 7788-7799, 8090, or 51678-51680. This argument is updatable.
    /// The port number on which InfluxDB accepts connections.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// (Default false) Configures the DB cluster with a public IP to facilitate access. Other resources, such as a VPC, a subnet, an internet gateway, and a route table with routes, are also required to enabled public access, in addition to this argument. See &quot;Usage with Public Internet Access Enabled&quot; for an example configuration with all required resources for public internet access.
    /// Configures the Timestream for InfluxDB cluster with a public IP to facilitate access.
    /// </summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// Username of the initial admin user created in InfluxDB. Must start with a letter and can&apos;t end with a hyphen or contain two consecutive hyphens. This username will allow you to access the InfluxDB UI to perform various administrative tasks and also use the InfluxDB CLI to create an operator token. Along with bucket, organization, and password, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// Username of the initial admin user created in InfluxDB. Must start with a letter
    /// and can&apos;t end with a hyphen or contain two consecutive hyphens. This username will allow
    /// you to access the InfluxDB UI to perform various administrative tasks and also use the
    /// InfluxDB CLI to create an operator token. Along with bucket, organization, and password,
    /// this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn
    /// attribute. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// List of VPC security group IDs to associate with the cluster.
    /// A list of VPC security group IDs to associate with the Timestream for InfluxDB cluster.
    /// </summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdsRefs")]
    public IList<V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsRefs>? VpcSecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdsSelector")]
    public V1beta1DBClusterSpecForProviderVpcSecurityGroupIdsSelector? VpcSecurityGroupIdsSelector { get; set; }

    /// <summary>
    /// List of VPC subnet IDs to associate with the cluster. Provide at least two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
    /// A list of VPC subnet IDs to associate with the DB cluster. Provide at least
    /// two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
    /// </summary>
    [JsonPropertyName("vpcSubnetIds")]
    public IList<string>? VpcSubnetIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate vpcSubnetIds.</summary>
    [JsonPropertyName("vpcSubnetIdsRefs")]
    public IList<V1beta1DBClusterSpecForProviderVpcSubnetIdsRefs>? VpcSubnetIdsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate vpcSubnetIds.</summary>
    [JsonPropertyName("vpcSubnetIdsSelector")]
    public V1beta1DBClusterSpecForProviderVpcSubnetIdsSelector? VpcSubnetIdsSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolutionEnum>))]
public enum V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolveEnum>))]
public enum V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Configuration for S3 bucket log delivery.
/// Configuration for S3 bucket log delivery.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3Configuration
{
    /// <summary>
    /// Name of the S3 bucket to deliver logs to.
    /// The name of the S3 bucket to deliver logs to.
    /// </summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelector? BucketNameSelector { get; set; }

    /// <summary>
    /// Indicates whether log delivery to the S3 bucket is enabled.
    /// Indicates whether log delivery to the S3 bucket is enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Configuration for sending InfluxDB engine logs to a specified S3 bucket. This argument is updatable.
/// Configuration for sending InfluxDB engine logs to a specified S3 bucket.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecInitProviderLogDeliveryConfiguration
{
    /// <summary>
    /// Configuration for S3 bucket log delivery.
    /// Configuration for S3 bucket log delivery.
    /// </summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DBClusterSpecInitProviderLogDeliveryConfigurationS3Configuration? S3Configuration { get; set; }
}

/// <summary>
/// Password of the initial admin user created in InfluxDB. This password will allow you to access the InfluxDB UI to perform various administrative tasks and also use the InfluxDB CLI to create an operator token. Along with bucket, username, and organization, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group) as the AWS API rejects it.
/// Password of the initial admin user created in InfluxDB. This password will
/// allow you to access the InfluxDB UI to perform various administrative tasks and
/// also use the InfluxDB CLI to create an operator token. Along with bucket, username,
/// and organization, this argument will be stored in the secret referred to by the
/// influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters
/// (when using an InfluxDB V3 db parameter group) as the AWS API rejects it.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecInitProviderPasswordSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsRefsPolicyResolutionEnum>))]
public enum V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsRefsPolicyResolveEnum>))]
public enum V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsSelectorPolicyResolveEnum>))]
public enum V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecInitProviderVpcSubnetIdsRefsPolicyResolutionEnum>))]
public enum V1beta1DBClusterSpecInitProviderVpcSubnetIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecInitProviderVpcSubnetIdsRefsPolicyResolveEnum>))]
public enum V1beta1DBClusterSpecInitProviderVpcSubnetIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecInitProviderVpcSubnetIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBClusterSpecInitProviderVpcSubnetIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBClusterSpecInitProviderVpcSubnetIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecInitProviderVpcSubnetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBClusterSpecInitProviderVpcSubnetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecInitProviderVpcSubnetIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1DBClusterSpecInitProviderVpcSubnetIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecInitProviderVpcSubnetIdsSelectorPolicyResolveEnum>))]
public enum V1beta1DBClusterSpecInitProviderVpcSubnetIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecInitProviderVpcSubnetIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBClusterSpecInitProviderVpcSubnetIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBClusterSpecInitProviderVpcSubnetIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate vpcSubnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecInitProviderVpcSubnetIdsSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBClusterSpecInitProviderVpcSubnetIdsSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1DBClusterSpecInitProvider
{
    /// <summary>
    /// Amount of storage in GiB (gibibytes). The minimum value is 20, the maximum value is 16384. The argument db_storage_type places restrictions on this argument&apos;s minimum value. The following is a list of db_storage_type values and the corresponding minimum value for allocated_storage: &quot;InfluxIOIncludedT1&quot;: 20, &quot;InfluxIOIncludedT2&quot; and &quot;InfluxIOIncludedT3&quot;: 400`. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// The amount of storage to allocate for your DB storage type in GiB (gibibytes).
    /// This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// </summary>
    [JsonPropertyName("allocatedStorage")]
    public double? AllocatedStorage { get; set; }

    /// <summary>
    /// Name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket. A bucket combines the concept of a database and a retention period (the duration of time that each data point persists). A bucket belongs to an organization. Along with organization, username, and password, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// Name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket.
    /// A bucket combines the concept of a database and a retention period (the duration of time
    /// that each data point persists). A bucket belongs to an organization. Along with organization,
    /// username, and password, this argument will be stored in the secret referred to by the
    /// influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters
    /// (when using an InfluxDB V3 db parameter group).
    /// </summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>
    /// Timestream for InfluxDB DB instance type to run InfluxDB on. Valid options are: &quot;db.influx.medium&quot;, &quot;db.influx.large&quot;, &quot;db.influx.xlarge&quot;, &quot;db.influx.2xlarge&quot;, &quot;db.influx.4xlarge&quot;, &quot;db.influx.8xlarge&quot;, &quot;db.influx.12xlarge&quot;, and &quot;db.influx.16xlarge&quot;. This argument is updatable.
    /// The Timestream for InfluxDB DB instance type to run InfluxDB on.
    /// </summary>
    [JsonPropertyName("dbInstanceType")]
    public string? DbInstanceType { get; set; }

    /// <summary>
    /// ID of the DB parameter group assigned to your cluster. This argument is updatable. If added to an existing Timestream for InfluxDB cluster or given a new value, will cause an in-place update to the cluster. However, if a cluster already has a value for db_parameter_group_identifier, removing db_parameter_group_identifier will cause the cluster to be destroyed and recreated.
    /// The ID of the DB parameter group to assign to your DB cluster.
    /// DB parameter groups specify how the database is configured. For example, DB parameter groups
    /// can specify the limit for query concurrency.
    /// </summary>
    [JsonPropertyName("dbParameterGroupIdentifier")]
    public string? DbParameterGroupIdentifier { get; set; }

    /// <summary>
    /// (Default &quot;InfluxIOIncludedT1&quot;) Timestream for InfluxDB DB storage type to read and write InfluxDB data. You can choose between 3 different types of provisioned Influx IOPS included storage according to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS, Influx IO Included 16000 IOPS. Valid options are: &quot;InfluxIOIncludedT1&quot;, &quot;InfluxIOIncludedT2&quot;, and &quot;InfluxIOIncludedT3&quot;. If you use &quot;InfluxIOIncludedT2&quot; or &quot;InfluxIOIncludedT3&quot;, the minimum value for allocated_storage` is 400.
    /// The Timestream for InfluxDB DB storage type to read and write InfluxDB data.
    /// You can choose between 3 different types of provisioned Influx IOPS included storage according
    /// to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS,
    /// Influx IO Included 16000 IOPS.
    /// </summary>
    [JsonPropertyName("dbStorageType")]
    public string? DbStorageType { get; set; }

    /// <summary>
    /// (Default &quot;MULTI_NODE_READ_REPLICAS&quot; for InfluxDB V2 clusters) Specifies the type of cluster to create. Valid options are: &quot;MULTI_NODE_READ_REPLICAS&quot;. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// Specifies the type of cluster to create. This field is forbidden for InfluxDB V3 clusters
    /// (when using an InfluxDB V3 db parameter group).
    /// </summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>
    /// (Default &quot;AUTOMATIC&quot;) Specifies the behavior of failure recovery when the primary node of the cluster fails. Valid options are: &quot;AUTOMATIC&quot; and &quot;NO_FAILOVER&quot;.
    /// Specifies the behavior of failure recovery when the primary node of the cluster
    /// fails.
    /// </summary>
    [JsonPropertyName("failoverMode")]
    public string? FailoverMode { get; set; }

    /// <summary>
    /// Configuration for sending InfluxDB engine logs to a specified S3 bucket. This argument is updatable.
    /// Configuration for sending InfluxDB engine logs to a specified S3 bucket.
    /// </summary>
    [JsonPropertyName("logDeliveryConfiguration")]
    public V1beta1DBClusterSpecInitProviderLogDeliveryConfiguration? LogDeliveryConfiguration { get; set; }

    /// <summary>
    /// Name that uniquely identifies the DB cluster when interacting with the Amazon Timestream for InfluxDB API and CLI commands. This name will also be a prefix included in the endpoint. Cluster names must be unique per customer and per region. The argument must start with a letter, cannot contain consecutive hyphens (-) and cannot end with a hyphen.
    /// The name that uniquely identifies the DB cluster when interacting with the
    /// Amazon Timestream for InfluxDB API and CLI commands. This name will also be a
    /// prefix included in the endpoint. DB cluster names must be unique per customer
    /// and per region.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Specifies whether the network type of the Timestream for InfluxDB cluster is IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate over both IPv4 and IPv6 protocols.
    /// Specifies whether the networkType of the Timestream for InfluxDB cluster is
    /// IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate
    /// over both IPv4 and IPv6 protocols.
    /// </summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>
    /// Name of the initial organization for the initial admin user in InfluxDB. An InfluxDB organization is a workspace for a group of users. Along with bucket, username, and password, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// Name of the initial organization for the initial admin user in InfluxDB. An
    /// InfluxDB organization is a workspace for a group of users. Along with bucket, username,
    /// and password, this argument will be stored in the secret referred to by the
    /// influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters
    /// (when using an InfluxDB V3 db parameter group).
    /// </summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>
    /// Password of the initial admin user created in InfluxDB. This password will allow you to access the InfluxDB UI to perform various administrative tasks and also use the InfluxDB CLI to create an operator token. Along with bucket, username, and organization, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group) as the AWS API rejects it.
    /// Password of the initial admin user created in InfluxDB. This password will
    /// allow you to access the InfluxDB UI to perform various administrative tasks and
    /// also use the InfluxDB CLI to create an operator token. Along with bucket, username,
    /// and organization, this argument will be stored in the secret referred to by the
    /// influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters
    /// (when using an InfluxDB V3 db parameter group) as the AWS API rejects it.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1DBClusterSpecInitProviderPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// (Default 8086) The port on which the cluster accepts connections. Valid values: 1024-65535. Cannot be 2375-2376, 7788-7799, 8090, or 51678-51680. This argument is updatable.
    /// The port number on which InfluxDB accepts connections.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// (Default false) Configures the DB cluster with a public IP to facilitate access. Other resources, such as a VPC, a subnet, an internet gateway, and a route table with routes, are also required to enabled public access, in addition to this argument. See &quot;Usage with Public Internet Access Enabled&quot; for an example configuration with all required resources for public internet access.
    /// Configures the Timestream for InfluxDB cluster with a public IP to facilitate access.
    /// </summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// Username of the initial admin user created in InfluxDB. Must start with a letter and can&apos;t end with a hyphen or contain two consecutive hyphens. This username will allow you to access the InfluxDB UI to perform various administrative tasks and also use the InfluxDB CLI to create an operator token. Along with bucket, organization, and password, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// Username of the initial admin user created in InfluxDB. Must start with a letter
    /// and can&apos;t end with a hyphen or contain two consecutive hyphens. This username will allow
    /// you to access the InfluxDB UI to perform various administrative tasks and also use the
    /// InfluxDB CLI to create an operator token. Along with bucket, organization, and password,
    /// this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn
    /// attribute. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// List of VPC security group IDs to associate with the cluster.
    /// A list of VPC security group IDs to associate with the Timestream for InfluxDB cluster.
    /// </summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdsRefs")]
    public IList<V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsRefs>? VpcSecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdsSelector")]
    public V1beta1DBClusterSpecInitProviderVpcSecurityGroupIdsSelector? VpcSecurityGroupIdsSelector { get; set; }

    /// <summary>
    /// List of VPC subnet IDs to associate with the cluster. Provide at least two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
    /// A list of VPC subnet IDs to associate with the DB cluster. Provide at least
    /// two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
    /// </summary>
    [JsonPropertyName("vpcSubnetIds")]
    public IList<string>? VpcSubnetIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate vpcSubnetIds.</summary>
    [JsonPropertyName("vpcSubnetIdsRefs")]
    public IList<V1beta1DBClusterSpecInitProviderVpcSubnetIdsRefs>? VpcSubnetIdsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate vpcSubnetIds.</summary>
    [JsonPropertyName("vpcSubnetIdsSelector")]
    public V1beta1DBClusterSpecInitProviderVpcSubnetIdsSelector? VpcSubnetIdsSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBClusterSpecManagementPoliciesEnum>))]
public enum V1beta1DBClusterSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>DBClusterSpec defines the desired state of DBCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1DBClusterSpecForProvider ForProvider { get; set; }

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
    public V1beta1DBClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DBClusterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DBClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DBClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Configuration for S3 bucket log delivery.
/// Configuration for S3 bucket log delivery.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterStatusAtProviderLogDeliveryConfigurationS3Configuration
{
    /// <summary>
    /// Name of the S3 bucket to deliver logs to.
    /// The name of the S3 bucket to deliver logs to.
    /// </summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>
    /// Indicates whether log delivery to the S3 bucket is enabled.
    /// Indicates whether log delivery to the S3 bucket is enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Configuration for sending InfluxDB engine logs to a specified S3 bucket. This argument is updatable.
/// Configuration for sending InfluxDB engine logs to a specified S3 bucket.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterStatusAtProviderLogDeliveryConfiguration
{
    /// <summary>
    /// Configuration for S3 bucket log delivery.
    /// Configuration for S3 bucket log delivery.
    /// </summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DBClusterStatusAtProviderLogDeliveryConfigurationS3Configuration? S3Configuration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterStatusAtProvider
{
    /// <summary>
    /// Amount of storage in GiB (gibibytes). The minimum value is 20, the maximum value is 16384. The argument db_storage_type places restrictions on this argument&apos;s minimum value. The following is a list of db_storage_type values and the corresponding minimum value for allocated_storage: &quot;InfluxIOIncludedT1&quot;: 20, &quot;InfluxIOIncludedT2&quot; and &quot;InfluxIOIncludedT3&quot;: 400`. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// The amount of storage to allocate for your DB storage type in GiB (gibibytes).
    /// This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// </summary>
    [JsonPropertyName("allocatedStorage")]
    public double? AllocatedStorage { get; set; }

    /// <summary>ARN of the Timestream for InfluxDB cluster.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// Name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket. A bucket combines the concept of a database and a retention period (the duration of time that each data point persists). A bucket belongs to an organization. Along with organization, username, and password, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// Name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket.
    /// A bucket combines the concept of a database and a retention period (the duration of time
    /// that each data point persists). A bucket belongs to an organization. Along with organization,
    /// username, and password, this argument will be stored in the secret referred to by the
    /// influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters
    /// (when using an InfluxDB V3 db parameter group).
    /// </summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>
    /// Timestream for InfluxDB DB instance type to run InfluxDB on. Valid options are: &quot;db.influx.medium&quot;, &quot;db.influx.large&quot;, &quot;db.influx.xlarge&quot;, &quot;db.influx.2xlarge&quot;, &quot;db.influx.4xlarge&quot;, &quot;db.influx.8xlarge&quot;, &quot;db.influx.12xlarge&quot;, and &quot;db.influx.16xlarge&quot;. This argument is updatable.
    /// The Timestream for InfluxDB DB instance type to run InfluxDB on.
    /// </summary>
    [JsonPropertyName("dbInstanceType")]
    public string? DbInstanceType { get; set; }

    /// <summary>
    /// ID of the DB parameter group assigned to your cluster. This argument is updatable. If added to an existing Timestream for InfluxDB cluster or given a new value, will cause an in-place update to the cluster. However, if a cluster already has a value for db_parameter_group_identifier, removing db_parameter_group_identifier will cause the cluster to be destroyed and recreated.
    /// The ID of the DB parameter group to assign to your DB cluster.
    /// DB parameter groups specify how the database is configured. For example, DB parameter groups
    /// can specify the limit for query concurrency.
    /// </summary>
    [JsonPropertyName("dbParameterGroupIdentifier")]
    public string? DbParameterGroupIdentifier { get; set; }

    /// <summary>
    /// (Default &quot;InfluxIOIncludedT1&quot;) Timestream for InfluxDB DB storage type to read and write InfluxDB data. You can choose between 3 different types of provisioned Influx IOPS included storage according to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS, Influx IO Included 16000 IOPS. Valid options are: &quot;InfluxIOIncludedT1&quot;, &quot;InfluxIOIncludedT2&quot;, and &quot;InfluxIOIncludedT3&quot;. If you use &quot;InfluxIOIncludedT2&quot; or &quot;InfluxIOIncludedT3&quot;, the minimum value for allocated_storage` is 400.
    /// The Timestream for InfluxDB DB storage type to read and write InfluxDB data.
    /// You can choose between 3 different types of provisioned Influx IOPS included storage according
    /// to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS,
    /// Influx IO Included 16000 IOPS.
    /// </summary>
    [JsonPropertyName("dbStorageType")]
    public string? DbStorageType { get; set; }

    /// <summary>
    /// (Default &quot;MULTI_NODE_READ_REPLICAS&quot; for InfluxDB V2 clusters) Specifies the type of cluster to create. Valid options are: &quot;MULTI_NODE_READ_REPLICAS&quot;. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// Specifies the type of cluster to create. This field is forbidden for InfluxDB V3 clusters
    /// (when using an InfluxDB V3 db parameter group).
    /// </summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>
    /// Endpoint used to connect to InfluxDB. The default InfluxDB port is 8086.
    /// The endpoint used to connect to InfluxDB. The default InfluxDB port is 8086.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>
    /// Database engine type of the DB cluster.
    /// The database engine type of the DB cluster.
    /// </summary>
    [JsonPropertyName("engineType")]
    public string? EngineType { get; set; }

    /// <summary>
    /// (Default &quot;AUTOMATIC&quot;) Specifies the behavior of failure recovery when the primary node of the cluster fails. Valid options are: &quot;AUTOMATIC&quot; and &quot;NO_FAILOVER&quot;.
    /// Specifies the behavior of failure recovery when the primary node of the cluster
    /// fails.
    /// </summary>
    [JsonPropertyName("failoverMode")]
    public string? FailoverMode { get; set; }

    /// <summary>ID of the Timestream for InfluxDB cluster.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// ARN of the AWS Secrets Manager secret containing the initial InfluxDB authorization parameters. For InfluxDB V2 clusters, the secret value is a JSON formatted key-value pair holding InfluxDB authorization values: organization, bucket, username, and password. For InfluxDB V3 clusters, the secret contains the InfluxDB admin token.
    /// The Amazon Resource Name (ARN) of the AWS Secrets Manager secret containing the
    /// initial InfluxDB authorization parameters. For InfluxDB V2 clusters, the secret value is a JSON
    /// formatted key-value pair holding InfluxDB authorization values: organization, bucket,
    /// username, and password. For InfluxDB V3 clusters, the secret contains the InfluxDB admin token.
    /// </summary>
    [JsonPropertyName("influxAuthParametersSecretArn")]
    public string? InfluxAuthParametersSecretArn { get; set; }

    /// <summary>
    /// Configuration for sending InfluxDB engine logs to a specified S3 bucket. This argument is updatable.
    /// Configuration for sending InfluxDB engine logs to a specified S3 bucket.
    /// </summary>
    [JsonPropertyName("logDeliveryConfiguration")]
    public V1beta1DBClusterStatusAtProviderLogDeliveryConfiguration? LogDeliveryConfiguration { get; set; }

    /// <summary>
    /// Name that uniquely identifies the DB cluster when interacting with the Amazon Timestream for InfluxDB API and CLI commands. This name will also be a prefix included in the endpoint. Cluster names must be unique per customer and per region. The argument must start with a letter, cannot contain consecutive hyphens (-) and cannot end with a hyphen.
    /// The name that uniquely identifies the DB cluster when interacting with the
    /// Amazon Timestream for InfluxDB API and CLI commands. This name will also be a
    /// prefix included in the endpoint. DB cluster names must be unique per customer
    /// and per region.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Specifies whether the network type of the Timestream for InfluxDB cluster is IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate over both IPv4 and IPv6 protocols.
    /// Specifies whether the networkType of the Timestream for InfluxDB cluster is
    /// IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate
    /// over both IPv4 and IPv6 protocols.
    /// </summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>
    /// Name of the initial organization for the initial admin user in InfluxDB. An InfluxDB organization is a workspace for a group of users. Along with bucket, username, and password, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// Name of the initial organization for the initial admin user in InfluxDB. An
    /// InfluxDB organization is a workspace for a group of users. Along with bucket, username,
    /// and password, this argument will be stored in the secret referred to by the
    /// influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters
    /// (when using an InfluxDB V3 db parameter group).
    /// </summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>
    /// (Default 8086) The port on which the cluster accepts connections. Valid values: 1024-65535. Cannot be 2375-2376, 7788-7799, 8090, or 51678-51680. This argument is updatable.
    /// The port number on which InfluxDB accepts connections.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// (Default false) Configures the DB cluster with a public IP to facilitate access. Other resources, such as a VPC, a subnet, an internet gateway, and a route table with routes, are also required to enabled public access, in addition to this argument. See &quot;Usage with Public Internet Access Enabled&quot; for an example configuration with all required resources for public internet access.
    /// Configures the Timestream for InfluxDB cluster with a public IP to facilitate access.
    /// </summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>
    /// The endpoint used to connect to the Timestream for InfluxDB cluster for read-only operations.
    /// The endpoint used to connect to the Timestream for InfluxDB cluster for
    /// read-only operations.
    /// </summary>
    [JsonPropertyName("readerEndpoint")]
    public string? ReaderEndpoint { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>
    /// Username of the initial admin user created in InfluxDB. Must start with a letter and can&apos;t end with a hyphen or contain two consecutive hyphens. This username will allow you to access the InfluxDB UI to perform various administrative tasks and also use the InfluxDB CLI to create an operator token. Along with bucket, organization, and password, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// Username of the initial admin user created in InfluxDB. Must start with a letter
    /// and can&apos;t end with a hyphen or contain two consecutive hyphens. This username will allow
    /// you to access the InfluxDB UI to perform various administrative tasks and also use the
    /// InfluxDB CLI to create an operator token. Along with bucket, organization, and password,
    /// this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn
    /// attribute. This field is forbidden for InfluxDB V3 clusters (when using an InfluxDB V3 db parameter group).
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// List of VPC security group IDs to associate with the cluster.
    /// A list of VPC security group IDs to associate with the Timestream for InfluxDB cluster.
    /// </summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    /// <summary>
    /// List of VPC subnet IDs to associate with the cluster. Provide at least two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
    /// A list of VPC subnet IDs to associate with the DB cluster. Provide at least
    /// two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
    /// </summary>
    [JsonPropertyName("vpcSubnetIds")]
    public IList<string>? VpcSubnetIds { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterStatusConditions
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

/// <summary>DBClusterStatus defines the observed state of DBCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBClusterStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1DBClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DBClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DBCluster is the Schema for the DBClusters API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DBCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DBClusterSpec>, IStatus<V1beta1DBClusterStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DBCluster";
    public const string KubeGroup = "timestreaminfluxdb.aws.m.upbound.io";
    public const string KubePluralName = "dbclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "timestreaminfluxdb.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DBClusterSpec defines the desired state of DBCluster</summary>
    [JsonPropertyName("spec")]
    public required V1beta1DBClusterSpec Spec { get; set; }

    /// <summary>DBClusterStatus defines the observed state of DBCluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1DBClusterStatus? Status { get; set; }
}
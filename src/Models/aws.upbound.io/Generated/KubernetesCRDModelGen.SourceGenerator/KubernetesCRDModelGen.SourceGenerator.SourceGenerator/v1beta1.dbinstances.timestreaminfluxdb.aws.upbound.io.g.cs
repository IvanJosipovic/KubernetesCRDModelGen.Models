#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.timestreaminfluxdb.aws.upbound.io;
/// <summary>DBInstance is the Schema for the DBInstances API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DBInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DBInstance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DBInstanceList";
    public const string KubeGroup = "timestreaminfluxdb.aws.upbound.io";
    public const string KubePluralName = "dbinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "timestreaminfluxdb.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBInstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1DBInstance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1DBInstance> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecDeletionPolicyEnum>))]
public enum V1beta1DBInstanceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolutionEnum>))]
public enum V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolveEnum>))]
public enum V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelector
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
    public V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Configuration for S3 bucket log delivery.
/// Configuration for S3 bucket log delivery.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3Configuration
{
    /// <summary>
    /// Name of the S3 bucket to deliver logs to.
    /// The name of the S3 bucket to deliver logs to.
    /// </summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelector? BucketNameSelector { get; set; }

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
public partial class V1beta1DBInstanceSpecForProviderLogDeliveryConfiguration
{
    /// <summary>
    /// Configuration for S3 bucket log delivery.
    /// Configuration for S3 bucket log delivery.
    /// </summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DBInstanceSpecForProviderLogDeliveryConfigurationS3Configuration? S3Configuration { get; set; }
}

/// <summary>
/// Password of the initial admin user created in InfluxDB. This password will allow you to access the InfluxDB UI to perform various administrative tasks and also use the InfluxDB CLI to create an operator token. Along with bucket, username, and organization, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute.
/// The password of the initial admin user created in InfluxDB. This password will
/// allow you to access the InfluxDB UI to perform various administrative tasks and
/// also use the InfluxDB CLI to create an operator token. These attributes will be
/// stored in a Secret created in AWS SecretManager in your account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecForProviderPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsRefsPolicyResolutionEnum>))]
public enum V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsRefsPolicyResolveEnum>))]
public enum V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsSelectorPolicyResolveEnum>))]
public enum V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsSelector
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
    public V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecForProviderVpcSubnetIdsRefsPolicyResolutionEnum>))]
public enum V1beta1DBInstanceSpecForProviderVpcSubnetIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecForProviderVpcSubnetIdsRefsPolicyResolveEnum>))]
public enum V1beta1DBInstanceSpecForProviderVpcSubnetIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecForProviderVpcSubnetIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBInstanceSpecForProviderVpcSubnetIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBInstanceSpecForProviderVpcSubnetIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecForProviderVpcSubnetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBInstanceSpecForProviderVpcSubnetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecForProviderVpcSubnetIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1DBInstanceSpecForProviderVpcSubnetIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecForProviderVpcSubnetIdsSelectorPolicyResolveEnum>))]
public enum V1beta1DBInstanceSpecForProviderVpcSubnetIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecForProviderVpcSubnetIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBInstanceSpecForProviderVpcSubnetIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBInstanceSpecForProviderVpcSubnetIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate vpcSubnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecForProviderVpcSubnetIdsSelector
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
    public V1beta1DBInstanceSpecForProviderVpcSubnetIdsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecForProvider
{
    /// <summary>
    /// Amount of storage in GiB (gibibytes). The minimum value is 20, the maximum value is 16384. This argument is updatable. The argument db_storage_type places restrictions on this argument&apos;s minimum value. The following is a list of db_storage_type values and the corresponding minimum value for allocated_storage: &quot;InfluxIOIncludedT1&quot;: 20, &quot;InfluxIOIncludedT2&quot; and &quot;InfluxIOIncludedT3&quot;: 400`.
    /// The amount of storage to allocate for your DB storage type in GiB (gibibytes).
    /// </summary>
    [JsonPropertyName("allocatedStorage")]
    public double? AllocatedStorage { get; set; }

    /// <summary>
    /// Name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket. A bucket combines the concept of a database and a retention period (the duration of time that each data point persists). A bucket belongs to an organization. Along with organization, username, and password, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute.
    /// The name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket.
    /// A bucket combines the concept of a database and a retention period (the duration of time
    /// that each data point persists). A bucket belongs to an organization.
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
    /// ID of the DB parameter group assigned to your DB instance. This argument is updatable. If added to an existing Timestream for InfluxDB instance or given a new value, will cause an in-place update to the instance. However, if an instance already has a value for db_parameter_group_identifier, removing db_parameter_group_identifier will cause the instance to be destroyed and recreated.
    /// The id of the DB parameter group assigned to your DB instance.
    /// </summary>
    [JsonPropertyName("dbParameterGroupIdentifier")]
    public string? DbParameterGroupIdentifier { get; set; }

    /// <summary>
    /// (Default &quot;InfluxIOIncludedT1&quot;) Timestream for InfluxDB DB storage type to read and write InfluxDB data. You can choose between 3 different types of provisioned Influx IOPS included storage according to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS, Influx IO Included 16000 IOPS. Valid options are: &quot;InfluxIOIncludedT1&quot;, &quot;InfluxIOIncludedT2&quot;, and &quot;InfluxIOIncludedT3&quot;. If you use &quot;InfluxIOIncludedT2&quot; or &quot;InfluxIOIncludedT3&quot;, the minimum value for allocated_storage` is 400. This argument is updatable. For a single instance, after this argument has been updated once, it can only be updated again after 6 hours have passed.
    /// The Timestream for InfluxDB DB storage type to read and write InfluxDB data.
    /// You can choose between 3 different types of provisioned Influx IOPS included storage according
    /// to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS,
    /// Influx IO Included 16000 IOPS.
    /// </summary>
    [JsonPropertyName("dbStorageType")]
    public string? DbStorageType { get; set; }

    /// <summary>
    /// (Default &quot;SINGLE_AZ&quot;) Specifies whether the DB instance will be deployed as a standalone instance or with a Multi-AZ standby for high availability. Valid options are: &quot;SINGLE_AZ&quot;, &quot;WITH_MULTIAZ_STANDBY&quot;. This argument is updatable.
    /// Specifies whether the DB instance will be deployed as a standalone instance or
    /// with a Multi-AZ standby for high availability.
    /// </summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>
    /// Configuration for sending InfluxDB engine logs to a specified S3 bucket. This argument is updatable.
    /// Configuration for sending InfluxDB engine logs to a specified S3 bucket.
    /// </summary>
    [JsonPropertyName("logDeliveryConfiguration")]
    public V1beta1DBInstanceSpecForProviderLogDeliveryConfiguration? LogDeliveryConfiguration { get; set; }

    /// <summary>
    /// Name that uniquely identifies the DB instance when interacting with the Amazon Timestream for InfluxDB API and CLI commands. This name will also be a prefix included in the endpoint. DB instance names must be unique per customer and per region. The argument must start with a letter, cannot contain consecutive hyphens (-) and cannot end with a hyphen.
    /// The name that uniquely identifies the DB instance when interacting with the
    /// Amazon Timestream for InfluxDB API and CLI commands. This name will also be a
    /// prefix included in the endpoint. DB instance names must be unique per customer
    /// and per region.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Specifies whether the networkType of the Timestream for InfluxDB instance is IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate over both IPv4 and IPv6 protocols.
    /// Specifies whether the networkType of the Timestream for InfluxDB instance is
    /// IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate
    /// over both IPv4 and IPv6 protocols.
    /// </summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>
    /// Name of the initial organization for the initial admin user in InfluxDB. An InfluxDB organization is a workspace for a group of users. Along with bucket, username, and password, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute.
    /// The name of the initial organization for the initial admin user in InfluxDB. An
    /// InfluxDB organization is a workspace for a group of users.
    /// </summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>
    /// Password of the initial admin user created in InfluxDB. This password will allow you to access the InfluxDB UI to perform various administrative tasks and also use the InfluxDB CLI to create an operator token. Along with bucket, username, and organization, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute.
    /// The password of the initial admin user created in InfluxDB. This password will
    /// allow you to access the InfluxDB UI to perform various administrative tasks and
    /// also use the InfluxDB CLI to create an operator token. These attributes will be
    /// stored in a Secret created in AWS SecretManager in your account.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1DBInstanceSpecForProviderPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// (Default 8086) The port on which the instance accepts connections. Valid values: 1024-65535. Cannot be 2375-2376, 7788-7799, 8090, or 51678-51680. This argument is updatable.
    /// The port number on which InfluxDB accepts connections.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// (Default false) Configures the DB instance with a public IP to facilitate access. Other resources, such as a VPC, a subnet, an internet gateway, and a route table with routes, are also required to enabled public access, in addition to this argument. See &quot;Usage with Public Internet Access Enabled&quot; for an example configuration with all required resources for public internet access.
    /// Configures the DB instance with a public IP to facilitate access.
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
    /// Username of the initial admin user created in InfluxDB. Must start with a letter and can&apos;t end with a hyphen or contain two consecutive hyphens. This username will allow you to access the InfluxDB UI to perform various administrative tasks and also use the InfluxDB CLI to create an operator token. Along with bucket, organization, and password, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute.
    /// The username of the initial admin user created in InfluxDB.
    /// Must start with a letter and can&apos;t end with a hyphen or contain two
    /// consecutive hyphens. For example, my-user1. This username will allow
    /// you to access the InfluxDB UI to perform various administrative tasks
    /// and also use the InfluxDB CLI to create an operator token. These
    /// attributes will be stored in a Secret created in Amazon Secrets
    /// Manager in your account
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// List of VPC security group IDs to associate with the DB instance.
    /// A list of VPC security group IDs to associate with the DB instance.
    /// </summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdsRefs")]
    public IList<V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsRefs>? VpcSecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdsSelector")]
    public V1beta1DBInstanceSpecForProviderVpcSecurityGroupIdsSelector? VpcSecurityGroupIdsSelector { get; set; }

    /// <summary>
    /// List of VPC subnet IDs to associate with the DB instance. Provide at least two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
    /// A list of VPC subnet IDs to associate with the DB instance. Provide at least
    /// two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
    /// </summary>
    [JsonPropertyName("vpcSubnetIds")]
    public IList<string>? VpcSubnetIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate vpcSubnetIds.</summary>
    [JsonPropertyName("vpcSubnetIdsRefs")]
    public IList<V1beta1DBInstanceSpecForProviderVpcSubnetIdsRefs>? VpcSubnetIdsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate vpcSubnetIds.</summary>
    [JsonPropertyName("vpcSubnetIdsSelector")]
    public V1beta1DBInstanceSpecForProviderVpcSubnetIdsSelector? VpcSubnetIdsSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolutionEnum>))]
public enum V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolveEnum>))]
public enum V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolutionEnum>))]
public enum V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolveEnum>))]
public enum V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelector
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
    public V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Configuration for S3 bucket log delivery.
/// Configuration for S3 bucket log delivery.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3Configuration
{
    /// <summary>
    /// Name of the S3 bucket to deliver logs to.
    /// The name of the S3 bucket to deliver logs to.
    /// </summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameRef")]
    public V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameRef? BucketNameRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucketName.</summary>
    [JsonPropertyName("bucketNameSelector")]
    public V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3ConfigurationBucketNameSelector? BucketNameSelector { get; set; }

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
public partial class V1beta1DBInstanceSpecInitProviderLogDeliveryConfiguration
{
    /// <summary>
    /// Configuration for S3 bucket log delivery.
    /// Configuration for S3 bucket log delivery.
    /// </summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DBInstanceSpecInitProviderLogDeliveryConfigurationS3Configuration? S3Configuration { get; set; }
}

/// <summary>
/// Password of the initial admin user created in InfluxDB. This password will allow you to access the InfluxDB UI to perform various administrative tasks and also use the InfluxDB CLI to create an operator token. Along with bucket, username, and organization, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute.
/// The password of the initial admin user created in InfluxDB. This password will
/// allow you to access the InfluxDB UI to perform various administrative tasks and
/// also use the InfluxDB CLI to create an operator token. These attributes will be
/// stored in a Secret created in AWS SecretManager in your account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecInitProviderPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsRefsPolicyResolutionEnum>))]
public enum V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsRefsPolicyResolveEnum>))]
public enum V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsSelectorPolicyResolveEnum>))]
public enum V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsSelector
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
    public V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecInitProviderVpcSubnetIdsRefsPolicyResolutionEnum>))]
public enum V1beta1DBInstanceSpecInitProviderVpcSubnetIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecInitProviderVpcSubnetIdsRefsPolicyResolveEnum>))]
public enum V1beta1DBInstanceSpecInitProviderVpcSubnetIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecInitProviderVpcSubnetIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBInstanceSpecInitProviderVpcSubnetIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBInstanceSpecInitProviderVpcSubnetIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecInitProviderVpcSubnetIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBInstanceSpecInitProviderVpcSubnetIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecInitProviderVpcSubnetIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1DBInstanceSpecInitProviderVpcSubnetIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecInitProviderVpcSubnetIdsSelectorPolicyResolveEnum>))]
public enum V1beta1DBInstanceSpecInitProviderVpcSubnetIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecInitProviderVpcSubnetIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBInstanceSpecInitProviderVpcSubnetIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBInstanceSpecInitProviderVpcSubnetIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate vpcSubnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecInitProviderVpcSubnetIdsSelector
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
    public V1beta1DBInstanceSpecInitProviderVpcSubnetIdsSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1DBInstanceSpecInitProvider
{
    /// <summary>
    /// Amount of storage in GiB (gibibytes). The minimum value is 20, the maximum value is 16384. This argument is updatable. The argument db_storage_type places restrictions on this argument&apos;s minimum value. The following is a list of db_storage_type values and the corresponding minimum value for allocated_storage: &quot;InfluxIOIncludedT1&quot;: 20, &quot;InfluxIOIncludedT2&quot; and &quot;InfluxIOIncludedT3&quot;: 400`.
    /// The amount of storage to allocate for your DB storage type in GiB (gibibytes).
    /// </summary>
    [JsonPropertyName("allocatedStorage")]
    public double? AllocatedStorage { get; set; }

    /// <summary>
    /// Name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket. A bucket combines the concept of a database and a retention period (the duration of time that each data point persists). A bucket belongs to an organization. Along with organization, username, and password, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute.
    /// The name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket.
    /// A bucket combines the concept of a database and a retention period (the duration of time
    /// that each data point persists). A bucket belongs to an organization.
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
    /// ID of the DB parameter group assigned to your DB instance. This argument is updatable. If added to an existing Timestream for InfluxDB instance or given a new value, will cause an in-place update to the instance. However, if an instance already has a value for db_parameter_group_identifier, removing db_parameter_group_identifier will cause the instance to be destroyed and recreated.
    /// The id of the DB parameter group assigned to your DB instance.
    /// </summary>
    [JsonPropertyName("dbParameterGroupIdentifier")]
    public string? DbParameterGroupIdentifier { get; set; }

    /// <summary>
    /// (Default &quot;InfluxIOIncludedT1&quot;) Timestream for InfluxDB DB storage type to read and write InfluxDB data. You can choose between 3 different types of provisioned Influx IOPS included storage according to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS, Influx IO Included 16000 IOPS. Valid options are: &quot;InfluxIOIncludedT1&quot;, &quot;InfluxIOIncludedT2&quot;, and &quot;InfluxIOIncludedT3&quot;. If you use &quot;InfluxIOIncludedT2&quot; or &quot;InfluxIOIncludedT3&quot;, the minimum value for allocated_storage` is 400. This argument is updatable. For a single instance, after this argument has been updated once, it can only be updated again after 6 hours have passed.
    /// The Timestream for InfluxDB DB storage type to read and write InfluxDB data.
    /// You can choose between 3 different types of provisioned Influx IOPS included storage according
    /// to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS,
    /// Influx IO Included 16000 IOPS.
    /// </summary>
    [JsonPropertyName("dbStorageType")]
    public string? DbStorageType { get; set; }

    /// <summary>
    /// (Default &quot;SINGLE_AZ&quot;) Specifies whether the DB instance will be deployed as a standalone instance or with a Multi-AZ standby for high availability. Valid options are: &quot;SINGLE_AZ&quot;, &quot;WITH_MULTIAZ_STANDBY&quot;. This argument is updatable.
    /// Specifies whether the DB instance will be deployed as a standalone instance or
    /// with a Multi-AZ standby for high availability.
    /// </summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>
    /// Configuration for sending InfluxDB engine logs to a specified S3 bucket. This argument is updatable.
    /// Configuration for sending InfluxDB engine logs to a specified S3 bucket.
    /// </summary>
    [JsonPropertyName("logDeliveryConfiguration")]
    public V1beta1DBInstanceSpecInitProviderLogDeliveryConfiguration? LogDeliveryConfiguration { get; set; }

    /// <summary>
    /// Name that uniquely identifies the DB instance when interacting with the Amazon Timestream for InfluxDB API and CLI commands. This name will also be a prefix included in the endpoint. DB instance names must be unique per customer and per region. The argument must start with a letter, cannot contain consecutive hyphens (-) and cannot end with a hyphen.
    /// The name that uniquely identifies the DB instance when interacting with the
    /// Amazon Timestream for InfluxDB API and CLI commands. This name will also be a
    /// prefix included in the endpoint. DB instance names must be unique per customer
    /// and per region.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Specifies whether the networkType of the Timestream for InfluxDB instance is IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate over both IPv4 and IPv6 protocols.
    /// Specifies whether the networkType of the Timestream for InfluxDB instance is
    /// IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate
    /// over both IPv4 and IPv6 protocols.
    /// </summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>
    /// Name of the initial organization for the initial admin user in InfluxDB. An InfluxDB organization is a workspace for a group of users. Along with bucket, username, and password, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute.
    /// The name of the initial organization for the initial admin user in InfluxDB. An
    /// InfluxDB organization is a workspace for a group of users.
    /// </summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>
    /// Password of the initial admin user created in InfluxDB. This password will allow you to access the InfluxDB UI to perform various administrative tasks and also use the InfluxDB CLI to create an operator token. Along with bucket, username, and organization, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute.
    /// The password of the initial admin user created in InfluxDB. This password will
    /// allow you to access the InfluxDB UI to perform various administrative tasks and
    /// also use the InfluxDB CLI to create an operator token. These attributes will be
    /// stored in a Secret created in AWS SecretManager in your account.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta1DBInstanceSpecInitProviderPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>
    /// (Default 8086) The port on which the instance accepts connections. Valid values: 1024-65535. Cannot be 2375-2376, 7788-7799, 8090, or 51678-51680. This argument is updatable.
    /// The port number on which InfluxDB accepts connections.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// (Default false) Configures the DB instance with a public IP to facilitate access. Other resources, such as a VPC, a subnet, an internet gateway, and a route table with routes, are also required to enabled public access, in addition to this argument. See &quot;Usage with Public Internet Access Enabled&quot; for an example configuration with all required resources for public internet access.
    /// Configures the DB instance with a public IP to facilitate access.
    /// </summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// Username of the initial admin user created in InfluxDB. Must start with a letter and can&apos;t end with a hyphen or contain two consecutive hyphens. This username will allow you to access the InfluxDB UI to perform various administrative tasks and also use the InfluxDB CLI to create an operator token. Along with bucket, organization, and password, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute.
    /// The username of the initial admin user created in InfluxDB.
    /// Must start with a letter and can&apos;t end with a hyphen or contain two
    /// consecutive hyphens. For example, my-user1. This username will allow
    /// you to access the InfluxDB UI to perform various administrative tasks
    /// and also use the InfluxDB CLI to create an operator token. These
    /// attributes will be stored in a Secret created in Amazon Secrets
    /// Manager in your account
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// List of VPC security group IDs to associate with the DB instance.
    /// A list of VPC security group IDs to associate with the DB instance.
    /// </summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdsRefs")]
    public IList<V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsRefs>? VpcSecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdsSelector")]
    public V1beta1DBInstanceSpecInitProviderVpcSecurityGroupIdsSelector? VpcSecurityGroupIdsSelector { get; set; }

    /// <summary>
    /// List of VPC subnet IDs to associate with the DB instance. Provide at least two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
    /// A list of VPC subnet IDs to associate with the DB instance. Provide at least
    /// two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
    /// </summary>
    [JsonPropertyName("vpcSubnetIds")]
    public IList<string>? VpcSubnetIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate vpcSubnetIds.</summary>
    [JsonPropertyName("vpcSubnetIdsRefs")]
    public IList<V1beta1DBInstanceSpecInitProviderVpcSubnetIdsRefs>? VpcSubnetIdsRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate vpcSubnetIds.</summary>
    [JsonPropertyName("vpcSubnetIdsSelector")]
    public V1beta1DBInstanceSpecInitProviderVpcSubnetIdsSelector? VpcSubnetIdsSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecManagementPoliciesEnum>))]
public enum V1beta1DBInstanceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1DBInstanceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DBInstanceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1DBInstanceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DBInstanceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DBInstanceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DBInstanceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DBInstanceSpec defines the desired state of DBInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceSpec
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
    public V1beta1DBInstanceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1DBInstanceSpecForProvider ForProvider { get; set; }

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
    public V1beta1DBInstanceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1DBInstanceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DBInstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DBInstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Configuration for S3 bucket log delivery.
/// Configuration for S3 bucket log delivery.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceStatusAtProviderLogDeliveryConfigurationS3Configuration
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
public partial class V1beta1DBInstanceStatusAtProviderLogDeliveryConfiguration
{
    /// <summary>
    /// Configuration for S3 bucket log delivery.
    /// Configuration for S3 bucket log delivery.
    /// </summary>
    [JsonPropertyName("s3Configuration")]
    public V1beta1DBInstanceStatusAtProviderLogDeliveryConfigurationS3Configuration? S3Configuration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceStatusAtProvider
{
    /// <summary>
    /// Amount of storage in GiB (gibibytes). The minimum value is 20, the maximum value is 16384. This argument is updatable. The argument db_storage_type places restrictions on this argument&apos;s minimum value. The following is a list of db_storage_type values and the corresponding minimum value for allocated_storage: &quot;InfluxIOIncludedT1&quot;: 20, &quot;InfluxIOIncludedT2&quot; and &quot;InfluxIOIncludedT3&quot;: 400`.
    /// The amount of storage to allocate for your DB storage type in GiB (gibibytes).
    /// </summary>
    [JsonPropertyName("allocatedStorage")]
    public double? AllocatedStorage { get; set; }

    /// <summary>ARN of the Timestream for InfluxDB Instance.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// Availability Zone in which the DB instance resides.
    /// The Availability Zone in which the DB instance resides.
    /// </summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>
    /// Name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket. A bucket combines the concept of a database and a retention period (the duration of time that each data point persists). A bucket belongs to an organization. Along with organization, username, and password, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute.
    /// The name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket.
    /// A bucket combines the concept of a database and a retention period (the duration of time
    /// that each data point persists). A bucket belongs to an organization.
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
    /// ID of the DB parameter group assigned to your DB instance. This argument is updatable. If added to an existing Timestream for InfluxDB instance or given a new value, will cause an in-place update to the instance. However, if an instance already has a value for db_parameter_group_identifier, removing db_parameter_group_identifier will cause the instance to be destroyed and recreated.
    /// The id of the DB parameter group assigned to your DB instance.
    /// </summary>
    [JsonPropertyName("dbParameterGroupIdentifier")]
    public string? DbParameterGroupIdentifier { get; set; }

    /// <summary>
    /// (Default &quot;InfluxIOIncludedT1&quot;) Timestream for InfluxDB DB storage type to read and write InfluxDB data. You can choose between 3 different types of provisioned Influx IOPS included storage according to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS, Influx IO Included 16000 IOPS. Valid options are: &quot;InfluxIOIncludedT1&quot;, &quot;InfluxIOIncludedT2&quot;, and &quot;InfluxIOIncludedT3&quot;. If you use &quot;InfluxIOIncludedT2&quot; or &quot;InfluxIOIncludedT3&quot;, the minimum value for allocated_storage` is 400. This argument is updatable. For a single instance, after this argument has been updated once, it can only be updated again after 6 hours have passed.
    /// The Timestream for InfluxDB DB storage type to read and write InfluxDB data.
    /// You can choose between 3 different types of provisioned Influx IOPS included storage according
    /// to your workloads requirements: Influx IO Included 3000 IOPS, Influx IO Included 12000 IOPS,
    /// Influx IO Included 16000 IOPS.
    /// </summary>
    [JsonPropertyName("dbStorageType")]
    public string? DbStorageType { get; set; }

    /// <summary>
    /// (Default &quot;SINGLE_AZ&quot;) Specifies whether the DB instance will be deployed as a standalone instance or with a Multi-AZ standby for high availability. Valid options are: &quot;SINGLE_AZ&quot;, &quot;WITH_MULTIAZ_STANDBY&quot;. This argument is updatable.
    /// Specifies whether the DB instance will be deployed as a standalone instance or
    /// with a Multi-AZ standby for high availability.
    /// </summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }

    /// <summary>
    /// Endpoint used to connect to InfluxDB. The default InfluxDB port is 8086.
    /// The endpoint used to connect to InfluxDB. The default InfluxDB port is 8086.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>ID of the Timestream for InfluxDB instance.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// ARN of the AWS Secrets Manager secret containing the initial InfluxDB authorization parameters. The secret value is a JSON formatted key-value pair holding InfluxDB authorization values: organization, bucket, username, and password.
    /// The Amazon Resource Name (ARN) of the AWS Secrets Manager secret containing the
    /// initial InfluxDB authorization parameters. The secret value is a JSON formatted
    /// key-value pair holding InfluxDB authorization values: organization, bucket,
    /// username, and password.
    /// </summary>
    [JsonPropertyName("influxAuthParametersSecretArn")]
    public string? InfluxAuthParametersSecretArn { get; set; }

    /// <summary>
    /// Configuration for sending InfluxDB engine logs to a specified S3 bucket. This argument is updatable.
    /// Configuration for sending InfluxDB engine logs to a specified S3 bucket.
    /// </summary>
    [JsonPropertyName("logDeliveryConfiguration")]
    public V1beta1DBInstanceStatusAtProviderLogDeliveryConfiguration? LogDeliveryConfiguration { get; set; }

    /// <summary>
    /// Name that uniquely identifies the DB instance when interacting with the Amazon Timestream for InfluxDB API and CLI commands. This name will also be a prefix included in the endpoint. DB instance names must be unique per customer and per region. The argument must start with a letter, cannot contain consecutive hyphens (-) and cannot end with a hyphen.
    /// The name that uniquely identifies the DB instance when interacting with the
    /// Amazon Timestream for InfluxDB API and CLI commands. This name will also be a
    /// prefix included in the endpoint. DB instance names must be unique per customer
    /// and per region.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Specifies whether the networkType of the Timestream for InfluxDB instance is IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate over both IPv4 and IPv6 protocols.
    /// Specifies whether the networkType of the Timestream for InfluxDB instance is
    /// IPV4, which can communicate over IPv4 protocol only, or DUAL, which can communicate
    /// over both IPv4 and IPv6 protocols.
    /// </summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>
    /// Name of the initial organization for the initial admin user in InfluxDB. An InfluxDB organization is a workspace for a group of users. Along with bucket, username, and password, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute.
    /// The name of the initial organization for the initial admin user in InfluxDB. An
    /// InfluxDB organization is a workspace for a group of users.
    /// </summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>
    /// (Default 8086) The port on which the instance accepts connections. Valid values: 1024-65535. Cannot be 2375-2376, 7788-7799, 8090, or 51678-51680. This argument is updatable.
    /// The port number on which InfluxDB accepts connections.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// (Default false) Configures the DB instance with a public IP to facilitate access. Other resources, such as a VPC, a subnet, an internet gateway, and a route table with routes, are also required to enabled public access, in addition to this argument. See &quot;Usage with Public Internet Access Enabled&quot; for an example configuration with all required resources for public internet access.
    /// Configures the DB instance with a public IP to facilitate access.
    /// </summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Availability Zone in which the standby instance is located when deploying with a MultiAZ standby instance.
    /// The Availability Zone in which the standby instance is located when deploying
    /// with a MultiAZ standby instance.
    /// </summary>
    [JsonPropertyName("secondaryAvailabilityZone")]
    public string? SecondaryAvailabilityZone { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>
    /// Username of the initial admin user created in InfluxDB. Must start with a letter and can&apos;t end with a hyphen or contain two consecutive hyphens. This username will allow you to access the InfluxDB UI to perform various administrative tasks and also use the InfluxDB CLI to create an operator token. Along with bucket, organization, and password, this argument will be stored in the secret referred to by the influx_auth_parameters_secret_arn attribute.
    /// The username of the initial admin user created in InfluxDB.
    /// Must start with a letter and can&apos;t end with a hyphen or contain two
    /// consecutive hyphens. For example, my-user1. This username will allow
    /// you to access the InfluxDB UI to perform various administrative tasks
    /// and also use the InfluxDB CLI to create an operator token. These
    /// attributes will be stored in a Secret created in Amazon Secrets
    /// Manager in your account
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// List of VPC security group IDs to associate with the DB instance.
    /// A list of VPC security group IDs to associate with the DB instance.
    /// </summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    /// <summary>
    /// List of VPC subnet IDs to associate with the DB instance. Provide at least two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
    /// A list of VPC subnet IDs to associate with the DB instance. Provide at least
    /// two VPC subnet IDs in different availability zones when deploying with a Multi-AZ standby.
    /// </summary>
    [JsonPropertyName("vpcSubnetIds")]
    public IList<string>? VpcSubnetIds { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceStatusConditions
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

/// <summary>DBInstanceStatus defines the observed state of DBInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DBInstanceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1DBInstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DBInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DBInstance is the Schema for the DBInstances API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DBInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DBInstanceSpec>, IStatus<V1beta1DBInstanceStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DBInstance";
    public const string KubeGroup = "timestreaminfluxdb.aws.upbound.io";
    public const string KubePluralName = "dbinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "timestreaminfluxdb.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBInstance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DBInstanceSpec defines the desired state of DBInstance</summary>
    [JsonPropertyName("spec")]
    public required V1beta1DBInstanceSpec Spec { get; set; }

    /// <summary>DBInstanceStatus defines the observed state of DBInstance.</summary>
    [JsonPropertyName("status")]
    public V1beta1DBInstanceStatus? Status { get; set; }
}
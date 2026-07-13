#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.rds.aws.upbound.io;
/// <summary>Instance is the Schema for the Instances API. Provides an RDS instance resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta3InstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta3Instance>
{
    public const string KubeApiVersion = "v1beta3";
    public const string KubeKind = "InstanceList";
    public const string KubeGroup = "rds.aws.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.aws.upbound.io/v1beta3";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta3Instance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta3Instance> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecDeletionPolicyEnum>))]
public enum V1beta3InstanceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Enables low-downtime updates using RDS Blue/Green deployments.
/// See blue_green_update below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderBlueGreenUpdate
{
    /// <summary>
    /// Enables low-downtime updates when true.
    /// Default is false.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderDbSubnetGroupNameRefPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecForProviderDbSubnetGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderDbSubnetGroupNameRefPolicyResolveEnum>))]
public enum V1beta3InstanceSpecForProviderDbSubnetGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderDbSubnetGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecForProviderDbSubnetGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecForProviderDbSubnetGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderDbSubnetGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3InstanceSpecForProviderDbSubnetGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderDbSubnetGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecForProviderDbSubnetGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderDbSubnetGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta3InstanceSpecForProviderDbSubnetGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderDbSubnetGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecForProviderDbSubnetGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecForProviderDbSubnetGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderDbSubnetGroupNameSelector
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
    public V1beta3InstanceSpecForProviderDbSubnetGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecForProviderKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta3InstanceSpecForProviderKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecForProviderKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecForProviderKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3InstanceSpecForProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta3InstanceSpecForProviderKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecForProviderKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecForProviderKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderKmsKeyIdSelector
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
    public V1beta3InstanceSpecForProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate masterUserSecretKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate masterUserSecretKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdSelector
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
    public V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderMonitoringRoleArnRefPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecForProviderMonitoringRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderMonitoringRoleArnRefPolicyResolveEnum>))]
public enum V1beta3InstanceSpecForProviderMonitoringRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderMonitoringRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecForProviderMonitoringRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecForProviderMonitoringRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate monitoringRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderMonitoringRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3InstanceSpecForProviderMonitoringRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderMonitoringRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecForProviderMonitoringRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderMonitoringRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta3InstanceSpecForProviderMonitoringRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderMonitoringRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecForProviderMonitoringRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecForProviderMonitoringRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate monitoringRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderMonitoringRoleArnSelector
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
    public V1beta3InstanceSpecForProviderMonitoringRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderParameterGroupNameRefPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecForProviderParameterGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderParameterGroupNameRefPolicyResolveEnum>))]
public enum V1beta3InstanceSpecForProviderParameterGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderParameterGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecForProviderParameterGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecForProviderParameterGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ParameterGroup in rds to populate parameterGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderParameterGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3InstanceSpecForProviderParameterGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderParameterGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecForProviderParameterGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderParameterGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta3InstanceSpecForProviderParameterGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderParameterGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecForProviderParameterGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecForProviderParameterGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ParameterGroup in rds to populate parameterGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderParameterGroupNameSelector
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
    public V1beta3InstanceSpecForProviderParameterGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Password for the master DB user. Note that this may show up in logs, and it will be stored in the state file. Cannot be set if manage_master_user_password is set to true.
/// Password for the master DB user. If you set autoGeneratePassword to true, the Secret referenced here will be created or updated with generated password if it does not already contain one.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderPasswordSecretRef
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

/// <summary>Password for the master DB user. Note that this may show up in logs, and it will be stored in the state file. Cannot be set if manage_master_user_password is set to true.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderPasswordWoSecretRef
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderReplicateSourceDbRefPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecForProviderReplicateSourceDbRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderReplicateSourceDbRefPolicyResolveEnum>))]
public enum V1beta3InstanceSpecForProviderReplicateSourceDbRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderReplicateSourceDbRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecForProviderReplicateSourceDbRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecForProviderReplicateSourceDbRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Instance in rds to populate replicateSourceDb.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderReplicateSourceDbRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3InstanceSpecForProviderReplicateSourceDbRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderReplicateSourceDbSelectorPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecForProviderReplicateSourceDbSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderReplicateSourceDbSelectorPolicyResolveEnum>))]
public enum V1beta3InstanceSpecForProviderReplicateSourceDbSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderReplicateSourceDbSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecForProviderReplicateSourceDbSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecForProviderReplicateSourceDbSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Instance in rds to populate replicateSourceDb.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderReplicateSourceDbSelector
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
    public V1beta3InstanceSpecForProviderReplicateSourceDbSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A configuration block for restoring a DB instance to an arbitrary point in time.
/// Requires the identifier argument to be set with the name of the new DB instance to be created.
/// See Restore To Point In Time below for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderRestoreToPointInTime
{
    /// <summary>The date and time to restore from. Value must be a time in Universal Coordinated Time (UTC) format and must be before the latest restorable time for the DB instance. Cannot be specified with use_latest_restorable_time.</summary>
    [JsonPropertyName("restoreTime")]
    public string? RestoreTime { get; set; }

    /// <summary>The ARN of the automated backup from which to restore. Required if source_db_instance_identifier or source_dbi_resource_id is not specified.</summary>
    [JsonPropertyName("sourceDbInstanceAutomatedBackupsArn")]
    public string? SourceDbInstanceAutomatedBackupsArn { get; set; }

    /// <summary>The identifier of the source DB instance from which to restore. Must match the identifier of an existing DB instance. Required if source_db_instance_automated_backups_arn or source_dbi_resource_id is not specified.</summary>
    [JsonPropertyName("sourceDbInstanceIdentifier")]
    public string? SourceDbInstanceIdentifier { get; set; }

    /// <summary>The resource ID of the source DB instance from which to restore. Required if source_db_instance_identifier or source_db_instance_automated_backups_arn is not specified.</summary>
    [JsonPropertyName("sourceDbiResourceId")]
    public string? SourceDbiResourceId { get; set; }

    /// <summary>A boolean value that indicates whether the DB instance is restored from the latest backup time. Defaults to false. Cannot be specified with restore_time.</summary>
    [JsonPropertyName("useLatestRestorableTime")]
    public bool? UseLatestRestorableTime { get; set; }
}

/// <summary>Restore from a Percona Xtrabackup in S3.  See Importing Data into an Amazon RDS MySQL DB Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderS3Import
{
    /// <summary>The bucket name where your backup is stored</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Can be blank, but is the path to your backup</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Role applied to load the data.</summary>
    [JsonPropertyName("ingestionRole")]
    public string? IngestionRole { get; set; }

    /// <summary>Source engine for the backup</summary>
    [JsonPropertyName("sourceEngine")]
    public string? SourceEngine { get; set; }

    /// <summary>Version of the source engine used to make the backup</summary>
    [JsonPropertyName("sourceEngineVersion")]
    public string? SourceEngineVersion { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
public enum V1beta3InstanceSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3InstanceSpecForProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta3InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProviderVpcSecurityGroupIdSelector
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
    public V1beta3InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecForProvider
{
    /// <summary>The allocated storage in gibibytes. If max_allocated_storage is configured, this argument represents the initial storage allocation and differences from the configuration will be ignored automatically when Storage Autoscaling occurs. If replicate_source_db is set, the value is ignored during the creation of the instance.</summary>
    [JsonPropertyName("allocatedStorage")]
    public double? AllocatedStorage { get; set; }

    /// <summary>
    /// Indicates that major version
    /// upgrades are allowed. Changing this parameter does not result in an outage and
    /// the change is asynchronously applied as soon as possible.
    /// </summary>
    [JsonPropertyName("allowMajorVersionUpgrade")]
    public bool? AllowMajorVersionUpgrade { get; set; }

    /// <summary>
    /// Specifies whether any database modifications
    /// are applied immediately, or during the next maintenance window. Default is
    /// false. See Amazon RDS Documentation for more
    /// information.
    /// </summary>
    [JsonPropertyName("applyImmediately")]
    public bool? ApplyImmediately { get; set; }

    /// <summary>
    /// Password for the master DB user. Note that this may show up in logs, and it will be stored in the state file. Cannot be set if manage_master_user_password is set to true.
    /// If true, the password will be auto-generated and stored in the Secret referenced by the passwordSecretRef field.
    /// </summary>
    [JsonPropertyName("autoGeneratePassword")]
    public bool? AutoGeneratePassword { get; set; }

    /// <summary>
    /// Indicates that minor engine upgrades
    /// will be applied automatically to the DB instance during the maintenance window.
    /// Defaults to true.
    /// </summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary>The AZ for the RDS instance.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>
    /// The days to retain backups for.
    /// Must be between 0 and 35.
    /// Default is 0.
    /// Must be greater than 0 if the database is used as a source for a Read Replica,
    /// uses low-downtime updates,
    /// or will use RDS Blue/Green deployments.
    /// </summary>
    [JsonPropertyName("backupRetentionPeriod")]
    public double? BackupRetentionPeriod { get; set; }

    /// <summary>Specifies where automated backups and manual snapshots are stored. Possible values are region (default) and outposts. See Working with Amazon RDS on AWS Outposts for more information.</summary>
    [JsonPropertyName("backupTarget")]
    public string? BackupTarget { get; set; }

    /// <summary>
    /// The daily time range (in UTC) during which automated backups are created if they are enabled.
    /// Example: &quot;09:46-10:16&quot;. Must not overlap with maintenance_window.
    /// </summary>
    [JsonPropertyName("backupWindow")]
    public string? BackupWindow { get; set; }

    /// <summary>
    /// Enables low-downtime updates using RDS Blue/Green deployments.
    /// See blue_green_update below.
    /// </summary>
    [JsonPropertyName("blueGreenUpdate")]
    public V1beta3InstanceSpecForProviderBlueGreenUpdate? BlueGreenUpdate { get; set; }

    /// <summary>The identifier of the CA certificate for the DB instance.</summary>
    [JsonPropertyName("caCertIdentifier")]
    public string? CaCertIdentifier { get; set; }

    /// <summary>
    /// The character set name to use for DB encoding in Oracle and Microsoft SQL instances (collation).
    /// This can&apos;t be changed.
    /// See Oracle Character Sets Supported in Amazon RDS or
    /// Server-Level Collation for Microsoft SQL Server for more information.
    /// Cannot be set  with replicate_source_db, restore_to_point_in_time, s3_import, or snapshot_identifier.
    /// </summary>
    [JsonPropertyName("characterSetName")]
    public string? CharacterSetName { get; set; }

    /// <summary>Copy all Instance tags to snapshots. Default is false.</summary>
    [JsonPropertyName("copyTagsToSnapshot")]
    public bool? CopyTagsToSnapshot { get; set; }

    /// <summary>The instance profile associated with the underlying Amazon EC2 instance of an RDS Custom DB instance.</summary>
    [JsonPropertyName("customIamInstanceProfile")]
    public string? CustomIamInstanceProfile { get; set; }

    /// <summary>Indicates whether to enable a customer-owned IP address (CoIP) for an RDS on Outposts DB instance. See CoIP for RDS on Outposts for more information.</summary>
    [JsonPropertyName("customerOwnedIpEnabled")]
    public bool? CustomerOwnedIpEnabled { get; set; }

    /// <summary>The mode of Database Insights that is enabled for the instance. Valid values: standard, advanced .</summary>
    [JsonPropertyName("databaseInsightsMode")]
    public string? DatabaseInsightsMode { get; set; }

    /// <summary>The name of the database to create when the DB instance is created. If this parameter is not specified, no database is created in the DB instance. Note that this does not apply for Oracle or SQL Server engines. See the AWS documentation for more details on what applies for those engines. If you are providing an Oracle db name, it needs to be in all upper case. Cannot be specified for a replica.</summary>
    [JsonPropertyName("dbName")]
    public string? DbName { get; set; }

    /// <summary>
    /// Name of DB subnet group.
    /// DB instance will be created in the VPC associated with the DB subnet group.
    /// If unspecified, will be created in the default Subnet Group.
    /// When working with read replicas created in the same region, defaults to the Subnet Group Name of the source DB.
    /// When working with read replicas created in a different region, defaults to the default Subnet Group.
    /// See DBSubnetGroupName in API action CreateDBInstanceReadReplica for additional read replica constraints.
    /// </summary>
    [JsonPropertyName("dbSubnetGroupName")]
    public string? DbSubnetGroupName { get; set; }

    /// <summary>Reference to a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
    [JsonPropertyName("dbSubnetGroupNameRef")]
    public V1beta3InstanceSpecForProviderDbSubnetGroupNameRef? DbSubnetGroupNameRef { get; set; }

    /// <summary>Selector for a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
    [JsonPropertyName("dbSubnetGroupNameSelector")]
    public V1beta3InstanceSpecForProviderDbSubnetGroupNameSelector? DbSubnetGroupNameSelector { get; set; }

    /// <summary>Use a dedicated log volume (DLV) for the DB instance. Requires Provisioned IOPS. See the AWS documentation for more details.</summary>
    [JsonPropertyName("dedicatedLogVolume")]
    public bool? DedicatedLogVolume { get; set; }

    /// <summary>Specifies whether to remove automated backups immediately after the DB instance is deleted. Default is true.</summary>
    [JsonPropertyName("deleteAutomatedBackups")]
    public bool? DeleteAutomatedBackups { get; set; }

    /// <summary>If the DB instance should have deletion protection enabled. The database can&apos;t be deleted when this value is set to true. The default is false.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>The ID of the Directory Service Active Directory domain to create the instance in. Conflicts with domain_fqdn, domain_ou, domain_auth_secret_arn and a domain_dns_ips.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>The ARN for the Secrets Manager secret with the self managed Active Directory credentials for the user joining the domain. Conflicts with domain and domain_iam_role_name.</summary>
    [JsonPropertyName("domainAuthSecretArn")]
    public string? DomainAuthSecretArn { get; set; }

    /// <summary>The IPv4 DNS IP addresses of your primary and secondary self managed Active Directory domain controllers. Two IP addresses must be provided. If there isn&apos;t a secondary domain controller, use the IP address of the primary domain controller for both entries in the list. Conflicts with domain and domain_iam_role_name.</summary>
    [JsonPropertyName("domainDnsIps")]
    public IList<string>? DomainDnsIps { get; set; }

    /// <summary>The fully qualified domain name (FQDN) of the self managed Active Directory domain. Conflicts with domain and domain_iam_role_name.</summary>
    [JsonPropertyName("domainFqdn")]
    public string? DomainFqdn { get; set; }

    /// <summary>The name of the IAM role to be used when making API calls to the Directory Service. Conflicts with domain_fqdn, domain_ou, domain_auth_secret_arn and a domain_dns_ips.</summary>
    [JsonPropertyName("domainIamRoleName")]
    public string? DomainIamRoleName { get; set; }

    /// <summary>The self managed Active Directory organizational unit for your DB instance to join. Conflicts with domain and domain_iam_role_name.</summary>
    [JsonPropertyName("domainOu")]
    public string? DomainOu { get; set; }

    /// <summary>Set of log types to enable for exporting to CloudWatch logs. If omitted, no logs will be exported. For supported values, see the EnableCloudwatchLogsExports.member.N parameter in API action CreateDBInstance.</summary>
    [JsonPropertyName("enabledCloudwatchLogsExports")]
    public IList<string>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>The database engine to use. For supported values, see the Engine parameter in [API action CreateDBInstance](https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_CreateDBInstance.html). Note that for Amazon Aurora instances the engine must match the [DB Cluster](https://marketplace.upbound.io/providers/upbound/provider-aws/latest/resources/rds.aws.upbound.io/Cluster/v1beta1)&apos;s engine&apos;. For information on the difference between the available Aurora MySQL engines see Comparison in the [Amazon RDS Release Notes](https://docs.aws.amazon.com/AmazonRDS/latest/AuroraMySQLReleaseNotes/Welcome.html).</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The life cycle type for this DB instance. This setting applies only to RDS for MySQL and RDS for PostgreSQL. Valid values are open-source-rds-extended-support, open-source-rds-extended-support-disabled. Default value is open-source-rds-extended-support. [Using Amazon RDS Extended Support]: https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/extended-support.html</summary>
    [JsonPropertyName("engineLifecycleSupport")]
    public string? EngineLifecycleSupport { get; set; }

    /// <summary>The engine version to use. If `autoMinorVersionUpgrade` is enabled, you can provide a prefix of the version such as 5.7 (for 5.7.10). The actual engine version used is returned in the attribute `status.atProvider.engineVersionActual`. For supported values, see the EngineVersion parameter in [API action CreateDBInstance](https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_CreateDBInstance.html). Note that for Amazon Aurora instances the engine version must match the [DB Cluster](https://marketplace.upbound.io/providers/upbound/provider-aws/latest/resources/rds.aws.upbound.io/Cluster/v1beta1)&apos;s engine version&apos;.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>
    /// The name of your final DB snapshot
    /// when this DB instance is deleted. Must be provided if skip_final_snapshot is
    /// set to false. The value must begin with a letter, only contain alphanumeric characters and hyphens, and not end with a hyphen or contain two consecutive hyphens. Must not be provided when deleting a read replica.
    /// </summary>
    [JsonPropertyName("finalSnapshotIdentifier")]
    public string? FinalSnapshotIdentifier { get; set; }

    /// <summary>
    /// Specifies whether mappings of AWS Identity and Access Management (IAM) accounts to database
    /// accounts is enabled.
    /// </summary>
    [JsonPropertyName("iamDatabaseAuthenticationEnabled")]
    public bool? IamDatabaseAuthenticationEnabled { get; set; }

    /// <summary>Required if restore_to_point_in_time is specified.</summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    /// <summary>Creates a unique identifier beginning with the specified prefix. Conflicts with identifier.</summary>
    [JsonPropertyName("identifierPrefix")]
    public string? IdentifierPrefix { get; set; }

    /// <summary>The instance type of the RDS instance.</summary>
    [JsonPropertyName("instanceClass")]
    public string? InstanceClass { get; set; }

    /// <summary>
    /// The amount of provisioned IOPS. Setting this implies a
    /// storage_type of &quot;io1&quot; or &quot;io2&quot;. Can only be set when storage_type is &quot;io1&quot;, &quot;io2 or &quot;gp3&quot;.
    /// Cannot be specified for gp3 storage if the allocated_storage value is below a per-engine threshold.
    /// See the RDS User Guide for details.
    /// </summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>
    /// The ARN for the KMS encryption key. If creating an
    /// encrypted replica, set this to the destination KMS ARN.
    /// </summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta3InstanceSpecForProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta3InstanceSpecForProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>License model information for this DB instance. Valid values for this field are as follows:</summary>
    [JsonPropertyName("licenseModel")]
    public string? LicenseModel { get; set; }

    /// <summary>
    /// The window to perform maintenance in.
    /// Syntax: &quot;ddd:hh24:mi-ddd:hh24:mi&quot;. Eg: &quot;Mon:00:00-Mon:03:00&quot;. See RDS
    /// Maintenance Window
    /// docs
    /// for more information.
    /// </summary>
    [JsonPropertyName("maintenanceWindow")]
    public string? MaintenanceWindow { get; set; }

    /// <summary>Set to true to allow RDS to manage the master user password in Secrets Manager. Cannot be set if password or password_wo is provided.</summary>
    [JsonPropertyName("manageMasterUserPassword")]
    public bool? ManageMasterUserPassword { get; set; }

    /// <summary>The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias name for the KMS key. To use a KMS key in a different Amazon Web Services account, specify the key ARN or alias ARN. If not specified, the default KMS key for your Amazon Web Services account is used.</summary>
    [JsonPropertyName("masterUserSecretKmsKeyId")]
    public string? MasterUserSecretKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate masterUserSecretKmsKeyId.</summary>
    [JsonPropertyName("masterUserSecretKmsKeyIdRef")]
    public V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdRef? MasterUserSecretKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate masterUserSecretKmsKeyId.</summary>
    [JsonPropertyName("masterUserSecretKmsKeyIdSelector")]
    public V1beta3InstanceSpecForProviderMasterUserSecretKmsKeyIdSelector? MasterUserSecretKmsKeyIdSelector { get; set; }

    /// <summary>Specifies the maximum storage (in GiB) that Amazon RDS can automatically scale to for this DB instance. By default, Storage Autoscaling is disabled. To enable Storage Autoscaling, set max_allocated_storage to greater than or equal to allocated_storage. Setting max_allocated_storage to 0 explicitly disables Storage Autoscaling. When configured, changes to allocated_storage will be automatically ignored as the storage can dynamically scale.</summary>
    [JsonPropertyName("maxAllocatedStorage")]
    public double? MaxAllocatedStorage { get; set; }

    /// <summary>
    /// The interval, in seconds, between points
    /// when Enhanced Monitoring metrics are collected for the DB instance. To disable
    /// collecting Enhanced Monitoring metrics, specify 0. The default is 0. Valid
    /// Values: 0, 1, 5, 10, 15, 30, 60.
    /// </summary>
    [JsonPropertyName("monitoringInterval")]
    public double? MonitoringInterval { get; set; }

    /// <summary>
    /// The ARN for the IAM role that permits RDS
    /// to send enhanced monitoring metrics to CloudWatch Logs. You can find more
    /// information on the AWS
    /// Documentation
    /// what IAM permissions are needed to allow Enhanced Monitoring for RDS Instances.
    /// </summary>
    [JsonPropertyName("monitoringRoleArn")]
    public string? MonitoringRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate monitoringRoleArn.</summary>
    [JsonPropertyName("monitoringRoleArnRef")]
    public V1beta3InstanceSpecForProviderMonitoringRoleArnRef? MonitoringRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate monitoringRoleArn.</summary>
    [JsonPropertyName("monitoringRoleArnSelector")]
    public V1beta3InstanceSpecForProviderMonitoringRoleArnSelector? MonitoringRoleArnSelector { get; set; }

    /// <summary>Specifies if the RDS instance is multi-AZ</summary>
    [JsonPropertyName("multiAz")]
    public bool? MultiAz { get; set; }

    /// <summary>
    /// The national character set is used in the NCHAR, NVARCHAR2, and NCLOB data types for Oracle instances. This can&apos;t be changed. See Oracle Character Sets
    /// Supported in Amazon RDS.
    /// </summary>
    [JsonPropertyName("ncharCharacterSetName")]
    public string? NcharCharacterSetName { get; set; }

    /// <summary>The network type of the DB instance. Valid values: IPV4, DUAL.</summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>Name of the DB option group to associate.</summary>
    [JsonPropertyName("optionGroupName")]
    public string? OptionGroupName { get; set; }

    /// <summary>Name of the DB parameter group to associate.</summary>
    [JsonPropertyName("parameterGroupName")]
    public string? ParameterGroupName { get; set; }

    /// <summary>Reference to a ParameterGroup in rds to populate parameterGroupName.</summary>
    [JsonPropertyName("parameterGroupNameRef")]
    public V1beta3InstanceSpecForProviderParameterGroupNameRef? ParameterGroupNameRef { get; set; }

    /// <summary>Selector for a ParameterGroup in rds to populate parameterGroupName.</summary>
    [JsonPropertyName("parameterGroupNameSelector")]
    public V1beta3InstanceSpecForProviderParameterGroupNameSelector? ParameterGroupNameSelector { get; set; }

    /// <summary>
    /// Password for the master DB user. Note that this may show up in logs, and it will be stored in the state file. Cannot be set if manage_master_user_password is set to true.
    /// Password for the master DB user. If you set autoGeneratePassword to true, the Secret referenced here will be created or updated with generated password if it does not already contain one.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta3InstanceSpecForProviderPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>Password for the master DB user. Note that this may show up in logs, and it will be stored in the state file. Cannot be set if manage_master_user_password is set to true.</summary>
    [JsonPropertyName("passwordWoSecretRef")]
    public V1beta3InstanceSpecForProviderPasswordWoSecretRef? PasswordWoSecretRef { get; set; }

    /// <summary>Used together with password_wo to trigger an update. Increment this value when an update to password_wo is required.</summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>Specifies whether Performance Insights are enabled. Defaults to false.</summary>
    [JsonPropertyName("performanceInsightsEnabled")]
    public bool? PerformanceInsightsEnabled { get; set; }

    /// <summary>The ARN for the KMS key to encrypt Performance Insights data. When specifying performance_insights_kms_key_id, performance_insights_enabled needs to be set to true. Once KMS key is set, it can never be changed.</summary>
    [JsonPropertyName("performanceInsightsKmsKeyId")]
    public string? PerformanceInsightsKmsKeyId { get; set; }

    /// <summary>Amount of time in days to retain Performance Insights data. Valid values are 7, 731 (2 years) or a multiple of 31. When specifying performance_insights_retention_period, performance_insights_enabled needs to be set to true. Defaults to &apos;7&apos;.</summary>
    [JsonPropertyName("performanceInsightsRetentionPeriod")]
    public double? PerformanceInsightsRetentionPeriod { get; set; }

    /// <summary>The port on which the DB accepts connections.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Bool to control if instance is publicly
    /// accessible. Default is false.
    /// </summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// Specifies whether the replica is in either mounted or open-read-only mode. This attribute
    /// is only supported by Oracle instances. Oracle replicas operate in open-read-only mode unless otherwise specified. See Working with Oracle Read Replicas for more information.
    /// </summary>
    [JsonPropertyName("replicaMode")]
    public string? ReplicaMode { get; set; }

    /// <summary>
    /// Specifies that this resource is a Replica database, and to use this value as the source database.
    /// If replicating an Amazon RDS Database Instance in the same region, use the identifier of the source DB, unless also specifying the db_subnet_group_name.
    /// If specifying the db_subnet_group_name in the same region, use the arn of the source DB.
    /// If replicating an Instance in a different region, use the arn of the source DB.
    /// Note that if you are creating a cross-region replica of an encrypted database you will also need to specify a kms_key_id.
    /// See DB Instance Replication and Working with PostgreSQL and MySQL Read Replicas for more information on using Replication.
    /// </summary>
    [JsonPropertyName("replicateSourceDb")]
    public string? ReplicateSourceDb { get; set; }

    /// <summary>Reference to a Instance in rds to populate replicateSourceDb.</summary>
    [JsonPropertyName("replicateSourceDbRef")]
    public V1beta3InstanceSpecForProviderReplicateSourceDbRef? ReplicateSourceDbRef { get; set; }

    /// <summary>Selector for a Instance in rds to populate replicateSourceDb.</summary>
    [JsonPropertyName("replicateSourceDbSelector")]
    public V1beta3InstanceSpecForProviderReplicateSourceDbSelector? ReplicateSourceDbSelector { get; set; }

    /// <summary>
    /// A configuration block for restoring a DB instance to an arbitrary point in time.
    /// Requires the identifier argument to be set with the name of the new DB instance to be created.
    /// See Restore To Point In Time below for details.
    /// </summary>
    [JsonPropertyName("restoreToPointInTime")]
    public V1beta3InstanceSpecForProviderRestoreToPointInTime? RestoreToPointInTime { get; set; }

    /// <summary>Restore from a Percona Xtrabackup in S3.  See Importing Data into an Amazon RDS MySQL DB Instance</summary>
    [JsonPropertyName("s3Import")]
    public V1beta3InstanceSpecForProviderS3Import? S3Import { get; set; }

    /// <summary>
    /// Determines whether a final DB snapshot is
    /// created before the DB instance is deleted. If true is specified, no DBSnapshot
    /// is created. If false is specified, a DB snapshot is created before the DB
    /// instance is deleted, using the value from final_snapshot_identifier. Default
    /// is false.
    /// </summary>
    [JsonPropertyName("skipFinalSnapshot")]
    public bool? SkipFinalSnapshot { get; set; }

    /// <summary>
    /// Specifies whether or not to create this database from a snapshot.
    /// This corresponds to the snapshot ID you&apos;d find in the RDS console, e.g: rds:production-2015-06-26-06-05.
    /// </summary>
    [JsonPropertyName("snapshotIdentifier")]
    public string? SnapshotIdentifier { get; set; }

    /// <summary>
    /// Specifies whether the DB instance is
    /// encrypted. Note that if you are creating a cross-region read replica this field
    /// is ignored and you should instead declare kms_key_id with a valid ARN. The
    /// default is false if not specified.
    /// </summary>
    [JsonPropertyName("storageEncrypted")]
    public bool? StorageEncrypted { get; set; }

    /// <summary>The storage throughput value for the DB instance. Can only be set when storage_type is &quot;gp3&quot;. Cannot be specified if the allocated_storage value is below a per-engine threshold. See the RDS User Guide for details.</summary>
    [JsonPropertyName("storageThroughput")]
    public double? StorageThroughput { get; set; }

    /// <summary>
    /// One of &quot;standard&quot; (magnetic), &quot;gp2&quot; (general
    /// purpose SSD), &quot;gp3&quot; (general purpose SSD that needs iops independently)
    /// &quot;io1&quot; (provisioned IOPS SSD) or &quot;io2&quot; (block express storage provisioned IOPS
    /// SSD). The default is &quot;io1&quot; if iops is specified, &quot;gp2&quot; if not.
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// Time zone of the DB instance. timezone is currently
    /// only supported by Microsoft SQL Server. The timezone can only be set on
    /// creation. See MSSQL User
    /// Guide
    /// for more information.
    /// </summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>
    /// Whether to upgrade the storage file system configuration on the read replica.
    /// Can only be set with replicate_source_db.
    /// </summary>
    [JsonPropertyName("upgradeStorageConfig")]
    public bool? UpgradeStorageConfig { get; set; }

    /// <summary>Username for the master DB user. Cannot be specified for a replica.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta3InstanceSpecForProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta3InstanceSpecForProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    /// <summary>
    /// List of VPC security groups to
    /// associate.
    /// </summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

/// <summary>
/// Enables low-downtime updates using RDS Blue/Green deployments.
/// See blue_green_update below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderBlueGreenUpdate
{
    /// <summary>
    /// Enables low-downtime updates when true.
    /// Default is false.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderDbSubnetGroupNameRefPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecInitProviderDbSubnetGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderDbSubnetGroupNameRefPolicyResolveEnum>))]
public enum V1beta3InstanceSpecInitProviderDbSubnetGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderDbSubnetGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecInitProviderDbSubnetGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecInitProviderDbSubnetGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderDbSubnetGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3InstanceSpecInitProviderDbSubnetGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderDbSubnetGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecInitProviderDbSubnetGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderDbSubnetGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta3InstanceSpecInitProviderDbSubnetGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderDbSubnetGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecInitProviderDbSubnetGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecInitProviderDbSubnetGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderDbSubnetGroupNameSelector
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
    public V1beta3InstanceSpecInitProviderDbSubnetGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecInitProviderKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta3InstanceSpecInitProviderKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecInitProviderKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecInitProviderKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3InstanceSpecInitProviderKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta3InstanceSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecInitProviderKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecInitProviderKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderKmsKeyIdSelector
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
    public V1beta3InstanceSpecInitProviderKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate masterUserSecretKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate masterUserSecretKmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdSelector
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
    public V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderMonitoringRoleArnRefPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecInitProviderMonitoringRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderMonitoringRoleArnRefPolicyResolveEnum>))]
public enum V1beta3InstanceSpecInitProviderMonitoringRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderMonitoringRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecInitProviderMonitoringRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecInitProviderMonitoringRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate monitoringRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderMonitoringRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3InstanceSpecInitProviderMonitoringRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderMonitoringRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecInitProviderMonitoringRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderMonitoringRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta3InstanceSpecInitProviderMonitoringRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderMonitoringRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecInitProviderMonitoringRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecInitProviderMonitoringRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate monitoringRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderMonitoringRoleArnSelector
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
    public V1beta3InstanceSpecInitProviderMonitoringRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderParameterGroupNameRefPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecInitProviderParameterGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderParameterGroupNameRefPolicyResolveEnum>))]
public enum V1beta3InstanceSpecInitProviderParameterGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderParameterGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecInitProviderParameterGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecInitProviderParameterGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ParameterGroup in rds to populate parameterGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderParameterGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3InstanceSpecInitProviderParameterGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderParameterGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecInitProviderParameterGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderParameterGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta3InstanceSpecInitProviderParameterGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderParameterGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecInitProviderParameterGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecInitProviderParameterGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ParameterGroup in rds to populate parameterGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderParameterGroupNameSelector
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
    public V1beta3InstanceSpecInitProviderParameterGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Password for the master DB user. Note that this may show up in logs, and it will be stored in the state file. Cannot be set if manage_master_user_password is set to true.
/// Password for the master DB user. If you set autoGeneratePassword to true, the Secret referenced here will be created or updated with generated password if it does not already contain one.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderPasswordSecretRef
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

/// <summary>Password for the master DB user. Note that this may show up in logs, and it will be stored in the state file. Cannot be set if manage_master_user_password is set to true.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderPasswordWoSecretRef
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderReplicateSourceDbRefPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecInitProviderReplicateSourceDbRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderReplicateSourceDbRefPolicyResolveEnum>))]
public enum V1beta3InstanceSpecInitProviderReplicateSourceDbRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderReplicateSourceDbRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecInitProviderReplicateSourceDbRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecInitProviderReplicateSourceDbRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Instance in rds to populate replicateSourceDb.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderReplicateSourceDbRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3InstanceSpecInitProviderReplicateSourceDbRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderReplicateSourceDbSelectorPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecInitProviderReplicateSourceDbSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderReplicateSourceDbSelectorPolicyResolveEnum>))]
public enum V1beta3InstanceSpecInitProviderReplicateSourceDbSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderReplicateSourceDbSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecInitProviderReplicateSourceDbSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecInitProviderReplicateSourceDbSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Instance in rds to populate replicateSourceDb.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderReplicateSourceDbSelector
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
    public V1beta3InstanceSpecInitProviderReplicateSourceDbSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A configuration block for restoring a DB instance to an arbitrary point in time.
/// Requires the identifier argument to be set with the name of the new DB instance to be created.
/// See Restore To Point In Time below for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderRestoreToPointInTime
{
    /// <summary>The date and time to restore from. Value must be a time in Universal Coordinated Time (UTC) format and must be before the latest restorable time for the DB instance. Cannot be specified with use_latest_restorable_time.</summary>
    [JsonPropertyName("restoreTime")]
    public string? RestoreTime { get; set; }

    /// <summary>The ARN of the automated backup from which to restore. Required if source_db_instance_identifier or source_dbi_resource_id is not specified.</summary>
    [JsonPropertyName("sourceDbInstanceAutomatedBackupsArn")]
    public string? SourceDbInstanceAutomatedBackupsArn { get; set; }

    /// <summary>The identifier of the source DB instance from which to restore. Must match the identifier of an existing DB instance. Required if source_db_instance_automated_backups_arn or source_dbi_resource_id is not specified.</summary>
    [JsonPropertyName("sourceDbInstanceIdentifier")]
    public string? SourceDbInstanceIdentifier { get; set; }

    /// <summary>The resource ID of the source DB instance from which to restore. Required if source_db_instance_identifier or source_db_instance_automated_backups_arn is not specified.</summary>
    [JsonPropertyName("sourceDbiResourceId")]
    public string? SourceDbiResourceId { get; set; }

    /// <summary>A boolean value that indicates whether the DB instance is restored from the latest backup time. Defaults to false. Cannot be specified with restore_time.</summary>
    [JsonPropertyName("useLatestRestorableTime")]
    public bool? UseLatestRestorableTime { get; set; }
}

/// <summary>Restore from a Percona Xtrabackup in S3.  See Importing Data into an Amazon RDS MySQL DB Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderS3Import
{
    /// <summary>The bucket name where your backup is stored</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Can be blank, but is the path to your backup</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Role applied to load the data.</summary>
    [JsonPropertyName("ingestionRole")]
    public string? IngestionRole { get; set; }

    /// <summary>Source engine for the backup</summary>
    [JsonPropertyName("sourceEngine")]
    public string? SourceEngine { get; set; }

    /// <summary>Version of the source engine used to make the backup</summary>
    [JsonPropertyName("sourceEngineVersion")]
    public string? SourceEngineVersion { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
public enum V1beta3InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta3InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecInitProviderVpcSecurityGroupIdSelector
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
    public V1beta3InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta3InstanceSpecInitProvider
{
    /// <summary>The allocated storage in gibibytes. If max_allocated_storage is configured, this argument represents the initial storage allocation and differences from the configuration will be ignored automatically when Storage Autoscaling occurs. If replicate_source_db is set, the value is ignored during the creation of the instance.</summary>
    [JsonPropertyName("allocatedStorage")]
    public double? AllocatedStorage { get; set; }

    /// <summary>
    /// Indicates that major version
    /// upgrades are allowed. Changing this parameter does not result in an outage and
    /// the change is asynchronously applied as soon as possible.
    /// </summary>
    [JsonPropertyName("allowMajorVersionUpgrade")]
    public bool? AllowMajorVersionUpgrade { get; set; }

    /// <summary>
    /// Specifies whether any database modifications
    /// are applied immediately, or during the next maintenance window. Default is
    /// false. See Amazon RDS Documentation for more
    /// information.
    /// </summary>
    [JsonPropertyName("applyImmediately")]
    public bool? ApplyImmediately { get; set; }

    /// <summary>
    /// Indicates that minor engine upgrades
    /// will be applied automatically to the DB instance during the maintenance window.
    /// Defaults to true.
    /// </summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary>The AZ for the RDS instance.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>
    /// The days to retain backups for.
    /// Must be between 0 and 35.
    /// Default is 0.
    /// Must be greater than 0 if the database is used as a source for a Read Replica,
    /// uses low-downtime updates,
    /// or will use RDS Blue/Green deployments.
    /// </summary>
    [JsonPropertyName("backupRetentionPeriod")]
    public double? BackupRetentionPeriod { get; set; }

    /// <summary>Specifies where automated backups and manual snapshots are stored. Possible values are region (default) and outposts. See Working with Amazon RDS on AWS Outposts for more information.</summary>
    [JsonPropertyName("backupTarget")]
    public string? BackupTarget { get; set; }

    /// <summary>
    /// The daily time range (in UTC) during which automated backups are created if they are enabled.
    /// Example: &quot;09:46-10:16&quot;. Must not overlap with maintenance_window.
    /// </summary>
    [JsonPropertyName("backupWindow")]
    public string? BackupWindow { get; set; }

    /// <summary>
    /// Enables low-downtime updates using RDS Blue/Green deployments.
    /// See blue_green_update below.
    /// </summary>
    [JsonPropertyName("blueGreenUpdate")]
    public V1beta3InstanceSpecInitProviderBlueGreenUpdate? BlueGreenUpdate { get; set; }

    /// <summary>The identifier of the CA certificate for the DB instance.</summary>
    [JsonPropertyName("caCertIdentifier")]
    public string? CaCertIdentifier { get; set; }

    /// <summary>
    /// The character set name to use for DB encoding in Oracle and Microsoft SQL instances (collation).
    /// This can&apos;t be changed.
    /// See Oracle Character Sets Supported in Amazon RDS or
    /// Server-Level Collation for Microsoft SQL Server for more information.
    /// Cannot be set  with replicate_source_db, restore_to_point_in_time, s3_import, or snapshot_identifier.
    /// </summary>
    [JsonPropertyName("characterSetName")]
    public string? CharacterSetName { get; set; }

    /// <summary>Copy all Instance tags to snapshots. Default is false.</summary>
    [JsonPropertyName("copyTagsToSnapshot")]
    public bool? CopyTagsToSnapshot { get; set; }

    /// <summary>The instance profile associated with the underlying Amazon EC2 instance of an RDS Custom DB instance.</summary>
    [JsonPropertyName("customIamInstanceProfile")]
    public string? CustomIamInstanceProfile { get; set; }

    /// <summary>Indicates whether to enable a customer-owned IP address (CoIP) for an RDS on Outposts DB instance. See CoIP for RDS on Outposts for more information.</summary>
    [JsonPropertyName("customerOwnedIpEnabled")]
    public bool? CustomerOwnedIpEnabled { get; set; }

    /// <summary>The mode of Database Insights that is enabled for the instance. Valid values: standard, advanced .</summary>
    [JsonPropertyName("databaseInsightsMode")]
    public string? DatabaseInsightsMode { get; set; }

    /// <summary>The name of the database to create when the DB instance is created. If this parameter is not specified, no database is created in the DB instance. Note that this does not apply for Oracle or SQL Server engines. See the AWS documentation for more details on what applies for those engines. If you are providing an Oracle db name, it needs to be in all upper case. Cannot be specified for a replica.</summary>
    [JsonPropertyName("dbName")]
    public string? DbName { get; set; }

    /// <summary>
    /// Name of DB subnet group.
    /// DB instance will be created in the VPC associated with the DB subnet group.
    /// If unspecified, will be created in the default Subnet Group.
    /// When working with read replicas created in the same region, defaults to the Subnet Group Name of the source DB.
    /// When working with read replicas created in a different region, defaults to the default Subnet Group.
    /// See DBSubnetGroupName in API action CreateDBInstanceReadReplica for additional read replica constraints.
    /// </summary>
    [JsonPropertyName("dbSubnetGroupName")]
    public string? DbSubnetGroupName { get; set; }

    /// <summary>Reference to a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
    [JsonPropertyName("dbSubnetGroupNameRef")]
    public V1beta3InstanceSpecInitProviderDbSubnetGroupNameRef? DbSubnetGroupNameRef { get; set; }

    /// <summary>Selector for a SubnetGroup in rds to populate dbSubnetGroupName.</summary>
    [JsonPropertyName("dbSubnetGroupNameSelector")]
    public V1beta3InstanceSpecInitProviderDbSubnetGroupNameSelector? DbSubnetGroupNameSelector { get; set; }

    /// <summary>Use a dedicated log volume (DLV) for the DB instance. Requires Provisioned IOPS. See the AWS documentation for more details.</summary>
    [JsonPropertyName("dedicatedLogVolume")]
    public bool? DedicatedLogVolume { get; set; }

    /// <summary>Specifies whether to remove automated backups immediately after the DB instance is deleted. Default is true.</summary>
    [JsonPropertyName("deleteAutomatedBackups")]
    public bool? DeleteAutomatedBackups { get; set; }

    /// <summary>If the DB instance should have deletion protection enabled. The database can&apos;t be deleted when this value is set to true. The default is false.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>The ID of the Directory Service Active Directory domain to create the instance in. Conflicts with domain_fqdn, domain_ou, domain_auth_secret_arn and a domain_dns_ips.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>The ARN for the Secrets Manager secret with the self managed Active Directory credentials for the user joining the domain. Conflicts with domain and domain_iam_role_name.</summary>
    [JsonPropertyName("domainAuthSecretArn")]
    public string? DomainAuthSecretArn { get; set; }

    /// <summary>The IPv4 DNS IP addresses of your primary and secondary self managed Active Directory domain controllers. Two IP addresses must be provided. If there isn&apos;t a secondary domain controller, use the IP address of the primary domain controller for both entries in the list. Conflicts with domain and domain_iam_role_name.</summary>
    [JsonPropertyName("domainDnsIps")]
    public IList<string>? DomainDnsIps { get; set; }

    /// <summary>The fully qualified domain name (FQDN) of the self managed Active Directory domain. Conflicts with domain and domain_iam_role_name.</summary>
    [JsonPropertyName("domainFqdn")]
    public string? DomainFqdn { get; set; }

    /// <summary>The name of the IAM role to be used when making API calls to the Directory Service. Conflicts with domain_fqdn, domain_ou, domain_auth_secret_arn and a domain_dns_ips.</summary>
    [JsonPropertyName("domainIamRoleName")]
    public string? DomainIamRoleName { get; set; }

    /// <summary>The self managed Active Directory organizational unit for your DB instance to join. Conflicts with domain and domain_iam_role_name.</summary>
    [JsonPropertyName("domainOu")]
    public string? DomainOu { get; set; }

    /// <summary>Set of log types to enable for exporting to CloudWatch logs. If omitted, no logs will be exported. For supported values, see the EnableCloudwatchLogsExports.member.N parameter in API action CreateDBInstance.</summary>
    [JsonPropertyName("enabledCloudwatchLogsExports")]
    public IList<string>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>The database engine to use. For supported values, see the Engine parameter in [API action CreateDBInstance](https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_CreateDBInstance.html). Note that for Amazon Aurora instances the engine must match the [DB Cluster](https://marketplace.upbound.io/providers/upbound/provider-aws/latest/resources/rds.aws.upbound.io/Cluster/v1beta1)&apos;s engine&apos;. For information on the difference between the available Aurora MySQL engines see Comparison in the [Amazon RDS Release Notes](https://docs.aws.amazon.com/AmazonRDS/latest/AuroraMySQLReleaseNotes/Welcome.html).</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The life cycle type for this DB instance. This setting applies only to RDS for MySQL and RDS for PostgreSQL. Valid values are open-source-rds-extended-support, open-source-rds-extended-support-disabled. Default value is open-source-rds-extended-support. [Using Amazon RDS Extended Support]: https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/extended-support.html</summary>
    [JsonPropertyName("engineLifecycleSupport")]
    public string? EngineLifecycleSupport { get; set; }

    /// <summary>The engine version to use. If `autoMinorVersionUpgrade` is enabled, you can provide a prefix of the version such as 5.7 (for 5.7.10). The actual engine version used is returned in the attribute `status.atProvider.engineVersionActual`. For supported values, see the EngineVersion parameter in [API action CreateDBInstance](https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_CreateDBInstance.html). Note that for Amazon Aurora instances the engine version must match the [DB Cluster](https://marketplace.upbound.io/providers/upbound/provider-aws/latest/resources/rds.aws.upbound.io/Cluster/v1beta1)&apos;s engine version&apos;.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>
    /// The name of your final DB snapshot
    /// when this DB instance is deleted. Must be provided if skip_final_snapshot is
    /// set to false. The value must begin with a letter, only contain alphanumeric characters and hyphens, and not end with a hyphen or contain two consecutive hyphens. Must not be provided when deleting a read replica.
    /// </summary>
    [JsonPropertyName("finalSnapshotIdentifier")]
    public string? FinalSnapshotIdentifier { get; set; }

    /// <summary>
    /// Specifies whether mappings of AWS Identity and Access Management (IAM) accounts to database
    /// accounts is enabled.
    /// </summary>
    [JsonPropertyName("iamDatabaseAuthenticationEnabled")]
    public bool? IamDatabaseAuthenticationEnabled { get; set; }

    /// <summary>Required if restore_to_point_in_time is specified.</summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    /// <summary>Creates a unique identifier beginning with the specified prefix. Conflicts with identifier.</summary>
    [JsonPropertyName("identifierPrefix")]
    public string? IdentifierPrefix { get; set; }

    /// <summary>The instance type of the RDS instance.</summary>
    [JsonPropertyName("instanceClass")]
    public string? InstanceClass { get; set; }

    /// <summary>
    /// The amount of provisioned IOPS. Setting this implies a
    /// storage_type of &quot;io1&quot; or &quot;io2&quot;. Can only be set when storage_type is &quot;io1&quot;, &quot;io2 or &quot;gp3&quot;.
    /// Cannot be specified for gp3 storage if the allocated_storage value is below a per-engine threshold.
    /// See the RDS User Guide for details.
    /// </summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>
    /// The ARN for the KMS encryption key. If creating an
    /// encrypted replica, set this to the destination KMS ARN.
    /// </summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta3InstanceSpecInitProviderKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta3InstanceSpecInitProviderKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>License model information for this DB instance. Valid values for this field are as follows:</summary>
    [JsonPropertyName("licenseModel")]
    public string? LicenseModel { get; set; }

    /// <summary>
    /// The window to perform maintenance in.
    /// Syntax: &quot;ddd:hh24:mi-ddd:hh24:mi&quot;. Eg: &quot;Mon:00:00-Mon:03:00&quot;. See RDS
    /// Maintenance Window
    /// docs
    /// for more information.
    /// </summary>
    [JsonPropertyName("maintenanceWindow")]
    public string? MaintenanceWindow { get; set; }

    /// <summary>Set to true to allow RDS to manage the master user password in Secrets Manager. Cannot be set if password or password_wo is provided.</summary>
    [JsonPropertyName("manageMasterUserPassword")]
    public bool? ManageMasterUserPassword { get; set; }

    /// <summary>The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias name for the KMS key. To use a KMS key in a different Amazon Web Services account, specify the key ARN or alias ARN. If not specified, the default KMS key for your Amazon Web Services account is used.</summary>
    [JsonPropertyName("masterUserSecretKmsKeyId")]
    public string? MasterUserSecretKmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate masterUserSecretKmsKeyId.</summary>
    [JsonPropertyName("masterUserSecretKmsKeyIdRef")]
    public V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdRef? MasterUserSecretKmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate masterUserSecretKmsKeyId.</summary>
    [JsonPropertyName("masterUserSecretKmsKeyIdSelector")]
    public V1beta3InstanceSpecInitProviderMasterUserSecretKmsKeyIdSelector? MasterUserSecretKmsKeyIdSelector { get; set; }

    /// <summary>Specifies the maximum storage (in GiB) that Amazon RDS can automatically scale to for this DB instance. By default, Storage Autoscaling is disabled. To enable Storage Autoscaling, set max_allocated_storage to greater than or equal to allocated_storage. Setting max_allocated_storage to 0 explicitly disables Storage Autoscaling. When configured, changes to allocated_storage will be automatically ignored as the storage can dynamically scale.</summary>
    [JsonPropertyName("maxAllocatedStorage")]
    public double? MaxAllocatedStorage { get; set; }

    /// <summary>
    /// The interval, in seconds, between points
    /// when Enhanced Monitoring metrics are collected for the DB instance. To disable
    /// collecting Enhanced Monitoring metrics, specify 0. The default is 0. Valid
    /// Values: 0, 1, 5, 10, 15, 30, 60.
    /// </summary>
    [JsonPropertyName("monitoringInterval")]
    public double? MonitoringInterval { get; set; }

    /// <summary>
    /// The ARN for the IAM role that permits RDS
    /// to send enhanced monitoring metrics to CloudWatch Logs. You can find more
    /// information on the AWS
    /// Documentation
    /// what IAM permissions are needed to allow Enhanced Monitoring for RDS Instances.
    /// </summary>
    [JsonPropertyName("monitoringRoleArn")]
    public string? MonitoringRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate monitoringRoleArn.</summary>
    [JsonPropertyName("monitoringRoleArnRef")]
    public V1beta3InstanceSpecInitProviderMonitoringRoleArnRef? MonitoringRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate monitoringRoleArn.</summary>
    [JsonPropertyName("monitoringRoleArnSelector")]
    public V1beta3InstanceSpecInitProviderMonitoringRoleArnSelector? MonitoringRoleArnSelector { get; set; }

    /// <summary>Specifies if the RDS instance is multi-AZ</summary>
    [JsonPropertyName("multiAz")]
    public bool? MultiAz { get; set; }

    /// <summary>
    /// The national character set is used in the NCHAR, NVARCHAR2, and NCLOB data types for Oracle instances. This can&apos;t be changed. See Oracle Character Sets
    /// Supported in Amazon RDS.
    /// </summary>
    [JsonPropertyName("ncharCharacterSetName")]
    public string? NcharCharacterSetName { get; set; }

    /// <summary>The network type of the DB instance. Valid values: IPV4, DUAL.</summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>Name of the DB option group to associate.</summary>
    [JsonPropertyName("optionGroupName")]
    public string? OptionGroupName { get; set; }

    /// <summary>Name of the DB parameter group to associate.</summary>
    [JsonPropertyName("parameterGroupName")]
    public string? ParameterGroupName { get; set; }

    /// <summary>Reference to a ParameterGroup in rds to populate parameterGroupName.</summary>
    [JsonPropertyName("parameterGroupNameRef")]
    public V1beta3InstanceSpecInitProviderParameterGroupNameRef? ParameterGroupNameRef { get; set; }

    /// <summary>Selector for a ParameterGroup in rds to populate parameterGroupName.</summary>
    [JsonPropertyName("parameterGroupNameSelector")]
    public V1beta3InstanceSpecInitProviderParameterGroupNameSelector? ParameterGroupNameSelector { get; set; }

    /// <summary>
    /// Password for the master DB user. Note that this may show up in logs, and it will be stored in the state file. Cannot be set if manage_master_user_password is set to true.
    /// Password for the master DB user. If you set autoGeneratePassword to true, the Secret referenced here will be created or updated with generated password if it does not already contain one.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta3InstanceSpecInitProviderPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>Password for the master DB user. Note that this may show up in logs, and it will be stored in the state file. Cannot be set if manage_master_user_password is set to true.</summary>
    [JsonPropertyName("passwordWoSecretRef")]
    public V1beta3InstanceSpecInitProviderPasswordWoSecretRef? PasswordWoSecretRef { get; set; }

    /// <summary>Used together with password_wo to trigger an update. Increment this value when an update to password_wo is required.</summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>Specifies whether Performance Insights are enabled. Defaults to false.</summary>
    [JsonPropertyName("performanceInsightsEnabled")]
    public bool? PerformanceInsightsEnabled { get; set; }

    /// <summary>The ARN for the KMS key to encrypt Performance Insights data. When specifying performance_insights_kms_key_id, performance_insights_enabled needs to be set to true. Once KMS key is set, it can never be changed.</summary>
    [JsonPropertyName("performanceInsightsKmsKeyId")]
    public string? PerformanceInsightsKmsKeyId { get; set; }

    /// <summary>Amount of time in days to retain Performance Insights data. Valid values are 7, 731 (2 years) or a multiple of 31. When specifying performance_insights_retention_period, performance_insights_enabled needs to be set to true. Defaults to &apos;7&apos;.</summary>
    [JsonPropertyName("performanceInsightsRetentionPeriod")]
    public double? PerformanceInsightsRetentionPeriod { get; set; }

    /// <summary>The port on which the DB accepts connections.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Bool to control if instance is publicly
    /// accessible. Default is false.
    /// </summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>
    /// Specifies whether the replica is in either mounted or open-read-only mode. This attribute
    /// is only supported by Oracle instances. Oracle replicas operate in open-read-only mode unless otherwise specified. See Working with Oracle Read Replicas for more information.
    /// </summary>
    [JsonPropertyName("replicaMode")]
    public string? ReplicaMode { get; set; }

    /// <summary>
    /// Specifies that this resource is a Replica database, and to use this value as the source database.
    /// If replicating an Amazon RDS Database Instance in the same region, use the identifier of the source DB, unless also specifying the db_subnet_group_name.
    /// If specifying the db_subnet_group_name in the same region, use the arn of the source DB.
    /// If replicating an Instance in a different region, use the arn of the source DB.
    /// Note that if you are creating a cross-region replica of an encrypted database you will also need to specify a kms_key_id.
    /// See DB Instance Replication and Working with PostgreSQL and MySQL Read Replicas for more information on using Replication.
    /// </summary>
    [JsonPropertyName("replicateSourceDb")]
    public string? ReplicateSourceDb { get; set; }

    /// <summary>Reference to a Instance in rds to populate replicateSourceDb.</summary>
    [JsonPropertyName("replicateSourceDbRef")]
    public V1beta3InstanceSpecInitProviderReplicateSourceDbRef? ReplicateSourceDbRef { get; set; }

    /// <summary>Selector for a Instance in rds to populate replicateSourceDb.</summary>
    [JsonPropertyName("replicateSourceDbSelector")]
    public V1beta3InstanceSpecInitProviderReplicateSourceDbSelector? ReplicateSourceDbSelector { get; set; }

    /// <summary>
    /// A configuration block for restoring a DB instance to an arbitrary point in time.
    /// Requires the identifier argument to be set with the name of the new DB instance to be created.
    /// See Restore To Point In Time below for details.
    /// </summary>
    [JsonPropertyName("restoreToPointInTime")]
    public V1beta3InstanceSpecInitProviderRestoreToPointInTime? RestoreToPointInTime { get; set; }

    /// <summary>Restore from a Percona Xtrabackup in S3.  See Importing Data into an Amazon RDS MySQL DB Instance</summary>
    [JsonPropertyName("s3Import")]
    public V1beta3InstanceSpecInitProviderS3Import? S3Import { get; set; }

    /// <summary>
    /// Determines whether a final DB snapshot is
    /// created before the DB instance is deleted. If true is specified, no DBSnapshot
    /// is created. If false is specified, a DB snapshot is created before the DB
    /// instance is deleted, using the value from final_snapshot_identifier. Default
    /// is false.
    /// </summary>
    [JsonPropertyName("skipFinalSnapshot")]
    public bool? SkipFinalSnapshot { get; set; }

    /// <summary>
    /// Specifies whether or not to create this database from a snapshot.
    /// This corresponds to the snapshot ID you&apos;d find in the RDS console, e.g: rds:production-2015-06-26-06-05.
    /// </summary>
    [JsonPropertyName("snapshotIdentifier")]
    public string? SnapshotIdentifier { get; set; }

    /// <summary>
    /// Specifies whether the DB instance is
    /// encrypted. Note that if you are creating a cross-region read replica this field
    /// is ignored and you should instead declare kms_key_id with a valid ARN. The
    /// default is false if not specified.
    /// </summary>
    [JsonPropertyName("storageEncrypted")]
    public bool? StorageEncrypted { get; set; }

    /// <summary>The storage throughput value for the DB instance. Can only be set when storage_type is &quot;gp3&quot;. Cannot be specified if the allocated_storage value is below a per-engine threshold. See the RDS User Guide for details.</summary>
    [JsonPropertyName("storageThroughput")]
    public double? StorageThroughput { get; set; }

    /// <summary>
    /// One of &quot;standard&quot; (magnetic), &quot;gp2&quot; (general
    /// purpose SSD), &quot;gp3&quot; (general purpose SSD that needs iops independently)
    /// &quot;io1&quot; (provisioned IOPS SSD) or &quot;io2&quot; (block express storage provisioned IOPS
    /// SSD). The default is &quot;io1&quot; if iops is specified, &quot;gp2&quot; if not.
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// Time zone of the DB instance. timezone is currently
    /// only supported by Microsoft SQL Server. The timezone can only be set on
    /// creation. See MSSQL User
    /// Guide
    /// for more information.
    /// </summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>
    /// Whether to upgrade the storage file system configuration on the read replica.
    /// Can only be set with replicate_source_db.
    /// </summary>
    [JsonPropertyName("upgradeStorageConfig")]
    public bool? UpgradeStorageConfig { get; set; }

    /// <summary>Username for the master DB user. Cannot be specified for a replica.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta3InstanceSpecInitProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta3InstanceSpecInitProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    /// <summary>
    /// List of VPC security groups to
    /// associate.
    /// </summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecManagementPoliciesEnum>))]
public enum V1beta3InstanceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta3InstanceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta3InstanceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta3InstanceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta3InstanceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta3InstanceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta3InstanceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>InstanceSpec defines the desired state of Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceSpec
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
    public V1beta3InstanceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta3InstanceSpecForProvider ForProvider { get; set; }

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
    public V1beta3InstanceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta3InstanceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta3InstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta3InstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Enables low-downtime updates using RDS Blue/Green deployments.
/// See blue_green_update below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceStatusAtProviderBlueGreenUpdate
{
    /// <summary>
    /// Enables low-downtime updates when true.
    /// Default is false.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceStatusAtProviderListenerEndpoint
{
    /// <summary>The hostname of the RDS instance. See also endpoint and port.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// The canonical hosted zone ID of the DB instance (to be used
    /// in a Route 53 Alias record).
    /// </summary>
    [JsonPropertyName("hostedZoneId")]
    public string? HostedZoneId { get; set; }

    /// <summary>The port on which the DB accepts connections.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceStatusAtProviderMasterUserSecret
{
    /// <summary>The Amazon Web Services KMS key identifier that is used to encrypt the secret.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the secret.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }

    /// <summary>The status of the secret. Valid Values: creating | active | rotating | impaired.</summary>
    [JsonPropertyName("secretStatus")]
    public string? SecretStatus { get; set; }
}

/// <summary>
/// A configuration block for restoring a DB instance to an arbitrary point in time.
/// Requires the identifier argument to be set with the name of the new DB instance to be created.
/// See Restore To Point In Time below for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceStatusAtProviderRestoreToPointInTime
{
    /// <summary>The date and time to restore from. Value must be a time in Universal Coordinated Time (UTC) format and must be before the latest restorable time for the DB instance. Cannot be specified with use_latest_restorable_time.</summary>
    [JsonPropertyName("restoreTime")]
    public string? RestoreTime { get; set; }

    /// <summary>The ARN of the automated backup from which to restore. Required if source_db_instance_identifier or source_dbi_resource_id is not specified.</summary>
    [JsonPropertyName("sourceDbInstanceAutomatedBackupsArn")]
    public string? SourceDbInstanceAutomatedBackupsArn { get; set; }

    /// <summary>The identifier of the source DB instance from which to restore. Must match the identifier of an existing DB instance. Required if source_db_instance_automated_backups_arn or source_dbi_resource_id is not specified.</summary>
    [JsonPropertyName("sourceDbInstanceIdentifier")]
    public string? SourceDbInstanceIdentifier { get; set; }

    /// <summary>The resource ID of the source DB instance from which to restore. Required if source_db_instance_identifier or source_db_instance_automated_backups_arn is not specified.</summary>
    [JsonPropertyName("sourceDbiResourceId")]
    public string? SourceDbiResourceId { get; set; }

    /// <summary>A boolean value that indicates whether the DB instance is restored from the latest backup time. Defaults to false. Cannot be specified with restore_time.</summary>
    [JsonPropertyName("useLatestRestorableTime")]
    public bool? UseLatestRestorableTime { get; set; }
}

/// <summary>Restore from a Percona Xtrabackup in S3.  See Importing Data into an Amazon RDS MySQL DB Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceStatusAtProviderS3Import
{
    /// <summary>The bucket name where your backup is stored</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>Can be blank, but is the path to your backup</summary>
    [JsonPropertyName("bucketPrefix")]
    public string? BucketPrefix { get; set; }

    /// <summary>Role applied to load the data.</summary>
    [JsonPropertyName("ingestionRole")]
    public string? IngestionRole { get; set; }

    /// <summary>Source engine for the backup</summary>
    [JsonPropertyName("sourceEngine")]
    public string? SourceEngine { get; set; }

    /// <summary>Version of the source engine used to make the backup</summary>
    [JsonPropertyName("sourceEngineVersion")]
    public string? SourceEngineVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceStatusAtProvider
{
    /// <summary>The hostname of the RDS instance. See also endpoint and port.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The allocated storage in gibibytes. If max_allocated_storage is configured, this argument represents the initial storage allocation and differences from the configuration will be ignored automatically when Storage Autoscaling occurs. If replicate_source_db is set, the value is ignored during the creation of the instance.</summary>
    [JsonPropertyName("allocatedStorage")]
    public double? AllocatedStorage { get; set; }

    /// <summary>
    /// Indicates that major version
    /// upgrades are allowed. Changing this parameter does not result in an outage and
    /// the change is asynchronously applied as soon as possible.
    /// </summary>
    [JsonPropertyName("allowMajorVersionUpgrade")]
    public bool? AllowMajorVersionUpgrade { get; set; }

    /// <summary>
    /// Specifies whether any database modifications
    /// are applied immediately, or during the next maintenance window. Default is
    /// false. See Amazon RDS Documentation for more
    /// information.
    /// </summary>
    [JsonPropertyName("applyImmediately")]
    public bool? ApplyImmediately { get; set; }

    /// <summary>The ARN of the RDS instance.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// Indicates that minor engine upgrades
    /// will be applied automatically to the DB instance during the maintenance window.
    /// Defaults to true.
    /// </summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary>The AZ for the RDS instance.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>
    /// The days to retain backups for.
    /// Must be between 0 and 35.
    /// Default is 0.
    /// Must be greater than 0 if the database is used as a source for a Read Replica,
    /// uses low-downtime updates,
    /// or will use RDS Blue/Green deployments.
    /// </summary>
    [JsonPropertyName("backupRetentionPeriod")]
    public double? BackupRetentionPeriod { get; set; }

    /// <summary>Specifies where automated backups and manual snapshots are stored. Possible values are region (default) and outposts. See Working with Amazon RDS on AWS Outposts for more information.</summary>
    [JsonPropertyName("backupTarget")]
    public string? BackupTarget { get; set; }

    /// <summary>
    /// The daily time range (in UTC) during which automated backups are created if they are enabled.
    /// Example: &quot;09:46-10:16&quot;. Must not overlap with maintenance_window.
    /// </summary>
    [JsonPropertyName("backupWindow")]
    public string? BackupWindow { get; set; }

    /// <summary>
    /// Enables low-downtime updates using RDS Blue/Green deployments.
    /// See blue_green_update below.
    /// </summary>
    [JsonPropertyName("blueGreenUpdate")]
    public V1beta3InstanceStatusAtProviderBlueGreenUpdate? BlueGreenUpdate { get; set; }

    /// <summary>The identifier of the CA certificate for the DB instance.</summary>
    [JsonPropertyName("caCertIdentifier")]
    public string? CaCertIdentifier { get; set; }

    /// <summary>
    /// The character set name to use for DB encoding in Oracle and Microsoft SQL instances (collation).
    /// This can&apos;t be changed.
    /// See Oracle Character Sets Supported in Amazon RDS or
    /// Server-Level Collation for Microsoft SQL Server for more information.
    /// Cannot be set  with replicate_source_db, restore_to_point_in_time, s3_import, or snapshot_identifier.
    /// </summary>
    [JsonPropertyName("characterSetName")]
    public string? CharacterSetName { get; set; }

    /// <summary>Copy all Instance tags to snapshots. Default is false.</summary>
    [JsonPropertyName("copyTagsToSnapshot")]
    public bool? CopyTagsToSnapshot { get; set; }

    /// <summary>The instance profile associated with the underlying Amazon EC2 instance of an RDS Custom DB instance.</summary>
    [JsonPropertyName("customIamInstanceProfile")]
    public string? CustomIamInstanceProfile { get; set; }

    /// <summary>Indicates whether to enable a customer-owned IP address (CoIP) for an RDS on Outposts DB instance. See CoIP for RDS on Outposts for more information.</summary>
    [JsonPropertyName("customerOwnedIpEnabled")]
    public bool? CustomerOwnedIpEnabled { get; set; }

    /// <summary>The mode of Database Insights that is enabled for the instance. Valid values: standard, advanced .</summary>
    [JsonPropertyName("databaseInsightsMode")]
    public string? DatabaseInsightsMode { get; set; }

    /// <summary>The name of the database to create when the DB instance is created. If this parameter is not specified, no database is created in the DB instance. Note that this does not apply for Oracle or SQL Server engines. See the AWS documentation for more details on what applies for those engines. If you are providing an Oracle db name, it needs to be in all upper case. Cannot be specified for a replica.</summary>
    [JsonPropertyName("dbName")]
    public string? DbName { get; set; }

    /// <summary>
    /// Name of DB subnet group.
    /// DB instance will be created in the VPC associated with the DB subnet group.
    /// If unspecified, will be created in the default Subnet Group.
    /// When working with read replicas created in the same region, defaults to the Subnet Group Name of the source DB.
    /// When working with read replicas created in a different region, defaults to the default Subnet Group.
    /// See DBSubnetGroupName in API action CreateDBInstanceReadReplica for additional read replica constraints.
    /// </summary>
    [JsonPropertyName("dbSubnetGroupName")]
    public string? DbSubnetGroupName { get; set; }

    /// <summary>Use a dedicated log volume (DLV) for the DB instance. Requires Provisioned IOPS. See the AWS documentation for more details.</summary>
    [JsonPropertyName("dedicatedLogVolume")]
    public bool? DedicatedLogVolume { get; set; }

    /// <summary>Specifies whether to remove automated backups immediately after the DB instance is deleted. Default is true.</summary>
    [JsonPropertyName("deleteAutomatedBackups")]
    public bool? DeleteAutomatedBackups { get; set; }

    /// <summary>If the DB instance should have deletion protection enabled. The database can&apos;t be deleted when this value is set to true. The default is false.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>The ID of the Directory Service Active Directory domain to create the instance in. Conflicts with domain_fqdn, domain_ou, domain_auth_secret_arn and a domain_dns_ips.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>The ARN for the Secrets Manager secret with the self managed Active Directory credentials for the user joining the domain. Conflicts with domain and domain_iam_role_name.</summary>
    [JsonPropertyName("domainAuthSecretArn")]
    public string? DomainAuthSecretArn { get; set; }

    /// <summary>The IPv4 DNS IP addresses of your primary and secondary self managed Active Directory domain controllers. Two IP addresses must be provided. If there isn&apos;t a secondary domain controller, use the IP address of the primary domain controller for both entries in the list. Conflicts with domain and domain_iam_role_name.</summary>
    [JsonPropertyName("domainDnsIps")]
    public IList<string>? DomainDnsIps { get; set; }

    /// <summary>The fully qualified domain name (FQDN) of the self managed Active Directory domain. Conflicts with domain and domain_iam_role_name.</summary>
    [JsonPropertyName("domainFqdn")]
    public string? DomainFqdn { get; set; }

    /// <summary>The name of the IAM role to be used when making API calls to the Directory Service. Conflicts with domain_fqdn, domain_ou, domain_auth_secret_arn and a domain_dns_ips.</summary>
    [JsonPropertyName("domainIamRoleName")]
    public string? DomainIamRoleName { get; set; }

    /// <summary>The self managed Active Directory organizational unit for your DB instance to join. Conflicts with domain and domain_iam_role_name.</summary>
    [JsonPropertyName("domainOu")]
    public string? DomainOu { get; set; }

    /// <summary>Set of log types to enable for exporting to CloudWatch logs. If omitted, no logs will be exported. For supported values, see the EnableCloudwatchLogsExports.member.N parameter in API action CreateDBInstance.</summary>
    [JsonPropertyName("enabledCloudwatchLogsExports")]
    public IList<string>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>The connection endpoint in address:port format.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The database engine to use. For supported values, see the Engine parameter in [API action CreateDBInstance](https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_CreateDBInstance.html). Note that for Amazon Aurora instances the engine must match the [DB Cluster](https://marketplace.upbound.io/providers/upbound/provider-aws/latest/resources/rds.aws.upbound.io/Cluster/v1beta1)&apos;s engine&apos;. For information on the difference between the available Aurora MySQL engines see Comparison in the [Amazon RDS Release Notes](https://docs.aws.amazon.com/AmazonRDS/latest/AuroraMySQLReleaseNotes/Welcome.html).</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The life cycle type for this DB instance. This setting applies only to RDS for MySQL and RDS for PostgreSQL. Valid values are open-source-rds-extended-support, open-source-rds-extended-support-disabled. Default value is open-source-rds-extended-support. [Using Amazon RDS Extended Support]: https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/extended-support.html</summary>
    [JsonPropertyName("engineLifecycleSupport")]
    public string? EngineLifecycleSupport { get; set; }

    /// <summary>The engine version to use. If `autoMinorVersionUpgrade` is enabled, you can provide a prefix of the version such as 5.7 (for 5.7.10). The actual engine version used is returned in the attribute `status.atProvider.engineVersionActual`. For supported values, see the EngineVersion parameter in [API action CreateDBInstance](https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_CreateDBInstance.html). Note that for Amazon Aurora instances the engine version must match the [DB Cluster](https://marketplace.upbound.io/providers/upbound/provider-aws/latest/resources/rds.aws.upbound.io/Cluster/v1beta1)&apos;s engine version&apos;.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>The running version of the database.</summary>
    [JsonPropertyName("engineVersionActual")]
    public string? EngineVersionActual { get; set; }

    /// <summary>
    /// The name of your final DB snapshot
    /// when this DB instance is deleted. Must be provided if skip_final_snapshot is
    /// set to false. The value must begin with a letter, only contain alphanumeric characters and hyphens, and not end with a hyphen or contain two consecutive hyphens. Must not be provided when deleting a read replica.
    /// </summary>
    [JsonPropertyName("finalSnapshotIdentifier")]
    public string? FinalSnapshotIdentifier { get; set; }

    /// <summary>
    /// The canonical hosted zone ID of the DB instance (to be used
    /// in a Route 53 Alias record).
    /// </summary>
    [JsonPropertyName("hostedZoneId")]
    public string? HostedZoneId { get; set; }

    /// <summary>
    /// Specifies whether mappings of AWS Identity and Access Management (IAM) accounts to database
    /// accounts is enabled.
    /// </summary>
    [JsonPropertyName("iamDatabaseAuthenticationEnabled")]
    public bool? IamDatabaseAuthenticationEnabled { get; set; }

    /// <summary>RDS DBI resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Required if restore_to_point_in_time is specified.</summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    /// <summary>Creates a unique identifier beginning with the specified prefix. Conflicts with identifier.</summary>
    [JsonPropertyName("identifierPrefix")]
    public string? IdentifierPrefix { get; set; }

    /// <summary>The instance type of the RDS instance.</summary>
    [JsonPropertyName("instanceClass")]
    public string? InstanceClass { get; set; }

    /// <summary>
    /// The amount of provisioned IOPS. Setting this implies a
    /// storage_type of &quot;io1&quot; or &quot;io2&quot;. Can only be set when storage_type is &quot;io1&quot;, &quot;io2 or &quot;gp3&quot;.
    /// Cannot be specified for gp3 storage if the allocated_storage value is below a per-engine threshold.
    /// See the RDS User Guide for details.
    /// </summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>
    /// The ARN for the KMS encryption key. If creating an
    /// encrypted replica, set this to the destination KMS ARN.
    /// </summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The latest time, in UTC RFC3339 format, to which a database can be restored with point-in-time restore.</summary>
    [JsonPropertyName("latestRestorableTime")]
    public string? LatestRestorableTime { get; set; }

    /// <summary>License model information for this DB instance. Valid values for this field are as follows:</summary>
    [JsonPropertyName("licenseModel")]
    public string? LicenseModel { get; set; }

    /// <summary>Specifies the listener connection endpoint for SQL Server Always On. See endpoint below.</summary>
    [JsonPropertyName("listenerEndpoint")]
    public IList<V1beta3InstanceStatusAtProviderListenerEndpoint>? ListenerEndpoint { get; set; }

    /// <summary>
    /// The window to perform maintenance in.
    /// Syntax: &quot;ddd:hh24:mi-ddd:hh24:mi&quot;. Eg: &quot;Mon:00:00-Mon:03:00&quot;. See RDS
    /// Maintenance Window
    /// docs
    /// for more information.
    /// </summary>
    [JsonPropertyName("maintenanceWindow")]
    public string? MaintenanceWindow { get; set; }

    /// <summary>Set to true to allow RDS to manage the master user password in Secrets Manager. Cannot be set if password or password_wo is provided.</summary>
    [JsonPropertyName("manageMasterUserPassword")]
    public bool? ManageMasterUserPassword { get; set; }

    /// <summary>A block that specifies the master user secret. Only available when manage_master_user_password is set to true. Documented below.</summary>
    [JsonPropertyName("masterUserSecret")]
    public IList<V1beta3InstanceStatusAtProviderMasterUserSecret>? MasterUserSecret { get; set; }

    /// <summary>The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias name for the KMS key. To use a KMS key in a different Amazon Web Services account, specify the key ARN or alias ARN. If not specified, the default KMS key for your Amazon Web Services account is used.</summary>
    [JsonPropertyName("masterUserSecretKmsKeyId")]
    public string? MasterUserSecretKmsKeyId { get; set; }

    /// <summary>Specifies the maximum storage (in GiB) that Amazon RDS can automatically scale to for this DB instance. By default, Storage Autoscaling is disabled. To enable Storage Autoscaling, set max_allocated_storage to greater than or equal to allocated_storage. Setting max_allocated_storage to 0 explicitly disables Storage Autoscaling. When configured, changes to allocated_storage will be automatically ignored as the storage can dynamically scale.</summary>
    [JsonPropertyName("maxAllocatedStorage")]
    public double? MaxAllocatedStorage { get; set; }

    /// <summary>
    /// The interval, in seconds, between points
    /// when Enhanced Monitoring metrics are collected for the DB instance. To disable
    /// collecting Enhanced Monitoring metrics, specify 0. The default is 0. Valid
    /// Values: 0, 1, 5, 10, 15, 30, 60.
    /// </summary>
    [JsonPropertyName("monitoringInterval")]
    public double? MonitoringInterval { get; set; }

    /// <summary>
    /// The ARN for the IAM role that permits RDS
    /// to send enhanced monitoring metrics to CloudWatch Logs. You can find more
    /// information on the AWS
    /// Documentation
    /// what IAM permissions are needed to allow Enhanced Monitoring for RDS Instances.
    /// </summary>
    [JsonPropertyName("monitoringRoleArn")]
    public string? MonitoringRoleArn { get; set; }

    /// <summary>Specifies if the RDS instance is multi-AZ</summary>
    [JsonPropertyName("multiAz")]
    public bool? MultiAz { get; set; }

    /// <summary>
    /// The national character set is used in the NCHAR, NVARCHAR2, and NCLOB data types for Oracle instances. This can&apos;t be changed. See Oracle Character Sets
    /// Supported in Amazon RDS.
    /// </summary>
    [JsonPropertyName("ncharCharacterSetName")]
    public string? NcharCharacterSetName { get; set; }

    /// <summary>The network type of the DB instance. Valid values: IPV4, DUAL.</summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>Name of the DB option group to associate.</summary>
    [JsonPropertyName("optionGroupName")]
    public string? OptionGroupName { get; set; }

    /// <summary>Name of the DB parameter group to associate.</summary>
    [JsonPropertyName("parameterGroupName")]
    public string? ParameterGroupName { get; set; }

    /// <summary>Used together with password_wo to trigger an update. Increment this value when an update to password_wo is required.</summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>Specifies whether Performance Insights are enabled. Defaults to false.</summary>
    [JsonPropertyName("performanceInsightsEnabled")]
    public bool? PerformanceInsightsEnabled { get; set; }

    /// <summary>The ARN for the KMS key to encrypt Performance Insights data. When specifying performance_insights_kms_key_id, performance_insights_enabled needs to be set to true. Once KMS key is set, it can never be changed.</summary>
    [JsonPropertyName("performanceInsightsKmsKeyId")]
    public string? PerformanceInsightsKmsKeyId { get; set; }

    /// <summary>Amount of time in days to retain Performance Insights data. Valid values are 7, 731 (2 years) or a multiple of 31. When specifying performance_insights_retention_period, performance_insights_enabled needs to be set to true. Defaults to &apos;7&apos;.</summary>
    [JsonPropertyName("performanceInsightsRetentionPeriod")]
    public double? PerformanceInsightsRetentionPeriod { get; set; }

    /// <summary>The port on which the DB accepts connections.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Bool to control if instance is publicly
    /// accessible. Default is false.
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
    /// Specifies whether the replica is in either mounted or open-read-only mode. This attribute
    /// is only supported by Oracle instances. Oracle replicas operate in open-read-only mode unless otherwise specified. See Working with Oracle Read Replicas for more information.
    /// </summary>
    [JsonPropertyName("replicaMode")]
    public string? ReplicaMode { get; set; }

    [JsonPropertyName("replicas")]
    public IList<string>? Replicas { get; set; }

    /// <summary>
    /// Specifies that this resource is a Replica database, and to use this value as the source database.
    /// If replicating an Amazon RDS Database Instance in the same region, use the identifier of the source DB, unless also specifying the db_subnet_group_name.
    /// If specifying the db_subnet_group_name in the same region, use the arn of the source DB.
    /// If replicating an Instance in a different region, use the arn of the source DB.
    /// Note that if you are creating a cross-region replica of an encrypted database you will also need to specify a kms_key_id.
    /// See DB Instance Replication and Working with PostgreSQL and MySQL Read Replicas for more information on using Replication.
    /// </summary>
    [JsonPropertyName("replicateSourceDb")]
    public string? ReplicateSourceDb { get; set; }

    /// <summary>The RDS Resource ID of this instance.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>
    /// A configuration block for restoring a DB instance to an arbitrary point in time.
    /// Requires the identifier argument to be set with the name of the new DB instance to be created.
    /// See Restore To Point In Time below for details.
    /// </summary>
    [JsonPropertyName("restoreToPointInTime")]
    public V1beta3InstanceStatusAtProviderRestoreToPointInTime? RestoreToPointInTime { get; set; }

    /// <summary>Restore from a Percona Xtrabackup in S3.  See Importing Data into an Amazon RDS MySQL DB Instance</summary>
    [JsonPropertyName("s3Import")]
    public V1beta3InstanceStatusAtProviderS3Import? S3Import { get; set; }

    /// <summary>
    /// Determines whether a final DB snapshot is
    /// created before the DB instance is deleted. If true is specified, no DBSnapshot
    /// is created. If false is specified, a DB snapshot is created before the DB
    /// instance is deleted, using the value from final_snapshot_identifier. Default
    /// is false.
    /// </summary>
    [JsonPropertyName("skipFinalSnapshot")]
    public bool? SkipFinalSnapshot { get; set; }

    /// <summary>
    /// Specifies whether or not to create this database from a snapshot.
    /// This corresponds to the snapshot ID you&apos;d find in the RDS console, e.g: rds:production-2015-06-26-06-05.
    /// </summary>
    [JsonPropertyName("snapshotIdentifier")]
    public string? SnapshotIdentifier { get; set; }

    /// <summary>The RDS instance status.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Specifies whether the DB instance is
    /// encrypted. Note that if you are creating a cross-region read replica this field
    /// is ignored and you should instead declare kms_key_id with a valid ARN. The
    /// default is false if not specified.
    /// </summary>
    [JsonPropertyName("storageEncrypted")]
    public bool? StorageEncrypted { get; set; }

    /// <summary>The storage throughput value for the DB instance. Can only be set when storage_type is &quot;gp3&quot;. Cannot be specified if the allocated_storage value is below a per-engine threshold. See the RDS User Guide for details.</summary>
    [JsonPropertyName("storageThroughput")]
    public double? StorageThroughput { get; set; }

    /// <summary>
    /// One of &quot;standard&quot; (magnetic), &quot;gp2&quot; (general
    /// purpose SSD), &quot;gp3&quot; (general purpose SSD that needs iops independently)
    /// &quot;io1&quot; (provisioned IOPS SSD) or &quot;io2&quot; (block express storage provisioned IOPS
    /// SSD). The default is &quot;io1&quot; if iops is specified, &quot;gp2&quot; if not.
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>
    /// Time zone of the DB instance. timezone is currently
    /// only supported by Microsoft SQL Server. The timezone can only be set on
    /// creation. See MSSQL User
    /// Guide
    /// for more information.
    /// </summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>Order in which the instances are upgraded (first, second, last). See the AWS documentation for details.</summary>
    [JsonPropertyName("upgradeRolloutOrder")]
    public string? UpgradeRolloutOrder { get; set; }

    /// <summary>
    /// Whether to upgrade the storage file system configuration on the read replica.
    /// Can only be set with replicate_source_db.
    /// </summary>
    [JsonPropertyName("upgradeStorageConfig")]
    public bool? UpgradeStorageConfig { get; set; }

    /// <summary>Username for the master DB user. Cannot be specified for a replica.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// List of VPC security groups to
    /// associate.
    /// </summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceStatusConditions
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

/// <summary>InstanceStatus defines the observed state of Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta3InstanceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta3InstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta3InstanceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Instance is the Schema for the Instances API. Provides an RDS instance resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta3Instance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta3InstanceSpec>, IStatus<V1beta3InstanceStatus?>
{
    public const string KubeApiVersion = "v1beta3";
    public const string KubeKind = "Instance";
    public const string KubeGroup = "rds.aws.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.aws.upbound.io/v1beta3";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Instance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceSpec defines the desired state of Instance</summary>
    [JsonPropertyName("spec")]
    public required V1beta3InstanceSpec Spec { get; set; }

    /// <summary>InstanceStatus defines the observed state of Instance.</summary>
    [JsonPropertyName("status")]
    public V1beta3InstanceStatus? Status { get; set; }
}
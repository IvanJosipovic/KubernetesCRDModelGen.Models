#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sagemaker.aws.upbound.io;
/// <summary>Workteam is the Schema for the Workteams API. Provides a SageMaker AI Workteam resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2WorkteamList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Workteam>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "WorkteamList";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "workteams";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkteamList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Workteam objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Workteam> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecDeletionPolicyEnum>))]
public enum V1beta2WorkteamSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicyResolutionEnum>))]
public enum V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicyResolveEnum>))]
public enum V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a UserPoolClient in cognitoidp to populate clientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicyResolveEnum>))]
public enum V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a UserPoolClient in cognitoidp to populate clientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdSelector
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
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicyResolutionEnum>))]
public enum V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicyResolveEnum>))]
public enum V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a UserGroup in cognitoidp to populate userGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicyResolveEnum>))]
public enum V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a UserGroup in cognitoidp to populate userGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelector
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
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicyResolutionEnum>))]
public enum V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicyResolveEnum>))]
public enum V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a UserPoolDomain in cognitoidp to populate userPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicyResolveEnum>))]
public enum V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a UserPoolDomain in cognitoidp to populate userPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelector
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
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicy? Policy { get; set; }
}

/// <summary>The Amazon Cognito user group that is part of the work team. See Cognito Member Definition details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinition
{
    /// <summary>An identifier for an application client. You must create the app client ID using Amazon Cognito.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Reference to a UserPoolClient in cognitoidp to populate clientId.</summary>
    [JsonPropertyName("clientIdRef")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdRef? ClientIdRef { get; set; }

    /// <summary>Selector for a UserPoolClient in cognitoidp to populate clientId.</summary>
    [JsonPropertyName("clientIdSelector")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionClientIdSelector? ClientIdSelector { get; set; }

    /// <summary>An identifier for a user group.</summary>
    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }

    /// <summary>Reference to a UserGroup in cognitoidp to populate userGroup.</summary>
    [JsonPropertyName("userGroupRef")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupRef? UserGroupRef { get; set; }

    /// <summary>Selector for a UserGroup in cognitoidp to populate userGroup.</summary>
    [JsonPropertyName("userGroupSelector")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelector? UserGroupSelector { get; set; }

    /// <summary>An identifier for a user pool. The user pool must be in the same region as the service that you are calling.</summary>
    [JsonPropertyName("userPool")]
    public string? UserPool { get; set; }

    /// <summary>Reference to a UserPoolDomain in cognitoidp to populate userPool.</summary>
    [JsonPropertyName("userPoolRef")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolRef? UserPoolRef { get; set; }

    /// <summary>Selector for a UserPoolDomain in cognitoidp to populate userPool.</summary>
    [JsonPropertyName("userPoolSelector")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelector? UserPoolSelector { get; set; }
}

/// <summary>A list user groups that exist in your OIDC Identity Provider (IdP). One to ten groups can be used to create a single private work team. See Cognito Member Definition details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderMemberDefinitionOidcMemberDefinition
{
    /// <summary>A list of comma separated strings that identifies user groups in your OIDC IdP. Each user group is made up of a group of private workers.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderMemberDefinition
{
    /// <summary>The Amazon Cognito user group that is part of the work team. See Cognito Member Definition details below.</summary>
    [JsonPropertyName("cognitoMemberDefinition")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionCognitoMemberDefinition? CognitoMemberDefinition { get; set; }

    /// <summary>A list user groups that exist in your OIDC Identity Provider (IdP). One to ten groups can be used to create a single private work team. See Cognito Member Definition details below.</summary>
    [JsonPropertyName("oidcMemberDefinition")]
    public V1beta2WorkteamSpecForProviderMemberDefinitionOidcMemberDefinition? OidcMemberDefinition { get; set; }
}

/// <summary>Configures notification of workers regarding available or expiring work items. see Notification Configuration details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderNotificationConfiguration
{
    /// <summary>The ARN for the SNS topic to which notifications should be published.</summary>
    [JsonPropertyName("notificationTopicArn")]
    public string? NotificationTopicArn { get; set; }
}

/// <summary>Use this parameter to specify the allowed request source. Possible sources are either SourceIp or VpcSourceIp. see IAM Policy Constraints details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderWorkerAccessConfigurationS3PresignIamPolicyConstraints
{
    /// <summary>When SourceIp is Enabled the worker&apos;s IP address when a task is rendered in the worker portal is added to the IAM policy as a Condition used to generate the Amazon S3 presigned URL. This IP address is checked by Amazon S3 and must match in order for the Amazon S3 resource to be rendered in the worker portal. Valid values are Enabled or Disabled</summary>
    [JsonPropertyName("sourceIp")]
    public string? SourceIp { get; set; }

    /// <summary>When VpcSourceIp is Enabled the worker&apos;s IP address when a task is rendered in private worker portal inside the VPC is added to the IAM policy as a Condition used to generate the Amazon S3 presigned URL. To render the task successfully Amazon S3 checks that the presigned URL is being accessed over an Amazon S3 VPC Endpoint, and that the worker&apos;s IP address matches the IP address in the IAM policy. To learn more about configuring private worker portal, see Use Amazon VPC mode from a private worker portal. Valid values are Enabled or Disabled</summary>
    [JsonPropertyName("vpcSourceIp")]
    public string? VpcSourceIp { get; set; }
}

/// <summary>Defines any Amazon S3 resource constraints. see S3 Presign details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderWorkerAccessConfigurationS3Presign
{
    /// <summary>Use this parameter to specify the allowed request source. Possible sources are either SourceIp or VpcSourceIp. see IAM Policy Constraints details below.</summary>
    [JsonPropertyName("iamPolicyConstraints")]
    public V1beta2WorkteamSpecForProviderWorkerAccessConfigurationS3PresignIamPolicyConstraints? IamPolicyConstraints { get; set; }
}

/// <summary>Use this optional parameter to constrain access to an Amazon S3 resource based on the IP address using supported IAM global condition keys. The Amazon S3 resource is accessed in the worker portal using a Amazon S3 presigned URL. see Worker Access Configuration details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderWorkerAccessConfiguration
{
    /// <summary>Defines any Amazon S3 resource constraints. see S3 Presign details below.</summary>
    [JsonPropertyName("s3Presign")]
    public V1beta2WorkteamSpecForProviderWorkerAccessConfigurationS3Presign? S3Presign { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecForProviderWorkforceNameRefPolicyResolutionEnum>))]
public enum V1beta2WorkteamSpecForProviderWorkforceNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecForProviderWorkforceNameRefPolicyResolveEnum>))]
public enum V1beta2WorkteamSpecForProviderWorkforceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderWorkforceNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkteamSpecForProviderWorkforceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkteamSpecForProviderWorkforceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Workforce in sagemaker to populate workforceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderWorkforceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkteamSpecForProviderWorkforceNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecForProviderWorkforceNameSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkteamSpecForProviderWorkforceNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecForProviderWorkforceNameSelectorPolicyResolveEnum>))]
public enum V1beta2WorkteamSpecForProviderWorkforceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderWorkforceNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkteamSpecForProviderWorkforceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkteamSpecForProviderWorkforceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Workforce in sagemaker to populate workforceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProviderWorkforceNameSelector
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
    public V1beta2WorkteamSpecForProviderWorkforceNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecForProvider
{
    /// <summary>A description of the work team.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A list of Member Definitions that contains objects that identify the workers that make up the work team. Workforces can be created using Amazon Cognito or your own OIDC Identity Provider (IdP). For private workforces created using Amazon Cognito use cognito_member_definition. For workforces created using your own OIDC identity provider (IdP) use oidc_member_definition. Do not provide input for both of these parameters in a single request. see Member Definition details below.</summary>
    [JsonPropertyName("memberDefinition")]
    public IList<V1beta2WorkteamSpecForProviderMemberDefinition>? MemberDefinition { get; set; }

    /// <summary>Configures notification of workers regarding available or expiring work items. see Notification Configuration details below.</summary>
    [JsonPropertyName("notificationConfiguration")]
    public V1beta2WorkteamSpecForProviderNotificationConfiguration? NotificationConfiguration { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Use this optional parameter to constrain access to an Amazon S3 resource based on the IP address using supported IAM global condition keys. The Amazon S3 resource is accessed in the worker portal using a Amazon S3 presigned URL. see Worker Access Configuration details below.</summary>
    [JsonPropertyName("workerAccessConfiguration")]
    public V1beta2WorkteamSpecForProviderWorkerAccessConfiguration? WorkerAccessConfiguration { get; set; }

    /// <summary>The name of the workforce.</summary>
    [JsonPropertyName("workforceName")]
    public string? WorkforceName { get; set; }

    /// <summary>Reference to a Workforce in sagemaker to populate workforceName.</summary>
    [JsonPropertyName("workforceNameRef")]
    public V1beta2WorkteamSpecForProviderWorkforceNameRef? WorkforceNameRef { get; set; }

    /// <summary>Selector for a Workforce in sagemaker to populate workforceName.</summary>
    [JsonPropertyName("workforceNameSelector")]
    public V1beta2WorkteamSpecForProviderWorkforceNameSelector? WorkforceNameSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicyResolutionEnum>))]
public enum V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicyResolveEnum>))]
public enum V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a UserPoolClient in cognitoidp to populate clientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicyResolveEnum>))]
public enum V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a UserPoolClient in cognitoidp to populate clientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdSelector
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
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicyResolutionEnum>))]
public enum V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicyResolveEnum>))]
public enum V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a UserGroup in cognitoidp to populate userGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicyResolveEnum>))]
public enum V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a UserGroup in cognitoidp to populate userGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelector
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
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicyResolutionEnum>))]
public enum V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicyResolveEnum>))]
public enum V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a UserPoolDomain in cognitoidp to populate userPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicyResolveEnum>))]
public enum V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a UserPoolDomain in cognitoidp to populate userPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelector
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
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelectorPolicy? Policy { get; set; }
}

/// <summary>The Amazon Cognito user group that is part of the work team. See Cognito Member Definition details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinition
{
    /// <summary>An identifier for an application client. You must create the app client ID using Amazon Cognito.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Reference to a UserPoolClient in cognitoidp to populate clientId.</summary>
    [JsonPropertyName("clientIdRef")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdRef? ClientIdRef { get; set; }

    /// <summary>Selector for a UserPoolClient in cognitoidp to populate clientId.</summary>
    [JsonPropertyName("clientIdSelector")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionClientIdSelector? ClientIdSelector { get; set; }

    /// <summary>An identifier for a user group.</summary>
    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }

    /// <summary>Reference to a UserGroup in cognitoidp to populate userGroup.</summary>
    [JsonPropertyName("userGroupRef")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupRef? UserGroupRef { get; set; }

    /// <summary>Selector for a UserGroup in cognitoidp to populate userGroup.</summary>
    [JsonPropertyName("userGroupSelector")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserGroupSelector? UserGroupSelector { get; set; }

    /// <summary>An identifier for a user pool. The user pool must be in the same region as the service that you are calling.</summary>
    [JsonPropertyName("userPool")]
    public string? UserPool { get; set; }

    /// <summary>Reference to a UserPoolDomain in cognitoidp to populate userPool.</summary>
    [JsonPropertyName("userPoolRef")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolRef? UserPoolRef { get; set; }

    /// <summary>Selector for a UserPoolDomain in cognitoidp to populate userPool.</summary>
    [JsonPropertyName("userPoolSelector")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinitionUserPoolSelector? UserPoolSelector { get; set; }
}

/// <summary>A list user groups that exist in your OIDC Identity Provider (IdP). One to ten groups can be used to create a single private work team. See Cognito Member Definition details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderMemberDefinitionOidcMemberDefinition
{
    /// <summary>A list of comma separated strings that identifies user groups in your OIDC IdP. Each user group is made up of a group of private workers.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderMemberDefinition
{
    /// <summary>The Amazon Cognito user group that is part of the work team. See Cognito Member Definition details below.</summary>
    [JsonPropertyName("cognitoMemberDefinition")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionCognitoMemberDefinition? CognitoMemberDefinition { get; set; }

    /// <summary>A list user groups that exist in your OIDC Identity Provider (IdP). One to ten groups can be used to create a single private work team. See Cognito Member Definition details below.</summary>
    [JsonPropertyName("oidcMemberDefinition")]
    public V1beta2WorkteamSpecInitProviderMemberDefinitionOidcMemberDefinition? OidcMemberDefinition { get; set; }
}

/// <summary>Configures notification of workers regarding available or expiring work items. see Notification Configuration details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderNotificationConfiguration
{
    /// <summary>The ARN for the SNS topic to which notifications should be published.</summary>
    [JsonPropertyName("notificationTopicArn")]
    public string? NotificationTopicArn { get; set; }
}

/// <summary>Use this parameter to specify the allowed request source. Possible sources are either SourceIp or VpcSourceIp. see IAM Policy Constraints details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderWorkerAccessConfigurationS3PresignIamPolicyConstraints
{
    /// <summary>When SourceIp is Enabled the worker&apos;s IP address when a task is rendered in the worker portal is added to the IAM policy as a Condition used to generate the Amazon S3 presigned URL. This IP address is checked by Amazon S3 and must match in order for the Amazon S3 resource to be rendered in the worker portal. Valid values are Enabled or Disabled</summary>
    [JsonPropertyName("sourceIp")]
    public string? SourceIp { get; set; }

    /// <summary>When VpcSourceIp is Enabled the worker&apos;s IP address when a task is rendered in private worker portal inside the VPC is added to the IAM policy as a Condition used to generate the Amazon S3 presigned URL. To render the task successfully Amazon S3 checks that the presigned URL is being accessed over an Amazon S3 VPC Endpoint, and that the worker&apos;s IP address matches the IP address in the IAM policy. To learn more about configuring private worker portal, see Use Amazon VPC mode from a private worker portal. Valid values are Enabled or Disabled</summary>
    [JsonPropertyName("vpcSourceIp")]
    public string? VpcSourceIp { get; set; }
}

/// <summary>Defines any Amazon S3 resource constraints. see S3 Presign details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderWorkerAccessConfigurationS3Presign
{
    /// <summary>Use this parameter to specify the allowed request source. Possible sources are either SourceIp or VpcSourceIp. see IAM Policy Constraints details below.</summary>
    [JsonPropertyName("iamPolicyConstraints")]
    public V1beta2WorkteamSpecInitProviderWorkerAccessConfigurationS3PresignIamPolicyConstraints? IamPolicyConstraints { get; set; }
}

/// <summary>Use this optional parameter to constrain access to an Amazon S3 resource based on the IP address using supported IAM global condition keys. The Amazon S3 resource is accessed in the worker portal using a Amazon S3 presigned URL. see Worker Access Configuration details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderWorkerAccessConfiguration
{
    /// <summary>Defines any Amazon S3 resource constraints. see S3 Presign details below.</summary>
    [JsonPropertyName("s3Presign")]
    public V1beta2WorkteamSpecInitProviderWorkerAccessConfigurationS3Presign? S3Presign { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecInitProviderWorkforceNameRefPolicyResolutionEnum>))]
public enum V1beta2WorkteamSpecInitProviderWorkforceNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecInitProviderWorkforceNameRefPolicyResolveEnum>))]
public enum V1beta2WorkteamSpecInitProviderWorkforceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderWorkforceNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkteamSpecInitProviderWorkforceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkteamSpecInitProviderWorkforceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Workforce in sagemaker to populate workforceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderWorkforceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkteamSpecInitProviderWorkforceNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecInitProviderWorkforceNameSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkteamSpecInitProviderWorkforceNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecInitProviderWorkforceNameSelectorPolicyResolveEnum>))]
public enum V1beta2WorkteamSpecInitProviderWorkforceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderWorkforceNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkteamSpecInitProviderWorkforceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkteamSpecInitProviderWorkforceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Workforce in sagemaker to populate workforceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecInitProviderWorkforceNameSelector
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
    public V1beta2WorkteamSpecInitProviderWorkforceNameSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2WorkteamSpecInitProvider
{
    /// <summary>A description of the work team.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A list of Member Definitions that contains objects that identify the workers that make up the work team. Workforces can be created using Amazon Cognito or your own OIDC Identity Provider (IdP). For private workforces created using Amazon Cognito use cognito_member_definition. For workforces created using your own OIDC identity provider (IdP) use oidc_member_definition. Do not provide input for both of these parameters in a single request. see Member Definition details below.</summary>
    [JsonPropertyName("memberDefinition")]
    public IList<V1beta2WorkteamSpecInitProviderMemberDefinition>? MemberDefinition { get; set; }

    /// <summary>Configures notification of workers regarding available or expiring work items. see Notification Configuration details below.</summary>
    [JsonPropertyName("notificationConfiguration")]
    public V1beta2WorkteamSpecInitProviderNotificationConfiguration? NotificationConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Use this optional parameter to constrain access to an Amazon S3 resource based on the IP address using supported IAM global condition keys. The Amazon S3 resource is accessed in the worker portal using a Amazon S3 presigned URL. see Worker Access Configuration details below.</summary>
    [JsonPropertyName("workerAccessConfiguration")]
    public V1beta2WorkteamSpecInitProviderWorkerAccessConfiguration? WorkerAccessConfiguration { get; set; }

    /// <summary>The name of the workforce.</summary>
    [JsonPropertyName("workforceName")]
    public string? WorkforceName { get; set; }

    /// <summary>Reference to a Workforce in sagemaker to populate workforceName.</summary>
    [JsonPropertyName("workforceNameRef")]
    public V1beta2WorkteamSpecInitProviderWorkforceNameRef? WorkforceNameRef { get; set; }

    /// <summary>Selector for a Workforce in sagemaker to populate workforceName.</summary>
    [JsonPropertyName("workforceNameSelector")]
    public V1beta2WorkteamSpecInitProviderWorkforceNameSelector? WorkforceNameSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecManagementPoliciesEnum>))]
public enum V1beta2WorkteamSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2WorkteamSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkteamSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2WorkteamSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkteamSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkteamSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkteamSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>WorkteamSpec defines the desired state of Workteam</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamSpec
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
    public V1beta2WorkteamSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2WorkteamSpecForProvider ForProvider { get; set; }

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
    public V1beta2WorkteamSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2WorkteamSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2WorkteamSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2WorkteamSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The Amazon Cognito user group that is part of the work team. See Cognito Member Definition details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamStatusAtProviderMemberDefinitionCognitoMemberDefinition
{
    /// <summary>An identifier for an application client. You must create the app client ID using Amazon Cognito.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>An identifier for a user group.</summary>
    [JsonPropertyName("userGroup")]
    public string? UserGroup { get; set; }

    /// <summary>An identifier for a user pool. The user pool must be in the same region as the service that you are calling.</summary>
    [JsonPropertyName("userPool")]
    public string? UserPool { get; set; }
}

/// <summary>A list user groups that exist in your OIDC Identity Provider (IdP). One to ten groups can be used to create a single private work team. See Cognito Member Definition details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamStatusAtProviderMemberDefinitionOidcMemberDefinition
{
    /// <summary>A list of comma separated strings that identifies user groups in your OIDC IdP. Each user group is made up of a group of private workers.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamStatusAtProviderMemberDefinition
{
    /// <summary>The Amazon Cognito user group that is part of the work team. See Cognito Member Definition details below.</summary>
    [JsonPropertyName("cognitoMemberDefinition")]
    public V1beta2WorkteamStatusAtProviderMemberDefinitionCognitoMemberDefinition? CognitoMemberDefinition { get; set; }

    /// <summary>A list user groups that exist in your OIDC Identity Provider (IdP). One to ten groups can be used to create a single private work team. See Cognito Member Definition details below.</summary>
    [JsonPropertyName("oidcMemberDefinition")]
    public V1beta2WorkteamStatusAtProviderMemberDefinitionOidcMemberDefinition? OidcMemberDefinition { get; set; }
}

/// <summary>Configures notification of workers regarding available or expiring work items. see Notification Configuration details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamStatusAtProviderNotificationConfiguration
{
    /// <summary>The ARN for the SNS topic to which notifications should be published.</summary>
    [JsonPropertyName("notificationTopicArn")]
    public string? NotificationTopicArn { get; set; }
}

/// <summary>Use this parameter to specify the allowed request source. Possible sources are either SourceIp or VpcSourceIp. see IAM Policy Constraints details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamStatusAtProviderWorkerAccessConfigurationS3PresignIamPolicyConstraints
{
    /// <summary>When SourceIp is Enabled the worker&apos;s IP address when a task is rendered in the worker portal is added to the IAM policy as a Condition used to generate the Amazon S3 presigned URL. This IP address is checked by Amazon S3 and must match in order for the Amazon S3 resource to be rendered in the worker portal. Valid values are Enabled or Disabled</summary>
    [JsonPropertyName("sourceIp")]
    public string? SourceIp { get; set; }

    /// <summary>When VpcSourceIp is Enabled the worker&apos;s IP address when a task is rendered in private worker portal inside the VPC is added to the IAM policy as a Condition used to generate the Amazon S3 presigned URL. To render the task successfully Amazon S3 checks that the presigned URL is being accessed over an Amazon S3 VPC Endpoint, and that the worker&apos;s IP address matches the IP address in the IAM policy. To learn more about configuring private worker portal, see Use Amazon VPC mode from a private worker portal. Valid values are Enabled or Disabled</summary>
    [JsonPropertyName("vpcSourceIp")]
    public string? VpcSourceIp { get; set; }
}

/// <summary>Defines any Amazon S3 resource constraints. see S3 Presign details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamStatusAtProviderWorkerAccessConfigurationS3Presign
{
    /// <summary>Use this parameter to specify the allowed request source. Possible sources are either SourceIp or VpcSourceIp. see IAM Policy Constraints details below.</summary>
    [JsonPropertyName("iamPolicyConstraints")]
    public V1beta2WorkteamStatusAtProviderWorkerAccessConfigurationS3PresignIamPolicyConstraints? IamPolicyConstraints { get; set; }
}

/// <summary>Use this optional parameter to constrain access to an Amazon S3 resource based on the IP address using supported IAM global condition keys. The Amazon S3 resource is accessed in the worker portal using a Amazon S3 presigned URL. see Worker Access Configuration details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamStatusAtProviderWorkerAccessConfiguration
{
    /// <summary>Defines any Amazon S3 resource constraints. see S3 Presign details below.</summary>
    [JsonPropertyName("s3Presign")]
    public V1beta2WorkteamStatusAtProviderWorkerAccessConfigurationS3Presign? S3Presign { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) assigned by AWS to this Workteam.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A description of the work team.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the Workteam.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of Member Definitions that contains objects that identify the workers that make up the work team. Workforces can be created using Amazon Cognito or your own OIDC Identity Provider (IdP). For private workforces created using Amazon Cognito use cognito_member_definition. For workforces created using your own OIDC identity provider (IdP) use oidc_member_definition. Do not provide input for both of these parameters in a single request. see Member Definition details below.</summary>
    [JsonPropertyName("memberDefinition")]
    public IList<V1beta2WorkteamStatusAtProviderMemberDefinition>? MemberDefinition { get; set; }

    /// <summary>Configures notification of workers regarding available or expiring work items. see Notification Configuration details below.</summary>
    [JsonPropertyName("notificationConfiguration")]
    public V1beta2WorkteamStatusAtProviderNotificationConfiguration? NotificationConfiguration { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The subdomain for your OIDC Identity Provider.</summary>
    [JsonPropertyName("subdomain")]
    public string? Subdomain { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Use this optional parameter to constrain access to an Amazon S3 resource based on the IP address using supported IAM global condition keys. The Amazon S3 resource is accessed in the worker portal using a Amazon S3 presigned URL. see Worker Access Configuration details below.</summary>
    [JsonPropertyName("workerAccessConfiguration")]
    public V1beta2WorkteamStatusAtProviderWorkerAccessConfiguration? WorkerAccessConfiguration { get; set; }

    /// <summary>The name of the workforce.</summary>
    [JsonPropertyName("workforceName")]
    public string? WorkforceName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamStatusConditions
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

/// <summary>WorkteamStatus defines the observed state of Workteam.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkteamStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2WorkteamStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2WorkteamStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Workteam is the Schema for the Workteams API. Provides a SageMaker AI Workteam resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Workteam : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2WorkteamSpec>, IStatus<V1beta2WorkteamStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Workteam";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "workteams";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Workteam";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkteamSpec defines the desired state of Workteam</summary>
    [JsonPropertyName("spec")]
    public required V1beta2WorkteamSpec Spec { get; set; }

    /// <summary>WorkteamStatus defines the observed state of Workteam.</summary>
    [JsonPropertyName("status")]
    public V1beta2WorkteamStatus? Status { get; set; }
}
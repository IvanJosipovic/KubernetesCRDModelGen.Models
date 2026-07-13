#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elbv2.aws.upbound.io;
/// <summary>LBListenerRule is the Schema for the LBListenerRules API. Provides a Load Balancer Listener Rule resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2LBListenerRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta2LBListenerRule>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "LBListenerRuleList";
    public const string KubeGroup = "elbv2.aws.upbound.io";
    public const string KubePluralName = "lblistenerrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elbv2.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LBListenerRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2LBListenerRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2LBListenerRule> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecDeletionPolicyEnum>))]
public enum V1beta2LBListenerRuleSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnRefPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a UserPool in cognitoidp to populate userPoolArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnSelectorPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a UserPool in cognitoidp to populate userPoolArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnSelector
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
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdRefPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a UserPoolClient in cognitoidp to populate userPoolClientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a UserPoolClient in cognitoidp to populate userPoolClientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdSelector
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
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainRefPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a UserPoolDomain in cognitoidp to populate userPoolDomain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a UserPoolDomain in cognitoidp to populate userPoolDomain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainSelector
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
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicy? Policy { get; set; }
}

/// <summary>Information for creating an authenticate action using Cognito. Required if type is authenticate-cognito.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognito
{
    /// <summary>The query parameters to include in the redirect request to the authorization endpoint. Max: 10.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>The behavior if the user is not authenticated. Valid values: deny, allow and authenticate</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>The set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>The name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>The maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>The ARN of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolArn")]
    public string? UserPoolArn { get; set; }

    /// <summary>Reference to a UserPool in cognitoidp to populate userPoolArn.</summary>
    [JsonPropertyName("userPoolArnRef")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnRef? UserPoolArnRef { get; set; }

    /// <summary>Selector for a UserPool in cognitoidp to populate userPoolArn.</summary>
    [JsonPropertyName("userPoolArnSelector")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolArnSelector? UserPoolArnSelector { get; set; }

    /// <summary>The ID of the Cognito user pool client.</summary>
    [JsonPropertyName("userPoolClientId")]
    public string? UserPoolClientId { get; set; }

    /// <summary>Reference to a UserPoolClient in cognitoidp to populate userPoolClientId.</summary>
    [JsonPropertyName("userPoolClientIdRef")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdRef? UserPoolClientIdRef { get; set; }

    /// <summary>Selector for a UserPoolClient in cognitoidp to populate userPoolClientId.</summary>
    [JsonPropertyName("userPoolClientIdSelector")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolClientIdSelector? UserPoolClientIdSelector { get; set; }

    /// <summary>The domain prefix or fully-qualified domain name of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolDomain")]
    public string? UserPoolDomain { get; set; }

    /// <summary>Reference to a UserPoolDomain in cognitoidp to populate userPoolDomain.</summary>
    [JsonPropertyName("userPoolDomainRef")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainRef? UserPoolDomainRef { get; set; }

    /// <summary>Selector for a UserPoolDomain in cognitoidp to populate userPoolDomain.</summary>
    [JsonPropertyName("userPoolDomainSelector")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognitoUserPoolDomainSelector? UserPoolDomainSelector { get; set; }
}

/// <summary>The OAuth 2.0 client secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionAuthenticateOidcClientSecretSecretRef
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

/// <summary>Information for creating an authenticate action using OIDC. Required if type is authenticate-oidc.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionAuthenticateOidc
{
    /// <summary>The query parameters to include in the redirect request to the authorization endpoint. Max: 10.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>The authorization endpoint of the IdP.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>The OAuth 2.0 client identifier.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateOidcClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Issuer of the JWT.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The behavior if the user is not authenticated. Valid values: deny, allow and authenticate</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>The set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>The name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>The maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>The token endpoint of the IdP.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>The user info endpoint of the IdP.</summary>
    [JsonPropertyName("userInfoEndpoint")]
    public string? UserInfoEndpoint { get; set; }
}

/// <summary>Information for creating an action that returns a custom HTTP response. Required if type is fixed-response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionFixedResponse
{
    /// <summary>The content type. Valid values are text/plain, text/css, text/html, application/javascript and application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>The message body.</summary>
    [JsonPropertyName("messageBody")]
    public string? MessageBody { get; set; }

    /// <summary>The HTTP redirect code. The redirect is either permanent (HTTP_301) or temporary (HTTP_302).</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>The target group stickiness for the rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionForwardStickiness
{
    /// <summary>The time period, in seconds, during which requests from a client should be routed to the same target group. The range is 1-604800 seconds (7 days).</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Indicates whether target group stickiness is enabled.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnRefPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LBTargetGroup in elbv2 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnSelectorPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LBTargetGroup in elbv2 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnSelector
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
    public V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroup
{
    /// <summary>The Amazon Resource Name (ARN) of the target group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnRef? ArnRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroupArnSelector? ArnSelector { get; set; }

    /// <summary>The weight. The range is 0 to 999.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// Configuration block for creating an action that distributes requests among one or more target groups.
/// Specify only if type is forward.
/// Cannot be specified with target_group_arn.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionForward
{
    /// <summary>The target group stickiness for the rule.</summary>
    [JsonPropertyName("stickiness")]
    public V1beta2LBListenerRuleSpecForProviderActionForwardStickiness? Stickiness { get; set; }

    /// <summary>One or more target group blocks.</summary>
    [JsonPropertyName("targetGroup")]
    public IList<V1beta2LBListenerRuleSpecForProviderActionForwardTargetGroup>? TargetGroup { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionJwtValidationAdditionalClaim
{
    /// <summary>Format of the claim value. Valid values are single-string, string-array and space-separated-values.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Name of the claim to validate. exp, iss, nbf, or iat cannot be specified because they are validated by default.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal &apos;*&apos; or &apos;?&apos; character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Information for creating a JWT validation action. Required if type is jwt-validation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionJwtValidation
{
    /// <summary>Repeatable configuration block for additional claims to validate.</summary>
    [JsonPropertyName("additionalClaim")]
    public IList<V1beta2LBListenerRuleSpecForProviderActionJwtValidationAdditionalClaim>? AdditionalClaim { get; set; }

    /// <summary>Issuer of the JWT.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>JSON Web Key Set (JWKS) endpoint. This endpoint contains JSON Web Keys (JWK) that are used to validate signatures from the provider. This must be a full URL, including the HTTPS protocol, the domain, and the path.</summary>
    [JsonPropertyName("jwksEndpoint")]
    public string? JwksEndpoint { get; set; }
}

/// <summary>Information for creating a redirect action. Required if type is redirect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionRedirect
{
    /// <summary>The hostname. This component is not percent-encoded. The hostname can contain #{host}. Defaults to #{host}.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The absolute path, starting with the leading &quot;/&quot;. This component is not percent-encoded. The path can contain #{host}, #{path}, and #{port}. Defaults to /#{path}.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port. Specify a value from 1 to 65535 or #{port}. Defaults to #{port}.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>The protocol. Valid values are HTTP, HTTPS, or #{protocol}. Defaults to #{protocol}.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The query parameters, URL-encoded when necessary, but not percent-encoded. Do not include the leading &quot;?&quot;. Defaults to #{query}.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>The HTTP redirect code. The redirect is either permanent (HTTP_301) or temporary (HTTP_302).</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnRefPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnSelectorPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnSelector
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
    public V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderAction
{
    /// <summary>Information for creating an authenticate action using Cognito. Required if type is authenticate-cognito.</summary>
    [JsonPropertyName("authenticateCognito")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateCognito? AuthenticateCognito { get; set; }

    /// <summary>Information for creating an authenticate action using OIDC. Required if type is authenticate-oidc.</summary>
    [JsonPropertyName("authenticateOidc")]
    public V1beta2LBListenerRuleSpecForProviderActionAuthenticateOidc? AuthenticateOidc { get; set; }

    /// <summary>Information for creating an action that returns a custom HTTP response. Required if type is fixed-response.</summary>
    [JsonPropertyName("fixedResponse")]
    public V1beta2LBListenerRuleSpecForProviderActionFixedResponse? FixedResponse { get; set; }

    /// <summary>
    /// Configuration block for creating an action that distributes requests among one or more target groups.
    /// Specify only if type is forward.
    /// Cannot be specified with target_group_arn.
    /// </summary>
    [JsonPropertyName("forward")]
    public V1beta2LBListenerRuleSpecForProviderActionForward? Forward { get; set; }

    /// <summary>Information for creating a JWT validation action. Required if type is jwt-validation.</summary>
    [JsonPropertyName("jwtValidation")]
    public V1beta2LBListenerRuleSpecForProviderActionJwtValidation? JwtValidation { get; set; }

    /// <summary>
    /// Order for the action.
    /// The action with the lowest value for order is performed first.
    /// Valid values are between 1 and 50000.
    /// Defaults to the position in the list of actions.
    /// </summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Information for creating a redirect action. Required if type is redirect.</summary>
    [JsonPropertyName("redirect")]
    public V1beta2LBListenerRuleSpecForProviderActionRedirect? Redirect { get; set; }

    /// <summary>
    /// ARN of the Target Group to which to route traffic.
    /// Specify only if type is forward and you want to route to a single target group.
    /// To route to one or more target groups, use a forward block instead.
    /// Cannot be specified with forward.
    /// </summary>
    [JsonPropertyName("targetGroupArn")]
    public string? TargetGroupArn { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnRef")]
    public V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnRef? TargetGroupArnRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnSelector")]
    public V1beta2LBListenerRuleSpecForProviderActionTargetGroupArnSelector? TargetGroupArnSelector { get; set; }

    /// <summary>The type of routing action. Valid values are forward, redirect, fixed-response, authenticate-cognito, authenticate-oidc and jwt-validation.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Host header patterns to match. Host Header block fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderConditionHostHeader
{
    /// <summary>List of regular expressions to compare against the host header. The maximum length of each string is 128 characters. Conflicts with values.</summary>
    [JsonPropertyName("regexValues")]
    public IList<string>? RegexValues { get; set; }

    /// <summary>List of host header value patterns to match. Maximum size of each pattern is 128 characters. Comparison is case-insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). Only one pattern needs to match for the condition to be satisfied. Conflicts with regex_values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>HTTP headers to match. HTTP Header block fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderConditionHttpHeader
{
    /// <summary>Name of HTTP header to search. The maximum size is 40 characters. Comparison is case-insensitive. Only RFC7240 characters are supported. Wildcards are not supported. You cannot use HTTP header condition to specify the host header, use a host-header condition instead.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>List of regular expressions to compare against the request URL. The maximum length of each string is 128 characters. Conflicts with values.</summary>
    [JsonPropertyName("regexValues")]
    public IList<string>? RegexValues { get; set; }

    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal &apos;*&apos; or &apos;?&apos; character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Contains a single values item which is a list of HTTP request methods or verbs to match. Maximum size is 40 characters. Only allowed characters are A-Z, hyphen (-) and underscore (_). Comparison is case sensitive. Wildcards are not supported. Only one needs to match for the condition to be satisfied. AWS recommends that GET and HEAD requests are routed in the same way because the response to a HEAD request may be cached.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderConditionHttpRequestMethod
{
    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal &apos;*&apos; or &apos;?&apos; character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Path patterns to match against the request URL. Path Pattern block fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderConditionPathPattern
{
    /// <summary>List of regular expressions to compare against the request URL. The maximum length of each string is 128 characters. Conflicts with values.</summary>
    [JsonPropertyName("regexValues")]
    public IList<string>? RegexValues { get; set; }

    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal &apos;*&apos; or &apos;?&apos; character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderConditionQueryString
{
    /// <summary>Query string key pattern to match.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Query string value pattern to match.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Contains a single values item which is a list of source IP CIDR notations to match. You can use both IPv4 and IPv6 addresses. Wildcards are not supported. Condition is satisfied if the source IP address of the request matches one of the CIDR blocks. Condition is not satisfied by the addresses in the X-Forwarded-For header, use http_header condition instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderConditionSourceIp
{
    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal &apos;*&apos; or &apos;?&apos; character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderCondition
{
    /// <summary>Host header patterns to match. Host Header block fields documented below.</summary>
    [JsonPropertyName("hostHeader")]
    public V1beta2LBListenerRuleSpecForProviderConditionHostHeader? HostHeader { get; set; }

    /// <summary>HTTP headers to match. HTTP Header block fields documented below.</summary>
    [JsonPropertyName("httpHeader")]
    public V1beta2LBListenerRuleSpecForProviderConditionHttpHeader? HttpHeader { get; set; }

    /// <summary>Contains a single values item which is a list of HTTP request methods or verbs to match. Maximum size is 40 characters. Only allowed characters are A-Z, hyphen (-) and underscore (_). Comparison is case sensitive. Wildcards are not supported. Only one needs to match for the condition to be satisfied. AWS recommends that GET and HEAD requests are routed in the same way because the response to a HEAD request may be cached.</summary>
    [JsonPropertyName("httpRequestMethod")]
    public V1beta2LBListenerRuleSpecForProviderConditionHttpRequestMethod? HttpRequestMethod { get; set; }

    /// <summary>Path patterns to match against the request URL. Path Pattern block fields documented below.</summary>
    [JsonPropertyName("pathPattern")]
    public V1beta2LBListenerRuleSpecForProviderConditionPathPattern? PathPattern { get; set; }

    /// <summary>Query strings to match. Query String block fields documented below.</summary>
    [JsonPropertyName("queryString")]
    public IList<V1beta2LBListenerRuleSpecForProviderConditionQueryString>? QueryString { get; set; }

    /// <summary>Contains a single values item which is a list of source IP CIDR notations to match. You can use both IPv4 and IPv6 addresses. Wildcards are not supported. Condition is satisfied if the source IP address of the request matches one of the CIDR blocks. Condition is not satisfied by the addresses in the X-Forwarded-For header, use http_header condition instead.</summary>
    [JsonPropertyName("sourceIp")]
    public V1beta2LBListenerRuleSpecForProviderConditionSourceIp? SourceIp { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderListenerArnRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderListenerArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderListenerArnRefPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderListenerArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderListenerArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecForProviderListenerArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecForProviderListenerArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LBListener in elbv2 to populate listenerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderListenerArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerRuleSpecForProviderListenerArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderListenerArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderListenerArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecForProviderListenerArnSelectorPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecForProviderListenerArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderListenerArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecForProviderListenerArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecForProviderListenerArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LBListener in elbv2 to populate listenerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderListenerArnSelector
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
    public V1beta2LBListenerRuleSpecForProviderListenerArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Block for host header rewrite configuration. Only one block is accepted. See Rewrite Blocks below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderTransformHostHeaderRewriteConfigRewrite
{
    /// <summary>Regular expression to match in the input string. Length constraints: Between 1 and 1024 characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Replacement string to use when rewriting the matched input. Capture groups in the regular expression (for example, $1 and $2) can be specified. Length constraints: Between 0 and 1024 characters.</summary>
    [JsonPropertyName("replace")]
    public string? Replace { get; set; }
}

/// <summary>Configuration block for host header rewrite. Required if type is host-header-rewrite. See Host Header Rewrite Config Blocks below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderTransformHostHeaderRewriteConfig
{
    /// <summary>Block for host header rewrite configuration. Only one block is accepted. See Rewrite Blocks below.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta2LBListenerRuleSpecForProviderTransformHostHeaderRewriteConfigRewrite? Rewrite { get; set; }
}

/// <summary>Block for URL rewrite configuration. Only one block is accepted. See Rewrite Blocks below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderTransformUrlRewriteConfigRewrite
{
    /// <summary>Regular expression to match in the input string. Length constraints: Between 1 and 1024 characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Replacement string to use when rewriting the matched input. Capture groups in the regular expression (for example, $1 and $2) can be specified. Length constraints: Between 0 and 1024 characters.</summary>
    [JsonPropertyName("replace")]
    public string? Replace { get; set; }
}

/// <summary>Configuration block for URL rewrite. Required if type is url-rewrite. See URL Rewrite Config Blocks below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderTransformUrlRewriteConfig
{
    /// <summary>Block for URL rewrite configuration. Only one block is accepted. See Rewrite Blocks below.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta2LBListenerRuleSpecForProviderTransformUrlRewriteConfigRewrite? Rewrite { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProviderTransform
{
    /// <summary>Configuration block for host header rewrite. Required if type is host-header-rewrite. See Host Header Rewrite Config Blocks below.</summary>
    [JsonPropertyName("hostHeaderRewriteConfig")]
    public V1beta2LBListenerRuleSpecForProviderTransformHostHeaderRewriteConfig? HostHeaderRewriteConfig { get; set; }

    /// <summary>Type of transform. Valid values are host-header-rewrite and url-rewrite.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Configuration block for URL rewrite. Required if type is url-rewrite. See URL Rewrite Config Blocks below.</summary>
    [JsonPropertyName("urlRewriteConfig")]
    public V1beta2LBListenerRuleSpecForProviderTransformUrlRewriteConfig? UrlRewriteConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecForProvider
{
    /// <summary>An Action block. Action blocks are documented below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta2LBListenerRuleSpecForProviderAction>? Action { get; set; }

    /// <summary>A Condition block. Multiple condition blocks of different types can be set and all must be satisfied for the rule to match. Condition blocks are documented below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta2LBListenerRuleSpecForProviderCondition>? Condition { get; set; }

    /// <summary>The ARN of the listener to which to attach the rule.</summary>
    [JsonPropertyName("listenerArn")]
    public string? ListenerArn { get; set; }

    /// <summary>Reference to a LBListener in elbv2 to populate listenerArn.</summary>
    [JsonPropertyName("listenerArnRef")]
    public V1beta2LBListenerRuleSpecForProviderListenerArnRef? ListenerArnRef { get; set; }

    /// <summary>Selector for a LBListener in elbv2 to populate listenerArn.</summary>
    [JsonPropertyName("listenerArnSelector")]
    public V1beta2LBListenerRuleSpecForProviderListenerArnSelector? ListenerArnSelector { get; set; }

    /// <summary>The priority for the rule between 1 and 50000. Leaving it unset will automatically set the rule with next available priority after currently existing highest rule. A listener can&apos;t have multiple rules with the same priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block that defines the transform to apply to requests matching this rule. See Transform Blocks below for more details. Once specified, to remove the transform from the rule, remove the transform block from the configuration.</summary>
    [JsonPropertyName("transform")]
    public IList<V1beta2LBListenerRuleSpecForProviderTransform>? Transform { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnRefPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a UserPool in cognitoidp to populate userPoolArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnSelectorPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a UserPool in cognitoidp to populate userPoolArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnSelector
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
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdRefPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a UserPoolClient in cognitoidp to populate userPoolClientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a UserPoolClient in cognitoidp to populate userPoolClientId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdSelector
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
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainRefPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a UserPoolDomain in cognitoidp to populate userPoolDomain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a UserPoolDomain in cognitoidp to populate userPoolDomain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainSelector
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
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainSelectorPolicy? Policy { get; set; }
}

/// <summary>Information for creating an authenticate action using Cognito. Required if type is authenticate-cognito.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognito
{
    /// <summary>The query parameters to include in the redirect request to the authorization endpoint. Max: 10.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>The behavior if the user is not authenticated. Valid values: deny, allow and authenticate</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>The set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>The name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>The maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>The ARN of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolArn")]
    public string? UserPoolArn { get; set; }

    /// <summary>Reference to a UserPool in cognitoidp to populate userPoolArn.</summary>
    [JsonPropertyName("userPoolArnRef")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnRef? UserPoolArnRef { get; set; }

    /// <summary>Selector for a UserPool in cognitoidp to populate userPoolArn.</summary>
    [JsonPropertyName("userPoolArnSelector")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolArnSelector? UserPoolArnSelector { get; set; }

    /// <summary>The ID of the Cognito user pool client.</summary>
    [JsonPropertyName("userPoolClientId")]
    public string? UserPoolClientId { get; set; }

    /// <summary>Reference to a UserPoolClient in cognitoidp to populate userPoolClientId.</summary>
    [JsonPropertyName("userPoolClientIdRef")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdRef? UserPoolClientIdRef { get; set; }

    /// <summary>Selector for a UserPoolClient in cognitoidp to populate userPoolClientId.</summary>
    [JsonPropertyName("userPoolClientIdSelector")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolClientIdSelector? UserPoolClientIdSelector { get; set; }

    /// <summary>The domain prefix or fully-qualified domain name of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolDomain")]
    public string? UserPoolDomain { get; set; }

    /// <summary>Reference to a UserPoolDomain in cognitoidp to populate userPoolDomain.</summary>
    [JsonPropertyName("userPoolDomainRef")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainRef? UserPoolDomainRef { get; set; }

    /// <summary>Selector for a UserPoolDomain in cognitoidp to populate userPoolDomain.</summary>
    [JsonPropertyName("userPoolDomainSelector")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognitoUserPoolDomainSelector? UserPoolDomainSelector { get; set; }
}

/// <summary>The OAuth 2.0 client secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionAuthenticateOidcClientSecretSecretRef
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

/// <summary>Information for creating an authenticate action using OIDC. Required if type is authenticate-oidc.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionAuthenticateOidc
{
    /// <summary>The query parameters to include in the redirect request to the authorization endpoint. Max: 10.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>The authorization endpoint of the IdP.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>The OAuth 2.0 client identifier.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public required V1beta2LBListenerRuleSpecInitProviderActionAuthenticateOidcClientSecretSecretRef ClientSecretSecretRef { get; set; }

    /// <summary>Issuer of the JWT.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The behavior if the user is not authenticated. Valid values: deny, allow and authenticate</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>The set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>The name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>The maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>The token endpoint of the IdP.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>The user info endpoint of the IdP.</summary>
    [JsonPropertyName("userInfoEndpoint")]
    public string? UserInfoEndpoint { get; set; }
}

/// <summary>Information for creating an action that returns a custom HTTP response. Required if type is fixed-response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionFixedResponse
{
    /// <summary>The content type. Valid values are text/plain, text/css, text/html, application/javascript and application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>The message body.</summary>
    [JsonPropertyName("messageBody")]
    public string? MessageBody { get; set; }

    /// <summary>The HTTP redirect code. The redirect is either permanent (HTTP_301) or temporary (HTTP_302).</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>The target group stickiness for the rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionForwardStickiness
{
    /// <summary>The time period, in seconds, during which requests from a client should be routed to the same target group. The range is 1-604800 seconds (7 days).</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Indicates whether target group stickiness is enabled.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnRefPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LBTargetGroup in elbv2 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnSelectorPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LBTargetGroup in elbv2 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnSelector
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
    public V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroup
{
    /// <summary>The Amazon Resource Name (ARN) of the target group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnRef? ArnRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroupArnSelector? ArnSelector { get; set; }

    /// <summary>The weight. The range is 0 to 999.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// Configuration block for creating an action that distributes requests among one or more target groups.
/// Specify only if type is forward.
/// Cannot be specified with target_group_arn.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionForward
{
    /// <summary>The target group stickiness for the rule.</summary>
    [JsonPropertyName("stickiness")]
    public V1beta2LBListenerRuleSpecInitProviderActionForwardStickiness? Stickiness { get; set; }

    /// <summary>One or more target group blocks.</summary>
    [JsonPropertyName("targetGroup")]
    public IList<V1beta2LBListenerRuleSpecInitProviderActionForwardTargetGroup>? TargetGroup { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionJwtValidationAdditionalClaim
{
    /// <summary>Format of the claim value. Valid values are single-string, string-array and space-separated-values.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Name of the claim to validate. exp, iss, nbf, or iat cannot be specified because they are validated by default.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal &apos;*&apos; or &apos;?&apos; character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Information for creating a JWT validation action. Required if type is jwt-validation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionJwtValidation
{
    /// <summary>Repeatable configuration block for additional claims to validate.</summary>
    [JsonPropertyName("additionalClaim")]
    public IList<V1beta2LBListenerRuleSpecInitProviderActionJwtValidationAdditionalClaim>? AdditionalClaim { get; set; }

    /// <summary>Issuer of the JWT.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>JSON Web Key Set (JWKS) endpoint. This endpoint contains JSON Web Keys (JWK) that are used to validate signatures from the provider. This must be a full URL, including the HTTPS protocol, the domain, and the path.</summary>
    [JsonPropertyName("jwksEndpoint")]
    public string? JwksEndpoint { get; set; }
}

/// <summary>Information for creating a redirect action. Required if type is redirect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionRedirect
{
    /// <summary>The hostname. This component is not percent-encoded. The hostname can contain #{host}. Defaults to #{host}.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The absolute path, starting with the leading &quot;/&quot;. This component is not percent-encoded. The path can contain #{host}, #{path}, and #{port}. Defaults to /#{path}.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port. Specify a value from 1 to 65535 or #{port}. Defaults to #{port}.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>The protocol. Valid values are HTTP, HTTPS, or #{protocol}. Defaults to #{protocol}.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The query parameters, URL-encoded when necessary, but not percent-encoded. Do not include the leading &quot;?&quot;. Defaults to #{query}.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>The HTTP redirect code. The redirect is either permanent (HTTP_301) or temporary (HTTP_302).</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnRefPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnSelectorPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnSelector
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
    public V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderAction
{
    /// <summary>Information for creating an authenticate action using Cognito. Required if type is authenticate-cognito.</summary>
    [JsonPropertyName("authenticateCognito")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateCognito? AuthenticateCognito { get; set; }

    /// <summary>Information for creating an authenticate action using OIDC. Required if type is authenticate-oidc.</summary>
    [JsonPropertyName("authenticateOidc")]
    public V1beta2LBListenerRuleSpecInitProviderActionAuthenticateOidc? AuthenticateOidc { get; set; }

    /// <summary>Information for creating an action that returns a custom HTTP response. Required if type is fixed-response.</summary>
    [JsonPropertyName("fixedResponse")]
    public V1beta2LBListenerRuleSpecInitProviderActionFixedResponse? FixedResponse { get; set; }

    /// <summary>
    /// Configuration block for creating an action that distributes requests among one or more target groups.
    /// Specify only if type is forward.
    /// Cannot be specified with target_group_arn.
    /// </summary>
    [JsonPropertyName("forward")]
    public V1beta2LBListenerRuleSpecInitProviderActionForward? Forward { get; set; }

    /// <summary>Information for creating a JWT validation action. Required if type is jwt-validation.</summary>
    [JsonPropertyName("jwtValidation")]
    public V1beta2LBListenerRuleSpecInitProviderActionJwtValidation? JwtValidation { get; set; }

    /// <summary>
    /// Order for the action.
    /// The action with the lowest value for order is performed first.
    /// Valid values are between 1 and 50000.
    /// Defaults to the position in the list of actions.
    /// </summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Information for creating a redirect action. Required if type is redirect.</summary>
    [JsonPropertyName("redirect")]
    public V1beta2LBListenerRuleSpecInitProviderActionRedirect? Redirect { get; set; }

    /// <summary>
    /// ARN of the Target Group to which to route traffic.
    /// Specify only if type is forward and you want to route to a single target group.
    /// To route to one or more target groups, use a forward block instead.
    /// Cannot be specified with forward.
    /// </summary>
    [JsonPropertyName("targetGroupArn")]
    public string? TargetGroupArn { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnRef")]
    public V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnRef? TargetGroupArnRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnSelector")]
    public V1beta2LBListenerRuleSpecInitProviderActionTargetGroupArnSelector? TargetGroupArnSelector { get; set; }

    /// <summary>The type of routing action. Valid values are forward, redirect, fixed-response, authenticate-cognito, authenticate-oidc and jwt-validation.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Host header patterns to match. Host Header block fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderConditionHostHeader
{
    /// <summary>List of regular expressions to compare against the host header. The maximum length of each string is 128 characters. Conflicts with values.</summary>
    [JsonPropertyName("regexValues")]
    public IList<string>? RegexValues { get; set; }

    /// <summary>List of host header value patterns to match. Maximum size of each pattern is 128 characters. Comparison is case-insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). Only one pattern needs to match for the condition to be satisfied. Conflicts with regex_values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>HTTP headers to match. HTTP Header block fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderConditionHttpHeader
{
    /// <summary>Name of HTTP header to search. The maximum size is 40 characters. Comparison is case-insensitive. Only RFC7240 characters are supported. Wildcards are not supported. You cannot use HTTP header condition to specify the host header, use a host-header condition instead.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>List of regular expressions to compare against the request URL. The maximum length of each string is 128 characters. Conflicts with values.</summary>
    [JsonPropertyName("regexValues")]
    public IList<string>? RegexValues { get; set; }

    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal &apos;*&apos; or &apos;?&apos; character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Contains a single values item which is a list of HTTP request methods or verbs to match. Maximum size is 40 characters. Only allowed characters are A-Z, hyphen (-) and underscore (_). Comparison is case sensitive. Wildcards are not supported. Only one needs to match for the condition to be satisfied. AWS recommends that GET and HEAD requests are routed in the same way because the response to a HEAD request may be cached.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderConditionHttpRequestMethod
{
    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal &apos;*&apos; or &apos;?&apos; character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Path patterns to match against the request URL. Path Pattern block fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderConditionPathPattern
{
    /// <summary>List of regular expressions to compare against the request URL. The maximum length of each string is 128 characters. Conflicts with values.</summary>
    [JsonPropertyName("regexValues")]
    public IList<string>? RegexValues { get; set; }

    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal &apos;*&apos; or &apos;?&apos; character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderConditionQueryString
{
    /// <summary>Query string key pattern to match.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Query string value pattern to match.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Contains a single values item which is a list of source IP CIDR notations to match. You can use both IPv4 and IPv6 addresses. Wildcards are not supported. Condition is satisfied if the source IP address of the request matches one of the CIDR blocks. Condition is not satisfied by the addresses in the X-Forwarded-For header, use http_header condition instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderConditionSourceIp
{
    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal &apos;*&apos; or &apos;?&apos; character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderCondition
{
    /// <summary>Host header patterns to match. Host Header block fields documented below.</summary>
    [JsonPropertyName("hostHeader")]
    public V1beta2LBListenerRuleSpecInitProviderConditionHostHeader? HostHeader { get; set; }

    /// <summary>HTTP headers to match. HTTP Header block fields documented below.</summary>
    [JsonPropertyName("httpHeader")]
    public V1beta2LBListenerRuleSpecInitProviderConditionHttpHeader? HttpHeader { get; set; }

    /// <summary>Contains a single values item which is a list of HTTP request methods or verbs to match. Maximum size is 40 characters. Only allowed characters are A-Z, hyphen (-) and underscore (_). Comparison is case sensitive. Wildcards are not supported. Only one needs to match for the condition to be satisfied. AWS recommends that GET and HEAD requests are routed in the same way because the response to a HEAD request may be cached.</summary>
    [JsonPropertyName("httpRequestMethod")]
    public V1beta2LBListenerRuleSpecInitProviderConditionHttpRequestMethod? HttpRequestMethod { get; set; }

    /// <summary>Path patterns to match against the request URL. Path Pattern block fields documented below.</summary>
    [JsonPropertyName("pathPattern")]
    public V1beta2LBListenerRuleSpecInitProviderConditionPathPattern? PathPattern { get; set; }

    /// <summary>Query strings to match. Query String block fields documented below.</summary>
    [JsonPropertyName("queryString")]
    public IList<V1beta2LBListenerRuleSpecInitProviderConditionQueryString>? QueryString { get; set; }

    /// <summary>Contains a single values item which is a list of source IP CIDR notations to match. You can use both IPv4 and IPv6 addresses. Wildcards are not supported. Condition is satisfied if the source IP address of the request matches one of the CIDR blocks. Condition is not satisfied by the addresses in the X-Forwarded-For header, use http_header condition instead.</summary>
    [JsonPropertyName("sourceIp")]
    public V1beta2LBListenerRuleSpecInitProviderConditionSourceIp? SourceIp { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderListenerArnRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderListenerArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderListenerArnRefPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderListenerArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderListenerArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecInitProviderListenerArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecInitProviderListenerArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LBListener in elbv2 to populate listenerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderListenerArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerRuleSpecInitProviderListenerArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderListenerArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderListenerArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecInitProviderListenerArnSelectorPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecInitProviderListenerArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderListenerArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecInitProviderListenerArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecInitProviderListenerArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LBListener in elbv2 to populate listenerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderListenerArnSelector
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
    public V1beta2LBListenerRuleSpecInitProviderListenerArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Block for host header rewrite configuration. Only one block is accepted. See Rewrite Blocks below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderTransformHostHeaderRewriteConfigRewrite
{
    /// <summary>Regular expression to match in the input string. Length constraints: Between 1 and 1024 characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Replacement string to use when rewriting the matched input. Capture groups in the regular expression (for example, $1 and $2) can be specified. Length constraints: Between 0 and 1024 characters.</summary>
    [JsonPropertyName("replace")]
    public string? Replace { get; set; }
}

/// <summary>Configuration block for host header rewrite. Required if type is host-header-rewrite. See Host Header Rewrite Config Blocks below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderTransformHostHeaderRewriteConfig
{
    /// <summary>Block for host header rewrite configuration. Only one block is accepted. See Rewrite Blocks below.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta2LBListenerRuleSpecInitProviderTransformHostHeaderRewriteConfigRewrite? Rewrite { get; set; }
}

/// <summary>Block for URL rewrite configuration. Only one block is accepted. See Rewrite Blocks below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderTransformUrlRewriteConfigRewrite
{
    /// <summary>Regular expression to match in the input string. Length constraints: Between 1 and 1024 characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Replacement string to use when rewriting the matched input. Capture groups in the regular expression (for example, $1 and $2) can be specified. Length constraints: Between 0 and 1024 characters.</summary>
    [JsonPropertyName("replace")]
    public string? Replace { get; set; }
}

/// <summary>Configuration block for URL rewrite. Required if type is url-rewrite. See URL Rewrite Config Blocks below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderTransformUrlRewriteConfig
{
    /// <summary>Block for URL rewrite configuration. Only one block is accepted. See Rewrite Blocks below.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta2LBListenerRuleSpecInitProviderTransformUrlRewriteConfigRewrite? Rewrite { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecInitProviderTransform
{
    /// <summary>Configuration block for host header rewrite. Required if type is host-header-rewrite. See Host Header Rewrite Config Blocks below.</summary>
    [JsonPropertyName("hostHeaderRewriteConfig")]
    public V1beta2LBListenerRuleSpecInitProviderTransformHostHeaderRewriteConfig? HostHeaderRewriteConfig { get; set; }

    /// <summary>Type of transform. Valid values are host-header-rewrite and url-rewrite.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Configuration block for URL rewrite. Required if type is url-rewrite. See URL Rewrite Config Blocks below.</summary>
    [JsonPropertyName("urlRewriteConfig")]
    public V1beta2LBListenerRuleSpecInitProviderTransformUrlRewriteConfig? UrlRewriteConfig { get; set; }
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
public partial class V1beta2LBListenerRuleSpecInitProvider
{
    /// <summary>An Action block. Action blocks are documented below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta2LBListenerRuleSpecInitProviderAction>? Action { get; set; }

    /// <summary>A Condition block. Multiple condition blocks of different types can be set and all must be satisfied for the rule to match. Condition blocks are documented below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta2LBListenerRuleSpecInitProviderCondition>? Condition { get; set; }

    /// <summary>The ARN of the listener to which to attach the rule.</summary>
    [JsonPropertyName("listenerArn")]
    public string? ListenerArn { get; set; }

    /// <summary>Reference to a LBListener in elbv2 to populate listenerArn.</summary>
    [JsonPropertyName("listenerArnRef")]
    public V1beta2LBListenerRuleSpecInitProviderListenerArnRef? ListenerArnRef { get; set; }

    /// <summary>Selector for a LBListener in elbv2 to populate listenerArn.</summary>
    [JsonPropertyName("listenerArnSelector")]
    public V1beta2LBListenerRuleSpecInitProviderListenerArnSelector? ListenerArnSelector { get; set; }

    /// <summary>The priority for the rule between 1 and 50000. Leaving it unset will automatically set the rule with next available priority after currently existing highest rule. A listener can&apos;t have multiple rules with the same priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block that defines the transform to apply to requests matching this rule. See Transform Blocks below for more details. Once specified, to remove the transform from the rule, remove the transform block from the configuration.</summary>
    [JsonPropertyName("transform")]
    public IList<V1beta2LBListenerRuleSpecInitProviderTransform>? Transform { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecManagementPoliciesEnum>))]
public enum V1beta2LBListenerRuleSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2LBListenerRuleSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LBListenerRuleSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2LBListenerRuleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LBListenerRuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LBListenerRuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LBListenerRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>LBListenerRuleSpec defines the desired state of LBListenerRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleSpec
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
    public V1beta2LBListenerRuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2LBListenerRuleSpecForProvider ForProvider { get; set; }

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
    public V1beta2LBListenerRuleSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2LBListenerRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2LBListenerRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2LBListenerRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Information for creating an authenticate action using Cognito. Required if type is authenticate-cognito.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderActionAuthenticateCognito
{
    /// <summary>The query parameters to include in the redirect request to the authorization endpoint. Max: 10.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>The behavior if the user is not authenticated. Valid values: deny, allow and authenticate</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>The set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>The name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>The maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>The ARN of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolArn")]
    public string? UserPoolArn { get; set; }

    /// <summary>The ID of the Cognito user pool client.</summary>
    [JsonPropertyName("userPoolClientId")]
    public string? UserPoolClientId { get; set; }

    /// <summary>The domain prefix or fully-qualified domain name of the Cognito user pool.</summary>
    [JsonPropertyName("userPoolDomain")]
    public string? UserPoolDomain { get; set; }
}

/// <summary>Information for creating an authenticate action using OIDC. Required if type is authenticate-oidc.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderActionAuthenticateOidc
{
    /// <summary>The query parameters to include in the redirect request to the authorization endpoint. Max: 10.</summary>
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>The authorization endpoint of the IdP.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>The OAuth 2.0 client identifier.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Issuer of the JWT.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The behavior if the user is not authenticated. Valid values: deny, allow and authenticate</summary>
    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    /// <summary>The set of user claims to be requested from the IdP.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>The name of the cookie used to maintain session information.</summary>
    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    /// <summary>The maximum duration of the authentication session, in seconds.</summary>
    [JsonPropertyName("sessionTimeout")]
    public double? SessionTimeout { get; set; }

    /// <summary>The token endpoint of the IdP.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>The user info endpoint of the IdP.</summary>
    [JsonPropertyName("userInfoEndpoint")]
    public string? UserInfoEndpoint { get; set; }
}

/// <summary>Information for creating an action that returns a custom HTTP response. Required if type is fixed-response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderActionFixedResponse
{
    /// <summary>The content type. Valid values are text/plain, text/css, text/html, application/javascript and application/json.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>The message body.</summary>
    [JsonPropertyName("messageBody")]
    public string? MessageBody { get; set; }

    /// <summary>The HTTP redirect code. The redirect is either permanent (HTTP_301) or temporary (HTTP_302).</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>The target group stickiness for the rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderActionForwardStickiness
{
    /// <summary>The time period, in seconds, during which requests from a client should be routed to the same target group. The range is 1-604800 seconds (7 days).</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Indicates whether target group stickiness is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderActionForwardTargetGroup
{
    /// <summary>The Amazon Resource Name (ARN) of the target group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The weight. The range is 0 to 999.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// Configuration block for creating an action that distributes requests among one or more target groups.
/// Specify only if type is forward.
/// Cannot be specified with target_group_arn.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderActionForward
{
    /// <summary>The target group stickiness for the rule.</summary>
    [JsonPropertyName("stickiness")]
    public V1beta2LBListenerRuleStatusAtProviderActionForwardStickiness? Stickiness { get; set; }

    /// <summary>One or more target group blocks.</summary>
    [JsonPropertyName("targetGroup")]
    public IList<V1beta2LBListenerRuleStatusAtProviderActionForwardTargetGroup>? TargetGroup { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderActionJwtValidationAdditionalClaim
{
    /// <summary>Format of the claim value. Valid values are single-string, string-array and space-separated-values.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Name of the claim to validate. exp, iss, nbf, or iat cannot be specified because they are validated by default.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal &apos;*&apos; or &apos;?&apos; character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Information for creating a JWT validation action. Required if type is jwt-validation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderActionJwtValidation
{
    /// <summary>Repeatable configuration block for additional claims to validate.</summary>
    [JsonPropertyName("additionalClaim")]
    public IList<V1beta2LBListenerRuleStatusAtProviderActionJwtValidationAdditionalClaim>? AdditionalClaim { get; set; }

    /// <summary>Issuer of the JWT.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>JSON Web Key Set (JWKS) endpoint. This endpoint contains JSON Web Keys (JWK) that are used to validate signatures from the provider. This must be a full URL, including the HTTPS protocol, the domain, and the path.</summary>
    [JsonPropertyName("jwksEndpoint")]
    public string? JwksEndpoint { get; set; }
}

/// <summary>Information for creating a redirect action. Required if type is redirect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderActionRedirect
{
    /// <summary>The hostname. This component is not percent-encoded. The hostname can contain #{host}. Defaults to #{host}.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The absolute path, starting with the leading &quot;/&quot;. This component is not percent-encoded. The path can contain #{host}, #{path}, and #{port}. Defaults to /#{path}.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port. Specify a value from 1 to 65535 or #{port}. Defaults to #{port}.</summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>The protocol. Valid values are HTTP, HTTPS, or #{protocol}. Defaults to #{protocol}.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The query parameters, URL-encoded when necessary, but not percent-encoded. Do not include the leading &quot;?&quot;. Defaults to #{query}.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>The HTTP redirect code. The redirect is either permanent (HTTP_301) or temporary (HTTP_302).</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderAction
{
    /// <summary>Information for creating an authenticate action using Cognito. Required if type is authenticate-cognito.</summary>
    [JsonPropertyName("authenticateCognito")]
    public V1beta2LBListenerRuleStatusAtProviderActionAuthenticateCognito? AuthenticateCognito { get; set; }

    /// <summary>Information for creating an authenticate action using OIDC. Required if type is authenticate-oidc.</summary>
    [JsonPropertyName("authenticateOidc")]
    public V1beta2LBListenerRuleStatusAtProviderActionAuthenticateOidc? AuthenticateOidc { get; set; }

    /// <summary>Information for creating an action that returns a custom HTTP response. Required if type is fixed-response.</summary>
    [JsonPropertyName("fixedResponse")]
    public V1beta2LBListenerRuleStatusAtProviderActionFixedResponse? FixedResponse { get; set; }

    /// <summary>
    /// Configuration block for creating an action that distributes requests among one or more target groups.
    /// Specify only if type is forward.
    /// Cannot be specified with target_group_arn.
    /// </summary>
    [JsonPropertyName("forward")]
    public V1beta2LBListenerRuleStatusAtProviderActionForward? Forward { get; set; }

    /// <summary>Information for creating a JWT validation action. Required if type is jwt-validation.</summary>
    [JsonPropertyName("jwtValidation")]
    public V1beta2LBListenerRuleStatusAtProviderActionJwtValidation? JwtValidation { get; set; }

    /// <summary>
    /// Order for the action.
    /// The action with the lowest value for order is performed first.
    /// Valid values are between 1 and 50000.
    /// Defaults to the position in the list of actions.
    /// </summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Information for creating a redirect action. Required if type is redirect.</summary>
    [JsonPropertyName("redirect")]
    public V1beta2LBListenerRuleStatusAtProviderActionRedirect? Redirect { get; set; }

    /// <summary>
    /// ARN of the Target Group to which to route traffic.
    /// Specify only if type is forward and you want to route to a single target group.
    /// To route to one or more target groups, use a forward block instead.
    /// Cannot be specified with forward.
    /// </summary>
    [JsonPropertyName("targetGroupArn")]
    public string? TargetGroupArn { get; set; }

    /// <summary>The type of routing action. Valid values are forward, redirect, fixed-response, authenticate-cognito, authenticate-oidc and jwt-validation.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Host header patterns to match. Host Header block fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderConditionHostHeader
{
    /// <summary>List of regular expressions to compare against the host header. The maximum length of each string is 128 characters. Conflicts with values.</summary>
    [JsonPropertyName("regexValues")]
    public IList<string>? RegexValues { get; set; }

    /// <summary>List of host header value patterns to match. Maximum size of each pattern is 128 characters. Comparison is case-insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). Only one pattern needs to match for the condition to be satisfied. Conflicts with regex_values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>HTTP headers to match. HTTP Header block fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderConditionHttpHeader
{
    /// <summary>Name of HTTP header to search. The maximum size is 40 characters. Comparison is case-insensitive. Only RFC7240 characters are supported. Wildcards are not supported. You cannot use HTTP header condition to specify the host header, use a host-header condition instead.</summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>List of regular expressions to compare against the request URL. The maximum length of each string is 128 characters. Conflicts with values.</summary>
    [JsonPropertyName("regexValues")]
    public IList<string>? RegexValues { get; set; }

    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal &apos;*&apos; or &apos;?&apos; character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Contains a single values item which is a list of HTTP request methods or verbs to match. Maximum size is 40 characters. Only allowed characters are A-Z, hyphen (-) and underscore (_). Comparison is case sensitive. Wildcards are not supported. Only one needs to match for the condition to be satisfied. AWS recommends that GET and HEAD requests are routed in the same way because the response to a HEAD request may be cached.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderConditionHttpRequestMethod
{
    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal &apos;*&apos; or &apos;?&apos; character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Path patterns to match against the request URL. Path Pattern block fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderConditionPathPattern
{
    /// <summary>List of regular expressions to compare against the request URL. The maximum length of each string is 128 characters. Conflicts with values.</summary>
    [JsonPropertyName("regexValues")]
    public IList<string>? RegexValues { get; set; }

    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal &apos;*&apos; or &apos;?&apos; character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderConditionQueryString
{
    /// <summary>Query string key pattern to match.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Query string value pattern to match.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Contains a single values item which is a list of source IP CIDR notations to match. You can use both IPv4 and IPv6 addresses. Wildcards are not supported. Condition is satisfied if the source IP address of the request matches one of the CIDR blocks. Condition is not satisfied by the addresses in the X-Forwarded-For header, use http_header condition instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderConditionSourceIp
{
    /// <summary>Query string pairs or values to match. Query String Value blocks documented below. Multiple values blocks can be specified, see example above. Maximum size of each string is 128 characters. Comparison is case insensitive. Wildcard characters supported: * (matches 0 or more characters) and ? (matches exactly 1 character). To search for a literal &apos;*&apos; or &apos;?&apos; character in a query string, escape the character with a backslash (\). Only one pair needs to match for the condition to be satisfied.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderCondition
{
    /// <summary>Host header patterns to match. Host Header block fields documented below.</summary>
    [JsonPropertyName("hostHeader")]
    public V1beta2LBListenerRuleStatusAtProviderConditionHostHeader? HostHeader { get; set; }

    /// <summary>HTTP headers to match. HTTP Header block fields documented below.</summary>
    [JsonPropertyName("httpHeader")]
    public V1beta2LBListenerRuleStatusAtProviderConditionHttpHeader? HttpHeader { get; set; }

    /// <summary>Contains a single values item which is a list of HTTP request methods or verbs to match. Maximum size is 40 characters. Only allowed characters are A-Z, hyphen (-) and underscore (_). Comparison is case sensitive. Wildcards are not supported. Only one needs to match for the condition to be satisfied. AWS recommends that GET and HEAD requests are routed in the same way because the response to a HEAD request may be cached.</summary>
    [JsonPropertyName("httpRequestMethod")]
    public V1beta2LBListenerRuleStatusAtProviderConditionHttpRequestMethod? HttpRequestMethod { get; set; }

    /// <summary>Path patterns to match against the request URL. Path Pattern block fields documented below.</summary>
    [JsonPropertyName("pathPattern")]
    public V1beta2LBListenerRuleStatusAtProviderConditionPathPattern? PathPattern { get; set; }

    /// <summary>Query strings to match. Query String block fields documented below.</summary>
    [JsonPropertyName("queryString")]
    public IList<V1beta2LBListenerRuleStatusAtProviderConditionQueryString>? QueryString { get; set; }

    /// <summary>Contains a single values item which is a list of source IP CIDR notations to match. You can use both IPv4 and IPv6 addresses. Wildcards are not supported. Condition is satisfied if the source IP address of the request matches one of the CIDR blocks. Condition is not satisfied by the addresses in the X-Forwarded-For header, use http_header condition instead.</summary>
    [JsonPropertyName("sourceIp")]
    public V1beta2LBListenerRuleStatusAtProviderConditionSourceIp? SourceIp { get; set; }
}

/// <summary>Block for host header rewrite configuration. Only one block is accepted. See Rewrite Blocks below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderTransformHostHeaderRewriteConfigRewrite
{
    /// <summary>Regular expression to match in the input string. Length constraints: Between 1 and 1024 characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Replacement string to use when rewriting the matched input. Capture groups in the regular expression (for example, $1 and $2) can be specified. Length constraints: Between 0 and 1024 characters.</summary>
    [JsonPropertyName("replace")]
    public string? Replace { get; set; }
}

/// <summary>Configuration block for host header rewrite. Required if type is host-header-rewrite. See Host Header Rewrite Config Blocks below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderTransformHostHeaderRewriteConfig
{
    /// <summary>Block for host header rewrite configuration. Only one block is accepted. See Rewrite Blocks below.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta2LBListenerRuleStatusAtProviderTransformHostHeaderRewriteConfigRewrite? Rewrite { get; set; }
}

/// <summary>Block for URL rewrite configuration. Only one block is accepted. See Rewrite Blocks below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderTransformUrlRewriteConfigRewrite
{
    /// <summary>Regular expression to match in the input string. Length constraints: Between 1 and 1024 characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Replacement string to use when rewriting the matched input. Capture groups in the regular expression (for example, $1 and $2) can be specified. Length constraints: Between 0 and 1024 characters.</summary>
    [JsonPropertyName("replace")]
    public string? Replace { get; set; }
}

/// <summary>Configuration block for URL rewrite. Required if type is url-rewrite. See URL Rewrite Config Blocks below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderTransformUrlRewriteConfig
{
    /// <summary>Block for URL rewrite configuration. Only one block is accepted. See Rewrite Blocks below.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta2LBListenerRuleStatusAtProviderTransformUrlRewriteConfigRewrite? Rewrite { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProviderTransform
{
    /// <summary>Configuration block for host header rewrite. Required if type is host-header-rewrite. See Host Header Rewrite Config Blocks below.</summary>
    [JsonPropertyName("hostHeaderRewriteConfig")]
    public V1beta2LBListenerRuleStatusAtProviderTransformHostHeaderRewriteConfig? HostHeaderRewriteConfig { get; set; }

    /// <summary>Type of transform. Valid values are host-header-rewrite and url-rewrite.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Configuration block for URL rewrite. Required if type is url-rewrite. See URL Rewrite Config Blocks below.</summary>
    [JsonPropertyName("urlRewriteConfig")]
    public V1beta2LBListenerRuleStatusAtProviderTransformUrlRewriteConfig? UrlRewriteConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusAtProvider
{
    /// <summary>An Action block. Action blocks are documented below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta2LBListenerRuleStatusAtProviderAction>? Action { get; set; }

    /// <summary>The ARN of the rule (matches id)</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A Condition block. Multiple condition blocks of different types can be set and all must be satisfied for the rule to match. Condition blocks are documented below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta2LBListenerRuleStatusAtProviderCondition>? Condition { get; set; }

    /// <summary>The ARN of the rule (matches arn)</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ARN of the listener to which to attach the rule.</summary>
    [JsonPropertyName("listenerArn")]
    public string? ListenerArn { get; set; }

    /// <summary>The priority for the rule between 1 and 50000. Leaving it unset will automatically set the rule with next available priority after currently existing highest rule. A listener can&apos;t have multiple rules with the same priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Configuration block that defines the transform to apply to requests matching this rule. See Transform Blocks below for more details. Once specified, to remove the transform from the rule, remove the transform block from the configuration.</summary>
    [JsonPropertyName("transform")]
    public IList<V1beta2LBListenerRuleStatusAtProviderTransform>? Transform { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatusConditions
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

/// <summary>LBListenerRuleStatus defines the observed state of LBListenerRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LBListenerRuleStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2LBListenerRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2LBListenerRuleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LBListenerRule is the Schema for the LBListenerRules API. Provides a Load Balancer Listener Rule resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2LBListenerRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2LBListenerRuleSpec>, IStatus<V1beta2LBListenerRuleStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "LBListenerRule";
    public const string KubeGroup = "elbv2.aws.upbound.io";
    public const string KubePluralName = "lblistenerrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elbv2.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LBListenerRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LBListenerRuleSpec defines the desired state of LBListenerRule</summary>
    [JsonPropertyName("spec")]
    public required V1beta2LBListenerRuleSpec Spec { get; set; }

    /// <summary>LBListenerRuleStatus defines the observed state of LBListenerRule.</summary>
    [JsonPropertyName("status")]
    public V1beta2LBListenerRuleStatus? Status { get; set; }
}
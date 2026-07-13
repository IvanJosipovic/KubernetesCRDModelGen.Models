#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.upbound.io;
/// <summary>FrontdoorSecurityPolicy is the Schema for the FrontdoorSecurityPolicys API. Manages a Front Door (standard/premium) Security Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FrontdoorSecurityPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta2FrontdoorSecurityPolicy>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FrontdoorSecurityPolicyList";
    public const string KubeGroup = "cdn.azure.upbound.io";
    public const string KubePluralName = "frontdoorsecuritypolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cdn.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FrontdoorSecurityPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2FrontdoorSecurityPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2FrontdoorSecurityPolicy> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecDeletionPolicyEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorProfile in cdn to populate cdnFrontdoorProfileId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorProfile in cdn to populate cdnFrontdoorProfileId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelector
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
    public V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorCustomDomain in cdn to populate cdnFrontdoorDomainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorCustomDomain in cdn to populate cdnFrontdoorDomainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelector
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
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomain
{
    /// <summary>The Resource Id of the Front Door Custom Domain or Front Door Endpoint that should be bound to this Front Door Security Policy.</summary>
    [JsonPropertyName("cdnFrontdoorDomainId")]
    public string? CdnFrontdoorDomainId { get; set; }

    /// <summary>Reference to a FrontdoorCustomDomain in cdn to populate cdnFrontdoorDomainId.</summary>
    [JsonPropertyName("cdnFrontdoorDomainIdRef")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRef? CdnFrontdoorDomainIdRef { get; set; }

    /// <summary>Selector for a FrontdoorCustomDomain in cdn to populate cdnFrontdoorDomainId.</summary>
    [JsonPropertyName("cdnFrontdoorDomainIdSelector")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelector? CdnFrontdoorDomainIdSelector { get; set; }
}

/// <summary>An association block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociation
{
    /// <summary>One or more domain blocks as defined below.</summary>
    [JsonPropertyName("domain")]
    public IList<V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociationDomain>? Domain { get; set; }

    /// <summary>The list of paths to match for this firewall policy. Possible value includes /*. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorFirewallPolicy in cdn to populate cdnFrontdoorFirewallPolicyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorFirewallPolicy in cdn to populate cdnFrontdoorFirewallPolicyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelector
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
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>An firewall block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewall
{
    /// <summary>An association block as defined below.</summary>
    [JsonPropertyName("association")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallAssociation? Association { get; set; }

    /// <summary>The Resource Id of the Front Door Firewall Policy that should be linked to this Front Door Security Policy. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("cdnFrontdoorFirewallPolicyId")]
    public string? CdnFrontdoorFirewallPolicyId { get; set; }

    /// <summary>Reference to a FrontdoorFirewallPolicy in cdn to populate cdnFrontdoorFirewallPolicyId.</summary>
    [JsonPropertyName("cdnFrontdoorFirewallPolicyIdRef")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRef? CdnFrontdoorFirewallPolicyIdRef { get; set; }

    /// <summary>Selector for a FrontdoorFirewallPolicy in cdn to populate cdnFrontdoorFirewallPolicyId.</summary>
    [JsonPropertyName("cdnFrontdoorFirewallPolicyIdSelector")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelector? CdnFrontdoorFirewallPolicyIdSelector { get; set; }
}

/// <summary>An security_policies block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPolicies
{
    /// <summary>An firewall block as defined below.</summary>
    [JsonPropertyName("firewall")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPoliciesFirewall? Firewall { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecForProvider
{
    /// <summary>The Front Door Profile Resource Id that is linked to this Front Door Security Policy. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("cdnFrontdoorProfileId")]
    public string? CdnFrontdoorProfileId { get; set; }

    /// <summary>Reference to a FrontdoorProfile in cdn to populate cdnFrontdoorProfileId.</summary>
    [JsonPropertyName("cdnFrontdoorProfileIdRef")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdRef? CdnFrontdoorProfileIdRef { get; set; }

    /// <summary>Selector for a FrontdoorProfile in cdn to populate cdnFrontdoorProfileId.</summary>
    [JsonPropertyName("cdnFrontdoorProfileIdSelector")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderCdnFrontdoorProfileIdSelector? CdnFrontdoorProfileIdSelector { get; set; }

    /// <summary>An security_policies block as defined below.</summary>
    [JsonPropertyName("securityPolicies")]
    public V1beta2FrontdoorSecurityPolicySpecForProviderSecurityPolicies? SecurityPolicies { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorCustomDomain in cdn to populate cdnFrontdoorDomainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorCustomDomain in cdn to populate cdnFrontdoorDomainId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelector
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
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomain
{
    /// <summary>The Resource Id of the Front Door Custom Domain or Front Door Endpoint that should be bound to this Front Door Security Policy.</summary>
    [JsonPropertyName("cdnFrontdoorDomainId")]
    public string? CdnFrontdoorDomainId { get; set; }

    /// <summary>Reference to a FrontdoorCustomDomain in cdn to populate cdnFrontdoorDomainId.</summary>
    [JsonPropertyName("cdnFrontdoorDomainIdRef")]
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdRef? CdnFrontdoorDomainIdRef { get; set; }

    /// <summary>Selector for a FrontdoorCustomDomain in cdn to populate cdnFrontdoorDomainId.</summary>
    [JsonPropertyName("cdnFrontdoorDomainIdSelector")]
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomainCdnFrontdoorDomainIdSelector? CdnFrontdoorDomainIdSelector { get; set; }
}

/// <summary>An association block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociation
{
    /// <summary>One or more domain blocks as defined below.</summary>
    [JsonPropertyName("domain")]
    public IList<V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociationDomain>? Domain { get; set; }

    /// <summary>The list of paths to match for this firewall policy. Possible value includes /*. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FrontdoorFirewallPolicy in cdn to populate cdnFrontdoorFirewallPolicyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FrontdoorFirewallPolicy in cdn to populate cdnFrontdoorFirewallPolicyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelector
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
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>An firewall block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewall
{
    /// <summary>An association block as defined below.</summary>
    [JsonPropertyName("association")]
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallAssociation? Association { get; set; }

    /// <summary>The Resource Id of the Front Door Firewall Policy that should be linked to this Front Door Security Policy. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("cdnFrontdoorFirewallPolicyId")]
    public string? CdnFrontdoorFirewallPolicyId { get; set; }

    /// <summary>Reference to a FrontdoorFirewallPolicy in cdn to populate cdnFrontdoorFirewallPolicyId.</summary>
    [JsonPropertyName("cdnFrontdoorFirewallPolicyIdRef")]
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdRef? CdnFrontdoorFirewallPolicyIdRef { get; set; }

    /// <summary>Selector for a FrontdoorFirewallPolicy in cdn to populate cdnFrontdoorFirewallPolicyId.</summary>
    [JsonPropertyName("cdnFrontdoorFirewallPolicyIdSelector")]
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewallCdnFrontdoorFirewallPolicyIdSelector? CdnFrontdoorFirewallPolicyIdSelector { get; set; }
}

/// <summary>An security_policies block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPolicies
{
    /// <summary>An firewall block as defined below.</summary>
    [JsonPropertyName("firewall")]
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPoliciesFirewall? Firewall { get; set; }
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
public partial class V1beta2FrontdoorSecurityPolicySpecInitProvider
{
    /// <summary>An security_policies block as defined below.</summary>
    [JsonPropertyName("securityPolicies")]
    public V1beta2FrontdoorSecurityPolicySpecInitProviderSecurityPolicies? SecurityPolicies { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecManagementPoliciesEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorSecurityPolicySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorSecurityPolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorSecurityPolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorSecurityPolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorSecurityPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>FrontdoorSecurityPolicySpec defines the desired state of FrontdoorSecurityPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicySpec
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
    public V1beta2FrontdoorSecurityPolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2FrontdoorSecurityPolicySpecForProvider ForProvider { get; set; }

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
    public V1beta2FrontdoorSecurityPolicySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2FrontdoorSecurityPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2FrontdoorSecurityPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2FrontdoorSecurityPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicyStatusAtProviderSecurityPoliciesFirewallAssociationDomain
{
    /// <summary>(Computed) Is the Front Door Custom Domain/Endpoint activated?</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>The Resource Id of the Front Door Custom Domain or Front Door Endpoint that should be bound to this Front Door Security Policy.</summary>
    [JsonPropertyName("cdnFrontdoorDomainId")]
    public string? CdnFrontdoorDomainId { get; set; }
}

/// <summary>An association block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicyStatusAtProviderSecurityPoliciesFirewallAssociation
{
    /// <summary>One or more domain blocks as defined below.</summary>
    [JsonPropertyName("domain")]
    public IList<V1beta2FrontdoorSecurityPolicyStatusAtProviderSecurityPoliciesFirewallAssociationDomain>? Domain { get; set; }

    /// <summary>The list of paths to match for this firewall policy. Possible value includes /*. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }
}

/// <summary>An firewall block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicyStatusAtProviderSecurityPoliciesFirewall
{
    /// <summary>An association block as defined below.</summary>
    [JsonPropertyName("association")]
    public V1beta2FrontdoorSecurityPolicyStatusAtProviderSecurityPoliciesFirewallAssociation? Association { get; set; }

    /// <summary>The Resource Id of the Front Door Firewall Policy that should be linked to this Front Door Security Policy. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("cdnFrontdoorFirewallPolicyId")]
    public string? CdnFrontdoorFirewallPolicyId { get; set; }
}

/// <summary>An security_policies block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicyStatusAtProviderSecurityPolicies
{
    /// <summary>An firewall block as defined below.</summary>
    [JsonPropertyName("firewall")]
    public V1beta2FrontdoorSecurityPolicyStatusAtProviderSecurityPoliciesFirewall? Firewall { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicyStatusAtProvider
{
    /// <summary>The Front Door Profile Resource Id that is linked to this Front Door Security Policy. Changing this forces a new Front Door Security Policy to be created.</summary>
    [JsonPropertyName("cdnFrontdoorProfileId")]
    public string? CdnFrontdoorProfileId { get; set; }

    /// <summary>The ID of the Front Door Security Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An security_policies block as defined below.</summary>
    [JsonPropertyName("securityPolicies")]
    public V1beta2FrontdoorSecurityPolicyStatusAtProviderSecurityPolicies? SecurityPolicies { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicyStatusConditions
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

/// <summary>FrontdoorSecurityPolicyStatus defines the observed state of FrontdoorSecurityPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorSecurityPolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2FrontdoorSecurityPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2FrontdoorSecurityPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FrontdoorSecurityPolicy is the Schema for the FrontdoorSecurityPolicys API. Manages a Front Door (standard/premium) Security Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FrontdoorSecurityPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2FrontdoorSecurityPolicySpec>, IStatus<V1beta2FrontdoorSecurityPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FrontdoorSecurityPolicy";
    public const string KubeGroup = "cdn.azure.upbound.io";
    public const string KubePluralName = "frontdoorsecuritypolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cdn.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FrontdoorSecurityPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FrontdoorSecurityPolicySpec defines the desired state of FrontdoorSecurityPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta2FrontdoorSecurityPolicySpec Spec { get; set; }

    /// <summary>FrontdoorSecurityPolicyStatus defines the observed state of FrontdoorSecurityPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta2FrontdoorSecurityPolicyStatus? Status { get; set; }
}
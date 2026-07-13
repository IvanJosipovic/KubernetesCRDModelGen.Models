#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
/// <summary>
/// ExpressRoutePort is the Schema for the ExpressRoutePorts API. Manages a Express Route Port.
/// Deprecated: This API version (v1beta1) has been deprecated in release v2.6.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ExpressRoutePortList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ExpressRoutePort>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ExpressRoutePortList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "expressrouteports";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ExpressRoutePortList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ExpressRoutePort objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ExpressRoutePort> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRoutePortSpecDeletionPolicyEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRoutePortSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Express Route Port.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Express Route Port. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortSpecForProviderLink1
{
    /// <summary>Whether enable administration state on the Express Route Port Link? Defaults to false.</summary>
    [JsonPropertyName("adminEnabled")]
    public bool? AdminEnabled { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the Mac security CAK key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCakKeyvaultSecretId")]
    public string? MacsecCakKeyvaultSecretId { get; set; }

    /// <summary>The MACSec cipher used for this Express Route Port Link. Possible values are GcmAes128 and GcmAes256. Defaults to GcmAes128.</summary>
    [JsonPropertyName("macsecCipher")]
    public string? MacsecCipher { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the MACSec CKN key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCknKeyvaultSecretId")]
    public string? MacsecCknKeyvaultSecretId { get; set; }

    /// <summary>Should Secure Channel Identifier on the Express Route Port Link be enabled? Defaults to false.</summary>
    [JsonPropertyName("macsecSciEnabled")]
    public bool? MacsecSciEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortSpecForProviderLink2
{
    /// <summary>Whether enable administration state on the Express Route Port Link? Defaults to false.</summary>
    [JsonPropertyName("adminEnabled")]
    public bool? AdminEnabled { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the Mac security CAK key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCakKeyvaultSecretId")]
    public string? MacsecCakKeyvaultSecretId { get; set; }

    /// <summary>The MACSec cipher used for this Express Route Port Link. Possible values are GcmAes128 and GcmAes256. Defaults to GcmAes128.</summary>
    [JsonPropertyName("macsecCipher")]
    public string? MacsecCipher { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the MACSec CKN key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCknKeyvaultSecretId")]
    public string? MacsecCknKeyvaultSecretId { get; set; }

    /// <summary>Should Secure Channel Identifier on the Express Route Port Link be enabled? Defaults to false.</summary>
    [JsonPropertyName("macsecSciEnabled")]
    public bool? MacsecSciEnabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelector
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
    public V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortSpecForProvider
{
    /// <summary>Bandwidth of the Express Route Port in Gbps. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("bandwidthInGbps")]
    public double? BandwidthInGbps { get; set; }

    /// <summary>The billing type of the Express Route Port. Possible values are MeteredData and UnlimitedData.</summary>
    [JsonPropertyName("billingType")]
    public string? BillingType { get; set; }

    /// <summary>The encapsulation method used for the Express Route Port. Changing this forces a new Express Route Port to be created. Possible values are: Dot1Q, QinQ.</summary>
    [JsonPropertyName("encapsulation")]
    public string? Encapsulation { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ExpressRoutePortSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>A list of link blocks as defined below.</summary>
    [JsonPropertyName("link1")]
    public IList<V1beta1ExpressRoutePortSpecForProviderLink1>? Link1 { get; set; }

    /// <summary>A list of link blocks as defined below.</summary>
    [JsonPropertyName("link2")]
    public IList<V1beta1ExpressRoutePortSpecForProviderLink2>? Link2 { get; set; }

    /// <summary>The Azure Region where the Express Route Port should exist. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the peering location that this Express Route Port is physically mapped to. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("peeringLocation")]
    public string? PeeringLocation { get; set; }

    /// <summary>The name of the Resource Group where the Express Route Port should exist. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ExpressRoutePortSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ExpressRoutePortSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Express Route Port.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Express Route Port.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Express Route Port. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortSpecInitProviderLink1
{
    /// <summary>Whether enable administration state on the Express Route Port Link? Defaults to false.</summary>
    [JsonPropertyName("adminEnabled")]
    public bool? AdminEnabled { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the Mac security CAK key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCakKeyvaultSecretId")]
    public string? MacsecCakKeyvaultSecretId { get; set; }

    /// <summary>The MACSec cipher used for this Express Route Port Link. Possible values are GcmAes128 and GcmAes256. Defaults to GcmAes128.</summary>
    [JsonPropertyName("macsecCipher")]
    public string? MacsecCipher { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the MACSec CKN key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCknKeyvaultSecretId")]
    public string? MacsecCknKeyvaultSecretId { get; set; }

    /// <summary>Should Secure Channel Identifier on the Express Route Port Link be enabled? Defaults to false.</summary>
    [JsonPropertyName("macsecSciEnabled")]
    public bool? MacsecSciEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortSpecInitProviderLink2
{
    /// <summary>Whether enable administration state on the Express Route Port Link? Defaults to false.</summary>
    [JsonPropertyName("adminEnabled")]
    public bool? AdminEnabled { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the Mac security CAK key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCakKeyvaultSecretId")]
    public string? MacsecCakKeyvaultSecretId { get; set; }

    /// <summary>The MACSec cipher used for this Express Route Port Link. Possible values are GcmAes128 and GcmAes256. Defaults to GcmAes128.</summary>
    [JsonPropertyName("macsecCipher")]
    public string? MacsecCipher { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the MACSec CKN key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCknKeyvaultSecretId")]
    public string? MacsecCknKeyvaultSecretId { get; set; }

    /// <summary>Should Secure Channel Identifier on the Express Route Port Link be enabled? Defaults to false.</summary>
    [JsonPropertyName("macsecSciEnabled")]
    public bool? MacsecSciEnabled { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortSpecInitProvider
{
    /// <summary>Bandwidth of the Express Route Port in Gbps. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("bandwidthInGbps")]
    public double? BandwidthInGbps { get; set; }

    /// <summary>The billing type of the Express Route Port. Possible values are MeteredData and UnlimitedData.</summary>
    [JsonPropertyName("billingType")]
    public string? BillingType { get; set; }

    /// <summary>The encapsulation method used for the Express Route Port. Changing this forces a new Express Route Port to be created. Possible values are: Dot1Q, QinQ.</summary>
    [JsonPropertyName("encapsulation")]
    public string? Encapsulation { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ExpressRoutePortSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>A list of link blocks as defined below.</summary>
    [JsonPropertyName("link1")]
    public IList<V1beta1ExpressRoutePortSpecInitProviderLink1>? Link1 { get; set; }

    /// <summary>A list of link blocks as defined below.</summary>
    [JsonPropertyName("link2")]
    public IList<V1beta1ExpressRoutePortSpecInitProviderLink2>? Link2 { get; set; }

    /// <summary>The Azure Region where the Express Route Port should exist. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the peering location that this Express Route Port is physically mapped to. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("peeringLocation")]
    public string? PeeringLocation { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Express Route Port.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRoutePortSpecManagementPoliciesEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRoutePortSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRoutePortSpecProviderConfigRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRoutePortSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ExpressRoutePortSpecProviderConfigRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public enum V1beta1ExpressRoutePortSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ExpressRoutePortSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ExpressRoutePortSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRoutePortSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ExpressRoutePortSpec defines the desired state of ExpressRoutePort</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortSpec
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
    public V1beta1ExpressRoutePortSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1ExpressRoutePortSpecForProvider ForProvider { get; set; }

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
    public V1beta1ExpressRoutePortSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1ExpressRoutePortSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ExpressRoutePortSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ExpressRoutePortSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Express Route Port.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The ID of the Express Route Port.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The ID of the Express Route Port.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Express Route Port. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortStatusAtProviderLink1
{
    /// <summary>Whether enable administration state on the Express Route Port Link? Defaults to false.</summary>
    [JsonPropertyName("adminEnabled")]
    public bool? AdminEnabled { get; set; }

    /// <summary>The connector type of the Express Route Port Link.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>The ID of this Express Route Port Link.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The interface name of the Azure router associated with the Express Route Port Link.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the Mac security CAK key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCakKeyvaultSecretId")]
    public string? MacsecCakKeyvaultSecretId { get; set; }

    /// <summary>The MACSec cipher used for this Express Route Port Link. Possible values are GcmAes128 and GcmAes256. Defaults to GcmAes128.</summary>
    [JsonPropertyName("macsecCipher")]
    public string? MacsecCipher { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the MACSec CKN key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCknKeyvaultSecretId")]
    public string? MacsecCknKeyvaultSecretId { get; set; }

    /// <summary>Should Secure Channel Identifier on the Express Route Port Link be enabled? Defaults to false.</summary>
    [JsonPropertyName("macsecSciEnabled")]
    public bool? MacsecSciEnabled { get; set; }

    /// <summary>The ID that maps from the Express Route Port Link to the patch panel port.</summary>
    [JsonPropertyName("patchPanelId")]
    public string? PatchPanelId { get; set; }

    /// <summary>The ID that maps from the patch panel port to the rack.</summary>
    [JsonPropertyName("rackId")]
    public string? RackId { get; set; }

    /// <summary>The name of the Azure router associated with the Express Route Port Link.</summary>
    [JsonPropertyName("routerName")]
    public string? RouterName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortStatusAtProviderLink2
{
    /// <summary>Whether enable administration state on the Express Route Port Link? Defaults to false.</summary>
    [JsonPropertyName("adminEnabled")]
    public bool? AdminEnabled { get; set; }

    /// <summary>The connector type of the Express Route Port Link.</summary>
    [JsonPropertyName("connectorType")]
    public string? ConnectorType { get; set; }

    /// <summary>The ID of this Express Route Port Link.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The interface name of the Azure router associated with the Express Route Port Link.</summary>
    [JsonPropertyName("interfaceName")]
    public string? InterfaceName { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the Mac security CAK key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCakKeyvaultSecretId")]
    public string? MacsecCakKeyvaultSecretId { get; set; }

    /// <summary>The MACSec cipher used for this Express Route Port Link. Possible values are GcmAes128 and GcmAes256. Defaults to GcmAes128.</summary>
    [JsonPropertyName("macsecCipher")]
    public string? MacsecCipher { get; set; }

    /// <summary>The ID of the Key Vault Secret that contains the MACSec CKN key for this Express Route Port Link.</summary>
    [JsonPropertyName("macsecCknKeyvaultSecretId")]
    public string? MacsecCknKeyvaultSecretId { get; set; }

    /// <summary>Should Secure Channel Identifier on the Express Route Port Link be enabled? Defaults to false.</summary>
    [JsonPropertyName("macsecSciEnabled")]
    public bool? MacsecSciEnabled { get; set; }

    /// <summary>The ID that maps from the Express Route Port Link to the patch panel port.</summary>
    [JsonPropertyName("patchPanelId")]
    public string? PatchPanelId { get; set; }

    /// <summary>The ID that maps from the patch panel port to the rack.</summary>
    [JsonPropertyName("rackId")]
    public string? RackId { get; set; }

    /// <summary>The name of the Azure router associated with the Express Route Port Link.</summary>
    [JsonPropertyName("routerName")]
    public string? RouterName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortStatusAtProvider
{
    /// <summary>Bandwidth of the Express Route Port in Gbps. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("bandwidthInGbps")]
    public double? BandwidthInGbps { get; set; }

    /// <summary>The billing type of the Express Route Port. Possible values are MeteredData and UnlimitedData.</summary>
    [JsonPropertyName("billingType")]
    public string? BillingType { get; set; }

    /// <summary>The encapsulation method used for the Express Route Port. Changing this forces a new Express Route Port to be created. Possible values are: Dot1Q, QinQ.</summary>
    [JsonPropertyName("encapsulation")]
    public string? Encapsulation { get; set; }

    /// <summary>The EtherType of the Express Route Port.</summary>
    [JsonPropertyName("ethertype")]
    public string? Ethertype { get; set; }

    /// <summary>The resource GUID of the Express Route Port.</summary>
    [JsonPropertyName("guid")]
    public string? Guid { get; set; }

    /// <summary>The ID of the Express Route Port.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ExpressRoutePortStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>A list of link blocks as defined below.</summary>
    [JsonPropertyName("link1")]
    public IList<V1beta1ExpressRoutePortStatusAtProviderLink1>? Link1 { get; set; }

    /// <summary>A list of link blocks as defined below.</summary>
    [JsonPropertyName("link2")]
    public IList<V1beta1ExpressRoutePortStatusAtProviderLink2>? Link2 { get; set; }

    /// <summary>The Azure Region where the Express Route Port should exist. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum transmission unit of the Express Route Port.</summary>
    [JsonPropertyName("mtu")]
    public string? Mtu { get; set; }

    /// <summary>The name of the peering location that this Express Route Port is physically mapped to. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("peeringLocation")]
    public string? PeeringLocation { get; set; }

    /// <summary>The name of the Resource Group where the Express Route Port should exist. Changing this forces a new Express Route Port to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Express Route Port.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortStatusConditions
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

/// <summary>ExpressRoutePortStatus defines the observed state of ExpressRoutePort.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
public partial class V1beta1ExpressRoutePortStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ExpressRoutePortStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ExpressRoutePortStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// ExpressRoutePort is the Schema for the ExpressRoutePorts API. Manages a Express Route Port.
/// Deprecated: This API version (v1beta1) has been deprecated in release v2.6.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Deprecated since v2.6.0.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ExpressRoutePort : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ExpressRoutePortSpec>, IStatus<V1beta1ExpressRoutePortStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ExpressRoutePort";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "expressrouteports";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ExpressRoutePort";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ExpressRoutePortSpec defines the desired state of ExpressRoutePort</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ExpressRoutePortSpec Spec { get; set; }

    /// <summary>ExpressRoutePortStatus defines the observed state of ExpressRoutePort.</summary>
    [JsonPropertyName("status")]
    public V1beta1ExpressRoutePortStatus? Status { get; set; }
}
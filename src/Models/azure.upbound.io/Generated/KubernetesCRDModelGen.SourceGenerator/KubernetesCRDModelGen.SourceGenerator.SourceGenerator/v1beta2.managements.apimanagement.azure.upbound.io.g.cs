#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.upbound.io;
/// <summary>Management is the Schema for the Managements API. Manages an API Management Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ManagementList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Management>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ManagementList";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "managements";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagementList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Management objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Management> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecDeletionPolicyEnum>))]
public enum V1beta2ManagementSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelector
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
    public V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfiguration
{
    /// <summary>The id of the subnet that will be used for the API Management.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderAdditionalLocation
{
    /// <summary>The number of compute units in this region. Defaults to the capacity of the main region.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>Only valid for an Api Management service deployed in multiple locations. This can be used to disable the gateway in this additional location.</summary>
    [JsonPropertyName("gatewayDisabled")]
    public bool? GatewayDisabled { get; set; }

    /// <summary>The name of the Azure Region in which the API Management Service should be expanded to.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ID of a standard SKU IPv4 Public IP.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1beta2ManagementSpecForProviderAdditionalLocationVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>A list of availability zones.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>The password for the certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderCertificateCertificatePasswordSecretRef
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

/// <summary>The Base64 Encoded PFX or Base64 Encoded X.509 Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderCertificateEncodedCertificateSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderCertificate
{
    /// <summary>The password for the certificate.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta2ManagementSpecForProviderCertificateCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded PFX or Base64 Encoded X.509 Certificate.</summary>
    [JsonPropertyName("encodedCertificateSecretRef")]
    public V1beta2ManagementSpecForProviderCertificateEncodedCertificateSecretRef? EncodedCertificateSecretRef { get; set; }

    /// <summary>The name of the Certificate Store where this certificate should be stored. Possible values are CertificateAuthority and Root.</summary>
    [JsonPropertyName("storeName")]
    public string? StoreName { get; set; }
}

/// <summary>A base64-encoded validation key to validate, that a request is coming from Azure API Management.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderDelegationValidationKeySecretRef
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

/// <summary>A delegation block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderDelegation
{
    /// <summary>Should subscription requests be delegated to an external url? Defaults to false.</summary>
    [JsonPropertyName("subscriptionsEnabled")]
    public bool? SubscriptionsEnabled { get; set; }

    /// <summary>The delegation URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Should user registration requests be delegated to an external url? Defaults to false.</summary>
    [JsonPropertyName("userRegistrationEnabled")]
    public bool? UserRegistrationEnabled { get; set; }

    /// <summary>A base64-encoded validation key to validate, that a request is coming from Azure API Management.</summary>
    [JsonPropertyName("validationKeySecretRef")]
    public V1beta2ManagementSpecForProviderDelegationValidationKeySecretRef? ValidationKeySecretRef { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this API Management Service.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this API Management Service. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A protocols block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderProtocols
{
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary>Should HTTP/2 be supported by the API Management Service? Defaults to false.</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2ManagementSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2ManagementSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagementSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagementSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagementSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagementSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2ManagementSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagementSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagementSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderResourceGroupNameSelector
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
    public V1beta2ManagementSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A security block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderSecurity
{
    /// <summary>Should SSL 3.0 be enabled on the backend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("backendSsl30Enabled")]
    public bool? BackendSsl30Enabled { get; set; }

    /// <summary>Should TLS 1.0 be enabled on the backend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("backendTls10Enabled")]
    public bool? BackendTls10Enabled { get; set; }

    /// <summary>Should TLS 1.1 be enabled on the backend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("backendTls11Enabled")]
    public bool? BackendTls11Enabled { get; set; }

    [JsonPropertyName("enableBackendSsl30")]
    public bool? EnableBackendSsl30 { get; set; }

    [JsonPropertyName("enableBackendTls10")]
    public bool? EnableBackendTls10 { get; set; }

    [JsonPropertyName("enableBackendTls11")]
    public bool? EnableBackendTls11 { get; set; }

    [JsonPropertyName("enableFrontendSsl30")]
    public bool? EnableFrontendSsl30 { get; set; }

    [JsonPropertyName("enableFrontendTls10")]
    public bool? EnableFrontendTls10 { get; set; }

    [JsonPropertyName("enableFrontendTls11")]
    public bool? EnableFrontendTls11 { get; set; }

    /// <summary>Should SSL 3.0 be enabled on the frontend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("frontendSsl30Enabled")]
    public bool? FrontendSsl30Enabled { get; set; }

    /// <summary>Should TLS 1.0 be enabled on the frontend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("frontendTls10Enabled")]
    public bool? FrontendTls10Enabled { get; set; }

    /// <summary>Should TLS 1.1 be enabled on the frontend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("frontendTls11Enabled")]
    public bool? FrontendTls11Enabled { get; set; }

    /// <summary>Should the TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheEcdsaWithAes128CbcShaCiphersEnabled")]
    public bool? TlsEcdheEcdsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheEcdsaWithAes256CbcShaCiphersEnabled")]
    public bool? TlsEcdheEcdsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheRsaWithAes128CbcShaCiphersEnabled")]
    public bool? TlsEcdheRsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheRsaWithAes256CbcShaCiphersEnabled")]
    public bool? TlsEcdheRsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_128_CBC_SHA256 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes128CbcSha256CiphersEnabled")]
    public bool? TlsRsaWithAes128CbcSha256CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_128_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes128CbcShaCiphersEnabled")]
    public bool? TlsRsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_128_GCM_SHA256 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes128GcmSha256CiphersEnabled")]
    public bool? TlsRsaWithAes128GcmSha256CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_256_CBC_SHA256 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes256CbcSha256CiphersEnabled")]
    public bool? TlsRsaWithAes256CbcSha256CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_256_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes256CbcShaCiphersEnabled")]
    public bool? TlsRsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_256_GCM_SHA384 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes256GcmSha384CiphersEnabled")]
    public bool? TlsRsaWithAes256GcmSha384CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_3DES_EDE_CBC_SHA cipher be enabled for alL TLS versions (1.0, 1.1 and 1.2)?</summary>
    [JsonPropertyName("tripleDesCiphersEnabled")]
    public bool? TripleDesCiphersEnabled { get; set; }
}

/// <summary>A sign_in block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderSignIn
{
    /// <summary>Should anonymous users be redirected to the sign in page?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>A terms_of_service block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderSignUpTermsOfService
{
    /// <summary>Should the user be asked for consent during sign up?</summary>
    [JsonPropertyName("consentRequired")]
    public bool? ConsentRequired { get; set; }

    /// <summary>Should Terms of Service be displayed during sign up?.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Terms of Service which users are required to agree to in order to sign up.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>A sign_up block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderSignUp
{
    /// <summary>Can users sign up on the development portal?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A terms_of_service block as defined below.</summary>
    [JsonPropertyName("termsOfService")]
    public V1beta2ManagementSpecForProviderSignUpTermsOfService? TermsOfService { get; set; }
}

/// <summary>A tenant_access block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderTenantAccess
{
    /// <summary>Should the access to the management API be enabled?</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdSelector
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
    public V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProviderVirtualNetworkConfiguration
{
    /// <summary>The id of the subnet that will be used for the API Management.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2ManagementSpecForProviderVirtualNetworkConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecForProvider
{
    /// <summary>One or more additional_location blocks as defined below.</summary>
    [JsonPropertyName("additionalLocation")]
    public IList<V1beta2ManagementSpecForProviderAdditionalLocation>? AdditionalLocation { get; set; }

    /// <summary>One or more certificate blocks (up to 10) as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta2ManagementSpecForProviderCertificate>? Certificate { get; set; }

    /// <summary>Enforce a client certificate to be presented on each request to the gateway? This is only supported when SKU type is Consumption.</summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>A delegation block as defined below.</summary>
    [JsonPropertyName("delegation")]
    public V1beta2ManagementSpecForProviderDelegation? Delegation { get; set; }

    /// <summary>Disable the gateway in main region? This is only supported when additional_location is set.</summary>
    [JsonPropertyName("gatewayDisabled")]
    public bool? GatewayDisabled { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2ManagementSpecForProviderIdentity? Identity { get; set; }

    /// <summary>The Azure location where the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The version which the control plane API calls to API Management service are limited with version equal to or newer than.</summary>
    [JsonPropertyName("minApiVersion")]
    public string? MinApiVersion { get; set; }

    /// <summary>Email address from which the notification will be sent.</summary>
    [JsonPropertyName("notificationSenderEmail")]
    public string? NotificationSenderEmail { get; set; }

    /// <summary>A protocols block as defined below.</summary>
    [JsonPropertyName("protocols")]
    public V1beta2ManagementSpecForProviderProtocols? Protocols { get; set; }

    /// <summary>ID of a standard SKU IPv4 Public IP.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>Is public access to the service allowed? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The email of publisher/company.</summary>
    [JsonPropertyName("publisherEmail")]
    public string? PublisherEmail { get; set; }

    /// <summary>The name of publisher/company.</summary>
    [JsonPropertyName("publisherName")]
    public string? PublisherName { get; set; }

    /// <summary>The name of the Resource Group in which the API Management Service should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2ManagementSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2ManagementSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A security block as defined below.</summary>
    [JsonPropertyName("security")]
    public V1beta2ManagementSpecForProviderSecurity? Security { get; set; }

    /// <summary>A sign_in block as defined below.</summary>
    [JsonPropertyName("signIn")]
    public V1beta2ManagementSpecForProviderSignIn? SignIn { get; set; }

    /// <summary>A sign_up block as defined below.</summary>
    [JsonPropertyName("signUp")]
    public V1beta2ManagementSpecForProviderSignUp? SignUp { get; set; }

    /// <summary>sku_name is a string consisting of two parts separated by an underscore(_). The first part is the name, valid values include: Consumption, Developer, Basic, BasicV2, Standard, StandardV2, Premium and PremiumV2. The second part is the capacity (e.g. the number of deployed units of the sku), which must be a positive integer (e.g. Developer_1).</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A mapping of tags assigned to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A tenant_access block as defined below.</summary>
    [JsonPropertyName("tenantAccess")]
    public V1beta2ManagementSpecForProviderTenantAccess? TenantAccess { get; set; }

    /// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1beta2ManagementSpecForProviderVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>The type of virtual network you want to use, valid values include: None, External, Internal. Defaults to None.</summary>
    [JsonPropertyName("virtualNetworkType")]
    public string? VirtualNetworkType { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this API Management service should be located.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelector
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
    public V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfiguration
{
    /// <summary>The id of the subnet that will be used for the API Management.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderAdditionalLocation
{
    /// <summary>The number of compute units in this region. Defaults to the capacity of the main region.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>Only valid for an Api Management service deployed in multiple locations. This can be used to disable the gateway in this additional location.</summary>
    [JsonPropertyName("gatewayDisabled")]
    public bool? GatewayDisabled { get; set; }

    /// <summary>The name of the Azure Region in which the API Management Service should be expanded to.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ID of a standard SKU IPv4 Public IP.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1beta2ManagementSpecInitProviderAdditionalLocationVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>A list of availability zones.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>The password for the certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderCertificateCertificatePasswordSecretRef
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

/// <summary>The Base64 Encoded PFX or Base64 Encoded X.509 Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderCertificateEncodedCertificateSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderCertificate
{
    /// <summary>The password for the certificate.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta2ManagementSpecInitProviderCertificateCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded PFX or Base64 Encoded X.509 Certificate.</summary>
    [JsonPropertyName("encodedCertificateSecretRef")]
    public required V1beta2ManagementSpecInitProviderCertificateEncodedCertificateSecretRef EncodedCertificateSecretRef { get; set; }

    /// <summary>The name of the Certificate Store where this certificate should be stored. Possible values are CertificateAuthority and Root.</summary>
    [JsonPropertyName("storeName")]
    public string? StoreName { get; set; }
}

/// <summary>A base64-encoded validation key to validate, that a request is coming from Azure API Management.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderDelegationValidationKeySecretRef
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

/// <summary>A delegation block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderDelegation
{
    /// <summary>Should subscription requests be delegated to an external url? Defaults to false.</summary>
    [JsonPropertyName("subscriptionsEnabled")]
    public bool? SubscriptionsEnabled { get; set; }

    /// <summary>The delegation URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Should user registration requests be delegated to an external url? Defaults to false.</summary>
    [JsonPropertyName("userRegistrationEnabled")]
    public bool? UserRegistrationEnabled { get; set; }

    /// <summary>A base64-encoded validation key to validate, that a request is coming from Azure API Management.</summary>
    [JsonPropertyName("validationKeySecretRef")]
    public V1beta2ManagementSpecInitProviderDelegationValidationKeySecretRef? ValidationKeySecretRef { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this API Management Service.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this API Management Service. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A protocols block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderProtocols
{
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary>Should HTTP/2 be supported by the API Management Service? Defaults to false.</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }
}

/// <summary>A security block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderSecurity
{
    /// <summary>Should SSL 3.0 be enabled on the backend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("backendSsl30Enabled")]
    public bool? BackendSsl30Enabled { get; set; }

    /// <summary>Should TLS 1.0 be enabled on the backend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("backendTls10Enabled")]
    public bool? BackendTls10Enabled { get; set; }

    /// <summary>Should TLS 1.1 be enabled on the backend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("backendTls11Enabled")]
    public bool? BackendTls11Enabled { get; set; }

    [JsonPropertyName("enableBackendSsl30")]
    public bool? EnableBackendSsl30 { get; set; }

    [JsonPropertyName("enableBackendTls10")]
    public bool? EnableBackendTls10 { get; set; }

    [JsonPropertyName("enableBackendTls11")]
    public bool? EnableBackendTls11 { get; set; }

    [JsonPropertyName("enableFrontendSsl30")]
    public bool? EnableFrontendSsl30 { get; set; }

    [JsonPropertyName("enableFrontendTls10")]
    public bool? EnableFrontendTls10 { get; set; }

    [JsonPropertyName("enableFrontendTls11")]
    public bool? EnableFrontendTls11 { get; set; }

    /// <summary>Should SSL 3.0 be enabled on the frontend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("frontendSsl30Enabled")]
    public bool? FrontendSsl30Enabled { get; set; }

    /// <summary>Should TLS 1.0 be enabled on the frontend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("frontendTls10Enabled")]
    public bool? FrontendTls10Enabled { get; set; }

    /// <summary>Should TLS 1.1 be enabled on the frontend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("frontendTls11Enabled")]
    public bool? FrontendTls11Enabled { get; set; }

    /// <summary>Should the TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheEcdsaWithAes128CbcShaCiphersEnabled")]
    public bool? TlsEcdheEcdsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheEcdsaWithAes256CbcShaCiphersEnabled")]
    public bool? TlsEcdheEcdsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheRsaWithAes128CbcShaCiphersEnabled")]
    public bool? TlsEcdheRsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheRsaWithAes256CbcShaCiphersEnabled")]
    public bool? TlsEcdheRsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_128_CBC_SHA256 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes128CbcSha256CiphersEnabled")]
    public bool? TlsRsaWithAes128CbcSha256CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_128_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes128CbcShaCiphersEnabled")]
    public bool? TlsRsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_128_GCM_SHA256 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes128GcmSha256CiphersEnabled")]
    public bool? TlsRsaWithAes128GcmSha256CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_256_CBC_SHA256 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes256CbcSha256CiphersEnabled")]
    public bool? TlsRsaWithAes256CbcSha256CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_256_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes256CbcShaCiphersEnabled")]
    public bool? TlsRsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_256_GCM_SHA384 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes256GcmSha384CiphersEnabled")]
    public bool? TlsRsaWithAes256GcmSha384CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_3DES_EDE_CBC_SHA cipher be enabled for alL TLS versions (1.0, 1.1 and 1.2)?</summary>
    [JsonPropertyName("tripleDesCiphersEnabled")]
    public bool? TripleDesCiphersEnabled { get; set; }
}

/// <summary>A sign_in block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderSignIn
{
    /// <summary>Should anonymous users be redirected to the sign in page?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>A terms_of_service block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderSignUpTermsOfService
{
    /// <summary>Should the user be asked for consent during sign up?</summary>
    [JsonPropertyName("consentRequired")]
    public bool? ConsentRequired { get; set; }

    /// <summary>Should Terms of Service be displayed during sign up?.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Terms of Service which users are required to agree to in order to sign up.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>A sign_up block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderSignUp
{
    /// <summary>Can users sign up on the development portal?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A terms_of_service block as defined below.</summary>
    [JsonPropertyName("termsOfService")]
    public V1beta2ManagementSpecInitProviderSignUpTermsOfService? TermsOfService { get; set; }
}

/// <summary>A tenant_access block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderTenantAccess
{
    /// <summary>Should the access to the management API be enabled?</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdSelector
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
    public V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecInitProviderVirtualNetworkConfiguration
{
    /// <summary>The id of the subnet that will be used for the API Management.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2ManagementSpecInitProviderVirtualNetworkConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
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
public partial class V1beta2ManagementSpecInitProvider
{
    /// <summary>One or more additional_location blocks as defined below.</summary>
    [JsonPropertyName("additionalLocation")]
    public IList<V1beta2ManagementSpecInitProviderAdditionalLocation>? AdditionalLocation { get; set; }

    /// <summary>One or more certificate blocks (up to 10) as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta2ManagementSpecInitProviderCertificate>? Certificate { get; set; }

    /// <summary>Enforce a client certificate to be presented on each request to the gateway? This is only supported when SKU type is Consumption.</summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>A delegation block as defined below.</summary>
    [JsonPropertyName("delegation")]
    public V1beta2ManagementSpecInitProviderDelegation? Delegation { get; set; }

    /// <summary>Disable the gateway in main region? This is only supported when additional_location is set.</summary>
    [JsonPropertyName("gatewayDisabled")]
    public bool? GatewayDisabled { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2ManagementSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>The Azure location where the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The version which the control plane API calls to API Management service are limited with version equal to or newer than.</summary>
    [JsonPropertyName("minApiVersion")]
    public string? MinApiVersion { get; set; }

    /// <summary>Email address from which the notification will be sent.</summary>
    [JsonPropertyName("notificationSenderEmail")]
    public string? NotificationSenderEmail { get; set; }

    /// <summary>A protocols block as defined below.</summary>
    [JsonPropertyName("protocols")]
    public V1beta2ManagementSpecInitProviderProtocols? Protocols { get; set; }

    /// <summary>ID of a standard SKU IPv4 Public IP.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>Is public access to the service allowed? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The email of publisher/company.</summary>
    [JsonPropertyName("publisherEmail")]
    public string? PublisherEmail { get; set; }

    /// <summary>The name of publisher/company.</summary>
    [JsonPropertyName("publisherName")]
    public string? PublisherName { get; set; }

    /// <summary>A security block as defined below.</summary>
    [JsonPropertyName("security")]
    public V1beta2ManagementSpecInitProviderSecurity? Security { get; set; }

    /// <summary>A sign_in block as defined below.</summary>
    [JsonPropertyName("signIn")]
    public V1beta2ManagementSpecInitProviderSignIn? SignIn { get; set; }

    /// <summary>A sign_up block as defined below.</summary>
    [JsonPropertyName("signUp")]
    public V1beta2ManagementSpecInitProviderSignUp? SignUp { get; set; }

    /// <summary>sku_name is a string consisting of two parts separated by an underscore(_). The first part is the name, valid values include: Consumption, Developer, Basic, BasicV2, Standard, StandardV2, Premium and PremiumV2. The second part is the capacity (e.g. the number of deployed units of the sku), which must be a positive integer (e.g. Developer_1).</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A mapping of tags assigned to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A tenant_access block as defined below.</summary>
    [JsonPropertyName("tenantAccess")]
    public V1beta2ManagementSpecInitProviderTenantAccess? TenantAccess { get; set; }

    /// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1beta2ManagementSpecInitProviderVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>The type of virtual network you want to use, valid values include: None, External, Internal. Defaults to None.</summary>
    [JsonPropertyName("virtualNetworkType")]
    public string? VirtualNetworkType { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this API Management service should be located.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecManagementPoliciesEnum>))]
public enum V1beta2ManagementSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ManagementSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagementSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ManagementSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagementSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagementSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagementSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ManagementSpec defines the desired state of Management</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementSpec
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
    public V1beta2ManagementSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ManagementSpecForProvider ForProvider { get; set; }

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
    public V1beta2ManagementSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ManagementSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ManagementSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ManagementSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProviderAdditionalLocationVirtualNetworkConfiguration
{
    /// <summary>The id of the subnet that will be used for the API Management.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProviderAdditionalLocation
{
    /// <summary>The number of compute units in this region. Defaults to the capacity of the main region.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>Only valid for an Api Management service deployed in multiple locations. This can be used to disable the gateway in this additional location.</summary>
    [JsonPropertyName("gatewayDisabled")]
    public bool? GatewayDisabled { get; set; }

    /// <summary>The URL of the Regional Gateway for the API Management Service in the specified region.</summary>
    [JsonPropertyName("gatewayRegionalUrl")]
    public string? GatewayRegionalUrl { get; set; }

    /// <summary>The name of the Azure Region in which the API Management Service should be expanded to.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The Private IP addresses of the API Management Service. Available only when the API Manager instance is using Virtual Network mode.</summary>
    [JsonPropertyName("privateIpAddresses")]
    public IList<string>? PrivateIpAddresses { get; set; }

    /// <summary>ID of a standard SKU IPv4 Public IP.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>Public Static Load Balanced IP addresses of the API Management service in the additional location. Available only for Basic, Standard and Premium SKU.</summary>
    [JsonPropertyName("publicIpAddresses")]
    public IList<string>? PublicIpAddresses { get; set; }

    /// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1beta2ManagementStatusAtProviderAdditionalLocationVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>A list of availability zones.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProviderCertificate
{
    /// <summary>The expiration date of the certificate in RFC3339 format: 2000-01-02T03:04:05Z.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The name of the Certificate Store where this certificate should be stored. Possible values are CertificateAuthority and Root.</summary>
    [JsonPropertyName("storeName")]
    public string? StoreName { get; set; }

    /// <summary>The subject of the certificate.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>A delegation block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProviderDelegation
{
    /// <summary>Should subscription requests be delegated to an external url? Defaults to false.</summary>
    [JsonPropertyName("subscriptionsEnabled")]
    public bool? SubscriptionsEnabled { get; set; }

    /// <summary>The delegation URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Should user registration requests be delegated to an external url? Defaults to false.</summary>
    [JsonPropertyName("userRegistrationEnabled")]
    public bool? UserRegistrationEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProviderHostnameConfigurationDeveloperPortal
{
    /// <summary>The source of the certificate.</summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary>The status of the certificate.</summary>
    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary>The expiration date of the certificate in RFC3339 format: 2000-01-02T03:04:05Z.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the Management API.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Service.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    /// <summary>The subject of the certificate.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProviderHostnameConfigurationManagement
{
    /// <summary>The source of the certificate.</summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary>The status of the certificate.</summary>
    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary>The expiration date of the certificate in RFC3339 format: 2000-01-02T03:04:05Z.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the Management API.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Service.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    /// <summary>The subject of the certificate.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProviderHostnameConfigurationPortal
{
    /// <summary>The source of the certificate.</summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary>The status of the certificate.</summary>
    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary>The expiration date of the certificate in RFC3339 format: 2000-01-02T03:04:05Z.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the Management API.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Service.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    /// <summary>The subject of the certificate.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProviderHostnameConfigurationProxy
{
    /// <summary>The source of the certificate.</summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary>The status of the certificate.</summary>
    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary>Is the certificate associated with this Hostname the Default SSL Certificate? This is used when an SNI header isn&apos;t specified by a client. Defaults to false.</summary>
    [JsonPropertyName("defaultSslBinding")]
    public bool? DefaultSslBinding { get; set; }

    /// <summary>The expiration date of the certificate in RFC3339 format: 2000-01-02T03:04:05Z.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the Management API.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Service.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    /// <summary>The subject of the certificate.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProviderHostnameConfigurationScm
{
    /// <summary>The source of the certificate.</summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary>The status of the certificate.</summary>
    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary>The expiration date of the certificate in RFC3339 format: 2000-01-02T03:04:05Z.</summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the Management API.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Service.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the keyVault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    /// <summary>The subject of the certificate.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>A hostname_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProviderHostnameConfiguration
{
    /// <summary>One or more developer_portal blocks as documented below.</summary>
    [JsonPropertyName("developerPortal")]
    public IList<V1beta2ManagementStatusAtProviderHostnameConfigurationDeveloperPortal>? DeveloperPortal { get; set; }

    /// <summary>One or more management blocks as documented below.</summary>
    [JsonPropertyName("management")]
    public IList<V1beta2ManagementStatusAtProviderHostnameConfigurationManagement>? Management { get; set; }

    /// <summary>One or more portal blocks as documented below.</summary>
    [JsonPropertyName("portal")]
    public IList<V1beta2ManagementStatusAtProviderHostnameConfigurationPortal>? Portal { get; set; }

    /// <summary>One or more proxy blocks as documented below.</summary>
    [JsonPropertyName("proxy")]
    public IList<V1beta2ManagementStatusAtProviderHostnameConfigurationProxy>? Proxy { get; set; }

    /// <summary>One or more scm blocks as documented below.</summary>
    [JsonPropertyName("scm")]
    public IList<V1beta2ManagementStatusAtProviderHostnameConfigurationScm>? Scm { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this API Management Service.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this API Management Service. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A protocols block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProviderProtocols
{
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary>Should HTTP/2 be supported by the API Management Service? Defaults to false.</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }
}

/// <summary>A security block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProviderSecurity
{
    /// <summary>Should SSL 3.0 be enabled on the backend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("backendSsl30Enabled")]
    public bool? BackendSsl30Enabled { get; set; }

    /// <summary>Should TLS 1.0 be enabled on the backend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("backendTls10Enabled")]
    public bool? BackendTls10Enabled { get; set; }

    /// <summary>Should TLS 1.1 be enabled on the backend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("backendTls11Enabled")]
    public bool? BackendTls11Enabled { get; set; }

    [JsonPropertyName("enableBackendSsl30")]
    public bool? EnableBackendSsl30 { get; set; }

    [JsonPropertyName("enableBackendTls10")]
    public bool? EnableBackendTls10 { get; set; }

    [JsonPropertyName("enableBackendTls11")]
    public bool? EnableBackendTls11 { get; set; }

    [JsonPropertyName("enableFrontendSsl30")]
    public bool? EnableFrontendSsl30 { get; set; }

    [JsonPropertyName("enableFrontendTls10")]
    public bool? EnableFrontendTls10 { get; set; }

    [JsonPropertyName("enableFrontendTls11")]
    public bool? EnableFrontendTls11 { get; set; }

    /// <summary>Should SSL 3.0 be enabled on the frontend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("frontendSsl30Enabled")]
    public bool? FrontendSsl30Enabled { get; set; }

    /// <summary>Should TLS 1.0 be enabled on the frontend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("frontendTls10Enabled")]
    public bool? FrontendTls10Enabled { get; set; }

    /// <summary>Should TLS 1.1 be enabled on the frontend of the gateway? Defaults to false.</summary>
    [JsonPropertyName("frontendTls11Enabled")]
    public bool? FrontendTls11Enabled { get; set; }

    /// <summary>Should the TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheEcdsaWithAes128CbcShaCiphersEnabled")]
    public bool? TlsEcdheEcdsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheEcdsaWithAes256CbcShaCiphersEnabled")]
    public bool? TlsEcdheEcdsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheRsaWithAes128CbcShaCiphersEnabled")]
    public bool? TlsEcdheRsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsEcdheRsaWithAes256CbcShaCiphersEnabled")]
    public bool? TlsEcdheRsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_128_CBC_SHA256 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes128CbcSha256CiphersEnabled")]
    public bool? TlsRsaWithAes128CbcSha256CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_128_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes128CbcShaCiphersEnabled")]
    public bool? TlsRsaWithAes128CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_128_GCM_SHA256 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes128GcmSha256CiphersEnabled")]
    public bool? TlsRsaWithAes128GcmSha256CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_256_CBC_SHA256 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes256CbcSha256CiphersEnabled")]
    public bool? TlsRsaWithAes256CbcSha256CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_256_CBC_SHA cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes256CbcShaCiphersEnabled")]
    public bool? TlsRsaWithAes256CbcShaCiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_AES_256_GCM_SHA384 cipher be enabled? Defaults to false.</summary>
    [JsonPropertyName("tlsRsaWithAes256GcmSha384CiphersEnabled")]
    public bool? TlsRsaWithAes256GcmSha384CiphersEnabled { get; set; }

    /// <summary>Should the TLS_RSA_WITH_3DES_EDE_CBC_SHA cipher be enabled for alL TLS versions (1.0, 1.1 and 1.2)?</summary>
    [JsonPropertyName("tripleDesCiphersEnabled")]
    public bool? TripleDesCiphersEnabled { get; set; }
}

/// <summary>A sign_in block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProviderSignIn
{
    /// <summary>Should anonymous users be redirected to the sign in page?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>A terms_of_service block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProviderSignUpTermsOfService
{
    /// <summary>Should the user be asked for consent during sign up?</summary>
    [JsonPropertyName("consentRequired")]
    public bool? ConsentRequired { get; set; }

    /// <summary>Should Terms of Service be displayed during sign up?.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Terms of Service which users are required to agree to in order to sign up.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>A sign_up block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProviderSignUp
{
    /// <summary>Can users sign up on the development portal?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A terms_of_service block as defined below.</summary>
    [JsonPropertyName("termsOfService")]
    public V1beta2ManagementStatusAtProviderSignUpTermsOfService? TermsOfService { get; set; }
}

/// <summary>A tenant_access block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProviderTenantAccess
{
    /// <summary>Should the access to the management API be enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The identifier for the tenant access information contract.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProviderVirtualNetworkConfiguration
{
    /// <summary>The id of the subnet that will be used for the API Management.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusAtProvider
{
    /// <summary>One or more additional_location blocks as defined below.</summary>
    [JsonPropertyName("additionalLocation")]
    public IList<V1beta2ManagementStatusAtProviderAdditionalLocation>? AdditionalLocation { get; set; }

    /// <summary>One or more certificate blocks (up to 10) as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta2ManagementStatusAtProviderCertificate>? Certificate { get; set; }

    /// <summary>Enforce a client certificate to be presented on each request to the gateway? This is only supported when SKU type is Consumption.</summary>
    [JsonPropertyName("clientCertificateEnabled")]
    public bool? ClientCertificateEnabled { get; set; }

    /// <summary>A delegation block as defined below.</summary>
    [JsonPropertyName("delegation")]
    public V1beta2ManagementStatusAtProviderDelegation? Delegation { get; set; }

    /// <summary>The URL for the Developer Portal associated with this API Management service.</summary>
    [JsonPropertyName("developerPortalUrl")]
    public string? DeveloperPortalUrl { get; set; }

    /// <summary>Disable the gateway in main region? This is only supported when additional_location is set.</summary>
    [JsonPropertyName("gatewayDisabled")]
    public bool? GatewayDisabled { get; set; }

    /// <summary>The Region URL for the Gateway of the API Management Service.</summary>
    [JsonPropertyName("gatewayRegionalUrl")]
    public string? GatewayRegionalUrl { get; set; }

    /// <summary>The URL of the Gateway for the API Management Service.</summary>
    [JsonPropertyName("gatewayUrl")]
    public string? GatewayUrl { get; set; }

    /// <summary>A hostname_configuration block as defined below.</summary>
    [JsonPropertyName("hostnameConfiguration")]
    public V1beta2ManagementStatusAtProviderHostnameConfiguration? HostnameConfiguration { get; set; }

    /// <summary>The ID of the API Management Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2ManagementStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>The Azure location where the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The URL for the Management API associated with this API Management service.</summary>
    [JsonPropertyName("managementApiUrl")]
    public string? ManagementApiUrl { get; set; }

    /// <summary>The version which the control plane API calls to API Management service are limited with version equal to or newer than.</summary>
    [JsonPropertyName("minApiVersion")]
    public string? MinApiVersion { get; set; }

    /// <summary>Email address from which the notification will be sent.</summary>
    [JsonPropertyName("notificationSenderEmail")]
    public string? NotificationSenderEmail { get; set; }

    /// <summary>The URL for the Publisher Portal associated with this API Management service.</summary>
    [JsonPropertyName("portalUrl")]
    public string? PortalUrl { get; set; }

    /// <summary>The Private IP addresses of the API Management Service.</summary>
    [JsonPropertyName("privateIpAddresses")]
    public IList<string>? PrivateIpAddresses { get; set; }

    /// <summary>A protocols block as defined below.</summary>
    [JsonPropertyName("protocols")]
    public V1beta2ManagementStatusAtProviderProtocols? Protocols { get; set; }

    /// <summary>ID of a standard SKU IPv4 Public IP.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>The Public IP addresses of the API Management Service.</summary>
    [JsonPropertyName("publicIpAddresses")]
    public IList<string>? PublicIpAddresses { get; set; }

    /// <summary>Is public access to the service allowed? Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The email of publisher/company.</summary>
    [JsonPropertyName("publisherEmail")]
    public string? PublisherEmail { get; set; }

    /// <summary>The name of publisher/company.</summary>
    [JsonPropertyName("publisherName")]
    public string? PublisherName { get; set; }

    /// <summary>The name of the Resource Group in which the API Management Service should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The URL for the SCM (Source Code Management) Endpoint associated with this API Management service.</summary>
    [JsonPropertyName("scmUrl")]
    public string? ScmUrl { get; set; }

    /// <summary>A security block as defined below.</summary>
    [JsonPropertyName("security")]
    public V1beta2ManagementStatusAtProviderSecurity? Security { get; set; }

    /// <summary>A sign_in block as defined below.</summary>
    [JsonPropertyName("signIn")]
    public V1beta2ManagementStatusAtProviderSignIn? SignIn { get; set; }

    /// <summary>A sign_up block as defined below.</summary>
    [JsonPropertyName("signUp")]
    public V1beta2ManagementStatusAtProviderSignUp? SignUp { get; set; }

    /// <summary>sku_name is a string consisting of two parts separated by an underscore(_). The first part is the name, valid values include: Consumption, Developer, Basic, BasicV2, Standard, StandardV2, Premium and PremiumV2. The second part is the capacity (e.g. the number of deployed units of the sku), which must be a positive integer (e.g. Developer_1).</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A mapping of tags assigned to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A tenant_access block as defined below.</summary>
    [JsonPropertyName("tenantAccess")]
    public V1beta2ManagementStatusAtProviderTenantAccess? TenantAccess { get; set; }

    /// <summary>A virtual_network_configuration block as defined below. Required when virtual_network_type is External or Internal.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1beta2ManagementStatusAtProviderVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>The type of virtual network you want to use, valid values include: None, External, Internal. Defaults to None.</summary>
    [JsonPropertyName("virtualNetworkType")]
    public string? VirtualNetworkType { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this API Management service should be located.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatusConditions
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

/// <summary>ManagementStatus defines the observed state of Management.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagementStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ManagementStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ManagementStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Management is the Schema for the Managements API. Manages an API Management Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Management : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ManagementSpec>, IStatus<V1beta2ManagementStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Management";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "managements";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Management";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagementSpec defines the desired state of Management</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ManagementSpec Spec { get; set; }

    /// <summary>ManagementStatus defines the observed state of Management.</summary>
    [JsonPropertyName("status")]
    public V1beta2ManagementStatus? Status { get; set; }
}
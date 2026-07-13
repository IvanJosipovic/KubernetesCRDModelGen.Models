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
/// <summary>VPNServerConfiguration is the Schema for the VPNServerConfigurations API. Manages a VPN Server Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2VPNServerConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta2VPNServerConfiguration>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "VPNServerConfigurationList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "vpnserverconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VPNServerConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2VPNServerConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2VPNServerConfiguration> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VPNServerConfigurationSpecDeletionPolicyEnum>))]
public enum V1beta2VPNServerConfigurationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecForProviderAzureActiveDirectoryAuthentication
{
    /// <summary>The Audience which should be used for authentication.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>The Issuer which should be used for authentication.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The Tenant which should be used for authentication.</summary>
    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecForProviderClientRevokedCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecForProviderClientRootCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Public Key Data associated with the Certificate.</summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary>A ipsec_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecForProviderIpsecPolicy
{
    /// <summary>The DH Group, used in IKE Phase 1. Possible values include DHGroup1, DHGroup2, DHGroup14, DHGroup24, DHGroup2048, ECP256, ECP384 and None.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>The IKE encryption algorithm, used for IKE Phase 2. Possible values include AES128, AES192, AES256, DES, DES3, GCMAES128 and GCMAES256.</summary>
    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    /// <summary>The IKE encryption integrity algorithm, used for IKE Phase 2. Possible values include GCMAES128, GCMAES256, MD5, SHA1, SHA256 and SHA384.</summary>
    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    /// <summary>The IPSec encryption algorithm, used for IKE phase 1. Possible values include AES128, AES192, AES256, DES, DES3, GCMAES128, GCMAES192, GCMAES256 and None.</summary>
    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    /// <summary>The IPSec integrity algorithm, used for IKE phase 1. Possible values include GCMAES128, GCMAES192, GCMAES256, MD5, SHA1 and SHA256.</summary>
    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    /// <summary>The Pfs Group, used in IKE Phase 2. Possible values include ECP256, ECP384, PFS1, PFS2, PFS14, PFS24, PFS2048, PFSMM and None.</summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>The IPSec Security Association payload size in KB for a Site-to-Site VPN tunnel.</summary>
    [JsonPropertyName("saDataSizeKilobytes")]
    public double? SaDataSizeKilobytes { get; set; }

    /// <summary>The IPSec Security Association lifetime in seconds for a Site-to-Site VPN tunnel.</summary>
    [JsonPropertyName("saLifetimeSeconds")]
    public double? SaLifetimeSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecForProviderRadiusClientRootCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>The Secret used to communicate with the Radius Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecForProviderRadiusServerSecretSecretRef
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
public partial class V1beta2VPNServerConfigurationSpecForProviderRadiusServer
{
    /// <summary>The Address of the Radius Server.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The Score of the Radius Server determines the priority of the server. Ranges from 1 to 30.</summary>
    [JsonPropertyName("score")]
    public double? Score { get; set; }

    /// <summary>The Secret used to communicate with the Radius Server.</summary>
    [JsonPropertyName("secretSecretRef")]
    public V1beta2VPNServerConfigurationSpecForProviderRadiusServerSecretSecretRef? SecretSecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecForProviderRadiusServerRootCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Public Key Data associated with the Certificate.</summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary>A radius block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecForProviderRadius
{
    /// <summary>One or more client_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("clientRootCertificate")]
    public IList<V1beta2VPNServerConfigurationSpecForProviderRadiusClientRootCertificate>? ClientRootCertificate { get; set; }

    /// <summary>One or more server blocks as defined below.</summary>
    [JsonPropertyName("server")]
    public IList<V1beta2VPNServerConfigurationSpecForProviderRadiusServer>? Server { get; set; }

    /// <summary>One or more server_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("serverRootCertificate")]
    public IList<V1beta2VPNServerConfigurationSpecForProviderRadiusServerRootCertificate>? ServerRootCertificate { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameSelector
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
    public V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecForProvider
{
    /// <summary>A azure_active_directory_authentication block as defined below.</summary>
    [JsonPropertyName("azureActiveDirectoryAuthentication")]
    public IList<V1beta2VPNServerConfigurationSpecForProviderAzureActiveDirectoryAuthentication>? AzureActiveDirectoryAuthentication { get; set; }

    /// <summary>One or more client_revoked_certificate blocks as defined below.</summary>
    [JsonPropertyName("clientRevokedCertificate")]
    public IList<V1beta2VPNServerConfigurationSpecForProviderClientRevokedCertificate>? ClientRevokedCertificate { get; set; }

    /// <summary>One or more client_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("clientRootCertificate")]
    public IList<V1beta2VPNServerConfigurationSpecForProviderClientRootCertificate>? ClientRootCertificate { get; set; }

    /// <summary>A ipsec_policy block as defined below.</summary>
    [JsonPropertyName("ipsecPolicy")]
    public V1beta2VPNServerConfigurationSpecForProviderIpsecPolicy? IpsecPolicy { get; set; }

    /// <summary>The Azure location where this VPN Server Configuration should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A radius block as defined below.</summary>
    [JsonPropertyName("radius")]
    public V1beta2VPNServerConfigurationSpecForProviderRadius? Radius { get; set; }

    /// <summary>The Name of the Resource Group in which this VPN Server Configuration should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2VPNServerConfigurationSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A list of Authentication Types applicable for this VPN Server Configuration. Possible values are AAD (Azure Active Directory), Certificate and Radius.</summary>
    [JsonPropertyName("vpnAuthenticationTypes")]
    public IList<string>? VpnAuthenticationTypes { get; set; }

    /// <summary>A list of VPN Protocols to use for this Server Configuration. Possible values are IkeV2 and OpenVPN.</summary>
    [JsonPropertyName("vpnProtocols")]
    public IList<string>? VpnProtocols { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecInitProviderAzureActiveDirectoryAuthentication
{
    /// <summary>The Audience which should be used for authentication.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>The Issuer which should be used for authentication.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The Tenant which should be used for authentication.</summary>
    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecInitProviderClientRevokedCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecInitProviderClientRootCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Public Key Data associated with the Certificate.</summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary>A ipsec_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecInitProviderIpsecPolicy
{
    /// <summary>The DH Group, used in IKE Phase 1. Possible values include DHGroup1, DHGroup2, DHGroup14, DHGroup24, DHGroup2048, ECP256, ECP384 and None.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>The IKE encryption algorithm, used for IKE Phase 2. Possible values include AES128, AES192, AES256, DES, DES3, GCMAES128 and GCMAES256.</summary>
    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    /// <summary>The IKE encryption integrity algorithm, used for IKE Phase 2. Possible values include GCMAES128, GCMAES256, MD5, SHA1, SHA256 and SHA384.</summary>
    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    /// <summary>The IPSec encryption algorithm, used for IKE phase 1. Possible values include AES128, AES192, AES256, DES, DES3, GCMAES128, GCMAES192, GCMAES256 and None.</summary>
    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    /// <summary>The IPSec integrity algorithm, used for IKE phase 1. Possible values include GCMAES128, GCMAES192, GCMAES256, MD5, SHA1 and SHA256.</summary>
    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    /// <summary>The Pfs Group, used in IKE Phase 2. Possible values include ECP256, ECP384, PFS1, PFS2, PFS14, PFS24, PFS2048, PFSMM and None.</summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>The IPSec Security Association payload size in KB for a Site-to-Site VPN tunnel.</summary>
    [JsonPropertyName("saDataSizeKilobytes")]
    public double? SaDataSizeKilobytes { get; set; }

    /// <summary>The IPSec Security Association lifetime in seconds for a Site-to-Site VPN tunnel.</summary>
    [JsonPropertyName("saLifetimeSeconds")]
    public double? SaLifetimeSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecInitProviderRadiusClientRootCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>The Secret used to communicate with the Radius Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecInitProviderRadiusServerSecretSecretRef
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
public partial class V1beta2VPNServerConfigurationSpecInitProviderRadiusServer
{
    /// <summary>The Address of the Radius Server.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The Score of the Radius Server determines the priority of the server. Ranges from 1 to 30.</summary>
    [JsonPropertyName("score")]
    public double? Score { get; set; }

    /// <summary>The Secret used to communicate with the Radius Server.</summary>
    [JsonPropertyName("secretSecretRef")]
    public required V1beta2VPNServerConfigurationSpecInitProviderRadiusServerSecretSecretRef SecretSecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecInitProviderRadiusServerRootCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Public Key Data associated with the Certificate.</summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary>A radius block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecInitProviderRadius
{
    /// <summary>One or more client_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("clientRootCertificate")]
    public IList<V1beta2VPNServerConfigurationSpecInitProviderRadiusClientRootCertificate>? ClientRootCertificate { get; set; }

    /// <summary>One or more server blocks as defined below.</summary>
    [JsonPropertyName("server")]
    public IList<V1beta2VPNServerConfigurationSpecInitProviderRadiusServer>? Server { get; set; }

    /// <summary>One or more server_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("serverRootCertificate")]
    public IList<V1beta2VPNServerConfigurationSpecInitProviderRadiusServerRootCertificate>? ServerRootCertificate { get; set; }
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
public partial class V1beta2VPNServerConfigurationSpecInitProvider
{
    /// <summary>A azure_active_directory_authentication block as defined below.</summary>
    [JsonPropertyName("azureActiveDirectoryAuthentication")]
    public IList<V1beta2VPNServerConfigurationSpecInitProviderAzureActiveDirectoryAuthentication>? AzureActiveDirectoryAuthentication { get; set; }

    /// <summary>One or more client_revoked_certificate blocks as defined below.</summary>
    [JsonPropertyName("clientRevokedCertificate")]
    public IList<V1beta2VPNServerConfigurationSpecInitProviderClientRevokedCertificate>? ClientRevokedCertificate { get; set; }

    /// <summary>One or more client_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("clientRootCertificate")]
    public IList<V1beta2VPNServerConfigurationSpecInitProviderClientRootCertificate>? ClientRootCertificate { get; set; }

    /// <summary>A ipsec_policy block as defined below.</summary>
    [JsonPropertyName("ipsecPolicy")]
    public V1beta2VPNServerConfigurationSpecInitProviderIpsecPolicy? IpsecPolicy { get; set; }

    /// <summary>The Azure location where this VPN Server Configuration should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A radius block as defined below.</summary>
    [JsonPropertyName("radius")]
    public V1beta2VPNServerConfigurationSpecInitProviderRadius? Radius { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A list of Authentication Types applicable for this VPN Server Configuration. Possible values are AAD (Azure Active Directory), Certificate and Radius.</summary>
    [JsonPropertyName("vpnAuthenticationTypes")]
    public IList<string>? VpnAuthenticationTypes { get; set; }

    /// <summary>A list of VPN Protocols to use for this Server Configuration. Possible values are IkeV2 and OpenVPN.</summary>
    [JsonPropertyName("vpnProtocols")]
    public IList<string>? VpnProtocols { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VPNServerConfigurationSpecManagementPoliciesEnum>))]
public enum V1beta2VPNServerConfigurationSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VPNServerConfigurationSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2VPNServerConfigurationSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VPNServerConfigurationSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2VPNServerConfigurationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VPNServerConfigurationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VPNServerConfigurationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VPNServerConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>VPNServerConfigurationSpec defines the desired state of VPNServerConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationSpec
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
    public V1beta2VPNServerConfigurationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2VPNServerConfigurationSpecForProvider ForProvider { get; set; }

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
    public V1beta2VPNServerConfigurationSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2VPNServerConfigurationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2VPNServerConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2VPNServerConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationStatusAtProviderAzureActiveDirectoryAuthentication
{
    /// <summary>The Audience which should be used for authentication.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>The Issuer which should be used for authentication.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>The Tenant which should be used for authentication.</summary>
    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationStatusAtProviderClientRevokedCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationStatusAtProviderClientRootCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Public Key Data associated with the Certificate.</summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary>A ipsec_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationStatusAtProviderIpsecPolicy
{
    /// <summary>The DH Group, used in IKE Phase 1. Possible values include DHGroup1, DHGroup2, DHGroup14, DHGroup24, DHGroup2048, ECP256, ECP384 and None.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>The IKE encryption algorithm, used for IKE Phase 2. Possible values include AES128, AES192, AES256, DES, DES3, GCMAES128 and GCMAES256.</summary>
    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    /// <summary>The IKE encryption integrity algorithm, used for IKE Phase 2. Possible values include GCMAES128, GCMAES256, MD5, SHA1, SHA256 and SHA384.</summary>
    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    /// <summary>The IPSec encryption algorithm, used for IKE phase 1. Possible values include AES128, AES192, AES256, DES, DES3, GCMAES128, GCMAES192, GCMAES256 and None.</summary>
    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    /// <summary>The IPSec integrity algorithm, used for IKE phase 1. Possible values include GCMAES128, GCMAES192, GCMAES256, MD5, SHA1 and SHA256.</summary>
    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    /// <summary>The Pfs Group, used in IKE Phase 2. Possible values include ECP256, ECP384, PFS1, PFS2, PFS14, PFS24, PFS2048, PFSMM and None.</summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>The IPSec Security Association payload size in KB for a Site-to-Site VPN tunnel.</summary>
    [JsonPropertyName("saDataSizeKilobytes")]
    public double? SaDataSizeKilobytes { get; set; }

    /// <summary>The IPSec Security Association lifetime in seconds for a Site-to-Site VPN tunnel.</summary>
    [JsonPropertyName("saLifetimeSeconds")]
    public double? SaLifetimeSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationStatusAtProviderRadiusClientRootCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Thumbprint of the Certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationStatusAtProviderRadiusServer
{
    /// <summary>The Address of the Radius Server.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The Score of the Radius Server determines the priority of the server. Ranges from 1 to 30.</summary>
    [JsonPropertyName("score")]
    public double? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationStatusAtProviderRadiusServerRootCertificate
{
    /// <summary>A name used to uniquely identify this certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Public Key Data associated with the Certificate.</summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary>A radius block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationStatusAtProviderRadius
{
    /// <summary>One or more client_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("clientRootCertificate")]
    public IList<V1beta2VPNServerConfigurationStatusAtProviderRadiusClientRootCertificate>? ClientRootCertificate { get; set; }

    /// <summary>One or more server blocks as defined below.</summary>
    [JsonPropertyName("server")]
    public IList<V1beta2VPNServerConfigurationStatusAtProviderRadiusServer>? Server { get; set; }

    /// <summary>One or more server_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("serverRootCertificate")]
    public IList<V1beta2VPNServerConfigurationStatusAtProviderRadiusServerRootCertificate>? ServerRootCertificate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationStatusAtProvider
{
    /// <summary>A azure_active_directory_authentication block as defined below.</summary>
    [JsonPropertyName("azureActiveDirectoryAuthentication")]
    public IList<V1beta2VPNServerConfigurationStatusAtProviderAzureActiveDirectoryAuthentication>? AzureActiveDirectoryAuthentication { get; set; }

    /// <summary>One or more client_revoked_certificate blocks as defined below.</summary>
    [JsonPropertyName("clientRevokedCertificate")]
    public IList<V1beta2VPNServerConfigurationStatusAtProviderClientRevokedCertificate>? ClientRevokedCertificate { get; set; }

    /// <summary>One or more client_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("clientRootCertificate")]
    public IList<V1beta2VPNServerConfigurationStatusAtProviderClientRootCertificate>? ClientRootCertificate { get; set; }

    /// <summary>The ID of the VPN Server Configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A ipsec_policy block as defined below.</summary>
    [JsonPropertyName("ipsecPolicy")]
    public V1beta2VPNServerConfigurationStatusAtProviderIpsecPolicy? IpsecPolicy { get; set; }

    /// <summary>The Azure location where this VPN Server Configuration should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A radius block as defined below.</summary>
    [JsonPropertyName("radius")]
    public V1beta2VPNServerConfigurationStatusAtProviderRadius? Radius { get; set; }

    /// <summary>The Name of the Resource Group in which this VPN Server Configuration should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A list of Authentication Types applicable for this VPN Server Configuration. Possible values are AAD (Azure Active Directory), Certificate and Radius.</summary>
    [JsonPropertyName("vpnAuthenticationTypes")]
    public IList<string>? VpnAuthenticationTypes { get; set; }

    /// <summary>A list of VPN Protocols to use for this Server Configuration. Possible values are IkeV2 and OpenVPN.</summary>
    [JsonPropertyName("vpnProtocols")]
    public IList<string>? VpnProtocols { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationStatusConditions
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

/// <summary>VPNServerConfigurationStatus defines the observed state of VPNServerConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VPNServerConfigurationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2VPNServerConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2VPNServerConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VPNServerConfiguration is the Schema for the VPNServerConfigurations API. Manages a VPN Server Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2VPNServerConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2VPNServerConfigurationSpec>, IStatus<V1beta2VPNServerConfigurationStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "VPNServerConfiguration";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "vpnserverconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VPNServerConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VPNServerConfigurationSpec defines the desired state of VPNServerConfiguration</summary>
    [JsonPropertyName("spec")]
    public required V1beta2VPNServerConfigurationSpec Spec { get; set; }

    /// <summary>VPNServerConfigurationStatus defines the observed state of VPNServerConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta2VPNServerConfigurationStatus? Status { get; set; }
}
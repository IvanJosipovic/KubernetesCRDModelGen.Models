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
/// <summary>FrontdoorCustomHTTPSConfiguration is the Schema for the FrontdoorCustomHTTPSConfigurations API. Manages the Custom Https Configuration for an Azure Front Door (classic) Frontend Endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta2FrontdoorCustomHTTPSConfiguration>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FrontdoorCustomHTTPSConfigurationList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "frontdoorcustomhttpsconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FrontdoorCustomHTTPSConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2FrontdoorCustomHTTPSConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2FrontdoorCustomHTTPSConfiguration> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorCustomHTTPSConfigurationSpecDeletionPolicyEnum>))]
public enum V1beta2FrontdoorCustomHTTPSConfigurationSpecDeletionPolicyEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in keyvault to populate azureKeyVaultCertificateVaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in keyvault to populate azureKeyVaultCertificateVaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelector
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
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A custom_https_configuration block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfiguration
{
    /// <summary>The name of the Key Vault secret representing the full certificate PFX.</summary>
    [JsonPropertyName("azureKeyVaultCertificateSecretName")]
    public string? AzureKeyVaultCertificateSecretName { get; set; }

    /// <summary>The version of the Key Vault secret representing the full certificate PFX.</summary>
    [JsonPropertyName("azureKeyVaultCertificateSecretVersion")]
    public string? AzureKeyVaultCertificateSecretVersion { get; set; }

    /// <summary>The ID of the Key Vault containing the SSL certificate.</summary>
    [JsonPropertyName("azureKeyVaultCertificateVaultId")]
    public string? AzureKeyVaultCertificateVaultId { get; set; }

    /// <summary>Reference to a Key in keyvault to populate azureKeyVaultCertificateVaultId.</summary>
    [JsonPropertyName("azureKeyVaultCertificateVaultIdRef")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRef? AzureKeyVaultCertificateVaultIdRef { get; set; }

    /// <summary>Selector for a Key in keyvault to populate azureKeyVaultCertificateVaultId.</summary>
    [JsonPropertyName("azureKeyVaultCertificateVaultIdSelector")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelector? AzureKeyVaultCertificateVaultIdSelector { get; set; }

    /// <summary>Certificate source to encrypted HTTPS traffic with. Allowed values are FrontDoor or AzureKeyVault. Defaults to FrontDoor.</summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationSpecForProvider
{
    /// <summary>A custom_https_configuration block as defined above.</summary>
    [JsonPropertyName("customHttpsConfiguration")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecForProviderCustomHttpsConfiguration? CustomHttpsConfiguration { get; set; }

    /// <summary>Should the HTTPS protocol be enabled for this custom domain associated with the Front Door?</summary>
    [JsonPropertyName("customHttpsProvisioningEnabled")]
    public bool? CustomHttpsProvisioningEnabled { get; set; }

    /// <summary>The ID of the Front Door Frontend Endpoint which this configuration refers to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("frontendEndpointId")]
    public string? FrontendEndpointId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in keyvault to populate azureKeyVaultCertificateVaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolutionEnum>))]
public enum V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolveEnum>))]
public enum V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in keyvault to populate azureKeyVaultCertificateVaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelector
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
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A custom_https_configuration block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfiguration
{
    /// <summary>The name of the Key Vault secret representing the full certificate PFX.</summary>
    [JsonPropertyName("azureKeyVaultCertificateSecretName")]
    public string? AzureKeyVaultCertificateSecretName { get; set; }

    /// <summary>The version of the Key Vault secret representing the full certificate PFX.</summary>
    [JsonPropertyName("azureKeyVaultCertificateSecretVersion")]
    public string? AzureKeyVaultCertificateSecretVersion { get; set; }

    /// <summary>The ID of the Key Vault containing the SSL certificate.</summary>
    [JsonPropertyName("azureKeyVaultCertificateVaultId")]
    public string? AzureKeyVaultCertificateVaultId { get; set; }

    /// <summary>Reference to a Key in keyvault to populate azureKeyVaultCertificateVaultId.</summary>
    [JsonPropertyName("azureKeyVaultCertificateVaultIdRef")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdRef? AzureKeyVaultCertificateVaultIdRef { get; set; }

    /// <summary>Selector for a Key in keyvault to populate azureKeyVaultCertificateVaultId.</summary>
    [JsonPropertyName("azureKeyVaultCertificateVaultIdSelector")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfigurationAzureKeyVaultCertificateVaultIdSelector? AzureKeyVaultCertificateVaultIdSelector { get; set; }

    /// <summary>Certificate source to encrypted HTTPS traffic with. Allowed values are FrontDoor or AzureKeyVault. Defaults to FrontDoor.</summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }
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
public partial class V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProvider
{
    /// <summary>A custom_https_configuration block as defined above.</summary>
    [JsonPropertyName("customHttpsConfiguration")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProviderCustomHttpsConfiguration? CustomHttpsConfiguration { get; set; }

    /// <summary>Should the HTTPS protocol be enabled for this custom domain associated with the Front Door?</summary>
    [JsonPropertyName("customHttpsProvisioningEnabled")]
    public bool? CustomHttpsProvisioningEnabled { get; set; }

    /// <summary>The ID of the Front Door Frontend Endpoint which this configuration refers to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("frontendEndpointId")]
    public string? FrontendEndpointId { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorCustomHTTPSConfigurationSpecManagementPoliciesEnum>))]
public enum V1beta2FrontdoorCustomHTTPSConfigurationSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorCustomHTTPSConfigurationSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2FrontdoorCustomHTTPSConfigurationSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FrontdoorCustomHTTPSConfigurationSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2FrontdoorCustomHTTPSConfigurationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>FrontdoorCustomHTTPSConfigurationSpec defines the desired state of FrontdoorCustomHTTPSConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationSpec
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
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2FrontdoorCustomHTTPSConfigurationSpecForProvider ForProvider { get; set; }

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
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2FrontdoorCustomHTTPSConfigurationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2FrontdoorCustomHTTPSConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A custom_https_configuration block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationStatusAtProviderCustomHttpsConfiguration
{
    /// <summary>The name of the Key Vault secret representing the full certificate PFX.</summary>
    [JsonPropertyName("azureKeyVaultCertificateSecretName")]
    public string? AzureKeyVaultCertificateSecretName { get; set; }

    /// <summary>The version of the Key Vault secret representing the full certificate PFX.</summary>
    [JsonPropertyName("azureKeyVaultCertificateSecretVersion")]
    public string? AzureKeyVaultCertificateSecretVersion { get; set; }

    /// <summary>The ID of the Key Vault containing the SSL certificate.</summary>
    [JsonPropertyName("azureKeyVaultCertificateVaultId")]
    public string? AzureKeyVaultCertificateVaultId { get; set; }

    /// <summary>Certificate source to encrypted HTTPS traffic with. Allowed values are FrontDoor or AzureKeyVault. Defaults to FrontDoor.</summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary>Minimum client TLS version supported.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("provisioningSubstate")]
    public string? ProvisioningSubstate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationStatusAtProvider
{
    /// <summary>A custom_https_configuration block as defined above.</summary>
    [JsonPropertyName("customHttpsConfiguration")]
    public V1beta2FrontdoorCustomHTTPSConfigurationStatusAtProviderCustomHttpsConfiguration? CustomHttpsConfiguration { get; set; }

    /// <summary>Should the HTTPS protocol be enabled for this custom domain associated with the Front Door?</summary>
    [JsonPropertyName("customHttpsProvisioningEnabled")]
    public bool? CustomHttpsProvisioningEnabled { get; set; }

    /// <summary>The ID of the Front Door Frontend Endpoint which this configuration refers to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("frontendEndpointId")]
    public string? FrontendEndpointId { get; set; }

    /// <summary>The ID of the Azure Front Door Custom HTTPS Configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationStatusConditions
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

/// <summary>FrontdoorCustomHTTPSConfigurationStatus defines the observed state of FrontdoorCustomHTTPSConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FrontdoorCustomHTTPSConfigurationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2FrontdoorCustomHTTPSConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2FrontdoorCustomHTTPSConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FrontdoorCustomHTTPSConfiguration is the Schema for the FrontdoorCustomHTTPSConfigurations API. Manages the Custom Https Configuration for an Azure Front Door (classic) Frontend Endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FrontdoorCustomHTTPSConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2FrontdoorCustomHTTPSConfigurationSpec>, IStatus<V1beta2FrontdoorCustomHTTPSConfigurationStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FrontdoorCustomHTTPSConfiguration";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "frontdoorcustomhttpsconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FrontdoorCustomHTTPSConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FrontdoorCustomHTTPSConfigurationSpec defines the desired state of FrontdoorCustomHTTPSConfiguration</summary>
    [JsonPropertyName("spec")]
    public required V1beta2FrontdoorCustomHTTPSConfigurationSpec Spec { get; set; }

    /// <summary>FrontdoorCustomHTTPSConfigurationStatus defines the observed state of FrontdoorCustomHTTPSConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta2FrontdoorCustomHTTPSConfigurationStatus? Status { get; set; }
}
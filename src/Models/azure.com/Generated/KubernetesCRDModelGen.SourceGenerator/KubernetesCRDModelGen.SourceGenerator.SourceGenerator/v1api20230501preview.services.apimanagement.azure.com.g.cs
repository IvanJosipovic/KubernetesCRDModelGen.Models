#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/preview/2023-05-01-preview/apimdeployment.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230501previewServiceList : IKubernetesObject<V1ListMeta>, IItems<V1api20230501previewService>
{
    public const string KubeApiVersion = "v1api20230501preview";
    public const string KubeKind = "ServiceList";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "services";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v1api20230501preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20230501previewService objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20230501previewService> Items { get; set; }
}

/// <summary>NatGatewayState: Property can be used to enable NAT Gateway for this API Management service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501previewServiceSpecAdditionalLocationsNatGatewayStateEnum>))]
public enum V1api20230501previewServiceSpecAdditionalLocationsNatGatewayStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// PublicIpAddressReference: Public Standard SKU IP V4 based IP address to be associated with Virtual Network deployed
/// service in the location. Supported only for Premium SKU being deployed in Virtual Network.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecAdditionalLocationsPublicIpAddressReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Name: Name of the Sku.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501previewServiceSpecAdditionalLocationsSkuNameEnum>))]
public enum V1api20230501previewServiceSpecAdditionalLocationsSkuNameEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "BasicV2"), JsonStringEnumMemberName("BasicV2")]
    BasicV2,
    [EnumMember(Value = "Consumption"), JsonStringEnumMemberName("Consumption")]
    Consumption,
    [EnumMember(Value = "Developer"), JsonStringEnumMemberName("Developer")]
    Developer,
    [EnumMember(Value = "Isolated"), JsonStringEnumMemberName("Isolated")]
    Isolated,
    [EnumMember(Value = "Premium"), JsonStringEnumMemberName("Premium")]
    Premium,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard,
    [EnumMember(Value = "StandardV2"), JsonStringEnumMemberName("StandardV2")]
    StandardV2
}

/// <summary>Sku: SKU properties of the API Management service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecAdditionalLocationsSku
{
    /// <summary>Capacity: Capacity of the SKU (number of deployed units of the SKU). For Consumption SKU capacity must be specified as 0.</summary>
    [JsonPropertyName("capacity")]
    public required int Capacity { get; set; }

    /// <summary>Name: Name of the Sku.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501previewServiceSpecAdditionalLocationsSkuNameEnum Name { get; set; }
}

/// <summary>SubnetResourceReference: The full resource ID of a subnet in a virtual network to deploy the API Management service in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecAdditionalLocationsVirtualNetworkConfigurationSubnetResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>VirtualNetworkConfiguration: Virtual network configuration for the location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecAdditionalLocationsVirtualNetworkConfiguration
{
    /// <summary>SubnetResourceReference: The full resource ID of a subnet in a virtual network to deploy the API Management service in.</summary>
    [JsonPropertyName("subnetResourceReference")]
    public V1api20230501previewServiceSpecAdditionalLocationsVirtualNetworkConfigurationSubnetResourceReference? SubnetResourceReference { get; set; }
}

/// <summary>Description of an additional API Management resource location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecAdditionalLocations
{
    /// <summary>
    /// DisableGateway: Property only valid for an Api Management service deployed in multiple locations. This can be used to
    /// disable the gateway in this additional location.
    /// </summary>
    [JsonPropertyName("disableGateway")]
    public bool? DisableGateway { get; set; }

    /// <summary>Location: The location name of the additional region among Azure Data center regions.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>NatGatewayState: Property can be used to enable NAT Gateway for this API Management service.</summary>
    [JsonPropertyName("natGatewayState")]
    public V1api20230501previewServiceSpecAdditionalLocationsNatGatewayStateEnum? NatGatewayState { get; set; }

    /// <summary>
    /// PublicIpAddressReference: Public Standard SKU IP V4 based IP address to be associated with Virtual Network deployed
    /// service in the location. Supported only for Premium SKU being deployed in Virtual Network.
    /// </summary>
    [JsonPropertyName("publicIpAddressReference")]
    public V1api20230501previewServiceSpecAdditionalLocationsPublicIpAddressReference? PublicIpAddressReference { get; set; }

    /// <summary>Sku: SKU properties of the API Management service.</summary>
    [JsonPropertyName("sku")]
    public required V1api20230501previewServiceSpecAdditionalLocationsSku Sku { get; set; }

    /// <summary>VirtualNetworkConfiguration: Virtual network configuration for the location.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1api20230501previewServiceSpecAdditionalLocationsVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>Zones: A list of availability zones denoting where the resource needs to come from.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>ApiVersionConstraint: Control Plane Apis version constraint for the API Management service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecApiVersionConstraint
{
    /// <summary>MinApiVersion: Limit control plane API calls to API Management service with version equal to or newer than this value.</summary>
    [JsonPropertyName("minApiVersion")]
    public string? MinApiVersion { get; set; }
}

/// <summary>
/// ExpiryFromConfig: Expiration date of the certificate. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ`
/// as specified by the ISO 8601 standard.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecCertificatesCertificateExpiryFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>SubjectFromConfig: Subject of the certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecCertificatesCertificateSubjectFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ThumbprintFromConfig: Thumbprint of the certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecCertificatesCertificateThumbprintFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Certificate: Certificate information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecCertificatesCertificate
{
    /// <summary>
    /// Expiry: Expiration date of the certificate. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as
    /// specified by the ISO 8601 standard.
    /// </summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>
    /// ExpiryFromConfig: Expiration date of the certificate. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ`
    /// as specified by the ISO 8601 standard.
    /// </summary>
    [JsonPropertyName("expiryFromConfig")]
    public V1api20230501previewServiceSpecCertificatesCertificateExpiryFromConfig? ExpiryFromConfig { get; set; }

    /// <summary>Subject: Subject of the certificate.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>SubjectFromConfig: Subject of the certificate.</summary>
    [JsonPropertyName("subjectFromConfig")]
    public V1api20230501previewServiceSpecCertificatesCertificateSubjectFromConfig? SubjectFromConfig { get; set; }

    /// <summary>Thumbprint: Thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>ThumbprintFromConfig: Thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprintFromConfig")]
    public V1api20230501previewServiceSpecCertificatesCertificateThumbprintFromConfig? ThumbprintFromConfig { get; set; }
}

/// <summary>CertificatePassword: Certificate Password.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecCertificatesCertificatePassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// StoreName: The System.Security.Cryptography.x509certificates.StoreName certificate store location. Only Root and
/// CertificateAuthority are valid locations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501previewServiceSpecCertificatesStoreNameEnum>))]
public enum V1api20230501previewServiceSpecCertificatesStoreNameEnum
{
    [EnumMember(Value = "CertificateAuthority"), JsonStringEnumMemberName("CertificateAuthority")]
    CertificateAuthority,
    [EnumMember(Value = "Root"), JsonStringEnumMemberName("Root")]
    Root
}

/// <summary>Certificate configuration which consist of non-trusted intermediates and root certificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecCertificates
{
    /// <summary>Certificate: Certificate information.</summary>
    [JsonPropertyName("certificate")]
    public V1api20230501previewServiceSpecCertificatesCertificate? Certificate { get; set; }

    /// <summary>CertificatePassword: Certificate Password.</summary>
    [JsonPropertyName("certificatePassword")]
    public V1api20230501previewServiceSpecCertificatesCertificatePassword? CertificatePassword { get; set; }

    /// <summary>EncodedCertificate: Base64 Encoded certificate.</summary>
    [JsonPropertyName("encodedCertificate")]
    public string? EncodedCertificate { get; set; }

    /// <summary>
    /// StoreName: The System.Security.Cryptography.x509certificates.StoreName certificate store location. Only Root and
    /// CertificateAuthority are valid locations.
    /// </summary>
    [JsonPropertyName("storeName")]
    public required V1api20230501previewServiceSpecCertificatesStoreNameEnum StoreName { get; set; }
}

/// <summary>
/// LegacyApi: Indication whether or not the legacy Configuration API (v1) should be exposed on the API Management service.
/// Value is optional but must be &apos;Enabled&apos; or &apos;Disabled&apos;. If &apos;Disabled&apos;, legacy Configuration API (v1) will not be
/// available for self-hosted gateways. Default value is &apos;Enabled&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501previewServiceSpecConfigurationApiLegacyApiEnum>))]
public enum V1api20230501previewServiceSpecConfigurationApiLegacyApiEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>ConfigurationApi: Configuration API configuration of the API Management service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecConfigurationApi
{
    /// <summary>
    /// LegacyApi: Indication whether or not the legacy Configuration API (v1) should be exposed on the API Management service.
    /// Value is optional but must be &apos;Enabled&apos; or &apos;Disabled&apos;. If &apos;Disabled&apos;, legacy Configuration API (v1) will not be
    /// available for self-hosted gateways. Default value is &apos;Enabled&apos;
    /// </summary>
    [JsonPropertyName("legacyApi")]
    public V1api20230501previewServiceSpecConfigurationApiLegacyApiEnum? LegacyApi { get; set; }
}

/// <summary>DeveloperPortalStatus: Status of developer portal in this API Management service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501previewServiceSpecDeveloperPortalStatusEnum>))]
public enum V1api20230501previewServiceSpecDeveloperPortalStatusEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// ExpiryFromConfig: Expiration date of the certificate. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ`
/// as specified by the ISO 8601 standard.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecHostnameConfigurationsCertificateExpiryFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>SubjectFromConfig: Subject of the certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecHostnameConfigurationsCertificateSubjectFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ThumbprintFromConfig: Thumbprint of the certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecHostnameConfigurationsCertificateThumbprintFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Certificate: Certificate information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecHostnameConfigurationsCertificate
{
    /// <summary>
    /// Expiry: Expiration date of the certificate. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as
    /// specified by the ISO 8601 standard.
    /// </summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>
    /// ExpiryFromConfig: Expiration date of the certificate. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ`
    /// as specified by the ISO 8601 standard.
    /// </summary>
    [JsonPropertyName("expiryFromConfig")]
    public V1api20230501previewServiceSpecHostnameConfigurationsCertificateExpiryFromConfig? ExpiryFromConfig { get; set; }

    /// <summary>Subject: Subject of the certificate.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>SubjectFromConfig: Subject of the certificate.</summary>
    [JsonPropertyName("subjectFromConfig")]
    public V1api20230501previewServiceSpecHostnameConfigurationsCertificateSubjectFromConfig? SubjectFromConfig { get; set; }

    /// <summary>Thumbprint: Thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }

    /// <summary>ThumbprintFromConfig: Thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprintFromConfig")]
    public V1api20230501previewServiceSpecHostnameConfigurationsCertificateThumbprintFromConfig? ThumbprintFromConfig { get; set; }
}

/// <summary>CertificatePassword: Certificate Password.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecHostnameConfigurationsCertificatePassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>CertificateSource: Certificate Source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501previewServiceSpecHostnameConfigurationsCertificateSourceEnum>))]
public enum V1api20230501previewServiceSpecHostnameConfigurationsCertificateSourceEnum
{
    [EnumMember(Value = "BuiltIn"), JsonStringEnumMemberName("BuiltIn")]
    BuiltIn,
    [EnumMember(Value = "Custom"), JsonStringEnumMemberName("Custom")]
    Custom,
    [EnumMember(Value = "KeyVault"), JsonStringEnumMemberName("KeyVault")]
    KeyVault,
    [EnumMember(Value = "Managed"), JsonStringEnumMemberName("Managed")]
    Managed
}

/// <summary>CertificateStatus: Certificate Status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501previewServiceSpecHostnameConfigurationsCertificateStatusEnum>))]
public enum V1api20230501previewServiceSpecHostnameConfigurationsCertificateStatusEnum
{
    [EnumMember(Value = "Completed"), JsonStringEnumMemberName("Completed")]
    Completed,
    [EnumMember(Value = "Failed"), JsonStringEnumMemberName("Failed")]
    Failed,
    [EnumMember(Value = "InProgress"), JsonStringEnumMemberName("InProgress")]
    InProgress
}

/// <summary>
/// IdentityClientIdFromConfig: System or User Assigned Managed identity clientId as generated by Azure AD, which has GET
/// access to the keyVault containing the SSL certificate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecHostnameConfigurationsIdentityClientIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Type: Hostname type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501previewServiceSpecHostnameConfigurationsTypeEnum>))]
public enum V1api20230501previewServiceSpecHostnameConfigurationsTypeEnum
{
    [EnumMember(Value = "ConfigurationApi"), JsonStringEnumMemberName("ConfigurationApi")]
    ConfigurationApi,
    [EnumMember(Value = "DeveloperPortal"), JsonStringEnumMemberName("DeveloperPortal")]
    DeveloperPortal,
    [EnumMember(Value = "Management"), JsonStringEnumMemberName("Management")]
    Management,
    [EnumMember(Value = "Portal"), JsonStringEnumMemberName("Portal")]
    Portal,
    [EnumMember(Value = "Proxy"), JsonStringEnumMemberName("Proxy")]
    Proxy,
    [EnumMember(Value = "Scm"), JsonStringEnumMemberName("Scm")]
    Scm
}

/// <summary>Custom hostname configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecHostnameConfigurations
{
    /// <summary>Certificate: Certificate information.</summary>
    [JsonPropertyName("certificate")]
    public V1api20230501previewServiceSpecHostnameConfigurationsCertificate? Certificate { get; set; }

    /// <summary>CertificatePassword: Certificate Password.</summary>
    [JsonPropertyName("certificatePassword")]
    public V1api20230501previewServiceSpecHostnameConfigurationsCertificatePassword? CertificatePassword { get; set; }

    /// <summary>CertificateSource: Certificate Source.</summary>
    [JsonPropertyName("certificateSource")]
    public V1api20230501previewServiceSpecHostnameConfigurationsCertificateSourceEnum? CertificateSource { get; set; }

    /// <summary>CertificateStatus: Certificate Status.</summary>
    [JsonPropertyName("certificateStatus")]
    public V1api20230501previewServiceSpecHostnameConfigurationsCertificateStatusEnum? CertificateStatus { get; set; }

    /// <summary>
    /// DefaultSslBinding: Specify true to setup the certificate associated with this Hostname as the Default SSL Certificate.
    /// If a client does not send the SNI header, then this will be the certificate that will be challenged. The property is
    /// useful if a service has multiple custom hostname enabled and it needs to decide on the default ssl certificate. The
    /// setting only applied to gateway Hostname Type.
    /// </summary>
    [JsonPropertyName("defaultSslBinding")]
    public bool? DefaultSslBinding { get; set; }

    /// <summary>EncodedCertificate: Base64 Encoded certificate.</summary>
    [JsonPropertyName("encodedCertificate")]
    public string? EncodedCertificate { get; set; }

    /// <summary>HostName: Hostname to configure on the Api Management service.</summary>
    [JsonPropertyName("hostName")]
    public required string HostName { get; set; }

    /// <summary>
    /// IdentityClientId: System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to
    /// the keyVault containing the SSL certificate.
    /// </summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary>
    /// IdentityClientIdFromConfig: System or User Assigned Managed identity clientId as generated by Azure AD, which has GET
    /// access to the keyVault containing the SSL certificate.
    /// </summary>
    [JsonPropertyName("identityClientIdFromConfig")]
    public V1api20230501previewServiceSpecHostnameConfigurationsIdentityClientIdFromConfig? IdentityClientIdFromConfig { get; set; }

    /// <summary>
    /// KeyVaultId: Url to the KeyVault Secret containing the Ssl Certificate. If absolute Url containing version is provided,
    /// auto-update of ssl certificate will not work. This requires Api Management service to be configured with aka.ms/apimmsi.
    /// The secret should be of type *application/x-pkcs12*
    /// </summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>NegotiateClientCertificate: Specify true to always negotiate client certificate on the hostname. Default Value is false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>Type: Hostname type.</summary>
    [JsonPropertyName("type")]
    public required V1api20230501previewServiceSpecHostnameConfigurationsTypeEnum Type { get; set; }
}

/// <summary>
/// Type: The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly
/// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501previewServiceSpecIdentityTypeEnum>))]
public enum V1api20230501previewServiceSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned, UserAssigned"), JsonStringEnumMemberName("SystemAssigned, UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecIdentityUserAssignedIdentitiesReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20230501previewServiceSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: Managed service identity of the Api Management service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecIdentity
{
    /// <summary>
    /// Type: The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly
    /// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the service.
    /// </summary>
    [JsonPropertyName("type")]
    public required V1api20230501previewServiceSpecIdentityTypeEnum Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the resource. The user identity
    /// dictionary key references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/
    /// providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20230501previewServiceSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>LegacyPortalStatus: Status of legacy portal in the API Management service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501previewServiceSpecLegacyPortalStatusEnum>))]
public enum V1api20230501previewServiceSpecLegacyPortalStatusEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>NatGatewayState: Property can be used to enable NAT Gateway for this API Management service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501previewServiceSpecNatGatewayStateEnum>))]
public enum V1api20230501previewServiceSpecNatGatewayStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230501previewServiceSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230501previewServiceSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// PublicIpAddressReference: Public Standard SKU IP V4 based IP address to be associated with Virtual Network deployed
/// service in the region. Supported only for Developer and Premium SKU being deployed in Virtual Network.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecPublicIpAddressReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// PublicNetworkAccess: Whether or not public endpoint access is allowed for this API Management service.  Value is
/// optional but if passed in, must be &apos;Enabled&apos; or &apos;Disabled&apos;. If &apos;Disabled&apos;, private endpoints are the exclusive access
/// method. Default value is &apos;Enabled&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501previewServiceSpecPublicNetworkAccessEnum>))]
public enum V1api20230501previewServiceSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Name: Name of the Sku.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501previewServiceSpecSkuNameEnum>))]
public enum V1api20230501previewServiceSpecSkuNameEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "BasicV2"), JsonStringEnumMemberName("BasicV2")]
    BasicV2,
    [EnumMember(Value = "Consumption"), JsonStringEnumMemberName("Consumption")]
    Consumption,
    [EnumMember(Value = "Developer"), JsonStringEnumMemberName("Developer")]
    Developer,
    [EnumMember(Value = "Isolated"), JsonStringEnumMemberName("Isolated")]
    Isolated,
    [EnumMember(Value = "Premium"), JsonStringEnumMemberName("Premium")]
    Premium,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard,
    [EnumMember(Value = "StandardV2"), JsonStringEnumMemberName("StandardV2")]
    StandardV2
}

/// <summary>Sku: SKU properties of the API Management service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecSku
{
    /// <summary>Capacity: Capacity of the SKU (number of deployed units of the SKU). For Consumption SKU capacity must be specified as 0.</summary>
    [JsonPropertyName("capacity")]
    public required int Capacity { get; set; }

    /// <summary>Name: Name of the Sku.</summary>
    [JsonPropertyName("name")]
    public required V1api20230501previewServiceSpecSkuNameEnum Name { get; set; }
}

/// <summary>SubnetResourceReference: The full resource ID of a subnet in a virtual network to deploy the API Management service in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecVirtualNetworkConfigurationSubnetResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>VirtualNetworkConfiguration: Virtual network configuration of the API Management service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpecVirtualNetworkConfiguration
{
    /// <summary>SubnetResourceReference: The full resource ID of a subnet in a virtual network to deploy the API Management service in.</summary>
    [JsonPropertyName("subnetResourceReference")]
    public V1api20230501previewServiceSpecVirtualNetworkConfigurationSubnetResourceReference? SubnetResourceReference { get; set; }
}

/// <summary>
/// VirtualNetworkType: The type of VPN in which API Management service needs to be configured in. None (Default Value)
/// means the API Management service is not part of any Virtual Network, External means the API Management deployment is set
/// up inside a Virtual Network having an Internet Facing Endpoint, and Internal means that API Management deployment is
/// setup inside a Virtual Network having an Intranet Facing Endpoint only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501previewServiceSpecVirtualNetworkTypeEnum>))]
public enum V1api20230501previewServiceSpecVirtualNetworkTypeEnum
{
    [EnumMember(Value = "External"), JsonStringEnumMemberName("External")]
    External,
    [EnumMember(Value = "Internal"), JsonStringEnumMemberName("Internal")]
    Internal,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceSpec
{
    /// <summary>AdditionalLocations: Additional datacenter locations of the API Management service.</summary>
    [JsonPropertyName("additionalLocations")]
    public IList<V1api20230501previewServiceSpecAdditionalLocations>? AdditionalLocations { get; set; }

    /// <summary>ApiVersionConstraint: Control Plane Apis version constraint for the API Management service.</summary>
    [JsonPropertyName("apiVersionConstraint")]
    public V1api20230501previewServiceSpecApiVersionConstraint? ApiVersionConstraint { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Certificates: List of Certificates that need to be installed in the API Management service. Max supported certificates
    /// that can be installed is 10.
    /// </summary>
    [JsonPropertyName("certificates")]
    public IList<V1api20230501previewServiceSpecCertificates>? Certificates { get; set; }

    /// <summary>ConfigurationApi: Configuration API configuration of the API Management service.</summary>
    [JsonPropertyName("configurationApi")]
    public V1api20230501previewServiceSpecConfigurationApi? ConfigurationApi { get; set; }

    /// <summary>
    /// CustomProperties: Custom properties of the API Management service.&lt;/br&gt;Setting
    /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TripleDes168` will disable the cipher
    /// TLS_RSA_WITH_3DES_EDE_CBC_SHA for all TLS(1.0, 1.1 and 1.2).&lt;/br&gt;Setting
    /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls11` can be used to disable just TLS 1.1.&lt;/br&gt;Setting
    /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls10` can be used to disable TLS 1.0 on an API
    /// Management service.&lt;/br&gt;Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Backend.Protocols.Tls11` can be
    /// used to disable just TLS 1.1 for communications with backends.&lt;/br&gt;Setting
    /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Backend.Protocols.Tls10` can be used to disable TLS 1.0 for
    /// communications with backends.&lt;/br&gt;Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Protocols.Server.Http2` can be
    /// used to enable HTTP2 protocol on an API Management service.&lt;/br&gt;Not specifying any of these properties on PATCH
    /// operation will reset omitted properties&apos; values to their defaults. For all the settings except Http2 the default value
    /// is `True` if the service was created on or before April 1, 2018 and `False` otherwise. Http2 setting&apos;s default value is
    /// `False`.&lt;/br&gt; &lt;/br&gt;You can disable any of the following ciphers by using settings
    /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.[cipher_name]`: TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA,
    /// TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA,
    /// TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA256, TLS_RSA_WITH_AES_128_CBC_SHA256,
    /// TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA. For example,
    /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TLS_RSA_WITH_AES_128_CBC_SHA256`:`false`. The default
    /// value is `true` for them.&lt;/br&gt; Note: The following ciphers can&apos;t be disabled since they are required by internal
    /// platform components:
    /// TLS_AES_256_GCM_SHA384,TLS_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256,TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256
    /// </summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }

    /// <summary>DeveloperPortalStatus: Status of developer portal in this API Management service.</summary>
    [JsonPropertyName("developerPortalStatus")]
    public V1api20230501previewServiceSpecDeveloperPortalStatusEnum? DeveloperPortalStatus { get; set; }

    /// <summary>
    /// DisableGateway: Property only valid for an Api Management service deployed in multiple locations. This can be used to
    /// disable the gateway in master region.
    /// </summary>
    [JsonPropertyName("disableGateway")]
    public bool? DisableGateway { get; set; }

    /// <summary>
    /// EnableClientCertificate: Property only meant to be used for Consumption SKU Service. This enforces a client certificate
    /// to be presented on each request to the gateway. This also enables the ability to authenticate the certificate in the
    /// policy on the gateway.
    /// </summary>
    [JsonPropertyName("enableClientCertificate")]
    public bool? EnableClientCertificate { get; set; }

    /// <summary>HostnameConfigurations: Custom hostname configuration of the API Management service.</summary>
    [JsonPropertyName("hostnameConfigurations")]
    public IList<V1api20230501previewServiceSpecHostnameConfigurations>? HostnameConfigurations { get; set; }

    /// <summary>Identity: Managed service identity of the Api Management service.</summary>
    [JsonPropertyName("identity")]
    public V1api20230501previewServiceSpecIdentity? Identity { get; set; }

    /// <summary>LegacyPortalStatus: Status of legacy portal in the API Management service.</summary>
    [JsonPropertyName("legacyPortalStatus")]
    public V1api20230501previewServiceSpecLegacyPortalStatusEnum? LegacyPortalStatus { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>NatGatewayState: Property can be used to enable NAT Gateway for this API Management service.</summary>
    [JsonPropertyName("natGatewayState")]
    public V1api20230501previewServiceSpecNatGatewayStateEnum? NatGatewayState { get; set; }

    /// <summary>NotificationSenderEmail: Email address from which the notification will be sent.</summary>
    [JsonPropertyName("notificationSenderEmail")]
    public string? NotificationSenderEmail { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230501previewServiceSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20230501previewServiceSpecOwner Owner { get; set; }

    /// <summary>
    /// PublicIpAddressReference: Public Standard SKU IP V4 based IP address to be associated with Virtual Network deployed
    /// service in the region. Supported only for Developer and Premium SKU being deployed in Virtual Network.
    /// </summary>
    [JsonPropertyName("publicIpAddressReference")]
    public V1api20230501previewServiceSpecPublicIpAddressReference? PublicIpAddressReference { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Whether or not public endpoint access is allowed for this API Management service.  Value is
    /// optional but if passed in, must be &apos;Enabled&apos; or &apos;Disabled&apos;. If &apos;Disabled&apos;, private endpoints are the exclusive access
    /// method. Default value is &apos;Enabled&apos;
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20230501previewServiceSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>PublisherEmail: Publisher email.</summary>
    [JsonPropertyName("publisherEmail")]
    public required string PublisherEmail { get; set; }

    /// <summary>PublisherName: Publisher name.</summary>
    [JsonPropertyName("publisherName")]
    public required string PublisherName { get; set; }

    /// <summary>
    /// Restore: Undelete Api Management Service if it was previously soft-deleted. If this flag is specified and set to True
    /// all other properties will be ignored.
    /// </summary>
    [JsonPropertyName("restore")]
    public bool? Restore { get; set; }

    /// <summary>Sku: SKU properties of the API Management service.</summary>
    [JsonPropertyName("sku")]
    public required V1api20230501previewServiceSpecSku Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>VirtualNetworkConfiguration: Virtual network configuration of the API Management service.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1api20230501previewServiceSpecVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>
    /// VirtualNetworkType: The type of VPN in which API Management service needs to be configured in. None (Default Value)
    /// means the API Management service is not part of any Virtual Network, External means the API Management deployment is set
    /// up inside a Virtual Network having an Internet Facing Endpoint, and Internal means that API Management deployment is
    /// setup inside a Virtual Network having an Intranet Facing Endpoint only.
    /// </summary>
    [JsonPropertyName("virtualNetworkType")]
    public V1api20230501previewServiceSpecVirtualNetworkTypeEnum? VirtualNetworkType { get; set; }

    /// <summary>Zones: A list of availability zones denoting where the resource needs to come from.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Sku: SKU properties of the API Management service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatusAdditionalLocationsSku
{
    /// <summary>Capacity: Capacity of the SKU (number of deployed units of the SKU). For Consumption SKU capacity must be specified as 0.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Name: Name of the Sku.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>VirtualNetworkConfiguration: Virtual network configuration for the location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatusAdditionalLocationsVirtualNetworkConfiguration
{
    /// <summary>SubnetResourceId: The full resource ID of a subnet in a virtual network to deploy the API Management service in.</summary>
    [JsonPropertyName("subnetResourceId")]
    public string? SubnetResourceId { get; set; }

    /// <summary>Subnetname: The name of the subnet.</summary>
    [JsonPropertyName("subnetname")]
    public string? Subnetname { get; set; }

    /// <summary>Vnetid: The virtual network ID. This is typically a GUID. Expect a null GUID by default.</summary>
    [JsonPropertyName("vnetid")]
    public string? Vnetid { get; set; }
}

/// <summary>Description of an additional API Management resource location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatusAdditionalLocations
{
    /// <summary>
    /// DisableGateway: Property only valid for an Api Management service deployed in multiple locations. This can be used to
    /// disable the gateway in this additional location.
    /// </summary>
    [JsonPropertyName("disableGateway")]
    public bool? DisableGateway { get; set; }

    /// <summary>GatewayRegionalUrl: Gateway URL of the API Management service in the Region.</summary>
    [JsonPropertyName("gatewayRegionalUrl")]
    public string? GatewayRegionalUrl { get; set; }

    /// <summary>Location: The location name of the additional region among Azure Data center regions.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>NatGatewayState: Property can be used to enable NAT Gateway for this API Management service.</summary>
    [JsonPropertyName("natGatewayState")]
    public string? NatGatewayState { get; set; }

    /// <summary>
    /// OutboundPublicIPAddresses: Outbound public IPV4 address prefixes associated with NAT Gateway deployed service. Available
    /// only for Premium SKU on stv2 platform.
    /// </summary>
    [JsonPropertyName("outboundPublicIPAddresses")]
    public IList<string>? OutboundPublicIPAddresses { get; set; }

    /// <summary>PlatformVersion: Compute Platform Version running the service.</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>
    /// PrivateIPAddresses: Private Static Load Balanced IP addresses of the API Management service which is deployed in an
    /// Internal Virtual Network in a particular additional location. Available only for Basic, Standard, Premium and Isolated
    /// SKU.
    /// </summary>
    [JsonPropertyName("privateIPAddresses")]
    public IList<string>? PrivateIPAddresses { get; set; }

    /// <summary>
    /// PublicIPAddresses: Public Static Load Balanced IP addresses of the API Management service in the additional location.
    /// Available only for Basic, Standard, Premium and Isolated SKU.
    /// </summary>
    [JsonPropertyName("publicIPAddresses")]
    public IList<string>? PublicIPAddresses { get; set; }

    /// <summary>
    /// PublicIpAddressId: Public Standard SKU IP V4 based IP address to be associated with Virtual Network deployed service in
    /// the location. Supported only for Premium SKU being deployed in Virtual Network.
    /// </summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>Sku: SKU properties of the API Management service.</summary>
    [JsonPropertyName("sku")]
    public V1api20230501previewServiceStatusAdditionalLocationsSku? Sku { get; set; }

    /// <summary>VirtualNetworkConfiguration: Virtual network configuration for the location.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1api20230501previewServiceStatusAdditionalLocationsVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>Zones: A list of availability zones denoting where the resource needs to come from.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>ApiVersionConstraint: Control Plane Apis version constraint for the API Management service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatusApiVersionConstraint
{
    /// <summary>MinApiVersion: Limit control plane API calls to API Management service with version equal to or newer than this value.</summary>
    [JsonPropertyName("minApiVersion")]
    public string? MinApiVersion { get; set; }
}

/// <summary>Certificate: Certificate information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatusCertificatesCertificate
{
    /// <summary>
    /// Expiry: Expiration date of the certificate. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as
    /// specified by the ISO 8601 standard.
    /// </summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>Subject: Subject of the certificate.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>Thumbprint: Thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>Certificate configuration which consist of non-trusted intermediates and root certificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatusCertificates
{
    /// <summary>Certificate: Certificate information.</summary>
    [JsonPropertyName("certificate")]
    public V1api20230501previewServiceStatusCertificatesCertificate? Certificate { get; set; }

    /// <summary>EncodedCertificate: Base64 Encoded certificate.</summary>
    [JsonPropertyName("encodedCertificate")]
    public string? EncodedCertificate { get; set; }

    /// <summary>
    /// StoreName: The System.Security.Cryptography.x509certificates.StoreName certificate store location. Only Root and
    /// CertificateAuthority are valid locations.
    /// </summary>
    [JsonPropertyName("storeName")]
    public string? StoreName { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ConfigurationApi: Configuration API configuration of the API Management service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatusConfigurationApi
{
    /// <summary>
    /// LegacyApi: Indication whether or not the legacy Configuration API (v1) should be exposed on the API Management service.
    /// Value is optional but must be &apos;Enabled&apos; or &apos;Disabled&apos;. If &apos;Disabled&apos;, legacy Configuration API (v1) will not be
    /// available for self-hosted gateways. Default value is &apos;Enabled&apos;
    /// </summary>
    [JsonPropertyName("legacyApi")]
    public string? LegacyApi { get; set; }
}

/// <summary>Certificate: Certificate information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatusHostnameConfigurationsCertificate
{
    /// <summary>
    /// Expiry: Expiration date of the certificate. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as
    /// specified by the ISO 8601 standard.
    /// </summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>Subject: Subject of the certificate.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>Thumbprint: Thumbprint of the certificate.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>Custom hostname configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatusHostnameConfigurations
{
    /// <summary>Certificate: Certificate information.</summary>
    [JsonPropertyName("certificate")]
    public V1api20230501previewServiceStatusHostnameConfigurationsCertificate? Certificate { get; set; }

    /// <summary>CertificateSource: Certificate Source.</summary>
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    /// <summary>CertificateStatus: Certificate Status.</summary>
    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary>
    /// DefaultSslBinding: Specify true to setup the certificate associated with this Hostname as the Default SSL Certificate.
    /// If a client does not send the SNI header, then this will be the certificate that will be challenged. The property is
    /// useful if a service has multiple custom hostname enabled and it needs to decide on the default ssl certificate. The
    /// setting only applied to gateway Hostname Type.
    /// </summary>
    [JsonPropertyName("defaultSslBinding")]
    public bool? DefaultSslBinding { get; set; }

    /// <summary>EncodedCertificate: Base64 Encoded certificate.</summary>
    [JsonPropertyName("encodedCertificate")]
    public string? EncodedCertificate { get; set; }

    /// <summary>HostName: Hostname to configure on the Api Management service.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>
    /// IdentityClientId: System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to
    /// the keyVault containing the SSL certificate.
    /// </summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary>
    /// KeyVaultId: Url to the KeyVault Secret containing the Ssl Certificate. If absolute Url containing version is provided,
    /// auto-update of ssl certificate will not work. This requires Api Management service to be configured with aka.ms/apimmsi.
    /// The secret should be of type *application/x-pkcs12*
    /// </summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>NegotiateClientCertificate: Specify true to always negotiate client certificate on the hostname. Default Value is false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>Type: Hostname type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: Managed service identity of the Api Management service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatusIdentity
{
    /// <summary>PrincipalId: The principal id of the identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The client tenant id of the identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// Type: The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly
    /// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the service.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the resource. The user identity
    /// dictionary key references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/
    /// providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20230501previewServiceStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>PrivateEndpoint: The resource of private end point.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatusPrivateEndpointConnectionsPrivateEndpoint
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// PrivateLinkServiceConnectionState: A collection of information about the state of the connection between service
/// consumer and provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatusPrivateEndpointConnectionsPrivateLinkServiceConnectionState
{
    /// <summary>ActionsRequired: A message indicating if changes on the service provider require any updates on the consumer.</summary>
    [JsonPropertyName("actionsRequired")]
    public string? ActionsRequired { get; set; }

    /// <summary>Description: The reason for approval/rejection of the connection.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Status: Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Remote Private Endpoint Connection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatusPrivateEndpointConnections
{
    /// <summary>GroupIds: All the Group ids.</summary>
    [JsonPropertyName("groupIds")]
    public IList<string>? GroupIds { get; set; }

    /// <summary>Id: Private Endpoint connection resource id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: Private Endpoint Connection Name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateEndpoint: The resource of private end point.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1api20230501previewServiceStatusPrivateEndpointConnectionsPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>
    /// PrivateLinkServiceConnectionState: A collection of information about the state of the connection between service
    /// consumer and provider.
    /// </summary>
    [JsonPropertyName("privateLinkServiceConnectionState")]
    public V1api20230501previewServiceStatusPrivateEndpointConnectionsPrivateLinkServiceConnectionState? PrivateLinkServiceConnectionState { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the private endpoint connection resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Type: Private Endpoint Connection Resource Type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Sku: SKU properties of the API Management service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatusSku
{
    /// <summary>Capacity: Capacity of the SKU (number of deployed units of the SKU). For Consumption SKU capacity must be specified as 0.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Name: Name of the Sku.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>VirtualNetworkConfiguration: Virtual network configuration of the API Management service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatusVirtualNetworkConfiguration
{
    /// <summary>SubnetResourceId: The full resource ID of a subnet in a virtual network to deploy the API Management service in.</summary>
    [JsonPropertyName("subnetResourceId")]
    public string? SubnetResourceId { get; set; }

    /// <summary>Subnetname: The name of the subnet.</summary>
    [JsonPropertyName("subnetname")]
    public string? Subnetname { get; set; }

    /// <summary>Vnetid: The virtual network ID. This is typically a GUID. Expect a null GUID by default.</summary>
    [JsonPropertyName("vnetid")]
    public string? Vnetid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501previewServiceStatus
{
    /// <summary>AdditionalLocations: Additional datacenter locations of the API Management service.</summary>
    [JsonPropertyName("additionalLocations")]
    public IList<V1api20230501previewServiceStatusAdditionalLocations>? AdditionalLocations { get; set; }

    /// <summary>ApiVersionConstraint: Control Plane Apis version constraint for the API Management service.</summary>
    [JsonPropertyName("apiVersionConstraint")]
    public V1api20230501previewServiceStatusApiVersionConstraint? ApiVersionConstraint { get; set; }

    /// <summary>
    /// Certificates: List of Certificates that need to be installed in the API Management service. Max supported certificates
    /// that can be installed is 10.
    /// </summary>
    [JsonPropertyName("certificates")]
    public IList<V1api20230501previewServiceStatusCertificates>? Certificates { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230501previewServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ConfigurationApi: Configuration API configuration of the API Management service.</summary>
    [JsonPropertyName("configurationApi")]
    public V1api20230501previewServiceStatusConfigurationApi? ConfigurationApi { get; set; }

    /// <summary>
    /// CreatedAtUtc: Creation UTC date of the API Management service.The date conforms to the following format:
    /// `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
    /// </summary>
    [JsonPropertyName("createdAtUtc")]
    public string? CreatedAtUtc { get; set; }

    /// <summary>
    /// CustomProperties: Custom properties of the API Management service.&lt;/br&gt;Setting
    /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TripleDes168` will disable the cipher
    /// TLS_RSA_WITH_3DES_EDE_CBC_SHA for all TLS(1.0, 1.1 and 1.2).&lt;/br&gt;Setting
    /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls11` can be used to disable just TLS 1.1.&lt;/br&gt;Setting
    /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Protocols.Tls10` can be used to disable TLS 1.0 on an API
    /// Management service.&lt;/br&gt;Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Backend.Protocols.Tls11` can be
    /// used to disable just TLS 1.1 for communications with backends.&lt;/br&gt;Setting
    /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Backend.Protocols.Tls10` can be used to disable TLS 1.0 for
    /// communications with backends.&lt;/br&gt;Setting `Microsoft.WindowsAzure.ApiManagement.Gateway.Protocols.Server.Http2` can be
    /// used to enable HTTP2 protocol on an API Management service.&lt;/br&gt;Not specifying any of these properties on PATCH
    /// operation will reset omitted properties&apos; values to their defaults. For all the settings except Http2 the default value
    /// is `True` if the service was created on or before April 1, 2018 and `False` otherwise. Http2 setting&apos;s default value is
    /// `False`.&lt;/br&gt; &lt;/br&gt;You can disable any of the following ciphers by using settings
    /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.[cipher_name]`: TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA,
    /// TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA,
    /// TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA256, TLS_RSA_WITH_AES_128_CBC_SHA256,
    /// TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA. For example,
    /// `Microsoft.WindowsAzure.ApiManagement.Gateway.Security.Ciphers.TLS_RSA_WITH_AES_128_CBC_SHA256`:`false`. The default
    /// value is `true` for them.&lt;/br&gt; Note: The following ciphers can&apos;t be disabled since they are required by internal
    /// platform components:
    /// TLS_AES_256_GCM_SHA384,TLS_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384,TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256,TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256,TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384,TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256
    /// </summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }

    /// <summary>DeveloperPortalStatus: Status of developer portal in this API Management service.</summary>
    [JsonPropertyName("developerPortalStatus")]
    public string? DeveloperPortalStatus { get; set; }

    /// <summary>DeveloperPortalUrl: DEveloper Portal endpoint URL of the API Management service.</summary>
    [JsonPropertyName("developerPortalUrl")]
    public string? DeveloperPortalUrl { get; set; }

    /// <summary>
    /// DisableGateway: Property only valid for an Api Management service deployed in multiple locations. This can be used to
    /// disable the gateway in master region.
    /// </summary>
    [JsonPropertyName("disableGateway")]
    public bool? DisableGateway { get; set; }

    /// <summary>
    /// EnableClientCertificate: Property only meant to be used for Consumption SKU Service. This enforces a client certificate
    /// to be presented on each request to the gateway. This also enables the ability to authenticate the certificate in the
    /// policy on the gateway.
    /// </summary>
    [JsonPropertyName("enableClientCertificate")]
    public bool? EnableClientCertificate { get; set; }

    /// <summary>Etag: ETag of the resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>GatewayRegionalUrl: Gateway URL of the API Management service in the Default Region.</summary>
    [JsonPropertyName("gatewayRegionalUrl")]
    public string? GatewayRegionalUrl { get; set; }

    /// <summary>GatewayUrl: Gateway URL of the API Management service.</summary>
    [JsonPropertyName("gatewayUrl")]
    public string? GatewayUrl { get; set; }

    /// <summary>HostnameConfigurations: Custom hostname configuration of the API Management service.</summary>
    [JsonPropertyName("hostnameConfigurations")]
    public IList<V1api20230501previewServiceStatusHostnameConfigurations>? HostnameConfigurations { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: Managed service identity of the Api Management service.</summary>
    [JsonPropertyName("identity")]
    public V1api20230501previewServiceStatusIdentity? Identity { get; set; }

    /// <summary>LegacyPortalStatus: Status of legacy portal in the API Management service.</summary>
    [JsonPropertyName("legacyPortalStatus")]
    public string? LegacyPortalStatus { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ManagementApiUrl: Management API endpoint URL of the API Management service.</summary>
    [JsonPropertyName("managementApiUrl")]
    public string? ManagementApiUrl { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NatGatewayState: Property can be used to enable NAT Gateway for this API Management service.</summary>
    [JsonPropertyName("natGatewayState")]
    public string? NatGatewayState { get; set; }

    /// <summary>NotificationSenderEmail: Email address from which the notification will be sent.</summary>
    [JsonPropertyName("notificationSenderEmail")]
    public string? NotificationSenderEmail { get; set; }

    /// <summary>
    /// OutboundPublicIPAddresses: Outbound public IPV4 address prefixes associated with NAT Gateway deployed service. Available
    /// only for Premium SKU on stv2 platform.
    /// </summary>
    [JsonPropertyName("outboundPublicIPAddresses")]
    public IList<string>? OutboundPublicIPAddresses { get; set; }

    /// <summary>PlatformVersion: Compute Platform Version running the service in this location.</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>PortalUrl: Publisher portal endpoint Url of the API Management service.</summary>
    [JsonPropertyName("portalUrl")]
    public string? PortalUrl { get; set; }

    /// <summary>PrivateEndpointConnections: List of Private Endpoint Connections of this service.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20230501previewServiceStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>
    /// PrivateIPAddresses: Private Static Load Balanced IP addresses of the API Management service in Primary region which is
    /// deployed in an Internal Virtual Network. Available only for Basic, Standard, Premium and Isolated SKU.
    /// </summary>
    [JsonPropertyName("privateIPAddresses")]
    public IList<string>? PrivateIPAddresses { get; set; }

    /// <summary>
    /// ProvisioningState: The current provisioning state of the API Management service which can be one of the following:
    /// Created/Activating/Succeeded/Updating/Failed/Stopped/Terminating/TerminationFailed/Deleted.
    /// </summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// PublicIPAddresses: Public Static Load Balanced IP addresses of the API Management service in Primary region. Available
    /// only for Basic, Standard, Premium and Isolated SKU.
    /// </summary>
    [JsonPropertyName("publicIPAddresses")]
    public IList<string>? PublicIPAddresses { get; set; }

    /// <summary>
    /// PublicIpAddressId: Public Standard SKU IP V4 based IP address to be associated with Virtual Network deployed service in
    /// the region. Supported only for Developer and Premium SKU being deployed in Virtual Network.
    /// </summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Whether or not public endpoint access is allowed for this API Management service.  Value is
    /// optional but if passed in, must be &apos;Enabled&apos; or &apos;Disabled&apos;. If &apos;Disabled&apos;, private endpoints are the exclusive access
    /// method. Default value is &apos;Enabled&apos;
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>PublisherEmail: Publisher email.</summary>
    [JsonPropertyName("publisherEmail")]
    public string? PublisherEmail { get; set; }

    /// <summary>PublisherName: Publisher name.</summary>
    [JsonPropertyName("publisherName")]
    public string? PublisherName { get; set; }

    /// <summary>
    /// Restore: Undelete Api Management Service if it was previously soft-deleted. If this flag is specified and set to True
    /// all other properties will be ignored.
    /// </summary>
    [JsonPropertyName("restore")]
    public bool? Restore { get; set; }

    /// <summary>ScmUrl: SCM endpoint URL of the API Management service.</summary>
    [JsonPropertyName("scmUrl")]
    public string? ScmUrl { get; set; }

    /// <summary>Sku: SKU properties of the API Management service.</summary>
    [JsonPropertyName("sku")]
    public V1api20230501previewServiceStatusSku? Sku { get; set; }

    /// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20230501previewServiceStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// TargetProvisioningState: The provisioning state of the API Management service, which is targeted by the long running
    /// operation started on the service.
    /// </summary>
    [JsonPropertyName("targetProvisioningState")]
    public string? TargetProvisioningState { get; set; }

    /// <summary>Type: Resource type for API Management resource is set to Microsoft.ApiManagement.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>VirtualNetworkConfiguration: Virtual network configuration of the API Management service.</summary>
    [JsonPropertyName("virtualNetworkConfiguration")]
    public V1api20230501previewServiceStatusVirtualNetworkConfiguration? VirtualNetworkConfiguration { get; set; }

    /// <summary>
    /// VirtualNetworkType: The type of VPN in which API Management service needs to be configured in. None (Default Value)
    /// means the API Management service is not part of any Virtual Network, External means the API Management deployment is set
    /// up inside a Virtual Network having an Internet Facing Endpoint, and Internal means that API Management deployment is
    /// setup inside a Virtual Network having an Intranet Facing Endpoint only.
    /// </summary>
    [JsonPropertyName("virtualNetworkType")]
    public string? VirtualNetworkType { get; set; }

    /// <summary>Zones: A list of availability zones denoting where the resource needs to come from.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /apimanagement/resource-manager/Microsoft.ApiManagement/ApiManagement/preview/2023-05-01-preview/apimdeployment.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230501previewService : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230501previewServiceSpec?>, IStatus<V1api20230501previewServiceStatus?>
{
    public const string KubeApiVersion = "v1api20230501preview";
    public const string KubeKind = "Service";
    public const string KubeGroup = "apimanagement.azure.com";
    public const string KubePluralName = "services";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.com/v1api20230501preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Service";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20230501previewServiceSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20230501previewServiceStatus? Status { get; set; }
}
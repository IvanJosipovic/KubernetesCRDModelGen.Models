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
/// <summary>ApplicationGateway is the Schema for the ApplicationGateways API. Manages an Application Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ApplicationGatewayList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ApplicationGateway>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ApplicationGatewayList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "applicationgateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApplicationGatewayList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ApplicationGateway objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ApplicationGateway> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecDeletionPolicyEnum>))]
public enum V1beta2ApplicationGatewaySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>The contents of the Authentication Certificate which should be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderAuthenticationCertificateDataSecretRef
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
public partial class V1beta2ApplicationGatewaySpecForProviderAuthenticationCertificate
{
    /// <summary>The contents of the Authentication Certificate which should be used.</summary>
    [JsonPropertyName("dataSecretRef")]
    public V1beta2ApplicationGatewaySpecForProviderAuthenticationCertificateDataSecretRef? DataSecretRef { get; set; }

    /// <summary>The Name of the Authentication Certificate to use.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>An autoscale_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderAutoscaleConfiguration
{
    /// <summary>Maximum capacity for autoscaling. Accepted values are in the range 2 to 125.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>Minimum capacity for autoscaling. Accepted values are in the range 0 to 100.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderBackendAddressPool
{
    /// <summary>A list of FQDN&apos;s which should be part of the Backend Address Pool.</summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary>A list of IP Addresses which should be part of the Backend Address Pool.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>The name of the Backend Address Pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderBackendHttpSettingsAuthenticationCertificate
{
    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A connection_draining block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderBackendHttpSettingsConnectionDraining
{
    /// <summary>The number of seconds connection draining is active. Acceptable values are from 1 second to 3600 seconds.</summary>
    [JsonPropertyName("drainTimeoutSec")]
    public double? DrainTimeoutSec { get; set; }

    /// <summary>Is the Web Application Firewall enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderBackendHttpSettings
{
    /// <summary>The name of the affinity cookie.</summary>
    [JsonPropertyName("affinityCookieName")]
    public string? AffinityCookieName { get; set; }

    /// <summary>One or more authentication_certificate_backend blocks as defined below.</summary>
    [JsonPropertyName("authenticationCertificate")]
    public IList<V1beta2ApplicationGatewaySpecForProviderBackendHttpSettingsAuthenticationCertificate>? AuthenticationCertificate { get; set; }

    /// <summary>A connection_draining block as defined below.</summary>
    [JsonPropertyName("connectionDraining")]
    public V1beta2ApplicationGatewaySpecForProviderBackendHttpSettingsConnectionDraining? ConnectionDraining { get; set; }

    /// <summary>Is Cookie-Based Affinity enabled? Possible values are Enabled and Disabled.</summary>
    [JsonPropertyName("cookieBasedAffinity")]
    public string? CookieBasedAffinity { get; set; }

    /// <summary>Whether to use a dedicated backend connection. Defaults to false.</summary>
    [JsonPropertyName("dedicatedBackendConnectionEnabled")]
    public bool? DedicatedBackendConnectionEnabled { get; set; }

    /// <summary>Host header to be sent to the backend servers. Cannot be set if pick_host_name_from_backend_address is set to true.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The name of the Backend HTTP Settings Collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Path which should be used as a prefix for all HTTP requests.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Whether host header should be picked from the host name of the backend server. Defaults to false.</summary>
    [JsonPropertyName("pickHostNameFromBackendAddress")]
    public bool? PickHostNameFromBackendAddress { get; set; }

    /// <summary>The port which should be used for this Backend HTTP Settings Collection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of an associated HTTP Probe.</summary>
    [JsonPropertyName("probeName")]
    public string? ProbeName { get; set; }

    /// <summary>The Protocol which should be used. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The request timeout in seconds, which must be between 1 and 86400 seconds. Defaults to 30.</summary>
    [JsonPropertyName("requestTimeout")]
    public double? RequestTimeout { get; set; }

    /// <summary>A list of trusted_root_certificate names.</summary>
    [JsonPropertyName("trustedRootCertificateNames")]
    public IList<string>? TrustedRootCertificateNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderCustomErrorConfiguration
{
    /// <summary>Error page URL of the application gateway customer error.</summary>
    [JsonPropertyName("customErrorPageUrl")]
    public string? CustomErrorPageUrl { get; set; }

    /// <summary>Status code of the application gateway customer error. Possible values are HttpStatus400, HttpStatus403, HttpStatus404, HttpStatus405, HttpStatus408, HttpStatus500, HttpStatus502, HttpStatus503 and HttpStatus504</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a PublicIP in network to populate publicIpAddressId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a PublicIP in network to populate publicIpAddressId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelector
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
    public V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelector
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
    public V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderFrontendIpConfiguration
{
    /// <summary>This is an injected field with a default value for being able to merge items of the parent object list.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>The name of the Frontend IP Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Private IP Address to use for the Application Gateway.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The Allocation Method for the Private IP Address. Possible values are Dynamic and Static. Defaults to Dynamic.</summary>
    [JsonPropertyName("privateIpAddressAllocation")]
    public string? PrivateIpAddressAllocation { get; set; }

    /// <summary>The name of the private link configuration to use for this frontend IP configuration.</summary>
    [JsonPropertyName("privateLinkConfigurationName")]
    public string? PrivateLinkConfigurationName { get; set; }

    /// <summary>The ID of a Public IP Address which the Application Gateway should use. The allocation method for the Public IP Address depends on the sku of this Application Gateway. Please refer to the Azure documentation for public IP addresses for details.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>Reference to a PublicIP in network to populate publicIpAddressId.</summary>
    [JsonPropertyName("publicIpAddressIdRef")]
    public V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdRef? PublicIpAddressIdRef { get; set; }

    /// <summary>Selector for a PublicIP in network to populate publicIpAddressId.</summary>
    [JsonPropertyName("publicIpAddressIdSelector")]
    public V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationPublicIpAddressIdSelector? PublicIpAddressIdSelector { get; set; }

    /// <summary>The ID of the Subnet.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2ApplicationGatewaySpecForProviderFrontendIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderFrontendPort
{
    /// <summary>The name of the Frontend Port.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The port used for this Frontend Port.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelector
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
    public V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderGatewayIpConfiguration
{
    /// <summary>This is an injected field with a default value for being able to merge items of the parent object list.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>The Name of this Gateway IP Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Subnet which the Application Gateway should be connected to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2ApplicationGatewaySpecForProviderGatewayIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary>A global block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderGlobal
{
    /// <summary>Whether Application Gateway&apos;s Request buffer is enabled.</summary>
    [JsonPropertyName("requestBufferingEnabled")]
    public bool? RequestBufferingEnabled { get; set; }

    /// <summary>Whether Application Gateway&apos;s Response buffer is enabled.</summary>
    [JsonPropertyName("responseBufferingEnabled")]
    public bool? ResponseBufferingEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderHttpListenerCustomErrorConfiguration
{
    /// <summary>Error page URL of the application gateway customer error.</summary>
    [JsonPropertyName("customErrorPageUrl")]
    public string? CustomErrorPageUrl { get; set; }

    /// <summary>A list of allowed status codes for this Health Probe.</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderHttpListener
{
    /// <summary>One or more custom_error_configuration blocks as defined below.</summary>
    [JsonPropertyName("customErrorConfiguration")]
    public IList<V1beta2ApplicationGatewaySpecForProviderHttpListenerCustomErrorConfiguration>? CustomErrorConfiguration { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy which should be used for this HTTP Listener.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>The Name of the Frontend IP Configuration used for this HTTP Listener.</summary>
    [JsonPropertyName("frontendIpConfigurationName")]
    public string? FrontendIpConfigurationName { get; set; }

    /// <summary>The Name of the Frontend Port use for this HTTP Listener.</summary>
    [JsonPropertyName("frontendPortName")]
    public string? FrontendPortName { get; set; }

    /// <summary>The Hostname which should be used for this HTTP Listener. Setting this value changes Listener Type to &apos;Multi site&apos;.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>A list of Hostname(s) should be used for this HTTP Listener. It allows special wildcard characters.</summary>
    [JsonPropertyName("hostNames")]
    public IList<string>? HostNames { get; set; }

    /// <summary>The Name of the HTTP Listener.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Protocol to use for this HTTP Listener. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Should Server Name Indication be Required? Defaults to false.</summary>
    [JsonPropertyName("requireSni")]
    public bool? RequireSni { get; set; }

    /// <summary>The name of the associated SSL Certificate which should be used for this HTTP Listener.</summary>
    [JsonPropertyName("sslCertificateName")]
    public string? SslCertificateName { get; set; }

    /// <summary>The name of the associated SSL Profile which should be used for this HTTP Listener.</summary>
    [JsonPropertyName("sslProfileName")]
    public string? SslProfileName { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Application Gateway.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Application Gateway. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector
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
    public V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfiguration
{
    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this the Primary IP Configuration?</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The Static IP Address which should be used.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The allocation method used for the Private IP Address. Possible values are Dynamic and Static.</summary>
    [JsonPropertyName("privateIpAddressAllocation")]
    public string? PrivateIpAddressAllocation { get; set; }

    /// <summary>The ID of the subnet the private link configuration should connect to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfiguration
{
    /// <summary>One or more ip_configuration blocks as defined below.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfigurationIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The name of the private link configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A match block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderProbeMatch
{
    /// <summary>A snippet from the Response Body which must be present in the Response.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>A list of allowed status codes for this Health Probe.</summary>
    [JsonPropertyName("statusCode")]
    public IList<string>? StatusCode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderProbe
{
    /// <summary>The Hostname used for this Probe. If the Application Gateway is configured for a single site, by default the Host name should be specified as 127.0.0.1, unless otherwise configured in custom probe. Cannot be set if pick_host_name_from_backend_http_settings is set to true.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The Interval between two consecutive probes in seconds. Possible values range from 1 second to a maximum of 86,400 seconds.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>A match block as defined above.</summary>
    [JsonPropertyName("match")]
    public V1beta2ApplicationGatewaySpecForProviderProbeMatch? Match { get; set; }

    /// <summary>The minimum number of servers that are always marked as healthy. Defaults to 0.</summary>
    [JsonPropertyName("minimumServers")]
    public double? MinimumServers { get; set; }

    /// <summary>The Name of the Probe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Path used for this Probe.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Whether the host header should be picked from the backend HTTP settings. Defaults to false.</summary>
    [JsonPropertyName("pickHostNameFromBackendHttpSettings")]
    public bool? PickHostNameFromBackendHttpSettings { get; set; }

    /// <summary>Custom port which will be used for probing the backend servers. The valid value ranges from 1 to 65535. In case not set, port from HTTP settings will be used. This property is valid for Basic, Standard_v2 and WAF_v2 only.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The Protocol used for this Probe. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The Timeout used for this Probe, which indicates when a probe becomes unhealthy. Possible values range from 1 second to a maximum of 86,400 seconds.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>The Unhealthy Threshold for this Probe, which indicates the amount of retries which should be attempted before a node is deemed unhealthy. Possible values are from 1 to 20.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderRedirectConfiguration
{
    /// <summary>Whether to include the path in the redirected URL. Defaults to false</summary>
    [JsonPropertyName("includePath")]
    public bool? IncludePath { get; set; }

    /// <summary>Whether to include the query string in the redirected URL. Default to false</summary>
    [JsonPropertyName("includeQueryString")]
    public bool? IncludeQueryString { get; set; }

    /// <summary>Unique name of the redirect configuration block</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of redirect. Possible values are Permanent, Temporary, Found and SeeOther</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }

    /// <summary>The name of the listener to redirect to. Cannot be set if target_url is set.</summary>
    [JsonPropertyName("targetListenerName")]
    public string? TargetListenerName { get; set; }

    /// <summary>The URL to redirect the request to. Cannot be set if target_listener_name is set.</summary>
    [JsonPropertyName("targetUrl")]
    public string? TargetUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderRequestRoutingRule
{
    /// <summary>The Name of the Backend Address Pool which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendAddressPoolName")]
    public string? BackendAddressPoolName { get; set; }

    /// <summary>The Name of the Backend HTTP Settings Collection which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendHttpSettingsName")]
    public string? BackendHttpSettingsName { get; set; }

    /// <summary>The Name of the HTTP Listener which should be used for this Routing Rule.</summary>
    [JsonPropertyName("httpListenerName")]
    public string? HttpListenerName { get; set; }

    /// <summary>The Name of this Request Routing Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Rule evaluation order can be dictated by specifying an integer value from 1 to 20000 with 1 being the highest priority and 20000 being the lowest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Name of the Redirect Configuration which should be used for this Routing Rule. Cannot be set if either backend_address_pool_name or backend_http_settings_name is set.</summary>
    [JsonPropertyName("redirectConfigurationName")]
    public string? RedirectConfigurationName { get; set; }

    /// <summary>The Name of the Rewrite Rule Set which should be used for this Routing Rule. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("rewriteRuleSetName")]
    public string? RewriteRuleSetName { get; set; }

    /// <summary>The Type of Routing that should be used for this Rule. Possible values are Basic and PathBasedRouting.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    /// <summary>The Name of the URL Path Map which should be associated with this Routing Rule.</summary>
    [JsonPropertyName("urlPathMapName")]
    public string? UrlPathMapName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationGatewaySpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderResourceGroupNameSelector
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
    public V1beta2ApplicationGatewaySpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRuleCondition
{
    /// <summary>Perform a case in-sensitive comparison. Defaults to false</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>Negate the result of the condition evaluation. Defaults to false</summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>The pattern, either fixed string or regular expression, that evaluates the truthfulness of the condition.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }

    /// <summary>The variable of the condition.</summary>
    [JsonPropertyName("variable")]
    public string? Variable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRuleRequestHeaderConfiguration
{
    /// <summary>Header name of the header configuration.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>Header value of the header configuration. To delete a response header set this property to an empty string.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRuleResponseHeaderConfiguration
{
    /// <summary>Header name of the header configuration.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>Header value of the header configuration. To delete a response header set this property to an empty string.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary>One url block as defined below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRuleUrl
{
    /// <summary>The components used to rewrite the URL. Possible values are path_only and query_string_only to limit the rewrite to the URL Path or URL Query String only.</summary>
    [JsonPropertyName("components")]
    public string? Components { get; set; }

    /// <summary>The URL path to rewrite.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The query string to rewrite.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>Whether the URL path map should be reevaluated after this rewrite has been applied. More info on rewrite configuration</summary>
    [JsonPropertyName("reroute")]
    public bool? Reroute { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRule
{
    /// <summary>One or more condition blocks as defined above.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta2ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRuleCondition>? Condition { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more request_header_configuration blocks as defined above.</summary>
    [JsonPropertyName("requestHeaderConfiguration")]
    public IList<V1beta2ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRuleRequestHeaderConfiguration>? RequestHeaderConfiguration { get; set; }

    /// <summary>One or more response_header_configuration blocks as defined above.</summary>
    [JsonPropertyName("responseHeaderConfiguration")]
    public IList<V1beta2ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRuleResponseHeaderConfiguration>? ResponseHeaderConfiguration { get; set; }

    /// <summary>Rule sequence of the rewrite rule that determines the order of execution in a set.</summary>
    [JsonPropertyName("ruleSequence")]
    public double? RuleSequence { get; set; }

    /// <summary>One url block as defined below</summary>
    [JsonPropertyName("url")]
    public V1beta2ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRuleUrl? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderRewriteRuleSet
{
    /// <summary>Unique name of the rewrite rule set block</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more rewrite_rule blocks as defined below.</summary>
    [JsonPropertyName("rewriteRule")]
    public IList<V1beta2ApplicationGatewaySpecForProviderRewriteRuleSetRewriteRule>? RewriteRule { get; set; }
}

/// <summary>A sku block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderSku
{
    /// <summary>The Capacity of the SKU to use for this Application Gateway. When using a V1 SKU this value must be between 1 and 32, and 1 to 125 for a V2 SKU. When using a Basic SKU this property must be between 1 and 2. This property is optional if autoscale_configuration is set.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The Name of the SKU to use for this Application Gateway. Possible values are Basic, Standard_Small, Standard_Medium, Standard_Large, Standard_v2, WAF_Large, WAF_Medium and WAF_v2.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Tier of the SKU to use for this Application Gateway. Possible values are Basic, Standard_v2, and WAF_v2.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>The base64-encoded PFX certificate data. Required if key_vault_secret_id is not set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderSslCertificateDataSecretRef
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

/// <summary>Password for the pfx file specified in data. Required if data is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderSslCertificatePasswordSecretRef
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
public partial class V1beta2ApplicationGatewaySpecForProviderSslCertificate
{
    /// <summary>The base64-encoded PFX certificate data. Required if key_vault_secret_id is not set.</summary>
    [JsonPropertyName("dataSecretRef")]
    public V1beta2ApplicationGatewaySpecForProviderSslCertificateDataSecretRef? DataSecretRef { get; set; }

    /// <summary>The Secret ID of the (base-64 encoded unencrypted pfx) Secret or Certificate object stored in Azure KeyVault. You need to enable soft delete for Key Vault to use this feature. Required if data is not set.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The Name of the SSL certificate that is unique within this Application Gateway</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Password for the pfx file specified in data. Required if data is set.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2ApplicationGatewaySpecForProviderSslCertificatePasswordSecretRef? PasswordSecretRef { get; set; }
}

/// <summary>a ssl_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderSslPolicy
{
    /// <summary>A List of accepted cipher suites. Possible values are: TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA256, TLS_DHE_DSS_WITH_AES_256_CBC_SHA, TLS_DHE_DSS_WITH_AES_256_CBC_SHA256, TLS_DHE_RSA_WITH_AES_128_CBC_SHA, TLS_DHE_RSA_WITH_AES_128_GCM_SHA256, TLS_DHE_RSA_WITH_AES_256_CBC_SHA, TLS_DHE_RSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384, TLS_RSA_WITH_3DES_EDE_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_256_CBC_SHA256 and TLS_RSA_WITH_AES_256_GCM_SHA384.</summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary>A list of SSL Protocols which should be disabled on this Application Gateway. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("disabledProtocols")]
    public IList<string>? DisabledProtocols { get; set; }

    /// <summary>The minimal TLS version. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("minProtocolVersion")]
    public string? MinProtocolVersion { get; set; }

    /// <summary>The Name of the Policy e.g. AppGwSslPolicy20170401S. Required if policy_type is set to Predefined. Possible values can change over time and are published here https://docs.microsoft.com/azure/application-gateway/application-gateway-ssl-policy-overview. Not compatible with disabled_protocols.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The Type of the Policy. Possible values are Predefined, Custom and CustomV2.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}

/// <summary>a ssl_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderSslProfileSslPolicy
{
    /// <summary>A List of accepted cipher suites. Possible values are: TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA256, TLS_DHE_DSS_WITH_AES_256_CBC_SHA, TLS_DHE_DSS_WITH_AES_256_CBC_SHA256, TLS_DHE_RSA_WITH_AES_128_CBC_SHA, TLS_DHE_RSA_WITH_AES_128_GCM_SHA256, TLS_DHE_RSA_WITH_AES_256_CBC_SHA, TLS_DHE_RSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384, TLS_RSA_WITH_3DES_EDE_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_256_CBC_SHA256 and TLS_RSA_WITH_AES_256_GCM_SHA384.</summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary>A list of SSL Protocols which should be disabled on this Application Gateway. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("disabledProtocols")]
    public IList<string>? DisabledProtocols { get; set; }

    /// <summary>The minimal TLS version. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("minProtocolVersion")]
    public string? MinProtocolVersion { get; set; }

    /// <summary>The Name of the Policy e.g. AppGwSslPolicy20170401S. Required if policy_type is set to Predefined. Possible values can change over time and are published here https://docs.microsoft.com/azure/application-gateway/application-gateway-ssl-policy-overview. Not compatible with disabled_protocols.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The Type of the Policy. Possible values are Predefined, Custom and CustomV2.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderSslProfile
{
    /// <summary>The name of the SSL Profile that is unique within this Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>a ssl_policy block as defined below.</summary>
    [JsonPropertyName("sslPolicy")]
    public V1beta2ApplicationGatewaySpecForProviderSslProfileSslPolicy? SslPolicy { get; set; }

    /// <summary>The name of the Trusted Client Certificate that will be used to authenticate requests from clients.</summary>
    [JsonPropertyName("trustedClientCertificateNames")]
    public IList<string>? TrustedClientCertificateNames { get; set; }

    /// <summary>Should client certificate issuer DN be verified? Defaults to false.</summary>
    [JsonPropertyName("verifyClientCertIssuerDn")]
    public bool? VerifyClientCertIssuerDn { get; set; }

    /// <summary>Specify the method to check client certificate revocation status. Possible value is OCSP.</summary>
    [JsonPropertyName("verifyClientCertificateRevocation")]
    public string? VerifyClientCertificateRevocation { get; set; }
}

/// <summary>The base-64 encoded certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderTrustedClientCertificateDataSecretRef
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
public partial class V1beta2ApplicationGatewaySpecForProviderTrustedClientCertificate
{
    /// <summary>The base-64 encoded certificate.</summary>
    [JsonPropertyName("dataSecretRef")]
    public V1beta2ApplicationGatewaySpecForProviderTrustedClientCertificateDataSecretRef? DataSecretRef { get; set; }

    /// <summary>The name of the Trusted Client Certificate that is unique within this Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The contents of the Trusted Root Certificate which should be used. Required if key_vault_secret_id is not set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderTrustedRootCertificateDataSecretRef
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
public partial class V1beta2ApplicationGatewaySpecForProviderTrustedRootCertificate
{
    /// <summary>The contents of the Trusted Root Certificate which should be used. Required if key_vault_secret_id is not set.</summary>
    [JsonPropertyName("dataSecretRef")]
    public V1beta2ApplicationGatewaySpecForProviderTrustedRootCertificateDataSecretRef? DataSecretRef { get; set; }

    /// <summary>The Secret ID of the (base-64 encoded unencrypted pfx) Secret or Certificate object stored in Azure KeyVault. You need to enable soft delete for the Key Vault to use this feature. Required if data is not set.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The Name of the Trusted Root Certificate to use.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderUrlPathMapPathRule
{
    /// <summary>The Name of the Backend Address Pool which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendAddressPoolName")]
    public string? BackendAddressPoolName { get; set; }

    /// <summary>The Name of the Backend HTTP Settings Collection which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendHttpSettingsName")]
    public string? BackendHttpSettingsName { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy which should be used as an HTTP Listener.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of Paths used in this Path Rule.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>The Name of the Redirect Configuration which should be used for this Routing Rule. Cannot be set if either backend_address_pool_name or backend_http_settings_name is set.</summary>
    [JsonPropertyName("redirectConfigurationName")]
    public string? RedirectConfigurationName { get; set; }

    /// <summary>The Name of the Rewrite Rule Set which should be used for this Routing Rule. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("rewriteRuleSetName")]
    public string? RewriteRuleSetName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderUrlPathMap
{
    /// <summary>The Name of the Default Backend Address Pool which should be used for this URL Path Map. Cannot be set if default_redirect_configuration_name is set.</summary>
    [JsonPropertyName("defaultBackendAddressPoolName")]
    public string? DefaultBackendAddressPoolName { get; set; }

    /// <summary>The Name of the Default Backend HTTP Settings Collection which should be used for this URL Path Map. Cannot be set if default_redirect_configuration_name is set.</summary>
    [JsonPropertyName("defaultBackendHttpSettingsName")]
    public string? DefaultBackendHttpSettingsName { get; set; }

    /// <summary>The Name of the Default Redirect Configuration which should be used for this URL Path Map. Cannot be set if either default_backend_address_pool_name or default_backend_http_settings_name is set.</summary>
    [JsonPropertyName("defaultRedirectConfigurationName")]
    public string? DefaultRedirectConfigurationName { get; set; }

    /// <summary>The Name of the Default Rewrite Rule Set which should be used for this URL Path Map. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("defaultRewriteRuleSetName")]
    public string? DefaultRewriteRuleSetName { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more path_rule blocks as defined above.</summary>
    [JsonPropertyName("pathRule")]
    public IList<V1beta2ApplicationGatewaySpecForProviderUrlPathMapPathRule>? PathRule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderWafConfigurationDisabledRuleGroup
{
    /// <summary>The rule group where specific rules should be disabled. Possible values are BadBots, crs_20_protocol_violations, crs_21_protocol_anomalies, crs_23_request_limits, crs_30_http_policy, crs_35_bad_robots, crs_40_generic_attacks, crs_41_sql_injection_attacks, crs_41_xss_attacks, crs_42_tight_security, crs_45_trojans, crs_49_inbound_blocking, General, GoodBots, KnownBadBots, Known-CVEs, REQUEST-911-METHOD-ENFORCEMENT, REQUEST-913-SCANNER-DETECTION, REQUEST-920-PROTOCOL-ENFORCEMENT, REQUEST-921-PROTOCOL-ATTACK, REQUEST-930-APPLICATION-ATTACK-LFI, REQUEST-931-APPLICATION-ATTACK-RFI, REQUEST-932-APPLICATION-ATTACK-RCE, REQUEST-933-APPLICATION-ATTACK-PHP, REQUEST-941-APPLICATION-ATTACK-XSS, REQUEST-942-APPLICATION-ATTACK-SQLI, REQUEST-943-APPLICATION-ATTACK-SESSION-FIXATION, REQUEST-944-APPLICATION-ATTACK-JAVA, UnknownBots, METHOD-ENFORCEMENT, PROTOCOL-ENFORCEMENT, PROTOCOL-ATTACK, LFI, RFI, RCE, PHP, NODEJS, XSS, SQLI, FIX, JAVA, MS-ThreatIntel-WebShells, MS-ThreatIntel-AppSec, MS-ThreatIntel-SQLI and MS-ThreatIntel-CVEs.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    /// <summary>A list of rules which should be disabled in that group. Disables all rules in the specified group if rules is not specified.</summary>
    [JsonPropertyName("rules")]
    public IList<double>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderWafConfigurationExclusion
{
    /// <summary>Match variable of the exclusion rule to exclude header, cookie or GET arguments. Possible values are RequestArgKeys, RequestArgNames, RequestArgValues, RequestCookieKeys, RequestCookieNames, RequestCookieValues, RequestHeaderKeys, RequestHeaderNames and RequestHeaderValues</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>String value which will be used for the filter operation. If empty will exclude all traffic on this match_variable</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Operator which will be used to search in the variable content. Possible values are Contains, EndsWith, Equals, EqualsAny and StartsWith. If empty will exclude all traffic on this match_variable</summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>A waf_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProviderWafConfiguration
{
    /// <summary>One or more disabled_rule_group blocks as defined below.</summary>
    [JsonPropertyName("disabledRuleGroup")]
    public IList<V1beta2ApplicationGatewaySpecForProviderWafConfigurationDisabledRuleGroup>? DisabledRuleGroup { get; set; }

    /// <summary>Is the Web Application Firewall enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta2ApplicationGatewaySpecForProviderWafConfigurationExclusion>? Exclusion { get; set; }

    /// <summary>The File Upload Limit in MB. Accepted values are in the range 1MB to 750MB for the WAF_v2 SKU, and 1MB to 500MB for all other SKUs. Defaults to 100MB.</summary>
    [JsonPropertyName("fileUploadLimitMb")]
    public double? FileUploadLimitMb { get; set; }

    /// <summary>The Web Application Firewall Mode. Possible values are Detection and Prevention.</summary>
    [JsonPropertyName("firewallMode")]
    public string? FirewallMode { get; set; }

    /// <summary>The Maximum Request Body Size in KB. Accepted values are in the range 1KB to 128KB. Defaults to 128KB.</summary>
    [JsonPropertyName("maxRequestBodySizeKb")]
    public double? MaxRequestBodySizeKb { get; set; }

    /// <summary>Is Request Body Inspection enabled? Defaults to true.</summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary>The Type of the Rule Set used for this Web Application Firewall. Possible values are OWASP, Microsoft_BotManagerRuleSet and Microsoft_DefaultRuleSet. Defaults to OWASP.</summary>
    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    /// <summary>The Version of the Rule Set used for this Web Application Firewall. Possible values are 0.1, 1.0, 1.1, 2.1, 2.2.9, 3.0, 3.1 and 3.2.</summary>
    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecForProvider
{
    /// <summary>One or more authentication_certificate blocks as defined below.</summary>
    [JsonPropertyName("authenticationCertificate")]
    public IList<V1beta2ApplicationGatewaySpecForProviderAuthenticationCertificate>? AuthenticationCertificate { get; set; }

    /// <summary>An autoscale_configuration block as defined below.</summary>
    [JsonPropertyName("autoscaleConfiguration")]
    public V1beta2ApplicationGatewaySpecForProviderAutoscaleConfiguration? AutoscaleConfiguration { get; set; }

    /// <summary>One or more backend_address_pool blocks as defined below.</summary>
    [JsonPropertyName("backendAddressPool")]
    public IList<V1beta2ApplicationGatewaySpecForProviderBackendAddressPool>? BackendAddressPool { get; set; }

    /// <summary>One or more backend_http_settings blocks as defined below.</summary>
    [JsonPropertyName("backendHttpSettings")]
    public IList<V1beta2ApplicationGatewaySpecForProviderBackendHttpSettings>? BackendHttpSettings { get; set; }

    /// <summary>One or more custom_error_configuration blocks as defined below.</summary>
    [JsonPropertyName("customErrorConfiguration")]
    public IList<V1beta2ApplicationGatewaySpecForProviderCustomErrorConfiguration>? CustomErrorConfiguration { get; set; }

    /// <summary>Is HTTP2 enabled on the application gateway resource? Defaults to false.</summary>
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary>Is FIPS enabled on the Application Gateway?</summary>
    [JsonPropertyName("fipsEnabled")]
    public bool? FipsEnabled { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>Is the Firewall Policy associated with the Application Gateway?</summary>
    [JsonPropertyName("forceFirewallPolicyAssociation")]
    public bool? ForceFirewallPolicyAssociation { get; set; }

    /// <summary>One or more frontend_ip_configuration blocks as defined below.</summary>
    [JsonPropertyName("frontendIpConfiguration")]
    public IList<V1beta2ApplicationGatewaySpecForProviderFrontendIpConfiguration>? FrontendIpConfiguration { get; set; }

    /// <summary>One or more frontend_port blocks as defined below.</summary>
    [JsonPropertyName("frontendPort")]
    public IList<V1beta2ApplicationGatewaySpecForProviderFrontendPort>? FrontendPort { get; set; }

    /// <summary>One or more gateway_ip_configuration blocks as defined below.</summary>
    [JsonPropertyName("gatewayIpConfiguration")]
    public IList<V1beta2ApplicationGatewaySpecForProviderGatewayIpConfiguration>? GatewayIpConfiguration { get; set; }

    /// <summary>A global block as defined below.</summary>
    [JsonPropertyName("global")]
    public V1beta2ApplicationGatewaySpecForProviderGlobal? Global { get; set; }

    /// <summary>One or more http_listener blocks as defined below.</summary>
    [JsonPropertyName("httpListener")]
    public IList<V1beta2ApplicationGatewaySpecForProviderHttpListener>? HttpListener { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2ApplicationGatewaySpecForProviderIdentity? Identity { get; set; }

    /// <summary>The Azure region where the Application Gateway should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more private_link_configuration blocks as defined below.</summary>
    [JsonPropertyName("privateLinkConfiguration")]
    public IList<V1beta2ApplicationGatewaySpecForProviderPrivateLinkConfiguration>? PrivateLinkConfiguration { get; set; }

    /// <summary>One or more probe blocks as defined below.</summary>
    [JsonPropertyName("probe")]
    public IList<V1beta2ApplicationGatewaySpecForProviderProbe>? Probe { get; set; }

    /// <summary>One or more redirect_configuration blocks as defined below.</summary>
    [JsonPropertyName("redirectConfiguration")]
    public IList<V1beta2ApplicationGatewaySpecForProviderRedirectConfiguration>? RedirectConfiguration { get; set; }

    /// <summary>One or more request_routing_rule blocks as defined below.</summary>
    [JsonPropertyName("requestRoutingRule")]
    public IList<V1beta2ApplicationGatewaySpecForProviderRequestRoutingRule>? RequestRoutingRule { get; set; }

    /// <summary>The name of the resource group in which to the Application Gateway should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2ApplicationGatewaySpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2ApplicationGatewaySpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>One or more rewrite_rule_set blocks as defined below. Only valid for v2 WAF and Standard SKUs.</summary>
    [JsonPropertyName("rewriteRuleSet")]
    public IList<V1beta2ApplicationGatewaySpecForProviderRewriteRuleSet>? RewriteRuleSet { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public V1beta2ApplicationGatewaySpecForProviderSku? Sku { get; set; }

    /// <summary>One or more ssl_certificate blocks as defined below.</summary>
    [JsonPropertyName("sslCertificate")]
    public IList<V1beta2ApplicationGatewaySpecForProviderSslCertificate>? SslCertificate { get; set; }

    /// <summary>a ssl_policy block as defined below.</summary>
    [JsonPropertyName("sslPolicy")]
    public V1beta2ApplicationGatewaySpecForProviderSslPolicy? SslPolicy { get; set; }

    /// <summary>One or more ssl_profile blocks as defined below.</summary>
    [JsonPropertyName("sslProfile")]
    public IList<V1beta2ApplicationGatewaySpecForProviderSslProfile>? SslProfile { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more trusted_client_certificate blocks as defined below.</summary>
    [JsonPropertyName("trustedClientCertificate")]
    public IList<V1beta2ApplicationGatewaySpecForProviderTrustedClientCertificate>? TrustedClientCertificate { get; set; }

    /// <summary>One or more trusted_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("trustedRootCertificate")]
    public IList<V1beta2ApplicationGatewaySpecForProviderTrustedRootCertificate>? TrustedRootCertificate { get; set; }

    /// <summary>One or more url_path_map blocks as defined below.</summary>
    [JsonPropertyName("urlPathMap")]
    public IList<V1beta2ApplicationGatewaySpecForProviderUrlPathMap>? UrlPathMap { get; set; }

    /// <summary>A waf_configuration block as defined below.</summary>
    [JsonPropertyName("wafConfiguration")]
    public V1beta2ApplicationGatewaySpecForProviderWafConfiguration? WafConfiguration { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Application Gateway should be located. Changing this forces a new Application Gateway to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>The contents of the Authentication Certificate which should be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderAuthenticationCertificateDataSecretRef
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
public partial class V1beta2ApplicationGatewaySpecInitProviderAuthenticationCertificate
{
    /// <summary>The contents of the Authentication Certificate which should be used.</summary>
    [JsonPropertyName("dataSecretRef")]
    public required V1beta2ApplicationGatewaySpecInitProviderAuthenticationCertificateDataSecretRef DataSecretRef { get; set; }

    /// <summary>The Name of the Authentication Certificate to use.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>An autoscale_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderAutoscaleConfiguration
{
    /// <summary>Maximum capacity for autoscaling. Accepted values are in the range 2 to 125.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>Minimum capacity for autoscaling. Accepted values are in the range 0 to 100.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderBackendAddressPool
{
    /// <summary>A list of FQDN&apos;s which should be part of the Backend Address Pool.</summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary>A list of IP Addresses which should be part of the Backend Address Pool.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>The name of the Backend Address Pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderBackendHttpSettingsAuthenticationCertificate
{
    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A connection_draining block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderBackendHttpSettingsConnectionDraining
{
    /// <summary>The number of seconds connection draining is active. Acceptable values are from 1 second to 3600 seconds.</summary>
    [JsonPropertyName("drainTimeoutSec")]
    public double? DrainTimeoutSec { get; set; }

    /// <summary>Is the Web Application Firewall enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderBackendHttpSettings
{
    /// <summary>The name of the affinity cookie.</summary>
    [JsonPropertyName("affinityCookieName")]
    public string? AffinityCookieName { get; set; }

    /// <summary>One or more authentication_certificate_backend blocks as defined below.</summary>
    [JsonPropertyName("authenticationCertificate")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderBackendHttpSettingsAuthenticationCertificate>? AuthenticationCertificate { get; set; }

    /// <summary>A connection_draining block as defined below.</summary>
    [JsonPropertyName("connectionDraining")]
    public V1beta2ApplicationGatewaySpecInitProviderBackendHttpSettingsConnectionDraining? ConnectionDraining { get; set; }

    /// <summary>Is Cookie-Based Affinity enabled? Possible values are Enabled and Disabled.</summary>
    [JsonPropertyName("cookieBasedAffinity")]
    public string? CookieBasedAffinity { get; set; }

    /// <summary>Whether to use a dedicated backend connection. Defaults to false.</summary>
    [JsonPropertyName("dedicatedBackendConnectionEnabled")]
    public bool? DedicatedBackendConnectionEnabled { get; set; }

    /// <summary>Host header to be sent to the backend servers. Cannot be set if pick_host_name_from_backend_address is set to true.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The name of the Backend HTTP Settings Collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Path which should be used as a prefix for all HTTP requests.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Whether host header should be picked from the host name of the backend server. Defaults to false.</summary>
    [JsonPropertyName("pickHostNameFromBackendAddress")]
    public bool? PickHostNameFromBackendAddress { get; set; }

    /// <summary>The port which should be used for this Backend HTTP Settings Collection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The name of an associated HTTP Probe.</summary>
    [JsonPropertyName("probeName")]
    public string? ProbeName { get; set; }

    /// <summary>The Protocol which should be used. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The request timeout in seconds, which must be between 1 and 86400 seconds. Defaults to 30.</summary>
    [JsonPropertyName("requestTimeout")]
    public double? RequestTimeout { get; set; }

    /// <summary>A list of trusted_root_certificate names.</summary>
    [JsonPropertyName("trustedRootCertificateNames")]
    public IList<string>? TrustedRootCertificateNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderCustomErrorConfiguration
{
    /// <summary>Error page URL of the application gateway customer error.</summary>
    [JsonPropertyName("customErrorPageUrl")]
    public string? CustomErrorPageUrl { get; set; }

    /// <summary>Status code of the application gateway customer error. Possible values are HttpStatus400, HttpStatus403, HttpStatus404, HttpStatus405, HttpStatus408, HttpStatus500, HttpStatus502, HttpStatus503 and HttpStatus504</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a PublicIP in network to populate publicIpAddressId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a PublicIP in network to populate publicIpAddressId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelector
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
    public V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelector
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
    public V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfiguration
{
    /// <summary>This is an injected field with a default value for being able to merge items of the parent object list.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>The name of the Frontend IP Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Private IP Address to use for the Application Gateway.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The Allocation Method for the Private IP Address. Possible values are Dynamic and Static. Defaults to Dynamic.</summary>
    [JsonPropertyName("privateIpAddressAllocation")]
    public string? PrivateIpAddressAllocation { get; set; }

    /// <summary>The name of the private link configuration to use for this frontend IP configuration.</summary>
    [JsonPropertyName("privateLinkConfigurationName")]
    public string? PrivateLinkConfigurationName { get; set; }

    /// <summary>The ID of a Public IP Address which the Application Gateway should use. The allocation method for the Public IP Address depends on the sku of this Application Gateway. Please refer to the Azure documentation for public IP addresses for details.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>Reference to a PublicIP in network to populate publicIpAddressId.</summary>
    [JsonPropertyName("publicIpAddressIdRef")]
    public V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdRef? PublicIpAddressIdRef { get; set; }

    /// <summary>Selector for a PublicIP in network to populate publicIpAddressId.</summary>
    [JsonPropertyName("publicIpAddressIdSelector")]
    public V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationPublicIpAddressIdSelector? PublicIpAddressIdSelector { get; set; }

    /// <summary>The ID of the Subnet.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderFrontendPort
{
    /// <summary>The name of the Frontend Port.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The port used for this Frontend Port.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelector
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
    public V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfiguration
{
    /// <summary>This is an injected field with a default value for being able to merge items of the parent object list.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>The Name of this Gateway IP Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Subnet which the Application Gateway should be connected to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary>A global block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderGlobal
{
    /// <summary>Whether Application Gateway&apos;s Request buffer is enabled.</summary>
    [JsonPropertyName("requestBufferingEnabled")]
    public bool? RequestBufferingEnabled { get; set; }

    /// <summary>Whether Application Gateway&apos;s Response buffer is enabled.</summary>
    [JsonPropertyName("responseBufferingEnabled")]
    public bool? ResponseBufferingEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderHttpListenerCustomErrorConfiguration
{
    /// <summary>Error page URL of the application gateway customer error.</summary>
    [JsonPropertyName("customErrorPageUrl")]
    public string? CustomErrorPageUrl { get; set; }

    /// <summary>A list of allowed status codes for this Health Probe.</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderHttpListener
{
    /// <summary>One or more custom_error_configuration blocks as defined below.</summary>
    [JsonPropertyName("customErrorConfiguration")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderHttpListenerCustomErrorConfiguration>? CustomErrorConfiguration { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy which should be used for this HTTP Listener.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>The Name of the Frontend IP Configuration used for this HTTP Listener.</summary>
    [JsonPropertyName("frontendIpConfigurationName")]
    public string? FrontendIpConfigurationName { get; set; }

    /// <summary>The Name of the Frontend Port use for this HTTP Listener.</summary>
    [JsonPropertyName("frontendPortName")]
    public string? FrontendPortName { get; set; }

    /// <summary>The Hostname which should be used for this HTTP Listener. Setting this value changes Listener Type to &apos;Multi site&apos;.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>A list of Hostname(s) should be used for this HTTP Listener. It allows special wildcard characters.</summary>
    [JsonPropertyName("hostNames")]
    public IList<string>? HostNames { get; set; }

    /// <summary>The Name of the HTTP Listener.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Protocol to use for this HTTP Listener. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Should Server Name Indication be Required? Defaults to false.</summary>
    [JsonPropertyName("requireSni")]
    public bool? RequireSni { get; set; }

    /// <summary>The name of the associated SSL Certificate which should be used for this HTTP Listener.</summary>
    [JsonPropertyName("sslCertificateName")]
    public string? SslCertificateName { get; set; }

    /// <summary>The name of the associated SSL Profile which should be used for this HTTP Listener.</summary>
    [JsonPropertyName("sslProfileName")]
    public string? SslProfileName { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Application Gateway.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Application Gateway. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector
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
    public V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfiguration
{
    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this the Primary IP Configuration?</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The Static IP Address which should be used.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The allocation method used for the Private IP Address. Possible values are Dynamic and Static.</summary>
    [JsonPropertyName("privateIpAddressAllocation")]
    public string? PrivateIpAddressAllocation { get; set; }

    /// <summary>The ID of the subnet the private link configuration should connect to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfiguration
{
    /// <summary>One or more ip_configuration blocks as defined below.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfigurationIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The name of the private link configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A match block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderProbeMatch
{
    /// <summary>A snippet from the Response Body which must be present in the Response.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>A list of allowed status codes for this Health Probe.</summary>
    [JsonPropertyName("statusCode")]
    public IList<string>? StatusCode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderProbe
{
    /// <summary>The Hostname used for this Probe. If the Application Gateway is configured for a single site, by default the Host name should be specified as 127.0.0.1, unless otherwise configured in custom probe. Cannot be set if pick_host_name_from_backend_http_settings is set to true.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The Interval between two consecutive probes in seconds. Possible values range from 1 second to a maximum of 86,400 seconds.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>A match block as defined above.</summary>
    [JsonPropertyName("match")]
    public V1beta2ApplicationGatewaySpecInitProviderProbeMatch? Match { get; set; }

    /// <summary>The minimum number of servers that are always marked as healthy. Defaults to 0.</summary>
    [JsonPropertyName("minimumServers")]
    public double? MinimumServers { get; set; }

    /// <summary>The Name of the Probe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Path used for this Probe.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Whether the host header should be picked from the backend HTTP settings. Defaults to false.</summary>
    [JsonPropertyName("pickHostNameFromBackendHttpSettings")]
    public bool? PickHostNameFromBackendHttpSettings { get; set; }

    /// <summary>Custom port which will be used for probing the backend servers. The valid value ranges from 1 to 65535. In case not set, port from HTTP settings will be used. This property is valid for Basic, Standard_v2 and WAF_v2 only.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The Protocol used for this Probe. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The Timeout used for this Probe, which indicates when a probe becomes unhealthy. Possible values range from 1 second to a maximum of 86,400 seconds.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>The Unhealthy Threshold for this Probe, which indicates the amount of retries which should be attempted before a node is deemed unhealthy. Possible values are from 1 to 20.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderRedirectConfiguration
{
    /// <summary>Whether to include the path in the redirected URL. Defaults to false</summary>
    [JsonPropertyName("includePath")]
    public bool? IncludePath { get; set; }

    /// <summary>Whether to include the query string in the redirected URL. Default to false</summary>
    [JsonPropertyName("includeQueryString")]
    public bool? IncludeQueryString { get; set; }

    /// <summary>Unique name of the redirect configuration block</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of redirect. Possible values are Permanent, Temporary, Found and SeeOther</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }

    /// <summary>The name of the listener to redirect to. Cannot be set if target_url is set.</summary>
    [JsonPropertyName("targetListenerName")]
    public string? TargetListenerName { get; set; }

    /// <summary>The URL to redirect the request to. Cannot be set if target_listener_name is set.</summary>
    [JsonPropertyName("targetUrl")]
    public string? TargetUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderRequestRoutingRule
{
    /// <summary>The Name of the Backend Address Pool which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendAddressPoolName")]
    public string? BackendAddressPoolName { get; set; }

    /// <summary>The Name of the Backend HTTP Settings Collection which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendHttpSettingsName")]
    public string? BackendHttpSettingsName { get; set; }

    /// <summary>The Name of the HTTP Listener which should be used for this Routing Rule.</summary>
    [JsonPropertyName("httpListenerName")]
    public string? HttpListenerName { get; set; }

    /// <summary>The Name of this Request Routing Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Rule evaluation order can be dictated by specifying an integer value from 1 to 20000 with 1 being the highest priority and 20000 being the lowest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Name of the Redirect Configuration which should be used for this Routing Rule. Cannot be set if either backend_address_pool_name or backend_http_settings_name is set.</summary>
    [JsonPropertyName("redirectConfigurationName")]
    public string? RedirectConfigurationName { get; set; }

    /// <summary>The Name of the Rewrite Rule Set which should be used for this Routing Rule. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("rewriteRuleSetName")]
    public string? RewriteRuleSetName { get; set; }

    /// <summary>The Type of Routing that should be used for this Rule. Possible values are Basic and PathBasedRouting.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    /// <summary>The Name of the URL Path Map which should be associated with this Routing Rule.</summary>
    [JsonPropertyName("urlPathMapName")]
    public string? UrlPathMapName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRuleCondition
{
    /// <summary>Perform a case in-sensitive comparison. Defaults to false</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>Negate the result of the condition evaluation. Defaults to false</summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>The pattern, either fixed string or regular expression, that evaluates the truthfulness of the condition.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }

    /// <summary>The variable of the condition.</summary>
    [JsonPropertyName("variable")]
    public string? Variable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRuleRequestHeaderConfiguration
{
    /// <summary>Header name of the header configuration.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>Header value of the header configuration. To delete a response header set this property to an empty string.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRuleResponseHeaderConfiguration
{
    /// <summary>Header name of the header configuration.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>Header value of the header configuration. To delete a response header set this property to an empty string.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary>One url block as defined below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRuleUrl
{
    /// <summary>The components used to rewrite the URL. Possible values are path_only and query_string_only to limit the rewrite to the URL Path or URL Query String only.</summary>
    [JsonPropertyName("components")]
    public string? Components { get; set; }

    /// <summary>The URL path to rewrite.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The query string to rewrite.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>Whether the URL path map should be reevaluated after this rewrite has been applied. More info on rewrite configuration</summary>
    [JsonPropertyName("reroute")]
    public bool? Reroute { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRule
{
    /// <summary>One or more condition blocks as defined above.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRuleCondition>? Condition { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more request_header_configuration blocks as defined above.</summary>
    [JsonPropertyName("requestHeaderConfiguration")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRuleRequestHeaderConfiguration>? RequestHeaderConfiguration { get; set; }

    /// <summary>One or more response_header_configuration blocks as defined above.</summary>
    [JsonPropertyName("responseHeaderConfiguration")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRuleResponseHeaderConfiguration>? ResponseHeaderConfiguration { get; set; }

    /// <summary>Rule sequence of the rewrite rule that determines the order of execution in a set.</summary>
    [JsonPropertyName("ruleSequence")]
    public double? RuleSequence { get; set; }

    /// <summary>One url block as defined below</summary>
    [JsonPropertyName("url")]
    public V1beta2ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRuleUrl? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderRewriteRuleSet
{
    /// <summary>Unique name of the rewrite rule set block</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more rewrite_rule blocks as defined below.</summary>
    [JsonPropertyName("rewriteRule")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderRewriteRuleSetRewriteRule>? RewriteRule { get; set; }
}

/// <summary>A sku block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderSku
{
    /// <summary>The Capacity of the SKU to use for this Application Gateway. When using a V1 SKU this value must be between 1 and 32, and 1 to 125 for a V2 SKU. When using a Basic SKU this property must be between 1 and 2. This property is optional if autoscale_configuration is set.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The Name of the SKU to use for this Application Gateway. Possible values are Basic, Standard_Small, Standard_Medium, Standard_Large, Standard_v2, WAF_Large, WAF_Medium and WAF_v2.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Tier of the SKU to use for this Application Gateway. Possible values are Basic, Standard_v2, and WAF_v2.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>The base64-encoded PFX certificate data. Required if key_vault_secret_id is not set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderSslCertificateDataSecretRef
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

/// <summary>Password for the pfx file specified in data. Required if data is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderSslCertificatePasswordSecretRef
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
public partial class V1beta2ApplicationGatewaySpecInitProviderSslCertificate
{
    /// <summary>The base64-encoded PFX certificate data. Required if key_vault_secret_id is not set.</summary>
    [JsonPropertyName("dataSecretRef")]
    public V1beta2ApplicationGatewaySpecInitProviderSslCertificateDataSecretRef? DataSecretRef { get; set; }

    /// <summary>The Secret ID of the (base-64 encoded unencrypted pfx) Secret or Certificate object stored in Azure KeyVault. You need to enable soft delete for Key Vault to use this feature. Required if data is not set.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The Name of the SSL certificate that is unique within this Application Gateway</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Password for the pfx file specified in data. Required if data is set.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta2ApplicationGatewaySpecInitProviderSslCertificatePasswordSecretRef? PasswordSecretRef { get; set; }
}

/// <summary>a ssl_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderSslPolicy
{
    /// <summary>A List of accepted cipher suites. Possible values are: TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA256, TLS_DHE_DSS_WITH_AES_256_CBC_SHA, TLS_DHE_DSS_WITH_AES_256_CBC_SHA256, TLS_DHE_RSA_WITH_AES_128_CBC_SHA, TLS_DHE_RSA_WITH_AES_128_GCM_SHA256, TLS_DHE_RSA_WITH_AES_256_CBC_SHA, TLS_DHE_RSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384, TLS_RSA_WITH_3DES_EDE_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_256_CBC_SHA256 and TLS_RSA_WITH_AES_256_GCM_SHA384.</summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary>A list of SSL Protocols which should be disabled on this Application Gateway. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("disabledProtocols")]
    public IList<string>? DisabledProtocols { get; set; }

    /// <summary>The minimal TLS version. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("minProtocolVersion")]
    public string? MinProtocolVersion { get; set; }

    /// <summary>The Name of the Policy e.g. AppGwSslPolicy20170401S. Required if policy_type is set to Predefined. Possible values can change over time and are published here https://docs.microsoft.com/azure/application-gateway/application-gateway-ssl-policy-overview. Not compatible with disabled_protocols.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The Type of the Policy. Possible values are Predefined, Custom and CustomV2.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}

/// <summary>a ssl_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderSslProfileSslPolicy
{
    /// <summary>A List of accepted cipher suites. Possible values are: TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA256, TLS_DHE_DSS_WITH_AES_256_CBC_SHA, TLS_DHE_DSS_WITH_AES_256_CBC_SHA256, TLS_DHE_RSA_WITH_AES_128_CBC_SHA, TLS_DHE_RSA_WITH_AES_128_GCM_SHA256, TLS_DHE_RSA_WITH_AES_256_CBC_SHA, TLS_DHE_RSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384, TLS_RSA_WITH_3DES_EDE_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_256_CBC_SHA256 and TLS_RSA_WITH_AES_256_GCM_SHA384.</summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary>A list of SSL Protocols which should be disabled on this Application Gateway. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("disabledProtocols")]
    public IList<string>? DisabledProtocols { get; set; }

    /// <summary>The minimal TLS version. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("minProtocolVersion")]
    public string? MinProtocolVersion { get; set; }

    /// <summary>The Name of the Policy e.g. AppGwSslPolicy20170401S. Required if policy_type is set to Predefined. Possible values can change over time and are published here https://docs.microsoft.com/azure/application-gateway/application-gateway-ssl-policy-overview. Not compatible with disabled_protocols.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The Type of the Policy. Possible values are Predefined, Custom and CustomV2.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderSslProfile
{
    /// <summary>The name of the SSL Profile that is unique within this Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>a ssl_policy block as defined below.</summary>
    [JsonPropertyName("sslPolicy")]
    public V1beta2ApplicationGatewaySpecInitProviderSslProfileSslPolicy? SslPolicy { get; set; }

    /// <summary>The name of the Trusted Client Certificate that will be used to authenticate requests from clients.</summary>
    [JsonPropertyName("trustedClientCertificateNames")]
    public IList<string>? TrustedClientCertificateNames { get; set; }

    /// <summary>Should client certificate issuer DN be verified? Defaults to false.</summary>
    [JsonPropertyName("verifyClientCertIssuerDn")]
    public bool? VerifyClientCertIssuerDn { get; set; }

    /// <summary>Specify the method to check client certificate revocation status. Possible value is OCSP.</summary>
    [JsonPropertyName("verifyClientCertificateRevocation")]
    public string? VerifyClientCertificateRevocation { get; set; }
}

/// <summary>The base-64 encoded certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderTrustedClientCertificateDataSecretRef
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
public partial class V1beta2ApplicationGatewaySpecInitProviderTrustedClientCertificate
{
    /// <summary>The base-64 encoded certificate.</summary>
    [JsonPropertyName("dataSecretRef")]
    public required V1beta2ApplicationGatewaySpecInitProviderTrustedClientCertificateDataSecretRef DataSecretRef { get; set; }

    /// <summary>The name of the Trusted Client Certificate that is unique within this Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The contents of the Trusted Root Certificate which should be used. Required if key_vault_secret_id is not set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderTrustedRootCertificateDataSecretRef
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
public partial class V1beta2ApplicationGatewaySpecInitProviderTrustedRootCertificate
{
    /// <summary>The contents of the Trusted Root Certificate which should be used. Required if key_vault_secret_id is not set.</summary>
    [JsonPropertyName("dataSecretRef")]
    public V1beta2ApplicationGatewaySpecInitProviderTrustedRootCertificateDataSecretRef? DataSecretRef { get; set; }

    /// <summary>The Secret ID of the (base-64 encoded unencrypted pfx) Secret or Certificate object stored in Azure KeyVault. You need to enable soft delete for the Key Vault to use this feature. Required if data is not set.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The Name of the Trusted Root Certificate to use.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderUrlPathMapPathRule
{
    /// <summary>The Name of the Backend Address Pool which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendAddressPoolName")]
    public string? BackendAddressPoolName { get; set; }

    /// <summary>The Name of the Backend HTTP Settings Collection which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendHttpSettingsName")]
    public string? BackendHttpSettingsName { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy which should be used as an HTTP Listener.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of Paths used in this Path Rule.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>The Name of the Redirect Configuration which should be used for this Routing Rule. Cannot be set if either backend_address_pool_name or backend_http_settings_name is set.</summary>
    [JsonPropertyName("redirectConfigurationName")]
    public string? RedirectConfigurationName { get; set; }

    /// <summary>The Name of the Rewrite Rule Set which should be used for this Routing Rule. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("rewriteRuleSetName")]
    public string? RewriteRuleSetName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderUrlPathMap
{
    /// <summary>The Name of the Default Backend Address Pool which should be used for this URL Path Map. Cannot be set if default_redirect_configuration_name is set.</summary>
    [JsonPropertyName("defaultBackendAddressPoolName")]
    public string? DefaultBackendAddressPoolName { get; set; }

    /// <summary>The Name of the Default Backend HTTP Settings Collection which should be used for this URL Path Map. Cannot be set if default_redirect_configuration_name is set.</summary>
    [JsonPropertyName("defaultBackendHttpSettingsName")]
    public string? DefaultBackendHttpSettingsName { get; set; }

    /// <summary>The Name of the Default Redirect Configuration which should be used for this URL Path Map. Cannot be set if either default_backend_address_pool_name or default_backend_http_settings_name is set.</summary>
    [JsonPropertyName("defaultRedirectConfigurationName")]
    public string? DefaultRedirectConfigurationName { get; set; }

    /// <summary>The Name of the Default Rewrite Rule Set which should be used for this URL Path Map. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("defaultRewriteRuleSetName")]
    public string? DefaultRewriteRuleSetName { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more path_rule blocks as defined above.</summary>
    [JsonPropertyName("pathRule")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderUrlPathMapPathRule>? PathRule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderWafConfigurationDisabledRuleGroup
{
    /// <summary>The rule group where specific rules should be disabled. Possible values are BadBots, crs_20_protocol_violations, crs_21_protocol_anomalies, crs_23_request_limits, crs_30_http_policy, crs_35_bad_robots, crs_40_generic_attacks, crs_41_sql_injection_attacks, crs_41_xss_attacks, crs_42_tight_security, crs_45_trojans, crs_49_inbound_blocking, General, GoodBots, KnownBadBots, Known-CVEs, REQUEST-911-METHOD-ENFORCEMENT, REQUEST-913-SCANNER-DETECTION, REQUEST-920-PROTOCOL-ENFORCEMENT, REQUEST-921-PROTOCOL-ATTACK, REQUEST-930-APPLICATION-ATTACK-LFI, REQUEST-931-APPLICATION-ATTACK-RFI, REQUEST-932-APPLICATION-ATTACK-RCE, REQUEST-933-APPLICATION-ATTACK-PHP, REQUEST-941-APPLICATION-ATTACK-XSS, REQUEST-942-APPLICATION-ATTACK-SQLI, REQUEST-943-APPLICATION-ATTACK-SESSION-FIXATION, REQUEST-944-APPLICATION-ATTACK-JAVA, UnknownBots, METHOD-ENFORCEMENT, PROTOCOL-ENFORCEMENT, PROTOCOL-ATTACK, LFI, RFI, RCE, PHP, NODEJS, XSS, SQLI, FIX, JAVA, MS-ThreatIntel-WebShells, MS-ThreatIntel-AppSec, MS-ThreatIntel-SQLI and MS-ThreatIntel-CVEs.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    /// <summary>A list of rules which should be disabled in that group. Disables all rules in the specified group if rules is not specified.</summary>
    [JsonPropertyName("rules")]
    public IList<double>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderWafConfigurationExclusion
{
    /// <summary>Match variable of the exclusion rule to exclude header, cookie or GET arguments. Possible values are RequestArgKeys, RequestArgNames, RequestArgValues, RequestCookieKeys, RequestCookieNames, RequestCookieValues, RequestHeaderKeys, RequestHeaderNames and RequestHeaderValues</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>String value which will be used for the filter operation. If empty will exclude all traffic on this match_variable</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Operator which will be used to search in the variable content. Possible values are Contains, EndsWith, Equals, EqualsAny and StartsWith. If empty will exclude all traffic on this match_variable</summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>A waf_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecInitProviderWafConfiguration
{
    /// <summary>One or more disabled_rule_group blocks as defined below.</summary>
    [JsonPropertyName("disabledRuleGroup")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderWafConfigurationDisabledRuleGroup>? DisabledRuleGroup { get; set; }

    /// <summary>Is the Web Application Firewall enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderWafConfigurationExclusion>? Exclusion { get; set; }

    /// <summary>The File Upload Limit in MB. Accepted values are in the range 1MB to 750MB for the WAF_v2 SKU, and 1MB to 500MB for all other SKUs. Defaults to 100MB.</summary>
    [JsonPropertyName("fileUploadLimitMb")]
    public double? FileUploadLimitMb { get; set; }

    /// <summary>The Web Application Firewall Mode. Possible values are Detection and Prevention.</summary>
    [JsonPropertyName("firewallMode")]
    public string? FirewallMode { get; set; }

    /// <summary>The Maximum Request Body Size in KB. Accepted values are in the range 1KB to 128KB. Defaults to 128KB.</summary>
    [JsonPropertyName("maxRequestBodySizeKb")]
    public double? MaxRequestBodySizeKb { get; set; }

    /// <summary>Is Request Body Inspection enabled? Defaults to true.</summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary>The Type of the Rule Set used for this Web Application Firewall. Possible values are OWASP, Microsoft_BotManagerRuleSet and Microsoft_DefaultRuleSet. Defaults to OWASP.</summary>
    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    /// <summary>The Version of the Rule Set used for this Web Application Firewall. Possible values are 0.1, 1.0, 1.1, 2.1, 2.2.9, 3.0, 3.1 and 3.2.</summary>
    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
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
public partial class V1beta2ApplicationGatewaySpecInitProvider
{
    /// <summary>One or more authentication_certificate blocks as defined below.</summary>
    [JsonPropertyName("authenticationCertificate")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderAuthenticationCertificate>? AuthenticationCertificate { get; set; }

    /// <summary>An autoscale_configuration block as defined below.</summary>
    [JsonPropertyName("autoscaleConfiguration")]
    public V1beta2ApplicationGatewaySpecInitProviderAutoscaleConfiguration? AutoscaleConfiguration { get; set; }

    /// <summary>One or more backend_address_pool blocks as defined below.</summary>
    [JsonPropertyName("backendAddressPool")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderBackendAddressPool>? BackendAddressPool { get; set; }

    /// <summary>One or more backend_http_settings blocks as defined below.</summary>
    [JsonPropertyName("backendHttpSettings")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderBackendHttpSettings>? BackendHttpSettings { get; set; }

    /// <summary>One or more custom_error_configuration blocks as defined below.</summary>
    [JsonPropertyName("customErrorConfiguration")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderCustomErrorConfiguration>? CustomErrorConfiguration { get; set; }

    /// <summary>Is HTTP2 enabled on the application gateway resource? Defaults to false.</summary>
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary>Is FIPS enabled on the Application Gateway?</summary>
    [JsonPropertyName("fipsEnabled")]
    public bool? FipsEnabled { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>Is the Firewall Policy associated with the Application Gateway?</summary>
    [JsonPropertyName("forceFirewallPolicyAssociation")]
    public bool? ForceFirewallPolicyAssociation { get; set; }

    /// <summary>One or more frontend_ip_configuration blocks as defined below.</summary>
    [JsonPropertyName("frontendIpConfiguration")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderFrontendIpConfiguration>? FrontendIpConfiguration { get; set; }

    /// <summary>One or more frontend_port blocks as defined below.</summary>
    [JsonPropertyName("frontendPort")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderFrontendPort>? FrontendPort { get; set; }

    /// <summary>One or more gateway_ip_configuration blocks as defined below.</summary>
    [JsonPropertyName("gatewayIpConfiguration")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderGatewayIpConfiguration>? GatewayIpConfiguration { get; set; }

    /// <summary>A global block as defined below.</summary>
    [JsonPropertyName("global")]
    public V1beta2ApplicationGatewaySpecInitProviderGlobal? Global { get; set; }

    /// <summary>One or more http_listener blocks as defined below.</summary>
    [JsonPropertyName("httpListener")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderHttpListener>? HttpListener { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2ApplicationGatewaySpecInitProviderIdentity? Identity { get; set; }

    /// <summary>The Azure region where the Application Gateway should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more private_link_configuration blocks as defined below.</summary>
    [JsonPropertyName("privateLinkConfiguration")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderPrivateLinkConfiguration>? PrivateLinkConfiguration { get; set; }

    /// <summary>One or more probe blocks as defined below.</summary>
    [JsonPropertyName("probe")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderProbe>? Probe { get; set; }

    /// <summary>One or more redirect_configuration blocks as defined below.</summary>
    [JsonPropertyName("redirectConfiguration")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderRedirectConfiguration>? RedirectConfiguration { get; set; }

    /// <summary>One or more request_routing_rule blocks as defined below.</summary>
    [JsonPropertyName("requestRoutingRule")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderRequestRoutingRule>? RequestRoutingRule { get; set; }

    /// <summary>One or more rewrite_rule_set blocks as defined below. Only valid for v2 WAF and Standard SKUs.</summary>
    [JsonPropertyName("rewriteRuleSet")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderRewriteRuleSet>? RewriteRuleSet { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public V1beta2ApplicationGatewaySpecInitProviderSku? Sku { get; set; }

    /// <summary>One or more ssl_certificate blocks as defined below.</summary>
    [JsonPropertyName("sslCertificate")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderSslCertificate>? SslCertificate { get; set; }

    /// <summary>a ssl_policy block as defined below.</summary>
    [JsonPropertyName("sslPolicy")]
    public V1beta2ApplicationGatewaySpecInitProviderSslPolicy? SslPolicy { get; set; }

    /// <summary>One or more ssl_profile blocks as defined below.</summary>
    [JsonPropertyName("sslProfile")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderSslProfile>? SslProfile { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more trusted_client_certificate blocks as defined below.</summary>
    [JsonPropertyName("trustedClientCertificate")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderTrustedClientCertificate>? TrustedClientCertificate { get; set; }

    /// <summary>One or more trusted_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("trustedRootCertificate")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderTrustedRootCertificate>? TrustedRootCertificate { get; set; }

    /// <summary>One or more url_path_map blocks as defined below.</summary>
    [JsonPropertyName("urlPathMap")]
    public IList<V1beta2ApplicationGatewaySpecInitProviderUrlPathMap>? UrlPathMap { get; set; }

    /// <summary>A waf_configuration block as defined below.</summary>
    [JsonPropertyName("wafConfiguration")]
    public V1beta2ApplicationGatewaySpecInitProviderWafConfiguration? WafConfiguration { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Application Gateway should be located. Changing this forces a new Application Gateway to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecManagementPoliciesEnum>))]
public enum V1beta2ApplicationGatewaySpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ApplicationGatewaySpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ApplicationGatewaySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ApplicationGatewaySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ApplicationGatewaySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ApplicationGatewaySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ApplicationGatewaySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ApplicationGatewaySpec defines the desired state of ApplicationGateway</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewaySpec
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
    public V1beta2ApplicationGatewaySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ApplicationGatewaySpecForProvider ForProvider { get; set; }

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
    public V1beta2ApplicationGatewaySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ApplicationGatewaySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ApplicationGatewaySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ApplicationGatewaySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderAuthenticationCertificate
{
    /// <summary>The ID of the Authentication Certificate.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Name of the Authentication Certificate to use.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>An autoscale_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderAutoscaleConfiguration
{
    /// <summary>Maximum capacity for autoscaling. Accepted values are in the range 2 to 125.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>Minimum capacity for autoscaling. Accepted values are in the range 0 to 100.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderBackendAddressPool
{
    /// <summary>A list of FQDN&apos;s which should be part of the Backend Address Pool.</summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary>The ID of the Backend Address Pool.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of IP Addresses which should be part of the Backend Address Pool.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>The name of the Backend Address Pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderBackendHttpSettingsAuthenticationCertificate
{
    /// <summary>The ID of the URL Path Map.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A connection_draining block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderBackendHttpSettingsConnectionDraining
{
    /// <summary>The number of seconds connection draining is active. Acceptable values are from 1 second to 3600 seconds.</summary>
    [JsonPropertyName("drainTimeoutSec")]
    public double? DrainTimeoutSec { get; set; }

    /// <summary>Is the Web Application Firewall enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderBackendHttpSettings
{
    /// <summary>The name of the affinity cookie.</summary>
    [JsonPropertyName("affinityCookieName")]
    public string? AffinityCookieName { get; set; }

    /// <summary>One or more authentication_certificate_backend blocks as defined below.</summary>
    [JsonPropertyName("authenticationCertificate")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderBackendHttpSettingsAuthenticationCertificate>? AuthenticationCertificate { get; set; }

    /// <summary>A connection_draining block as defined below.</summary>
    [JsonPropertyName("connectionDraining")]
    public V1beta2ApplicationGatewayStatusAtProviderBackendHttpSettingsConnectionDraining? ConnectionDraining { get; set; }

    /// <summary>Is Cookie-Based Affinity enabled? Possible values are Enabled and Disabled.</summary>
    [JsonPropertyName("cookieBasedAffinity")]
    public string? CookieBasedAffinity { get; set; }

    /// <summary>Whether to use a dedicated backend connection. Defaults to false.</summary>
    [JsonPropertyName("dedicatedBackendConnectionEnabled")]
    public bool? DedicatedBackendConnectionEnabled { get; set; }

    /// <summary>Host header to be sent to the backend servers. Cannot be set if pick_host_name_from_backend_address is set to true.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Backend HTTP Settings Configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Backend HTTP Settings Collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Path which should be used as a prefix for all HTTP requests.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Whether host header should be picked from the host name of the backend server. Defaults to false.</summary>
    [JsonPropertyName("pickHostNameFromBackendAddress")]
    public bool? PickHostNameFromBackendAddress { get; set; }

    /// <summary>The port which should be used for this Backend HTTP Settings Collection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The ID of the associated Probe.</summary>
    [JsonPropertyName("probeId")]
    public string? ProbeId { get; set; }

    /// <summary>The name of an associated HTTP Probe.</summary>
    [JsonPropertyName("probeName")]
    public string? ProbeName { get; set; }

    /// <summary>The Protocol which should be used. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The request timeout in seconds, which must be between 1 and 86400 seconds. Defaults to 30.</summary>
    [JsonPropertyName("requestTimeout")]
    public double? RequestTimeout { get; set; }

    /// <summary>A list of trusted_root_certificate names.</summary>
    [JsonPropertyName("trustedRootCertificateNames")]
    public IList<string>? TrustedRootCertificateNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderCustomErrorConfiguration
{
    /// <summary>Error page URL of the application gateway customer error.</summary>
    [JsonPropertyName("customErrorPageUrl")]
    public string? CustomErrorPageUrl { get; set; }

    /// <summary>The ID of the Custom Error Configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Status code of the application gateway customer error. Possible values are HttpStatus400, HttpStatus403, HttpStatus404, HttpStatus405, HttpStatus408, HttpStatus500, HttpStatus502, HttpStatus503 and HttpStatus504</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderFrontendIpConfiguration
{
    /// <summary>The ID of the Frontend IP Configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>This is an injected field with a default value for being able to merge items of the parent object list.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>The name of the Frontend IP Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Private IP Address to use for the Application Gateway.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The Allocation Method for the Private IP Address. Possible values are Dynamic and Static. Defaults to Dynamic.</summary>
    [JsonPropertyName("privateIpAddressAllocation")]
    public string? PrivateIpAddressAllocation { get; set; }

    /// <summary>The ID of the associated private link configuration.</summary>
    [JsonPropertyName("privateLinkConfigurationId")]
    public string? PrivateLinkConfigurationId { get; set; }

    /// <summary>The name of the private link configuration to use for this frontend IP configuration.</summary>
    [JsonPropertyName("privateLinkConfigurationName")]
    public string? PrivateLinkConfigurationName { get; set; }

    /// <summary>The ID of a Public IP Address which the Application Gateway should use. The allocation method for the Public IP Address depends on the sku of this Application Gateway. Please refer to the Azure documentation for public IP addresses for details.</summary>
    [JsonPropertyName("publicIpAddressId")]
    public string? PublicIpAddressId { get; set; }

    /// <summary>The ID of the Subnet.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderFrontendPort
{
    /// <summary>The ID of the Frontend Port.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Frontend Port.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The port used for this Frontend Port.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderGatewayIpConfiguration
{
    /// <summary>The ID of the Gateway IP Configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>This is an injected field with a default value for being able to merge items of the parent object list.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>The Name of this Gateway IP Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Subnet which the Application Gateway should be connected to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary>A global block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderGlobal
{
    /// <summary>Whether Application Gateway&apos;s Request buffer is enabled.</summary>
    [JsonPropertyName("requestBufferingEnabled")]
    public bool? RequestBufferingEnabled { get; set; }

    /// <summary>Whether Application Gateway&apos;s Response buffer is enabled.</summary>
    [JsonPropertyName("responseBufferingEnabled")]
    public bool? ResponseBufferingEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderHttpListenerCustomErrorConfiguration
{
    /// <summary>Error page URL of the application gateway customer error.</summary>
    [JsonPropertyName("customErrorPageUrl")]
    public string? CustomErrorPageUrl { get; set; }

    /// <summary>The ID of the URL Path Map.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of allowed status codes for this Health Probe.</summary>
    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderHttpListener
{
    /// <summary>One or more custom_error_configuration blocks as defined below.</summary>
    [JsonPropertyName("customErrorConfiguration")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderHttpListenerCustomErrorConfiguration>? CustomErrorConfiguration { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy which should be used for this HTTP Listener.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>The ID of the associated Frontend Configuration.</summary>
    [JsonPropertyName("frontendIpConfigurationId")]
    public string? FrontendIpConfigurationId { get; set; }

    /// <summary>The Name of the Frontend IP Configuration used for this HTTP Listener.</summary>
    [JsonPropertyName("frontendIpConfigurationName")]
    public string? FrontendIpConfigurationName { get; set; }

    /// <summary>The ID of the associated Frontend Port.</summary>
    [JsonPropertyName("frontendPortId")]
    public string? FrontendPortId { get; set; }

    /// <summary>The Name of the Frontend Port use for this HTTP Listener.</summary>
    [JsonPropertyName("frontendPortName")]
    public string? FrontendPortName { get; set; }

    /// <summary>The Hostname which should be used for this HTTP Listener. Setting this value changes Listener Type to &apos;Multi site&apos;.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>A list of Hostname(s) should be used for this HTTP Listener. It allows special wildcard characters.</summary>
    [JsonPropertyName("hostNames")]
    public IList<string>? HostNames { get; set; }

    /// <summary>The ID of the HTTP Listener.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Name of the HTTP Listener.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Protocol to use for this HTTP Listener. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Should Server Name Indication be Required? Defaults to false.</summary>
    [JsonPropertyName("requireSni")]
    public bool? RequireSni { get; set; }

    /// <summary>The ID of the associated SSL Certificate.</summary>
    [JsonPropertyName("sslCertificateId")]
    public string? SslCertificateId { get; set; }

    /// <summary>The name of the associated SSL Certificate which should be used for this HTTP Listener.</summary>
    [JsonPropertyName("sslCertificateName")]
    public string? SslCertificateName { get; set; }

    /// <summary>The ID of the associated SSL Profile.</summary>
    [JsonPropertyName("sslProfileId")]
    public string? SslProfileId { get; set; }

    /// <summary>The name of the associated SSL Profile which should be used for this HTTP Listener.</summary>
    [JsonPropertyName("sslProfileName")]
    public string? SslProfileName { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Application Gateway.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The ID of the Application Gateway.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The ID of the Application Gateway.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Application Gateway. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderPrivateEndpointConnection
{
    /// <summary>The ID of the private endpoint connection.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the private endpoint connection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderPrivateLinkConfigurationIpConfiguration
{
    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this the Primary IP Configuration?</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>The Static IP Address which should be used.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The allocation method used for the Private IP Address. Possible values are Dynamic and Static.</summary>
    [JsonPropertyName("privateIpAddressAllocation")]
    public string? PrivateIpAddressAllocation { get; set; }

    /// <summary>The ID of the subnet the private link configuration should connect to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderPrivateLinkConfiguration
{
    /// <summary>The ID of the private link configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more ip_configuration blocks as defined below.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderPrivateLinkConfigurationIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The name of the private link configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A match block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderProbeMatch
{
    /// <summary>A snippet from the Response Body which must be present in the Response.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>A list of allowed status codes for this Health Probe.</summary>
    [JsonPropertyName("statusCode")]
    public IList<string>? StatusCode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderProbe
{
    /// <summary>The Hostname used for this Probe. If the Application Gateway is configured for a single site, by default the Host name should be specified as 127.0.0.1, unless otherwise configured in custom probe. Cannot be set if pick_host_name_from_backend_http_settings is set to true.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The ID of the Probe.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Interval between two consecutive probes in seconds. Possible values range from 1 second to a maximum of 86,400 seconds.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>A match block as defined above.</summary>
    [JsonPropertyName("match")]
    public V1beta2ApplicationGatewayStatusAtProviderProbeMatch? Match { get; set; }

    /// <summary>The minimum number of servers that are always marked as healthy. Defaults to 0.</summary>
    [JsonPropertyName("minimumServers")]
    public double? MinimumServers { get; set; }

    /// <summary>The Name of the Probe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Path used for this Probe.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Whether the host header should be picked from the backend HTTP settings. Defaults to false.</summary>
    [JsonPropertyName("pickHostNameFromBackendHttpSettings")]
    public bool? PickHostNameFromBackendHttpSettings { get; set; }

    /// <summary>Custom port which will be used for probing the backend servers. The valid value ranges from 1 to 65535. In case not set, port from HTTP settings will be used. This property is valid for Basic, Standard_v2 and WAF_v2 only.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The Protocol used for this Probe. Possible values are Http and Https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The Timeout used for this Probe, which indicates when a probe becomes unhealthy. Possible values range from 1 second to a maximum of 86,400 seconds.</summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>The Unhealthy Threshold for this Probe, which indicates the amount of retries which should be attempted before a node is deemed unhealthy. Possible values are from 1 to 20.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderRedirectConfiguration
{
    /// <summary>The ID of the Redirect Configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether to include the path in the redirected URL. Defaults to false</summary>
    [JsonPropertyName("includePath")]
    public bool? IncludePath { get; set; }

    /// <summary>Whether to include the query string in the redirected URL. Default to false</summary>
    [JsonPropertyName("includeQueryString")]
    public bool? IncludeQueryString { get; set; }

    /// <summary>Unique name of the redirect configuration block</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of redirect. Possible values are Permanent, Temporary, Found and SeeOther</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }

    /// <summary>The ID of the Application Gateway.</summary>
    [JsonPropertyName("targetListenerId")]
    public string? TargetListenerId { get; set; }

    /// <summary>The name of the listener to redirect to. Cannot be set if target_url is set.</summary>
    [JsonPropertyName("targetListenerName")]
    public string? TargetListenerName { get; set; }

    /// <summary>The URL to redirect the request to. Cannot be set if target_listener_name is set.</summary>
    [JsonPropertyName("targetUrl")]
    public string? TargetUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderRequestRoutingRule
{
    /// <summary>The ID of the associated Backend Address Pool.</summary>
    [JsonPropertyName("backendAddressPoolId")]
    public string? BackendAddressPoolId { get; set; }

    /// <summary>The Name of the Backend Address Pool which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendAddressPoolName")]
    public string? BackendAddressPoolName { get; set; }

    /// <summary>The ID of the associated Backend HTTP Settings Configuration.</summary>
    [JsonPropertyName("backendHttpSettingsId")]
    public string? BackendHttpSettingsId { get; set; }

    /// <summary>The Name of the Backend HTTP Settings Collection which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendHttpSettingsName")]
    public string? BackendHttpSettingsName { get; set; }

    /// <summary>The ID of the associated HTTP Listener.</summary>
    [JsonPropertyName("httpListenerId")]
    public string? HttpListenerId { get; set; }

    /// <summary>The Name of the HTTP Listener which should be used for this Routing Rule.</summary>
    [JsonPropertyName("httpListenerName")]
    public string? HttpListenerName { get; set; }

    /// <summary>The ID of the Request Routing Rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Name of this Request Routing Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Rule evaluation order can be dictated by specifying an integer value from 1 to 20000 with 1 being the highest priority and 20000 being the lowest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The ID of the associated Redirect Configuration.</summary>
    [JsonPropertyName("redirectConfigurationId")]
    public string? RedirectConfigurationId { get; set; }

    /// <summary>The Name of the Redirect Configuration which should be used for this Routing Rule. Cannot be set if either backend_address_pool_name or backend_http_settings_name is set.</summary>
    [JsonPropertyName("redirectConfigurationName")]
    public string? RedirectConfigurationName { get; set; }

    /// <summary>The ID of the associated Rewrite Rule Set.</summary>
    [JsonPropertyName("rewriteRuleSetId")]
    public string? RewriteRuleSetId { get; set; }

    /// <summary>The Name of the Rewrite Rule Set which should be used for this Routing Rule. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("rewriteRuleSetName")]
    public string? RewriteRuleSetName { get; set; }

    /// <summary>The Type of Routing that should be used for this Rule. Possible values are Basic and PathBasedRouting.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    /// <summary>The ID of the associated URL Path Map.</summary>
    [JsonPropertyName("urlPathMapId")]
    public string? UrlPathMapId { get; set; }

    /// <summary>The Name of the URL Path Map which should be associated with this Routing Rule.</summary>
    [JsonPropertyName("urlPathMapName")]
    public string? UrlPathMapName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRuleCondition
{
    /// <summary>Perform a case in-sensitive comparison. Defaults to false</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>Negate the result of the condition evaluation. Defaults to false</summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    /// <summary>The pattern, either fixed string or regular expression, that evaluates the truthfulness of the condition.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }

    /// <summary>The variable of the condition.</summary>
    [JsonPropertyName("variable")]
    public string? Variable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRuleRequestHeaderConfiguration
{
    /// <summary>Header name of the header configuration.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>Header value of the header configuration. To delete a response header set this property to an empty string.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRuleResponseHeaderConfiguration
{
    /// <summary>Header name of the header configuration.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>Header value of the header configuration. To delete a response header set this property to an empty string.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary>One url block as defined below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRuleUrl
{
    /// <summary>The components used to rewrite the URL. Possible values are path_only and query_string_only to limit the rewrite to the URL Path or URL Query String only.</summary>
    [JsonPropertyName("components")]
    public string? Components { get; set; }

    /// <summary>The URL path to rewrite.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The query string to rewrite.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>Whether the URL path map should be reevaluated after this rewrite has been applied. More info on rewrite configuration</summary>
    [JsonPropertyName("reroute")]
    public bool? Reroute { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRule
{
    /// <summary>One or more condition blocks as defined above.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRuleCondition>? Condition { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more request_header_configuration blocks as defined above.</summary>
    [JsonPropertyName("requestHeaderConfiguration")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRuleRequestHeaderConfiguration>? RequestHeaderConfiguration { get; set; }

    /// <summary>One or more response_header_configuration blocks as defined above.</summary>
    [JsonPropertyName("responseHeaderConfiguration")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRuleResponseHeaderConfiguration>? ResponseHeaderConfiguration { get; set; }

    /// <summary>Rule sequence of the rewrite rule that determines the order of execution in a set.</summary>
    [JsonPropertyName("ruleSequence")]
    public double? RuleSequence { get; set; }

    /// <summary>One url block as defined below</summary>
    [JsonPropertyName("url")]
    public V1beta2ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRuleUrl? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderRewriteRuleSet
{
    /// <summary>The ID of the Rewrite Rule Set</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Unique name of the rewrite rule set block</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more rewrite_rule blocks as defined below.</summary>
    [JsonPropertyName("rewriteRule")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderRewriteRuleSetRewriteRule>? RewriteRule { get; set; }
}

/// <summary>A sku block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderSku
{
    /// <summary>The Capacity of the SKU to use for this Application Gateway. When using a V1 SKU this value must be between 1 and 32, and 1 to 125 for a V2 SKU. When using a Basic SKU this property must be between 1 and 2. This property is optional if autoscale_configuration is set.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The Name of the SKU to use for this Application Gateway. Possible values are Basic, Standard_Small, Standard_Medium, Standard_Large, Standard_v2, WAF_Large, WAF_Medium and WAF_v2.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Tier of the SKU to use for this Application Gateway. Possible values are Basic, Standard_v2, and WAF_v2.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderSslCertificate
{
    /// <summary>The ID of the SSL Certificate.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Secret ID of the (base-64 encoded unencrypted pfx) Secret or Certificate object stored in Azure KeyVault. You need to enable soft delete for Key Vault to use this feature. Required if data is not set.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The Name of the SSL certificate that is unique within this Application Gateway</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Public Certificate Data associated with the SSL Certificate.</summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary>a ssl_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderSslPolicy
{
    /// <summary>A List of accepted cipher suites. Possible values are: TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA256, TLS_DHE_DSS_WITH_AES_256_CBC_SHA, TLS_DHE_DSS_WITH_AES_256_CBC_SHA256, TLS_DHE_RSA_WITH_AES_128_CBC_SHA, TLS_DHE_RSA_WITH_AES_128_GCM_SHA256, TLS_DHE_RSA_WITH_AES_256_CBC_SHA, TLS_DHE_RSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384, TLS_RSA_WITH_3DES_EDE_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_256_CBC_SHA256 and TLS_RSA_WITH_AES_256_GCM_SHA384.</summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary>A list of SSL Protocols which should be disabled on this Application Gateway. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("disabledProtocols")]
    public IList<string>? DisabledProtocols { get; set; }

    /// <summary>The minimal TLS version. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("minProtocolVersion")]
    public string? MinProtocolVersion { get; set; }

    /// <summary>The Name of the Policy e.g. AppGwSslPolicy20170401S. Required if policy_type is set to Predefined. Possible values can change over time and are published here https://docs.microsoft.com/azure/application-gateway/application-gateway-ssl-policy-overview. Not compatible with disabled_protocols.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The Type of the Policy. Possible values are Predefined, Custom and CustomV2.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}

/// <summary>a ssl_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderSslProfileSslPolicy
{
    /// <summary>A List of accepted cipher suites. Possible values are: TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA, TLS_DHE_DSS_WITH_AES_128_CBC_SHA256, TLS_DHE_DSS_WITH_AES_256_CBC_SHA, TLS_DHE_DSS_WITH_AES_256_CBC_SHA256, TLS_DHE_RSA_WITH_AES_128_CBC_SHA, TLS_DHE_RSA_WITH_AES_128_GCM_SHA256, TLS_DHE_RSA_WITH_AES_256_CBC_SHA, TLS_DHE_RSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256, TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA, TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384, TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384, TLS_RSA_WITH_3DES_EDE_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA, TLS_RSA_WITH_AES_128_CBC_SHA256, TLS_RSA_WITH_AES_128_GCM_SHA256, TLS_RSA_WITH_AES_256_CBC_SHA, TLS_RSA_WITH_AES_256_CBC_SHA256 and TLS_RSA_WITH_AES_256_GCM_SHA384.</summary>
    [JsonPropertyName("cipherSuites")]
    public IList<string>? CipherSuites { get; set; }

    /// <summary>A list of SSL Protocols which should be disabled on this Application Gateway. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("disabledProtocols")]
    public IList<string>? DisabledProtocols { get; set; }

    /// <summary>The minimal TLS version. Possible values are TLSv1_0, TLSv1_1, TLSv1_2 and TLSv1_3.</summary>
    [JsonPropertyName("minProtocolVersion")]
    public string? MinProtocolVersion { get; set; }

    /// <summary>The Name of the Policy e.g. AppGwSslPolicy20170401S. Required if policy_type is set to Predefined. Possible values can change over time and are published here https://docs.microsoft.com/azure/application-gateway/application-gateway-ssl-policy-overview. Not compatible with disabled_protocols.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The Type of the Policy. Possible values are Predefined, Custom and CustomV2.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderSslProfile
{
    /// <summary>The ID of the URL Path Map.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the SSL Profile that is unique within this Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>a ssl_policy block as defined below.</summary>
    [JsonPropertyName("sslPolicy")]
    public V1beta2ApplicationGatewayStatusAtProviderSslProfileSslPolicy? SslPolicy { get; set; }

    /// <summary>The name of the Trusted Client Certificate that will be used to authenticate requests from clients.</summary>
    [JsonPropertyName("trustedClientCertificateNames")]
    public IList<string>? TrustedClientCertificateNames { get; set; }

    /// <summary>Should client certificate issuer DN be verified? Defaults to false.</summary>
    [JsonPropertyName("verifyClientCertIssuerDn")]
    public bool? VerifyClientCertIssuerDn { get; set; }

    /// <summary>Specify the method to check client certificate revocation status. Possible value is OCSP.</summary>
    [JsonPropertyName("verifyClientCertificateRevocation")]
    public string? VerifyClientCertificateRevocation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderTrustedClientCertificate
{
    /// <summary>The ID of the URL Path Map.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Trusted Client Certificate that is unique within this Application Gateway.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderTrustedRootCertificate
{
    /// <summary>The ID of the URL Path Map.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Secret ID of the (base-64 encoded unencrypted pfx) Secret or Certificate object stored in Azure KeyVault. You need to enable soft delete for the Key Vault to use this feature. Required if data is not set.</summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>The Name of the Trusted Root Certificate to use.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderUrlPathMapPathRule
{
    /// <summary>The ID of the associated Backend Address Pool.</summary>
    [JsonPropertyName("backendAddressPoolId")]
    public string? BackendAddressPoolId { get; set; }

    /// <summary>The Name of the Backend Address Pool which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendAddressPoolName")]
    public string? BackendAddressPoolName { get; set; }

    /// <summary>The ID of the associated Backend HTTP Settings Configuration.</summary>
    [JsonPropertyName("backendHttpSettingsId")]
    public string? BackendHttpSettingsId { get; set; }

    /// <summary>The Name of the Backend HTTP Settings Collection which should be used for this Routing Rule. Cannot be set if redirect_configuration_name is set.</summary>
    [JsonPropertyName("backendHttpSettingsName")]
    public string? BackendHttpSettingsName { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy which should be used as an HTTP Listener.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>The ID of the URL Path Map.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of Paths used in this Path Rule.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>The ID of the associated Redirect Configuration.</summary>
    [JsonPropertyName("redirectConfigurationId")]
    public string? RedirectConfigurationId { get; set; }

    /// <summary>The Name of the Redirect Configuration which should be used for this Routing Rule. Cannot be set if either backend_address_pool_name or backend_http_settings_name is set.</summary>
    [JsonPropertyName("redirectConfigurationName")]
    public string? RedirectConfigurationName { get; set; }

    /// <summary>The ID of the associated Rewrite Rule Set.</summary>
    [JsonPropertyName("rewriteRuleSetId")]
    public string? RewriteRuleSetId { get; set; }

    /// <summary>The Name of the Rewrite Rule Set which should be used for this Routing Rule. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("rewriteRuleSetName")]
    public string? RewriteRuleSetName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderUrlPathMap
{
    /// <summary>The ID of the Default Backend Address Pool.</summary>
    [JsonPropertyName("defaultBackendAddressPoolId")]
    public string? DefaultBackendAddressPoolId { get; set; }

    /// <summary>The Name of the Default Backend Address Pool which should be used for this URL Path Map. Cannot be set if default_redirect_configuration_name is set.</summary>
    [JsonPropertyName("defaultBackendAddressPoolName")]
    public string? DefaultBackendAddressPoolName { get; set; }

    /// <summary>The ID of the Default Backend HTTP Settings Collection.</summary>
    [JsonPropertyName("defaultBackendHttpSettingsId")]
    public string? DefaultBackendHttpSettingsId { get; set; }

    /// <summary>The Name of the Default Backend HTTP Settings Collection which should be used for this URL Path Map. Cannot be set if default_redirect_configuration_name is set.</summary>
    [JsonPropertyName("defaultBackendHttpSettingsName")]
    public string? DefaultBackendHttpSettingsName { get; set; }

    /// <summary>The ID of the Default Redirect Configuration.</summary>
    [JsonPropertyName("defaultRedirectConfigurationId")]
    public string? DefaultRedirectConfigurationId { get; set; }

    /// <summary>The Name of the Default Redirect Configuration which should be used for this URL Path Map. Cannot be set if either default_backend_address_pool_name or default_backend_http_settings_name is set.</summary>
    [JsonPropertyName("defaultRedirectConfigurationName")]
    public string? DefaultRedirectConfigurationName { get; set; }

    /// <summary>The ID of the Application Gateway.</summary>
    [JsonPropertyName("defaultRewriteRuleSetId")]
    public string? DefaultRewriteRuleSetId { get; set; }

    /// <summary>The Name of the Default Rewrite Rule Set which should be used for this URL Path Map. Only valid for v2 SKUs.</summary>
    [JsonPropertyName("defaultRewriteRuleSetName")]
    public string? DefaultRewriteRuleSetName { get; set; }

    /// <summary>The ID of the URL Path Map.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Name of the URL Path Map.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more path_rule blocks as defined above.</summary>
    [JsonPropertyName("pathRule")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderUrlPathMapPathRule>? PathRule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderWafConfigurationDisabledRuleGroup
{
    /// <summary>The rule group where specific rules should be disabled. Possible values are BadBots, crs_20_protocol_violations, crs_21_protocol_anomalies, crs_23_request_limits, crs_30_http_policy, crs_35_bad_robots, crs_40_generic_attacks, crs_41_sql_injection_attacks, crs_41_xss_attacks, crs_42_tight_security, crs_45_trojans, crs_49_inbound_blocking, General, GoodBots, KnownBadBots, Known-CVEs, REQUEST-911-METHOD-ENFORCEMENT, REQUEST-913-SCANNER-DETECTION, REQUEST-920-PROTOCOL-ENFORCEMENT, REQUEST-921-PROTOCOL-ATTACK, REQUEST-930-APPLICATION-ATTACK-LFI, REQUEST-931-APPLICATION-ATTACK-RFI, REQUEST-932-APPLICATION-ATTACK-RCE, REQUEST-933-APPLICATION-ATTACK-PHP, REQUEST-941-APPLICATION-ATTACK-XSS, REQUEST-942-APPLICATION-ATTACK-SQLI, REQUEST-943-APPLICATION-ATTACK-SESSION-FIXATION, REQUEST-944-APPLICATION-ATTACK-JAVA, UnknownBots, METHOD-ENFORCEMENT, PROTOCOL-ENFORCEMENT, PROTOCOL-ATTACK, LFI, RFI, RCE, PHP, NODEJS, XSS, SQLI, FIX, JAVA, MS-ThreatIntel-WebShells, MS-ThreatIntel-AppSec, MS-ThreatIntel-SQLI and MS-ThreatIntel-CVEs.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    /// <summary>A list of rules which should be disabled in that group. Disables all rules in the specified group if rules is not specified.</summary>
    [JsonPropertyName("rules")]
    public IList<double>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderWafConfigurationExclusion
{
    /// <summary>Match variable of the exclusion rule to exclude header, cookie or GET arguments. Possible values are RequestArgKeys, RequestArgNames, RequestArgValues, RequestCookieKeys, RequestCookieNames, RequestCookieValues, RequestHeaderKeys, RequestHeaderNames and RequestHeaderValues</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>String value which will be used for the filter operation. If empty will exclude all traffic on this match_variable</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Operator which will be used to search in the variable content. Possible values are Contains, EndsWith, Equals, EqualsAny and StartsWith. If empty will exclude all traffic on this match_variable</summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>A waf_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProviderWafConfiguration
{
    /// <summary>One or more disabled_rule_group blocks as defined below.</summary>
    [JsonPropertyName("disabledRuleGroup")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderWafConfigurationDisabledRuleGroup>? DisabledRuleGroup { get; set; }

    /// <summary>Is the Web Application Firewall enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more exclusion blocks as defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderWafConfigurationExclusion>? Exclusion { get; set; }

    /// <summary>The File Upload Limit in MB. Accepted values are in the range 1MB to 750MB for the WAF_v2 SKU, and 1MB to 500MB for all other SKUs. Defaults to 100MB.</summary>
    [JsonPropertyName("fileUploadLimitMb")]
    public double? FileUploadLimitMb { get; set; }

    /// <summary>The Web Application Firewall Mode. Possible values are Detection and Prevention.</summary>
    [JsonPropertyName("firewallMode")]
    public string? FirewallMode { get; set; }

    /// <summary>The Maximum Request Body Size in KB. Accepted values are in the range 1KB to 128KB. Defaults to 128KB.</summary>
    [JsonPropertyName("maxRequestBodySizeKb")]
    public double? MaxRequestBodySizeKb { get; set; }

    /// <summary>Is Request Body Inspection enabled? Defaults to true.</summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary>The Type of the Rule Set used for this Web Application Firewall. Possible values are OWASP, Microsoft_BotManagerRuleSet and Microsoft_DefaultRuleSet. Defaults to OWASP.</summary>
    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    /// <summary>The Version of the Rule Set used for this Web Application Firewall. Possible values are 0.1, 1.0, 1.1, 2.1, 2.2.9, 3.0, 3.1 and 3.2.</summary>
    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusAtProvider
{
    /// <summary>One or more authentication_certificate blocks as defined below.</summary>
    [JsonPropertyName("authenticationCertificate")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderAuthenticationCertificate>? AuthenticationCertificate { get; set; }

    /// <summary>An autoscale_configuration block as defined below.</summary>
    [JsonPropertyName("autoscaleConfiguration")]
    public V1beta2ApplicationGatewayStatusAtProviderAutoscaleConfiguration? AutoscaleConfiguration { get; set; }

    /// <summary>One or more backend_address_pool blocks as defined below.</summary>
    [JsonPropertyName("backendAddressPool")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderBackendAddressPool>? BackendAddressPool { get; set; }

    /// <summary>One or more backend_http_settings blocks as defined below.</summary>
    [JsonPropertyName("backendHttpSettings")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderBackendHttpSettings>? BackendHttpSettings { get; set; }

    /// <summary>One or more custom_error_configuration blocks as defined below.</summary>
    [JsonPropertyName("customErrorConfiguration")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderCustomErrorConfiguration>? CustomErrorConfiguration { get; set; }

    /// <summary>Is HTTP2 enabled on the application gateway resource? Defaults to false.</summary>
    [JsonPropertyName("enableHttp2")]
    public bool? EnableHttp2 { get; set; }

    /// <summary>Is FIPS enabled on the Application Gateway?</summary>
    [JsonPropertyName("fipsEnabled")]
    public bool? FipsEnabled { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy.</summary>
    [JsonPropertyName("firewallPolicyId")]
    public string? FirewallPolicyId { get; set; }

    /// <summary>Is the Firewall Policy associated with the Application Gateway?</summary>
    [JsonPropertyName("forceFirewallPolicyAssociation")]
    public bool? ForceFirewallPolicyAssociation { get; set; }

    /// <summary>One or more frontend_ip_configuration blocks as defined below.</summary>
    [JsonPropertyName("frontendIpConfiguration")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderFrontendIpConfiguration>? FrontendIpConfiguration { get; set; }

    /// <summary>One or more frontend_port blocks as defined below.</summary>
    [JsonPropertyName("frontendPort")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderFrontendPort>? FrontendPort { get; set; }

    /// <summary>One or more gateway_ip_configuration blocks as defined below.</summary>
    [JsonPropertyName("gatewayIpConfiguration")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderGatewayIpConfiguration>? GatewayIpConfiguration { get; set; }

    /// <summary>A global block as defined below.</summary>
    [JsonPropertyName("global")]
    public V1beta2ApplicationGatewayStatusAtProviderGlobal? Global { get; set; }

    /// <summary>One or more http_listener blocks as defined below.</summary>
    [JsonPropertyName("httpListener")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderHttpListener>? HttpListener { get; set; }

    /// <summary>The ID of the Application Gateway.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2ApplicationGatewayStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>The Azure region where the Application Gateway should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A list of private_endpoint_connection blocks as defined below.</summary>
    [JsonPropertyName("privateEndpointConnection")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderPrivateEndpointConnection>? PrivateEndpointConnection { get; set; }

    /// <summary>One or more private_link_configuration blocks as defined below.</summary>
    [JsonPropertyName("privateLinkConfiguration")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderPrivateLinkConfiguration>? PrivateLinkConfiguration { get; set; }

    /// <summary>One or more probe blocks as defined below.</summary>
    [JsonPropertyName("probe")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderProbe>? Probe { get; set; }

    /// <summary>One or more redirect_configuration blocks as defined below.</summary>
    [JsonPropertyName("redirectConfiguration")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderRedirectConfiguration>? RedirectConfiguration { get; set; }

    /// <summary>One or more request_routing_rule blocks as defined below.</summary>
    [JsonPropertyName("requestRoutingRule")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderRequestRoutingRule>? RequestRoutingRule { get; set; }

    /// <summary>The name of the resource group in which to the Application Gateway should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>One or more rewrite_rule_set blocks as defined below. Only valid for v2 WAF and Standard SKUs.</summary>
    [JsonPropertyName("rewriteRuleSet")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderRewriteRuleSet>? RewriteRuleSet { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public V1beta2ApplicationGatewayStatusAtProviderSku? Sku { get; set; }

    /// <summary>One or more ssl_certificate blocks as defined below.</summary>
    [JsonPropertyName("sslCertificate")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderSslCertificate>? SslCertificate { get; set; }

    /// <summary>a ssl_policy block as defined below.</summary>
    [JsonPropertyName("sslPolicy")]
    public V1beta2ApplicationGatewayStatusAtProviderSslPolicy? SslPolicy { get; set; }

    /// <summary>One or more ssl_profile blocks as defined below.</summary>
    [JsonPropertyName("sslProfile")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderSslProfile>? SslProfile { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>One or more trusted_client_certificate blocks as defined below.</summary>
    [JsonPropertyName("trustedClientCertificate")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderTrustedClientCertificate>? TrustedClientCertificate { get; set; }

    /// <summary>One or more trusted_root_certificate blocks as defined below.</summary>
    [JsonPropertyName("trustedRootCertificate")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderTrustedRootCertificate>? TrustedRootCertificate { get; set; }

    /// <summary>One or more url_path_map blocks as defined below.</summary>
    [JsonPropertyName("urlPathMap")]
    public IList<V1beta2ApplicationGatewayStatusAtProviderUrlPathMap>? UrlPathMap { get; set; }

    /// <summary>A waf_configuration block as defined below.</summary>
    [JsonPropertyName("wafConfiguration")]
    public V1beta2ApplicationGatewayStatusAtProviderWafConfiguration? WafConfiguration { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Application Gateway should be located. Changing this forces a new Application Gateway to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatusConditions
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

/// <summary>ApplicationGatewayStatus defines the observed state of ApplicationGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ApplicationGatewayStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ApplicationGatewayStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ApplicationGatewayStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ApplicationGateway is the Schema for the ApplicationGateways API. Manages an Application Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ApplicationGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ApplicationGatewaySpec>, IStatus<V1beta2ApplicationGatewayStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ApplicationGateway";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "applicationgateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApplicationGateway";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApplicationGatewaySpec defines the desired state of ApplicationGateway</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ApplicationGatewaySpec Spec { get; set; }

    /// <summary>ApplicationGatewayStatus defines the observed state of ApplicationGateway.</summary>
    [JsonPropertyName("status")]
    public V1beta2ApplicationGatewayStatus? Status { get; set; }
}
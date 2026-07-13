#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerapp.azure.upbound.io;
/// <summary>ContainerApp is the Schema for the ContainerApps API. Manages a Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ContainerAppList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ContainerApp>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ContainerAppList";
    public const string KubeGroup = "containerapp.azure.upbound.io";
    public const string KubePluralName = "containerapps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerapp.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ContainerAppList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ContainerApp objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ContainerApp> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ContainerAppSpecDeletionPolicyEnum>))]
public enum V1beta2ContainerAppSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdRefPolicyResolutionEnum>))]
public enum V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdRefPolicyResolveEnum>))]
public enum V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Environment in containerapp to populate containerAppEnvironmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdSelectorPolicyResolveEnum>))]
public enum V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Environment in containerapp to populate containerAppEnvironmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdSelector
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
    public V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A dapr block as detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderDapr
{
    /// <summary>
    /// The Dapr Application Identifier.
    /// The Dapr Application Identifier.
    /// </summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>
    /// The port which the application is listening on. This is the same as the ingress port.
    /// The port which the application is listening on. This is the same as the `ingress` port.
    /// </summary>
    [JsonPropertyName("appPort")]
    public double? AppPort { get; set; }

    /// <summary>
    /// The protocol for the app. Possible values include http and grpc. Defaults to http.
    /// The protocol for the app. Possible values include `http` and `grpc`. Defaults to `http`.
    /// </summary>
    [JsonPropertyName("appProtocol")]
    public string? AppProtocol { get; set; }
}

/// <summary>An identity block as detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderIdentity
{
    /// <summary>- A list of one or more Resource IDs for User Assigned Managed identities to assign. Required when type is set to UserAssigned or SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of managed identity to assign. Possible values are SystemAssigned, UserAssigned, and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A cors block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderIngressCors
{
    /// <summary>Whether user credentials are allowed in the cross-origin request is enabled. Defaults to false.</summary>
    [JsonPropertyName("allowCredentialsEnabled")]
    public bool? AllowCredentialsEnabled { get; set; }

    /// <summary>Specifies the list of request headers that are permitted in the actual request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>Specifies the list of HTTP methods are allowed when accessing the resource in a cross-origin request.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Specifies the list of origins that are allowed to make cross-origin calls.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Specifies the list of headers exposed to the browser in the response to a cross-origin request.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>Specifies the number of seconds that the browser can cache the results of a preflight request.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderIngressIpSecurityRestriction
{
    /// <summary>
    /// The IP-filter action. Allow or Deny.
    /// The action. Allow or Deny.
    /// </summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>
    /// Describe the IP restriction rule that is being sent to the container-app.
    /// Describe the IP restriction rule that is being sent to the container-app.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The incoming IP address or range of IP addresses (in CIDR notation).
    /// The incoming IP address or range of IP addresses (in CIDR notation).
    /// </summary>
    [JsonPropertyName("ipAddressRange")]
    public string? IpAddressRange { get; set; }

    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// Name for the IP restriction rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderIngressTrafficWeight
{
    /// <summary>
    /// The label to apply to the revision as a name prefix for routing traffic.
    /// The label to apply to the revision as a name prefix for routing traffic.
    /// </summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>
    /// This traffic Weight applies to the latest stable Container Revision. At most only one traffic_weight block can have the latest_revision set to true.
    /// This traffic Weight relates to the latest stable Container Revision.
    /// </summary>
    [JsonPropertyName("latestRevision")]
    public bool? LatestRevision { get; set; }

    /// <summary>
    /// The percentage of traffic which should be sent this revision.
    /// The percentage of traffic to send to this revision.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }

    /// <summary>
    /// The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
    /// The suffix string to append to the revision. This must be unique for the Container App&apos;s lifetime. A default hash created by the service will be used if this value is omitted.
    /// </summary>
    [JsonPropertyName("revisionSuffix")]
    public string? RevisionSuffix { get; set; }
}

/// <summary>An ingress block as detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderIngress
{
    /// <summary>
    /// Should this ingress allow insecure connections?
    /// Should this ingress allow insecure connections?
    /// </summary>
    [JsonPropertyName("allowInsecureConnections")]
    public bool? AllowInsecureConnections { get; set; }

    /// <summary>
    /// The client certificate mode for the Ingress. Possible values are require, accept, and ignore.
    /// Client certificate mode for mTLS authentication. Ignore indicates server drops client certificate on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require indicates server requires a client certificate.
    /// </summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public V1beta2ContainerAppSpecForProviderIngressCors? Cors { get; set; }

    /// <summary>
    /// The exposed port on the container for the Ingress traffic.
    /// The exposed port on the container for the Ingress traffic.
    /// </summary>
    [JsonPropertyName("exposedPort")]
    public double? ExposedPort { get; set; }

    /// <summary>
    /// Are connections to this Ingress from outside the Container App Environment enabled? Defaults to false.
    /// Is this an external Ingress.
    /// </summary>
    [JsonPropertyName("externalEnabled")]
    public bool? ExternalEnabled { get; set; }

    /// <summary>One or more ip_security_restriction blocks for IP-filtering rules as defined below.</summary>
    [JsonPropertyName("ipSecurityRestriction")]
    public IList<V1beta2ContainerAppSpecForProviderIngressIpSecurityRestriction>? IpSecurityRestriction { get; set; }

    /// <summary>
    /// The target port on the container for the Ingress traffic.
    /// The target port on the container for the Ingress traffic.
    /// </summary>
    [JsonPropertyName("targetPort")]
    public double? TargetPort { get; set; }

    /// <summary>One or more traffic_weight blocks as detailed below.</summary>
    [JsonPropertyName("trafficWeight")]
    public IList<V1beta2ContainerAppSpecForProviderIngressTrafficWeight>? TrafficWeight { get; set; }

    /// <summary>
    /// The transport method for the Ingress. Possible values are auto, http, http2 and tcp. Defaults to auto.
    /// The transport method for the Ingress. Possible values include `auto`, `http`, and `http2`, `tcp`. Defaults to `auto`
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderRegistry
{
    /// <summary>
    /// Resource ID for the User Assigned Managed identity to use when pulling from the Container Registry.
    /// ID of the System or User Managed Identity used to pull images from the Container Registry
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>
    /// The name of the Secret Reference containing the password value for this user on the Container Registry, username must also be supplied.
    /// The name of the Secret Reference containing the password value for this user on the Container Registry.
    /// </summary>
    [JsonPropertyName("passwordSecretName")]
    public string? PasswordSecretName { get; set; }

    /// <summary>
    /// The hostname for the Container Registry.
    /// The hostname for the Container Registry.
    /// </summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>
    /// The username to use for this Container Registry, password_secret_name must also be supplied..
    /// The username to use for this Container Registry.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ContainerAppSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2ContainerAppSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ContainerAppSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2ContainerAppSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ContainerAppSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ContainerAppSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ContainerAppSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ContainerAppSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ContainerAppSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ContainerAppSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2ContainerAppSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ContainerAppSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ContainerAppSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderResourceGroupNameSelector
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
    public V1beta2ContainerAppSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The secret name.
/// The secret name.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderSecretNameSecretRef
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
/// The value for this secret.
/// The value for this secret.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderSecretValueSecretRef
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
public partial class V1beta2ContainerAppSpecForProviderSecret
{
    /// <summary>
    /// The identity to use for accessing the Key Vault secret reference. This can either be the Resource ID of a User Assigned Identity, or System for the System Assigned Identity.
    /// The identity to use for accessing key vault reference.
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>
    /// The ID of a Key Vault secret. This can be a versioned or version-less ID.
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>
    /// The secret name.
    /// The secret name.
    /// </summary>
    [JsonPropertyName("nameSecretRef")]
    public V1beta2ContainerAppSpecForProviderSecretNameSecretRef? NameSecretRef { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The value for this secret.
    /// </summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta2ContainerAppSpecForProviderSecretValueSecretRef? ValueSecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateAzureQueueScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateAzureQueueScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateAzureQueueScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the length of the queue to trigger scaling actions.</summary>
    [JsonPropertyName("queueLength")]
    public double? QueueLength { get; set; }

    /// <summary>The name of the Azure Queue</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateContainerEnv
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the environment variable for the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the secret that contains the value for this environment variable.
    /// The name of the secret that contains the value for this environment variable.
    /// </summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateContainerLivenessProbeHeader
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The HTTP Header Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The HTTP Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateContainerLivenessProbe
{
    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 30. Defaults to 3.
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateContainerLivenessProbeHeader>? Header { get; set; }

    /// <summary>
    /// The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes.
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds.
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `1` seconds.
    /// </summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// The path in the container at which to mount this volume.
    /// The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The port number on which to connect. Possible values are between 1 and 65535.
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1.
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Type of probe. Possible values are TCP, HTTP, and HTTPS.
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateContainerReadinessProbeHeader
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The HTTP Header Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The HTTP Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateContainerReadinessProbe
{
    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 30. Defaults to 3.
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateContainerReadinessProbeHeader>? Header { get; set; }

    /// <summary>
    /// The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes.
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds.
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.
    /// </summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// The path in the container at which to mount this volume.
    /// The URI to use for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The port number on which to connect. Possible values are between 1 and 65535.
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The number of consecutive successful responses required to consider this probe as successful. Possible values are between 1 and 10. Defaults to 3.
    /// The number of consecutive successful responses required to consider this probe as successful. Possible values are between `1` and `10`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("successCountThreshold")]
    public double? SuccessCountThreshold { get; set; }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1.
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Type of probe. Possible values are TCP, HTTP, and HTTPS.
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateContainerStartupProbeHeader
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The HTTP Header Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The HTTP Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateContainerStartupProbe
{
    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 30. Defaults to 3.
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateContainerStartupProbeHeader>? Header { get; set; }

    /// <summary>
    /// The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes.
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds.
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.
    /// </summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// The path in the container at which to mount this volume.
    /// The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The port number on which to connect. Possible values are between 1 and 65535.
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1.
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Type of probe. Possible values are TCP, HTTP, and HTTPS.
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateContainerVolumeMounts
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the Volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The path in the container at which to mount this volume.
    /// The path in the container at which to mount this volume.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The sub path of the volume to be mounted in the container.
    /// The sub path of the volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateContainer
{
    /// <summary>
    /// A list of extra arguments to pass to the container.
    /// A list of args to pass to the container.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// </summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>
    /// The amount of vCPU to allocate to the container.
    /// The amount of vCPU to allocate to the container.
    /// </summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>One or more env blocks as detailed below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateContainerEnv>? Env { get; set; }

    /// <summary>
    /// The image to use to create the container.
    /// The image to use to create the container.
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>A liveness_probe block as detailed below.</summary>
    [JsonPropertyName("livenessProbe")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateContainerLivenessProbe>? LivenessProbe { get; set; }

    /// <summary>
    /// The amount of memory to allocate to the container.
    /// The amount of memory to allocate to the container.
    /// </summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A readiness_probe block as detailed below.</summary>
    [JsonPropertyName("readinessProbe")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateContainerReadinessProbe>? ReadinessProbe { get; set; }

    /// <summary>A startup_probe block as detailed below.</summary>
    [JsonPropertyName("startupProbe")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateContainerStartupProbe>? StartupProbe { get; set; }

    /// <summary>A volume_mounts block as detailed below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateContainerVolumeMounts>? VolumeMounts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateCustomScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateCustomScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateCustomScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>The Custom rule type. Possible values include: activemq, artemis-queue, kafka, pulsar, aws-cloudwatch, aws-dynamodb, aws-dynamodb-streams, aws-kinesis-stream, aws-sqs-queue, azure-app-insights, azure-blob, azure-data-explorer, azure-eventhub, azure-log-analytics, azure-monitor, azure-pipelines, azure-servicebus, azure-queue, cassandra, cpu, cron, datadog, elasticsearch, external, external-push, gcp-stackdriver, gcp-storage, gcp-pubsub, graphite, http, huawei-cloudeye, ibmmq, influxdb, kubernetes-workload, liiklus, memory, metrics-api, mongodb, mssql, mysql, nats-jetstream, stan, tcp, new-relic, openstack-metric, openstack-swift, postgresql, predictkube, prometheus, rabbitmq, redis, redis-cluster, redis-sentinel, redis-streams, redis-cluster-streams, redis-sentinel-streams, selenium-grid,solace-event-queue, and github-runner.</summary>
    [JsonPropertyName("customRuleType")]
    public string? CustomRuleType { get; set; }

    /// <summary>- A map of string key-value pairs to configure the Custom Scale Rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateHttpScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateHttpScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateHttpScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>- The number of concurrent requests to trigger scaling.</summary>
    [JsonPropertyName("concurrentRequests")]
    public string? ConcurrentRequests { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateInitContainerEnv
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the environment variable for the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the secret that contains the value for this environment variable.
    /// The name of the secret that contains the value for this environment variable.
    /// </summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateInitContainerVolumeMounts
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the Volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The path in the container at which to mount this volume.
    /// The path in the container at which to mount this volume.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The sub path of the volume to be mounted in the container.
    /// The sub path of the volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateInitContainer
{
    /// <summary>
    /// A list of extra arguments to pass to the container.
    /// A list of args to pass to the container.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// </summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>
    /// The amount of vCPU to allocate to the container.
    /// The amount of vCPU to allocate to the container.
    /// </summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>One or more env blocks as detailed below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateInitContainerEnv>? Env { get; set; }

    /// <summary>
    /// The image to use to create the container.
    /// The image to use to create the container.
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// The amount of memory to allocate to the container.
    /// The amount of memory to allocate to the container.
    /// </summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A volume_mounts block as detailed below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateInitContainerVolumeMounts>? VolumeMounts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateTcpScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateTcpScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateTcpScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>- The number of concurrent requests to trigger scaling.</summary>
    [JsonPropertyName("concurrentRequests")]
    public string? ConcurrentRequests { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplateVolume
{
    /// <summary>
    /// Mount options used while mounting the AzureFile. Must be a comma-separated string e.g. dir_mode=0751,file_mode=0751.
    /// Mount options used while mounting the AzureFile. Must be a comma-separated string.
    /// </summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the volume.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the AzureFile storage.
    /// The name of the `AzureFile` storage. Required when `storage_type` is `AzureFile`
    /// </summary>
    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }

    /// <summary>
    /// The type of storage volume. Possible values are AzureFile, EmptyDir, NfsAzureFile and Secret. Defaults to EmptyDir.
    /// The type of storage volume. Possible values include `AzureFile` and `EmptyDir`. Defaults to `EmptyDir`.
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary>A template block as detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProviderTemplate
{
    /// <summary>One or more azure_queue_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("azureQueueScaleRule")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateAzureQueueScaleRule>? AzureQueueScaleRule { get; set; }

    /// <summary>One or more container blocks as detailed below.</summary>
    [JsonPropertyName("container")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateContainer>? Container { get; set; }

    /// <summary>
    /// The number of seconds to wait before scaling down the number of instances again. Defaults to 300.
    /// The number of seconds to wait before scaling down the number of instances again.
    /// </summary>
    [JsonPropertyName("cooldownPeriodInSeconds")]
    public double? CooldownPeriodInSeconds { get; set; }

    /// <summary>One or more custom_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("customScaleRule")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateCustomScaleRule>? CustomScaleRule { get; set; }

    /// <summary>One or more http_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("httpScaleRule")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateHttpScaleRule>? HttpScaleRule { get; set; }

    /// <summary>The definition of an init container that is part of the group as documented in the init_container block below.</summary>
    [JsonPropertyName("initContainer")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateInitContainer>? InitContainer { get; set; }

    /// <summary>
    /// The maximum number of replicas for this container.
    /// The maximum number of replicas for this container.
    /// </summary>
    [JsonPropertyName("maxReplicas")]
    public double? MaxReplicas { get; set; }

    /// <summary>
    /// The minimum number of replicas for this container.
    /// The minimum number of replicas for this container.
    /// </summary>
    [JsonPropertyName("minReplicas")]
    public double? MinReplicas { get; set; }

    /// <summary>
    /// The interval in seconds used for polling KEDA. Defaults to 30.
    /// The interval in seconds used for polling KEDA.
    /// </summary>
    [JsonPropertyName("pollingIntervalInSeconds")]
    public double? PollingIntervalInSeconds { get; set; }

    /// <summary>
    /// The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
    /// The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
    /// </summary>
    [JsonPropertyName("revisionSuffix")]
    public string? RevisionSuffix { get; set; }

    /// <summary>One or more tcp_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("tcpScaleRule")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateTcpScaleRule>? TcpScaleRule { get; set; }

    /// <summary>
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// </summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public double? TerminationGracePeriodSeconds { get; set; }

    /// <summary>A volume block as detailed below.</summary>
    [JsonPropertyName("volume")]
    public IList<V1beta2ContainerAppSpecForProviderTemplateVolume>? Volume { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecForProvider
{
    /// <summary>
    /// The ID of the Container App Environment within which this Container App should exist. Changing this forces a new resource to be created.
    /// The ID of the Container App Environment to host this Container App.
    /// </summary>
    [JsonPropertyName("containerAppEnvironmentId")]
    public string? ContainerAppEnvironmentId { get; set; }

    /// <summary>Reference to a Environment in containerapp to populate containerAppEnvironmentId.</summary>
    [JsonPropertyName("containerAppEnvironmentIdRef")]
    public V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdRef? ContainerAppEnvironmentIdRef { get; set; }

    /// <summary>Selector for a Environment in containerapp to populate containerAppEnvironmentId.</summary>
    [JsonPropertyName("containerAppEnvironmentIdSelector")]
    public V1beta2ContainerAppSpecForProviderContainerAppEnvironmentIdSelector? ContainerAppEnvironmentIdSelector { get; set; }

    /// <summary>A dapr block as detailed below.</summary>
    [JsonPropertyName("dapr")]
    public V1beta2ContainerAppSpecForProviderDapr? Dapr { get; set; }

    /// <summary>An identity block as detailed below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2ContainerAppSpecForProviderIdentity? Identity { get; set; }

    /// <summary>An ingress block as detailed below.</summary>
    [JsonPropertyName("ingress")]
    public V1beta2ContainerAppSpecForProviderIngress? Ingress { get; set; }

    /// <summary>The maximum of inactive revisions allowed for this Container App.</summary>
    [JsonPropertyName("maxInactiveRevisions")]
    public double? MaxInactiveRevisions { get; set; }

    /// <summary>A registry block as detailed below.</summary>
    [JsonPropertyName("registry")]
    public IList<V1beta2ContainerAppSpecForProviderRegistry>? Registry { get; set; }

    /// <summary>The name of the resource group in which the Container App Environment is to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2ContainerAppSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2ContainerAppSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The revisions operational mode for the Container App. Possible values include Single and Multiple. In Single mode, a single revision is in operation at any given time. In Multiple mode, more than one revision can be active at a time and can be configured with load distribution via the traffic_weight block in the ingress configuration.</summary>
    [JsonPropertyName("revisionMode")]
    public string? RevisionMode { get; set; }

    /// <summary>One or more secret block as detailed below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta2ContainerAppSpecForProviderSecret>? Secret { get; set; }

    /// <summary>A mapping of tags to assign to the Container App.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A template block as detailed below.</summary>
    [JsonPropertyName("template")]
    public V1beta2ContainerAppSpecForProviderTemplate? Template { get; set; }

    /// <summary>The name of the Workload Profile in the Container App Environment to place this Container App.</summary>
    [JsonPropertyName("workloadProfileName")]
    public string? WorkloadProfileName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdRefPolicyResolutionEnum>))]
public enum V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdRefPolicyResolveEnum>))]
public enum V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Environment in containerapp to populate containerAppEnvironmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdSelectorPolicyResolveEnum>))]
public enum V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Environment in containerapp to populate containerAppEnvironmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdSelector
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
    public V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A dapr block as detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderDapr
{
    /// <summary>
    /// The Dapr Application Identifier.
    /// The Dapr Application Identifier.
    /// </summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>
    /// The port which the application is listening on. This is the same as the ingress port.
    /// The port which the application is listening on. This is the same as the `ingress` port.
    /// </summary>
    [JsonPropertyName("appPort")]
    public double? AppPort { get; set; }

    /// <summary>
    /// The protocol for the app. Possible values include http and grpc. Defaults to http.
    /// The protocol for the app. Possible values include `http` and `grpc`. Defaults to `http`.
    /// </summary>
    [JsonPropertyName("appProtocol")]
    public string? AppProtocol { get; set; }
}

/// <summary>An identity block as detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderIdentity
{
    /// <summary>- A list of one or more Resource IDs for User Assigned Managed identities to assign. Required when type is set to UserAssigned or SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of managed identity to assign. Possible values are SystemAssigned, UserAssigned, and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A cors block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderIngressCors
{
    /// <summary>Whether user credentials are allowed in the cross-origin request is enabled. Defaults to false.</summary>
    [JsonPropertyName("allowCredentialsEnabled")]
    public bool? AllowCredentialsEnabled { get; set; }

    /// <summary>Specifies the list of request headers that are permitted in the actual request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>Specifies the list of HTTP methods are allowed when accessing the resource in a cross-origin request.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Specifies the list of origins that are allowed to make cross-origin calls.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Specifies the list of headers exposed to the browser in the response to a cross-origin request.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>Specifies the number of seconds that the browser can cache the results of a preflight request.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderIngressIpSecurityRestriction
{
    /// <summary>
    /// The IP-filter action. Allow or Deny.
    /// The action. Allow or Deny.
    /// </summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>
    /// Describe the IP restriction rule that is being sent to the container-app.
    /// Describe the IP restriction rule that is being sent to the container-app.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The incoming IP address or range of IP addresses (in CIDR notation).
    /// The incoming IP address or range of IP addresses (in CIDR notation).
    /// </summary>
    [JsonPropertyName("ipAddressRange")]
    public string? IpAddressRange { get; set; }

    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// Name for the IP restriction rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderIngressTrafficWeight
{
    /// <summary>
    /// The label to apply to the revision as a name prefix for routing traffic.
    /// The label to apply to the revision as a name prefix for routing traffic.
    /// </summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>
    /// This traffic Weight applies to the latest stable Container Revision. At most only one traffic_weight block can have the latest_revision set to true.
    /// This traffic Weight relates to the latest stable Container Revision.
    /// </summary>
    [JsonPropertyName("latestRevision")]
    public bool? LatestRevision { get; set; }

    /// <summary>
    /// The percentage of traffic which should be sent this revision.
    /// The percentage of traffic to send to this revision.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }

    /// <summary>
    /// The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
    /// The suffix string to append to the revision. This must be unique for the Container App&apos;s lifetime. A default hash created by the service will be used if this value is omitted.
    /// </summary>
    [JsonPropertyName("revisionSuffix")]
    public string? RevisionSuffix { get; set; }
}

/// <summary>An ingress block as detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderIngress
{
    /// <summary>
    /// Should this ingress allow insecure connections?
    /// Should this ingress allow insecure connections?
    /// </summary>
    [JsonPropertyName("allowInsecureConnections")]
    public bool? AllowInsecureConnections { get; set; }

    /// <summary>
    /// The client certificate mode for the Ingress. Possible values are require, accept, and ignore.
    /// Client certificate mode for mTLS authentication. Ignore indicates server drops client certificate on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require indicates server requires a client certificate.
    /// </summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public V1beta2ContainerAppSpecInitProviderIngressCors? Cors { get; set; }

    /// <summary>
    /// The exposed port on the container for the Ingress traffic.
    /// The exposed port on the container for the Ingress traffic.
    /// </summary>
    [JsonPropertyName("exposedPort")]
    public double? ExposedPort { get; set; }

    /// <summary>
    /// Are connections to this Ingress from outside the Container App Environment enabled? Defaults to false.
    /// Is this an external Ingress.
    /// </summary>
    [JsonPropertyName("externalEnabled")]
    public bool? ExternalEnabled { get; set; }

    /// <summary>One or more ip_security_restriction blocks for IP-filtering rules as defined below.</summary>
    [JsonPropertyName("ipSecurityRestriction")]
    public IList<V1beta2ContainerAppSpecInitProviderIngressIpSecurityRestriction>? IpSecurityRestriction { get; set; }

    /// <summary>
    /// The target port on the container for the Ingress traffic.
    /// The target port on the container for the Ingress traffic.
    /// </summary>
    [JsonPropertyName("targetPort")]
    public double? TargetPort { get; set; }

    /// <summary>One or more traffic_weight blocks as detailed below.</summary>
    [JsonPropertyName("trafficWeight")]
    public IList<V1beta2ContainerAppSpecInitProviderIngressTrafficWeight>? TrafficWeight { get; set; }

    /// <summary>
    /// The transport method for the Ingress. Possible values are auto, http, http2 and tcp. Defaults to auto.
    /// The transport method for the Ingress. Possible values include `auto`, `http`, and `http2`, `tcp`. Defaults to `auto`
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderRegistry
{
    /// <summary>
    /// Resource ID for the User Assigned Managed identity to use when pulling from the Container Registry.
    /// ID of the System or User Managed Identity used to pull images from the Container Registry
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>
    /// The name of the Secret Reference containing the password value for this user on the Container Registry, username must also be supplied.
    /// The name of the Secret Reference containing the password value for this user on the Container Registry.
    /// </summary>
    [JsonPropertyName("passwordSecretName")]
    public string? PasswordSecretName { get; set; }

    /// <summary>
    /// The hostname for the Container Registry.
    /// The hostname for the Container Registry.
    /// </summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>
    /// The username to use for this Container Registry, password_secret_name must also be supplied..
    /// The username to use for this Container Registry.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// The secret name.
/// The secret name.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderSecretNameSecretRef
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
/// The value for this secret.
/// The value for this secret.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderSecretValueSecretRef
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
public partial class V1beta2ContainerAppSpecInitProviderSecret
{
    /// <summary>
    /// The identity to use for accessing the Key Vault secret reference. This can either be the Resource ID of a User Assigned Identity, or System for the System Assigned Identity.
    /// The identity to use for accessing key vault reference.
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>
    /// The ID of a Key Vault secret. This can be a versioned or version-less ID.
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>
    /// The secret name.
    /// The secret name.
    /// </summary>
    [JsonPropertyName("nameSecretRef")]
    public required V1beta2ContainerAppSpecInitProviderSecretNameSecretRef NameSecretRef { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The value for this secret.
    /// </summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta2ContainerAppSpecInitProviderSecretValueSecretRef? ValueSecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateAzureQueueScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateAzureQueueScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateAzureQueueScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the length of the queue to trigger scaling actions.</summary>
    [JsonPropertyName("queueLength")]
    public double? QueueLength { get; set; }

    /// <summary>The name of the Azure Queue</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateContainerEnv
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the environment variable for the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the secret that contains the value for this environment variable.
    /// The name of the secret that contains the value for this environment variable.
    /// </summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateContainerLivenessProbeHeader
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The HTTP Header Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The HTTP Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateContainerLivenessProbe
{
    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 30. Defaults to 3.
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateContainerLivenessProbeHeader>? Header { get; set; }

    /// <summary>
    /// The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes.
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds.
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `1` seconds.
    /// </summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// The path in the container at which to mount this volume.
    /// The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The port number on which to connect. Possible values are between 1 and 65535.
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1.
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Type of probe. Possible values are TCP, HTTP, and HTTPS.
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateContainerReadinessProbeHeader
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The HTTP Header Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The HTTP Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateContainerReadinessProbe
{
    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 30. Defaults to 3.
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateContainerReadinessProbeHeader>? Header { get; set; }

    /// <summary>
    /// The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes.
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds.
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.
    /// </summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// The path in the container at which to mount this volume.
    /// The URI to use for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The port number on which to connect. Possible values are between 1 and 65535.
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The number of consecutive successful responses required to consider this probe as successful. Possible values are between 1 and 10. Defaults to 3.
    /// The number of consecutive successful responses required to consider this probe as successful. Possible values are between `1` and `10`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("successCountThreshold")]
    public double? SuccessCountThreshold { get; set; }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1.
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Type of probe. Possible values are TCP, HTTP, and HTTPS.
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateContainerStartupProbeHeader
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The HTTP Header Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The HTTP Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateContainerStartupProbe
{
    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 30. Defaults to 3.
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateContainerStartupProbeHeader>? Header { get; set; }

    /// <summary>
    /// The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes.
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds.
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.
    /// </summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// The path in the container at which to mount this volume.
    /// The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The port number on which to connect. Possible values are between 1 and 65535.
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1.
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Type of probe. Possible values are TCP, HTTP, and HTTPS.
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateContainerVolumeMounts
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the Volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The path in the container at which to mount this volume.
    /// The path in the container at which to mount this volume.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The sub path of the volume to be mounted in the container.
    /// The sub path of the volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateContainer
{
    /// <summary>
    /// A list of extra arguments to pass to the container.
    /// A list of args to pass to the container.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// </summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>
    /// The amount of vCPU to allocate to the container.
    /// The amount of vCPU to allocate to the container.
    /// </summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>One or more env blocks as detailed below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateContainerEnv>? Env { get; set; }

    /// <summary>
    /// The image to use to create the container.
    /// The image to use to create the container.
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>A liveness_probe block as detailed below.</summary>
    [JsonPropertyName("livenessProbe")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateContainerLivenessProbe>? LivenessProbe { get; set; }

    /// <summary>
    /// The amount of memory to allocate to the container.
    /// The amount of memory to allocate to the container.
    /// </summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A readiness_probe block as detailed below.</summary>
    [JsonPropertyName("readinessProbe")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateContainerReadinessProbe>? ReadinessProbe { get; set; }

    /// <summary>A startup_probe block as detailed below.</summary>
    [JsonPropertyName("startupProbe")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateContainerStartupProbe>? StartupProbe { get; set; }

    /// <summary>A volume_mounts block as detailed below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateContainerVolumeMounts>? VolumeMounts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateCustomScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateCustomScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateCustomScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>The Custom rule type. Possible values include: activemq, artemis-queue, kafka, pulsar, aws-cloudwatch, aws-dynamodb, aws-dynamodb-streams, aws-kinesis-stream, aws-sqs-queue, azure-app-insights, azure-blob, azure-data-explorer, azure-eventhub, azure-log-analytics, azure-monitor, azure-pipelines, azure-servicebus, azure-queue, cassandra, cpu, cron, datadog, elasticsearch, external, external-push, gcp-stackdriver, gcp-storage, gcp-pubsub, graphite, http, huawei-cloudeye, ibmmq, influxdb, kubernetes-workload, liiklus, memory, metrics-api, mongodb, mssql, mysql, nats-jetstream, stan, tcp, new-relic, openstack-metric, openstack-swift, postgresql, predictkube, prometheus, rabbitmq, redis, redis-cluster, redis-sentinel, redis-streams, redis-cluster-streams, redis-sentinel-streams, selenium-grid,solace-event-queue, and github-runner.</summary>
    [JsonPropertyName("customRuleType")]
    public string? CustomRuleType { get; set; }

    /// <summary>- A map of string key-value pairs to configure the Custom Scale Rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateHttpScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateHttpScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateHttpScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>- The number of concurrent requests to trigger scaling.</summary>
    [JsonPropertyName("concurrentRequests")]
    public string? ConcurrentRequests { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateInitContainerEnv
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the environment variable for the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the secret that contains the value for this environment variable.
    /// The name of the secret that contains the value for this environment variable.
    /// </summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateInitContainerVolumeMounts
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the Volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The path in the container at which to mount this volume.
    /// The path in the container at which to mount this volume.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The sub path of the volume to be mounted in the container.
    /// The sub path of the volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateInitContainer
{
    /// <summary>
    /// A list of extra arguments to pass to the container.
    /// A list of args to pass to the container.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// </summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>
    /// The amount of vCPU to allocate to the container.
    /// The amount of vCPU to allocate to the container.
    /// </summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>One or more env blocks as detailed below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateInitContainerEnv>? Env { get; set; }

    /// <summary>
    /// The image to use to create the container.
    /// The image to use to create the container.
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// The amount of memory to allocate to the container.
    /// The amount of memory to allocate to the container.
    /// </summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A volume_mounts block as detailed below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateInitContainerVolumeMounts>? VolumeMounts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateTcpScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateTcpScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateTcpScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>- The number of concurrent requests to trigger scaling.</summary>
    [JsonPropertyName("concurrentRequests")]
    public string? ConcurrentRequests { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplateVolume
{
    /// <summary>
    /// Mount options used while mounting the AzureFile. Must be a comma-separated string e.g. dir_mode=0751,file_mode=0751.
    /// Mount options used while mounting the AzureFile. Must be a comma-separated string.
    /// </summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the volume.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the AzureFile storage.
    /// The name of the `AzureFile` storage. Required when `storage_type` is `AzureFile`
    /// </summary>
    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }

    /// <summary>
    /// The type of storage volume. Possible values are AzureFile, EmptyDir, NfsAzureFile and Secret. Defaults to EmptyDir.
    /// The type of storage volume. Possible values include `AzureFile` and `EmptyDir`. Defaults to `EmptyDir`.
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary>A template block as detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecInitProviderTemplate
{
    /// <summary>One or more azure_queue_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("azureQueueScaleRule")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateAzureQueueScaleRule>? AzureQueueScaleRule { get; set; }

    /// <summary>One or more container blocks as detailed below.</summary>
    [JsonPropertyName("container")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateContainer>? Container { get; set; }

    /// <summary>
    /// The number of seconds to wait before scaling down the number of instances again. Defaults to 300.
    /// The number of seconds to wait before scaling down the number of instances again.
    /// </summary>
    [JsonPropertyName("cooldownPeriodInSeconds")]
    public double? CooldownPeriodInSeconds { get; set; }

    /// <summary>One or more custom_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("customScaleRule")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateCustomScaleRule>? CustomScaleRule { get; set; }

    /// <summary>One or more http_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("httpScaleRule")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateHttpScaleRule>? HttpScaleRule { get; set; }

    /// <summary>The definition of an init container that is part of the group as documented in the init_container block below.</summary>
    [JsonPropertyName("initContainer")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateInitContainer>? InitContainer { get; set; }

    /// <summary>
    /// The maximum number of replicas for this container.
    /// The maximum number of replicas for this container.
    /// </summary>
    [JsonPropertyName("maxReplicas")]
    public double? MaxReplicas { get; set; }

    /// <summary>
    /// The minimum number of replicas for this container.
    /// The minimum number of replicas for this container.
    /// </summary>
    [JsonPropertyName("minReplicas")]
    public double? MinReplicas { get; set; }

    /// <summary>
    /// The interval in seconds used for polling KEDA. Defaults to 30.
    /// The interval in seconds used for polling KEDA.
    /// </summary>
    [JsonPropertyName("pollingIntervalInSeconds")]
    public double? PollingIntervalInSeconds { get; set; }

    /// <summary>
    /// The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
    /// The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
    /// </summary>
    [JsonPropertyName("revisionSuffix")]
    public string? RevisionSuffix { get; set; }

    /// <summary>One or more tcp_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("tcpScaleRule")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateTcpScaleRule>? TcpScaleRule { get; set; }

    /// <summary>
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// </summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public double? TerminationGracePeriodSeconds { get; set; }

    /// <summary>A volume block as detailed below.</summary>
    [JsonPropertyName("volume")]
    public IList<V1beta2ContainerAppSpecInitProviderTemplateVolume>? Volume { get; set; }
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
public partial class V1beta2ContainerAppSpecInitProvider
{
    /// <summary>
    /// The ID of the Container App Environment within which this Container App should exist. Changing this forces a new resource to be created.
    /// The ID of the Container App Environment to host this Container App.
    /// </summary>
    [JsonPropertyName("containerAppEnvironmentId")]
    public string? ContainerAppEnvironmentId { get; set; }

    /// <summary>Reference to a Environment in containerapp to populate containerAppEnvironmentId.</summary>
    [JsonPropertyName("containerAppEnvironmentIdRef")]
    public V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdRef? ContainerAppEnvironmentIdRef { get; set; }

    /// <summary>Selector for a Environment in containerapp to populate containerAppEnvironmentId.</summary>
    [JsonPropertyName("containerAppEnvironmentIdSelector")]
    public V1beta2ContainerAppSpecInitProviderContainerAppEnvironmentIdSelector? ContainerAppEnvironmentIdSelector { get; set; }

    /// <summary>A dapr block as detailed below.</summary>
    [JsonPropertyName("dapr")]
    public V1beta2ContainerAppSpecInitProviderDapr? Dapr { get; set; }

    /// <summary>An identity block as detailed below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2ContainerAppSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>An ingress block as detailed below.</summary>
    [JsonPropertyName("ingress")]
    public V1beta2ContainerAppSpecInitProviderIngress? Ingress { get; set; }

    /// <summary>The maximum of inactive revisions allowed for this Container App.</summary>
    [JsonPropertyName("maxInactiveRevisions")]
    public double? MaxInactiveRevisions { get; set; }

    /// <summary>A registry block as detailed below.</summary>
    [JsonPropertyName("registry")]
    public IList<V1beta2ContainerAppSpecInitProviderRegistry>? Registry { get; set; }

    /// <summary>The revisions operational mode for the Container App. Possible values include Single and Multiple. In Single mode, a single revision is in operation at any given time. In Multiple mode, more than one revision can be active at a time and can be configured with load distribution via the traffic_weight block in the ingress configuration.</summary>
    [JsonPropertyName("revisionMode")]
    public string? RevisionMode { get; set; }

    /// <summary>One or more secret block as detailed below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta2ContainerAppSpecInitProviderSecret>? Secret { get; set; }

    /// <summary>A mapping of tags to assign to the Container App.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A template block as detailed below.</summary>
    [JsonPropertyName("template")]
    public V1beta2ContainerAppSpecInitProviderTemplate? Template { get; set; }

    /// <summary>The name of the Workload Profile in the Container App Environment to place this Container App.</summary>
    [JsonPropertyName("workloadProfileName")]
    public string? WorkloadProfileName { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ContainerAppSpecManagementPoliciesEnum>))]
public enum V1beta2ContainerAppSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ContainerAppSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ContainerAppSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ContainerAppSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ContainerAppSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ContainerAppSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ContainerAppSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ContainerAppSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ContainerAppSpec defines the desired state of ContainerApp</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppSpec
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
    public V1beta2ContainerAppSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ContainerAppSpecForProvider ForProvider { get; set; }

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
    public V1beta2ContainerAppSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ContainerAppSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ContainerAppSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ContainerAppSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A dapr block as detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderDapr
{
    /// <summary>
    /// The Dapr Application Identifier.
    /// The Dapr Application Identifier.
    /// </summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>
    /// The port which the application is listening on. This is the same as the ingress port.
    /// The port which the application is listening on. This is the same as the `ingress` port.
    /// </summary>
    [JsonPropertyName("appPort")]
    public double? AppPort { get; set; }

    /// <summary>
    /// The protocol for the app. Possible values include http and grpc. Defaults to http.
    /// The protocol for the app. Possible values include `http` and `grpc`. Defaults to `http`.
    /// </summary>
    [JsonPropertyName("appProtocol")]
    public string? AppProtocol { get; set; }
}

/// <summary>An identity block as detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderIdentity
{
    /// <summary>- A list of one or more Resource IDs for User Assigned Managed identities to assign. Required when type is set to UserAssigned or SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The ID of the Container App.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The ID of the Container App.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The type of managed identity to assign. Possible values are SystemAssigned, UserAssigned, and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A cors block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderIngressCors
{
    /// <summary>Whether user credentials are allowed in the cross-origin request is enabled. Defaults to false.</summary>
    [JsonPropertyName("allowCredentialsEnabled")]
    public bool? AllowCredentialsEnabled { get; set; }

    /// <summary>Specifies the list of request headers that are permitted in the actual request.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>Specifies the list of HTTP methods are allowed when accessing the resource in a cross-origin request.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Specifies the list of origins that are allowed to make cross-origin calls.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Specifies the list of headers exposed to the browser in the response to a cross-origin request.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>Specifies the number of seconds that the browser can cache the results of a preflight request.</summary>
    [JsonPropertyName("maxAgeInSeconds")]
    public double? MaxAgeInSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderIngressCustomDomain
{
    /// <summary>The Binding type.</summary>
    [JsonPropertyName("certificateBindingType")]
    public string? CertificateBindingType { get; set; }

    /// <summary>The ID of the Container App Environment Certificate.</summary>
    [JsonPropertyName("certificateId")]
    public string? CertificateId { get; set; }

    /// <summary>The hostname of the Certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderIngressIpSecurityRestriction
{
    /// <summary>
    /// The IP-filter action. Allow or Deny.
    /// The action. Allow or Deny.
    /// </summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>
    /// Describe the IP restriction rule that is being sent to the container-app.
    /// Describe the IP restriction rule that is being sent to the container-app.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The incoming IP address or range of IP addresses (in CIDR notation).
    /// The incoming IP address or range of IP addresses (in CIDR notation).
    /// </summary>
    [JsonPropertyName("ipAddressRange")]
    public string? IpAddressRange { get; set; }

    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// Name for the IP restriction rule.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderIngressTrafficWeight
{
    /// <summary>
    /// The label to apply to the revision as a name prefix for routing traffic.
    /// The label to apply to the revision as a name prefix for routing traffic.
    /// </summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>
    /// This traffic Weight applies to the latest stable Container Revision. At most only one traffic_weight block can have the latest_revision set to true.
    /// This traffic Weight relates to the latest stable Container Revision.
    /// </summary>
    [JsonPropertyName("latestRevision")]
    public bool? LatestRevision { get; set; }

    /// <summary>
    /// The percentage of traffic which should be sent this revision.
    /// The percentage of traffic to send to this revision.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }

    /// <summary>
    /// The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
    /// The suffix string to append to the revision. This must be unique for the Container App&apos;s lifetime. A default hash created by the service will be used if this value is omitted.
    /// </summary>
    [JsonPropertyName("revisionSuffix")]
    public string? RevisionSuffix { get; set; }
}

/// <summary>An ingress block as detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderIngress
{
    /// <summary>
    /// Should this ingress allow insecure connections?
    /// Should this ingress allow insecure connections?
    /// </summary>
    [JsonPropertyName("allowInsecureConnections")]
    public bool? AllowInsecureConnections { get; set; }

    /// <summary>
    /// The client certificate mode for the Ingress. Possible values are require, accept, and ignore.
    /// Client certificate mode for mTLS authentication. Ignore indicates server drops client certificate on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require indicates server requires a client certificate.
    /// </summary>
    [JsonPropertyName("clientCertificateMode")]
    public string? ClientCertificateMode { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public V1beta2ContainerAppStatusAtProviderIngressCors? Cors { get; set; }

    /// <summary>One or more custom_domain block as detailed below.</summary>
    [JsonPropertyName("customDomain")]
    public IList<V1beta2ContainerAppStatusAtProviderIngressCustomDomain>? CustomDomain { get; set; }

    /// <summary>
    /// The exposed port on the container for the Ingress traffic.
    /// The exposed port on the container for the Ingress traffic.
    /// </summary>
    [JsonPropertyName("exposedPort")]
    public double? ExposedPort { get; set; }

    /// <summary>
    /// Are connections to this Ingress from outside the Container App Environment enabled? Defaults to false.
    /// Is this an external Ingress.
    /// </summary>
    [JsonPropertyName("externalEnabled")]
    public bool? ExternalEnabled { get; set; }

    /// <summary>
    /// The FQDN of the ingress.
    /// The FQDN of the ingress.
    /// </summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>One or more ip_security_restriction blocks for IP-filtering rules as defined below.</summary>
    [JsonPropertyName("ipSecurityRestriction")]
    public IList<V1beta2ContainerAppStatusAtProviderIngressIpSecurityRestriction>? IpSecurityRestriction { get; set; }

    /// <summary>
    /// The target port on the container for the Ingress traffic.
    /// The target port on the container for the Ingress traffic.
    /// </summary>
    [JsonPropertyName("targetPort")]
    public double? TargetPort { get; set; }

    /// <summary>One or more traffic_weight blocks as detailed below.</summary>
    [JsonPropertyName("trafficWeight")]
    public IList<V1beta2ContainerAppStatusAtProviderIngressTrafficWeight>? TrafficWeight { get; set; }

    /// <summary>
    /// The transport method for the Ingress. Possible values are auto, http, http2 and tcp. Defaults to auto.
    /// The transport method for the Ingress. Possible values include `auto`, `http`, and `http2`, `tcp`. Defaults to `auto`
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderRegistry
{
    /// <summary>
    /// Resource ID for the User Assigned Managed identity to use when pulling from the Container Registry.
    /// ID of the System or User Managed Identity used to pull images from the Container Registry
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>
    /// The name of the Secret Reference containing the password value for this user on the Container Registry, username must also be supplied.
    /// The name of the Secret Reference containing the password value for this user on the Container Registry.
    /// </summary>
    [JsonPropertyName("passwordSecretName")]
    public string? PasswordSecretName { get; set; }

    /// <summary>
    /// The hostname for the Container Registry.
    /// The hostname for the Container Registry.
    /// </summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>
    /// The username to use for this Container Registry, password_secret_name must also be supplied..
    /// The username to use for this Container Registry.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderSecret
{
    /// <summary>
    /// The identity to use for accessing the Key Vault secret reference. This can either be the Resource ID of a User Assigned Identity, or System for the System Assigned Identity.
    /// The identity to use for accessing key vault reference.
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>
    /// The ID of a Key Vault secret. This can be a versioned or version-less ID.
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateAzureQueueScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateAzureQueueScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateAzureQueueScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the length of the queue to trigger scaling actions.</summary>
    [JsonPropertyName("queueLength")]
    public double? QueueLength { get; set; }

    /// <summary>The name of the Azure Queue</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateContainerEnv
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the environment variable for the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the secret that contains the value for this environment variable.
    /// The name of the secret that contains the value for this environment variable.
    /// </summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateContainerLivenessProbeHeader
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The HTTP Header Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The HTTP Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateContainerLivenessProbe
{
    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 30. Defaults to 3.
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateContainerLivenessProbeHeader>? Header { get; set; }

    /// <summary>
    /// The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes.
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds.
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `1` seconds.
    /// </summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// The path in the container at which to mount this volume.
    /// The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The port number on which to connect. Possible values are between 1 and 65535.
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// </summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public double? TerminationGracePeriodSeconds { get; set; }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1.
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Type of probe. Possible values are TCP, HTTP, and HTTPS.
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateContainerReadinessProbeHeader
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The HTTP Header Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The HTTP Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateContainerReadinessProbe
{
    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 30. Defaults to 3.
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateContainerReadinessProbeHeader>? Header { get; set; }

    /// <summary>
    /// The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes.
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds.
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.
    /// </summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// The path in the container at which to mount this volume.
    /// The URI to use for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The port number on which to connect. Possible values are between 1 and 65535.
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The number of consecutive successful responses required to consider this probe as successful. Possible values are between 1 and 10. Defaults to 3.
    /// The number of consecutive successful responses required to consider this probe as successful. Possible values are between `1` and `10`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("successCountThreshold")]
    public double? SuccessCountThreshold { get; set; }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1.
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Type of probe. Possible values are TCP, HTTP, and HTTPS.
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateContainerStartupProbeHeader
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The HTTP Header Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The HTTP Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateContainerStartupProbe
{
    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 30. Defaults to 3.
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateContainerStartupProbeHeader>? Header { get; set; }

    /// <summary>
    /// The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes.
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds.
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.
    /// </summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// The path in the container at which to mount this volume.
    /// The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The port number on which to connect. Possible values are between 1 and 65535.
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// </summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public double? TerminationGracePeriodSeconds { get; set; }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1.
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Type of probe. Possible values are TCP, HTTP, and HTTPS.
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateContainerVolumeMounts
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the Volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The path in the container at which to mount this volume.
    /// The path in the container at which to mount this volume.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The sub path of the volume to be mounted in the container.
    /// The sub path of the volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateContainer
{
    /// <summary>
    /// A list of extra arguments to pass to the container.
    /// A list of args to pass to the container.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// </summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>
    /// The amount of vCPU to allocate to the container.
    /// The amount of vCPU to allocate to the container.
    /// </summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>One or more env blocks as detailed below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateContainerEnv>? Env { get; set; }

    /// <summary>
    /// The amount of ephemeral storage available to the Container App.
    /// The amount of ephemeral storage available to the Container App.
    /// </summary>
    [JsonPropertyName("ephemeralStorage")]
    public string? EphemeralStorage { get; set; }

    /// <summary>
    /// The image to use to create the container.
    /// The image to use to create the container.
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>A liveness_probe block as detailed below.</summary>
    [JsonPropertyName("livenessProbe")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateContainerLivenessProbe>? LivenessProbe { get; set; }

    /// <summary>
    /// The amount of memory to allocate to the container.
    /// The amount of memory to allocate to the container.
    /// </summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A readiness_probe block as detailed below.</summary>
    [JsonPropertyName("readinessProbe")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateContainerReadinessProbe>? ReadinessProbe { get; set; }

    /// <summary>A startup_probe block as detailed below.</summary>
    [JsonPropertyName("startupProbe")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateContainerStartupProbe>? StartupProbe { get; set; }

    /// <summary>A volume_mounts block as detailed below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateContainerVolumeMounts>? VolumeMounts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateCustomScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateCustomScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateCustomScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>The Custom rule type. Possible values include: activemq, artemis-queue, kafka, pulsar, aws-cloudwatch, aws-dynamodb, aws-dynamodb-streams, aws-kinesis-stream, aws-sqs-queue, azure-app-insights, azure-blob, azure-data-explorer, azure-eventhub, azure-log-analytics, azure-monitor, azure-pipelines, azure-servicebus, azure-queue, cassandra, cpu, cron, datadog, elasticsearch, external, external-push, gcp-stackdriver, gcp-storage, gcp-pubsub, graphite, http, huawei-cloudeye, ibmmq, influxdb, kubernetes-workload, liiklus, memory, metrics-api, mongodb, mssql, mysql, nats-jetstream, stan, tcp, new-relic, openstack-metric, openstack-swift, postgresql, predictkube, prometheus, rabbitmq, redis, redis-cluster, redis-sentinel, redis-streams, redis-cluster-streams, redis-sentinel-streams, selenium-grid,solace-event-queue, and github-runner.</summary>
    [JsonPropertyName("customRuleType")]
    public string? CustomRuleType { get; set; }

    /// <summary>- A map of string key-value pairs to configure the Custom Scale Rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateHttpScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateHttpScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateHttpScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>- The number of concurrent requests to trigger scaling.</summary>
    [JsonPropertyName("concurrentRequests")]
    public string? ConcurrentRequests { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateInitContainerEnv
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the environment variable for the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the secret that contains the value for this environment variable.
    /// The name of the secret that contains the value for this environment variable.
    /// </summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateInitContainerVolumeMounts
{
    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the Volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The path in the container at which to mount this volume.
    /// The path in the container at which to mount this volume.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The sub path of the volume to be mounted in the container.
    /// The sub path of the volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateInitContainer
{
    /// <summary>
    /// A list of extra arguments to pass to the container.
    /// A list of args to pass to the container.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// </summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>
    /// The amount of vCPU to allocate to the container.
    /// The amount of vCPU to allocate to the container.
    /// </summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>One or more env blocks as detailed below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateInitContainerEnv>? Env { get; set; }

    /// <summary>
    /// The amount of ephemeral storage available to the Container App.
    /// The amount of ephemeral storage available to the Container App.
    /// </summary>
    [JsonPropertyName("ephemeralStorage")]
    public string? EphemeralStorage { get; set; }

    /// <summary>
    /// The image to use to create the container.
    /// The image to use to create the container.
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// The amount of memory to allocate to the container.
    /// The amount of memory to allocate to the container.
    /// </summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A volume_mounts block as detailed below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateInitContainerVolumeMounts>? VolumeMounts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateTcpScaleRuleAuthentication
{
    /// <summary>The name of the secret that contains the value for this environment variable.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>The Trigger Parameter name to use the supply the value retrieved from the secret_name.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateTcpScaleRule
{
    /// <summary>Zero or more authentication blocks as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateTcpScaleRuleAuthentication>? Authentication { get; set; }

    /// <summary>- The number of concurrent requests to trigger scaling.</summary>
    [JsonPropertyName("concurrentRequests")]
    public string? ConcurrentRequests { get; set; }

    /// <summary>The name of the Volume to be mounted in the container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplateVolume
{
    /// <summary>
    /// Mount options used while mounting the AzureFile. Must be a comma-separated string e.g. dir_mode=0751,file_mode=0751.
    /// Mount options used while mounting the AzureFile. Must be a comma-separated string.
    /// </summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>
    /// The name of the Volume to be mounted in the container.
    /// The name of the volume.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the AzureFile storage.
    /// The name of the `AzureFile` storage. Required when `storage_type` is `AzureFile`
    /// </summary>
    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }

    /// <summary>
    /// The type of storage volume. Possible values are AzureFile, EmptyDir, NfsAzureFile and Secret. Defaults to EmptyDir.
    /// The type of storage volume. Possible values include `AzureFile` and `EmptyDir`. Defaults to `EmptyDir`.
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary>A template block as detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProviderTemplate
{
    /// <summary>One or more azure_queue_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("azureQueueScaleRule")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateAzureQueueScaleRule>? AzureQueueScaleRule { get; set; }

    /// <summary>One or more container blocks as detailed below.</summary>
    [JsonPropertyName("container")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateContainer>? Container { get; set; }

    /// <summary>
    /// The number of seconds to wait before scaling down the number of instances again. Defaults to 300.
    /// The number of seconds to wait before scaling down the number of instances again.
    /// </summary>
    [JsonPropertyName("cooldownPeriodInSeconds")]
    public double? CooldownPeriodInSeconds { get; set; }

    /// <summary>One or more custom_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("customScaleRule")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateCustomScaleRule>? CustomScaleRule { get; set; }

    /// <summary>One or more http_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("httpScaleRule")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateHttpScaleRule>? HttpScaleRule { get; set; }

    /// <summary>The definition of an init container that is part of the group as documented in the init_container block below.</summary>
    [JsonPropertyName("initContainer")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateInitContainer>? InitContainer { get; set; }

    /// <summary>
    /// The maximum number of replicas for this container.
    /// The maximum number of replicas for this container.
    /// </summary>
    [JsonPropertyName("maxReplicas")]
    public double? MaxReplicas { get; set; }

    /// <summary>
    /// The minimum number of replicas for this container.
    /// The minimum number of replicas for this container.
    /// </summary>
    [JsonPropertyName("minReplicas")]
    public double? MinReplicas { get; set; }

    /// <summary>
    /// The interval in seconds used for polling KEDA. Defaults to 30.
    /// The interval in seconds used for polling KEDA.
    /// </summary>
    [JsonPropertyName("pollingIntervalInSeconds")]
    public double? PollingIntervalInSeconds { get; set; }

    /// <summary>
    /// The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
    /// The suffix for the revision. This value must be unique for the lifetime of the Resource. If omitted the service will use a hash function to create one.
    /// </summary>
    [JsonPropertyName("revisionSuffix")]
    public string? RevisionSuffix { get; set; }

    /// <summary>One or more tcp_scale_rule blocks as defined below.</summary>
    [JsonPropertyName("tcpScaleRule")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateTcpScaleRule>? TcpScaleRule { get; set; }

    /// <summary>
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// The time in seconds after the container is sent the termination signal before the process if forcibly killed.
    /// </summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public double? TerminationGracePeriodSeconds { get; set; }

    /// <summary>A volume block as detailed below.</summary>
    [JsonPropertyName("volume")]
    public IList<V1beta2ContainerAppStatusAtProviderTemplateVolume>? Volume { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusAtProvider
{
    /// <summary>
    /// The ID of the Container App Environment within which this Container App should exist. Changing this forces a new resource to be created.
    /// The ID of the Container App Environment to host this Container App.
    /// </summary>
    [JsonPropertyName("containerAppEnvironmentId")]
    public string? ContainerAppEnvironmentId { get; set; }

    /// <summary>A dapr block as detailed below.</summary>
    [JsonPropertyName("dapr")]
    public V1beta2ContainerAppStatusAtProviderDapr? Dapr { get; set; }

    /// <summary>The ID of the Container App.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as detailed below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2ContainerAppStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>An ingress block as detailed below.</summary>
    [JsonPropertyName("ingress")]
    public V1beta2ContainerAppStatusAtProviderIngress? Ingress { get; set; }

    /// <summary>
    /// The FQDN of the Latest Revision of the Container App.
    /// The FQDN of the Latest Revision of the Container App.
    /// </summary>
    [JsonPropertyName("latestRevisionFqdn")]
    public string? LatestRevisionFqdn { get; set; }

    /// <summary>
    /// The name of the latest Container Revision.
    /// The name of the latest Container Revision.
    /// </summary>
    [JsonPropertyName("latestRevisionName")]
    public string? LatestRevisionName { get; set; }

    /// <summary>The location this Container App is deployed in. This is the same as the Environment in which it is deployed.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum of inactive revisions allowed for this Container App.</summary>
    [JsonPropertyName("maxInactiveRevisions")]
    public double? MaxInactiveRevisions { get; set; }

    /// <summary>A list of the Public IP Addresses which the Container App uses for outbound network access.</summary>
    [JsonPropertyName("outboundIpAddresses")]
    public IList<string>? OutboundIpAddresses { get; set; }

    /// <summary>A registry block as detailed below.</summary>
    [JsonPropertyName("registry")]
    public IList<V1beta2ContainerAppStatusAtProviderRegistry>? Registry { get; set; }

    /// <summary>The name of the resource group in which the Container App Environment is to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The revisions operational mode for the Container App. Possible values include Single and Multiple. In Single mode, a single revision is in operation at any given time. In Multiple mode, more than one revision can be active at a time and can be configured with load distribution via the traffic_weight block in the ingress configuration.</summary>
    [JsonPropertyName("revisionMode")]
    public string? RevisionMode { get; set; }

    /// <summary>One or more secret block as detailed below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta2ContainerAppStatusAtProviderSecret>? Secret { get; set; }

    /// <summary>A mapping of tags to assign to the Container App.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A template block as detailed below.</summary>
    [JsonPropertyName("template")]
    public V1beta2ContainerAppStatusAtProviderTemplate? Template { get; set; }

    /// <summary>The name of the Workload Profile in the Container App Environment to place this Container App.</summary>
    [JsonPropertyName("workloadProfileName")]
    public string? WorkloadProfileName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatusConditions
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

/// <summary>ContainerAppStatus defines the observed state of ContainerApp.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ContainerAppStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ContainerAppStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ContainerAppStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ContainerApp is the Schema for the ContainerApps API. Manages a Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ContainerApp : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ContainerAppSpec>, IStatus<V1beta2ContainerAppStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ContainerApp";
    public const string KubeGroup = "containerapp.azure.upbound.io";
    public const string KubePluralName = "containerapps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerapp.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ContainerApp";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ContainerAppSpec defines the desired state of ContainerApp</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ContainerAppSpec Spec { get; set; }

    /// <summary>ContainerAppStatus defines the observed state of ContainerApp.</summary>
    [JsonPropertyName("status")]
    public V1beta2ContainerAppStatus? Status { get; set; }
}
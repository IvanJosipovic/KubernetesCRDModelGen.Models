#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.@operator.tigera.io;
/// <summary>
/// ManagementClusterConnection represents a link between a managed cluster and a management cluster. At most one
/// instance of this resource is supported. It must be named &quot;tigera-secure&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ManagementClusterConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1ManagementClusterConnection>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ManagementClusterConnectionList";
    public const string KubeGroup = "operator.tigera.io";
    public const string KubePluralName = "managementclusterconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "operator.tigera.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagementClusterConnectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1ManagementClusterConnection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1ManagementClusterConnection> Items { get; set; }
}

/// <summary>
/// Name is an enum which identifies the guardian Deployment container by name.
/// Supported values are: tigera-guardian
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplateSpecContainersNameEnum>))]
public enum V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplateSpecContainersNameEnum
{
    [EnumMember(Value = "tigera-guardian"), JsonStringEnumMemberName("tigera-guardian")]
    TigeraGuardian
}

/// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplateSpecContainersResourcesClaims
{
    /// <summary>
    /// Name must match the name of one entry in pod.spec.resourceClaims of
    /// the Pod where this field is used. It makes that resource available
    /// inside a container.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Request is the name chosen for a request in the referenced claim.
    /// If empty, everything from the claim is made available, otherwise
    /// only the result of this request.
    /// </summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

/// <summary>
/// Resources allows customization of limits and requests for compute resources such as cpu and memory.
/// If specified, this overrides the named guardian Deployment container&apos;s resources.
/// If omitted, the guardian Deployment will use its default value for this container&apos;s resources.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplateSpecContainersResources
{
    /// <summary>
    /// Claims lists the names of resources, defined in spec.resourceClaims,
    /// that are used by this container.
    /// This field depends on the
    /// DynamicResourceAllocation feature gate.
    /// This field is immutable. It can only be set for containers.
    /// </summary>
    [JsonPropertyName("claims")]
    public IList<V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplateSpecContainersResourcesClaims>? Claims { get; set; }

    /// <summary>
    /// Limits describes the maximum amount of compute resources allowed.
    /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
    /// </summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    /// <summary>
    /// Requests describes the minimum amount of compute resources required.
    /// If Requests is omitted for a container, it defaults to Limits if that is explicitly specified,
    /// otherwise to an implementation-defined value. Requests cannot exceed Limits.
    /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
    /// </summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

/// <summary>GuardianDeploymentContainer is a guardian Deployment container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplateSpecContainers
{
    /// <summary>
    /// Name is an enum which identifies the guardian Deployment container by name.
    /// Supported values are: tigera-guardian
    /// </summary>
    [JsonPropertyName("name")]
    public required V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplateSpecContainersNameEnum Name { get; set; }

    /// <summary>
    /// Resources allows customization of limits and requests for compute resources such as cpu and memory.
    /// If specified, this overrides the named guardian Deployment container&apos;s resources.
    /// If omitted, the guardian Deployment will use its default value for this container&apos;s resources.
    /// </summary>
    [JsonPropertyName("resources")]
    public V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplateSpecContainersResources? Resources { get; set; }
}

/// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplateSpecInitContainersResourcesClaims
{
    /// <summary>
    /// Name must match the name of one entry in pod.spec.resourceClaims of
    /// the Pod where this field is used. It makes that resource available
    /// inside a container.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Request is the name chosen for a request in the referenced claim.
    /// If empty, everything from the claim is made available, otherwise
    /// only the result of this request.
    /// </summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

/// <summary>
/// Resources allows customization of limits and requests for compute resources such as cpu and memory.
/// If specified, this overrides the named guardian Deployment init container&apos;s resources.
/// If omitted, the guardian Deployment will use its default value for this init container&apos;s resources.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplateSpecInitContainersResources
{
    /// <summary>
    /// Claims lists the names of resources, defined in spec.resourceClaims,
    /// that are used by this container.
    /// This field depends on the
    /// DynamicResourceAllocation feature gate.
    /// This field is immutable. It can only be set for containers.
    /// </summary>
    [JsonPropertyName("claims")]
    public IList<V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplateSpecInitContainersResourcesClaims>? Claims { get; set; }

    /// <summary>
    /// Limits describes the maximum amount of compute resources allowed.
    /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
    /// </summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    /// <summary>
    /// Requests describes the minimum amount of compute resources required.
    /// If Requests is omitted for a container, it defaults to Limits if that is explicitly specified,
    /// otherwise to an implementation-defined value. Requests cannot exceed Limits.
    /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
    /// </summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

/// <summary>GuardianDeploymentInitContainer is a guardian Deployment init container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplateSpecInitContainers
{
    /// <summary>Name is an enum which identifies the guardian Deployment init container by name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Resources allows customization of limits and requests for compute resources such as cpu and memory.
    /// If specified, this overrides the named guardian Deployment init container&apos;s resources.
    /// If omitted, the guardian Deployment will use its default value for this init container&apos;s resources.
    /// </summary>
    [JsonPropertyName("resources")]
    public V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplateSpecInitContainersResources? Resources { get; set; }
}

/// <summary>Spec is the guardian Deployment&apos;s PodSpec.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplateSpec
{
    /// <summary>
    /// Containers is a list of guardian containers.
    /// If specified, this overrides the specified guardian Deployment containers.
    /// If omitted, the guardian Deployment will use its default values for its containers.
    /// </summary>
    [JsonPropertyName("containers")]
    public IList<V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplateSpecContainers>? Containers { get; set; }

    /// <summary>
    /// InitContainers is a list of guardian init containers.
    /// If specified, this overrides the specified guardian Deployment init containers.
    /// If omitted, the guardian Deployment will use its default values for its init containers.
    /// </summary>
    [JsonPropertyName("initContainers")]
    public IList<V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplateSpecInitContainers>? InitContainers { get; set; }
}

/// <summary>Template describes the guardian Deployment pod that will be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplate
{
    /// <summary>Spec is the guardian Deployment&apos;s PodSpec.</summary>
    [JsonPropertyName("spec")]
    public V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplateSpec? Spec { get; set; }
}

/// <summary>Spec is the specification of the guardian Deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ManagementClusterConnectionSpecGuardianDeploymentSpec
{
    /// <summary>Template describes the guardian Deployment pod that will be created.</summary>
    [JsonPropertyName("template")]
    public V1ManagementClusterConnectionSpecGuardianDeploymentSpecTemplate? Template { get; set; }
}

/// <summary>GuardianDeployment configures the guardian Deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ManagementClusterConnectionSpecGuardianDeployment
{
    /// <summary>Spec is the specification of the guardian Deployment.</summary>
    [JsonPropertyName("spec")]
    public V1ManagementClusterConnectionSpecGuardianDeploymentSpec? Spec { get; set; }
}

/// <summary>
/// Impersonation configures the RBAC impersonation permissions for the guardian deployment. This field is not
/// applicable to installation variant Calico as no impersonation is ever used. Otherwise, if this field is left nil,
/// a default set of permissions will be applied.
/// WARNING: If this field is specified, it completely replaces the default permissions.
/// For example, providing an empty `impersonation: {}` block will result in guardian
/// having NO impersonation permissions. Similarly, if you specify `users` but omit `groups`,
/// guardian will lose its default permissions to impersonate groups.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ManagementClusterConnectionSpecImpersonation
{
    /// <summary>
    /// Groups is a list of group names that can be impersonated. An empty list infers all groups can be impersonated,
    /// a null values means none.
    /// </summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>
    /// ServiceAccounts is a list of service account names that can be impersonated. An empty list infers all service accounts can
    /// be impersonated, a null values means none.
    /// </summary>
    [JsonPropertyName("serviceAccounts")]
    public IList<string>? ServiceAccounts { get; set; }

    /// <summary>
    /// Users is a list of users that can be impersonated. An empty list infers all users can be impersonated, a null
    /// value means none.
    /// </summary>
    [JsonPropertyName("users")]
    public IList<string>? Users { get; set; }
}

/// <summary>
/// CA indicates which verification method the tunnel client should use to verify the tunnel server&apos;s identity.
/// When left blank or set to &apos;Tigera&apos;, the tunnel client will expect a self-signed cert to be included in the certificate bundle
/// and will expect the cert to have a Common Name (CN) of &apos;voltron&apos;.
/// When set to &apos;Public&apos;, the tunnel client will use its installed system certs and will use the managementClusterAddr to verify the tunnel server&apos;s identity.
/// Default: Tigera
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ManagementClusterConnectionSpecTlsCaEnum>))]
public enum V1ManagementClusterConnectionSpecTlsCaEnum
{
    [EnumMember(Value = "Tigera"), JsonStringEnumMemberName("Tigera")]
    Tigera,
    [EnumMember(Value = "Public"), JsonStringEnumMemberName("Public")]
    Public
}

/// <summary>TLS provides options for configuring how Managed Clusters can establish an mTLS connection with the Management Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ManagementClusterConnectionSpecTls
{
    /// <summary>
    /// CA indicates which verification method the tunnel client should use to verify the tunnel server&apos;s identity.
    /// When left blank or set to &apos;Tigera&apos;, the tunnel client will expect a self-signed cert to be included in the certificate bundle
    /// and will expect the cert to have a Common Name (CN) of &apos;voltron&apos;.
    /// When set to &apos;Public&apos;, the tunnel client will use its installed system certs and will use the managementClusterAddr to verify the tunnel server&apos;s identity.
    /// Default: Tigera
    /// </summary>
    [JsonPropertyName("ca")]
    public V1ManagementClusterConnectionSpecTlsCaEnum? Ca { get; set; }
}

/// <summary>ManagementClusterConnectionSpec defines the desired state of ManagementClusterConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ManagementClusterConnectionSpec
{
    /// <summary>GuardianDeployment configures the guardian Deployment.</summary>
    [JsonPropertyName("guardianDeployment")]
    public V1ManagementClusterConnectionSpecGuardianDeployment? GuardianDeployment { get; set; }

    /// <summary>
    /// Impersonation configures the RBAC impersonation permissions for the guardian deployment. This field is not
    /// applicable to installation variant Calico as no impersonation is ever used. Otherwise, if this field is left nil,
    /// a default set of permissions will be applied.
    /// WARNING: If this field is specified, it completely replaces the default permissions.
    /// For example, providing an empty `impersonation: {}` block will result in guardian
    /// having NO impersonation permissions. Similarly, if you specify `users` but omit `groups`,
    /// guardian will lose its default permissions to impersonate groups.
    /// </summary>
    [JsonPropertyName("impersonation")]
    public V1ManagementClusterConnectionSpecImpersonation? Impersonation { get; set; }

    /// <summary>
    /// Specify where the managed cluster can reach the management cluster. Ex.: &quot;10.128.0.10:30449&quot;. A managed cluster
    /// should be able to access this address. This field is used by managed clusters only.
    /// </summary>
    [JsonPropertyName("managementClusterAddr")]
    public string? ManagementClusterAddr { get; set; }

    /// <summary>TLS provides options for configuring how Managed Clusters can establish an mTLS connection with the Management Cluster.</summary>
    [JsonPropertyName("tls")]
    public V1ManagementClusterConnectionSpecTls? Tls { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ManagementClusterConnectionStatusConditionsStatusEnum>))]
public enum V1ManagementClusterConnectionStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ManagementClusterConnectionStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1ManagementClusterConnectionStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ManagementClusterConnectionStatus defines the observed state of ManagementClusterConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ManagementClusterConnectionStatus
{
    /// <summary>
    /// Conditions represents the latest observed set of conditions for the component. A component may be one or more of
    /// Ready, Progressing, Degraded or other customer types.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1ManagementClusterConnectionStatusConditions>? Conditions { get; set; }
}

/// <summary>
/// ManagementClusterConnection represents a link between a managed cluster and a management cluster. At most one
/// instance of this resource is supported. It must be named &quot;tigera-secure&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ManagementClusterConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1ManagementClusterConnectionSpec?>, IStatus<V1ManagementClusterConnectionStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ManagementClusterConnection";
    public const string KubeGroup = "operator.tigera.io";
    public const string KubePluralName = "managementclusterconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "operator.tigera.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagementClusterConnection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagementClusterConnectionSpec defines the desired state of ManagementClusterConnection</summary>
    [JsonPropertyName("spec")]
    public V1ManagementClusterConnectionSpec? Spec { get; set; }

    /// <summary>ManagementClusterConnectionStatus defines the observed state of ManagementClusterConnection</summary>
    [JsonPropertyName("status")]
    public V1ManagementClusterConnectionStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /cdn/resource-manager/Microsoft.Cdn/Cdn/stable/2023-05-01/afdx.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/origins/{originName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230501AfdOriginList : IKubernetesObject<V1ListMeta>, IItems<V1api20230501AfdOrigin>
{
    public const string KubeApiVersion = "v1api20230501";
    public const string KubeKind = "AfdOriginList";
    public const string KubeGroup = "cdn.azure.com";
    public const string KubePluralName = "afdorigins";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cdn.azure.com/v1api20230501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AfdOriginList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20230501AfdOrigin objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20230501AfdOrigin> Items { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginSpecAzureOriginReference
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

/// <summary>AzureOrigin: Resource reference to the Azure origin resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginSpecAzureOrigin
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20230501AfdOriginSpecAzureOriginReference? Reference { get; set; }
}

/// <summary>
/// EnabledState: Whether to enable health probes to be made against backends defined under backendPools. Health probes can
/// only be disabled if there is a single enabled backend in single enabled backend pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501AfdOriginSpecEnabledStateEnum>))]
public enum V1api20230501AfdOriginSpecEnabledStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// HostNameFromConfig: The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This
/// should be unique across all origins in an endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginSpecHostNameFromConfig
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

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230501AfdOriginSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230501AfdOriginSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a cdn.azure.com/AfdOriginGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginSpecSharedPrivateLinkResourcePrivateLinkReference
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

/// <summary>PrivateLink: The resource id of the resource the shared private link resource is for.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginSpecSharedPrivateLinkResourcePrivateLink
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20230501AfdOriginSpecSharedPrivateLinkResourcePrivateLinkReference? Reference { get; set; }
}

/// <summary>Status: Status of the shared private link resource. Can be Pending, Approved, Rejected, Disconnected, or Timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501AfdOriginSpecSharedPrivateLinkResourceStatusEnum>))]
public enum V1api20230501AfdOriginSpecSharedPrivateLinkResourceStatusEnum
{
    [EnumMember(Value = "Approved"), JsonStringEnumMemberName("Approved")]
    Approved,
    [EnumMember(Value = "Disconnected"), JsonStringEnumMemberName("Disconnected")]
    Disconnected,
    [EnumMember(Value = "Pending"), JsonStringEnumMemberName("Pending")]
    Pending,
    [EnumMember(Value = "Rejected"), JsonStringEnumMemberName("Rejected")]
    Rejected,
    [EnumMember(Value = "Timeout"), JsonStringEnumMemberName("Timeout")]
    Timeout
}

/// <summary>SharedPrivateLinkResource: The properties of the private link resource for private origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginSpecSharedPrivateLinkResource
{
    /// <summary>GroupId: The group id from the provider of resource the shared private link resource is for.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>PrivateLink: The resource id of the resource the shared private link resource is for.</summary>
    [JsonPropertyName("privateLink")]
    public V1api20230501AfdOriginSpecSharedPrivateLinkResourcePrivateLink? PrivateLink { get; set; }

    /// <summary>PrivateLinkLocation: The location of the shared private link resource</summary>
    [JsonPropertyName("privateLinkLocation")]
    public string? PrivateLinkLocation { get; set; }

    /// <summary>RequestMessage: The request message for requesting approval of the shared private link resource.</summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary>Status: Status of the shared private link resource. Can be Pending, Approved, Rejected, Disconnected, or Timeout.</summary>
    [JsonPropertyName("status")]
    public V1api20230501AfdOriginSpecSharedPrivateLinkResourceStatusEnum? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>AzureOrigin: Resource reference to the Azure origin resource.</summary>
    [JsonPropertyName("azureOrigin")]
    public V1api20230501AfdOriginSpecAzureOrigin? AzureOrigin { get; set; }

    /// <summary>
    /// EnabledState: Whether to enable health probes to be made against backends defined under backendPools. Health probes can
    /// only be disabled if there is a single enabled backend in single enabled backend pool.
    /// </summary>
    [JsonPropertyName("enabledState")]
    public V1api20230501AfdOriginSpecEnabledStateEnum? EnabledState { get; set; }

    /// <summary>EnforceCertificateNameCheck: Whether to enable certificate name check at origin level</summary>
    [JsonPropertyName("enforceCertificateNameCheck")]
    public bool? EnforceCertificateNameCheck { get; set; }

    /// <summary>
    /// HostName: The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be
    /// unique across all origins in an endpoint.
    /// </summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>
    /// HostNameFromConfig: The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This
    /// should be unique across all origins in an endpoint.
    /// </summary>
    [JsonPropertyName("hostNameFromConfig")]
    public V1api20230501AfdOriginSpecHostNameFromConfig? HostNameFromConfig { get; set; }

    /// <summary>HttpPort: The value of the HTTP port. Must be between 1 and 65535.</summary>
    [JsonPropertyName("httpPort")]
    public int? HttpPort { get; set; }

    /// <summary>HttpsPort: The value of the HTTPS port. Must be between 1 and 65535.</summary>
    [JsonPropertyName("httpsPort")]
    public int? HttpsPort { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230501AfdOriginSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// OriginHostHeader: The host header value sent to the origin with each request. If you leave this blank, the request
    /// hostname determines this value. Azure Front Door origins, such as Web Apps, Blob Storage, and Cloud Services require
    /// this host header value to match the origin hostname by default. This overrides the host header defined at Endpoint
    /// </summary>
    [JsonPropertyName("originHostHeader")]
    public string? OriginHostHeader { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a cdn.azure.com/AfdOriginGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20230501AfdOriginSpecOwner Owner { get; set; }

    /// <summary>
    /// Priority: Priority of origin in given origin group for load balancing. Higher priorities will not be used for load
    /// balancing if any lower priority origin is healthy.Must be between 1 and 5
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>SharedPrivateLinkResource: The properties of the private link resource for private origin.</summary>
    [JsonPropertyName("sharedPrivateLinkResource")]
    public V1api20230501AfdOriginSpecSharedPrivateLinkResource? SharedPrivateLinkResource { get; set; }

    /// <summary>Weight: Weight of the origin in given origin group for load balancing. Must be between 1 and 1000</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>AzureOrigin: Resource reference to the Azure origin resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginStatusAzureOrigin
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginStatusConditions
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

/// <summary>PrivateLink: The resource id of the resource the shared private link resource is for.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginStatusSharedPrivateLinkResourcePrivateLink
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>SharedPrivateLinkResource: The properties of the private link resource for private origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginStatusSharedPrivateLinkResource
{
    /// <summary>GroupId: The group id from the provider of resource the shared private link resource is for.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>PrivateLink: The resource id of the resource the shared private link resource is for.</summary>
    [JsonPropertyName("privateLink")]
    public V1api20230501AfdOriginStatusSharedPrivateLinkResourcePrivateLink? PrivateLink { get; set; }

    /// <summary>PrivateLinkLocation: The location of the shared private link resource</summary>
    [JsonPropertyName("privateLinkLocation")]
    public string? PrivateLinkLocation { get; set; }

    /// <summary>RequestMessage: The request message for requesting approval of the shared private link resource.</summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary>Status: Status of the shared private link resource. Can be Pending, Approved, Rejected, Disconnected, or Timeout.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>SystemData: Read only system data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC)</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: An identifier for the identity that created the resource</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: An identifier for the identity that last modified the resource</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginStatus
{
    /// <summary>AzureOrigin: Resource reference to the Azure origin resource.</summary>
    [JsonPropertyName("azureOrigin")]
    public V1api20230501AfdOriginStatusAzureOrigin? AzureOrigin { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230501AfdOriginStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("deploymentStatus")]
    public string? DeploymentStatus { get; set; }

    /// <summary>
    /// EnabledState: Whether to enable health probes to be made against backends defined under backendPools. Health probes can
    /// only be disabled if there is a single enabled backend in single enabled backend pool.
    /// </summary>
    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    /// <summary>EnforceCertificateNameCheck: Whether to enable certificate name check at origin level</summary>
    [JsonPropertyName("enforceCertificateNameCheck")]
    public bool? EnforceCertificateNameCheck { get; set; }

    /// <summary>
    /// HostName: The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be
    /// unique across all origins in an endpoint.
    /// </summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>HttpPort: The value of the HTTP port. Must be between 1 and 65535.</summary>
    [JsonPropertyName("httpPort")]
    public int? HttpPort { get; set; }

    /// <summary>HttpsPort: The value of the HTTPS port. Must be between 1 and 65535.</summary>
    [JsonPropertyName("httpsPort")]
    public int? HttpsPort { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OriginGroupName: The name of the origin group which contains this origin.</summary>
    [JsonPropertyName("originGroupName")]
    public string? OriginGroupName { get; set; }

    /// <summary>
    /// OriginHostHeader: The host header value sent to the origin with each request. If you leave this blank, the request
    /// hostname determines this value. Azure Front Door origins, such as Web Apps, Blob Storage, and Cloud Services require
    /// this host header value to match the origin hostname by default. This overrides the host header defined at Endpoint
    /// </summary>
    [JsonPropertyName("originHostHeader")]
    public string? OriginHostHeader { get; set; }

    /// <summary>
    /// Priority: Priority of origin in given origin group for load balancing. Higher priorities will not be used for load
    /// balancing if any lower priority origin is healthy.Must be between 1 and 5
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>ProvisioningState: Provisioning status</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>SharedPrivateLinkResource: The properties of the private link resource for private origin.</summary>
    [JsonPropertyName("sharedPrivateLinkResource")]
    public V1api20230501AfdOriginStatusSharedPrivateLinkResource? SharedPrivateLinkResource { get; set; }

    /// <summary>SystemData: Read only system data</summary>
    [JsonPropertyName("systemData")]
    public V1api20230501AfdOriginStatusSystemData? SystemData { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Weight: Weight of the origin in given origin group for load balancing. Must be between 1 and 1000</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /cdn/resource-manager/Microsoft.Cdn/Cdn/stable/2023-05-01/afdx.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/origins/{originName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230501AfdOrigin : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230501AfdOriginSpec?>, IStatus<V1api20230501AfdOriginStatus?>
{
    public const string KubeApiVersion = "v1api20230501";
    public const string KubeKind = "AfdOrigin";
    public const string KubeGroup = "cdn.azure.com";
    public const string KubePluralName = "afdorigins";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cdn.azure.com/v1api20230501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AfdOrigin";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20230501AfdOriginSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20230501AfdOriginStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.signalrservice.azure.com;
/// <summary>
/// Storage version of v1api20240301.SignalR
/// Generator information:
/// - Generated from: /signalr/resource-manager/Microsoft.SignalRService/SignalRService/stable/2024-03-01/signalr.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301storageSignalRList : IKubernetesObject<V1ListMeta>, IItems<V1api20240301storageSignalR>
{
    public const string KubeApiVersion = "v1api20240301storage";
    public const string KubeKind = "SignalRList";
    public const string KubeGroup = "signalrservice.azure.com";
    public const string KubePluralName = "signalrs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "signalrservice.azure.com/v1api20240301storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SignalRList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240301storageSignalR objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240301storageSignalR> Items { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.SignalRCorsSettings
/// Cross-Origin Resource Sharing (CORS) settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecCors
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.SignalRFeature
/// Feature of a resource, which controls the runtime behavior.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecFeatures
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("flag")]
    public string? Flag { get; set; }

    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecIdentityUserAssignedIdentitiesReference
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
/// Storage version of v1api20240301.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20240301storageSignalRSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ManagedIdentity
/// A class represent managed identities used for request and response
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20240301storageSignalRSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.LiveTraceCategory
/// Live trace category configuration of a Microsoft.SignalRService resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecLiveTraceConfigurationCategories
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public string? Enabled { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.LiveTraceConfiguration
/// Live trace configuration of a Microsoft.SignalRService resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecLiveTraceConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("categories")]
    public IList<V1api20240301storageSignalRSpecLiveTraceConfigurationCategories>? Categories { get; set; }

    [JsonPropertyName("enabled")]
    public string? Enabled { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.IPRule
/// An IP rule
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecNetworkACLsIpRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.PrivateEndpointACL
/// ACL for a private endpoint
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecNetworkACLsPrivateEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allow")]
    public IList<string>? Allow { get; set; }

    [JsonPropertyName("deny")]
    public IList<string>? Deny { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.NetworkACL
/// Network ACL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecNetworkACLsPublicNetwork
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allow")]
    public IList<string>? Allow { get; set; }

    [JsonPropertyName("deny")]
    public IList<string>? Deny { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.SignalRNetworkACLs
/// Network ACLs for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecNetworkACLs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    [JsonPropertyName("ipRules")]
    public IList<V1api20240301storageSignalRSpecNetworkACLsIpRules>? IpRules { get; set; }

    [JsonPropertyName("privateEndpoints")]
    public IList<V1api20240301storageSignalRSpecNetworkACLsPrivateEndpoints>? PrivateEndpoints { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.NetworkACL
    /// Network ACL
    /// </summary>
    [JsonPropertyName("publicNetwork")]
    public V1api20240301storageSignalRSpecNetworkACLsPublicNetwork? PublicNetwork { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240301storageSignalRSpecOperatorSpecSecretExpressions
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecOperatorSpecSecretsPrimaryConnectionString
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecOperatorSpecSecretsPrimaryKey
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecOperatorSpecSecretsSecondaryConnectionString
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecOperatorSpecSecretsSecondaryKey
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Storage version of v1api20240301.SignalROperatorSecrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecOperatorSpecSecrets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("primaryConnectionString")]
    public V1api20240301storageSignalRSpecOperatorSpecSecretsPrimaryConnectionString? PrimaryConnectionString { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("primaryKey")]
    public V1api20240301storageSignalRSpecOperatorSpecSecretsPrimaryKey? PrimaryKey { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("secondaryConnectionString")]
    public V1api20240301storageSignalRSpecOperatorSpecSecretsSecondaryConnectionString? SecondaryConnectionString { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("secondaryKey")]
    public V1api20240301storageSignalRSpecOperatorSpecSecretsSecondaryKey? SecondaryKey { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.SignalROperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240301storageSignalRSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240301storageSignalRSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Storage version of v1api20240301.SignalROperatorSecrets</summary>
    [JsonPropertyName("secrets")]
    public V1api20240301storageSignalRSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ResourceLogCategory
/// Resource log category configuration of a Microsoft.SignalRService resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecResourceLogConfigurationCategories
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public string? Enabled { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ResourceLogConfiguration
/// Resource log configuration of a Microsoft.SignalRService resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecResourceLogConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("categories")]
    public IList<V1api20240301storageSignalRSpecResourceLogConfigurationCategories>? Categories { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ServerlessSettings
/// Serverless settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecServerless
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("connectionTimeoutInSeconds")]
    public int? ConnectionTimeoutInSeconds { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ResourceSku
/// The billing information of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.SignalRTlsSettings
/// TLS settings for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecTls
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientCertEnabled")]
    public bool? ClientCertEnabled { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ManagedIdentitySettings
/// Managed identity settings for upstream.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecUpstreamTemplatesAuthManagedIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.UpstreamAuthSettings
/// Upstream auth settings. If not set, no auth is used for upstream messages.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecUpstreamTemplatesAuth
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.ManagedIdentitySettings
    /// Managed identity settings for upstream.
    /// </summary>
    [JsonPropertyName("managedIdentity")]
    public V1api20240301storageSignalRSpecUpstreamTemplatesAuthManagedIdentity? ManagedIdentity { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.UpstreamTemplate
/// Upstream template item settings. It defines the Upstream URL of the incoming requests.
/// The template defines the pattern
/// of the event, the hub or the category of the incoming request that matches current URL template.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecUpstreamTemplates
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.UpstreamAuthSettings
    /// Upstream auth settings. If not set, no auth is used for upstream messages.
    /// </summary>
    [JsonPropertyName("auth")]
    public V1api20240301storageSignalRSpecUpstreamTemplatesAuth? Auth { get; set; }

    [JsonPropertyName("categoryPattern")]
    public string? CategoryPattern { get; set; }

    [JsonPropertyName("eventPattern")]
    public string? EventPattern { get; set; }

    [JsonPropertyName("hubPattern")]
    public string? HubPattern { get; set; }

    [JsonPropertyName("urlTemplate")]
    public string? UrlTemplate { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ServerlessUpstreamSettings
/// The settings for the Upstream when the service is in server-less mode.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpecUpstream
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("templates")]
    public IList<V1api20240301storageSignalRSpecUpstreamTemplates>? Templates { get; set; }
}

/// <summary>Storage version of v1api20240301.SignalR_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.SignalRCorsSettings
    /// Cross-Origin Resource Sharing (CORS) settings.
    /// </summary>
    [JsonPropertyName("cors")]
    public V1api20240301storageSignalRSpecCors? Cors { get; set; }

    [JsonPropertyName("disableAadAuth")]
    public bool? DisableAadAuth { get; set; }

    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    [JsonPropertyName("features")]
    public IList<V1api20240301storageSignalRSpecFeatures>? Features { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.ManagedIdentity
    /// A class represent managed identities used for request and response
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20240301storageSignalRSpecIdentity? Identity { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.LiveTraceConfiguration
    /// Live trace configuration of a Microsoft.SignalRService resource.
    /// </summary>
    [JsonPropertyName("liveTraceConfiguration")]
    public V1api20240301storageSignalRSpecLiveTraceConfiguration? LiveTraceConfiguration { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.SignalRNetworkACLs
    /// Network ACLs for the resource
    /// </summary>
    [JsonPropertyName("networkACLs")]
    public V1api20240301storageSignalRSpecNetworkACLs? NetworkACLs { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.SignalROperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240301storageSignalRSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240301storageSignalRSpecOwner Owner { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    [JsonPropertyName("regionEndpointEnabled")]
    public string? RegionEndpointEnabled { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.ResourceLogConfiguration
    /// Resource log configuration of a Microsoft.SignalRService resource.
    /// </summary>
    [JsonPropertyName("resourceLogConfiguration")]
    public V1api20240301storageSignalRSpecResourceLogConfiguration? ResourceLogConfiguration { get; set; }

    [JsonPropertyName("resourceStopped")]
    public string? ResourceStopped { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.ServerlessSettings
    /// Serverless settings.
    /// </summary>
    [JsonPropertyName("serverless")]
    public V1api20240301storageSignalRSpecServerless? Serverless { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.ResourceSku
    /// The billing information of the resource.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20240301storageSignalRSpecSku? Sku { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.SignalRTlsSettings
    /// TLS settings for the resource
    /// </summary>
    [JsonPropertyName("tls")]
    public V1api20240301storageSignalRSpecTls? Tls { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.ServerlessUpstreamSettings
    /// The settings for the Upstream when the service is in server-less mode.
    /// </summary>
    [JsonPropertyName("upstream")]
    public V1api20240301storageSignalRSpecUpstream? Upstream { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusConditions
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

/// <summary>
/// Storage version of v1api20240301.SignalRCorsSettings_STATUS
/// Cross-Origin Resource Sharing (CORS) settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusCors
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.SignalRFeature_STATUS
/// Feature of a resource, which controls the runtime behavior.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusFeatures
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("flag")]
    public string? Flag { get; set; }

    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.UserAssignedIdentityProperty_STATUS
/// Properties of user assigned identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ManagedIdentity_STATUS
/// A class represent managed identities used for request and response
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20240301storageSignalRStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.LiveTraceCategory_STATUS
/// Live trace category configuration of a Microsoft.SignalRService resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusLiveTraceConfigurationCategories
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public string? Enabled { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.LiveTraceConfiguration_STATUS
/// Live trace configuration of a Microsoft.SignalRService resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusLiveTraceConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("categories")]
    public IList<V1api20240301storageSignalRStatusLiveTraceConfigurationCategories>? Categories { get; set; }

    [JsonPropertyName("enabled")]
    public string? Enabled { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.IPRule_STATUS
/// An IP rule
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusNetworkACLsIpRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.PrivateEndpointACL_STATUS
/// ACL for a private endpoint
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusNetworkACLsPrivateEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allow")]
    public IList<string>? Allow { get; set; }

    [JsonPropertyName("deny")]
    public IList<string>? Deny { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.NetworkACL_STATUS
/// Network ACL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusNetworkACLsPublicNetwork
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allow")]
    public IList<string>? Allow { get; set; }

    [JsonPropertyName("deny")]
    public IList<string>? Deny { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.SignalRNetworkACLs_STATUS
/// Network ACLs for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusNetworkACLs
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    [JsonPropertyName("ipRules")]
    public IList<V1api20240301storageSignalRStatusNetworkACLsIpRules>? IpRules { get; set; }

    [JsonPropertyName("privateEndpoints")]
    public IList<V1api20240301storageSignalRStatusNetworkACLsPrivateEndpoints>? PrivateEndpoints { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.NetworkACL_STATUS
    /// Network ACL
    /// </summary>
    [JsonPropertyName("publicNetwork")]
    public V1api20240301storageSignalRStatusNetworkACLsPublicNetwork? PublicNetwork { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.PrivateEndpointConnection_STATUS_SignalR_SubResourceEmbedded
/// A private endpoint connection to an azure resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusPrivateEndpointConnections
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ResourceLogCategory_STATUS
/// Resource log category configuration of a Microsoft.SignalRService resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusResourceLogConfigurationCategories
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public string? Enabled { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ResourceLogConfiguration_STATUS
/// Resource log configuration of a Microsoft.SignalRService resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusResourceLogConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("categories")]
    public IList<V1api20240301storageSignalRStatusResourceLogConfigurationCategories>? Categories { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ServerlessSettings_STATUS
/// Serverless settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusServerless
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("connectionTimeoutInSeconds")]
    public int? ConnectionTimeoutInSeconds { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.SharedPrivateLinkResource_STATUS_SignalR_SubResourceEmbedded
/// Describes a Shared Private Link Resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusSharedPrivateLinkResources
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ResourceSku_STATUS
/// The billing information of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    [JsonPropertyName("family")]
    public string? Family { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusSystemData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.SignalRTlsSettings_STATUS
/// TLS settings for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusTls
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientCertEnabled")]
    public bool? ClientCertEnabled { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ManagedIdentitySettings_STATUS
/// Managed identity settings for upstream.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusUpstreamTemplatesAuthManagedIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("resource")]
    public string? Resource { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.UpstreamAuthSettings_STATUS
/// Upstream auth settings. If not set, no auth is used for upstream messages.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusUpstreamTemplatesAuth
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.ManagedIdentitySettings_STATUS
    /// Managed identity settings for upstream.
    /// </summary>
    [JsonPropertyName("managedIdentity")]
    public V1api20240301storageSignalRStatusUpstreamTemplatesAuthManagedIdentity? ManagedIdentity { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.UpstreamTemplate_STATUS
/// Upstream template item settings. It defines the Upstream URL of the incoming requests.
/// The template defines the pattern
/// of the event, the hub or the category of the incoming request that matches current URL template.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusUpstreamTemplates
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.UpstreamAuthSettings_STATUS
    /// Upstream auth settings. If not set, no auth is used for upstream messages.
    /// </summary>
    [JsonPropertyName("auth")]
    public V1api20240301storageSignalRStatusUpstreamTemplatesAuth? Auth { get; set; }

    [JsonPropertyName("categoryPattern")]
    public string? CategoryPattern { get; set; }

    [JsonPropertyName("eventPattern")]
    public string? EventPattern { get; set; }

    [JsonPropertyName("hubPattern")]
    public string? HubPattern { get; set; }

    [JsonPropertyName("urlTemplate")]
    public string? UrlTemplate { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.ServerlessUpstreamSettings_STATUS
/// The settings for the Upstream when the service is in server-less mode.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatusUpstream
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("templates")]
    public IList<V1api20240301storageSignalRStatusUpstreamTemplates>? Templates { get; set; }
}

/// <summary>Storage version of v1api20240301.SignalR_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageSignalRStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20240301storageSignalRStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.SignalRCorsSettings_STATUS
    /// Cross-Origin Resource Sharing (CORS) settings.
    /// </summary>
    [JsonPropertyName("cors")]
    public V1api20240301storageSignalRStatusCors? Cors { get; set; }

    [JsonPropertyName("disableAadAuth")]
    public bool? DisableAadAuth { get; set; }

    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    [JsonPropertyName("externalIP")]
    public string? ExternalIP { get; set; }

    [JsonPropertyName("features")]
    public IList<V1api20240301storageSignalRStatusFeatures>? Features { get; set; }

    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    [JsonPropertyName("hostNamePrefix")]
    public string? HostNamePrefix { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.ManagedIdentity_STATUS
    /// A class represent managed identities used for request and response
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20240301storageSignalRStatusIdentity? Identity { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.LiveTraceConfiguration_STATUS
    /// Live trace configuration of a Microsoft.SignalRService resource.
    /// </summary>
    [JsonPropertyName("liveTraceConfiguration")]
    public V1api20240301storageSignalRStatusLiveTraceConfiguration? LiveTraceConfiguration { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.SignalRNetworkACLs_STATUS
    /// Network ACLs for the resource
    /// </summary>
    [JsonPropertyName("networkACLs")]
    public V1api20240301storageSignalRStatusNetworkACLs? NetworkACLs { get; set; }

    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20240301storageSignalRStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    [JsonPropertyName("publicPort")]
    public int? PublicPort { get; set; }

    [JsonPropertyName("regionEndpointEnabled")]
    public string? RegionEndpointEnabled { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.ResourceLogConfiguration_STATUS
    /// Resource log configuration of a Microsoft.SignalRService resource.
    /// </summary>
    [JsonPropertyName("resourceLogConfiguration")]
    public V1api20240301storageSignalRStatusResourceLogConfiguration? ResourceLogConfiguration { get; set; }

    [JsonPropertyName("resourceStopped")]
    public string? ResourceStopped { get; set; }

    [JsonPropertyName("serverPort")]
    public int? ServerPort { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.ServerlessSettings_STATUS
    /// Serverless settings.
    /// </summary>
    [JsonPropertyName("serverless")]
    public V1api20240301storageSignalRStatusServerless? Serverless { get; set; }

    [JsonPropertyName("sharedPrivateLinkResources")]
    public IList<V1api20240301storageSignalRStatusSharedPrivateLinkResources>? SharedPrivateLinkResources { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.ResourceSku_STATUS
    /// The billing information of the resource.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20240301storageSignalRStatusSku? Sku { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V1api20240301storageSignalRStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.SignalRTlsSettings_STATUS
    /// TLS settings for the resource
    /// </summary>
    [JsonPropertyName("tls")]
    public V1api20240301storageSignalRStatusTls? Tls { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.ServerlessUpstreamSettings_STATUS
    /// The settings for the Upstream when the service is in server-less mode.
    /// </summary>
    [JsonPropertyName("upstream")]
    public V1api20240301storageSignalRStatusUpstream? Upstream { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.SignalR
/// Generator information:
/// - Generated from: /signalr/resource-manager/Microsoft.SignalRService/SignalRService/stable/2024-03-01/signalr.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301storageSignalR : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240301storageSignalRSpec?>, IStatus<V1api20240301storageSignalRStatus?>
{
    public const string KubeApiVersion = "v1api20240301storage";
    public const string KubeKind = "SignalR";
    public const string KubeGroup = "signalrservice.azure.com";
    public const string KubePluralName = "signalrs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "signalrservice.azure.com/v1api20240301storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SignalR";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240301.SignalR_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240301storageSignalRSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240301.SignalR_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20240301storageSignalRStatus? Status { get; set; }
}
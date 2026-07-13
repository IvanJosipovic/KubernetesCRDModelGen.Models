#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cognitiveservices.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2025-06-01/cognitiveservices.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/deployments/{deploymentName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250601DeploymentList : IKubernetesObject<V1ListMeta>, IItems<V1api20250601Deployment>
{
    public const string KubeApiVersion = "v1api20250601";
    public const string KubeKind = "DeploymentList";
    public const string KubeGroup = "cognitiveservices.azure.com";
    public const string KubePluralName = "deployments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cognitiveservices.azure.com/v1api20250601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DeploymentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20250601Deployment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20250601Deployment> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20250601DeploymentSpecOperatorSpecSecretExpressions
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
public partial class V1api20250601DeploymentSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20250601DeploymentSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20250601DeploymentSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a cognitiveservices.azure.com/Account resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>CapacitySettings: Internal use only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentSpecPropertiesCapacitySettings
{
    /// <summary>DesignatedCapacity: The designated capacity.</summary>
    [JsonPropertyName("designatedCapacity")]
    public int? DesignatedCapacity { get; set; }

    /// <summary>Priority: The priority of this capacity setting.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }
}

/// <summary>FormatFromConfig: Deployment model format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentSpecPropertiesModelFormatFromConfig
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

/// <summary>NameFromConfig: Deployment model name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentSpecPropertiesModelNameFromConfig
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

/// <summary>PublisherFromConfig: Deployment model publisher.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentSpecPropertiesModelPublisherFromConfig
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

/// <summary>SourceAccountReference: Optional. Source of the model, another Microsoft.CognitiveServices accounts ARM resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentSpecPropertiesModelSourceAccountReference
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

/// <summary>SourceReference: Optional. Deployment model source ARM resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentSpecPropertiesModelSourceReference
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
/// VersionFromConfig: Optional. Deployment model version. If version is not specified, a default version will be assigned.
/// The default version is different for different models and might change when there is new version available for a model.
/// Default version for a model could be found from list models API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentSpecPropertiesModelVersionFromConfig
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

/// <summary>Model: Properties of Cognitive Services account deployment model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentSpecPropertiesModel
{
    /// <summary>Format: Deployment model format.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>FormatFromConfig: Deployment model format.</summary>
    [JsonPropertyName("formatFromConfig")]
    public V1api20250601DeploymentSpecPropertiesModelFormatFromConfig? FormatFromConfig { get; set; }

    /// <summary>Name: Deployment model name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NameFromConfig: Deployment model name.</summary>
    [JsonPropertyName("nameFromConfig")]
    public V1api20250601DeploymentSpecPropertiesModelNameFromConfig? NameFromConfig { get; set; }

    /// <summary>Publisher: Deployment model publisher.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>PublisherFromConfig: Deployment model publisher.</summary>
    [JsonPropertyName("publisherFromConfig")]
    public V1api20250601DeploymentSpecPropertiesModelPublisherFromConfig? PublisherFromConfig { get; set; }

    /// <summary>SourceAccountReference: Optional. Source of the model, another Microsoft.CognitiveServices accounts ARM resource ID.</summary>
    [JsonPropertyName("sourceAccountReference")]
    public V1api20250601DeploymentSpecPropertiesModelSourceAccountReference? SourceAccountReference { get; set; }

    /// <summary>SourceReference: Optional. Deployment model source ARM resource ID.</summary>
    [JsonPropertyName("sourceReference")]
    public V1api20250601DeploymentSpecPropertiesModelSourceReference? SourceReference { get; set; }

    /// <summary>
    /// Version: Optional. Deployment model version. If version is not specified, a default version will be assigned. The
    /// default version is different for different models and might change when there is new version available for a model.
    /// Default version for a model could be found from list models API.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>
    /// VersionFromConfig: Optional. Deployment model version. If version is not specified, a default version will be assigned.
    /// The default version is different for different models and might change when there is new version available for a model.
    /// Default version for a model could be found from list models API.
    /// </summary>
    [JsonPropertyName("versionFromConfig")]
    public V1api20250601DeploymentSpecPropertiesModelVersionFromConfig? VersionFromConfig { get; set; }
}

/// <summary>ScaleType: Deployment scale type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250601DeploymentSpecPropertiesScaleSettingsScaleTypeEnum>))]
public enum V1api20250601DeploymentSpecPropertiesScaleSettingsScaleTypeEnum
{
    [EnumMember(Value = "Manual"), JsonStringEnumMemberName("Manual")]
    Manual,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>
/// ScaleSettings: Properties of Cognitive Services account deployment model. (Deprecated, please use Deployment.sku
/// instead.)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentSpecPropertiesScaleSettings
{
    /// <summary>Capacity: Deployment capacity.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>ScaleType: Deployment scale type.</summary>
    [JsonPropertyName("scaleType")]
    public V1api20250601DeploymentSpecPropertiesScaleSettingsScaleTypeEnum? ScaleType { get; set; }
}

/// <summary>VersionUpgradeOption: Deployment model version upgrade option.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250601DeploymentSpecPropertiesVersionUpgradeOptionEnum>))]
public enum V1api20250601DeploymentSpecPropertiesVersionUpgradeOptionEnum
{
    [EnumMember(Value = "NoAutoUpgrade"), JsonStringEnumMemberName("NoAutoUpgrade")]
    NoAutoUpgrade,
    [EnumMember(Value = "OnceCurrentVersionExpired"), JsonStringEnumMemberName("OnceCurrentVersionExpired")]
    OnceCurrentVersionExpired,
    [EnumMember(Value = "OnceNewDefaultVersionAvailable"), JsonStringEnumMemberName("OnceNewDefaultVersionAvailable")]
    OnceNewDefaultVersionAvailable
}

/// <summary>Properties: Properties of Cognitive Services account deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentSpecProperties
{
    /// <summary>CapacitySettings: Internal use only.</summary>
    [JsonPropertyName("capacitySettings")]
    public V1api20250601DeploymentSpecPropertiesCapacitySettings? CapacitySettings { get; set; }

    /// <summary>Model: Properties of Cognitive Services account deployment model.</summary>
    [JsonPropertyName("model")]
    public V1api20250601DeploymentSpecPropertiesModel? Model { get; set; }

    /// <summary>ParentDeploymentName: The name of parent deployment.</summary>
    [JsonPropertyName("parentDeploymentName")]
    public string? ParentDeploymentName { get; set; }

    /// <summary>RaiPolicyName: The name of RAI policy.</summary>
    [JsonPropertyName("raiPolicyName")]
    public string? RaiPolicyName { get; set; }

    /// <summary>
    /// ScaleSettings: Properties of Cognitive Services account deployment model. (Deprecated, please use Deployment.sku
    /// instead.)
    /// </summary>
    [JsonPropertyName("scaleSettings")]
    public V1api20250601DeploymentSpecPropertiesScaleSettings? ScaleSettings { get; set; }

    /// <summary>
    /// SpilloverDeploymentName: Specifies the deployment name that should serve requests when the request would have otherwise
    /// been throttled due to reaching current deployment throughput limit.
    /// </summary>
    [JsonPropertyName("spilloverDeploymentName")]
    public string? SpilloverDeploymentName { get; set; }

    /// <summary>VersionUpgradeOption: Deployment model version upgrade option.</summary>
    [JsonPropertyName("versionUpgradeOption")]
    public V1api20250601DeploymentSpecPropertiesVersionUpgradeOptionEnum? VersionUpgradeOption { get; set; }
}

/// <summary>
/// Tier: This field is required to be implemented by the Resource Provider if the service has more than one tier, but is
/// not required on a PUT.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250601DeploymentSpecSkuTierEnum>))]
public enum V1api20250601DeploymentSpecSkuTierEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Enterprise"), JsonStringEnumMemberName("Enterprise")]
    Enterprise,
    [EnumMember(Value = "Free"), JsonStringEnumMemberName("Free")]
    Free,
    [EnumMember(Value = "Premium"), JsonStringEnumMemberName("Premium")]
    Premium,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Sku: The resource model definition representing SKU</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentSpecSku
{
    /// <summary>
    /// Capacity: If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible
    /// for the resource this may be omitted.
    /// </summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: If the service has different generations of hardware, for the same SKU, then that can be captured here.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: The name of the SKU. Ex - P3. It is typically a letter+number code</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Size: The SKU size. When the name field is the combination of tier and some other value, this would be the standalone
    /// code.
    /// </summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>
    /// Tier: This field is required to be implemented by the Resource Provider if the service has more than one tier, but is
    /// not required on a PUT.
    /// </summary>
    [JsonPropertyName("tier")]
    public V1api20250601DeploymentSpecSkuTierEnum? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20250601DeploymentSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a cognitiveservices.azure.com/Account resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20250601DeploymentSpecOwner Owner { get; set; }

    /// <summary>Properties: Properties of Cognitive Services account deployment.</summary>
    [JsonPropertyName("properties")]
    public V1api20250601DeploymentSpecProperties? Properties { get; set; }

    /// <summary>Sku: The resource model definition representing SKU</summary>
    [JsonPropertyName("sku")]
    public V1api20250601DeploymentSpecSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentStatusPropertiesCallRateLimitRulesMatchPatterns
{
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentStatusPropertiesCallRateLimitRules
{
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    [JsonPropertyName("dynamicThrottlingEnabled")]
    public bool? DynamicThrottlingEnabled { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("matchPatterns")]
    public IList<V1api20250601DeploymentStatusPropertiesCallRateLimitRulesMatchPatterns>? MatchPatterns { get; set; }

    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    [JsonPropertyName("renewalPeriod")]
    public double? RenewalPeriod { get; set; }
}

/// <summary>CallRateLimit: The call rate limit Cognitive Services account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentStatusPropertiesCallRateLimit
{
    /// <summary>Count: The count value of Call Rate Limit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>RenewalPeriod: The renewal period in seconds of Call Rate Limit.</summary>
    [JsonPropertyName("renewalPeriod")]
    public double? RenewalPeriod { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20250601DeploymentStatusPropertiesCallRateLimitRules>? Rules { get; set; }
}

/// <summary>CapacitySettings: Internal use only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentStatusPropertiesCapacitySettings
{
    /// <summary>DesignatedCapacity: The designated capacity.</summary>
    [JsonPropertyName("designatedCapacity")]
    public int? DesignatedCapacity { get; set; }

    /// <summary>Priority: The priority of this capacity setting.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentStatusPropertiesModelCallRateLimitRulesMatchPatterns
{
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentStatusPropertiesModelCallRateLimitRules
{
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    [JsonPropertyName("dynamicThrottlingEnabled")]
    public bool? DynamicThrottlingEnabled { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("matchPatterns")]
    public IList<V1api20250601DeploymentStatusPropertiesModelCallRateLimitRulesMatchPatterns>? MatchPatterns { get; set; }

    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    [JsonPropertyName("renewalPeriod")]
    public double? RenewalPeriod { get; set; }
}

/// <summary>CallRateLimit: The call rate limit Cognitive Services account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentStatusPropertiesModelCallRateLimit
{
    /// <summary>Count: The count value of Call Rate Limit.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>RenewalPeriod: The renewal period in seconds of Call Rate Limit.</summary>
    [JsonPropertyName("renewalPeriod")]
    public double? RenewalPeriod { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20250601DeploymentStatusPropertiesModelCallRateLimitRules>? Rules { get; set; }
}

/// <summary>Model: Properties of Cognitive Services account deployment model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentStatusPropertiesModel
{
    /// <summary>CallRateLimit: The call rate limit Cognitive Services account.</summary>
    [JsonPropertyName("callRateLimit")]
    public V1api20250601DeploymentStatusPropertiesModelCallRateLimit? CallRateLimit { get; set; }

    /// <summary>Format: Deployment model format.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Name: Deployment model name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Publisher: Deployment model publisher.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Source: Optional. Deployment model source ARM resource ID.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>SourceAccount: Optional. Source of the model, another Microsoft.CognitiveServices accounts ARM resource ID.</summary>
    [JsonPropertyName("sourceAccount")]
    public string? SourceAccount { get; set; }

    /// <summary>
    /// Version: Optional. Deployment model version. If version is not specified, a default version will be assigned. The
    /// default version is different for different models and might change when there is new version available for a model.
    /// Default version for a model could be found from list models API.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentStatusPropertiesRateLimitsMatchPatterns
{
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentStatusPropertiesRateLimits
{
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    [JsonPropertyName("dynamicThrottlingEnabled")]
    public bool? DynamicThrottlingEnabled { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("matchPatterns")]
    public IList<V1api20250601DeploymentStatusPropertiesRateLimitsMatchPatterns>? MatchPatterns { get; set; }

    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    [JsonPropertyName("renewalPeriod")]
    public double? RenewalPeriod { get; set; }
}

/// <summary>
/// ScaleSettings: Properties of Cognitive Services account deployment model. (Deprecated, please use Deployment.sku
/// instead.)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentStatusPropertiesScaleSettings
{
    /// <summary>
    /// ActiveCapacity: Deployment active capacity. This value might be different from `capacity` if customer recently updated
    /// `capacity`.
    /// </summary>
    [JsonPropertyName("activeCapacity")]
    public int? ActiveCapacity { get; set; }

    /// <summary>Capacity: Deployment capacity.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>ScaleType: Deployment scale type.</summary>
    [JsonPropertyName("scaleType")]
    public string? ScaleType { get; set; }
}

/// <summary>Properties: Properties of Cognitive Services account deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentStatusProperties
{
    /// <summary>CallRateLimit: The call rate limit Cognitive Services account.</summary>
    [JsonPropertyName("callRateLimit")]
    public V1api20250601DeploymentStatusPropertiesCallRateLimit? CallRateLimit { get; set; }

    /// <summary>Capabilities: The capabilities.</summary>
    [JsonPropertyName("capabilities")]
    public IDictionary<string, string>? Capabilities { get; set; }

    /// <summary>CapacitySettings: Internal use only.</summary>
    [JsonPropertyName("capacitySettings")]
    public V1api20250601DeploymentStatusPropertiesCapacitySettings? CapacitySettings { get; set; }

    /// <summary>CurrentCapacity: The current capacity.</summary>
    [JsonPropertyName("currentCapacity")]
    public int? CurrentCapacity { get; set; }

    /// <summary>DynamicThrottlingEnabled: If the dynamic throttling is enabled.</summary>
    [JsonPropertyName("dynamicThrottlingEnabled")]
    public bool? DynamicThrottlingEnabled { get; set; }

    /// <summary>Model: Properties of Cognitive Services account deployment model.</summary>
    [JsonPropertyName("model")]
    public V1api20250601DeploymentStatusPropertiesModel? Model { get; set; }

    /// <summary>ParentDeploymentName: The name of parent deployment.</summary>
    [JsonPropertyName("parentDeploymentName")]
    public string? ParentDeploymentName { get; set; }

    /// <summary>ProvisioningState: Gets the status of the resource at the time the operation was called.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>RaiPolicyName: The name of RAI policy.</summary>
    [JsonPropertyName("raiPolicyName")]
    public string? RaiPolicyName { get; set; }

    [JsonPropertyName("rateLimits")]
    public IList<V1api20250601DeploymentStatusPropertiesRateLimits>? RateLimits { get; set; }

    /// <summary>
    /// ScaleSettings: Properties of Cognitive Services account deployment model. (Deprecated, please use Deployment.sku
    /// instead.)
    /// </summary>
    [JsonPropertyName("scaleSettings")]
    public V1api20250601DeploymentStatusPropertiesScaleSettings? ScaleSettings { get; set; }

    /// <summary>
    /// SpilloverDeploymentName: Specifies the deployment name that should serve requests when the request would have otherwise
    /// been throttled due to reaching current deployment throughput limit.
    /// </summary>
    [JsonPropertyName("spilloverDeploymentName")]
    public string? SpilloverDeploymentName { get; set; }

    /// <summary>VersionUpgradeOption: Deployment model version upgrade option.</summary>
    [JsonPropertyName("versionUpgradeOption")]
    public string? VersionUpgradeOption { get; set; }
}

/// <summary>Sku: The resource model definition representing SKU</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentStatusSku
{
    /// <summary>
    /// Capacity: If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible
    /// for the resource this may be omitted.
    /// </summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: If the service has different generations of hardware, for the same SKU, then that can be captured here.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: The name of the SKU. Ex - P3. It is typically a letter+number code</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Size: The SKU size. When the name field is the combination of tier and some other value, this would be the standalone
    /// code.
    /// </summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>
    /// Tier: This field is required to be implemented by the Resource Provider if the service has more than one tier, but is
    /// not required on a PUT.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentStatusSystemData
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250601DeploymentStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20250601DeploymentStatusConditions>? Conditions { get; set; }

    /// <summary>Etag: Resource Etag.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Properties: Properties of Cognitive Services account deployment.</summary>
    [JsonPropertyName("properties")]
    public V1api20250601DeploymentStatusProperties? Properties { get; set; }

    /// <summary>Sku: The resource model definition representing SKU</summary>
    [JsonPropertyName("sku")]
    public V1api20250601DeploymentStatusSku? Sku { get; set; }

    /// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20250601DeploymentStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2025-06-01/cognitiveservices.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/deployments/{deploymentName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250601Deployment : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20250601DeploymentSpec?>, IStatus<V1api20250601DeploymentStatus?>
{
    public const string KubeApiVersion = "v1api20250601";
    public const string KubeKind = "Deployment";
    public const string KubeGroup = "cognitiveservices.azure.com";
    public const string KubePluralName = "deployments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cognitiveservices.azure.com/v1api20250601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Deployment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20250601DeploymentSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20250601DeploymentStatus? Status { get; set; }
}
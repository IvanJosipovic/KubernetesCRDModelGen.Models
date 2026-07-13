#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.web.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /web/resource-manager/Microsoft.Web/AppService/stable/2022-03-01/AppServicePlans.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220301ServerFarmList : IKubernetesObject<V1ListMeta>, IItems<V1api20220301ServerFarm>
{
    public const string KubeApiVersion = "v1api20220301";
    public const string KubeKind = "ServerFarmList";
    public const string KubeGroup = "web.azure.com";
    public const string KubePluralName = "serverfarms";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "web.azure.com/v1api20220301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServerFarmList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20220301ServerFarm objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20220301ServerFarm> Items { get; set; }
}

/// <summary>ExtendedLocation: Extended Location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmSpecExtendedLocation
{
    /// <summary>Name: Name of extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: Resource ID of the App Service Environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmSpecHostingEnvironmentProfileReference
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

/// <summary>HostingEnvironmentProfile: Specification for the App Service Environment to use for the App Service plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmSpecHostingEnvironmentProfile
{
    /// <summary>Reference: Resource ID of the App Service Environment.</summary>
    [JsonPropertyName("reference")]
    public V1api20220301ServerFarmSpecHostingEnvironmentProfileReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID of the Kubernetes Environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmSpecKubeEnvironmentProfileReference
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

/// <summary>KubeEnvironmentProfile: Specification for the Kubernetes Environment to use for the App Service plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmSpecKubeEnvironmentProfile
{
    /// <summary>Reference: Resource ID of the Kubernetes Environment.</summary>
    [JsonPropertyName("reference")]
    public V1api20220301ServerFarmSpecKubeEnvironmentProfileReference? Reference { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20220301ServerFarmSpecOperatorSpecSecretExpressions
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
public partial class V1api20220301ServerFarmSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20220301ServerFarmSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20220301ServerFarmSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Describes the capabilities/features allowed for a specific SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmSpecSkuCapabilities
{
    /// <summary>Name: Name of the SKU capability.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reason: Reason of the SKU capability.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Value: Value of the SKU capability.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>SkuCapacity: Min, max, and default scale values of the SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmSpecSkuSkuCapacity
{
    /// <summary>Default: Default number of workers for this App Service plan SKU.</summary>
    [JsonPropertyName("default")]
    public int? Default { get; set; }

    /// <summary>ElasticMaximum: Maximum number of Elastic workers for this App Service plan SKU.</summary>
    [JsonPropertyName("elasticMaximum")]
    public int? ElasticMaximum { get; set; }

    /// <summary>Maximum: Maximum number of workers for this App Service plan SKU.</summary>
    [JsonPropertyName("maximum")]
    public int? Maximum { get; set; }

    /// <summary>Minimum: Minimum number of workers for this App Service plan SKU.</summary>
    [JsonPropertyName("minimum")]
    public int? Minimum { get; set; }

    /// <summary>ScaleType: Available scale configurations for an App Service plan.</summary>
    [JsonPropertyName("scaleType")]
    public string? ScaleType { get; set; }
}

/// <summary>Sku: Description of a SKU for a scalable resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmSpecSku
{
    /// <summary>Capabilities: Capabilities of the SKU, e.g., is traffic manager enabled?</summary>
    [JsonPropertyName("capabilities")]
    public IList<V1api20220301ServerFarmSpecSkuCapabilities>? Capabilities { get; set; }

    /// <summary>Capacity: Current number of instances assigned to the resource.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: Family code of the resource SKU.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Locations: Locations of the SKU.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary>Name: Name of the resource SKU.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Size: Size specifier of the resource SKU.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>SkuCapacity: Min, max, and default scale values of the SKU.</summary>
    [JsonPropertyName("skuCapacity")]
    public V1api20220301ServerFarmSpecSkuSkuCapacity? SkuCapacity { get; set; }

    /// <summary>Tier: Service tier of the resource SKU.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// ElasticScaleEnabled: ServerFarm supports ElasticScale. Apps in this plan will scale as if the ServerFarm was
    /// ElasticPremium sku
    /// </summary>
    [JsonPropertyName("elasticScaleEnabled")]
    public bool? ElasticScaleEnabled { get; set; }

    /// <summary>ExtendedLocation: Extended Location.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20220301ServerFarmSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>FreeOfferExpirationTime: The time when the server farm free offer expires.</summary>
    [JsonPropertyName("freeOfferExpirationTime")]
    public string? FreeOfferExpirationTime { get; set; }

    /// <summary>HostingEnvironmentProfile: Specification for the App Service Environment to use for the App Service plan.</summary>
    [JsonPropertyName("hostingEnvironmentProfile")]
    public V1api20220301ServerFarmSpecHostingEnvironmentProfile? HostingEnvironmentProfile { get; set; }

    /// <summary>HyperV: If Hyper-V container app service plan &lt;code&gt;true&lt;/code&gt;, &lt;code&gt;false&lt;/code&gt; otherwise.</summary>
    [JsonPropertyName("hyperV")]
    public bool? HyperV { get; set; }

    /// <summary>IsSpot: If &lt;code&gt;true&lt;/code&gt;, this App Service Plan owns spot instances.</summary>
    [JsonPropertyName("isSpot")]
    public bool? IsSpot { get; set; }

    /// <summary>IsXenon: Obsolete: If Hyper-V container app service plan &lt;code&gt;true&lt;/code&gt;, &lt;code&gt;false&lt;/code&gt; otherwise.</summary>
    [JsonPropertyName("isXenon")]
    public bool? IsXenon { get; set; }

    /// <summary>Kind: Kind of resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>KubeEnvironmentProfile: Specification for the Kubernetes Environment to use for the App Service plan.</summary>
    [JsonPropertyName("kubeEnvironmentProfile")]
    public V1api20220301ServerFarmSpecKubeEnvironmentProfile? KubeEnvironmentProfile { get; set; }

    /// <summary>Location: Resource Location.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>MaximumElasticWorkerCount: Maximum number of total workers allowed for this ElasticScaleEnabled App Service Plan</summary>
    [JsonPropertyName("maximumElasticWorkerCount")]
    public int? MaximumElasticWorkerCount { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220301ServerFarmSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20220301ServerFarmSpecOwner Owner { get; set; }

    /// <summary>
    /// PerSiteScaling: If &lt;code&gt;true&lt;/code&gt;, apps assigned to this App Service plan can be scaled independently.
    /// If &lt;code&gt;false&lt;/code&gt;, apps assigned to this App Service plan will scale to all instances of the plan.
    /// </summary>
    [JsonPropertyName("perSiteScaling")]
    public bool? PerSiteScaling { get; set; }

    /// <summary>Reserved: If Linux app service plan &lt;code&gt;true&lt;/code&gt;, &lt;code&gt;false&lt;/code&gt; otherwise.</summary>
    [JsonPropertyName("reserved")]
    public bool? Reserved { get; set; }

    /// <summary>Sku: Description of a SKU for a scalable resource.</summary>
    [JsonPropertyName("sku")]
    public V1api20220301ServerFarmSpecSku? Sku { get; set; }

    /// <summary>SpotExpirationTime: The time when the server farm expires. Valid only if it is a spot server farm.</summary>
    [JsonPropertyName("spotExpirationTime")]
    public string? SpotExpirationTime { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TargetWorkerCount: Scaling worker count.</summary>
    [JsonPropertyName("targetWorkerCount")]
    public int? TargetWorkerCount { get; set; }

    /// <summary>TargetWorkerSizeId: Scaling worker size ID.</summary>
    [JsonPropertyName("targetWorkerSizeId")]
    public int? TargetWorkerSizeId { get; set; }

    /// <summary>WorkerTierName: Target worker tier assigned to the App Service plan.</summary>
    [JsonPropertyName("workerTierName")]
    public string? WorkerTierName { get; set; }

    /// <summary>
    /// ZoneRedundant: If &lt;code&gt;true&lt;/code&gt;, this App Service Plan will perform availability zone balancing.
    /// If &lt;code&gt;false&lt;/code&gt;, this App Service Plan will not perform availability zone balancing.
    /// </summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmStatusConditions
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

/// <summary>ExtendedLocation: Extended Location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmStatusExtendedLocation
{
    /// <summary>Name: Name of extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>HostingEnvironmentProfile: Specification for the App Service Environment to use for the App Service plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmStatusHostingEnvironmentProfile
{
    /// <summary>Id: Resource ID of the App Service Environment.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: Name of the App Service Environment.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Resource type of the App Service Environment.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>KubeEnvironmentProfile: Specification for the Kubernetes Environment to use for the App Service plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmStatusKubeEnvironmentProfile
{
    /// <summary>Id: Resource ID of the Kubernetes Environment.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: Name of the Kubernetes Environment.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Resource type of the Kubernetes Environment.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Describes the capabilities/features allowed for a specific SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmStatusSkuCapabilities
{
    /// <summary>Name: Name of the SKU capability.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reason: Reason of the SKU capability.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Value: Value of the SKU capability.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>SkuCapacity: Min, max, and default scale values of the SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmStatusSkuSkuCapacity
{
    /// <summary>Default: Default number of workers for this App Service plan SKU.</summary>
    [JsonPropertyName("default")]
    public int? Default { get; set; }

    /// <summary>ElasticMaximum: Maximum number of Elastic workers for this App Service plan SKU.</summary>
    [JsonPropertyName("elasticMaximum")]
    public int? ElasticMaximum { get; set; }

    /// <summary>Maximum: Maximum number of workers for this App Service plan SKU.</summary>
    [JsonPropertyName("maximum")]
    public int? Maximum { get; set; }

    /// <summary>Minimum: Minimum number of workers for this App Service plan SKU.</summary>
    [JsonPropertyName("minimum")]
    public int? Minimum { get; set; }

    /// <summary>ScaleType: Available scale configurations for an App Service plan.</summary>
    [JsonPropertyName("scaleType")]
    public string? ScaleType { get; set; }
}

/// <summary>Sku: Description of a SKU for a scalable resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmStatusSku
{
    /// <summary>Capabilities: Capabilities of the SKU, e.g., is traffic manager enabled?</summary>
    [JsonPropertyName("capabilities")]
    public IList<V1api20220301ServerFarmStatusSkuCapabilities>? Capabilities { get; set; }

    /// <summary>Capacity: Current number of instances assigned to the resource.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: Family code of the resource SKU.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Locations: Locations of the SKU.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary>Name: Name of the resource SKU.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Size: Size specifier of the resource SKU.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>SkuCapacity: Min, max, and default scale values of the SKU.</summary>
    [JsonPropertyName("skuCapacity")]
    public V1api20220301ServerFarmStatusSkuSkuCapacity? SkuCapacity { get; set; }

    /// <summary>Tier: Service tier of the resource SKU.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301ServerFarmStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220301ServerFarmStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ElasticScaleEnabled: ServerFarm supports ElasticScale. Apps in this plan will scale as if the ServerFarm was
    /// ElasticPremium sku
    /// </summary>
    [JsonPropertyName("elasticScaleEnabled")]
    public bool? ElasticScaleEnabled { get; set; }

    /// <summary>ExtendedLocation: Extended Location.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20220301ServerFarmStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>FreeOfferExpirationTime: The time when the server farm free offer expires.</summary>
    [JsonPropertyName("freeOfferExpirationTime")]
    public string? FreeOfferExpirationTime { get; set; }

    /// <summary>GeoRegion: Geographical location for the App Service plan.</summary>
    [JsonPropertyName("geoRegion")]
    public string? GeoRegion { get; set; }

    /// <summary>HostingEnvironmentProfile: Specification for the App Service Environment to use for the App Service plan.</summary>
    [JsonPropertyName("hostingEnvironmentProfile")]
    public V1api20220301ServerFarmStatusHostingEnvironmentProfile? HostingEnvironmentProfile { get; set; }

    /// <summary>HyperV: If Hyper-V container app service plan &lt;code&gt;true&lt;/code&gt;, &lt;code&gt;false&lt;/code&gt; otherwise.</summary>
    [JsonPropertyName("hyperV")]
    public bool? HyperV { get; set; }

    /// <summary>Id: Resource Id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IsSpot: If &lt;code&gt;true&lt;/code&gt;, this App Service Plan owns spot instances.</summary>
    [JsonPropertyName("isSpot")]
    public bool? IsSpot { get; set; }

    /// <summary>IsXenon: Obsolete: If Hyper-V container app service plan &lt;code&gt;true&lt;/code&gt;, &lt;code&gt;false&lt;/code&gt; otherwise.</summary>
    [JsonPropertyName("isXenon")]
    public bool? IsXenon { get; set; }

    /// <summary>Kind: Kind of resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>KubeEnvironmentProfile: Specification for the Kubernetes Environment to use for the App Service plan.</summary>
    [JsonPropertyName("kubeEnvironmentProfile")]
    public V1api20220301ServerFarmStatusKubeEnvironmentProfile? KubeEnvironmentProfile { get; set; }

    /// <summary>Location: Resource Location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MaximumElasticWorkerCount: Maximum number of total workers allowed for this ElasticScaleEnabled App Service Plan</summary>
    [JsonPropertyName("maximumElasticWorkerCount")]
    public int? MaximumElasticWorkerCount { get; set; }

    /// <summary>MaximumNumberOfWorkers: Maximum number of instances that can be assigned to this App Service plan.</summary>
    [JsonPropertyName("maximumNumberOfWorkers")]
    public int? MaximumNumberOfWorkers { get; set; }

    /// <summary>Name: Resource Name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NumberOfSites: Number of apps assigned to this App Service plan.</summary>
    [JsonPropertyName("numberOfSites")]
    public int? NumberOfSites { get; set; }

    /// <summary>NumberOfWorkers: The number of instances that are assigned to this App Service plan.</summary>
    [JsonPropertyName("numberOfWorkers")]
    public int? NumberOfWorkers { get; set; }

    /// <summary>
    /// PerSiteScaling: If &lt;code&gt;true&lt;/code&gt;, apps assigned to this App Service plan can be scaled independently.
    /// If &lt;code&gt;false&lt;/code&gt;, apps assigned to this App Service plan will scale to all instances of the plan.
    /// </summary>
    [JsonPropertyName("perSiteScaling")]
    public bool? PerSiteScaling { get; set; }

    /// <summary>ProvisioningState: Provisioning state of the App Service Plan.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Reserved: If Linux app service plan &lt;code&gt;true&lt;/code&gt;, &lt;code&gt;false&lt;/code&gt; otherwise.</summary>
    [JsonPropertyName("reserved")]
    public bool? Reserved { get; set; }

    /// <summary>ResourceGroup: Resource group of the App Service plan.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>Sku: Description of a SKU for a scalable resource.</summary>
    [JsonPropertyName("sku")]
    public V1api20220301ServerFarmStatusSku? Sku { get; set; }

    /// <summary>SpotExpirationTime: The time when the server farm expires. Valid only if it is a spot server farm.</summary>
    [JsonPropertyName("spotExpirationTime")]
    public string? SpotExpirationTime { get; set; }

    /// <summary>Status: App Service plan status.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Subscription: App Service plan subscription.</summary>
    [JsonPropertyName("subscription")]
    public string? Subscription { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TargetWorkerCount: Scaling worker count.</summary>
    [JsonPropertyName("targetWorkerCount")]
    public int? TargetWorkerCount { get; set; }

    /// <summary>TargetWorkerSizeId: Scaling worker size ID.</summary>
    [JsonPropertyName("targetWorkerSizeId")]
    public int? TargetWorkerSizeId { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>WorkerTierName: Target worker tier assigned to the App Service plan.</summary>
    [JsonPropertyName("workerTierName")]
    public string? WorkerTierName { get; set; }

    /// <summary>
    /// ZoneRedundant: If &lt;code&gt;true&lt;/code&gt;, this App Service Plan will perform availability zone balancing.
    /// If &lt;code&gt;false&lt;/code&gt;, this App Service Plan will not perform availability zone balancing.
    /// </summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /web/resource-manager/Microsoft.Web/AppService/stable/2022-03-01/AppServicePlans.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220301ServerFarm : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220301ServerFarmSpec?>, IStatus<V1api20220301ServerFarmStatus?>
{
    public const string KubeApiVersion = "v1api20220301";
    public const string KubeKind = "ServerFarm";
    public const string KubeGroup = "web.azure.com";
    public const string KubePluralName = "serverfarms";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "web.azure.com/v1api20220301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServerFarm";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20220301ServerFarmSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20220301ServerFarmStatus? Status { get; set; }
}
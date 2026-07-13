#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerservice.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/fleets.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/autoUpgradeProfiles/{autoUpgradeProfileName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250301FleetsAutoUpgradeProfileList : IKubernetesObject<V1ListMeta>, IItems<V1api20250301FleetsAutoUpgradeProfile>
{
    public const string KubeApiVersion = "v1api20250301";
    public const string KubeKind = "FleetsAutoUpgradeProfileList";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "fleetsautoupgradeprofiles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v1api20250301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FleetsAutoUpgradeProfileList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20250301FleetsAutoUpgradeProfile objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20250301FleetsAutoUpgradeProfile> Items { get; set; }
}

/// <summary>Channel: Configures how auto-upgrade will be run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250301FleetsAutoUpgradeProfileSpecChannelEnum>))]
public enum V1api20250301FleetsAutoUpgradeProfileSpecChannelEnum
{
    [EnumMember(Value = "NodeImage"), JsonStringEnumMemberName("NodeImage")]
    NodeImage,
    [EnumMember(Value = "Rapid"), JsonStringEnumMemberName("Rapid")]
    Rapid,
    [EnumMember(Value = "Stable"), JsonStringEnumMemberName("Stable")]
    Stable
}

/// <summary>Type: The node image upgrade type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250301FleetsAutoUpgradeProfileSpecNodeImageSelectionTypeEnum>))]
public enum V1api20250301FleetsAutoUpgradeProfileSpecNodeImageSelectionTypeEnum
{
    [EnumMember(Value = "Consistent"), JsonStringEnumMemberName("Consistent")]
    Consistent,
    [EnumMember(Value = "Latest"), JsonStringEnumMemberName("Latest")]
    Latest
}

/// <summary>NodeImageSelection: The node image upgrade to be applied to the target clusters in auto upgrade.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsAutoUpgradeProfileSpecNodeImageSelection
{
    /// <summary>Type: The node image upgrade type.</summary>
    [JsonPropertyName("type")]
    public required V1api20250301FleetsAutoUpgradeProfileSpecNodeImageSelectionTypeEnum Type { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsAutoUpgradeProfileSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20250301FleetsAutoUpgradeProfileSpecOperatorSpecSecretExpressions
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
public partial class V1api20250301FleetsAutoUpgradeProfileSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20250301FleetsAutoUpgradeProfileSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20250301FleetsAutoUpgradeProfileSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a containerservice.azure.com/Fleet resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsAutoUpgradeProfileSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// UpdateStrategyReference: The resource id of the UpdateStrategy resource to reference. If not specified, the auto upgrade
/// will run on all clusters which are members of the fleet.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsAutoUpgradeProfileSpecUpdateStrategyReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsAutoUpgradeProfileSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Channel: Configures how auto-upgrade will be run.</summary>
    [JsonPropertyName("channel")]
    public required V1api20250301FleetsAutoUpgradeProfileSpecChannelEnum Channel { get; set; }

    /// <summary>
    /// Disabled: If set to False: the auto upgrade has effect - target managed clusters will be upgraded on schedule.
    /// If set to True: the auto upgrade has no effect - no upgrade will be run on the target managed clusters.
    /// This is a boolean and not an enum because enabled/disabled are all available states of the auto upgrade profile.
    /// By default, this is set to False.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>NodeImageSelection: The node image upgrade to be applied to the target clusters in auto upgrade.</summary>
    [JsonPropertyName("nodeImageSelection")]
    public V1api20250301FleetsAutoUpgradeProfileSpecNodeImageSelection? NodeImageSelection { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20250301FleetsAutoUpgradeProfileSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a containerservice.azure.com/Fleet resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20250301FleetsAutoUpgradeProfileSpecOwner Owner { get; set; }

    /// <summary>
    /// UpdateStrategyReference: The resource id of the UpdateStrategy resource to reference. If not specified, the auto upgrade
    /// will run on all clusters which are members of the fleet.
    /// </summary>
    [JsonPropertyName("updateStrategyReference")]
    public V1api20250301FleetsAutoUpgradeProfileSpecUpdateStrategyReference? UpdateStrategyReference { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsAutoUpgradeProfileStatusAutoUpgradeProfileStatusLastTriggerErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsAutoUpgradeProfileStatusAutoUpgradeProfileStatusLastTriggerErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsAutoUpgradeProfileStatusAutoUpgradeProfileStatusLastTriggerErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301FleetsAutoUpgradeProfileStatusAutoUpgradeProfileStatusLastTriggerErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>LastTriggerError: The error details of the last trigger.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsAutoUpgradeProfileStatusAutoUpgradeProfileStatusLastTriggerError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301FleetsAutoUpgradeProfileStatusAutoUpgradeProfileStatusLastTriggerErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20250301FleetsAutoUpgradeProfileStatusAutoUpgradeProfileStatusLastTriggerErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>AutoUpgradeProfileStatus: The status of the auto upgrade profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsAutoUpgradeProfileStatusAutoUpgradeProfileStatus
{
    /// <summary>LastTriggerError: The error details of the last trigger.</summary>
    [JsonPropertyName("lastTriggerError")]
    public V1api20250301FleetsAutoUpgradeProfileStatusAutoUpgradeProfileStatusLastTriggerError? LastTriggerError { get; set; }

    /// <summary>LastTriggerStatus: The status of the last AutoUpgrade trigger.</summary>
    [JsonPropertyName("lastTriggerStatus")]
    public string? LastTriggerStatus { get; set; }

    /// <summary>LastTriggerUpgradeVersions: The target Kubernetes version or node image versions of the last trigger.</summary>
    [JsonPropertyName("lastTriggerUpgradeVersions")]
    public IList<string>? LastTriggerUpgradeVersions { get; set; }

    /// <summary>
    /// LastTriggeredAt: The UTC time of the last attempt to automatically create and start an UpdateRun as triggered by the
    /// release of new versions.
    /// </summary>
    [JsonPropertyName("lastTriggeredAt")]
    public string? LastTriggeredAt { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsAutoUpgradeProfileStatusConditions
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

/// <summary>NodeImageSelection: The node image upgrade to be applied to the target clusters in auto upgrade.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsAutoUpgradeProfileStatusNodeImageSelection
{
    /// <summary>Type: The node image upgrade type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsAutoUpgradeProfileStatusSystemData
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
public partial class V1api20250301FleetsAutoUpgradeProfileStatus
{
    /// <summary>AutoUpgradeProfileStatus: The status of the auto upgrade profile.</summary>
    [JsonPropertyName("autoUpgradeProfileStatus")]
    public V1api20250301FleetsAutoUpgradeProfileStatusAutoUpgradeProfileStatus? AutoUpgradeProfileStatus { get; set; }

    /// <summary>Channel: Configures how auto-upgrade will be run.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20250301FleetsAutoUpgradeProfileStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Disabled: If set to False: the auto upgrade has effect - target managed clusters will be upgraded on schedule.
    /// If set to True: the auto upgrade has no effect - no upgrade will be run on the target managed clusters.
    /// This is a boolean and not an enum because enabled/disabled are all available states of the auto upgrade profile.
    /// By default, this is set to False.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// ETag: If eTag is provided in the response body, it may also be provided as a header per the normal etag convention.
    /// Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in
    /// the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header
    /// fields.
    /// </summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NodeImageSelection: The node image upgrade to be applied to the target clusters in auto upgrade.</summary>
    [JsonPropertyName("nodeImageSelection")]
    public V1api20250301FleetsAutoUpgradeProfileStatusNodeImageSelection? NodeImageSelection { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the AutoUpgradeProfile resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20250301FleetsAutoUpgradeProfileStatusSystemData? SystemData { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UpdateStrategyId: The resource id of the UpdateStrategy resource to reference. If not specified, the auto upgrade will
    /// run on all clusters which are members of the fleet.
    /// </summary>
    [JsonPropertyName("updateStrategyId")]
    public string? UpdateStrategyId { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/fleets.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/autoUpgradeProfiles/{autoUpgradeProfileName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250301FleetsAutoUpgradeProfile : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20250301FleetsAutoUpgradeProfileSpec?>, IStatus<V1api20250301FleetsAutoUpgradeProfileStatus?>
{
    public const string KubeApiVersion = "v1api20250301";
    public const string KubeKind = "FleetsAutoUpgradeProfile";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "fleetsautoupgradeprofiles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v1api20250301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FleetsAutoUpgradeProfile";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20250301FleetsAutoUpgradeProfileSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20250301FleetsAutoUpgradeProfileStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2020-12-01/compute.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/extensions/{vmExtensionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20201201VirtualMachinesExtensionList : IKubernetesObject<V1ListMeta>, IItems<V20201201VirtualMachinesExtension>
{
    public const string KubeApiVersion = "v20201201";
    public const string KubeKind = "VirtualMachinesExtensionList";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "virtualmachinesextensions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v20201201";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualMachinesExtensionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20201201VirtualMachinesExtension objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20201201VirtualMachinesExtension> Items { get; set; }
}

/// <summary>Level: The level code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachinesExtensionSpecInstanceViewStatusesLevelEnum>))]
public enum V20201201VirtualMachinesExtensionSpecInstanceViewStatusesLevelEnum
{
    [EnumMember(Value = "Error"), JsonStringEnumMemberName("Error")]
    Error,
    [EnumMember(Value = "Info"), JsonStringEnumMemberName("Info")]
    Info,
    [EnumMember(Value = "Warning"), JsonStringEnumMemberName("Warning")]
    Warning
}

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachinesExtensionSpecInstanceViewStatuses
{
    /// <summary>Code: The status code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>DisplayStatus: The short localizable label for the status.</summary>
    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    /// <summary>Level: The level code.</summary>
    [JsonPropertyName("level")]
    public V20201201VirtualMachinesExtensionSpecInstanceViewStatusesLevelEnum? Level { get; set; }

    /// <summary>Message: The detailed status message, including for alerts and error messages.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Time: The time of the status.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>Level: The level code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20201201VirtualMachinesExtensionSpecInstanceViewSubstatusesLevelEnum>))]
public enum V20201201VirtualMachinesExtensionSpecInstanceViewSubstatusesLevelEnum
{
    [EnumMember(Value = "Error"), JsonStringEnumMemberName("Error")]
    Error,
    [EnumMember(Value = "Info"), JsonStringEnumMemberName("Info")]
    Info,
    [EnumMember(Value = "Warning"), JsonStringEnumMemberName("Warning")]
    Warning
}

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachinesExtensionSpecInstanceViewSubstatuses
{
    /// <summary>Code: The status code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>DisplayStatus: The short localizable label for the status.</summary>
    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    /// <summary>Level: The level code.</summary>
    [JsonPropertyName("level")]
    public V20201201VirtualMachinesExtensionSpecInstanceViewSubstatusesLevelEnum? Level { get; set; }

    /// <summary>Message: The detailed status message, including for alerts and error messages.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Time: The time of the status.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>InstanceView: The virtual machine extension instance view.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachinesExtensionSpecInstanceView
{
    /// <summary>Name: The virtual machine extension name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Statuses: The resource status information.</summary>
    [JsonPropertyName("statuses")]
    public IList<V20201201VirtualMachinesExtensionSpecInstanceViewStatuses>? Statuses { get; set; }

    /// <summary>Substatuses: The resource status information.</summary>
    [JsonPropertyName("substatuses")]
    public IList<V20201201VirtualMachinesExtensionSpecInstanceViewSubstatuses>? Substatuses { get; set; }

    /// <summary>Type: Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>TypeHandlerVersion: Specifies the version of the script handler.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachinesExtensionSpecOperatorSpecConfigMapExpressions
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
public partial class V20201201VirtualMachinesExtensionSpecOperatorSpecSecretExpressions
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
public partial class V20201201VirtualMachinesExtensionSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20201201VirtualMachinesExtensionSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20201201VirtualMachinesExtensionSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a compute.azure.com/VirtualMachine resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachinesExtensionSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// ProtectedSettings: The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected
/// settings at all.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachinesExtensionSpecProtectedSettings
{
    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachinesExtensionSpec
{
    /// <summary>
    /// AutoUpgradeMinorVersion: Indicates whether the extension should use a newer minor version if one is available at
    /// deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this
    /// property set to true.
    /// </summary>
    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// EnableAutomaticUpgrade: Indicates whether the extension should be automatically upgraded by the platform if there is a
    /// newer version of the extension available.
    /// </summary>
    [JsonPropertyName("enableAutomaticUpgrade")]
    public bool? EnableAutomaticUpgrade { get; set; }

    /// <summary>ForceUpdateTag: How the extension handler should be forced to update even if the extension configuration has not changed.</summary>
    [JsonPropertyName("forceUpdateTag")]
    public string? ForceUpdateTag { get; set; }

    /// <summary>InstanceView: The virtual machine extension instance view.</summary>
    [JsonPropertyName("instanceView")]
    public V20201201VirtualMachinesExtensionSpecInstanceView? InstanceView { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20201201VirtualMachinesExtensionSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a compute.azure.com/VirtualMachine resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20201201VirtualMachinesExtensionSpecOwner Owner { get; set; }

    /// <summary>
    /// ProtectedSettings: The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected
    /// settings at all.
    /// </summary>
    [JsonPropertyName("protectedSettings")]
    public V20201201VirtualMachinesExtensionSpecProtectedSettings? ProtectedSettings { get; set; }

    /// <summary>Publisher: The name of the extension handler publisher.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Settings: Json formatted public settings for the extension.</summary>
    [JsonPropertyName("settings")]
    public IDictionary<string, JsonNode>? Settings { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>TypeHandlerVersion: Specifies the version of the script handler.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachinesExtensionStatusConditions
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

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachinesExtensionStatusInstanceViewStatuses
{
    /// <summary>Code: The status code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>DisplayStatus: The short localizable label for the status.</summary>
    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    /// <summary>Level: The level code.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Message: The detailed status message, including for alerts and error messages.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Time: The time of the status.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachinesExtensionStatusInstanceViewSubstatuses
{
    /// <summary>Code: The status code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>DisplayStatus: The short localizable label for the status.</summary>
    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    /// <summary>Level: The level code.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Message: The detailed status message, including for alerts and error messages.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Time: The time of the status.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>InstanceView: The virtual machine extension instance view.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachinesExtensionStatusInstanceView
{
    /// <summary>Name: The virtual machine extension name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Statuses: The resource status information.</summary>
    [JsonPropertyName("statuses")]
    public IList<V20201201VirtualMachinesExtensionStatusInstanceViewStatuses>? Statuses { get; set; }

    /// <summary>Substatuses: The resource status information.</summary>
    [JsonPropertyName("substatuses")]
    public IList<V20201201VirtualMachinesExtensionStatusInstanceViewSubstatuses>? Substatuses { get; set; }

    /// <summary>Type: Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>TypeHandlerVersion: Specifies the version of the script handler.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20201201VirtualMachinesExtensionStatus
{
    /// <summary>
    /// AutoUpgradeMinorVersion: Indicates whether the extension should use a newer minor version if one is available at
    /// deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this
    /// property set to true.
    /// </summary>
    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20201201VirtualMachinesExtensionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// EnableAutomaticUpgrade: Indicates whether the extension should be automatically upgraded by the platform if there is a
    /// newer version of the extension available.
    /// </summary>
    [JsonPropertyName("enableAutomaticUpgrade")]
    public bool? EnableAutomaticUpgrade { get; set; }

    /// <summary>ForceUpdateTag: How the extension handler should be forced to update even if the extension configuration has not changed.</summary>
    [JsonPropertyName("forceUpdateTag")]
    public string? ForceUpdateTag { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>InstanceView: The virtual machine extension instance view.</summary>
    [JsonPropertyName("instanceView")]
    public V20201201VirtualMachinesExtensionStatusInstanceView? InstanceView { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Resource name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PropertiesType: Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;.</summary>
    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    /// <summary>ProvisioningState: The provisioning state, which only appears in the response.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Publisher: The name of the extension handler publisher.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Settings: Json formatted public settings for the extension.</summary>
    [JsonPropertyName("settings")]
    public IDictionary<string, JsonNode>? Settings { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>TypeHandlerVersion: Specifies the version of the script handler.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2020-12-01/compute.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/extensions/{vmExtensionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20201201VirtualMachinesExtension : IKubernetesObject<V1ObjectMeta>, ISpec<V20201201VirtualMachinesExtensionSpec?>, IStatus<V20201201VirtualMachinesExtensionStatus?>
{
    public const string KubeApiVersion = "v20201201";
    public const string KubeKind = "VirtualMachinesExtension";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "virtualmachinesextensions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v20201201";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualMachinesExtension";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20201201VirtualMachinesExtensionSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20201201VirtualMachinesExtensionStatus? Status { get; set; }
}
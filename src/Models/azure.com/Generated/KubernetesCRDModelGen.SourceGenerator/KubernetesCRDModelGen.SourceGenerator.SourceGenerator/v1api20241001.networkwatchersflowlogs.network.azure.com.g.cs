#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2024-10-01/networkWatcher.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20241001NetworkWatchersFlowLogList : IKubernetesObject<V1ListMeta>, IItems<V1api20241001NetworkWatchersFlowLog>
{
    public const string KubeApiVersion = "v1api20241001";
    public const string KubeKind = "NetworkWatchersFlowLogList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "networkwatchersflowlogs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20241001";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkWatchersFlowLogList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20241001NetworkWatchersFlowLog objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20241001NetworkWatchersFlowLog> Items { get; set; }
}

/// <summary>WorkspaceResourceReference: Resource Id of the attached workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogSpecFlowAnalyticsConfigurationNetworkWatcherFlowAnalyticsConfigurationWorkspaceResourceReference
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

/// <summary>NetworkWatcherFlowAnalyticsConfiguration: Parameters that define the configuration of traffic analytics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogSpecFlowAnalyticsConfigurationNetworkWatcherFlowAnalyticsConfiguration
{
    /// <summary>Enabled: Flag to enable/disable traffic analytics.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>TrafficAnalyticsInterval: The interval in minutes which would decide how frequently TA service should do flow analytics.</summary>
    [JsonPropertyName("trafficAnalyticsInterval")]
    public int? TrafficAnalyticsInterval { get; set; }

    /// <summary>WorkspaceRegion: The location of the attached workspace.</summary>
    [JsonPropertyName("workspaceRegion")]
    public string? WorkspaceRegion { get; set; }

    /// <summary>WorkspaceResourceReference: Resource Id of the attached workspace.</summary>
    [JsonPropertyName("workspaceResourceReference")]
    public V1api20241001NetworkWatchersFlowLogSpecFlowAnalyticsConfigurationNetworkWatcherFlowAnalyticsConfigurationWorkspaceResourceReference? WorkspaceResourceReference { get; set; }
}

/// <summary>FlowAnalyticsConfiguration: Parameters that define the configuration of traffic analytics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogSpecFlowAnalyticsConfiguration
{
    /// <summary>NetworkWatcherFlowAnalyticsConfiguration: Parameters that define the configuration of traffic analytics.</summary>
    [JsonPropertyName("networkWatcherFlowAnalyticsConfiguration")]
    public V1api20241001NetworkWatchersFlowLogSpecFlowAnalyticsConfigurationNetworkWatcherFlowAnalyticsConfiguration? NetworkWatcherFlowAnalyticsConfiguration { get; set; }
}

/// <summary>Type: The file type of flow log.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20241001NetworkWatchersFlowLogSpecFormatTypeEnum>))]
public enum V1api20241001NetworkWatchersFlowLogSpecFormatTypeEnum
{
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    JSON
}

/// <summary>Format: Parameters that define the flow log format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogSpecFormat
{
    /// <summary>Type: The file type of flow log.</summary>
    [JsonPropertyName("type")]
    public V1api20241001NetworkWatchersFlowLogSpecFormatTypeEnum? Type { get; set; }

    /// <summary>Version: The version (revision) of the flow log.</summary>
    [JsonPropertyName("version")]
    public int? Version { get; set; }
}

/// <summary>
/// Type: The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly
/// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the virtual
/// machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20241001NetworkWatchersFlowLogSpecIdentityTypeEnum>))]
public enum V1api20241001NetworkWatchersFlowLogSpecIdentityTypeEnum
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
public partial class V1api20241001NetworkWatchersFlowLogSpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20241001NetworkWatchersFlowLogSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20241001NetworkWatchersFlowLogSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: FlowLog resource Managed Identity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogSpecIdentity
{
    /// <summary>
    /// Type: The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly
    /// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the virtual
    /// machine.
    /// </summary>
    [JsonPropertyName("type")]
    public V1api20241001NetworkWatchersFlowLogSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with resource. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20241001NetworkWatchersFlowLogSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20241001NetworkWatchersFlowLogSpecOperatorSpecSecretExpressions
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
public partial class V1api20241001NetworkWatchersFlowLogSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20241001NetworkWatchersFlowLogSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20241001NetworkWatchersFlowLogSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a network.azure.com/NetworkWatcher resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>RetentionPolicy: Parameters that define the retention policy for flow log.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogSpecRetentionPolicy
{
    /// <summary>Days: Number of days to retain flow log records.</summary>
    [JsonPropertyName("days")]
    public int? Days { get; set; }

    /// <summary>Enabled: Flag to enable/disable retention.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>StorageReference: ID of the storage account which is used to store the flow log.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogSpecStorageReference
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

/// <summary>TargetResourceReference: ID of network security group to which flow log will be applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogSpecTargetResourceReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Enabled: Flag to enable/disable flow logging.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// EnabledFilteringCriteria: Optional field to filter network traffic logs based on SrcIP, SrcPort, DstIP, DstPort,
    /// Protocol, Encryption, Direction and Action. If not specified, all network traffic will be logged.
    /// </summary>
    [JsonPropertyName("enabledFilteringCriteria")]
    public string? EnabledFilteringCriteria { get; set; }

    /// <summary>FlowAnalyticsConfiguration: Parameters that define the configuration of traffic analytics.</summary>
    [JsonPropertyName("flowAnalyticsConfiguration")]
    public V1api20241001NetworkWatchersFlowLogSpecFlowAnalyticsConfiguration? FlowAnalyticsConfiguration { get; set; }

    /// <summary>Format: Parameters that define the flow log format.</summary>
    [JsonPropertyName("format")]
    public V1api20241001NetworkWatchersFlowLogSpecFormat? Format { get; set; }

    /// <summary>Identity: FlowLog resource Managed Identity</summary>
    [JsonPropertyName("identity")]
    public V1api20241001NetworkWatchersFlowLogSpecIdentity? Identity { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20241001NetworkWatchersFlowLogSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a network.azure.com/NetworkWatcher resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20241001NetworkWatchersFlowLogSpecOwner Owner { get; set; }

    /// <summary>RetentionPolicy: Parameters that define the retention policy for flow log.</summary>
    [JsonPropertyName("retentionPolicy")]
    public V1api20241001NetworkWatchersFlowLogSpecRetentionPolicy? RetentionPolicy { get; set; }

    /// <summary>StorageReference: ID of the storage account which is used to store the flow log.</summary>
    [JsonPropertyName("storageReference")]
    public required V1api20241001NetworkWatchersFlowLogSpecStorageReference StorageReference { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TargetResourceReference: ID of network security group to which flow log will be applied.</summary>
    [JsonPropertyName("targetResourceReference")]
    public required V1api20241001NetworkWatchersFlowLogSpecTargetResourceReference TargetResourceReference { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogStatusConditions
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

/// <summary>NetworkWatcherFlowAnalyticsConfiguration: Parameters that define the configuration of traffic analytics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogStatusFlowAnalyticsConfigurationNetworkWatcherFlowAnalyticsConfiguration
{
    /// <summary>Enabled: Flag to enable/disable traffic analytics.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>TrafficAnalyticsInterval: The interval in minutes which would decide how frequently TA service should do flow analytics.</summary>
    [JsonPropertyName("trafficAnalyticsInterval")]
    public int? TrafficAnalyticsInterval { get; set; }

    /// <summary>WorkspaceId: The resource guid of the attached workspace.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }

    /// <summary>WorkspaceRegion: The location of the attached workspace.</summary>
    [JsonPropertyName("workspaceRegion")]
    public string? WorkspaceRegion { get; set; }

    /// <summary>WorkspaceResourceId: Resource Id of the attached workspace.</summary>
    [JsonPropertyName("workspaceResourceId")]
    public string? WorkspaceResourceId { get; set; }
}

/// <summary>FlowAnalyticsConfiguration: Parameters that define the configuration of traffic analytics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogStatusFlowAnalyticsConfiguration
{
    /// <summary>NetworkWatcherFlowAnalyticsConfiguration: Parameters that define the configuration of traffic analytics.</summary>
    [JsonPropertyName("networkWatcherFlowAnalyticsConfiguration")]
    public V1api20241001NetworkWatchersFlowLogStatusFlowAnalyticsConfigurationNetworkWatcherFlowAnalyticsConfiguration? NetworkWatcherFlowAnalyticsConfiguration { get; set; }
}

/// <summary>Format: Parameters that define the flow log format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogStatusFormat
{
    /// <summary>Type: The file type of flow log.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Version: The version (revision) of the flow log.</summary>
    [JsonPropertyName("version")]
    public int? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: FlowLog resource Managed Identity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogStatusIdentity
{
    /// <summary>
    /// PrincipalId: The principal id of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: The tenant id of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// Type: The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly
    /// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the virtual
    /// machine.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with resource. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20241001NetworkWatchersFlowLogStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>RetentionPolicy: Parameters that define the retention policy for flow log.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogStatusRetentionPolicy
{
    /// <summary>Days: Number of days to retain flow log records.</summary>
    [JsonPropertyName("days")]
    public int? Days { get; set; }

    /// <summary>Enabled: Flag to enable/disable retention.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20241001NetworkWatchersFlowLogStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20241001NetworkWatchersFlowLogStatusConditions>? Conditions { get; set; }

    /// <summary>Enabled: Flag to enable/disable flow logging.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// EnabledFilteringCriteria: Optional field to filter network traffic logs based on SrcIP, SrcPort, DstIP, DstPort,
    /// Protocol, Encryption, Direction and Action. If not specified, all network traffic will be logged.
    /// </summary>
    [JsonPropertyName("enabledFilteringCriteria")]
    public string? EnabledFilteringCriteria { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>FlowAnalyticsConfiguration: Parameters that define the configuration of traffic analytics.</summary>
    [JsonPropertyName("flowAnalyticsConfiguration")]
    public V1api20241001NetworkWatchersFlowLogStatusFlowAnalyticsConfiguration? FlowAnalyticsConfiguration { get; set; }

    /// <summary>Format: Parameters that define the flow log format.</summary>
    [JsonPropertyName("format")]
    public V1api20241001NetworkWatchersFlowLogStatusFormat? Format { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: FlowLog resource Managed Identity</summary>
    [JsonPropertyName("identity")]
    public V1api20241001NetworkWatchersFlowLogStatusIdentity? Identity { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the flow log.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>RetentionPolicy: Parameters that define the retention policy for flow log.</summary>
    [JsonPropertyName("retentionPolicy")]
    public V1api20241001NetworkWatchersFlowLogStatusRetentionPolicy? RetentionPolicy { get; set; }

    /// <summary>StorageId: ID of the storage account which is used to store the flow log.</summary>
    [JsonPropertyName("storageId")]
    public string? StorageId { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TargetResourceGuid: Guid of network security group to which flow log will be applied.</summary>
    [JsonPropertyName("targetResourceGuid")]
    public string? TargetResourceGuid { get; set; }

    /// <summary>TargetResourceId: ID of network security group to which flow log will be applied.</summary>
    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2024-10-01/networkWatcher.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkWatchers/{networkWatcherName}/flowLogs/{flowLogName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20241001NetworkWatchersFlowLog : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20241001NetworkWatchersFlowLogSpec?>, IStatus<V1api20241001NetworkWatchersFlowLogStatus?>
{
    public const string KubeApiVersion = "v1api20241001";
    public const string KubeKind = "NetworkWatchersFlowLog";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "networkwatchersflowlogs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20241001";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkWatchersFlowLog";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20241001NetworkWatchersFlowLogSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20241001NetworkWatchersFlowLogStatus? Status { get; set; }
}
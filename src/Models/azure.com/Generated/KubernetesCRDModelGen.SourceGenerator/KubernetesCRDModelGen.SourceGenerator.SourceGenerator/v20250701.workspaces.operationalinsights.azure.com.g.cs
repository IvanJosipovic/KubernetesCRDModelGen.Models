#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.operationalinsights.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /operationalinsights/resource-manager/Microsoft.OperationalInsights/OperationalInsights/stable/2025-07-01/Workspaces.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250701WorkspaceList : IKubernetesObject<V1ListMeta>, IItems<V20250701Workspace>
{
    public const string KubeApiVersion = "v20250701";
    public const string KubeKind = "WorkspaceList";
    public const string KubeGroup = "operationalinsights.azure.com";
    public const string KubePluralName = "workspaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "operationalinsights.azure.com/v20250701";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkspaceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250701Workspace objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250701Workspace> Items { get; set; }
}

/// <summary>
/// DefaultDataCollectionRuleResourceReference: The resource ID of the default Data Collection Rule to use for this
/// workspace. Expected format is -
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dcrName}.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceSpecDefaultDataCollectionRuleResourceReference
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

/// <summary>ClusterResourceReference: Dedicated LA cluster resourceId that is linked to the workspaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceSpecFeaturesClusterResourceReference
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

/// <summary>Features: Workspace features.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceSpecFeatures
{
    /// <summary>ClusterResourceReference: Dedicated LA cluster resourceId that is linked to the workspaces.</summary>
    [JsonPropertyName("clusterResourceReference")]
    public V20250701WorkspaceSpecFeaturesClusterResourceReference? ClusterResourceReference { get; set; }

    /// <summary>DisableLocalAuth: Disable Non-AAD based Auth.</summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>EnableDataExport: Flag that indicate if data should be exported.</summary>
    [JsonPropertyName("enableDataExport")]
    public bool? EnableDataExport { get; set; }

    /// <summary>EnableLogAccessUsingOnlyResourcePermissions: Flag that indicate which permission to use - resource or workspace or both.</summary>
    [JsonPropertyName("enableLogAccessUsingOnlyResourcePermissions")]
    public bool? EnableLogAccessUsingOnlyResourcePermissions { get; set; }

    /// <summary>ImmediatePurgeDataOn30Days: Flag that describes if we want to remove the data after 30 days.</summary>
    [JsonPropertyName("immediatePurgeDataOn30Days")]
    public bool? ImmediatePurgeDataOn30Days { get; set; }
}

/// <summary>Type: Type of managed service identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250701WorkspaceSpecIdentityTypeEnum>))]
public enum V20250701WorkspaceSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceSpecIdentityUserAssignedIdentitiesReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20250701WorkspaceSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceSpecIdentity
{
    /// <summary>Type: Type of managed service identity.</summary>
    [JsonPropertyName("type")]
    public required V20250701WorkspaceSpecIdentityTypeEnum Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the resource. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20250701WorkspaceSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceSpecOperatorSpecConfigMapExpressions
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
public partial class V20250701WorkspaceSpecOperatorSpecSecretExpressions
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
/// PrimarySharedKey: indicates where the PrimarySharedKey secret should be placed. If omitted, the secret will not be
/// retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceSpecOperatorSpecSecretsPrimarySharedKey
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
/// SecondarySharedKey: indicates where the SecondarySharedKey secret should be placed. If omitted, the secret will not be
/// retrieved from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceSpecOperatorSpecSecretsSecondarySharedKey
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

/// <summary>Secrets: configures where to place Azure generated secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceSpecOperatorSpecSecrets
{
    /// <summary>
    /// PrimarySharedKey: indicates where the PrimarySharedKey secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("primarySharedKey")]
    public V20250701WorkspaceSpecOperatorSpecSecretsPrimarySharedKey? PrimarySharedKey { get; set; }

    /// <summary>
    /// SecondarySharedKey: indicates where the SecondarySharedKey secret should be placed. If omitted, the secret will not be
    /// retrieved from Azure.
    /// </summary>
    [JsonPropertyName("secondarySharedKey")]
    public V20250701WorkspaceSpecOperatorSpecSecretsSecondarySharedKey? SecondarySharedKey { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20250701WorkspaceSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20250701WorkspaceSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V20250701WorkspaceSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PublicNetworkAccessForIngestion: The network access type for accessing Log Analytics ingestion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250701WorkspaceSpecPublicNetworkAccessForIngestionEnum>))]
public enum V20250701WorkspaceSpecPublicNetworkAccessForIngestionEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "SecuredByPerimeter"), JsonStringEnumMemberName("SecuredByPerimeter")]
    SecuredByPerimeter
}

/// <summary>PublicNetworkAccessForQuery: The network access type for accessing Log Analytics query.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250701WorkspaceSpecPublicNetworkAccessForQueryEnum>))]
public enum V20250701WorkspaceSpecPublicNetworkAccessForQueryEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "SecuredByPerimeter"), JsonStringEnumMemberName("SecuredByPerimeter")]
    SecuredByPerimeter
}

/// <summary>Replication: workspace replication properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceSpecReplication
{
    /// <summary>
    /// Enabled: Specifies whether the replication is enabled or not. When true, workspace configuration and data is replicated
    /// to the specified location. If replication is been enabled, location must be provided.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Location: The location of the replication.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}

/// <summary>Name: The name of the SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250701WorkspaceSpecSkuNameEnum>))]
public enum V20250701WorkspaceSpecSkuNameEnum
{
    [EnumMember(Value = "CapacityReservation"), JsonStringEnumMemberName("CapacityReservation")]
    CapacityReservation,
    [EnumMember(Value = "Free"), JsonStringEnumMemberName("Free")]
    Free,
    [EnumMember(Value = "LACluster"), JsonStringEnumMemberName("LACluster")]
    LACluster,
    [EnumMember(Value = "PerGB2018"), JsonStringEnumMemberName("PerGB2018")]
    PerGB2018,
    [EnumMember(Value = "PerNode"), JsonStringEnumMemberName("PerNode")]
    PerNode,
    [EnumMember(Value = "Premium"), JsonStringEnumMemberName("Premium")]
    Premium,
    [EnumMember(Value = "Standalone"), JsonStringEnumMemberName("Standalone")]
    Standalone,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Sku: The SKU of the workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceSpecSku
{
    /// <summary>
    /// CapacityReservationLevel: The capacity reservation level in GB for this workspace, when CapacityReservation sku is
    /// selected.
    /// </summary>
    [JsonPropertyName("capacityReservationLevel")]
    public int? CapacityReservationLevel { get; set; }

    /// <summary>Name: The name of the SKU.</summary>
    [JsonPropertyName("name")]
    public required V20250701WorkspaceSpecSkuNameEnum Name { get; set; }
}

/// <summary>WorkspaceCapping: The daily volume cap for ingestion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceSpecWorkspaceCapping
{
    /// <summary>DailyQuotaGb: The workspace daily quota for ingestion.</summary>
    [JsonPropertyName("dailyQuotaGb")]
    public double? DailyQuotaGb { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// DefaultDataCollectionRuleResourceReference: The resource ID of the default Data Collection Rule to use for this
    /// workspace. Expected format is -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dcrName}.
    /// </summary>
    [JsonPropertyName("defaultDataCollectionRuleResourceReference")]
    public V20250701WorkspaceSpecDefaultDataCollectionRuleResourceReference? DefaultDataCollectionRuleResourceReference { get; set; }

    /// <summary>Etag: The etag of the workspace.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Features: Workspace features.</summary>
    [JsonPropertyName("features")]
    public V20250701WorkspaceSpecFeatures? Features { get; set; }

    /// <summary>ForceCmkForQuery: Indicates whether customer managed storage is mandatory for query management.</summary>
    [JsonPropertyName("forceCmkForQuery")]
    public bool? ForceCmkForQuery { get; set; }

    /// <summary>Identity: The identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V20250701WorkspaceSpecIdentity? Identity { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250701WorkspaceSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250701WorkspaceSpecOwner Owner { get; set; }

    /// <summary>PublicNetworkAccessForIngestion: The network access type for accessing Log Analytics ingestion.</summary>
    [JsonPropertyName("publicNetworkAccessForIngestion")]
    public V20250701WorkspaceSpecPublicNetworkAccessForIngestionEnum? PublicNetworkAccessForIngestion { get; set; }

    /// <summary>PublicNetworkAccessForQuery: The network access type for accessing Log Analytics query.</summary>
    [JsonPropertyName("publicNetworkAccessForQuery")]
    public V20250701WorkspaceSpecPublicNetworkAccessForQueryEnum? PublicNetworkAccessForQuery { get; set; }

    /// <summary>Replication: workspace replication properties.</summary>
    [JsonPropertyName("replication")]
    public V20250701WorkspaceSpecReplication? Replication { get; set; }

    /// <summary>
    /// RetentionInDays: The workspace data retention in days. Allowed values are per pricing plan. See pricing tiers
    /// documentation for details.
    /// </summary>
    [JsonPropertyName("retentionInDays")]
    public int? RetentionInDays { get; set; }

    /// <summary>Sku: The SKU of the workspace.</summary>
    [JsonPropertyName("sku")]
    public V20250701WorkspaceSpecSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>WorkspaceCapping: The daily volume cap for ingestion.</summary>
    [JsonPropertyName("workspaceCapping")]
    public V20250701WorkspaceSpecWorkspaceCapping? WorkspaceCapping { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceStatusConditions
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

/// <summary>Failover: workspace failover properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceStatusFailover
{
    /// <summary>LastModifiedDate: The last time when the failover state was updated.</summary>
    [JsonPropertyName("lastModifiedDate")]
    public string? LastModifiedDate { get; set; }

    /// <summary>State: The failover state of the replication.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Features: Workspace features.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceStatusFeatures
{
    /// <summary>
    /// Associations: List of associations for the workspace. Indicates if the workspace is associated with any of the following
    /// experiences: MDC, Sentinel, SentinelGraph, etc.
    /// </summary>
    [JsonPropertyName("associations")]
    public IList<string>? Associations { get; set; }

    /// <summary>ClusterResourceId: Dedicated LA cluster resourceId that is linked to the workspaces.</summary>
    [JsonPropertyName("clusterResourceId")]
    public string? ClusterResourceId { get; set; }

    /// <summary>DisableLocalAuth: Disable Non-AAD based Auth.</summary>
    [JsonPropertyName("disableLocalAuth")]
    public bool? DisableLocalAuth { get; set; }

    /// <summary>EnableDataExport: Flag that indicate if data should be exported.</summary>
    [JsonPropertyName("enableDataExport")]
    public bool? EnableDataExport { get; set; }

    /// <summary>EnableLogAccessUsingOnlyResourcePermissions: Flag that indicate which permission to use - resource or workspace or both.</summary>
    [JsonPropertyName("enableLogAccessUsingOnlyResourcePermissions")]
    public bool? EnableLogAccessUsingOnlyResourcePermissions { get; set; }

    /// <summary>ImmediatePurgeDataOn30Days: Flag that describes if we want to remove the data after 30 days.</summary>
    [JsonPropertyName("immediatePurgeDataOn30Days")]
    public bool? ImmediatePurgeDataOn30Days { get; set; }

    /// <summary>UnifiedSentinelBillingOnly: An indication if the specify workspace is limited to sentinel&apos;s unified billing model only.</summary>
    [JsonPropertyName("unifiedSentinelBillingOnly")]
    public bool? UnifiedSentinelBillingOnly { get; set; }
}

/// <summary>User assigned identity properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceStatusIdentity
{
    /// <summary>PrincipalId: The principal ID of resource identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The tenant ID of resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: Type of managed service identity.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with the resource. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20250701WorkspaceStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>The private link scope resource reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceStatusPrivateLinkScopedResources
{
    /// <summary>ResourceId: The full resource Id of the private link scope resource.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>ScopeId: The private link scope unique Identifier.</summary>
    [JsonPropertyName("scopeId")]
    public string? ScopeId { get; set; }
}

/// <summary>Replication: workspace replication properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceStatusReplication
{
    /// <summary>CreatedDate: The last time when the replication was enabled.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>
    /// Enabled: Specifies whether the replication is enabled or not. When true, workspace configuration and data is replicated
    /// to the specified location. If replication is been enabled, location must be provided.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>LastModifiedDate: The last time when the replication was updated.</summary>
    [JsonPropertyName("lastModifiedDate")]
    public string? LastModifiedDate { get; set; }

    /// <summary>Location: The location of the replication.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the replication.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>Sku: The SKU of the workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceStatusSku
{
    /// <summary>
    /// CapacityReservationLevel: The capacity reservation level in GB for this workspace, when CapacityReservation sku is
    /// selected.
    /// </summary>
    [JsonPropertyName("capacityReservationLevel")]
    public int? CapacityReservationLevel { get; set; }

    /// <summary>LastSkuUpdate: The last time when the sku was updated.</summary>
    [JsonPropertyName("lastSkuUpdate")]
    public string? LastSkuUpdate { get; set; }

    /// <summary>Name: The name of the SKU.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceStatusSystemData
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

/// <summary>WorkspaceCapping: The daily volume cap for ingestion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceStatusWorkspaceCapping
{
    /// <summary>DailyQuotaGb: The workspace daily quota for ingestion.</summary>
    [JsonPropertyName("dailyQuotaGb")]
    public double? DailyQuotaGb { get; set; }

    /// <summary>DataIngestionStatus: The status of data ingestion for this workspace.</summary>
    [JsonPropertyName("dataIngestionStatus")]
    public string? DataIngestionStatus { get; set; }

    /// <summary>QuotaNextResetTime: The time when the quota will be rest.</summary>
    [JsonPropertyName("quotaNextResetTime")]
    public string? QuotaNextResetTime { get; set; }
}

/// <summary>The top level Workspace resource container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250701WorkspaceStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20250701WorkspaceStatusConditions>? Conditions { get; set; }

    /// <summary>CreatedDate: Workspace creation date.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>CustomerId: This is a read-only property. Represents the ID associated with the workspace.</summary>
    [JsonPropertyName("customerId")]
    public string? CustomerId { get; set; }

    /// <summary>
    /// DefaultDataCollectionRuleResourceId: The resource ID of the default Data Collection Rule to use for this workspace.
    /// Expected format is -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionRules/{dcrName}.
    /// </summary>
    [JsonPropertyName("defaultDataCollectionRuleResourceId")]
    public string? DefaultDataCollectionRuleResourceId { get; set; }

    /// <summary>Etag: The etag of the workspace.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Failover: workspace failover properties.</summary>
    [JsonPropertyName("failover")]
    public V20250701WorkspaceStatusFailover? Failover { get; set; }

    /// <summary>Features: Workspace features.</summary>
    [JsonPropertyName("features")]
    public V20250701WorkspaceStatusFeatures? Features { get; set; }

    /// <summary>ForceCmkForQuery: Indicates whether customer managed storage is mandatory for query management.</summary>
    [JsonPropertyName("forceCmkForQuery")]
    public bool? ForceCmkForQuery { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V20250701WorkspaceStatusIdentity? Identity { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ModifiedDate: Workspace modification date.</summary>
    [JsonPropertyName("modifiedDate")]
    public string? ModifiedDate { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateLinkScopedResources: List of linked private link scope resources.</summary>
    [JsonPropertyName("privateLinkScopedResources")]
    public IList<V20250701WorkspaceStatusPrivateLinkScopedResources>? PrivateLinkScopedResources { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the workspace.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicNetworkAccessForIngestion: The network access type for accessing Log Analytics ingestion.</summary>
    [JsonPropertyName("publicNetworkAccessForIngestion")]
    public string? PublicNetworkAccessForIngestion { get; set; }

    /// <summary>PublicNetworkAccessForQuery: The network access type for accessing Log Analytics query.</summary>
    [JsonPropertyName("publicNetworkAccessForQuery")]
    public string? PublicNetworkAccessForQuery { get; set; }

    /// <summary>Replication: workspace replication properties.</summary>
    [JsonPropertyName("replication")]
    public V20250701WorkspaceStatusReplication? Replication { get; set; }

    /// <summary>
    /// RetentionInDays: The workspace data retention in days. Allowed values are per pricing plan. See pricing tiers
    /// documentation for details.
    /// </summary>
    [JsonPropertyName("retentionInDays")]
    public int? RetentionInDays { get; set; }

    /// <summary>Sku: The SKU of the workspace.</summary>
    [JsonPropertyName("sku")]
    public V20250701WorkspaceStatusSku? Sku { get; set; }

    /// <summary>SystemData: Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V20250701WorkspaceStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>WorkspaceCapping: The daily volume cap for ingestion.</summary>
    [JsonPropertyName("workspaceCapping")]
    public V20250701WorkspaceStatusWorkspaceCapping? WorkspaceCapping { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /operationalinsights/resource-manager/Microsoft.OperationalInsights/OperationalInsights/stable/2025-07-01/Workspaces.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250701Workspace : IKubernetesObject<V1ObjectMeta>, ISpec<V20250701WorkspaceSpec?>, IStatus<V20250701WorkspaceStatus?>
{
    public const string KubeApiVersion = "v20250701";
    public const string KubeKind = "Workspace";
    public const string KubeGroup = "operationalinsights.azure.com";
    public const string KubePluralName = "workspaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "operationalinsights.azure.com/v20250701";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Workspace";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20250701WorkspaceSpec? Spec { get; set; }

    /// <summary>The top level Workspace resource container.</summary>
    [JsonPropertyName("status")]
    public V20250701WorkspaceStatus? Status { get; set; }
}
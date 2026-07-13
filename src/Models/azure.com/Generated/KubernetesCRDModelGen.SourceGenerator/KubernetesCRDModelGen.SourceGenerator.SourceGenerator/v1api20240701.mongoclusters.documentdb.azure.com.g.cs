#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.documentdb.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /mongocluster/resource-manager/Microsoft.DocumentDB/MongoCluster/stable/2024-07-01/mongoCluster.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240701MongoClusterList : IKubernetesObject<V1ListMeta>, IItems<V1api20240701MongoCluster>
{
    public const string KubeApiVersion = "v1api20240701";
    public const string KubeKind = "MongoClusterList";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "mongoclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20240701";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MongoClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240701MongoCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240701MongoCluster> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240701MongoClusterSpecOperatorSpecSecretExpressions
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
public partial class V1api20240701MongoClusterSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240701MongoClusterSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240701MongoClusterSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Password: The administrator password.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterSpecPropertiesAdministratorPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Administrator: The local administrator properties for the mongo cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterSpecPropertiesAdministrator
{
    /// <summary>Password: The administrator password.</summary>
    [JsonPropertyName("password")]
    public V1api20240701MongoClusterSpecPropertiesAdministratorPassword? Password { get; set; }

    /// <summary>UserName: The administrator user name.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>Compute: The compute properties of the mongo cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterSpecPropertiesCompute
{
    /// <summary>
    /// Tier: The compute tier to assign to the cluster, where each tier maps to a virtual-core and memory size. Example values:
    /// &apos;M30&apos;, &apos;M40&apos;.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>CreateMode: The mode to create a mongo cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240701MongoClusterSpecPropertiesCreateModeEnum>))]
public enum V1api20240701MongoClusterSpecPropertiesCreateModeEnum
{
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "GeoReplica"), JsonStringEnumMemberName("GeoReplica")]
    GeoReplica,
    [EnumMember(Value = "PointInTimeRestore"), JsonStringEnumMemberName("PointInTimeRestore")]
    PointInTimeRestore,
    [EnumMember(Value = "Replica"), JsonStringEnumMemberName("Replica")]
    Replica
}

/// <summary>TargetMode: The target high availability mode requested for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240701MongoClusterSpecPropertiesHighAvailabilityTargetModeEnum>))]
public enum V1api20240701MongoClusterSpecPropertiesHighAvailabilityTargetModeEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "SameZone"), JsonStringEnumMemberName("SameZone")]
    SameZone,
    [EnumMember(Value = "ZoneRedundantPreferred"), JsonStringEnumMemberName("ZoneRedundantPreferred")]
    ZoneRedundantPreferred
}

/// <summary>HighAvailability: The high availability properties of the mongo cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterSpecPropertiesHighAvailability
{
    /// <summary>TargetMode: The target high availability mode requested for the cluster.</summary>
    [JsonPropertyName("targetMode")]
    public V1api20240701MongoClusterSpecPropertiesHighAvailabilityTargetModeEnum? TargetMode { get; set; }
}

/// <summary>Preview features that can be enabled on a mongo cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240701MongoClusterSpecPropertiesPreviewFeaturesEnum>))]
public enum V1api20240701MongoClusterSpecPropertiesPreviewFeaturesEnum
{
    [EnumMember(Value = "GeoReplicas"), JsonStringEnumMemberName("GeoReplicas")]
    GeoReplicas
}

/// <summary>PublicNetworkAccess: Whether or not public endpoint access is allowed for this mongo cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240701MongoClusterSpecPropertiesPublicNetworkAccessEnum>))]
public enum V1api20240701MongoClusterSpecPropertiesPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>SourceResourceReference: The id of the replication source cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterSpecPropertiesReplicaParametersSourceResourceReference
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

/// <summary>ReplicaParameters: The parameters to create a replica mongo cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterSpecPropertiesReplicaParameters
{
    /// <summary>SourceLocation: The location of the source cluster</summary>
    [JsonPropertyName("sourceLocation")]
    public required string SourceLocation { get; set; }

    /// <summary>SourceResourceReference: The id of the replication source cluster.</summary>
    [JsonPropertyName("sourceResourceReference")]
    public required V1api20240701MongoClusterSpecPropertiesReplicaParametersSourceResourceReference SourceResourceReference { get; set; }
}

/// <summary>SourceResourceReference: Resource ID to locate the source cluster to restore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterSpecPropertiesRestoreParametersSourceResourceReference
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

/// <summary>RestoreParameters: The parameters to create a point-in-time restore mongo cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterSpecPropertiesRestoreParameters
{
    /// <summary>PointInTimeUTC: UTC point in time to restore a mongo cluster</summary>
    [JsonPropertyName("pointInTimeUTC")]
    public string? PointInTimeUTC { get; set; }

    /// <summary>SourceResourceReference: Resource ID to locate the source cluster to restore</summary>
    [JsonPropertyName("sourceResourceReference")]
    public V1api20240701MongoClusterSpecPropertiesRestoreParametersSourceResourceReference? SourceResourceReference { get; set; }
}

/// <summary>Sharding: The sharding properties of the mongo cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterSpecPropertiesSharding
{
    /// <summary>ShardCount: Number of shards to provision on the cluster.</summary>
    [JsonPropertyName("shardCount")]
    public int? ShardCount { get; set; }
}

/// <summary>Storage: The storage properties of the mongo cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterSpecPropertiesStorage
{
    /// <summary>SizeGb: The size of the data disk assigned to each server.</summary>
    [JsonPropertyName("sizeGb")]
    public int? SizeGb { get; set; }
}

/// <summary>Properties: The resource-specific properties for this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterSpecProperties
{
    /// <summary>Administrator: The local administrator properties for the mongo cluster.</summary>
    [JsonPropertyName("administrator")]
    public V1api20240701MongoClusterSpecPropertiesAdministrator? Administrator { get; set; }

    /// <summary>Compute: The compute properties of the mongo cluster.</summary>
    [JsonPropertyName("compute")]
    public V1api20240701MongoClusterSpecPropertiesCompute? Compute { get; set; }

    /// <summary>CreateMode: The mode to create a mongo cluster.</summary>
    [JsonPropertyName("createMode")]
    public V1api20240701MongoClusterSpecPropertiesCreateModeEnum? CreateMode { get; set; }

    /// <summary>HighAvailability: The high availability properties of the mongo cluster.</summary>
    [JsonPropertyName("highAvailability")]
    public V1api20240701MongoClusterSpecPropertiesHighAvailability? HighAvailability { get; set; }

    /// <summary>PreviewFeatures: List of private endpoint connections.</summary>
    [JsonPropertyName("previewFeatures")]
    public IList<V1api20240701MongoClusterSpecPropertiesPreviewFeaturesEnum>? PreviewFeatures { get; set; }

    /// <summary>PublicNetworkAccess: Whether or not public endpoint access is allowed for this mongo cluster.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20240701MongoClusterSpecPropertiesPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>ReplicaParameters: The parameters to create a replica mongo cluster.</summary>
    [JsonPropertyName("replicaParameters")]
    public V1api20240701MongoClusterSpecPropertiesReplicaParameters? ReplicaParameters { get; set; }

    /// <summary>RestoreParameters: The parameters to create a point-in-time restore mongo cluster.</summary>
    [JsonPropertyName("restoreParameters")]
    public V1api20240701MongoClusterSpecPropertiesRestoreParameters? RestoreParameters { get; set; }

    /// <summary>ServerVersion: The Mongo DB server version. Defaults to the latest available version if not specified.</summary>
    [JsonPropertyName("serverVersion")]
    public string? ServerVersion { get; set; }

    /// <summary>Sharding: The sharding properties of the mongo cluster.</summary>
    [JsonPropertyName("sharding")]
    public V1api20240701MongoClusterSpecPropertiesSharding? Sharding { get; set; }

    /// <summary>Storage: The storage properties of the mongo cluster.</summary>
    [JsonPropertyName("storage")]
    public V1api20240701MongoClusterSpecPropertiesStorage? Storage { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240701MongoClusterSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240701MongoClusterSpecOwner Owner { get; set; }

    /// <summary>Properties: The resource-specific properties for this resource.</summary>
    [JsonPropertyName("properties")]
    public V1api20240701MongoClusterSpecProperties? Properties { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterStatusConditions
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

/// <summary>Administrator: The local administrator properties for the mongo cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterStatusPropertiesAdministrator
{
    /// <summary>UserName: The administrator user name.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>Backup: The backup properties of the mongo cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterStatusPropertiesBackup
{
    /// <summary>EarliestRestoreTime: Earliest restore timestamp in UTC ISO8601 format.</summary>
    [JsonPropertyName("earliestRestoreTime")]
    public string? EarliestRestoreTime { get; set; }
}

/// <summary>Compute: The compute properties of the mongo cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterStatusPropertiesCompute
{
    /// <summary>
    /// Tier: The compute tier to assign to the cluster, where each tier maps to a virtual-core and memory size. Example values:
    /// &apos;M30&apos;, &apos;M40&apos;.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>HighAvailability: The high availability properties of the mongo cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterStatusPropertiesHighAvailability
{
    /// <summary>TargetMode: The target high availability mode requested for the cluster.</summary>
    [JsonPropertyName("targetMode")]
    public string? TargetMode { get; set; }
}

/// <summary>The private endpoint connection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterStatusPropertiesPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Replica: The replication properties for the mongo cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterStatusPropertiesReplica
{
    /// <summary>ReplicationState: The replication link state of the replica cluster.</summary>
    [JsonPropertyName("replicationState")]
    public string? ReplicationState { get; set; }

    /// <summary>Role: The replication role of the cluster</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>SourceResourceId: The resource id the source cluster for the replica cluster.</summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }
}

/// <summary>ReplicaParameters: The parameters to create a replica mongo cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterStatusPropertiesReplicaParameters
{
    /// <summary>SourceLocation: The location of the source cluster</summary>
    [JsonPropertyName("sourceLocation")]
    public string? SourceLocation { get; set; }

    /// <summary>SourceResourceId: The id of the replication source cluster.</summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }
}

/// <summary>RestoreParameters: The parameters to create a point-in-time restore mongo cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterStatusPropertiesRestoreParameters
{
    /// <summary>PointInTimeUTC: UTC point in time to restore a mongo cluster</summary>
    [JsonPropertyName("pointInTimeUTC")]
    public string? PointInTimeUTC { get; set; }

    /// <summary>SourceResourceId: Resource ID to locate the source cluster to restore</summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }
}

/// <summary>Sharding: The sharding properties of the mongo cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterStatusPropertiesSharding
{
    /// <summary>ShardCount: Number of shards to provision on the cluster.</summary>
    [JsonPropertyName("shardCount")]
    public int? ShardCount { get; set; }
}

/// <summary>Storage: The storage properties of the mongo cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterStatusPropertiesStorage
{
    /// <summary>SizeGb: The size of the data disk assigned to each server.</summary>
    [JsonPropertyName("sizeGb")]
    public int? SizeGb { get; set; }
}

/// <summary>Properties: The resource-specific properties for this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterStatusProperties
{
    /// <summary>Administrator: The local administrator properties for the mongo cluster.</summary>
    [JsonPropertyName("administrator")]
    public V1api20240701MongoClusterStatusPropertiesAdministrator? Administrator { get; set; }

    /// <summary>Backup: The backup properties of the mongo cluster.</summary>
    [JsonPropertyName("backup")]
    public V1api20240701MongoClusterStatusPropertiesBackup? Backup { get; set; }

    /// <summary>ClusterStatus: The status of the mongo cluster.</summary>
    [JsonPropertyName("clusterStatus")]
    public string? ClusterStatus { get; set; }

    /// <summary>Compute: The compute properties of the mongo cluster.</summary>
    [JsonPropertyName("compute")]
    public V1api20240701MongoClusterStatusPropertiesCompute? Compute { get; set; }

    /// <summary>ConnectionString: The default mongo connection string for the cluster.</summary>
    [JsonPropertyName("connectionString")]
    public string? ConnectionString { get; set; }

    /// <summary>CreateMode: The mode to create a mongo cluster.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>HighAvailability: The high availability properties of the mongo cluster.</summary>
    [JsonPropertyName("highAvailability")]
    public V1api20240701MongoClusterStatusPropertiesHighAvailability? HighAvailability { get; set; }

    /// <summary>InfrastructureVersion: The infrastructure version the cluster is provisioned on.</summary>
    [JsonPropertyName("infrastructureVersion")]
    public string? InfrastructureVersion { get; set; }

    /// <summary>PreviewFeatures: List of private endpoint connections.</summary>
    [JsonPropertyName("previewFeatures")]
    public IList<string>? PreviewFeatures { get; set; }

    /// <summary>PrivateEndpointConnections: List of private endpoint connections.</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20240701MongoClusterStatusPropertiesPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the mongo cluster.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicNetworkAccess: Whether or not public endpoint access is allowed for this mongo cluster.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Replica: The replication properties for the mongo cluster</summary>
    [JsonPropertyName("replica")]
    public V1api20240701MongoClusterStatusPropertiesReplica? Replica { get; set; }

    /// <summary>ReplicaParameters: The parameters to create a replica mongo cluster.</summary>
    [JsonPropertyName("replicaParameters")]
    public V1api20240701MongoClusterStatusPropertiesReplicaParameters? ReplicaParameters { get; set; }

    /// <summary>RestoreParameters: The parameters to create a point-in-time restore mongo cluster.</summary>
    [JsonPropertyName("restoreParameters")]
    public V1api20240701MongoClusterStatusPropertiesRestoreParameters? RestoreParameters { get; set; }

    /// <summary>ServerVersion: The Mongo DB server version. Defaults to the latest available version if not specified.</summary>
    [JsonPropertyName("serverVersion")]
    public string? ServerVersion { get; set; }

    /// <summary>Sharding: The sharding properties of the mongo cluster.</summary>
    [JsonPropertyName("sharding")]
    public V1api20240701MongoClusterStatusPropertiesSharding? Sharding { get; set; }

    /// <summary>Storage: The storage properties of the mongo cluster.</summary>
    [JsonPropertyName("storage")]
    public V1api20240701MongoClusterStatusPropertiesStorage? Storage { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterStatusSystemData
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

/// <summary>Represents a mongo cluster resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240701MongoClusterStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240701MongoClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Properties: The resource-specific properties for this resource.</summary>
    [JsonPropertyName("properties")]
    public V1api20240701MongoClusterStatusProperties? Properties { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240701MongoClusterStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /mongocluster/resource-manager/Microsoft.DocumentDB/MongoCluster/stable/2024-07-01/mongoCluster.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/mongoClusters/{mongoClusterName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240701MongoCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240701MongoClusterSpec?>, IStatus<V1api20240701MongoClusterStatus?>
{
    public const string KubeApiVersion = "v1api20240701";
    public const string KubeKind = "MongoCluster";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "mongoclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20240701";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MongoCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240701MongoClusterSpec? Spec { get; set; }

    /// <summary>Represents a mongo cluster resource.</summary>
    [JsonPropertyName("status")]
    public V1api20240701MongoClusterStatus? Status { get; set; }
}
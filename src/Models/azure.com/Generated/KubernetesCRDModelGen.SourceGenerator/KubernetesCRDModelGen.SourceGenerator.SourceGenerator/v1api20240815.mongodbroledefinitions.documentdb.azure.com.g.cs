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
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2024-08-15/mongorbac.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions/{mongoRoleDefinitionId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240815MongodbRoleDefinitionList : IKubernetesObject<V1ListMeta>, IItems<V1api20240815MongodbRoleDefinition>
{
    public const string KubeApiVersion = "v1api20240815";
    public const string KubeKind = "MongodbRoleDefinitionList";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "mongodbroledefinitions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20240815";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MongodbRoleDefinitionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240815MongodbRoleDefinition objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240815MongodbRoleDefinition> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815MongodbRoleDefinitionSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240815MongodbRoleDefinitionSpecOperatorSpecSecretExpressions
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
public partial class V1api20240815MongodbRoleDefinitionSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240815MongodbRoleDefinitionSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240815MongodbRoleDefinitionSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a documentdb.azure.com/DatabaseAccount resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815MongodbRoleDefinitionSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Resource: An Azure Cosmos DB Mongo DB Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815MongodbRoleDefinitionSpecPrivilegesResource
{
    /// <summary>Collection: The collection name the role is applied.</summary>
    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    /// <summary>Db: The database name the role is applied.</summary>
    [JsonPropertyName("db")]
    public string? Db { get; set; }
}

/// <summary>The set of data plane operations permitted through this Role Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815MongodbRoleDefinitionSpecPrivileges
{
    /// <summary>Actions: An array of actions that are allowed.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>Resource: An Azure Cosmos DB Mongo DB Resource.</summary>
    [JsonPropertyName("resource")]
    public V1api20240815MongodbRoleDefinitionSpecPrivilegesResource? Resource { get; set; }
}

/// <summary>The set of roles permitted through this Role Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815MongodbRoleDefinitionSpecRoles
{
    /// <summary>Db: The database name the role is applied.</summary>
    [JsonPropertyName("db")]
    public string? Db { get; set; }

    /// <summary>Role: The role name.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

/// <summary>Type: Indicates whether the Role Definition was built-in or user created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240815MongodbRoleDefinitionSpecTypeEnum>))]
public enum V1api20240815MongodbRoleDefinitionSpecTypeEnum
{
    [EnumMember(Value = "BuiltInRole"), JsonStringEnumMemberName("BuiltInRole")]
    BuiltInRole,
    [EnumMember(Value = "CustomRole"), JsonStringEnumMemberName("CustomRole")]
    CustomRole
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815MongodbRoleDefinitionSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>DatabaseName: The database name for which access is being granted for this Role Definition.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240815MongodbRoleDefinitionSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a documentdb.azure.com/DatabaseAccount resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240815MongodbRoleDefinitionSpecOwner Owner { get; set; }

    /// <summary>
    /// Privileges: A set of privileges contained by the Role Definition. This will allow application of this Role Definition on
    /// the entire database account or any underlying Database / Collection. Scopes higher than Database are not enforceable as
    /// privilege.
    /// </summary>
    [JsonPropertyName("privileges")]
    public IList<V1api20240815MongodbRoleDefinitionSpecPrivileges>? Privileges { get; set; }

    /// <summary>RoleName: A user-friendly name for the Role Definition. Must be unique for the database account.</summary>
    [JsonPropertyName("roleName")]
    public string? RoleName { get; set; }

    /// <summary>Roles: The set of roles inherited by this Role Definition.</summary>
    [JsonPropertyName("roles")]
    public IList<V1api20240815MongodbRoleDefinitionSpecRoles>? Roles { get; set; }

    /// <summary>Type: Indicates whether the Role Definition was built-in or user created.</summary>
    [JsonPropertyName("type")]
    public V1api20240815MongodbRoleDefinitionSpecTypeEnum? Type { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815MongodbRoleDefinitionStatusConditions
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

/// <summary>Resource: An Azure Cosmos DB Mongo DB Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815MongodbRoleDefinitionStatusPrivilegesResource
{
    /// <summary>Collection: The collection name the role is applied.</summary>
    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    /// <summary>Db: The database name the role is applied.</summary>
    [JsonPropertyName("db")]
    public string? Db { get; set; }
}

/// <summary>The set of data plane operations permitted through this Role Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815MongodbRoleDefinitionStatusPrivileges
{
    /// <summary>Actions: An array of actions that are allowed.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>Resource: An Azure Cosmos DB Mongo DB Resource.</summary>
    [JsonPropertyName("resource")]
    public V1api20240815MongodbRoleDefinitionStatusPrivilegesResource? Resource { get; set; }
}

/// <summary>The set of roles permitted through this Role Definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815MongodbRoleDefinitionStatusRoles
{
    /// <summary>Db: The database name the role is applied.</summary>
    [JsonPropertyName("db")]
    public string? Db { get; set; }

    /// <summary>Role: The role name.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240815MongodbRoleDefinitionStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240815MongodbRoleDefinitionStatusConditions>? Conditions { get; set; }

    /// <summary>DatabaseName: The database name for which access is being granted for this Role Definition.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Id: The unique resource identifier of the database account.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the database account.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Privileges: A set of privileges contained by the Role Definition. This will allow application of this Role Definition on
    /// the entire database account or any underlying Database / Collection. Scopes higher than Database are not enforceable as
    /// privilege.
    /// </summary>
    [JsonPropertyName("privileges")]
    public IList<V1api20240815MongodbRoleDefinitionStatusPrivileges>? Privileges { get; set; }

    /// <summary>RoleName: A user-friendly name for the Role Definition. Must be unique for the database account.</summary>
    [JsonPropertyName("roleName")]
    public string? RoleName { get; set; }

    /// <summary>Roles: The set of roles inherited by this Role Definition.</summary>
    [JsonPropertyName("roles")]
    public IList<V1api20240815MongodbRoleDefinitionStatusRoles>? Roles { get; set; }

    /// <summary>Type: The type of Azure resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2024-08-15/mongorbac.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbRoleDefinitions/{mongoRoleDefinitionId}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240815MongodbRoleDefinition : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240815MongodbRoleDefinitionSpec?>, IStatus<V1api20240815MongodbRoleDefinitionStatus?>
{
    public const string KubeApiVersion = "v1api20240815";
    public const string KubeKind = "MongodbRoleDefinition";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "mongodbroledefinitions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20240815";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MongodbRoleDefinition";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240815MongodbRoleDefinitionSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20240815MongodbRoleDefinitionStatus? Status { get; set; }
}
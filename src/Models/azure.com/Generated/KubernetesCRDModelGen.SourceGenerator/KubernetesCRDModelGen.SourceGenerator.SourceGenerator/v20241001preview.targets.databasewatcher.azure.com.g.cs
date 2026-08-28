#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.databasewatcher.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /databasewatcher/resource-manager/Microsoft.DatabaseWatcher/preview/2024-10-01-preview/Watcher.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/targets/{targetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20241001previewTargetList : IKubernetesObject<V1ListMeta>, IItems<V20241001previewTarget>
{
    public const string KubeApiVersion = "v20241001preview";
    public const string KubeKind = "TargetList";
    public const string KubeGroup = "databasewatcher.azure.com";
    public const string KubePluralName = "targets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "databasewatcher.azure.com/v20241001preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TargetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20241001previewTarget objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20241001previewTarget> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecOperatorSpecConfigMapExpressions
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
public partial class V20241001previewTargetSpecOperatorSpecSecretExpressions
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
public partial class V20241001previewTargetSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20241001previewTargetSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20241001previewTargetSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a databasewatcher.azure.com/Watcher resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// ConnectionServerNameFromConfig: The FQDN host name of the server to use in the connection string when connecting to a
/// target. For example, for an Azure SQL logical server in the Azure commercial cloud, the value might be
/// &apos;sql-logical-server-22092780.database.windows.net&apos;; for an Azure SQL managed instance in the Azure commercial cloud, the
/// value might be &apos;sql-mi-39441134.767d5869f605.database.windows.net&apos;. Port number and instance name must be specified
/// separately.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlDbConnectionServerNameFromConfig
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

/// <summary>SqlDbResourceReference: The Azure resource ID of an Azure SQL DB database target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlDbSqlDbResourceReference
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

/// <summary>TargetAuthenticationType: The type of authentication to use when connecting to a target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241001previewTargetSpecPropertiesSqlDbTargetAuthenticationTypeEnum>))]
public enum V20241001previewTargetSpecPropertiesSqlDbTargetAuthenticationTypeEnum
{
    [EnumMember(Value = "Aad"), JsonStringEnumMemberName("Aad")]
    Aad,
    [EnumMember(Value = "Sql"), JsonStringEnumMemberName("Sql")]
    Sql
}

/// <summary>TargetType: Discriminator property for TargetProperties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241001previewTargetSpecPropertiesSqlDbTargetTypeEnum>))]
public enum V20241001previewTargetSpecPropertiesSqlDbTargetTypeEnum
{
    [EnumMember(Value = "SqlDb"), JsonStringEnumMemberName("SqlDb")]
    SqlDb
}

/// <summary>AkvResourceReference: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlDbTargetVaultAkvResourceReference
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
/// TargetVault: To use SQL authentication when connecting to targets, specify the vault where the login name and password
/// secrets are stored.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlDbTargetVault
{
    /// <summary>AkvResourceReference: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
    [JsonPropertyName("akvResourceReference")]
    public V20241001previewTargetSpecPropertiesSqlDbTargetVaultAkvResourceReference? AkvResourceReference { get; set; }

    /// <summary>AkvTargetPassword: The path to the Key Vault secret storing the password for authentication to a target.</summary>
    [JsonPropertyName("akvTargetPassword")]
    public string? AkvTargetPassword { get; set; }

    /// <summary>
    /// AkvTargetUser: The path to the Key Vault secret storing the login name (aka user name, aka account name) for
    /// authentication to a target.
    /// </summary>
    [JsonPropertyName("akvTargetUser")]
    public string? AkvTargetUser { get; set; }
}

/// <summary>SqlDb: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlDb
{
    /// <summary>
    /// ConnectionServerName: The FQDN host name of the server to use in the connection string when connecting to a target. For
    /// example, for an Azure SQL logical server in the Azure commercial cloud, the value might be
    /// &apos;sql-logical-server-22092780.database.windows.net&apos;; for an Azure SQL managed instance in the Azure commercial cloud, the
    /// value might be &apos;sql-mi-39441134.767d5869f605.database.windows.net&apos;. Port number and instance name must be specified
    /// separately.
    /// </summary>
    [JsonPropertyName("connectionServerName")]
    public string? ConnectionServerName { get; set; }

    /// <summary>
    /// ConnectionServerNameFromConfig: The FQDN host name of the server to use in the connection string when connecting to a
    /// target. For example, for an Azure SQL logical server in the Azure commercial cloud, the value might be
    /// &apos;sql-logical-server-22092780.database.windows.net&apos;; for an Azure SQL managed instance in the Azure commercial cloud, the
    /// value might be &apos;sql-mi-39441134.767d5869f605.database.windows.net&apos;. Port number and instance name must be specified
    /// separately.
    /// </summary>
    [JsonPropertyName("connectionServerNameFromConfig")]
    public V20241001previewTargetSpecPropertiesSqlDbConnectionServerNameFromConfig? ConnectionServerNameFromConfig { get; set; }

    /// <summary>ReadIntent: Set to true to monitor a high availability replica of specified target, if any.</summary>
    [JsonPropertyName("readIntent")]
    public bool? ReadIntent { get; set; }

    /// <summary>SqlDbResourceReference: The Azure resource ID of an Azure SQL DB database target.</summary>
    [JsonPropertyName("sqlDbResourceReference")]
    public required V20241001previewTargetSpecPropertiesSqlDbSqlDbResourceReference SqlDbResourceReference { get; set; }

    /// <summary>TargetAuthenticationType: The type of authentication to use when connecting to a target.</summary>
    [JsonPropertyName("targetAuthenticationType")]
    public required V20241001previewTargetSpecPropertiesSqlDbTargetAuthenticationTypeEnum TargetAuthenticationType { get; set; }

    /// <summary>TargetType: Discriminator property for TargetProperties.</summary>
    [JsonPropertyName("targetType")]
    public required V20241001previewTargetSpecPropertiesSqlDbTargetTypeEnum TargetType { get; set; }

    /// <summary>
    /// TargetVault: To use SQL authentication when connecting to targets, specify the vault where the login name and password
    /// secrets are stored.
    /// </summary>
    [JsonPropertyName("targetVault")]
    public V20241001previewTargetSpecPropertiesSqlDbTargetVault? TargetVault { get; set; }
}

/// <summary>AnchorDatabaseResourceReference: The Azure resource ID of the anchor database used to connect to an elastic pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlEpAnchorDatabaseResourceReference
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
/// ConnectionServerNameFromConfig: The FQDN host name of the server to use in the connection string when connecting to a
/// target. For example, for an Azure SQL logical server in the Azure commercial cloud, the value might be
/// &apos;sql-logical-server-22092780.database.windows.net&apos;; for an Azure SQL managed instance in the Azure commercial cloud, the
/// value might be &apos;sql-mi-39441134.767d5869f605.database.windows.net&apos;. Port number and instance name must be specified
/// separately.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlEpConnectionServerNameFromConfig
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

/// <summary>SqlEpResourceReference: The Azure resource ID of an Azure SQL DB elastic pool target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlEpSqlEpResourceReference
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

/// <summary>TargetAuthenticationType: The type of authentication to use when connecting to a target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241001previewTargetSpecPropertiesSqlEpTargetAuthenticationTypeEnum>))]
public enum V20241001previewTargetSpecPropertiesSqlEpTargetAuthenticationTypeEnum
{
    [EnumMember(Value = "Aad"), JsonStringEnumMemberName("Aad")]
    Aad,
    [EnumMember(Value = "Sql"), JsonStringEnumMemberName("Sql")]
    Sql
}

/// <summary>TargetType: Discriminator property for TargetProperties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241001previewTargetSpecPropertiesSqlEpTargetTypeEnum>))]
public enum V20241001previewTargetSpecPropertiesSqlEpTargetTypeEnum
{
    [EnumMember(Value = "SqlEp"), JsonStringEnumMemberName("SqlEp")]
    SqlEp
}

/// <summary>AkvResourceReference: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlEpTargetVaultAkvResourceReference
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
/// TargetVault: To use SQL authentication when connecting to targets, specify the vault where the login name and password
/// secrets are stored.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlEpTargetVault
{
    /// <summary>AkvResourceReference: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
    [JsonPropertyName("akvResourceReference")]
    public V20241001previewTargetSpecPropertiesSqlEpTargetVaultAkvResourceReference? AkvResourceReference { get; set; }

    /// <summary>AkvTargetPassword: The path to the Key Vault secret storing the password for authentication to a target.</summary>
    [JsonPropertyName("akvTargetPassword")]
    public string? AkvTargetPassword { get; set; }

    /// <summary>
    /// AkvTargetUser: The path to the Key Vault secret storing the login name (aka user name, aka account name) for
    /// authentication to a target.
    /// </summary>
    [JsonPropertyName("akvTargetUser")]
    public string? AkvTargetUser { get; set; }
}

/// <summary>SqlEp: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlEp
{
    /// <summary>AnchorDatabaseResourceReference: The Azure resource ID of the anchor database used to connect to an elastic pool.</summary>
    [JsonPropertyName("anchorDatabaseResourceReference")]
    public required V20241001previewTargetSpecPropertiesSqlEpAnchorDatabaseResourceReference AnchorDatabaseResourceReference { get; set; }

    /// <summary>
    /// ConnectionServerName: The FQDN host name of the server to use in the connection string when connecting to a target. For
    /// example, for an Azure SQL logical server in the Azure commercial cloud, the value might be
    /// &apos;sql-logical-server-22092780.database.windows.net&apos;; for an Azure SQL managed instance in the Azure commercial cloud, the
    /// value might be &apos;sql-mi-39441134.767d5869f605.database.windows.net&apos;. Port number and instance name must be specified
    /// separately.
    /// </summary>
    [JsonPropertyName("connectionServerName")]
    public string? ConnectionServerName { get; set; }

    /// <summary>
    /// ConnectionServerNameFromConfig: The FQDN host name of the server to use in the connection string when connecting to a
    /// target. For example, for an Azure SQL logical server in the Azure commercial cloud, the value might be
    /// &apos;sql-logical-server-22092780.database.windows.net&apos;; for an Azure SQL managed instance in the Azure commercial cloud, the
    /// value might be &apos;sql-mi-39441134.767d5869f605.database.windows.net&apos;. Port number and instance name must be specified
    /// separately.
    /// </summary>
    [JsonPropertyName("connectionServerNameFromConfig")]
    public V20241001previewTargetSpecPropertiesSqlEpConnectionServerNameFromConfig? ConnectionServerNameFromConfig { get; set; }

    /// <summary>ReadIntent: Set to true to monitor a high availability replica of specified target, if any.</summary>
    [JsonPropertyName("readIntent")]
    public bool? ReadIntent { get; set; }

    /// <summary>SqlEpResourceReference: The Azure resource ID of an Azure SQL DB elastic pool target.</summary>
    [JsonPropertyName("sqlEpResourceReference")]
    public required V20241001previewTargetSpecPropertiesSqlEpSqlEpResourceReference SqlEpResourceReference { get; set; }

    /// <summary>TargetAuthenticationType: The type of authentication to use when connecting to a target.</summary>
    [JsonPropertyName("targetAuthenticationType")]
    public required V20241001previewTargetSpecPropertiesSqlEpTargetAuthenticationTypeEnum TargetAuthenticationType { get; set; }

    /// <summary>TargetType: Discriminator property for TargetProperties.</summary>
    [JsonPropertyName("targetType")]
    public required V20241001previewTargetSpecPropertiesSqlEpTargetTypeEnum TargetType { get; set; }

    /// <summary>
    /// TargetVault: To use SQL authentication when connecting to targets, specify the vault where the login name and password
    /// secrets are stored.
    /// </summary>
    [JsonPropertyName("targetVault")]
    public V20241001previewTargetSpecPropertiesSqlEpTargetVault? TargetVault { get; set; }
}

/// <summary>
/// ConnectionServerNameFromConfig: The FQDN host name of the server to use in the connection string when connecting to a
/// target. For example, for an Azure SQL logical server in the Azure commercial cloud, the value might be
/// &apos;sql-logical-server-22092780.database.windows.net&apos;; for an Azure SQL managed instance in the Azure commercial cloud, the
/// value might be &apos;sql-mi-39441134.767d5869f605.database.windows.net&apos;. Port number and instance name must be specified
/// separately.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlMiConnectionServerNameFromConfig
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

/// <summary>SqlMiResourceReference: The Azure resource ID of an Azure SQL Managed Instance target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlMiSqlMiResourceReference
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

/// <summary>TargetAuthenticationType: The type of authentication to use when connecting to a target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241001previewTargetSpecPropertiesSqlMiTargetAuthenticationTypeEnum>))]
public enum V20241001previewTargetSpecPropertiesSqlMiTargetAuthenticationTypeEnum
{
    [EnumMember(Value = "Aad"), JsonStringEnumMemberName("Aad")]
    Aad,
    [EnumMember(Value = "Sql"), JsonStringEnumMemberName("Sql")]
    Sql
}

/// <summary>TargetType: Discriminator property for TargetProperties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241001previewTargetSpecPropertiesSqlMiTargetTypeEnum>))]
public enum V20241001previewTargetSpecPropertiesSqlMiTargetTypeEnum
{
    [EnumMember(Value = "SqlMi"), JsonStringEnumMemberName("SqlMi")]
    SqlMi
}

/// <summary>AkvResourceReference: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlMiTargetVaultAkvResourceReference
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
/// TargetVault: To use SQL authentication when connecting to targets, specify the vault where the login name and password
/// secrets are stored.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlMiTargetVault
{
    /// <summary>AkvResourceReference: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
    [JsonPropertyName("akvResourceReference")]
    public V20241001previewTargetSpecPropertiesSqlMiTargetVaultAkvResourceReference? AkvResourceReference { get; set; }

    /// <summary>AkvTargetPassword: The path to the Key Vault secret storing the password for authentication to a target.</summary>
    [JsonPropertyName("akvTargetPassword")]
    public string? AkvTargetPassword { get; set; }

    /// <summary>
    /// AkvTargetUser: The path to the Key Vault secret storing the login name (aka user name, aka account name) for
    /// authentication to a target.
    /// </summary>
    [JsonPropertyName("akvTargetUser")]
    public string? AkvTargetUser { get; set; }
}

/// <summary>SqlMi: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlMi
{
    /// <summary>
    /// ConnectionServerName: The FQDN host name of the server to use in the connection string when connecting to a target. For
    /// example, for an Azure SQL logical server in the Azure commercial cloud, the value might be
    /// &apos;sql-logical-server-22092780.database.windows.net&apos;; for an Azure SQL managed instance in the Azure commercial cloud, the
    /// value might be &apos;sql-mi-39441134.767d5869f605.database.windows.net&apos;. Port number and instance name must be specified
    /// separately.
    /// </summary>
    [JsonPropertyName("connectionServerName")]
    public string? ConnectionServerName { get; set; }

    /// <summary>
    /// ConnectionServerNameFromConfig: The FQDN host name of the server to use in the connection string when connecting to a
    /// target. For example, for an Azure SQL logical server in the Azure commercial cloud, the value might be
    /// &apos;sql-logical-server-22092780.database.windows.net&apos;; for an Azure SQL managed instance in the Azure commercial cloud, the
    /// value might be &apos;sql-mi-39441134.767d5869f605.database.windows.net&apos;. Port number and instance name must be specified
    /// separately.
    /// </summary>
    [JsonPropertyName("connectionServerNameFromConfig")]
    public V20241001previewTargetSpecPropertiesSqlMiConnectionServerNameFromConfig? ConnectionServerNameFromConfig { get; set; }

    /// <summary>
    /// ConnectionTcpPort: The TCP port number to optionally use in the connection string when connecting to an Azure SQL
    /// Managed Instance target.
    /// </summary>
    [JsonPropertyName("connectionTcpPort")]
    public int? ConnectionTcpPort { get; set; }

    /// <summary>ReadIntent: Set to true to monitor a high availability replica of specified target, if any.</summary>
    [JsonPropertyName("readIntent")]
    public bool? ReadIntent { get; set; }

    /// <summary>SqlMiResourceReference: The Azure resource ID of an Azure SQL Managed Instance target.</summary>
    [JsonPropertyName("sqlMiResourceReference")]
    public required V20241001previewTargetSpecPropertiesSqlMiSqlMiResourceReference SqlMiResourceReference { get; set; }

    /// <summary>TargetAuthenticationType: The type of authentication to use when connecting to a target.</summary>
    [JsonPropertyName("targetAuthenticationType")]
    public required V20241001previewTargetSpecPropertiesSqlMiTargetAuthenticationTypeEnum TargetAuthenticationType { get; set; }

    /// <summary>TargetType: Discriminator property for TargetProperties.</summary>
    [JsonPropertyName("targetType")]
    public required V20241001previewTargetSpecPropertiesSqlMiTargetTypeEnum TargetType { get; set; }

    /// <summary>
    /// TargetVault: To use SQL authentication when connecting to targets, specify the vault where the login name and password
    /// secrets are stored.
    /// </summary>
    [JsonPropertyName("targetVault")]
    public V20241001previewTargetSpecPropertiesSqlMiTargetVault? TargetVault { get; set; }
}

/// <summary>
/// ConnectionServerNameFromConfig: The FQDN host name of the server to use in the connection string when connecting to a
/// target. For example, for an Azure SQL logical server in the Azure commercial cloud, the value might be
/// &apos;sql-logical-server-22092780.database.windows.net&apos;; for an Azure SQL managed instance in the Azure commercial cloud, the
/// value might be &apos;sql-mi-39441134.767d5869f605.database.windows.net&apos;. Port number and instance name must be specified
/// separately.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlVmConnectionServerNameFromConfig
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

/// <summary>SqlVmResourceReference: The Azure resource ID of an Azure SQL VM target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlVmSqlVmResourceReference
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

/// <summary>TargetAuthenticationType: The type of authentication to use when connecting to a target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241001previewTargetSpecPropertiesSqlVmTargetAuthenticationTypeEnum>))]
public enum V20241001previewTargetSpecPropertiesSqlVmTargetAuthenticationTypeEnum
{
    [EnumMember(Value = "Aad"), JsonStringEnumMemberName("Aad")]
    Aad,
    [EnumMember(Value = "Sql"), JsonStringEnumMemberName("Sql")]
    Sql
}

/// <summary>TargetType: Discriminator property for TargetProperties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20241001previewTargetSpecPropertiesSqlVmTargetTypeEnum>))]
public enum V20241001previewTargetSpecPropertiesSqlVmTargetTypeEnum
{
    [EnumMember(Value = "SqlVm"), JsonStringEnumMemberName("SqlVm")]
    SqlVm
}

/// <summary>AkvResourceReference: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlVmTargetVaultAkvResourceReference
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
/// TargetVault: To use SQL authentication when connecting to targets, specify the vault where the login name and password
/// secrets are stored.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlVmTargetVault
{
    /// <summary>AkvResourceReference: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
    [JsonPropertyName("akvResourceReference")]
    public V20241001previewTargetSpecPropertiesSqlVmTargetVaultAkvResourceReference? AkvResourceReference { get; set; }

    /// <summary>AkvTargetPassword: The path to the Key Vault secret storing the password for authentication to a target.</summary>
    [JsonPropertyName("akvTargetPassword")]
    public string? AkvTargetPassword { get; set; }

    /// <summary>
    /// AkvTargetUser: The path to the Key Vault secret storing the login name (aka user name, aka account name) for
    /// authentication to a target.
    /// </summary>
    [JsonPropertyName("akvTargetUser")]
    public string? AkvTargetUser { get; set; }
}

/// <summary>SqlVm: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecPropertiesSqlVm
{
    /// <summary>
    /// ConnectionServerName: The FQDN host name of the server to use in the connection string when connecting to a target. For
    /// example, for an Azure SQL logical server in the Azure commercial cloud, the value might be
    /// &apos;sql-logical-server-22092780.database.windows.net&apos;; for an Azure SQL managed instance in the Azure commercial cloud, the
    /// value might be &apos;sql-mi-39441134.767d5869f605.database.windows.net&apos;. Port number and instance name must be specified
    /// separately.
    /// </summary>
    [JsonPropertyName("connectionServerName")]
    public string? ConnectionServerName { get; set; }

    /// <summary>
    /// ConnectionServerNameFromConfig: The FQDN host name of the server to use in the connection string when connecting to a
    /// target. For example, for an Azure SQL logical server in the Azure commercial cloud, the value might be
    /// &apos;sql-logical-server-22092780.database.windows.net&apos;; for an Azure SQL managed instance in the Azure commercial cloud, the
    /// value might be &apos;sql-mi-39441134.767d5869f605.database.windows.net&apos;. Port number and instance name must be specified
    /// separately.
    /// </summary>
    [JsonPropertyName("connectionServerNameFromConfig")]
    public V20241001previewTargetSpecPropertiesSqlVmConnectionServerNameFromConfig? ConnectionServerNameFromConfig { get; set; }

    /// <summary>
    /// ConnectionTcpPort: The TCP port number to optionally use in the connection string when connecting to an Azure SQL VM
    /// target.
    /// </summary>
    [JsonPropertyName("connectionTcpPort")]
    public int? ConnectionTcpPort { get; set; }

    /// <summary>
    /// SqlNamedInstanceName: The SQL instance name to optionally use in the connection string when connecting to an Azure SQL
    /// VM target.
    /// </summary>
    [JsonPropertyName("sqlNamedInstanceName")]
    public string? SqlNamedInstanceName { get; set; }

    /// <summary>SqlVmResourceReference: The Azure resource ID of an Azure SQL VM target.</summary>
    [JsonPropertyName("sqlVmResourceReference")]
    public required V20241001previewTargetSpecPropertiesSqlVmSqlVmResourceReference SqlVmResourceReference { get; set; }

    /// <summary>TargetAuthenticationType: The type of authentication to use when connecting to a target.</summary>
    [JsonPropertyName("targetAuthenticationType")]
    public required V20241001previewTargetSpecPropertiesSqlVmTargetAuthenticationTypeEnum TargetAuthenticationType { get; set; }

    /// <summary>TargetType: Discriminator property for TargetProperties.</summary>
    [JsonPropertyName("targetType")]
    public required V20241001previewTargetSpecPropertiesSqlVmTargetTypeEnum TargetType { get; set; }

    /// <summary>
    /// TargetVault: To use SQL authentication when connecting to targets, specify the vault where the login name and password
    /// secrets are stored.
    /// </summary>
    [JsonPropertyName("targetVault")]
    public V20241001previewTargetSpecPropertiesSqlVmTargetVault? TargetVault { get; set; }
}

/// <summary>Properties: The resource-specific properties for this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpecProperties
{
    /// <summary>SqlDb: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("sqlDb")]
    public V20241001previewTargetSpecPropertiesSqlDb? SqlDb { get; set; }

    /// <summary>SqlEp: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("sqlEp")]
    public V20241001previewTargetSpecPropertiesSqlEp? SqlEp { get; set; }

    /// <summary>SqlMi: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("sqlMi")]
    public V20241001previewTargetSpecPropertiesSqlMi? SqlMi { get; set; }

    /// <summary>SqlVm: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("sqlVm")]
    public V20241001previewTargetSpecPropertiesSqlVm? SqlVm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetSpec
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
    public V20241001previewTargetSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a databasewatcher.azure.com/Watcher resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20241001previewTargetSpecOwner Owner { get; set; }

    /// <summary>Properties: The resource-specific properties for this resource.</summary>
    [JsonPropertyName("properties")]
    public V20241001previewTargetSpecProperties? Properties { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetStatusConditions
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
/// TargetVault: To use SQL authentication when connecting to targets, specify the vault where the login name and password
/// secrets are stored.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetStatusPropertiesSqlDbTargetVault
{
    /// <summary>AkvResourceId: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
    [JsonPropertyName("akvResourceId")]
    public string? AkvResourceId { get; set; }

    /// <summary>AkvTargetPassword: The path to the Key Vault secret storing the password for authentication to a target.</summary>
    [JsonPropertyName("akvTargetPassword")]
    public string? AkvTargetPassword { get; set; }

    /// <summary>
    /// AkvTargetUser: The path to the Key Vault secret storing the login name (aka user name, aka account name) for
    /// authentication to a target.
    /// </summary>
    [JsonPropertyName("akvTargetUser")]
    public string? AkvTargetUser { get; set; }
}

/// <summary>SqlDb: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetStatusPropertiesSqlDb
{
    /// <summary>
    /// ConnectionServerName: The FQDN host name of the server to use in the connection string when connecting to a target. For
    /// example, for an Azure SQL logical server in the Azure commercial cloud, the value might be
    /// &apos;sql-logical-server-22092780.database.windows.net&apos;; for an Azure SQL managed instance in the Azure commercial cloud, the
    /// value might be &apos;sql-mi-39441134.767d5869f605.database.windows.net&apos;. Port number and instance name must be specified
    /// separately.
    /// </summary>
    [JsonPropertyName("connectionServerName")]
    public string? ConnectionServerName { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ReadIntent: Set to true to monitor a high availability replica of specified target, if any.</summary>
    [JsonPropertyName("readIntent")]
    public bool? ReadIntent { get; set; }

    /// <summary>SqlDbResourceId: The Azure resource ID of an Azure SQL DB database target.</summary>
    [JsonPropertyName("sqlDbResourceId")]
    public string? SqlDbResourceId { get; set; }

    /// <summary>TargetAuthenticationType: The type of authentication to use when connecting to a target.</summary>
    [JsonPropertyName("targetAuthenticationType")]
    public string? TargetAuthenticationType { get; set; }

    /// <summary>TargetType: Discriminator property for TargetProperties.</summary>
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>
    /// TargetVault: To use SQL authentication when connecting to targets, specify the vault where the login name and password
    /// secrets are stored.
    /// </summary>
    [JsonPropertyName("targetVault")]
    public V20241001previewTargetStatusPropertiesSqlDbTargetVault? TargetVault { get; set; }
}

/// <summary>
/// TargetVault: To use SQL authentication when connecting to targets, specify the vault where the login name and password
/// secrets are stored.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetStatusPropertiesSqlEpTargetVault
{
    /// <summary>AkvResourceId: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
    [JsonPropertyName("akvResourceId")]
    public string? AkvResourceId { get; set; }

    /// <summary>AkvTargetPassword: The path to the Key Vault secret storing the password for authentication to a target.</summary>
    [JsonPropertyName("akvTargetPassword")]
    public string? AkvTargetPassword { get; set; }

    /// <summary>
    /// AkvTargetUser: The path to the Key Vault secret storing the login name (aka user name, aka account name) for
    /// authentication to a target.
    /// </summary>
    [JsonPropertyName("akvTargetUser")]
    public string? AkvTargetUser { get; set; }
}

/// <summary>SqlEp: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetStatusPropertiesSqlEp
{
    /// <summary>AnchorDatabaseResourceId: The Azure resource ID of the anchor database used to connect to an elastic pool.</summary>
    [JsonPropertyName("anchorDatabaseResourceId")]
    public string? AnchorDatabaseResourceId { get; set; }

    /// <summary>
    /// ConnectionServerName: The FQDN host name of the server to use in the connection string when connecting to a target. For
    /// example, for an Azure SQL logical server in the Azure commercial cloud, the value might be
    /// &apos;sql-logical-server-22092780.database.windows.net&apos;; for an Azure SQL managed instance in the Azure commercial cloud, the
    /// value might be &apos;sql-mi-39441134.767d5869f605.database.windows.net&apos;. Port number and instance name must be specified
    /// separately.
    /// </summary>
    [JsonPropertyName("connectionServerName")]
    public string? ConnectionServerName { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ReadIntent: Set to true to monitor a high availability replica of specified target, if any.</summary>
    [JsonPropertyName("readIntent")]
    public bool? ReadIntent { get; set; }

    /// <summary>SqlEpResourceId: The Azure resource ID of an Azure SQL DB elastic pool target.</summary>
    [JsonPropertyName("sqlEpResourceId")]
    public string? SqlEpResourceId { get; set; }

    /// <summary>TargetAuthenticationType: The type of authentication to use when connecting to a target.</summary>
    [JsonPropertyName("targetAuthenticationType")]
    public string? TargetAuthenticationType { get; set; }

    /// <summary>TargetType: Discriminator property for TargetProperties.</summary>
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>
    /// TargetVault: To use SQL authentication when connecting to targets, specify the vault where the login name and password
    /// secrets are stored.
    /// </summary>
    [JsonPropertyName("targetVault")]
    public V20241001previewTargetStatusPropertiesSqlEpTargetVault? TargetVault { get; set; }
}

/// <summary>
/// TargetVault: To use SQL authentication when connecting to targets, specify the vault where the login name and password
/// secrets are stored.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetStatusPropertiesSqlMiTargetVault
{
    /// <summary>AkvResourceId: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
    [JsonPropertyName("akvResourceId")]
    public string? AkvResourceId { get; set; }

    /// <summary>AkvTargetPassword: The path to the Key Vault secret storing the password for authentication to a target.</summary>
    [JsonPropertyName("akvTargetPassword")]
    public string? AkvTargetPassword { get; set; }

    /// <summary>
    /// AkvTargetUser: The path to the Key Vault secret storing the login name (aka user name, aka account name) for
    /// authentication to a target.
    /// </summary>
    [JsonPropertyName("akvTargetUser")]
    public string? AkvTargetUser { get; set; }
}

/// <summary>SqlMi: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetStatusPropertiesSqlMi
{
    /// <summary>
    /// ConnectionServerName: The FQDN host name of the server to use in the connection string when connecting to a target. For
    /// example, for an Azure SQL logical server in the Azure commercial cloud, the value might be
    /// &apos;sql-logical-server-22092780.database.windows.net&apos;; for an Azure SQL managed instance in the Azure commercial cloud, the
    /// value might be &apos;sql-mi-39441134.767d5869f605.database.windows.net&apos;. Port number and instance name must be specified
    /// separately.
    /// </summary>
    [JsonPropertyName("connectionServerName")]
    public string? ConnectionServerName { get; set; }

    /// <summary>
    /// ConnectionTcpPort: The TCP port number to optionally use in the connection string when connecting to an Azure SQL
    /// Managed Instance target.
    /// </summary>
    [JsonPropertyName("connectionTcpPort")]
    public int? ConnectionTcpPort { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ReadIntent: Set to true to monitor a high availability replica of specified target, if any.</summary>
    [JsonPropertyName("readIntent")]
    public bool? ReadIntent { get; set; }

    /// <summary>SqlMiResourceId: The Azure resource ID of an Azure SQL Managed Instance target.</summary>
    [JsonPropertyName("sqlMiResourceId")]
    public string? SqlMiResourceId { get; set; }

    /// <summary>TargetAuthenticationType: The type of authentication to use when connecting to a target.</summary>
    [JsonPropertyName("targetAuthenticationType")]
    public string? TargetAuthenticationType { get; set; }

    /// <summary>TargetType: Discriminator property for TargetProperties.</summary>
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>
    /// TargetVault: To use SQL authentication when connecting to targets, specify the vault where the login name and password
    /// secrets are stored.
    /// </summary>
    [JsonPropertyName("targetVault")]
    public V20241001previewTargetStatusPropertiesSqlMiTargetVault? TargetVault { get; set; }
}

/// <summary>
/// TargetVault: To use SQL authentication when connecting to targets, specify the vault where the login name and password
/// secrets are stored.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetStatusPropertiesSqlVmTargetVault
{
    /// <summary>AkvResourceId: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
    [JsonPropertyName("akvResourceId")]
    public string? AkvResourceId { get; set; }

    /// <summary>AkvTargetPassword: The path to the Key Vault secret storing the password for authentication to a target.</summary>
    [JsonPropertyName("akvTargetPassword")]
    public string? AkvTargetPassword { get; set; }

    /// <summary>
    /// AkvTargetUser: The path to the Key Vault secret storing the login name (aka user name, aka account name) for
    /// authentication to a target.
    /// </summary>
    [JsonPropertyName("akvTargetUser")]
    public string? AkvTargetUser { get; set; }
}

/// <summary>SqlVm: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetStatusPropertiesSqlVm
{
    /// <summary>
    /// ConnectionServerName: The FQDN host name of the server to use in the connection string when connecting to a target. For
    /// example, for an Azure SQL logical server in the Azure commercial cloud, the value might be
    /// &apos;sql-logical-server-22092780.database.windows.net&apos;; for an Azure SQL managed instance in the Azure commercial cloud, the
    /// value might be &apos;sql-mi-39441134.767d5869f605.database.windows.net&apos;. Port number and instance name must be specified
    /// separately.
    /// </summary>
    [JsonPropertyName("connectionServerName")]
    public string? ConnectionServerName { get; set; }

    /// <summary>
    /// ConnectionTcpPort: The TCP port number to optionally use in the connection string when connecting to an Azure SQL VM
    /// target.
    /// </summary>
    [JsonPropertyName("connectionTcpPort")]
    public int? ConnectionTcpPort { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// SqlNamedInstanceName: The SQL instance name to optionally use in the connection string when connecting to an Azure SQL
    /// VM target.
    /// </summary>
    [JsonPropertyName("sqlNamedInstanceName")]
    public string? SqlNamedInstanceName { get; set; }

    /// <summary>SqlVmResourceId: The Azure resource ID of an Azure SQL VM target.</summary>
    [JsonPropertyName("sqlVmResourceId")]
    public string? SqlVmResourceId { get; set; }

    /// <summary>TargetAuthenticationType: The type of authentication to use when connecting to a target.</summary>
    [JsonPropertyName("targetAuthenticationType")]
    public string? TargetAuthenticationType { get; set; }

    /// <summary>TargetType: Discriminator property for TargetProperties.</summary>
    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>
    /// TargetVault: To use SQL authentication when connecting to targets, specify the vault where the login name and password
    /// secrets are stored.
    /// </summary>
    [JsonPropertyName("targetVault")]
    public V20241001previewTargetStatusPropertiesSqlVmTargetVault? TargetVault { get; set; }
}

/// <summary>Properties: The resource-specific properties for this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetStatusProperties
{
    /// <summary>SqlDb: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("sqlDb")]
    public V20241001previewTargetStatusPropertiesSqlDb? SqlDb { get; set; }

    /// <summary>SqlEp: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("sqlEp")]
    public V20241001previewTargetStatusPropertiesSqlEp? SqlEp { get; set; }

    /// <summary>SqlMi: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("sqlMi")]
    public V20241001previewTargetStatusPropertiesSqlMi? SqlMi { get; set; }

    /// <summary>SqlVm: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("sqlVm")]
    public V20241001previewTargetStatusPropertiesSqlVm? SqlVm { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetStatusSystemData
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewTargetStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20241001previewTargetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Properties: The resource-specific properties for this resource.</summary>
    [JsonPropertyName("properties")]
    public V20241001previewTargetStatusProperties? Properties { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20241001previewTargetStatusSystemData? SystemData { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /databasewatcher/resource-manager/Microsoft.DatabaseWatcher/preview/2024-10-01-preview/Watcher.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/targets/{targetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20241001previewTarget : IKubernetesObject<V1ObjectMeta>, ISpec<V20241001previewTargetSpec?>, IStatus<V20241001previewTargetStatus?>
{
    public const string KubeApiVersion = "v20241001preview";
    public const string KubeKind = "Target";
    public const string KubeGroup = "databasewatcher.azure.com";
    public const string KubePluralName = "targets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "databasewatcher.azure.com/v20241001preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Target";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20241001previewTargetSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20241001previewTargetStatus? Status { get; set; }
}
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
/// Storage version of v20241001preview.Target
/// Generator information:
/// - Generated from: /databasewatcher/resource-manager/Microsoft.DatabaseWatcher/preview/2024-10-01-preview/Watcher.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/targets/{targetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20241001previewstorageTargetList : IKubernetesObject<V1ListMeta>, IItems<V20241001previewstorageTarget>
{
    public const string KubeApiVersion = "v20241001previewstorage";
    public const string KubeKind = "TargetList";
    public const string KubeGroup = "databasewatcher.azure.com";
    public const string KubePluralName = "targets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "databasewatcher.azure.com/v20241001previewstorage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TargetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20241001previewstorageTarget objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20241001previewstorageTarget> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecOperatorSpecConfigMapExpressions
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
public partial class V20241001previewstorageTargetSpecOperatorSpecSecretExpressions
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
/// Storage version of v20241001preview.TargetOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20241001previewstorageTargetSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20241001previewstorageTargetSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a databasewatcher.azure.com/Watcher resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecPropertiesSqlDbConnectionServerNameFromConfig
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
public partial class V20241001previewstorageTargetSpecPropertiesSqlDbSqlDbResourceReference
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

/// <summary>AkvResourceReference: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecPropertiesSqlDbTargetVaultAkvResourceReference
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
/// Storage version of v20241001preview.VaultSecret
/// The vault specific details required if using SQL authentication to connect to a target.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecPropertiesSqlDbTargetVault
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AkvResourceReference: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
    [JsonPropertyName("akvResourceReference")]
    public V20241001previewstorageTargetSpecPropertiesSqlDbTargetVaultAkvResourceReference? AkvResourceReference { get; set; }

    [JsonPropertyName("akvTargetPassword")]
    public string? AkvTargetPassword { get; set; }

    [JsonPropertyName("akvTargetUser")]
    public string? AkvTargetUser { get; set; }
}

/// <summary>Storage version of v20241001preview.SqlDbSingleDatabaseTargetProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecPropertiesSqlDb
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("connectionServerName")]
    public string? ConnectionServerName { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("connectionServerNameFromConfig")]
    public V20241001previewstorageTargetSpecPropertiesSqlDbConnectionServerNameFromConfig? ConnectionServerNameFromConfig { get; set; }

    [JsonPropertyName("readIntent")]
    public bool? ReadIntent { get; set; }

    /// <summary>SqlDbResourceReference: The Azure resource ID of an Azure SQL DB database target.</summary>
    [JsonPropertyName("sqlDbResourceReference")]
    public required V20241001previewstorageTargetSpecPropertiesSqlDbSqlDbResourceReference SqlDbResourceReference { get; set; }

    [JsonPropertyName("targetAuthenticationType")]
    public string? TargetAuthenticationType { get; set; }

    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>
    /// Storage version of v20241001preview.VaultSecret
    /// The vault specific details required if using SQL authentication to connect to a target.
    /// </summary>
    [JsonPropertyName("targetVault")]
    public V20241001previewstorageTargetSpecPropertiesSqlDbTargetVault? TargetVault { get; set; }
}

/// <summary>AnchorDatabaseResourceReference: The Azure resource ID of the anchor database used to connect to an elastic pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecPropertiesSqlEpAnchorDatabaseResourceReference
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
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecPropertiesSqlEpConnectionServerNameFromConfig
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
public partial class V20241001previewstorageTargetSpecPropertiesSqlEpSqlEpResourceReference
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

/// <summary>AkvResourceReference: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecPropertiesSqlEpTargetVaultAkvResourceReference
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
/// Storage version of v20241001preview.VaultSecret
/// The vault specific details required if using SQL authentication to connect to a target.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecPropertiesSqlEpTargetVault
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AkvResourceReference: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
    [JsonPropertyName("akvResourceReference")]
    public V20241001previewstorageTargetSpecPropertiesSqlEpTargetVaultAkvResourceReference? AkvResourceReference { get; set; }

    [JsonPropertyName("akvTargetPassword")]
    public string? AkvTargetPassword { get; set; }

    [JsonPropertyName("akvTargetUser")]
    public string? AkvTargetUser { get; set; }
}

/// <summary>Storage version of v20241001preview.SqlDbElasticPoolTargetProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecPropertiesSqlEp
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AnchorDatabaseResourceReference: The Azure resource ID of the anchor database used to connect to an elastic pool.</summary>
    [JsonPropertyName("anchorDatabaseResourceReference")]
    public required V20241001previewstorageTargetSpecPropertiesSqlEpAnchorDatabaseResourceReference AnchorDatabaseResourceReference { get; set; }

    [JsonPropertyName("connectionServerName")]
    public string? ConnectionServerName { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("connectionServerNameFromConfig")]
    public V20241001previewstorageTargetSpecPropertiesSqlEpConnectionServerNameFromConfig? ConnectionServerNameFromConfig { get; set; }

    [JsonPropertyName("readIntent")]
    public bool? ReadIntent { get; set; }

    /// <summary>SqlEpResourceReference: The Azure resource ID of an Azure SQL DB elastic pool target.</summary>
    [JsonPropertyName("sqlEpResourceReference")]
    public required V20241001previewstorageTargetSpecPropertiesSqlEpSqlEpResourceReference SqlEpResourceReference { get; set; }

    [JsonPropertyName("targetAuthenticationType")]
    public string? TargetAuthenticationType { get; set; }

    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>
    /// Storage version of v20241001preview.VaultSecret
    /// The vault specific details required if using SQL authentication to connect to a target.
    /// </summary>
    [JsonPropertyName("targetVault")]
    public V20241001previewstorageTargetSpecPropertiesSqlEpTargetVault? TargetVault { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecPropertiesSqlMiConnectionServerNameFromConfig
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
public partial class V20241001previewstorageTargetSpecPropertiesSqlMiSqlMiResourceReference
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

/// <summary>AkvResourceReference: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecPropertiesSqlMiTargetVaultAkvResourceReference
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
/// Storage version of v20241001preview.VaultSecret
/// The vault specific details required if using SQL authentication to connect to a target.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecPropertiesSqlMiTargetVault
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AkvResourceReference: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
    [JsonPropertyName("akvResourceReference")]
    public V20241001previewstorageTargetSpecPropertiesSqlMiTargetVaultAkvResourceReference? AkvResourceReference { get; set; }

    [JsonPropertyName("akvTargetPassword")]
    public string? AkvTargetPassword { get; set; }

    [JsonPropertyName("akvTargetUser")]
    public string? AkvTargetUser { get; set; }
}

/// <summary>Storage version of v20241001preview.SqlMiTargetProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecPropertiesSqlMi
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("connectionServerName")]
    public string? ConnectionServerName { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("connectionServerNameFromConfig")]
    public V20241001previewstorageTargetSpecPropertiesSqlMiConnectionServerNameFromConfig? ConnectionServerNameFromConfig { get; set; }

    [JsonPropertyName("connectionTcpPort")]
    public int? ConnectionTcpPort { get; set; }

    [JsonPropertyName("readIntent")]
    public bool? ReadIntent { get; set; }

    /// <summary>SqlMiResourceReference: The Azure resource ID of an Azure SQL Managed Instance target.</summary>
    [JsonPropertyName("sqlMiResourceReference")]
    public required V20241001previewstorageTargetSpecPropertiesSqlMiSqlMiResourceReference SqlMiResourceReference { get; set; }

    [JsonPropertyName("targetAuthenticationType")]
    public string? TargetAuthenticationType { get; set; }

    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>
    /// Storage version of v20241001preview.VaultSecret
    /// The vault specific details required if using SQL authentication to connect to a target.
    /// </summary>
    [JsonPropertyName("targetVault")]
    public V20241001previewstorageTargetSpecPropertiesSqlMiTargetVault? TargetVault { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecPropertiesSqlVmConnectionServerNameFromConfig
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
public partial class V20241001previewstorageTargetSpecPropertiesSqlVmSqlVmResourceReference
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

/// <summary>AkvResourceReference: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecPropertiesSqlVmTargetVaultAkvResourceReference
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
/// Storage version of v20241001preview.VaultSecret
/// The vault specific details required if using SQL authentication to connect to a target.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecPropertiesSqlVmTargetVault
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AkvResourceReference: The Azure resource ID of the Key Vault instance storing database authentication secrets.</summary>
    [JsonPropertyName("akvResourceReference")]
    public V20241001previewstorageTargetSpecPropertiesSqlVmTargetVaultAkvResourceReference? AkvResourceReference { get; set; }

    [JsonPropertyName("akvTargetPassword")]
    public string? AkvTargetPassword { get; set; }

    [JsonPropertyName("akvTargetUser")]
    public string? AkvTargetUser { get; set; }
}

/// <summary>Storage version of v20241001preview.SqlVmTargetProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecPropertiesSqlVm
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("connectionServerName")]
    public string? ConnectionServerName { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("connectionServerNameFromConfig")]
    public V20241001previewstorageTargetSpecPropertiesSqlVmConnectionServerNameFromConfig? ConnectionServerNameFromConfig { get; set; }

    [JsonPropertyName("connectionTcpPort")]
    public int? ConnectionTcpPort { get; set; }

    [JsonPropertyName("sqlNamedInstanceName")]
    public string? SqlNamedInstanceName { get; set; }

    /// <summary>SqlVmResourceReference: The Azure resource ID of an Azure SQL VM target.</summary>
    [JsonPropertyName("sqlVmResourceReference")]
    public required V20241001previewstorageTargetSpecPropertiesSqlVmSqlVmResourceReference SqlVmResourceReference { get; set; }

    [JsonPropertyName("targetAuthenticationType")]
    public string? TargetAuthenticationType { get; set; }

    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>
    /// Storage version of v20241001preview.VaultSecret
    /// The vault specific details required if using SQL authentication to connect to a target.
    /// </summary>
    [JsonPropertyName("targetVault")]
    public V20241001previewstorageTargetSpecPropertiesSqlVmTargetVault? TargetVault { get; set; }
}

/// <summary>Storage version of v20241001preview.TargetProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpecProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20241001preview.SqlDbSingleDatabaseTargetProperties</summary>
    [JsonPropertyName("sqlDb")]
    public V20241001previewstorageTargetSpecPropertiesSqlDb? SqlDb { get; set; }

    /// <summary>Storage version of v20241001preview.SqlDbElasticPoolTargetProperties</summary>
    [JsonPropertyName("sqlEp")]
    public V20241001previewstorageTargetSpecPropertiesSqlEp? SqlEp { get; set; }

    /// <summary>Storage version of v20241001preview.SqlMiTargetProperties</summary>
    [JsonPropertyName("sqlMi")]
    public V20241001previewstorageTargetSpecPropertiesSqlMi? SqlMi { get; set; }

    /// <summary>Storage version of v20241001preview.SqlVmTargetProperties</summary>
    [JsonPropertyName("sqlVm")]
    public V20241001previewstorageTargetSpecPropertiesSqlVm? SqlVm { get; set; }
}

/// <summary>Storage version of v20241001preview.Target_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetSpec
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
    /// Storage version of v20241001preview.TargetOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20241001previewstorageTargetSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a databasewatcher.azure.com/Watcher resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20241001previewstorageTargetSpecOwner Owner { get; set; }

    /// <summary>Storage version of v20241001preview.TargetProperties</summary>
    [JsonPropertyName("properties")]
    public V20241001previewstorageTargetSpecProperties? Properties { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetStatusConditions
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
/// Storage version of v20241001preview.VaultSecret_STATUS
/// The vault specific details required if using SQL authentication to connect to a target.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetStatusPropertiesSqlDbTargetVault
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("akvResourceId")]
    public string? AkvResourceId { get; set; }

    [JsonPropertyName("akvTargetPassword")]
    public string? AkvTargetPassword { get; set; }

    [JsonPropertyName("akvTargetUser")]
    public string? AkvTargetUser { get; set; }
}

/// <summary>Storage version of v20241001preview.SqlDbSingleDatabaseTargetProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetStatusPropertiesSqlDb
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("connectionServerName")]
    public string? ConnectionServerName { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("readIntent")]
    public bool? ReadIntent { get; set; }

    [JsonPropertyName("sqlDbResourceId")]
    public string? SqlDbResourceId { get; set; }

    [JsonPropertyName("targetAuthenticationType")]
    public string? TargetAuthenticationType { get; set; }

    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>
    /// Storage version of v20241001preview.VaultSecret_STATUS
    /// The vault specific details required if using SQL authentication to connect to a target.
    /// </summary>
    [JsonPropertyName("targetVault")]
    public V20241001previewstorageTargetStatusPropertiesSqlDbTargetVault? TargetVault { get; set; }
}

/// <summary>
/// Storage version of v20241001preview.VaultSecret_STATUS
/// The vault specific details required if using SQL authentication to connect to a target.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetStatusPropertiesSqlEpTargetVault
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("akvResourceId")]
    public string? AkvResourceId { get; set; }

    [JsonPropertyName("akvTargetPassword")]
    public string? AkvTargetPassword { get; set; }

    [JsonPropertyName("akvTargetUser")]
    public string? AkvTargetUser { get; set; }
}

/// <summary>Storage version of v20241001preview.SqlDbElasticPoolTargetProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetStatusPropertiesSqlEp
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("anchorDatabaseResourceId")]
    public string? AnchorDatabaseResourceId { get; set; }

    [JsonPropertyName("connectionServerName")]
    public string? ConnectionServerName { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("readIntent")]
    public bool? ReadIntent { get; set; }

    [JsonPropertyName("sqlEpResourceId")]
    public string? SqlEpResourceId { get; set; }

    [JsonPropertyName("targetAuthenticationType")]
    public string? TargetAuthenticationType { get; set; }

    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>
    /// Storage version of v20241001preview.VaultSecret_STATUS
    /// The vault specific details required if using SQL authentication to connect to a target.
    /// </summary>
    [JsonPropertyName("targetVault")]
    public V20241001previewstorageTargetStatusPropertiesSqlEpTargetVault? TargetVault { get; set; }
}

/// <summary>
/// Storage version of v20241001preview.VaultSecret_STATUS
/// The vault specific details required if using SQL authentication to connect to a target.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetStatusPropertiesSqlMiTargetVault
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("akvResourceId")]
    public string? AkvResourceId { get; set; }

    [JsonPropertyName("akvTargetPassword")]
    public string? AkvTargetPassword { get; set; }

    [JsonPropertyName("akvTargetUser")]
    public string? AkvTargetUser { get; set; }
}

/// <summary>Storage version of v20241001preview.SqlMiTargetProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetStatusPropertiesSqlMi
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("connectionServerName")]
    public string? ConnectionServerName { get; set; }

    [JsonPropertyName("connectionTcpPort")]
    public int? ConnectionTcpPort { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("readIntent")]
    public bool? ReadIntent { get; set; }

    [JsonPropertyName("sqlMiResourceId")]
    public string? SqlMiResourceId { get; set; }

    [JsonPropertyName("targetAuthenticationType")]
    public string? TargetAuthenticationType { get; set; }

    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>
    /// Storage version of v20241001preview.VaultSecret_STATUS
    /// The vault specific details required if using SQL authentication to connect to a target.
    /// </summary>
    [JsonPropertyName("targetVault")]
    public V20241001previewstorageTargetStatusPropertiesSqlMiTargetVault? TargetVault { get; set; }
}

/// <summary>
/// Storage version of v20241001preview.VaultSecret_STATUS
/// The vault specific details required if using SQL authentication to connect to a target.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetStatusPropertiesSqlVmTargetVault
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("akvResourceId")]
    public string? AkvResourceId { get; set; }

    [JsonPropertyName("akvTargetPassword")]
    public string? AkvTargetPassword { get; set; }

    [JsonPropertyName("akvTargetUser")]
    public string? AkvTargetUser { get; set; }
}

/// <summary>Storage version of v20241001preview.SqlVmTargetProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetStatusPropertiesSqlVm
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("connectionServerName")]
    public string? ConnectionServerName { get; set; }

    [JsonPropertyName("connectionTcpPort")]
    public int? ConnectionTcpPort { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("sqlNamedInstanceName")]
    public string? SqlNamedInstanceName { get; set; }

    [JsonPropertyName("sqlVmResourceId")]
    public string? SqlVmResourceId { get; set; }

    [JsonPropertyName("targetAuthenticationType")]
    public string? TargetAuthenticationType { get; set; }

    [JsonPropertyName("targetType")]
    public string? TargetType { get; set; }

    /// <summary>
    /// Storage version of v20241001preview.VaultSecret_STATUS
    /// The vault specific details required if using SQL authentication to connect to a target.
    /// </summary>
    [JsonPropertyName("targetVault")]
    public V20241001previewstorageTargetStatusPropertiesSqlVmTargetVault? TargetVault { get; set; }
}

/// <summary>Storage version of v20241001preview.TargetProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetStatusProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20241001preview.SqlDbSingleDatabaseTargetProperties_STATUS</summary>
    [JsonPropertyName("sqlDb")]
    public V20241001previewstorageTargetStatusPropertiesSqlDb? SqlDb { get; set; }

    /// <summary>Storage version of v20241001preview.SqlDbElasticPoolTargetProperties_STATUS</summary>
    [JsonPropertyName("sqlEp")]
    public V20241001previewstorageTargetStatusPropertiesSqlEp? SqlEp { get; set; }

    /// <summary>Storage version of v20241001preview.SqlMiTargetProperties_STATUS</summary>
    [JsonPropertyName("sqlMi")]
    public V20241001previewstorageTargetStatusPropertiesSqlMi? SqlMi { get; set; }

    /// <summary>Storage version of v20241001preview.SqlVmTargetProperties_STATUS</summary>
    [JsonPropertyName("sqlVm")]
    public V20241001previewstorageTargetStatusPropertiesSqlVm? SqlVm { get; set; }
}

/// <summary>
/// Storage version of v20241001preview.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetStatusSystemData
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

/// <summary>Storage version of v20241001preview.Target_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20241001previewstorageTargetStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20241001previewstorageTargetStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v20241001preview.TargetProperties_STATUS</summary>
    [JsonPropertyName("properties")]
    public V20241001previewstorageTargetStatusProperties? Properties { get; set; }

    /// <summary>
    /// Storage version of v20241001preview.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V20241001previewstorageTargetStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20241001preview.Target
/// Generator information:
/// - Generated from: /databasewatcher/resource-manager/Microsoft.DatabaseWatcher/preview/2024-10-01-preview/Watcher.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DatabaseWatcher/watchers/{watcherName}/targets/{targetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20241001previewstorageTarget : IKubernetesObject<V1ObjectMeta>, ISpec<V20241001previewstorageTargetSpec?>, IStatus<V20241001previewstorageTargetStatus?>
{
    public const string KubeApiVersion = "v20241001previewstorage";
    public const string KubeKind = "Target";
    public const string KubeGroup = "databasewatcher.azure.com";
    public const string KubePluralName = "targets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "databasewatcher.azure.com/v20241001previewstorage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Target";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20241001preview.Target_Spec</summary>
    [JsonPropertyName("spec")]
    public V20241001previewstorageTargetSpec? Spec { get; set; }

    /// <summary>Storage version of v20241001preview.Target_STATUS</summary>
    [JsonPropertyName("status")]
    public V20241001previewstorageTargetStatus? Status { get; set; }
}
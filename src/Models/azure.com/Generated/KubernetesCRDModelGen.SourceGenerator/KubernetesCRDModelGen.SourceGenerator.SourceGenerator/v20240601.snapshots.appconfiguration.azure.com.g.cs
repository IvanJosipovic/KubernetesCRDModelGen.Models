#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appconfiguration.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /appconfiguration/resource-manager/Microsoft.AppConfiguration/AppConfiguration/stable/2024-06-01/appconfiguration.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/snapshots/{snapshotName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240601SnapshotList : IKubernetesObject<V1ListMeta>, IItems<V20240601Snapshot>
{
    public const string KubeApiVersion = "v20240601";
    public const string KubeKind = "SnapshotList";
    public const string KubeGroup = "appconfiguration.azure.com";
    public const string KubePluralName = "snapshots";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appconfiguration.azure.com/v20240601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SnapshotList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20240601Snapshot objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20240601Snapshot> Items { get; set; }
}

/// <summary>
/// CompositionType: The composition type describes how the key-values within the snapshot are composed. The &apos;key&apos;
/// composition type ensures there are no two key-values containing the same key. The &apos;key_label&apos; composition type ensures
/// there are no two key-values containing the same key and label.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240601SnapshotSpecCompositionTypeEnum>))]
public enum V20240601SnapshotSpecCompositionTypeEnum
{
    [EnumMember(Value = "Key"), JsonStringEnumMemberName("Key")]
    Key,
    [EnumMember(Value = "Key_Label"), JsonStringEnumMemberName("Key_Label")]
    KeyLabel
}

/// <summary>Enables filtering of key-values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240601SnapshotSpecFilters
{
    /// <summary>Key: Filters key-values by their key field.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Label: Filters key-values by their label field.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240601SnapshotSpecOperatorSpecConfigMapExpressions
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
public partial class V20240601SnapshotSpecOperatorSpecSecretExpressions
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
public partial class V20240601SnapshotSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20240601SnapshotSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20240601SnapshotSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a appconfiguration.azure.com/ConfigurationStore resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240601SnapshotSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240601SnapshotSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// CompositionType: The composition type describes how the key-values within the snapshot are composed. The &apos;key&apos;
    /// composition type ensures there are no two key-values containing the same key. The &apos;key_label&apos; composition type ensures
    /// there are no two key-values containing the same key and label.
    /// </summary>
    [JsonPropertyName("compositionType")]
    public V20240601SnapshotSpecCompositionTypeEnum? CompositionType { get; set; }

    /// <summary>Filters: A list of filters used to filter the key-values included in the snapshot.</summary>
    [JsonPropertyName("filters")]
    public required IList<V20240601SnapshotSpecFilters> Filters { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20240601SnapshotSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a appconfiguration.azure.com/ConfigurationStore resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20240601SnapshotSpecOwner Owner { get; set; }

    /// <summary>
    /// RetentionPeriod: The amount of time, in seconds, that a snapshot will remain in the archived state before expiring. This
    /// property is only writable during the creation of a snapshot. If not specified, the default lifetime of key-value
    /// revisions will be used.
    /// </summary>
    [JsonPropertyName("retentionPeriod")]
    public int? RetentionPeriod { get; set; }

    /// <summary>Tags: The tags of the snapshot. NOTE: These are data plane tags, not Azure Resource Manager (ARM) tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240601SnapshotStatusConditions
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

/// <summary>Enables filtering of key-values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240601SnapshotStatusFilters
{
    /// <summary>Key: Filters key-values by their key field.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Label: Filters key-values by their label field.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240601SnapshotStatus
{
    /// <summary>
    /// CompositionType: The composition type describes how the key-values within the snapshot are composed. The &apos;key&apos;
    /// composition type ensures there are no two key-values containing the same key. The &apos;key_label&apos; composition type ensures
    /// there are no two key-values containing the same key and label.
    /// </summary>
    [JsonPropertyName("compositionType")]
    public string? CompositionType { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20240601SnapshotStatusConditions>? Conditions { get; set; }

    /// <summary>Created: The time that the snapshot was created.</summary>
    [JsonPropertyName("created")]
    public string? Created { get; set; }

    /// <summary>Etag: A value representing the current state of the snapshot.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Expires: The time that the snapshot will expire.</summary>
    [JsonPropertyName("expires")]
    public string? Expires { get; set; }

    /// <summary>Filters: A list of filters used to filter the key-values included in the snapshot.</summary>
    [JsonPropertyName("filters")]
    public IList<V20240601SnapshotStatusFilters>? Filters { get; set; }

    /// <summary>Id: The resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ItemsCount: The amount of key-values in the snapshot.</summary>
    [JsonPropertyName("itemsCount")]
    public int? ItemsCount { get; set; }

    /// <summary>Name: The name of the snapshot.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the snapshot.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// RetentionPeriod: The amount of time, in seconds, that a snapshot will remain in the archived state before expiring. This
    /// property is only writable during the creation of a snapshot. If not specified, the default lifetime of key-value
    /// revisions will be used.
    /// </summary>
    [JsonPropertyName("retentionPeriod")]
    public int? RetentionPeriod { get; set; }

    /// <summary>Size: The size in bytes of the snapshot.</summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }

    /// <summary>Status: The current status of the snapshot.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Tags: The tags of the snapshot. NOTE: These are data plane tags, not Azure Resource Manager (ARM) tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /appconfiguration/resource-manager/Microsoft.AppConfiguration/AppConfiguration/stable/2024-06-01/appconfiguration.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/snapshots/{snapshotName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240601Snapshot : IKubernetesObject<V1ObjectMeta>, ISpec<V20240601SnapshotSpec?>, IStatus<V20240601SnapshotStatus?>
{
    public const string KubeApiVersion = "v20240601";
    public const string KubeKind = "Snapshot";
    public const string KubeGroup = "appconfiguration.azure.com";
    public const string KubePluralName = "snapshots";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appconfiguration.azure.com/v20240601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Snapshot";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20240601SnapshotSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20240601SnapshotStatus? Status { get; set; }
}
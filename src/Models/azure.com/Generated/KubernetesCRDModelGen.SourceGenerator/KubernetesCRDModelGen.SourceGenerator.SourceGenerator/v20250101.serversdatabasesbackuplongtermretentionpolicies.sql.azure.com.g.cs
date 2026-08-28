#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /sql/resource-manager/Microsoft.Sql/SQL/stable/2025-01-01/longTermRetentionPolicies.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/backupLongTermRetentionPolicies/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250101ServersDatabasesBackupLongTermRetentionPolicyList : IKubernetesObject<V1ListMeta>, IItems<V20250101ServersDatabasesBackupLongTermRetentionPolicy>
{
    public const string KubeApiVersion = "v20250101";
    public const string KubeKind = "ServersDatabasesBackupLongTermRetentionPolicyList";
    public const string KubeGroup = "sql.azure.com";
    public const string KubePluralName = "serversdatabasesbackuplongtermretentionpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.azure.com/v20250101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServersDatabasesBackupLongTermRetentionPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250101ServersDatabasesBackupLongTermRetentionPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250101ServersDatabasesBackupLongTermRetentionPolicy> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabasesBackupLongTermRetentionPolicySpecOperatorSpecConfigMapExpressions
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
public partial class V20250101ServersDatabasesBackupLongTermRetentionPolicySpecOperatorSpecSecretExpressions
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
public partial class V20250101ServersDatabasesBackupLongTermRetentionPolicySpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20250101ServersDatabasesBackupLongTermRetentionPolicySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20250101ServersDatabasesBackupLongTermRetentionPolicySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a sql.azure.com/ServersDatabase resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabasesBackupLongTermRetentionPolicySpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// TimeBasedImmutability: The setting for whether to enable time-based immutability for future backups. When set, future
/// backups will have TimeBasedImmutability enabled.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250101ServersDatabasesBackupLongTermRetentionPolicySpecTimeBasedImmutabilityEnum>))]
public enum V20250101ServersDatabasesBackupLongTermRetentionPolicySpecTimeBasedImmutabilityEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// TimeBasedImmutabilityMode: The setting for time-based immutability mode for future backup (Value can be either Locked or
/// UnLocked. Only effective if TimeBasedImmutability is enabled). Caution: Immutability of LTR backup cannot be removed if
/// TimeBasedImmutabilityMode is Locked.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250101ServersDatabasesBackupLongTermRetentionPolicySpecTimeBasedImmutabilityModeEnum>))]
public enum V20250101ServersDatabasesBackupLongTermRetentionPolicySpecTimeBasedImmutabilityModeEnum
{
    [EnumMember(Value = "Locked"), JsonStringEnumMemberName("Locked")]
    Locked,
    [EnumMember(Value = "Unlocked"), JsonStringEnumMemberName("Unlocked")]
    Unlocked
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabasesBackupLongTermRetentionPolicySpec
{
    /// <summary>MonthlyRetention: The monthly retention policy for an LTR backup in an ISO 8601 format.</summary>
    [JsonPropertyName("monthlyRetention")]
    public string? MonthlyRetention { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250101ServersDatabasesBackupLongTermRetentionPolicySpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a sql.azure.com/ServersDatabase resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250101ServersDatabasesBackupLongTermRetentionPolicySpecOwner Owner { get; set; }

    /// <summary>
    /// TimeBasedImmutability: The setting for whether to enable time-based immutability for future backups. When set, future
    /// backups will have TimeBasedImmutability enabled.
    /// </summary>
    [JsonPropertyName("timeBasedImmutability")]
    public V20250101ServersDatabasesBackupLongTermRetentionPolicySpecTimeBasedImmutabilityEnum? TimeBasedImmutability { get; set; }

    /// <summary>
    /// TimeBasedImmutabilityMode: The setting for time-based immutability mode for future backup (Value can be either Locked or
    /// UnLocked. Only effective if TimeBasedImmutability is enabled). Caution: Immutability of LTR backup cannot be removed if
    /// TimeBasedImmutabilityMode is Locked.
    /// </summary>
    [JsonPropertyName("timeBasedImmutabilityMode")]
    public V20250101ServersDatabasesBackupLongTermRetentionPolicySpecTimeBasedImmutabilityModeEnum? TimeBasedImmutabilityMode { get; set; }

    /// <summary>WeekOfYear: The week of year to take the yearly backup in an ISO 8601 format.</summary>
    [JsonPropertyName("weekOfYear")]
    public int? WeekOfYear { get; set; }

    /// <summary>WeeklyRetention: The weekly retention policy for an LTR backup in an ISO 8601 format.</summary>
    [JsonPropertyName("weeklyRetention")]
    public string? WeeklyRetention { get; set; }

    /// <summary>YearlyRetention: The yearly retention policy for an LTR backup in an ISO 8601 format.</summary>
    [JsonPropertyName("yearlyRetention")]
    public string? YearlyRetention { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabasesBackupLongTermRetentionPolicyStatusConditions
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

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101ServersDatabasesBackupLongTermRetentionPolicyStatusSystemData
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
public partial class V20250101ServersDatabasesBackupLongTermRetentionPolicyStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20250101ServersDatabasesBackupLongTermRetentionPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>MonthlyRetention: The monthly retention policy for an LTR backup in an ISO 8601 format.</summary>
    [JsonPropertyName("monthlyRetention")]
    public string? MonthlyRetention { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20250101ServersDatabasesBackupLongTermRetentionPolicyStatusSystemData? SystemData { get; set; }

    /// <summary>
    /// TimeBasedImmutability: The setting for whether to enable time-based immutability for future backups. When set, future
    /// backups will have TimeBasedImmutability enabled.
    /// </summary>
    [JsonPropertyName("timeBasedImmutability")]
    public string? TimeBasedImmutability { get; set; }

    /// <summary>
    /// TimeBasedImmutabilityMode: The setting for time-based immutability mode for future backup (Value can be either Locked or
    /// UnLocked. Only effective if TimeBasedImmutability is enabled). Caution: Immutability of LTR backup cannot be removed if
    /// TimeBasedImmutabilityMode is Locked.
    /// </summary>
    [JsonPropertyName("timeBasedImmutabilityMode")]
    public string? TimeBasedImmutabilityMode { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>WeekOfYear: The week of year to take the yearly backup in an ISO 8601 format.</summary>
    [JsonPropertyName("weekOfYear")]
    public int? WeekOfYear { get; set; }

    /// <summary>WeeklyRetention: The weekly retention policy for an LTR backup in an ISO 8601 format.</summary>
    [JsonPropertyName("weeklyRetention")]
    public string? WeeklyRetention { get; set; }

    /// <summary>YearlyRetention: The yearly retention policy for an LTR backup in an ISO 8601 format.</summary>
    [JsonPropertyName("yearlyRetention")]
    public string? YearlyRetention { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /sql/resource-manager/Microsoft.Sql/SQL/stable/2025-01-01/longTermRetentionPolicies.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/backupLongTermRetentionPolicies/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250101ServersDatabasesBackupLongTermRetentionPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V20250101ServersDatabasesBackupLongTermRetentionPolicySpec?>, IStatus<V20250101ServersDatabasesBackupLongTermRetentionPolicyStatus?>
{
    public const string KubeApiVersion = "v20250101";
    public const string KubeKind = "ServersDatabasesBackupLongTermRetentionPolicy";
    public const string KubeGroup = "sql.azure.com";
    public const string KubePluralName = "serversdatabasesbackuplongtermretentionpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.azure.com/v20250101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServersDatabasesBackupLongTermRetentionPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20250101ServersDatabasesBackupLongTermRetentionPolicySpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20250101ServersDatabasesBackupLongTermRetentionPolicyStatus? Status { get; set; }
}
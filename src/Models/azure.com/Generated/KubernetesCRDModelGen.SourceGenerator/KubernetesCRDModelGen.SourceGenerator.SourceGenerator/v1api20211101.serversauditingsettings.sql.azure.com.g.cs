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
/// - Generated from: /sql/resource-manager/Microsoft.Sql/stable/2021-11-01/BlobAuditing.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211101ServersAuditingSettingList : IKubernetesObject<V1ListMeta>, IItems<V1api20211101ServersAuditingSetting>
{
    public const string KubeApiVersion = "v1api20211101";
    public const string KubeKind = "ServersAuditingSettingList";
    public const string KubeGroup = "sql.azure.com";
    public const string KubePluralName = "serversauditingsettings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.azure.com/v1api20211101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServersAuditingSettingList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20211101ServersAuditingSetting objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20211101ServersAuditingSetting> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersAuditingSettingSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20211101ServersAuditingSettingSpecOperatorSpecSecretExpressions
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
public partial class V1api20211101ServersAuditingSettingSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20211101ServersAuditingSettingSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20211101ServersAuditingSettingSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a sql.azure.com/Server resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersAuditingSettingSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// State: Specifies the state of the audit. If state is Enabled, storageEndpoint or isAzureMonitorTargetEnabled are
/// required.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211101ServersAuditingSettingSpecStateEnum>))]
public enum V1api20211101ServersAuditingSettingSpecStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// StorageAccountAccessKey: Specifies the identifier key of the auditing storage account.
/// If state is Enabled and storageEndpoint is specified, not specifying the storageAccountAccessKey will use SQL server
/// system-assigned managed identity to access the storage.
/// Prerequisites for using managed identity authentication:
/// 1. Assign SQL Server a system-assigned managed identity in Azure Active Directory (AAD).
/// 2. Grant SQL Server identity access to the storage account by adding &apos;Storage Blob Data Contributor&apos; RBAC role to the
/// server identity.
/// For more information, see [Auditing to storage using Managed Identity
/// authentication](https://go.microsoft.com/fwlink/?linkid=2114355)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersAuditingSettingSpecStorageAccountAccessKey
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersAuditingSettingSpec
{
    /// <summary>
    /// AuditActionsAndGroups: Specifies the Actions-Groups and Actions to audit.
    /// The recommended set of action groups to use is the following combination - this will audit all the queries and stored
    /// procedures executed against the database, as well as successful and failed logins:
    /// BATCH_COMPLETED_GROUP,
    /// SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP,
    /// FAILED_DATABASE_AUTHENTICATION_GROUP.
    /// This above combination is also the set that is configured by default when enabling auditing from the Azure portal.
    /// The supported action groups to audit are (note: choose only specific groups that cover your auditing needs. Using
    /// unnecessary groups could lead to very large quantities of audit records):
    /// APPLICATION_ROLE_CHANGE_PASSWORD_GROUP
    /// BACKUP_RESTORE_GROUP
    /// DATABASE_LOGOUT_GROUP
    /// DATABASE_OBJECT_CHANGE_GROUP
    /// DATABASE_OBJECT_OWNERSHIP_CHANGE_GROUP
    /// DATABASE_OBJECT_PERMISSION_CHANGE_GROUP
    /// DATABASE_OPERATION_GROUP
    /// DATABASE_PERMISSION_CHANGE_GROUP
    /// DATABASE_PRINCIPAL_CHANGE_GROUP
    /// DATABASE_PRINCIPAL_IMPERSONATION_GROUP
    /// DATABASE_ROLE_MEMBER_CHANGE_GROUP
    /// FAILED_DATABASE_AUTHENTICATION_GROUP
    /// SCHEMA_OBJECT_ACCESS_GROUP
    /// SCHEMA_OBJECT_CHANGE_GROUP
    /// SCHEMA_OBJECT_OWNERSHIP_CHANGE_GROUP
    /// SCHEMA_OBJECT_PERMISSION_CHANGE_GROUP
    /// SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP
    /// USER_CHANGE_PASSWORD_GROUP
    /// BATCH_STARTED_GROUP
    /// BATCH_COMPLETED_GROUP
    /// DBCC_GROUP
    /// DATABASE_OWNERSHIP_CHANGE_GROUP
    /// DATABASE_CHANGE_GROUP
    /// LEDGER_OPERATION_GROUP
    /// These are groups that cover all sql statements and stored procedures executed against the database, and should not be
    /// used in combination with other groups as this will result in duplicate audit logs.
    /// For more information, see [Database-Level Audit Action
    /// Groups](https://docs.microsoft.com/en-us/sql/relational-databases/security/auditing/sql-server-audit-action-groups-and-actions#database-level-audit-action-groups).
    /// For Database auditing policy, specific Actions can also be specified (note that Actions cannot be specified for Server
    /// auditing policy). The supported actions to audit are:
    /// SELECT
    /// UPDATE
    /// INSERT
    /// DELETE
    /// EXECUTE
    /// RECEIVE
    /// REFERENCES
    /// The general form for defining an action to be audited is:
    /// {action} ON {object} BY {principal}
    /// Note that &lt;object&gt; in the above format can refer to an object like a table, view, or stored procedure, or an entire
    /// database or schema. For the latter cases, the forms DATABASE::{db_name} and SCHEMA::{schema_name} are used, respectively.
    /// For example:
    /// SELECT on dbo.myTable by public
    /// SELECT on DATABASE::myDatabase by public
    /// SELECT on SCHEMA::mySchema by public
    /// For more information, see [Database-Level Audit
    /// Actions](https://docs.microsoft.com/en-us/sql/relational-databases/security/auditing/sql-server-audit-action-groups-and-actions#database-level-audit-actions)
    /// </summary>
    [JsonPropertyName("auditActionsAndGroups")]
    public IList<string>? AuditActionsAndGroups { get; set; }

    /// <summary>
    /// IsAzureMonitorTargetEnabled: Specifies whether audit events are sent to Azure Monitor.
    /// In order to send the events to Azure Monitor, specify &apos;State&apos; as &apos;Enabled&apos; and &apos;IsAzureMonitorTargetEnabled&apos; as true.
    /// When using REST API to configure auditing, Diagnostic Settings with &apos;SQLSecurityAuditEvents&apos; diagnostic logs category on
    /// the database should be also created.
    /// Note that for server level audit you should use the &apos;master&apos; database as {databaseName}.
    /// Diagnostic Settings URI format:
    /// PUT
    /// https://management.azure.com/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/providers/microsoft.insights/diagnosticSettings/{settingsName}?api-version=2017-05-01-preview
    /// For more information, see [Diagnostic Settings REST API](https://go.microsoft.com/fwlink/?linkid=2033207)
    /// or [Diagnostic Settings PowerShell](https://go.microsoft.com/fwlink/?linkid=2033043)
    /// </summary>
    [JsonPropertyName("isAzureMonitorTargetEnabled")]
    public bool? IsAzureMonitorTargetEnabled { get; set; }

    /// <summary>
    /// IsDevopsAuditEnabled: Specifies the state of devops audit. If state is Enabled, devops logs will be sent to Azure
    /// Monitor.
    /// In order to send the events to Azure Monitor, specify &apos;State&apos; as &apos;Enabled&apos;, &apos;IsAzureMonitorTargetEnabled&apos; as true and
    /// &apos;IsDevopsAuditEnabled&apos; as true
    /// When using REST API to configure auditing, Diagnostic Settings with &apos;DevOpsOperationsAudit&apos; diagnostic logs category on
    /// the master database should also be created.
    /// Diagnostic Settings URI format:
    /// PUT
    /// https://management.azure.com/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Sql/servers/{serverName}/databases/master/providers/microsoft.insights/diagnosticSettings/{settingsName}?api-version=2017-05-01-preview
    /// For more information, see [Diagnostic Settings REST API](https://go.microsoft.com/fwlink/?linkid=2033207)
    /// or [Diagnostic Settings PowerShell](https://go.microsoft.com/fwlink/?linkid=2033043)
    /// </summary>
    [JsonPropertyName("isDevopsAuditEnabled")]
    public bool? IsDevopsAuditEnabled { get; set; }

    /// <summary>IsManagedIdentityInUse: Specifies whether Managed Identity is used to access blob storage</summary>
    [JsonPropertyName("isManagedIdentityInUse")]
    public bool? IsManagedIdentityInUse { get; set; }

    /// <summary>IsStorageSecondaryKeyInUse: Specifies whether storageAccountAccessKey value is the storage&apos;s secondary key.</summary>
    [JsonPropertyName("isStorageSecondaryKeyInUse")]
    public bool? IsStorageSecondaryKeyInUse { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20211101ServersAuditingSettingSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a sql.azure.com/Server resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20211101ServersAuditingSettingSpecOwner Owner { get; set; }

    /// <summary>
    /// QueueDelayMs: Specifies the amount of time in milliseconds that can elapse before audit actions are forced to be
    /// processed.
    /// The default minimum value is 1000 (1 second). The maximum is 2,147,483,647.
    /// </summary>
    [JsonPropertyName("queueDelayMs")]
    public int? QueueDelayMs { get; set; }

    /// <summary>RetentionDays: Specifies the number of days to keep in the audit logs in the storage account.</summary>
    [JsonPropertyName("retentionDays")]
    public int? RetentionDays { get; set; }

    /// <summary>
    /// State: Specifies the state of the audit. If state is Enabled, storageEndpoint or isAzureMonitorTargetEnabled are
    /// required.
    /// </summary>
    [JsonPropertyName("state")]
    public required V1api20211101ServersAuditingSettingSpecStateEnum State { get; set; }

    /// <summary>
    /// StorageAccountAccessKey: Specifies the identifier key of the auditing storage account.
    /// If state is Enabled and storageEndpoint is specified, not specifying the storageAccountAccessKey will use SQL server
    /// system-assigned managed identity to access the storage.
    /// Prerequisites for using managed identity authentication:
    /// 1. Assign SQL Server a system-assigned managed identity in Azure Active Directory (AAD).
    /// 2. Grant SQL Server identity access to the storage account by adding &apos;Storage Blob Data Contributor&apos; RBAC role to the
    /// server identity.
    /// For more information, see [Auditing to storage using Managed Identity
    /// authentication](https://go.microsoft.com/fwlink/?linkid=2114355)
    /// </summary>
    [JsonPropertyName("storageAccountAccessKey")]
    public V1api20211101ServersAuditingSettingSpecStorageAccountAccessKey? StorageAccountAccessKey { get; set; }

    /// <summary>StorageAccountSubscriptionId: Specifies the blob storage subscription Id.</summary>
    [JsonPropertyName("storageAccountSubscriptionId")]
    public string? StorageAccountSubscriptionId { get; set; }

    /// <summary>
    /// StorageEndpoint: Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). If state is
    /// Enabled, storageEndpoint or isAzureMonitorTargetEnabled is required.
    /// </summary>
    [JsonPropertyName("storageEndpoint")]
    public string? StorageEndpoint { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersAuditingSettingStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersAuditingSettingStatus
{
    /// <summary>
    /// AuditActionsAndGroups: Specifies the Actions-Groups and Actions to audit.
    /// The recommended set of action groups to use is the following combination - this will audit all the queries and stored
    /// procedures executed against the database, as well as successful and failed logins:
    /// BATCH_COMPLETED_GROUP,
    /// SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP,
    /// FAILED_DATABASE_AUTHENTICATION_GROUP.
    /// This above combination is also the set that is configured by default when enabling auditing from the Azure portal.
    /// The supported action groups to audit are (note: choose only specific groups that cover your auditing needs. Using
    /// unnecessary groups could lead to very large quantities of audit records):
    /// APPLICATION_ROLE_CHANGE_PASSWORD_GROUP
    /// BACKUP_RESTORE_GROUP
    /// DATABASE_LOGOUT_GROUP
    /// DATABASE_OBJECT_CHANGE_GROUP
    /// DATABASE_OBJECT_OWNERSHIP_CHANGE_GROUP
    /// DATABASE_OBJECT_PERMISSION_CHANGE_GROUP
    /// DATABASE_OPERATION_GROUP
    /// DATABASE_PERMISSION_CHANGE_GROUP
    /// DATABASE_PRINCIPAL_CHANGE_GROUP
    /// DATABASE_PRINCIPAL_IMPERSONATION_GROUP
    /// DATABASE_ROLE_MEMBER_CHANGE_GROUP
    /// FAILED_DATABASE_AUTHENTICATION_GROUP
    /// SCHEMA_OBJECT_ACCESS_GROUP
    /// SCHEMA_OBJECT_CHANGE_GROUP
    /// SCHEMA_OBJECT_OWNERSHIP_CHANGE_GROUP
    /// SCHEMA_OBJECT_PERMISSION_CHANGE_GROUP
    /// SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP
    /// USER_CHANGE_PASSWORD_GROUP
    /// BATCH_STARTED_GROUP
    /// BATCH_COMPLETED_GROUP
    /// DBCC_GROUP
    /// DATABASE_OWNERSHIP_CHANGE_GROUP
    /// DATABASE_CHANGE_GROUP
    /// LEDGER_OPERATION_GROUP
    /// These are groups that cover all sql statements and stored procedures executed against the database, and should not be
    /// used in combination with other groups as this will result in duplicate audit logs.
    /// For more information, see [Database-Level Audit Action
    /// Groups](https://docs.microsoft.com/en-us/sql/relational-databases/security/auditing/sql-server-audit-action-groups-and-actions#database-level-audit-action-groups).
    /// For Database auditing policy, specific Actions can also be specified (note that Actions cannot be specified for Server
    /// auditing policy). The supported actions to audit are:
    /// SELECT
    /// UPDATE
    /// INSERT
    /// DELETE
    /// EXECUTE
    /// RECEIVE
    /// REFERENCES
    /// The general form for defining an action to be audited is:
    /// {action} ON {object} BY {principal}
    /// Note that &lt;object&gt; in the above format can refer to an object like a table, view, or stored procedure, or an entire
    /// database or schema. For the latter cases, the forms DATABASE::{db_name} and SCHEMA::{schema_name} are used, respectively.
    /// For example:
    /// SELECT on dbo.myTable by public
    /// SELECT on DATABASE::myDatabase by public
    /// SELECT on SCHEMA::mySchema by public
    /// For more information, see [Database-Level Audit
    /// Actions](https://docs.microsoft.com/en-us/sql/relational-databases/security/auditing/sql-server-audit-action-groups-and-actions#database-level-audit-actions)
    /// </summary>
    [JsonPropertyName("auditActionsAndGroups")]
    public IList<string>? AuditActionsAndGroups { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20211101ServersAuditingSettingStatusConditions>? Conditions { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// IsAzureMonitorTargetEnabled: Specifies whether audit events are sent to Azure Monitor.
    /// In order to send the events to Azure Monitor, specify &apos;State&apos; as &apos;Enabled&apos; and &apos;IsAzureMonitorTargetEnabled&apos; as true.
    /// When using REST API to configure auditing, Diagnostic Settings with &apos;SQLSecurityAuditEvents&apos; diagnostic logs category on
    /// the database should be also created.
    /// Note that for server level audit you should use the &apos;master&apos; database as {databaseName}.
    /// Diagnostic Settings URI format:
    /// PUT
    /// https://management.azure.com/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/providers/microsoft.insights/diagnosticSettings/{settingsName}?api-version=2017-05-01-preview
    /// For more information, see [Diagnostic Settings REST API](https://go.microsoft.com/fwlink/?linkid=2033207)
    /// or [Diagnostic Settings PowerShell](https://go.microsoft.com/fwlink/?linkid=2033043)
    /// </summary>
    [JsonPropertyName("isAzureMonitorTargetEnabled")]
    public bool? IsAzureMonitorTargetEnabled { get; set; }

    /// <summary>
    /// IsDevopsAuditEnabled: Specifies the state of devops audit. If state is Enabled, devops logs will be sent to Azure
    /// Monitor.
    /// In order to send the events to Azure Monitor, specify &apos;State&apos; as &apos;Enabled&apos;, &apos;IsAzureMonitorTargetEnabled&apos; as true and
    /// &apos;IsDevopsAuditEnabled&apos; as true
    /// When using REST API to configure auditing, Diagnostic Settings with &apos;DevOpsOperationsAudit&apos; diagnostic logs category on
    /// the master database should also be created.
    /// Diagnostic Settings URI format:
    /// PUT
    /// https://management.azure.com/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Sql/servers/{serverName}/databases/master/providers/microsoft.insights/diagnosticSettings/{settingsName}?api-version=2017-05-01-preview
    /// For more information, see [Diagnostic Settings REST API](https://go.microsoft.com/fwlink/?linkid=2033207)
    /// or [Diagnostic Settings PowerShell](https://go.microsoft.com/fwlink/?linkid=2033043)
    /// </summary>
    [JsonPropertyName("isDevopsAuditEnabled")]
    public bool? IsDevopsAuditEnabled { get; set; }

    /// <summary>IsManagedIdentityInUse: Specifies whether Managed Identity is used to access blob storage</summary>
    [JsonPropertyName("isManagedIdentityInUse")]
    public bool? IsManagedIdentityInUse { get; set; }

    /// <summary>IsStorageSecondaryKeyInUse: Specifies whether storageAccountAccessKey value is the storage&apos;s secondary key.</summary>
    [JsonPropertyName("isStorageSecondaryKeyInUse")]
    public bool? IsStorageSecondaryKeyInUse { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// QueueDelayMs: Specifies the amount of time in milliseconds that can elapse before audit actions are forced to be
    /// processed.
    /// The default minimum value is 1000 (1 second). The maximum is 2,147,483,647.
    /// </summary>
    [JsonPropertyName("queueDelayMs")]
    public int? QueueDelayMs { get; set; }

    /// <summary>RetentionDays: Specifies the number of days to keep in the audit logs in the storage account.</summary>
    [JsonPropertyName("retentionDays")]
    public int? RetentionDays { get; set; }

    /// <summary>
    /// State: Specifies the state of the audit. If state is Enabled, storageEndpoint or isAzureMonitorTargetEnabled are
    /// required.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>StorageAccountSubscriptionId: Specifies the blob storage subscription Id.</summary>
    [JsonPropertyName("storageAccountSubscriptionId")]
    public string? StorageAccountSubscriptionId { get; set; }

    /// <summary>
    /// StorageEndpoint: Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). If state is
    /// Enabled, storageEndpoint or isAzureMonitorTargetEnabled is required.
    /// </summary>
    [JsonPropertyName("storageEndpoint")]
    public string? StorageEndpoint { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /sql/resource-manager/Microsoft.Sql/stable/2021-11-01/BlobAuditing.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/auditingSettings/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211101ServersAuditingSetting : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20211101ServersAuditingSettingSpec?>, IStatus<V1api20211101ServersAuditingSettingStatus?>
{
    public const string KubeApiVersion = "v1api20211101";
    public const string KubeKind = "ServersAuditingSetting";
    public const string KubeGroup = "sql.azure.com";
    public const string KubePluralName = "serversauditingsettings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.azure.com/v1api20211101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServersAuditingSetting";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20211101ServersAuditingSettingSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20211101ServersAuditingSettingStatus? Status { get; set; }
}
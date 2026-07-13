#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.rds.services.k8s.aws;
/// <summary>DBClusterParameterGroup is the Schema for the DBClusterParameterGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBClusterParameterGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DBClusterParameterGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBClusterParameterGroupList";
    public const string KubeGroup = "rds.services.k8s.aws";
    public const string KubePluralName = "dbclusterparametergroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBClusterParameterGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DBClusterParameterGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DBClusterParameterGroup> Items { get; set; }
}

/// <summary>
/// This data type is used as a request parameter in the ModifyDBParameterGroup
/// and ResetDBParameterGroup actions.
/// 
/// This data type is used as a response element in the DescribeEngineDefaultParameters
/// and DescribeDBParameters actions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterParameterGroupSpecParameters
{
    [JsonPropertyName("allowedValues")]
    public string? AllowedValues { get; set; }

    [JsonPropertyName("applyMethod")]
    public string? ApplyMethod { get; set; }

    [JsonPropertyName("applyType")]
    public string? ApplyType { get; set; }

    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("isModifiable")]
    public bool? IsModifiable { get; set; }

    [JsonPropertyName("minimumEngineVersion")]
    public string? MinimumEngineVersion { get; set; }

    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("supportedEngineModes")]
    public IList<string>? SupportedEngineModes { get; set; }
}

/// <summary>
/// Metadata assigned to an Amazon RDS resource consisting of a key-value pair.
/// 
/// For more information, see Tagging Amazon RDS resources (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.html)
/// in the Amazon RDS User Guide or Tagging Amazon Aurora and Amazon RDS resources
/// (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Tagging.html)
/// in the Amazon Aurora User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterParameterGroupSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// DBClusterParameterGroupSpec defines the desired state of DBClusterParameterGroup.
/// 
/// Contains the details of an Amazon RDS DB cluster parameter group.
/// 
/// This data type is used as a response element in the DescribeDBClusterParameterGroups
/// action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterParameterGroupSpec
{
    /// <summary>The description for the DB cluster parameter group.</summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    /// <summary>
    /// The DB cluster parameter group family name. A DB cluster parameter group
    /// can be associated with one and only one DB cluster parameter group family,
    /// and can be applied only to a DB cluster running a database engine and engine
    /// version compatible with that DB cluster parameter group family.
    /// 
    /// # Aurora MySQL
    /// 
    /// Example: aurora-mysql5.7, aurora-mysql8.0
    /// 
    /// # Aurora PostgreSQL
    /// 
    /// Example: aurora-postgresql14
    /// 
    /// # RDS for MySQL
    /// 
    /// Example: mysql8.0
    /// 
    /// # RDS for PostgreSQL
    /// 
    /// Example: postgres13
    /// 
    /// To list all of the available parameter group families for a DB engine, use
    /// the following command:
    /// 
    /// aws rds describe-db-engine-versions --query &quot;DBEngineVersions[].DBParameterGroupFamily&quot;
    /// --engine
    /// 
    /// For example, to list all of the available parameter group families for the
    /// Aurora PostgreSQL DB engine, use the following command:
    /// 
    /// aws rds describe-db-engine-versions --query &quot;DBEngineVersions[].DBParameterGroupFamily&quot;
    /// --engine aurora-postgresql
    /// 
    /// The output contains duplicates.
    /// 
    /// The following are the valid DB engine values:
    /// 
    ///   - aurora-mysql
    /// 
    ///   - aurora-postgresql
    /// 
    ///   - mysql
    /// 
    ///   - postgres
    /// </summary>
    [JsonPropertyName("family")]
    public required string Family { get; set; }

    /// <summary>
    /// The name of the DB cluster parameter group.
    /// 
    /// Constraints:
    /// 
    ///   - Must not match the name of an existing DB cluster parameter group.
    /// 
    /// This value is stored as a lowercase string.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Map keys are the parameter name and the values are the parameter value.
    /// 
    /// The &quot;apply method&quot; for parameters is automatically determined.
    /// 
    /// These are ONLY user-defined parameter overrides for the DB cluster parameter group.
    /// 
    /// This does not contain default or system parameters.
    /// </summary>
    [JsonPropertyName("parameterOverrides")]
    public IDictionary<string, string>? ParameterOverrides { get; set; }

    /// <summary>DEPRECATED - do not use.  Prefer ParameterOverrides instead.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1DBClusterParameterGroupSpecParameters>? Parameters { get; set; }

    /// <summary>Tags to assign to the DB cluster parameter group.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1DBClusterParameterGroupSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterParameterGroupStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterParameterGroupStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// This data type is used as a request parameter in the ModifyDBParameterGroup
/// and ResetDBParameterGroup actions.
/// 
/// This data type is used as a response element in the DescribeEngineDefaultParameters
/// and DescribeDBParameters actions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterParameterGroupStatusParameterOverrideStatuses
{
    [JsonPropertyName("allowedValues")]
    public string? AllowedValues { get; set; }

    [JsonPropertyName("applyMethod")]
    public string? ApplyMethod { get; set; }

    [JsonPropertyName("applyType")]
    public string? ApplyType { get; set; }

    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("isModifiable")]
    public bool? IsModifiable { get; set; }

    [JsonPropertyName("minimumEngineVersion")]
    public string? MinimumEngineVersion { get; set; }

    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("supportedEngineModes")]
    public IList<string>? SupportedEngineModes { get; set; }
}

/// <summary>DBClusterParameterGroupStatus defines the observed state of DBClusterParameterGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterParameterGroupStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DBClusterParameterGroupStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DBClusterParameterGroupStatusConditions>? Conditions { get; set; }

    /// <summary>Provides a list of parameters for the DB cluster parameter group.</summary>
    [JsonPropertyName("parameterOverrideStatuses")]
    public IList<V1alpha1DBClusterParameterGroupStatusParameterOverrideStatuses>? ParameterOverrideStatuses { get; set; }
}

/// <summary>DBClusterParameterGroup is the Schema for the DBClusterParameterGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBClusterParameterGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DBClusterParameterGroupSpec?>, IStatus<V1alpha1DBClusterParameterGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBClusterParameterGroup";
    public const string KubeGroup = "rds.services.k8s.aws";
    public const string KubePluralName = "dbclusterparametergroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBClusterParameterGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// DBClusterParameterGroupSpec defines the desired state of DBClusterParameterGroup.
    /// 
    /// Contains the details of an Amazon RDS DB cluster parameter group.
    /// 
    /// This data type is used as a response element in the DescribeDBClusterParameterGroups
    /// action.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1DBClusterParameterGroupSpec? Spec { get; set; }

    /// <summary>DBClusterParameterGroupStatus defines the observed state of DBClusterParameterGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1DBClusterParameterGroupStatus? Status { get; set; }
}
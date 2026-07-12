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
/// <summary>DBParameterGroup is the Schema for the DBParameterGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBParameterGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DBParameterGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBParameterGroupList";
    public const string KubeGroup = "rds.services.k8s.aws";
    public const string KubePluralName = "dbparametergroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBParameterGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DBParameterGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DBParameterGroup> Items { get; set; }
}

/// <summary>
/// Metadata assigned to an Amazon RDS resource consisting of a key-value pair.
/// 
/// For more information, see Tagging Amazon RDS resources (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.html)
/// in the Amazon RDS User Guide or Tagging Amazon Aurora and Amazon RDS resources
/// (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Tagging.html)
/// in the Amazon Aurora User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBParameterGroupSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// DBParameterGroupSpec defines the desired state of DBParameterGroup.
/// 
/// Contains the details of an Amazon RDS DB parameter group.
/// 
/// This data type is used as a response element in the DescribeDBParameterGroups
/// action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBParameterGroupSpec
{
    /// <summary>The description for the DB parameter group.</summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    /// <summary>
    /// The DB parameter group family name. A DB parameter group can be associated
    /// with one and only one DB parameter group family, and can be applied only
    /// to a DB instance running a database engine and engine version compatible
    /// with that DB parameter group family.
    /// 
    /// To list all of the available parameter group families for a DB engine, use
    /// the following command:
    /// 
    /// aws rds describe-db-engine-versions --query &quot;DBEngineVersions[].DBParameterGroupFamily&quot;
    /// --engine
    /// 
    /// For example, to list all of the available parameter group families for the
    /// MySQL DB engine, use the following command:
    /// 
    /// aws rds describe-db-engine-versions --query &quot;DBEngineVersions[].DBParameterGroupFamily&quot;
    /// --engine mysql
    /// 
    /// The output contains duplicates.
    /// 
    /// The following are the valid DB engine values:
    /// 
    ///   - aurora-mysql
    /// 
    ///   - aurora-postgresql
    /// 
    ///   - db2-ae
    /// 
    ///   - db2-se
    /// 
    ///   - mysql
    /// 
    ///   - oracle-ee
    /// 
    ///   - oracle-ee-cdb
    /// 
    ///   - oracle-se2
    /// 
    ///   - oracle-se2-cdb
    /// 
    ///   - postgres
    /// 
    ///   - sqlserver-ee
    /// 
    ///   - sqlserver-se
    /// 
    ///   - sqlserver-ex
    /// 
    ///   - sqlserver-web
    /// </summary>
    [JsonPropertyName("family")]
    public required string Family { get; set; }

    /// <summary>
    /// The name of the DB parameter group.
    /// 
    /// Constraints:
    /// 
    ///   - Must be 1 to 255 letters, numbers, or hyphens.
    /// 
    ///   - First character must be a letter
    /// 
    ///   - Can&apos;t end with a hyphen or contain two consecutive hyphens
    /// 
    /// This value is stored as a lowercase string.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Map keys are the parameter name and the values are the parameter value.
    /// 
    /// These are ONLY user-defined parameter overrides for the DB parameter group.
    /// 
    /// This does not contain default or system parameters.
    /// </summary>
    [JsonPropertyName("parameterOverrides")]
    public IDictionary<string, string>? ParameterOverrides { get; set; }

    /// <summary>Tags to assign to the DB parameter group.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1DBParameterGroupSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBParameterGroupStatusAckResourceMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBParameterGroupStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBParameterGroupStatusParameterOverrideStatuses
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

/// <summary>DBParameterGroupStatus defines the observed state of DBParameterGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBParameterGroupStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DBParameterGroupStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DBParameterGroupStatusConditions>? Conditions { get; set; }

    /// <summary>A list of Parameter values.</summary>
    [JsonPropertyName("parameterOverrideStatuses")]
    public IList<V1alpha1DBParameterGroupStatusParameterOverrideStatuses>? ParameterOverrideStatuses { get; set; }
}

/// <summary>DBParameterGroup is the Schema for the DBParameterGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBParameterGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DBParameterGroupSpec?>, IStatus<V1alpha1DBParameterGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBParameterGroup";
    public const string KubeGroup = "rds.services.k8s.aws";
    public const string KubePluralName = "dbparametergroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBParameterGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// DBParameterGroupSpec defines the desired state of DBParameterGroup.
    /// 
    /// Contains the details of an Amazon RDS DB parameter group.
    /// 
    /// This data type is used as a response element in the DescribeDBParameterGroups
    /// action.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1DBParameterGroupSpec? Spec { get; set; }

    /// <summary>DBParameterGroupStatus defines the observed state of DBParameterGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1DBParameterGroupStatus? Status { get; set; }
}
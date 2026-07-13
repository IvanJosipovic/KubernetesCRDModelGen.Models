#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.memorydb.services.k8s.aws;
/// <summary>ParameterGroup is the Schema for the ParameterGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ParameterGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ParameterGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ParameterGroupList";
    public const string KubeGroup = "memorydb.services.k8s.aws";
    public const string KubePluralName = "parametergroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memorydb.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ParameterGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ParameterGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ParameterGroup> Items { get; set; }
}

/// <summary>Describes a name-value pair that is used to update the value of a parameter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterGroupSpecParameterNameValues
{
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
}

/// <summary>
/// A tag that can be added to an MemoryDB resource. Tags are composed of a Key/Value
/// pair. You can use tags to categorize and track all your MemoryDB resources.
/// When you add or remove tags on clusters, those actions will be replicated
/// to all nodes in the cluster. A tag with a null Value is permitted. For more
/// information, see Tagging your MemoryDB resources (https://docs.aws.amazon.com/MemoryDB/latest/devguide/tagging-resources.html)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterGroupSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// ParameterGroupSpec defines the desired state of ParameterGroup.
/// 
/// Represents the output of a CreateParameterGroup operation. A parameter group
/// represents a combination of specific values for the parameters that are passed
/// to the engine software during startup.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterGroupSpec
{
    /// <summary>An optional description of the parameter group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The name of the parameter group family that the parameter group can be used
    /// with.
    /// </summary>
    [JsonPropertyName("family")]
    public required string Family { get; set; }

    /// <summary>The name of the parameter group.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// An array of parameter names and values for the parameter update. You must
    /// supply at least one parameter name and value; subsequent arguments are optional.
    /// A maximum of 20 parameters may be updated per request.
    /// </summary>
    [JsonPropertyName("parameterNameValues")]
    public IList<V1alpha1ParameterGroupSpecParameterNameValues>? ParameterNameValues { get; set; }

    /// <summary>
    /// A list of tags to be added to this resource. A tag is a key-value pair. A
    /// tag key must be accompanied by a tag value, although null is accepted.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ParameterGroupSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterGroupStatusAckResourceMetadata
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
public partial class V1alpha1ParameterGroupStatusConditions
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

/// <summary>Describes an individual setting that controls some aspect of MemoryDB behavior.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterGroupStatusParameters
{
    [JsonPropertyName("allowedValues")]
    public string? AllowedValues { get; set; }

    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("minimumEngineVersion")]
    public string? MinimumEngineVersion { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>ParameterGroupStatus defines the observed state of ParameterGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterGroupStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ParameterGroupStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ParameterGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// A list of parameters specific to a particular parameter group. Each element
    /// in the list contains detailed information about one parameter.
    /// </summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1ParameterGroupStatusParameters>? Parameters { get; set; }
}

/// <summary>ParameterGroup is the Schema for the ParameterGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ParameterGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ParameterGroupSpec?>, IStatus<V1alpha1ParameterGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ParameterGroup";
    public const string KubeGroup = "memorydb.services.k8s.aws";
    public const string KubePluralName = "parametergroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memorydb.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ParameterGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ParameterGroupSpec defines the desired state of ParameterGroup.
    /// 
    /// Represents the output of a CreateParameterGroup operation. A parameter group
    /// represents a combination of specific values for the parameters that are passed
    /// to the engine software during startup.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ParameterGroupSpec? Spec { get; set; }

    /// <summary>ParameterGroupStatus defines the observed state of ParameterGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1ParameterGroupStatus? Status { get; set; }
}
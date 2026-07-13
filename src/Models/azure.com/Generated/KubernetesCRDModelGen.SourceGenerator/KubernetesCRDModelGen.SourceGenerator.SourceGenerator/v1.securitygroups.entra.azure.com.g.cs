#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.entra.azure.com;
/// <summary>SecurityGroup is an Entra Security Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1SecurityGroupList : IKubernetesObject<V1ListMeta>, IItems<V1SecurityGroup>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "SecurityGroupList";
    public const string KubeGroup = "entra.azure.com";
    public const string KubePluralName = "securitygroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "entra.azure.com/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecurityGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1SecurityGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1SecurityGroup> Items { get; set; }
}

/// <summary>MembershipType: The membership type of the group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1SecurityGroupSpecMembershipTypeEnum>))]
public enum V1SecurityGroupSpecMembershipTypeEnum
{
    [EnumMember(Value = "assigned"), JsonStringEnumMemberName("assigned")]
    Assigned,
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    Enabled,
    [EnumMember(Value = "assignedm365"), JsonStringEnumMemberName("assignedm365")]
    Assignedm365,
    [EnumMember(Value = "enabledm365"), JsonStringEnumMemberName("enabledm365")]
    Enabledm365
}

/// <summary>EntraID: The Entra ID of the group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SecurityGroupSpecOperatorSpecConfigmapsEntraID
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ConfigMaps specifies any config maps that should be created by the operator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SecurityGroupSpecOperatorSpecConfigmaps
{
    /// <summary>EntraID: The Entra ID of the group.</summary>
    [JsonPropertyName("entraID")]
    public V1SecurityGroupSpecOperatorSpecConfigmapsEntraID? EntraID { get; set; }
}

/// <summary>
/// CreationMode: Specifies how ASO will try to create the resource.
/// Specify &quot;AlwaysCreate&quot; to always create a new security group when first reconciled.
/// Or specify &quot;AdoptOrCreate&quot; to first try to adopt an existing security group with the same display name.
/// If multiple security groups with the same display name are found, the resource condition will show an error.
/// If not specified, defaults to &quot;AdoptOrCreate&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1SecurityGroupSpecOperatorSpecCreationModeEnum>))]
public enum V1SecurityGroupSpecOperatorSpecCreationModeEnum
{
    [EnumMember(Value = "AdoptOrCreate"), JsonStringEnumMemberName("AdoptOrCreate")]
    AdoptOrCreate,
    [EnumMember(Value = "AlwaysCreate"), JsonStringEnumMemberName("AlwaysCreate")]
    AlwaysCreate
}

/// <summary>OperatorSpec: The operator specific configuration for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SecurityGroupSpecOperatorSpec
{
    /// <summary>ConfigMaps specifies any config maps that should be created by the operator.</summary>
    [JsonPropertyName("configmaps")]
    public V1SecurityGroupSpecOperatorSpecConfigmaps? Configmaps { get; set; }

    /// <summary>
    /// CreationMode: Specifies how ASO will try to create the resource.
    /// Specify &quot;AlwaysCreate&quot; to always create a new security group when first reconciled.
    /// Or specify &quot;AdoptOrCreate&quot; to first try to adopt an existing security group with the same display name.
    /// If multiple security groups with the same display name are found, the resource condition will show an error.
    /// If not specified, defaults to &quot;AdoptOrCreate&quot;.
    /// </summary>
    [JsonPropertyName("creationMode")]
    public V1SecurityGroupSpecOperatorSpecCreationModeEnum? CreationMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SecurityGroupSpec
{
    /// <summary>Description: The description of the group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DisplayName: The display name of the group.</summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>IsAssignableToRole: Indicates whether the group can be assigned to a role.</summary>
    [JsonPropertyName("isAssignableToRole")]
    public bool? IsAssignableToRole { get; set; }

    /// <summary>
    /// MailNickname: The email address of the group, specified either as a mail nickname (`mygroup`)
    /// or as a full email address (`mygroup@mydomain.com`).
    /// </summary>
    [JsonPropertyName("mailNickname")]
    public required string MailNickname { get; set; }

    /// <summary>MembershipType: The membership type of the group.</summary>
    [JsonPropertyName("membershipType")]
    public V1SecurityGroupSpecMembershipTypeEnum? MembershipType { get; set; }

    /// <summary>OperatorSpec: The operator specific configuration for the resource.</summary>
    [JsonPropertyName("operatorSpec")]
    public V1SecurityGroupSpecOperatorSpec? OperatorSpec { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1SecurityGroupStatusConditions
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
public partial class V1SecurityGroupStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1SecurityGroupStatusConditions>? Conditions { get; set; }

    /// <summary>Description: The description of the group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DisplayName: The display name of the group.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>EntraID: The GUID identifing the resource in Entra</summary>
    [JsonPropertyName("entraID")]
    public string? EntraID { get; set; }

    /// <summary>MailNickname: The email address of the group.</summary>
    [JsonPropertyName("groupEmailAddress")]
    public required string GroupEmailAddress { get; set; }
}

/// <summary>SecurityGroup is an Entra Security Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1SecurityGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1SecurityGroupSpec?>, IStatus<V1SecurityGroupStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "SecurityGroup";
    public const string KubeGroup = "entra.azure.com";
    public const string KubePluralName = "securitygroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "entra.azure.com/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecurityGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1SecurityGroupSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1SecurityGroupStatus? Status { get; set; }
}
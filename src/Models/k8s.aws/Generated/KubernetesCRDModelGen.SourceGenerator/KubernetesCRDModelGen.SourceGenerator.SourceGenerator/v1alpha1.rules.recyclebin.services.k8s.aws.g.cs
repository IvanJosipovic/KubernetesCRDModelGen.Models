#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.recyclebin.services.k8s.aws;
/// <summary>Rule is the Schema for the Rules API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RuleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Rule>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RuleList";
    public const string KubeGroup = "recyclebin.services.k8s.aws";
    public const string KubePluralName = "rules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "recyclebin.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Rule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Rule> Items { get; set; }
}

/// <summary>
/// Information about the retention rule unlock delay. The unlock delay is the
/// period after which a retention rule can be modified or edited after it has
/// been unlocked by a user with the required permissions. The retention rule
/// can&apos;t be modified or deleted during the unlock delay.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecLockConfigurationUnlockDelay
{
    [JsonPropertyName("unlockDelayUnit")]
    public string? UnlockDelayUnit { get; set; }

    [JsonPropertyName("unlockDelayValue")]
    public long? UnlockDelayValue { get; set; }
}

/// <summary>Information about the retention rule lock configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecLockConfiguration
{
    /// <summary>
    /// Information about the retention rule unlock delay. The unlock delay is the
    /// period after which a retention rule can be modified or edited after it has
    /// been unlocked by a user with the required permissions. The retention rule
    /// can&apos;t be modified or deleted during the unlock delay.
    /// </summary>
    [JsonPropertyName("unlockDelay")]
    public V1alpha1RuleSpecLockConfigurationUnlockDelay? UnlockDelay { get; set; }
}

/// <summary>
/// [Tag-level retention rules only] Information about the resource tags used
/// to identify resources that are retained by the retention rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecResourceTags
{
    [JsonPropertyName("resourceTagKey")]
    public string? ResourceTagKey { get; set; }

    [JsonPropertyName("resourceTagValue")]
    public string? ResourceTagValue { get; set; }
}

/// <summary>
/// Information about the retention period for which the retention rule is to
/// retain resources.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecRetentionPeriod
{
    [JsonPropertyName("retentionPeriodUnit")]
    public string? RetentionPeriodUnit { get; set; }

    [JsonPropertyName("retentionPeriodValue")]
    public long? RetentionPeriodValue { get; set; }
}

/// <summary>Information about the tags to assign to the retention rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>RuleSpec defines the desired state of Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpec
{
    /// <summary>
    /// The retention rule description.
    /// 
    /// Regex Pattern: `^[\S ]{0,255}$`
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Information about the retention rule lock configuration.</summary>
    [JsonPropertyName("lockConfiguration")]
    public V1alpha1RuleSpecLockConfiguration? LockConfiguration { get; set; }

    /// <summary>
    /// [Tag-level retention rules only] Specifies the resource tags to use to identify
    /// resources that are to be retained by a tag-level retention rule. For tag-level
    /// retention rules, only deleted resources, of the specified resource type,
    /// that have one or more of the specified tag key and value pairs are retained.
    /// If a resource is deleted, but it does not have any of the specified tag key
    /// and value pairs, it is immediately deleted without being retained by the
    /// retention rule.
    /// 
    /// You can add the same tag key and value pair to a maximum or five retention
    /// rules.
    /// 
    /// To create a Region-level retention rule, omit this parameter. A Region-level
    /// retention rule does not have any resource tags specified. It retains all
    /// deleted resources of the specified resource type in the Region in which the
    /// rule is created, even if the resources are not tagged.
    /// </summary>
    [JsonPropertyName("resourceTags")]
    public IList<V1alpha1RuleSpecResourceTags>? ResourceTags { get; set; }

    /// <summary>
    /// The resource type to be retained by the retention rule. Currently, only Amazon
    /// EBS snapshots and EBS-backed AMIs are supported. To retain snapshots, specify
    /// EBS_SNAPSHOT. To retain EBS-backed AMIs, specify EC2_IMAGE.
    /// </summary>
    [JsonPropertyName("resourceType")]
    public required string ResourceType { get; set; }

    /// <summary>
    /// Information about the retention period for which the retention rule is to
    /// retain resources.
    /// </summary>
    [JsonPropertyName("retentionPeriod")]
    public required V1alpha1RuleSpecRetentionPeriod RetentionPeriod { get; set; }

    /// <summary>Information about the tags to assign to the retention rule.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1RuleSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleStatusAckResourceMetadata
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
public partial class V1alpha1RuleStatusConditions
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

/// <summary>RuleStatus defines the observed state of Rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1RuleStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RuleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The unique ID of the retention rule.
    /// 
    /// Regex Pattern: `^[0-9a-zA-Z]{11}$`
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    /// <summary>
    /// [Region-level retention rules only] The lock state for the retention rule.
    /// 
    ///    * locked - The retention rule is locked and can&apos;t be modified or deleted.
    /// 
    ///    * pending_unlock - The retention rule has been unlocked but it is still
    ///    within the unlock delay period. The retention rule can be modified or
    ///    deleted only after the unlock delay period has expired.
    /// 
    ///    * unlocked - The retention rule is unlocked and it can be modified or
    ///    deleted by any user with the required permissions.
    /// 
    ///    * null - The retention rule has never been locked. Once a retention rule
    ///    has been locked, it can transition between the locked and unlocked states
    ///    only; it can never transition back to null.
    /// </summary>
    [JsonPropertyName("lockState")]
    public string? LockState { get; set; }

    /// <summary>
    /// The state of the retention rule. Only retention rules that are in the available
    /// state retain resources.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Rule is the Schema for the Rules API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Rule : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1RuleSpec?>, IStatus<V1alpha1RuleStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Rule";
    public const string KubeGroup = "recyclebin.services.k8s.aws";
    public const string KubePluralName = "rules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "recyclebin.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Rule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RuleSpec defines the desired state of Rule.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1RuleSpec? Spec { get; set; }

    /// <summary>RuleStatus defines the observed state of Rule</summary>
    [JsonPropertyName("status")]
    public V1alpha1RuleStatus? Status { get; set; }
}
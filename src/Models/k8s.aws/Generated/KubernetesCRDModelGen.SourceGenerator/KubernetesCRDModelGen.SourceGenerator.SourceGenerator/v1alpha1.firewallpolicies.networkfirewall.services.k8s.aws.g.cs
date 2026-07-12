#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkfirewall.services.k8s.aws;
/// <summary>FirewallPolicy is the Schema for the FirewallPolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FirewallPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1FirewallPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FirewallPolicyList";
    public const string KubeGroup = "networkfirewall.services.k8s.aws";
    public const string KubePluralName = "firewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networkfirewall.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirewallPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1FirewallPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1FirewallPolicy> Items { get; set; }
}

/// <summary>
/// A complex type that contains settings for encryption of your firewall policy
/// resources.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicySpecEncryptionConfiguration
{
    [JsonPropertyName("keyID")]
    public string? KeyID { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>
/// A list of IP addresses and address ranges, in CIDR notation. This is part
/// of a RuleVariables.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicySpecFirewallPolicyPolicyVariablesRuleVariables
{
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}

/// <summary>
/// Contains variables that you can use to override default Suricata settings
/// in your firewall policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicySpecFirewallPolicyPolicyVariables
{
    [JsonPropertyName("ruleVariables")]
    public IDictionary<string, V1alpha1FirewallPolicySpecFirewallPolicyPolicyVariablesRuleVariables>? RuleVariables { get; set; }
}

/// <summary>
/// Configuration settings for the handling of the stateful rule groups in a
/// firewall policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicySpecFirewallPolicyStatefulEngineOptions
{
    [JsonPropertyName("ruleOrder")]
    public string? RuleOrder { get; set; }

    [JsonPropertyName("streamExceptionPolicy")]
    public string? StreamExceptionPolicy { get; set; }
}

/// <summary>
/// The setting that allows the policy owner to change the behavior of the rule
/// group within a policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicySpecFirewallPolicyStatefulRuleGroupReferencesOverride
{
    [JsonPropertyName("action")]
    public string? Action { get; set; }
}

/// <summary>
/// Identifier for a single stateful rule group, used in a firewall policy to
/// refer to a rule group.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicySpecFirewallPolicyStatefulRuleGroupReferences
{
    /// <summary>
    /// The setting that allows the policy owner to change the behavior of the rule
    /// group within a policy.
    /// </summary>
    [JsonPropertyName("override")]
    public V1alpha1FirewallPolicySpecFirewallPolicyStatefulRuleGroupReferencesOverride? Override { get; set; }

    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    [JsonPropertyName("resourceARN")]
    public string? ResourceARN { get; set; }
}

/// <summary>
/// The value to use in an Amazon CloudWatch custom metric dimension. This is
/// used in the PublishMetrics CustomAction. A CloudWatch custom metric dimension
/// is a name/value pair that&apos;s part of the identity of a metric.
/// 
/// Network Firewall sets the dimension name to CustomAction and you provide
/// the dimension value.
/// 
/// For more information about CloudWatch custom metric dimensions, see Publishing
/// Custom Metrics (https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/publishingMetrics.html#usingDimensions)
/// in the Amazon CloudWatch User Guide (https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/WhatIsCloudWatch.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicySpecFirewallPolicyStatelessCustomActionsActionDefinitionPublishMetricActionDimensions
{
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Stateless inspection criteria that publishes the specified metrics to Amazon
/// CloudWatch for the matching packet. This setting defines a CloudWatch dimension
/// value to be published.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicySpecFirewallPolicyStatelessCustomActionsActionDefinitionPublishMetricAction
{
    [JsonPropertyName("dimensions")]
    public IList<V1alpha1FirewallPolicySpecFirewallPolicyStatelessCustomActionsActionDefinitionPublishMetricActionDimensions>? Dimensions { get; set; }
}

/// <summary>
/// A custom action to use in stateless rule actions settings. This is used in
/// CustomAction.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicySpecFirewallPolicyStatelessCustomActionsActionDefinition
{
    /// <summary>
    /// Stateless inspection criteria that publishes the specified metrics to Amazon
    /// CloudWatch for the matching packet. This setting defines a CloudWatch dimension
    /// value to be published.
    /// </summary>
    [JsonPropertyName("publishMetricAction")]
    public V1alpha1FirewallPolicySpecFirewallPolicyStatelessCustomActionsActionDefinitionPublishMetricAction? PublishMetricAction { get; set; }
}

/// <summary>
/// An optional, non-standard action to use for stateless packet handling. You
/// can define this in addition to the standard action that you must specify.
/// 
/// You define and name the custom actions that you want to be able to use, and
/// then you reference them by name in your actions settings.
/// 
/// You can use custom actions in the following places:
/// 
///   - In a rule group&apos;s StatelessRulesAndCustomActions specification. The
///     custom actions are available for use by name inside the StatelessRulesAndCustomActions
///     where you define them. You can use them for your stateless rule actions
///     to specify what to do with a packet that matches the rule&apos;s match attributes.
/// 
///   - In a FirewallPolicy specification, in StatelessCustomActions. The custom
///     actions are available for use inside the policy where you define them.
///     You can use them for the policy&apos;s default stateless actions settings to
///     specify what to do with packets that don&apos;t match any of the policy&apos;s stateless
///     rules.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicySpecFirewallPolicyStatelessCustomActions
{
    /// <summary>
    /// A custom action to use in stateless rule actions settings. This is used in
    /// CustomAction.
    /// </summary>
    [JsonPropertyName("actionDefinition")]
    public V1alpha1FirewallPolicySpecFirewallPolicyStatelessCustomActionsActionDefinition? ActionDefinition { get; set; }

    [JsonPropertyName("actionName")]
    public string? ActionName { get; set; }
}

/// <summary>
/// Identifier for a single stateless rule group, used in a firewall policy to
/// refer to the rule group.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicySpecFirewallPolicyStatelessRuleGroupReferences
{
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    [JsonPropertyName("resourceARN")]
    public string? ResourceARN { get; set; }
}

/// <summary>The rule groups and policy actions to use in the firewall policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicySpecFirewallPolicy
{
    /// <summary>
    /// Contains variables that you can use to override default Suricata settings
    /// in your firewall policy.
    /// </summary>
    [JsonPropertyName("policyVariables")]
    public V1alpha1FirewallPolicySpecFirewallPolicyPolicyVariables? PolicyVariables { get; set; }

    [JsonPropertyName("statefulDefaultActions")]
    public IList<string>? StatefulDefaultActions { get; set; }

    /// <summary>
    /// Configuration settings for the handling of the stateful rule groups in a
    /// firewall policy.
    /// </summary>
    [JsonPropertyName("statefulEngineOptions")]
    public V1alpha1FirewallPolicySpecFirewallPolicyStatefulEngineOptions? StatefulEngineOptions { get; set; }

    [JsonPropertyName("statefulRuleGroupReferences")]
    public IList<V1alpha1FirewallPolicySpecFirewallPolicyStatefulRuleGroupReferences>? StatefulRuleGroupReferences { get; set; }

    [JsonPropertyName("statelessCustomActions")]
    public IList<V1alpha1FirewallPolicySpecFirewallPolicyStatelessCustomActions>? StatelessCustomActions { get; set; }

    [JsonPropertyName("statelessDefaultActions")]
    public IList<string>? StatelessDefaultActions { get; set; }

    [JsonPropertyName("statelessFragmentDefaultActions")]
    public IList<string>? StatelessFragmentDefaultActions { get; set; }

    [JsonPropertyName("statelessRuleGroupReferences")]
    public IList<V1alpha1FirewallPolicySpecFirewallPolicyStatelessRuleGroupReferences>? StatelessRuleGroupReferences { get; set; }

    [JsonPropertyName("tlsInspectionConfigurationARN")]
    public string? TlsInspectionConfigurationARN { get; set; }
}

/// <summary>
/// A key:value pair associated with an Amazon Web Services resource. The key:value
/// pair can be anything you define. Typically, the tag key represents a category
/// (such as &quot;environment&quot;) and the tag value represents a specific value within
/// that category (such as &quot;test,&quot; &quot;development,&quot; or &quot;production&quot;). You can add
/// up to 50 tags to each Amazon Web Services resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicySpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// FirewallPolicySpec defines the desired state of FirewallPolicy.
/// 
/// The firewall policy defines the behavior of a firewall using a collection
/// of stateless and stateful rule groups and other settings. You can use one
/// firewall policy for multiple firewalls.
/// 
/// This, along with FirewallPolicyResponse, define the policy. You can retrieve
/// all objects for a firewall policy by calling DescribeFirewallPolicy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicySpec
{
    /// <summary>
    /// A description of the firewall policy.
    /// 
    /// Regex Pattern: `^.*$`
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// A complex type that contains settings for encryption of your firewall policy
    /// resources.
    /// </summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1alpha1FirewallPolicySpecEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>The rule groups and policy actions to use in the firewall policy.</summary>
    [JsonPropertyName("firewallPolicy")]
    public required V1alpha1FirewallPolicySpecFirewallPolicy FirewallPolicy { get; set; }

    /// <summary>
    /// The descriptive name of the firewall policy. You can&apos;t change the name of
    /// a firewall policy after you create it.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9-]+$`
    /// </summary>
    [JsonPropertyName("firewallPolicyName")]
    public required string FirewallPolicyName { get; set; }

    /// <summary>The key:value pairs to associate with the resource.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1FirewallPolicySpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicyStatusAckResourceMetadata
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
public partial class V1alpha1FirewallPolicyStatusConditions
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
/// A complex type that contains optional Amazon Web Services Key Management
/// Service (KMS) encryption settings for your Network Firewall resources. Your
/// data is encrypted by default with an Amazon Web Services owned key that Amazon
/// Web Services owns and manages for you. You can use either the Amazon Web
/// Services owned key, or provide your own customer managed key. To learn more
/// about KMS encryption of your Network Firewall resources, see Encryption at
/// rest with Amazon Web Services Key Managment Service (https://docs.aws.amazon.com/kms/latest/developerguide/kms-encryption-at-rest.html)
/// in the Network Firewall Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicyStatusFirewallPolicyResponseEncryptionConfiguration
{
    [JsonPropertyName("keyID")]
    public string? KeyID { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>
/// A key:value pair associated with an Amazon Web Services resource. The key:value
/// pair can be anything you define. Typically, the tag key represents a category
/// (such as &quot;environment&quot;) and the tag value represents a specific value within
/// that category (such as &quot;test,&quot; &quot;development,&quot; or &quot;production&quot;). You can add
/// up to 50 tags to each Amazon Web Services resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicyStatusFirewallPolicyResponseTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The high-level properties of a firewall policy. This, along with the FirewallPolicy,
/// define the policy. You can retrieve all objects for a firewall policy by
/// calling DescribeFirewallPolicy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicyStatusFirewallPolicyResponse
{
    [JsonPropertyName("consumedStatefulRuleCapacity")]
    public long? ConsumedStatefulRuleCapacity { get; set; }

    [JsonPropertyName("consumedStatelessRuleCapacity")]
    public long? ConsumedStatelessRuleCapacity { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// A complex type that contains optional Amazon Web Services Key Management
    /// Service (KMS) encryption settings for your Network Firewall resources. Your
    /// data is encrypted by default with an Amazon Web Services owned key that Amazon
    /// Web Services owns and manages for you. You can use either the Amazon Web
    /// Services owned key, or provide your own customer managed key. To learn more
    /// about KMS encryption of your Network Firewall resources, see Encryption at
    /// rest with Amazon Web Services Key Managment Service (https://docs.aws.amazon.com/kms/latest/developerguide/kms-encryption-at-rest.html)
    /// in the Network Firewall Developer Guide.
    /// </summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1alpha1FirewallPolicyStatusFirewallPolicyResponseEncryptionConfiguration? EncryptionConfiguration { get; set; }

    [JsonPropertyName("firewallPolicyARN")]
    public string? FirewallPolicyARN { get; set; }

    [JsonPropertyName("firewallPolicyID")]
    public string? FirewallPolicyID { get; set; }

    [JsonPropertyName("firewallPolicyName")]
    public string? FirewallPolicyName { get; set; }

    [JsonPropertyName("firewallPolicyStatus")]
    public string? FirewallPolicyStatus { get; set; }

    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    [JsonPropertyName("numberOfAssociations")]
    public long? NumberOfAssociations { get; set; }

    [JsonPropertyName("tags")]
    public IList<V1alpha1FirewallPolicyStatusFirewallPolicyResponseTags>? Tags { get; set; }
}

/// <summary>FirewallPolicyStatus defines the observed state of FirewallPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallPolicyStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1FirewallPolicyStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1FirewallPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The high-level properties of a firewall policy. This, along with the FirewallPolicy,
    /// define the policy. You can retrieve all objects for a firewall policy by
    /// calling DescribeFirewallPolicy.
    /// </summary>
    [JsonPropertyName("firewallPolicyResponse")]
    public V1alpha1FirewallPolicyStatusFirewallPolicyResponse? FirewallPolicyResponse { get; set; }

    /// <summary>
    /// A token used for optimistic locking. Network Firewall returns a token to
    /// your requests that access the firewall policy. The token marks the state
    /// of the policy resource at the time of the request.
    /// 
    /// To make changes to the policy, you provide the token in your request. Network
    /// Firewall uses the token to ensure that the policy hasn&apos;t changed since you
    /// last retrieved it. If it has changed, the operation fails with an InvalidTokenException.
    /// If this happens, retrieve the firewall policy again to get a current copy
    /// of it with current token. Reapply your changes as needed, then try the operation
    /// again using the new token.
    /// 
    /// Regex Pattern: `^([0-9a-f]{8})-([0-9a-f]{4}-){3}([0-9a-f]{12})$`
    /// </summary>
    [JsonPropertyName("updateToken")]
    public string? UpdateToken { get; set; }
}

/// <summary>FirewallPolicy is the Schema for the FirewallPolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FirewallPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1FirewallPolicySpec?>, IStatus<V1alpha1FirewallPolicyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FirewallPolicy";
    public const string KubeGroup = "networkfirewall.services.k8s.aws";
    public const string KubePluralName = "firewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networkfirewall.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirewallPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// FirewallPolicySpec defines the desired state of FirewallPolicy.
    /// 
    /// The firewall policy defines the behavior of a firewall using a collection
    /// of stateless and stateful rule groups and other settings. You can use one
    /// firewall policy for multiple firewalls.
    /// 
    /// This, along with FirewallPolicyResponse, define the policy. You can retrieve
    /// all objects for a firewall policy by calling DescribeFirewallPolicy.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1FirewallPolicySpec? Spec { get; set; }

    /// <summary>FirewallPolicyStatus defines the observed state of FirewallPolicy</summary>
    [JsonPropertyName("status")]
    public V1alpha1FirewallPolicyStatus? Status { get; set; }
}
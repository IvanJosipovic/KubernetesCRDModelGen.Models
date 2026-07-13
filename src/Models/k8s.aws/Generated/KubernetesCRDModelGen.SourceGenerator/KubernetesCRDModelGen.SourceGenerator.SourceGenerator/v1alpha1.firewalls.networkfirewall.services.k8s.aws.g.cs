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
/// <summary>Firewall is the Schema for the Firewalls API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FirewallList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Firewall>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FirewallList";
    public const string KubeGroup = "networkfirewall.services.k8s.aws";
    public const string KubePluralName = "firewalls";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networkfirewall.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirewallList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Firewall objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Firewall> Items { get; set; }
}

/// <summary>A complex type that contains settings for encryption of your firewall resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallSpecEncryptionConfiguration
{
    [JsonPropertyName("keyID")]
    public string? KeyID { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>
/// Defines where Network Firewall sends logs for the firewall for one log type.
/// This is used in LoggingConfiguration. You can send each type of log to an
/// Amazon S3 bucket, a CloudWatch log group, or a Firehose delivery stream.
/// 
/// Network Firewall generates logs for stateful rule groups. You can save alert,
/// flow, and TLS log types.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallSpecLoggingConfigurationLogDestinationConfigs
{
    [JsonPropertyName("logDestination")]
    public IDictionary<string, string>? LogDestination { get; set; }

    [JsonPropertyName("logDestinationType")]
    public string? LogDestinationType { get; set; }

    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

/// <summary>
/// Defines how Network Firewall performs logging for a firewall. If you omit
/// this setting, Network Firewall disables logging for the firewall.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallSpecLoggingConfiguration
{
    [JsonPropertyName("logDestinationConfigs")]
    public IList<V1alpha1FirewallSpecLoggingConfigurationLogDestinationConfigs>? LogDestinationConfigs { get; set; }
}

/// <summary>
/// The ID for a subnet that you want to associate with the firewall. This is
/// used with CreateFirewall and AssociateSubnets. Network Firewall creates an
/// instance of the associated firewall in each subnet that you specify, to filter
/// traffic in the subnet&apos;s Availability Zone.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallSpecSubnetMappings
{
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    [JsonPropertyName("subnetID")]
    public string? SubnetID { get; set; }
}

/// <summary>
/// A key:value pair associated with an Amazon Web Services resource. The key:value
/// pair can be anything you define. Typically, the tag key represents a category
/// (such as &quot;environment&quot;) and the tag value represents a specific value within
/// that category (such as &quot;test,&quot; &quot;development,&quot; or &quot;production&quot;). You can add
/// up to 50 tags to each Amazon Web Services resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// FirewallSpec defines the desired state of Firewall.
/// 
/// The firewall defines the configuration settings for an Network Firewall firewall.
/// These settings include the firewall policy, the subnets in your VPC to use
/// for the firewall endpoints, and any tags that are attached to the firewall
/// Amazon Web Services resource.
/// 
/// The status of the firewall, for example whether it&apos;s ready to filter network
/// traffic, is provided in the corresponding FirewallStatus. You can retrieve
/// both objects by calling DescribeFirewall.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallSpec
{
    /// <summary>
    /// A flag indicating whether it is possible to delete the firewall. A setting
    /// of TRUE indicates that the firewall is protected against deletion. Use this
    /// setting to protect against accidentally deleting a firewall that is in use.
    /// When you create a firewall, the operation initializes this flag to TRUE.
    /// </summary>
    [JsonPropertyName("deleteProtection")]
    public bool? DeleteProtection { get; set; }

    /// <summary>
    /// A description of the firewall.
    /// 
    /// Regex Pattern: `^.*$`
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A complex type that contains settings for encryption of your firewall resources.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1alpha1FirewallSpecEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>
    /// The descriptive name of the firewall. You can&apos;t change the name of a firewall
    /// after you create it.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9-]+$`
    /// </summary>
    [JsonPropertyName("firewallName")]
    public required string FirewallName { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the FirewallPolicy that you want to use
    /// for the firewall.
    /// 
    /// Regex Pattern: `^arn:aws`
    /// </summary>
    [JsonPropertyName("firewallPolicyARN")]
    public required string FirewallPolicyARN { get; set; }

    /// <summary>
    /// A setting indicating whether the firewall is protected against a change to
    /// the firewall policy association. Use this setting to protect against accidentally
    /// modifying the firewall policy for a firewall that is in use. When you create
    /// a firewall, the operation initializes this setting to TRUE.
    /// </summary>
    [JsonPropertyName("firewallPolicyChangeProtection")]
    public bool? FirewallPolicyChangeProtection { get; set; }

    /// <summary>
    /// Defines how Network Firewall performs logging for a firewall. If you omit
    /// this setting, Network Firewall disables logging for the firewall.
    /// </summary>
    [JsonPropertyName("loggingConfiguration")]
    public V1alpha1FirewallSpecLoggingConfiguration? LoggingConfiguration { get; set; }

    /// <summary>
    /// A setting indicating whether the firewall is protected against changes to
    /// the subnet associations. Use this setting to protect against accidentally
    /// modifying the subnet associations for a firewall that is in use. When you
    /// create a firewall, the operation initializes this setting to TRUE.
    /// </summary>
    [JsonPropertyName("subnetChangeProtection")]
    public bool? SubnetChangeProtection { get; set; }

    /// <summary>
    /// The public subnets to use for your Network Firewall firewalls. Each subnet
    /// must belong to a different Availability Zone in the VPC. Network Firewall
    /// creates a firewall endpoint in each subnet.
    /// </summary>
    [JsonPropertyName("subnetMappings")]
    public required IList<V1alpha1FirewallSpecSubnetMappings> SubnetMappings { get; set; }

    /// <summary>The key:value pairs to associate with the resource.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1FirewallSpecTags>? Tags { get; set; }

    /// <summary>
    /// The unique identifier of the VPC where Network Firewall should create the
    /// firewall.
    /// 
    /// You can&apos;t change this setting after you create the firewall.
    /// 
    /// Regex Pattern: `^vpc-[0-9a-f]+$`
    /// </summary>
    [JsonPropertyName("vpcID")]
    public required string VpcID { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallStatusAckResourceMetadata
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
public partial class V1alpha1FirewallStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallStatusFirewallEncryptionConfiguration
{
    [JsonPropertyName("keyID")]
    public string? KeyID { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>
/// The ID for a subnet that you want to associate with the firewall. This is
/// used with CreateFirewall and AssociateSubnets. Network Firewall creates an
/// instance of the associated firewall in each subnet that you specify, to filter
/// traffic in the subnet&apos;s Availability Zone.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallStatusFirewallSubnetMappings
{
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    [JsonPropertyName("subnetID")]
    public string? SubnetID { get; set; }
}

/// <summary>
/// A key:value pair associated with an Amazon Web Services resource. The key:value
/// pair can be anything you define. Typically, the tag key represents a category
/// (such as &quot;environment&quot;) and the tag value represents a specific value within
/// that category (such as &quot;test,&quot; &quot;development,&quot; or &quot;production&quot;). You can add
/// up to 50 tags to each Amazon Web Services resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallStatusFirewallTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The configuration settings for the firewall. These settings include the firewall
/// policy and the subnets in your VPC to use for the firewall endpoints.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallStatusFirewall
{
    [JsonPropertyName("deleteProtection")]
    public bool? DeleteProtection { get; set; }

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
    public V1alpha1FirewallStatusFirewallEncryptionConfiguration? EncryptionConfiguration { get; set; }

    [JsonPropertyName("firewallARN")]
    public string? FirewallARN { get; set; }

    [JsonPropertyName("firewallID")]
    public string? FirewallID { get; set; }

    [JsonPropertyName("firewallName")]
    public string? FirewallName { get; set; }

    [JsonPropertyName("firewallPolicyARN")]
    public string? FirewallPolicyARN { get; set; }

    [JsonPropertyName("firewallPolicyChangeProtection")]
    public bool? FirewallPolicyChangeProtection { get; set; }

    [JsonPropertyName("subnetChangeProtection")]
    public bool? SubnetChangeProtection { get; set; }

    [JsonPropertyName("subnetMappings")]
    public IList<V1alpha1FirewallStatusFirewallSubnetMappings>? SubnetMappings { get; set; }

    [JsonPropertyName("tags")]
    public IList<V1alpha1FirewallStatusFirewallTags>? Tags { get; set; }

    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }
}

/// <summary>General information about the IP set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallStatusFirewallStatusCapacityUsageSummaryCidrsIpSetReferences
{
    [JsonPropertyName("resolvedCIDRCount")]
    public long? ResolvedCIDRCount { get; set; }
}

/// <summary>
/// Summarizes the CIDR blocks used by the IP set references in a firewall. Network
/// Firewall calculates the number of CIDRs by taking an aggregated count of
/// all CIDRs used by the IP sets you are referencing.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallStatusFirewallStatusCapacityUsageSummaryCidrs
{
    [JsonPropertyName("availableCIDRCount")]
    public long? AvailableCIDRCount { get; set; }

    [JsonPropertyName("ipSetReferences")]
    public IDictionary<string, V1alpha1FirewallStatusFirewallStatusCapacityUsageSummaryCidrsIpSetReferences>? IpSetReferences { get; set; }

    [JsonPropertyName("utilizedCIDRCount")]
    public long? UtilizedCIDRCount { get; set; }
}

/// <summary>
/// The capacity usage summary of the resources used by the ReferenceSets in
/// a firewall.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallStatusFirewallStatusCapacityUsageSummary
{
    /// <summary>
    /// Summarizes the CIDR blocks used by the IP set references in a firewall. Network
    /// Firewall calculates the number of CIDRs by taking an aggregated count of
    /// all CIDRs used by the IP sets you are referencing.
    /// </summary>
    [JsonPropertyName("cidrs")]
    public V1alpha1FirewallStatusFirewallStatusCapacityUsageSummaryCidrs? Cidrs { get; set; }
}

/// <summary>
/// The configuration and status for a single subnet that you&apos;ve specified for
/// use by the Network Firewall firewall. This is part of the FirewallStatus.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallStatusFirewallStatusSyncStatesAttachment
{
    [JsonPropertyName("endpointID")]
    public string? EndpointID { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }

    [JsonPropertyName("subnetID")]
    public string? SubnetID { get; set; }
}

/// <summary>
/// Provides configuration status for a single policy or rule group that is used
/// for a firewall endpoint. Network Firewall provides each endpoint with the
/// rules that are configured in the firewall policy. Each time you add a subnet
/// or modify the associated firewall policy, Network Firewall synchronizes the
/// rules in the endpoint, so it can properly filter network traffic. This is
/// part of a SyncState for a firewall.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallStatusFirewallStatusSyncStatesConfig
{
    [JsonPropertyName("syncStatus")]
    public string? SyncStatus { get; set; }

    [JsonPropertyName("updateToken")]
    public string? UpdateToken { get; set; }
}

/// <summary>
/// The status of the firewall endpoint and firewall policy configuration for
/// a single VPC subnet.
/// 
/// For each VPC subnet that you associate with a firewall, Network Firewall
/// does the following:
/// 
///   - Instantiates a firewall endpoint in the subnet, ready to take traffic.
/// 
///   - Configures the endpoint with the current firewall policy settings, to
///     provide the filtering behavior for the endpoint.
/// 
/// When you update a firewall, for example to add a subnet association or change
/// a rule group in the firewall policy, the affected sync states reflect out-of-sync
/// or not ready status until the changes are complete.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallStatusFirewallStatusSyncStates
{
    /// <summary>
    /// The configuration and status for a single subnet that you&apos;ve specified for
    /// use by the Network Firewall firewall. This is part of the FirewallStatus.
    /// </summary>
    [JsonPropertyName("attachment")]
    public V1alpha1FirewallStatusFirewallStatusSyncStatesAttachment? Attachment { get; set; }

    [JsonPropertyName("config")]
    public IDictionary<string, V1alpha1FirewallStatusFirewallStatusSyncStatesConfig>? Config { get; set; }
}

/// <summary>
/// Detailed information about the current status of a Firewall. You can retrieve
/// this for a firewall by calling DescribeFirewall and providing the firewall
/// name and ARN.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallStatusFirewallStatus
{
    /// <summary>
    /// The capacity usage summary of the resources used by the ReferenceSets in
    /// a firewall.
    /// </summary>
    [JsonPropertyName("capacityUsageSummary")]
    public V1alpha1FirewallStatusFirewallStatusCapacityUsageSummary? CapacityUsageSummary { get; set; }

    [JsonPropertyName("configurationSyncStateSummary")]
    public string? ConfigurationSyncStateSummary { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("syncStates")]
    public IDictionary<string, V1alpha1FirewallStatusFirewallStatusSyncStates>? SyncStates { get; set; }
}

/// <summary>FirewallStatus defines the observed state of Firewall</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirewallStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1FirewallStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1FirewallStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The configuration settings for the firewall. These settings include the firewall
    /// policy and the subnets in your VPC to use for the firewall endpoints.
    /// </summary>
    [JsonPropertyName("firewall")]
    public V1alpha1FirewallStatusFirewall? Firewall { get; set; }

    /// <summary>
    /// Detailed information about the current status of a Firewall. You can retrieve
    /// this for a firewall by calling DescribeFirewall and providing the firewall
    /// name and ARN.
    /// </summary>
    [JsonPropertyName("firewallStatus")]
    public V1alpha1FirewallStatusFirewallStatus? FirewallStatus { get; set; }
}

/// <summary>Firewall is the Schema for the Firewalls API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Firewall : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1FirewallSpec?>, IStatus<V1alpha1FirewallStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Firewall";
    public const string KubeGroup = "networkfirewall.services.k8s.aws";
    public const string KubePluralName = "firewalls";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networkfirewall.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Firewall";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// FirewallSpec defines the desired state of Firewall.
    /// 
    /// The firewall defines the configuration settings for an Network Firewall firewall.
    /// These settings include the firewall policy, the subnets in your VPC to use
    /// for the firewall endpoints, and any tags that are attached to the firewall
    /// Amazon Web Services resource.
    /// 
    /// The status of the firewall, for example whether it&apos;s ready to filter network
    /// traffic, is provided in the corresponding FirewallStatus. You can retrieve
    /// both objects by calling DescribeFirewall.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1FirewallSpec? Spec { get; set; }

    /// <summary>FirewallStatus defines the observed state of Firewall</summary>
    [JsonPropertyName("status")]
    public V1alpha1FirewallStatus? Status { get; set; }
}
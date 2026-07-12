#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.mq.services.k8s.aws;
/// <summary>Broker is the Schema for the Brokers API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BrokerList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Broker>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BrokerList";
    public const string KubeGroup = "mq.services.k8s.aws";
    public const string KubePluralName = "brokers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "mq.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BrokerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Broker objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Broker> Items { get; set; }
}

/// <summary>A list of information about the configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BrokerSpecConfiguration
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("revision")]
    public long? Revision { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BrokerSpecEncryptionOptionsKmsKeyRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for KMSKeyID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BrokerSpecEncryptionOptionsKmsKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1BrokerSpecEncryptionOptionsKmsKeyRefFrom? From { get; set; }
}

/// <summary>Encryption options for the broker.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BrokerSpecEncryptionOptions
{
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    /// <summary>Reference field for KMSKeyID</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1BrokerSpecEncryptionOptionsKmsKeyRef? KmsKeyRef { get; set; }

    [JsonPropertyName("useAWSOwnedKey")]
    public bool? UseAWSOwnedKey { get; set; }
}

/// <summary>
/// Optional. The metadata of the LDAP server used to authenticate and authorize
/// connections to the broker. Does not apply to RabbitMQ brokers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BrokerSpecLdapServerMetadata
{
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    [JsonPropertyName("roleBase")]
    public string? RoleBase { get; set; }

    [JsonPropertyName("roleName")]
    public string? RoleName { get; set; }

    [JsonPropertyName("roleSearchMatching")]
    public string? RoleSearchMatching { get; set; }

    [JsonPropertyName("roleSearchSubtree")]
    public bool? RoleSearchSubtree { get; set; }

    [JsonPropertyName("serviceAccountPassword")]
    public string? ServiceAccountPassword { get; set; }

    [JsonPropertyName("serviceAccountUsername")]
    public string? ServiceAccountUsername { get; set; }

    [JsonPropertyName("userBase")]
    public string? UserBase { get; set; }

    [JsonPropertyName("userRoleName")]
    public string? UserRoleName { get; set; }

    [JsonPropertyName("userSearchMatching")]
    public string? UserSearchMatching { get; set; }

    [JsonPropertyName("userSearchSubtree")]
    public bool? UserSearchSubtree { get; set; }
}

/// <summary>Enables Amazon CloudWatch logging for brokers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BrokerSpecLogs
{
    [JsonPropertyName("audit")]
    public bool? Audit { get; set; }

    [JsonPropertyName("general")]
    public bool? General { get; set; }
}

/// <summary>The parameters that determine the WeeklyStartTime.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BrokerSpecMaintenanceWindowStartTime
{
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    [JsonPropertyName("timeOfDay")]
    public string? TimeOfDay { get; set; }

    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BrokerSpecSecurityGroupRefsFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BrokerSpecSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1BrokerSpecSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BrokerSpecSubnetRefsFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BrokerSpecSubnetRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1BrokerSpecSubnetRefsFrom? From { get; set; }
}

/// <summary>
/// SecretKeyReference combines a k8s corev1.SecretReference with a
/// specific key within the referred-to Secret
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BrokerSpecUsersPassword
{
    /// <summary>Key is the key within the secret</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>name is unique within a namespace to reference a secret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>namespace defines the space within which the secret name must be unique.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// A user associated with the broker. For Amazon MQ for RabbitMQ brokers, one
/// and only one administrative user is accepted and created when a broker is
/// first provisioned. All subsequent broker users are created by making RabbitMQ
/// API calls directly to brokers or via the RabbitMQ web console.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BrokerSpecUsers
{
    [JsonPropertyName("consoleAccess")]
    public bool? ConsoleAccess { get; set; }

    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>
    /// SecretKeyReference combines a k8s corev1.SecretReference with a
    /// specific key within the referred-to Secret
    /// </summary>
    [JsonPropertyName("password")]
    public V1alpha1BrokerSpecUsersPassword? Password { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>BrokerSpec defines the desired state of Broker.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BrokerSpec
{
    /// <summary>
    /// Optional. The authentication strategy used to secure the broker. The default
    /// is SIMPLE.
    /// </summary>
    [JsonPropertyName("authenticationStrategy")]
    public string? AuthenticationStrategy { get; set; }

    /// <summary>
    /// Enables automatic upgrades to new patch versions for brokers as new versions
    /// are released and supported by Amazon MQ. Automatic upgrades occur during
    /// the scheduled maintenance window or after a manual broker reboot. Set to
    /// true by default, if no value is specified.
    /// 
    /// Must be set to true for ActiveMQ brokers version 5.18 and above and for RabbitMQ
    /// brokers version 3.13 and above.
    /// </summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary>A list of information about the configuration.</summary>
    [JsonPropertyName("configuration")]
    public V1alpha1BrokerSpecConfiguration? Configuration { get; set; }

    /// <summary>
    /// The unique ID that the requester receives for the created broker. Amazon
    /// MQ passes your ID with the API action.
    /// 
    /// We recommend using a Universally Unique Identifier (UUID) for the creatorRequestId.
    /// You may omit the creatorRequestId if your application doesn&apos;t require idempotency.
    /// </summary>
    [JsonPropertyName("creatorRequestID")]
    public string? CreatorRequestID { get; set; }

    /// <summary>Required. The broker&apos;s deployment mode.</summary>
    [JsonPropertyName("deploymentMode")]
    public required string DeploymentMode { get; set; }

    /// <summary>Encryption options for the broker.</summary>
    [JsonPropertyName("encryptionOptions")]
    public V1alpha1BrokerSpecEncryptionOptions? EncryptionOptions { get; set; }

    /// <summary>
    /// Required. The type of broker engine. Currently, Amazon MQ supports ACTIVEMQ
    /// and RABBITMQ.
    /// </summary>
    [JsonPropertyName("engineType")]
    public required string EngineType { get; set; }

    /// <summary>
    /// The broker engine version. Defaults to the latest available version for the
    /// specified broker engine type. For more information, see the ActiveMQ version
    /// management (https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/activemq-version-management.html)
    /// and the RabbitMQ version management (https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/rabbitmq-version-management.html)
    /// sections in the Amazon MQ Developer Guide.
    /// </summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>Required. The broker&apos;s instance type.</summary>
    [JsonPropertyName("hostInstanceType")]
    public required string HostInstanceType { get; set; }

    /// <summary>
    /// Optional. The metadata of the LDAP server used to authenticate and authorize
    /// connections to the broker. Does not apply to RabbitMQ brokers.
    /// </summary>
    [JsonPropertyName("ldapServerMetadata")]
    public V1alpha1BrokerSpecLdapServerMetadata? LdapServerMetadata { get; set; }

    /// <summary>Enables Amazon CloudWatch logging for brokers.</summary>
    [JsonPropertyName("logs")]
    public V1alpha1BrokerSpecLogs? Logs { get; set; }

    /// <summary>The parameters that determine the WeeklyStartTime.</summary>
    [JsonPropertyName("maintenanceWindowStartTime")]
    public V1alpha1BrokerSpecMaintenanceWindowStartTime? MaintenanceWindowStartTime { get; set; }

    /// <summary>
    /// Required. The broker&apos;s name. This value must be unique in your Amazon Web
    /// Services account, 1-50 characters long, must contain only letters, numbers,
    /// dashes, and underscores, and must not contain white spaces, brackets, wildcard
    /// characters, or special characters.
    /// 
    /// Do not add personally identifiable information (PII) or other confidential
    /// or sensitive information in broker names. Broker names are accessible to
    /// other Amazon Web Services services, including CloudWatch Logs. Broker names
    /// are not intended to be used for private or sensitive data.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Enables connections from applications outside of the VPC that hosts the broker&apos;s
    /// subnets. Set to false by default, if no value is provided.
    /// </summary>
    [JsonPropertyName("publiclyAccessible")]
    public required bool PubliclyAccessible { get; set; }

    [JsonPropertyName("securityGroupRefs")]
    public IList<V1alpha1BrokerSpecSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>
    /// The list of rules (1 minimum, 125 maximum) that authorize connections to
    /// brokers.
    /// </summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The broker&apos;s storage type.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>
    /// The list of groups that define which subnets and IP ranges the broker can
    /// use from different Availability Zones. If you specify more than one subnet,
    /// the subnets must be in different Availability Zones. Amazon MQ will not be
    /// able to create VPC endpoints for your broker with multiple subnets in the
    /// same Availability Zone. A SINGLE_INSTANCE deployment requires one subnet
    /// (for example, the default subnet). An ACTIVE_STANDBY_MULTI_AZ Amazon MQ for
    /// ActiveMQ deployment requires two subnets. A CLUSTER_MULTI_AZ Amazon MQ for
    /// RabbitMQ deployment has no subnet requirements when deployed with public
    /// accessibility. Deployment without public accessibility requires at least
    /// one subnet.
    /// 
    /// If you specify subnets in a shared VPC (https://docs.aws.amazon.com/vpc/latest/userguide/vpc-sharing.html)
    /// for a RabbitMQ broker, the associated VPC to which the specified subnets
    /// belong must be owned by your Amazon Web Services account. Amazon MQ will
    /// not be able to create VPC endpoints in VPCs that are not owned by your Amazon
    /// Web Services account.
    /// </summary>
    [JsonPropertyName("subnetIDs")]
    public IList<string>? SubnetIDs { get; set; }

    [JsonPropertyName("subnetRefs")]
    public IList<V1alpha1BrokerSpecSubnetRefs>? SubnetRefs { get; set; }

    /// <summary>Create tags when creating the broker.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The list of broker users (persons or applications) who can access queues
    /// and topics. For Amazon MQ for RabbitMQ brokers, one and only one administrative
    /// user is accepted and created when a broker is first provisioned. All subsequent
    /// broker users are created by making RabbitMQ API calls directly to brokers
    /// or via the RabbitMQ web console.
    /// </summary>
    [JsonPropertyName("users")]
    public required IList<V1alpha1BrokerSpecUsers> Users { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BrokerStatusAckResourceMetadata
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

/// <summary>Returns information about all brokers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BrokerStatusBrokerInstances
{
    [JsonPropertyName("consoleURL")]
    public string? ConsoleURL { get; set; }

    [JsonPropertyName("endpoints")]
    public IList<string>? Endpoints { get; set; }

    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BrokerStatusConditions
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

/// <summary>BrokerStatus defines the observed state of Broker</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BrokerStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1BrokerStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>The unique ID that Amazon MQ generates for the broker.</summary>
    [JsonPropertyName("brokerID")]
    public string? BrokerID { get; set; }

    /// <summary>A list of information about allocated brokers.</summary>
    [JsonPropertyName("brokerInstances")]
    public IList<V1alpha1BrokerStatusBrokerInstances>? BrokerInstances { get; set; }

    /// <summary>The broker&apos;s status.</summary>
    [JsonPropertyName("brokerState")]
    public string? BrokerState { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BrokerStatusConditions>? Conditions { get; set; }
}

/// <summary>Broker is the Schema for the Brokers API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Broker : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BrokerSpec?>, IStatus<V1alpha1BrokerStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Broker";
    public const string KubeGroup = "mq.services.k8s.aws";
    public const string KubePluralName = "brokers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "mq.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Broker";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BrokerSpec defines the desired state of Broker.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BrokerSpec? Spec { get; set; }

    /// <summary>BrokerStatus defines the observed state of Broker</summary>
    [JsonPropertyName("status")]
    public V1alpha1BrokerStatus? Status { get; set; }
}
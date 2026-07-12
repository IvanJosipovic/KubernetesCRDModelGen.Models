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
/// <summary>DBProxy is the Schema for the DBProxies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBProxyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DBProxy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBProxyList";
    public const string KubeGroup = "rds.services.k8s.aws";
    public const string KubePluralName = "dbproxies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBProxyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DBProxy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DBProxy> Items { get; set; }
}

/// <summary>
/// Specifies the details of authentication used by a proxy to log in as a specific
/// database user.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBProxySpecAuth
{
    [JsonPropertyName("authScheme")]
    public string? AuthScheme { get; set; }

    [JsonPropertyName("clientPasswordAuthType")]
    public string? ClientPasswordAuthType { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("iamAuth")]
    public string? IamAuth { get; set; }

    [JsonPropertyName("secretARN")]
    public string? SecretARN { get; set; }

    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBProxySpecRoleRefFrom
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
public partial class V1alpha1DBProxySpecRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DBProxySpecRoleRefFrom? From { get; set; }
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
public partial class V1alpha1DBProxySpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// DBProxySpec defines the desired state of DBProxy.
/// 
/// The data structure representing a proxy managed by the RDS Proxy.
/// 
/// This data type is used as a response element in the DescribeDBProxies action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBProxySpec
{
    /// <summary>The authorization mechanism that the proxy uses.</summary>
    [JsonPropertyName("auth")]
    public required IList<V1alpha1DBProxySpecAuth> Auth { get; set; }

    /// <summary>
    /// Specifies whether the proxy includes detailed information about SQL statements
    /// in its logs. This information helps you to debug issues involving SQL behavior
    /// or the performance and scalability of the proxy connections. The debug information
    /// includes the text of SQL statements that you submit through the proxy. Thus,
    /// only enable this setting when needed for debugging, and only when you have
    /// security measures in place to safeguard any sensitive information that appears
    /// in the logs.
    /// </summary>
    [JsonPropertyName("debugLogging")]
    public bool? DebugLogging { get; set; }

    /// <summary>
    /// The kinds of databases that the proxy can connect to. This value determines
    /// which database network protocol the proxy recognizes when it interprets network
    /// traffic to and from the database. For Aurora MySQL, RDS for MariaDB, and
    /// RDS for MySQL databases, specify MYSQL. For Aurora PostgreSQL and RDS for
    /// PostgreSQL databases, specify POSTGRESQL. For RDS for Microsoft SQL Server,
    /// specify SQLSERVER.
    /// </summary>
    [JsonPropertyName("engineFamily")]
    public required string EngineFamily { get; set; }

    /// <summary>
    /// The number of seconds that a connection to the proxy can be inactive before
    /// the proxy disconnects it. You can set this value higher or lower than the
    /// connection timeout limit for the associated database.
    /// </summary>
    [JsonPropertyName("idleClientTimeout")]
    public long? IdleClientTimeout { get; set; }

    /// <summary>
    /// The identifier for the proxy. This name must be unique for all proxies owned
    /// by your Amazon Web Services account in the specified Amazon Web Services
    /// Region. An identifier must begin with a letter and must contain only ASCII
    /// letters, digits, and hyphens; it can&apos;t end with a hyphen or contain two consecutive
    /// hyphens.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Specifies whether Transport Layer Security (TLS) encryption is required for
    /// connections to the proxy. By enabling this setting, you can enforce encrypted
    /// TLS connections to the proxy.
    /// </summary>
    [JsonPropertyName("requireTLS")]
    public bool? RequireTLS { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the IAM role that the proxy uses to access
    /// secrets in Amazon Web Services Secrets Manager.
    /// </summary>
    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("roleRef")]
    public V1alpha1DBProxySpecRoleRef? RoleRef { get; set; }

    /// <summary>
    /// An optional set of key-value pairs to associate arbitrary data of your choosing
    /// with the proxy.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1DBProxySpecTags>? Tags { get; set; }

    /// <summary>One or more VPC security group IDs to associate with the new proxy.</summary>
    [JsonPropertyName("vpcSecurityGroupIDs")]
    public IList<string>? VpcSecurityGroupIDs { get; set; }

    /// <summary>One or more VPC subnet IDs to associate with the new proxy.</summary>
    [JsonPropertyName("vpcSubnetIDs")]
    public required IList<string> VpcSubnetIDs { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBProxyStatusAckResourceMetadata
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
public partial class V1alpha1DBProxyStatusConditions
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

/// <summary>DBProxyStatus defines the observed state of DBProxy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBProxyStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DBProxyStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DBProxyStatusConditions>? Conditions { get; set; }

    /// <summary>The date and time when the proxy was first created.</summary>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// The endpoint that you can use to connect to the DB proxy. You include the
    /// endpoint value in the connection string for a database client application.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>
    /// The current status of this proxy. A status of available means the proxy is
    /// ready to handle requests. Other values indicate that you must wait for the
    /// proxy to be ready, or take some action to resolve an issue.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The date and time when the proxy was last updated.</summary>
    [JsonPropertyName("updatedDate")]
    public DateTime? UpdatedDate { get; set; }

    /// <summary>Provides the VPC ID of the DB proxy.</summary>
    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }
}

/// <summary>DBProxy is the Schema for the DBProxies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBProxy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DBProxySpec?>, IStatus<V1alpha1DBProxyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBProxy";
    public const string KubeGroup = "rds.services.k8s.aws";
    public const string KubePluralName = "dbproxies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBProxy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// DBProxySpec defines the desired state of DBProxy.
    /// 
    /// The data structure representing a proxy managed by the RDS Proxy.
    /// 
    /// This data type is used as a response element in the DescribeDBProxies action.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1DBProxySpec? Spec { get; set; }

    /// <summary>DBProxyStatus defines the observed state of DBProxy</summary>
    [JsonPropertyName("status")]
    public V1alpha1DBProxyStatus? Status { get; set; }
}
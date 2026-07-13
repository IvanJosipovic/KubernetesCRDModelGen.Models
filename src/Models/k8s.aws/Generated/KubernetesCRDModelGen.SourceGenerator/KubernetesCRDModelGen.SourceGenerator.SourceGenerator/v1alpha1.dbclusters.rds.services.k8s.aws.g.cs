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
/// <summary>DBCluster is the Schema for the DBClusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBClusterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DBCluster>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBClusterList";
    public const string KubeGroup = "rds.services.k8s.aws";
    public const string KubePluralName = "dbclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DBCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DBCluster> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecDbClusterParameterGroupRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecDbClusterParameterGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DBClusterSpecDbClusterParameterGroupRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecDbSubnetGroupRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecDbSubnetGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DBClusterSpecDbSubnetGroupRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecKmsKeyRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecKmsKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DBClusterSpecKmsKeyRefFrom? From { get; set; }
}

/// <summary>
/// The password for the master database user.
/// 
/// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
/// 
/// Constraints:
/// 
///   - Must contain from 8 to 41 characters.
/// 
///   - Can contain any printable ASCII character except &quot;/&quot;, &quot; &quot; &quot;, or &quot;@&quot;.
/// 
///   - Can&apos;t be specified if ManageMasterUserPassword is turned on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecMasterUserPassword
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
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecMasterUserSecretKMSKeyRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecMasterUserSecretKMSKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DBClusterSpecMasterUserSecretKMSKeyRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecMonitoringRoleRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecMonitoringRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DBClusterSpecMonitoringRoleRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecPerformanceInsightsKMSKeyRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecPerformanceInsightsKMSKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DBClusterSpecPerformanceInsightsKMSKeyRefFrom? From { get; set; }
}

/// <summary>
/// For DB clusters in serverless DB engine mode, the scaling properties of the
/// DB cluster.
/// 
/// Valid for Cluster Type: Aurora DB clusters only
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecScalingConfiguration
{
    [JsonPropertyName("autoPause")]
    public bool? AutoPause { get; set; }

    [JsonPropertyName("maxCapacity")]
    public long? MaxCapacity { get; set; }

    [JsonPropertyName("minCapacity")]
    public long? MinCapacity { get; set; }

    [JsonPropertyName("secondsBeforeTimeout")]
    public long? SecondsBeforeTimeout { get; set; }

    [JsonPropertyName("secondsUntilAutoPause")]
    public long? SecondsUntilAutoPause { get; set; }

    [JsonPropertyName("timeoutAction")]
    public string? TimeoutAction { get; set; }
}

/// <summary>
/// Contains the scaling configuration of an Aurora Serverless v2 DB cluster.
/// 
/// For more information, see Using Amazon Aurora Serverless v2 (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless-v2.html)
/// in the Amazon Aurora User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecServerlessV2ScalingConfiguration
{
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    [JsonPropertyName("secondsUntilAutoPause")]
    public long? SecondsUntilAutoPause { get; set; }
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
public partial class V1alpha1DBClusterSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecVpcSecurityGroupRefsFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecVpcSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DBClusterSpecVpcSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// DBClusterSpec defines the desired state of DBCluster.
/// 
/// Contains the details of an Amazon Aurora DB cluster or Multi-AZ DB cluster.
/// 
/// For an Amazon Aurora DB cluster, this data type is used as a response element
/// in the operations CreateDBCluster, DeleteDBCluster, DescribeDBClusters, FailoverDBCluster,
/// ModifyDBCluster, PromoteReadReplicaDBCluster, RestoreDBClusterFromS3, RestoreDBClusterFromSnapshot,
/// RestoreDBClusterToPointInTime, StartDBCluster, and StopDBCluster.
/// 
/// For a Multi-AZ DB cluster, this data type is used as a response element in
/// the operations CreateDBCluster, DeleteDBCluster, DescribeDBClusters, FailoverDBCluster,
/// ModifyDBCluster, RebootDBCluster, RestoreDBClusterFromSnapshot, and RestoreDBClusterToPointInTime.
/// 
/// For more information on Amazon Aurora DB clusters, see What is Amazon Aurora?
/// (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html)
/// in the Amazon Aurora User Guide.
/// 
/// For more information on Multi-AZ DB clusters, see Multi-AZ deployments with
/// two readable standby DB instances (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html)
/// in the Amazon RDS User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpec
{
    /// <summary>
    /// The amount of storage in gibibytes (GiB) to allocate to each DB instance
    /// in the Multi-AZ DB cluster.
    /// 
    /// Valid for Cluster Type: Multi-AZ DB clusters only
    /// 
    /// This setting is required to create a Multi-AZ DB cluster.
    /// </summary>
    [JsonPropertyName("allocatedStorage")]
    public long? AllocatedStorage { get; set; }

    /// <summary>
    /// Specifies whether minor engine upgrades are applied automatically to the
    /// DB cluster during the maintenance window. By default, minor engine upgrades
    /// are applied automatically.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB cluster
    /// </summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// A list of Availability Zones (AZs) where you specifically want to create
    /// DB instances in the DB cluster.
    /// 
    /// For information on AZs, see Availability Zones (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Concepts.RegionsAndAvailabilityZones.html#Concepts.RegionsAndAvailabilityZones.AvailabilityZones)
    /// in the Amazon Aurora User Guide.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters only
    /// 
    /// Constraints:
    /// 
    ///   - Can&apos;t specify more than three AZs.
    /// </summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>
    /// The target backtrack window, in seconds. To disable backtracking, set this
    /// value to 0.
    /// 
    /// Valid for Cluster Type: Aurora MySQL DB clusters only
    /// 
    /// Default: 0
    /// 
    /// Constraints:
    /// 
    ///   - If specified, this value must be set to a number from 0 to 259,200 (72
    ///     hours).
    /// </summary>
    [JsonPropertyName("backtrackWindow")]
    public long? BacktrackWindow { get; set; }

    /// <summary>
    /// The number of days for which automated backups are retained.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// 
    /// Default: 1
    /// 
    /// Constraints:
    /// 
    ///   - Must be a value from 1 to 35.
    /// </summary>
    [JsonPropertyName("backupRetentionPeriod")]
    public long? BackupRetentionPeriod { get; set; }

    /// <summary>
    /// The name of the character set (CharacterSet) to associate the DB cluster
    /// with.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters only
    /// </summary>
    [JsonPropertyName("characterSetName")]
    public string? CharacterSetName { get; set; }

    /// <summary>
    /// Specifies whether to copy all tags from the DB cluster to snapshots of the
    /// DB cluster. The default is not to copy them.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("copyTagsToSnapshot")]
    public bool? CopyTagsToSnapshot { get; set; }

    /// <summary>
    /// The mode of Database Insights to enable for the DB cluster.
    /// 
    /// If you set this value to advanced, you must also set the PerformanceInsightsEnabled
    /// parameter to true and the PerformanceInsightsRetentionPeriod parameter to
    /// 465.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters only
    /// </summary>
    [JsonPropertyName("databaseInsightsMode")]
    public string? DatabaseInsightsMode { get; set; }

    /// <summary>
    /// The name for your database of up to 64 alphanumeric characters. A database
    /// named postgres is always created. If this parameter is specified, an additional
    /// database with this name is created.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>
    /// The identifier for this DB cluster. This parameter is stored as a lowercase
    /// string.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// 
    /// Constraints:
    /// 
    ///   - Must contain from 1 to 63 (for Aurora DB clusters) or 1 to 52 (for Multi-AZ
    ///     DB clusters) letters, numbers, or hyphens.
    /// 
    ///   - First character must be a letter.
    /// 
    ///   - Can&apos;t end with a hyphen or contain two consecutive hyphens.
    /// 
    /// Example: my-cluster1
    /// </summary>
    [JsonPropertyName("dbClusterIdentifier")]
    public required string DbClusterIdentifier { get; set; }

    /// <summary>
    /// The compute and memory capacity of each DB instance in the Multi-AZ DB cluster,
    /// for example db.m6gd.xlarge. Not all DB instance classes are available in
    /// all Amazon Web Services Regions, or for all database engines.
    /// 
    /// For the full list of DB instance classes and availability for your engine,
    /// see DB instance class (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html)
    /// in the Amazon RDS User Guide.
    /// 
    /// This setting is required to create a Multi-AZ DB cluster.
    /// 
    /// Valid for Cluster Type: Multi-AZ DB clusters only
    /// </summary>
    [JsonPropertyName("dbClusterInstanceClass")]
    public string? DbClusterInstanceClass { get; set; }

    /// <summary>
    /// The name of the DB cluster parameter group to associate with this DB cluster.
    /// If you don&apos;t specify a value, then the default DB cluster parameter group
    /// for the specified DB engine and version is used.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// 
    /// Constraints:
    /// 
    ///   - If supplied, must match the name of an existing DB cluster parameter
    ///     group.
    /// </summary>
    [JsonPropertyName("dbClusterParameterGroupName")]
    public string? DbClusterParameterGroupName { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("dbClusterParameterGroupRef")]
    public V1alpha1DBClusterSpecDbClusterParameterGroupRef? DbClusterParameterGroupRef { get; set; }

    /// <summary>
    /// A DB subnet group to associate with this DB cluster.
    /// 
    /// This setting is required to create a Multi-AZ DB cluster.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// 
    /// Constraints:
    /// 
    ///   - Must match the name of an existing DB subnet group.
    /// 
    /// Example: mydbsubnetgroup
    /// </summary>
    [JsonPropertyName("dbSubnetGroupName")]
    public string? DbSubnetGroupName { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("dbSubnetGroupRef")]
    public V1alpha1DBClusterSpecDbSubnetGroupRef? DbSubnetGroupRef { get; set; }

    /// <summary>Reserved for future use.</summary>
    [JsonPropertyName("dbSystemID")]
    public string? DbSystemID { get; set; }

    /// <summary>
    /// Specifies whether the DB cluster has deletion protection enabled. The database
    /// can&apos;t be deleted when deletion protection is enabled. By default, deletion
    /// protection isn&apos;t enabled.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>DestinationRegion is used for presigning the request to a given region.</summary>
    [JsonPropertyName("destinationRegion")]
    public string? DestinationRegion { get; set; }

    /// <summary>
    /// The Active Directory directory ID to create the DB cluster in.
    /// 
    /// For Amazon Aurora DB clusters, Amazon RDS can use Kerberos authentication
    /// to authenticate users that connect to the DB cluster.
    /// 
    /// For more information, see Kerberos authentication (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/kerberos-authentication.html)
    /// in the Amazon Aurora User Guide.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters only
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>
    /// The name of the IAM role to use when making API calls to the Directory Service.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters only
    /// </summary>
    [JsonPropertyName("domainIAMRoleName")]
    public string? DomainIAMRoleName { get; set; }

    /// <summary>
    /// The list of log types that need to be enabled for exporting to CloudWatch
    /// Logs.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// 
    /// The following values are valid for each DB engine:
    /// 
    ///   - Aurora MySQL - audit | error | general | slowquery
    /// 
    ///   - Aurora PostgreSQL - postgresql
    /// 
    ///   - RDS for MySQL - error | general | slowquery
    /// 
    ///   - RDS for PostgreSQL - postgresql | upgrade
    /// 
    /// For more information about exporting CloudWatch Logs for Amazon RDS, see
    /// Publishing Database Logs to Amazon CloudWatch Logs (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch)
    /// in the Amazon RDS User Guide.
    /// 
    /// For more information about exporting CloudWatch Logs for Amazon Aurora, see
    /// Publishing Database Logs to Amazon CloudWatch Logs (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch)
    /// in the Amazon Aurora User Guide.
    /// </summary>
    [JsonPropertyName("enableCloudwatchLogsExports")]
    public IList<string>? EnableCloudwatchLogsExports { get; set; }

    /// <summary>
    /// Specifies whether to enable this DB cluster to forward write operations to
    /// the primary cluster of a global cluster (Aurora global database). By default,
    /// write operations are not allowed on Aurora DB clusters that are secondary
    /// clusters in an Aurora global database.
    /// 
    /// You can set this value only on Aurora DB clusters that are members of an
    /// Aurora global database. With this parameter enabled, a secondary cluster
    /// can forward writes to the current primary cluster, and the resulting changes
    /// are replicated back to this cluster. For the primary DB cluster of an Aurora
    /// global database, this value is used immediately if the primary is demoted
    /// by a global cluster API operation, but it does nothing until then.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters only
    /// </summary>
    [JsonPropertyName("enableGlobalWriteForwarding")]
    public bool? EnableGlobalWriteForwarding { get; set; }

    /// <summary>
    /// Specifies whether to enable the HTTP endpoint for the DB cluster. By default,
    /// the HTTP endpoint isn&apos;t enabled.
    /// 
    /// When enabled, the HTTP endpoint provides a connectionless web service API
    /// (RDS Data API) for running SQL queries on the DB cluster. You can also query
    /// your database from inside the RDS console with the RDS query editor.
    /// 
    /// For more information, see Using RDS Data API (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/data-api.html)
    /// in the Amazon Aurora User Guide.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters only
    /// </summary>
    [JsonPropertyName("enableHTTPEndpoint")]
    public bool? EnableHTTPEndpoint { get; set; }

    /// <summary>
    /// Specifies whether to enable mapping of Amazon Web Services Identity and Access
    /// Management (IAM) accounts to database accounts. By default, mapping isn&apos;t
    /// enabled.
    /// 
    /// For more information, see IAM Database Authentication (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/UsingWithRDS.IAMDBAuth.html)
    /// in the Amazon Aurora User Guide or IAM database authentication for MariaDB,
    /// MySQL, and PostgreSQL (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.IAMDBAuth.html)
    /// in the Amazon RDS User Guide.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("enableIAMDatabaseAuthentication")]
    public bool? EnableIAMDatabaseAuthentication { get; set; }

    /// <summary>
    /// Specifies whether to turn on Performance Insights for the DB cluster.
    /// 
    /// For more information, see Using Amazon Performance Insights (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PerfInsights.html)
    /// in the Amazon RDS User Guide.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("enablePerformanceInsights")]
    public bool? EnablePerformanceInsights { get; set; }

    /// <summary>
    /// The database engine to use for this DB cluster.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// 
    /// Valid Values:
    /// 
    ///   - aurora-mysql
    /// 
    ///   - aurora-postgresql
    /// 
    ///   - mysql
    /// 
    ///   - postgres
    /// 
    ///   - neptune - For information about using Amazon Neptune, see the Amazon
    ///     Neptune User Guide (https://docs.aws.amazon.com/neptune/latest/userguide/intro.html).
    /// </summary>
    [JsonPropertyName("engine")]
    public required string Engine { get; set; }

    /// <summary>
    /// The DB engine mode of the DB cluster, either provisioned or serverless.
    /// 
    /// The serverless engine mode only applies for Aurora Serverless v1 DB clusters.
    /// Aurora Serverless v2 DB clusters use the provisioned engine mode.
    /// 
    /// For information about limitations and requirements for Serverless DB clusters,
    /// see the following sections in the Amazon Aurora User Guide:
    /// 
    ///   - Limitations of Aurora Serverless v1 (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.html#aurora-serverless.limitations)
    /// 
    ///   - Requirements for Aurora Serverless v2 (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless-v2.requirements.html)
    /// 
    /// Valid for Cluster Type: Aurora DB clusters only
    /// </summary>
    [JsonPropertyName("engineMode")]
    public string? EngineMode { get; set; }

    /// <summary>
    /// The version number of the database engine to use.
    /// 
    /// To list all of the available engine versions for Aurora MySQL version 2 (5.7-compatible)
    /// and version 3 (MySQL 8.0-compatible), use the following command:
    /// 
    /// aws rds describe-db-engine-versions --engine aurora-mysql --query &quot;DBEngineVersions[].EngineVersion&quot;
    /// 
    /// You can supply either 5.7 or 8.0 to use the default engine version for Aurora
    /// MySQL version 2 or version 3, respectively.
    /// 
    /// To list all of the available engine versions for Aurora PostgreSQL, use the
    /// following command:
    /// 
    /// aws rds describe-db-engine-versions --engine aurora-postgresql --query &quot;DBEngineVersions[].EngineVersion&quot;
    /// 
    /// To list all of the available engine versions for RDS for MySQL, use the following
    /// command:
    /// 
    /// aws rds describe-db-engine-versions --engine mysql --query &quot;DBEngineVersions[].EngineVersion&quot;
    /// 
    /// To list all of the available engine versions for RDS for PostgreSQL, use
    /// the following command:
    /// 
    /// aws rds describe-db-engine-versions --engine postgres --query &quot;DBEngineVersions[].EngineVersion&quot;
    /// 
    /// For information about a specific engine, see the following topics:
    /// 
    ///   - Aurora MySQL - see Database engine updates for Amazon Aurora MySQL (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/AuroraMySQL.Updates.html)
    ///     in the Amazon Aurora User Guide.
    /// 
    ///   - Aurora PostgreSQL - see Amazon Aurora PostgreSQL releases and engine
    ///     versions (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/AuroraPostgreSQL.Updates.20180305.html)
    ///     in the Amazon Aurora User Guide.
    /// 
    ///   - RDS for MySQL - see Amazon RDS for MySQL (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_MySQL.html#MySQL.Concepts.VersionMgmt)
    ///     in the Amazon RDS User Guide.
    /// 
    ///   - RDS for PostgreSQL - see Amazon RDS for PostgreSQL (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_PostgreSQL.html#PostgreSQL.Concepts)
    ///     in the Amazon RDS User Guide.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>
    /// The global cluster ID of an Aurora cluster that becomes the primary cluster
    /// in the new global database cluster.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters only
    /// </summary>
    [JsonPropertyName("globalClusterIdentifier")]
    public string? GlobalClusterIdentifier { get; set; }

    /// <summary>
    /// The amount of Provisioned IOPS (input/output operations per second) to be
    /// initially allocated for each DB instance in the Multi-AZ DB cluster.
    /// 
    /// For information about valid IOPS values, see Provisioned IOPS storage (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Storage.html#USER_PIOPS)
    /// in the Amazon RDS User Guide.
    /// 
    /// This setting is required to create a Multi-AZ DB cluster.
    /// 
    /// Valid for Cluster Type: Multi-AZ DB clusters only
    /// 
    /// Constraints:
    /// 
    ///   - Must be a multiple between .5 and 50 of the storage amount for the DB
    ///     cluster.
    /// </summary>
    [JsonPropertyName("iops")]
    public long? Iops { get; set; }

    /// <summary>
    /// The Amazon Web Services KMS key identifier for an encrypted DB cluster.
    /// 
    /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias
    /// ARN, or alias name for the KMS key. To use a KMS key in a different Amazon
    /// Web Services account, specify the key ARN or alias ARN.
    /// 
    /// When a KMS key isn&apos;t specified in KmsKeyId:
    /// 
    ///   - If ReplicationSourceIdentifier identifies an encrypted source, then
    ///     Amazon RDS uses the KMS key used to encrypt the source. Otherwise, Amazon
    ///     RDS uses your default KMS key.
    /// 
    ///   - If the StorageEncrypted parameter is enabled and ReplicationSourceIdentifier
    ///     isn&apos;t specified, then Amazon RDS uses your default KMS key.
    /// 
    /// There is a default KMS key for your Amazon Web Services account. Your Amazon
    /// Web Services account has a different default KMS key for each Amazon Web
    /// Services Region.
    /// 
    /// If you create a read replica of an encrypted DB cluster in another Amazon
    /// Web Services Region, make sure to set KmsKeyId to a KMS key identifier that
    /// is valid in the destination Amazon Web Services Region. This KMS key is used
    /// to encrypt the read replica in that Amazon Web Services Region.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1DBClusterSpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>
    /// Specifies whether to manage the master user password with Amazon Web Services
    /// Secrets Manager.
    /// 
    /// For more information, see Password management with Amazon Web Services Secrets
    /// Manager (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-secrets-manager.html)
    /// in the Amazon RDS User Guide and Password management with Amazon Web Services
    /// Secrets Manager (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/rds-secrets-manager.html)
    /// in the Amazon Aurora User Guide.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// 
    /// Constraints:
    /// 
    ///   - Can&apos;t manage the master user password with Amazon Web Services Secrets
    ///     Manager if MasterUserPassword is specified.
    /// </summary>
    [JsonPropertyName("manageMasterUserPassword")]
    public bool? ManageMasterUserPassword { get; set; }

    /// <summary>
    /// The password for the master database user.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// 
    /// Constraints:
    /// 
    ///   - Must contain from 8 to 41 characters.
    /// 
    ///   - Can contain any printable ASCII character except &quot;/&quot;, &quot; &quot; &quot;, or &quot;@&quot;.
    /// 
    ///   - Can&apos;t be specified if ManageMasterUserPassword is turned on.
    /// </summary>
    [JsonPropertyName("masterUserPassword")]
    public V1alpha1DBClusterSpecMasterUserPassword? MasterUserPassword { get; set; }

    /// <summary>
    /// The Amazon Web Services KMS key identifier to encrypt a secret that is automatically
    /// generated and managed in Amazon Web Services Secrets Manager.
    /// 
    /// This setting is valid only if the master user password is managed by RDS
    /// in Amazon Web Services Secrets Manager for the DB cluster.
    /// 
    /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias
    /// ARN, or alias name for the KMS key. To use a KMS key in a different Amazon
    /// Web Services account, specify the key ARN or alias ARN.
    /// 
    /// If you don&apos;t specify MasterUserSecretKmsKeyId, then the aws/secretsmanager
    /// KMS key is used to encrypt the secret. If the secret is in a different Amazon
    /// Web Services account, then you can&apos;t use the aws/secretsmanager KMS key to
    /// encrypt the secret, and you must use a customer managed KMS key.
    /// 
    /// There is a default KMS key for your Amazon Web Services account. Your Amazon
    /// Web Services account has a different default KMS key for each Amazon Web
    /// Services Region.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("masterUserSecretKMSKeyID")]
    public string? MasterUserSecretKMSKeyID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("masterUserSecretKMSKeyRef")]
    public V1alpha1DBClusterSpecMasterUserSecretKMSKeyRef? MasterUserSecretKMSKeyRef { get; set; }

    /// <summary>
    /// The name of the master user for the DB cluster.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// 
    /// Constraints:
    /// 
    ///   - Must be 1 to 16 letters or numbers.
    /// 
    ///   - First character must be a letter.
    /// 
    ///   - Can&apos;t be a reserved word for the chosen database engine.
    /// </summary>
    [JsonPropertyName("masterUsername")]
    public string? MasterUsername { get; set; }

    /// <summary>
    /// The interval, in seconds, between points when Enhanced Monitoring metrics
    /// are collected for the DB cluster. To turn off collecting Enhanced Monitoring
    /// metrics, specify 0.
    /// 
    /// If MonitoringRoleArn is specified, also set MonitoringInterval to a value
    /// other than 0.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// 
    /// Valid Values: 0 | 1 | 5 | 10 | 15 | 30 | 60
    /// 
    /// Default: 0
    /// </summary>
    [JsonPropertyName("monitoringInterval")]
    public long? MonitoringInterval { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) for the IAM role that permits RDS to send
    /// Enhanced Monitoring metrics to Amazon CloudWatch Logs. An example is arn:aws:iam:123456789012:role/emaccess.
    /// For information on creating a monitoring role, see Setting up and enabling
    /// Enhanced Monitoring (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Monitoring.OS.html#USER_Monitoring.OS.Enabling)
    /// in the Amazon RDS User Guide.
    /// 
    /// If MonitoringInterval is set to a value other than 0, supply a MonitoringRoleArn
    /// value.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("monitoringRoleARN")]
    public string? MonitoringRoleARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("monitoringRoleRef")]
    public V1alpha1DBClusterSpecMonitoringRoleRef? MonitoringRoleRef { get; set; }

    /// <summary>
    /// The network type of the DB cluster.
    /// 
    /// The network type is determined by the DBSubnetGroup specified for the DB
    /// cluster. A DBSubnetGroup can support only the IPv4 protocol or the IPv4 and
    /// the IPv6 protocols (DUAL).
    /// 
    /// For more information, see Working with a DB instance in a VPC (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html)
    /// in the Amazon Aurora User Guide.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters only
    /// 
    /// Valid Values: IPV4 | DUAL
    /// </summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>
    /// The option group to associate the DB cluster with.
    /// 
    /// DB clusters are associated with a default option group that can&apos;t be modified.
    /// </summary>
    [JsonPropertyName("optionGroupName")]
    public string? OptionGroupName { get; set; }

    /// <summary>
    /// The Amazon Web Services KMS key identifier for encryption of Performance
    /// Insights data.
    /// 
    /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias
    /// ARN, or alias name for the KMS key.
    /// 
    /// If you don&apos;t specify a value for PerformanceInsightsKMSKeyId, then Amazon
    /// RDS uses your default KMS key. There is a default KMS key for your Amazon
    /// Web Services account. Your Amazon Web Services account has a different default
    /// KMS key for each Amazon Web Services Region.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("performanceInsightsKMSKeyID")]
    public string? PerformanceInsightsKMSKeyID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("performanceInsightsKMSKeyRef")]
    public V1alpha1DBClusterSpecPerformanceInsightsKMSKeyRef? PerformanceInsightsKMSKeyRef { get; set; }

    /// <summary>
    /// The number of days to retain Performance Insights data.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// 
    /// Valid Values:
    /// 
    ///   - 7
    /// 
    ///   - month * 31, where month is a number of months from 1-23. Examples: 93
    ///     (3 months * 31), 341 (11 months * 31), 589 (19 months * 31)
    /// 
    ///   - 731
    /// 
    /// Default: 7 days
    /// 
    /// If you specify a retention period that isn&apos;t valid, such as 94, Amazon RDS
    /// issues an error.
    /// </summary>
    [JsonPropertyName("performanceInsightsRetentionPeriod")]
    public long? PerformanceInsightsRetentionPeriod { get; set; }

    /// <summary>
    /// The port number on which the instances in the DB cluster accept connections.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// 
    /// Valid Values: 1150-65535
    /// 
    /// Default:
    /// 
    ///   - RDS for MySQL and Aurora MySQL - 3306
    /// 
    ///   - RDS for PostgreSQL and Aurora PostgreSQL - 5432
    /// </summary>
    [JsonPropertyName("port")]
    public long? Port { get; set; }

    /// <summary>
    /// When you are replicating a DB cluster from one Amazon Web Services GovCloud
    /// (US) Region to another, an URL that contains a Signature Version 4 signed
    /// request for the CreateDBCluster operation to be called in the source Amazon
    /// Web Services Region where the DB cluster is replicated from. Specify PreSignedUrl
    /// only when you are performing cross-Region replication from an encrypted DB
    /// cluster.
    /// 
    /// The presigned URL must be a valid request for the CreateDBCluster API operation
    /// that can run in the source Amazon Web Services Region that contains the encrypted
    /// DB cluster to copy.
    /// 
    /// The presigned URL request must contain the following parameter values:
    /// 
    ///   - KmsKeyId - The KMS key identifier for the KMS key to use to encrypt
    ///     the copy of the DB cluster in the destination Amazon Web Services Region.
    ///     This should refer to the same KMS key for both the CreateDBCluster operation
    ///     that is called in the destination Amazon Web Services Region, and the
    ///     operation contained in the presigned URL.
    /// 
    ///   - DestinationRegion - The name of the Amazon Web Services Region that
    ///     Aurora read replica will be created in.
    /// 
    ///   - ReplicationSourceIdentifier - The DB cluster identifier for the encrypted
    ///     DB cluster to be copied. This identifier must be in the Amazon Resource
    ///     Name (ARN) format for the source Amazon Web Services Region. For example,
    ///     if you are copying an encrypted DB cluster from the us-west-2 Amazon Web
    ///     Services Region, then your ReplicationSourceIdentifier would look like
    ///     Example: arn:aws:rds:us-west-2:123456789012:cluster:aurora-cluster1.
    /// 
    /// To learn how to generate a Signature Version 4 signed request, see Authenticating
    /// Requests: Using Query Parameters (Amazon Web Services Signature Version 4)
    /// (https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html)
    /// and Signature Version 4 Signing Process (https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html).
    /// 
    /// If you are using an Amazon Web Services SDK tool or the CLI, you can specify
    /// SourceRegion (or --source-region for the CLI) instead of specifying PreSignedUrl
    /// manually. Specifying SourceRegion autogenerates a presigned URL that is a
    /// valid request for the operation that can run in the source Amazon Web Services
    /// Region.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters only
    /// </summary>
    [JsonPropertyName("preSignedURL")]
    public string? PreSignedURL { get; set; }

    /// <summary>
    /// The daily time range during which automated backups are created if automated
    /// backups are enabled using the BackupRetentionPeriod parameter.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// 
    /// The default is a 30-minute window selected at random from an 8-hour block
    /// of time for each Amazon Web Services Region. To view the time blocks available,
    /// see Backup window (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Aurora.Managing.Backups.html#Aurora.Managing.Backups.BackupWindow)
    /// in the Amazon Aurora User Guide.
    /// 
    /// Constraints:
    /// 
    ///   - Must be in the format hh24:mi-hh24:mi.
    /// 
    ///   - Must be in Universal Coordinated Time (UTC).
    /// 
    ///   - Must not conflict with the preferred maintenance window.
    /// 
    ///   - Must be at least 30 minutes.
    /// </summary>
    [JsonPropertyName("preferredBackupWindow")]
    public string? PreferredBackupWindow { get; set; }

    /// <summary>
    /// The weekly time range during which system maintenance can occur.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// 
    /// The default is a 30-minute window selected at random from an 8-hour block
    /// of time for each Amazon Web Services Region, occurring on a random day of
    /// the week. To see the time blocks available, see Adjusting the Preferred DB
    /// Cluster Maintenance Window (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_UpgradeDBInstance.Maintenance.html#AdjustingTheMaintenanceWindow.Aurora)
    /// in the Amazon Aurora User Guide.
    /// 
    /// Constraints:
    /// 
    ///   - Must be in the format ddd:hh24:mi-ddd:hh24:mi.
    /// 
    ///   - Days must be one of Mon | Tue | Wed | Thu | Fri | Sat | Sun.
    /// 
    ///   - Must be in Universal Coordinated Time (UTC).
    /// 
    ///   - Must be at least 30 minutes.
    /// </summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>
    /// Specifies whether the DB cluster is publicly accessible.
    /// 
    /// When the DB cluster is publicly accessible and you connect from outside of
    /// the DB cluster&apos;s virtual private cloud (VPC), its Domain Name System (DNS)
    /// endpoint resolves to the public IP address. When you connect from within
    /// the same VPC as the DB cluster, the endpoint resolves to the private IP address.
    /// Access to the DB cluster is ultimately controlled by the security group it
    /// uses. That public access isn&apos;t permitted if the security group assigned to
    /// the DB cluster doesn&apos;t permit it.
    /// 
    /// When the DB cluster isn&apos;t publicly accessible, it is an internal DB cluster
    /// with a DNS name that resolves to a private IP address.
    /// 
    /// Valid for Cluster Type: Multi-AZ DB clusters only
    /// 
    /// Default: The default behavior varies depending on whether DBSubnetGroupName
    /// is specified.
    /// 
    /// If DBSubnetGroupName isn&apos;t specified, and PubliclyAccessible isn&apos;t specified,
    /// the following applies:
    /// 
    ///   - If the default VPC in the target Region doesn’t have an internet gateway
    ///     attached to it, the DB cluster is private.
    /// 
    ///   - If the default VPC in the target Region has an internet gateway attached
    ///     to it, the DB cluster is public.
    /// 
    /// If DBSubnetGroupName is specified, and PubliclyAccessible isn&apos;t specified,
    /// the following applies:
    /// 
    ///   - If the subnets are part of a VPC that doesn’t have an internet gateway
    ///     attached to it, the DB cluster is private.
    /// 
    ///   - If the subnets are part of a VPC that has an internet gateway attached
    ///     to it, the DB cluster is public.
    /// </summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the source DB instance or DB cluster if
    /// this DB cluster is created as a read replica.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("replicationSourceIdentifier")]
    public string? ReplicationSourceIdentifier { get; set; }

    /// <summary>
    /// The date and time to restore the DB cluster to.
    /// 
    /// Valid Values: Value must be a time in Universal Coordinated Time (UTC) format
    /// 
    /// Constraints:
    /// 
    ///   - Must be before the latest restorable time for the DB instance
    /// 
    ///   - Must be specified if UseLatestRestorableTime parameter isn&apos;t provided
    /// 
    ///   - Can&apos;t be specified if the UseLatestRestorableTime parameter is enabled
    /// 
    ///   - Can&apos;t be specified if the RestoreType parameter is copy-on-write
    /// 
    /// Example: 2015-03-07T23:45:00Z
    /// 
    /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("restoreToTime")]
    public DateTime? RestoreToTime { get; set; }

    /// <summary>
    /// The type of restore to be performed. You can specify one of the following
    /// values:
    /// 
    ///   - full-copy - The new DB cluster is restored as a full copy of the source
    ///     DB cluster.
    /// 
    ///   - copy-on-write - The new DB cluster is restored as a clone of the source
    ///     DB cluster.
    /// 
    /// If you don&apos;t specify a RestoreType value, then the new DB cluster is restored
    /// as a full copy of the source DB cluster.
    /// 
    /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("restoreType")]
    public string? RestoreType { get; set; }

    /// <summary>
    /// For DB clusters in serverless DB engine mode, the scaling properties of the
    /// DB cluster.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters only
    /// </summary>
    [JsonPropertyName("scalingConfiguration")]
    public V1alpha1DBClusterSpecScalingConfiguration? ScalingConfiguration { get; set; }

    /// <summary>
    /// Contains the scaling configuration of an Aurora Serverless v2 DB cluster.
    /// 
    /// For more information, see Using Amazon Aurora Serverless v2 (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless-v2.html)
    /// in the Amazon Aurora User Guide.
    /// </summary>
    [JsonPropertyName("serverlessV2ScalingConfiguration")]
    public V1alpha1DBClusterSpecServerlessV2ScalingConfiguration? ServerlessV2ScalingConfiguration { get; set; }

    /// <summary>
    /// The identifier for the DB snapshot or DB cluster snapshot to restore from.
    /// 
    /// You can use either the name or the Amazon Resource Name (ARN) to specify
    /// a DB cluster snapshot. However, you can use only the ARN to specify a DB
    /// snapshot.
    /// 
    /// Constraints:
    /// 
    ///   - Must match the identifier of an existing Snapshot.
    /// 
    /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("snapshotIdentifier")]
    public string? SnapshotIdentifier { get; set; }

    /// <summary>
    /// The identifier of the source DB cluster from which to restore.
    /// 
    /// Constraints:
    /// 
    ///   - Must match the identifier of an existing DBCluster.
    /// 
    /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("sourceDBClusterIdentifier")]
    public string? SourceDBClusterIdentifier { get; set; }

    /// <summary>
    /// SourceRegion is the source region where the resource exists. This is not
    /// sent over the wire and is only used for presigning. This value should always
    /// have the same region as the source ARN.
    /// </summary>
    [JsonPropertyName("sourceRegion")]
    public string? SourceRegion { get; set; }

    /// <summary>
    /// Specifies whether the DB cluster is encrypted.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("storageEncrypted")]
    public bool? StorageEncrypted { get; set; }

    /// <summary>
    /// The storage type to associate with the DB cluster.
    /// 
    /// For information on storage types for Aurora DB clusters, see Storage configurations
    /// for Amazon Aurora DB clusters (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Aurora.Overview.StorageReliability.html#aurora-storage-type).
    /// For information on storage types for Multi-AZ DB clusters, see Settings for
    /// creating Multi-AZ DB clusters (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/create-multi-az-db-cluster.html#create-multi-az-db-cluster-settings).
    /// 
    /// This setting is required to create a Multi-AZ DB cluster.
    /// 
    /// When specified for a Multi-AZ DB cluster, a value for the Iops parameter
    /// is required.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// 
    /// Valid Values:
    /// 
    ///   - Aurora DB clusters - aurora | aurora-iopt1
    /// 
    ///   - Multi-AZ DB clusters - io1 | io2 | gp3
    /// 
    /// Default:
    /// 
    ///   - Aurora DB clusters - aurora
    /// 
    ///   - Multi-AZ DB clusters - io1
    /// 
    /// When you create an Aurora DB cluster with the storage type set to aurora-iopt1,
    /// the storage type is returned in the response. The storage type isn&apos;t returned
    /// when you set it to aurora.
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>
    /// Tags to assign to the DB cluster.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1DBClusterSpecTags>? Tags { get; set; }

    /// <summary>
    /// Specifies whether to restore the DB cluster to the latest restorable backup
    /// time. By default, the DB cluster isn&apos;t restored to the latest restorable
    /// backup time.
    /// 
    /// Constraints: Can&apos;t be specified if RestoreToTime parameter is provided.
    /// 
    /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("useLatestRestorableTime")]
    public bool? UseLatestRestorableTime { get; set; }

    /// <summary>
    /// A list of EC2 VPC security groups to associate with this DB cluster.
    /// 
    /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
    /// </summary>
    [JsonPropertyName("vpcSecurityGroupIDs")]
    public IList<string>? VpcSecurityGroupIDs { get; set; }

    [JsonPropertyName("vpcSecurityGroupRefs")]
    public IList<V1alpha1DBClusterSpecVpcSecurityGroupRefs>? VpcSecurityGroupRefs { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterStatusAckResourceMetadata
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
/// Describes an Amazon Web Services Identity and Access Management (IAM) role
/// that is associated with a DB cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterStatusAssociatedRoles
{
    [JsonPropertyName("featureName")]
    public string? FeatureName { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterStatusConditions
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

/// <summary>Contains information about an instance that is part of a DB cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterStatusDbClusterMembers
{
    [JsonPropertyName("dbClusterParameterGroupStatus")]
    public string? DbClusterParameterGroupStatus { get; set; }

    [JsonPropertyName("dbInstanceIdentifier")]
    public string? DbInstanceIdentifier { get; set; }

    [JsonPropertyName("isClusterWriter")]
    public bool? IsClusterWriter { get; set; }

    [JsonPropertyName("promotionTier")]
    public long? PromotionTier { get; set; }
}

/// <summary>Contains status information for a DB cluster option group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterStatusDbClusterOptionGroupMemberships
{
    [JsonPropertyName("dbClusterOptionGroupName")]
    public string? DbClusterOptionGroupName { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// An Active Directory Domain membership record associated with the DB instance
/// or cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterStatusDomainMemberships
{
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    [JsonPropertyName("fQDN")]
    public string? FQDN { get; set; }

    [JsonPropertyName("iamRoleName")]
    public string? IamRoleName { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// The secret managed by RDS in Amazon Web Services Secrets Manager for the
/// master user password.
/// 
/// For more information, see Password management with Amazon Web Services Secrets
/// Manager (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-secrets-manager.html)
/// in the Amazon RDS User Guide and Password management with Amazon Web Services
/// Secrets Manager (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/rds-secrets-manager.html)
/// in the Amazon Aurora User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterStatusMasterUserSecret
{
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    [JsonPropertyName("secretARN")]
    public string? SecretARN { get; set; }

    [JsonPropertyName("secretStatus")]
    public string? SecretStatus { get; set; }
}

/// <summary>
/// A list of the log types whose configuration is still pending. In other words,
/// these log types are in the process of being activated or deactivated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterStatusPendingModifiedValuesPendingCloudwatchLogsExports
{
    [JsonPropertyName("logTypesToDisable")]
    public IList<string>? LogTypesToDisable { get; set; }

    [JsonPropertyName("logTypesToEnable")]
    public IList<string>? LogTypesToEnable { get; set; }
}

/// <summary>
/// Information about pending changes to the DB cluster. This information is
/// returned only when there are pending changes. Specific changes are identified
/// by subelements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterStatusPendingModifiedValues
{
    [JsonPropertyName("allocatedStorage")]
    public long? AllocatedStorage { get; set; }

    [JsonPropertyName("backupRetentionPeriod")]
    public long? BackupRetentionPeriod { get; set; }

    [JsonPropertyName("dbClusterIdentifier")]
    public string? DbClusterIdentifier { get; set; }

    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    [JsonPropertyName("iamDatabaseAuthenticationEnabled")]
    public bool? IamDatabaseAuthenticationEnabled { get; set; }

    [JsonPropertyName("iops")]
    public long? Iops { get; set; }

    [JsonPropertyName("masterUserPassword")]
    public string? MasterUserPassword { get; set; }

    /// <summary>
    /// A list of the log types whose configuration is still pending. In other words,
    /// these log types are in the process of being activated or deactivated.
    /// </summary>
    [JsonPropertyName("pendingCloudwatchLogsExports")]
    public V1alpha1DBClusterStatusPendingModifiedValuesPendingCloudwatchLogsExports? PendingCloudwatchLogsExports { get; set; }
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
public partial class V1alpha1DBClusterStatusTagList
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// This data type is used as a response element for queries on VPC security
/// group membership.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterStatusVpcSecurityGroups
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("vpcSecurityGroupID")]
    public string? VpcSecurityGroupID { get; set; }
}

/// <summary>DBClusterStatus defines the observed state of DBCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DBClusterStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// The Amazon Web Services KMS key identifier used for encrypting messages in
    /// the database activity stream.
    /// 
    /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias
    /// ARN, or alias name for the KMS key.
    /// </summary>
    [JsonPropertyName("activityStreamKMSKeyID")]
    public string? ActivityStreamKMSKeyID { get; set; }

    /// <summary>
    /// The name of the Amazon Kinesis data stream used for the database activity
    /// stream.
    /// </summary>
    [JsonPropertyName("activityStreamKinesisStreamName")]
    public string? ActivityStreamKinesisStreamName { get; set; }

    /// <summary>
    /// The mode of the database activity stream. Database events such as a change
    /// or access generate an activity stream event. The database session can handle
    /// these events either synchronously or asynchronously.
    /// </summary>
    [JsonPropertyName("activityStreamMode")]
    public string? ActivityStreamMode { get; set; }

    /// <summary>The status of the database activity stream.</summary>
    [JsonPropertyName("activityStreamStatus")]
    public string? ActivityStreamStatus { get; set; }

    /// <summary>
    /// A list of the Amazon Web Services Identity and Access Management (IAM) roles
    /// that are associated with the DB cluster. IAM roles that are associated with
    /// a DB cluster grant permission for the DB cluster to access other Amazon Web
    /// Services on your behalf.
    /// </summary>
    [JsonPropertyName("associatedRoles")]
    public IList<V1alpha1DBClusterStatusAssociatedRoles>? AssociatedRoles { get; set; }

    /// <summary>The time when a stopped DB cluster is restarted automatically.</summary>
    [JsonPropertyName("automaticRestartTime")]
    public DateTime? AutomaticRestartTime { get; set; }

    /// <summary>The number of change records stored for Backtrack.</summary>
    [JsonPropertyName("backtrackConsumedChangeRecords")]
    public long? BacktrackConsumedChangeRecords { get; set; }

    /// <summary>
    /// The current capacity of an Aurora Serverless v1 DB cluster. The capacity
    /// is 0 (zero) when the cluster is paused.
    /// 
    /// For more information about Aurora Serverless v1, see Using Amazon Aurora
    /// Serverless v1 (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.html)
    /// in the Amazon Aurora User Guide.
    /// </summary>
    [JsonPropertyName("capacity")]
    public long? Capacity { get; set; }

    /// <summary>The ID of the clone group with which the DB cluster is associated.</summary>
    [JsonPropertyName("cloneGroupID")]
    public string? CloneGroupID { get; set; }

    /// <summary>The time when the DB cluster was created, in Universal Coordinated Time (UTC).</summary>
    [JsonPropertyName("clusterCreateTime")]
    public DateTime? ClusterCreateTime { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DBClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Indicates whether the DB cluster is a clone of a DB cluster owned by a different
    /// Amazon Web Services account.
    /// </summary>
    [JsonPropertyName("crossAccountClone")]
    public bool? CrossAccountClone { get; set; }

    /// <summary>The custom endpoints associated with the DB cluster.</summary>
    [JsonPropertyName("customEndpoints")]
    public IList<string>? CustomEndpoints { get; set; }

    /// <summary>The list of DB instances that make up the DB cluster.</summary>
    [JsonPropertyName("dbClusterMembers")]
    public IList<V1alpha1DBClusterStatusDbClusterMembers>? DbClusterMembers { get; set; }

    /// <summary>The list of option group memberships for this DB cluster.</summary>
    [JsonPropertyName("dbClusterOptionGroupMemberships")]
    public IList<V1alpha1DBClusterStatusDbClusterOptionGroupMemberships>? DbClusterOptionGroupMemberships { get; set; }

    /// <summary>The name of the DB cluster parameter group for the DB cluster.</summary>
    [JsonPropertyName("dbClusterParameterGroup")]
    public string? DbClusterParameterGroup { get; set; }

    /// <summary>
    /// The Amazon Web Services Region-unique, immutable identifier for the DB cluster.
    /// This identifier is found in Amazon Web Services CloudTrail log entries whenever
    /// the KMS key for the DB cluster is accessed.
    /// </summary>
    [JsonPropertyName("dbClusterResourceID")]
    public string? DbClusterResourceID { get; set; }

    /// <summary>
    /// Information about the subnet group associated with the DB cluster, including
    /// the name, description, and subnets in the subnet group.
    /// </summary>
    [JsonPropertyName("dbSubnetGroup")]
    public string? DbSubnetGroup { get; set; }

    /// <summary>The Active Directory Domain membership records associated with the DB cluster.</summary>
    [JsonPropertyName("domainMemberships")]
    public IList<V1alpha1DBClusterStatusDomainMemberships>? DomainMemberships { get; set; }

    /// <summary>The earliest time to which a DB cluster can be backtracked.</summary>
    [JsonPropertyName("earliestBacktrackTime")]
    public DateTime? EarliestBacktrackTime { get; set; }

    /// <summary>
    /// The earliest time to which a database can be restored with point-in-time
    /// restore.
    /// </summary>
    [JsonPropertyName("earliestRestorableTime")]
    public DateTime? EarliestRestorableTime { get; set; }

    /// <summary>
    /// A list of log types that this DB cluster is configured to export to CloudWatch
    /// Logs.
    /// 
    /// Log types vary by DB engine. For information about the log types for each
    /// DB engine, see Amazon RDS Database Log Files (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_LogAccess.html)
    /// in the Amazon Aurora User Guide.
    /// </summary>
    [JsonPropertyName("enabledCloudwatchLogsExports")]
    public IList<string>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>The connection endpoint for the primary instance of the DB cluster.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>
    /// Indicates whether write forwarding is enabled for a secondary cluster in
    /// an Aurora global database. Because write forwarding takes time to enable,
    /// check the value of GlobalWriteForwardingStatus to confirm that the request
    /// has completed before using the write forwarding feature for this cluster.
    /// </summary>
    [JsonPropertyName("globalWriteForwardingRequested")]
    public bool? GlobalWriteForwardingRequested { get; set; }

    /// <summary>
    /// The status of write forwarding for a secondary cluster in an Aurora global
    /// database.
    /// </summary>
    [JsonPropertyName("globalWriteForwardingStatus")]
    public string? GlobalWriteForwardingStatus { get; set; }

    /// <summary>The ID that Amazon Route 53 assigns when you create a hosted zone.</summary>
    [JsonPropertyName("hostedZoneID")]
    public string? HostedZoneID { get; set; }

    /// <summary>
    /// Indicates whether the HTTP endpoint is enabled for an Aurora DB cluster.
    /// 
    /// When enabled, the HTTP endpoint provides a connectionless web service API
    /// (RDS Data API) for running SQL queries on the DB cluster. You can also query
    /// your database from inside the RDS console with the RDS query editor.
    /// 
    /// For more information, see Using RDS Data API (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/data-api.html)
    /// in the Amazon Aurora User Guide.
    /// </summary>
    [JsonPropertyName("httpEndpointEnabled")]
    public bool? HttpEndpointEnabled { get; set; }

    /// <summary>
    /// Indicates whether the mapping of Amazon Web Services Identity and Access
    /// Management (IAM) accounts to database accounts is enabled.
    /// </summary>
    [JsonPropertyName("iamDatabaseAuthenticationEnabled")]
    public bool? IamDatabaseAuthenticationEnabled { get; set; }

    /// <summary>The latest time to which a database can be restored with point-in-time restore.</summary>
    [JsonPropertyName("latestRestorableTime")]
    public DateTime? LatestRestorableTime { get; set; }

    /// <summary>
    /// The secret managed by RDS in Amazon Web Services Secrets Manager for the
    /// master user password.
    /// 
    /// For more information, see Password management with Amazon Web Services Secrets
    /// Manager (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-secrets-manager.html)
    /// in the Amazon RDS User Guide and Password management with Amazon Web Services
    /// Secrets Manager (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/rds-secrets-manager.html)
    /// in the Amazon Aurora User Guide.
    /// </summary>
    [JsonPropertyName("masterUserSecret")]
    public V1alpha1DBClusterStatusMasterUserSecret? MasterUserSecret { get; set; }

    /// <summary>Indicates whether the DB cluster has instances in multiple Availability Zones.</summary>
    [JsonPropertyName("multiAZ")]
    public bool? MultiAZ { get; set; }

    /// <summary>
    /// Information about pending changes to the DB cluster. This information is
    /// returned only when there are pending changes. Specific changes are identified
    /// by subelements.
    /// </summary>
    [JsonPropertyName("pendingModifiedValues")]
    public V1alpha1DBClusterStatusPendingModifiedValues? PendingModifiedValues { get; set; }

    /// <summary>The progress of the operation as a percentage.</summary>
    [JsonPropertyName("percentProgress")]
    public string? PercentProgress { get; set; }

    /// <summary>
    /// Indicates whether Performance Insights is enabled for the DB cluster.
    /// 
    /// This setting is only for Aurora DB clusters and Multi-AZ DB clusters.
    /// </summary>
    [JsonPropertyName("performanceInsightsEnabled")]
    public bool? PerformanceInsightsEnabled { get; set; }

    /// <summary>
    /// Contains one or more identifiers of the read replicas associated with this
    /// DB cluster.
    /// </summary>
    [JsonPropertyName("readReplicaIdentifiers")]
    public IList<string>? ReadReplicaIdentifiers { get; set; }

    /// <summary>
    /// The reader endpoint for the DB cluster. The reader endpoint for a DB cluster
    /// load-balances connections across the Aurora Replicas that are available in
    /// a DB cluster. As clients request new connections to the reader endpoint,
    /// Aurora distributes the connection requests among the Aurora Replicas in the
    /// DB cluster. This functionality can help balance your read workload across
    /// multiple Aurora Replicas in your DB cluster.
    /// 
    /// If a failover occurs, and the Aurora Replica that you are connected to is
    /// promoted to be the primary instance, your connection is dropped. To continue
    /// sending your read workload to other Aurora Replicas in the cluster, you can
    /// then reconnect to the reader endpoint.
    /// </summary>
    [JsonPropertyName("readerEndpoint")]
    public string? ReaderEndpoint { get; set; }

    /// <summary>The current state of this DB cluster.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("tagList")]
    public IList<V1alpha1DBClusterStatusTagList>? TagList { get; set; }

    /// <summary>The list of VPC security groups that the DB cluster belongs to.</summary>
    [JsonPropertyName("vpcSecurityGroups")]
    public IList<V1alpha1DBClusterStatusVpcSecurityGroups>? VpcSecurityGroups { get; set; }
}

/// <summary>DBCluster is the Schema for the DBClusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DBClusterSpec?>, IStatus<V1alpha1DBClusterStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBCluster";
    public const string KubeGroup = "rds.services.k8s.aws";
    public const string KubePluralName = "dbclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// DBClusterSpec defines the desired state of DBCluster.
    /// 
    /// Contains the details of an Amazon Aurora DB cluster or Multi-AZ DB cluster.
    /// 
    /// For an Amazon Aurora DB cluster, this data type is used as a response element
    /// in the operations CreateDBCluster, DeleteDBCluster, DescribeDBClusters, FailoverDBCluster,
    /// ModifyDBCluster, PromoteReadReplicaDBCluster, RestoreDBClusterFromS3, RestoreDBClusterFromSnapshot,
    /// RestoreDBClusterToPointInTime, StartDBCluster, and StopDBCluster.
    /// 
    /// For a Multi-AZ DB cluster, this data type is used as a response element in
    /// the operations CreateDBCluster, DeleteDBCluster, DescribeDBClusters, FailoverDBCluster,
    /// ModifyDBCluster, RebootDBCluster, RestoreDBClusterFromSnapshot, and RestoreDBClusterToPointInTime.
    /// 
    /// For more information on Amazon Aurora DB clusters, see What is Amazon Aurora?
    /// (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html)
    /// in the Amazon Aurora User Guide.
    /// 
    /// For more information on Multi-AZ DB clusters, see Multi-AZ deployments with
    /// two readable standby DB instances (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html)
    /// in the Amazon RDS User Guide.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1DBClusterSpec? Spec { get; set; }

    /// <summary>DBClusterStatus defines the observed state of DBCluster</summary>
    [JsonPropertyName("status")]
    public V1alpha1DBClusterStatus? Status { get; set; }
}
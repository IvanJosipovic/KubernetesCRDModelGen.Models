#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.databricks.upbound.io;
/// <summary>Cluster is the Schema for the Clusters API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Cluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "compute.databricks.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.databricks.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Cluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Cluster> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecDeletionPolicyEnum>))]
public enum V1beta1ClusterSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAutoscale
{
    /// <summary>The maximum number of workers to which the cluster can scale up when overloaded. max_workers must be strictly greater than min_workers.</summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary>The minimum number of workers to which the cluster can scale down when underutilized. It is also the initial number of workers the cluster will have after creation.</summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAwsAttributes
{
    /// <summary>Availability type used for all subsequent nodes past the first_on_demand ones. Valid values are SPOT, SPOT_WITH_FALLBACK and ON_DEMAND. Note: If first_on_demand is zero, this availability type will be used for the entire cluster. Backend default value is SPOT_WITH_FALLBACK and could change in the future</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>The number of volumes launched for each instance. You can choose up to 10 volumes. This feature is only enabled for supported node types. Legacy node types cannot specify custom EBS volumes. For node types with no instance store, at least one EBS volume needs to be specified; otherwise, cluster creation will fail. These EBS volumes will be mounted at /ebs0, /ebs1, and etc. Instance store volumes will be mounted at /local_disk0, /local_disk1, and etc. If EBS volumes are attached, Databricks will configure Spark to use only the EBS volumes for scratch storage because heterogeneously sized scratch devices can lead to inefficient disk utilization. If no EBS volumes are attached, Databricks will configure Spark to use instance store volumes. If EBS volumes are specified, then the Spark configuration spark.local.dir will be overridden.</summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary>The size of each EBS volume (in GiB) launched for each instance. For general purpose SSD, this value must be within the range 100 - 4096. For throughput optimized HDD, this value must be within the range 500 - 4096. Custom EBS volumes cannot be specified for the legacy node types (memory-optimized and compute-optimized).</summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary>The type of EBS volumes that will be launched with this cluster. Valid values are GENERAL_PURPOSE_SSD or THROUGHPUT_OPTIMIZED_HDD. Use this option only if you&apos;re not picking Delta Optimized  node types.</summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary>The first first_on_demand nodes of the cluster will be placed on on-demand instances. If this value is greater than 0, the cluster driver node will be placed on an on-demand instance. If this value is greater than or equal to the current cluster size, all nodes will be placed on on-demand instances. If this value is less than the current cluster size, first_on_demand nodes will be placed on on-demand instances, and the remainder will be placed on availability instances. This value does not affect cluster size and cannot be mutated over the lifetime of a cluster. Backend default value is 1 and could change in the future</summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary>Nodes for this cluster will only be placed on AWS instances with this instance profile.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>The max price for AWS spot instances, as a percentage of the corresponding instance type’s on-demand price. For example, if this field is set to 50, and the cluster needs a new i3.xlarge spot instance, then the max price is half of the price of on-demand i3.xlarge instances. Similarly, if this field is set to 200, the max price is twice the price of on-demand i3.xlarge instances. If not specified, the default value is 100. When spot instances are requested for this cluster, only spot instances whose max price percentage matches this field will be considered. For safety, we enforce this field to be no more than 10000.</summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>Identifier for the availability zone/datacenter in which the cluster resides. This string will be of a form like us-west-2a. The provided availability zone must be in the same region as the Databricks deployment. For example, us-west-2a is not a valid zone ID if the Databricks deployment resides in the us-east-1 region. Enable automatic availability zone selection (&quot;Auto-AZ&quot;), by setting the value auto. Databricks selects the AZ based on available IPs in the workspace subnets and retries in other availability zones if AWS returns insufficient capacity errors.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAzureAttributesLogAnalyticsInfo
{
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>Canonical unique identifier for the cluster.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAzureAttributes
{
    /// <summary>Availability type used for all subsequent nodes past the first_on_demand ones. Valid values are SPOT_AZURE, SPOT_WITH_FALLBACK_AZURE, and ON_DEMAND_AZURE. Note: If first_on_demand is zero, this availability type will be used for the entire cluster.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>The first first_on_demand nodes of the cluster will be placed on on-demand instances. If this value is greater than 0, the cluster driver node will be placed on an on-demand instance. If this value is greater than or equal to the current cluster size, all nodes will be placed on on-demand instances. If this value is less than the current cluster size, first_on_demand nodes will be placed on on-demand instances, and the remainder will be placed on availability instances. This value does not affect cluster size and cannot be mutated over the lifetime of a cluster.</summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("logAnalyticsInfo")]
    public V1beta1ClusterSpecForProviderAzureAttributesLogAnalyticsInfo? LogAnalyticsInfo { get; set; }

    /// <summary>The max bid price used for Azure spot instances. You can set this to greater than or equal to the current spot price. You can also set this to -1, which specifies that the instance cannot be evicted on the basis of price. The price for the instance will be the current price for spot instances or the price for a standard instance.</summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterLogConfDbfs
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterLogConfS3
{
    /// <summary>Set canned access control list, e.g. bucket-owner-full-control. If canned_cal is set, the cluster instance profile must have s3:PutObjectAcl permission on the destination bucket and prefix. The full list of possible canned ACLs can be found here. By default, only the object owner gets full control. If you are using a cross-account role for writing data, you may want to set bucket-owner-full-control to make bucket owners able to read the logs.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Enable server-side encryption, false by default.</summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary>The encryption type, it could be sse-s3 or sse-kms. It is used only when encryption is enabled, and the default type is sse-s3.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>S3 endpoint, e.g. https://s3-us-west-2.amazonaws.com. Either region or endpoint needs to be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>KMS key used if encryption is enabled and encryption type is set to sse-kms.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>S3 region, e.g. us-west-2. Either region or endpoint must be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterLogConf
{
    [JsonPropertyName("dbfs")]
    public V1beta1ClusterSpecForProviderClusterLogConfDbfs? Dbfs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1ClusterSpecForProviderClusterLogConfS3? S3 { get; set; }
}

/// <summary>block specifying connection. It consists of:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterMountInfoNetworkFilesystemInfo
{
    /// <summary>string that will be passed as options passed to the mount command.</summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>host name.</summary>
    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterMountInfo
{
    /// <summary>path inside the Spark container.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    /// <summary>block specifying connection. It consists of:</summary>
    [JsonPropertyName("networkFilesystemInfo")]
    public V1beta1ClusterSpecForProviderClusterMountInfoNetworkFilesystemInfo? NetworkFilesystemInfo { get; set; }

    /// <summary>string specifying path to mount on the remote service.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderDockerImageBasicAuthPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>basic_auth.username and basic_auth.password for Docker repository. Docker registry credentials are encrypted when they are stored in Databricks internal storage and when they are passed to a registry upon fetching Docker images at cluster launch. However, other authenticated and authorized API users of this workspace can access the username and password.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderDockerImageBasicAuth
{
    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1ClusterSpecForProviderDockerImageBasicAuthPasswordSecretRef? PasswordSecretRef { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderDockerImage
{
    /// <summary>basic_auth.username and basic_auth.password for Docker repository. Docker registry credentials are encrypted when they are stored in Databricks internal storage and when they are passed to a registry upon fetching Docker images at cluster launch. However, other authenticated and authorized API users of this workspace can access the username and password.</summary>
    [JsonPropertyName("basicAuth")]
    public V1beta1ClusterSpecForProviderDockerImageBasicAuth? BasicAuth { get; set; }

    /// <summary>URL for the Docker image</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderGcpAttributes
{
    /// <summary>, and will be removed soon.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>Boot disk size in GB</summary>
    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    /// <summary>Google Service Account email address that the cluster uses to authenticate with Google Identity. This field is used for authentication with the GCS and BigQuery data sources.</summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary>Number of local SSD disks (each is 375GB in size) that will be attached to each node of the cluster.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>if we should use preemptible executors (GCP documentation). Warning: this field is deprecated in favor of</summary>
    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>Identifier for the availability zone in which the cluster resides. This can be one of the following:</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderInitScriptsAbfss
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderInitScriptsDbfs
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderInitScriptsFile
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderInitScriptsGcs
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderInitScriptsS3
{
    /// <summary>Set canned access control list, e.g. bucket-owner-full-control. If canned_cal is set, the cluster instance profile must have s3:PutObjectAcl permission on the destination bucket and prefix. The full list of possible canned ACLs can be found here. By default, only the object owner gets full control. If you are using a cross-account role for writing data, you may want to set bucket-owner-full-control to make bucket owners able to read the logs.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Enable server-side encryption, false by default.</summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary>The encryption type, it could be sse-s3 or sse-kms. It is used only when encryption is enabled, and the default type is sse-s3.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>S3 endpoint, e.g. https://s3-us-west-2.amazonaws.com. Either region or endpoint needs to be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>KMS key used if encryption is enabled and encryption type is set to sse-kms.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>S3 region, e.g. us-west-2. Either region or endpoint must be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderInitScriptsVolumes
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderInitScriptsWorkspace
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderInitScripts
{
    [JsonPropertyName("abfss")]
    public V1beta1ClusterSpecForProviderInitScriptsAbfss? Abfss { get; set; }

    [JsonPropertyName("dbfs")]
    public V1beta1ClusterSpecForProviderInitScriptsDbfs? Dbfs { get; set; }

    [JsonPropertyName("file")]
    public V1beta1ClusterSpecForProviderInitScriptsFile? File { get; set; }

    [JsonPropertyName("gcs")]
    public V1beta1ClusterSpecForProviderInitScriptsGcs? Gcs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1ClusterSpecForProviderInitScriptsS3? S3 { get; set; }

    [JsonPropertyName("volumes")]
    public V1beta1ClusterSpecForProviderInitScriptsVolumes? Volumes { get; set; }

    [JsonPropertyName("workspace")]
    public V1beta1ClusterSpecForProviderInitScriptsWorkspace? Workspace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLibraryMaven
{
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1ClusterSpecForProviderLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1ClusterSpecForProviderLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1ClusterSpecForProviderLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderWorkloadTypeClients
{
    /// <summary>boolean flag defining if it&apos;s possible to run Databricks Jobs on this cluster. Default: true.</summary>
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    /// <summary>boolean flag defining if it&apos;s possible to run notebooks on this cluster. Default: true.</summary>
    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderWorkloadType
{
    [JsonPropertyName("clients")]
    public V1beta1ClusterSpecForProviderWorkloadTypeClients? Clients { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProvider
{
    /// <summary>Whether to use policy default values for missing cluster attributes.</summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    [JsonPropertyName("autoscale")]
    public V1beta1ClusterSpecForProviderAutoscale? Autoscale { get; set; }

    /// <summary>Automatically terminate the cluster after being inactive for this time in minutes. If specified, the threshold must be between 10 and 10000 minutes. You can also set this value to 0 to explicitly disable automatic termination. Defaults to 60.  We highly recommend having this setting present for Interactive/BI clusters.</summary>
    [JsonPropertyName("autoterminationMinutes")]
    public double? AutoterminationMinutes { get; set; }

    [JsonPropertyName("awsAttributes")]
    public V1beta1ClusterSpecForProviderAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1ClusterSpecForProviderAzureAttributes? AzureAttributes { get; set; }

    [JsonPropertyName("clusterLogConf")]
    public V1beta1ClusterSpecForProviderClusterLogConf? ClusterLogConf { get; set; }

    [JsonPropertyName("clusterMountInfo")]
    public IList<V1beta1ClusterSpecForProviderClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>Cluster name, which doesn’t have to be unique. If not specified at creation, the cluster name will be an empty string.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Additional tags for cluster resources. Databricks will tag all cluster resources (e.g., AWS EC2 instances and EBS volumes) with these tags in addition to default_tags. If a custom cluster tag has the same name as a default cluster tag, the custom tag is prefixed with an x_ when it is propagated.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>Select the security features of the cluster (see API docs for full list of values). Unity Catalog requires SINGLE_USER or USER_ISOLATION mode. LEGACY_PASSTHROUGH for passthrough cluster and LEGACY_TABLE_ACL for Table ACL cluster. If omitted, default security features are enabled. To disable security features use NONE or legacy mode NO_ISOLATION.  If kind is specified, then the following options are available:</summary>
    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    [JsonPropertyName("dockerImage")]
    public V1beta1ClusterSpecForProviderDockerImage? DockerImage { get; set; }

    /// <summary>similar to instance_pool_id, but for driver node. If omitted, and instance_pool_id is specified, then the driver will be allocated from that pool.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>The node type of the Spark driver. This field is optional; if unset, API will set the driver node type to the same value as node_type_id defined above.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary>If you don’t want to allocate a fixed number of EBS volumes at cluster creation time, use autoscaling local storage. With autoscaling local storage, Databricks monitors the amount of free disk space available on your cluster’s Spark workers. If a worker begins to run too low on disk, Databricks automatically attaches a new EBS volume to the worker before it runs out of disk space. EBS volumes are attached up to a limit of 5 TB of total disk space per instance (including the instance’s local storage). To scale down EBS usage, make sure you have autotermination_minutes and autoscale attributes set. More documentation available at cluster configuration page.</summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary>Some instance types you use to run clusters may have locally attached disks. Databricks may store shuffle data or temporary data on these locally attached disks. To ensure that all data at rest is encrypted for all storage types, including shuffle data stored temporarily on your cluster’s local disks, you can enable local disk encryption. When local disk encryption is enabled, Databricks generates an encryption key locally unique to each cluster node and uses it to encrypt all data stored on local disks. The scope of the key is local to each cluster node and is destroyed along with the cluster node itself. During its lifetime, the key resides in memory for encryption and decryption and is stored encrypted on the disk. Your workloads may run more slowly because of the performance impact of reading and writing encrypted data to and from local volumes. This feature is not available for all Azure Databricks subscriptions. Contact your Microsoft or Databricks account representative to request access.</summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1ClusterSpecForProviderGcpAttributes? GcpAttributes { get; set; }

    /// <summary>An optional token to guarantee the idempotency of cluster creation requests. If an active cluster with the provided token already exists, the request will not create a new cluster, but it will return the existing running cluster&apos;s ID instead. If you specify the idempotency token, upon failure, you can retry until the request succeeds. Databricks platform guarantees to launch exactly one cluster with that idempotency token. This token should have at most 64 characters.</summary>
    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    [JsonPropertyName("initScripts")]
    public IList<V1beta1ClusterSpecForProviderInitScripts>? InitScripts { get; set; }

    /// <summary>required if node_type_id is not given) - To reduce cluster start time, you can attach a cluster to a predefined pool of idle instances. When attached to a pool, a cluster allocates its driver and worker nodes from the pool. If the pool does not have sufficient idle resources to accommodate the cluster’s request, it expands by allocating new instances from the instance provider. When an attached cluster changes its state to TERMINATED, the instances it used are returned to the pool and reused by a different cluster.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary>boolean value specifying if the cluster is pinned (not pinned by default). You must be a Databricks administrator to use this.  The pinned clusters&apos; maximum number is limited to 100, so apply may fail if you have more than that (this number may change over time, so check Databricks documentation for actual number).</summary>
    [JsonPropertyName("isPinned")]
    public bool? IsPinned { get; set; }

    /// <summary>When set to true, Databricks will automatically set single node related custom_tags, spark_conf, and num_workers.</summary>
    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    /// <summary>The kind of compute described by this compute specification.  Possible values (see API docs for full list): CLASSIC_PREVIEW (if corresponding public preview is enabled).</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("library")]
    public IList<V1beta1ClusterSpecForProviderLibrary>? Library { get; set; }

    /// <summary>If true, the provider will not wait for the cluster to reach RUNNING state when creating the cluster, allowing cluster creation and library installation to continue asynchronously. Defaults to false (the provider will wait for cluster creation and library installation to succeed).</summary>
    [JsonPropertyName("noWait")]
    public bool? NoWait { get; set; }

    /// <summary>Any supported databricks_node_type id. If instance_pool_id is specified, this field is not needed.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary>Number of worker nodes that this cluster should have. A cluster has one Spark driver and num_workers executors for a total of num_workers + 1 Spark nodes.</summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>Identifier of Cluster Policy to validate cluster and preset certain defaults. The primary use for cluster policies is to allow users to create policy-scoped clusters via UI rather than sharing configuration for API-created clusters. For example, when you specify policy_id of external metastore policy, you still have to fill in relevant keys for spark_conf.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary>The type of runtime engine to use. If not specified, the runtime engine type is inferred based on the spark_version value. Allowed values include: PHOTON, STANDARD.</summary>
    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>The optional user name of the user (or group name if kind if specified) to assign to an interactive cluster. This field is required when using data_security_mode set to SINGLE_USER or AAD Passthrough for Azure Data Lake Storage (ADLS) with a single-user cluster (i.e., not high-concurrency clusters).</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    /// <summary>Map with key-value pairs to fine-tune Spark clusters, where you can provide custom Spark configuration properties in a cluster configuration.</summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary>Map with environment variable key-value pairs to fine-tune Spark clusters. Key-value pairs of the form (X,Y) are exported (i.e., X=&apos;Y&apos;) while launching the driver and workers.</summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>Runtime version of the cluster. Any supported databricks_spark_version id.  We advise using Cluster Policies to restrict the list of versions for simplicity while maintaining enough control.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary>SSH public key contents that will be added to each Spark node in this cluster. The corresponding private keys can be used to login with the user name ubuntu on port 2200. You can specify up to 10 keys.</summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    /// <summary>Whenever ML runtime should be selected or not.  Actual runtime is determined by spark_version (DBR release), this field use_ml_runtime, and whether node_type_id is GPU node or not.</summary>
    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    [JsonPropertyName("workloadType")]
    public V1beta1ClusterSpecForProviderWorkloadType? WorkloadType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAutoscale
{
    /// <summary>The maximum number of workers to which the cluster can scale up when overloaded. max_workers must be strictly greater than min_workers.</summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary>The minimum number of workers to which the cluster can scale down when underutilized. It is also the initial number of workers the cluster will have after creation.</summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAwsAttributes
{
    /// <summary>Availability type used for all subsequent nodes past the first_on_demand ones. Valid values are SPOT, SPOT_WITH_FALLBACK and ON_DEMAND. Note: If first_on_demand is zero, this availability type will be used for the entire cluster. Backend default value is SPOT_WITH_FALLBACK and could change in the future</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>The number of volumes launched for each instance. You can choose up to 10 volumes. This feature is only enabled for supported node types. Legacy node types cannot specify custom EBS volumes. For node types with no instance store, at least one EBS volume needs to be specified; otherwise, cluster creation will fail. These EBS volumes will be mounted at /ebs0, /ebs1, and etc. Instance store volumes will be mounted at /local_disk0, /local_disk1, and etc. If EBS volumes are attached, Databricks will configure Spark to use only the EBS volumes for scratch storage because heterogeneously sized scratch devices can lead to inefficient disk utilization. If no EBS volumes are attached, Databricks will configure Spark to use instance store volumes. If EBS volumes are specified, then the Spark configuration spark.local.dir will be overridden.</summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary>The size of each EBS volume (in GiB) launched for each instance. For general purpose SSD, this value must be within the range 100 - 4096. For throughput optimized HDD, this value must be within the range 500 - 4096. Custom EBS volumes cannot be specified for the legacy node types (memory-optimized and compute-optimized).</summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary>The type of EBS volumes that will be launched with this cluster. Valid values are GENERAL_PURPOSE_SSD or THROUGHPUT_OPTIMIZED_HDD. Use this option only if you&apos;re not picking Delta Optimized  node types.</summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary>The first first_on_demand nodes of the cluster will be placed on on-demand instances. If this value is greater than 0, the cluster driver node will be placed on an on-demand instance. If this value is greater than or equal to the current cluster size, all nodes will be placed on on-demand instances. If this value is less than the current cluster size, first_on_demand nodes will be placed on on-demand instances, and the remainder will be placed on availability instances. This value does not affect cluster size and cannot be mutated over the lifetime of a cluster. Backend default value is 1 and could change in the future</summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary>Nodes for this cluster will only be placed on AWS instances with this instance profile.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>The max price for AWS spot instances, as a percentage of the corresponding instance type’s on-demand price. For example, if this field is set to 50, and the cluster needs a new i3.xlarge spot instance, then the max price is half of the price of on-demand i3.xlarge instances. Similarly, if this field is set to 200, the max price is twice the price of on-demand i3.xlarge instances. If not specified, the default value is 100. When spot instances are requested for this cluster, only spot instances whose max price percentage matches this field will be considered. For safety, we enforce this field to be no more than 10000.</summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>Identifier for the availability zone/datacenter in which the cluster resides. This string will be of a form like us-west-2a. The provided availability zone must be in the same region as the Databricks deployment. For example, us-west-2a is not a valid zone ID if the Databricks deployment resides in the us-east-1 region. Enable automatic availability zone selection (&quot;Auto-AZ&quot;), by setting the value auto. Databricks selects the AZ based on available IPs in the workspace subnets and retries in other availability zones if AWS returns insufficient capacity errors.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAzureAttributesLogAnalyticsInfo
{
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>Canonical unique identifier for the cluster.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAzureAttributes
{
    /// <summary>Availability type used for all subsequent nodes past the first_on_demand ones. Valid values are SPOT_AZURE, SPOT_WITH_FALLBACK_AZURE, and ON_DEMAND_AZURE. Note: If first_on_demand is zero, this availability type will be used for the entire cluster.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>The first first_on_demand nodes of the cluster will be placed on on-demand instances. If this value is greater than 0, the cluster driver node will be placed on an on-demand instance. If this value is greater than or equal to the current cluster size, all nodes will be placed on on-demand instances. If this value is less than the current cluster size, first_on_demand nodes will be placed on on-demand instances, and the remainder will be placed on availability instances. This value does not affect cluster size and cannot be mutated over the lifetime of a cluster.</summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("logAnalyticsInfo")]
    public V1beta1ClusterSpecInitProviderAzureAttributesLogAnalyticsInfo? LogAnalyticsInfo { get; set; }

    /// <summary>The max bid price used for Azure spot instances. You can set this to greater than or equal to the current spot price. You can also set this to -1, which specifies that the instance cannot be evicted on the basis of price. The price for the instance will be the current price for spot instances or the price for a standard instance.</summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterLogConfDbfs
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterLogConfS3
{
    /// <summary>Set canned access control list, e.g. bucket-owner-full-control. If canned_cal is set, the cluster instance profile must have s3:PutObjectAcl permission on the destination bucket and prefix. The full list of possible canned ACLs can be found here. By default, only the object owner gets full control. If you are using a cross-account role for writing data, you may want to set bucket-owner-full-control to make bucket owners able to read the logs.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Enable server-side encryption, false by default.</summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary>The encryption type, it could be sse-s3 or sse-kms. It is used only when encryption is enabled, and the default type is sse-s3.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>S3 endpoint, e.g. https://s3-us-west-2.amazonaws.com. Either region or endpoint needs to be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>KMS key used if encryption is enabled and encryption type is set to sse-kms.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>S3 region, e.g. us-west-2. Either region or endpoint must be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterLogConf
{
    [JsonPropertyName("dbfs")]
    public V1beta1ClusterSpecInitProviderClusterLogConfDbfs? Dbfs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1ClusterSpecInitProviderClusterLogConfS3? S3 { get; set; }
}

/// <summary>block specifying connection. It consists of:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterMountInfoNetworkFilesystemInfo
{
    /// <summary>string that will be passed as options passed to the mount command.</summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>host name.</summary>
    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterMountInfo
{
    /// <summary>path inside the Spark container.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    /// <summary>block specifying connection. It consists of:</summary>
    [JsonPropertyName("networkFilesystemInfo")]
    public V1beta1ClusterSpecInitProviderClusterMountInfoNetworkFilesystemInfo? NetworkFilesystemInfo { get; set; }

    /// <summary>string specifying path to mount on the remote service.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderDockerImageBasicAuthPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>basic_auth.username and basic_auth.password for Docker repository. Docker registry credentials are encrypted when they are stored in Databricks internal storage and when they are passed to a registry upon fetching Docker images at cluster launch. However, other authenticated and authorized API users of this workspace can access the username and password.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderDockerImageBasicAuth
{
    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta1ClusterSpecInitProviderDockerImageBasicAuthPasswordSecretRef PasswordSecretRef { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderDockerImage
{
    /// <summary>basic_auth.username and basic_auth.password for Docker repository. Docker registry credentials are encrypted when they are stored in Databricks internal storage and when they are passed to a registry upon fetching Docker images at cluster launch. However, other authenticated and authorized API users of this workspace can access the username and password.</summary>
    [JsonPropertyName("basicAuth")]
    public V1beta1ClusterSpecInitProviderDockerImageBasicAuth? BasicAuth { get; set; }

    /// <summary>URL for the Docker image</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderGcpAttributes
{
    /// <summary>, and will be removed soon.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>Boot disk size in GB</summary>
    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    /// <summary>Google Service Account email address that the cluster uses to authenticate with Google Identity. This field is used for authentication with the GCS and BigQuery data sources.</summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary>Number of local SSD disks (each is 375GB in size) that will be attached to each node of the cluster.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>if we should use preemptible executors (GCP documentation). Warning: this field is deprecated in favor of</summary>
    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>Identifier for the availability zone in which the cluster resides. This can be one of the following:</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderInitScriptsAbfss
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderInitScriptsDbfs
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderInitScriptsFile
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderInitScriptsGcs
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderInitScriptsS3
{
    /// <summary>Set canned access control list, e.g. bucket-owner-full-control. If canned_cal is set, the cluster instance profile must have s3:PutObjectAcl permission on the destination bucket and prefix. The full list of possible canned ACLs can be found here. By default, only the object owner gets full control. If you are using a cross-account role for writing data, you may want to set bucket-owner-full-control to make bucket owners able to read the logs.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Enable server-side encryption, false by default.</summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary>The encryption type, it could be sse-s3 or sse-kms. It is used only when encryption is enabled, and the default type is sse-s3.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>S3 endpoint, e.g. https://s3-us-west-2.amazonaws.com. Either region or endpoint needs to be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>KMS key used if encryption is enabled and encryption type is set to sse-kms.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>S3 region, e.g. us-west-2. Either region or endpoint must be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderInitScriptsVolumes
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderInitScriptsWorkspace
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderInitScripts
{
    [JsonPropertyName("abfss")]
    public V1beta1ClusterSpecInitProviderInitScriptsAbfss? Abfss { get; set; }

    [JsonPropertyName("dbfs")]
    public V1beta1ClusterSpecInitProviderInitScriptsDbfs? Dbfs { get; set; }

    [JsonPropertyName("file")]
    public V1beta1ClusterSpecInitProviderInitScriptsFile? File { get; set; }

    [JsonPropertyName("gcs")]
    public V1beta1ClusterSpecInitProviderInitScriptsGcs? Gcs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1ClusterSpecInitProviderInitScriptsS3? S3 { get; set; }

    [JsonPropertyName("volumes")]
    public V1beta1ClusterSpecInitProviderInitScriptsVolumes? Volumes { get; set; }

    [JsonPropertyName("workspace")]
    public V1beta1ClusterSpecInitProviderInitScriptsWorkspace? Workspace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLibraryMaven
{
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1ClusterSpecInitProviderLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1ClusterSpecInitProviderLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1ClusterSpecInitProviderLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderWorkloadTypeClients
{
    /// <summary>boolean flag defining if it&apos;s possible to run Databricks Jobs on this cluster. Default: true.</summary>
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    /// <summary>boolean flag defining if it&apos;s possible to run notebooks on this cluster. Default: true.</summary>
    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderWorkloadType
{
    [JsonPropertyName("clients")]
    public V1beta1ClusterSpecInitProviderWorkloadTypeClients? Clients { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProvider
{
    /// <summary>Whether to use policy default values for missing cluster attributes.</summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    [JsonPropertyName("autoscale")]
    public V1beta1ClusterSpecInitProviderAutoscale? Autoscale { get; set; }

    /// <summary>Automatically terminate the cluster after being inactive for this time in minutes. If specified, the threshold must be between 10 and 10000 minutes. You can also set this value to 0 to explicitly disable automatic termination. Defaults to 60.  We highly recommend having this setting present for Interactive/BI clusters.</summary>
    [JsonPropertyName("autoterminationMinutes")]
    public double? AutoterminationMinutes { get; set; }

    [JsonPropertyName("awsAttributes")]
    public V1beta1ClusterSpecInitProviderAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1ClusterSpecInitProviderAzureAttributes? AzureAttributes { get; set; }

    [JsonPropertyName("clusterLogConf")]
    public V1beta1ClusterSpecInitProviderClusterLogConf? ClusterLogConf { get; set; }

    [JsonPropertyName("clusterMountInfo")]
    public IList<V1beta1ClusterSpecInitProviderClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>Cluster name, which doesn’t have to be unique. If not specified at creation, the cluster name will be an empty string.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Additional tags for cluster resources. Databricks will tag all cluster resources (e.g., AWS EC2 instances and EBS volumes) with these tags in addition to default_tags. If a custom cluster tag has the same name as a default cluster tag, the custom tag is prefixed with an x_ when it is propagated.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>Select the security features of the cluster (see API docs for full list of values). Unity Catalog requires SINGLE_USER or USER_ISOLATION mode. LEGACY_PASSTHROUGH for passthrough cluster and LEGACY_TABLE_ACL for Table ACL cluster. If omitted, default security features are enabled. To disable security features use NONE or legacy mode NO_ISOLATION.  If kind is specified, then the following options are available:</summary>
    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    [JsonPropertyName("dockerImage")]
    public V1beta1ClusterSpecInitProviderDockerImage? DockerImage { get; set; }

    /// <summary>similar to instance_pool_id, but for driver node. If omitted, and instance_pool_id is specified, then the driver will be allocated from that pool.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>The node type of the Spark driver. This field is optional; if unset, API will set the driver node type to the same value as node_type_id defined above.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary>If you don’t want to allocate a fixed number of EBS volumes at cluster creation time, use autoscaling local storage. With autoscaling local storage, Databricks monitors the amount of free disk space available on your cluster’s Spark workers. If a worker begins to run too low on disk, Databricks automatically attaches a new EBS volume to the worker before it runs out of disk space. EBS volumes are attached up to a limit of 5 TB of total disk space per instance (including the instance’s local storage). To scale down EBS usage, make sure you have autotermination_minutes and autoscale attributes set. More documentation available at cluster configuration page.</summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary>Some instance types you use to run clusters may have locally attached disks. Databricks may store shuffle data or temporary data on these locally attached disks. To ensure that all data at rest is encrypted for all storage types, including shuffle data stored temporarily on your cluster’s local disks, you can enable local disk encryption. When local disk encryption is enabled, Databricks generates an encryption key locally unique to each cluster node and uses it to encrypt all data stored on local disks. The scope of the key is local to each cluster node and is destroyed along with the cluster node itself. During its lifetime, the key resides in memory for encryption and decryption and is stored encrypted on the disk. Your workloads may run more slowly because of the performance impact of reading and writing encrypted data to and from local volumes. This feature is not available for all Azure Databricks subscriptions. Contact your Microsoft or Databricks account representative to request access.</summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1ClusterSpecInitProviderGcpAttributes? GcpAttributes { get; set; }

    /// <summary>An optional token to guarantee the idempotency of cluster creation requests. If an active cluster with the provided token already exists, the request will not create a new cluster, but it will return the existing running cluster&apos;s ID instead. If you specify the idempotency token, upon failure, you can retry until the request succeeds. Databricks platform guarantees to launch exactly one cluster with that idempotency token. This token should have at most 64 characters.</summary>
    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    [JsonPropertyName("initScripts")]
    public IList<V1beta1ClusterSpecInitProviderInitScripts>? InitScripts { get; set; }

    /// <summary>required if node_type_id is not given) - To reduce cluster start time, you can attach a cluster to a predefined pool of idle instances. When attached to a pool, a cluster allocates its driver and worker nodes from the pool. If the pool does not have sufficient idle resources to accommodate the cluster’s request, it expands by allocating new instances from the instance provider. When an attached cluster changes its state to TERMINATED, the instances it used are returned to the pool and reused by a different cluster.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary>boolean value specifying if the cluster is pinned (not pinned by default). You must be a Databricks administrator to use this.  The pinned clusters&apos; maximum number is limited to 100, so apply may fail if you have more than that (this number may change over time, so check Databricks documentation for actual number).</summary>
    [JsonPropertyName("isPinned")]
    public bool? IsPinned { get; set; }

    /// <summary>When set to true, Databricks will automatically set single node related custom_tags, spark_conf, and num_workers.</summary>
    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    /// <summary>The kind of compute described by this compute specification.  Possible values (see API docs for full list): CLASSIC_PREVIEW (if corresponding public preview is enabled).</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("library")]
    public IList<V1beta1ClusterSpecInitProviderLibrary>? Library { get; set; }

    /// <summary>If true, the provider will not wait for the cluster to reach RUNNING state when creating the cluster, allowing cluster creation and library installation to continue asynchronously. Defaults to false (the provider will wait for cluster creation and library installation to succeed).</summary>
    [JsonPropertyName("noWait")]
    public bool? NoWait { get; set; }

    /// <summary>Any supported databricks_node_type id. If instance_pool_id is specified, this field is not needed.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary>Number of worker nodes that this cluster should have. A cluster has one Spark driver and num_workers executors for a total of num_workers + 1 Spark nodes.</summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>Identifier of Cluster Policy to validate cluster and preset certain defaults. The primary use for cluster policies is to allow users to create policy-scoped clusters via UI rather than sharing configuration for API-created clusters. For example, when you specify policy_id of external metastore policy, you still have to fill in relevant keys for spark_conf.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary>The type of runtime engine to use. If not specified, the runtime engine type is inferred based on the spark_version value. Allowed values include: PHOTON, STANDARD.</summary>
    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>The optional user name of the user (or group name if kind if specified) to assign to an interactive cluster. This field is required when using data_security_mode set to SINGLE_USER or AAD Passthrough for Azure Data Lake Storage (ADLS) with a single-user cluster (i.e., not high-concurrency clusters).</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    /// <summary>Map with key-value pairs to fine-tune Spark clusters, where you can provide custom Spark configuration properties in a cluster configuration.</summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary>Map with environment variable key-value pairs to fine-tune Spark clusters. Key-value pairs of the form (X,Y) are exported (i.e., X=&apos;Y&apos;) while launching the driver and workers.</summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>Runtime version of the cluster. Any supported databricks_spark_version id.  We advise using Cluster Policies to restrict the list of versions for simplicity while maintaining enough control.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary>SSH public key contents that will be added to each Spark node in this cluster. The corresponding private keys can be used to login with the user name ubuntu on port 2200. You can specify up to 10 keys.</summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    /// <summary>Whenever ML runtime should be selected or not.  Actual runtime is determined by spark_version (DBR release), this field use_ml_runtime, and whether node_type_id is GPU node or not.</summary>
    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    [JsonPropertyName("workloadType")]
    public V1beta1ClusterSpecInitProviderWorkloadType? WorkloadType { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecManagementPoliciesEnum>))]
public enum V1beta1ClusterSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1ClusterSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ClusterSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1ClusterSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ClusterSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ClusterSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ClusterSpec defines the desired state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta1ClusterSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1ClusterSpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ClusterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAutoscale
{
    /// <summary>The maximum number of workers to which the cluster can scale up when overloaded. max_workers must be strictly greater than min_workers.</summary>
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    /// <summary>The minimum number of workers to which the cluster can scale down when underutilized. It is also the initial number of workers the cluster will have after creation.</summary>
    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAwsAttributes
{
    /// <summary>Availability type used for all subsequent nodes past the first_on_demand ones. Valid values are SPOT, SPOT_WITH_FALLBACK and ON_DEMAND. Note: If first_on_demand is zero, this availability type will be used for the entire cluster. Backend default value is SPOT_WITH_FALLBACK and could change in the future</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>The number of volumes launched for each instance. You can choose up to 10 volumes. This feature is only enabled for supported node types. Legacy node types cannot specify custom EBS volumes. For node types with no instance store, at least one EBS volume needs to be specified; otherwise, cluster creation will fail. These EBS volumes will be mounted at /ebs0, /ebs1, and etc. Instance store volumes will be mounted at /local_disk0, /local_disk1, and etc. If EBS volumes are attached, Databricks will configure Spark to use only the EBS volumes for scratch storage because heterogeneously sized scratch devices can lead to inefficient disk utilization. If no EBS volumes are attached, Databricks will configure Spark to use instance store volumes. If EBS volumes are specified, then the Spark configuration spark.local.dir will be overridden.</summary>
    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    /// <summary>The size of each EBS volume (in GiB) launched for each instance. For general purpose SSD, this value must be within the range 100 - 4096. For throughput optimized HDD, this value must be within the range 500 - 4096. Custom EBS volumes cannot be specified for the legacy node types (memory-optimized and compute-optimized).</summary>
    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    /// <summary>The type of EBS volumes that will be launched with this cluster. Valid values are GENERAL_PURPOSE_SSD or THROUGHPUT_OPTIMIZED_HDD. Use this option only if you&apos;re not picking Delta Optimized  node types.</summary>
    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    /// <summary>The first first_on_demand nodes of the cluster will be placed on on-demand instances. If this value is greater than 0, the cluster driver node will be placed on an on-demand instance. If this value is greater than or equal to the current cluster size, all nodes will be placed on on-demand instances. If this value is less than the current cluster size, first_on_demand nodes will be placed on on-demand instances, and the remainder will be placed on availability instances. This value does not affect cluster size and cannot be mutated over the lifetime of a cluster. Backend default value is 1 and could change in the future</summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    /// <summary>Nodes for this cluster will only be placed on AWS instances with this instance profile.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>The max price for AWS spot instances, as a percentage of the corresponding instance type’s on-demand price. For example, if this field is set to 50, and the cluster needs a new i3.xlarge spot instance, then the max price is half of the price of on-demand i3.xlarge instances. Similarly, if this field is set to 200, the max price is twice the price of on-demand i3.xlarge instances. If not specified, the default value is 100. When spot instances are requested for this cluster, only spot instances whose max price percentage matches this field will be considered. For safety, we enforce this field to be no more than 10000.</summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>Identifier for the availability zone/datacenter in which the cluster resides. This string will be of a form like us-west-2a. The provided availability zone must be in the same region as the Databricks deployment. For example, us-west-2a is not a valid zone ID if the Databricks deployment resides in the us-east-1 region. Enable automatic availability zone selection (&quot;Auto-AZ&quot;), by setting the value auto. Databricks selects the AZ based on available IPs in the workspace subnets and retries in other availability zones if AWS returns insufficient capacity errors.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAzureAttributesLogAnalyticsInfo
{
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>Canonical unique identifier for the cluster.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAzureAttributes
{
    /// <summary>Availability type used for all subsequent nodes past the first_on_demand ones. Valid values are SPOT_AZURE, SPOT_WITH_FALLBACK_AZURE, and ON_DEMAND_AZURE. Note: If first_on_demand is zero, this availability type will be used for the entire cluster.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>The first first_on_demand nodes of the cluster will be placed on on-demand instances. If this value is greater than 0, the cluster driver node will be placed on an on-demand instance. If this value is greater than or equal to the current cluster size, all nodes will be placed on on-demand instances. If this value is less than the current cluster size, first_on_demand nodes will be placed on on-demand instances, and the remainder will be placed on availability instances. This value does not affect cluster size and cannot be mutated over the lifetime of a cluster.</summary>
    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("logAnalyticsInfo")]
    public V1beta1ClusterStatusAtProviderAzureAttributesLogAnalyticsInfo? LogAnalyticsInfo { get; set; }

    /// <summary>The max bid price used for Azure spot instances. You can set this to greater than or equal to the current spot price. You can also set this to -1, which specifies that the instance cannot be evicted on the basis of price. The price for the instance will be the current price for spot instances or the price for a standard instance.</summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterLogConfDbfs
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterLogConfS3
{
    /// <summary>Set canned access control list, e.g. bucket-owner-full-control. If canned_cal is set, the cluster instance profile must have s3:PutObjectAcl permission on the destination bucket and prefix. The full list of possible canned ACLs can be found here. By default, only the object owner gets full control. If you are using a cross-account role for writing data, you may want to set bucket-owner-full-control to make bucket owners able to read the logs.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Enable server-side encryption, false by default.</summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary>The encryption type, it could be sse-s3 or sse-kms. It is used only when encryption is enabled, and the default type is sse-s3.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>S3 endpoint, e.g. https://s3-us-west-2.amazonaws.com. Either region or endpoint needs to be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>KMS key used if encryption is enabled and encryption type is set to sse-kms.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>S3 region, e.g. us-west-2. Either region or endpoint must be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterLogConf
{
    [JsonPropertyName("dbfs")]
    public V1beta1ClusterStatusAtProviderClusterLogConfDbfs? Dbfs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1ClusterStatusAtProviderClusterLogConfS3? S3 { get; set; }
}

/// <summary>block specifying connection. It consists of:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterMountInfoNetworkFilesystemInfo
{
    /// <summary>string that will be passed as options passed to the mount command.</summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>host name.</summary>
    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterMountInfo
{
    /// <summary>path inside the Spark container.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    /// <summary>block specifying connection. It consists of:</summary>
    [JsonPropertyName("networkFilesystemInfo")]
    public V1beta1ClusterStatusAtProviderClusterMountInfoNetworkFilesystemInfo? NetworkFilesystemInfo { get; set; }

    /// <summary>string specifying path to mount on the remote service.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}

/// <summary>basic_auth.username and basic_auth.password for Docker repository. Docker registry credentials are encrypted when they are stored in Databricks internal storage and when they are passed to a registry upon fetching Docker images at cluster launch. However, other authenticated and authorized API users of this workspace can access the username and password.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderDockerImageBasicAuth
{
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderDockerImage
{
    /// <summary>basic_auth.username and basic_auth.password for Docker repository. Docker registry credentials are encrypted when they are stored in Databricks internal storage and when they are passed to a registry upon fetching Docker images at cluster launch. However, other authenticated and authorized API users of this workspace can access the username and password.</summary>
    [JsonPropertyName("basicAuth")]
    public V1beta1ClusterStatusAtProviderDockerImageBasicAuth? BasicAuth { get; set; }

    /// <summary>URL for the Docker image</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderGcpAttributes
{
    /// <summary>, and will be removed soon.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>Boot disk size in GB</summary>
    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    /// <summary>Google Service Account email address that the cluster uses to authenticate with Google Identity. This field is used for authentication with the GCS and BigQuery data sources.</summary>
    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    /// <summary>Number of local SSD disks (each is 375GB in size) that will be attached to each node of the cluster.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>if we should use preemptible executors (GCP documentation). Warning: this field is deprecated in favor of</summary>
    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>Identifier for the availability zone in which the cluster resides. This can be one of the following:</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderInitScriptsAbfss
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderInitScriptsDbfs
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderInitScriptsFile
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderInitScriptsGcs
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderInitScriptsS3
{
    /// <summary>Set canned access control list, e.g. bucket-owner-full-control. If canned_cal is set, the cluster instance profile must have s3:PutObjectAcl permission on the destination bucket and prefix. The full list of possible canned ACLs can be found here. By default, only the object owner gets full control. If you are using a cross-account role for writing data, you may want to set bucket-owner-full-control to make bucket owners able to read the logs.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Enable server-side encryption, false by default.</summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary>The encryption type, it could be sse-s3 or sse-kms. It is used only when encryption is enabled, and the default type is sse-s3.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>S3 endpoint, e.g. https://s3-us-west-2.amazonaws.com. Either region or endpoint needs to be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>KMS key used if encryption is enabled and encryption type is set to sse-kms.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>S3 region, e.g. us-west-2. Either region or endpoint must be set. If both are set, the endpoint is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderInitScriptsVolumes
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderInitScriptsWorkspace
{
    /// <summary>S3 destination, e.g., s3://my-bucket/some-prefix You must configure the cluster with an instance profile, and the instance profile must have write access to the destination. You cannot use AWS keys.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderInitScripts
{
    [JsonPropertyName("abfss")]
    public V1beta1ClusterStatusAtProviderInitScriptsAbfss? Abfss { get; set; }

    [JsonPropertyName("dbfs")]
    public V1beta1ClusterStatusAtProviderInitScriptsDbfs? Dbfs { get; set; }

    [JsonPropertyName("file")]
    public V1beta1ClusterStatusAtProviderInitScriptsFile? File { get; set; }

    [JsonPropertyName("gcs")]
    public V1beta1ClusterStatusAtProviderInitScriptsGcs? Gcs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1ClusterStatusAtProviderInitScriptsS3? S3 { get; set; }

    [JsonPropertyName("volumes")]
    public V1beta1ClusterStatusAtProviderInitScriptsVolumes? Volumes { get; set; }

    [JsonPropertyName("workspace")]
    public V1beta1ClusterStatusAtProviderInitScriptsWorkspace? Workspace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderLibraryMaven
{
    [JsonPropertyName("coordinates")]
    public string? Coordinates { get; set; }

    [JsonPropertyName("exclusions")]
    public IList<string>? Exclusions { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1ClusterStatusAtProviderLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1ClusterStatusAtProviderLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1ClusterStatusAtProviderLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderWorkloadTypeClients
{
    /// <summary>boolean flag defining if it&apos;s possible to run Databricks Jobs on this cluster. Default: true.</summary>
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    /// <summary>boolean flag defining if it&apos;s possible to run notebooks on this cluster. Default: true.</summary>
    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderWorkloadType
{
    [JsonPropertyName("clients")]
    public V1beta1ClusterStatusAtProviderWorkloadTypeClients? Clients { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProvider
{
    /// <summary>Whether to use policy default values for missing cluster attributes.</summary>
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    [JsonPropertyName("autoscale")]
    public V1beta1ClusterStatusAtProviderAutoscale? Autoscale { get; set; }

    /// <summary>Automatically terminate the cluster after being inactive for this time in minutes. If specified, the threshold must be between 10 and 10000 minutes. You can also set this value to 0 to explicitly disable automatic termination. Defaults to 60.  We highly recommend having this setting present for Interactive/BI clusters.</summary>
    [JsonPropertyName("autoterminationMinutes")]
    public double? AutoterminationMinutes { get; set; }

    [JsonPropertyName("awsAttributes")]
    public V1beta1ClusterStatusAtProviderAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1ClusterStatusAtProviderAzureAttributes? AzureAttributes { get; set; }

    /// <summary>Canonical unique identifier for the cluster.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    [JsonPropertyName("clusterLogConf")]
    public V1beta1ClusterStatusAtProviderClusterLogConf? ClusterLogConf { get; set; }

    [JsonPropertyName("clusterMountInfo")]
    public IList<V1beta1ClusterStatusAtProviderClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>Cluster name, which doesn’t have to be unique. If not specified at creation, the cluster name will be an empty string.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Additional tags for cluster resources. Databricks will tag all cluster resources (e.g., AWS EC2 instances and EBS volumes) with these tags in addition to default_tags. If a custom cluster tag has the same name as a default cluster tag, the custom tag is prefixed with an x_ when it is propagated.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>Select the security features of the cluster (see API docs for full list of values). Unity Catalog requires SINGLE_USER or USER_ISOLATION mode. LEGACY_PASSTHROUGH for passthrough cluster and LEGACY_TABLE_ACL for Table ACL cluster. If omitted, default security features are enabled. To disable security features use NONE or legacy mode NO_ISOLATION.  If kind is specified, then the following options are available:</summary>
    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    /// <summary>(map) Tags that are added by Databricks by default, regardless of any custom_tags that may have been added. These include: Vendor: Databricks, Creator: &lt;username_of_creator&gt;, ClusterName: &lt;name_of_cluster&gt;, ClusterId: &lt;id_of_cluster&gt;, Name: , and any workspace and pool tags.</summary>
    [JsonPropertyName("defaultTags")]
    public IDictionary<string, string>? DefaultTags { get; set; }

    [JsonPropertyName("dockerImage")]
    public V1beta1ClusterStatusAtProviderDockerImage? DockerImage { get; set; }

    /// <summary>similar to instance_pool_id, but for driver node. If omitted, and instance_pool_id is specified, then the driver will be allocated from that pool.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>The node type of the Spark driver. This field is optional; if unset, API will set the driver node type to the same value as node_type_id defined above.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    /// <summary>If you don’t want to allocate a fixed number of EBS volumes at cluster creation time, use autoscaling local storage. With autoscaling local storage, Databricks monitors the amount of free disk space available on your cluster’s Spark workers. If a worker begins to run too low on disk, Databricks automatically attaches a new EBS volume to the worker before it runs out of disk space. EBS volumes are attached up to a limit of 5 TB of total disk space per instance (including the instance’s local storage). To scale down EBS usage, make sure you have autotermination_minutes and autoscale attributes set. More documentation available at cluster configuration page.</summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    /// <summary>Some instance types you use to run clusters may have locally attached disks. Databricks may store shuffle data or temporary data on these locally attached disks. To ensure that all data at rest is encrypted for all storage types, including shuffle data stored temporarily on your cluster’s local disks, you can enable local disk encryption. When local disk encryption is enabled, Databricks generates an encryption key locally unique to each cluster node and uses it to encrypt all data stored on local disks. The scope of the key is local to each cluster node and is destroyed along with the cluster node itself. During its lifetime, the key resides in memory for encryption and decryption and is stored encrypted on the disk. Your workloads may run more slowly because of the performance impact of reading and writing encrypted data to and from local volumes. This feature is not available for all Azure Databricks subscriptions. Contact your Microsoft or Databricks account representative to request access.</summary>
    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1ClusterStatusAtProviderGcpAttributes? GcpAttributes { get; set; }

    /// <summary>Canonical unique identifier for the cluster.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An optional token to guarantee the idempotency of cluster creation requests. If an active cluster with the provided token already exists, the request will not create a new cluster, but it will return the existing running cluster&apos;s ID instead. If you specify the idempotency token, upon failure, you can retry until the request succeeds. Databricks platform guarantees to launch exactly one cluster with that idempotency token. This token should have at most 64 characters.</summary>
    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    [JsonPropertyName("initScripts")]
    public IList<V1beta1ClusterStatusAtProviderInitScripts>? InitScripts { get; set; }

    /// <summary>required if node_type_id is not given) - To reduce cluster start time, you can attach a cluster to a predefined pool of idle instances. When attached to a pool, a cluster allocates its driver and worker nodes from the pool. If the pool does not have sufficient idle resources to accommodate the cluster’s request, it expands by allocating new instances from the instance provider. When an attached cluster changes its state to TERMINATED, the instances it used are returned to the pool and reused by a different cluster.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary>boolean value specifying if the cluster is pinned (not pinned by default). You must be a Databricks administrator to use this.  The pinned clusters&apos; maximum number is limited to 100, so apply may fail if you have more than that (this number may change over time, so check Databricks documentation for actual number).</summary>
    [JsonPropertyName("isPinned")]
    public bool? IsPinned { get; set; }

    /// <summary>When set to true, Databricks will automatically set single node related custom_tags, spark_conf, and num_workers.</summary>
    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    /// <summary>The kind of compute described by this compute specification.  Possible values (see API docs for full list): CLASSIC_PREVIEW (if corresponding public preview is enabled).</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("library")]
    public IList<V1beta1ClusterStatusAtProviderLibrary>? Library { get; set; }

    /// <summary>If true, the provider will not wait for the cluster to reach RUNNING state when creating the cluster, allowing cluster creation and library installation to continue asynchronously. Defaults to false (the provider will wait for cluster creation and library installation to succeed).</summary>
    [JsonPropertyName("noWait")]
    public bool? NoWait { get; set; }

    /// <summary>Any supported databricks_node_type id. If instance_pool_id is specified, this field is not needed.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    /// <summary>Number of worker nodes that this cluster should have. A cluster has one Spark driver and num_workers executors for a total of num_workers + 1 Spark nodes.</summary>
    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>Identifier of Cluster Policy to validate cluster and preset certain defaults. The primary use for cluster policies is to allow users to create policy-scoped clusters via UI rather than sharing configuration for API-created clusters. For example, when you specify policy_id of external metastore policy, you still have to fill in relevant keys for spark_conf.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary>The type of runtime engine to use. If not specified, the runtime engine type is inferred based on the spark_version value. Allowed values include: PHOTON, STANDARD.</summary>
    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>The optional user name of the user (or group name if kind if specified) to assign to an interactive cluster. This field is required when using data_security_mode set to SINGLE_USER or AAD Passthrough for Azure Data Lake Storage (ADLS) with a single-user cluster (i.e., not high-concurrency clusters).</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    /// <summary>Map with key-value pairs to fine-tune Spark clusters, where you can provide custom Spark configuration properties in a cluster configuration.</summary>
    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    /// <summary>Map with environment variable key-value pairs to fine-tune Spark clusters. Key-value pairs of the form (X,Y) are exported (i.e., X=&apos;Y&apos;) while launching the driver and workers.</summary>
    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>Runtime version of the cluster. Any supported databricks_spark_version id.  We advise using Cluster Policies to restrict the list of versions for simplicity while maintaining enough control.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary>SSH public key contents that will be added to each Spark node in this cluster. The corresponding private keys can be used to login with the user name ubuntu on port 2200. You can specify up to 10 keys.</summary>
    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    /// <summary>(string) State of the cluster.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>URL for the Docker image</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Whenever ML runtime should be selected or not.  Actual runtime is determined by spark_version (DBR release), this field use_ml_runtime, and whether node_type_id is GPU node or not.</summary>
    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    [JsonPropertyName("workloadType")]
    public V1beta1ClusterStatusAtProviderWorkloadType? WorkloadType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ClusterStatus defines the observed state of Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterSpec>, IStatus<V1beta1ClusterStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "compute.databricks.upbound.io";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.databricks.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Cluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ClusterSpec defines the desired state of Cluster</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ClusterSpec Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1ClusterStatus? Status { get; set; }
}
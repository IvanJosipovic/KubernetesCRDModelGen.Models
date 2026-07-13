#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.databricks.crossplane.io;
/// <summary>InstancePool is the Schema for the InstancePools API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InstancePoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta1InstancePool>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InstancePoolList";
    public const string KubeGroup = "compute.databricks.crossplane.io";
    public const string KubePluralName = "instancepools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstancePoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1InstancePool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1InstancePool> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstancePoolSpecDeletionPolicyEnum>))]
public enum V1beta1InstancePoolSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecForProviderAwsAttributes
{
    /// <summary>Availability type used for all nodes. Valid values are SPOT_AZURE and ON_DEMAND_AZURE.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>Nodes belonging to the pool will only be placed on AWS instances with this instance profile.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>(Integer) The max price for AWS spot instances, as a percentage of the corresponding instance type&apos;s on-demand price. For example, if this field is set to 50, and the instance pool needs a new i3.xlarge spot instance, then the max price is half of the price of on-demand i3.xlarge instances. Similarly, if this field is set to 200, the max price is twice the price of on-demand i3.xlarge instances. If not specified, the default value is 100. When spot instances are requested for this instance pool, only spot instances whose max price percentage matches this field are considered. For safety, this field cannot be greater than 10000.</summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>(String) Identifier for the availability zone/datacenter in which the instance pool resides. This string is of the form like &quot;us-west-2a&quot;. The provided availability zone must be in the same region as the Databricks deployment. For example, &quot;us-west-2a&quot; is not a valid zone ID if the Databricks deployment resides in the &quot;us-east-1&quot; region. If not specified, a default zone is used. You can find the list of available zones as well as the default value by using the List Zones API.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecForProviderAzureAttributes
{
    /// <summary>Availability type used for all nodes. Valid values are SPOT_AZURE and ON_DEMAND_AZURE.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>The max bid price used for Azure spot instances. You can set this to greater than or equal to the current spot price. You can also set this to -1, which specifies that the instance cannot be evicted on the basis of price. The price for the instance will be the current price for spot instances or the price for a standard instance.</summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecForProviderDiskSpecDiskType
{
    [JsonPropertyName("azureDiskVolumeType")]
    public string? AzureDiskVolumeType { get; set; }

    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecForProviderDiskSpec
{
    /// <summary>(Integer) The number of disks to attach to each instance. This feature is only enabled for supported node types. Users can choose up to the limit of the disks supported by the node type. For node types with no local disk, at least one disk needs to be specified.</summary>
    [JsonPropertyName("diskCount")]
    public double? DiskCount { get; set; }

    /// <summary>(Integer) The size of each disk (in GiB) to attach.</summary>
    [JsonPropertyName("diskSize")]
    public double? DiskSize { get; set; }

    [JsonPropertyName("diskType")]
    public V1beta1InstancePoolSpecForProviderDiskSpecDiskType? DiskType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecForProviderGcpAttributes
{
    /// <summary>Availability type used for all nodes. Valid values are PREEMPTIBLE_GCP, PREEMPTIBLE_WITH_FALLBACK_GCP and ON_DEMAND_GCP, default: ON_DEMAND_GCP.</summary>
    [JsonPropertyName("gcpAvailability")]
    public string? GcpAvailability { get; set; }

    /// <summary>Number of local SSD disks (each is 375GB in size) that will be attached to each node of the cluster.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>Identifier for the availability zone/datacenter in which the cluster resides. This string will be of a form like us-central1-a. The provided availability zone must be in the same region as the Databricks workspace.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecForProviderInstancePoolFleetAttributesFleetOnDemandOption
{
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecForProviderInstancePoolFleetAttributesFleetSpotOption
{
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecForProviderInstancePoolFleetAttributesLaunchTemplateOverride
{
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecForProviderInstancePoolFleetAttributes
{
    [JsonPropertyName("fleetOnDemandOption")]
    public V1beta1InstancePoolSpecForProviderInstancePoolFleetAttributesFleetOnDemandOption? FleetOnDemandOption { get; set; }

    [JsonPropertyName("fleetSpotOption")]
    public V1beta1InstancePoolSpecForProviderInstancePoolFleetAttributesFleetSpotOption? FleetSpotOption { get; set; }

    [JsonPropertyName("launchTemplateOverride")]
    public IList<V1beta1InstancePoolSpecForProviderInstancePoolFleetAttributesLaunchTemplateOverride>? LaunchTemplateOverride { get; set; }
}

/// <summary>a block describing the alternative driver node types if node_type_id isn&apos;t available.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecForProviderNodeTypeFlexibility
{
    /// <summary>list of alternative node types that will be used if main node type isn&apos;t available.  Follow the documentation for requirements on selection of alternative node types.</summary>
    [JsonPropertyName("alternateNodeTypeIds")]
    public IList<string>? AlternateNodeTypeIds { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecForProviderPreloadedDockerImageBasicAuthPasswordSecretRef
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

/// <summary>basic_auth.username and basic_auth.password for Docker repository. Docker registry credentials are encrypted when they are stored in Databricks internal storage and when they are passed to a registry upon fetching Docker images at cluster launch.  For better security, these credentials should be stored in the secret scope and referred using secret path syntax: {{secrets/scope/key}}, otherwise other users of the workspace may access them via UI/API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecForProviderPreloadedDockerImageBasicAuth
{
    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1InstancePoolSpecForProviderPreloadedDockerImageBasicAuthPasswordSecretRef? PasswordSecretRef { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecForProviderPreloadedDockerImage
{
    /// <summary>basic_auth.username and basic_auth.password for Docker repository. Docker registry credentials are encrypted when they are stored in Databricks internal storage and when they are passed to a registry upon fetching Docker images at cluster launch.  For better security, these credentials should be stored in the secret scope and referred using secret path syntax: {{secrets/scope/key}}, otherwise other users of the workspace may access them via UI/API.</summary>
    [JsonPropertyName("basicAuth")]
    public V1beta1InstancePoolSpecForProviderPreloadedDockerImageBasicAuth? BasicAuth { get; set; }

    /// <summary>URL for the Docker image</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecForProvider
{
    [JsonPropertyName("awsAttributes")]
    public V1beta1InstancePoolSpecForProviderAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1InstancePoolSpecForProviderAzureAttributes? AzureAttributes { get; set; }

    /// <summary>(Map) Additional tags for instance pool resources. Databricks tags all pool resources (e.g. AWS &amp; Azure instances and Disk volumes). The tags of the instance pool will propagate to the clusters using the pool (see the official documentation). Attempting to set the same tags in both cluster and instance pool will raise an error. Databricks allows at most 43 custom tags.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    [JsonPropertyName("diskSpec")]
    public V1beta1InstancePoolSpecForProviderDiskSpec? DiskSpec { get; set; }

    /// <summary>(Bool) Autoscaling Local Storage: when enabled, the instances in the pool dynamically acquire additional disk space when they are running low on disk space.</summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1InstancePoolSpecForProviderGcpAttributes? GcpAttributes { get; set; }

    /// <summary>(Integer) The number of minutes that idle instances in excess of the min_idle_instances are maintained by the pool before being terminated. If not specified, excess idle instances are terminated automatically after a default timeout period. If specified, the time must be between 0 and 10000 minutes. If you specify 0, excess idle instances are removed as soon as possible.</summary>
    [JsonPropertyName("idleInstanceAutoterminationMinutes")]
    public double? IdleInstanceAutoterminationMinutes { get; set; }

    [JsonPropertyName("instancePoolFleetAttributes")]
    public V1beta1InstancePoolSpecForProviderInstancePoolFleetAttributes? InstancePoolFleetAttributes { get; set; }

    /// <summary>Canonical unique identifier for the instance pool.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary>(String) The name of the instance pool. This is required for create and edit operations. It must be unique, non-empty, and less than 100 characters.</summary>
    [JsonPropertyName("instancePoolName")]
    public string? InstancePoolName { get; set; }

    /// <summary>(Integer) The maximum number of instances the pool can contain, including both idle instances and ones in use by clusters. Once the maximum capacity is reached, you cannot create new clusters from the pool and existing clusters cannot autoscale up until some instances are made idle in the pool via cluster termination or down-scaling. There is no default limit, but as a best practice, this should be set based on anticipated usage.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>(Integer) The minimum number of idle instances maintained by the pool. This is in addition to any instances in use by active clusters.</summary>
    [JsonPropertyName("minIdleInstances")]
    public double? MinIdleInstances { get; set; }

    /// <summary>a block describing the alternative driver node types if node_type_id isn&apos;t available.</summary>
    [JsonPropertyName("nodeTypeFlexibility")]
    public V1beta1InstancePoolSpecForProviderNodeTypeFlexibility? NodeTypeFlexibility { get; set; }

    /// <summary>(String) The node type for the instances in the pool. All clusters attached to the pool inherit this node type and the pool&apos;s idle instances are allocated based on this type. You can retrieve a list of available node types by using the List Node Types API call.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    [JsonPropertyName("preloadedDockerImage")]
    public IList<V1beta1InstancePoolSpecForProviderPreloadedDockerImage>? PreloadedDockerImage { get; set; }

    /// <summary>(List) A list with at most one runtime version the pool installs on each instance. Pool clusters that use a preloaded runtime version start faster as they do not have to wait for the image to download. You can retrieve them via databricks_spark_version data source or via  Runtime Versions API call.</summary>
    [JsonPropertyName("preloadedSparkVersions")]
    public IList<string>? PreloadedSparkVersions { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1InstancePoolSpecForProviderProviderConfig? ProviderConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecInitProviderAwsAttributes
{
    /// <summary>Availability type used for all nodes. Valid values are SPOT_AZURE and ON_DEMAND_AZURE.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>Nodes belonging to the pool will only be placed on AWS instances with this instance profile.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>(Integer) The max price for AWS spot instances, as a percentage of the corresponding instance type&apos;s on-demand price. For example, if this field is set to 50, and the instance pool needs a new i3.xlarge spot instance, then the max price is half of the price of on-demand i3.xlarge instances. Similarly, if this field is set to 200, the max price is twice the price of on-demand i3.xlarge instances. If not specified, the default value is 100. When spot instances are requested for this instance pool, only spot instances whose max price percentage matches this field are considered. For safety, this field cannot be greater than 10000.</summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>(String) Identifier for the availability zone/datacenter in which the instance pool resides. This string is of the form like &quot;us-west-2a&quot;. The provided availability zone must be in the same region as the Databricks deployment. For example, &quot;us-west-2a&quot; is not a valid zone ID if the Databricks deployment resides in the &quot;us-east-1&quot; region. If not specified, a default zone is used. You can find the list of available zones as well as the default value by using the List Zones API.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecInitProviderAzureAttributes
{
    /// <summary>Availability type used for all nodes. Valid values are SPOT_AZURE and ON_DEMAND_AZURE.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>The max bid price used for Azure spot instances. You can set this to greater than or equal to the current spot price. You can also set this to -1, which specifies that the instance cannot be evicted on the basis of price. The price for the instance will be the current price for spot instances or the price for a standard instance.</summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecInitProviderDiskSpecDiskType
{
    [JsonPropertyName("azureDiskVolumeType")]
    public string? AzureDiskVolumeType { get; set; }

    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecInitProviderDiskSpec
{
    /// <summary>(Integer) The number of disks to attach to each instance. This feature is only enabled for supported node types. Users can choose up to the limit of the disks supported by the node type. For node types with no local disk, at least one disk needs to be specified.</summary>
    [JsonPropertyName("diskCount")]
    public double? DiskCount { get; set; }

    /// <summary>(Integer) The size of each disk (in GiB) to attach.</summary>
    [JsonPropertyName("diskSize")]
    public double? DiskSize { get; set; }

    [JsonPropertyName("diskType")]
    public V1beta1InstancePoolSpecInitProviderDiskSpecDiskType? DiskType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecInitProviderGcpAttributes
{
    /// <summary>Availability type used for all nodes. Valid values are PREEMPTIBLE_GCP, PREEMPTIBLE_WITH_FALLBACK_GCP and ON_DEMAND_GCP, default: ON_DEMAND_GCP.</summary>
    [JsonPropertyName("gcpAvailability")]
    public string? GcpAvailability { get; set; }

    /// <summary>Number of local SSD disks (each is 375GB in size) that will be attached to each node of the cluster.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>Identifier for the availability zone/datacenter in which the cluster resides. This string will be of a form like us-central1-a. The provided availability zone must be in the same region as the Databricks workspace.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecInitProviderInstancePoolFleetAttributesFleetOnDemandOption
{
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecInitProviderInstancePoolFleetAttributesFleetSpotOption
{
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecInitProviderInstancePoolFleetAttributesLaunchTemplateOverride
{
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecInitProviderInstancePoolFleetAttributes
{
    [JsonPropertyName("fleetOnDemandOption")]
    public V1beta1InstancePoolSpecInitProviderInstancePoolFleetAttributesFleetOnDemandOption? FleetOnDemandOption { get; set; }

    [JsonPropertyName("fleetSpotOption")]
    public V1beta1InstancePoolSpecInitProviderInstancePoolFleetAttributesFleetSpotOption? FleetSpotOption { get; set; }

    [JsonPropertyName("launchTemplateOverride")]
    public IList<V1beta1InstancePoolSpecInitProviderInstancePoolFleetAttributesLaunchTemplateOverride>? LaunchTemplateOverride { get; set; }
}

/// <summary>a block describing the alternative driver node types if node_type_id isn&apos;t available.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecInitProviderNodeTypeFlexibility
{
    /// <summary>list of alternative node types that will be used if main node type isn&apos;t available.  Follow the documentation for requirements on selection of alternative node types.</summary>
    [JsonPropertyName("alternateNodeTypeIds")]
    public IList<string>? AlternateNodeTypeIds { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecInitProviderPreloadedDockerImageBasicAuthPasswordSecretRef
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

/// <summary>basic_auth.username and basic_auth.password for Docker repository. Docker registry credentials are encrypted when they are stored in Databricks internal storage and when they are passed to a registry upon fetching Docker images at cluster launch.  For better security, these credentials should be stored in the secret scope and referred using secret path syntax: {{secrets/scope/key}}, otherwise other users of the workspace may access them via UI/API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecInitProviderPreloadedDockerImageBasicAuth
{
    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta1InstancePoolSpecInitProviderPreloadedDockerImageBasicAuthPasswordSecretRef PasswordSecretRef { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecInitProviderPreloadedDockerImage
{
    /// <summary>basic_auth.username and basic_auth.password for Docker repository. Docker registry credentials are encrypted when they are stored in Databricks internal storage and when they are passed to a registry upon fetching Docker images at cluster launch.  For better security, these credentials should be stored in the secret scope and referred using secret path syntax: {{secrets/scope/key}}, otherwise other users of the workspace may access them via UI/API.</summary>
    [JsonPropertyName("basicAuth")]
    public V1beta1InstancePoolSpecInitProviderPreloadedDockerImageBasicAuth? BasicAuth { get; set; }

    /// <summary>URL for the Docker image</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
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
public partial class V1beta1InstancePoolSpecInitProvider
{
    [JsonPropertyName("awsAttributes")]
    public V1beta1InstancePoolSpecInitProviderAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1InstancePoolSpecInitProviderAzureAttributes? AzureAttributes { get; set; }

    /// <summary>(Map) Additional tags for instance pool resources. Databricks tags all pool resources (e.g. AWS &amp; Azure instances and Disk volumes). The tags of the instance pool will propagate to the clusters using the pool (see the official documentation). Attempting to set the same tags in both cluster and instance pool will raise an error. Databricks allows at most 43 custom tags.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    [JsonPropertyName("diskSpec")]
    public V1beta1InstancePoolSpecInitProviderDiskSpec? DiskSpec { get; set; }

    /// <summary>(Bool) Autoscaling Local Storage: when enabled, the instances in the pool dynamically acquire additional disk space when they are running low on disk space.</summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1InstancePoolSpecInitProviderGcpAttributes? GcpAttributes { get; set; }

    /// <summary>(Integer) The number of minutes that idle instances in excess of the min_idle_instances are maintained by the pool before being terminated. If not specified, excess idle instances are terminated automatically after a default timeout period. If specified, the time must be between 0 and 10000 minutes. If you specify 0, excess idle instances are removed as soon as possible.</summary>
    [JsonPropertyName("idleInstanceAutoterminationMinutes")]
    public double? IdleInstanceAutoterminationMinutes { get; set; }

    [JsonPropertyName("instancePoolFleetAttributes")]
    public V1beta1InstancePoolSpecInitProviderInstancePoolFleetAttributes? InstancePoolFleetAttributes { get; set; }

    /// <summary>Canonical unique identifier for the instance pool.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary>(String) The name of the instance pool. This is required for create and edit operations. It must be unique, non-empty, and less than 100 characters.</summary>
    [JsonPropertyName("instancePoolName")]
    public string? InstancePoolName { get; set; }

    /// <summary>(Integer) The maximum number of instances the pool can contain, including both idle instances and ones in use by clusters. Once the maximum capacity is reached, you cannot create new clusters from the pool and existing clusters cannot autoscale up until some instances are made idle in the pool via cluster termination or down-scaling. There is no default limit, but as a best practice, this should be set based on anticipated usage.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>(Integer) The minimum number of idle instances maintained by the pool. This is in addition to any instances in use by active clusters.</summary>
    [JsonPropertyName("minIdleInstances")]
    public double? MinIdleInstances { get; set; }

    /// <summary>a block describing the alternative driver node types if node_type_id isn&apos;t available.</summary>
    [JsonPropertyName("nodeTypeFlexibility")]
    public V1beta1InstancePoolSpecInitProviderNodeTypeFlexibility? NodeTypeFlexibility { get; set; }

    /// <summary>(String) The node type for the instances in the pool. All clusters attached to the pool inherit this node type and the pool&apos;s idle instances are allocated based on this type. You can retrieve a list of available node types by using the List Node Types API call.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    [JsonPropertyName("preloadedDockerImage")]
    public IList<V1beta1InstancePoolSpecInitProviderPreloadedDockerImage>? PreloadedDockerImage { get; set; }

    /// <summary>(List) A list with at most one runtime version the pool installs on each instance. Pool clusters that use a preloaded runtime version start faster as they do not have to wait for the image to download. You can retrieve them via databricks_spark_version data source or via  Runtime Versions API call.</summary>
    [JsonPropertyName("preloadedSparkVersions")]
    public IList<string>? PreloadedSparkVersions { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1InstancePoolSpecInitProviderProviderConfig? ProviderConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstancePoolSpecManagementPoliciesEnum>))]
public enum V1beta1InstancePoolSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstancePoolSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1InstancePoolSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1InstancePoolSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1InstancePoolSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1InstancePoolSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1InstancePoolSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1InstancePoolSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>InstancePoolSpec defines the desired state of InstancePool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolSpec
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
    public V1beta1InstancePoolSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1InstancePoolSpecForProvider ForProvider { get; set; }

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
    public V1beta1InstancePoolSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1InstancePoolSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1InstancePoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1InstancePoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolStatusAtProviderAwsAttributes
{
    /// <summary>Availability type used for all nodes. Valid values are SPOT_AZURE and ON_DEMAND_AZURE.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>Nodes belonging to the pool will only be placed on AWS instances with this instance profile.</summary>
    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>(Integer) The max price for AWS spot instances, as a percentage of the corresponding instance type&apos;s on-demand price. For example, if this field is set to 50, and the instance pool needs a new i3.xlarge spot instance, then the max price is half of the price of on-demand i3.xlarge instances. Similarly, if this field is set to 200, the max price is twice the price of on-demand i3.xlarge instances. If not specified, the default value is 100. When spot instances are requested for this instance pool, only spot instances whose max price percentage matches this field are considered. For safety, this field cannot be greater than 10000.</summary>
    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>(String) Identifier for the availability zone/datacenter in which the instance pool resides. This string is of the form like &quot;us-west-2a&quot;. The provided availability zone must be in the same region as the Databricks deployment. For example, &quot;us-west-2a&quot; is not a valid zone ID if the Databricks deployment resides in the &quot;us-east-1&quot; region. If not specified, a default zone is used. You can find the list of available zones as well as the default value by using the List Zones API.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolStatusAtProviderAzureAttributes
{
    /// <summary>Availability type used for all nodes. Valid values are SPOT_AZURE and ON_DEMAND_AZURE.</summary>
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    /// <summary>The max bid price used for Azure spot instances. You can set this to greater than or equal to the current spot price. You can also set this to -1, which specifies that the instance cannot be evicted on the basis of price. The price for the instance will be the current price for spot instances or the price for a standard instance.</summary>
    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolStatusAtProviderDiskSpecDiskType
{
    [JsonPropertyName("azureDiskVolumeType")]
    public string? AzureDiskVolumeType { get; set; }

    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolStatusAtProviderDiskSpec
{
    /// <summary>(Integer) The number of disks to attach to each instance. This feature is only enabled for supported node types. Users can choose up to the limit of the disks supported by the node type. For node types with no local disk, at least one disk needs to be specified.</summary>
    [JsonPropertyName("diskCount")]
    public double? DiskCount { get; set; }

    /// <summary>(Integer) The size of each disk (in GiB) to attach.</summary>
    [JsonPropertyName("diskSize")]
    public double? DiskSize { get; set; }

    [JsonPropertyName("diskType")]
    public V1beta1InstancePoolStatusAtProviderDiskSpecDiskType? DiskType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolStatusAtProviderGcpAttributes
{
    /// <summary>Availability type used for all nodes. Valid values are PREEMPTIBLE_GCP, PREEMPTIBLE_WITH_FALLBACK_GCP and ON_DEMAND_GCP, default: ON_DEMAND_GCP.</summary>
    [JsonPropertyName("gcpAvailability")]
    public string? GcpAvailability { get; set; }

    /// <summary>Number of local SSD disks (each is 375GB in size) that will be attached to each node of the cluster.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>Identifier for the availability zone/datacenter in which the cluster resides. This string will be of a form like us-central1-a. The provided availability zone must be in the same region as the Databricks workspace.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolStatusAtProviderInstancePoolFleetAttributesFleetOnDemandOption
{
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolStatusAtProviderInstancePoolFleetAttributesFleetSpotOption
{
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolStatusAtProviderInstancePoolFleetAttributesLaunchTemplateOverride
{
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolStatusAtProviderInstancePoolFleetAttributes
{
    [JsonPropertyName("fleetOnDemandOption")]
    public V1beta1InstancePoolStatusAtProviderInstancePoolFleetAttributesFleetOnDemandOption? FleetOnDemandOption { get; set; }

    [JsonPropertyName("fleetSpotOption")]
    public V1beta1InstancePoolStatusAtProviderInstancePoolFleetAttributesFleetSpotOption? FleetSpotOption { get; set; }

    [JsonPropertyName("launchTemplateOverride")]
    public IList<V1beta1InstancePoolStatusAtProviderInstancePoolFleetAttributesLaunchTemplateOverride>? LaunchTemplateOverride { get; set; }
}

/// <summary>a block describing the alternative driver node types if node_type_id isn&apos;t available.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolStatusAtProviderNodeTypeFlexibility
{
    /// <summary>list of alternative node types that will be used if main node type isn&apos;t available.  Follow the documentation for requirements on selection of alternative node types.</summary>
    [JsonPropertyName("alternateNodeTypeIds")]
    public IList<string>? AlternateNodeTypeIds { get; set; }
}

/// <summary>basic_auth.username and basic_auth.password for Docker repository. Docker registry credentials are encrypted when they are stored in Databricks internal storage and when they are passed to a registry upon fetching Docker images at cluster launch.  For better security, these credentials should be stored in the secret scope and referred using secret path syntax: {{secrets/scope/key}}, otherwise other users of the workspace may access them via UI/API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolStatusAtProviderPreloadedDockerImageBasicAuth
{
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolStatusAtProviderPreloadedDockerImage
{
    /// <summary>basic_auth.username and basic_auth.password for Docker repository. Docker registry credentials are encrypted when they are stored in Databricks internal storage and when they are passed to a registry upon fetching Docker images at cluster launch.  For better security, these credentials should be stored in the secret scope and referred using secret path syntax: {{secrets/scope/key}}, otherwise other users of the workspace may access them via UI/API.</summary>
    [JsonPropertyName("basicAuth")]
    public V1beta1InstancePoolStatusAtProviderPreloadedDockerImageBasicAuth? BasicAuth { get; set; }

    /// <summary>URL for the Docker image</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolStatusAtProvider
{
    [JsonPropertyName("awsAttributes")]
    public V1beta1InstancePoolStatusAtProviderAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1InstancePoolStatusAtProviderAzureAttributes? AzureAttributes { get; set; }

    /// <summary>(Map) Additional tags for instance pool resources. Databricks tags all pool resources (e.g. AWS &amp; Azure instances and Disk volumes). The tags of the instance pool will propagate to the clusters using the pool (see the official documentation). Attempting to set the same tags in both cluster and instance pool will raise an error. Databricks allows at most 43 custom tags.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    [JsonPropertyName("diskSpec")]
    public V1beta1InstancePoolStatusAtProviderDiskSpec? DiskSpec { get; set; }

    /// <summary>(Bool) Autoscaling Local Storage: when enabled, the instances in the pool dynamically acquire additional disk space when they are running low on disk space.</summary>
    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1InstancePoolStatusAtProviderGcpAttributes? GcpAttributes { get; set; }

    /// <summary>Canonical unique identifier for the instance pool.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>(Integer) The number of minutes that idle instances in excess of the min_idle_instances are maintained by the pool before being terminated. If not specified, excess idle instances are terminated automatically after a default timeout period. If specified, the time must be between 0 and 10000 minutes. If you specify 0, excess idle instances are removed as soon as possible.</summary>
    [JsonPropertyName("idleInstanceAutoterminationMinutes")]
    public double? IdleInstanceAutoterminationMinutes { get; set; }

    [JsonPropertyName("instancePoolFleetAttributes")]
    public V1beta1InstancePoolStatusAtProviderInstancePoolFleetAttributes? InstancePoolFleetAttributes { get; set; }

    /// <summary>Canonical unique identifier for the instance pool.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    /// <summary>(String) The name of the instance pool. This is required for create and edit operations. It must be unique, non-empty, and less than 100 characters.</summary>
    [JsonPropertyName("instancePoolName")]
    public string? InstancePoolName { get; set; }

    /// <summary>(Integer) The maximum number of instances the pool can contain, including both idle instances and ones in use by clusters. Once the maximum capacity is reached, you cannot create new clusters from the pool and existing clusters cannot autoscale up until some instances are made idle in the pool via cluster termination or down-scaling. There is no default limit, but as a best practice, this should be set based on anticipated usage.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>(Integer) The minimum number of idle instances maintained by the pool. This is in addition to any instances in use by active clusters.</summary>
    [JsonPropertyName("minIdleInstances")]
    public double? MinIdleInstances { get; set; }

    /// <summary>a block describing the alternative driver node types if node_type_id isn&apos;t available.</summary>
    [JsonPropertyName("nodeTypeFlexibility")]
    public V1beta1InstancePoolStatusAtProviderNodeTypeFlexibility? NodeTypeFlexibility { get; set; }

    /// <summary>(String) The node type for the instances in the pool. All clusters attached to the pool inherit this node type and the pool&apos;s idle instances are allocated based on this type. You can retrieve a list of available node types by using the List Node Types API call.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    [JsonPropertyName("preloadedDockerImage")]
    public IList<V1beta1InstancePoolStatusAtProviderPreloadedDockerImage>? PreloadedDockerImage { get; set; }

    /// <summary>(List) A list with at most one runtime version the pool installs on each instance. Pool clusters that use a preloaded runtime version start faster as they do not have to wait for the image to download. You can retrieve them via databricks_spark_version data source or via  Runtime Versions API call.</summary>
    [JsonPropertyName("preloadedSparkVersions")]
    public IList<string>? PreloadedSparkVersions { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1InstancePoolStatusAtProviderProviderConfig? ProviderConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolStatusConditions
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

/// <summary>InstancePoolStatus defines the observed state of InstancePool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1InstancePoolStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1InstancePoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1InstancePoolStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>InstancePool is the Schema for the InstancePools API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1InstancePool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1InstancePoolSpec>, IStatus<V1beta1InstancePoolStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "InstancePool";
    public const string KubeGroup = "compute.databricks.crossplane.io";
    public const string KubePluralName = "instancepools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstancePool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstancePoolSpec defines the desired state of InstancePool</summary>
    [JsonPropertyName("spec")]
    public required V1beta1InstancePoolSpec Spec { get; set; }

    /// <summary>InstancePoolStatus defines the observed state of InstancePool.</summary>
    [JsonPropertyName("status")]
    public V1beta1InstancePoolStatus? Status { get; set; }
}
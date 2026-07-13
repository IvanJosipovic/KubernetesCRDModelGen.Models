#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.databricks.m.upbound.io;
/// <summary>Job is the Schema for the Jobs API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1JobList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Job>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "JobList";
    public const string KubeGroup = "compute.databricks.m.upbound.io";
    public const string KubePluralName = "jobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.databricks.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "JobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Job objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Job> Items { get; set; }
}

/// <summary>Configuration block to configure pause status. See continuous Configuration Block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderContinuous
{
    /// <summary>Indicate whether this continuous job is paused or not. Either PAUSED or UNPAUSED. When the pause_status field is omitted in the block, the server will default to using UNPAUSED as a value for pause_status.</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderDbtTask
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with &quot;dbt&quot;.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>The relative path to the directory in the repository specified by git_source where dbt should look in for the profiles.yml file. If not specified, defaults to the repository&apos;s root directory. Equivalent to passing --profile-dir to a dbt command.</summary>
    [JsonPropertyName("profilesDirectory")]
    public string? ProfilesDirectory { get; set; }

    /// <summary>The path where dbt should look for dbt_project.yml. Equivalent to passing --project-dir to the dbt CLI.</summary>
    [JsonPropertyName("projectDirectory")]
    public string? ProjectDirectory { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderDeployment
{
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("metadataFilePath")]
    public string? MetadataFilePath { get; set; }
}

/// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderEmailNotifications
{
    /// <summary>(Bool) don&apos;t send alert for skipped runs. (It&apos;s recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }

    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<string>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<string>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<string>? OnStart { get; set; }

    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<string>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<string>? OnSuccess { get; set; }
}

/// <summary>block describing the Environment. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderEnvironmentSpec
{
    /// <summary>client version used by the environment.</summary>
    [JsonPropertyName("client")]
    public string? Client { get; set; }

    /// <summary>(list of strings) List of pip dependencies, as supported by the version of pip in this environment. Each dependency is a pip requirement file line.  See API docs for more information.</summary>
    [JsonPropertyName("dependencies")]
    public IList<string>? Dependencies { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderEnvironment
{
    /// <summary>identifier of an environment block that is used to specify libraries.  Required for some tasks (spark_python_task, python_wheel_task, ...) running on serverless compute.</summary>
    [JsonPropertyName("environmentKey")]
    public string? EnvironmentKey { get; set; }

    /// <summary>block describing the Environment. Consists of following attributes:</summary>
    [JsonPropertyName("spec")]
    public V1beta1JobSpecForProviderEnvironmentSpec? Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderGitSourceGitSnapshot
{
    /// <summary>hash of Git commit to use. Conflicts with branch and tag.</summary>
    [JsonPropertyName("usedCommit")]
    public string? UsedCommit { get; set; }
}

/// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderGitSourceJobSource
{
    [JsonPropertyName("dirtyState")]
    public string? DirtyState { get; set; }

    /// <summary>name of the Git branch to use. Conflicts with tag and commit.</summary>
    [JsonPropertyName("importFromGitBranch")]
    public string? ImportFromGitBranch { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("jobConfigPath")]
    public string? JobConfigPath { get; set; }
}

/// <summary>Specifices the a Git repository for task source code. See git_source Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderGitSource
{
    /// <summary>name of the Git branch to use. Conflicts with tag and commit.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>hash of Git commit to use. Conflicts with branch and tag.</summary>
    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    [JsonPropertyName("gitSnapshot")]
    public V1beta1JobSpecForProviderGitSourceGitSnapshot? GitSnapshot { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("jobSource")]
    public V1beta1JobSpecForProviderGitSourceJobSource? JobSource { get; set; }

    /// <summary>case insensitive name of the Git provider.  Following values are supported right now (could be a subject for change, consult Repos API documentation): gitHub, gitHubEnterprise, bitbucketCloud, bitbucketServer, azureDevOpsServices, gitLab, gitLabEnterpriseEdition.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>name of the Git branch to use. Conflicts with branch and commit.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderHealthRules
{
    /// <summary>string specifying the metric to check.  The only supported metric is RUN_DURATION_SECONDS (check Jobs REST API documentation for the latest information).</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>integer value used to compare to the given metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderHealth
{
    /// <summary>(List) list of rules that are represented as objects with the following attributes:</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1JobSpecForProviderHealthRules>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterAutoscale
{
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterAwsAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterAzureAttributesLogAnalyticsInfo
{
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterAzureAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("logAnalyticsInfo")]
    public V1beta1JobSpecForProviderJobClusterNewClusterAzureAttributesLogAnalyticsInfo? LogAnalyticsInfo { get; set; }

    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterClusterLogConfDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterClusterLogConfS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterClusterLogConf
{
    [JsonPropertyName("dbfs")]
    public V1beta1JobSpecForProviderJobClusterNewClusterClusterLogConfDbfs? Dbfs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobSpecForProviderJobClusterNewClusterClusterLogConfS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterClusterMountInfoNetworkFilesystemInfo
{
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    [JsonPropertyName("networkFilesystemInfo")]
    public V1beta1JobSpecForProviderJobClusterNewClusterClusterMountInfoNetworkFilesystemInfo? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterDockerImageBasicAuthPasswordSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterDockerImageBasicAuth
{
    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1JobSpecForProviderJobClusterNewClusterDockerImageBasicAuthPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterDockerImage
{
    [JsonPropertyName("basicAuth")]
    public V1beta1JobSpecForProviderJobClusterNewClusterDockerImageBasicAuth? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterGcpAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterInitScriptsAbfss
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterInitScriptsDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>block consisting of single string fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterInitScriptsFile
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterInitScriptsGcs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterInitScriptsS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterInitScriptsVolumes
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterInitScriptsWorkspace
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterInitScripts
{
    [JsonPropertyName("abfss")]
    public V1beta1JobSpecForProviderJobClusterNewClusterInitScriptsAbfss? Abfss { get; set; }

    [JsonPropertyName("dbfs")]
    public V1beta1JobSpecForProviderJobClusterNewClusterInitScriptsDbfs? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public V1beta1JobSpecForProviderJobClusterNewClusterInitScriptsFile? File { get; set; }

    [JsonPropertyName("gcs")]
    public V1beta1JobSpecForProviderJobClusterNewClusterInitScriptsGcs? Gcs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobSpecForProviderJobClusterNewClusterInitScriptsS3? S3 { get; set; }

    [JsonPropertyName("volumes")]
    public V1beta1JobSpecForProviderJobClusterNewClusterInitScriptsVolumes? Volumes { get; set; }

    [JsonPropertyName("workspace")]
    public V1beta1JobSpecForProviderJobClusterNewClusterInitScriptsWorkspace? Workspace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterLibraryMaven
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
public partial class V1beta1JobSpecForProviderJobClusterNewClusterLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobSpecForProviderJobClusterNewClusterLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobSpecForProviderJobClusterNewClusterLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobSpecForProviderJobClusterNewClusterLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterWorkloadTypeClients
{
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}

/// <summary>isn&apos;t supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewClusterWorkloadType
{
    [JsonPropertyName("clients")]
    public V1beta1JobSpecForProviderJobClusterNewClusterWorkloadTypeClients? Clients { get; set; }
}

/// <summary>Block with almost the same set of parameters as for databricks_cluster resource, except following (check the REST API documentation for full list of supported parameters):</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobClusterNewCluster
{
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    [JsonPropertyName("autoscale")]
    public V1beta1JobSpecForProviderJobClusterNewClusterAutoscale? Autoscale { get; set; }

    [JsonPropertyName("awsAttributes")]
    public V1beta1JobSpecForProviderJobClusterNewClusterAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1JobSpecForProviderJobClusterNewClusterAzureAttributes? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    [JsonPropertyName("clusterLogConf")]
    public V1beta1JobSpecForProviderJobClusterNewClusterClusterLogConf? ClusterLogConf { get; set; }

    [JsonPropertyName("clusterMountInfo")]
    public IList<V1beta1JobSpecForProviderJobClusterNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    [JsonPropertyName("dockerImage")]
    public V1beta1JobSpecForProviderJobClusterNewClusterDockerImage? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1JobSpecForProviderJobClusterNewClusterGcpAttributes? GcpAttributes { get; set; }

    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    [JsonPropertyName("initScripts")]
    public IList<V1beta1JobSpecForProviderJobClusterNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobSpecForProviderJobClusterNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn&apos;t supported</summary>
    [JsonPropertyName("workloadType")]
    public V1beta1JobSpecForProviderJobClusterNewClusterWorkloadType? WorkloadType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobCluster
{
    /// <summary>Identifier that can be referenced in task block, so that cluster is shared between tasks</summary>
    [JsonPropertyName("jobClusterKey")]
    public string? JobClusterKey { get; set; }

    /// <summary>Block with almost the same set of parameters as for databricks_cluster resource, except following (check the REST API documentation for full list of supported parameters):</summary>
    [JsonPropertyName("newCluster")]
    public V1beta1JobSpecForProviderJobClusterNewCluster? NewCluster { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderLibraryMaven
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
public partial class V1beta1JobSpecForProviderLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobSpecForProviderLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobSpecForProviderLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobSpecForProviderLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterAutoscale
{
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterAwsAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterAzureAttributesLogAnalyticsInfo
{
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterAzureAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("logAnalyticsInfo")]
    public V1beta1JobSpecForProviderNewClusterAzureAttributesLogAnalyticsInfo? LogAnalyticsInfo { get; set; }

    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterClusterLogConfDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterClusterLogConfS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterClusterLogConf
{
    [JsonPropertyName("dbfs")]
    public V1beta1JobSpecForProviderNewClusterClusterLogConfDbfs? Dbfs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobSpecForProviderNewClusterClusterLogConfS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterClusterMountInfoNetworkFilesystemInfo
{
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    [JsonPropertyName("networkFilesystemInfo")]
    public V1beta1JobSpecForProviderNewClusterClusterMountInfoNetworkFilesystemInfo? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterDockerImageBasicAuthPasswordSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterDockerImageBasicAuth
{
    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1JobSpecForProviderNewClusterDockerImageBasicAuthPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterDockerImage
{
    [JsonPropertyName("basicAuth")]
    public V1beta1JobSpecForProviderNewClusterDockerImageBasicAuth? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterGcpAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterInitScriptsAbfss
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterInitScriptsDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>block consisting of single string fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterInitScriptsFile
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterInitScriptsGcs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterInitScriptsS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterInitScriptsVolumes
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterInitScriptsWorkspace
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterInitScripts
{
    [JsonPropertyName("abfss")]
    public V1beta1JobSpecForProviderNewClusterInitScriptsAbfss? Abfss { get; set; }

    [JsonPropertyName("dbfs")]
    public V1beta1JobSpecForProviderNewClusterInitScriptsDbfs? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public V1beta1JobSpecForProviderNewClusterInitScriptsFile? File { get; set; }

    [JsonPropertyName("gcs")]
    public V1beta1JobSpecForProviderNewClusterInitScriptsGcs? Gcs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobSpecForProviderNewClusterInitScriptsS3? S3 { get; set; }

    [JsonPropertyName("volumes")]
    public V1beta1JobSpecForProviderNewClusterInitScriptsVolumes? Volumes { get; set; }

    [JsonPropertyName("workspace")]
    public V1beta1JobSpecForProviderNewClusterInitScriptsWorkspace? Workspace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterLibraryMaven
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
public partial class V1beta1JobSpecForProviderNewClusterLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobSpecForProviderNewClusterLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobSpecForProviderNewClusterLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobSpecForProviderNewClusterLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterWorkloadTypeClients
{
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}

/// <summary>isn&apos;t supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewClusterWorkloadType
{
    [JsonPropertyName("clients")]
    public V1beta1JobSpecForProviderNewClusterWorkloadTypeClients? Clients { get; set; }
}

/// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNewCluster
{
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    [JsonPropertyName("autoscale")]
    public V1beta1JobSpecForProviderNewClusterAutoscale? Autoscale { get; set; }

    [JsonPropertyName("awsAttributes")]
    public V1beta1JobSpecForProviderNewClusterAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1JobSpecForProviderNewClusterAzureAttributes? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    [JsonPropertyName("clusterLogConf")]
    public V1beta1JobSpecForProviderNewClusterClusterLogConf? ClusterLogConf { get; set; }

    [JsonPropertyName("clusterMountInfo")]
    public IList<V1beta1JobSpecForProviderNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    [JsonPropertyName("dockerImage")]
    public V1beta1JobSpecForProviderNewClusterDockerImage? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1JobSpecForProviderNewClusterGcpAttributes? GcpAttributes { get; set; }

    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    [JsonPropertyName("initScripts")]
    public IList<V1beta1JobSpecForProviderNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobSpecForProviderNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn&apos;t supported</summary>
    [JsonPropertyName("workloadType")]
    public V1beta1JobSpecForProviderNewClusterWorkloadType? WorkloadType { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNotebookTask
{
    /// <summary>(Map) Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used. If the notebook takes a parameter that is not specified in the job’s base_parameters or the run-now override parameters, the default value from the notebook will be used. Retrieve these parameters in a notebook using dbutils.widgets.get.</summary>
    [JsonPropertyName("baseParameters")]
    public IDictionary<string, string>? BaseParameters { get; set; }

    /// <summary>The path of the databricks_notebook to be run in the Databricks workspace or remote repository. For notebooks stored in the Databricks workspace, the path must be absolute and begin with a slash. For notebooks stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("notebookPath")]
    public string? NotebookPath { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderNotificationSettings
{
    /// <summary>(Bool) don&apos;t send alert for cancelled runs.</summary>
    [JsonPropertyName("noAlertForCanceledRuns")]
    public bool? NoAlertForCanceledRuns { get; set; }

    /// <summary>(Bool) don&apos;t send alert for skipped runs. (It&apos;s recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderParameter
{
    /// <summary>Default value of the parameter.</summary>
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderPipelineTask
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }

    /// <summary>The pipeline&apos;s unique ID.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderPythonWheelTask
{
    /// <summary>Python function as entry point for the task</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Named parameters for the task</summary>
    [JsonPropertyName("namedParameters")]
    public IDictionary<string, string>? NamedParameters { get; set; }

    /// <summary>Name of Python package</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

/// <summary>The queue status for the job. See queue Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderQueue
{
    /// <summary>If true, enable queueing for the job.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The user or the service prinicipal the job runs as. See run_as Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderRunAs
{
    /// <summary>The application ID of an active service principal. Setting this field requires the servicePrincipal/user role.</summary>
    [JsonPropertyName("servicePrincipalName")]
    public string? ServicePrincipalName { get; set; }

    /// <summary>The email of an active workspace user. Non-admin users can only set this field to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderRunJobTask
{
    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("jobId")]
    public double? JobId { get; set; }

    /// <summary>(Map) Job parameters for the task</summary>
    [JsonPropertyName("jobParameters")]
    public IDictionary<string, string>? JobParameters { get; set; }
}

/// <summary>An optional periodic schedule for this job. The default behavior is that the job runs when triggered by clicking Run Now in the Jobs UI or sending an API request to runNow. See schedule Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderSchedule
{
    /// <summary>Indicate whether this schedule is paused or not. Either PAUSED or UNPAUSED. When the pause_status field is omitted and a schedule is provided, the server will default to using UNPAUSED as a value for pause_status.</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }

    /// <summary>A Cron expression using Quartz syntax that describes the schedule for a job. This field is required.</summary>
    [JsonPropertyName("quartzCronExpression")]
    public string? QuartzCronExpression { get; set; }

    /// <summary>A Java timezone ID. The schedule for a job will be resolved with respect to this timezone. See Java TimeZone for details. This field is required.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderSparkJarTask
{
    [JsonPropertyName("jarUri")]
    public string? JarUri { get; set; }

    /// <summary>The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. The code should use SparkContext.getOrCreate to obtain a Spark context; otherwise, runs of the job will fail.</summary>
    [JsonPropertyName("mainClassName")]
    public string? MainClassName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderSparkPythonTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary>The URI of the Python file to be executed. databricks_dbfs_file, cloud file URIs (e.g. s3:/, abfss:/, gs:/), workspace paths and remote repository are supported. For Python files stored in the Databricks workspace, the path must be absolute and begin with /Repos. For files stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("pythonFile")]
    public string? PythonFile { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderSparkSubmitTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskCleanRoomsNotebookTask
{
    /// <summary>The clean room that the notebook belongs to.</summary>
    [JsonPropertyName("cleanRoomName")]
    public string? CleanRoomName { get; set; }

    /// <summary>Checksum to validate the freshness of the notebook resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>(Map) Base parameters to be used for the clean room notebook job.</summary>
    [JsonPropertyName("notebookBaseParameters")]
    public IDictionary<string, string>? NotebookBaseParameters { get; set; }

    /// <summary>Name of the notebook being run.</summary>
    [JsonPropertyName("notebookName")]
    public string? NotebookName { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskConditionTask
{
    /// <summary>The left operand of the condition task. It could be a string value, job state, or a parameter reference.</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>The right operand of the condition task. It could be a string value, job state, or parameter reference.</summary>
    [JsonPropertyName("right")]
    public string? Right { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskDbtTask
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with &quot;dbt&quot;.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>The relative path to the directory in the repository specified by git_source where dbt should look in for the profiles.yml file. If not specified, defaults to the repository&apos;s root directory. Equivalent to passing --profile-dir to a dbt command.</summary>
    [JsonPropertyName("profilesDirectory")]
    public string? ProfilesDirectory { get; set; }

    /// <summary>The path where dbt should look for dbt_project.yml. Equivalent to passing --project-dir to the dbt CLI.</summary>
    [JsonPropertyName("projectDirectory")]
    public string? ProjectDirectory { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskDependsOn
{
    /// <summary>Can only be specified on condition task dependencies. The outcome of the dependent task that must be met for this task to run. Possible values are &quot;true&quot; or &quot;false&quot;.</summary>
    [JsonPropertyName("outcome")]
    public string? Outcome { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }
}

/// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskEmailNotifications
{
    /// <summary>(Bool) don&apos;t send alert for skipped runs. (It&apos;s recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }

    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<string>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<string>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<string>? OnStart { get; set; }

    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<string>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<string>? OnSuccess { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTaskExistingClusterIdRefPolicyResolutionEnum>))]
public enum V1beta1JobSpecForProviderTaskExistingClusterIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTaskExistingClusterIdRefPolicyResolveEnum>))]
public enum V1beta1JobSpecForProviderTaskExistingClusterIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskExistingClusterIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecForProviderTaskExistingClusterIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecForProviderTaskExistingClusterIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in compute to populate existingClusterId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskExistingClusterIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderTaskExistingClusterIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTaskExistingClusterIdSelectorPolicyResolutionEnum>))]
public enum V1beta1JobSpecForProviderTaskExistingClusterIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTaskExistingClusterIdSelectorPolicyResolveEnum>))]
public enum V1beta1JobSpecForProviderTaskExistingClusterIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskExistingClusterIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecForProviderTaskExistingClusterIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecForProviderTaskExistingClusterIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in compute to populate existingClusterId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskExistingClusterIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderTaskExistingClusterIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskCleanRoomsNotebookTask
{
    /// <summary>The clean room that the notebook belongs to.</summary>
    [JsonPropertyName("cleanRoomName")]
    public string? CleanRoomName { get; set; }

    /// <summary>Checksum to validate the freshness of the notebook resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>(Map) Base parameters to be used for the clean room notebook job.</summary>
    [JsonPropertyName("notebookBaseParameters")]
    public IDictionary<string, string>? NotebookBaseParameters { get; set; }

    /// <summary>Name of the notebook being run.</summary>
    [JsonPropertyName("notebookName")]
    public string? NotebookName { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskConditionTask
{
    /// <summary>The left operand of the condition task. It could be a string value, job state, or a parameter reference.</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>The right operand of the condition task. It could be a string value, job state, or parameter reference.</summary>
    [JsonPropertyName("right")]
    public string? Right { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskDbtTask
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with &quot;dbt&quot;.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>The relative path to the directory in the repository specified by git_source where dbt should look in for the profiles.yml file. If not specified, defaults to the repository&apos;s root directory. Equivalent to passing --profile-dir to a dbt command.</summary>
    [JsonPropertyName("profilesDirectory")]
    public string? ProfilesDirectory { get; set; }

    /// <summary>The path where dbt should look for dbt_project.yml. Equivalent to passing --project-dir to the dbt CLI.</summary>
    [JsonPropertyName("projectDirectory")]
    public string? ProjectDirectory { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskDependsOn
{
    /// <summary>Can only be specified on condition task dependencies. The outcome of the dependent task that must be met for this task to run. Possible values are &quot;true&quot; or &quot;false&quot;.</summary>
    [JsonPropertyName("outcome")]
    public string? Outcome { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }
}

/// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskEmailNotifications
{
    /// <summary>(Bool) don&apos;t send alert for skipped runs. (It&apos;s recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }

    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<string>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<string>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<string>? OnStart { get; set; }

    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<string>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<string>? OnSuccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskHealthRules
{
    /// <summary>string specifying the metric to check.  The only supported metric is RUN_DURATION_SECONDS (check Jobs REST API documentation for the latest information).</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>integer value used to compare to the given metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskHealth
{
    /// <summary>(List) list of rules that are represented as objects with the following attributes:</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1JobSpecForProviderTaskForEachTaskTaskHealthRules>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskLibraryMaven
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
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterAutoscale
{
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterAwsAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterAzureAttributesLogAnalyticsInfo
{
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterAzureAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("logAnalyticsInfo")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterAzureAttributesLogAnalyticsInfo? LogAnalyticsInfo { get; set; }

    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterLogConfDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterLogConfS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterLogConf
{
    [JsonPropertyName("dbfs")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterLogConfDbfs? Dbfs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterLogConfS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterMountInfoNetworkFilesystemInfo
{
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    [JsonPropertyName("networkFilesystemInfo")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterMountInfoNetworkFilesystemInfo? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuthPasswordSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuth
{
    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuthPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterDockerImage
{
    [JsonPropertyName("basicAuth")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuth? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterGcpAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsAbfss
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>block consisting of single string fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsFile
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsGcs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsVolumes
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsWorkspace
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScripts
{
    [JsonPropertyName("abfss")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsAbfss? Abfss { get; set; }

    [JsonPropertyName("dbfs")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsDbfs? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsFile? File { get; set; }

    [JsonPropertyName("gcs")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsGcs? Gcs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsS3? S3 { get; set; }

    [JsonPropertyName("volumes")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsVolumes? Volumes { get; set; }

    [JsonPropertyName("workspace")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScriptsWorkspace? Workspace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterLibraryMaven
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
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterWorkloadTypeClients
{
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}

/// <summary>isn&apos;t supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterWorkloadType
{
    [JsonPropertyName("clients")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterWorkloadTypeClients? Clients { get; set; }
}

/// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNewCluster
{
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    [JsonPropertyName("autoscale")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterAutoscale? Autoscale { get; set; }

    [JsonPropertyName("awsAttributes")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterAzureAttributes? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    [JsonPropertyName("clusterLogConf")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterLogConf? ClusterLogConf { get; set; }

    [JsonPropertyName("clusterMountInfo")]
    public IList<V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    [JsonPropertyName("dockerImage")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterDockerImage? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterGcpAttributes? GcpAttributes { get; set; }

    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    [JsonPropertyName("initScripts")]
    public IList<V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn&apos;t supported</summary>
    [JsonPropertyName("workloadType")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewClusterWorkloadType? WorkloadType { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNotebookTask
{
    /// <summary>(Map) Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used. If the notebook takes a parameter that is not specified in the job’s base_parameters or the run-now override parameters, the default value from the notebook will be used. Retrieve these parameters in a notebook using dbutils.widgets.get.</summary>
    [JsonPropertyName("baseParameters")]
    public IDictionary<string, string>? BaseParameters { get; set; }

    /// <summary>The path of the databricks_notebook to be run in the Databricks workspace or remote repository. For notebooks stored in the Databricks workspace, the path must be absolute and begin with a slash. For notebooks stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("notebookPath")]
    public string? NotebookPath { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskNotificationSettings
{
    /// <summary>(Bool) do not send notifications to recipients specified in on_start for the retried runs and do not send notifications to recipients specified in on_failure until the last retry of the run.</summary>
    [JsonPropertyName("alertOnLastAttempt")]
    public bool? AlertOnLastAttempt { get; set; }

    /// <summary>(Bool) don&apos;t send alert for cancelled runs.</summary>
    [JsonPropertyName("noAlertForCanceledRuns")]
    public bool? NoAlertForCanceledRuns { get; set; }

    /// <summary>(Bool) don&apos;t send alert for skipped runs. (It&apos;s recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskPipelineTask
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }

    /// <summary>The pipeline&apos;s unique ID.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskPythonWheelTask
{
    /// <summary>Python function as entry point for the task</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Named parameters for the task</summary>
    [JsonPropertyName("namedParameters")]
    public IDictionary<string, string>? NamedParameters { get; set; }

    /// <summary>Name of Python package</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskRunJobTaskPipelineParams
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskRunJobTask
{
    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with &quot;dbt&quot;.</summary>
    [JsonPropertyName("dbtCommands")]
    public IList<string>? DbtCommands { get; set; }

    [JsonPropertyName("jarParams")]
    public IList<string>? JarParams { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("jobId")]
    public double? JobId { get; set; }

    /// <summary>(Map) Job parameters for the task</summary>
    [JsonPropertyName("jobParameters")]
    public IDictionary<string, string>? JobParameters { get; set; }

    [JsonPropertyName("notebookParams")]
    public IDictionary<string, string>? NotebookParams { get; set; }

    [JsonPropertyName("pipelineParams")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskRunJobTaskPipelineParams? PipelineParams { get; set; }

    [JsonPropertyName("pythonNamedParams")]
    public IDictionary<string, string>? PythonNamedParams { get; set; }

    [JsonPropertyName("pythonParams")]
    public IList<string>? PythonParams { get; set; }

    [JsonPropertyName("sparkSubmitParams")]
    public IList<string>? SparkSubmitParams { get; set; }

    [JsonPropertyName("sqlParams")]
    public IDictionary<string, string>? SqlParams { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskSparkJarTask
{
    [JsonPropertyName("jarUri")]
    public string? JarUri { get; set; }

    /// <summary>The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. The code should use SparkContext.getOrCreate to obtain a Spark context; otherwise, runs of the job will fail.</summary>
    [JsonPropertyName("mainClassName")]
    public string? MainClassName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    [JsonPropertyName("runAsRepl")]
    public bool? RunAsRepl { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskSparkPythonTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary>The URI of the Python file to be executed. databricks_dbfs_file, cloud file URIs (e.g. s3:/, abfss:/, gs:/), workspace paths and remote repository are supported. For Python files stored in the Databricks workspace, the path must be absolute and begin with /Repos. For files stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("pythonFile")]
    public string? PythonFile { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskSparkSubmitTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskSqlTaskAlertSubscriptions
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>The email of an active workspace user. Non-admin users can only set this field to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>block consisting of following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskSqlTaskAlert
{
    /// <summary>(String) identifier of the Databricks Alert (databricks_alert).</summary>
    [JsonPropertyName("alertId")]
    public string? AlertId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination&apos;s identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1beta1JobSpecForProviderTaskForEachTaskTaskSqlTaskAlertSubscriptions>? Subscriptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskSqlTaskDashboardSubscriptions
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>The email of an active workspace user. Non-admin users can only set this field to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>block consisting of following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskSqlTaskDashboard
{
    /// <summary>string specifying a custom subject of email sent.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>(String) identifier of the Databricks SQL Dashboard databricks_sql_dashboard.</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination&apos;s identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1beta1JobSpecForProviderTaskForEachTaskTaskSqlTaskDashboardSubscriptions>? Subscriptions { get; set; }
}

/// <summary>block consisting of single string fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskSqlTaskFile
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>block consisting of single string field: query_id - identifier of the Databricks Query (databricks_query).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskSqlTaskQuery
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskSqlTask
{
    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("alert")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskSqlTaskAlert? Alert { get; set; }

    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("dashboard")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskSqlTaskDashboard? Dashboard { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskSqlTaskFile? File { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>block consisting of single string field: query_id - identifier of the Databricks Query (databricks_query).</summary>
    [JsonPropertyName("query")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskSqlTaskQuery? Query { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnDurationWarningThresholdExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnFailure
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnStart
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnStreamingBacklogExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnSuccess
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTaskWebhookNotifications
{
    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<V1beta1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnDurationWarningThresholdExceeded>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1beta1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<V1beta1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnStart>? OnStart { get; set; }

    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<V1beta1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnStreamingBacklogExceeded>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1beta1JobSpecForProviderTaskForEachTaskTaskWebhookNotificationsOnSuccess>? OnSuccess { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTaskTask
{
    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("cleanRoomsNotebookTask")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskCleanRoomsNotebookTask? CleanRoomsNotebookTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("conditionTask")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskConditionTask? ConditionTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtTask")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskDbtTask? DbtTask { get; set; }

    /// <summary>block specifying dependency(-ies) for a given task.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<V1beta1JobSpecForProviderTaskForEachTaskTaskDependsOn>? DependsOn { get; set; }

    /// <summary>An optional description for the job. The maximum length is 1024 characters in UTF-8 encoding.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flag to disable auto optimization in serverless tasks.</summary>
    [JsonPropertyName("disableAutoOptimization")]
    public bool? DisableAutoOptimization { get; set; }

    /// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
    [JsonPropertyName("emailNotifications")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskEmailNotifications? EmailNotifications { get; set; }

    /// <summary>identifier of an environment block that is used to specify libraries.  Required for some tasks (spark_python_task, python_wheel_task, ...) running on serverless compute.</summary>
    [JsonPropertyName("environmentKey")]
    public string? EnvironmentKey { get; set; }

    /// <summary>If existing_cluster_id, the ID of an existing cluster that will be used for all runs of this job. When running jobs on an existing cluster, you may need to manually restart the cluster if it stops responding. We strongly suggest to use new_cluster for greater reliability.</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    /// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
    [JsonPropertyName("health")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskHealth? Health { get; set; }

    /// <summary>Identifier of the Job cluster specified in the job_cluster block.</summary>
    [JsonPropertyName("jobClusterKey")]
    public string? JobClusterKey { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobSpecForProviderTaskForEachTaskTaskLibrary>? Library { get; set; }

    /// <summary>(Integer) An optional maximum number of times to retry an unsuccessful run. A run is considered to be unsuccessful if it completes with a FAILED or INTERNAL_ERROR lifecycle state. The value -1 means to retry indefinitely and the value 0 means to never retry. The default behavior is to never retry. A run can have the following lifecycle state: PENDING, RUNNING, TERMINATING, TERMINATED, SKIPPED or INTERNAL_ERROR.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>(Integer) An optional minimal interval in milliseconds between the start of the failed run and the subsequent retry run. The default behavior is that unsuccessful runs are immediately retried.</summary>
    [JsonPropertyName("minRetryIntervalMillis")]
    public double? MinRetryIntervalMillis { get; set; }

    /// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
    [JsonPropertyName("newCluster")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNewCluster? NewCluster { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("notebookTask")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNotebookTask? NotebookTask { get; set; }

    /// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
    [JsonPropertyName("notificationSettings")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskNotificationSettings? NotificationSettings { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pipelineTask")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskPipelineTask? PipelineTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pythonWheelTask")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskPythonWheelTask? PythonWheelTask { get; set; }

    /// <summary>(Bool) An optional policy to specify whether to retry a job when it times out. The default behavior is to not retry on timeout.</summary>
    [JsonPropertyName("retryOnTimeout")]
    public bool? RetryOnTimeout { get; set; }

    /// <summary>An optional value indicating the condition that determines whether the task should be run once its dependencies have been completed. One of ALL_SUCCESS, AT_LEAST_ONE_SUCCESS, NONE_FAILED, ALL_DONE, AT_LEAST_ONE_FAILED or ALL_FAILED. When omitted, defaults to ALL_SUCCESS.</summary>
    [JsonPropertyName("runIf")]
    public string? RunIf { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("runJobTask")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskRunJobTask? RunJobTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkJarTask")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskSparkJarTask? SparkJarTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkPythonTask")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskSparkPythonTask? SparkPythonTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkSubmitTask")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskSparkSubmitTask? SparkSubmitTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sqlTask")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskSqlTask? SqlTask { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }

    /// <summary>(Integer) An optional timeout applied to each run of this job. The default behavior is to have no timeout.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
    [JsonPropertyName("webhookNotifications")]
    public V1beta1JobSpecForProviderTaskForEachTaskTaskWebhookNotifications? WebhookNotifications { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskForEachTask
{
    /// <summary>Controls the number of active iteration task runs. Default is 20, maximum allowed is 100.</summary>
    [JsonPropertyName("concurrency")]
    public double? Concurrency { get; set; }

    /// <summary>(String) Array for task to iterate on. This can be a JSON string or a reference to an array parameter.</summary>
    [JsonPropertyName("inputs")]
    public string? Inputs { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("task")]
    public V1beta1JobSpecForProviderTaskForEachTaskTask? Task { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskHealthRules
{
    /// <summary>string specifying the metric to check.  The only supported metric is RUN_DURATION_SECONDS (check Jobs REST API documentation for the latest information).</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>integer value used to compare to the given metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskHealth
{
    /// <summary>(List) list of rules that are represented as objects with the following attributes:</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1JobSpecForProviderTaskHealthRules>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskLibraryMaven
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
public partial class V1beta1JobSpecForProviderTaskLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobSpecForProviderTaskLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobSpecForProviderTaskLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobSpecForProviderTaskLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterAutoscale
{
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterAwsAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterAzureAttributesLogAnalyticsInfo
{
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterAzureAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("logAnalyticsInfo")]
    public V1beta1JobSpecForProviderTaskNewClusterAzureAttributesLogAnalyticsInfo? LogAnalyticsInfo { get; set; }

    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterClusterLogConfDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterClusterLogConfS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterClusterLogConf
{
    [JsonPropertyName("dbfs")]
    public V1beta1JobSpecForProviderTaskNewClusterClusterLogConfDbfs? Dbfs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobSpecForProviderTaskNewClusterClusterLogConfS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterClusterMountInfoNetworkFilesystemInfo
{
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    [JsonPropertyName("networkFilesystemInfo")]
    public V1beta1JobSpecForProviderTaskNewClusterClusterMountInfoNetworkFilesystemInfo? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterDockerImageBasicAuthPasswordSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterDockerImageBasicAuth
{
    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1JobSpecForProviderTaskNewClusterDockerImageBasicAuthPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterDockerImage
{
    [JsonPropertyName("basicAuth")]
    public V1beta1JobSpecForProviderTaskNewClusterDockerImageBasicAuth? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterGcpAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterInitScriptsAbfss
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterInitScriptsDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>block consisting of single string fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterInitScriptsFile
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterInitScriptsGcs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterInitScriptsS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterInitScriptsVolumes
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterInitScriptsWorkspace
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterInitScripts
{
    [JsonPropertyName("abfss")]
    public V1beta1JobSpecForProviderTaskNewClusterInitScriptsAbfss? Abfss { get; set; }

    [JsonPropertyName("dbfs")]
    public V1beta1JobSpecForProviderTaskNewClusterInitScriptsDbfs? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public V1beta1JobSpecForProviderTaskNewClusterInitScriptsFile? File { get; set; }

    [JsonPropertyName("gcs")]
    public V1beta1JobSpecForProviderTaskNewClusterInitScriptsGcs? Gcs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobSpecForProviderTaskNewClusterInitScriptsS3? S3 { get; set; }

    [JsonPropertyName("volumes")]
    public V1beta1JobSpecForProviderTaskNewClusterInitScriptsVolumes? Volumes { get; set; }

    [JsonPropertyName("workspace")]
    public V1beta1JobSpecForProviderTaskNewClusterInitScriptsWorkspace? Workspace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterLibraryMaven
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
public partial class V1beta1JobSpecForProviderTaskNewClusterLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobSpecForProviderTaskNewClusterLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobSpecForProviderTaskNewClusterLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobSpecForProviderTaskNewClusterLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterWorkloadTypeClients
{
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}

/// <summary>isn&apos;t supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewClusterWorkloadType
{
    [JsonPropertyName("clients")]
    public V1beta1JobSpecForProviderTaskNewClusterWorkloadTypeClients? Clients { get; set; }
}

/// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNewCluster
{
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    [JsonPropertyName("autoscale")]
    public V1beta1JobSpecForProviderTaskNewClusterAutoscale? Autoscale { get; set; }

    [JsonPropertyName("awsAttributes")]
    public V1beta1JobSpecForProviderTaskNewClusterAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1JobSpecForProviderTaskNewClusterAzureAttributes? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    [JsonPropertyName("clusterLogConf")]
    public V1beta1JobSpecForProviderTaskNewClusterClusterLogConf? ClusterLogConf { get; set; }

    [JsonPropertyName("clusterMountInfo")]
    public IList<V1beta1JobSpecForProviderTaskNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    [JsonPropertyName("dockerImage")]
    public V1beta1JobSpecForProviderTaskNewClusterDockerImage? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1JobSpecForProviderTaskNewClusterGcpAttributes? GcpAttributes { get; set; }

    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    [JsonPropertyName("initScripts")]
    public IList<V1beta1JobSpecForProviderTaskNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobSpecForProviderTaskNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn&apos;t supported</summary>
    [JsonPropertyName("workloadType")]
    public V1beta1JobSpecForProviderTaskNewClusterWorkloadType? WorkloadType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathRefPolicyResolutionEnum>))]
public enum V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathRefPolicyResolveEnum>))]
public enum V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Notebook in workspace to populate notebookPath.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathSelectorPolicyResolutionEnum>))]
public enum V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathSelectorPolicyResolveEnum>))]
public enum V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Notebook in workspace to populate notebookPath.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathSelectorPolicy? Policy { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNotebookTask
{
    /// <summary>(Map) Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used. If the notebook takes a parameter that is not specified in the job’s base_parameters or the run-now override parameters, the default value from the notebook will be used. Retrieve these parameters in a notebook using dbutils.widgets.get.</summary>
    [JsonPropertyName("baseParameters")]
    public IDictionary<string, string>? BaseParameters { get; set; }

    /// <summary>The path of the databricks_notebook to be run in the Databricks workspace or remote repository. For notebooks stored in the Databricks workspace, the path must be absolute and begin with a slash. For notebooks stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("notebookPath")]
    public string? NotebookPath { get; set; }

    /// <summary>Reference to a Notebook in workspace to populate notebookPath.</summary>
    [JsonPropertyName("notebookPathRef")]
    public V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathRef? NotebookPathRef { get; set; }

    /// <summary>Selector for a Notebook in workspace to populate notebookPath.</summary>
    [JsonPropertyName("notebookPathSelector")]
    public V1beta1JobSpecForProviderTaskNotebookTaskNotebookPathSelector? NotebookPathSelector { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskNotificationSettings
{
    /// <summary>(Bool) do not send notifications to recipients specified in on_start for the retried runs and do not send notifications to recipients specified in on_failure until the last retry of the run.</summary>
    [JsonPropertyName("alertOnLastAttempt")]
    public bool? AlertOnLastAttempt { get; set; }

    /// <summary>(Bool) don&apos;t send alert for cancelled runs.</summary>
    [JsonPropertyName("noAlertForCanceledRuns")]
    public bool? NoAlertForCanceledRuns { get; set; }

    /// <summary>(Bool) don&apos;t send alert for skipped runs. (It&apos;s recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdRefPolicyResolutionEnum>))]
public enum V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdRefPolicyResolveEnum>))]
public enum V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Pipeline in compute to populate pipelineId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdSelectorPolicyResolutionEnum>))]
public enum V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdSelectorPolicyResolveEnum>))]
public enum V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Pipeline in compute to populate pipelineId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskPipelineTask
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }

    /// <summary>The pipeline&apos;s unique ID.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }

    /// <summary>Reference to a Pipeline in compute to populate pipelineId.</summary>
    [JsonPropertyName("pipelineIdRef")]
    public V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdRef? PipelineIdRef { get; set; }

    /// <summary>Selector for a Pipeline in compute to populate pipelineId.</summary>
    [JsonPropertyName("pipelineIdSelector")]
    public V1beta1JobSpecForProviderTaskPipelineTaskPipelineIdSelector? PipelineIdSelector { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskPythonWheelTask
{
    /// <summary>Python function as entry point for the task</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Named parameters for the task</summary>
    [JsonPropertyName("namedParameters")]
    public IDictionary<string, string>? NamedParameters { get; set; }

    /// <summary>Name of Python package</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskRunJobTaskPipelineParams
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskRunJobTask
{
    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with &quot;dbt&quot;.</summary>
    [JsonPropertyName("dbtCommands")]
    public IList<string>? DbtCommands { get; set; }

    [JsonPropertyName("jarParams")]
    public IList<string>? JarParams { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("jobId")]
    public double? JobId { get; set; }

    /// <summary>(Map) Job parameters for the task</summary>
    [JsonPropertyName("jobParameters")]
    public IDictionary<string, string>? JobParameters { get; set; }

    [JsonPropertyName("notebookParams")]
    public IDictionary<string, string>? NotebookParams { get; set; }

    [JsonPropertyName("pipelineParams")]
    public V1beta1JobSpecForProviderTaskRunJobTaskPipelineParams? PipelineParams { get; set; }

    [JsonPropertyName("pythonNamedParams")]
    public IDictionary<string, string>? PythonNamedParams { get; set; }

    [JsonPropertyName("pythonParams")]
    public IList<string>? PythonParams { get; set; }

    [JsonPropertyName("sparkSubmitParams")]
    public IList<string>? SparkSubmitParams { get; set; }

    [JsonPropertyName("sqlParams")]
    public IDictionary<string, string>? SqlParams { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskSparkJarTask
{
    [JsonPropertyName("jarUri")]
    public string? JarUri { get; set; }

    /// <summary>The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. The code should use SparkContext.getOrCreate to obtain a Spark context; otherwise, runs of the job will fail.</summary>
    [JsonPropertyName("mainClassName")]
    public string? MainClassName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    [JsonPropertyName("runAsRepl")]
    public bool? RunAsRepl { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskSparkPythonTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary>The URI of the Python file to be executed. databricks_dbfs_file, cloud file URIs (e.g. s3:/, abfss:/, gs:/), workspace paths and remote repository are supported. For Python files stored in the Databricks workspace, the path must be absolute and begin with /Repos. For files stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("pythonFile")]
    public string? PythonFile { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskSparkSubmitTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskSqlTaskAlertSubscriptions
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>The email of an active workspace user. Non-admin users can only set this field to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>block consisting of following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskSqlTaskAlert
{
    /// <summary>(String) identifier of the Databricks Alert (databricks_alert).</summary>
    [JsonPropertyName("alertId")]
    public string? AlertId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination&apos;s identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1beta1JobSpecForProviderTaskSqlTaskAlertSubscriptions>? Subscriptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskSqlTaskDashboardSubscriptions
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>The email of an active workspace user. Non-admin users can only set this field to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>block consisting of following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskSqlTaskDashboard
{
    /// <summary>string specifying a custom subject of email sent.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>(String) identifier of the Databricks SQL Dashboard databricks_sql_dashboard.</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination&apos;s identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1beta1JobSpecForProviderTaskSqlTaskDashboardSubscriptions>? Subscriptions { get; set; }
}

/// <summary>block consisting of single string fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskSqlTaskFile
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>block consisting of single string field: query_id - identifier of the Databricks Query (databricks_query).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskSqlTaskQuery
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskSqlTask
{
    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("alert")]
    public V1beta1JobSpecForProviderTaskSqlTaskAlert? Alert { get; set; }

    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("dashboard")]
    public V1beta1JobSpecForProviderTaskSqlTaskDashboard? Dashboard { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public V1beta1JobSpecForProviderTaskSqlTaskFile? File { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>block consisting of single string field: query_id - identifier of the Databricks Query (databricks_query).</summary>
    [JsonPropertyName("query")]
    public V1beta1JobSpecForProviderTaskSqlTaskQuery? Query { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskWebhookNotificationsOnDurationWarningThresholdExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskWebhookNotificationsOnFailure
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskWebhookNotificationsOnStart
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskWebhookNotificationsOnStreamingBacklogExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskWebhookNotificationsOnSuccess
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTaskWebhookNotifications
{
    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<V1beta1JobSpecForProviderTaskWebhookNotificationsOnDurationWarningThresholdExceeded>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1beta1JobSpecForProviderTaskWebhookNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<V1beta1JobSpecForProviderTaskWebhookNotificationsOnStart>? OnStart { get; set; }

    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<V1beta1JobSpecForProviderTaskWebhookNotificationsOnStreamingBacklogExceeded>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1beta1JobSpecForProviderTaskWebhookNotificationsOnSuccess>? OnSuccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTask
{
    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("cleanRoomsNotebookTask")]
    public V1beta1JobSpecForProviderTaskCleanRoomsNotebookTask? CleanRoomsNotebookTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("conditionTask")]
    public V1beta1JobSpecForProviderTaskConditionTask? ConditionTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtTask")]
    public V1beta1JobSpecForProviderTaskDbtTask? DbtTask { get; set; }

    /// <summary>block specifying dependency(-ies) for a given task.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<V1beta1JobSpecForProviderTaskDependsOn>? DependsOn { get; set; }

    /// <summary>An optional description for the job. The maximum length is 1024 characters in UTF-8 encoding.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flag to disable auto optimization in serverless tasks.</summary>
    [JsonPropertyName("disableAutoOptimization")]
    public bool? DisableAutoOptimization { get; set; }

    /// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
    [JsonPropertyName("emailNotifications")]
    public V1beta1JobSpecForProviderTaskEmailNotifications? EmailNotifications { get; set; }

    /// <summary>identifier of an environment block that is used to specify libraries.  Required for some tasks (spark_python_task, python_wheel_task, ...) running on serverless compute.</summary>
    [JsonPropertyName("environmentKey")]
    public string? EnvironmentKey { get; set; }

    /// <summary>If existing_cluster_id, the ID of an existing cluster that will be used for all runs of this job. When running jobs on an existing cluster, you may need to manually restart the cluster if it stops responding. We strongly suggest to use new_cluster for greater reliability.</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    /// <summary>Reference to a Cluster in compute to populate existingClusterId.</summary>
    [JsonPropertyName("existingClusterIdRef")]
    public V1beta1JobSpecForProviderTaskExistingClusterIdRef? ExistingClusterIdRef { get; set; }

    /// <summary>Selector for a Cluster in compute to populate existingClusterId.</summary>
    [JsonPropertyName("existingClusterIdSelector")]
    public V1beta1JobSpecForProviderTaskExistingClusterIdSelector? ExistingClusterIdSelector { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("forEachTask")]
    public V1beta1JobSpecForProviderTaskForEachTask? ForEachTask { get; set; }

    /// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
    [JsonPropertyName("health")]
    public V1beta1JobSpecForProviderTaskHealth? Health { get; set; }

    /// <summary>Identifier of the Job cluster specified in the job_cluster block.</summary>
    [JsonPropertyName("jobClusterKey")]
    public string? JobClusterKey { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobSpecForProviderTaskLibrary>? Library { get; set; }

    /// <summary>(Integer) An optional maximum number of times to retry an unsuccessful run. A run is considered to be unsuccessful if it completes with a FAILED or INTERNAL_ERROR lifecycle state. The value -1 means to retry indefinitely and the value 0 means to never retry. The default behavior is to never retry. A run can have the following lifecycle state: PENDING, RUNNING, TERMINATING, TERMINATED, SKIPPED or INTERNAL_ERROR.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>(Integer) An optional minimal interval in milliseconds between the start of the failed run and the subsequent retry run. The default behavior is that unsuccessful runs are immediately retried.</summary>
    [JsonPropertyName("minRetryIntervalMillis")]
    public double? MinRetryIntervalMillis { get; set; }

    /// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
    [JsonPropertyName("newCluster")]
    public V1beta1JobSpecForProviderTaskNewCluster? NewCluster { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("notebookTask")]
    public V1beta1JobSpecForProviderTaskNotebookTask? NotebookTask { get; set; }

    /// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
    [JsonPropertyName("notificationSettings")]
    public V1beta1JobSpecForProviderTaskNotificationSettings? NotificationSettings { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pipelineTask")]
    public V1beta1JobSpecForProviderTaskPipelineTask? PipelineTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pythonWheelTask")]
    public V1beta1JobSpecForProviderTaskPythonWheelTask? PythonWheelTask { get; set; }

    /// <summary>(Bool) An optional policy to specify whether to retry a job when it times out. The default behavior is to not retry on timeout.</summary>
    [JsonPropertyName("retryOnTimeout")]
    public bool? RetryOnTimeout { get; set; }

    /// <summary>An optional value indicating the condition that determines whether the task should be run once its dependencies have been completed. One of ALL_SUCCESS, AT_LEAST_ONE_SUCCESS, NONE_FAILED, ALL_DONE, AT_LEAST_ONE_FAILED or ALL_FAILED. When omitted, defaults to ALL_SUCCESS.</summary>
    [JsonPropertyName("runIf")]
    public string? RunIf { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("runJobTask")]
    public V1beta1JobSpecForProviderTaskRunJobTask? RunJobTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkJarTask")]
    public V1beta1JobSpecForProviderTaskSparkJarTask? SparkJarTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkPythonTask")]
    public V1beta1JobSpecForProviderTaskSparkPythonTask? SparkPythonTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkSubmitTask")]
    public V1beta1JobSpecForProviderTaskSparkSubmitTask? SparkSubmitTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sqlTask")]
    public V1beta1JobSpecForProviderTaskSqlTask? SqlTask { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }

    /// <summary>(Integer) An optional timeout applied to each run of this job. The default behavior is to have no timeout.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
    [JsonPropertyName("webhookNotifications")]
    public V1beta1JobSpecForProviderTaskWebhookNotifications? WebhookNotifications { get; set; }
}

/// <summary>configuration block to define a trigger for File Arrival events consisting of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTriggerFileArrival
{
    /// <summary>If set, the trigger starts a run only after the specified amount of time passed since the last time the trigger fired. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("minTimeBetweenTriggersSeconds")]
    public double? MinTimeBetweenTriggersSeconds { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>If set, the trigger starts a run only after no file activity has occurred for the specified amount of time. This makes it possible to wait for a batch of incoming files to arrive before triggering a run. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("waitAfterLastChangeSeconds")]
    public double? WaitAfterLastChangeSeconds { get; set; }
}

/// <summary>configuration block to define a trigger for Periodic Triggers consisting of the following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTriggerPeriodic
{
    /// <summary>Specifies the interval at which the job should run. This value is required.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>Options are {&quot;DAYS&quot;, &quot;HOURS&quot;, &quot;WEEKS&quot;}.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTriggerTable
{
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>If set, the trigger starts a run only after the specified amount of time passed since the last time the trigger fired. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("minTimeBetweenTriggersSeconds")]
    public double? MinTimeBetweenTriggersSeconds { get; set; }

    [JsonPropertyName("tableNames")]
    public IList<string>? TableNames { get; set; }

    /// <summary>If set, the trigger starts a run only after no file activity has occurred for the specified amount of time. This makes it possible to wait for a batch of incoming files to arrive before triggering a run. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("waitAfterLastChangeSeconds")]
    public double? WaitAfterLastChangeSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTriggerTableUpdate
{
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>If set, the trigger starts a run only after the specified amount of time passed since the last time the trigger fired. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("minTimeBetweenTriggersSeconds")]
    public double? MinTimeBetweenTriggersSeconds { get; set; }

    [JsonPropertyName("tableNames")]
    public IList<string>? TableNames { get; set; }

    /// <summary>If set, the trigger starts a run only after no file activity has occurred for the specified amount of time. This makes it possible to wait for a batch of incoming files to arrive before triggering a run. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("waitAfterLastChangeSeconds")]
    public double? WaitAfterLastChangeSeconds { get; set; }
}

/// <summary>The conditions that triggers the job to start. See trigger Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderTrigger
{
    /// <summary>configuration block to define a trigger for File Arrival events consisting of following attributes:</summary>
    [JsonPropertyName("fileArrival")]
    public V1beta1JobSpecForProviderTriggerFileArrival? FileArrival { get; set; }

    /// <summary>Indicate whether this trigger is paused or not. Either PAUSED or UNPAUSED. When the pause_status field is omitted in the block, the server will default to using UNPAUSED as a value for pause_status.</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }

    /// <summary>configuration block to define a trigger for Periodic Triggers consisting of the following attributes:</summary>
    [JsonPropertyName("periodic")]
    public V1beta1JobSpecForProviderTriggerPeriodic? Periodic { get; set; }

    [JsonPropertyName("table")]
    public V1beta1JobSpecForProviderTriggerTable? Table { get; set; }

    [JsonPropertyName("tableUpdate")]
    public V1beta1JobSpecForProviderTriggerTableUpdate? TableUpdate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderWebhookNotificationsOnDurationWarningThresholdExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderWebhookNotificationsOnFailure
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderWebhookNotificationsOnStart
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderWebhookNotificationsOnStreamingBacklogExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderWebhookNotificationsOnSuccess
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderWebhookNotifications
{
    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<V1beta1JobSpecForProviderWebhookNotificationsOnDurationWarningThresholdExceeded>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1beta1JobSpecForProviderWebhookNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<V1beta1JobSpecForProviderWebhookNotificationsOnStart>? OnStart { get; set; }

    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<V1beta1JobSpecForProviderWebhookNotificationsOnStreamingBacklogExceeded>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1beta1JobSpecForProviderWebhookNotificationsOnSuccess>? OnSuccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProvider
{
    /// <summary>(Bool) Whenever the job is always running, like a Spark Streaming application, on every update restart the current active run or start it again, if nothing it is not running. False by default. Any job runs are started with parameters specified in spark_jar_task or spark_submit_task or spark_python_task or notebook_task blocks.</summary>
    [JsonPropertyName("alwaysRunning")]
    public bool? AlwaysRunning { get; set; }

    /// <summary>The ID of the user-specified budget policy to use for this job. If not specified, a default budget policy may be applied when creating or modifying the job.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>Configuration block to configure pause status. See continuous Configuration Block.</summary>
    [JsonPropertyName("continuous")]
    public V1beta1JobSpecForProviderContinuous? Continuous { get; set; }

    /// <summary>(Bool) If true, the Databricks provider will stop and start the job as needed to ensure that the active run for the job reflects the deployed configuration. For continuous jobs, the provider respects the pause_status by stopping the current active run. This flag cannot be set for non-continuous jobs.</summary>
    [JsonPropertyName("controlRunState")]
    public bool? ControlRunState { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtTask")]
    public V1beta1JobSpecForProviderDbtTask? DbtTask { get; set; }

    [JsonPropertyName("deployment")]
    public V1beta1JobSpecForProviderDeployment? Deployment { get; set; }

    /// <summary>An optional description for the job. The maximum length is 1024 characters in UTF-8 encoding.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If &quot;UI_LOCKED&quot;, the user interface for the job will be locked. If &quot;EDITABLE&quot; (the default), the user interface will be editable.</summary>
    [JsonPropertyName("editMode")]
    public string? EditMode { get; set; }

    /// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
    [JsonPropertyName("emailNotifications")]
    public V1beta1JobSpecForProviderEmailNotifications? EmailNotifications { get; set; }

    [JsonPropertyName("environment")]
    public IList<V1beta1JobSpecForProviderEnvironment>? Environment { get; set; }

    /// <summary>Identifier of the interactive cluster to run job on.  Note: running tasks on interactive clusters may lead to increased costs!</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Specifices the a Git repository for task source code. See git_source Configuration Block below.</summary>
    [JsonPropertyName("gitSource")]
    public V1beta1JobSpecForProviderGitSource? GitSource { get; set; }

    /// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
    [JsonPropertyName("health")]
    public V1beta1JobSpecForProviderHealth? Health { get; set; }

    /// <summary>A list of job databricks_cluster specifications that can be shared and reused by tasks of this job. Libraries cannot be declared in a shared job cluster. You must declare dependent libraries in task settings. Multi-task syntax</summary>
    [JsonPropertyName("jobCluster")]
    public IList<V1beta1JobSpecForProviderJobCluster>? JobCluster { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobSpecForProviderLibrary>? Library { get; set; }

    /// <summary>(Integer) An optional maximum allowed number of concurrent runs of the job. Defaults to 1.</summary>
    [JsonPropertyName("maxConcurrentRuns")]
    public double? MaxConcurrentRuns { get; set; }

    /// <summary>(Integer) An optional maximum number of times to retry an unsuccessful run. A run is considered to be unsuccessful if it completes with a FAILED or INTERNAL_ERROR lifecycle state. The value -1 means to retry indefinitely and the value 0 means to never retry. The default behavior is to never retry. A run can have the following lifecycle state: PENDING, RUNNING, TERMINATING, TERMINATED, SKIPPED or INTERNAL_ERROR.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>(Integer) An optional minimal interval in milliseconds between the start of the failed run and the subsequent retry run. The default behavior is that unsuccessful runs are immediately retried.</summary>
    [JsonPropertyName("minRetryIntervalMillis")]
    public double? MinRetryIntervalMillis { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
    [JsonPropertyName("newCluster")]
    public V1beta1JobSpecForProviderNewCluster? NewCluster { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("notebookTask")]
    public V1beta1JobSpecForProviderNotebookTask? NotebookTask { get; set; }

    /// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
    [JsonPropertyName("notificationSettings")]
    public V1beta1JobSpecForProviderNotificationSettings? NotificationSettings { get; set; }

    /// <summary>Specifices job parameter for the job. See parameter Configuration Block</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1JobSpecForProviderParameter>? Parameter { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pipelineTask")]
    public V1beta1JobSpecForProviderPipelineTask? PipelineTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pythonWheelTask")]
    public V1beta1JobSpecForProviderPythonWheelTask? PythonWheelTask { get; set; }

    /// <summary>The queue status for the job. See queue Configuration Block below.</summary>
    [JsonPropertyName("queue")]
    public V1beta1JobSpecForProviderQueue? Queue { get; set; }

    /// <summary>(Bool) An optional policy to specify whether to retry a job when it times out. The default behavior is to not retry on timeout.</summary>
    [JsonPropertyName("retryOnTimeout")]
    public bool? RetryOnTimeout { get; set; }

    /// <summary>The user or the service prinicipal the job runs as. See run_as Configuration Block below.</summary>
    [JsonPropertyName("runAs")]
    public V1beta1JobSpecForProviderRunAs? RunAs { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("runJobTask")]
    public V1beta1JobSpecForProviderRunJobTask? RunJobTask { get; set; }

    /// <summary>An optional periodic schedule for this job. The default behavior is that the job runs when triggered by clicking Run Now in the Jobs UI or sending an API request to runNow. See schedule Configuration Block below.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1JobSpecForProviderSchedule? Schedule { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkJarTask")]
    public V1beta1JobSpecForProviderSparkJarTask? SparkJarTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkPythonTask")]
    public V1beta1JobSpecForProviderSparkPythonTask? SparkPythonTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkSubmitTask")]
    public V1beta1JobSpecForProviderSparkSubmitTask? SparkSubmitTask { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("task")]
    public IList<V1beta1JobSpecForProviderTask>? Task { get; set; }

    /// <summary>(Integer) An optional timeout applied to each run of this job. The default behavior is to have no timeout.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>The conditions that triggers the job to start. See trigger Configuration Block below.</summary>
    [JsonPropertyName("trigger")]
    public V1beta1JobSpecForProviderTrigger? Trigger { get; set; }

    /// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
    [JsonPropertyName("webhookNotifications")]
    public V1beta1JobSpecForProviderWebhookNotifications? WebhookNotifications { get; set; }
}

/// <summary>Configuration block to configure pause status. See continuous Configuration Block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderContinuous
{
    /// <summary>Indicate whether this continuous job is paused or not. Either PAUSED or UNPAUSED. When the pause_status field is omitted in the block, the server will default to using UNPAUSED as a value for pause_status.</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderDbtTask
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with &quot;dbt&quot;.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>The relative path to the directory in the repository specified by git_source where dbt should look in for the profiles.yml file. If not specified, defaults to the repository&apos;s root directory. Equivalent to passing --profile-dir to a dbt command.</summary>
    [JsonPropertyName("profilesDirectory")]
    public string? ProfilesDirectory { get; set; }

    /// <summary>The path where dbt should look for dbt_project.yml. Equivalent to passing --project-dir to the dbt CLI.</summary>
    [JsonPropertyName("projectDirectory")]
    public string? ProjectDirectory { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderDeployment
{
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("metadataFilePath")]
    public string? MetadataFilePath { get; set; }
}

/// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderEmailNotifications
{
    /// <summary>(Bool) don&apos;t send alert for skipped runs. (It&apos;s recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }

    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<string>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<string>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<string>? OnStart { get; set; }

    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<string>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<string>? OnSuccess { get; set; }
}

/// <summary>block describing the Environment. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderEnvironmentSpec
{
    /// <summary>client version used by the environment.</summary>
    [JsonPropertyName("client")]
    public string? Client { get; set; }

    /// <summary>(list of strings) List of pip dependencies, as supported by the version of pip in this environment. Each dependency is a pip requirement file line.  See API docs for more information.</summary>
    [JsonPropertyName("dependencies")]
    public IList<string>? Dependencies { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderEnvironment
{
    /// <summary>identifier of an environment block that is used to specify libraries.  Required for some tasks (spark_python_task, python_wheel_task, ...) running on serverless compute.</summary>
    [JsonPropertyName("environmentKey")]
    public string? EnvironmentKey { get; set; }

    /// <summary>block describing the Environment. Consists of following attributes:</summary>
    [JsonPropertyName("spec")]
    public V1beta1JobSpecInitProviderEnvironmentSpec? Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderGitSourceGitSnapshot
{
    /// <summary>hash of Git commit to use. Conflicts with branch and tag.</summary>
    [JsonPropertyName("usedCommit")]
    public string? UsedCommit { get; set; }
}

/// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderGitSourceJobSource
{
    [JsonPropertyName("dirtyState")]
    public string? DirtyState { get; set; }

    /// <summary>name of the Git branch to use. Conflicts with tag and commit.</summary>
    [JsonPropertyName("importFromGitBranch")]
    public string? ImportFromGitBranch { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("jobConfigPath")]
    public string? JobConfigPath { get; set; }
}

/// <summary>Specifices the a Git repository for task source code. See git_source Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderGitSource
{
    /// <summary>name of the Git branch to use. Conflicts with tag and commit.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>hash of Git commit to use. Conflicts with branch and tag.</summary>
    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    [JsonPropertyName("gitSnapshot")]
    public V1beta1JobSpecInitProviderGitSourceGitSnapshot? GitSnapshot { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("jobSource")]
    public V1beta1JobSpecInitProviderGitSourceJobSource? JobSource { get; set; }

    /// <summary>case insensitive name of the Git provider.  Following values are supported right now (could be a subject for change, consult Repos API documentation): gitHub, gitHubEnterprise, bitbucketCloud, bitbucketServer, azureDevOpsServices, gitLab, gitLabEnterpriseEdition.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>name of the Git branch to use. Conflicts with branch and commit.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderHealthRules
{
    /// <summary>string specifying the metric to check.  The only supported metric is RUN_DURATION_SECONDS (check Jobs REST API documentation for the latest information).</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>integer value used to compare to the given metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderHealth
{
    /// <summary>(List) list of rules that are represented as objects with the following attributes:</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1JobSpecInitProviderHealthRules>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterAutoscale
{
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterAwsAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterAzureAttributesLogAnalyticsInfo
{
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterAzureAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("logAnalyticsInfo")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterAzureAttributesLogAnalyticsInfo? LogAnalyticsInfo { get; set; }

    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterClusterLogConfDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterClusterLogConfS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterClusterLogConf
{
    [JsonPropertyName("dbfs")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterClusterLogConfDbfs? Dbfs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterClusterLogConfS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterClusterMountInfoNetworkFilesystemInfo
{
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    [JsonPropertyName("networkFilesystemInfo")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterClusterMountInfoNetworkFilesystemInfo? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterDockerImageBasicAuthPasswordSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterDockerImageBasicAuth
{
    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta1JobSpecInitProviderJobClusterNewClusterDockerImageBasicAuthPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterDockerImage
{
    [JsonPropertyName("basicAuth")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterDockerImageBasicAuth? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterGcpAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterInitScriptsAbfss
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterInitScriptsDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>block consisting of single string fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterInitScriptsFile
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterInitScriptsGcs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterInitScriptsS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterInitScriptsVolumes
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterInitScriptsWorkspace
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterInitScripts
{
    [JsonPropertyName("abfss")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterInitScriptsAbfss? Abfss { get; set; }

    [JsonPropertyName("dbfs")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterInitScriptsDbfs? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterInitScriptsFile? File { get; set; }

    [JsonPropertyName("gcs")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterInitScriptsGcs? Gcs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterInitScriptsS3? S3 { get; set; }

    [JsonPropertyName("volumes")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterInitScriptsVolumes? Volumes { get; set; }

    [JsonPropertyName("workspace")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterInitScriptsWorkspace? Workspace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterLibraryMaven
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
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterWorkloadTypeClients
{
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}

/// <summary>isn&apos;t supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewClusterWorkloadType
{
    [JsonPropertyName("clients")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterWorkloadTypeClients? Clients { get; set; }
}

/// <summary>Block with almost the same set of parameters as for databricks_cluster resource, except following (check the REST API documentation for full list of supported parameters):</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobClusterNewCluster
{
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    [JsonPropertyName("autoscale")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterAutoscale? Autoscale { get; set; }

    [JsonPropertyName("awsAttributes")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterAzureAttributes? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    [JsonPropertyName("clusterLogConf")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterClusterLogConf? ClusterLogConf { get; set; }

    [JsonPropertyName("clusterMountInfo")]
    public IList<V1beta1JobSpecInitProviderJobClusterNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    [JsonPropertyName("dockerImage")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterDockerImage? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterGcpAttributes? GcpAttributes { get; set; }

    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    [JsonPropertyName("initScripts")]
    public IList<V1beta1JobSpecInitProviderJobClusterNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobSpecInitProviderJobClusterNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn&apos;t supported</summary>
    [JsonPropertyName("workloadType")]
    public V1beta1JobSpecInitProviderJobClusterNewClusterWorkloadType? WorkloadType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobCluster
{
    /// <summary>Identifier that can be referenced in task block, so that cluster is shared between tasks</summary>
    [JsonPropertyName("jobClusterKey")]
    public string? JobClusterKey { get; set; }

    /// <summary>Block with almost the same set of parameters as for databricks_cluster resource, except following (check the REST API documentation for full list of supported parameters):</summary>
    [JsonPropertyName("newCluster")]
    public V1beta1JobSpecInitProviderJobClusterNewCluster? NewCluster { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderLibraryMaven
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
public partial class V1beta1JobSpecInitProviderLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobSpecInitProviderLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobSpecInitProviderLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobSpecInitProviderLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterAutoscale
{
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterAwsAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterAzureAttributesLogAnalyticsInfo
{
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterAzureAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("logAnalyticsInfo")]
    public V1beta1JobSpecInitProviderNewClusterAzureAttributesLogAnalyticsInfo? LogAnalyticsInfo { get; set; }

    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterClusterLogConfDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterClusterLogConfS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterClusterLogConf
{
    [JsonPropertyName("dbfs")]
    public V1beta1JobSpecInitProviderNewClusterClusterLogConfDbfs? Dbfs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobSpecInitProviderNewClusterClusterLogConfS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterClusterMountInfoNetworkFilesystemInfo
{
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    [JsonPropertyName("networkFilesystemInfo")]
    public V1beta1JobSpecInitProviderNewClusterClusterMountInfoNetworkFilesystemInfo? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterDockerImageBasicAuthPasswordSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterDockerImageBasicAuth
{
    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta1JobSpecInitProviderNewClusterDockerImageBasicAuthPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterDockerImage
{
    [JsonPropertyName("basicAuth")]
    public V1beta1JobSpecInitProviderNewClusterDockerImageBasicAuth? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterGcpAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterInitScriptsAbfss
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterInitScriptsDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>block consisting of single string fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterInitScriptsFile
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterInitScriptsGcs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterInitScriptsS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterInitScriptsVolumes
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterInitScriptsWorkspace
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterInitScripts
{
    [JsonPropertyName("abfss")]
    public V1beta1JobSpecInitProviderNewClusterInitScriptsAbfss? Abfss { get; set; }

    [JsonPropertyName("dbfs")]
    public V1beta1JobSpecInitProviderNewClusterInitScriptsDbfs? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public V1beta1JobSpecInitProviderNewClusterInitScriptsFile? File { get; set; }

    [JsonPropertyName("gcs")]
    public V1beta1JobSpecInitProviderNewClusterInitScriptsGcs? Gcs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobSpecInitProviderNewClusterInitScriptsS3? S3 { get; set; }

    [JsonPropertyName("volumes")]
    public V1beta1JobSpecInitProviderNewClusterInitScriptsVolumes? Volumes { get; set; }

    [JsonPropertyName("workspace")]
    public V1beta1JobSpecInitProviderNewClusterInitScriptsWorkspace? Workspace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterLibraryMaven
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
public partial class V1beta1JobSpecInitProviderNewClusterLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobSpecInitProviderNewClusterLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobSpecInitProviderNewClusterLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobSpecInitProviderNewClusterLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterWorkloadTypeClients
{
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}

/// <summary>isn&apos;t supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewClusterWorkloadType
{
    [JsonPropertyName("clients")]
    public V1beta1JobSpecInitProviderNewClusterWorkloadTypeClients? Clients { get; set; }
}

/// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNewCluster
{
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    [JsonPropertyName("autoscale")]
    public V1beta1JobSpecInitProviderNewClusterAutoscale? Autoscale { get; set; }

    [JsonPropertyName("awsAttributes")]
    public V1beta1JobSpecInitProviderNewClusterAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1JobSpecInitProviderNewClusterAzureAttributes? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    [JsonPropertyName("clusterLogConf")]
    public V1beta1JobSpecInitProviderNewClusterClusterLogConf? ClusterLogConf { get; set; }

    [JsonPropertyName("clusterMountInfo")]
    public IList<V1beta1JobSpecInitProviderNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    [JsonPropertyName("dockerImage")]
    public V1beta1JobSpecInitProviderNewClusterDockerImage? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1JobSpecInitProviderNewClusterGcpAttributes? GcpAttributes { get; set; }

    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    [JsonPropertyName("initScripts")]
    public IList<V1beta1JobSpecInitProviderNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobSpecInitProviderNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn&apos;t supported</summary>
    [JsonPropertyName("workloadType")]
    public V1beta1JobSpecInitProviderNewClusterWorkloadType? WorkloadType { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNotebookTask
{
    /// <summary>(Map) Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used. If the notebook takes a parameter that is not specified in the job’s base_parameters or the run-now override parameters, the default value from the notebook will be used. Retrieve these parameters in a notebook using dbutils.widgets.get.</summary>
    [JsonPropertyName("baseParameters")]
    public IDictionary<string, string>? BaseParameters { get; set; }

    /// <summary>The path of the databricks_notebook to be run in the Databricks workspace or remote repository. For notebooks stored in the Databricks workspace, the path must be absolute and begin with a slash. For notebooks stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("notebookPath")]
    public string? NotebookPath { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderNotificationSettings
{
    /// <summary>(Bool) don&apos;t send alert for cancelled runs.</summary>
    [JsonPropertyName("noAlertForCanceledRuns")]
    public bool? NoAlertForCanceledRuns { get; set; }

    /// <summary>(Bool) don&apos;t send alert for skipped runs. (It&apos;s recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderParameter
{
    /// <summary>Default value of the parameter.</summary>
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderPipelineTask
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }

    /// <summary>The pipeline&apos;s unique ID.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderPythonWheelTask
{
    /// <summary>Python function as entry point for the task</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Named parameters for the task</summary>
    [JsonPropertyName("namedParameters")]
    public IDictionary<string, string>? NamedParameters { get; set; }

    /// <summary>Name of Python package</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

/// <summary>The queue status for the job. See queue Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderQueue
{
    /// <summary>If true, enable queueing for the job.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The user or the service prinicipal the job runs as. See run_as Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderRunAs
{
    /// <summary>The application ID of an active service principal. Setting this field requires the servicePrincipal/user role.</summary>
    [JsonPropertyName("servicePrincipalName")]
    public string? ServicePrincipalName { get; set; }

    /// <summary>The email of an active workspace user. Non-admin users can only set this field to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderRunJobTask
{
    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("jobId")]
    public double? JobId { get; set; }

    /// <summary>(Map) Job parameters for the task</summary>
    [JsonPropertyName("jobParameters")]
    public IDictionary<string, string>? JobParameters { get; set; }
}

/// <summary>An optional periodic schedule for this job. The default behavior is that the job runs when triggered by clicking Run Now in the Jobs UI or sending an API request to runNow. See schedule Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderSchedule
{
    /// <summary>Indicate whether this schedule is paused or not. Either PAUSED or UNPAUSED. When the pause_status field is omitted and a schedule is provided, the server will default to using UNPAUSED as a value for pause_status.</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }

    /// <summary>A Cron expression using Quartz syntax that describes the schedule for a job. This field is required.</summary>
    [JsonPropertyName("quartzCronExpression")]
    public string? QuartzCronExpression { get; set; }

    /// <summary>A Java timezone ID. The schedule for a job will be resolved with respect to this timezone. See Java TimeZone for details. This field is required.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderSparkJarTask
{
    [JsonPropertyName("jarUri")]
    public string? JarUri { get; set; }

    /// <summary>The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. The code should use SparkContext.getOrCreate to obtain a Spark context; otherwise, runs of the job will fail.</summary>
    [JsonPropertyName("mainClassName")]
    public string? MainClassName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderSparkPythonTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary>The URI of the Python file to be executed. databricks_dbfs_file, cloud file URIs (e.g. s3:/, abfss:/, gs:/), workspace paths and remote repository are supported. For Python files stored in the Databricks workspace, the path must be absolute and begin with /Repos. For files stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("pythonFile")]
    public string? PythonFile { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderSparkSubmitTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskCleanRoomsNotebookTask
{
    /// <summary>The clean room that the notebook belongs to.</summary>
    [JsonPropertyName("cleanRoomName")]
    public string? CleanRoomName { get; set; }

    /// <summary>Checksum to validate the freshness of the notebook resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>(Map) Base parameters to be used for the clean room notebook job.</summary>
    [JsonPropertyName("notebookBaseParameters")]
    public IDictionary<string, string>? NotebookBaseParameters { get; set; }

    /// <summary>Name of the notebook being run.</summary>
    [JsonPropertyName("notebookName")]
    public string? NotebookName { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskConditionTask
{
    /// <summary>The left operand of the condition task. It could be a string value, job state, or a parameter reference.</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>The right operand of the condition task. It could be a string value, job state, or parameter reference.</summary>
    [JsonPropertyName("right")]
    public string? Right { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskDbtTask
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with &quot;dbt&quot;.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>The relative path to the directory in the repository specified by git_source where dbt should look in for the profiles.yml file. If not specified, defaults to the repository&apos;s root directory. Equivalent to passing --profile-dir to a dbt command.</summary>
    [JsonPropertyName("profilesDirectory")]
    public string? ProfilesDirectory { get; set; }

    /// <summary>The path where dbt should look for dbt_project.yml. Equivalent to passing --project-dir to the dbt CLI.</summary>
    [JsonPropertyName("projectDirectory")]
    public string? ProjectDirectory { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskDependsOn
{
    /// <summary>Can only be specified on condition task dependencies. The outcome of the dependent task that must be met for this task to run. Possible values are &quot;true&quot; or &quot;false&quot;.</summary>
    [JsonPropertyName("outcome")]
    public string? Outcome { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }
}

/// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskEmailNotifications
{
    /// <summary>(Bool) don&apos;t send alert for skipped runs. (It&apos;s recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }

    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<string>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<string>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<string>? OnStart { get; set; }

    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<string>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<string>? OnSuccess { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTaskExistingClusterIdRefPolicyResolutionEnum>))]
public enum V1beta1JobSpecInitProviderTaskExistingClusterIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTaskExistingClusterIdRefPolicyResolveEnum>))]
public enum V1beta1JobSpecInitProviderTaskExistingClusterIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskExistingClusterIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecInitProviderTaskExistingClusterIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecInitProviderTaskExistingClusterIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in compute to populate existingClusterId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskExistingClusterIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderTaskExistingClusterIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTaskExistingClusterIdSelectorPolicyResolutionEnum>))]
public enum V1beta1JobSpecInitProviderTaskExistingClusterIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTaskExistingClusterIdSelectorPolicyResolveEnum>))]
public enum V1beta1JobSpecInitProviderTaskExistingClusterIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskExistingClusterIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecInitProviderTaskExistingClusterIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecInitProviderTaskExistingClusterIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in compute to populate existingClusterId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskExistingClusterIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderTaskExistingClusterIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskCleanRoomsNotebookTask
{
    /// <summary>The clean room that the notebook belongs to.</summary>
    [JsonPropertyName("cleanRoomName")]
    public string? CleanRoomName { get; set; }

    /// <summary>Checksum to validate the freshness of the notebook resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>(Map) Base parameters to be used for the clean room notebook job.</summary>
    [JsonPropertyName("notebookBaseParameters")]
    public IDictionary<string, string>? NotebookBaseParameters { get; set; }

    /// <summary>Name of the notebook being run.</summary>
    [JsonPropertyName("notebookName")]
    public string? NotebookName { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskConditionTask
{
    /// <summary>The left operand of the condition task. It could be a string value, job state, or a parameter reference.</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>The right operand of the condition task. It could be a string value, job state, or parameter reference.</summary>
    [JsonPropertyName("right")]
    public string? Right { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskDbtTask
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with &quot;dbt&quot;.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>The relative path to the directory in the repository specified by git_source where dbt should look in for the profiles.yml file. If not specified, defaults to the repository&apos;s root directory. Equivalent to passing --profile-dir to a dbt command.</summary>
    [JsonPropertyName("profilesDirectory")]
    public string? ProfilesDirectory { get; set; }

    /// <summary>The path where dbt should look for dbt_project.yml. Equivalent to passing --project-dir to the dbt CLI.</summary>
    [JsonPropertyName("projectDirectory")]
    public string? ProjectDirectory { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskDependsOn
{
    /// <summary>Can only be specified on condition task dependencies. The outcome of the dependent task that must be met for this task to run. Possible values are &quot;true&quot; or &quot;false&quot;.</summary>
    [JsonPropertyName("outcome")]
    public string? Outcome { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }
}

/// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskEmailNotifications
{
    /// <summary>(Bool) don&apos;t send alert for skipped runs. (It&apos;s recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }

    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<string>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<string>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<string>? OnStart { get; set; }

    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<string>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<string>? OnSuccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskHealthRules
{
    /// <summary>string specifying the metric to check.  The only supported metric is RUN_DURATION_SECONDS (check Jobs REST API documentation for the latest information).</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>integer value used to compare to the given metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskHealth
{
    /// <summary>(List) list of rules that are represented as objects with the following attributes:</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1JobSpecInitProviderTaskForEachTaskTaskHealthRules>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskLibraryMaven
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
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterAutoscale
{
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterAwsAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterAzureAttributesLogAnalyticsInfo
{
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterAzureAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("logAnalyticsInfo")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterAzureAttributesLogAnalyticsInfo? LogAnalyticsInfo { get; set; }

    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterLogConfDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterLogConfS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterLogConf
{
    [JsonPropertyName("dbfs")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterLogConfDbfs? Dbfs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterLogConfS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterMountInfoNetworkFilesystemInfo
{
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    [JsonPropertyName("networkFilesystemInfo")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterMountInfoNetworkFilesystemInfo? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuthPasswordSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuth
{
    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuthPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterDockerImage
{
    [JsonPropertyName("basicAuth")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuth? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterGcpAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsAbfss
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>block consisting of single string fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsFile
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsGcs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsVolumes
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsWorkspace
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScripts
{
    [JsonPropertyName("abfss")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsAbfss? Abfss { get; set; }

    [JsonPropertyName("dbfs")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsDbfs? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsFile? File { get; set; }

    [JsonPropertyName("gcs")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsGcs? Gcs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsS3? S3 { get; set; }

    [JsonPropertyName("volumes")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsVolumes? Volumes { get; set; }

    [JsonPropertyName("workspace")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScriptsWorkspace? Workspace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterLibraryMaven
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
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterWorkloadTypeClients
{
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}

/// <summary>isn&apos;t supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterWorkloadType
{
    [JsonPropertyName("clients")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterWorkloadTypeClients? Clients { get; set; }
}

/// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNewCluster
{
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    [JsonPropertyName("autoscale")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterAutoscale? Autoscale { get; set; }

    [JsonPropertyName("awsAttributes")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterAzureAttributes? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    [JsonPropertyName("clusterLogConf")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterLogConf? ClusterLogConf { get; set; }

    [JsonPropertyName("clusterMountInfo")]
    public IList<V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    [JsonPropertyName("dockerImage")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterDockerImage? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterGcpAttributes? GcpAttributes { get; set; }

    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    [JsonPropertyName("initScripts")]
    public IList<V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn&apos;t supported</summary>
    [JsonPropertyName("workloadType")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewClusterWorkloadType? WorkloadType { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNotebookTask
{
    /// <summary>(Map) Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used. If the notebook takes a parameter that is not specified in the job’s base_parameters or the run-now override parameters, the default value from the notebook will be used. Retrieve these parameters in a notebook using dbutils.widgets.get.</summary>
    [JsonPropertyName("baseParameters")]
    public IDictionary<string, string>? BaseParameters { get; set; }

    /// <summary>The path of the databricks_notebook to be run in the Databricks workspace or remote repository. For notebooks stored in the Databricks workspace, the path must be absolute and begin with a slash. For notebooks stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("notebookPath")]
    public string? NotebookPath { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskNotificationSettings
{
    /// <summary>(Bool) do not send notifications to recipients specified in on_start for the retried runs and do not send notifications to recipients specified in on_failure until the last retry of the run.</summary>
    [JsonPropertyName("alertOnLastAttempt")]
    public bool? AlertOnLastAttempt { get; set; }

    /// <summary>(Bool) don&apos;t send alert for cancelled runs.</summary>
    [JsonPropertyName("noAlertForCanceledRuns")]
    public bool? NoAlertForCanceledRuns { get; set; }

    /// <summary>(Bool) don&apos;t send alert for skipped runs. (It&apos;s recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskPipelineTask
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }

    /// <summary>The pipeline&apos;s unique ID.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskPythonWheelTask
{
    /// <summary>Python function as entry point for the task</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Named parameters for the task</summary>
    [JsonPropertyName("namedParameters")]
    public IDictionary<string, string>? NamedParameters { get; set; }

    /// <summary>Name of Python package</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskRunJobTaskPipelineParams
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskRunJobTask
{
    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with &quot;dbt&quot;.</summary>
    [JsonPropertyName("dbtCommands")]
    public IList<string>? DbtCommands { get; set; }

    [JsonPropertyName("jarParams")]
    public IList<string>? JarParams { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("jobId")]
    public double? JobId { get; set; }

    /// <summary>(Map) Job parameters for the task</summary>
    [JsonPropertyName("jobParameters")]
    public IDictionary<string, string>? JobParameters { get; set; }

    [JsonPropertyName("notebookParams")]
    public IDictionary<string, string>? NotebookParams { get; set; }

    [JsonPropertyName("pipelineParams")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskRunJobTaskPipelineParams? PipelineParams { get; set; }

    [JsonPropertyName("pythonNamedParams")]
    public IDictionary<string, string>? PythonNamedParams { get; set; }

    [JsonPropertyName("pythonParams")]
    public IList<string>? PythonParams { get; set; }

    [JsonPropertyName("sparkSubmitParams")]
    public IList<string>? SparkSubmitParams { get; set; }

    [JsonPropertyName("sqlParams")]
    public IDictionary<string, string>? SqlParams { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskSparkJarTask
{
    [JsonPropertyName("jarUri")]
    public string? JarUri { get; set; }

    /// <summary>The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. The code should use SparkContext.getOrCreate to obtain a Spark context; otherwise, runs of the job will fail.</summary>
    [JsonPropertyName("mainClassName")]
    public string? MainClassName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    [JsonPropertyName("runAsRepl")]
    public bool? RunAsRepl { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskSparkPythonTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary>The URI of the Python file to be executed. databricks_dbfs_file, cloud file URIs (e.g. s3:/, abfss:/, gs:/), workspace paths and remote repository are supported. For Python files stored in the Databricks workspace, the path must be absolute and begin with /Repos. For files stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("pythonFile")]
    public string? PythonFile { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskSparkSubmitTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskSqlTaskAlertSubscriptions
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>The email of an active workspace user. Non-admin users can only set this field to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>block consisting of following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskSqlTaskAlert
{
    /// <summary>(String) identifier of the Databricks Alert (databricks_alert).</summary>
    [JsonPropertyName("alertId")]
    public string? AlertId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination&apos;s identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1beta1JobSpecInitProviderTaskForEachTaskTaskSqlTaskAlertSubscriptions>? Subscriptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskSqlTaskDashboardSubscriptions
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>The email of an active workspace user. Non-admin users can only set this field to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>block consisting of following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskSqlTaskDashboard
{
    /// <summary>string specifying a custom subject of email sent.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>(String) identifier of the Databricks SQL Dashboard databricks_sql_dashboard.</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination&apos;s identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1beta1JobSpecInitProviderTaskForEachTaskTaskSqlTaskDashboardSubscriptions>? Subscriptions { get; set; }
}

/// <summary>block consisting of single string fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskSqlTaskFile
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>block consisting of single string field: query_id - identifier of the Databricks Query (databricks_query).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskSqlTaskQuery
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskSqlTask
{
    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("alert")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskSqlTaskAlert? Alert { get; set; }

    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("dashboard")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskSqlTaskDashboard? Dashboard { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskSqlTaskFile? File { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>block consisting of single string field: query_id - identifier of the Databricks Query (databricks_query).</summary>
    [JsonPropertyName("query")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskSqlTaskQuery? Query { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnDurationWarningThresholdExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnFailure
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnStart
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnStreamingBacklogExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnSuccess
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTaskWebhookNotifications
{
    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<V1beta1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnDurationWarningThresholdExceeded>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1beta1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<V1beta1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnStart>? OnStart { get; set; }

    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<V1beta1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnStreamingBacklogExceeded>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1beta1JobSpecInitProviderTaskForEachTaskTaskWebhookNotificationsOnSuccess>? OnSuccess { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTaskTask
{
    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("cleanRoomsNotebookTask")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskCleanRoomsNotebookTask? CleanRoomsNotebookTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("conditionTask")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskConditionTask? ConditionTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtTask")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskDbtTask? DbtTask { get; set; }

    /// <summary>block specifying dependency(-ies) for a given task.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<V1beta1JobSpecInitProviderTaskForEachTaskTaskDependsOn>? DependsOn { get; set; }

    /// <summary>An optional description for the job. The maximum length is 1024 characters in UTF-8 encoding.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flag to disable auto optimization in serverless tasks.</summary>
    [JsonPropertyName("disableAutoOptimization")]
    public bool? DisableAutoOptimization { get; set; }

    /// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
    [JsonPropertyName("emailNotifications")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskEmailNotifications? EmailNotifications { get; set; }

    /// <summary>identifier of an environment block that is used to specify libraries.  Required for some tasks (spark_python_task, python_wheel_task, ...) running on serverless compute.</summary>
    [JsonPropertyName("environmentKey")]
    public string? EnvironmentKey { get; set; }

    /// <summary>If existing_cluster_id, the ID of an existing cluster that will be used for all runs of this job. When running jobs on an existing cluster, you may need to manually restart the cluster if it stops responding. We strongly suggest to use new_cluster for greater reliability.</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    /// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
    [JsonPropertyName("health")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskHealth? Health { get; set; }

    /// <summary>Identifier of the Job cluster specified in the job_cluster block.</summary>
    [JsonPropertyName("jobClusterKey")]
    public string? JobClusterKey { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobSpecInitProviderTaskForEachTaskTaskLibrary>? Library { get; set; }

    /// <summary>(Integer) An optional maximum number of times to retry an unsuccessful run. A run is considered to be unsuccessful if it completes with a FAILED or INTERNAL_ERROR lifecycle state. The value -1 means to retry indefinitely and the value 0 means to never retry. The default behavior is to never retry. A run can have the following lifecycle state: PENDING, RUNNING, TERMINATING, TERMINATED, SKIPPED or INTERNAL_ERROR.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>(Integer) An optional minimal interval in milliseconds between the start of the failed run and the subsequent retry run. The default behavior is that unsuccessful runs are immediately retried.</summary>
    [JsonPropertyName("minRetryIntervalMillis")]
    public double? MinRetryIntervalMillis { get; set; }

    /// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
    [JsonPropertyName("newCluster")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNewCluster? NewCluster { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("notebookTask")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNotebookTask? NotebookTask { get; set; }

    /// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
    [JsonPropertyName("notificationSettings")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskNotificationSettings? NotificationSettings { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pipelineTask")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskPipelineTask? PipelineTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pythonWheelTask")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskPythonWheelTask? PythonWheelTask { get; set; }

    /// <summary>(Bool) An optional policy to specify whether to retry a job when it times out. The default behavior is to not retry on timeout.</summary>
    [JsonPropertyName("retryOnTimeout")]
    public bool? RetryOnTimeout { get; set; }

    /// <summary>An optional value indicating the condition that determines whether the task should be run once its dependencies have been completed. One of ALL_SUCCESS, AT_LEAST_ONE_SUCCESS, NONE_FAILED, ALL_DONE, AT_LEAST_ONE_FAILED or ALL_FAILED. When omitted, defaults to ALL_SUCCESS.</summary>
    [JsonPropertyName("runIf")]
    public string? RunIf { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("runJobTask")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskRunJobTask? RunJobTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkJarTask")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskSparkJarTask? SparkJarTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkPythonTask")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskSparkPythonTask? SparkPythonTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkSubmitTask")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskSparkSubmitTask? SparkSubmitTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sqlTask")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskSqlTask? SqlTask { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }

    /// <summary>(Integer) An optional timeout applied to each run of this job. The default behavior is to have no timeout.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
    [JsonPropertyName("webhookNotifications")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTaskWebhookNotifications? WebhookNotifications { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskForEachTask
{
    /// <summary>Controls the number of active iteration task runs. Default is 20, maximum allowed is 100.</summary>
    [JsonPropertyName("concurrency")]
    public double? Concurrency { get; set; }

    /// <summary>(String) Array for task to iterate on. This can be a JSON string or a reference to an array parameter.</summary>
    [JsonPropertyName("inputs")]
    public string? Inputs { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("task")]
    public V1beta1JobSpecInitProviderTaskForEachTaskTask? Task { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskHealthRules
{
    /// <summary>string specifying the metric to check.  The only supported metric is RUN_DURATION_SECONDS (check Jobs REST API documentation for the latest information).</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>integer value used to compare to the given metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskHealth
{
    /// <summary>(List) list of rules that are represented as objects with the following attributes:</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1JobSpecInitProviderTaskHealthRules>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskLibraryMaven
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
public partial class V1beta1JobSpecInitProviderTaskLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobSpecInitProviderTaskLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobSpecInitProviderTaskLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobSpecInitProviderTaskLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterAutoscale
{
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterAwsAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterAzureAttributesLogAnalyticsInfo
{
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterAzureAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("logAnalyticsInfo")]
    public V1beta1JobSpecInitProviderTaskNewClusterAzureAttributesLogAnalyticsInfo? LogAnalyticsInfo { get; set; }

    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterClusterLogConfDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterClusterLogConfS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterClusterLogConf
{
    [JsonPropertyName("dbfs")]
    public V1beta1JobSpecInitProviderTaskNewClusterClusterLogConfDbfs? Dbfs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobSpecInitProviderTaskNewClusterClusterLogConfS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterClusterMountInfoNetworkFilesystemInfo
{
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    [JsonPropertyName("networkFilesystemInfo")]
    public V1beta1JobSpecInitProviderTaskNewClusterClusterMountInfoNetworkFilesystemInfo? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterDockerImageBasicAuthPasswordSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterDockerImageBasicAuth
{
    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1beta1JobSpecInitProviderTaskNewClusterDockerImageBasicAuthPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterDockerImage
{
    [JsonPropertyName("basicAuth")]
    public V1beta1JobSpecInitProviderTaskNewClusterDockerImageBasicAuth? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterGcpAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterInitScriptsAbfss
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterInitScriptsDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>block consisting of single string fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterInitScriptsFile
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterInitScriptsGcs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterInitScriptsS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterInitScriptsVolumes
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterInitScriptsWorkspace
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterInitScripts
{
    [JsonPropertyName("abfss")]
    public V1beta1JobSpecInitProviderTaskNewClusterInitScriptsAbfss? Abfss { get; set; }

    [JsonPropertyName("dbfs")]
    public V1beta1JobSpecInitProviderTaskNewClusterInitScriptsDbfs? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public V1beta1JobSpecInitProviderTaskNewClusterInitScriptsFile? File { get; set; }

    [JsonPropertyName("gcs")]
    public V1beta1JobSpecInitProviderTaskNewClusterInitScriptsGcs? Gcs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobSpecInitProviderTaskNewClusterInitScriptsS3? S3 { get; set; }

    [JsonPropertyName("volumes")]
    public V1beta1JobSpecInitProviderTaskNewClusterInitScriptsVolumes? Volumes { get; set; }

    [JsonPropertyName("workspace")]
    public V1beta1JobSpecInitProviderTaskNewClusterInitScriptsWorkspace? Workspace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterLibraryMaven
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
public partial class V1beta1JobSpecInitProviderTaskNewClusterLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobSpecInitProviderTaskNewClusterLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobSpecInitProviderTaskNewClusterLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobSpecInitProviderTaskNewClusterLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterWorkloadTypeClients
{
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}

/// <summary>isn&apos;t supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewClusterWorkloadType
{
    [JsonPropertyName("clients")]
    public V1beta1JobSpecInitProviderTaskNewClusterWorkloadTypeClients? Clients { get; set; }
}

/// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNewCluster
{
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    [JsonPropertyName("autoscale")]
    public V1beta1JobSpecInitProviderTaskNewClusterAutoscale? Autoscale { get; set; }

    [JsonPropertyName("awsAttributes")]
    public V1beta1JobSpecInitProviderTaskNewClusterAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1JobSpecInitProviderTaskNewClusterAzureAttributes? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    [JsonPropertyName("clusterLogConf")]
    public V1beta1JobSpecInitProviderTaskNewClusterClusterLogConf? ClusterLogConf { get; set; }

    [JsonPropertyName("clusterMountInfo")]
    public IList<V1beta1JobSpecInitProviderTaskNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    [JsonPropertyName("dockerImage")]
    public V1beta1JobSpecInitProviderTaskNewClusterDockerImage? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1JobSpecInitProviderTaskNewClusterGcpAttributes? GcpAttributes { get; set; }

    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    [JsonPropertyName("initScripts")]
    public IList<V1beta1JobSpecInitProviderTaskNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobSpecInitProviderTaskNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn&apos;t supported</summary>
    [JsonPropertyName("workloadType")]
    public V1beta1JobSpecInitProviderTaskNewClusterWorkloadType? WorkloadType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathRefPolicyResolutionEnum>))]
public enum V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathRefPolicyResolveEnum>))]
public enum V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Notebook in workspace to populate notebookPath.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathSelectorPolicyResolutionEnum>))]
public enum V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathSelectorPolicyResolveEnum>))]
public enum V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Notebook in workspace to populate notebookPath.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathSelectorPolicy? Policy { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNotebookTask
{
    /// <summary>(Map) Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used. If the notebook takes a parameter that is not specified in the job’s base_parameters or the run-now override parameters, the default value from the notebook will be used. Retrieve these parameters in a notebook using dbutils.widgets.get.</summary>
    [JsonPropertyName("baseParameters")]
    public IDictionary<string, string>? BaseParameters { get; set; }

    /// <summary>The path of the databricks_notebook to be run in the Databricks workspace or remote repository. For notebooks stored in the Databricks workspace, the path must be absolute and begin with a slash. For notebooks stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("notebookPath")]
    public string? NotebookPath { get; set; }

    /// <summary>Reference to a Notebook in workspace to populate notebookPath.</summary>
    [JsonPropertyName("notebookPathRef")]
    public V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathRef? NotebookPathRef { get; set; }

    /// <summary>Selector for a Notebook in workspace to populate notebookPath.</summary>
    [JsonPropertyName("notebookPathSelector")]
    public V1beta1JobSpecInitProviderTaskNotebookTaskNotebookPathSelector? NotebookPathSelector { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskNotificationSettings
{
    /// <summary>(Bool) do not send notifications to recipients specified in on_start for the retried runs and do not send notifications to recipients specified in on_failure until the last retry of the run.</summary>
    [JsonPropertyName("alertOnLastAttempt")]
    public bool? AlertOnLastAttempt { get; set; }

    /// <summary>(Bool) don&apos;t send alert for cancelled runs.</summary>
    [JsonPropertyName("noAlertForCanceledRuns")]
    public bool? NoAlertForCanceledRuns { get; set; }

    /// <summary>(Bool) don&apos;t send alert for skipped runs. (It&apos;s recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdRefPolicyResolutionEnum>))]
public enum V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdRefPolicyResolveEnum>))]
public enum V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Pipeline in compute to populate pipelineId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdSelectorPolicyResolutionEnum>))]
public enum V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdSelectorPolicyResolveEnum>))]
public enum V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Pipeline in compute to populate pipelineId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskPipelineTask
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }

    /// <summary>The pipeline&apos;s unique ID.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }

    /// <summary>Reference to a Pipeline in compute to populate pipelineId.</summary>
    [JsonPropertyName("pipelineIdRef")]
    public V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdRef? PipelineIdRef { get; set; }

    /// <summary>Selector for a Pipeline in compute to populate pipelineId.</summary>
    [JsonPropertyName("pipelineIdSelector")]
    public V1beta1JobSpecInitProviderTaskPipelineTaskPipelineIdSelector? PipelineIdSelector { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskPythonWheelTask
{
    /// <summary>Python function as entry point for the task</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Named parameters for the task</summary>
    [JsonPropertyName("namedParameters")]
    public IDictionary<string, string>? NamedParameters { get; set; }

    /// <summary>Name of Python package</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskRunJobTaskPipelineParams
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskRunJobTask
{
    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with &quot;dbt&quot;.</summary>
    [JsonPropertyName("dbtCommands")]
    public IList<string>? DbtCommands { get; set; }

    [JsonPropertyName("jarParams")]
    public IList<string>? JarParams { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("jobId")]
    public double? JobId { get; set; }

    /// <summary>(Map) Job parameters for the task</summary>
    [JsonPropertyName("jobParameters")]
    public IDictionary<string, string>? JobParameters { get; set; }

    [JsonPropertyName("notebookParams")]
    public IDictionary<string, string>? NotebookParams { get; set; }

    [JsonPropertyName("pipelineParams")]
    public V1beta1JobSpecInitProviderTaskRunJobTaskPipelineParams? PipelineParams { get; set; }

    [JsonPropertyName("pythonNamedParams")]
    public IDictionary<string, string>? PythonNamedParams { get; set; }

    [JsonPropertyName("pythonParams")]
    public IList<string>? PythonParams { get; set; }

    [JsonPropertyName("sparkSubmitParams")]
    public IList<string>? SparkSubmitParams { get; set; }

    [JsonPropertyName("sqlParams")]
    public IDictionary<string, string>? SqlParams { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskSparkJarTask
{
    [JsonPropertyName("jarUri")]
    public string? JarUri { get; set; }

    /// <summary>The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. The code should use SparkContext.getOrCreate to obtain a Spark context; otherwise, runs of the job will fail.</summary>
    [JsonPropertyName("mainClassName")]
    public string? MainClassName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    [JsonPropertyName("runAsRepl")]
    public bool? RunAsRepl { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskSparkPythonTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary>The URI of the Python file to be executed. databricks_dbfs_file, cloud file URIs (e.g. s3:/, abfss:/, gs:/), workspace paths and remote repository are supported. For Python files stored in the Databricks workspace, the path must be absolute and begin with /Repos. For files stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("pythonFile")]
    public string? PythonFile { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskSparkSubmitTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskSqlTaskAlertSubscriptions
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>The email of an active workspace user. Non-admin users can only set this field to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>block consisting of following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskSqlTaskAlert
{
    /// <summary>(String) identifier of the Databricks Alert (databricks_alert).</summary>
    [JsonPropertyName("alertId")]
    public string? AlertId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination&apos;s identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1beta1JobSpecInitProviderTaskSqlTaskAlertSubscriptions>? Subscriptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskSqlTaskDashboardSubscriptions
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>The email of an active workspace user. Non-admin users can only set this field to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>block consisting of following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskSqlTaskDashboard
{
    /// <summary>string specifying a custom subject of email sent.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>(String) identifier of the Databricks SQL Dashboard databricks_sql_dashboard.</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination&apos;s identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1beta1JobSpecInitProviderTaskSqlTaskDashboardSubscriptions>? Subscriptions { get; set; }
}

/// <summary>block consisting of single string fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskSqlTaskFile
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>block consisting of single string field: query_id - identifier of the Databricks Query (databricks_query).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskSqlTaskQuery
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskSqlTask
{
    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("alert")]
    public V1beta1JobSpecInitProviderTaskSqlTaskAlert? Alert { get; set; }

    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("dashboard")]
    public V1beta1JobSpecInitProviderTaskSqlTaskDashboard? Dashboard { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public V1beta1JobSpecInitProviderTaskSqlTaskFile? File { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>block consisting of single string field: query_id - identifier of the Databricks Query (databricks_query).</summary>
    [JsonPropertyName("query")]
    public V1beta1JobSpecInitProviderTaskSqlTaskQuery? Query { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskWebhookNotificationsOnDurationWarningThresholdExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskWebhookNotificationsOnFailure
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskWebhookNotificationsOnStart
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskWebhookNotificationsOnStreamingBacklogExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskWebhookNotificationsOnSuccess
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTaskWebhookNotifications
{
    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<V1beta1JobSpecInitProviderTaskWebhookNotificationsOnDurationWarningThresholdExceeded>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1beta1JobSpecInitProviderTaskWebhookNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<V1beta1JobSpecInitProviderTaskWebhookNotificationsOnStart>? OnStart { get; set; }

    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<V1beta1JobSpecInitProviderTaskWebhookNotificationsOnStreamingBacklogExceeded>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1beta1JobSpecInitProviderTaskWebhookNotificationsOnSuccess>? OnSuccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTask
{
    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("cleanRoomsNotebookTask")]
    public V1beta1JobSpecInitProviderTaskCleanRoomsNotebookTask? CleanRoomsNotebookTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("conditionTask")]
    public V1beta1JobSpecInitProviderTaskConditionTask? ConditionTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtTask")]
    public V1beta1JobSpecInitProviderTaskDbtTask? DbtTask { get; set; }

    /// <summary>block specifying dependency(-ies) for a given task.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<V1beta1JobSpecInitProviderTaskDependsOn>? DependsOn { get; set; }

    /// <summary>An optional description for the job. The maximum length is 1024 characters in UTF-8 encoding.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flag to disable auto optimization in serverless tasks.</summary>
    [JsonPropertyName("disableAutoOptimization")]
    public bool? DisableAutoOptimization { get; set; }

    /// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
    [JsonPropertyName("emailNotifications")]
    public V1beta1JobSpecInitProviderTaskEmailNotifications? EmailNotifications { get; set; }

    /// <summary>identifier of an environment block that is used to specify libraries.  Required for some tasks (spark_python_task, python_wheel_task, ...) running on serverless compute.</summary>
    [JsonPropertyName("environmentKey")]
    public string? EnvironmentKey { get; set; }

    /// <summary>If existing_cluster_id, the ID of an existing cluster that will be used for all runs of this job. When running jobs on an existing cluster, you may need to manually restart the cluster if it stops responding. We strongly suggest to use new_cluster for greater reliability.</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    /// <summary>Reference to a Cluster in compute to populate existingClusterId.</summary>
    [JsonPropertyName("existingClusterIdRef")]
    public V1beta1JobSpecInitProviderTaskExistingClusterIdRef? ExistingClusterIdRef { get; set; }

    /// <summary>Selector for a Cluster in compute to populate existingClusterId.</summary>
    [JsonPropertyName("existingClusterIdSelector")]
    public V1beta1JobSpecInitProviderTaskExistingClusterIdSelector? ExistingClusterIdSelector { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("forEachTask")]
    public V1beta1JobSpecInitProviderTaskForEachTask? ForEachTask { get; set; }

    /// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
    [JsonPropertyName("health")]
    public V1beta1JobSpecInitProviderTaskHealth? Health { get; set; }

    /// <summary>Identifier of the Job cluster specified in the job_cluster block.</summary>
    [JsonPropertyName("jobClusterKey")]
    public string? JobClusterKey { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobSpecInitProviderTaskLibrary>? Library { get; set; }

    /// <summary>(Integer) An optional maximum number of times to retry an unsuccessful run. A run is considered to be unsuccessful if it completes with a FAILED or INTERNAL_ERROR lifecycle state. The value -1 means to retry indefinitely and the value 0 means to never retry. The default behavior is to never retry. A run can have the following lifecycle state: PENDING, RUNNING, TERMINATING, TERMINATED, SKIPPED or INTERNAL_ERROR.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>(Integer) An optional minimal interval in milliseconds between the start of the failed run and the subsequent retry run. The default behavior is that unsuccessful runs are immediately retried.</summary>
    [JsonPropertyName("minRetryIntervalMillis")]
    public double? MinRetryIntervalMillis { get; set; }

    /// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
    [JsonPropertyName("newCluster")]
    public V1beta1JobSpecInitProviderTaskNewCluster? NewCluster { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("notebookTask")]
    public V1beta1JobSpecInitProviderTaskNotebookTask? NotebookTask { get; set; }

    /// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
    [JsonPropertyName("notificationSettings")]
    public V1beta1JobSpecInitProviderTaskNotificationSettings? NotificationSettings { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pipelineTask")]
    public V1beta1JobSpecInitProviderTaskPipelineTask? PipelineTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pythonWheelTask")]
    public V1beta1JobSpecInitProviderTaskPythonWheelTask? PythonWheelTask { get; set; }

    /// <summary>(Bool) An optional policy to specify whether to retry a job when it times out. The default behavior is to not retry on timeout.</summary>
    [JsonPropertyName("retryOnTimeout")]
    public bool? RetryOnTimeout { get; set; }

    /// <summary>An optional value indicating the condition that determines whether the task should be run once its dependencies have been completed. One of ALL_SUCCESS, AT_LEAST_ONE_SUCCESS, NONE_FAILED, ALL_DONE, AT_LEAST_ONE_FAILED or ALL_FAILED. When omitted, defaults to ALL_SUCCESS.</summary>
    [JsonPropertyName("runIf")]
    public string? RunIf { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("runJobTask")]
    public V1beta1JobSpecInitProviderTaskRunJobTask? RunJobTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkJarTask")]
    public V1beta1JobSpecInitProviderTaskSparkJarTask? SparkJarTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkPythonTask")]
    public V1beta1JobSpecInitProviderTaskSparkPythonTask? SparkPythonTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkSubmitTask")]
    public V1beta1JobSpecInitProviderTaskSparkSubmitTask? SparkSubmitTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sqlTask")]
    public V1beta1JobSpecInitProviderTaskSqlTask? SqlTask { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }

    /// <summary>(Integer) An optional timeout applied to each run of this job. The default behavior is to have no timeout.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
    [JsonPropertyName("webhookNotifications")]
    public V1beta1JobSpecInitProviderTaskWebhookNotifications? WebhookNotifications { get; set; }
}

/// <summary>configuration block to define a trigger for File Arrival events consisting of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTriggerFileArrival
{
    /// <summary>If set, the trigger starts a run only after the specified amount of time passed since the last time the trigger fired. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("minTimeBetweenTriggersSeconds")]
    public double? MinTimeBetweenTriggersSeconds { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>If set, the trigger starts a run only after no file activity has occurred for the specified amount of time. This makes it possible to wait for a batch of incoming files to arrive before triggering a run. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("waitAfterLastChangeSeconds")]
    public double? WaitAfterLastChangeSeconds { get; set; }
}

/// <summary>configuration block to define a trigger for Periodic Triggers consisting of the following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTriggerPeriodic
{
    /// <summary>Specifies the interval at which the job should run. This value is required.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>Options are {&quot;DAYS&quot;, &quot;HOURS&quot;, &quot;WEEKS&quot;}.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTriggerTable
{
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>If set, the trigger starts a run only after the specified amount of time passed since the last time the trigger fired. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("minTimeBetweenTriggersSeconds")]
    public double? MinTimeBetweenTriggersSeconds { get; set; }

    [JsonPropertyName("tableNames")]
    public IList<string>? TableNames { get; set; }

    /// <summary>If set, the trigger starts a run only after no file activity has occurred for the specified amount of time. This makes it possible to wait for a batch of incoming files to arrive before triggering a run. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("waitAfterLastChangeSeconds")]
    public double? WaitAfterLastChangeSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTriggerTableUpdate
{
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>If set, the trigger starts a run only after the specified amount of time passed since the last time the trigger fired. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("minTimeBetweenTriggersSeconds")]
    public double? MinTimeBetweenTriggersSeconds { get; set; }

    [JsonPropertyName("tableNames")]
    public IList<string>? TableNames { get; set; }

    /// <summary>If set, the trigger starts a run only after no file activity has occurred for the specified amount of time. This makes it possible to wait for a batch of incoming files to arrive before triggering a run. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("waitAfterLastChangeSeconds")]
    public double? WaitAfterLastChangeSeconds { get; set; }
}

/// <summary>The conditions that triggers the job to start. See trigger Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderTrigger
{
    /// <summary>configuration block to define a trigger for File Arrival events consisting of following attributes:</summary>
    [JsonPropertyName("fileArrival")]
    public V1beta1JobSpecInitProviderTriggerFileArrival? FileArrival { get; set; }

    /// <summary>Indicate whether this trigger is paused or not. Either PAUSED or UNPAUSED. When the pause_status field is omitted in the block, the server will default to using UNPAUSED as a value for pause_status.</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }

    /// <summary>configuration block to define a trigger for Periodic Triggers consisting of the following attributes:</summary>
    [JsonPropertyName("periodic")]
    public V1beta1JobSpecInitProviderTriggerPeriodic? Periodic { get; set; }

    [JsonPropertyName("table")]
    public V1beta1JobSpecInitProviderTriggerTable? Table { get; set; }

    [JsonPropertyName("tableUpdate")]
    public V1beta1JobSpecInitProviderTriggerTableUpdate? TableUpdate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderWebhookNotificationsOnDurationWarningThresholdExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderWebhookNotificationsOnFailure
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderWebhookNotificationsOnStart
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderWebhookNotificationsOnStreamingBacklogExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderWebhookNotificationsOnSuccess
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderWebhookNotifications
{
    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<V1beta1JobSpecInitProviderWebhookNotificationsOnDurationWarningThresholdExceeded>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1beta1JobSpecInitProviderWebhookNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<V1beta1JobSpecInitProviderWebhookNotificationsOnStart>? OnStart { get; set; }

    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<V1beta1JobSpecInitProviderWebhookNotificationsOnStreamingBacklogExceeded>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1beta1JobSpecInitProviderWebhookNotificationsOnSuccess>? OnSuccess { get; set; }
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
public partial class V1beta1JobSpecInitProvider
{
    /// <summary>(Bool) Whenever the job is always running, like a Spark Streaming application, on every update restart the current active run or start it again, if nothing it is not running. False by default. Any job runs are started with parameters specified in spark_jar_task or spark_submit_task or spark_python_task or notebook_task blocks.</summary>
    [JsonPropertyName("alwaysRunning")]
    public bool? AlwaysRunning { get; set; }

    /// <summary>The ID of the user-specified budget policy to use for this job. If not specified, a default budget policy may be applied when creating or modifying the job.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>Configuration block to configure pause status. See continuous Configuration Block.</summary>
    [JsonPropertyName("continuous")]
    public V1beta1JobSpecInitProviderContinuous? Continuous { get; set; }

    /// <summary>(Bool) If true, the Databricks provider will stop and start the job as needed to ensure that the active run for the job reflects the deployed configuration. For continuous jobs, the provider respects the pause_status by stopping the current active run. This flag cannot be set for non-continuous jobs.</summary>
    [JsonPropertyName("controlRunState")]
    public bool? ControlRunState { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtTask")]
    public V1beta1JobSpecInitProviderDbtTask? DbtTask { get; set; }

    [JsonPropertyName("deployment")]
    public V1beta1JobSpecInitProviderDeployment? Deployment { get; set; }

    /// <summary>An optional description for the job. The maximum length is 1024 characters in UTF-8 encoding.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If &quot;UI_LOCKED&quot;, the user interface for the job will be locked. If &quot;EDITABLE&quot; (the default), the user interface will be editable.</summary>
    [JsonPropertyName("editMode")]
    public string? EditMode { get; set; }

    /// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
    [JsonPropertyName("emailNotifications")]
    public V1beta1JobSpecInitProviderEmailNotifications? EmailNotifications { get; set; }

    [JsonPropertyName("environment")]
    public IList<V1beta1JobSpecInitProviderEnvironment>? Environment { get; set; }

    /// <summary>Identifier of the interactive cluster to run job on.  Note: running tasks on interactive clusters may lead to increased costs!</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Specifices the a Git repository for task source code. See git_source Configuration Block below.</summary>
    [JsonPropertyName("gitSource")]
    public V1beta1JobSpecInitProviderGitSource? GitSource { get; set; }

    /// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
    [JsonPropertyName("health")]
    public V1beta1JobSpecInitProviderHealth? Health { get; set; }

    /// <summary>A list of job databricks_cluster specifications that can be shared and reused by tasks of this job. Libraries cannot be declared in a shared job cluster. You must declare dependent libraries in task settings. Multi-task syntax</summary>
    [JsonPropertyName("jobCluster")]
    public IList<V1beta1JobSpecInitProviderJobCluster>? JobCluster { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobSpecInitProviderLibrary>? Library { get; set; }

    /// <summary>(Integer) An optional maximum allowed number of concurrent runs of the job. Defaults to 1.</summary>
    [JsonPropertyName("maxConcurrentRuns")]
    public double? MaxConcurrentRuns { get; set; }

    /// <summary>(Integer) An optional maximum number of times to retry an unsuccessful run. A run is considered to be unsuccessful if it completes with a FAILED or INTERNAL_ERROR lifecycle state. The value -1 means to retry indefinitely and the value 0 means to never retry. The default behavior is to never retry. A run can have the following lifecycle state: PENDING, RUNNING, TERMINATING, TERMINATED, SKIPPED or INTERNAL_ERROR.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>(Integer) An optional minimal interval in milliseconds between the start of the failed run and the subsequent retry run. The default behavior is that unsuccessful runs are immediately retried.</summary>
    [JsonPropertyName("minRetryIntervalMillis")]
    public double? MinRetryIntervalMillis { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
    [JsonPropertyName("newCluster")]
    public V1beta1JobSpecInitProviderNewCluster? NewCluster { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("notebookTask")]
    public V1beta1JobSpecInitProviderNotebookTask? NotebookTask { get; set; }

    /// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
    [JsonPropertyName("notificationSettings")]
    public V1beta1JobSpecInitProviderNotificationSettings? NotificationSettings { get; set; }

    /// <summary>Specifices job parameter for the job. See parameter Configuration Block</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1JobSpecInitProviderParameter>? Parameter { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pipelineTask")]
    public V1beta1JobSpecInitProviderPipelineTask? PipelineTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pythonWheelTask")]
    public V1beta1JobSpecInitProviderPythonWheelTask? PythonWheelTask { get; set; }

    /// <summary>The queue status for the job. See queue Configuration Block below.</summary>
    [JsonPropertyName("queue")]
    public V1beta1JobSpecInitProviderQueue? Queue { get; set; }

    /// <summary>(Bool) An optional policy to specify whether to retry a job when it times out. The default behavior is to not retry on timeout.</summary>
    [JsonPropertyName("retryOnTimeout")]
    public bool? RetryOnTimeout { get; set; }

    /// <summary>The user or the service prinicipal the job runs as. See run_as Configuration Block below.</summary>
    [JsonPropertyName("runAs")]
    public V1beta1JobSpecInitProviderRunAs? RunAs { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("runJobTask")]
    public V1beta1JobSpecInitProviderRunJobTask? RunJobTask { get; set; }

    /// <summary>An optional periodic schedule for this job. The default behavior is that the job runs when triggered by clicking Run Now in the Jobs UI or sending an API request to runNow. See schedule Configuration Block below.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1JobSpecInitProviderSchedule? Schedule { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkJarTask")]
    public V1beta1JobSpecInitProviderSparkJarTask? SparkJarTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkPythonTask")]
    public V1beta1JobSpecInitProviderSparkPythonTask? SparkPythonTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkSubmitTask")]
    public V1beta1JobSpecInitProviderSparkSubmitTask? SparkSubmitTask { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("task")]
    public IList<V1beta1JobSpecInitProviderTask>? Task { get; set; }

    /// <summary>(Integer) An optional timeout applied to each run of this job. The default behavior is to have no timeout.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>The conditions that triggers the job to start. See trigger Configuration Block below.</summary>
    [JsonPropertyName("trigger")]
    public V1beta1JobSpecInitProviderTrigger? Trigger { get; set; }

    /// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
    [JsonPropertyName("webhookNotifications")]
    public V1beta1JobSpecInitProviderWebhookNotifications? WebhookNotifications { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecManagementPoliciesEnum>))]
public enum V1beta1JobSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>JobSpec defines the desired state of Job</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1JobSpecForProvider ForProvider { get; set; }

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
    public V1beta1JobSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1JobSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1JobSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1JobSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block to configure pause status. See continuous Configuration Block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderContinuous
{
    /// <summary>Indicate whether this continuous job is paused or not. Either PAUSED or UNPAUSED. When the pause_status field is omitted in the block, the server will default to using UNPAUSED as a value for pause_status.</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderDbtTask
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with &quot;dbt&quot;.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>The relative path to the directory in the repository specified by git_source where dbt should look in for the profiles.yml file. If not specified, defaults to the repository&apos;s root directory. Equivalent to passing --profile-dir to a dbt command.</summary>
    [JsonPropertyName("profilesDirectory")]
    public string? ProfilesDirectory { get; set; }

    /// <summary>The path where dbt should look for dbt_project.yml. Equivalent to passing --project-dir to the dbt CLI.</summary>
    [JsonPropertyName("projectDirectory")]
    public string? ProjectDirectory { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderDeployment
{
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("metadataFilePath")]
    public string? MetadataFilePath { get; set; }
}

/// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderEmailNotifications
{
    /// <summary>(Bool) don&apos;t send alert for skipped runs. (It&apos;s recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }

    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<string>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<string>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<string>? OnStart { get; set; }

    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<string>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<string>? OnSuccess { get; set; }
}

/// <summary>block describing the Environment. Consists of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderEnvironmentSpec
{
    /// <summary>client version used by the environment.</summary>
    [JsonPropertyName("client")]
    public string? Client { get; set; }

    /// <summary>(list of strings) List of pip dependencies, as supported by the version of pip in this environment. Each dependency is a pip requirement file line.  See API docs for more information.</summary>
    [JsonPropertyName("dependencies")]
    public IList<string>? Dependencies { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderEnvironment
{
    /// <summary>identifier of an environment block that is used to specify libraries.  Required for some tasks (spark_python_task, python_wheel_task, ...) running on serverless compute.</summary>
    [JsonPropertyName("environmentKey")]
    public string? EnvironmentKey { get; set; }

    /// <summary>block describing the Environment. Consists of following attributes:</summary>
    [JsonPropertyName("spec")]
    public V1beta1JobStatusAtProviderEnvironmentSpec? Spec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderGitSourceGitSnapshot
{
    /// <summary>hash of Git commit to use. Conflicts with branch and tag.</summary>
    [JsonPropertyName("usedCommit")]
    public string? UsedCommit { get; set; }
}

/// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderGitSourceJobSource
{
    [JsonPropertyName("dirtyState")]
    public string? DirtyState { get; set; }

    /// <summary>name of the Git branch to use. Conflicts with tag and commit.</summary>
    [JsonPropertyName("importFromGitBranch")]
    public string? ImportFromGitBranch { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("jobConfigPath")]
    public string? JobConfigPath { get; set; }
}

/// <summary>Specifices the a Git repository for task source code. See git_source Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderGitSource
{
    /// <summary>name of the Git branch to use. Conflicts with tag and commit.</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>hash of Git commit to use. Conflicts with branch and tag.</summary>
    [JsonPropertyName("commit")]
    public string? Commit { get; set; }

    [JsonPropertyName("gitSnapshot")]
    public V1beta1JobStatusAtProviderGitSourceGitSnapshot? GitSnapshot { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("jobSource")]
    public V1beta1JobStatusAtProviderGitSourceJobSource? JobSource { get; set; }

    /// <summary>case insensitive name of the Git provider.  Following values are supported right now (could be a subject for change, consult Repos API documentation): gitHub, gitHubEnterprise, bitbucketCloud, bitbucketServer, azureDevOpsServices, gitLab, gitLabEnterpriseEdition.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>name of the Git branch to use. Conflicts with branch and commit.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderHealthRules
{
    /// <summary>string specifying the metric to check.  The only supported metric is RUN_DURATION_SECONDS (check Jobs REST API documentation for the latest information).</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>integer value used to compare to the given metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderHealth
{
    /// <summary>(List) list of rules that are represented as objects with the following attributes:</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1JobStatusAtProviderHealthRules>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterAutoscale
{
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterAwsAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterAzureAttributesLogAnalyticsInfo
{
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterAzureAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("logAnalyticsInfo")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterAzureAttributesLogAnalyticsInfo? LogAnalyticsInfo { get; set; }

    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterClusterLogConfDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterClusterLogConfS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterClusterLogConf
{
    [JsonPropertyName("dbfs")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterClusterLogConfDbfs? Dbfs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterClusterLogConfS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterClusterMountInfoNetworkFilesystemInfo
{
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    [JsonPropertyName("networkFilesystemInfo")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterClusterMountInfoNetworkFilesystemInfo? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterDockerImageBasicAuth
{
    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterDockerImage
{
    [JsonPropertyName("basicAuth")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterDockerImageBasicAuth? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterGcpAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterInitScriptsAbfss
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterInitScriptsDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>block consisting of single string fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterInitScriptsFile
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterInitScriptsGcs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterInitScriptsS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterInitScriptsVolumes
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterInitScriptsWorkspace
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterInitScripts
{
    [JsonPropertyName("abfss")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterInitScriptsAbfss? Abfss { get; set; }

    [JsonPropertyName("dbfs")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterInitScriptsDbfs? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterInitScriptsFile? File { get; set; }

    [JsonPropertyName("gcs")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterInitScriptsGcs? Gcs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterInitScriptsS3? S3 { get; set; }

    [JsonPropertyName("volumes")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterInitScriptsVolumes? Volumes { get; set; }

    [JsonPropertyName("workspace")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterInitScriptsWorkspace? Workspace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterLibraryMaven
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
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterWorkloadTypeClients
{
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}

/// <summary>isn&apos;t supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewClusterWorkloadType
{
    [JsonPropertyName("clients")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterWorkloadTypeClients? Clients { get; set; }
}

/// <summary>Block with almost the same set of parameters as for databricks_cluster resource, except following (check the REST API documentation for full list of supported parameters):</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobClusterNewCluster
{
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    [JsonPropertyName("autoscale")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterAutoscale? Autoscale { get; set; }

    [JsonPropertyName("awsAttributes")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterAzureAttributes? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    [JsonPropertyName("clusterLogConf")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterClusterLogConf? ClusterLogConf { get; set; }

    [JsonPropertyName("clusterMountInfo")]
    public IList<V1beta1JobStatusAtProviderJobClusterNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    [JsonPropertyName("dockerImage")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterDockerImage? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterGcpAttributes? GcpAttributes { get; set; }

    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    [JsonPropertyName("initScripts")]
    public IList<V1beta1JobStatusAtProviderJobClusterNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobStatusAtProviderJobClusterNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn&apos;t supported</summary>
    [JsonPropertyName("workloadType")]
    public V1beta1JobStatusAtProviderJobClusterNewClusterWorkloadType? WorkloadType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobCluster
{
    /// <summary>Identifier that can be referenced in task block, so that cluster is shared between tasks</summary>
    [JsonPropertyName("jobClusterKey")]
    public string? JobClusterKey { get; set; }

    /// <summary>Block with almost the same set of parameters as for databricks_cluster resource, except following (check the REST API documentation for full list of supported parameters):</summary>
    [JsonPropertyName("newCluster")]
    public V1beta1JobStatusAtProviderJobClusterNewCluster? NewCluster { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderLibraryMaven
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
public partial class V1beta1JobStatusAtProviderLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobStatusAtProviderLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobStatusAtProviderLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobStatusAtProviderLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterAutoscale
{
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterAwsAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterAzureAttributesLogAnalyticsInfo
{
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterAzureAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("logAnalyticsInfo")]
    public V1beta1JobStatusAtProviderNewClusterAzureAttributesLogAnalyticsInfo? LogAnalyticsInfo { get; set; }

    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterClusterLogConfDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterClusterLogConfS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterClusterLogConf
{
    [JsonPropertyName("dbfs")]
    public V1beta1JobStatusAtProviderNewClusterClusterLogConfDbfs? Dbfs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobStatusAtProviderNewClusterClusterLogConfS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterClusterMountInfoNetworkFilesystemInfo
{
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    [JsonPropertyName("networkFilesystemInfo")]
    public V1beta1JobStatusAtProviderNewClusterClusterMountInfoNetworkFilesystemInfo? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterDockerImageBasicAuth
{
    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterDockerImage
{
    [JsonPropertyName("basicAuth")]
    public V1beta1JobStatusAtProviderNewClusterDockerImageBasicAuth? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterGcpAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterInitScriptsAbfss
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterInitScriptsDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>block consisting of single string fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterInitScriptsFile
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterInitScriptsGcs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterInitScriptsS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterInitScriptsVolumes
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterInitScriptsWorkspace
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterInitScripts
{
    [JsonPropertyName("abfss")]
    public V1beta1JobStatusAtProviderNewClusterInitScriptsAbfss? Abfss { get; set; }

    [JsonPropertyName("dbfs")]
    public V1beta1JobStatusAtProviderNewClusterInitScriptsDbfs? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public V1beta1JobStatusAtProviderNewClusterInitScriptsFile? File { get; set; }

    [JsonPropertyName("gcs")]
    public V1beta1JobStatusAtProviderNewClusterInitScriptsGcs? Gcs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobStatusAtProviderNewClusterInitScriptsS3? S3 { get; set; }

    [JsonPropertyName("volumes")]
    public V1beta1JobStatusAtProviderNewClusterInitScriptsVolumes? Volumes { get; set; }

    [JsonPropertyName("workspace")]
    public V1beta1JobStatusAtProviderNewClusterInitScriptsWorkspace? Workspace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterLibraryMaven
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
public partial class V1beta1JobStatusAtProviderNewClusterLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobStatusAtProviderNewClusterLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobStatusAtProviderNewClusterLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobStatusAtProviderNewClusterLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterWorkloadTypeClients
{
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}

/// <summary>isn&apos;t supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewClusterWorkloadType
{
    [JsonPropertyName("clients")]
    public V1beta1JobStatusAtProviderNewClusterWorkloadTypeClients? Clients { get; set; }
}

/// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNewCluster
{
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    [JsonPropertyName("autoscale")]
    public V1beta1JobStatusAtProviderNewClusterAutoscale? Autoscale { get; set; }

    [JsonPropertyName("awsAttributes")]
    public V1beta1JobStatusAtProviderNewClusterAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1JobStatusAtProviderNewClusterAzureAttributes? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    [JsonPropertyName("clusterLogConf")]
    public V1beta1JobStatusAtProviderNewClusterClusterLogConf? ClusterLogConf { get; set; }

    [JsonPropertyName("clusterMountInfo")]
    public IList<V1beta1JobStatusAtProviderNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    [JsonPropertyName("dockerImage")]
    public V1beta1JobStatusAtProviderNewClusterDockerImage? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1JobStatusAtProviderNewClusterGcpAttributes? GcpAttributes { get; set; }

    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    [JsonPropertyName("initScripts")]
    public IList<V1beta1JobStatusAtProviderNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobStatusAtProviderNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn&apos;t supported</summary>
    [JsonPropertyName("workloadType")]
    public V1beta1JobStatusAtProviderNewClusterWorkloadType? WorkloadType { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNotebookTask
{
    /// <summary>(Map) Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used. If the notebook takes a parameter that is not specified in the job’s base_parameters or the run-now override parameters, the default value from the notebook will be used. Retrieve these parameters in a notebook using dbutils.widgets.get.</summary>
    [JsonPropertyName("baseParameters")]
    public IDictionary<string, string>? BaseParameters { get; set; }

    /// <summary>The path of the databricks_notebook to be run in the Databricks workspace or remote repository. For notebooks stored in the Databricks workspace, the path must be absolute and begin with a slash. For notebooks stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("notebookPath")]
    public string? NotebookPath { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderNotificationSettings
{
    /// <summary>(Bool) don&apos;t send alert for cancelled runs.</summary>
    [JsonPropertyName("noAlertForCanceledRuns")]
    public bool? NoAlertForCanceledRuns { get; set; }

    /// <summary>(Bool) don&apos;t send alert for skipped runs. (It&apos;s recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderParameter
{
    /// <summary>Default value of the parameter.</summary>
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderPipelineTask
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }

    /// <summary>The pipeline&apos;s unique ID.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderPythonWheelTask
{
    /// <summary>Python function as entry point for the task</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Named parameters for the task</summary>
    [JsonPropertyName("namedParameters")]
    public IDictionary<string, string>? NamedParameters { get; set; }

    /// <summary>Name of Python package</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

/// <summary>The queue status for the job. See queue Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderQueue
{
    /// <summary>If true, enable queueing for the job.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The user or the service prinicipal the job runs as. See run_as Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderRunAs
{
    /// <summary>The application ID of an active service principal. Setting this field requires the servicePrincipal/user role.</summary>
    [JsonPropertyName("servicePrincipalName")]
    public string? ServicePrincipalName { get; set; }

    /// <summary>The email of an active workspace user. Non-admin users can only set this field to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderRunJobTask
{
    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("jobId")]
    public double? JobId { get; set; }

    /// <summary>(Map) Job parameters for the task</summary>
    [JsonPropertyName("jobParameters")]
    public IDictionary<string, string>? JobParameters { get; set; }
}

/// <summary>An optional periodic schedule for this job. The default behavior is that the job runs when triggered by clicking Run Now in the Jobs UI or sending an API request to runNow. See schedule Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderSchedule
{
    /// <summary>Indicate whether this schedule is paused or not. Either PAUSED or UNPAUSED. When the pause_status field is omitted and a schedule is provided, the server will default to using UNPAUSED as a value for pause_status.</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }

    /// <summary>A Cron expression using Quartz syntax that describes the schedule for a job. This field is required.</summary>
    [JsonPropertyName("quartzCronExpression")]
    public string? QuartzCronExpression { get; set; }

    /// <summary>A Java timezone ID. The schedule for a job will be resolved with respect to this timezone. See Java TimeZone for details. This field is required.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderSparkJarTask
{
    [JsonPropertyName("jarUri")]
    public string? JarUri { get; set; }

    /// <summary>The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. The code should use SparkContext.getOrCreate to obtain a Spark context; otherwise, runs of the job will fail.</summary>
    [JsonPropertyName("mainClassName")]
    public string? MainClassName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderSparkPythonTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary>The URI of the Python file to be executed. databricks_dbfs_file, cloud file URIs (e.g. s3:/, abfss:/, gs:/), workspace paths and remote repository are supported. For Python files stored in the Databricks workspace, the path must be absolute and begin with /Repos. For files stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("pythonFile")]
    public string? PythonFile { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderSparkSubmitTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskCleanRoomsNotebookTask
{
    /// <summary>The clean room that the notebook belongs to.</summary>
    [JsonPropertyName("cleanRoomName")]
    public string? CleanRoomName { get; set; }

    /// <summary>Checksum to validate the freshness of the notebook resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>(Map) Base parameters to be used for the clean room notebook job.</summary>
    [JsonPropertyName("notebookBaseParameters")]
    public IDictionary<string, string>? NotebookBaseParameters { get; set; }

    /// <summary>Name of the notebook being run.</summary>
    [JsonPropertyName("notebookName")]
    public string? NotebookName { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskConditionTask
{
    /// <summary>The left operand of the condition task. It could be a string value, job state, or a parameter reference.</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>The right operand of the condition task. It could be a string value, job state, or parameter reference.</summary>
    [JsonPropertyName("right")]
    public string? Right { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskDbtTask
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with &quot;dbt&quot;.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>The relative path to the directory in the repository specified by git_source where dbt should look in for the profiles.yml file. If not specified, defaults to the repository&apos;s root directory. Equivalent to passing --profile-dir to a dbt command.</summary>
    [JsonPropertyName("profilesDirectory")]
    public string? ProfilesDirectory { get; set; }

    /// <summary>The path where dbt should look for dbt_project.yml. Equivalent to passing --project-dir to the dbt CLI.</summary>
    [JsonPropertyName("projectDirectory")]
    public string? ProjectDirectory { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskDependsOn
{
    /// <summary>Can only be specified on condition task dependencies. The outcome of the dependent task that must be met for this task to run. Possible values are &quot;true&quot; or &quot;false&quot;.</summary>
    [JsonPropertyName("outcome")]
    public string? Outcome { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }
}

/// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskEmailNotifications
{
    /// <summary>(Bool) don&apos;t send alert for skipped runs. (It&apos;s recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }

    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<string>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<string>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<string>? OnStart { get; set; }

    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<string>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<string>? OnSuccess { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskCleanRoomsNotebookTask
{
    /// <summary>The clean room that the notebook belongs to.</summary>
    [JsonPropertyName("cleanRoomName")]
    public string? CleanRoomName { get; set; }

    /// <summary>Checksum to validate the freshness of the notebook resource.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>(Map) Base parameters to be used for the clean room notebook job.</summary>
    [JsonPropertyName("notebookBaseParameters")]
    public IDictionary<string, string>? NotebookBaseParameters { get; set; }

    /// <summary>Name of the notebook being run.</summary>
    [JsonPropertyName("notebookName")]
    public string? NotebookName { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskConditionTask
{
    /// <summary>The left operand of the condition task. It could be a string value, job state, or a parameter reference.</summary>
    [JsonPropertyName("left")]
    public string? Left { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>The right operand of the condition task. It could be a string value, job state, or parameter reference.</summary>
    [JsonPropertyName("right")]
    public string? Right { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskDbtTask
{
    /// <summary>The name of the catalog to use inside Unity Catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with &quot;dbt&quot;.</summary>
    [JsonPropertyName("commands")]
    public IList<string>? Commands { get; set; }

    /// <summary>The relative path to the directory in the repository specified by git_source where dbt should look in for the profiles.yml file. If not specified, defaults to the repository&apos;s root directory. Equivalent to passing --profile-dir to a dbt command.</summary>
    [JsonPropertyName("profilesDirectory")]
    public string? ProfilesDirectory { get; set; }

    /// <summary>The path where dbt should look for dbt_project.yml. Equivalent to passing --project-dir to the dbt CLI.</summary>
    [JsonPropertyName("projectDirectory")]
    public string? ProjectDirectory { get; set; }

    /// <summary>The name of the schema dbt should run in. Defaults to default.</summary>
    [JsonPropertyName("schema")]
    public string? Schema { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskDependsOn
{
    /// <summary>Can only be specified on condition task dependencies. The outcome of the dependent task that must be met for this task to run. Possible values are &quot;true&quot; or &quot;false&quot;.</summary>
    [JsonPropertyName("outcome")]
    public string? Outcome { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }
}

/// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskEmailNotifications
{
    /// <summary>(Bool) don&apos;t send alert for skipped runs. (It&apos;s recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }

    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<string>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<string>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<string>? OnStart { get; set; }

    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<string>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<string>? OnSuccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskHealthRules
{
    /// <summary>string specifying the metric to check.  The only supported metric is RUN_DURATION_SECONDS (check Jobs REST API documentation for the latest information).</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>integer value used to compare to the given metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskHealth
{
    /// <summary>(List) list of rules that are represented as objects with the following attributes:</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1JobStatusAtProviderTaskForEachTaskTaskHealthRules>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskLibraryMaven
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
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterAutoscale
{
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterAwsAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterAzureAttributesLogAnalyticsInfo
{
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterAzureAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("logAnalyticsInfo")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterAzureAttributesLogAnalyticsInfo? LogAnalyticsInfo { get; set; }

    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterLogConfDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterLogConfS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterLogConf
{
    [JsonPropertyName("dbfs")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterLogConfDbfs? Dbfs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterLogConfS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterMountInfoNetworkFilesystemInfo
{
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    [JsonPropertyName("networkFilesystemInfo")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterMountInfoNetworkFilesystemInfo? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuth
{
    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterDockerImage
{
    [JsonPropertyName("basicAuth")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterDockerImageBasicAuth? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterGcpAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsAbfss
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>block consisting of single string fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsFile
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsGcs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsVolumes
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsWorkspace
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScripts
{
    [JsonPropertyName("abfss")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsAbfss? Abfss { get; set; }

    [JsonPropertyName("dbfs")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsDbfs? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsFile? File { get; set; }

    [JsonPropertyName("gcs")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsGcs? Gcs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsS3? S3 { get; set; }

    [JsonPropertyName("volumes")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsVolumes? Volumes { get; set; }

    [JsonPropertyName("workspace")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScriptsWorkspace? Workspace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterLibraryMaven
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
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterWorkloadTypeClients
{
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}

/// <summary>isn&apos;t supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterWorkloadType
{
    [JsonPropertyName("clients")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterWorkloadTypeClients? Clients { get; set; }
}

/// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNewCluster
{
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    [JsonPropertyName("autoscale")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterAutoscale? Autoscale { get; set; }

    [JsonPropertyName("awsAttributes")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterAzureAttributes? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    [JsonPropertyName("clusterLogConf")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterLogConf? ClusterLogConf { get; set; }

    [JsonPropertyName("clusterMountInfo")]
    public IList<V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    [JsonPropertyName("dockerImage")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterDockerImage? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterGcpAttributes? GcpAttributes { get; set; }

    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    [JsonPropertyName("initScripts")]
    public IList<V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn&apos;t supported</summary>
    [JsonPropertyName("workloadType")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewClusterWorkloadType? WorkloadType { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNotebookTask
{
    /// <summary>(Map) Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used. If the notebook takes a parameter that is not specified in the job’s base_parameters or the run-now override parameters, the default value from the notebook will be used. Retrieve these parameters in a notebook using dbutils.widgets.get.</summary>
    [JsonPropertyName("baseParameters")]
    public IDictionary<string, string>? BaseParameters { get; set; }

    /// <summary>The path of the databricks_notebook to be run in the Databricks workspace or remote repository. For notebooks stored in the Databricks workspace, the path must be absolute and begin with a slash. For notebooks stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("notebookPath")]
    public string? NotebookPath { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskNotificationSettings
{
    /// <summary>(Bool) do not send notifications to recipients specified in on_start for the retried runs and do not send notifications to recipients specified in on_failure until the last retry of the run.</summary>
    [JsonPropertyName("alertOnLastAttempt")]
    public bool? AlertOnLastAttempt { get; set; }

    /// <summary>(Bool) don&apos;t send alert for cancelled runs.</summary>
    [JsonPropertyName("noAlertForCanceledRuns")]
    public bool? NoAlertForCanceledRuns { get; set; }

    /// <summary>(Bool) don&apos;t send alert for skipped runs. (It&apos;s recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskPipelineTask
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }

    /// <summary>The pipeline&apos;s unique ID.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskPythonWheelTask
{
    /// <summary>Python function as entry point for the task</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Named parameters for the task</summary>
    [JsonPropertyName("namedParameters")]
    public IDictionary<string, string>? NamedParameters { get; set; }

    /// <summary>Name of Python package</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskRunJobTaskPipelineParams
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskRunJobTask
{
    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with &quot;dbt&quot;.</summary>
    [JsonPropertyName("dbtCommands")]
    public IList<string>? DbtCommands { get; set; }

    [JsonPropertyName("jarParams")]
    public IList<string>? JarParams { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("jobId")]
    public double? JobId { get; set; }

    /// <summary>(Map) Job parameters for the task</summary>
    [JsonPropertyName("jobParameters")]
    public IDictionary<string, string>? JobParameters { get; set; }

    [JsonPropertyName("notebookParams")]
    public IDictionary<string, string>? NotebookParams { get; set; }

    [JsonPropertyName("pipelineParams")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskRunJobTaskPipelineParams? PipelineParams { get; set; }

    [JsonPropertyName("pythonNamedParams")]
    public IDictionary<string, string>? PythonNamedParams { get; set; }

    [JsonPropertyName("pythonParams")]
    public IList<string>? PythonParams { get; set; }

    [JsonPropertyName("sparkSubmitParams")]
    public IList<string>? SparkSubmitParams { get; set; }

    [JsonPropertyName("sqlParams")]
    public IDictionary<string, string>? SqlParams { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskSparkJarTask
{
    [JsonPropertyName("jarUri")]
    public string? JarUri { get; set; }

    /// <summary>The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. The code should use SparkContext.getOrCreate to obtain a Spark context; otherwise, runs of the job will fail.</summary>
    [JsonPropertyName("mainClassName")]
    public string? MainClassName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    [JsonPropertyName("runAsRepl")]
    public bool? RunAsRepl { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskSparkPythonTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary>The URI of the Python file to be executed. databricks_dbfs_file, cloud file URIs (e.g. s3:/, abfss:/, gs:/), workspace paths and remote repository are supported. For Python files stored in the Databricks workspace, the path must be absolute and begin with /Repos. For files stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("pythonFile")]
    public string? PythonFile { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskSparkSubmitTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskSqlTaskAlertSubscriptions
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>The email of an active workspace user. Non-admin users can only set this field to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>block consisting of following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskSqlTaskAlert
{
    /// <summary>(String) identifier of the Databricks Alert (databricks_alert).</summary>
    [JsonPropertyName("alertId")]
    public string? AlertId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination&apos;s identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1beta1JobStatusAtProviderTaskForEachTaskTaskSqlTaskAlertSubscriptions>? Subscriptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskSqlTaskDashboardSubscriptions
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>The email of an active workspace user. Non-admin users can only set this field to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>block consisting of following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskSqlTaskDashboard
{
    /// <summary>string specifying a custom subject of email sent.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>(String) identifier of the Databricks SQL Dashboard databricks_sql_dashboard.</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination&apos;s identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1beta1JobStatusAtProviderTaskForEachTaskTaskSqlTaskDashboardSubscriptions>? Subscriptions { get; set; }
}

/// <summary>block consisting of single string fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskSqlTaskFile
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>block consisting of single string field: query_id - identifier of the Databricks Query (databricks_query).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskSqlTaskQuery
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskSqlTask
{
    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("alert")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskSqlTaskAlert? Alert { get; set; }

    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("dashboard")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskSqlTaskDashboard? Dashboard { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskSqlTaskFile? File { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>block consisting of single string field: query_id - identifier of the Databricks Query (databricks_query).</summary>
    [JsonPropertyName("query")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskSqlTaskQuery? Query { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnDurationWarningThresholdExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnFailure
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnStart
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnStreamingBacklogExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnSuccess
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTaskWebhookNotifications
{
    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<V1beta1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnDurationWarningThresholdExceeded>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1beta1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<V1beta1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnStart>? OnStart { get; set; }

    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<V1beta1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnStreamingBacklogExceeded>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1beta1JobStatusAtProviderTaskForEachTaskTaskWebhookNotificationsOnSuccess>? OnSuccess { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTaskTask
{
    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("cleanRoomsNotebookTask")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskCleanRoomsNotebookTask? CleanRoomsNotebookTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("conditionTask")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskConditionTask? ConditionTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtTask")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskDbtTask? DbtTask { get; set; }

    /// <summary>block specifying dependency(-ies) for a given task.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<V1beta1JobStatusAtProviderTaskForEachTaskTaskDependsOn>? DependsOn { get; set; }

    /// <summary>An optional description for the job. The maximum length is 1024 characters in UTF-8 encoding.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flag to disable auto optimization in serverless tasks.</summary>
    [JsonPropertyName("disableAutoOptimization")]
    public bool? DisableAutoOptimization { get; set; }

    /// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
    [JsonPropertyName("emailNotifications")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskEmailNotifications? EmailNotifications { get; set; }

    /// <summary>identifier of an environment block that is used to specify libraries.  Required for some tasks (spark_python_task, python_wheel_task, ...) running on serverless compute.</summary>
    [JsonPropertyName("environmentKey")]
    public string? EnvironmentKey { get; set; }

    /// <summary>If existing_cluster_id, the ID of an existing cluster that will be used for all runs of this job. When running jobs on an existing cluster, you may need to manually restart the cluster if it stops responding. We strongly suggest to use new_cluster for greater reliability.</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    /// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
    [JsonPropertyName("health")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskHealth? Health { get; set; }

    /// <summary>Identifier of the Job cluster specified in the job_cluster block.</summary>
    [JsonPropertyName("jobClusterKey")]
    public string? JobClusterKey { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobStatusAtProviderTaskForEachTaskTaskLibrary>? Library { get; set; }

    /// <summary>(Integer) An optional maximum number of times to retry an unsuccessful run. A run is considered to be unsuccessful if it completes with a FAILED or INTERNAL_ERROR lifecycle state. The value -1 means to retry indefinitely and the value 0 means to never retry. The default behavior is to never retry. A run can have the following lifecycle state: PENDING, RUNNING, TERMINATING, TERMINATED, SKIPPED or INTERNAL_ERROR.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>(Integer) An optional minimal interval in milliseconds between the start of the failed run and the subsequent retry run. The default behavior is that unsuccessful runs are immediately retried.</summary>
    [JsonPropertyName("minRetryIntervalMillis")]
    public double? MinRetryIntervalMillis { get; set; }

    /// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
    [JsonPropertyName("newCluster")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNewCluster? NewCluster { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("notebookTask")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNotebookTask? NotebookTask { get; set; }

    /// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
    [JsonPropertyName("notificationSettings")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskNotificationSettings? NotificationSettings { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pipelineTask")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskPipelineTask? PipelineTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pythonWheelTask")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskPythonWheelTask? PythonWheelTask { get; set; }

    /// <summary>(Bool) An optional policy to specify whether to retry a job when it times out. The default behavior is to not retry on timeout.</summary>
    [JsonPropertyName("retryOnTimeout")]
    public bool? RetryOnTimeout { get; set; }

    /// <summary>An optional value indicating the condition that determines whether the task should be run once its dependencies have been completed. One of ALL_SUCCESS, AT_LEAST_ONE_SUCCESS, NONE_FAILED, ALL_DONE, AT_LEAST_ONE_FAILED or ALL_FAILED. When omitted, defaults to ALL_SUCCESS.</summary>
    [JsonPropertyName("runIf")]
    public string? RunIf { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("runJobTask")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskRunJobTask? RunJobTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkJarTask")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskSparkJarTask? SparkJarTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkPythonTask")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskSparkPythonTask? SparkPythonTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkSubmitTask")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskSparkSubmitTask? SparkSubmitTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sqlTask")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskSqlTask? SqlTask { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }

    /// <summary>(Integer) An optional timeout applied to each run of this job. The default behavior is to have no timeout.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
    [JsonPropertyName("webhookNotifications")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTaskWebhookNotifications? WebhookNotifications { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskForEachTask
{
    /// <summary>Controls the number of active iteration task runs. Default is 20, maximum allowed is 100.</summary>
    [JsonPropertyName("concurrency")]
    public double? Concurrency { get; set; }

    /// <summary>(String) Array for task to iterate on. This can be a JSON string or a reference to an array parameter.</summary>
    [JsonPropertyName("inputs")]
    public string? Inputs { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("task")]
    public V1beta1JobStatusAtProviderTaskForEachTaskTask? Task { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskHealthRules
{
    /// <summary>string specifying the metric to check.  The only supported metric is RUN_DURATION_SECONDS (check Jobs REST API documentation for the latest information).</summary>
    [JsonPropertyName("metric")]
    public string? Metric { get; set; }

    /// <summary>The string specifying the operation used to compare operands.  Currently, following operators are supported: EQUAL_TO, GREATER_THAN, GREATER_THAN_OR_EQUAL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL. (Check the API docs for the latest information).</summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>integer value used to compare to the given metric.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskHealth
{
    /// <summary>(List) list of rules that are represented as objects with the following attributes:</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1JobStatusAtProviderTaskHealthRules>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskLibraryMaven
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
public partial class V1beta1JobStatusAtProviderTaskLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobStatusAtProviderTaskLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobStatusAtProviderTaskLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobStatusAtProviderTaskLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterAutoscale
{
    [JsonPropertyName("maxWorkers")]
    public double? MaxWorkers { get; set; }

    [JsonPropertyName("minWorkers")]
    public double? MinWorkers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterAwsAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("ebsVolumeCount")]
    public double? EbsVolumeCount { get; set; }

    [JsonPropertyName("ebsVolumeIops")]
    public double? EbsVolumeIops { get; set; }

    [JsonPropertyName("ebsVolumeSize")]
    public double? EbsVolumeSize { get; set; }

    [JsonPropertyName("ebsVolumeThroughput")]
    public double? EbsVolumeThroughput { get; set; }

    [JsonPropertyName("ebsVolumeType")]
    public string? EbsVolumeType { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    [JsonPropertyName("spotBidPricePercent")]
    public double? SpotBidPricePercent { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterAzureAttributesLogAnalyticsInfo
{
    [JsonPropertyName("logAnalyticsPrimaryKey")]
    public string? LogAnalyticsPrimaryKey { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterAzureAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("firstOnDemand")]
    public double? FirstOnDemand { get; set; }

    [JsonPropertyName("logAnalyticsInfo")]
    public V1beta1JobStatusAtProviderTaskNewClusterAzureAttributesLogAnalyticsInfo? LogAnalyticsInfo { get; set; }

    [JsonPropertyName("spotBidMaxPrice")]
    public double? SpotBidMaxPrice { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterClusterLogConfDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterClusterLogConfS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterClusterLogConf
{
    [JsonPropertyName("dbfs")]
    public V1beta1JobStatusAtProviderTaskNewClusterClusterLogConfDbfs? Dbfs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobStatusAtProviderTaskNewClusterClusterLogConfS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterClusterMountInfoNetworkFilesystemInfo
{
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    [JsonPropertyName("serverAddress")]
    public string? ServerAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterClusterMountInfo
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("localMountDirPath")]
    public string? LocalMountDirPath { get; set; }

    [JsonPropertyName("networkFilesystemInfo")]
    public V1beta1JobStatusAtProviderTaskNewClusterClusterMountInfoNetworkFilesystemInfo? NetworkFilesystemInfo { get; set; }

    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("remoteMountDirPath")]
    public string? RemoteMountDirPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterDockerImageBasicAuth
{
    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterDockerImage
{
    [JsonPropertyName("basicAuth")]
    public V1beta1JobStatusAtProviderTaskNewClusterDockerImageBasicAuth? BasicAuth { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterGcpAttributes
{
    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("bootDiskSize")]
    public double? BootDiskSize { get; set; }

    [JsonPropertyName("googleServiceAccount")]
    public string? GoogleServiceAccount { get; set; }

    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    [JsonPropertyName("usePreemptibleExecutors")]
    public bool? UsePreemptibleExecutors { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("zoneId")]
    public string? ZoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterInitScriptsAbfss
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterInitScriptsDbfs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

/// <summary>block consisting of single string fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterInitScriptsFile
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterInitScriptsGcs
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterInitScriptsS3
{
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }

    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterInitScriptsVolumes
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterInitScriptsWorkspace
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterInitScripts
{
    [JsonPropertyName("abfss")]
    public V1beta1JobStatusAtProviderTaskNewClusterInitScriptsAbfss? Abfss { get; set; }

    [JsonPropertyName("dbfs")]
    public V1beta1JobStatusAtProviderTaskNewClusterInitScriptsDbfs? Dbfs { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public V1beta1JobStatusAtProviderTaskNewClusterInitScriptsFile? File { get; set; }

    [JsonPropertyName("gcs")]
    public V1beta1JobStatusAtProviderTaskNewClusterInitScriptsGcs? Gcs { get; set; }

    [JsonPropertyName("s3")]
    public V1beta1JobStatusAtProviderTaskNewClusterInitScriptsS3? S3 { get; set; }

    [JsonPropertyName("volumes")]
    public V1beta1JobStatusAtProviderTaskNewClusterInitScriptsVolumes? Volumes { get; set; }

    [JsonPropertyName("workspace")]
    public V1beta1JobStatusAtProviderTaskNewClusterInitScriptsWorkspace? Workspace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterLibraryCran
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterLibraryMaven
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
public partial class V1beta1JobStatusAtProviderTaskNewClusterLibraryPypi
{
    [JsonPropertyName("package")]
    public string? Package { get; set; }

    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterLibrary
{
    [JsonPropertyName("cran")]
    public V1beta1JobStatusAtProviderTaskNewClusterLibraryCran? Cran { get; set; }

    [JsonPropertyName("egg")]
    public string? Egg { get; set; }

    [JsonPropertyName("jar")]
    public string? Jar { get; set; }

    [JsonPropertyName("maven")]
    public V1beta1JobStatusAtProviderTaskNewClusterLibraryMaven? Maven { get; set; }

    [JsonPropertyName("pypi")]
    public V1beta1JobStatusAtProviderTaskNewClusterLibraryPypi? Pypi { get; set; }

    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    [JsonPropertyName("whl")]
    public string? Whl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterWorkloadTypeClients
{
    [JsonPropertyName("jobs")]
    public bool? Jobs { get; set; }

    [JsonPropertyName("notebooks")]
    public bool? Notebooks { get; set; }
}

/// <summary>isn&apos;t supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewClusterWorkloadType
{
    [JsonPropertyName("clients")]
    public V1beta1JobStatusAtProviderTaskNewClusterWorkloadTypeClients? Clients { get; set; }
}

/// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNewCluster
{
    [JsonPropertyName("applyPolicyDefaultValues")]
    public bool? ApplyPolicyDefaultValues { get; set; }

    [JsonPropertyName("autoscale")]
    public V1beta1JobStatusAtProviderTaskNewClusterAutoscale? Autoscale { get; set; }

    [JsonPropertyName("awsAttributes")]
    public V1beta1JobStatusAtProviderTaskNewClusterAwsAttributes? AwsAttributes { get; set; }

    [JsonPropertyName("azureAttributes")]
    public V1beta1JobStatusAtProviderTaskNewClusterAzureAttributes? AzureAttributes { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; set; }

    [JsonPropertyName("clusterLogConf")]
    public V1beta1JobStatusAtProviderTaskNewClusterClusterLogConf? ClusterLogConf { get; set; }

    [JsonPropertyName("clusterMountInfo")]
    public IList<V1beta1JobStatusAtProviderTaskNewClusterClusterMountInfo>? ClusterMountInfo { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    [JsonPropertyName("dataSecurityMode")]
    public string? DataSecurityMode { get; set; }

    [JsonPropertyName("dockerImage")]
    public V1beta1JobStatusAtProviderTaskNewClusterDockerImage? DockerImage { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverInstancePoolId")]
    public string? DriverInstancePoolId { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("driverNodeTypeId")]
    public string? DriverNodeTypeId { get; set; }

    [JsonPropertyName("enableElasticDisk")]
    public bool? EnableElasticDisk { get; set; }

    [JsonPropertyName("enableLocalDiskEncryption")]
    public bool? EnableLocalDiskEncryption { get; set; }

    [JsonPropertyName("gcpAttributes")]
    public V1beta1JobStatusAtProviderTaskNewClusterGcpAttributes? GcpAttributes { get; set; }

    [JsonPropertyName("idempotencyToken")]
    public string? IdempotencyToken { get; set; }

    [JsonPropertyName("initScripts")]
    public IList<V1beta1JobStatusAtProviderTaskNewClusterInitScripts>? InitScripts { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("instancePoolId")]
    public string? InstancePoolId { get; set; }

    [JsonPropertyName("isSingleNode")]
    public bool? IsSingleNode { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobStatusAtProviderTaskNewClusterLibrary>? Library { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("nodeTypeId")]
    public string? NodeTypeId { get; set; }

    [JsonPropertyName("numWorkers")]
    public double? NumWorkers { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    [JsonPropertyName("runtimeEngine")]
    public string? RuntimeEngine { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("singleUserName")]
    public string? SingleUserName { get; set; }

    [JsonPropertyName("sparkConf")]
    public IDictionary<string, string>? SparkConf { get; set; }

    [JsonPropertyName("sparkEnvVars")]
    public IDictionary<string, string>? SparkEnvVars { get; set; }

    /// <summary>parameter in databricks_cluster and other resources.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    [JsonPropertyName("sshPublicKeys")]
    public IList<string>? SshPublicKeys { get; set; }

    [JsonPropertyName("useMlRuntime")]
    public bool? UseMlRuntime { get; set; }

    /// <summary>isn&apos;t supported</summary>
    [JsonPropertyName("workloadType")]
    public V1beta1JobStatusAtProviderTaskNewClusterWorkloadType? WorkloadType { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNotebookTask
{
    /// <summary>(Map) Base parameters to be used for each run of this job. If the run is initiated by a call to run-now with parameters specified, the two parameters maps will be merged. If the same key is specified in base_parameters and in run-now, the value from run-now will be used. If the notebook takes a parameter that is not specified in the job’s base_parameters or the run-now override parameters, the default value from the notebook will be used. Retrieve these parameters in a notebook using dbutils.widgets.get.</summary>
    [JsonPropertyName("baseParameters")]
    public IDictionary<string, string>? BaseParameters { get; set; }

    /// <summary>The path of the databricks_notebook to be run in the Databricks workspace or remote repository. For notebooks stored in the Databricks workspace, the path must be absolute and begin with a slash. For notebooks stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("notebookPath")]
    public string? NotebookPath { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskNotificationSettings
{
    /// <summary>(Bool) do not send notifications to recipients specified in on_start for the retried runs and do not send notifications to recipients specified in on_failure until the last retry of the run.</summary>
    [JsonPropertyName("alertOnLastAttempt")]
    public bool? AlertOnLastAttempt { get; set; }

    /// <summary>(Bool) don&apos;t send alert for cancelled runs.</summary>
    [JsonPropertyName("noAlertForCanceledRuns")]
    public bool? NoAlertForCanceledRuns { get; set; }

    /// <summary>(Bool) don&apos;t send alert for skipped runs. (It&apos;s recommended to use the corresponding setting in the notification_settings configuration block).</summary>
    [JsonPropertyName("noAlertForSkippedRuns")]
    public bool? NoAlertForSkippedRuns { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskPipelineTask
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }

    /// <summary>The pipeline&apos;s unique ID.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskPythonWheelTask
{
    /// <summary>Python function as entry point for the task</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Named parameters for the task</summary>
    [JsonPropertyName("namedParameters")]
    public IDictionary<string, string>? NamedParameters { get; set; }

    /// <summary>Name of Python package</summary>
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskRunJobTaskPipelineParams
{
    /// <summary>(Bool) Specifies if there should be full refresh of the pipeline.</summary>
    [JsonPropertyName("fullRefresh")]
    public bool? FullRefresh { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskRunJobTask
{
    /// <summary>(Array) Series of dbt commands to execute in sequence. Every command must start with &quot;dbt&quot;.</summary>
    [JsonPropertyName("dbtCommands")]
    public IList<string>? DbtCommands { get; set; }

    [JsonPropertyName("jarParams")]
    public IList<string>? JarParams { get; set; }

    /// <summary>(String) ID of the job</summary>
    [JsonPropertyName("jobId")]
    public double? JobId { get; set; }

    /// <summary>(Map) Job parameters for the task</summary>
    [JsonPropertyName("jobParameters")]
    public IDictionary<string, string>? JobParameters { get; set; }

    [JsonPropertyName("notebookParams")]
    public IDictionary<string, string>? NotebookParams { get; set; }

    [JsonPropertyName("pipelineParams")]
    public V1beta1JobStatusAtProviderTaskRunJobTaskPipelineParams? PipelineParams { get; set; }

    [JsonPropertyName("pythonNamedParams")]
    public IDictionary<string, string>? PythonNamedParams { get; set; }

    [JsonPropertyName("pythonParams")]
    public IList<string>? PythonParams { get; set; }

    [JsonPropertyName("sparkSubmitParams")]
    public IList<string>? SparkSubmitParams { get; set; }

    [JsonPropertyName("sqlParams")]
    public IDictionary<string, string>? SqlParams { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskSparkJarTask
{
    [JsonPropertyName("jarUri")]
    public string? JarUri { get; set; }

    /// <summary>The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. The code should use SparkContext.getOrCreate to obtain a Spark context; otherwise, runs of the job will fail.</summary>
    [JsonPropertyName("mainClassName")]
    public string? MainClassName { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    [JsonPropertyName("runAsRepl")]
    public bool? RunAsRepl { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskSparkPythonTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }

    /// <summary>The URI of the Python file to be executed. databricks_dbfs_file, cloud file URIs (e.g. s3:/, abfss:/, gs:/), workspace paths and remote repository are supported. For Python files stored in the Databricks workspace, the path must be absolute and begin with /Repos. For files stored in a remote repository, the path must be relative. This field is required.</summary>
    [JsonPropertyName("pythonFile")]
    public string? PythonFile { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskSparkSubmitTask
{
    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IList<string>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskSqlTaskAlertSubscriptions
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>The email of an active workspace user. Non-admin users can only set this field to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>block consisting of following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskSqlTaskAlert
{
    /// <summary>(String) identifier of the Databricks Alert (databricks_alert).</summary>
    [JsonPropertyName("alertId")]
    public string? AlertId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination&apos;s identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1beta1JobStatusAtProviderTaskSqlTaskAlertSubscriptions>? Subscriptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskSqlTaskDashboardSubscriptions
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>The email of an active workspace user. Non-admin users can only set this field to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>block consisting of following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskSqlTaskDashboard
{
    /// <summary>string specifying a custom subject of email sent.</summary>
    [JsonPropertyName("customSubject")]
    public string? CustomSubject { get; set; }

    /// <summary>(String) identifier of the Databricks SQL Dashboard databricks_sql_dashboard.</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>flag that specifies if subscriptions are paused or not.</summary>
    [JsonPropertyName("pauseSubscriptions")]
    public bool? PauseSubscriptions { get; set; }

    /// <summary>a list of subscription blocks consisting out of one of the required fields: user_name for user emails or destination_id - for Alert destination&apos;s identifier.</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1beta1JobStatusAtProviderTaskSqlTaskDashboardSubscriptions>? Subscriptions { get; set; }
}

/// <summary>block consisting of single string fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskSqlTaskFile
{
    /// <summary>If source is GIT: Relative path to the file in the repository specified in the git_source block with SQL commands to execute. If source is WORKSPACE: Absolute path to the file in the workspace with SQL commands to execute.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The source of the project. Possible values are WORKSPACE and GIT.  Defaults to GIT if a git_source block is present in the job definition.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>block consisting of single string field: query_id - identifier of the Databricks Query (databricks_query).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskSqlTaskQuery
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("queryId")]
    public string? QueryId { get; set; }
}

/// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskSqlTask
{
    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("alert")]
    public V1beta1JobStatusAtProviderTaskSqlTaskAlert? Alert { get; set; }

    /// <summary>block consisting of following fields:</summary>
    [JsonPropertyName("dashboard")]
    public V1beta1JobStatusAtProviderTaskSqlTaskDashboard? Dashboard { get; set; }

    /// <summary>block consisting of single string fields:</summary>
    [JsonPropertyName("file")]
    public V1beta1JobStatusAtProviderTaskSqlTaskFile? File { get; set; }

    /// <summary>Parameters for the task</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>block consisting of single string field: query_id - identifier of the Databricks Query (databricks_query).</summary>
    [JsonPropertyName("query")]
    public V1beta1JobStatusAtProviderTaskSqlTaskQuery? Query { get; set; }

    /// <summary>The ID of the SQL warehouse that dbt should execute against.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskWebhookNotificationsOnDurationWarningThresholdExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskWebhookNotificationsOnFailure
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskWebhookNotificationsOnStart
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskWebhookNotificationsOnStreamingBacklogExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskWebhookNotificationsOnSuccess
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTaskWebhookNotifications
{
    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<V1beta1JobStatusAtProviderTaskWebhookNotificationsOnDurationWarningThresholdExceeded>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1beta1JobStatusAtProviderTaskWebhookNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<V1beta1JobStatusAtProviderTaskWebhookNotificationsOnStart>? OnStart { get; set; }

    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<V1beta1JobStatusAtProviderTaskWebhookNotificationsOnStreamingBacklogExceeded>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1beta1JobStatusAtProviderTaskWebhookNotificationsOnSuccess>? OnSuccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTask
{
    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("cleanRoomsNotebookTask")]
    public V1beta1JobStatusAtProviderTaskCleanRoomsNotebookTask? CleanRoomsNotebookTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("conditionTask")]
    public V1beta1JobStatusAtProviderTaskConditionTask? ConditionTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtTask")]
    public V1beta1JobStatusAtProviderTaskDbtTask? DbtTask { get; set; }

    /// <summary>block specifying dependency(-ies) for a given task.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<V1beta1JobStatusAtProviderTaskDependsOn>? DependsOn { get; set; }

    /// <summary>An optional description for the job. The maximum length is 1024 characters in UTF-8 encoding.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A flag to disable auto optimization in serverless tasks.</summary>
    [JsonPropertyName("disableAutoOptimization")]
    public bool? DisableAutoOptimization { get; set; }

    /// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
    [JsonPropertyName("emailNotifications")]
    public V1beta1JobStatusAtProviderTaskEmailNotifications? EmailNotifications { get; set; }

    /// <summary>identifier of an environment block that is used to specify libraries.  Required for some tasks (spark_python_task, python_wheel_task, ...) running on serverless compute.</summary>
    [JsonPropertyName("environmentKey")]
    public string? EnvironmentKey { get; set; }

    /// <summary>If existing_cluster_id, the ID of an existing cluster that will be used for all runs of this job. When running jobs on an existing cluster, you may need to manually restart the cluster if it stops responding. We strongly suggest to use new_cluster for greater reliability.</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("forEachTask")]
    public V1beta1JobStatusAtProviderTaskForEachTask? ForEachTask { get; set; }

    /// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
    [JsonPropertyName("health")]
    public V1beta1JobStatusAtProviderTaskHealth? Health { get; set; }

    /// <summary>Identifier of the Job cluster specified in the job_cluster block.</summary>
    [JsonPropertyName("jobClusterKey")]
    public string? JobClusterKey { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobStatusAtProviderTaskLibrary>? Library { get; set; }

    /// <summary>(Integer) An optional maximum number of times to retry an unsuccessful run. A run is considered to be unsuccessful if it completes with a FAILED or INTERNAL_ERROR lifecycle state. The value -1 means to retry indefinitely and the value 0 means to never retry. The default behavior is to never retry. A run can have the following lifecycle state: PENDING, RUNNING, TERMINATING, TERMINATED, SKIPPED or INTERNAL_ERROR.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>(Integer) An optional minimal interval in milliseconds between the start of the failed run and the subsequent retry run. The default behavior is that unsuccessful runs are immediately retried.</summary>
    [JsonPropertyName("minRetryIntervalMillis")]
    public double? MinRetryIntervalMillis { get; set; }

    /// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
    [JsonPropertyName("newCluster")]
    public V1beta1JobStatusAtProviderTaskNewCluster? NewCluster { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("notebookTask")]
    public V1beta1JobStatusAtProviderTaskNotebookTask? NotebookTask { get; set; }

    /// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
    [JsonPropertyName("notificationSettings")]
    public V1beta1JobStatusAtProviderTaskNotificationSettings? NotificationSettings { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pipelineTask")]
    public V1beta1JobStatusAtProviderTaskPipelineTask? PipelineTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pythonWheelTask")]
    public V1beta1JobStatusAtProviderTaskPythonWheelTask? PythonWheelTask { get; set; }

    /// <summary>(Bool) An optional policy to specify whether to retry a job when it times out. The default behavior is to not retry on timeout.</summary>
    [JsonPropertyName("retryOnTimeout")]
    public bool? RetryOnTimeout { get; set; }

    /// <summary>An optional value indicating the condition that determines whether the task should be run once its dependencies have been completed. One of ALL_SUCCESS, AT_LEAST_ONE_SUCCESS, NONE_FAILED, ALL_DONE, AT_LEAST_ONE_FAILED or ALL_FAILED. When omitted, defaults to ALL_SUCCESS.</summary>
    [JsonPropertyName("runIf")]
    public string? RunIf { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("runJobTask")]
    public V1beta1JobStatusAtProviderTaskRunJobTask? RunJobTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkJarTask")]
    public V1beta1JobStatusAtProviderTaskSparkJarTask? SparkJarTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkPythonTask")]
    public V1beta1JobStatusAtProviderTaskSparkPythonTask? SparkPythonTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkSubmitTask")]
    public V1beta1JobStatusAtProviderTaskSparkSubmitTask? SparkSubmitTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sqlTask")]
    public V1beta1JobStatusAtProviderTaskSqlTask? SqlTask { get; set; }

    /// <summary>string specifying an unique key for a given task.</summary>
    [JsonPropertyName("taskKey")]
    public string? TaskKey { get; set; }

    /// <summary>(Integer) An optional timeout applied to each run of this job. The default behavior is to have no timeout.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
    [JsonPropertyName("webhookNotifications")]
    public V1beta1JobStatusAtProviderTaskWebhookNotifications? WebhookNotifications { get; set; }
}

/// <summary>configuration block to define a trigger for File Arrival events consisting of following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTriggerFileArrival
{
    /// <summary>If set, the trigger starts a run only after the specified amount of time passed since the last time the trigger fired. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("minTimeBetweenTriggersSeconds")]
    public double? MinTimeBetweenTriggersSeconds { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>If set, the trigger starts a run only after no file activity has occurred for the specified amount of time. This makes it possible to wait for a batch of incoming files to arrive before triggering a run. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("waitAfterLastChangeSeconds")]
    public double? WaitAfterLastChangeSeconds { get; set; }
}

/// <summary>configuration block to define a trigger for Periodic Triggers consisting of the following attributes:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTriggerPeriodic
{
    /// <summary>Specifies the interval at which the job should run. This value is required.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>Options are {&quot;DAYS&quot;, &quot;HOURS&quot;, &quot;WEEKS&quot;}.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTriggerTable
{
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>If set, the trigger starts a run only after the specified amount of time passed since the last time the trigger fired. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("minTimeBetweenTriggersSeconds")]
    public double? MinTimeBetweenTriggersSeconds { get; set; }

    [JsonPropertyName("tableNames")]
    public IList<string>? TableNames { get; set; }

    /// <summary>If set, the trigger starts a run only after no file activity has occurred for the specified amount of time. This makes it possible to wait for a batch of incoming files to arrive before triggering a run. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("waitAfterLastChangeSeconds")]
    public double? WaitAfterLastChangeSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTriggerTableUpdate
{
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>If set, the trigger starts a run only after the specified amount of time passed since the last time the trigger fired. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("minTimeBetweenTriggersSeconds")]
    public double? MinTimeBetweenTriggersSeconds { get; set; }

    [JsonPropertyName("tableNames")]
    public IList<string>? TableNames { get; set; }

    /// <summary>If set, the trigger starts a run only after no file activity has occurred for the specified amount of time. This makes it possible to wait for a batch of incoming files to arrive before triggering a run. The minimum allowed value is 60 seconds.</summary>
    [JsonPropertyName("waitAfterLastChangeSeconds")]
    public double? WaitAfterLastChangeSeconds { get; set; }
}

/// <summary>The conditions that triggers the job to start. See trigger Configuration Block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderTrigger
{
    /// <summary>configuration block to define a trigger for File Arrival events consisting of following attributes:</summary>
    [JsonPropertyName("fileArrival")]
    public V1beta1JobStatusAtProviderTriggerFileArrival? FileArrival { get; set; }

    /// <summary>Indicate whether this trigger is paused or not. Either PAUSED or UNPAUSED. When the pause_status field is omitted in the block, the server will default to using UNPAUSED as a value for pause_status.</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }

    /// <summary>configuration block to define a trigger for Periodic Triggers consisting of the following attributes:</summary>
    [JsonPropertyName("periodic")]
    public V1beta1JobStatusAtProviderTriggerPeriodic? Periodic { get; set; }

    [JsonPropertyName("table")]
    public V1beta1JobStatusAtProviderTriggerTable? Table { get; set; }

    [JsonPropertyName("tableUpdate")]
    public V1beta1JobStatusAtProviderTriggerTableUpdate? TableUpdate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderWebhookNotificationsOnDurationWarningThresholdExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderWebhookNotificationsOnFailure
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderWebhookNotificationsOnStart
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderWebhookNotificationsOnStreamingBacklogExceeded
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderWebhookNotificationsOnSuccess
{
    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderWebhookNotifications
{
    /// <summary>(List) list of notification IDs to call when the duration of a run exceeds the threshold specified by the RUN_DURATION_SECONDS metric in the health block.</summary>
    [JsonPropertyName("onDurationWarningThresholdExceeded")]
    public IList<V1beta1JobStatusAtProviderWebhookNotificationsOnDurationWarningThresholdExceeded>? OnDurationWarningThresholdExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run fails. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onFailure")]
    public IList<V1beta1JobStatusAtProviderWebhookNotificationsOnFailure>? OnFailure { get; set; }

    /// <summary>(List) list of notification IDs to call when the run starts. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onStart")]
    public IList<V1beta1JobStatusAtProviderWebhookNotificationsOnStart>? OnStart { get; set; }

    [JsonPropertyName("onStreamingBacklogExceeded")]
    public IList<V1beta1JobStatusAtProviderWebhookNotificationsOnStreamingBacklogExceeded>? OnStreamingBacklogExceeded { get; set; }

    /// <summary>(List) list of notification IDs to call when the run completes successfully. A maximum of 3 destinations can be specified.</summary>
    [JsonPropertyName("onSuccess")]
    public IList<V1beta1JobStatusAtProviderWebhookNotificationsOnSuccess>? OnSuccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProvider
{
    /// <summary>(Bool) Whenever the job is always running, like a Spark Streaming application, on every update restart the current active run or start it again, if nothing it is not running. False by default. Any job runs are started with parameters specified in spark_jar_task or spark_submit_task or spark_python_task or notebook_task blocks.</summary>
    [JsonPropertyName("alwaysRunning")]
    public bool? AlwaysRunning { get; set; }

    /// <summary>The ID of the user-specified budget policy to use for this job. If not specified, a default budget policy may be applied when creating or modifying the job.</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>Configuration block to configure pause status. See continuous Configuration Block.</summary>
    [JsonPropertyName("continuous")]
    public V1beta1JobStatusAtProviderContinuous? Continuous { get; set; }

    /// <summary>(Bool) If true, the Databricks provider will stop and start the job as needed to ensure that the active run for the job reflects the deployed configuration. For continuous jobs, the provider respects the pause_status by stopping the current active run. This flag cannot be set for non-continuous jobs.</summary>
    [JsonPropertyName("controlRunState")]
    public bool? ControlRunState { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("dbtTask")]
    public V1beta1JobStatusAtProviderDbtTask? DbtTask { get; set; }

    [JsonPropertyName("deployment")]
    public V1beta1JobStatusAtProviderDeployment? Deployment { get; set; }

    /// <summary>An optional description for the job. The maximum length is 1024 characters in UTF-8 encoding.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If &quot;UI_LOCKED&quot;, the user interface for the job will be locked. If &quot;EDITABLE&quot; (the default), the user interface will be editable.</summary>
    [JsonPropertyName("editMode")]
    public string? EditMode { get; set; }

    /// <summary>(List) An optional set of email addresses notified when runs of this job begins, completes or fails. The default behavior is to not send any emails. This field is a block and is documented below.</summary>
    [JsonPropertyName("emailNotifications")]
    public V1beta1JobStatusAtProviderEmailNotifications? EmailNotifications { get; set; }

    [JsonPropertyName("environment")]
    public IList<V1beta1JobStatusAtProviderEnvironment>? Environment { get; set; }

    /// <summary>Identifier of the interactive cluster to run job on.  Note: running tasks on interactive clusters may lead to increased costs!</summary>
    [JsonPropertyName("existingClusterId")]
    public string? ExistingClusterId { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Specifices the a Git repository for task source code. See git_source Configuration Block below.</summary>
    [JsonPropertyName("gitSource")]
    public V1beta1JobStatusAtProviderGitSource? GitSource { get; set; }

    /// <summary>An optional block that specifies the health conditions for the job documented below.</summary>
    [JsonPropertyName("health")]
    public V1beta1JobStatusAtProviderHealth? Health { get; set; }

    /// <summary>ID of the system notification that is notified when an event defined in webhook_notifications is triggered.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of job databricks_cluster specifications that can be shared and reused by tasks of this job. Libraries cannot be declared in a shared job cluster. You must declare dependent libraries in task settings. Multi-task syntax</summary>
    [JsonPropertyName("jobCluster")]
    public IList<V1beta1JobStatusAtProviderJobCluster>? JobCluster { get; set; }

    /// <summary>(List) An optional list of libraries to be installed on the cluster that will execute the job. See library Configuration Block below.</summary>
    [JsonPropertyName("library")]
    public IList<V1beta1JobStatusAtProviderLibrary>? Library { get; set; }

    /// <summary>(Integer) An optional maximum allowed number of concurrent runs of the job. Defaults to 1.</summary>
    [JsonPropertyName("maxConcurrentRuns")]
    public double? MaxConcurrentRuns { get; set; }

    /// <summary>(Integer) An optional maximum number of times to retry an unsuccessful run. A run is considered to be unsuccessful if it completes with a FAILED or INTERNAL_ERROR lifecycle state. The value -1 means to retry indefinitely and the value 0 means to never retry. The default behavior is to never retry. A run can have the following lifecycle state: PENDING, RUNNING, TERMINATING, TERMINATED, SKIPPED or INTERNAL_ERROR.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>(Integer) An optional minimal interval in milliseconds between the start of the failed run and the subsequent retry run. The default behavior is that unsuccessful runs are immediately retried.</summary>
    [JsonPropertyName("minRetryIntervalMillis")]
    public double? MinRetryIntervalMillis { get; set; }

    /// <summary>An optional name for the job. The default value is Untitled.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Task will run on a dedicated cluster.  See databricks_cluster documentation for specification. Some parameters, such as</summary>
    [JsonPropertyName("newCluster")]
    public V1beta1JobStatusAtProviderNewCluster? NewCluster { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("notebookTask")]
    public V1beta1JobStatusAtProviderNotebookTask? NotebookTask { get; set; }

    /// <summary>An optional block controlling the notification settings on the job level documented below.</summary>
    [JsonPropertyName("notificationSettings")]
    public V1beta1JobStatusAtProviderNotificationSettings? NotificationSettings { get; set; }

    /// <summary>Specifices job parameter for the job. See parameter Configuration Block</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta1JobStatusAtProviderParameter>? Parameter { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pipelineTask")]
    public V1beta1JobStatusAtProviderPipelineTask? PipelineTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("pythonWheelTask")]
    public V1beta1JobStatusAtProviderPythonWheelTask? PythonWheelTask { get; set; }

    /// <summary>The queue status for the job. See queue Configuration Block below.</summary>
    [JsonPropertyName("queue")]
    public V1beta1JobStatusAtProviderQueue? Queue { get; set; }

    /// <summary>(Bool) An optional policy to specify whether to retry a job when it times out. The default behavior is to not retry on timeout.</summary>
    [JsonPropertyName("retryOnTimeout")]
    public bool? RetryOnTimeout { get; set; }

    /// <summary>The user or the service prinicipal the job runs as. See run_as Configuration Block below.</summary>
    [JsonPropertyName("runAs")]
    public V1beta1JobStatusAtProviderRunAs? RunAs { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("runJobTask")]
    public V1beta1JobStatusAtProviderRunJobTask? RunJobTask { get; set; }

    /// <summary>An optional periodic schedule for this job. The default behavior is that the job runs when triggered by clicking Run Now in the Jobs UI or sending an API request to runNow. See schedule Configuration Block below.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1JobStatusAtProviderSchedule? Schedule { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkJarTask")]
    public V1beta1JobStatusAtProviderSparkJarTask? SparkJarTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkPythonTask")]
    public V1beta1JobStatusAtProviderSparkPythonTask? SparkPythonTask { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("sparkSubmitTask")]
    public V1beta1JobStatusAtProviderSparkSubmitTask? SparkSubmitTask { get; set; }

    /// <summary>An optional map of the tags associated with the job. See tags Configuration Map</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A list of task specification that the job will execute. See task Configuration Block below.</summary>
    [JsonPropertyName("task")]
    public IList<V1beta1JobStatusAtProviderTask>? Task { get; set; }

    /// <summary>(Integer) An optional timeout applied to each run of this job. The default behavior is to have no timeout.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>The conditions that triggers the job to start. See trigger Configuration Block below.</summary>
    [JsonPropertyName("trigger")]
    public V1beta1JobStatusAtProviderTrigger? Trigger { get; set; }

    /// <summary>URL to be monitored for file arrivals. The path must point to the root or a subpath of the external location. Please note that the URL must have a trailing slash character (/).</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>(List) An optional set of system destinations (for example, webhook destinations or Slack) to be notified when runs of this job begins, completes or fails. The default behavior is to not send any notifications. This field is a block and is documented below.</summary>
    [JsonPropertyName("webhookNotifications")]
    public V1beta1JobStatusAtProviderWebhookNotifications? WebhookNotifications { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusConditions
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

/// <summary>JobStatus defines the observed state of Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1JobStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1JobStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Job is the Schema for the Jobs API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Job : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1JobSpec>, IStatus<V1beta1JobStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Job";
    public const string KubeGroup = "compute.databricks.m.upbound.io";
    public const string KubePluralName = "jobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.databricks.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Job";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>JobSpec defines the desired state of Job</summary>
    [JsonPropertyName("spec")]
    public required V1beta1JobSpec Spec { get; set; }

    /// <summary>JobStatus defines the observed state of Job.</summary>
    [JsonPropertyName("status")]
    public V1beta1JobStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataproc.gcp.upbound.io;
/// <summary>Job is the Schema for the Jobs API. Manages a job resource within a Dataproc cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2JobList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Job>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "JobList";
    public const string KubeGroup = "dataproc.gcp.upbound.io";
    public const string KubePluralName = "jobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataproc.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "JobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Job objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Job> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecDeletionPolicyEnum>))]
public enum V1beta2JobSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderHadoopConfigLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &apos;root&apos; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderHadoopConfig
{
    /// <summary>HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as -libjars or -Dfoo=bar, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be copied to the working directory of Hadoop drivers and distributed tasks. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to add to the CLASSPATHs of the Spark driver and tasks.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    [JsonPropertyName("loggingConfig")]
    public V1beta2JobSpecForProviderHadoopConfigLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The name of the driver&apos;s main class. The jar file containing the class must be in the default CLASSPATH or specified in jar_file_uris. Conflicts with main_jar_file_uri</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The HCFS URI of the jar file containing the main class. Examples: &apos;gs://foo-bucket/analytics-binaries/extract-useful-metrics-mr.jar&apos; &apos;hdfs:/tmp/test-samples/custom-wordcount.jar&apos; &apos;file:///home/usr/lib/hadoop-mapreduce/hadoop-mapreduce-examples.jar&apos;. Conflicts with main_class</summary>
    [JsonPropertyName("mainJarFileUri")]
    public string? MainJarFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Hadoop. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site and classes in user code..</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderHiveConfig
{
    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries. Defaults to false.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>HCFS URIs of jar files to add to the CLASSPATH of the Hive server and Hadoop MapReduce (MR) tasks. Can contain Hive SerDes and UDFs.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>A mapping of property names and values, used to configure Hive. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site.xml, /etc/hive/conf/hive-site.xml, and classes in user code..</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>
    /// HCFS URI of file containing Hive script to execute as the job.
    /// Conflicts with query_list
    /// </summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>
    /// The list of Hive queries or statements to execute as part of the job.
    /// Conflicts with query_file_uri
    /// </summary>
    [JsonPropertyName("queryList")]
    public IList<string>? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Hive command: SET name=&quot;value&quot;;).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderPigConfigLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &apos;root&apos; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderPigConfig
{
    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries. Defaults to false.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>HCFS URIs of jar files to add to the CLASSPATH of the Pig Client and Hadoop MapReduce (MR) tasks. Can contain Pig UDFs.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    [JsonPropertyName("loggingConfig")]
    public V1beta2JobSpecForProviderPigConfigLoggingConfig? LoggingConfig { get; set; }

    /// <summary>A mapping of property names to values, used to configure Pig. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site.xml, /etc/pig/conf/pig.properties, and classes in user code.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>
    /// HCFS URI of file containing Hive script to execute as the job.
    /// Conflicts with query_list
    /// </summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>
    /// The list of Hive queries or statements to execute as part of the job.
    /// Conflicts with query_file_uri
    /// </summary>
    [JsonPropertyName("queryList")]
    public IList<string>? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Pig command: name=[value]).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderPlacementClusterNameRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderPlacementClusterNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderPlacementClusterNameRefPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderPlacementClusterNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderPlacementClusterNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderPlacementClusterNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderPlacementClusterNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in dataproc to populate clusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderPlacementClusterNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecForProviderPlacementClusterNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderPlacementClusterNameSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderPlacementClusterNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderPlacementClusterNameSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderPlacementClusterNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderPlacementClusterNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderPlacementClusterNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderPlacementClusterNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in dataproc to populate clusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderPlacementClusterNameSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecForProviderPlacementClusterNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderPlacement
{
    /// <summary>
    /// The name of the cluster where the job
    /// will be submitted.
    /// </summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Reference to a Cluster in dataproc to populate clusterName.</summary>
    [JsonPropertyName("clusterNameRef")]
    public V1beta2JobSpecForProviderPlacementClusterNameRef? ClusterNameRef { get; set; }

    /// <summary>Selector for a Cluster in dataproc to populate clusterName.</summary>
    [JsonPropertyName("clusterNameSelector")]
    public V1beta2JobSpecForProviderPlacementClusterNameSelector? ClusterNameSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderPrestoConfigLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &apos;root&apos; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderPrestoConfig
{
    /// <summary>Presto client tags to attach to this query.</summary>
    [JsonPropertyName("clientTags")]
    public IList<string>? ClientTags { get; set; }

    /// <summary>Whether to continue executing queries if a query fails. Setting to true can be useful when executing independent parallel queries. Defaults to false.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    [JsonPropertyName("loggingConfig")]
    public V1beta2JobSpecForProviderPrestoConfigLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The format in which query output will be displayed. See the Presto documentation for supported output formats.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>A mapping of property names to values. Used to set Presto session properties Equivalent to using the --session flag in the Presto CLI.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries.
    /// Conflicts with query_list
    /// </summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>
    /// The list of SQL queries or statements to execute as part of the job.
    /// Conflicts with query_file_uri
    /// </summary>
    [JsonPropertyName("queryList")]
    public IList<string>? QueryList { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderPysparkConfigLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &apos;root&apos; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderPysparkConfig
{
    /// <summary>HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be copied to the working directory of Python drivers and distributed tasks. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to add to the CLASSPATHs of the Python driver and tasks.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    [JsonPropertyName("loggingConfig")]
    public V1beta2JobSpecForProviderPysparkConfigLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The HCFS URI of the main Python file to use as the driver. Must be a .py file.</summary>
    [JsonPropertyName("mainPythonFileUri")]
    public string? MainPythonFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure PySpark. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip.</summary>
    [JsonPropertyName("pythonFileUris")]
    public IList<string>? PythonFileUris { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderReference
{
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderRegionRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderRegionRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderRegionRefPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderRegionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderRegionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderRegionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderRegionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in dataproc to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderRegionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecForProviderRegionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderRegionSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecForProviderRegionSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecForProviderRegionSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecForProviderRegionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderRegionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecForProviderRegionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecForProviderRegionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in dataproc to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderRegionSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecForProviderRegionSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderScheduling
{
    /// <summary>Maximum number of times per hour a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed.</summary>
    [JsonPropertyName("maxFailuresPerHour")]
    public double? MaxFailuresPerHour { get; set; }

    /// <summary>Maximum number of times in total a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed.</summary>
    [JsonPropertyName("maxFailuresTotal")]
    public double? MaxFailuresTotal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderSparkConfigLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &apos;root&apos; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderSparkConfig
{
    /// <summary>HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be copied to the working directory of Spark drivers and distributed tasks. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to add to the CLASSPATHs of the Spark driver and tasks.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    [JsonPropertyName("loggingConfig")]
    public V1beta2JobSpecForProviderSparkConfigLoggingConfig? LoggingConfig { get; set; }

    /// <summary>
    /// The class containing the main method of the driver. Must be in a
    /// provided jar or jar that is already on the classpath. Conflicts with main_jar_file_uri
    /// </summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>
    /// The HCFS URI of jar file containing
    /// the driver jar. Conflicts with main_class
    /// </summary>
    [JsonPropertyName("mainJarFileUri")]
    public string? MainJarFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderSparksqlConfigLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &apos;root&apos; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProviderSparksqlConfig
{
    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    [JsonPropertyName("loggingConfig")]
    public V1beta2JobSpecForProviderSparksqlConfigLoggingConfig? LoggingConfig { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Cloud Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries.
    /// Conflicts with query_list
    /// </summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>
    /// The list of SQL queries or statements to execute as part of the job.
    /// Conflicts with query_file_uri
    /// </summary>
    [JsonPropertyName("queryList")]
    public IList<string>? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&quot;value&quot;;).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecForProvider
{
    /// <summary>
    /// By default, you can only delete inactive jobs within
    /// Dataproc. Setting this to true, and calling destroy, will ensure that the
    /// job is first cancelled before issuing the delete.
    /// </summary>
    [JsonPropertyName("forceDelete")]
    public bool? ForceDelete { get; set; }

    [JsonPropertyName("hadoopConfig")]
    public V1beta2JobSpecForProviderHadoopConfig? HadoopConfig { get; set; }

    [JsonPropertyName("hiveConfig")]
    public V1beta2JobSpecForProviderHiveConfig? HiveConfig { get; set; }

    /// <summary>
    /// The list of labels (key/value pairs) to add to the job.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &apos;effective_labels&apos; for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    [JsonPropertyName("pigConfig")]
    public V1beta2JobSpecForProviderPigConfig? PigConfig { get; set; }

    [JsonPropertyName("placement")]
    public V1beta2JobSpecForProviderPlacement? Placement { get; set; }

    [JsonPropertyName("prestoConfig")]
    public V1beta2JobSpecForProviderPrestoConfig? PrestoConfig { get; set; }

    /// <summary>
    /// The project in which the cluster can be found and jobs
    /// subsequently run against. If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    [JsonPropertyName("pysparkConfig")]
    public V1beta2JobSpecForProviderPysparkConfig? PysparkConfig { get; set; }

    [JsonPropertyName("reference")]
    public V1beta2JobSpecForProviderReference? Reference { get; set; }

    /// <summary>
    /// The Cloud Dataproc region. This essentially determines which clusters are available
    /// for this job to be submitted to. If not specified, defaults to global.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Reference to a Cluster in dataproc to populate region.</summary>
    [JsonPropertyName("regionRef")]
    public V1beta2JobSpecForProviderRegionRef? RegionRef { get; set; }

    /// <summary>Selector for a Cluster in dataproc to populate region.</summary>
    [JsonPropertyName("regionSelector")]
    public V1beta2JobSpecForProviderRegionSelector? RegionSelector { get; set; }

    [JsonPropertyName("scheduling")]
    public V1beta2JobSpecForProviderScheduling? Scheduling { get; set; }

    [JsonPropertyName("sparkConfig")]
    public V1beta2JobSpecForProviderSparkConfig? SparkConfig { get; set; }

    [JsonPropertyName("sparksqlConfig")]
    public V1beta2JobSpecForProviderSparksqlConfig? SparksqlConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderHadoopConfigLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &apos;root&apos; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderHadoopConfig
{
    /// <summary>HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as -libjars or -Dfoo=bar, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be copied to the working directory of Hadoop drivers and distributed tasks. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to add to the CLASSPATHs of the Spark driver and tasks.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    [JsonPropertyName("loggingConfig")]
    public V1beta2JobSpecInitProviderHadoopConfigLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The name of the driver&apos;s main class. The jar file containing the class must be in the default CLASSPATH or specified in jar_file_uris. Conflicts with main_jar_file_uri</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The HCFS URI of the jar file containing the main class. Examples: &apos;gs://foo-bucket/analytics-binaries/extract-useful-metrics-mr.jar&apos; &apos;hdfs:/tmp/test-samples/custom-wordcount.jar&apos; &apos;file:///home/usr/lib/hadoop-mapreduce/hadoop-mapreduce-examples.jar&apos;. Conflicts with main_class</summary>
    [JsonPropertyName("mainJarFileUri")]
    public string? MainJarFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Hadoop. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site and classes in user code..</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderHiveConfig
{
    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries. Defaults to false.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>HCFS URIs of jar files to add to the CLASSPATH of the Hive server and Hadoop MapReduce (MR) tasks. Can contain Hive SerDes and UDFs.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>A mapping of property names and values, used to configure Hive. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site.xml, /etc/hive/conf/hive-site.xml, and classes in user code..</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>
    /// HCFS URI of file containing Hive script to execute as the job.
    /// Conflicts with query_list
    /// </summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>
    /// The list of Hive queries or statements to execute as part of the job.
    /// Conflicts with query_file_uri
    /// </summary>
    [JsonPropertyName("queryList")]
    public IList<string>? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Hive command: SET name=&quot;value&quot;;).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderPigConfigLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &apos;root&apos; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderPigConfig
{
    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries. Defaults to false.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>HCFS URIs of jar files to add to the CLASSPATH of the Pig Client and Hadoop MapReduce (MR) tasks. Can contain Pig UDFs.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    [JsonPropertyName("loggingConfig")]
    public V1beta2JobSpecInitProviderPigConfigLoggingConfig? LoggingConfig { get; set; }

    /// <summary>A mapping of property names to values, used to configure Pig. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site.xml, /etc/pig/conf/pig.properties, and classes in user code.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>
    /// HCFS URI of file containing Hive script to execute as the job.
    /// Conflicts with query_list
    /// </summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>
    /// The list of Hive queries or statements to execute as part of the job.
    /// Conflicts with query_file_uri
    /// </summary>
    [JsonPropertyName("queryList")]
    public IList<string>? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Pig command: name=[value]).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderPlacementClusterNameRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderPlacementClusterNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderPlacementClusterNameRefPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderPlacementClusterNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderPlacementClusterNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderPlacementClusterNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderPlacementClusterNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in dataproc to populate clusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderPlacementClusterNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecInitProviderPlacementClusterNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderPlacementClusterNameSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderPlacementClusterNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderPlacementClusterNameSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderPlacementClusterNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderPlacementClusterNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderPlacementClusterNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderPlacementClusterNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in dataproc to populate clusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderPlacementClusterNameSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecInitProviderPlacementClusterNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderPlacement
{
    /// <summary>
    /// The name of the cluster where the job
    /// will be submitted.
    /// </summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Reference to a Cluster in dataproc to populate clusterName.</summary>
    [JsonPropertyName("clusterNameRef")]
    public V1beta2JobSpecInitProviderPlacementClusterNameRef? ClusterNameRef { get; set; }

    /// <summary>Selector for a Cluster in dataproc to populate clusterName.</summary>
    [JsonPropertyName("clusterNameSelector")]
    public V1beta2JobSpecInitProviderPlacementClusterNameSelector? ClusterNameSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderPrestoConfigLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &apos;root&apos; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderPrestoConfig
{
    /// <summary>Presto client tags to attach to this query.</summary>
    [JsonPropertyName("clientTags")]
    public IList<string>? ClientTags { get; set; }

    /// <summary>Whether to continue executing queries if a query fails. Setting to true can be useful when executing independent parallel queries. Defaults to false.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    [JsonPropertyName("loggingConfig")]
    public V1beta2JobSpecInitProviderPrestoConfigLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The format in which query output will be displayed. See the Presto documentation for supported output formats.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>A mapping of property names to values. Used to set Presto session properties Equivalent to using the --session flag in the Presto CLI.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries.
    /// Conflicts with query_list
    /// </summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>
    /// The list of SQL queries or statements to execute as part of the job.
    /// Conflicts with query_file_uri
    /// </summary>
    [JsonPropertyName("queryList")]
    public IList<string>? QueryList { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderPysparkConfigLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &apos;root&apos; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderPysparkConfig
{
    /// <summary>HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be copied to the working directory of Python drivers and distributed tasks. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to add to the CLASSPATHs of the Python driver and tasks.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    [JsonPropertyName("loggingConfig")]
    public V1beta2JobSpecInitProviderPysparkConfigLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The HCFS URI of the main Python file to use as the driver. Must be a .py file.</summary>
    [JsonPropertyName("mainPythonFileUri")]
    public string? MainPythonFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure PySpark. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip.</summary>
    [JsonPropertyName("pythonFileUris")]
    public IList<string>? PythonFileUris { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderReference
{
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderRegionRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderRegionRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderRegionRefPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderRegionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderRegionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderRegionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderRegionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in dataproc to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderRegionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecInitProviderRegionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderRegionSelectorPolicyResolutionEnum>))]
public enum V1beta2JobSpecInitProviderRegionSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecInitProviderRegionSelectorPolicyResolveEnum>))]
public enum V1beta2JobSpecInitProviderRegionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderRegionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecInitProviderRegionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecInitProviderRegionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in dataproc to populate region.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderRegionSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecInitProviderRegionSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderScheduling
{
    /// <summary>Maximum number of times per hour a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed.</summary>
    [JsonPropertyName("maxFailuresPerHour")]
    public double? MaxFailuresPerHour { get; set; }

    /// <summary>Maximum number of times in total a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed.</summary>
    [JsonPropertyName("maxFailuresTotal")]
    public double? MaxFailuresTotal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderSparkConfigLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &apos;root&apos; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderSparkConfig
{
    /// <summary>HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be copied to the working directory of Spark drivers and distributed tasks. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to add to the CLASSPATHs of the Spark driver and tasks.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    [JsonPropertyName("loggingConfig")]
    public V1beta2JobSpecInitProviderSparkConfigLoggingConfig? LoggingConfig { get; set; }

    /// <summary>
    /// The class containing the main method of the driver. Must be in a
    /// provided jar or jar that is already on the classpath. Conflicts with main_jar_file_uri
    /// </summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>
    /// The HCFS URI of jar file containing
    /// the driver jar. Conflicts with main_class
    /// </summary>
    [JsonPropertyName("mainJarFileUri")]
    public string? MainJarFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderSparksqlConfigLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &apos;root&apos; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecInitProviderSparksqlConfig
{
    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    [JsonPropertyName("loggingConfig")]
    public V1beta2JobSpecInitProviderSparksqlConfigLoggingConfig? LoggingConfig { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Cloud Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries.
    /// Conflicts with query_list
    /// </summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>
    /// The list of SQL queries or statements to execute as part of the job.
    /// Conflicts with query_file_uri
    /// </summary>
    [JsonPropertyName("queryList")]
    public IList<string>? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&quot;value&quot;;).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
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
public partial class V1beta2JobSpecInitProvider
{
    /// <summary>
    /// By default, you can only delete inactive jobs within
    /// Dataproc. Setting this to true, and calling destroy, will ensure that the
    /// job is first cancelled before issuing the delete.
    /// </summary>
    [JsonPropertyName("forceDelete")]
    public bool? ForceDelete { get; set; }

    [JsonPropertyName("hadoopConfig")]
    public V1beta2JobSpecInitProviderHadoopConfig? HadoopConfig { get; set; }

    [JsonPropertyName("hiveConfig")]
    public V1beta2JobSpecInitProviderHiveConfig? HiveConfig { get; set; }

    /// <summary>
    /// The list of labels (key/value pairs) to add to the job.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &apos;effective_labels&apos; for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    [JsonPropertyName("pigConfig")]
    public V1beta2JobSpecInitProviderPigConfig? PigConfig { get; set; }

    [JsonPropertyName("placement")]
    public V1beta2JobSpecInitProviderPlacement? Placement { get; set; }

    [JsonPropertyName("prestoConfig")]
    public V1beta2JobSpecInitProviderPrestoConfig? PrestoConfig { get; set; }

    /// <summary>
    /// The project in which the cluster can be found and jobs
    /// subsequently run against. If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    [JsonPropertyName("pysparkConfig")]
    public V1beta2JobSpecInitProviderPysparkConfig? PysparkConfig { get; set; }

    [JsonPropertyName("reference")]
    public V1beta2JobSpecInitProviderReference? Reference { get; set; }

    /// <summary>
    /// The Cloud Dataproc region. This essentially determines which clusters are available
    /// for this job to be submitted to. If not specified, defaults to global.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Reference to a Cluster in dataproc to populate region.</summary>
    [JsonPropertyName("regionRef")]
    public V1beta2JobSpecInitProviderRegionRef? RegionRef { get; set; }

    /// <summary>Selector for a Cluster in dataproc to populate region.</summary>
    [JsonPropertyName("regionSelector")]
    public V1beta2JobSpecInitProviderRegionSelector? RegionSelector { get; set; }

    [JsonPropertyName("scheduling")]
    public V1beta2JobSpecInitProviderScheduling? Scheduling { get; set; }

    [JsonPropertyName("sparkConfig")]
    public V1beta2JobSpecInitProviderSparkConfig? SparkConfig { get; set; }

    [JsonPropertyName("sparksqlConfig")]
    public V1beta2JobSpecInitProviderSparksqlConfig? SparksqlConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecManagementPoliciesEnum>))]
public enum V1beta2JobSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2JobSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2JobSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>JobSpec defines the desired state of Job</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobSpec
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
    public V1beta2JobSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2JobSpecForProvider ForProvider { get; set; }

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
    public V1beta2JobSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2JobSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2JobSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2JobSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderHadoopConfigLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &apos;root&apos; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderHadoopConfig
{
    /// <summary>HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as -libjars or -Dfoo=bar, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be copied to the working directory of Hadoop drivers and distributed tasks. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to add to the CLASSPATHs of the Spark driver and tasks.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    [JsonPropertyName("loggingConfig")]
    public V1beta2JobStatusAtProviderHadoopConfigLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The name of the driver&apos;s main class. The jar file containing the class must be in the default CLASSPATH or specified in jar_file_uris. Conflicts with main_jar_file_uri</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The HCFS URI of the jar file containing the main class. Examples: &apos;gs://foo-bucket/analytics-binaries/extract-useful-metrics-mr.jar&apos; &apos;hdfs:/tmp/test-samples/custom-wordcount.jar&apos; &apos;file:///home/usr/lib/hadoop-mapreduce/hadoop-mapreduce-examples.jar&apos;. Conflicts with main_class</summary>
    [JsonPropertyName("mainJarFileUri")]
    public string? MainJarFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Hadoop. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site and classes in user code..</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderHiveConfig
{
    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries. Defaults to false.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>HCFS URIs of jar files to add to the CLASSPATH of the Hive server and Hadoop MapReduce (MR) tasks. Can contain Hive SerDes and UDFs.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>A mapping of property names and values, used to configure Hive. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site.xml, /etc/hive/conf/hive-site.xml, and classes in user code..</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>
    /// HCFS URI of file containing Hive script to execute as the job.
    /// Conflicts with query_list
    /// </summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>
    /// The list of Hive queries or statements to execute as part of the job.
    /// Conflicts with query_file_uri
    /// </summary>
    [JsonPropertyName("queryList")]
    public IList<string>? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Hive command: SET name=&quot;value&quot;;).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderPigConfigLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &apos;root&apos; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderPigConfig
{
    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries. Defaults to false.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>HCFS URIs of jar files to add to the CLASSPATH of the Pig Client and Hadoop MapReduce (MR) tasks. Can contain Pig UDFs.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    [JsonPropertyName("loggingConfig")]
    public V1beta2JobStatusAtProviderPigConfigLoggingConfig? LoggingConfig { get; set; }

    /// <summary>A mapping of property names to values, used to configure Pig. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site.xml, /etc/pig/conf/pig.properties, and classes in user code.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>
    /// HCFS URI of file containing Hive script to execute as the job.
    /// Conflicts with query_list
    /// </summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>
    /// The list of Hive queries or statements to execute as part of the job.
    /// Conflicts with query_file_uri
    /// </summary>
    [JsonPropertyName("queryList")]
    public IList<string>? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Pig command: name=[value]).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderPlacement
{
    /// <summary>
    /// The name of the cluster where the job
    /// will be submitted.
    /// </summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>A cluster UUID generated by the Cloud Dataproc service when the job is submitted.</summary>
    [JsonPropertyName("clusterUuid")]
    public string? ClusterUuid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderPrestoConfigLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &apos;root&apos; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderPrestoConfig
{
    /// <summary>Presto client tags to attach to this query.</summary>
    [JsonPropertyName("clientTags")]
    public IList<string>? ClientTags { get; set; }

    /// <summary>Whether to continue executing queries if a query fails. Setting to true can be useful when executing independent parallel queries. Defaults to false.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    [JsonPropertyName("loggingConfig")]
    public V1beta2JobStatusAtProviderPrestoConfigLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The format in which query output will be displayed. See the Presto documentation for supported output formats.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>A mapping of property names to values. Used to set Presto session properties Equivalent to using the --session flag in the Presto CLI.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries.
    /// Conflicts with query_list
    /// </summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>
    /// The list of SQL queries or statements to execute as part of the job.
    /// Conflicts with query_file_uri
    /// </summary>
    [JsonPropertyName("queryList")]
    public IList<string>? QueryList { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderPysparkConfigLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &apos;root&apos; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderPysparkConfig
{
    /// <summary>HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be copied to the working directory of Python drivers and distributed tasks. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to add to the CLASSPATHs of the Python driver and tasks.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    [JsonPropertyName("loggingConfig")]
    public V1beta2JobStatusAtProviderPysparkConfigLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The HCFS URI of the main Python file to use as the driver. Must be a .py file.</summary>
    [JsonPropertyName("mainPythonFileUri")]
    public string? MainPythonFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure PySpark. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip.</summary>
    [JsonPropertyName("pythonFileUris")]
    public IList<string>? PythonFileUris { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderReference
{
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderScheduling
{
    /// <summary>Maximum number of times per hour a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed.</summary>
    [JsonPropertyName("maxFailuresPerHour")]
    public double? MaxFailuresPerHour { get; set; }

    /// <summary>Maximum number of times in total a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed.</summary>
    [JsonPropertyName("maxFailuresTotal")]
    public double? MaxFailuresTotal { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderSparkConfigLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &apos;root&apos; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderSparkConfig
{
    /// <summary>HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be copied to the working directory of Spark drivers and distributed tasks. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to add to the CLASSPATHs of the Spark driver and tasks.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    [JsonPropertyName("loggingConfig")]
    public V1beta2JobStatusAtProviderSparkConfigLoggingConfig? LoggingConfig { get; set; }

    /// <summary>
    /// The class containing the main method of the driver. Must be in a
    /// provided jar or jar that is already on the classpath. Conflicts with main_jar_file_uri
    /// </summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>
    /// The HCFS URI of jar file containing
    /// the driver jar. Conflicts with main_class
    /// </summary>
    [JsonPropertyName("mainJarFileUri")]
    public string? MainJarFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderSparksqlConfigLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &apos;root&apos; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderSparksqlConfig
{
    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    [JsonPropertyName("loggingConfig")]
    public V1beta2JobStatusAtProviderSparksqlConfigLoggingConfig? LoggingConfig { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Cloud Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries.
    /// Conflicts with query_list
    /// </summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>
    /// The list of SQL queries or statements to execute as part of the job.
    /// Conflicts with query_file_uri
    /// </summary>
    [JsonPropertyName("queryList")]
    public IList<string>? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&quot;value&quot;;).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProviderStatus
{
    /// <summary>Optional job state details, such as an error description if the state is ERROR.</summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary>A state message specifying the overall job state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The time when this state was entered.</summary>
    [JsonPropertyName("stateStartTime")]
    public string? StateStartTime { get; set; }

    /// <summary>Additional state information, which includes status reported by the agent.</summary>
    [JsonPropertyName("substate")]
    public string? Substate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusAtProvider
{
    /// <summary>If present, the location of miscellaneous control files which may be used as part of job setup and handling. If not present, control files may be placed in the same location as driver_output_uri.</summary>
    [JsonPropertyName("driverControlsFilesUri")]
    public string? DriverControlsFilesUri { get; set; }

    /// <summary>A URI pointing to the location of the stdout of the job&apos;s driver program.</summary>
    [JsonPropertyName("driverOutputResourceUri")]
    public string? DriverOutputResourceUri { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>
    /// By default, you can only delete inactive jobs within
    /// Dataproc. Setting this to true, and calling destroy, will ensure that the
    /// job is first cancelled before issuing the delete.
    /// </summary>
    [JsonPropertyName("forceDelete")]
    public bool? ForceDelete { get; set; }

    [JsonPropertyName("hadoopConfig")]
    public V1beta2JobStatusAtProviderHadoopConfig? HadoopConfig { get; set; }

    [JsonPropertyName("hiveConfig")]
    public V1beta2JobStatusAtProviderHiveConfig? HiveConfig { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The list of labels (key/value pairs) to add to the job.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &apos;effective_labels&apos; for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    [JsonPropertyName("pigConfig")]
    public V1beta2JobStatusAtProviderPigConfig? PigConfig { get; set; }

    [JsonPropertyName("placement")]
    public V1beta2JobStatusAtProviderPlacement? Placement { get; set; }

    [JsonPropertyName("prestoConfig")]
    public V1beta2JobStatusAtProviderPrestoConfig? PrestoConfig { get; set; }

    /// <summary>
    /// The project in which the cluster can be found and jobs
    /// subsequently run against. If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    [JsonPropertyName("pysparkConfig")]
    public V1beta2JobStatusAtProviderPysparkConfig? PysparkConfig { get; set; }

    [JsonPropertyName("reference")]
    public V1beta2JobStatusAtProviderReference? Reference { get; set; }

    /// <summary>
    /// The Cloud Dataproc region. This essentially determines which clusters are available
    /// for this job to be submitted to. If not specified, defaults to global.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("scheduling")]
    public V1beta2JobStatusAtProviderScheduling? Scheduling { get; set; }

    [JsonPropertyName("sparkConfig")]
    public V1beta2JobStatusAtProviderSparkConfig? SparkConfig { get; set; }

    [JsonPropertyName("sparksqlConfig")]
    public V1beta2JobStatusAtProviderSparksqlConfig? SparksqlConfig { get; set; }

    [JsonPropertyName("status")]
    public IList<V1beta2JobStatusAtProviderStatus>? Status { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobStatusConditions
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
public partial class V1beta2JobStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2JobStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2JobStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Job is the Schema for the Jobs API. Manages a job resource within a Dataproc cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Job : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2JobSpec>, IStatus<V1beta2JobStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Job";
    public const string KubeGroup = "dataproc.gcp.upbound.io";
    public const string KubePluralName = "jobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataproc.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Job";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>JobSpec defines the desired state of Job</summary>
    [JsonPropertyName("spec")]
    public required V1beta2JobSpec Spec { get; set; }

    /// <summary>JobStatus defines the observed state of Job.</summary>
    [JsonPropertyName("status")]
    public V1beta2JobStatus? Status { get; set; }
}
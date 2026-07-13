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
/// <summary>WorkflowTemplate is the Schema for the WorkflowTemplates API. A Workflow Template is a reusable workflow configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2WorkflowTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1beta2WorkflowTemplate>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "WorkflowTemplateList";
    public const string KubeGroup = "dataproc.gcp.upbound.io";
    public const string KubePluralName = "workflowtemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataproc.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkflowTemplateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2WorkflowTemplate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2WorkflowTemplate> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkflowTemplateSpecDeletionPolicyEnum>))]
public enum V1beta2WorkflowTemplateSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Encryption settings for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderEncryptionConfig
{
    /// <summary>The uri of the KMS key used to encrypt various sensitive files.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsHadoopJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>Job is a Hadoop job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsHadoopJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateSpecForProviderJobsHadoopJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The name of the driver&apos;s main class. The jar file that contains the class must be in the default CLASSPATH or specified in jar_file_uris.</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The HCFS URI of the jar file that contains the main class.</summary>
    [JsonPropertyName("mainJarFileUri")]
    public string? MainJarFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>A list of queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsHiveJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: &quot;hiveJob&quot;: { &quot;queryList&quot;: { &quot;queries&quot;: } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary>Job is a Hive job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsHiveJob
{
    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public V1beta2WorkflowTemplateSpecForProviderJobsHiveJobQueryList? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&quot;value&quot;;).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsPigJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>A list of queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsPigJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: &quot;hiveJob&quot;: { &quot;queryList&quot;: { &quot;queries&quot;: } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary>Job is a Pig job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsPigJob
{
    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateSpecForProviderJobsPigJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public V1beta2WorkflowTemplateSpecForProviderJobsPigJobQueryList? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&quot;value&quot;;).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsPrestoJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>A list of queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsPrestoJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: &quot;hiveJob&quot;: { &quot;queryList&quot;: { &quot;queries&quot;: } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary>Job is a Presto job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsPrestoJob
{
    /// <summary>Presto client tags to attach to this query</summary>
    [JsonPropertyName("clientTags")]
    public IList<string>? ClientTags { get; set; }

    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateSpecForProviderJobsPrestoJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The format in which query output will be displayed. See the Presto documentation for supported output formats</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public V1beta2WorkflowTemplateSpecForProviderJobsPrestoJobQueryList? QueryList { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsPysparkJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>Job is a PySpark job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsPysparkJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateSpecForProviderJobsPysparkJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Required. The HCFS URI of the main Python file to use as the driver. Must be a .py file.</summary>
    [JsonPropertyName("mainPythonFileUri")]
    public string? MainPythonFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip.</summary>
    [JsonPropertyName("pythonFileUris")]
    public IList<string>? PythonFileUris { get; set; }
}

/// <summary>Job scheduling configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsScheduling
{
    /// <summary>Maximum number of times per hour a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed. A job may be reported as thrashing if driver exits with non-zero code 4 times within 10 minute window. Maximum value is 10.</summary>
    [JsonPropertyName("maxFailuresPerHour")]
    public double? MaxFailuresPerHour { get; set; }

    /// <summary>Maximum number of times in total a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed. Maximum value is 240</summary>
    [JsonPropertyName("maxFailuresTotal")]
    public double? MaxFailuresTotal { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsSparkJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>Job is a Spark job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsSparkJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateSpecForProviderJobsSparkJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The name of the driver&apos;s main class. The jar file that contains the class must be in the default CLASSPATH or specified in jar_file_uris.</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The HCFS URI of the jar file that contains the main class.</summary>
    [JsonPropertyName("mainJarFileUri")]
    public string? MainJarFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsSparkRJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>Job is a SparkR job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsSparkRJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateSpecForProviderJobsSparkRJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Required. The HCFS URI of the main R file to use as the driver. Must be a .R file.</summary>
    [JsonPropertyName("mainRFileUri")]
    public string? MainRFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsSparkSqlJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>A list of queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsSparkSqlJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: &quot;hiveJob&quot;: { &quot;queryList&quot;: { &quot;queries&quot;: } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary>Job is a SparkSql job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobsSparkSqlJob
{
    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateSpecForProviderJobsSparkSqlJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public V1beta2WorkflowTemplateSpecForProviderJobsSparkSqlJobQueryList? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&quot;value&quot;;).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderJobs
{
    /// <summary>Job is a Hadoop job.</summary>
    [JsonPropertyName("hadoopJob")]
    public V1beta2WorkflowTemplateSpecForProviderJobsHadoopJob? HadoopJob { get; set; }

    /// <summary>Job is a Hive job.</summary>
    [JsonPropertyName("hiveJob")]
    public V1beta2WorkflowTemplateSpecForProviderJobsHiveJob? HiveJob { get; set; }

    /// <summary>The labels to associate with this job. Label keys must be between 1 and 63 characters long, and must conform to the following regular expression: {0,63} No more than 32 labels can be associated with a given job.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Job is a Pig job.</summary>
    [JsonPropertyName("pigJob")]
    public V1beta2WorkflowTemplateSpecForProviderJobsPigJob? PigJob { get; set; }

    /// <summary>The optional list of prerequisite job step_ids. If not specified, the job will start at the beginning of workflow.</summary>
    [JsonPropertyName("prerequisiteStepIds")]
    public IList<string>? PrerequisiteStepIds { get; set; }

    /// <summary>Job is a Presto job.</summary>
    [JsonPropertyName("prestoJob")]
    public V1beta2WorkflowTemplateSpecForProviderJobsPrestoJob? PrestoJob { get; set; }

    /// <summary>Job is a PySpark job.</summary>
    [JsonPropertyName("pysparkJob")]
    public V1beta2WorkflowTemplateSpecForProviderJobsPysparkJob? PysparkJob { get; set; }

    /// <summary>Job scheduling configuration.</summary>
    [JsonPropertyName("scheduling")]
    public V1beta2WorkflowTemplateSpecForProviderJobsScheduling? Scheduling { get; set; }

    /// <summary>Job is a Spark job.</summary>
    [JsonPropertyName("sparkJob")]
    public V1beta2WorkflowTemplateSpecForProviderJobsSparkJob? SparkJob { get; set; }

    /// <summary>Job is a SparkR job.</summary>
    [JsonPropertyName("sparkRJob")]
    public V1beta2WorkflowTemplateSpecForProviderJobsSparkRJob? SparkRJob { get; set; }

    /// <summary>Job is a SparkSql job.</summary>
    [JsonPropertyName("sparkSqlJob")]
    public V1beta2WorkflowTemplateSpecForProviderJobsSparkSqlJob? SparkSqlJob { get; set; }

    /// <summary>Required. The step id. The id must be unique among all jobs within the template. The step id is used as prefix for job id, as job goog-dataproc-workflow-step-id label, and in field from other steps. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between 3 and 50 characters.</summary>
    [JsonPropertyName("stepId")]
    public string? StepId { get; set; }
}

/// <summary>Validation based on regular expressions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderParametersValidationRegex
{
    /// <summary>Required. RE2 regular expressions used to validate the parameter&apos;s value. The value must match the regex in its entirety (substring matches are not sufficient).</summary>
    [JsonPropertyName("regexes")]
    public IList<string>? Regexes { get; set; }
}

/// <summary>Required. List of allowed values for the parameter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderParametersValidationValues
{
    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Validation rules to be applied to this parameter&apos;s value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderParametersValidation
{
    /// <summary>Validation based on regular expressions.</summary>
    [JsonPropertyName("regex")]
    public V1beta2WorkflowTemplateSpecForProviderParametersValidationRegex? Regex { get; set; }

    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public V1beta2WorkflowTemplateSpecForProviderParametersValidationValues? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderParameters
{
    /// <summary>Brief description of the parameter. Must not exceed 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Paths to all fields that the parameter replaces. A field is allowed to appear in at most one parameter&apos;s list of field paths. A field path is similar in syntax to a .sparkJob.args</summary>
    [JsonPropertyName("fields")]
    public IList<string>? Fields { get; set; }

    /// <summary>Required. Parameter name. The parameter name is used as the key, and paired with the parameter value, which are passed to the template when the template is instantiated. The name must contain only capital letters (A-Z), numbers (0-9), and underscores (_), and must not start with a number. The maximum length is 40 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Validation rules to be applied to this parameter&apos;s value.</summary>
    [JsonPropertyName("validation")]
    public V1beta2WorkflowTemplateSpecForProviderParametersValidation? Validation { get; set; }
}

/// <summary>A selector that chooses target cluster for jobs based on metadata. The selector is evaluated at the time each job is submitted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementClusterSelector
{
    /// <summary>Required. The cluster labels. Cluster must have all labels to match.</summary>
    [JsonPropertyName("clusterLabels")]
    public IDictionary<string, string>? ClusterLabels { get; set; }

    /// <summary>The zone where the Compute Engine cluster will be located. On a create request, it is required in the &quot;global&quot; region. If omitted in a non-global Dataproc region, the service will pick a zone in the corresponding Compute Engine region. On a get request, zone will always be present. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/ * us-central1-f</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>Autoscaling config for the policy associated with the cluster. Cluster does not autoscale if this field is unset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigAutoscalingConfig
{
    /// <summary>The autoscaling policy used by the cluster. Only resource names including projectid and location (region) are valid. Examples: * https://www.googleapis.com/compute/v1/projects/ Note that the policy must be in the same project and Dataproc region.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

/// <summary>Encryption settings for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigEncryptionConfig
{
    /// <summary>The Cloud KMS key name to use for PD disk encryption for all instances in the cluster.</summary>
    [JsonPropertyName("gcePdKmsKeyName")]
    public string? GcePdKmsKeyName { get; set; }
}

/// <summary>Port/endpoint configuration for this cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigEndpointConfig
{
    /// <summary>If true, enable http access to specific ports on the cluster from external sources. Defaults to false.</summary>
    [JsonPropertyName("enableHttpPortAccess")]
    public bool? EnableHttpPortAccess { get; set; }
}

/// <summary>Node Group Affinity for sole-tenant clusters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigGceClusterConfigNodeGroupAffinity
{
    /// <summary>Required. The URI of a sole-tenant /zones/us-central1-a/nodeGroups/node-group-1*node-group-1`</summary>
    [JsonPropertyName("nodeGroup")]
    public string? NodeGroup { get; set; }
}

/// <summary>Reservation Affinity for consuming Zonal reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigGceClusterConfigReservationAffinity
{
    /// <summary>Type of reservation to consume Possible values: TYPE_UNSPECIFIED, NO_RESERVATION, ANY_RESERVATION, SPECIFIC_RESERVATION</summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>Corresponds to the label key of reservation resource.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Shielded Instance Config for clusters using Compute Engine Shielded VMs. Structure defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigGceClusterConfigShieldedInstanceConfig
{
    /// <summary>Defines whether instances have Integrity Monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines whether instances have Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Defines whether instances have the vTPM enabled.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

/// <summary>The shared Compute Engine config settings for all instances in a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigGceClusterConfig
{
    /// <summary>If true, all instances in the cluster will only have internal IP addresses. By default, clusters are not restricted to internal IP addresses, and will have ephemeral external IP addresses assigned to each instance. This internal_ip_only restriction can only be enabled for subnetwork enabled networks, and all off-cluster dependencies must be configured to be accessible without external IP addresses.</summary>
    [JsonPropertyName("internalIpOnly")]
    public bool? InternalIpOnly { get; set; }

    /// <summary>The Compute Engine metadata entries to add to all instances (see About VM metadata).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The Compute Engine network to be used for machine communications. Cannot be specified with subnetwork_uri. If neither network_uri nor subnetwork_uri is specified, the &quot;default&quot; network of the project is used, if it exists. Cannot be a &quot;Custom Subnet Network&quot; (see /regions/global/default*default`</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Node Group Affinity for sole-tenant clusters.</summary>
    [JsonPropertyName("nodeGroupAffinity")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigGceClusterConfigNodeGroupAffinity? NodeGroupAffinity { get; set; }

    /// <summary>The type of IPv6 access for a cluster. Possible values: PRIVATE_IPV6_GOOGLE_ACCESS_UNSPECIFIED, INHERIT_FROM_SUBNETWORK, OUTBOUND, BIDIRECTIONAL</summary>
    [JsonPropertyName("privateIpv6GoogleAccess")]
    public string? PrivateIpv6GoogleAccess { get; set; }

    /// <summary>Reservation Affinity for consuming Zonal reservation.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigGceClusterConfigReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>The (https://cloud.google.com/compute/docs/access/service-accounts#default_service_account) is used.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>The URIs of service account scopes to be included in Compute Engine instances. The following base set of scopes is always included: * https://www.googleapis.com/auth/cloud.useraccounts.readonly * https://www.googleapis.com/auth/devstorage.read_write * https://www.googleapis.com/auth/logging.write If no scopes are specified, the following defaults are also provided: * https://www.googleapis.com/auth/bigquery * https://www.googleapis.com/auth/bigtable.admin.table * https://www.googleapis.com/auth/bigtable.data * https://www.googleapis.com/auth/devstorage.full_control</summary>
    [JsonPropertyName("serviceAccountScopes")]
    public IList<string>? ServiceAccountScopes { get; set; }

    /// <summary>Shielded Instance Config for clusters using Compute Engine Shielded VMs. Structure defined below.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigGceClusterConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>The Compute Engine subnetwork to be used for machine communications. Cannot be specified with network_uri. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects//regions/us-east1/subnetworks/sub0 * sub0</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>The Compute Engine tags to add to all instances (see Manage tags for resources).</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The zone where the Compute Engine cluster will be located. On a create request, it is required in the &quot;global&quot; region. If omitted in a non-global Dataproc region, the service will pick a zone in the corresponding Compute Engine region. On a get request, zone will always be present. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/ * us-central1-f</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigInitializationActions
{
    /// <summary>Required. Cloud Storage URI of executable file.</summary>
    [JsonPropertyName("executableFile")]
    public string? ExecutableFile { get; set; }

    /// <summary>Amount of time executable has to complete. Default is 10 minutes (see JSON representation of JSON Mapping - Language Guide (proto 3)). Cluster creation fails with an explanatory error message (the name of the executable that caused the error and the exceeded timeout period) if the executable is not completed at end of the timeout period.</summary>
    [JsonPropertyName("executionTimeout")]
    public string? ExecutionTimeout { get; set; }
}

/// <summary>Lifecycle setting for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigLifecycleConfig
{
    /// <summary>The time when cluster will be auto-deleted (see JSON representation of JSON Mapping - Language Guide (proto 3)).</summary>
    [JsonPropertyName("autoDeleteTime")]
    public string? AutoDeleteTime { get; set; }

    /// <summary>The lifetime duration of cluster. The cluster will be auto-deleted at the end of this period. Minimum value is 10 minutes; maximum value is 14 days (see JSON representation of JSON Mapping - Language Guide (proto 3)).</summary>
    [JsonPropertyName("autoDeleteTtl")]
    public string? AutoDeleteTtl { get; set; }

    /// <summary>The duration to keep the cluster alive while idling (when no jobs are running). Passing this threshold will cause the cluster to be deleted. Minimum value is 5 minutes; maximum value is 14 days (see JSON representation of JSON Mapping - Language Guide (proto 3).</summary>
    [JsonPropertyName("idleDeleteTtl")]
    public string? IdleDeleteTtl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigMasterConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Disk option config settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigMasterConfigDiskConfig
{
    /// <summary>Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>Type of the boot disk (default is &quot;pd-standard&quot;). Valid values: &quot;pd-ssd&quot; (Persistent Disk Solid State Drive) or &quot;pd-standard&quot; (Persistent Disk Hard Disk Drive).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigMasterConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigMasterConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigMasterConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * https://www.googleapis.com/compute/beta/projects/ If the URI is unspecified, it will be inferred from SoftwareConfig.image_version or the system default.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/(https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Specifies the minimum cpu platform for the Instance Group. See Minimum CPU platform.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The number of VM instances in the instance group. For master instance groups, must be set to 1.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the instance group. The default value for master and worker groups is NON_PREEMPTIBLE. This default cannot be changed. The default value for secondary instances is PREEMPTIBLE. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecondaryWorkerConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Disk option config settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecondaryWorkerConfigDiskConfig
{
    /// <summary>Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>Type of the boot disk (default is &quot;pd-standard&quot;). Valid values: &quot;pd-ssd&quot; (Persistent Disk Solid State Drive) or &quot;pd-standard&quot; (Persistent Disk Hard Disk Drive).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecondaryWorkerConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecondaryWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecondaryWorkerConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * https://www.googleapis.com/compute/beta/projects/ If the URI is unspecified, it will be inferred from SoftwareConfig.image_version or the system default.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/(https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Specifies the minimum cpu platform for the Instance Group. See Minimum CPU platform.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The number of VM instances in the instance group. For master instance groups, must be set to 1.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the instance group. The default value for master and worker groups is NON_PREEMPTIBLE. This default cannot be changed. The default value for secondary instances is PREEMPTIBLE. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary>Kerberos related configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecurityConfigKerberosConfig
{
    /// <summary>The admin server (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustAdminServer")]
    public string? CrossRealmTrustAdminServer { get; set; }

    /// <summary>The KDC (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustKdc")]
    public string? CrossRealmTrustKdc { get; set; }

    /// <summary>The remote realm the Dataproc on-cluster KDC will trust, should the user enable cross realm trust.</summary>
    [JsonPropertyName("crossRealmTrustRealm")]
    public string? CrossRealmTrustRealm { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the shared password between the on-cluster Kerberos realm and the remote trusted realm, in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustSharedPassword")]
    public string? CrossRealmTrustSharedPassword { get; set; }

    /// <summary>Flag to indicate whether to Kerberize the cluster (default: false). Set this field to true to enable Kerberos on a cluster.</summary>
    [JsonPropertyName("enableKerberos")]
    public bool? EnableKerberos { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the master key of the KDC database.</summary>
    [JsonPropertyName("kdcDbKey")]
    public string? KdcDbKey { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided key. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("keyPassword")]
    public string? KeyPassword { get; set; }

    /// <summary>The Cloud Storage URI of the keystore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("keystore")]
    public string? Keystore { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided keystore. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("keystorePassword")]
    public string? KeystorePassword { get; set; }

    /// <summary>The uri of the KMS key used to encrypt various sensitive files.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>The name of the on-cluster Kerberos realm. If not specified, the uppercased domain of hostnames will be the realm.</summary>
    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the root principal password.</summary>
    [JsonPropertyName("rootPrincipalPassword")]
    public string? RootPrincipalPassword { get; set; }

    /// <summary>The lifetime of the ticket granting ticket, in hours. If not specified, or user specifies 0, then default value 10 will be used.</summary>
    [JsonPropertyName("tgtLifetimeHours")]
    public double? TgtLifetimeHours { get; set; }

    /// <summary>The Cloud Storage URI of the truststore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("truststore")]
    public string? Truststore { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided truststore. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("truststorePassword")]
    public string? TruststorePassword { get; set; }
}

/// <summary>Security settings for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecurityConfig
{
    /// <summary>Kerberos related configuration.</summary>
    [JsonPropertyName("kerberosConfig")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecurityConfigKerberosConfig? KerberosConfig { get; set; }
}

/// <summary>The config settings for software inside the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSoftwareConfig
{
    /// <summary>The version of software inside the cluster. It must be one of the supported Dataproc Versions, such as &quot;1.2&quot; (including a subminor version, such as &quot;1.2.29&quot;), or the &quot;preview&quot; version. If unspecified, it defaults to the latest Debian version.</summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>The set of components to activate on the cluster.</summary>
    [JsonPropertyName("optionalComponents")]
    public IList<string>? OptionalComponents { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigWorkerConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Disk option config settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigWorkerConfigDiskConfig
{
    /// <summary>Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>Type of the boot disk (default is &quot;pd-standard&quot;). Valid values: &quot;pd-ssd&quot; (Persistent Disk Solid State Drive) or &quot;pd-standard&quot; (Persistent Disk Hard Disk Drive).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigWorkerConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigWorkerConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * https://www.googleapis.com/compute/beta/projects/ If the URI is unspecified, it will be inferred from SoftwareConfig.image_version or the system default.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/(https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Specifies the minimum cpu platform for the Instance Group. See Minimum CPU platform.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The number of VM instances in the instance group. For master instance groups, must be set to 1.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the instance group. The default value for master and worker groups is NON_PREEMPTIBLE. This default cannot be changed. The default value for secondary instances is PREEMPTIBLE. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary>Required. The cluster configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfig
{
    /// <summary>Autoscaling config for the policy associated with the cluster. Cluster does not autoscale if this field is unset.</summary>
    [JsonPropertyName("autoscalingConfig")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigAutoscalingConfig? AutoscalingConfig { get; set; }

    /// <summary>Encryption settings for the cluster.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>Port/endpoint configuration for this cluster</summary>
    [JsonPropertyName("endpointConfig")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigEndpointConfig? EndpointConfig { get; set; }

    /// <summary>The shared Compute Engine config settings for all instances in a cluster.</summary>
    [JsonPropertyName("gceClusterConfig")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigGceClusterConfig? GceClusterConfig { get; set; }

    /// <summary>Commands to execute on each node after config is completed. By default, executables are run on master and all worker nodes. You can test a node&apos;s role metadata to run an executable on a master or worker node, as shown below using curl (you can also use wget): ROLE=$(curl -H Metadata-Flavor:Google http://metadata/computeMetadata/v1/instance/attributes/dataproc-role) if ; then ... master specific actions ... else ... worker specific actions ... fi</summary>
    [JsonPropertyName("initializationActions")]
    public IList<V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigInitializationActions>? InitializationActions { get; set; }

    /// <summary>Lifecycle setting for the cluster.</summary>
    [JsonPropertyName("lifecycleConfig")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigLifecycleConfig? LifecycleConfig { get; set; }

    /// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("masterConfig")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigMasterConfig? MasterConfig { get; set; }

    /// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("secondaryWorkerConfig")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecondaryWorkerConfig? SecondaryWorkerConfig { get; set; }

    /// <summary>Security settings for the cluster.</summary>
    [JsonPropertyName("securityConfig")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSecurityConfig? SecurityConfig { get; set; }

    /// <summary>The config settings for software inside the cluster.</summary>
    [JsonPropertyName("softwareConfig")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigSoftwareConfig? SoftwareConfig { get; set; }

    /// <summary>A Cloud Storage bucket used to stage job dependencies, config files, and job driver console output. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster&apos;s staging bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket (see Dataproc staging and temp buckets).</summary>
    [JsonPropertyName("stagingBucket")]
    public string? StagingBucket { get; set; }

    /// <summary>A Cloud Storage bucket used to store ephemeral cluster and jobs data, such as Spark and MapReduce history files. If you do not specify a temp bucket, Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster&apos;s temp bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket. The default bucket has a TTL of 90 days, but you can use any TTL (or none) if you specify a bucket.</summary>
    [JsonPropertyName("tempBucket")]
    public string? TempBucket { get; set; }

    /// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("workerConfig")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfigWorkerConfig? WorkerConfig { get; set; }
}

/// <summary>A cluster that is managed by the workflow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacementManagedCluster
{
    /// <summary>Required. The cluster name prefix. A unique cluster name will be formed by appending a random suffix. The name must contain only lower-case letters (a-z), numbers (0-9), and hyphens (-). Must begin with a letter. Cannot begin or end with hyphen. Must consist of between 2 and 35 characters.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Required. The cluster configuration.</summary>
    [JsonPropertyName("config")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedClusterConfig? Config { get; set; }

    /// <summary>The labels to associate with this cluster. Label keys must be between 1 and 63 characters long, and must conform to the following PCRE regular expression: {0,63} No more than 32 labels can be associated with a given cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>Required. WorkflowTemplate scheduling information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProviderPlacement
{
    /// <summary>A selector that chooses target cluster for jobs based on metadata. The selector is evaluated at the time each job is submitted.</summary>
    [JsonPropertyName("clusterSelector")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementClusterSelector? ClusterSelector { get; set; }

    /// <summary>A cluster that is managed by the workflow.</summary>
    [JsonPropertyName("managedCluster")]
    public V1beta2WorkflowTemplateSpecForProviderPlacementManagedCluster? ManagedCluster { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecForProvider
{
    /// <summary>(Beta only) Optional. Timeout duration for the DAG of jobs. You can use &quot;s&quot;, &quot;m&quot;, &quot;h&quot;, and &quot;d&quot; suffixes for second, minute, hour, and day duration values, respectively. The timeout duration must be from 10 minutes (&quot;10m&quot;) to 24 hours (&quot;24h&quot; or &quot;1d&quot;). The timer begins when the first job is submitted. If the workflow is running at the end of the timeout period, any remaining jobs are cancelled, the workflow is ended, and if the workflow was running on a (/dataproc/docs/concepts/workflows/using-workflows#configuring_or_selecting_a_cluster), the cluster is deleted.</summary>
    [JsonPropertyName("dagTimeout")]
    public string? DagTimeout { get; set; }

    /// <summary>Encryption settings for the cluster.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta2WorkflowTemplateSpecForProviderEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>Required. The Directed Acyclic Graph of Jobs to submit.</summary>
    [JsonPropertyName("jobs")]
    public IList<V1beta2WorkflowTemplateSpecForProviderJobs>? Jobs { get; set; }

    /// <summary>The labels to associate with this cluster. Label keys must be between 1 and 63 characters long, and must conform to the following PCRE regular expression: {0,63} No more than 32 labels can be associated with a given cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Template parameters whose values are substituted into the template. Values for parameters must be provided when the template is instantiated.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta2WorkflowTemplateSpecForProviderParameters>? Parameters { get; set; }

    /// <summary>Required. WorkflowTemplate scheduling information.</summary>
    [JsonPropertyName("placement")]
    public V1beta2WorkflowTemplateSpecForProviderPlacement? Placement { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Used to perform a consistent read-modify-write. This field should be left blank for a CreateWorkflowTemplate request. It is required for an UpdateWorkflowTemplate request, and must match the current server version. A typical update template flow would fetch the current template with a GetWorkflowTemplate request, which will return the current template with the version field filled in with the current server version. The user updates other fields in the template, then returns it as part of the UpdateWorkflowTemplate request.</summary>
    [JsonPropertyName("version")]
    public double? Version { get; set; }
}

/// <summary>Encryption settings for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderEncryptionConfig
{
    /// <summary>The uri of the KMS key used to encrypt various sensitive files.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsHadoopJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>Job is a Hadoop job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsHadoopJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsHadoopJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The name of the driver&apos;s main class. The jar file that contains the class must be in the default CLASSPATH or specified in jar_file_uris.</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The HCFS URI of the jar file that contains the main class.</summary>
    [JsonPropertyName("mainJarFileUri")]
    public string? MainJarFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>A list of queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsHiveJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: &quot;hiveJob&quot;: { &quot;queryList&quot;: { &quot;queries&quot;: } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary>Job is a Hive job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsHiveJob
{
    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsHiveJobQueryList? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&quot;value&quot;;).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsPigJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>A list of queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsPigJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: &quot;hiveJob&quot;: { &quot;queryList&quot;: { &quot;queries&quot;: } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary>Job is a Pig job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsPigJob
{
    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsPigJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsPigJobQueryList? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&quot;value&quot;;).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsPrestoJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>A list of queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsPrestoJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: &quot;hiveJob&quot;: { &quot;queryList&quot;: { &quot;queries&quot;: } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary>Job is a Presto job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsPrestoJob
{
    /// <summary>Presto client tags to attach to this query</summary>
    [JsonPropertyName("clientTags")]
    public IList<string>? ClientTags { get; set; }

    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsPrestoJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The format in which query output will be displayed. See the Presto documentation for supported output formats</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsPrestoJobQueryList? QueryList { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsPysparkJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>Job is a PySpark job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsPysparkJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsPysparkJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Required. The HCFS URI of the main Python file to use as the driver. Must be a .py file.</summary>
    [JsonPropertyName("mainPythonFileUri")]
    public string? MainPythonFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip.</summary>
    [JsonPropertyName("pythonFileUris")]
    public IList<string>? PythonFileUris { get; set; }
}

/// <summary>Job scheduling configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsScheduling
{
    /// <summary>Maximum number of times per hour a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed. A job may be reported as thrashing if driver exits with non-zero code 4 times within 10 minute window. Maximum value is 10.</summary>
    [JsonPropertyName("maxFailuresPerHour")]
    public double? MaxFailuresPerHour { get; set; }

    /// <summary>Maximum number of times in total a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed. Maximum value is 240</summary>
    [JsonPropertyName("maxFailuresTotal")]
    public double? MaxFailuresTotal { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsSparkJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>Job is a Spark job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsSparkJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsSparkJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The name of the driver&apos;s main class. The jar file that contains the class must be in the default CLASSPATH or specified in jar_file_uris.</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The HCFS URI of the jar file that contains the main class.</summary>
    [JsonPropertyName("mainJarFileUri")]
    public string? MainJarFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsSparkRJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>Job is a SparkR job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsSparkRJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsSparkRJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Required. The HCFS URI of the main R file to use as the driver. Must be a .R file.</summary>
    [JsonPropertyName("mainRFileUri")]
    public string? MainRFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsSparkSqlJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>A list of queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsSparkSqlJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: &quot;hiveJob&quot;: { &quot;queryList&quot;: { &quot;queries&quot;: } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary>Job is a SparkSql job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobsSparkSqlJob
{
    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsSparkSqlJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsSparkSqlJobQueryList? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&quot;value&quot;;).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderJobs
{
    /// <summary>Job is a Hadoop job.</summary>
    [JsonPropertyName("hadoopJob")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsHadoopJob? HadoopJob { get; set; }

    /// <summary>Job is a Hive job.</summary>
    [JsonPropertyName("hiveJob")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsHiveJob? HiveJob { get; set; }

    /// <summary>The labels to associate with this job. Label keys must be between 1 and 63 characters long, and must conform to the following regular expression: {0,63} No more than 32 labels can be associated with a given job.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Job is a Pig job.</summary>
    [JsonPropertyName("pigJob")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsPigJob? PigJob { get; set; }

    /// <summary>The optional list of prerequisite job step_ids. If not specified, the job will start at the beginning of workflow.</summary>
    [JsonPropertyName("prerequisiteStepIds")]
    public IList<string>? PrerequisiteStepIds { get; set; }

    /// <summary>Job is a Presto job.</summary>
    [JsonPropertyName("prestoJob")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsPrestoJob? PrestoJob { get; set; }

    /// <summary>Job is a PySpark job.</summary>
    [JsonPropertyName("pysparkJob")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsPysparkJob? PysparkJob { get; set; }

    /// <summary>Job scheduling configuration.</summary>
    [JsonPropertyName("scheduling")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsScheduling? Scheduling { get; set; }

    /// <summary>Job is a Spark job.</summary>
    [JsonPropertyName("sparkJob")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsSparkJob? SparkJob { get; set; }

    /// <summary>Job is a SparkR job.</summary>
    [JsonPropertyName("sparkRJob")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsSparkRJob? SparkRJob { get; set; }

    /// <summary>Job is a SparkSql job.</summary>
    [JsonPropertyName("sparkSqlJob")]
    public V1beta2WorkflowTemplateSpecInitProviderJobsSparkSqlJob? SparkSqlJob { get; set; }

    /// <summary>Required. The step id. The id must be unique among all jobs within the template. The step id is used as prefix for job id, as job goog-dataproc-workflow-step-id label, and in field from other steps. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between 3 and 50 characters.</summary>
    [JsonPropertyName("stepId")]
    public string? StepId { get; set; }
}

/// <summary>Validation based on regular expressions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderParametersValidationRegex
{
    /// <summary>Required. RE2 regular expressions used to validate the parameter&apos;s value. The value must match the regex in its entirety (substring matches are not sufficient).</summary>
    [JsonPropertyName("regexes")]
    public IList<string>? Regexes { get; set; }
}

/// <summary>Required. List of allowed values for the parameter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderParametersValidationValues
{
    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Validation rules to be applied to this parameter&apos;s value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderParametersValidation
{
    /// <summary>Validation based on regular expressions.</summary>
    [JsonPropertyName("regex")]
    public V1beta2WorkflowTemplateSpecInitProviderParametersValidationRegex? Regex { get; set; }

    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public V1beta2WorkflowTemplateSpecInitProviderParametersValidationValues? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderParameters
{
    /// <summary>Brief description of the parameter. Must not exceed 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Paths to all fields that the parameter replaces. A field is allowed to appear in at most one parameter&apos;s list of field paths. A field path is similar in syntax to a .sparkJob.args</summary>
    [JsonPropertyName("fields")]
    public IList<string>? Fields { get; set; }

    /// <summary>Required. Parameter name. The parameter name is used as the key, and paired with the parameter value, which are passed to the template when the template is instantiated. The name must contain only capital letters (A-Z), numbers (0-9), and underscores (_), and must not start with a number. The maximum length is 40 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Validation rules to be applied to this parameter&apos;s value.</summary>
    [JsonPropertyName("validation")]
    public V1beta2WorkflowTemplateSpecInitProviderParametersValidation? Validation { get; set; }
}

/// <summary>A selector that chooses target cluster for jobs based on metadata. The selector is evaluated at the time each job is submitted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementClusterSelector
{
    /// <summary>Required. The cluster labels. Cluster must have all labels to match.</summary>
    [JsonPropertyName("clusterLabels")]
    public IDictionary<string, string>? ClusterLabels { get; set; }

    /// <summary>The zone where the Compute Engine cluster will be located. On a create request, it is required in the &quot;global&quot; region. If omitted in a non-global Dataproc region, the service will pick a zone in the corresponding Compute Engine region. On a get request, zone will always be present. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/ * us-central1-f</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>Autoscaling config for the policy associated with the cluster. Cluster does not autoscale if this field is unset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigAutoscalingConfig
{
    /// <summary>The autoscaling policy used by the cluster. Only resource names including projectid and location (region) are valid. Examples: * https://www.googleapis.com/compute/v1/projects/ Note that the policy must be in the same project and Dataproc region.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

/// <summary>Encryption settings for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigEncryptionConfig
{
    /// <summary>The Cloud KMS key name to use for PD disk encryption for all instances in the cluster.</summary>
    [JsonPropertyName("gcePdKmsKeyName")]
    public string? GcePdKmsKeyName { get; set; }
}

/// <summary>Port/endpoint configuration for this cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigEndpointConfig
{
    /// <summary>If true, enable http access to specific ports on the cluster from external sources. Defaults to false.</summary>
    [JsonPropertyName("enableHttpPortAccess")]
    public bool? EnableHttpPortAccess { get; set; }
}

/// <summary>Node Group Affinity for sole-tenant clusters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigGceClusterConfigNodeGroupAffinity
{
    /// <summary>Required. The URI of a sole-tenant /zones/us-central1-a/nodeGroups/node-group-1*node-group-1`</summary>
    [JsonPropertyName("nodeGroup")]
    public string? NodeGroup { get; set; }
}

/// <summary>Reservation Affinity for consuming Zonal reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigGceClusterConfigReservationAffinity
{
    /// <summary>Type of reservation to consume Possible values: TYPE_UNSPECIFIED, NO_RESERVATION, ANY_RESERVATION, SPECIFIC_RESERVATION</summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>Corresponds to the label key of reservation resource.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Shielded Instance Config for clusters using Compute Engine Shielded VMs. Structure defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigGceClusterConfigShieldedInstanceConfig
{
    /// <summary>Defines whether instances have Integrity Monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines whether instances have Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Defines whether instances have the vTPM enabled.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

/// <summary>The shared Compute Engine config settings for all instances in a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigGceClusterConfig
{
    /// <summary>If true, all instances in the cluster will only have internal IP addresses. By default, clusters are not restricted to internal IP addresses, and will have ephemeral external IP addresses assigned to each instance. This internal_ip_only restriction can only be enabled for subnetwork enabled networks, and all off-cluster dependencies must be configured to be accessible without external IP addresses.</summary>
    [JsonPropertyName("internalIpOnly")]
    public bool? InternalIpOnly { get; set; }

    /// <summary>The Compute Engine metadata entries to add to all instances (see About VM metadata).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The Compute Engine network to be used for machine communications. Cannot be specified with subnetwork_uri. If neither network_uri nor subnetwork_uri is specified, the &quot;default&quot; network of the project is used, if it exists. Cannot be a &quot;Custom Subnet Network&quot; (see /regions/global/default*default`</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Node Group Affinity for sole-tenant clusters.</summary>
    [JsonPropertyName("nodeGroupAffinity")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigGceClusterConfigNodeGroupAffinity? NodeGroupAffinity { get; set; }

    /// <summary>The type of IPv6 access for a cluster. Possible values: PRIVATE_IPV6_GOOGLE_ACCESS_UNSPECIFIED, INHERIT_FROM_SUBNETWORK, OUTBOUND, BIDIRECTIONAL</summary>
    [JsonPropertyName("privateIpv6GoogleAccess")]
    public string? PrivateIpv6GoogleAccess { get; set; }

    /// <summary>Reservation Affinity for consuming Zonal reservation.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigGceClusterConfigReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>The (https://cloud.google.com/compute/docs/access/service-accounts#default_service_account) is used.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>The URIs of service account scopes to be included in Compute Engine instances. The following base set of scopes is always included: * https://www.googleapis.com/auth/cloud.useraccounts.readonly * https://www.googleapis.com/auth/devstorage.read_write * https://www.googleapis.com/auth/logging.write If no scopes are specified, the following defaults are also provided: * https://www.googleapis.com/auth/bigquery * https://www.googleapis.com/auth/bigtable.admin.table * https://www.googleapis.com/auth/bigtable.data * https://www.googleapis.com/auth/devstorage.full_control</summary>
    [JsonPropertyName("serviceAccountScopes")]
    public IList<string>? ServiceAccountScopes { get; set; }

    /// <summary>Shielded Instance Config for clusters using Compute Engine Shielded VMs. Structure defined below.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigGceClusterConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>The Compute Engine subnetwork to be used for machine communications. Cannot be specified with network_uri. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects//regions/us-east1/subnetworks/sub0 * sub0</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>The Compute Engine tags to add to all instances (see Manage tags for resources).</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The zone where the Compute Engine cluster will be located. On a create request, it is required in the &quot;global&quot; region. If omitted in a non-global Dataproc region, the service will pick a zone in the corresponding Compute Engine region. On a get request, zone will always be present. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/ * us-central1-f</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigInitializationActions
{
    /// <summary>Required. Cloud Storage URI of executable file.</summary>
    [JsonPropertyName("executableFile")]
    public string? ExecutableFile { get; set; }

    /// <summary>Amount of time executable has to complete. Default is 10 minutes (see JSON representation of JSON Mapping - Language Guide (proto 3)). Cluster creation fails with an explanatory error message (the name of the executable that caused the error and the exceeded timeout period) if the executable is not completed at end of the timeout period.</summary>
    [JsonPropertyName("executionTimeout")]
    public string? ExecutionTimeout { get; set; }
}

/// <summary>Lifecycle setting for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigLifecycleConfig
{
    /// <summary>The time when cluster will be auto-deleted (see JSON representation of JSON Mapping - Language Guide (proto 3)).</summary>
    [JsonPropertyName("autoDeleteTime")]
    public string? AutoDeleteTime { get; set; }

    /// <summary>The lifetime duration of cluster. The cluster will be auto-deleted at the end of this period. Minimum value is 10 minutes; maximum value is 14 days (see JSON representation of JSON Mapping - Language Guide (proto 3)).</summary>
    [JsonPropertyName("autoDeleteTtl")]
    public string? AutoDeleteTtl { get; set; }

    /// <summary>The duration to keep the cluster alive while idling (when no jobs are running). Passing this threshold will cause the cluster to be deleted. Minimum value is 5 minutes; maximum value is 14 days (see JSON representation of JSON Mapping - Language Guide (proto 3).</summary>
    [JsonPropertyName("idleDeleteTtl")]
    public string? IdleDeleteTtl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigMasterConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Disk option config settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigMasterConfigDiskConfig
{
    /// <summary>Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>Type of the boot disk (default is &quot;pd-standard&quot;). Valid values: &quot;pd-ssd&quot; (Persistent Disk Solid State Drive) or &quot;pd-standard&quot; (Persistent Disk Hard Disk Drive).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigMasterConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigMasterConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigMasterConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * https://www.googleapis.com/compute/beta/projects/ If the URI is unspecified, it will be inferred from SoftwareConfig.image_version or the system default.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/(https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Specifies the minimum cpu platform for the Instance Group. See Minimum CPU platform.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The number of VM instances in the instance group. For master instance groups, must be set to 1.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the instance group. The default value for master and worker groups is NON_PREEMPTIBLE. This default cannot be changed. The default value for secondary instances is PREEMPTIBLE. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecondaryWorkerConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Disk option config settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecondaryWorkerConfigDiskConfig
{
    /// <summary>Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>Type of the boot disk (default is &quot;pd-standard&quot;). Valid values: &quot;pd-ssd&quot; (Persistent Disk Solid State Drive) or &quot;pd-standard&quot; (Persistent Disk Hard Disk Drive).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecondaryWorkerConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecondaryWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecondaryWorkerConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * https://www.googleapis.com/compute/beta/projects/ If the URI is unspecified, it will be inferred from SoftwareConfig.image_version or the system default.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/(https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Specifies the minimum cpu platform for the Instance Group. See Minimum CPU platform.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The number of VM instances in the instance group. For master instance groups, must be set to 1.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the instance group. The default value for master and worker groups is NON_PREEMPTIBLE. This default cannot be changed. The default value for secondary instances is PREEMPTIBLE. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary>Kerberos related configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecurityConfigKerberosConfig
{
    /// <summary>The admin server (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustAdminServer")]
    public string? CrossRealmTrustAdminServer { get; set; }

    /// <summary>The KDC (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustKdc")]
    public string? CrossRealmTrustKdc { get; set; }

    /// <summary>The remote realm the Dataproc on-cluster KDC will trust, should the user enable cross realm trust.</summary>
    [JsonPropertyName("crossRealmTrustRealm")]
    public string? CrossRealmTrustRealm { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the shared password between the on-cluster Kerberos realm and the remote trusted realm, in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustSharedPassword")]
    public string? CrossRealmTrustSharedPassword { get; set; }

    /// <summary>Flag to indicate whether to Kerberize the cluster (default: false). Set this field to true to enable Kerberos on a cluster.</summary>
    [JsonPropertyName("enableKerberos")]
    public bool? EnableKerberos { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the master key of the KDC database.</summary>
    [JsonPropertyName("kdcDbKey")]
    public string? KdcDbKey { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided key. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("keyPassword")]
    public string? KeyPassword { get; set; }

    /// <summary>The Cloud Storage URI of the keystore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("keystore")]
    public string? Keystore { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided keystore. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("keystorePassword")]
    public string? KeystorePassword { get; set; }

    /// <summary>The uri of the KMS key used to encrypt various sensitive files.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>The name of the on-cluster Kerberos realm. If not specified, the uppercased domain of hostnames will be the realm.</summary>
    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the root principal password.</summary>
    [JsonPropertyName("rootPrincipalPassword")]
    public string? RootPrincipalPassword { get; set; }

    /// <summary>The lifetime of the ticket granting ticket, in hours. If not specified, or user specifies 0, then default value 10 will be used.</summary>
    [JsonPropertyName("tgtLifetimeHours")]
    public double? TgtLifetimeHours { get; set; }

    /// <summary>The Cloud Storage URI of the truststore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("truststore")]
    public string? Truststore { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided truststore. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("truststorePassword")]
    public string? TruststorePassword { get; set; }
}

/// <summary>Security settings for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecurityConfig
{
    /// <summary>Kerberos related configuration.</summary>
    [JsonPropertyName("kerberosConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecurityConfigKerberosConfig? KerberosConfig { get; set; }
}

/// <summary>The config settings for software inside the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSoftwareConfig
{
    /// <summary>The version of software inside the cluster. It must be one of the supported Dataproc Versions, such as &quot;1.2&quot; (including a subminor version, such as &quot;1.2.29&quot;), or the &quot;preview&quot; version. If unspecified, it defaults to the latest Debian version.</summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>The set of components to activate on the cluster.</summary>
    [JsonPropertyName("optionalComponents")]
    public IList<string>? OptionalComponents { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigWorkerConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Disk option config settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigWorkerConfigDiskConfig
{
    /// <summary>Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>Type of the boot disk (default is &quot;pd-standard&quot;). Valid values: &quot;pd-ssd&quot; (Persistent Disk Solid State Drive) or &quot;pd-standard&quot; (Persistent Disk Hard Disk Drive).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

/// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigWorkerConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigWorkerConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * https://www.googleapis.com/compute/beta/projects/ If the URI is unspecified, it will be inferred from SoftwareConfig.image_version or the system default.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/(https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Specifies the minimum cpu platform for the Instance Group. See Minimum CPU platform.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The number of VM instances in the instance group. For master instance groups, must be set to 1.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the instance group. The default value for master and worker groups is NON_PREEMPTIBLE. This default cannot be changed. The default value for secondary instances is PREEMPTIBLE. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary>Required. The cluster configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfig
{
    /// <summary>Autoscaling config for the policy associated with the cluster. Cluster does not autoscale if this field is unset.</summary>
    [JsonPropertyName("autoscalingConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigAutoscalingConfig? AutoscalingConfig { get; set; }

    /// <summary>Encryption settings for the cluster.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>Port/endpoint configuration for this cluster</summary>
    [JsonPropertyName("endpointConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigEndpointConfig? EndpointConfig { get; set; }

    /// <summary>The shared Compute Engine config settings for all instances in a cluster.</summary>
    [JsonPropertyName("gceClusterConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigGceClusterConfig? GceClusterConfig { get; set; }

    /// <summary>Commands to execute on each node after config is completed. By default, executables are run on master and all worker nodes. You can test a node&apos;s role metadata to run an executable on a master or worker node, as shown below using curl (you can also use wget): ROLE=$(curl -H Metadata-Flavor:Google http://metadata/computeMetadata/v1/instance/attributes/dataproc-role) if ; then ... master specific actions ... else ... worker specific actions ... fi</summary>
    [JsonPropertyName("initializationActions")]
    public IList<V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigInitializationActions>? InitializationActions { get; set; }

    /// <summary>Lifecycle setting for the cluster.</summary>
    [JsonPropertyName("lifecycleConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigLifecycleConfig? LifecycleConfig { get; set; }

    /// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("masterConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigMasterConfig? MasterConfig { get; set; }

    /// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("secondaryWorkerConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecondaryWorkerConfig? SecondaryWorkerConfig { get; set; }

    /// <summary>Security settings for the cluster.</summary>
    [JsonPropertyName("securityConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSecurityConfig? SecurityConfig { get; set; }

    /// <summary>The config settings for software inside the cluster.</summary>
    [JsonPropertyName("softwareConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigSoftwareConfig? SoftwareConfig { get; set; }

    /// <summary>A Cloud Storage bucket used to stage job dependencies, config files, and job driver console output. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster&apos;s staging bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket (see Dataproc staging and temp buckets).</summary>
    [JsonPropertyName("stagingBucket")]
    public string? StagingBucket { get; set; }

    /// <summary>A Cloud Storage bucket used to store ephemeral cluster and jobs data, such as Spark and MapReduce history files. If you do not specify a temp bucket, Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster&apos;s temp bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket. The default bucket has a TTL of 90 days, but you can use any TTL (or none) if you specify a bucket.</summary>
    [JsonPropertyName("tempBucket")]
    public string? TempBucket { get; set; }

    /// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("workerConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfigWorkerConfig? WorkerConfig { get; set; }
}

/// <summary>A cluster that is managed by the workflow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacementManagedCluster
{
    /// <summary>Required. The cluster name prefix. A unique cluster name will be formed by appending a random suffix. The name must contain only lower-case letters (a-z), numbers (0-9), and hyphens (-). Must begin with a letter. Cannot begin or end with hyphen. Must consist of between 2 and 35 characters.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Required. The cluster configuration.</summary>
    [JsonPropertyName("config")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedClusterConfig? Config { get; set; }

    /// <summary>The labels to associate with this cluster. Label keys must be between 1 and 63 characters long, and must conform to the following PCRE regular expression: {0,63} No more than 32 labels can be associated with a given cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>Required. WorkflowTemplate scheduling information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecInitProviderPlacement
{
    /// <summary>A selector that chooses target cluster for jobs based on metadata. The selector is evaluated at the time each job is submitted.</summary>
    [JsonPropertyName("clusterSelector")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementClusterSelector? ClusterSelector { get; set; }

    /// <summary>A cluster that is managed by the workflow.</summary>
    [JsonPropertyName("managedCluster")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacementManagedCluster? ManagedCluster { get; set; }
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
public partial class V1beta2WorkflowTemplateSpecInitProvider
{
    /// <summary>(Beta only) Optional. Timeout duration for the DAG of jobs. You can use &quot;s&quot;, &quot;m&quot;, &quot;h&quot;, and &quot;d&quot; suffixes for second, minute, hour, and day duration values, respectively. The timeout duration must be from 10 minutes (&quot;10m&quot;) to 24 hours (&quot;24h&quot; or &quot;1d&quot;). The timer begins when the first job is submitted. If the workflow is running at the end of the timeout period, any remaining jobs are cancelled, the workflow is ended, and if the workflow was running on a (/dataproc/docs/concepts/workflows/using-workflows#configuring_or_selecting_a_cluster), the cluster is deleted.</summary>
    [JsonPropertyName("dagTimeout")]
    public string? DagTimeout { get; set; }

    /// <summary>Encryption settings for the cluster.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta2WorkflowTemplateSpecInitProviderEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>Required. The Directed Acyclic Graph of Jobs to submit.</summary>
    [JsonPropertyName("jobs")]
    public IList<V1beta2WorkflowTemplateSpecInitProviderJobs>? Jobs { get; set; }

    /// <summary>The labels to associate with this cluster. Label keys must be between 1 and 63 characters long, and must conform to the following PCRE regular expression: {0,63} No more than 32 labels can be associated with a given cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Template parameters whose values are substituted into the template. Values for parameters must be provided when the template is instantiated.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta2WorkflowTemplateSpecInitProviderParameters>? Parameters { get; set; }

    /// <summary>Required. WorkflowTemplate scheduling information.</summary>
    [JsonPropertyName("placement")]
    public V1beta2WorkflowTemplateSpecInitProviderPlacement? Placement { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Used to perform a consistent read-modify-write. This field should be left blank for a CreateWorkflowTemplate request. It is required for an UpdateWorkflowTemplate request, and must match the current server version. A typical update template flow would fetch the current template with a GetWorkflowTemplate request, which will return the current template with the version field filled in with the current server version. The user updates other fields in the template, then returns it as part of the UpdateWorkflowTemplate request.</summary>
    [JsonPropertyName("version")]
    public double? Version { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkflowTemplateSpecManagementPoliciesEnum>))]
public enum V1beta2WorkflowTemplateSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkflowTemplateSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2WorkflowTemplateSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkflowTemplateSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2WorkflowTemplateSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkflowTemplateSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkflowTemplateSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkflowTemplateSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>WorkflowTemplateSpec defines the desired state of WorkflowTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateSpec
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
    public V1beta2WorkflowTemplateSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2WorkflowTemplateSpecForProvider ForProvider { get; set; }

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
    public V1beta2WorkflowTemplateSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2WorkflowTemplateSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2WorkflowTemplateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2WorkflowTemplateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Encryption settings for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderEncryptionConfig
{
    /// <summary>The uri of the KMS key used to encrypt various sensitive files.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsHadoopJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>Job is a Hadoop job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsHadoopJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsHadoopJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The name of the driver&apos;s main class. The jar file that contains the class must be in the default CLASSPATH or specified in jar_file_uris.</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The HCFS URI of the jar file that contains the main class.</summary>
    [JsonPropertyName("mainJarFileUri")]
    public string? MainJarFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>A list of queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsHiveJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: &quot;hiveJob&quot;: { &quot;queryList&quot;: { &quot;queries&quot;: } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary>Job is a Hive job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsHiveJob
{
    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsHiveJobQueryList? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&quot;value&quot;;).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsPigJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>A list of queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsPigJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: &quot;hiveJob&quot;: { &quot;queryList&quot;: { &quot;queries&quot;: } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary>Job is a Pig job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsPigJob
{
    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsPigJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsPigJobQueryList? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&quot;value&quot;;).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsPrestoJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>A list of queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsPrestoJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: &quot;hiveJob&quot;: { &quot;queryList&quot;: { &quot;queries&quot;: } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary>Job is a Presto job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsPrestoJob
{
    /// <summary>Presto client tags to attach to this query</summary>
    [JsonPropertyName("clientTags")]
    public IList<string>? ClientTags { get; set; }

    /// <summary>Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries.</summary>
    [JsonPropertyName("continueOnFailure")]
    public bool? ContinueOnFailure { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsPrestoJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The format in which query output will be displayed. See the Presto documentation for supported output formats</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsPrestoJobQueryList? QueryList { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsPysparkJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>Job is a PySpark job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsPysparkJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsPysparkJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Required. The HCFS URI of the main Python file to use as the driver. Must be a .py file.</summary>
    [JsonPropertyName("mainPythonFileUri")]
    public string? MainPythonFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip.</summary>
    [JsonPropertyName("pythonFileUris")]
    public IList<string>? PythonFileUris { get; set; }
}

/// <summary>Job scheduling configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsScheduling
{
    /// <summary>Maximum number of times per hour a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed. A job may be reported as thrashing if driver exits with non-zero code 4 times within 10 minute window. Maximum value is 10.</summary>
    [JsonPropertyName("maxFailuresPerHour")]
    public double? MaxFailuresPerHour { get; set; }

    /// <summary>Maximum number of times in total a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed. Maximum value is 240</summary>
    [JsonPropertyName("maxFailuresTotal")]
    public double? MaxFailuresTotal { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsSparkJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>Job is a Spark job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsSparkJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsSparkJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The name of the driver&apos;s main class. The jar file that contains the class must be in the default CLASSPATH or specified in jar_file_uris.</summary>
    [JsonPropertyName("mainClass")]
    public string? MainClass { get; set; }

    /// <summary>The HCFS URI of the jar file that contains the main class.</summary>
    [JsonPropertyName("mainJarFileUri")]
    public string? MainJarFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsSparkRJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>Job is a SparkR job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsSparkRJob
{
    /// <summary>HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.</summary>
    [JsonPropertyName("archiveUris")]
    public IList<string>? ArchiveUris { get; set; }

    /// <summary>The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.</summary>
    [JsonPropertyName("fileUris")]
    public IList<string>? FileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsSparkRJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>Required. The HCFS URI of the main R file to use as the driver. Must be a .R file.</summary>
    [JsonPropertyName("mainRFileUri")]
    public string? MainRFileUri { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

/// <summary>The runtime log config for job execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsSparkSqlJobLoggingConfig
{
    /// <summary>The per-package log levels for the driver. This may include &quot;root&quot; package name to configure rootLogger. Examples: &apos;com.google = FATAL&apos;, &apos;root = INFO&apos;, &apos;org.apache = DEBUG&apos;</summary>
    [JsonPropertyName("driverLogLevels")]
    public IDictionary<string, string>? DriverLogLevels { get; set; }
}

/// <summary>A list of queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsSparkSqlJobQueryList
{
    /// <summary>Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: &quot;hiveJob&quot;: { &quot;queryList&quot;: { &quot;queries&quot;: } }</summary>
    [JsonPropertyName("queries")]
    public IList<string>? Queries { get; set; }
}

/// <summary>Job is a SparkSql job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobsSparkSqlJob
{
    /// <summary>HCFS URIs of jar files to be added to the Spark CLASSPATH.</summary>
    [JsonPropertyName("jarFileUris")]
    public IList<string>? JarFileUris { get; set; }

    /// <summary>The runtime log config for job execution.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsSparkSqlJobLoggingConfig? LoggingConfig { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HCFS URI of the script that contains SQL queries.</summary>
    [JsonPropertyName("queryFileUri")]
    public string? QueryFileUri { get; set; }

    /// <summary>A list of queries.</summary>
    [JsonPropertyName("queryList")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsSparkSqlJobQueryList? QueryList { get; set; }

    /// <summary>Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&quot;value&quot;;).</summary>
    [JsonPropertyName("scriptVariables")]
    public IDictionary<string, string>? ScriptVariables { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderJobs
{
    /// <summary>Job is a Hadoop job.</summary>
    [JsonPropertyName("hadoopJob")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsHadoopJob? HadoopJob { get; set; }

    /// <summary>Job is a Hive job.</summary>
    [JsonPropertyName("hiveJob")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsHiveJob? HiveJob { get; set; }

    /// <summary>The labels to associate with this job. Label keys must be between 1 and 63 characters long, and must conform to the following regular expression: {0,63} No more than 32 labels can be associated with a given job.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Job is a Pig job.</summary>
    [JsonPropertyName("pigJob")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsPigJob? PigJob { get; set; }

    /// <summary>The optional list of prerequisite job step_ids. If not specified, the job will start at the beginning of workflow.</summary>
    [JsonPropertyName("prerequisiteStepIds")]
    public IList<string>? PrerequisiteStepIds { get; set; }

    /// <summary>Job is a Presto job.</summary>
    [JsonPropertyName("prestoJob")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsPrestoJob? PrestoJob { get; set; }

    /// <summary>Job is a PySpark job.</summary>
    [JsonPropertyName("pysparkJob")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsPysparkJob? PysparkJob { get; set; }

    /// <summary>Job scheduling configuration.</summary>
    [JsonPropertyName("scheduling")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsScheduling? Scheduling { get; set; }

    /// <summary>Job is a Spark job.</summary>
    [JsonPropertyName("sparkJob")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsSparkJob? SparkJob { get; set; }

    /// <summary>Job is a SparkR job.</summary>
    [JsonPropertyName("sparkRJob")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsSparkRJob? SparkRJob { get; set; }

    /// <summary>Job is a SparkSql job.</summary>
    [JsonPropertyName("sparkSqlJob")]
    public V1beta2WorkflowTemplateStatusAtProviderJobsSparkSqlJob? SparkSqlJob { get; set; }

    /// <summary>Required. The step id. The id must be unique among all jobs within the template. The step id is used as prefix for job id, as job goog-dataproc-workflow-step-id label, and in field from other steps. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between 3 and 50 characters.</summary>
    [JsonPropertyName("stepId")]
    public string? StepId { get; set; }
}

/// <summary>Validation based on regular expressions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderParametersValidationRegex
{
    /// <summary>Required. RE2 regular expressions used to validate the parameter&apos;s value. The value must match the regex in its entirety (substring matches are not sufficient).</summary>
    [JsonPropertyName("regexes")]
    public IList<string>? Regexes { get; set; }
}

/// <summary>Required. List of allowed values for the parameter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderParametersValidationValues
{
    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Validation rules to be applied to this parameter&apos;s value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderParametersValidation
{
    /// <summary>Validation based on regular expressions.</summary>
    [JsonPropertyName("regex")]
    public V1beta2WorkflowTemplateStatusAtProviderParametersValidationRegex? Regex { get; set; }

    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public V1beta2WorkflowTemplateStatusAtProviderParametersValidationValues? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderParameters
{
    /// <summary>Brief description of the parameter. Must not exceed 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Paths to all fields that the parameter replaces. A field is allowed to appear in at most one parameter&apos;s list of field paths. A field path is similar in syntax to a .sparkJob.args</summary>
    [JsonPropertyName("fields")]
    public IList<string>? Fields { get; set; }

    /// <summary>Required. Parameter name. The parameter name is used as the key, and paired with the parameter value, which are passed to the template when the template is instantiated. The name must contain only capital letters (A-Z), numbers (0-9), and underscores (_), and must not start with a number. The maximum length is 40 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Validation rules to be applied to this parameter&apos;s value.</summary>
    [JsonPropertyName("validation")]
    public V1beta2WorkflowTemplateStatusAtProviderParametersValidation? Validation { get; set; }
}

/// <summary>A selector that chooses target cluster for jobs based on metadata. The selector is evaluated at the time each job is submitted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementClusterSelector
{
    /// <summary>Required. The cluster labels. Cluster must have all labels to match.</summary>
    [JsonPropertyName("clusterLabels")]
    public IDictionary<string, string>? ClusterLabels { get; set; }

    /// <summary>The zone where the Compute Engine cluster will be located. On a create request, it is required in the &quot;global&quot; region. If omitted in a non-global Dataproc region, the service will pick a zone in the corresponding Compute Engine region. On a get request, zone will always be present. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/ * us-central1-f</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>Autoscaling config for the policy associated with the cluster. Cluster does not autoscale if this field is unset.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigAutoscalingConfig
{
    /// <summary>The autoscaling policy used by the cluster. Only resource names including projectid and location (region) are valid. Examples: * https://www.googleapis.com/compute/v1/projects/ Note that the policy must be in the same project and Dataproc region.</summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }
}

/// <summary>Encryption settings for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigEncryptionConfig
{
    /// <summary>The Cloud KMS key name to use for PD disk encryption for all instances in the cluster.</summary>
    [JsonPropertyName("gcePdKmsKeyName")]
    public string? GcePdKmsKeyName { get; set; }
}

/// <summary>Port/endpoint configuration for this cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigEndpointConfig
{
    /// <summary>If true, enable http access to specific ports on the cluster from external sources. Defaults to false.</summary>
    [JsonPropertyName("enableHttpPortAccess")]
    public bool? EnableHttpPortAccess { get; set; }

    /// <summary>Output only. The map of port descriptions to URLs. Will only be populated if enable_http_port_access is true.</summary>
    [JsonPropertyName("httpPorts")]
    public IDictionary<string, string>? HttpPorts { get; set; }
}

/// <summary>Node Group Affinity for sole-tenant clusters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigGceClusterConfigNodeGroupAffinity
{
    /// <summary>Required. The URI of a sole-tenant /zones/us-central1-a/nodeGroups/node-group-1*node-group-1`</summary>
    [JsonPropertyName("nodeGroup")]
    public string? NodeGroup { get; set; }
}

/// <summary>Reservation Affinity for consuming Zonal reservation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigGceClusterConfigReservationAffinity
{
    /// <summary>Type of reservation to consume Possible values: TYPE_UNSPECIFIED, NO_RESERVATION, ANY_RESERVATION, SPECIFIC_RESERVATION</summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>Corresponds to the label key of reservation resource.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Required. List of allowed values for the parameter.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Shielded Instance Config for clusters using Compute Engine Shielded VMs. Structure defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigGceClusterConfigShieldedInstanceConfig
{
    /// <summary>Defines whether instances have Integrity Monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines whether instances have Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>Defines whether instances have the vTPM enabled.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

/// <summary>The shared Compute Engine config settings for all instances in a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigGceClusterConfig
{
    /// <summary>If true, all instances in the cluster will only have internal IP addresses. By default, clusters are not restricted to internal IP addresses, and will have ephemeral external IP addresses assigned to each instance. This internal_ip_only restriction can only be enabled for subnetwork enabled networks, and all off-cluster dependencies must be configured to be accessible without external IP addresses.</summary>
    [JsonPropertyName("internalIpOnly")]
    public bool? InternalIpOnly { get; set; }

    /// <summary>The Compute Engine metadata entries to add to all instances (see About VM metadata).</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The Compute Engine network to be used for machine communications. Cannot be specified with subnetwork_uri. If neither network_uri nor subnetwork_uri is specified, the &quot;default&quot; network of the project is used, if it exists. Cannot be a &quot;Custom Subnet Network&quot; (see /regions/global/default*default`</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Node Group Affinity for sole-tenant clusters.</summary>
    [JsonPropertyName("nodeGroupAffinity")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigGceClusterConfigNodeGroupAffinity? NodeGroupAffinity { get; set; }

    /// <summary>The type of IPv6 access for a cluster. Possible values: PRIVATE_IPV6_GOOGLE_ACCESS_UNSPECIFIED, INHERIT_FROM_SUBNETWORK, OUTBOUND, BIDIRECTIONAL</summary>
    [JsonPropertyName("privateIpv6GoogleAccess")]
    public string? PrivateIpv6GoogleAccess { get; set; }

    /// <summary>Reservation Affinity for consuming Zonal reservation.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigGceClusterConfigReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>The (https://cloud.google.com/compute/docs/access/service-accounts#default_service_account) is used.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>The URIs of service account scopes to be included in Compute Engine instances. The following base set of scopes is always included: * https://www.googleapis.com/auth/cloud.useraccounts.readonly * https://www.googleapis.com/auth/devstorage.read_write * https://www.googleapis.com/auth/logging.write If no scopes are specified, the following defaults are also provided: * https://www.googleapis.com/auth/bigquery * https://www.googleapis.com/auth/bigtable.admin.table * https://www.googleapis.com/auth/bigtable.data * https://www.googleapis.com/auth/devstorage.full_control</summary>
    [JsonPropertyName("serviceAccountScopes")]
    public IList<string>? ServiceAccountScopes { get; set; }

    /// <summary>Shielded Instance Config for clusters using Compute Engine Shielded VMs. Structure defined below.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigGceClusterConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>The Compute Engine subnetwork to be used for machine communications. Cannot be specified with network_uri. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects//regions/us-east1/subnetworks/sub0 * sub0</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>The Compute Engine tags to add to all instances (see Manage tags for resources).</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The zone where the Compute Engine cluster will be located. On a create request, it is required in the &quot;global&quot; region. If omitted in a non-global Dataproc region, the service will pick a zone in the corresponding Compute Engine region. On a get request, zone will always be present. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/ * us-central1-f</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigInitializationActions
{
    /// <summary>Required. Cloud Storage URI of executable file.</summary>
    [JsonPropertyName("executableFile")]
    public string? ExecutableFile { get; set; }

    /// <summary>Amount of time executable has to complete. Default is 10 minutes (see JSON representation of JSON Mapping - Language Guide (proto 3)). Cluster creation fails with an explanatory error message (the name of the executable that caused the error and the exceeded timeout period) if the executable is not completed at end of the timeout period.</summary>
    [JsonPropertyName("executionTimeout")]
    public string? ExecutionTimeout { get; set; }
}

/// <summary>Lifecycle setting for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigLifecycleConfig
{
    /// <summary>The time when cluster will be auto-deleted (see JSON representation of JSON Mapping - Language Guide (proto 3)).</summary>
    [JsonPropertyName("autoDeleteTime")]
    public string? AutoDeleteTime { get; set; }

    /// <summary>The lifetime duration of cluster. The cluster will be auto-deleted at the end of this period. Minimum value is 10 minutes; maximum value is 14 days (see JSON representation of JSON Mapping - Language Guide (proto 3)).</summary>
    [JsonPropertyName("autoDeleteTtl")]
    public string? AutoDeleteTtl { get; set; }

    /// <summary>The duration to keep the cluster alive while idling (when no jobs are running). Passing this threshold will cause the cluster to be deleted. Minimum value is 5 minutes; maximum value is 14 days (see JSON representation of JSON Mapping - Language Guide (proto 3).</summary>
    [JsonPropertyName("idleDeleteTtl")]
    public string? IdleDeleteTtl { get; set; }

    /// <summary>Output only. The time when cluster became idle (most recent job finished) and became eligible for deletion due to idleness (see JSON representation of JSON Mapping - Language Guide (proto 3)).</summary>
    [JsonPropertyName("idleStartTime")]
    public string? IdleStartTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigMasterConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Disk option config settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigMasterConfigDiskConfig
{
    /// <summary>Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>Type of the boot disk (default is &quot;pd-standard&quot;). Valid values: &quot;pd-ssd&quot; (Persistent Disk Solid State Drive) or &quot;pd-standard&quot; (Persistent Disk Hard Disk Drive).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigMasterConfigManagedGroupConfig
{
    /// <summary>Output only. The resource name of the workflow template, as described in https://cloud.google.com/apis/design/resource_names. * For projects.regions.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} * For projects.locations.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}</summary>
    [JsonPropertyName("instanceGroupManagerName")]
    public string? InstanceGroupManagerName { get; set; }

    /// <summary>Output only. The resource name of the workflow template, as described in https://cloud.google.com/apis/design/resource_names. * For projects.regions.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} * For projects.locations.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}</summary>
    [JsonPropertyName("instanceTemplateName")]
    public string? InstanceTemplateName { get; set; }
}

/// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigMasterConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigMasterConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigMasterConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * https://www.googleapis.com/compute/beta/projects/ If the URI is unspecified, it will be inferred from SoftwareConfig.image_version or the system default.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Output only. The list of instance names. Dataproc derives the names from cluster_name, num_instances, and the instance group.</summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>Output only. Specifies that this instance group contains preemptible instances.</summary>
    [JsonPropertyName("isPreemptible")]
    public bool? IsPreemptible { get; set; }

    /// <summary>The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/(https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Output only. The config for Compute Engine Instance Group Manager that manages this group. This is only used for preemptible instance groups.</summary>
    [JsonPropertyName("managedGroupConfig")]
    public IList<V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigMasterConfigManagedGroupConfig>? ManagedGroupConfig { get; set; }

    /// <summary>Specifies the minimum cpu platform for the Instance Group. See Minimum CPU platform.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The number of VM instances in the instance group. For master instance groups, must be set to 1.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the instance group. The default value for master and worker groups is NON_PREEMPTIBLE. This default cannot be changed. The default value for secondary instances is PREEMPTIBLE. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecondaryWorkerConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Disk option config settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecondaryWorkerConfigDiskConfig
{
    /// <summary>Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>Type of the boot disk (default is &quot;pd-standard&quot;). Valid values: &quot;pd-ssd&quot; (Persistent Disk Solid State Drive) or &quot;pd-standard&quot; (Persistent Disk Hard Disk Drive).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecondaryWorkerConfigManagedGroupConfig
{
    /// <summary>Output only. The resource name of the workflow template, as described in https://cloud.google.com/apis/design/resource_names. * For projects.regions.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} * For projects.locations.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}</summary>
    [JsonPropertyName("instanceGroupManagerName")]
    public string? InstanceGroupManagerName { get; set; }

    /// <summary>Output only. The resource name of the workflow template, as described in https://cloud.google.com/apis/design/resource_names. * For projects.regions.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} * For projects.locations.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}</summary>
    [JsonPropertyName("instanceTemplateName")]
    public string? InstanceTemplateName { get; set; }
}

/// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecondaryWorkerConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecondaryWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecondaryWorkerConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * https://www.googleapis.com/compute/beta/projects/ If the URI is unspecified, it will be inferred from SoftwareConfig.image_version or the system default.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Output only. The list of instance names. Dataproc derives the names from cluster_name, num_instances, and the instance group.</summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>Output only. Specifies that this instance group contains preemptible instances.</summary>
    [JsonPropertyName("isPreemptible")]
    public bool? IsPreemptible { get; set; }

    /// <summary>The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/(https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Output only. The config for Compute Engine Instance Group Manager that manages this group. This is only used for preemptible instance groups.</summary>
    [JsonPropertyName("managedGroupConfig")]
    public IList<V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecondaryWorkerConfigManagedGroupConfig>? ManagedGroupConfig { get; set; }

    /// <summary>Specifies the minimum cpu platform for the Instance Group. See Minimum CPU platform.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The number of VM instances in the instance group. For master instance groups, must be set to 1.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the instance group. The default value for master and worker groups is NON_PREEMPTIBLE. This default cannot be changed. The default value for secondary instances is PREEMPTIBLE. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary>Kerberos related configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecurityConfigKerberosConfig
{
    /// <summary>The admin server (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustAdminServer")]
    public string? CrossRealmTrustAdminServer { get; set; }

    /// <summary>The KDC (IP or hostname) for the remote trusted realm in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustKdc")]
    public string? CrossRealmTrustKdc { get; set; }

    /// <summary>The remote realm the Dataproc on-cluster KDC will trust, should the user enable cross realm trust.</summary>
    [JsonPropertyName("crossRealmTrustRealm")]
    public string? CrossRealmTrustRealm { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the shared password between the on-cluster Kerberos realm and the remote trusted realm, in a cross realm trust relationship.</summary>
    [JsonPropertyName("crossRealmTrustSharedPassword")]
    public string? CrossRealmTrustSharedPassword { get; set; }

    /// <summary>Flag to indicate whether to Kerberize the cluster (default: false). Set this field to true to enable Kerberos on a cluster.</summary>
    [JsonPropertyName("enableKerberos")]
    public bool? EnableKerberos { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the master key of the KDC database.</summary>
    [JsonPropertyName("kdcDbKey")]
    public string? KdcDbKey { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided key. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("keyPassword")]
    public string? KeyPassword { get; set; }

    /// <summary>The Cloud Storage URI of the keystore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("keystore")]
    public string? Keystore { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided keystore. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("keystorePassword")]
    public string? KeystorePassword { get; set; }

    /// <summary>The uri of the KMS key used to encrypt various sensitive files.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>The name of the on-cluster Kerberos realm. If not specified, the uppercased domain of hostnames will be the realm.</summary>
    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the root principal password.</summary>
    [JsonPropertyName("rootPrincipalPassword")]
    public string? RootPrincipalPassword { get; set; }

    /// <summary>The lifetime of the ticket granting ticket, in hours. If not specified, or user specifies 0, then default value 10 will be used.</summary>
    [JsonPropertyName("tgtLifetimeHours")]
    public double? TgtLifetimeHours { get; set; }

    /// <summary>The Cloud Storage URI of the truststore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.</summary>
    [JsonPropertyName("truststore")]
    public string? Truststore { get; set; }

    /// <summary>The Cloud Storage URI of a KMS encrypted file containing the password to the user provided truststore. For the self-signed certificate, this password is generated by Dataproc.</summary>
    [JsonPropertyName("truststorePassword")]
    public string? TruststorePassword { get; set; }
}

/// <summary>Security settings for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecurityConfig
{
    /// <summary>Kerberos related configuration.</summary>
    [JsonPropertyName("kerberosConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecurityConfigKerberosConfig? KerberosConfig { get; set; }
}

/// <summary>The config settings for software inside the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSoftwareConfig
{
    /// <summary>The version of software inside the cluster. It must be one of the supported Dataproc Versions, such as &quot;1.2&quot; (including a subminor version, such as &quot;1.2.29&quot;), or the &quot;preview&quot; version. If unspecified, it defaults to the latest Debian version.</summary>
    [JsonPropertyName("imageVersion")]
    public string? ImageVersion { get; set; }

    /// <summary>The set of components to activate on the cluster.</summary>
    [JsonPropertyName("optionalComponents")]
    public IList<string>? OptionalComponents { get; set; }

    /// <summary>A mapping of property names to values, used to configure Spark SQL&apos;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigWorkerConfigAccelerators
{
    /// <summary>The number of the accelerator cards of this type exposed to this instance.</summary>
    [JsonPropertyName("acceleratorCount")]
    public double? AcceleratorCount { get; set; }

    /// <summary>Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See (https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, nvidia-tesla-k80.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }
}

/// <summary>Disk option config settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigWorkerConfigDiskConfig
{
    /// <summary>Size in GB of the boot disk (default is 500GB).</summary>
    [JsonPropertyName("bootDiskSizeGb")]
    public double? BootDiskSizeGb { get; set; }

    /// <summary>Type of the boot disk (default is &quot;pd-standard&quot;). Valid values: &quot;pd-ssd&quot; (Persistent Disk Solid State Drive) or &quot;pd-standard&quot; (Persistent Disk Hard Disk Drive).</summary>
    [JsonPropertyName("bootDiskType")]
    public string? BootDiskType { get; set; }

    /// <summary>Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and (https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.</summary>
    [JsonPropertyName("numLocalSsds")]
    public double? NumLocalSsds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigWorkerConfigManagedGroupConfig
{
    /// <summary>Output only. The resource name of the workflow template, as described in https://cloud.google.com/apis/design/resource_names. * For projects.regions.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} * For projects.locations.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}</summary>
    [JsonPropertyName("instanceGroupManagerName")]
    public string? InstanceGroupManagerName { get; set; }

    /// <summary>Output only. The resource name of the workflow template, as described in https://cloud.google.com/apis/design/resource_names. * For projects.regions.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/regions/{region}/workflowTemplates/{template_id} * For projects.locations.workflowTemplates, the resource name of the template has the following format: projects/{project_id}/locations/{location}/workflowTemplates/{template_id}</summary>
    [JsonPropertyName("instanceTemplateName")]
    public string? InstanceTemplateName { get; set; }
}

/// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigWorkerConfig
{
    /// <summary>The Compute Engine accelerator configuration for these instances.</summary>
    [JsonPropertyName("accelerators")]
    public IList<V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigWorkerConfigAccelerators>? Accelerators { get; set; }

    /// <summary>Disk option config settings.</summary>
    [JsonPropertyName("diskConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigWorkerConfigDiskConfig? DiskConfig { get; set; }

    /// <summary>The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * https://www.googleapis.com/compute/beta/projects/ If the URI is unspecified, it will be inferred from SoftwareConfig.image_version or the system default.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Output only. The list of instance names. Dataproc derives the names from cluster_name, num_instances, and the instance group.</summary>
    [JsonPropertyName("instanceNames")]
    public IList<string>? InstanceNames { get; set; }

    /// <summary>Output only. Specifies that this instance group contains preemptible instances.</summary>
    [JsonPropertyName("isPreemptible")]
    public bool? IsPreemptible { get; set; }

    /// <summary>The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * https://www.googleapis.com/compute/v1/projects/(https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, n1-standard-2`.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Output only. The config for Compute Engine Instance Group Manager that manages this group. This is only used for preemptible instance groups.</summary>
    [JsonPropertyName("managedGroupConfig")]
    public IList<V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigWorkerConfigManagedGroupConfig>? ManagedGroupConfig { get; set; }

    /// <summary>Specifies the minimum cpu platform for the Instance Group. See Minimum CPU platform.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The number of VM instances in the instance group. For master instance groups, must be set to 1.</summary>
    [JsonPropertyName("numInstances")]
    public double? NumInstances { get; set; }

    /// <summary>Specifies the preemptibility of the instance group. The default value for master and worker groups is NON_PREEMPTIBLE. This default cannot be changed. The default value for secondary instances is PREEMPTIBLE. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE</summary>
    [JsonPropertyName("preemptibility")]
    public string? Preemptibility { get; set; }
}

/// <summary>Required. The cluster configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfig
{
    /// <summary>Autoscaling config for the policy associated with the cluster. Cluster does not autoscale if this field is unset.</summary>
    [JsonPropertyName("autoscalingConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigAutoscalingConfig? AutoscalingConfig { get; set; }

    /// <summary>Encryption settings for the cluster.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>Port/endpoint configuration for this cluster</summary>
    [JsonPropertyName("endpointConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigEndpointConfig? EndpointConfig { get; set; }

    /// <summary>The shared Compute Engine config settings for all instances in a cluster.</summary>
    [JsonPropertyName("gceClusterConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigGceClusterConfig? GceClusterConfig { get; set; }

    /// <summary>Commands to execute on each node after config is completed. By default, executables are run on master and all worker nodes. You can test a node&apos;s role metadata to run an executable on a master or worker node, as shown below using curl (you can also use wget): ROLE=$(curl -H Metadata-Flavor:Google http://metadata/computeMetadata/v1/instance/attributes/dataproc-role) if ; then ... master specific actions ... else ... worker specific actions ... fi</summary>
    [JsonPropertyName("initializationActions")]
    public IList<V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigInitializationActions>? InitializationActions { get; set; }

    /// <summary>Lifecycle setting for the cluster.</summary>
    [JsonPropertyName("lifecycleConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigLifecycleConfig? LifecycleConfig { get; set; }

    /// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("masterConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigMasterConfig? MasterConfig { get; set; }

    /// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("secondaryWorkerConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecondaryWorkerConfig? SecondaryWorkerConfig { get; set; }

    /// <summary>Security settings for the cluster.</summary>
    [JsonPropertyName("securityConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSecurityConfig? SecurityConfig { get; set; }

    /// <summary>The config settings for software inside the cluster.</summary>
    [JsonPropertyName("softwareConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigSoftwareConfig? SoftwareConfig { get; set; }

    /// <summary>A Cloud Storage bucket used to stage job dependencies, config files, and job driver console output. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster&apos;s staging bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket (see Dataproc staging and temp buckets).</summary>
    [JsonPropertyName("stagingBucket")]
    public string? StagingBucket { get; set; }

    /// <summary>A Cloud Storage bucket used to store ephemeral cluster and jobs data, such as Spark and MapReduce history files. If you do not specify a temp bucket, Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster&apos;s temp bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket. The default bucket has a TTL of 90 days, but you can use any TTL (or none) if you specify a bucket.</summary>
    [JsonPropertyName("tempBucket")]
    public string? TempBucket { get; set; }

    /// <summary>The Compute Engine config settings for additional worker instances in a cluster.</summary>
    [JsonPropertyName("workerConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfigWorkerConfig? WorkerConfig { get; set; }
}

/// <summary>A cluster that is managed by the workflow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacementManagedCluster
{
    /// <summary>Required. The cluster name prefix. A unique cluster name will be formed by appending a random suffix. The name must contain only lower-case letters (a-z), numbers (0-9), and hyphens (-). Must begin with a letter. Cannot begin or end with hyphen. Must consist of between 2 and 35 characters.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Required. The cluster configuration.</summary>
    [JsonPropertyName("config")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedClusterConfig? Config { get; set; }

    /// <summary>The labels to associate with this cluster. Label keys must be between 1 and 63 characters long, and must conform to the following PCRE regular expression: {0,63} No more than 32 labels can be associated with a given cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>Required. WorkflowTemplate scheduling information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProviderPlacement
{
    /// <summary>A selector that chooses target cluster for jobs based on metadata. The selector is evaluated at the time each job is submitted.</summary>
    [JsonPropertyName("clusterSelector")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementClusterSelector? ClusterSelector { get; set; }

    /// <summary>A cluster that is managed by the workflow.</summary>
    [JsonPropertyName("managedCluster")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacementManagedCluster? ManagedCluster { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusAtProvider
{
    /// <summary>Output only. The time template was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>(Beta only) Optional. Timeout duration for the DAG of jobs. You can use &quot;s&quot;, &quot;m&quot;, &quot;h&quot;, and &quot;d&quot; suffixes for second, minute, hour, and day duration values, respectively. The timeout duration must be from 10 minutes (&quot;10m&quot;) to 24 hours (&quot;24h&quot; or &quot;1d&quot;). The timer begins when the first job is submitted. If the workflow is running at the end of the timeout period, any remaining jobs are cancelled, the workflow is ended, and if the workflow was running on a (/dataproc/docs/concepts/workflows/using-workflows#configuring_or_selecting_a_cluster), the cluster is deleted.</summary>
    [JsonPropertyName("dagTimeout")]
    public string? DagTimeout { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Encryption settings for the cluster.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1beta2WorkflowTemplateStatusAtProviderEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/workflowTemplates/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Required. The Directed Acyclic Graph of Jobs to submit.</summary>
    [JsonPropertyName("jobs")]
    public IList<V1beta2WorkflowTemplateStatusAtProviderJobs>? Jobs { get; set; }

    /// <summary>The labels to associate with this cluster. Label keys must be between 1 and 63 characters long, and must conform to the following PCRE regular expression: {0,63} No more than 32 labels can be associated with a given cluster.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Template parameters whose values are substituted into the template. Values for parameters must be provided when the template is instantiated.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta2WorkflowTemplateStatusAtProviderParameters>? Parameters { get; set; }

    /// <summary>Required. WorkflowTemplate scheduling information.</summary>
    [JsonPropertyName("placement")]
    public V1beta2WorkflowTemplateStatusAtProviderPlacement? Placement { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Output only. The time template was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Used to perform a consistent read-modify-write. This field should be left blank for a CreateWorkflowTemplate request. It is required for an UpdateWorkflowTemplate request, and must match the current server version. A typical update template flow would fetch the current template with a GetWorkflowTemplate request, which will return the current template with the version field filled in with the current server version. The user updates other fields in the template, then returns it as part of the UpdateWorkflowTemplate request.</summary>
    [JsonPropertyName("version")]
    public double? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatusConditions
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

/// <summary>WorkflowTemplateStatus defines the observed state of WorkflowTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkflowTemplateStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2WorkflowTemplateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2WorkflowTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>WorkflowTemplate is the Schema for the WorkflowTemplates API. A Workflow Template is a reusable workflow configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2WorkflowTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2WorkflowTemplateSpec>, IStatus<V1beta2WorkflowTemplateStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "WorkflowTemplate";
    public const string KubeGroup = "dataproc.gcp.upbound.io";
    public const string KubePluralName = "workflowtemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataproc.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkflowTemplate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkflowTemplateSpec defines the desired state of WorkflowTemplate</summary>
    [JsonPropertyName("spec")]
    public required V1beta2WorkflowTemplateSpec Spec { get; set; }

    /// <summary>WorkflowTemplateStatus defines the observed state of WorkflowTemplate.</summary>
    [JsonPropertyName("status")]
    public V1beta2WorkflowTemplateStatus? Status { get; set; }
}
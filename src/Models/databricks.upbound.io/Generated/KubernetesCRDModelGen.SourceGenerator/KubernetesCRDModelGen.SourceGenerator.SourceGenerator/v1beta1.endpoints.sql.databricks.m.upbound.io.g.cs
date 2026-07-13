#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.databricks.m.upbound.io;
/// <summary>Endpoint is the Schema for the Endpoints API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EndpointList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Endpoint>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EndpointList";
    public const string KubeGroup = "sql.databricks.m.upbound.io";
    public const string KubePluralName = "endpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.databricks.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Endpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Endpoint> Items { get; set; }
}

/// <summary>block, consisting of following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderChannel
{
    [JsonPropertyName("dbsqlVersion")]
    public string? DbsqlVersion { get; set; }

    /// <summary>Name of the Databricks SQL release channel. Possible values are: CHANNEL_NAME_PREVIEW and CHANNEL_NAME_CURRENT. Default is CHANNEL_NAME_CURRENT.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderTagsCustomTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Databricks tags all endpoint resources with these tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderTags
{
    /// <summary>Databricks tags all endpoint resources with these tags.</summary>
    [JsonPropertyName("customTags")]
    public IList<V1beta1EndpointSpecForProviderTagsCustomTags>? CustomTags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProvider
{
    /// <summary>Time in minutes until an idle SQL warehouse terminates all clusters and stops. This field is optional. The default is 120, set to 0 to disable the auto stop.</summary>
    [JsonPropertyName("autoStopMins")]
    public double? AutoStopMins { get; set; }

    /// <summary>block, consisting of following fields:</summary>
    [JsonPropertyName("channel")]
    public V1beta1EndpointSpecForProviderChannel? Channel { get; set; }

    /// <summary>The size of the clusters allocated to the endpoint: &quot;2X-Small&quot;, &quot;X-Small&quot;, &quot;Small&quot;, &quot;Medium&quot;, &quot;Large&quot;, &quot;X-Large&quot;, &quot;2X-Large&quot;, &quot;3X-Large&quot;, &quot;4X-Large&quot;.</summary>
    [JsonPropertyName("clusterSize")]
    public string? ClusterSize { get; set; }

    /// <summary>ID of the data source for this endpoint. This is used to bind an Databricks SQL query to an endpoint.</summary>
    [JsonPropertyName("dataSourceId")]
    public string? DataSourceId { get; set; }

    /// <summary>Whether to enable Photon. This field is optional and is enabled by default.</summary>
    [JsonPropertyName("enablePhoton")]
    public bool? EnablePhoton { get; set; }

    /// <summary>Whether this SQL warehouse is a serverless endpoint. See below for details about the default values. To avoid ambiguity, especially for organizations with many workspaces, Databricks recommends that you always set this field explicitly.</summary>
    [JsonPropertyName("enableServerlessCompute")]
    public bool? EnableServerlessCompute { get; set; }

    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>Maximum number of clusters available when a SQL warehouse is running. This field is required. If multi-cluster load balancing is not enabled, this is default to 1.</summary>
    [JsonPropertyName("maxNumClusters")]
    public double? MaxNumClusters { get; set; }

    /// <summary>Minimum number of clusters available when a SQL warehouse is running. The default is 1.</summary>
    [JsonPropertyName("minNumClusters")]
    public double? MinNumClusters { get; set; }

    /// <summary>Name of the SQL warehouse. Must be unique.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The spot policy to use for allocating instances to clusters: COST_OPTIMIZED or RELIABILITY_OPTIMIZED. This field is optional. Default is COST_OPTIMIZED.</summary>
    [JsonPropertyName("spotInstancePolicy")]
    public string? SpotInstancePolicy { get; set; }

    /// <summary>Databricks tags all endpoint resources with these tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1EndpointSpecForProviderTags? Tags { get; set; }

    /// <summary>SQL warehouse type. See for AWS or Azure. Set to PRO or CLASSIC. If the field enable_serverless_compute has the value true either explicitly or through the default logic (see that field above for details), the default is PRO, which is required for serverless SQL warehouses. Otherwise, the default is CLASSIC.</summary>
    [JsonPropertyName("warehouseType")]
    public string? WarehouseType { get; set; }
}

/// <summary>block, consisting of following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderChannel
{
    [JsonPropertyName("dbsqlVersion")]
    public string? DbsqlVersion { get; set; }

    /// <summary>Name of the Databricks SQL release channel. Possible values are: CHANNEL_NAME_PREVIEW and CHANNEL_NAME_CURRENT. Default is CHANNEL_NAME_CURRENT.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderTagsCustomTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Databricks tags all endpoint resources with these tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderTags
{
    /// <summary>Databricks tags all endpoint resources with these tags.</summary>
    [JsonPropertyName("customTags")]
    public IList<V1beta1EndpointSpecInitProviderTagsCustomTags>? CustomTags { get; set; }
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
public partial class V1beta1EndpointSpecInitProvider
{
    /// <summary>Time in minutes until an idle SQL warehouse terminates all clusters and stops. This field is optional. The default is 120, set to 0 to disable the auto stop.</summary>
    [JsonPropertyName("autoStopMins")]
    public double? AutoStopMins { get; set; }

    /// <summary>block, consisting of following fields:</summary>
    [JsonPropertyName("channel")]
    public V1beta1EndpointSpecInitProviderChannel? Channel { get; set; }

    /// <summary>The size of the clusters allocated to the endpoint: &quot;2X-Small&quot;, &quot;X-Small&quot;, &quot;Small&quot;, &quot;Medium&quot;, &quot;Large&quot;, &quot;X-Large&quot;, &quot;2X-Large&quot;, &quot;3X-Large&quot;, &quot;4X-Large&quot;.</summary>
    [JsonPropertyName("clusterSize")]
    public string? ClusterSize { get; set; }

    /// <summary>ID of the data source for this endpoint. This is used to bind an Databricks SQL query to an endpoint.</summary>
    [JsonPropertyName("dataSourceId")]
    public string? DataSourceId { get; set; }

    /// <summary>Whether to enable Photon. This field is optional and is enabled by default.</summary>
    [JsonPropertyName("enablePhoton")]
    public bool? EnablePhoton { get; set; }

    /// <summary>Whether this SQL warehouse is a serverless endpoint. See below for details about the default values. To avoid ambiguity, especially for organizations with many workspaces, Databricks recommends that you always set this field explicitly.</summary>
    [JsonPropertyName("enableServerlessCompute")]
    public bool? EnableServerlessCompute { get; set; }

    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>Maximum number of clusters available when a SQL warehouse is running. This field is required. If multi-cluster load balancing is not enabled, this is default to 1.</summary>
    [JsonPropertyName("maxNumClusters")]
    public double? MaxNumClusters { get; set; }

    /// <summary>Minimum number of clusters available when a SQL warehouse is running. The default is 1.</summary>
    [JsonPropertyName("minNumClusters")]
    public double? MinNumClusters { get; set; }

    /// <summary>Name of the SQL warehouse. Must be unique.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The spot policy to use for allocating instances to clusters: COST_OPTIMIZED or RELIABILITY_OPTIMIZED. This field is optional. Default is COST_OPTIMIZED.</summary>
    [JsonPropertyName("spotInstancePolicy")]
    public string? SpotInstancePolicy { get; set; }

    /// <summary>Databricks tags all endpoint resources with these tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1EndpointSpecInitProviderTags? Tags { get; set; }

    /// <summary>SQL warehouse type. See for AWS or Azure. Set to PRO or CLASSIC. If the field enable_serverless_compute has the value true either explicitly or through the default logic (see that field above for details), the default is PRO, which is required for serverless SQL warehouses. Otherwise, the default is CLASSIC.</summary>
    [JsonPropertyName("warehouseType")]
    public string? WarehouseType { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointSpecManagementPoliciesEnum>))]
public enum V1beta1EndpointSpecManagementPoliciesEnum
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
public partial class V1beta1EndpointSpecProviderConfigRef
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
public partial class V1beta1EndpointSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>EndpointSpec defines the desired state of Endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1EndpointSpecForProvider ForProvider { get; set; }

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
    public V1beta1EndpointSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1EndpointSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EndpointSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EndpointSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>block, consisting of following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatusAtProviderChannel
{
    [JsonPropertyName("dbsqlVersion")]
    public string? DbsqlVersion { get; set; }

    /// <summary>Name of the Databricks SQL release channel. Possible values are: CHANNEL_NAME_PREVIEW and CHANNEL_NAME_CURRENT. Default is CHANNEL_NAME_CURRENT.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatusAtProviderHealthFailureReason
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatusAtProviderHealth
{
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    [JsonPropertyName("failureReason")]
    public IList<V1beta1EndpointStatusAtProviderHealthFailureReason>? FailureReason { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("summary")]
    public string? Summary { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatusAtProviderOdbcParams
{
    /// <summary>Name of the SQL warehouse. Must be unique.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public double? Port { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatusAtProviderTagsCustomTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Databricks tags all endpoint resources with these tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatusAtProviderTags
{
    /// <summary>Databricks tags all endpoint resources with these tags.</summary>
    [JsonPropertyName("customTags")]
    public IList<V1beta1EndpointStatusAtProviderTagsCustomTags>? CustomTags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatusAtProvider
{
    /// <summary>Time in minutes until an idle SQL warehouse terminates all clusters and stops. This field is optional. The default is 120, set to 0 to disable the auto stop.</summary>
    [JsonPropertyName("autoStopMins")]
    public double? AutoStopMins { get; set; }

    /// <summary>block, consisting of following fields:</summary>
    [JsonPropertyName("channel")]
    public V1beta1EndpointStatusAtProviderChannel? Channel { get; set; }

    /// <summary>The size of the clusters allocated to the endpoint: &quot;2X-Small&quot;, &quot;X-Small&quot;, &quot;Small&quot;, &quot;Medium&quot;, &quot;Large&quot;, &quot;X-Large&quot;, &quot;2X-Large&quot;, &quot;3X-Large&quot;, &quot;4X-Large&quot;.</summary>
    [JsonPropertyName("clusterSize")]
    public string? ClusterSize { get; set; }

    /// <summary>The username of the user who created the endpoint.</summary>
    [JsonPropertyName("creatorName")]
    public string? CreatorName { get; set; }

    /// <summary>ID of the data source for this endpoint. This is used to bind an Databricks SQL query to an endpoint.</summary>
    [JsonPropertyName("dataSourceId")]
    public string? DataSourceId { get; set; }

    /// <summary>Whether to enable Photon. This field is optional and is enabled by default.</summary>
    [JsonPropertyName("enablePhoton")]
    public bool? EnablePhoton { get; set; }

    /// <summary>Whether this SQL warehouse is a serverless endpoint. See below for details about the default values. To avoid ambiguity, especially for organizations with many workspaces, Databricks recommends that you always set this field explicitly.</summary>
    [JsonPropertyName("enableServerlessCompute")]
    public bool? EnableServerlessCompute { get; set; }

    /// <summary>Health status of the endpoint.</summary>
    [JsonPropertyName("health")]
    public IList<V1beta1EndpointStatusAtProviderHealth>? Health { get; set; }

    /// <summary>the unique ID of the SQL warehouse.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("instanceProfileArn")]
    public string? InstanceProfileArn { get; set; }

    /// <summary>JDBC connection string.</summary>
    [JsonPropertyName("jdbcUrl")]
    public string? JdbcUrl { get; set; }

    /// <summary>Maximum number of clusters available when a SQL warehouse is running. This field is required. If multi-cluster load balancing is not enabled, this is default to 1.</summary>
    [JsonPropertyName("maxNumClusters")]
    public double? MaxNumClusters { get; set; }

    /// <summary>Minimum number of clusters available when a SQL warehouse is running. The default is 1.</summary>
    [JsonPropertyName("minNumClusters")]
    public double? MinNumClusters { get; set; }

    /// <summary>Name of the SQL warehouse. Must be unique.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The current number of clusters used by the endpoint.</summary>
    [JsonPropertyName("numActiveSessions")]
    public double? NumActiveSessions { get; set; }

    /// <summary>The current number of clusters used by the endpoint.</summary>
    [JsonPropertyName("numClusters")]
    public double? NumClusters { get; set; }

    /// <summary>ODBC connection params: odbc_params.hostname, odbc_params.path, odbc_params.protocol, and odbc_params.port.</summary>
    [JsonPropertyName("odbcParams")]
    public IList<V1beta1EndpointStatusAtProviderOdbcParams>? OdbcParams { get; set; }

    /// <summary>The spot policy to use for allocating instances to clusters: COST_OPTIMIZED or RELIABILITY_OPTIMIZED. This field is optional. Default is COST_OPTIMIZED.</summary>
    [JsonPropertyName("spotInstancePolicy")]
    public string? SpotInstancePolicy { get; set; }

    /// <summary>The current state of the endpoint.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Databricks tags all endpoint resources with these tags.</summary>
    [JsonPropertyName("tags")]
    public V1beta1EndpointStatusAtProviderTags? Tags { get; set; }

    /// <summary>SQL warehouse type. See for AWS or Azure. Set to PRO or CLASSIC. If the field enable_serverless_compute has the value true either explicitly or through the default logic (see that field above for details), the default is PRO, which is required for serverless SQL warehouses. Otherwise, the default is CLASSIC.</summary>
    [JsonPropertyName("warehouseType")]
    public string? WarehouseType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatusConditions
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

/// <summary>EndpointStatus defines the observed state of Endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1EndpointStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EndpointStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Endpoint is the Schema for the Endpoints API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Endpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EndpointSpec>, IStatus<V1beta1EndpointStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Endpoint";
    public const string KubeGroup = "sql.databricks.m.upbound.io";
    public const string KubePluralName = "endpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.databricks.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Endpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EndpointSpec defines the desired state of Endpoint</summary>
    [JsonPropertyName("spec")]
    public required V1beta1EndpointSpec Spec { get; set; }

    /// <summary>EndpointStatus defines the observed state of Endpoint.</summary>
    [JsonPropertyName("status")]
    public V1beta1EndpointStatus? Status { get; set; }
}
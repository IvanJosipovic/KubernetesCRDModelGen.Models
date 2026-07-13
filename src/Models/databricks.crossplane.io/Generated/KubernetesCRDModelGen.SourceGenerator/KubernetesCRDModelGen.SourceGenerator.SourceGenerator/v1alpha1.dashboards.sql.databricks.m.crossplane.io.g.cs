#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.databricks.m.crossplane.io;
/// <summary>
/// Dashboard is the Schema for the Dashboards API.
/// Deprecated: This API version (v1alpha1) has been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DashboardList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Dashboard>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DashboardList";
    public const string KubeGroup = "sql.databricks.m.crossplane.io";
    public const string KubePluralName = "dashboards";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.databricks.m.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DashboardList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Dashboard objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Dashboard> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1DashboardSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1DashboardSpecForProvider
{
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    [JsonPropertyName("dashboardChangeDetected")]
    public bool? DashboardChangeDetected { get; set; }

    /// <summary>The unique ID of the dashboard.</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>Sets the default catalog for all datasets in this dashboard. Does not impact table references that use fully qualified catalog names (ex: samples.nyctaxi.trips).</summary>
    [JsonPropertyName("datasetCatalog")]
    public string? DatasetCatalog { get; set; }

    /// <summary>Sets the default schema for all datasets in this dashboard. Does not impact table references that use fully qualified catalog names (ex: samples.nyctaxi.trips).</summary>
    [JsonPropertyName("datasetSchema")]
    public string? DatasetSchema { get; set; }

    /// <summary>The display name of the dashboard.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether to embed credentials in the dashboard. Default is true.</summary>
    [JsonPropertyName("embedCredentials")]
    public bool? EmbedCredentials { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>The path to the dashboard JSON file. Conflicts with serialized_dashboard.</summary>
    [JsonPropertyName("filePath")]
    public string? FilePath { get; set; }

    [JsonPropertyName("lifecycleState")]
    public string? LifecycleState { get; set; }

    [JsonPropertyName("md5")]
    public string? Md5 { get; set; }

    /// <summary>The workspace path of the folder containing the dashboard. Includes leading slash and no trailing slash.  If folder doesn&apos;t exist, it will be created.</summary>
    [JsonPropertyName("parentPath")]
    public string? ParentPath { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public IList<V1alpha1DashboardSpecForProviderProviderConfig>? ProviderConfig { get; set; }

    /// <summary>The contents of the dashboard in serialized string form. Conflicts with file_path.</summary>
    [JsonPropertyName("serializedDashboard")]
    public string? SerializedDashboard { get; set; }

    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>The warehouse ID used to run the dashboard.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1DashboardSpecInitProviderProviderConfig
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1DashboardSpecInitProvider
{
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    [JsonPropertyName("dashboardChangeDetected")]
    public bool? DashboardChangeDetected { get; set; }

    /// <summary>The unique ID of the dashboard.</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>Sets the default catalog for all datasets in this dashboard. Does not impact table references that use fully qualified catalog names (ex: samples.nyctaxi.trips).</summary>
    [JsonPropertyName("datasetCatalog")]
    public string? DatasetCatalog { get; set; }

    /// <summary>Sets the default schema for all datasets in this dashboard. Does not impact table references that use fully qualified catalog names (ex: samples.nyctaxi.trips).</summary>
    [JsonPropertyName("datasetSchema")]
    public string? DatasetSchema { get; set; }

    /// <summary>The display name of the dashboard.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether to embed credentials in the dashboard. Default is true.</summary>
    [JsonPropertyName("embedCredentials")]
    public bool? EmbedCredentials { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>The path to the dashboard JSON file. Conflicts with serialized_dashboard.</summary>
    [JsonPropertyName("filePath")]
    public string? FilePath { get; set; }

    [JsonPropertyName("lifecycleState")]
    public string? LifecycleState { get; set; }

    [JsonPropertyName("md5")]
    public string? Md5 { get; set; }

    /// <summary>The workspace path of the folder containing the dashboard. Includes leading slash and no trailing slash.  If folder doesn&apos;t exist, it will be created.</summary>
    [JsonPropertyName("parentPath")]
    public string? ParentPath { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public IList<V1alpha1DashboardSpecInitProviderProviderConfig>? ProviderConfig { get; set; }

    /// <summary>The contents of the dashboard in serialized string form. Conflicts with file_path.</summary>
    [JsonPropertyName("serializedDashboard")]
    public string? SerializedDashboard { get; set; }

    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>The warehouse ID used to run the dashboard.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1DashboardSpecManagementPoliciesEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1DashboardSpecManagementPoliciesEnum
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1DashboardSpecProviderConfigRef
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1DashboardSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>DashboardSpec defines the desired state of Dashboard</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1DashboardSpec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1DashboardSpecForProvider ForProvider { get; set; }

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
    public V1alpha1DashboardSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1DashboardSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1DashboardSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1DashboardSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1DashboardStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1DashboardStatusAtProvider
{
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    [JsonPropertyName("dashboardChangeDetected")]
    public bool? DashboardChangeDetected { get; set; }

    /// <summary>The unique ID of the dashboard.</summary>
    [JsonPropertyName("dashboardId")]
    public string? DashboardId { get; set; }

    /// <summary>Sets the default catalog for all datasets in this dashboard. Does not impact table references that use fully qualified catalog names (ex: samples.nyctaxi.trips).</summary>
    [JsonPropertyName("datasetCatalog")]
    public string? DatasetCatalog { get; set; }

    /// <summary>Sets the default schema for all datasets in this dashboard. Does not impact table references that use fully qualified catalog names (ex: samples.nyctaxi.trips).</summary>
    [JsonPropertyName("datasetSchema")]
    public string? DatasetSchema { get; set; }

    /// <summary>The display name of the dashboard.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Whether to embed credentials in the dashboard. Default is true.</summary>
    [JsonPropertyName("embedCredentials")]
    public bool? EmbedCredentials { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>The path to the dashboard JSON file. Conflicts with serialized_dashboard.</summary>
    [JsonPropertyName("filePath")]
    public string? FilePath { get; set; }

    /// <summary>The unique ID of the dashboard.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("lifecycleState")]
    public string? LifecycleState { get; set; }

    [JsonPropertyName("md5")]
    public string? Md5 { get; set; }

    /// <summary>The workspace path of the folder containing the dashboard. Includes leading slash and no trailing slash.  If folder doesn&apos;t exist, it will be created.</summary>
    [JsonPropertyName("parentPath")]
    public string? ParentPath { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public IList<V1alpha1DashboardStatusAtProviderProviderConfig>? ProviderConfig { get; set; }

    /// <summary>The contents of the dashboard in serialized string form. Conflicts with file_path.</summary>
    [JsonPropertyName("serializedDashboard")]
    public string? SerializedDashboard { get; set; }

    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>The warehouse ID used to run the dashboard.</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1DashboardStatusConditions
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

/// <summary>DashboardStatus defines the observed state of Dashboard.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1DashboardStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1DashboardStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DashboardStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// Dashboard is the Schema for the Dashboards API.
/// Deprecated: This API version (v1alpha1) has been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Dashboard : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DashboardSpec>, IStatus<V1alpha1DashboardStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Dashboard";
    public const string KubeGroup = "sql.databricks.m.crossplane.io";
    public const string KubePluralName = "dashboards";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.databricks.m.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Dashboard";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DashboardSpec defines the desired state of Dashboard</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DashboardSpec Spec { get; set; }

    /// <summary>DashboardStatus defines the observed state of Dashboard.</summary>
    [JsonPropertyName("status")]
    public V1alpha1DashboardStatus? Status { get; set; }
}
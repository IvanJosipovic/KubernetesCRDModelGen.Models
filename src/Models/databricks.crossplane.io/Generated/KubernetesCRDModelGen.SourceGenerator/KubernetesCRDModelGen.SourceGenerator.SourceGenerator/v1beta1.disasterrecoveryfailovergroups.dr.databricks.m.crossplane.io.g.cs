#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dr.databricks.m.crossplane.io;
/// <summary>DisasterRecoveryFailoverGroup is the Schema for the DisasterRecoveryFailoverGroups API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DisasterRecoveryFailoverGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DisasterRecoveryFailoverGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DisasterRecoveryFailoverGroupList";
    public const string KubeGroup = "dr.databricks.m.crossplane.io";
    public const string KubePluralName = "disasterrecoveryfailovergroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dr.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DisasterRecoveryFailoverGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1DisasterRecoveryFailoverGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1DisasterRecoveryFailoverGroup> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupSpecForProviderUnityCatalogAssetsCatalogs
{
    /// <summary>Resource name for this location</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupSpecForProviderUnityCatalogAssetsLocationMappingsUriByRegion
{
    /// <summary>The region name</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The storage URI for this region</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupSpecForProviderUnityCatalogAssetsLocationMappings
{
    /// <summary>Resource name for this location</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>URI for each region. Each entry maps a region name to a storage URI</summary>
    [JsonPropertyName("uriByRegion")]
    public IList<V1beta1DisasterRecoveryFailoverGroupSpecForProviderUnityCatalogAssetsLocationMappingsUriByRegion>? UriByRegion { get; set; }
}

/// <summary>Unity Catalog replication configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupSpecForProviderUnityCatalogAssets
{
    /// <summary>UC catalogs to replicate</summary>
    [JsonPropertyName("catalogs")]
    public IList<V1beta1DisasterRecoveryFailoverGroupSpecForProviderUnityCatalogAssetsCatalogs>? Catalogs { get; set; }

    /// <summary>
    /// The workspace set whose workspaces will be used for data replication
    /// of all UC catalogs&apos; underlying storage
    /// </summary>
    [JsonPropertyName("dataReplicationWorkspaceSet")]
    public string? DataReplicationWorkspaceSet { get; set; }

    /// <summary>Location mappings - storage URI per region for each location</summary>
    [JsonPropertyName("locationMappings")]
    public IList<V1beta1DisasterRecoveryFailoverGroupSpecForProviderUnityCatalogAssetsLocationMappings>? LocationMappings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupSpecForProviderWorkspaceSets
{
    /// <summary>Resource name for this location</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Whether to enable control plane DR (notebooks, jobs, clusters, etc.) for this set.
    /// Defaults to false
    /// </summary>
    [JsonPropertyName("replicateWorkspaceAssets")]
    public bool? ReplicateWorkspaceAssets { get; set; }

    /// <summary>
    /// Resource names of stable URLs associated with this workspace set.
    /// Format: accounts/{account_id}/stable-urls/{stable_url_id}.
    /// The referenced stable URLs must already exist (via CreateStableUrl)
    /// </summary>
    [JsonPropertyName("stableUrlNames")]
    public IList<string>? StableUrlNames { get; set; }

    /// <summary>
    /// Workspace IDs in this set. The system derives and validates regions.
    /// All workspaces must be in the Mission Critical tier
    /// </summary>
    [JsonPropertyName("workspaceIds")]
    public IList<string>? WorkspaceIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupSpecForProvider
{
    /// <summary>
    /// Client-provided identifier for the failover group. Used to construct the
    /// resource name as {parent}/failover-groups/{failover_group_id}
    /// </summary>
    [JsonPropertyName("failoverGroupId")]
    public string? FailoverGroupId { get; set; }

    /// <summary>
    /// Initial primary region. Used only in Create requests to set the starting
    /// primary region. Not returned in responses
    /// </summary>
    [JsonPropertyName("initialPrimaryRegion")]
    public string? InitialPrimaryRegion { get; set; }

    /// <summary>The parent resource. Format: accounts/{account_id}</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>List of all regions participating in this failover group</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    /// <summary>Unity Catalog replication configuration</summary>
    [JsonPropertyName("unityCatalogAssets")]
    public V1beta1DisasterRecoveryFailoverGroupSpecForProviderUnityCatalogAssets? UnityCatalogAssets { get; set; }

    /// <summary>Workspace sets, each containing workspaces that replicate to each other</summary>
    [JsonPropertyName("workspaceSets")]
    public IList<V1beta1DisasterRecoveryFailoverGroupSpecForProviderWorkspaceSets>? WorkspaceSets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupSpecInitProviderUnityCatalogAssetsCatalogs
{
    /// <summary>Resource name for this location</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupSpecInitProviderUnityCatalogAssetsLocationMappingsUriByRegion
{
    /// <summary>The region name</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The storage URI for this region</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupSpecInitProviderUnityCatalogAssetsLocationMappings
{
    /// <summary>Resource name for this location</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>URI for each region. Each entry maps a region name to a storage URI</summary>
    [JsonPropertyName("uriByRegion")]
    public IList<V1beta1DisasterRecoveryFailoverGroupSpecInitProviderUnityCatalogAssetsLocationMappingsUriByRegion>? UriByRegion { get; set; }
}

/// <summary>Unity Catalog replication configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupSpecInitProviderUnityCatalogAssets
{
    /// <summary>UC catalogs to replicate</summary>
    [JsonPropertyName("catalogs")]
    public IList<V1beta1DisasterRecoveryFailoverGroupSpecInitProviderUnityCatalogAssetsCatalogs>? Catalogs { get; set; }

    /// <summary>
    /// The workspace set whose workspaces will be used for data replication
    /// of all UC catalogs&apos; underlying storage
    /// </summary>
    [JsonPropertyName("dataReplicationWorkspaceSet")]
    public string? DataReplicationWorkspaceSet { get; set; }

    /// <summary>Location mappings - storage URI per region for each location</summary>
    [JsonPropertyName("locationMappings")]
    public IList<V1beta1DisasterRecoveryFailoverGroupSpecInitProviderUnityCatalogAssetsLocationMappings>? LocationMappings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupSpecInitProviderWorkspaceSets
{
    /// <summary>Resource name for this location</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Whether to enable control plane DR (notebooks, jobs, clusters, etc.) for this set.
    /// Defaults to false
    /// </summary>
    [JsonPropertyName("replicateWorkspaceAssets")]
    public bool? ReplicateWorkspaceAssets { get; set; }

    /// <summary>
    /// Resource names of stable URLs associated with this workspace set.
    /// Format: accounts/{account_id}/stable-urls/{stable_url_id}.
    /// The referenced stable URLs must already exist (via CreateStableUrl)
    /// </summary>
    [JsonPropertyName("stableUrlNames")]
    public IList<string>? StableUrlNames { get; set; }

    /// <summary>
    /// Workspace IDs in this set. The system derives and validates regions.
    /// All workspaces must be in the Mission Critical tier
    /// </summary>
    [JsonPropertyName("workspaceIds")]
    public IList<string>? WorkspaceIds { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupSpecInitProvider
{
    /// <summary>
    /// Client-provided identifier for the failover group. Used to construct the
    /// resource name as {parent}/failover-groups/{failover_group_id}
    /// </summary>
    [JsonPropertyName("failoverGroupId")]
    public string? FailoverGroupId { get; set; }

    /// <summary>
    /// Initial primary region. Used only in Create requests to set the starting
    /// primary region. Not returned in responses
    /// </summary>
    [JsonPropertyName("initialPrimaryRegion")]
    public string? InitialPrimaryRegion { get; set; }

    /// <summary>The parent resource. Format: accounts/{account_id}</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>List of all regions participating in this failover group</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    /// <summary>Unity Catalog replication configuration</summary>
    [JsonPropertyName("unityCatalogAssets")]
    public V1beta1DisasterRecoveryFailoverGroupSpecInitProviderUnityCatalogAssets? UnityCatalogAssets { get; set; }

    /// <summary>Workspace sets, each containing workspaces that replicate to each other</summary>
    [JsonPropertyName("workspaceSets")]
    public IList<V1beta1DisasterRecoveryFailoverGroupSpecInitProviderWorkspaceSets>? WorkspaceSets { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DisasterRecoveryFailoverGroupSpecManagementPoliciesEnum>))]
public enum V1beta1DisasterRecoveryFailoverGroupSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupSpecProviderConfigRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>DisasterRecoveryFailoverGroupSpec defines the desired state of DisasterRecoveryFailoverGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1DisasterRecoveryFailoverGroupSpecForProvider ForProvider { get; set; }

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
    public V1beta1DisasterRecoveryFailoverGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DisasterRecoveryFailoverGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DisasterRecoveryFailoverGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DisasterRecoveryFailoverGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupStatusAtProviderUnityCatalogAssetsCatalogs
{
    /// <summary>Resource name for this location</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupStatusAtProviderUnityCatalogAssetsLocationMappingsUriByRegion
{
    /// <summary>The region name</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The storage URI for this region</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupStatusAtProviderUnityCatalogAssetsLocationMappings
{
    /// <summary>Resource name for this location</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>URI for each region. Each entry maps a region name to a storage URI</summary>
    [JsonPropertyName("uriByRegion")]
    public IList<V1beta1DisasterRecoveryFailoverGroupStatusAtProviderUnityCatalogAssetsLocationMappingsUriByRegion>? UriByRegion { get; set; }
}

/// <summary>Unity Catalog replication configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupStatusAtProviderUnityCatalogAssets
{
    /// <summary>UC catalogs to replicate</summary>
    [JsonPropertyName("catalogs")]
    public IList<V1beta1DisasterRecoveryFailoverGroupStatusAtProviderUnityCatalogAssetsCatalogs>? Catalogs { get; set; }

    /// <summary>
    /// The workspace set whose workspaces will be used for data replication
    /// of all UC catalogs&apos; underlying storage
    /// </summary>
    [JsonPropertyName("dataReplicationWorkspaceSet")]
    public string? DataReplicationWorkspaceSet { get; set; }

    /// <summary>Location mappings - storage URI per region for each location</summary>
    [JsonPropertyName("locationMappings")]
    public IList<V1beta1DisasterRecoveryFailoverGroupStatusAtProviderUnityCatalogAssetsLocationMappings>? LocationMappings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupStatusAtProviderWorkspaceSets
{
    /// <summary>Resource name for this location</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Whether to enable control plane DR (notebooks, jobs, clusters, etc.) for this set.
    /// Defaults to false
    /// </summary>
    [JsonPropertyName("replicateWorkspaceAssets")]
    public bool? ReplicateWorkspaceAssets { get; set; }

    /// <summary>
    /// Resource names of stable URLs associated with this workspace set.
    /// Format: accounts/{account_id}/stable-urls/{stable_url_id}.
    /// The referenced stable URLs must already exist (via CreateStableUrl)
    /// </summary>
    [JsonPropertyName("stableUrlNames")]
    public IList<string>? StableUrlNames { get; set; }

    /// <summary>
    /// Workspace IDs in this set. The system derives and validates regions.
    /// All workspaces must be in the Mission Critical tier
    /// </summary>
    [JsonPropertyName("workspaceIds")]
    public IList<string>? WorkspaceIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupStatusAtProvider
{
    /// <summary>Time at which this failover group was created</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// Current effective primary region. Replication flows FROM workspaces in this region.
    /// Changes after a successful failover
    /// </summary>
    [JsonPropertyName("effectivePrimaryRegion")]
    public string? EffectivePrimaryRegion { get; set; }

    /// <summary>Opaque version string for optimistic locking. Server-generated and returned in responses</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// Client-provided identifier for the failover group. Used to construct the
    /// resource name as {parent}/failover-groups/{failover_group_id}
    /// </summary>
    [JsonPropertyName("failoverGroupId")]
    public string? FailoverGroupId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Initial primary region. Used only in Create requests to set the starting
    /// primary region. Not returned in responses
    /// </summary>
    [JsonPropertyName("initialPrimaryRegion")]
    public string? InitialPrimaryRegion { get; set; }

    /// <summary>The parent resource. Format: accounts/{account_id}</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>List of all regions participating in this failover group</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    /// <summary>The latest point in time to which data has been replicated</summary>
    [JsonPropertyName("replicationPoint")]
    public string? ReplicationPoint { get; set; }

    /// <summary>Aggregate state of the failover group. Possible values are: ACTIVE, CREATING, CREATION_FAILED, DELETING, DELETION_FAILED, FAILING_OVER, FAILOVER_FAILED, INITIAL_REPLICATION</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Unity Catalog replication configuration</summary>
    [JsonPropertyName("unityCatalogAssets")]
    public V1beta1DisasterRecoveryFailoverGroupStatusAtProviderUnityCatalogAssets? UnityCatalogAssets { get; set; }

    /// <summary>Time at which this failover group was last modified</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Workspace sets, each containing workspaces that replicate to each other</summary>
    [JsonPropertyName("workspaceSets")]
    public IList<V1beta1DisasterRecoveryFailoverGroupStatusAtProviderWorkspaceSets>? WorkspaceSets { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupStatusConditions
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

/// <summary>DisasterRecoveryFailoverGroupStatus defines the observed state of DisasterRecoveryFailoverGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DisasterRecoveryFailoverGroupStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1DisasterRecoveryFailoverGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DisasterRecoveryFailoverGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile-requested-at annotation token that the controller has
    /// processed. Users can compare this to the annotation to determine
    /// whether a reconcile request has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DisasterRecoveryFailoverGroup is the Schema for the DisasterRecoveryFailoverGroups API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DisasterRecoveryFailoverGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DisasterRecoveryFailoverGroupSpec>, IStatus<V1beta1DisasterRecoveryFailoverGroupStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DisasterRecoveryFailoverGroup";
    public const string KubeGroup = "dr.databricks.m.crossplane.io";
    public const string KubePluralName = "disasterrecoveryfailovergroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dr.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DisasterRecoveryFailoverGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DisasterRecoveryFailoverGroupSpec defines the desired state of DisasterRecoveryFailoverGroup</summary>
    [JsonPropertyName("spec")]
    public required V1beta1DisasterRecoveryFailoverGroupSpec Spec { get; set; }

    /// <summary>DisasterRecoveryFailoverGroupStatus defines the observed state of DisasterRecoveryFailoverGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1DisasterRecoveryFailoverGroupStatus? Status { get; set; }
}
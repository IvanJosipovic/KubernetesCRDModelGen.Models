#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.security.databricks.m.crossplane.io;
/// <summary>
/// Entitlements is the Schema for the Entitlementss API.
/// Deprecated: This API version (v1alpha1) has been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1EntitlementsList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Entitlements>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "EntitlementsList";
    public const string KubeGroup = "security.databricks.m.crossplane.io";
    public const string KubePluralName = "entitlements";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "security.databricks.m.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EntitlementsList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Entitlements objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Entitlements> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1EntitlementsSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1EntitlementsSpecForProvider
{
    /// <summary>Allow the principal to have cluster create privileges. Defaults to false. More fine grained permissions could be assigned with databricks_permissions and cluster_id argument. Everyone without allow_cluster_create argument set, but with permission to use Cluster Policy would be able to create clusters, but within boundaries of that specific policy.</summary>
    [JsonPropertyName("allowClusterCreate")]
    public bool? AllowClusterCreate { get; set; }

    /// <summary>Allow the principal to have instance pool create privileges. Defaults to false. More fine grained permissions could be assigned with databricks_permissions and instance_pool_id argument.</summary>
    [JsonPropertyName("allowInstancePoolCreate")]
    public bool? AllowInstancePoolCreate { get; set; }

    /// <summary>This is a field to allow the principal to have access to Databricks SQL  UI, Databricks One and through databricks_sql_endpoint.</summary>
    [JsonPropertyName("databricksSqlAccess")]
    public bool? DatabricksSqlAccess { get; set; }

    /// <summary>Canonical unique identifier for the group.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public IList<V1alpha1EntitlementsSpecForProviderProviderConfig>? ProviderConfig { get; set; }

    /// <summary>Canonical unique identifier for the service principal.</summary>
    [JsonPropertyName("servicePrincipalId")]
    public string? ServicePrincipalId { get; set; }

    /// <summary>Canonical unique identifier for the user.</summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>This is a field to allow the principal to have access to a Databricks Workspace UI and Databricks One.</summary>
    [JsonPropertyName("workspaceAccess")]
    public bool? WorkspaceAccess { get; set; }

    /// <summary>This is a field to allow the principal to have access only to Databricks One.  Couldn&apos;t be used with workspace_access or databricks_sql_access.</summary>
    [JsonPropertyName("workspaceConsume")]
    public bool? WorkspaceConsume { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1EntitlementsSpecInitProviderProviderConfig
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
public partial class V1alpha1EntitlementsSpecInitProvider
{
    /// <summary>Allow the principal to have cluster create privileges. Defaults to false. More fine grained permissions could be assigned with databricks_permissions and cluster_id argument. Everyone without allow_cluster_create argument set, but with permission to use Cluster Policy would be able to create clusters, but within boundaries of that specific policy.</summary>
    [JsonPropertyName("allowClusterCreate")]
    public bool? AllowClusterCreate { get; set; }

    /// <summary>Allow the principal to have instance pool create privileges. Defaults to false. More fine grained permissions could be assigned with databricks_permissions and instance_pool_id argument.</summary>
    [JsonPropertyName("allowInstancePoolCreate")]
    public bool? AllowInstancePoolCreate { get; set; }

    /// <summary>This is a field to allow the principal to have access to Databricks SQL  UI, Databricks One and through databricks_sql_endpoint.</summary>
    [JsonPropertyName("databricksSqlAccess")]
    public bool? DatabricksSqlAccess { get; set; }

    /// <summary>Canonical unique identifier for the group.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public IList<V1alpha1EntitlementsSpecInitProviderProviderConfig>? ProviderConfig { get; set; }

    /// <summary>Canonical unique identifier for the service principal.</summary>
    [JsonPropertyName("servicePrincipalId")]
    public string? ServicePrincipalId { get; set; }

    /// <summary>Canonical unique identifier for the user.</summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>This is a field to allow the principal to have access to a Databricks Workspace UI and Databricks One.</summary>
    [JsonPropertyName("workspaceAccess")]
    public bool? WorkspaceAccess { get; set; }

    /// <summary>This is a field to allow the principal to have access only to Databricks One.  Couldn&apos;t be used with workspace_access or databricks_sql_access.</summary>
    [JsonPropertyName("workspaceConsume")]
    public bool? WorkspaceConsume { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1EntitlementsSpecManagementPoliciesEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1EntitlementsSpecManagementPoliciesEnum
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
public partial class V1alpha1EntitlementsSpecProviderConfigRef
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
public partial class V1alpha1EntitlementsSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>EntitlementsSpec defines the desired state of Entitlements</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1EntitlementsSpec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1EntitlementsSpecForProvider ForProvider { get; set; }

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
    public V1alpha1EntitlementsSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1EntitlementsSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1EntitlementsSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1EntitlementsSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1EntitlementsStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1EntitlementsStatusAtProvider
{
    /// <summary>Allow the principal to have cluster create privileges. Defaults to false. More fine grained permissions could be assigned with databricks_permissions and cluster_id argument. Everyone without allow_cluster_create argument set, but with permission to use Cluster Policy would be able to create clusters, but within boundaries of that specific policy.</summary>
    [JsonPropertyName("allowClusterCreate")]
    public bool? AllowClusterCreate { get; set; }

    /// <summary>Allow the principal to have instance pool create privileges. Defaults to false. More fine grained permissions could be assigned with databricks_permissions and instance_pool_id argument.</summary>
    [JsonPropertyName("allowInstancePoolCreate")]
    public bool? AllowInstancePoolCreate { get; set; }

    /// <summary>This is a field to allow the principal to have access to Databricks SQL  UI, Databricks One and through databricks_sql_endpoint.</summary>
    [JsonPropertyName("databricksSqlAccess")]
    public bool? DatabricksSqlAccess { get; set; }

    /// <summary>Canonical unique identifier for the group.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public IList<V1alpha1EntitlementsStatusAtProviderProviderConfig>? ProviderConfig { get; set; }

    /// <summary>Canonical unique identifier for the service principal.</summary>
    [JsonPropertyName("servicePrincipalId")]
    public string? ServicePrincipalId { get; set; }

    /// <summary>Canonical unique identifier for the user.</summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>This is a field to allow the principal to have access to a Databricks Workspace UI and Databricks One.</summary>
    [JsonPropertyName("workspaceAccess")]
    public bool? WorkspaceAccess { get; set; }

    /// <summary>This is a field to allow the principal to have access only to Databricks One.  Couldn&apos;t be used with workspace_access or databricks_sql_access.</summary>
    [JsonPropertyName("workspaceConsume")]
    public bool? WorkspaceConsume { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1EntitlementsStatusConditions
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

/// <summary>EntitlementsStatus defines the observed state of Entitlements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1EntitlementsStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1EntitlementsStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1EntitlementsStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// Entitlements is the Schema for the Entitlementss API.
/// Deprecated: This API version (v1alpha1) has been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Entitlements : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1EntitlementsSpec>, IStatus<V1alpha1EntitlementsStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Entitlements";
    public const string KubeGroup = "security.databricks.m.crossplane.io";
    public const string KubePluralName = "entitlements";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "security.databricks.m.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Entitlements";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EntitlementsSpec defines the desired state of Entitlements</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1EntitlementsSpec Spec { get; set; }

    /// <summary>EntitlementsStatus defines the observed state of Entitlements.</summary>
    [JsonPropertyName("status")]
    public V1alpha1EntitlementsStatus? Status { get; set; }
}
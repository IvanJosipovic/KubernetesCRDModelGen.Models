#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.governance.databricks.m.crossplane.io;
/// <summary>DataClassificationCatalogConfig is the Schema for the DataClassificationCatalogConfigs API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataClassificationCatalogConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DataClassificationCatalogConfig>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataClassificationCatalogConfigList";
    public const string KubeGroup = "governance.databricks.m.crossplane.io";
    public const string KubePluralName = "dataclassificationcatalogconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "governance.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataClassificationCatalogConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1DataClassificationCatalogConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1DataClassificationCatalogConfig> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataClassificationCatalogConfigSpecForProviderAutoTagConfigs
{
    /// <summary>Whether auto-tagging is enabled or disabled for this classification tag. Possible values are: AUTO_TAGGING_DISABLED, AUTO_TAGGING_ENABLED</summary>
    [JsonPropertyName("autoTaggingMode")]
    public string? AutoTaggingMode { get; set; }

    /// <summary>
    /// The Classification Tag. For built-in classes this is a system tag (e.g., &quot;class.name&quot;,
    /// &quot;class.location&quot;); for custom classes it is a user-defined governance tag key
    /// </summary>
    [JsonPropertyName("classificationTag")]
    public string? ClassificationTag { get; set; }
}

/// <summary>
/// Schemas to exclude from the scan, each named relative to the parent catalog.
/// If specified, all schemas except the specified ones will be scanned.
/// Mutually exclusive with included_schemas: only one may be set per request.
/// If neither included_schemas nor excluded_schemas is set, all schemas are scanned
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataClassificationCatalogConfigSpecForProviderExcludedSchemas
{
    /// <summary>Schema names, each relative to the parent catalog. Must not be empty</summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }
}

/// <summary>
/// Schemas to include in the scan, each named relative to the parent catalog.
/// If specified, only listed schemas will be scanned.
/// Mutually exclusive with excluded_schemas: only one may be set per request.
/// If neither included_schemas nor excluded_schemas is set, all schemas are scanned
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataClassificationCatalogConfigSpecForProviderIncludedSchemas
{
    /// <summary>Schema names, each relative to the parent catalog. Must not be empty</summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataClassificationCatalogConfigSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataClassificationCatalogConfigSpecForProvider
{
    /// <summary>
    /// List of auto-tagging configurations for this catalog.
    /// Empty list means no auto-tagging is enabled
    /// </summary>
    [JsonPropertyName("autoTagConfigs")]
    public IList<V1beta1DataClassificationCatalogConfigSpecForProviderAutoTagConfigs>? AutoTagConfigs { get; set; }

    /// <summary>
    /// Schemas to exclude from the scan, each named relative to the parent catalog.
    /// If specified, all schemas except the specified ones will be scanned.
    /// Mutually exclusive with included_schemas: only one may be set per request.
    /// If neither included_schemas nor excluded_schemas is set, all schemas are scanned
    /// </summary>
    [JsonPropertyName("excludedSchemas")]
    public V1beta1DataClassificationCatalogConfigSpecForProviderExcludedSchemas? ExcludedSchemas { get; set; }

    /// <summary>
    /// Schemas to include in the scan, each named relative to the parent catalog.
    /// If specified, only listed schemas will be scanned.
    /// Mutually exclusive with excluded_schemas: only one may be set per request.
    /// If neither included_schemas nor excluded_schemas is set, all schemas are scanned
    /// </summary>
    [JsonPropertyName("includedSchemas")]
    public V1beta1DataClassificationCatalogConfigSpecForProviderIncludedSchemas? IncludedSchemas { get; set; }

    /// <summary>Parent resource in the format: catalogs/{catalog_name}</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1DataClassificationCatalogConfigSpecForProviderProviderConfig? ProviderConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataClassificationCatalogConfigSpecInitProviderAutoTagConfigs
{
    /// <summary>Whether auto-tagging is enabled or disabled for this classification tag. Possible values are: AUTO_TAGGING_DISABLED, AUTO_TAGGING_ENABLED</summary>
    [JsonPropertyName("autoTaggingMode")]
    public string? AutoTaggingMode { get; set; }

    /// <summary>
    /// The Classification Tag. For built-in classes this is a system tag (e.g., &quot;class.name&quot;,
    /// &quot;class.location&quot;); for custom classes it is a user-defined governance tag key
    /// </summary>
    [JsonPropertyName("classificationTag")]
    public string? ClassificationTag { get; set; }
}

/// <summary>
/// Schemas to exclude from the scan, each named relative to the parent catalog.
/// If specified, all schemas except the specified ones will be scanned.
/// Mutually exclusive with included_schemas: only one may be set per request.
/// If neither included_schemas nor excluded_schemas is set, all schemas are scanned
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataClassificationCatalogConfigSpecInitProviderExcludedSchemas
{
    /// <summary>Schema names, each relative to the parent catalog. Must not be empty</summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }
}

/// <summary>
/// Schemas to include in the scan, each named relative to the parent catalog.
/// If specified, only listed schemas will be scanned.
/// Mutually exclusive with excluded_schemas: only one may be set per request.
/// If neither included_schemas nor excluded_schemas is set, all schemas are scanned
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataClassificationCatalogConfigSpecInitProviderIncludedSchemas
{
    /// <summary>Schema names, each relative to the parent catalog. Must not be empty</summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataClassificationCatalogConfigSpecInitProviderProviderConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataClassificationCatalogConfigSpecInitProvider
{
    /// <summary>
    /// List of auto-tagging configurations for this catalog.
    /// Empty list means no auto-tagging is enabled
    /// </summary>
    [JsonPropertyName("autoTagConfigs")]
    public IList<V1beta1DataClassificationCatalogConfigSpecInitProviderAutoTagConfigs>? AutoTagConfigs { get; set; }

    /// <summary>
    /// Schemas to exclude from the scan, each named relative to the parent catalog.
    /// If specified, all schemas except the specified ones will be scanned.
    /// Mutually exclusive with included_schemas: only one may be set per request.
    /// If neither included_schemas nor excluded_schemas is set, all schemas are scanned
    /// </summary>
    [JsonPropertyName("excludedSchemas")]
    public V1beta1DataClassificationCatalogConfigSpecInitProviderExcludedSchemas? ExcludedSchemas { get; set; }

    /// <summary>
    /// Schemas to include in the scan, each named relative to the parent catalog.
    /// If specified, only listed schemas will be scanned.
    /// Mutually exclusive with excluded_schemas: only one may be set per request.
    /// If neither included_schemas nor excluded_schemas is set, all schemas are scanned
    /// </summary>
    [JsonPropertyName("includedSchemas")]
    public V1beta1DataClassificationCatalogConfigSpecInitProviderIncludedSchemas? IncludedSchemas { get; set; }

    /// <summary>Parent resource in the format: catalogs/{catalog_name}</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1DataClassificationCatalogConfigSpecInitProviderProviderConfig? ProviderConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DataClassificationCatalogConfigSpecManagementPoliciesEnum>))]
public enum V1beta1DataClassificationCatalogConfigSpecManagementPoliciesEnum
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
public partial class V1beta1DataClassificationCatalogConfigSpecProviderConfigRef
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
public partial class V1beta1DataClassificationCatalogConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>DataClassificationCatalogConfigSpec defines the desired state of DataClassificationCatalogConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataClassificationCatalogConfigSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1DataClassificationCatalogConfigSpecForProvider ForProvider { get; set; }

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
    public V1beta1DataClassificationCatalogConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DataClassificationCatalogConfigSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DataClassificationCatalogConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DataClassificationCatalogConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataClassificationCatalogConfigStatusAtProviderAutoTagConfigs
{
    /// <summary>Whether auto-tagging is enabled or disabled for this classification tag. Possible values are: AUTO_TAGGING_DISABLED, AUTO_TAGGING_ENABLED</summary>
    [JsonPropertyName("autoTaggingMode")]
    public string? AutoTaggingMode { get; set; }

    /// <summary>
    /// The Classification Tag. For built-in classes this is a system tag (e.g., &quot;class.name&quot;,
    /// &quot;class.location&quot;); for custom classes it is a user-defined governance tag key
    /// </summary>
    [JsonPropertyName("classificationTag")]
    public string? ClassificationTag { get; set; }
}

/// <summary>
/// Schemas to exclude from the scan, each named relative to the parent catalog.
/// If specified, all schemas except the specified ones will be scanned.
/// Mutually exclusive with included_schemas: only one may be set per request.
/// If neither included_schemas nor excluded_schemas is set, all schemas are scanned
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataClassificationCatalogConfigStatusAtProviderExcludedSchemas
{
    /// <summary>Schema names, each relative to the parent catalog. Must not be empty</summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }
}

/// <summary>
/// Schemas to include in the scan, each named relative to the parent catalog.
/// If specified, only listed schemas will be scanned.
/// Mutually exclusive with excluded_schemas: only one may be set per request.
/// If neither included_schemas nor excluded_schemas is set, all schemas are scanned
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataClassificationCatalogConfigStatusAtProviderIncludedSchemas
{
    /// <summary>Schema names, each relative to the parent catalog. Must not be empty</summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataClassificationCatalogConfigStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataClassificationCatalogConfigStatusAtProvider
{
    /// <summary>
    /// List of auto-tagging configurations for this catalog.
    /// Empty list means no auto-tagging is enabled
    /// </summary>
    [JsonPropertyName("autoTagConfigs")]
    public IList<V1beta1DataClassificationCatalogConfigStatusAtProviderAutoTagConfigs>? AutoTagConfigs { get; set; }

    /// <summary>
    /// Schemas to exclude from the scan, each named relative to the parent catalog.
    /// If specified, all schemas except the specified ones will be scanned.
    /// Mutually exclusive with included_schemas: only one may be set per request.
    /// If neither included_schemas nor excluded_schemas is set, all schemas are scanned
    /// </summary>
    [JsonPropertyName("excludedSchemas")]
    public V1beta1DataClassificationCatalogConfigStatusAtProviderExcludedSchemas? ExcludedSchemas { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Schemas to include in the scan, each named relative to the parent catalog.
    /// If specified, only listed schemas will be scanned.
    /// Mutually exclusive with excluded_schemas: only one may be set per request.
    /// If neither included_schemas nor excluded_schemas is set, all schemas are scanned
    /// </summary>
    [JsonPropertyName("includedSchemas")]
    public V1beta1DataClassificationCatalogConfigStatusAtProviderIncludedSchemas? IncludedSchemas { get; set; }

    /// <summary>Parent resource in the format: catalogs/{catalog_name}</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1DataClassificationCatalogConfigStatusAtProviderProviderConfig? ProviderConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataClassificationCatalogConfigStatusConditions
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

/// <summary>DataClassificationCatalogConfigStatus defines the observed state of DataClassificationCatalogConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DataClassificationCatalogConfigStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1DataClassificationCatalogConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DataClassificationCatalogConfigStatusConditions>? Conditions { get; set; }

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

/// <summary>DataClassificationCatalogConfig is the Schema for the DataClassificationCatalogConfigs API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DataClassificationCatalogConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DataClassificationCatalogConfigSpec>, IStatus<V1beta1DataClassificationCatalogConfigStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DataClassificationCatalogConfig";
    public const string KubeGroup = "governance.databricks.m.crossplane.io";
    public const string KubePluralName = "dataclassificationcatalogconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "governance.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataClassificationCatalogConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DataClassificationCatalogConfigSpec defines the desired state of DataClassificationCatalogConfig</summary>
    [JsonPropertyName("spec")]
    public required V1beta1DataClassificationCatalogConfigSpec Spec { get; set; }

    /// <summary>DataClassificationCatalogConfigStatus defines the observed state of DataClassificationCatalogConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1DataClassificationCatalogConfigStatus? Status { get; set; }
}
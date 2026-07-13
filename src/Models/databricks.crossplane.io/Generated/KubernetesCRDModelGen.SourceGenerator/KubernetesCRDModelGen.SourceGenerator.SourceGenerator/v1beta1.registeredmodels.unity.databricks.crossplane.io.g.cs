#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.unity.databricks.crossplane.io;
/// <summary>RegisteredModel is the Schema for the RegisteredModels API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RegisteredModelList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RegisteredModel>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegisteredModelList";
    public const string KubeGroup = "unity.databricks.crossplane.io";
    public const string KubePluralName = "registeredmodels";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "unity.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegisteredModelList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1RegisteredModel objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1RegisteredModel> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegisteredModelSpecDeletionPolicyEnum>))]
public enum V1beta1RegisteredModelSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegisteredModelSpecForProviderAliases
{
    /// <summary>The name of the registered model.  Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("aliasName")]
    public string? AliasName { get; set; }

    /// <summary>The name of the catalog where the schema and the registered model reside. Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>Equal to the full name of the model (catalog_name.schema_name.name) and used to identify the model uniquely across the metastore.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the registered model.  Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>The name of the schema where the registered model resides. Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    [JsonPropertyName("versionNum")]
    public double? VersionNum { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegisteredModelSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegisteredModelSpecForProvider
{
    [JsonPropertyName("aliases")]
    public IList<V1beta1RegisteredModelSpecForProviderAliases>? Aliases { get; set; }

    [JsonPropertyName("browseOnly")]
    public bool? BrowseOnly { get; set; }

    /// <summary>The name of the catalog where the schema and the registered model reside. Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>The comment attached to the registered model.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("createdAt")]
    public double? CreatedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>The name of the registered model.  Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary>Equal to the full name of the model (catalog_name.schema_name.name) and used to identify the model uniquely across the metastore.</summary>
    [JsonPropertyName("metastoreId")]
    public string? MetastoreId { get; set; }

    /// <summary>The name of the registered model.  Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Name of the registered model owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1RegisteredModelSpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>The name of the schema where the registered model resides. Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    /// <summary>The storage location under which model version data files are stored.  If the URL contains special characters, such as space, &amp;, etc., they should be percent-encoded (space -&gt; %20, etc.). Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("storageLocation")]
    public string? StorageLocation { get; set; }

    [JsonPropertyName("updatedAt")]
    public double? UpdatedAt { get; set; }

    [JsonPropertyName("updatedBy")]
    public string? UpdatedBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegisteredModelSpecInitProviderAliases
{
    /// <summary>The name of the registered model.  Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("aliasName")]
    public string? AliasName { get; set; }

    /// <summary>The name of the catalog where the schema and the registered model reside. Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>Equal to the full name of the model (catalog_name.schema_name.name) and used to identify the model uniquely across the metastore.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the registered model.  Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>The name of the schema where the registered model resides. Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    [JsonPropertyName("versionNum")]
    public double? VersionNum { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegisteredModelSpecInitProviderProviderConfig
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
public partial class V1beta1RegisteredModelSpecInitProvider
{
    [JsonPropertyName("aliases")]
    public IList<V1beta1RegisteredModelSpecInitProviderAliases>? Aliases { get; set; }

    [JsonPropertyName("browseOnly")]
    public bool? BrowseOnly { get; set; }

    /// <summary>The name of the catalog where the schema and the registered model reside. Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>The comment attached to the registered model.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("createdAt")]
    public double? CreatedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>The name of the registered model.  Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary>Equal to the full name of the model (catalog_name.schema_name.name) and used to identify the model uniquely across the metastore.</summary>
    [JsonPropertyName("metastoreId")]
    public string? MetastoreId { get; set; }

    /// <summary>The name of the registered model.  Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Name of the registered model owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1RegisteredModelSpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>The name of the schema where the registered model resides. Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    /// <summary>The storage location under which model version data files are stored.  If the URL contains special characters, such as space, &amp;, etc., they should be percent-encoded (space -&gt; %20, etc.). Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("storageLocation")]
    public string? StorageLocation { get; set; }

    [JsonPropertyName("updatedAt")]
    public double? UpdatedAt { get; set; }

    [JsonPropertyName("updatedBy")]
    public string? UpdatedBy { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegisteredModelSpecManagementPoliciesEnum>))]
public enum V1beta1RegisteredModelSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegisteredModelSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1RegisteredModelSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegisteredModelSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1RegisteredModelSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegisteredModelSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RegisteredModelSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RegisteredModelSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegisteredModelSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RegisteredModelSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegisteredModelSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>RegisteredModelSpec defines the desired state of RegisteredModel</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegisteredModelSpec
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
    public V1beta1RegisteredModelSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1RegisteredModelSpecForProvider ForProvider { get; set; }

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
    public V1beta1RegisteredModelSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1RegisteredModelSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RegisteredModelSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RegisteredModelSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegisteredModelStatusAtProviderAliases
{
    /// <summary>The name of the registered model.  Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("aliasName")]
    public string? AliasName { get; set; }

    /// <summary>The name of the catalog where the schema and the registered model reside. Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>Equal to the full name of the model (catalog_name.schema_name.name) and used to identify the model uniquely across the metastore.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the registered model.  Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>The name of the schema where the registered model resides. Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    [JsonPropertyName("versionNum")]
    public double? VersionNum { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegisteredModelStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegisteredModelStatusAtProvider
{
    [JsonPropertyName("aliases")]
    public IList<V1beta1RegisteredModelStatusAtProviderAliases>? Aliases { get; set; }

    [JsonPropertyName("browseOnly")]
    public bool? BrowseOnly { get; set; }

    /// <summary>The name of the catalog where the schema and the registered model reside. Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("catalogName")]
    public string? CatalogName { get; set; }

    /// <summary>The comment attached to the registered model.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("createdAt")]
    public double? CreatedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>The name of the registered model.  Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    /// <summary>Equal to the full name of the model (catalog_name.schema_name.name) and used to identify the model uniquely across the metastore.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Equal to the full name of the model (catalog_name.schema_name.name) and used to identify the model uniquely across the metastore.</summary>
    [JsonPropertyName("metastoreId")]
    public string? MetastoreId { get; set; }

    /// <summary>The name of the registered model.  Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Name of the registered model owner.</summary>
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1RegisteredModelStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>The name of the schema where the registered model resides. Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("schemaName")]
    public string? SchemaName { get; set; }

    /// <summary>The storage location under which model version data files are stored.  If the URL contains special characters, such as space, &amp;, etc., they should be percent-encoded (space -&gt; %20, etc.). Change of this parameter forces recreation of the resource.</summary>
    [JsonPropertyName("storageLocation")]
    public string? StorageLocation { get; set; }

    [JsonPropertyName("updatedAt")]
    public double? UpdatedAt { get; set; }

    [JsonPropertyName("updatedBy")]
    public string? UpdatedBy { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegisteredModelStatusConditions
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

/// <summary>RegisteredModelStatus defines the observed state of RegisteredModel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegisteredModelStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1RegisteredModelStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RegisteredModelStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RegisteredModel is the Schema for the RegisteredModels API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RegisteredModel : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RegisteredModelSpec>, IStatus<V1beta1RegisteredModelStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegisteredModel";
    public const string KubeGroup = "unity.databricks.crossplane.io";
    public const string KubePluralName = "registeredmodels";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "unity.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegisteredModel";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegisteredModelSpec defines the desired state of RegisteredModel</summary>
    [JsonPropertyName("spec")]
    public required V1beta1RegisteredModelSpec Spec { get; set; }

    /// <summary>RegisteredModelStatus defines the observed state of RegisteredModel.</summary>
    [JsonPropertyName("status")]
    public V1beta1RegisteredModelStatus? Status { get; set; }
}
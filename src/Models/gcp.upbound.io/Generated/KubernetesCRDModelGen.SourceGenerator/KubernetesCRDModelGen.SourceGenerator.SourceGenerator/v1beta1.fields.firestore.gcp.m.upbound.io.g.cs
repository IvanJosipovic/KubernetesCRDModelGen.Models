#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.firestore.gcp.m.upbound.io;
/// <summary>Field is the Schema for the Fields API. Represents a single field in the database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FieldList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Field>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FieldList";
    public const string KubeGroup = "firestore.gcp.m.upbound.io";
    public const string KubePluralName = "fields";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firestore.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FieldList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Field objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Field> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FieldSpecForProviderDatabaseRefPolicyResolutionEnum>))]
public enum V1beta1FieldSpecForProviderDatabaseRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FieldSpecForProviderDatabaseRefPolicyResolveEnum>))]
public enum V1beta1FieldSpecForProviderDatabaseRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldSpecForProviderDatabaseRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FieldSpecForProviderDatabaseRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FieldSpecForProviderDatabaseRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Database in firestore to populate database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldSpecForProviderDatabaseRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FieldSpecForProviderDatabaseRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FieldSpecForProviderDatabaseSelectorPolicyResolutionEnum>))]
public enum V1beta1FieldSpecForProviderDatabaseSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FieldSpecForProviderDatabaseSelectorPolicyResolveEnum>))]
public enum V1beta1FieldSpecForProviderDatabaseSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldSpecForProviderDatabaseSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FieldSpecForProviderDatabaseSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FieldSpecForProviderDatabaseSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Database in firestore to populate database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldSpecForProviderDatabaseSelector
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
    public V1beta1FieldSpecForProviderDatabaseSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldSpecForProviderIndexConfigIndexes
{
    /// <summary>
    /// Indicates that this field supports operations on arrayValues. Only one of order and arrayConfig can
    /// be specified.
    /// Possible values are: CONTAINS.
    /// </summary>
    [JsonPropertyName("arrayConfig")]
    public string? ArrayConfig { get; set; }

    /// <summary>
    /// Indicates that this field supports ordering by the specified order or comparing using =, &lt;, &lt;=, &gt;, &gt;=, !=.
    /// Only one of order and arrayConfig can be specified.
    /// Possible values are: ASCENDING, DESCENDING.
    /// </summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary>
    /// The scope at which a query is run. Collection scoped queries require you specify
    /// the collection at query time. Collection group scope allows queries across all
    /// collections with the same id.
    /// Default value is COLLECTION.
    /// Possible values are: COLLECTION, COLLECTION_GROUP.
    /// </summary>
    [JsonPropertyName("queryScope")]
    public string? QueryScope { get; set; }
}

/// <summary>
/// The single field index configuration for this field.
/// Creating an index configuration for this field will override any inherited configuration with the
/// indexes specified. Configuring the index configuration with an empty block disables all indexes on
/// the field.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldSpecForProviderIndexConfig
{
    /// <summary>
    /// The indexes to configure on the field. Order or array contains must be specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("indexes")]
    public IList<V1beta1FieldSpecForProviderIndexConfigIndexes>? Indexes { get; set; }
}

/// <summary>
/// The TTL configuration for this Field. If set to an empty (i.e. ttl_config {}) or non-empty block, a TTL policy is configured based on the field. If unset, a TTL policy is not configured (or will be disabled upon updating the resource).
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldSpecForProviderTtlConfig
{
    /// <summary>The offset, relative to the timestamp value from the field, used to determine the document&apos;s expiration time. Formatted as the number of seconds followed by &apos;s&apos;. For example, &quot;60s&quot; represents an offset of one minute. The number of seconds must be between 1 and 2147483647 inclusive. To configure no offset, omit this field.</summary>
    [JsonPropertyName("expirationOffset")]
    public string? ExpirationOffset { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldSpecForProvider
{
    /// <summary>The id of the collection group to configure.</summary>
    [JsonPropertyName("collection")]
    public required string Collection { get; set; }

    /// <summary>The Firestore database id. Defaults to &quot;(default)&quot;.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Reference to a Database in firestore to populate database.</summary>
    [JsonPropertyName("databaseRef")]
    public V1beta1FieldSpecForProviderDatabaseRef? DatabaseRef { get; set; }

    /// <summary>Selector for a Database in firestore to populate database.</summary>
    [JsonPropertyName("databaseSelector")]
    public V1beta1FieldSpecForProviderDatabaseSelector? DatabaseSelector { get; set; }

    /// <summary>
    /// The single field index configuration for this field.
    /// Creating an index configuration for this field will override any inherited configuration with the
    /// indexes specified. Configuring the index configuration with an empty block disables all indexes on
    /// the field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("indexConfig")]
    public V1beta1FieldSpecForProviderIndexConfig? IndexConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The TTL configuration for this Field. If set to an empty (i.e. ttl_config {}) or non-empty block, a TTL policy is configured based on the field. If unset, a TTL policy is not configured (or will be disabled upon updating the resource).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ttlConfig")]
    public V1beta1FieldSpecForProviderTtlConfig? TtlConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldSpecInitProviderIndexConfigIndexes
{
    /// <summary>
    /// Indicates that this field supports operations on arrayValues. Only one of order and arrayConfig can
    /// be specified.
    /// Possible values are: CONTAINS.
    /// </summary>
    [JsonPropertyName("arrayConfig")]
    public string? ArrayConfig { get; set; }

    /// <summary>
    /// Indicates that this field supports ordering by the specified order or comparing using =, &lt;, &lt;=, &gt;, &gt;=, !=.
    /// Only one of order and arrayConfig can be specified.
    /// Possible values are: ASCENDING, DESCENDING.
    /// </summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary>
    /// The scope at which a query is run. Collection scoped queries require you specify
    /// the collection at query time. Collection group scope allows queries across all
    /// collections with the same id.
    /// Default value is COLLECTION.
    /// Possible values are: COLLECTION, COLLECTION_GROUP.
    /// </summary>
    [JsonPropertyName("queryScope")]
    public string? QueryScope { get; set; }
}

/// <summary>
/// The single field index configuration for this field.
/// Creating an index configuration for this field will override any inherited configuration with the
/// indexes specified. Configuring the index configuration with an empty block disables all indexes on
/// the field.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldSpecInitProviderIndexConfig
{
    /// <summary>
    /// The indexes to configure on the field. Order or array contains must be specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("indexes")]
    public IList<V1beta1FieldSpecInitProviderIndexConfigIndexes>? Indexes { get; set; }
}

/// <summary>
/// The TTL configuration for this Field. If set to an empty (i.e. ttl_config {}) or non-empty block, a TTL policy is configured based on the field. If unset, a TTL policy is not configured (or will be disabled upon updating the resource).
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldSpecInitProviderTtlConfig
{
    /// <summary>The offset, relative to the timestamp value from the field, used to determine the document&apos;s expiration time. Formatted as the number of seconds followed by &apos;s&apos;. For example, &quot;60s&quot; represents an offset of one minute. The number of seconds must be between 1 and 2147483647 inclusive. To configure no offset, omit this field.</summary>
    [JsonPropertyName("expirationOffset")]
    public string? ExpirationOffset { get; set; }
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
public partial class V1beta1FieldSpecInitProvider
{
    /// <summary>
    /// The single field index configuration for this field.
    /// Creating an index configuration for this field will override any inherited configuration with the
    /// indexes specified. Configuring the index configuration with an empty block disables all indexes on
    /// the field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("indexConfig")]
    public V1beta1FieldSpecInitProviderIndexConfig? IndexConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The TTL configuration for this Field. If set to an empty (i.e. ttl_config {}) or non-empty block, a TTL policy is configured based on the field. If unset, a TTL policy is not configured (or will be disabled upon updating the resource).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ttlConfig")]
    public V1beta1FieldSpecInitProviderTtlConfig? TtlConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FieldSpecManagementPoliciesEnum>))]
public enum V1beta1FieldSpecManagementPoliciesEnum
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
public partial class V1beta1FieldSpecProviderConfigRef
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
public partial class V1beta1FieldSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>FieldSpec defines the desired state of Field</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1FieldSpecForProvider ForProvider { get; set; }

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
    public V1beta1FieldSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1FieldSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FieldSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FieldSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldStatusAtProviderIndexConfigIndexes
{
    /// <summary>
    /// Indicates that this field supports operations on arrayValues. Only one of order and arrayConfig can
    /// be specified.
    /// Possible values are: CONTAINS.
    /// </summary>
    [JsonPropertyName("arrayConfig")]
    public string? ArrayConfig { get; set; }

    /// <summary>
    /// Indicates that this field supports ordering by the specified order or comparing using =, &lt;, &lt;=, &gt;, &gt;=, !=.
    /// Only one of order and arrayConfig can be specified.
    /// Possible values are: ASCENDING, DESCENDING.
    /// </summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary>
    /// The scope at which a query is run. Collection scoped queries require you specify
    /// the collection at query time. Collection group scope allows queries across all
    /// collections with the same id.
    /// Default value is COLLECTION.
    /// Possible values are: COLLECTION, COLLECTION_GROUP.
    /// </summary>
    [JsonPropertyName("queryScope")]
    public string? QueryScope { get; set; }
}

/// <summary>
/// The single field index configuration for this field.
/// Creating an index configuration for this field will override any inherited configuration with the
/// indexes specified. Configuring the index configuration with an empty block disables all indexes on
/// the field.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldStatusAtProviderIndexConfig
{
    /// <summary>
    /// The indexes to configure on the field. Order or array contains must be specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("indexes")]
    public IList<V1beta1FieldStatusAtProviderIndexConfigIndexes>? Indexes { get; set; }
}

/// <summary>
/// The TTL configuration for this Field. If set to an empty (i.e. ttl_config {}) or non-empty block, a TTL policy is configured based on the field. If unset, a TTL policy is not configured (or will be disabled upon updating the resource).
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldStatusAtProviderTtlConfig
{
    /// <summary>The offset, relative to the timestamp value from the field, used to determine the document&apos;s expiration time. Formatted as the number of seconds followed by &apos;s&apos;. For example, &quot;60s&quot; represents an offset of one minute. The number of seconds must be between 1 and 2147483647 inclusive. To configure no offset, omit this field.</summary>
    [JsonPropertyName("expirationOffset")]
    public string? ExpirationOffset { get; set; }

    /// <summary>
    /// (Output)
    /// The state of TTL (time-to-live) configuration for documents that have this Field set.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldStatusAtProvider
{
    /// <summary>The id of the collection group to configure.</summary>
    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    /// <summary>The Firestore database id. Defaults to &quot;(default)&quot;.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>
    /// Defaults to DELETE.
    /// When set to &quot;DELETE&quot;, deleting the resource is allowed.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The single field index configuration for this field.
    /// Creating an index configuration for this field will override any inherited configuration with the
    /// indexes specified. Configuring the index configuration with an empty block disables all indexes on
    /// the field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("indexConfig")]
    public V1beta1FieldStatusAtProviderIndexConfig? IndexConfig { get; set; }

    /// <summary>
    /// The name of this field. Format:
    /// projects/{{project}}/databases/{{database}}/collectionGroups/{{collection}}/fields/{{field}}
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The TTL configuration for this Field. If set to an empty (i.e. ttl_config {}) or non-empty block, a TTL policy is configured based on the field. If unset, a TTL policy is not configured (or will be disabled upon updating the resource).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ttlConfig")]
    public V1beta1FieldStatusAtProviderTtlConfig? TtlConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldStatusConditions
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

/// <summary>FieldStatus defines the observed state of Field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FieldStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1FieldStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FieldStatusConditions>? Conditions { get; set; }

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

/// <summary>Field is the Schema for the Fields API. Represents a single field in the database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Field : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FieldSpec>, IStatus<V1beta1FieldStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Field";
    public const string KubeGroup = "firestore.gcp.m.upbound.io";
    public const string KubePluralName = "fields";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firestore.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Field";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FieldSpec defines the desired state of Field</summary>
    [JsonPropertyName("spec")]
    public required V1beta1FieldSpec Spec { get; set; }

    /// <summary>FieldStatus defines the observed state of Field.</summary>
    [JsonPropertyName("status")]
    public V1beta1FieldStatus? Status { get; set; }
}
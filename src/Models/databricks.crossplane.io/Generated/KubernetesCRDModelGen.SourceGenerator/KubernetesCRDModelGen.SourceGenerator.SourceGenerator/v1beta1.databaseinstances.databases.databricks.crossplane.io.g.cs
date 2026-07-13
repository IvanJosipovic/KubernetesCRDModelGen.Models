#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.databases.databricks.crossplane.io;
/// <summary>DatabaseInstance is the Schema for the DatabaseInstances API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DatabaseInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DatabaseInstance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DatabaseInstanceList";
    public const string KubeGroup = "databases.databricks.crossplane.io";
    public const string KubePluralName = "databaseinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "databases.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatabaseInstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1DatabaseInstance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1DatabaseInstance> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatabaseInstanceSpecDeletionPolicyEnum>))]
public enum V1beta1DatabaseInstanceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderCustomTags
{
    /// <summary>The key of the custom tag</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the custom tag</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The ref of the parent instance. This is only available if the instance is
/// child instance.
/// Input: For specifying the parent instance to create a child instance. Optional.
/// Output: Only populated if provided as input to create a child instance
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderParentInstanceRef
{
    /// <summary>
    /// Branch time of the ref database instance.
    /// For a parent ref instance, this is the point in time on the parent instance from which the
    /// instance was created.
    /// For a child ref instance, this is the point in time on the instance from which the child
    /// instance was created.
    /// Input: For specifying the point in time to create a child instance. Optional.
    /// Output: Only populated if provided as input to create a child instance
    /// </summary>
    [JsonPropertyName("branchTime")]
    public string? BranchTime { get; set; }

    /// <summary>User-specified WAL LSN of the ref database instance.</summary>
    [JsonPropertyName("lsn")]
    public string? Lsn { get; set; }

    /// <summary>The name of the instance. This is the unique identifier for the instance</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProvider
{
    /// <summary>The sku of the instance. Valid values are &quot;CU_1&quot;, &quot;CU_2&quot;, &quot;CU_4&quot;, &quot;CU_8&quot;</summary>
    [JsonPropertyName("capacity")]
    public string? Capacity { get; set; }

    /// <summary>Custom tags associated with the instance. This field is only included on create and update responses</summary>
    [JsonPropertyName("customTags")]
    public IList<V1beta1DatabaseInstanceSpecForProviderCustomTags>? CustomTags { get; set; }

    /// <summary>Whether to enable PG native password login on the instance. Defaults to false</summary>
    [JsonPropertyName("enablePgNativeLogin")]
    public bool? EnablePgNativeLogin { get; set; }

    /// <summary>Whether to enable secondaries to serve read-only traffic. Defaults to false</summary>
    [JsonPropertyName("enableReadableSecondaries")]
    public bool? EnableReadableSecondaries { get; set; }

    /// <summary>
    /// The number of nodes in the instance, composed of 1 primary and 0 or more secondaries. Defaults to
    /// 1 primary and 0 secondaries. This field is input only, see effective_node_count for the output
    /// </summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>
    /// The ref of the parent instance. This is only available if the instance is
    /// child instance.
    /// Input: For specifying the parent instance to create a child instance. Optional.
    /// Output: Only populated if provided as input to create a child instance
    /// </summary>
    [JsonPropertyName("parentInstanceRef")]
    public V1beta1DatabaseInstanceSpecForProviderParentInstanceRef? ParentInstanceRef { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1DatabaseInstanceSpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Purge the resource on delete</summary>
    [JsonPropertyName("purgeOnDelete")]
    public bool? PurgeOnDelete { get; set; }

    /// <summary>
    /// The retention window for the instance. This is the time window in days
    /// for which the historical data is retained. The default value is 7 days.
    /// Valid values are 2 to 35 days
    /// </summary>
    [JsonPropertyName("retentionWindowInDays")]
    public double? RetentionWindowInDays { get; set; }

    /// <summary>Whether to stop the instance. An input only param, see effective_stopped for the output</summary>
    [JsonPropertyName("stopped")]
    public bool? Stopped { get; set; }

    /// <summary>The desired usage policy to associate with the instance</summary>
    [JsonPropertyName("usagePolicyId")]
    public string? UsagePolicyId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderCustomTags
{
    /// <summary>The key of the custom tag</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the custom tag</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The ref of the parent instance. This is only available if the instance is
/// child instance.
/// Input: For specifying the parent instance to create a child instance. Optional.
/// Output: Only populated if provided as input to create a child instance
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderParentInstanceRef
{
    /// <summary>
    /// Branch time of the ref database instance.
    /// For a parent ref instance, this is the point in time on the parent instance from which the
    /// instance was created.
    /// For a child ref instance, this is the point in time on the instance from which the child
    /// instance was created.
    /// Input: For specifying the point in time to create a child instance. Optional.
    /// Output: Only populated if provided as input to create a child instance
    /// </summary>
    [JsonPropertyName("branchTime")]
    public string? BranchTime { get; set; }

    /// <summary>User-specified WAL LSN of the ref database instance.</summary>
    [JsonPropertyName("lsn")]
    public string? Lsn { get; set; }

    /// <summary>The name of the instance. This is the unique identifier for the instance</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderProviderConfig
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
public partial class V1beta1DatabaseInstanceSpecInitProvider
{
    /// <summary>The sku of the instance. Valid values are &quot;CU_1&quot;, &quot;CU_2&quot;, &quot;CU_4&quot;, &quot;CU_8&quot;</summary>
    [JsonPropertyName("capacity")]
    public string? Capacity { get; set; }

    /// <summary>Custom tags associated with the instance. This field is only included on create and update responses</summary>
    [JsonPropertyName("customTags")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderCustomTags>? CustomTags { get; set; }

    /// <summary>Whether to enable PG native password login on the instance. Defaults to false</summary>
    [JsonPropertyName("enablePgNativeLogin")]
    public bool? EnablePgNativeLogin { get; set; }

    /// <summary>Whether to enable secondaries to serve read-only traffic. Defaults to false</summary>
    [JsonPropertyName("enableReadableSecondaries")]
    public bool? EnableReadableSecondaries { get; set; }

    /// <summary>
    /// The number of nodes in the instance, composed of 1 primary and 0 or more secondaries. Defaults to
    /// 1 primary and 0 secondaries. This field is input only, see effective_node_count for the output
    /// </summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>
    /// The ref of the parent instance. This is only available if the instance is
    /// child instance.
    /// Input: For specifying the parent instance to create a child instance. Optional.
    /// Output: Only populated if provided as input to create a child instance
    /// </summary>
    [JsonPropertyName("parentInstanceRef")]
    public V1beta1DatabaseInstanceSpecInitProviderParentInstanceRef? ParentInstanceRef { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1DatabaseInstanceSpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Purge the resource on delete</summary>
    [JsonPropertyName("purgeOnDelete")]
    public bool? PurgeOnDelete { get; set; }

    /// <summary>
    /// The retention window for the instance. This is the time window in days
    /// for which the historical data is retained. The default value is 7 days.
    /// Valid values are 2 to 35 days
    /// </summary>
    [JsonPropertyName("retentionWindowInDays")]
    public double? RetentionWindowInDays { get; set; }

    /// <summary>Whether to stop the instance. An input only param, see effective_stopped for the output</summary>
    [JsonPropertyName("stopped")]
    public bool? Stopped { get; set; }

    /// <summary>The desired usage policy to associate with the instance</summary>
    [JsonPropertyName("usagePolicyId")]
    public string? UsagePolicyId { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatabaseInstanceSpecManagementPoliciesEnum>))]
public enum V1beta1DatabaseInstanceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatabaseInstanceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1DatabaseInstanceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DatabaseInstanceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1DatabaseInstanceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DatabaseInstanceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DatabaseInstanceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatabaseInstanceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DatabaseInstanceSpec defines the desired state of DatabaseInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpec
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
    public V1beta1DatabaseInstanceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1DatabaseInstanceSpecForProvider ForProvider { get; set; }

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
    public V1beta1DatabaseInstanceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1DatabaseInstanceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DatabaseInstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DatabaseInstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderChildInstanceRefs
{
    /// <summary>
    /// Branch time of the ref database instance.
    /// For a parent ref instance, this is the point in time on the parent instance from which the
    /// instance was created.
    /// For a child ref instance, this is the point in time on the instance from which the child
    /// instance was created.
    /// Input: For specifying the point in time to create a child instance. Optional.
    /// Output: Only populated if provided as input to create a child instance
    /// </summary>
    [JsonPropertyName("branchTime")]
    public string? BranchTime { get; set; }

    /// <summary>
    /// For a parent ref instance, this is the LSN on the parent instance from which the
    /// instance was created.
    /// For a child ref instance, this is the LSN on the instance from which the child instance
    /// was created.
    /// This is an output only field that contains the value computed from the input field combined with
    /// server side defaults. Use the field without the effective_ prefix to set the value
    /// </summary>
    [JsonPropertyName("effectiveLsn")]
    public string? EffectiveLsn { get; set; }

    /// <summary>User-specified WAL LSN of the ref database instance.</summary>
    [JsonPropertyName("lsn")]
    public string? Lsn { get; set; }

    /// <summary>The name of the instance. This is the unique identifier for the instance</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>An immutable UUID identifier for the instance</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderCustomTags
{
    /// <summary>The key of the custom tag</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the custom tag</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderEffectiveCustomTags
{
    /// <summary>The key of the custom tag</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the custom tag</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The ref of the parent instance. This is only available if the instance is
/// child instance.
/// Input: For specifying the parent instance to create a child instance. Optional.
/// Output: Only populated if provided as input to create a child instance
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderParentInstanceRef
{
    /// <summary>
    /// Branch time of the ref database instance.
    /// For a parent ref instance, this is the point in time on the parent instance from which the
    /// instance was created.
    /// For a child ref instance, this is the point in time on the instance from which the child
    /// instance was created.
    /// Input: For specifying the point in time to create a child instance. Optional.
    /// Output: Only populated if provided as input to create a child instance
    /// </summary>
    [JsonPropertyName("branchTime")]
    public string? BranchTime { get; set; }

    /// <summary>
    /// For a parent ref instance, this is the LSN on the parent instance from which the
    /// instance was created.
    /// For a child ref instance, this is the LSN on the instance from which the child instance
    /// was created.
    /// This is an output only field that contains the value computed from the input field combined with
    /// server side defaults. Use the field without the effective_ prefix to set the value
    /// </summary>
    [JsonPropertyName("effectiveLsn")]
    public string? EffectiveLsn { get; set; }

    /// <summary>User-specified WAL LSN of the ref database instance.</summary>
    [JsonPropertyName("lsn")]
    public string? Lsn { get; set; }

    /// <summary>The name of the instance. This is the unique identifier for the instance</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>An immutable UUID identifier for the instance</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProvider
{
    /// <summary>The sku of the instance. Valid values are &quot;CU_1&quot;, &quot;CU_2&quot;, &quot;CU_4&quot;, &quot;CU_8&quot;</summary>
    [JsonPropertyName("capacity")]
    public string? Capacity { get; set; }

    /// <summary>
    /// The refs of the child instances. This is only available if the instance is
    /// parent instance
    /// </summary>
    [JsonPropertyName("childInstanceRefs")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderChildInstanceRefs>? ChildInstanceRefs { get; set; }

    /// <summary>The timestamp when the instance was created</summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>The email of the creator of the instance</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    /// <summary>Custom tags associated with the instance. This field is only included on create and update responses</summary>
    [JsonPropertyName("customTags")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderCustomTags>? CustomTags { get; set; }

    /// <summary>
    /// Deprecated. The sku of the instance; this field will always match the value of capacity.
    /// This is an output only field that contains the value computed from the input field combined with
    /// server side defaults. Use the field without the effective_ prefix to set the value
    /// </summary>
    [JsonPropertyName("effectiveCapacity")]
    public string? EffectiveCapacity { get; set; }

    /// <summary>
    /// The recorded custom tags associated with the instance.
    /// This is an output only field that contains the value computed from the input field combined with
    /// server side defaults. Use the field without the effective_ prefix to set the value
    /// </summary>
    [JsonPropertyName("effectiveCustomTags")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderEffectiveCustomTags>? EffectiveCustomTags { get; set; }

    /// <summary>
    /// Whether the instance has PG native password login enabled.
    /// This is an output only field that contains the value computed from the input field combined with
    /// server side defaults. Use the field without the effective_ prefix to set the value
    /// </summary>
    [JsonPropertyName("effectiveEnablePgNativeLogin")]
    public bool? EffectiveEnablePgNativeLogin { get; set; }

    /// <summary>
    /// Whether secondaries serving read-only traffic are enabled. Defaults to false.
    /// This is an output only field that contains the value computed from the input field combined with
    /// server side defaults. Use the field without the effective_ prefix to set the value
    /// </summary>
    [JsonPropertyName("effectiveEnableReadableSecondaries")]
    public bool? EffectiveEnableReadableSecondaries { get; set; }

    /// <summary>
    /// The number of nodes in the instance, composed of 1 primary and 0 or more secondaries. Defaults to
    /// 1 primary and 0 secondaries.
    /// This is an output only field that contains the value computed from the input field combined with
    /// server side defaults. Use the field without the effective_ prefix to set the value
    /// </summary>
    [JsonPropertyName("effectiveNodeCount")]
    public double? EffectiveNodeCount { get; set; }

    /// <summary>
    /// The retention window for the instance. This is the time window in days
    /// for which the historical data is retained.
    /// This is an output only field that contains the value computed from the input field combined with
    /// server side defaults. Use the field without the effective_ prefix to set the value
    /// </summary>
    [JsonPropertyName("effectiveRetentionWindowInDays")]
    public double? EffectiveRetentionWindowInDays { get; set; }

    /// <summary>
    /// Whether the instance is stopped.
    /// This is an output only field that contains the value computed from the input field combined with
    /// server side defaults. Use the field without the effective_ prefix to set the value
    /// </summary>
    [JsonPropertyName("effectiveStopped")]
    public bool? EffectiveStopped { get; set; }

    /// <summary>
    /// The policy that is applied to the instance.
    /// This is an output only field that contains the value computed from the input field combined with
    /// server side defaults. Use the field without the effective_ prefix to set the value
    /// </summary>
    [JsonPropertyName("effectiveUsagePolicyId")]
    public string? EffectiveUsagePolicyId { get; set; }

    /// <summary>Whether to enable PG native password login on the instance. Defaults to false</summary>
    [JsonPropertyName("enablePgNativeLogin")]
    public bool? EnablePgNativeLogin { get; set; }

    /// <summary>Whether to enable secondaries to serve read-only traffic. Defaults to false</summary>
    [JsonPropertyName("enableReadableSecondaries")]
    public bool? EnableReadableSecondaries { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The number of nodes in the instance, composed of 1 primary and 0 or more secondaries. Defaults to
    /// 1 primary and 0 secondaries. This field is input only, see effective_node_count for the output
    /// </summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>
    /// The ref of the parent instance. This is only available if the instance is
    /// child instance.
    /// Input: For specifying the parent instance to create a child instance. Optional.
    /// Output: Only populated if provided as input to create a child instance
    /// </summary>
    [JsonPropertyName("parentInstanceRef")]
    public V1beta1DatabaseInstanceStatusAtProviderParentInstanceRef? ParentInstanceRef { get; set; }

    /// <summary>The version of Postgres running on the instance</summary>
    [JsonPropertyName("pgVersion")]
    public string? PgVersion { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1DatabaseInstanceStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Purge the resource on delete</summary>
    [JsonPropertyName("purgeOnDelete")]
    public bool? PurgeOnDelete { get; set; }

    /// <summary>
    /// The DNS endpoint to connect to the instance for read only access. This is only available if
    /// enable_readable_secondaries is true
    /// </summary>
    [JsonPropertyName("readOnlyDns")]
    public string? ReadOnlyDns { get; set; }

    /// <summary>The DNS endpoint to connect to the instance for read+write access</summary>
    [JsonPropertyName("readWriteDns")]
    public string? ReadWriteDns { get; set; }

    /// <summary>
    /// The retention window for the instance. This is the time window in days
    /// for which the historical data is retained. The default value is 7 days.
    /// Valid values are 2 to 35 days
    /// </summary>
    [JsonPropertyName("retentionWindowInDays")]
    public double? RetentionWindowInDays { get; set; }

    /// <summary>The current state of the instance. Possible values are: AVAILABLE, DELETING, FAILING_OVER, STARTING, STOPPED, UPDATING</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Whether to stop the instance. An input only param, see effective_stopped for the output</summary>
    [JsonPropertyName("stopped")]
    public bool? Stopped { get; set; }

    /// <summary>An immutable UUID identifier for the instance</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>The desired usage policy to associate with the instance</summary>
    [JsonPropertyName("usagePolicyId")]
    public string? UsagePolicyId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusConditions
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

/// <summary>DatabaseInstanceStatus defines the observed state of DatabaseInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1DatabaseInstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DatabaseInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DatabaseInstance is the Schema for the DatabaseInstances API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DatabaseInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DatabaseInstanceSpec>, IStatus<V1beta1DatabaseInstanceStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DatabaseInstance";
    public const string KubeGroup = "databases.databricks.crossplane.io";
    public const string KubePluralName = "databaseinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "databases.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatabaseInstance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DatabaseInstanceSpec defines the desired state of DatabaseInstance</summary>
    [JsonPropertyName("spec")]
    public required V1beta1DatabaseInstanceSpec Spec { get; set; }

    /// <summary>DatabaseInstanceStatus defines the observed state of DatabaseInstance.</summary>
    [JsonPropertyName("status")]
    public V1beta1DatabaseInstanceStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgres.databricks.crossplane.io;
/// <summary>PostgresEndpoint is the Schema for the PostgresEndpoints API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PostgresEndpointList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PostgresEndpoint>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PostgresEndpointList";
    public const string KubeGroup = "postgres.databricks.crossplane.io";
    public const string KubePluralName = "postgresendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "postgres.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PostgresEndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1PostgresEndpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1PostgresEndpoint> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresEndpointSpecDeletionPolicyEnum>))]
public enum V1beta1PostgresEndpointSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresEndpointSpecForProviderParentRefPolicyResolutionEnum>))]
public enum V1beta1PostgresEndpointSpecForProviderParentRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresEndpointSpecForProviderParentRefPolicyResolveEnum>))]
public enum V1beta1PostgresEndpointSpecForProviderParentRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecForProviderParentRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PostgresEndpointSpecForProviderParentRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PostgresEndpointSpecForProviderParentRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a PostgresBranch in postgres to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecForProviderParentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PostgresEndpointSpecForProviderParentRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresEndpointSpecForProviderParentSelectorPolicyResolutionEnum>))]
public enum V1beta1PostgresEndpointSpecForProviderParentSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresEndpointSpecForProviderParentSelectorPolicyResolveEnum>))]
public enum V1beta1PostgresEndpointSpecForProviderParentSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecForProviderParentSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PostgresEndpointSpecForProviderParentSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PostgresEndpointSpecForProviderParentSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a PostgresBranch in postgres to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecForProviderParentSelector
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
    public V1beta1PostgresEndpointSpecForProviderParentSelectorPolicy? Policy { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>
/// Settings for optional HA configuration of the endpoint. If unspecified, the endpoint defaults
/// to non HA settings, with a single compute backing the endpoint (and no readable secondaries
/// for Read/Write endpoints)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecForProviderSpecGroup
{
    /// <summary>
    /// Whether to allow read-only connections to read-write endpoints. Only relevant for read-write endpoints where
    /// size.max &gt; 1
    /// </summary>
    [JsonPropertyName("enableReadableSecondaries")]
    public bool? EnableReadableSecondaries { get; set; }

    /// <summary>
    /// The maximum number of computes in the endpoint group. Currently, this must be equal to min. Set to 1 for single
    /// compute endpoints, to disable HA. To manually suspend all computes in an endpoint group, set disabled to
    /// true on the EndpointSpec
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// The minimum number of computes in the endpoint group. Currently, this must be equal to max. This must be greater
    /// than or equal to 1
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>(EndpointSettings, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecForProviderSpecSettings
{
    /// <summary>A raw representation of Postgres settings</summary>
    [JsonPropertyName("pgSettings")]
    public IDictionary<string, string>? PgSettings { get; set; }
}

/// <summary>The spec contains the compute endpoint configuration, including autoscaling limits, suspend timeout, and disabled state</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecForProviderSpec
{
    /// <summary>
    /// The maximum number of Compute Units. The maximum value is 64.
    /// The difference between the minimum and maximum Compute Units (max - min) must not exceed 16
    /// </summary>
    [JsonPropertyName("autoscalingLimitMaxCu")]
    public double? AutoscalingLimitMaxCu { get; set; }

    /// <summary>The minimum number of Compute Units. Minimum value is 0.5</summary>
    [JsonPropertyName("autoscalingLimitMinCu")]
    public double? AutoscalingLimitMinCu { get; set; }

    /// <summary>
    /// Whether to restrict connections to the compute endpoint.
    /// Enabling this option schedules a suspend compute operation.
    /// A disabled compute endpoint cannot be enabled by a connection or
    /// console action
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The endpoint type. A branch can only have one READ_WRITE endpoint. Possible values are: ENDPOINT_TYPE_READ_ONLY, ENDPOINT_TYPE_READ_WRITE</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// Settings for optional HA configuration of the endpoint. If unspecified, the endpoint defaults
    /// to non HA settings, with a single compute backing the endpoint (and no readable secondaries
    /// for Read/Write endpoints)
    /// </summary>
    [JsonPropertyName("group")]
    public V1beta1PostgresEndpointSpecForProviderSpecGroup? Group { get; set; }

    /// <summary>
    /// When set to true, explicitly disables automatic suspension (never suspend).
    /// Should be set to true when provided.
    /// Mutually exclusive with suspend_timeout_duration. When updating, use spec.suspension in the update_mask
    /// </summary>
    [JsonPropertyName("noSuspension")]
    public bool? NoSuspension { get; set; }

    /// <summary>(EndpointSettings, optional)</summary>
    [JsonPropertyName("settings")]
    public V1beta1PostgresEndpointSpecForProviderSpecSettings? Settings { get; set; }

    /// <summary>
    /// Duration of inactivity after which the compute endpoint is automatically suspended.
    /// If specified should be between 60s and 604800s (1 minute to 1 week).
    /// Mutually exclusive with no_suspension. When updating, use spec.suspension in the update_mask
    /// </summary>
    [JsonPropertyName("suspendTimeoutDuration")]
    public string? SuspendTimeoutDuration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecForProvider
{
    /// <summary>The part of the name, chosen by the user when the resource was created</summary>
    [JsonPropertyName("endpointId")]
    public string? EndpointId { get; set; }

    /// <summary>
    /// The branch containing this endpoint (API resource hierarchy).
    /// Format: projects/{project_id}/branches/{branch_id}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Reference to a PostgresBranch in postgres to populate parent.</summary>
    [JsonPropertyName("parentRef")]
    public V1beta1PostgresEndpointSpecForProviderParentRef? ParentRef { get; set; }

    /// <summary>Selector for a PostgresBranch in postgres to populate parent.</summary>
    [JsonPropertyName("parentSelector")]
    public V1beta1PostgresEndpointSpecForProviderParentSelector? ParentSelector { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1PostgresEndpointSpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>If true, update the endpoint if it already exists instead of returning an error</summary>
    [JsonPropertyName("replaceExisting")]
    public bool? ReplaceExisting { get; set; }

    /// <summary>The spec contains the compute endpoint configuration, including autoscaling limits, suspend timeout, and disabled state</summary>
    [JsonPropertyName("spec")]
    public V1beta1PostgresEndpointSpecForProviderSpec? Spec { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresEndpointSpecInitProviderParentRefPolicyResolutionEnum>))]
public enum V1beta1PostgresEndpointSpecInitProviderParentRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresEndpointSpecInitProviderParentRefPolicyResolveEnum>))]
public enum V1beta1PostgresEndpointSpecInitProviderParentRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecInitProviderParentRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PostgresEndpointSpecInitProviderParentRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PostgresEndpointSpecInitProviderParentRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a PostgresBranch in postgres to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecInitProviderParentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PostgresEndpointSpecInitProviderParentRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresEndpointSpecInitProviderParentSelectorPolicyResolutionEnum>))]
public enum V1beta1PostgresEndpointSpecInitProviderParentSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresEndpointSpecInitProviderParentSelectorPolicyResolveEnum>))]
public enum V1beta1PostgresEndpointSpecInitProviderParentSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecInitProviderParentSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PostgresEndpointSpecInitProviderParentSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PostgresEndpointSpecInitProviderParentSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a PostgresBranch in postgres to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecInitProviderParentSelector
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
    public V1beta1PostgresEndpointSpecInitProviderParentSelectorPolicy? Policy { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>
/// Settings for optional HA configuration of the endpoint. If unspecified, the endpoint defaults
/// to non HA settings, with a single compute backing the endpoint (and no readable secondaries
/// for Read/Write endpoints)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecInitProviderSpecGroup
{
    /// <summary>
    /// Whether to allow read-only connections to read-write endpoints. Only relevant for read-write endpoints where
    /// size.max &gt; 1
    /// </summary>
    [JsonPropertyName("enableReadableSecondaries")]
    public bool? EnableReadableSecondaries { get; set; }

    /// <summary>
    /// The maximum number of computes in the endpoint group. Currently, this must be equal to min. Set to 1 for single
    /// compute endpoints, to disable HA. To manually suspend all computes in an endpoint group, set disabled to
    /// true on the EndpointSpec
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// The minimum number of computes in the endpoint group. Currently, this must be equal to max. This must be greater
    /// than or equal to 1
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>(EndpointSettings, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecInitProviderSpecSettings
{
    /// <summary>A raw representation of Postgres settings</summary>
    [JsonPropertyName("pgSettings")]
    public IDictionary<string, string>? PgSettings { get; set; }
}

/// <summary>The spec contains the compute endpoint configuration, including autoscaling limits, suspend timeout, and disabled state</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecInitProviderSpec
{
    /// <summary>
    /// The maximum number of Compute Units. The maximum value is 64.
    /// The difference between the minimum and maximum Compute Units (max - min) must not exceed 16
    /// </summary>
    [JsonPropertyName("autoscalingLimitMaxCu")]
    public double? AutoscalingLimitMaxCu { get; set; }

    /// <summary>The minimum number of Compute Units. Minimum value is 0.5</summary>
    [JsonPropertyName("autoscalingLimitMinCu")]
    public double? AutoscalingLimitMinCu { get; set; }

    /// <summary>
    /// Whether to restrict connections to the compute endpoint.
    /// Enabling this option schedules a suspend compute operation.
    /// A disabled compute endpoint cannot be enabled by a connection or
    /// console action
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The endpoint type. A branch can only have one READ_WRITE endpoint. Possible values are: ENDPOINT_TYPE_READ_ONLY, ENDPOINT_TYPE_READ_WRITE</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// Settings for optional HA configuration of the endpoint. If unspecified, the endpoint defaults
    /// to non HA settings, with a single compute backing the endpoint (and no readable secondaries
    /// for Read/Write endpoints)
    /// </summary>
    [JsonPropertyName("group")]
    public V1beta1PostgresEndpointSpecInitProviderSpecGroup? Group { get; set; }

    /// <summary>
    /// When set to true, explicitly disables automatic suspension (never suspend).
    /// Should be set to true when provided.
    /// Mutually exclusive with suspend_timeout_duration. When updating, use spec.suspension in the update_mask
    /// </summary>
    [JsonPropertyName("noSuspension")]
    public bool? NoSuspension { get; set; }

    /// <summary>(EndpointSettings, optional)</summary>
    [JsonPropertyName("settings")]
    public V1beta1PostgresEndpointSpecInitProviderSpecSettings? Settings { get; set; }

    /// <summary>
    /// Duration of inactivity after which the compute endpoint is automatically suspended.
    /// If specified should be between 60s and 604800s (1 minute to 1 week).
    /// Mutually exclusive with no_suspension. When updating, use spec.suspension in the update_mask
    /// </summary>
    [JsonPropertyName("suspendTimeoutDuration")]
    public string? SuspendTimeoutDuration { get; set; }
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
public partial class V1beta1PostgresEndpointSpecInitProvider
{
    /// <summary>The part of the name, chosen by the user when the resource was created</summary>
    [JsonPropertyName("endpointId")]
    public string? EndpointId { get; set; }

    /// <summary>
    /// The branch containing this endpoint (API resource hierarchy).
    /// Format: projects/{project_id}/branches/{branch_id}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Reference to a PostgresBranch in postgres to populate parent.</summary>
    [JsonPropertyName("parentRef")]
    public V1beta1PostgresEndpointSpecInitProviderParentRef? ParentRef { get; set; }

    /// <summary>Selector for a PostgresBranch in postgres to populate parent.</summary>
    [JsonPropertyName("parentSelector")]
    public V1beta1PostgresEndpointSpecInitProviderParentSelector? ParentSelector { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1PostgresEndpointSpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>If true, update the endpoint if it already exists instead of returning an error</summary>
    [JsonPropertyName("replaceExisting")]
    public bool? ReplaceExisting { get; set; }

    /// <summary>The spec contains the compute endpoint configuration, including autoscaling limits, suspend timeout, and disabled state</summary>
    [JsonPropertyName("spec")]
    public V1beta1PostgresEndpointSpecInitProviderSpec? Spec { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresEndpointSpecManagementPoliciesEnum>))]
public enum V1beta1PostgresEndpointSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresEndpointSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1PostgresEndpointSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PostgresEndpointSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1PostgresEndpointSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PostgresEndpointSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PostgresEndpointSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PostgresEndpointSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>PostgresEndpointSpec defines the desired state of PostgresEndpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointSpec
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
    public V1beta1PostgresEndpointSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1PostgresEndpointSpecForProvider ForProvider { get; set; }

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
    public V1beta1PostgresEndpointSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1PostgresEndpointSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PostgresEndpointSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PostgresEndpointSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>
/// Settings for optional HA configuration of the endpoint. If unspecified, the endpoint defaults
/// to non HA settings, with a single compute backing the endpoint (and no readable secondaries
/// for Read/Write endpoints)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointStatusAtProviderSpecGroup
{
    /// <summary>
    /// Whether to allow read-only connections to read-write endpoints. Only relevant for read-write endpoints where
    /// size.max &gt; 1
    /// </summary>
    [JsonPropertyName("enableReadableSecondaries")]
    public bool? EnableReadableSecondaries { get; set; }

    /// <summary>
    /// The maximum number of computes in the endpoint group. Currently, this must be equal to min. Set to 1 for single
    /// compute endpoints, to disable HA. To manually suspend all computes in an endpoint group, set disabled to
    /// true on the EndpointSpec
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// The minimum number of computes in the endpoint group. Currently, this must be equal to max. This must be greater
    /// than or equal to 1
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>(EndpointSettings, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointStatusAtProviderSpecSettings
{
    /// <summary>A raw representation of Postgres settings</summary>
    [JsonPropertyName("pgSettings")]
    public IDictionary<string, string>? PgSettings { get; set; }
}

/// <summary>The spec contains the compute endpoint configuration, including autoscaling limits, suspend timeout, and disabled state</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointStatusAtProviderSpec
{
    /// <summary>
    /// The maximum number of Compute Units. The maximum value is 64.
    /// The difference between the minimum and maximum Compute Units (max - min) must not exceed 16
    /// </summary>
    [JsonPropertyName("autoscalingLimitMaxCu")]
    public double? AutoscalingLimitMaxCu { get; set; }

    /// <summary>The minimum number of Compute Units. Minimum value is 0.5</summary>
    [JsonPropertyName("autoscalingLimitMinCu")]
    public double? AutoscalingLimitMinCu { get; set; }

    /// <summary>
    /// Whether to restrict connections to the compute endpoint.
    /// Enabling this option schedules a suspend compute operation.
    /// A disabled compute endpoint cannot be enabled by a connection or
    /// console action
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The endpoint type. A branch can only have one READ_WRITE endpoint. Possible values are: ENDPOINT_TYPE_READ_ONLY, ENDPOINT_TYPE_READ_WRITE</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// Settings for optional HA configuration of the endpoint. If unspecified, the endpoint defaults
    /// to non HA settings, with a single compute backing the endpoint (and no readable secondaries
    /// for Read/Write endpoints)
    /// </summary>
    [JsonPropertyName("group")]
    public V1beta1PostgresEndpointStatusAtProviderSpecGroup? Group { get; set; }

    /// <summary>
    /// When set to true, explicitly disables automatic suspension (never suspend).
    /// Should be set to true when provided.
    /// Mutually exclusive with suspend_timeout_duration. When updating, use spec.suspension in the update_mask
    /// </summary>
    [JsonPropertyName("noSuspension")]
    public bool? NoSuspension { get; set; }

    /// <summary>(EndpointSettings, optional)</summary>
    [JsonPropertyName("settings")]
    public V1beta1PostgresEndpointStatusAtProviderSpecSettings? Settings { get; set; }

    /// <summary>
    /// Duration of inactivity after which the compute endpoint is automatically suspended.
    /// If specified should be between 60s and 604800s (1 minute to 1 week).
    /// Mutually exclusive with no_suspension. When updating, use spec.suspension in the update_mask
    /// </summary>
    [JsonPropertyName("suspendTimeoutDuration")]
    public string? SuspendTimeoutDuration { get; set; }
}

/// <summary>
/// Settings for optional HA configuration of the endpoint. If unspecified, the endpoint defaults
/// to non HA settings, with a single compute backing the endpoint (and no readable secondaries
/// for Read/Write endpoints)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointStatusAtProviderStatusGroup
{
    /// <summary>
    /// Whether to allow read-only connections to read-write endpoints. Only relevant for read-write endpoints where
    /// size.max &gt; 1
    /// </summary>
    [JsonPropertyName("enableReadableSecondaries")]
    public bool? EnableReadableSecondaries { get; set; }

    /// <summary>
    /// The maximum number of computes in the endpoint group. Currently, this must be equal to min. Set to 1 for single
    /// compute endpoints, to disable HA. To manually suspend all computes in an endpoint group, set disabled to
    /// true on the EndpointSpec
    /// </summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>
    /// The minimum number of computes in the endpoint group. Currently, this must be equal to max. This must be greater
    /// than or equal to 1
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Contains host information for connecting to the endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointStatusAtProviderStatusHosts
{
    /// <summary>
    /// The hostname to connect to this endpoint. For read-write endpoints, this is a read-write hostname which connects
    /// to the primary compute. For read-only endpoints, this is a read-only hostname which allows read-only operations
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// An optionally defined read-only host for the endpoint, without pooling. For read-only endpoints,
    /// this attribute is always defined and is equivalent to host. For read-write endpoints, this attribute is defined
    /// if the enclosing endpoint is a group with greater than 1 computes configured, and has readable secondaries enabled
    /// </summary>
    [JsonPropertyName("readOnlyHost")]
    public string? ReadOnlyHost { get; set; }

    /// <summary>
    /// The read-only hostname of the compute endpoint, with pooling. This attribute is always defined for read-only endpoints,
    /// and may be defined for read-write endpoints if configured with read replicas and allow read-only connections
    /// </summary>
    [JsonPropertyName("readOnlyPooledHost")]
    public string? ReadOnlyPooledHost { get; set; }

    /// <summary>The read-write hostname of the compute endpoint, with pooling. This attribute is only defined for read-write endpoints</summary>
    [JsonPropertyName("readWritePooledHost")]
    public string? ReadWritePooledHost { get; set; }
}

/// <summary>(EndpointSettings, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointStatusAtProviderStatusSettings
{
    /// <summary>A raw representation of Postgres settings</summary>
    [JsonPropertyName("pgSettings")]
    public IDictionary<string, string>? PgSettings { get; set; }
}

/// <summary>Current operational status of the compute endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointStatusAtProviderStatus
{
    /// <summary>
    /// The maximum number of Compute Units. The maximum value is 64.
    /// The difference between the minimum and maximum Compute Units (max - min) must not exceed 16
    /// </summary>
    [JsonPropertyName("autoscalingLimitMaxCu")]
    public double? AutoscalingLimitMaxCu { get; set; }

    /// <summary>The minimum number of Compute Units. Minimum value is 0.5</summary>
    [JsonPropertyName("autoscalingLimitMinCu")]
    public double? AutoscalingLimitMinCu { get; set; }

    /// <summary>Possible values are: ACTIVE, DEGRADED, IDLE, INIT</summary>
    [JsonPropertyName("currentState")]
    public string? CurrentState { get; set; }

    /// <summary>
    /// Whether to restrict connections to the compute endpoint.
    /// Enabling this option schedules a suspend compute operation.
    /// A disabled compute endpoint cannot be enabled by a connection or
    /// console action
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The part of the name, chosen by the user when the resource was created</summary>
    [JsonPropertyName("endpointId")]
    public string? EndpointId { get; set; }

    /// <summary>The endpoint type. A branch can only have one READ_WRITE endpoint. Possible values are: ENDPOINT_TYPE_READ_ONLY, ENDPOINT_TYPE_READ_WRITE</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// Settings for optional HA configuration of the endpoint. If unspecified, the endpoint defaults
    /// to non HA settings, with a single compute backing the endpoint (and no readable secondaries
    /// for Read/Write endpoints)
    /// </summary>
    [JsonPropertyName("group")]
    public V1beta1PostgresEndpointStatusAtProviderStatusGroup? Group { get; set; }

    /// <summary>Contains host information for connecting to the endpoint</summary>
    [JsonPropertyName("hosts")]
    public V1beta1PostgresEndpointStatusAtProviderStatusHosts? Hosts { get; set; }

    /// <summary>A timestamp indicating when the compute endpoint was last active</summary>
    [JsonPropertyName("lastActiveTime")]
    public string? LastActiveTime { get; set; }

    /// <summary>Possible values are: ACTIVE, DEGRADED, IDLE, INIT</summary>
    [JsonPropertyName("pendingState")]
    public string? PendingState { get; set; }

    /// <summary>(EndpointSettings, optional)</summary>
    [JsonPropertyName("settings")]
    public V1beta1PostgresEndpointStatusAtProviderStatusSettings? Settings { get; set; }

    /// <summary>
    /// Duration of inactivity after which the compute endpoint is automatically suspended.
    /// If specified should be between 60s and 604800s (1 minute to 1 week).
    /// Mutually exclusive with no_suspension. When updating, use spec.suspension in the update_mask
    /// </summary>
    [JsonPropertyName("suspendTimeoutDuration")]
    public string? SuspendTimeoutDuration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointStatusAtProvider
{
    /// <summary>A timestamp indicating when the compute endpoint was created</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The part of the name, chosen by the user when the resource was created</summary>
    [JsonPropertyName("endpointId")]
    public string? EndpointId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The branch containing this endpoint (API resource hierarchy).
    /// Format: projects/{project_id}/branches/{branch_id}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1PostgresEndpointStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>If true, update the endpoint if it already exists instead of returning an error</summary>
    [JsonPropertyName("replaceExisting")]
    public bool? ReplaceExisting { get; set; }

    /// <summary>The spec contains the compute endpoint configuration, including autoscaling limits, suspend timeout, and disabled state</summary>
    [JsonPropertyName("spec")]
    public V1beta1PostgresEndpointStatusAtProviderSpec? Spec { get; set; }

    /// <summary>Current operational status of the compute endpoint</summary>
    [JsonPropertyName("status")]
    public V1beta1PostgresEndpointStatusAtProviderStatus? Status { get; set; }

    /// <summary>System-generated unique ID for the endpoint</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>A timestamp indicating when the compute endpoint was last updated</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointStatusConditions
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

/// <summary>PostgresEndpointStatus defines the observed state of PostgresEndpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PostgresEndpointStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1PostgresEndpointStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PostgresEndpointStatusConditions>? Conditions { get; set; }

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

/// <summary>PostgresEndpoint is the Schema for the PostgresEndpoints API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PostgresEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PostgresEndpointSpec>, IStatus<V1beta1PostgresEndpointStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PostgresEndpoint";
    public const string KubeGroup = "postgres.databricks.crossplane.io";
    public const string KubePluralName = "postgresendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "postgres.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PostgresEndpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PostgresEndpointSpec defines the desired state of PostgresEndpoint</summary>
    [JsonPropertyName("spec")]
    public required V1beta1PostgresEndpointSpec Spec { get; set; }

    /// <summary>PostgresEndpointStatus defines the observed state of PostgresEndpoint.</summary>
    [JsonPropertyName("status")]
    public V1beta1PostgresEndpointStatus? Status { get; set; }
}
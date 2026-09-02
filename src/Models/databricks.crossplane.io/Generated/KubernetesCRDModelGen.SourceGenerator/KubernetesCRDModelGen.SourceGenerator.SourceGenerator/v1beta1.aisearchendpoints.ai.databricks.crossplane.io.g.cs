#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ai.databricks.crossplane.io;
/// <summary>AISearchEndpoint is the Schema for the AISearchEndpoints API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AISearchEndpointList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AISearchEndpoint>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AISearchEndpointList";
    public const string KubeGroup = "ai.databricks.crossplane.io";
    public const string KubePluralName = "aisearchendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ai.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AISearchEndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1AISearchEndpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1AISearchEndpoint> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AISearchEndpointSpecDeletionPolicyEnum>))]
public enum V1beta1AISearchEndpointSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchEndpointSpecForProviderCustomTags
{
    /// <summary>Key field for an AI Search endpoint tag</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>[Optional] Value field for an AI Search endpoint tag</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchEndpointSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchEndpointSpecForProvider
{
    /// <summary>The user-selected budget policy id for the endpoint</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>The custom tags assigned to the endpoint</summary>
    [JsonPropertyName("customTags")]
    public IList<V1beta1AISearchEndpointSpecForProviderCustomTags>? CustomTags { get; set; }

    /// <summary>
    /// The user-supplied short name for the Endpoint, per AIP-133. The server composes the
    /// full Endpoint.name as {parent}/endpoints/{endpoint_id}. AIP-133 does not list
    /// endpoint_id as a fields-may-be-required entry, so we annotate it OPTIONAL on the
    /// wire; the server still rejects empty values with INVALID_PARAMETER_VALUE
    /// </summary>
    [JsonPropertyName("endpointId")]
    public string? EndpointId { get; set; }

    /// <summary>Type of endpoint. Required on create and immutable thereafter. Possible values are: STANDARD, STORAGE_OPTIMIZED</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// The Workspace where this Endpoint will be created.
    /// Format: workspaces/{workspace_id}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1AISearchEndpointSpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>
    /// The client-supplied desired number of replicas for the endpoint, applied at
    /// create/update time. Mutually exclusive with target_qps
    /// </summary>
    [JsonPropertyName("replicaCount")]
    public double? ReplicaCount { get; set; }

    /// <summary>
    /// Target QPS for the endpoint. Mutually exclusive with replica_count. Best-effort;
    /// the system does not guarantee this QPS will be achieved
    /// </summary>
    [JsonPropertyName("targetQps")]
    public double? TargetQps { get; set; }

    /// <summary>The usage policy id applied to the endpoint</summary>
    [JsonPropertyName("usagePolicyId")]
    public string? UsagePolicyId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchEndpointSpecInitProviderCustomTags
{
    /// <summary>Key field for an AI Search endpoint tag</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>[Optional] Value field for an AI Search endpoint tag</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchEndpointSpecInitProviderProviderConfig
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
public partial class V1beta1AISearchEndpointSpecInitProvider
{
    /// <summary>The user-selected budget policy id for the endpoint</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>The custom tags assigned to the endpoint</summary>
    [JsonPropertyName("customTags")]
    public IList<V1beta1AISearchEndpointSpecInitProviderCustomTags>? CustomTags { get; set; }

    /// <summary>
    /// The user-supplied short name for the Endpoint, per AIP-133. The server composes the
    /// full Endpoint.name as {parent}/endpoints/{endpoint_id}. AIP-133 does not list
    /// endpoint_id as a fields-may-be-required entry, so we annotate it OPTIONAL on the
    /// wire; the server still rejects empty values with INVALID_PARAMETER_VALUE
    /// </summary>
    [JsonPropertyName("endpointId")]
    public string? EndpointId { get; set; }

    /// <summary>Type of endpoint. Required on create and immutable thereafter. Possible values are: STANDARD, STORAGE_OPTIMIZED</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// The Workspace where this Endpoint will be created.
    /// Format: workspaces/{workspace_id}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1AISearchEndpointSpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>
    /// The client-supplied desired number of replicas for the endpoint, applied at
    /// create/update time. Mutually exclusive with target_qps
    /// </summary>
    [JsonPropertyName("replicaCount")]
    public double? ReplicaCount { get; set; }

    /// <summary>
    /// Target QPS for the endpoint. Mutually exclusive with replica_count. Best-effort;
    /// the system does not guarantee this QPS will be achieved
    /// </summary>
    [JsonPropertyName("targetQps")]
    public double? TargetQps { get; set; }

    /// <summary>The usage policy id applied to the endpoint</summary>
    [JsonPropertyName("usagePolicyId")]
    public string? UsagePolicyId { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AISearchEndpointSpecManagementPoliciesEnum>))]
public enum V1beta1AISearchEndpointSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AISearchEndpointSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1AISearchEndpointSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AISearchEndpointSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1AISearchEndpointSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchEndpointSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AISearchEndpointSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AISearchEndpointSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchEndpointSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AISearchEndpointSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchEndpointSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AISearchEndpointSpec defines the desired state of AISearchEndpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchEndpointSpec
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
    public V1beta1AISearchEndpointSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1AISearchEndpointSpecForProvider ForProvider { get; set; }

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
    public V1beta1AISearchEndpointSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1AISearchEndpointSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AISearchEndpointSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AISearchEndpointSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchEndpointStatusAtProviderCustomTags
{
    /// <summary>Key field for an AI Search endpoint tag</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>[Optional] Value field for an AI Search endpoint tag</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Current status of the endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchEndpointStatusAtProviderEndpointStatus
{
    /// <summary>Human-readable detail about the endpoint&apos;s current state or the reason for a state transition</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The current state of the scaling change request. Possible values are: SCALING_CHANGE_APPLIED, SCALING_CHANGE_IN_PROGRESS, SCALING_CHANGE_UNSPECIFIED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchEndpointStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>Scaling information for the endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchEndpointStatusAtProviderScalingInfo
{
    /// <summary>
    /// The requested QPS target for the endpoint. Best-effort; the system does not
    /// guarantee this QPS will be achieved
    /// </summary>
    [JsonPropertyName("requestedTargetQps")]
    public double? RequestedTargetQps { get; set; }

    /// <summary>The current state of the scaling change request. Possible values are: SCALING_CHANGE_APPLIED, SCALING_CHANGE_IN_PROGRESS, SCALING_CHANGE_UNSPECIFIED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Throughput information for the endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchEndpointStatusAtProviderThroughputInfo
{
    /// <summary>Additional information about the throughput change request</summary>
    [JsonPropertyName("changeRequestMessage")]
    public string? ChangeRequestMessage { get; set; }

    /// <summary>The state of the most recent throughput change request. Possible values are: CHANGE_ADJUSTED, CHANGE_FAILED, CHANGE_IN_PROGRESS, CHANGE_REACHED_MAXIMUM, CHANGE_REACHED_MINIMUM, CHANGE_SUCCESS</summary>
    [JsonPropertyName("changeRequestState")]
    public string? ChangeRequestState { get; set; }

    /// <summary>The current concurrency (total CPU) allocated to the endpoint</summary>
    [JsonPropertyName("currentConcurrency")]
    public double? CurrentConcurrency { get; set; }

    /// <summary>The current utilization of concurrency as a percentage (0-100)</summary>
    [JsonPropertyName("currentConcurrencyUtilizationPercentage")]
    public double? CurrentConcurrencyUtilizationPercentage { get; set; }

    /// <summary>The current number of replicas allocated to the endpoint</summary>
    [JsonPropertyName("currentNumReplicas")]
    public double? CurrentNumReplicas { get; set; }

    /// <summary>The maximum concurrency allowed for this endpoint</summary>
    [JsonPropertyName("maximumConcurrencyAllowed")]
    public double? MaximumConcurrencyAllowed { get; set; }

    /// <summary>The minimum concurrency allowed for this endpoint</summary>
    [JsonPropertyName("minimalConcurrencyAllowed")]
    public double? MinimalConcurrencyAllowed { get; set; }

    /// <summary>The requested concurrency (total CPU) for the endpoint</summary>
    [JsonPropertyName("requestedConcurrency")]
    public double? RequestedConcurrency { get; set; }

    /// <summary>The requested number of replicas for the endpoint</summary>
    [JsonPropertyName("requestedNumReplicas")]
    public double? RequestedNumReplicas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchEndpointStatusAtProvider
{
    /// <summary>The user-selected budget policy id for the endpoint</summary>
    [JsonPropertyName("budgetPolicyId")]
    public string? BudgetPolicyId { get; set; }

    /// <summary>Time the endpoint was created</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Creator of the endpoint</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    /// <summary>The custom tags assigned to the endpoint</summary>
    [JsonPropertyName("customTags")]
    public IList<V1beta1AISearchEndpointStatusAtProviderCustomTags>? CustomTags { get; set; }

    /// <summary>The budget policy id applied to the endpoint</summary>
    [JsonPropertyName("effectiveBudgetPolicyId")]
    public string? EffectiveBudgetPolicyId { get; set; }

    /// <summary>
    /// The user-supplied short name for the Endpoint, per AIP-133. The server composes the
    /// full Endpoint.name as {parent}/endpoints/{endpoint_id}. AIP-133 does not list
    /// endpoint_id as a fields-may-be-required entry, so we annotate it OPTIONAL on the
    /// wire; the server still rejects empty values with INVALID_PARAMETER_VALUE
    /// </summary>
    [JsonPropertyName("endpointId")]
    public string? EndpointId { get; set; }

    /// <summary>Current status of the endpoint</summary>
    [JsonPropertyName("endpointStatus")]
    public V1beta1AISearchEndpointStatusAtProviderEndpointStatus? EndpointStatus { get; set; }

    /// <summary>Type of endpoint. Required on create and immutable thereafter. Possible values are: STANDARD, STORAGE_OPTIMIZED</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>Unique identifier of the endpoint</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Number of indexes on the endpoint</summary>
    [JsonPropertyName("indexCount")]
    public double? IndexCount { get; set; }

    /// <summary>User who last updated the endpoint</summary>
    [JsonPropertyName("lastUpdatedUser")]
    public string? LastUpdatedUser { get; set; }

    /// <summary>
    /// The Workspace where this Endpoint will be created.
    /// Format: workspaces/{workspace_id}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1AISearchEndpointStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>
    /// The client-supplied desired number of replicas for the endpoint, applied at
    /// create/update time. Mutually exclusive with target_qps
    /// </summary>
    [JsonPropertyName("replicaCount")]
    public double? ReplicaCount { get; set; }

    /// <summary>Scaling information for the endpoint</summary>
    [JsonPropertyName("scalingInfo")]
    public V1beta1AISearchEndpointStatusAtProviderScalingInfo? ScalingInfo { get; set; }

    /// <summary>
    /// Target QPS for the endpoint. Mutually exclusive with replica_count. Best-effort;
    /// the system does not guarantee this QPS will be achieved
    /// </summary>
    [JsonPropertyName("targetQps")]
    public double? TargetQps { get; set; }

    /// <summary>Throughput information for the endpoint</summary>
    [JsonPropertyName("throughputInfo")]
    public V1beta1AISearchEndpointStatusAtProviderThroughputInfo? ThroughputInfo { get; set; }

    /// <summary>Time the endpoint was last updated</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>The usage policy id applied to the endpoint</summary>
    [JsonPropertyName("usagePolicyId")]
    public string? UsagePolicyId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchEndpointStatusConditions
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

/// <summary>AISearchEndpointStatus defines the observed state of AISearchEndpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchEndpointStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1AISearchEndpointStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AISearchEndpointStatusConditions>? Conditions { get; set; }

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

/// <summary>AISearchEndpoint is the Schema for the AISearchEndpoints API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AISearchEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AISearchEndpointSpec>, IStatus<V1beta1AISearchEndpointStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AISearchEndpoint";
    public const string KubeGroup = "ai.databricks.crossplane.io";
    public const string KubePluralName = "aisearchendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ai.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AISearchEndpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AISearchEndpointSpec defines the desired state of AISearchEndpoint</summary>
    [JsonPropertyName("spec")]
    public required V1beta1AISearchEndpointSpec Spec { get; set; }

    /// <summary>AISearchEndpointStatus defines the observed state of AISearchEndpoint.</summary>
    [JsonPropertyName("status")]
    public V1beta1AISearchEndpointStatus? Status { get; set; }
}
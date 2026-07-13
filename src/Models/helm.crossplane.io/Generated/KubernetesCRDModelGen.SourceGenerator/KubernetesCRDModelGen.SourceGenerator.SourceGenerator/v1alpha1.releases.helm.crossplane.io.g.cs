#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.helm.crossplane.io;
/// <summary>A Release is an example API type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ReleaseList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Release>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ReleaseList";
    public const string KubeGroup = "helm.crossplane.io";
    public const string KubePluralName = "releases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "helm.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ReleaseList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Release objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Release> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ReleaseSpecDeletionPolicyEnum>))]
public enum V1alpha1ReleaseSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A SecretReference is a reference to a secret in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseSpecForProviderChartPullSecretRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A ChartSpec defines the chart spec for a Release</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseSpecForProviderChart
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>A SecretReference is a reference to a secret in an arbitrary namespace.</summary>
    [JsonPropertyName("pullSecretRef")]
    public V1alpha1ReleaseSpecForProviderChartPullSecretRef? PullSecretRef { get; set; }

    [JsonPropertyName("repository")]
    public required string Repository { get; set; }

    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

/// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseSpecForProviderPatchesFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseSpecForProviderPatchesFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>ValueFromSource represents source of a value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseSpecForProviderPatchesFrom
{
    /// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1ReleaseSpecForProviderPatchesFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ReleaseSpecForProviderPatchesFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseSpecForProviderSetValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseSpecForProviderSetValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>ValueFromSource represents source of a value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseSpecForProviderSetValueFrom
{
    /// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1ReleaseSpecForProviderSetValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ReleaseSpecForProviderSetValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>SetVal represents a &quot;set&quot; value override in a Release</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseSpecForProviderSet
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFromSource represents source of a value</summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1ReleaseSpecForProviderSetValueFrom? ValueFrom { get; set; }
}

/// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseSpecForProviderValuesFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseSpecForProviderValuesFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>ValueFromSource represents source of a value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseSpecForProviderValuesFrom
{
    /// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1ReleaseSpecForProviderValuesFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1ReleaseSpecForProviderValuesFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>ReleaseParameters are the configurable fields of a Release.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseSpecForProvider
{
    /// <summary>A ChartSpec defines the chart spec for a Release</summary>
    [JsonPropertyName("chart")]
    public required V1alpha1ReleaseSpecForProviderChart Chart { get; set; }

    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }

    [JsonPropertyName("patchesFrom")]
    public IList<V1alpha1ReleaseSpecForProviderPatchesFrom>? PatchesFrom { get; set; }

    [JsonPropertyName("set")]
    public IList<V1alpha1ReleaseSpecForProviderSet>? Set { get; set; }

    [JsonPropertyName("values")]
    public JsonNode? Values { get; set; }

    [JsonPropertyName("valuesFrom")]
    public IList<V1alpha1ReleaseSpecForProviderValuesFrom>? ValuesFrom { get; set; }

    [JsonPropertyName("wait")]
    public bool? Wait { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ReleaseSpecManagementPoliciesEnum>))]
public enum V1alpha1ReleaseSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ReleaseSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha1ReleaseSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ReleaseSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha1ReleaseSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1ReleaseSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1ReleaseSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1ReleaseSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A ReleaseSpec defines the desired state of a Release.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseSpec
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
    public V1alpha1ReleaseSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary>ReleaseParameters are the configurable fields of a Release.</summary>
    [JsonPropertyName("forProvider")]
    public required V1alpha1ReleaseSpecForProvider ForProvider { get; set; }

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
    public IList<V1alpha1ReleaseSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1ReleaseSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>RollbackRetriesLimit is max number of attempts to retry Helm deployment by rolling back the release.</summary>
    [JsonPropertyName("rollbackLimit")]
    public int? RollbackLimit { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1ReleaseSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>ReleaseObservation are the observable fields of a Release.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseStatusAtProvider
{
    [JsonPropertyName("releaseDescription")]
    public string? ReleaseDescription { get; set; }

    [JsonPropertyName("revision")]
    public int? Revision { get; set; }

    /// <summary>Status is the status of a release</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseStatusConditions
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

/// <summary>A ReleaseStatus represents the observed state of a Release.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReleaseStatus
{
    /// <summary>ReleaseObservation are the observable fields of a Release.</summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1ReleaseStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ReleaseStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("failed")]
    public int? Failed { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    [JsonPropertyName("patchesSha")]
    public string? PatchesSha { get; set; }

    [JsonPropertyName("synced")]
    public bool? Synced { get; set; }
}

/// <summary>A Release is an example API type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Release : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ReleaseSpec>, IStatus<V1alpha1ReleaseStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Release";
    public const string KubeGroup = "helm.crossplane.io";
    public const string KubePluralName = "releases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "helm.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Release";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>A ReleaseSpec defines the desired state of a Release.</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ReleaseSpec Spec { get; set; }

    /// <summary>A ReleaseStatus represents the observed state of a Release.</summary>
    [JsonPropertyName("status")]
    public V1alpha1ReleaseStatus? Status { get; set; }
}
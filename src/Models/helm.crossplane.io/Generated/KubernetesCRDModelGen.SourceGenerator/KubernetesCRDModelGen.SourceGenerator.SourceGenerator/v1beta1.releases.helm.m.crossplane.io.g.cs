#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.helm.m.crossplane.io;
/// <summary>A Release is an example API type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ReleaseList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Release>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReleaseList";
    public const string KubeGroup = "helm.m.crossplane.io";
    public const string KubePluralName = "releases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "helm.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ReleaseList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Release objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Release> Items { get; set; }
}

/// <summary>ConnectionDetail todo</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecConnectionDetails
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>
    /// If referring to a piece of an object instead of an entire object, this string
    /// should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2].
    /// For example, if the object reference is to a container within a pod, this would take on a value like:
    /// &quot;spec.containers{name}&quot; (where &quot;name&quot; refers to the name of the container that triggered
    /// the event) or if no container name is specified &quot;spec.containers[2]&quot; (container with
    /// index 2 in this pod). This syntax is chosen only to have some well-defined way of
    /// referencing a part of an object.
    /// </summary>
    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    /// <summary>
    /// Kind of the referent.
    /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// Name of the referent.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Namespace of the referent.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Specific resourceVersion to which this reference is made, if any.
    /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
    /// </summary>
    [JsonPropertyName("resourceVersion")]
    public string? ResourceVersion { get; set; }

    /// <summary>SkipPartOfReleaseCheck skips check for meta.helm.sh/release-name annotation.</summary>
    [JsonPropertyName("skipPartOfReleaseCheck")]
    public bool? SkipPartOfReleaseCheck { get; set; }

    [JsonPropertyName("toConnectionSecretKey")]
    public string? ToConnectionSecretKey { get; set; }

    /// <summary>
    /// UID of the referent.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids
    /// </summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }
}

/// <summary>
/// PullSecretRef is reference to the secret containing credentials to helm repository.
/// The secret must contain &apos;username&apos; and &apos;password&apos; keys. Optional - if not provided,
/// the default credential chain is used (AWS IRSA, Azure/GCP Workload Identity, etc.).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderChartPullSecretRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>A ChartSpec defines the chart spec for a Release</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderChart
{
    /// <summary>
    /// Digest is the OCI image digest in the format &quot;sha256:abc123...&quot;
    /// Only supported for OCI registries. When specified, the chart will be pulled by digest.
    /// Can be used alone or in combination with Version. Optional.
    /// </summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>Name of Helm chart, required if ChartSpec.URL not set</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// PullSecretRef is reference to the secret containing credentials to helm repository.
    /// The secret must contain &apos;username&apos; and &apos;password&apos; keys. Optional - if not provided,
    /// the default credential chain is used (AWS IRSA, Azure/GCP Workload Identity, etc.).
    /// </summary>
    [JsonPropertyName("pullSecretRef")]
    public V1beta1ReleaseSpecForProviderChartPullSecretRef? PullSecretRef { get; set; }

    /// <summary>Repository: Helm repository URL, required if ChartSpec.URL not set</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>URL to chart package (typically .tgz), optional and overrides others fields in the spec</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Version of Helm chart. Optional when Digest is specified.
    /// If not set and Digest is not specified, gets late initialized with the latest available version.
    /// If not set and Digest is specified, version is NOT late initialized to avoid spec drift.
    /// The actual deployed version is always available in status.atProvider.version for observability.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderPatchesFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderPatchesFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>ValueFromSource represents source of a value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderPatchesFrom
{
    /// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1beta1ReleaseSpecForProviderPatchesFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ReleaseSpecForProviderPatchesFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderSetValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderSetValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>ValueFromSource represents source of a value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderSetValueFrom
{
    /// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1beta1ReleaseSpecForProviderSetValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ReleaseSpecForProviderSetValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>SetVal represents a &quot;set&quot; value override in a Release</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderSet
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFromSource represents source of a value</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1ReleaseSpecForProviderSetValueFrom? ValueFrom { get; set; }
}

/// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderValuesFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderValuesFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>ValueFromSource represents source of a value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProviderValuesFrom
{
    /// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1beta1ReleaseSpecForProviderValuesFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary>DataKeySelector defines required spec to access a key of a configmap or secret</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ReleaseSpecForProviderValuesFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>ReleaseParameters are the configurable fields of a Release.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpecForProvider
{
    /// <summary>A ChartSpec defines the chart spec for a Release</summary>
    [JsonPropertyName("chart")]
    public required V1beta1ReleaseSpecForProviderChart Chart { get; set; }

    /// <summary>InsecureSkipTLSVerify skips tls certificate checks for the chart download</summary>
    [JsonPropertyName("insecureSkipTLSVerify")]
    public bool? InsecureSkipTLSVerify { get; set; }

    /// <summary>MaxHistory limits the maximum number of revisions saved per release. Use 0 for no limit.</summary>
    [JsonPropertyName("maxHistory")]
    public int? MaxHistory { get; set; }

    /// <summary>
    /// Namespace to install the release into.
    /// The Release Managed Resource&apos;s namespace will be used if nothing is set.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>PatchesFrom describe patches to be applied to the rendered manifests.</summary>
    [JsonPropertyName("patchesFrom")]
    public IList<V1beta1ReleaseSpecForProviderPatchesFrom>? PatchesFrom { get; set; }

    /// <summary>PlainHTTP uses insecure HTTP connections for the chart download</summary>
    [JsonPropertyName("plainHTTP")]
    public bool? PlainHTTP { get; set; }

    [JsonPropertyName("set")]
    public IList<V1beta1ReleaseSpecForProviderSet>? Set { get; set; }

    /// <summary>SkipCRDs skips installation of CRDs for the release.</summary>
    [JsonPropertyName("skipCRDs")]
    public bool? SkipCRDs { get; set; }

    /// <summary>SkipCreateNamespace won&apos;t create the namespace for the release. This requires the namespace to already exist.</summary>
    [JsonPropertyName("skipCreateNamespace")]
    public bool? SkipCreateNamespace { get; set; }

    /// <summary>
    /// TakeOwnership ignores Helm ownership validation and adopts pre-existing releases.
    /// This is a ONE-TIME operation: after the first successful deployment, the flag is recorded
    /// in status.atProvider.ownershipTaken and subsequent reconciles use normal Helm validation.
    /// This prevents silent adoption of unrelated resources during chart upgrades.
    /// Use this field to migrate manually-deployed Helm releases into Crossplane management.
    /// </summary>
    [JsonPropertyName("takeOwnership")]
    public bool? TakeOwnership { get; set; }

    [JsonPropertyName("values")]
    public JsonNode? Values { get; set; }

    [JsonPropertyName("valuesFrom")]
    public IList<V1beta1ReleaseSpecForProviderValuesFrom>? ValuesFrom { get; set; }

    /// <summary>Wait for the release to become ready.</summary>
    [JsonPropertyName("wait")]
    public bool? Wait { get; set; }

    /// <summary>
    /// WaitTimeout is the duration Helm will wait for the release to become
    /// ready. Only applies if wait is also set. Defaults to 5m.
    /// </summary>
    [JsonPropertyName("waitTimeout")]
    public string? WaitTimeout { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ReleaseSpecManagementPoliciesEnum>))]
public enum V1beta1ReleaseSpecManagementPoliciesEnum
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
public partial class V1beta1ReleaseSpecProviderConfigRef
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
public partial class V1beta1ReleaseSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>A ReleaseSpec defines the desired state of a Release.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseSpec
{
    [JsonPropertyName("connectionDetails")]
    public IList<V1beta1ReleaseSpecConnectionDetails>? ConnectionDetails { get; set; }

    /// <summary>ReleaseParameters are the configurable fields of a Release.</summary>
    [JsonPropertyName("forProvider")]
    public required V1beta1ReleaseSpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ReleaseSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ReleaseSpecProviderConfigRef? ProviderConfigRef { get; set; }

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
    public V1beta1ReleaseSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>ReleaseObservation are the observable fields of a Release.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseStatusAtProvider
{
    /// <summary>Digest is the last successfully deployed chart digest (for OCI charts only).</summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>
    /// OwnershipTaken indicates that spec.forProvider.takeOwnership was used for initial adoption.
    /// Once set to true, subsequent reconciles use normal Helm validation instead of takeOwnership,
    /// preventing silent adoption of unrelated resources during upgrades.
    /// </summary>
    [JsonPropertyName("ownershipTaken")]
    public bool? OwnershipTaken { get; set; }

    [JsonPropertyName("releaseDescription")]
    public string? ReleaseDescription { get; set; }

    [JsonPropertyName("revision")]
    public int? Revision { get; set; }

    /// <summary>Status is the status of a release</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Version is the actual deployed chart version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReleaseStatus
{
    /// <summary>ReleaseObservation are the observable fields of a Release.</summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ReleaseStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ReleaseStatusConditions>? Conditions { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Release : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ReleaseSpec>, IStatus<V1beta1ReleaseStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Release";
    public const string KubeGroup = "helm.m.crossplane.io";
    public const string KubePluralName = "releases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "helm.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Release";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>A ReleaseSpec defines the desired state of a Release.</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ReleaseSpec Spec { get; set; }

    /// <summary>A ReleaseStatus represents the observed state of a Release.</summary>
    [JsonPropertyName("status")]
    public V1beta1ReleaseStatus? Status { get; set; }
}
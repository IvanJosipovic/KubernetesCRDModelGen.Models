#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kubernetes.crossplane.io;
/// <summary>
/// A Object is an provider Kubernetes API type
/// 
/// Deprecated: v1alpha1.Object is deprecated in favor of v1alpha2.Object
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ObjectList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Object>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ObjectList";
    public const string KubeGroup = "kubernetes.crossplane.io";
    public const string KubePluralName = "objects";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kubernetes.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ObjectList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Object objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Object> Items { get; set; }
}

/// <summary>ConnectionDetail represents an entry in the connection secret for an Object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ObjectSpecConnectionDetails
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
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicy
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ObjectSpecDeletionPolicyEnum>))]
[global::System.Obsolete]
public enum V1alpha1ObjectSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>ObjectParameters are the configurable fields of a Object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ObjectSpecForProvider
{
    /// <summary>Raw JSON representation of the kubernetes object to be created.</summary>
    [JsonPropertyName("manifest")]
    public required JsonNode Manifest { get; set; }
}

/// <summary>
/// A ManagementPolicy determines what should happen to the underlying external
/// resource when a managed resource is created, updated, deleted, or observed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ObjectSpecManagementPolicyEnum>))]
[global::System.Obsolete]
public enum V1alpha1ObjectSpecManagementPolicyEnum
{
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "ObserveCreateUpdate"), JsonStringEnumMemberName("ObserveCreateUpdate")]
    ObserveCreateUpdate,
    [EnumMember(Value = "ObserveDelete"), JsonStringEnumMemberName("ObserveDelete")]
    ObserveDelete,
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ObjectSpecProviderConfigRefPolicyResolutionEnum>))]
[global::System.Obsolete]
public enum V1alpha1ObjectSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ObjectSpecProviderConfigRefPolicyResolveEnum>))]
[global::System.Obsolete]
public enum V1alpha1ObjectSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ObjectSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1ObjectSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1ObjectSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ObjectSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1ObjectSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ObjectSpecProviderRefPolicyResolutionEnum>))]
[global::System.Obsolete]
public enum V1alpha1ObjectSpecProviderRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ObjectSpecProviderRefPolicyResolveEnum>))]
[global::System.Obsolete]
public enum V1alpha1ObjectSpecProviderRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ObjectSpecProviderRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1ObjectSpecProviderRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1ObjectSpecProviderRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderReference specifies the provider that will be used to create,
/// observe, update, and delete this managed resource.
/// 
/// Deprecated: Please use ProviderConfigReference, i.e. `providerConfigRef`
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ObjectSpecProviderRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1ObjectSpecProviderRefPolicy? Policy { get; set; }
}

/// <summary>Policy defines how the Object&apos;s readiness condition should be computed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ObjectSpecReadinessPolicyEnum>))]
[global::System.Obsolete]
public enum V1alpha1ObjectSpecReadinessPolicyEnum
{
    [EnumMember(Value = "SuccessfulCreate"), JsonStringEnumMemberName("SuccessfulCreate")]
    SuccessfulCreate,
    [EnumMember(Value = "DeriveFromObject"), JsonStringEnumMemberName("DeriveFromObject")]
    DeriveFromObject,
    [EnumMember(Value = "AllTrue"), JsonStringEnumMemberName("AllTrue")]
    AllTrue
}

/// <summary>
/// Readiness defines how the object&apos;s readiness condition should be computed,
/// if not specified it will be considered ready as soon as the underlying external
/// resource is considered up-to-date.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ObjectSpecReadiness
{
    /// <summary>Policy defines how the Object&apos;s readiness condition should be computed.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1ObjectSpecReadinessPolicyEnum? Policy { get; set; }
}

/// <summary>
/// DependsOn is used to declare dependency on other Object or arbitrary
/// Kubernetes resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ObjectSpecReferencesDependsOn
{
    /// <summary>APIVersion of the referenced object.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// PatchesFrom is used to declare dependency on other Object or arbitrary
/// Kubernetes resource, and also patch fields from this object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ObjectSpecReferencesPatchesFrom
{
    /// <summary>APIVersion of the referenced object.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>
    /// FieldPath is the path of the field on the resource whose value is to be
    /// used as input.
    /// </summary>
    [JsonPropertyName("fieldPath")]
    public required string FieldPath { get; set; }

    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Reference refers to an Object or arbitrary Kubernetes resource and optionally
/// patch values from that resource to the current Object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ObjectSpecReferences
{
    /// <summary>
    /// DependsOn is used to declare dependency on other Object or arbitrary
    /// Kubernetes resource.
    /// </summary>
    [JsonPropertyName("dependsOn")]
    public V1alpha1ObjectSpecReferencesDependsOn? DependsOn { get; set; }

    /// <summary>
    /// PatchesFrom is used to declare dependency on other Object or arbitrary
    /// Kubernetes resource, and also patch fields from this object.
    /// </summary>
    [JsonPropertyName("patchesFrom")]
    public V1alpha1ObjectSpecReferencesPatchesFrom? PatchesFrom { get; set; }

    /// <summary>
    /// ToFieldPath is the path of the field on the resource whose value will
    /// be changed with the result of transforms. Leave empty if you&apos;d like to
    /// propagate to the same path as patchesFrom.fieldPath.
    /// </summary>
    [JsonPropertyName("toFieldPath")]
    public string? ToFieldPath { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// This field is planned to be replaced in a future release in favor of
/// PublishConnectionDetailsTo. Currently, both could be set independently
/// and connection details would be published to both without affecting
/// each other.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ObjectSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A ObjectSpec defines the desired state of a Object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ObjectSpec
{
    [JsonPropertyName("connectionDetails")]
    public IList<V1alpha1ObjectSpecConnectionDetails>? ConnectionDetails { get; set; }

    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicy
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1alpha1ObjectSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary>ObjectParameters are the configurable fields of a Object.</summary>
    [JsonPropertyName("forProvider")]
    public required V1alpha1ObjectSpecForProvider ForProvider { get; set; }

    /// <summary>
    /// A ManagementPolicy determines what should happen to the underlying external
    /// resource when a managed resource is created, updated, deleted, or observed.
    /// </summary>
    [JsonPropertyName("managementPolicy")]
    public V1alpha1ObjectSpecManagementPolicyEnum? ManagementPolicy { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1ObjectSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// ProviderReference specifies the provider that will be used to create,
    /// observe, update, and delete this managed resource.
    /// 
    /// Deprecated: Please use ProviderConfigReference, i.e. `providerConfigRef`
    /// </summary>
    [JsonPropertyName("providerRef")]
    public V1alpha1ObjectSpecProviderRef? ProviderRef { get; set; }

    /// <summary>
    /// Readiness defines how the object&apos;s readiness condition should be computed,
    /// if not specified it will be considered ready as soon as the underlying external
    /// resource is considered up-to-date.
    /// </summary>
    [JsonPropertyName("readiness")]
    public V1alpha1ObjectSpecReadiness? Readiness { get; set; }

    [JsonPropertyName("references")]
    public IList<V1alpha1ObjectSpecReferences>? References { get; set; }

    /// <summary>
    /// Watch enables watching the referenced or managed kubernetes resources.
    /// 
    /// THIS IS AN ALPHA FIELD. Do not use it in production. It is not honored
    /// unless &quot;watches&quot; feature gate is enabled, and may be changed or removed
    /// without notice.
    /// </summary>
    [JsonPropertyName("watch")]
    public bool? Watch { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// This field is planned to be replaced in a future release in favor of
    /// PublishConnectionDetailsTo. Currently, both could be set independently
    /// and connection details would be published to both without affecting
    /// each other.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1ObjectSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>ObjectObservation are the observable fields of a Object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ObjectStatusAtProvider
{
    /// <summary>Raw JSON representation of the remote object.</summary>
    [JsonPropertyName("manifest")]
    public JsonNode? Manifest { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ObjectStatusConditions
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

/// <summary>A ObjectStatus represents the observed state of a Object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
public partial class V1alpha1ObjectStatus
{
    /// <summary>ObjectObservation are the observable fields of a Object.</summary>
    [JsonPropertyName("atProvider")]
    public V1alpha1ObjectStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ObjectStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// A Object is an provider Kubernetes API type
/// 
/// Deprecated: v1alpha1.Object is deprecated in favor of v1alpha2.Object
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Object : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ObjectSpec>, IStatus<V1alpha1ObjectStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Object";
    public const string KubeGroup = "kubernetes.crossplane.io";
    public const string KubePluralName = "objects";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kubernetes.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Object";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>A ObjectSpec defines the desired state of a Object.</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ObjectSpec Spec { get; set; }

    /// <summary>A ObjectStatus represents the observed state of a Object.</summary>
    [JsonPropertyName("status")]
    public V1alpha1ObjectStatus? Status { get; set; }
}
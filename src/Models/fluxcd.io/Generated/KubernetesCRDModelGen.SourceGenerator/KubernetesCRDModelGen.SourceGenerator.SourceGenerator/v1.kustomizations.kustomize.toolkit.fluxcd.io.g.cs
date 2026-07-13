#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kustomize.toolkit.fluxcd.io;
/// <summary>Kustomization is the Schema for the kustomizations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KustomizationList : IKubernetesObject<V1ListMeta>, IItems<V1Kustomization>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KustomizationList";
    public const string KubeGroup = "kustomize.toolkit.fluxcd.io";
    public const string KubePluralName = "kustomizations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kustomize.toolkit.fluxcd.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KustomizationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1Kustomization objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1Kustomization> Items { get; set; }
}

/// <summary>BuildMetadataOption defines the supported buildMetadata options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KustomizationSpecBuildMetadataEnum>))]
public enum V1KustomizationSpecBuildMetadataEnum
{
    [EnumMember(Value = "originAnnotations"), JsonStringEnumMemberName("originAnnotations")]
    OriginAnnotations,
    [EnumMember(Value = "transformerAnnotations"), JsonStringEnumMemberName("transformerAnnotations")]
    TransformerAnnotations
}

/// <summary>
/// CommonMetadata specifies the common labels and annotations that are
/// applied to all resources. Any existing label or annotation will be
/// overridden if its key matches a common one.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecCommonMetadata
{
    /// <summary>Annotations to be added to the object&apos;s metadata.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels to be added to the object&apos;s metadata.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>Provider is the name of the decryption engine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KustomizationSpecDecryptionProviderEnum>))]
public enum V1KustomizationSpecDecryptionProviderEnum
{
    [EnumMember(Value = "sops"), JsonStringEnumMemberName("sops")]
    Sops
}

/// <summary>
/// The secret name containing the private OpenPGP keys used for decryption.
/// A static credential for a cloud provider defined inside the Secret
/// takes priority to secret-less authentication with the ServiceAccountName
/// field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecDecryptionSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Decrypt Kubernetes secrets before applying them on the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecDecryption
{
    /// <summary>Provider is the name of the decryption engine.</summary>
    [JsonPropertyName("provider")]
    public required V1KustomizationSpecDecryptionProviderEnum Provider { get; set; }

    /// <summary>
    /// The secret name containing the private OpenPGP keys used for decryption.
    /// A static credential for a cloud provider defined inside the Secret
    /// takes priority to secret-less authentication with the ServiceAccountName
    /// field.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1KustomizationSpecDecryptionSecretRef? SecretRef { get; set; }

    /// <summary>
    /// ServiceAccountName is the name of the service account used to
    /// authenticate with KMS services from cloud providers. If a
    /// static credential for a given cloud provider is defined
    /// inside the Secret referenced by SecretRef, that static
    /// credential takes priority.
    /// </summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }
}

/// <summary>
/// DeletionPolicy can be used to control garbage collection when this
/// Kustomization is deleted. Valid values are (&apos;MirrorPrune&apos;, &apos;Delete&apos;,
/// &apos;WaitForTermination&apos;, &apos;Orphan&apos;). &apos;MirrorPrune&apos; mirrors the Prune field
/// (orphan if false, delete if true). Defaults to &apos;MirrorPrune&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KustomizationSpecDeletionPolicyEnum>))]
public enum V1KustomizationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "MirrorPrune"), JsonStringEnumMemberName("MirrorPrune")]
    MirrorPrune,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "WaitForTermination"), JsonStringEnumMemberName("WaitForTermination")]
    WaitForTermination,
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan
}

/// <summary>
/// DependencyReference contains enough information to locate the referenced Kubernetes resource object
/// and optional CEL expression to assess its readiness.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecDependsOn
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace of the referent, defaults to the namespace of the resource
    /// object that contains the reference.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// ReadyExpr is a CEL expression that can be used to assess the readiness
    /// of a dependency. When specified, the built-in readiness check
    /// is replaced by the logic defined in the CEL expression.
    /// To make the CEL expression additive to the built-in readiness check,
    /// the feature gate `AdditiveCELDependencyCheck` must be set to `true`.
    /// </summary>
    [JsonPropertyName("readyExpr")]
    public string? ReadyExpr { get; set; }
}

/// <summary>CustomHealthCheck defines the health check for custom resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecHealthCheckExprs
{
    /// <summary>APIVersion of the custom resource under evaluation.</summary>
    [JsonPropertyName("apiVersion")]
    public required string ApiVersion { get; set; }

    /// <summary>
    /// Current is the CEL expression that determines if the status
    /// of the custom resource has reached the desired state.
    /// </summary>
    [JsonPropertyName("current")]
    public required string Current { get; set; }

    /// <summary>
    /// Failed is the CEL expression that determines if the status
    /// of the custom resource has failed to reach the desired state.
    /// </summary>
    [JsonPropertyName("failed")]
    public string? Failed { get; set; }

    /// <summary>
    /// InProgress is the CEL expression that determines if the status
    /// of the custom resource has not yet reached the desired state.
    /// </summary>
    [JsonPropertyName("inProgress")]
    public string? InProgress { get; set; }

    /// <summary>Kind of the custom resource under evaluation.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }
}

/// <summary>
/// NamespacedObjectKindReference contains enough information to locate the typed referenced Kubernetes resource object
/// in any namespace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecHealthChecks
{
    /// <summary>API version of the referent, if not specified the Kubernetes preferred version will be used.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referent, when not specified it acts as LocalObjectReference.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Target is a selector for specifying Kubernetes objects to which this
/// rule applies.
/// If Target is not set, the Paths will be ignored for all Kubernetes
/// objects within the manifest of the Kustomization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecIgnoreTarget
{
    /// <summary>
    /// AnnotationSelector is a string that follows the label selection expression
    /// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#api
    /// It matches with the resource annotations.
    /// </summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary>
    /// Group is the API group to select resources from.
    /// Together with Version and Kind it is capable of unambiguously identifying and/or selecting resources.
    /// https://github.com/kubernetes/community/blob/master/contributors/design-proposals/api-machinery/api-group.md
    /// </summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>
    /// Kind of the API Group to select resources from.
    /// Together with Group and Version it is capable of unambiguously
    /// identifying and/or selecting resources.
    /// https://github.com/kubernetes/community/blob/master/contributors/design-proposals/api-machinery/api-group.md
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// LabelSelector is a string that follows the label selection expression
    /// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#api
    /// It matches with the resource labels.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary>Name to match resources with.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace to select resources from.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Version of the API Group to select resources from.
    /// Together with Group and Kind it is capable of unambiguously identifying and/or selecting resources.
    /// https://github.com/kubernetes/community/blob/master/contributors/design-proposals/api-machinery/api-group.md
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// IgnoreRule defines a rule to selectively disregard specific changes during
/// the drift detection process.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecIgnore
{
    /// <summary>
    /// Paths is a list of JSON Pointer (RFC 6901) paths to be excluded from
    /// consideration in a Kubernetes object.
    /// </summary>
    [JsonPropertyName("paths")]
    public required IList<string> Paths { get; set; }

    /// <summary>
    /// Target is a selector for specifying Kubernetes objects to which this
    /// rule applies.
    /// If Target is not set, the Paths will be ignored for all Kubernetes
    /// objects within the manifest of the Kustomization.
    /// </summary>
    [JsonPropertyName("target")]
    public V1KustomizationSpecIgnoreTarget? Target { get; set; }
}

/// <summary>Image contains an image name, a new name, a new tag or digest, which will replace the original name and tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecImages
{
    /// <summary>
    /// Digest is the value used to replace the original image tag.
    /// If digest is present NewTag value is ignored.
    /// </summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>Name is a tag-less image name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>NewName is the value used to replace the original name.</summary>
    [JsonPropertyName("newName")]
    public string? NewName { get; set; }

    /// <summary>NewTag is the value used to replace the original tag.</summary>
    [JsonPropertyName("newTag")]
    public string? NewTag { get; set; }
}

/// <summary>
/// ConfigMapRef holds an optional name of a ConfigMap that contains
/// the following keys:
/// 
/// - `provider`: the provider to use. One of `aws`, `azure`, `gcp`, or
///    `generic`. Required.
/// - `cluster`: the fully qualified resource name of the Kubernetes
///    cluster in the cloud provider API. Not used by the `generic`
///    provider. Required when one of `address` or `ca.crt` is not set.
/// - `address`: the address of the Kubernetes API server. Required
///    for `generic`. For the other providers, if not specified, the
///    first address in the cluster resource will be used, and if
///    specified, it must match one of the addresses in the cluster
///    resource.
///    If audiences is not set, will be used as the audience for the
///    `generic` provider.
/// - `ca.crt`: the optional PEM-encoded CA certificate for the
///    Kubernetes API server. If not set, the controller will use the
///    CA certificate from the cluster resource.
/// - `audiences`: the optional audiences as a list of
///    line-break-separated strings for the Kubernetes ServiceAccount
///    token. Defaults to the `address` for the `generic` provider, or
///    to specific values for the other providers depending on the
///    provider.
/// -  `serviceAccountName`: the optional name of the Kubernetes
///    ServiceAccount in the same namespace that should be used
///    for authentication. If not specified, the controller
///    ServiceAccount will be used.
/// 
/// Mutually exclusive with SecretRef.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecKubeConfigConfigMapRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecretRef holds an optional name of a secret that contains a key with
/// the kubeconfig file as the value. If no key is set, the key will default
/// to &apos;value&apos;. Mutually exclusive with ConfigMapRef.
/// It is recommended that the kubeconfig is self-contained, and the secret
/// is regularly updated if credentials such as a cloud-access-token expire.
/// Cloud specific `cmd-path` auth helpers will not function without adding
/// binaries and credentials to the Pod that is responsible for reconciling
/// Kubernetes resources. Supported only for the generic provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecKubeConfigSecretRef
{
    /// <summary>Key in the Secret, when not specified an implementation-specific default key is used.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the Secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// The KubeConfig for reconciling the Kustomization on a remote cluster.
/// When used in combination with KustomizationSpec.ServiceAccountName,
/// forces the controller to act on behalf of that Service Account at the
/// target cluster.
/// If the --default-service-account flag is set, its value will be used as
/// a controller level fallback for when KustomizationSpec.ServiceAccountName
/// is empty.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecKubeConfig
{
    /// <summary>
    /// ConfigMapRef holds an optional name of a ConfigMap that contains
    /// the following keys:
    /// 
    /// - `provider`: the provider to use. One of `aws`, `azure`, `gcp`, or
    ///    `generic`. Required.
    /// - `cluster`: the fully qualified resource name of the Kubernetes
    ///    cluster in the cloud provider API. Not used by the `generic`
    ///    provider. Required when one of `address` or `ca.crt` is not set.
    /// - `address`: the address of the Kubernetes API server. Required
    ///    for `generic`. For the other providers, if not specified, the
    ///    first address in the cluster resource will be used, and if
    ///    specified, it must match one of the addresses in the cluster
    ///    resource.
    ///    If audiences is not set, will be used as the audience for the
    ///    `generic` provider.
    /// - `ca.crt`: the optional PEM-encoded CA certificate for the
    ///    Kubernetes API server. If not set, the controller will use the
    ///    CA certificate from the cluster resource.
    /// - `audiences`: the optional audiences as a list of
    ///    line-break-separated strings for the Kubernetes ServiceAccount
    ///    token. Defaults to the `address` for the `generic` provider, or
    ///    to specific values for the other providers depending on the
    ///    provider.
    /// -  `serviceAccountName`: the optional name of the Kubernetes
    ///    ServiceAccount in the same namespace that should be used
    ///    for authentication. If not specified, the controller
    ///    ServiceAccount will be used.
    /// 
    /// Mutually exclusive with SecretRef.
    /// </summary>
    [JsonPropertyName("configMapRef")]
    public V1KustomizationSpecKubeConfigConfigMapRef? ConfigMapRef { get; set; }

    /// <summary>
    /// SecretRef holds an optional name of a secret that contains a key with
    /// the kubeconfig file as the value. If no key is set, the key will default
    /// to &apos;value&apos;. Mutually exclusive with ConfigMapRef.
    /// It is recommended that the kubeconfig is self-contained, and the secret
    /// is regularly updated if credentials such as a cloud-access-token expire.
    /// Cloud specific `cmd-path` auth helpers will not function without adding
    /// binaries and credentials to the Pod that is responsible for reconciling
    /// Kubernetes resources. Supported only for the generic provider.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1KustomizationSpecKubeConfigSecretRef? SecretRef { get; set; }
}

/// <summary>Target points to the resources that the patch document should be applied to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecPatchesTarget
{
    /// <summary>
    /// AnnotationSelector is a string that follows the label selection expression
    /// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#api
    /// It matches with the resource annotations.
    /// </summary>
    [JsonPropertyName("annotationSelector")]
    public string? AnnotationSelector { get; set; }

    /// <summary>
    /// Group is the API group to select resources from.
    /// Together with Version and Kind it is capable of unambiguously identifying and/or selecting resources.
    /// https://github.com/kubernetes/community/blob/master/contributors/design-proposals/api-machinery/api-group.md
    /// </summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>
    /// Kind of the API Group to select resources from.
    /// Together with Group and Version it is capable of unambiguously
    /// identifying and/or selecting resources.
    /// https://github.com/kubernetes/community/blob/master/contributors/design-proposals/api-machinery/api-group.md
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// LabelSelector is a string that follows the label selection expression
    /// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#api
    /// It matches with the resource labels.
    /// </summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary>Name to match resources with.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace to select resources from.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Version of the API Group to select resources from.
    /// Together with Group and Kind it is capable of unambiguously identifying and/or selecting resources.
    /// https://github.com/kubernetes/community/blob/master/contributors/design-proposals/api-machinery/api-group.md
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Patch contains an inline StrategicMerge or JSON6902 patch, and the target the patch should
/// be applied to.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecPatches
{
    /// <summary>
    /// Patch contains an inline StrategicMerge patch or an inline JSON6902 patch with
    /// an array of operation objects.
    /// </summary>
    [JsonPropertyName("patch")]
    public required string Patch { get; set; }

    /// <summary>Target points to the resources that the patch document should be applied to.</summary>
    [JsonPropertyName("target")]
    public V1KustomizationSpecPatchesTarget? Target { get; set; }
}

/// <summary>Kind of the values referent, valid values are (&apos;Secret&apos;, &apos;ConfigMap&apos;).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KustomizationSpecPostBuildSubstituteFromKindEnum>))]
public enum V1KustomizationSpecPostBuildSubstituteFromKindEnum
{
    [EnumMember(Value = "Secret"), JsonStringEnumMemberName("Secret")]
    Secret,
    [EnumMember(Value = "ConfigMap"), JsonStringEnumMemberName("ConfigMap")]
    ConfigMap
}

/// <summary>
/// SubstituteReference contains a reference to a resource containing
/// the variables name and value.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecPostBuildSubstituteFrom
{
    /// <summary>Kind of the values referent, valid values are (&apos;Secret&apos;, &apos;ConfigMap&apos;).</summary>
    [JsonPropertyName("kind")]
    public required V1KustomizationSpecPostBuildSubstituteFromKindEnum Kind { get; set; }

    /// <summary>
    /// Name of the values referent. Should reside in the same namespace as the
    /// referring resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Optional indicates whether the referenced resource must exist, or whether to
    /// tolerate its absence. If true and the referenced resource is absent, proceed
    /// as if the resource was present but empty, without any variables defined.
    /// </summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>
/// SubstituteStrategy defines the strategy for substituting variables in the YAML manifests.
/// Valid values are:
/// 
///  - WithVariables (the default): require at least one variable to be defined,
///    either through the inline map or through the resolved references to ConfigMaps
///    and Secrets.
///  - Always: perform the substitution even if no variables are defined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KustomizationSpecPostBuildSubstituteStrategyEnum>))]
public enum V1KustomizationSpecPostBuildSubstituteStrategyEnum
{
    [EnumMember(Value = "WithVariables"), JsonStringEnumMemberName("WithVariables")]
    WithVariables,
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always
}

/// <summary>
/// PostBuild describes which actions to perform on the YAML manifest
/// generated by building the kustomize overlay.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecPostBuild
{
    /// <summary>
    /// Substitute holds a map of key/value pairs.
    /// The variables defined in your YAML manifests that match any of the keys
    /// defined in the map will be substituted with the set value.
    /// Includes support for bash string replacement functions
    /// e.g. ${var:=default}, ${var:position} and ${var/substring/replacement}.
    /// </summary>
    [JsonPropertyName("substitute")]
    public IDictionary<string, string>? Substitute { get; set; }

    /// <summary>
    /// SubstituteFrom holds references to ConfigMaps and Secrets containing
    /// the variables and their values to be substituted in the YAML manifests.
    /// The ConfigMap and the Secret data keys represent the var names, and they
    /// must match the vars declared in the manifests for the substitution to
    /// happen.
    /// </summary>
    [JsonPropertyName("substituteFrom")]
    public IList<V1KustomizationSpecPostBuildSubstituteFrom>? SubstituteFrom { get; set; }

    /// <summary>
    /// SubstituteStrategy defines the strategy for substituting variables in the YAML manifests.
    /// Valid values are:
    /// 
    ///  - WithVariables (the default): require at least one variable to be defined,
    ///    either through the inline map or through the resolved references to ConfigMaps
    ///    and Secrets.
    ///  - Always: perform the substitution even if no variables are defined.
    /// </summary>
    [JsonPropertyName("substituteStrategy")]
    public V1KustomizationSpecPostBuildSubstituteStrategyEnum? SubstituteStrategy { get; set; }
}

/// <summary>Kind of the referent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KustomizationSpecSourceRefKindEnum>))]
public enum V1KustomizationSpecSourceRefKindEnum
{
    [EnumMember(Value = "OCIRepository"), JsonStringEnumMemberName("OCIRepository")]
    OCIRepository,
    [EnumMember(Value = "GitRepository"), JsonStringEnumMemberName("GitRepository")]
    GitRepository,
    [EnumMember(Value = "Bucket"), JsonStringEnumMemberName("Bucket")]
    Bucket,
    [EnumMember(Value = "ExternalArtifact"), JsonStringEnumMemberName("ExternalArtifact")]
    ExternalArtifact
}

/// <summary>Reference of the source where the kustomization file is.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpecSourceRef
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public required V1KustomizationSpecSourceRefKindEnum Kind { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace of the referent, defaults to the namespace of the Kubernetes
    /// resource object that contains the reference.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// KustomizationSpec defines the configuration to calculate the desired state
/// from a Source using Kustomize.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationSpec
{
    /// <summary>
    /// BuildMetadata specifies which kustomize build metadata should be added
    /// to the built resources. The allowed values are &apos;originAnnotations&apos; to
    /// annotate resources with their source origin, and &apos;transformerAnnotations&apos;
    /// to annotate resources with the transformers that produced them.
    /// </summary>
    [JsonPropertyName("buildMetadata")]
    public IList<V1KustomizationSpecBuildMetadataEnum>? BuildMetadata { get; set; }

    /// <summary>
    /// CommonMetadata specifies the common labels and annotations that are
    /// applied to all resources. Any existing label or annotation will be
    /// overridden if its key matches a common one.
    /// </summary>
    [JsonPropertyName("commonMetadata")]
    public V1KustomizationSpecCommonMetadata? CommonMetadata { get; set; }

    /// <summary>Components specifies relative paths to kustomize Components.</summary>
    [JsonPropertyName("components")]
    public IList<string>? Components { get; set; }

    /// <summary>Decrypt Kubernetes secrets before applying them on the cluster.</summary>
    [JsonPropertyName("decryption")]
    public V1KustomizationSpecDecryption? Decryption { get; set; }

    /// <summary>
    /// DeletionPolicy can be used to control garbage collection when this
    /// Kustomization is deleted. Valid values are (&apos;MirrorPrune&apos;, &apos;Delete&apos;,
    /// &apos;WaitForTermination&apos;, &apos;Orphan&apos;). &apos;MirrorPrune&apos; mirrors the Prune field
    /// (orphan if false, delete if true). Defaults to &apos;MirrorPrune&apos;.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1KustomizationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary>
    /// DependsOn may contain a DependencyReference slice
    /// with references to Kustomization resources that must be ready before this
    /// Kustomization can be reconciled.
    /// </summary>
    [JsonPropertyName("dependsOn")]
    public IList<V1KustomizationSpecDependsOn>? DependsOn { get; set; }

    /// <summary>
    /// Force instructs the controller to recreate resources
    /// when patching fails due to an immutable field change.
    /// </summary>
    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    /// <summary>
    /// HealthCheckExprs is a list of healthcheck expressions for evaluating the
    /// health of custom resources using Common Expression Language (CEL).
    /// The expressions are evaluated only when Wait or HealthChecks are specified.
    /// </summary>
    [JsonPropertyName("healthCheckExprs")]
    public IList<V1KustomizationSpecHealthCheckExprs>? HealthCheckExprs { get; set; }

    /// <summary>A list of resources to be included in the health assessment.</summary>
    [JsonPropertyName("healthChecks")]
    public IList<V1KustomizationSpecHealthChecks>? HealthChecks { get; set; }

    /// <summary>
    /// Ignore is a list of rules for specifying which changes to ignore
    /// during drift detection. These rules are applied to the resources managed
    /// by the Kustomization and are used to exclude specific JSON pointer paths
    /// from the drift detection and apply process.
    /// </summary>
    [JsonPropertyName("ignore")]
    public IList<V1KustomizationSpecIgnore>? Ignore { get; set; }

    /// <summary>
    /// IgnoreMissingComponents instructs the controller to ignore Components paths
    /// not found in source by removing them from the generated kustomization.yaml
    /// before running kustomize build.
    /// </summary>
    [JsonPropertyName("ignoreMissingComponents")]
    public bool? IgnoreMissingComponents { get; set; }

    /// <summary>
    /// Images is a list of (image name, new name, new tag or digest)
    /// for changing image names, tags or digests. This can also be achieved with a
    /// patch, but this operator is simpler to specify.
    /// </summary>
    [JsonPropertyName("images")]
    public IList<V1KustomizationSpecImages>? Images { get; set; }

    /// <summary>
    /// The interval at which to reconcile the Kustomization.
    /// This interval is approximate and may be subject to jitter to ensure
    /// efficient use of resources.
    /// </summary>
    [JsonPropertyName("interval")]
    public required string Interval { get; set; }

    /// <summary>
    /// The KubeConfig for reconciling the Kustomization on a remote cluster.
    /// When used in combination with KustomizationSpec.ServiceAccountName,
    /// forces the controller to act on behalf of that Service Account at the
    /// target cluster.
    /// If the --default-service-account flag is set, its value will be used as
    /// a controller level fallback for when KustomizationSpec.ServiceAccountName
    /// is empty.
    /// </summary>
    [JsonPropertyName("kubeConfig")]
    public V1KustomizationSpecKubeConfig? KubeConfig { get; set; }

    /// <summary>NamePrefix will prefix the names of all managed resources.</summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>NameSuffix will suffix the names of all managed resources.</summary>
    [JsonPropertyName("nameSuffix")]
    public string? NameSuffix { get; set; }

    /// <summary>
    /// Strategic merge and JSON patches, defined as inline YAML objects,
    /// capable of targeting objects based on kind, label and annotation selectors.
    /// </summary>
    [JsonPropertyName("patches")]
    public IList<V1KustomizationSpecPatches>? Patches { get; set; }

    /// <summary>
    /// Path to the directory containing the kustomization.yaml file, or the
    /// set of plain YAMLs a kustomization.yaml should be generated for.
    /// Defaults to &apos;None&apos;, which translates to the root path of the SourceRef.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// PostBuild describes which actions to perform on the YAML manifest
    /// generated by building the kustomize overlay.
    /// </summary>
    [JsonPropertyName("postBuild")]
    public V1KustomizationSpecPostBuild? PostBuild { get; set; }

    /// <summary>Prune enables garbage collection.</summary>
    [JsonPropertyName("prune")]
    public required bool Prune { get; set; }

    /// <summary>
    /// The interval at which to retry a previously failed reconciliation.
    /// When not specified, the controller uses the KustomizationSpec.Interval
    /// value to retry failures.
    /// </summary>
    [JsonPropertyName("retryInterval")]
    public string? RetryInterval { get; set; }

    /// <summary>
    /// The name of the Kubernetes service account to impersonate
    /// when reconciling this Kustomization.
    /// </summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>Reference of the source where the kustomization file is.</summary>
    [JsonPropertyName("sourceRef")]
    public required V1KustomizationSpecSourceRef SourceRef { get; set; }

    /// <summary>
    /// This flag tells the controller to suspend subsequent kustomize executions,
    /// it does not apply to already started executions. Defaults to false.
    /// </summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>
    /// TargetNamespace sets or overrides the namespace in the
    /// kustomization.yaml file.
    /// </summary>
    [JsonPropertyName("targetNamespace")]
    public string? TargetNamespace { get; set; }

    /// <summary>
    /// Timeout for validation, apply and health checking operations.
    /// Defaults to &apos;Interval&apos; duration.
    /// </summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>
    /// Wait instructs the controller to check the health of all the reconciled
    /// resources. When enabled, the HealthChecks are ignored. Defaults to false.
    /// </summary>
    [JsonPropertyName("wait")]
    public bool? Wait { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KustomizationStatusConditionsStatusEnum>))]
public enum V1KustomizationStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1KustomizationStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// Snapshot represents a point-in-time record of a group of resources reconciliation,
/// including timing information, status, and a unique digest identifier.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationStatusHistory
{
    /// <summary>Digest is the checksum in the format `&lt;algo&gt;:&lt;hex&gt;` of the resources in this snapshot.</summary>
    [JsonPropertyName("digest")]
    public required string Digest { get; set; }

    /// <summary>FirstReconciled is the time when this revision was first reconciled to the cluster.</summary>
    [JsonPropertyName("firstReconciled")]
    public required DateTime FirstReconciled { get; set; }

    /// <summary>LastReconciled is the time when this revision was last reconciled to the cluster.</summary>
    [JsonPropertyName("lastReconciled")]
    public required DateTime LastReconciled { get; set; }

    /// <summary>LastReconciledDuration is time it took to reconcile the resources in this revision.</summary>
    [JsonPropertyName("lastReconciledDuration")]
    public required string LastReconciledDuration { get; set; }

    /// <summary>LastReconciledStatus is the status of the last reconciliation.</summary>
    [JsonPropertyName("lastReconciledStatus")]
    public required string LastReconciledStatus { get; set; }

    /// <summary>Metadata contains additional information about the snapshot.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>TotalReconciliations is the total number of reconciliations that have occurred for this snapshot.</summary>
    [JsonPropertyName("totalReconciliations")]
    public required long TotalReconciliations { get; set; }
}

/// <summary>ResourceRef contains the information necessary to locate a resource within a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationStatusInventoryEntries
{
    /// <summary>
    /// ID is the string representation of the Kubernetes resource object&apos;s metadata,
    /// in the format &apos; &lt;namespace&gt;_&lt;name&gt;_&lt;group&gt;_&lt;kind&gt; &apos;.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>Version is the API version of the Kubernetes resource object&apos;s kind.</summary>
    [JsonPropertyName("v")]
    public required string V { get; set; }
}

/// <summary>
/// Inventory contains the list of Kubernetes resource object references that
/// have been successfully applied.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationStatusInventory
{
    /// <summary>Entries of Kubernetes resource object references.</summary>
    [JsonPropertyName("entries")]
    public required IList<V1KustomizationStatusInventoryEntries> Entries { get; set; }
}

/// <summary>KustomizationStatus defines the observed state of a kustomization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KustomizationStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1KustomizationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// History contains a set of snapshots of the last reconciliation attempts
    /// tracking the revision, the state and the duration of each attempt.
    /// </summary>
    [JsonPropertyName("history")]
    public IList<V1KustomizationStatusHistory>? History { get; set; }

    /// <summary>
    /// Inventory contains the list of Kubernetes resource object references that
    /// have been successfully applied.
    /// </summary>
    [JsonPropertyName("inventory")]
    public V1KustomizationStatusInventory? Inventory { get; set; }

    /// <summary>
    /// The last successfully applied origin revision.
    /// Equals the origin revision of the applied Artifact from the referenced Source.
    /// Usually present on the Metadata of the applied Artifact and depends on the
    /// Source type, e.g. for OCI it&apos;s the value associated with the key
    /// &quot;org.opencontainers.image.revision&quot;.
    /// </summary>
    [JsonPropertyName("lastAppliedOriginRevision")]
    public string? LastAppliedOriginRevision { get; set; }

    /// <summary>
    /// The last successfully applied revision.
    /// Equals the Revision of the applied Artifact from the referenced Source.
    /// </summary>
    [JsonPropertyName("lastAppliedRevision")]
    public string? LastAppliedRevision { get; set; }

    /// <summary>LastAttemptedRevision is the revision of the last reconciliation attempt.</summary>
    [JsonPropertyName("lastAttemptedRevision")]
    public string? LastAttemptedRevision { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile request value, so a change of the annotation value
    /// can be detected.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>ObservedGeneration is the last reconciled generation.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Kustomization is the Schema for the kustomizations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Kustomization : IKubernetesObject<V1ObjectMeta>, ISpec<V1KustomizationSpec?>, IStatus<V1KustomizationStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Kustomization";
    public const string KubeGroup = "kustomize.toolkit.fluxcd.io";
    public const string KubePluralName = "kustomizations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kustomize.toolkit.fluxcd.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Kustomization";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// KustomizationSpec defines the configuration to calculate the desired state
    /// from a Source using Kustomize.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1KustomizationSpec? Spec { get; set; }

    /// <summary>KustomizationStatus defines the observed state of a kustomization.</summary>
    [JsonPropertyName("status")]
    public V1KustomizationStatus? Status { get; set; }
}
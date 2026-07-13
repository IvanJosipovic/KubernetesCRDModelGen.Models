#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pkg.crossplane.io;
/// <summary>
/// A Function installs an OCI compatible Crossplane package, extending
/// Crossplane with support for a new kind of composition function.
/// 
/// Read the Crossplane documentation for
/// [more information about Functions](https://docs.crossplane.io/latest/packages/functions/).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FunctionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Function>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FunctionList";
    public const string KubeGroup = "pkg.crossplane.io";
    public const string KubePluralName = "functions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pkg.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FunctionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Function objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Function> Items { get; set; }
}

/// <summary>
/// LocalObjectReference contains enough information to let you locate the
/// referenced object inside the same namespace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecPackagePullSecrets
{
    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// RuntimeConfigRef references a RuntimeConfig resource that will be used
/// to configure the package runtime.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpecRuntimeConfigRef
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the RuntimeConfig.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>FunctionSpec specifies the configuration of a Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionSpec
{
    /// <summary>
    /// Map of string keys and values that can be used to annotate objects.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations/
    /// </summary>
    [JsonPropertyName("commonAnnotations")]
    public IDictionary<string, string>? CommonAnnotations { get; set; }

    /// <summary>
    /// Map of string keys and values that can be used to organize and categorize
    /// (scope and select) objects. May match selectors of replication controllers
    /// and services.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/
    /// </summary>
    [JsonPropertyName("commonLabels")]
    public IDictionary<string, string>? CommonLabels { get; set; }

    /// <summary>
    /// IgnoreCrossplaneConstraints indicates to the package manager whether to
    /// honor Crossplane version constrains specified by the package.
    /// Default is false.
    /// </summary>
    [JsonPropertyName("ignoreCrossplaneConstraints")]
    public bool? IgnoreCrossplaneConstraints { get; set; }

    /// <summary>
    /// Package is the name of the package that is being requested.
    /// must be a fully qualified image name, including the registry,
    /// repository, and tag. for example, &quot;registry.example.com/repo/package:tag&quot;.
    /// </summary>
    [JsonPropertyName("package")]
    public required string Package { get; set; }

    /// <summary>
    /// PackagePullPolicy defines the pull policy for the package.
    /// Default is IfNotPresent.
    /// </summary>
    [JsonPropertyName("packagePullPolicy")]
    public string? PackagePullPolicy { get; set; }

    /// <summary>
    /// PackagePullSecrets are named secrets in the same namespace that can be used
    /// to fetch packages from private registries.
    /// </summary>
    [JsonPropertyName("packagePullSecrets")]
    public IList<V1beta1FunctionSpecPackagePullSecrets>? PackagePullSecrets { get; set; }

    /// <summary>
    /// RevisionActivationPolicy specifies how the package controller should
    /// update from one revision to the next. Options are Automatic or Manual.
    /// Default is Automatic.
    /// </summary>
    [JsonPropertyName("revisionActivationPolicy")]
    public string? RevisionActivationPolicy { get; set; }

    /// <summary>
    /// RevisionHistoryLimit dictates how the package controller cleans up old
    /// inactive package revisions.
    /// Defaults to 1. Can be disabled by explicitly setting to 0.
    /// </summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public long? RevisionHistoryLimit { get; set; }

    /// <summary>
    /// RuntimeConfigRef references a RuntimeConfig resource that will be used
    /// to configure the package runtime.
    /// </summary>
    [JsonPropertyName("runtimeConfigRef")]
    public V1beta1FunctionSpecRuntimeConfigRef? RuntimeConfigRef { get; set; }

    /// <summary>
    /// SkipDependencyResolution indicates to the package manager whether to skip
    /// resolving dependencies for a package. Setting this value to true may have
    /// unintended consequences.
    /// Default is false.
    /// </summary>
    [JsonPropertyName("skipDependencyResolution")]
    public bool? SkipDependencyResolution { get; set; }
}

/// <summary>
/// ImageConfigRef is a reference to an image config that indicates how the
/// referenced image config was used by the package manager.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatusAppliedImageConfigRefs
{
    /// <summary>Name is the name of the image config.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Reason indicates what the image config was used for.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatusConditions
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

/// <summary>FunctionStatus represents the observed state of a Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionStatus
{
    /// <summary>
    /// AppliedImageConfigRefs records any image configs that were applied in
    /// reconciling this package, and what they were used for.
    /// </summary>
    [JsonPropertyName("appliedImageConfigRefs")]
    public IList<V1beta1FunctionStatusAppliedImageConfigRefs>? AppliedImageConfigRefs { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FunctionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// CurrentIdentifier is the most recent package source that was used to
    /// produce a revision. The package manager uses this field to determine
    /// whether to check for package updates for a given source when
    /// packagePullPolicy is set to IfNotPresent. Manually removing this field
    /// will cause the package manager to check that the current revision is
    /// correct for the given package source.
    /// </summary>
    [JsonPropertyName("currentIdentifier")]
    public string? CurrentIdentifier { get; set; }

    /// <summary>
    /// CurrentRevision is the name of the current package revision. It will
    /// reflect the most up to date revision, whether it has been activated or
    /// not.
    /// </summary>
    [JsonPropertyName("currentRevision")]
    public string? CurrentRevision { get; set; }

    /// <summary>
    /// ResolvedPackage is the name of the package that was used for version
    /// resolution. It may be different from spec.package if the package path was
    /// rewritten using an image config.
    /// </summary>
    [JsonPropertyName("resolvedPackage")]
    public string? ResolvedPackage { get; set; }
}

/// <summary>
/// A Function installs an OCI compatible Crossplane package, extending
/// Crossplane with support for a new kind of composition function.
/// 
/// Read the Crossplane documentation for
/// [more information about Functions](https://docs.crossplane.io/latest/packages/functions/).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Function : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FunctionSpec?>, IStatus<V1beta1FunctionStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Function";
    public const string KubeGroup = "pkg.crossplane.io";
    public const string KubePluralName = "functions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pkg.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Function";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FunctionSpec specifies the configuration of a Function.</summary>
    [JsonPropertyName("spec")]
    public V1beta1FunctionSpec? Spec { get; set; }

    /// <summary>FunctionStatus represents the observed state of a Function.</summary>
    [JsonPropertyName("status")]
    public V1beta1FunctionStatus? Status { get; set; }
}
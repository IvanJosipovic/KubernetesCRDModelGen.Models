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
/// A Configuration installs an OCI compatible Crossplane package, extending
/// Crossplane with support for new kinds of CompositeResourceDefinitions and
/// Compositions.
/// 
/// Read the Crossplane documentation for
/// [more information about Configuration packages]( https://docs.crossplane.io/latest/packages/configurations/).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1Configuration>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ConfigurationList";
    public const string KubeGroup = "pkg.crossplane.io";
    public const string KubePluralName = "configurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pkg.crossplane.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1Configuration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1Configuration> Items { get; set; }
}

/// <summary>
/// LocalObjectReference contains enough information to let you locate the
/// referenced object inside the same namespace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpecPackagePullSecrets
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
/// ConfigurationSpec specifies details about a request to install a
/// configuration to Crossplane.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationSpec
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
    public IList<V1ConfigurationSpecPackagePullSecrets>? PackagePullSecrets { get; set; }

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
public partial class V1ConfigurationStatusAppliedImageConfigRefs
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
public partial class V1ConfigurationStatusConditions
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

/// <summary>ConfigurationStatus represents the observed state of a Configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ConfigurationStatus
{
    /// <summary>
    /// AppliedImageConfigRefs records any image configs that were applied in
    /// reconciling this package, and what they were used for.
    /// </summary>
    [JsonPropertyName("appliedImageConfigRefs")]
    public IList<V1ConfigurationStatusAppliedImageConfigRefs>? AppliedImageConfigRefs { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1ConfigurationStatusConditions>? Conditions { get; set; }

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
/// A Configuration installs an OCI compatible Crossplane package, extending
/// Crossplane with support for new kinds of CompositeResourceDefinitions and
/// Compositions.
/// 
/// Read the Crossplane documentation for
/// [more information about Configuration packages]( https://docs.crossplane.io/latest/packages/configurations/).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Configuration : IKubernetesObject<V1ObjectMeta>, ISpec<V1ConfigurationSpec?>, IStatus<V1ConfigurationStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Configuration";
    public const string KubeGroup = "pkg.crossplane.io";
    public const string KubePluralName = "configurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pkg.crossplane.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Configuration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ConfigurationSpec specifies details about a request to install a
    /// configuration to Crossplane.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1ConfigurationSpec? Spec { get; set; }

    /// <summary>ConfigurationStatus represents the observed state of a Configuration.</summary>
    [JsonPropertyName("status")]
    public V1ConfigurationStatus? Status { get; set; }
}
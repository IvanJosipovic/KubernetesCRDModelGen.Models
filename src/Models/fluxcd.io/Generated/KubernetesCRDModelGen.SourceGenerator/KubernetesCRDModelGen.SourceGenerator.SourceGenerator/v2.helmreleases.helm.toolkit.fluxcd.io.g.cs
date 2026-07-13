#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.helm.toolkit.fluxcd.io;
/// <summary>HelmRelease is the Schema for the helmreleases API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V2HelmReleaseList : IKubernetesObject<V1ListMeta>, IItems<V2HelmRelease>
{
    public const string KubeApiVersion = "v2";
    public const string KubeKind = "HelmReleaseList";
    public const string KubeGroup = "helm.toolkit.fluxcd.io";
    public const string KubePluralName = "helmreleases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "helm.toolkit.fluxcd.io/v2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HelmReleaseList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V2HelmRelease objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V2HelmRelease> Items { get; set; }
}

/// <summary>ObjectMeta holds the template for metadata like labels and annotations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecChartMetadata
{
    /// <summary>
    /// Annotations is an unstructured key value map stored with a resource that may be
    /// set by external tools to store and retrieve arbitrary metadata. They are not
    /// queryable and should be preserved when modifying objects.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations/
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Map of string keys and values that can be used to organize and categorize
    /// (scope and select) objects.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>
/// Determines what enables the creation of a new artifact. Valid values are
/// (&apos;ChartVersion&apos;, &apos;Revision&apos;).
/// See the documentation of the values for an explanation on their behavior.
/// Defaults to ChartVersion when omitted.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecChartSpecReconcileStrategyEnum>))]
public enum V2HelmReleaseSpecChartSpecReconcileStrategyEnum
{
    [EnumMember(Value = "ChartVersion"), JsonStringEnumMemberName("ChartVersion")]
    ChartVersion,
    [EnumMember(Value = "Revision"), JsonStringEnumMemberName("Revision")]
    Revision
}

/// <summary>Kind of the referent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecChartSpecSourceRefKindEnum>))]
public enum V2HelmReleaseSpecChartSpecSourceRefKindEnum
{
    [EnumMember(Value = "HelmRepository"), JsonStringEnumMemberName("HelmRepository")]
    HelmRepository,
    [EnumMember(Value = "GitRepository"), JsonStringEnumMemberName("GitRepository")]
    GitRepository,
    [EnumMember(Value = "Bucket"), JsonStringEnumMemberName("Bucket")]
    Bucket
}

/// <summary>The name and namespace of the v1.Source the chart is available at.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecChartSpecSourceRef
{
    /// <summary>APIVersion of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public required V2HelmReleaseSpecChartSpecSourceRefKindEnum Kind { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referent.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Provider specifies the technology used to sign the OCI Helm chart.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecChartSpecVerifyProviderEnum>))]
public enum V2HelmReleaseSpecChartSpecVerifyProviderEnum
{
    [EnumMember(Value = "cosign"), JsonStringEnumMemberName("cosign")]
    Cosign,
    [EnumMember(Value = "notation"), JsonStringEnumMemberName("notation")]
    Notation
}

/// <summary>
/// SecretRef specifies the Kubernetes Secret containing the
/// trusted public keys.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecChartSpecVerifySecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Verify contains the secret name containing the trusted public keys
/// used to verify the signature and specifies which provider to use to check
/// whether OCI image is authentic.
/// This field is only supported for OCI sources.
/// Chart dependencies, which are not bundled in the umbrella chart artifact,
/// are not verified.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecChartSpecVerify
{
    /// <summary>Provider specifies the technology used to sign the OCI Helm chart.</summary>
    [JsonPropertyName("provider")]
    public V2HelmReleaseSpecChartSpecVerifyProviderEnum? Provider { get; set; }

    /// <summary>
    /// SecretRef specifies the Kubernetes Secret containing the
    /// trusted public keys.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V2HelmReleaseSpecChartSpecVerifySecretRef? SecretRef { get; set; }
}

/// <summary>Spec holds the template for the v1.HelmChartSpec for this HelmRelease.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecChartSpec
{
    /// <summary>The name or path the Helm chart is available at in the SourceRef.</summary>
    [JsonPropertyName("chart")]
    public required string Chart { get; set; }

    /// <summary>IgnoreMissingValuesFiles controls whether to silently ignore missing values files rather than failing.</summary>
    [JsonPropertyName("ignoreMissingValuesFiles")]
    public bool? IgnoreMissingValuesFiles { get; set; }

    /// <summary>
    /// Interval at which to check the v1.Source for updates. Defaults to
    /// &apos;HelmReleaseSpec.Interval&apos;.
    /// </summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>
    /// Determines what enables the creation of a new artifact. Valid values are
    /// (&apos;ChartVersion&apos;, &apos;Revision&apos;).
    /// See the documentation of the values for an explanation on their behavior.
    /// Defaults to ChartVersion when omitted.
    /// </summary>
    [JsonPropertyName("reconcileStrategy")]
    public V2HelmReleaseSpecChartSpecReconcileStrategyEnum? ReconcileStrategy { get; set; }

    /// <summary>The name and namespace of the v1.Source the chart is available at.</summary>
    [JsonPropertyName("sourceRef")]
    public required V2HelmReleaseSpecChartSpecSourceRef SourceRef { get; set; }

    /// <summary>
    /// Alternative list of values files to use as the chart values (values.yaml
    /// is not included by default), expected to be a relative path in the SourceRef.
    /// Values files are merged in the order of this list with the last file overriding
    /// the first. Ignored when omitted.
    /// </summary>
    [JsonPropertyName("valuesFiles")]
    public IList<string>? ValuesFiles { get; set; }

    /// <summary>
    /// Verify contains the secret name containing the trusted public keys
    /// used to verify the signature and specifies which provider to use to check
    /// whether OCI image is authentic.
    /// This field is only supported for OCI sources.
    /// Chart dependencies, which are not bundled in the umbrella chart artifact,
    /// are not verified.
    /// </summary>
    [JsonPropertyName("verify")]
    public V2HelmReleaseSpecChartSpecVerify? Verify { get; set; }

    /// <summary>
    /// Version semver expression, ignored for charts from v1.GitRepository and
    /// v1beta2.Bucket sources. Defaults to latest when omitted.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Chart defines the template of the v1.HelmChart that should be created
/// for this HelmRelease.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecChart
{
    /// <summary>ObjectMeta holds the template for metadata like labels and annotations.</summary>
    [JsonPropertyName("metadata")]
    public V2HelmReleaseSpecChartMetadata? Metadata { get; set; }

    /// <summary>Spec holds the template for the v1.HelmChartSpec for this HelmRelease.</summary>
    [JsonPropertyName("spec")]
    public required V2HelmReleaseSpecChartSpec Spec { get; set; }
}

/// <summary>Kind of the referent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecChartRefKindEnum>))]
public enum V2HelmReleaseSpecChartRefKindEnum
{
    [EnumMember(Value = "OCIRepository"), JsonStringEnumMemberName("OCIRepository")]
    OCIRepository,
    [EnumMember(Value = "HelmChart"), JsonStringEnumMemberName("HelmChart")]
    HelmChart,
    [EnumMember(Value = "ExternalArtifact"), JsonStringEnumMemberName("ExternalArtifact")]
    ExternalArtifact
}

/// <summary>
/// ChartRef holds a reference to a source controller resource containing the
/// Helm chart artifact.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecChartRef
{
    /// <summary>APIVersion of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public required V2HelmReleaseSpecChartRefKindEnum Kind { get; set; }

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
/// CommonMetadata specifies the common labels and annotations that are
/// applied to all resources. Any existing label or annotation will be
/// overridden if its key matches a common one.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecCommonMetadata
{
    /// <summary>Annotations to be added to the object&apos;s metadata.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels to be added to the object&apos;s metadata.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>
/// DependencyReference contains enough information to locate the referenced Kubernetes resource object
/// and optional CEL expression to assess its readiness.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecDependsOn
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

/// <summary>
/// Target is a selector for specifying Kubernetes objects to which this
/// rule applies.
/// If Target is not set, the Paths will be ignored for all Kubernetes
/// objects within the manifest of the Helm release.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecDriftDetectionIgnoreTarget
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
public partial class V2HelmReleaseSpecDriftDetectionIgnore
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
    /// objects within the manifest of the Helm release.
    /// </summary>
    [JsonPropertyName("target")]
    public V2HelmReleaseSpecDriftDetectionIgnoreTarget? Target { get; set; }
}

/// <summary>
/// Mode defines how differences should be handled between the Helm manifest
/// and the manifest currently applied to the cluster.
/// If not explicitly set, it defaults to DiffModeDisabled.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecDriftDetectionModeEnum>))]
public enum V2HelmReleaseSpecDriftDetectionModeEnum
{
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    Enabled,
    [EnumMember(Value = "warn"), JsonStringEnumMemberName("warn")]
    Warn,
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled
}

/// <summary>
/// DriftDetection holds the configuration for detecting and handling
/// differences between the manifest in the Helm storage and the resources
/// currently existing in the cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecDriftDetection
{
    /// <summary>
    /// Ignore contains a list of rules for specifying which changes to ignore
    /// during diffing.
    /// </summary>
    [JsonPropertyName("ignore")]
    public IList<V2HelmReleaseSpecDriftDetectionIgnore>? Ignore { get; set; }

    /// <summary>
    /// Mode defines how differences should be handled between the Helm manifest
    /// and the manifest currently applied to the cluster.
    /// If not explicitly set, it defaults to DiffModeDisabled.
    /// </summary>
    [JsonPropertyName("mode")]
    public V2HelmReleaseSpecDriftDetectionModeEnum? Mode { get; set; }
}

/// <summary>CustomHealthCheck defines the health check for custom resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecHealthCheckExprs
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
/// CRDs upgrade CRDs from the Helm Chart&apos;s crds directory according
/// to the CRD upgrade policy provided here. Valid values are `Skip`,
/// `Create` or `CreateReplace`. Default is `Create` and if omitted
/// CRDs are installed but not updated.
/// 
/// Skip: do neither install nor replace (update) any CRDs.
/// 
/// Create: new CRDs are created, existing CRDs are neither updated nor deleted.
/// 
/// CreateReplace: new CRDs are created, existing CRDs are updated (replaced)
/// but not deleted.
/// 
/// By default, CRDs are applied (installed) during Helm install action.
/// With this option users can opt in to CRD replace existing CRDs on Helm
/// install actions, which is not (yet) natively supported by Helm.
/// https://helm.sh/docs/chart_best_practices/custom_resource_definitions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecInstallCrdsEnum>))]
public enum V2HelmReleaseSpecInstallCrdsEnum
{
    [EnumMember(Value = "Skip"), JsonStringEnumMemberName("Skip")]
    Skip,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "CreateReplace"), JsonStringEnumMemberName("CreateReplace")]
    CreateReplace
}

/// <summary>
/// Remediation holds the remediation configuration for when the Helm install
/// action for the HelmRelease fails. The default is to not perform any action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecInstallRemediation
{
    /// <summary>
    /// IgnoreTestFailures tells the controller to skip remediation when the Helm
    /// tests are run after an install action but fail. Defaults to
    /// &apos;Test.IgnoreFailures&apos;.
    /// </summary>
    [JsonPropertyName("ignoreTestFailures")]
    public bool? IgnoreTestFailures { get; set; }

    /// <summary>
    /// RemediateLastFailure tells the controller to remediate the last failure, when
    /// no retries remain. Defaults to &apos;false&apos;.
    /// </summary>
    [JsonPropertyName("remediateLastFailure")]
    public bool? RemediateLastFailure { get; set; }

    /// <summary>
    /// Retries is the number of retries that should be attempted on failures before
    /// bailing. Remediation, using an uninstall, is performed between each attempt.
    /// Defaults to &apos;0&apos;, a negative integer equals to unlimited retries.
    /// </summary>
    [JsonPropertyName("retries")]
    public int? Retries { get; set; }
}

/// <summary>Name of the install strategy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecInstallStrategyNameEnum>))]
public enum V2HelmReleaseSpecInstallStrategyNameEnum
{
    [EnumMember(Value = "RemediateOnFailure"), JsonStringEnumMemberName("RemediateOnFailure")]
    RemediateOnFailure,
    [EnumMember(Value = "RetryOnFailure"), JsonStringEnumMemberName("RetryOnFailure")]
    RetryOnFailure
}

/// <summary>
/// Strategy defines the install strategy to use for this HelmRelease.
/// Defaults to &apos;RemediateOnFailure&apos;, or &apos;RetryOnFailure&apos; when the
/// DefaultToRetryOnFailure feature gate is enabled.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecInstallStrategy
{
    /// <summary>Name of the install strategy.</summary>
    [JsonPropertyName("name")]
    public required V2HelmReleaseSpecInstallStrategyNameEnum Name { get; set; }

    /// <summary>
    /// RetryInterval is the interval at which to retry a failed install.
    /// Can be used only when Name is set to RetryOnFailure.
    /// Defaults to &apos;5m&apos;.
    /// </summary>
    [JsonPropertyName("retryInterval")]
    public string? RetryInterval { get; set; }
}

/// <summary>Install holds the configuration for Helm install actions for this HelmRelease.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecInstall
{
    /// <summary>
    /// CRDs upgrade CRDs from the Helm Chart&apos;s crds directory according
    /// to the CRD upgrade policy provided here. Valid values are `Skip`,
    /// `Create` or `CreateReplace`. Default is `Create` and if omitted
    /// CRDs are installed but not updated.
    /// 
    /// Skip: do neither install nor replace (update) any CRDs.
    /// 
    /// Create: new CRDs are created, existing CRDs are neither updated nor deleted.
    /// 
    /// CreateReplace: new CRDs are created, existing CRDs are updated (replaced)
    /// but not deleted.
    /// 
    /// By default, CRDs are applied (installed) during Helm install action.
    /// With this option users can opt in to CRD replace existing CRDs on Helm
    /// install actions, which is not (yet) natively supported by Helm.
    /// https://helm.sh/docs/chart_best_practices/custom_resource_definitions.
    /// </summary>
    [JsonPropertyName("crds")]
    public V2HelmReleaseSpecInstallCrdsEnum? Crds { get; set; }

    /// <summary>
    /// CreateNamespace tells the Helm install action to create the
    /// HelmReleaseSpec.TargetNamespace if it does not exist yet.
    /// On uninstall, the namespace will not be garbage collected.
    /// </summary>
    [JsonPropertyName("createNamespace")]
    public bool? CreateNamespace { get; set; }

    /// <summary>DisableHooks prevents hooks from running during the Helm install action.</summary>
    [JsonPropertyName("disableHooks")]
    public bool? DisableHooks { get; set; }

    /// <summary>
    /// DisableOpenAPIValidation prevents the Helm install action from validating
    /// rendered templates against the Kubernetes OpenAPI Schema.
    /// </summary>
    [JsonPropertyName("disableOpenAPIValidation")]
    public bool? DisableOpenAPIValidation { get; set; }

    /// <summary>
    /// DisableSchemaValidation prevents the Helm install action from validating
    /// the values against the JSON Schema.
    /// </summary>
    [JsonPropertyName("disableSchemaValidation")]
    public bool? DisableSchemaValidation { get; set; }

    /// <summary>
    /// DisableTakeOwnership disables taking ownership of existing resources
    /// during the Helm install action. Defaults to false.
    /// </summary>
    [JsonPropertyName("disableTakeOwnership")]
    public bool? DisableTakeOwnership { get; set; }

    /// <summary>
    /// DisableWait disables the waiting for resources to be ready after a Helm
    /// install has been performed.
    /// </summary>
    [JsonPropertyName("disableWait")]
    public bool? DisableWait { get; set; }

    /// <summary>
    /// DisableWaitForJobs disables waiting for jobs to complete after a Helm
    /// install has been performed.
    /// </summary>
    [JsonPropertyName("disableWaitForJobs")]
    public bool? DisableWaitForJobs { get; set; }

    /// <summary>
    /// Remediation holds the remediation configuration for when the Helm install
    /// action for the HelmRelease fails. The default is to not perform any action.
    /// </summary>
    [JsonPropertyName("remediation")]
    public V2HelmReleaseSpecInstallRemediation? Remediation { get; set; }

    /// <summary>
    /// Replace tells the Helm install action to re-use the &apos;ReleaseName&apos;, but only
    /// if that name is a deleted release which remains in the history.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }

    /// <summary>
    /// ServerSideApply enables server-side apply for resources during install.
    /// Defaults to true (or false when UseHelm3Defaults feature gate is enabled).
    /// </summary>
    [JsonPropertyName("serverSideApply")]
    public bool? ServerSideApply { get; set; }

    /// <summary>
    /// SkipCRDs tells the Helm install action to not install any CRDs. By default,
    /// CRDs are installed if not already present.
    /// 
    /// Deprecated use CRD policy (`crds`) attribute with value `Skip` instead.
    /// </summary>
    [JsonPropertyName("skipCRDs")]
    public bool? SkipCRDs { get; set; }

    /// <summary>
    /// Strategy defines the install strategy to use for this HelmRelease.
    /// Defaults to &apos;RemediateOnFailure&apos;, or &apos;RetryOnFailure&apos; when the
    /// DefaultToRetryOnFailure feature gate is enabled.
    /// </summary>
    [JsonPropertyName("strategy")]
    public V2HelmReleaseSpecInstallStrategy? Strategy { get; set; }

    /// <summary>
    /// Timeout is the time to wait for any individual Kubernetes operation (like
    /// Jobs for hooks) during the performance of a Helm install action. Defaults to
    /// &apos;HelmReleaseSpec.Timeout&apos;.
    /// </summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
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
public partial class V2HelmReleaseSpecKubeConfigConfigMapRef
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
public partial class V2HelmReleaseSpecKubeConfigSecretRef
{
    /// <summary>Key in the Secret, when not specified an implementation-specific default key is used.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name of the Secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// KubeConfig for reconciling the HelmRelease on a remote cluster.
/// When used in combination with HelmReleaseSpec.ServiceAccountName,
/// forces the controller to act on behalf of that Service Account at the
/// target cluster.
/// If the --default-service-account flag is set, its value will be used as
/// a controller level fallback for when HelmReleaseSpec.ServiceAccountName
/// is empty.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecKubeConfig
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
    public V2HelmReleaseSpecKubeConfigConfigMapRef? ConfigMapRef { get; set; }

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
    public V2HelmReleaseSpecKubeConfigSecretRef? SecretRef { get; set; }
}

/// <summary>
/// PostRenderStrategy defines the strategy for sending hooks to post-renderers.
/// Valid values are &apos;nohooks&apos; (hooks not sent to post-renderers, Helm 3 behavior),
/// &apos;combined&apos; (hooks and templates sent together, Helm 4 default), and &apos;separate&apos;
/// (hooks and templates sent in separate streams, Helm 4.2 opt-in).
/// Defaults to &apos;combined&apos;, or &apos;nohooks&apos; when the UseHelm3Defaults feature gate is enabled.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecPostRenderStrategyEnum>))]
public enum V2HelmReleaseSpecPostRenderStrategyEnum
{
    [EnumMember(Value = "nohooks"), JsonStringEnumMemberName("nohooks")]
    Nohooks,
    [EnumMember(Value = "combined"), JsonStringEnumMemberName("combined")]
    Combined,
    [EnumMember(Value = "separate"), JsonStringEnumMemberName("separate")]
    Separate
}

/// <summary>Image contains an image name, a new name, a new tag or digest, which will replace the original name and tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecPostRenderersKustomizeImages
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

/// <summary>Target points to the resources that the patch document should be applied to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecPostRenderersKustomizePatchesTarget
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
public partial class V2HelmReleaseSpecPostRenderersKustomizePatches
{
    /// <summary>
    /// Patch contains an inline StrategicMerge patch or an inline JSON6902 patch with
    /// an array of operation objects.
    /// </summary>
    [JsonPropertyName("patch")]
    public required string Patch { get; set; }

    /// <summary>Target points to the resources that the patch document should be applied to.</summary>
    [JsonPropertyName("target")]
    public V2HelmReleaseSpecPostRenderersKustomizePatchesTarget? Target { get; set; }
}

/// <summary>Kustomization to apply as PostRenderer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecPostRenderersKustomize
{
    /// <summary>
    /// Images is a list of (image name, new name, new tag or digest)
    /// for changing image names, tags or digests. This can also be achieved with a
    /// patch, but this operator is simpler to specify.
    /// </summary>
    [JsonPropertyName("images")]
    public IList<V2HelmReleaseSpecPostRenderersKustomizeImages>? Images { get; set; }

    /// <summary>
    /// Strategic merge and JSON patches, defined as inline YAML objects,
    /// capable of targeting objects based on kind, label and annotation selectors.
    /// </summary>
    [JsonPropertyName("patches")]
    public IList<V2HelmReleaseSpecPostRenderersKustomizePatches>? Patches { get; set; }
}

/// <summary>PostRenderer contains a Helm PostRenderer specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecPostRenderers
{
    /// <summary>Kustomization to apply as PostRenderer.</summary>
    [JsonPropertyName("kustomize")]
    public V2HelmReleaseSpecPostRenderersKustomize? Kustomize { get; set; }
}

/// <summary>
/// ServerSideApply enables server-side apply for resources during rollback.
/// Can be &quot;enabled&quot;, &quot;disabled&quot;, or &quot;auto&quot;.
/// When &quot;auto&quot;, server-side apply usage will be based on the release&apos;s previous usage.
/// Defaults to &quot;auto&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecRollbackServerSideApplyEnum>))]
public enum V2HelmReleaseSpecRollbackServerSideApplyEnum
{
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    Enabled,
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled,
    [EnumMember(Value = "auto"), JsonStringEnumMemberName("auto")]
    Auto
}

/// <summary>Rollback holds the configuration for Helm rollback actions for this HelmRelease.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecRollback
{
    /// <summary>
    /// CleanupOnFail allows deletion of new resources created during the Helm
    /// rollback action when it fails.
    /// </summary>
    [JsonPropertyName("cleanupOnFail")]
    public bool? CleanupOnFail { get; set; }

    /// <summary>DisableHooks prevents hooks from running during the Helm rollback action.</summary>
    [JsonPropertyName("disableHooks")]
    public bool? DisableHooks { get; set; }

    /// <summary>
    /// DisableWait disables the waiting for resources to be ready after a Helm
    /// rollback has been performed.
    /// </summary>
    [JsonPropertyName("disableWait")]
    public bool? DisableWait { get; set; }

    /// <summary>
    /// DisableWaitForJobs disables waiting for jobs to complete after a Helm
    /// rollback has been performed.
    /// </summary>
    [JsonPropertyName("disableWaitForJobs")]
    public bool? DisableWaitForJobs { get; set; }

    /// <summary>
    /// Force forces resource updates through a replacement strategy
    /// that avoids 3-way merge conflicts on client-side apply.
    /// This field is ignored for server-side apply (which always
    /// forces conflicts with other field managers).
    /// </summary>
    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    /// <summary>
    /// Recreate performs pod restarts for any managed workloads.
    /// 
    /// Deprecated: This behavior was deprecated in Helm 3:
    ///   - Deprecation: https://github.com/helm/helm/pull/6463
    ///   - Removal: https://github.com/helm/helm/pull/31023
    /// After helm-controller was upgraded to the Helm 4 SDK,
    /// this field is no longer functional and will print a
    /// warning if set to true. It will also be removed in a
    /// future release.
    /// </summary>
    [JsonPropertyName("recreate")]
    public bool? Recreate { get; set; }

    /// <summary>
    /// ServerSideApply enables server-side apply for resources during rollback.
    /// Can be &quot;enabled&quot;, &quot;disabled&quot;, or &quot;auto&quot;.
    /// When &quot;auto&quot;, server-side apply usage will be based on the release&apos;s previous usage.
    /// Defaults to &quot;auto&quot;.
    /// </summary>
    [JsonPropertyName("serverSideApply")]
    public V2HelmReleaseSpecRollbackServerSideApplyEnum? ServerSideApply { get; set; }

    /// <summary>
    /// Timeout is the time to wait for any individual Kubernetes operation (like
    /// Jobs for hooks) during the performance of a Helm rollback action. Defaults to
    /// &apos;HelmReleaseSpec.Timeout&apos;.
    /// </summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>Filter holds the configuration for individual Helm test filters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecTestFilters
{
    /// <summary>Exclude specifies whether the named test should be excluded.</summary>
    [JsonPropertyName("exclude")]
    public bool? Exclude { get; set; }

    /// <summary>Name is the name of the test.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Test holds the configuration for Helm test actions for this HelmRelease.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecTest
{
    /// <summary>
    /// Enable enables Helm test actions for this HelmRelease after an Helm install
    /// or upgrade action has been performed.
    /// </summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Filters is a list of tests to run or exclude from running.</summary>
    [JsonPropertyName("filters")]
    public IList<V2HelmReleaseSpecTestFilters>? Filters { get; set; }

    /// <summary>
    /// IgnoreFailures tells the controller to skip remediation when the Helm tests
    /// are run but fail. Can be overwritten for tests run after install or upgrade
    /// actions in &apos;Install.IgnoreTestFailures&apos; and &apos;Upgrade.IgnoreTestFailures&apos;.
    /// </summary>
    [JsonPropertyName("ignoreFailures")]
    public bool? IgnoreFailures { get; set; }

    /// <summary>
    /// Timeout is the time to wait for any individual Kubernetes operation during
    /// the performance of a Helm test action. Defaults to &apos;HelmReleaseSpec.Timeout&apos;.
    /// </summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>
/// DeletionPropagation specifies the deletion propagation policy when
/// a Helm uninstall is performed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecUninstallDeletionPropagationEnum>))]
public enum V2HelmReleaseSpecUninstallDeletionPropagationEnum
{
    [EnumMember(Value = "background"), JsonStringEnumMemberName("background")]
    Background,
    [EnumMember(Value = "foreground"), JsonStringEnumMemberName("foreground")]
    Foreground,
    [EnumMember(Value = "orphan"), JsonStringEnumMemberName("orphan")]
    Orphan
}

/// <summary>Uninstall holds the configuration for Helm uninstall actions for this HelmRelease.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecUninstall
{
    /// <summary>
    /// DeletionPropagation specifies the deletion propagation policy when
    /// a Helm uninstall is performed.
    /// </summary>
    [JsonPropertyName("deletionPropagation")]
    public V2HelmReleaseSpecUninstallDeletionPropagationEnum? DeletionPropagation { get; set; }

    /// <summary>DisableHooks prevents hooks from running during the Helm rollback action.</summary>
    [JsonPropertyName("disableHooks")]
    public bool? DisableHooks { get; set; }

    /// <summary>
    /// DisableWait disables waiting for all the resources to be deleted after
    /// a Helm uninstall is performed.
    /// </summary>
    [JsonPropertyName("disableWait")]
    public bool? DisableWait { get; set; }

    /// <summary>
    /// KeepHistory tells Helm to remove all associated resources and mark the
    /// release as deleted, but retain the release history.
    /// </summary>
    [JsonPropertyName("keepHistory")]
    public bool? KeepHistory { get; set; }

    /// <summary>
    /// Timeout is the time to wait for any individual Kubernetes operation (like
    /// Jobs for hooks) during the performance of a Helm uninstall action. Defaults
    /// to &apos;HelmReleaseSpec.Timeout&apos;.
    /// </summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>
/// ChartNameChangeStrategy defines the strategy to use when a Helm chart name changes.
/// Valid values are &apos;Reinstall&apos; or &apos;InPlaceUpdate&apos;. Defaults to &apos;Reinstall&apos; if omitted.
/// 
/// Reinstall: Reinstall the Helm release, uninstalling the existing Helm release.
/// 
/// InPlaceUpdate: Update the Helm release in place.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecUpgradeChartNameChangeStrategyEnum>))]
public enum V2HelmReleaseSpecUpgradeChartNameChangeStrategyEnum
{
    [EnumMember(Value = "InPlaceUpdate"), JsonStringEnumMemberName("InPlaceUpdate")]
    InPlaceUpdate,
    [EnumMember(Value = "Reinstall"), JsonStringEnumMemberName("Reinstall")]
    Reinstall
}

/// <summary>
/// CRDs upgrade CRDs from the Helm Chart&apos;s crds directory according
/// to the CRD upgrade policy provided here. Valid values are `Skip`,
/// `Create` or `CreateReplace`. Default is `Skip` and if omitted
/// CRDs are neither installed nor upgraded.
/// 
/// Skip: do neither install nor replace (update) any CRDs.
/// 
/// Create: new CRDs are created, existing CRDs are neither updated nor deleted.
/// 
/// CreateReplace: new CRDs are created, existing CRDs are updated (replaced)
/// but not deleted.
/// 
/// By default, CRDs are not applied during Helm upgrade action. With this
/// option users can opt-in to CRD upgrade, which is not (yet) natively supported by Helm.
/// https://helm.sh/docs/chart_best_practices/custom_resource_definitions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecUpgradeCrdsEnum>))]
public enum V2HelmReleaseSpecUpgradeCrdsEnum
{
    [EnumMember(Value = "Skip"), JsonStringEnumMemberName("Skip")]
    Skip,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "CreateReplace"), JsonStringEnumMemberName("CreateReplace")]
    CreateReplace
}

/// <summary>Strategy to use for failure remediation. Defaults to &apos;rollback&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecUpgradeRemediationStrategyEnum>))]
public enum V2HelmReleaseSpecUpgradeRemediationStrategyEnum
{
    [EnumMember(Value = "rollback"), JsonStringEnumMemberName("rollback")]
    Rollback,
    [EnumMember(Value = "uninstall"), JsonStringEnumMemberName("uninstall")]
    Uninstall
}

/// <summary>
/// Remediation holds the remediation configuration for when the Helm upgrade
/// action for the HelmRelease fails. The default is to not perform any action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecUpgradeRemediation
{
    /// <summary>
    /// IgnoreTestFailures tells the controller to skip remediation when the Helm
    /// tests are run after an upgrade action but fail.
    /// Defaults to &apos;Test.IgnoreFailures&apos;.
    /// </summary>
    [JsonPropertyName("ignoreTestFailures")]
    public bool? IgnoreTestFailures { get; set; }

    /// <summary>
    /// RemediateLastFailure tells the controller to remediate the last failure, when
    /// no retries remain. Defaults to &apos;false&apos; unless &apos;Retries&apos; is greater than 0.
    /// </summary>
    [JsonPropertyName("remediateLastFailure")]
    public bool? RemediateLastFailure { get; set; }

    /// <summary>
    /// Retries is the number of retries that should be attempted on failures before
    /// bailing. Remediation, using &apos;Strategy&apos;, is performed between each attempt.
    /// Defaults to &apos;0&apos;, a negative integer equals to unlimited retries.
    /// </summary>
    [JsonPropertyName("retries")]
    public int? Retries { get; set; }

    /// <summary>Strategy to use for failure remediation. Defaults to &apos;rollback&apos;.</summary>
    [JsonPropertyName("strategy")]
    public V2HelmReleaseSpecUpgradeRemediationStrategyEnum? Strategy { get; set; }
}

/// <summary>
/// ServerSideApply enables server-side apply for resources during upgrade.
/// Can be &quot;enabled&quot;, &quot;disabled&quot;, or &quot;auto&quot;.
/// When &quot;auto&quot;, server-side apply usage will be based on the release&apos;s previous usage.
/// Defaults to &quot;auto&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecUpgradeServerSideApplyEnum>))]
public enum V2HelmReleaseSpecUpgradeServerSideApplyEnum
{
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    Enabled,
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled,
    [EnumMember(Value = "auto"), JsonStringEnumMemberName("auto")]
    Auto
}

/// <summary>Name of the upgrade strategy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecUpgradeStrategyNameEnum>))]
public enum V2HelmReleaseSpecUpgradeStrategyNameEnum
{
    [EnumMember(Value = "RemediateOnFailure"), JsonStringEnumMemberName("RemediateOnFailure")]
    RemediateOnFailure,
    [EnumMember(Value = "RetryOnFailure"), JsonStringEnumMemberName("RetryOnFailure")]
    RetryOnFailure
}

/// <summary>
/// Strategy defines the upgrade strategy to use for this HelmRelease.
/// Defaults to &apos;RemediateOnFailure&apos;, or &apos;RetryOnFailure&apos; when the
/// DefaultToRetryOnFailure feature gate is enabled.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecUpgradeStrategy
{
    /// <summary>Name of the upgrade strategy.</summary>
    [JsonPropertyName("name")]
    public required V2HelmReleaseSpecUpgradeStrategyNameEnum Name { get; set; }

    /// <summary>
    /// RetryInterval is the interval at which to retry a failed upgrade.
    /// Can be used only when Name is set to RetryOnFailure.
    /// Defaults to &apos;5m&apos;.
    /// </summary>
    [JsonPropertyName("retryInterval")]
    public string? RetryInterval { get; set; }
}

/// <summary>Upgrade holds the configuration for Helm upgrade actions for this HelmRelease.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecUpgrade
{
    /// <summary>
    /// ChartNameChangeStrategy defines the strategy to use when a Helm chart name changes.
    /// Valid values are &apos;Reinstall&apos; or &apos;InPlaceUpdate&apos;. Defaults to &apos;Reinstall&apos; if omitted.
    /// 
    /// Reinstall: Reinstall the Helm release, uninstalling the existing Helm release.
    /// 
    /// InPlaceUpdate: Update the Helm release in place.
    /// </summary>
    [JsonPropertyName("chartNameChangeStrategy")]
    public V2HelmReleaseSpecUpgradeChartNameChangeStrategyEnum? ChartNameChangeStrategy { get; set; }

    /// <summary>
    /// CleanupOnFail allows deletion of new resources created during the Helm
    /// upgrade action when it fails.
    /// </summary>
    [JsonPropertyName("cleanupOnFail")]
    public bool? CleanupOnFail { get; set; }

    /// <summary>
    /// CRDs upgrade CRDs from the Helm Chart&apos;s crds directory according
    /// to the CRD upgrade policy provided here. Valid values are `Skip`,
    /// `Create` or `CreateReplace`. Default is `Skip` and if omitted
    /// CRDs are neither installed nor upgraded.
    /// 
    /// Skip: do neither install nor replace (update) any CRDs.
    /// 
    /// Create: new CRDs are created, existing CRDs are neither updated nor deleted.
    /// 
    /// CreateReplace: new CRDs are created, existing CRDs are updated (replaced)
    /// but not deleted.
    /// 
    /// By default, CRDs are not applied during Helm upgrade action. With this
    /// option users can opt-in to CRD upgrade, which is not (yet) natively supported by Helm.
    /// https://helm.sh/docs/chart_best_practices/custom_resource_definitions.
    /// </summary>
    [JsonPropertyName("crds")]
    public V2HelmReleaseSpecUpgradeCrdsEnum? Crds { get; set; }

    /// <summary>DisableHooks prevents hooks from running during the Helm upgrade action.</summary>
    [JsonPropertyName("disableHooks")]
    public bool? DisableHooks { get; set; }

    /// <summary>
    /// DisableOpenAPIValidation prevents the Helm upgrade action from validating
    /// rendered templates against the Kubernetes OpenAPI Schema.
    /// </summary>
    [JsonPropertyName("disableOpenAPIValidation")]
    public bool? DisableOpenAPIValidation { get; set; }

    /// <summary>
    /// DisableSchemaValidation prevents the Helm upgrade action from validating
    /// the values against the JSON Schema.
    /// </summary>
    [JsonPropertyName("disableSchemaValidation")]
    public bool? DisableSchemaValidation { get; set; }

    /// <summary>
    /// DisableTakeOwnership disables taking ownership of existing resources
    /// during the Helm upgrade action. Defaults to false.
    /// </summary>
    [JsonPropertyName("disableTakeOwnership")]
    public bool? DisableTakeOwnership { get; set; }

    /// <summary>
    /// DisableWait disables the waiting for resources to be ready after a Helm
    /// upgrade has been performed.
    /// </summary>
    [JsonPropertyName("disableWait")]
    public bool? DisableWait { get; set; }

    /// <summary>
    /// DisableWaitForJobs disables waiting for jobs to complete after a Helm
    /// upgrade has been performed.
    /// </summary>
    [JsonPropertyName("disableWaitForJobs")]
    public bool? DisableWaitForJobs { get; set; }

    /// <summary>
    /// Force forces resource updates through a replacement strategy
    /// that avoids 3-way merge conflicts on client-side apply.
    /// This field is ignored for server-side apply (which always
    /// forces conflicts with other field managers).
    /// </summary>
    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    /// <summary>
    /// PreserveValues will make Helm reuse the last release&apos;s values and merge in
    /// overrides from &apos;Values&apos;. Setting this flag makes the HelmRelease
    /// non-declarative.
    /// </summary>
    [JsonPropertyName("preserveValues")]
    public bool? PreserveValues { get; set; }

    /// <summary>
    /// Remediation holds the remediation configuration for when the Helm upgrade
    /// action for the HelmRelease fails. The default is to not perform any action.
    /// </summary>
    [JsonPropertyName("remediation")]
    public V2HelmReleaseSpecUpgradeRemediation? Remediation { get; set; }

    /// <summary>
    /// ServerSideApply enables server-side apply for resources during upgrade.
    /// Can be &quot;enabled&quot;, &quot;disabled&quot;, or &quot;auto&quot;.
    /// When &quot;auto&quot;, server-side apply usage will be based on the release&apos;s previous usage.
    /// Defaults to &quot;auto&quot;.
    /// </summary>
    [JsonPropertyName("serverSideApply")]
    public V2HelmReleaseSpecUpgradeServerSideApplyEnum? ServerSideApply { get; set; }

    /// <summary>
    /// Strategy defines the upgrade strategy to use for this HelmRelease.
    /// Defaults to &apos;RemediateOnFailure&apos;, or &apos;RetryOnFailure&apos; when the
    /// DefaultToRetryOnFailure feature gate is enabled.
    /// </summary>
    [JsonPropertyName("strategy")]
    public V2HelmReleaseSpecUpgradeStrategy? Strategy { get; set; }

    /// <summary>
    /// Timeout is the time to wait for any individual Kubernetes operation (like
    /// Jobs for hooks) during the performance of a Helm upgrade action. Defaults to
    /// &apos;HelmReleaseSpec.Timeout&apos;.
    /// </summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>Kind of the values referent, valid values are (&apos;Secret&apos;, &apos;ConfigMap&apos;).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecValuesFromKindEnum>))]
public enum V2HelmReleaseSpecValuesFromKindEnum
{
    [EnumMember(Value = "Secret"), JsonStringEnumMemberName("Secret")]
    Secret,
    [EnumMember(Value = "ConfigMap"), JsonStringEnumMemberName("ConfigMap")]
    ConfigMap
}

/// <summary>
/// ValuesReference contains a reference to a resource containing Helm values,
/// and optionally the key they can be found at.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecValuesFrom
{
    /// <summary>Kind of the values referent, valid values are (&apos;Secret&apos;, &apos;ConfigMap&apos;).</summary>
    [JsonPropertyName("kind")]
    public required V2HelmReleaseSpecValuesFromKindEnum Kind { get; set; }

    /// <summary>
    /// Literal marks this ValuesReference as a literal value. When set in
    /// combination with TargetPath, the referenced value is merged at the target
    /// path without interpreting Helm&apos;s `--set` syntax (commas, brackets, dots,
    /// equal signs, etc.), mirroring the behavior of `helm --set-literal`. This
    /// is the only safe way to inject arbitrary file content (config files, JSON
    /// blobs, multi-line strings containing special characters) through
    /// `valuesFrom`. Has no effect when TargetPath is empty: in that mode the
    /// referenced value is always YAML-merged at the root.
    /// </summary>
    [JsonPropertyName("literal")]
    public bool? Literal { get; set; }

    /// <summary>
    /// Name of the values referent. Should reside in the same namespace as the
    /// referring resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Optional marks this ValuesReference as optional. When set, a not found error
    /// for the values reference is ignored, but any ValuesKey, TargetPath or
    /// transient error will still result in a reconciliation failure.
    /// </summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    /// <summary>
    /// TargetPath is the YAML dot notation path the value should be merged at. When
    /// set, the ValuesKey is expected to be a single flat value. Defaults to &apos;None&apos;,
    /// which results in the values getting merged at the root.
    /// </summary>
    [JsonPropertyName("targetPath")]
    public string? TargetPath { get; set; }

    /// <summary>
    /// ValuesKey is the data key where the values.yaml or a specific value can be
    /// found at. Defaults to &apos;values.yaml&apos;.
    /// </summary>
    [JsonPropertyName("valuesKey")]
    public string? ValuesKey { get; set; }
}

/// <summary>
/// Name is Helm&apos;s wait strategy for waiting for applied resources to
/// become ready. One of &apos;poller&apos; or &apos;legacy&apos;. The &apos;poller&apos; strategy uses
/// kstatus to poll resource statuses, while the &apos;legacy&apos; strategy uses
/// Helm v3&apos;s waiting logic.
/// Defaults to &apos;poller&apos;, or to &apos;legacy&apos; when UseHelm3Defaults feature
/// gate is enabled.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseSpecWaitStrategyNameEnum>))]
public enum V2HelmReleaseSpecWaitStrategyNameEnum
{
    [EnumMember(Value = "poller"), JsonStringEnumMemberName("poller")]
    Poller,
    [EnumMember(Value = "legacy"), JsonStringEnumMemberName("legacy")]
    Legacy
}

/// <summary>
/// WaitStrategy defines Helm&apos;s wait strategy for waiting for applied
/// resources to become ready.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpecWaitStrategy
{
    /// <summary>
    /// Name is Helm&apos;s wait strategy for waiting for applied resources to
    /// become ready. One of &apos;poller&apos; or &apos;legacy&apos;. The &apos;poller&apos; strategy uses
    /// kstatus to poll resource statuses, while the &apos;legacy&apos; strategy uses
    /// Helm v3&apos;s waiting logic.
    /// Defaults to &apos;poller&apos;, or to &apos;legacy&apos; when UseHelm3Defaults feature
    /// gate is enabled.
    /// </summary>
    [JsonPropertyName("name")]
    public required V2HelmReleaseSpecWaitStrategyNameEnum Name { get; set; }
}

/// <summary>HelmReleaseSpec defines the desired state of a Helm release.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseSpec
{
    /// <summary>
    /// Chart defines the template of the v1.HelmChart that should be created
    /// for this HelmRelease.
    /// </summary>
    [JsonPropertyName("chart")]
    public V2HelmReleaseSpecChart? Chart { get; set; }

    /// <summary>
    /// ChartRef holds a reference to a source controller resource containing the
    /// Helm chart artifact.
    /// </summary>
    [JsonPropertyName("chartRef")]
    public V2HelmReleaseSpecChartRef? ChartRef { get; set; }

    /// <summary>
    /// CommonMetadata specifies the common labels and annotations that are
    /// applied to all resources. Any existing label or annotation will be
    /// overridden if its key matches a common one.
    /// </summary>
    [JsonPropertyName("commonMetadata")]
    public V2HelmReleaseSpecCommonMetadata? CommonMetadata { get; set; }

    /// <summary>
    /// DependsOn may contain a DependencyReference slice with
    /// references to HelmRelease resources that must be ready before this HelmRelease
    /// can be reconciled.
    /// </summary>
    [JsonPropertyName("dependsOn")]
    public IList<V2HelmReleaseSpecDependsOn>? DependsOn { get; set; }

    /// <summary>
    /// DriftDetection holds the configuration for detecting and handling
    /// differences between the manifest in the Helm storage and the resources
    /// currently existing in the cluster.
    /// </summary>
    [JsonPropertyName("driftDetection")]
    public V2HelmReleaseSpecDriftDetection? DriftDetection { get; set; }

    /// <summary>
    /// HealthCheckExprs is a list of healthcheck expressions for evaluating the
    /// health of custom resources using Common Expression Language (CEL).
    /// The expressions are evaluated only when the specific Helm action
    /// taking place has wait enabled, i.e. DisableWait is false, and the
    /// &apos;poller&apos; WaitStrategy is used.
    /// </summary>
    [JsonPropertyName("healthCheckExprs")]
    public IList<V2HelmReleaseSpecHealthCheckExprs>? HealthCheckExprs { get; set; }

    /// <summary>Install holds the configuration for Helm install actions for this HelmRelease.</summary>
    [JsonPropertyName("install")]
    public V2HelmReleaseSpecInstall? Install { get; set; }

    /// <summary>Interval at which to reconcile the Helm release.</summary>
    [JsonPropertyName("interval")]
    public required string Interval { get; set; }

    /// <summary>
    /// KubeConfig for reconciling the HelmRelease on a remote cluster.
    /// When used in combination with HelmReleaseSpec.ServiceAccountName,
    /// forces the controller to act on behalf of that Service Account at the
    /// target cluster.
    /// If the --default-service-account flag is set, its value will be used as
    /// a controller level fallback for when HelmReleaseSpec.ServiceAccountName
    /// is empty.
    /// </summary>
    [JsonPropertyName("kubeConfig")]
    public V2HelmReleaseSpecKubeConfig? KubeConfig { get; set; }

    /// <summary>
    /// MaxHistory is the number of revisions saved by Helm for this HelmRelease.
    /// Use &apos;0&apos; for an unlimited number of revisions; defaults to &apos;5&apos;.
    /// </summary>
    [JsonPropertyName("maxHistory")]
    public int? MaxHistory { get; set; }

    /// <summary>
    /// PersistentClient tells the controller to use a persistent Kubernetes
    /// client for this release. When enabled, the client will be reused for the
    /// duration of the reconciliation, instead of being created and destroyed
    /// for each (step of a) Helm action.
    /// 
    /// This can improve performance, but may cause issues with some Helm charts
    /// that for example do create Custom Resource Definitions during installation
    /// outside Helm&apos;s CRD lifecycle hooks, which are then not observed to be
    /// available by e.g. post-install hooks.
    /// 
    /// If not set, it defaults to true.
    /// </summary>
    [JsonPropertyName("persistentClient")]
    public bool? PersistentClient { get; set; }

    /// <summary>
    /// PostRenderStrategy defines the strategy for sending hooks to post-renderers.
    /// Valid values are &apos;nohooks&apos; (hooks not sent to post-renderers, Helm 3 behavior),
    /// &apos;combined&apos; (hooks and templates sent together, Helm 4 default), and &apos;separate&apos;
    /// (hooks and templates sent in separate streams, Helm 4.2 opt-in).
    /// Defaults to &apos;combined&apos;, or &apos;nohooks&apos; when the UseHelm3Defaults feature gate is enabled.
    /// </summary>
    [JsonPropertyName("postRenderStrategy")]
    public V2HelmReleaseSpecPostRenderStrategyEnum? PostRenderStrategy { get; set; }

    /// <summary>
    /// PostRenderers holds an array of Helm PostRenderers, which will be applied in order
    /// of their definition.
    /// </summary>
    [JsonPropertyName("postRenderers")]
    public IList<V2HelmReleaseSpecPostRenderers>? PostRenderers { get; set; }

    /// <summary>
    /// ReleaseName used for the Helm release. Defaults to a composition of
    /// &apos;[TargetNamespace-]Name&apos;.
    /// </summary>
    [JsonPropertyName("releaseName")]
    public string? ReleaseName { get; set; }

    /// <summary>Rollback holds the configuration for Helm rollback actions for this HelmRelease.</summary>
    [JsonPropertyName("rollback")]
    public V2HelmReleaseSpecRollback? Rollback { get; set; }

    /// <summary>
    /// The name of the Kubernetes service account to impersonate
    /// when reconciling this HelmRelease.
    /// </summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>
    /// StorageNamespace used for the Helm storage.
    /// Defaults to the namespace of the HelmRelease.
    /// </summary>
    [JsonPropertyName("storageNamespace")]
    public string? StorageNamespace { get; set; }

    /// <summary>
    /// Suspend tells the controller to suspend reconciliation for this HelmRelease,
    /// it does not apply to already started reconciliations. Defaults to false.
    /// </summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>
    /// TargetNamespace to target when performing operations for the HelmRelease.
    /// Defaults to the namespace of the HelmRelease.
    /// </summary>
    [JsonPropertyName("targetNamespace")]
    public string? TargetNamespace { get; set; }

    /// <summary>Test holds the configuration for Helm test actions for this HelmRelease.</summary>
    [JsonPropertyName("test")]
    public V2HelmReleaseSpecTest? Test { get; set; }

    /// <summary>
    /// Timeout is the time to wait for any individual Kubernetes operation (like Jobs
    /// for hooks) during the performance of a Helm action. Defaults to &apos;5m0s&apos;.
    /// </summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>Uninstall holds the configuration for Helm uninstall actions for this HelmRelease.</summary>
    [JsonPropertyName("uninstall")]
    public V2HelmReleaseSpecUninstall? Uninstall { get; set; }

    /// <summary>Upgrade holds the configuration for Helm upgrade actions for this HelmRelease.</summary>
    [JsonPropertyName("upgrade")]
    public V2HelmReleaseSpecUpgrade? Upgrade { get; set; }

    /// <summary>Values holds the values for this Helm release.</summary>
    [JsonPropertyName("values")]
    public JsonNode? Values { get; set; }

    /// <summary>
    /// ValuesFrom holds references to resources containing Helm values for this HelmRelease,
    /// and information about how they should be merged.
    /// </summary>
    [JsonPropertyName("valuesFrom")]
    public IList<V2HelmReleaseSpecValuesFrom>? ValuesFrom { get; set; }

    /// <summary>
    /// WaitStrategy defines Helm&apos;s wait strategy for waiting for applied
    /// resources to become ready.
    /// </summary>
    [JsonPropertyName("waitStrategy")]
    public V2HelmReleaseSpecWaitStrategy? WaitStrategy { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseStatusConditionsStatusEnum>))]
public enum V2HelmReleaseStatusConditionsStatusEnum
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
public partial class V2HelmReleaseStatusConditions
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
    public required V2HelmReleaseStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// TestHookStatus holds the status information for a test hook as observed
/// to be run by the controller.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseStatusHistoryTestHooks
{
    /// <summary>LastCompleted is the time the test hook last completed.</summary>
    [JsonPropertyName("lastCompleted")]
    public DateTime? LastCompleted { get; set; }

    /// <summary>LastStarted is the time the test hook was last started.</summary>
    [JsonPropertyName("lastStarted")]
    public DateTime? LastStarted { get; set; }

    /// <summary>Phase the test hook was observed to be in.</summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }
}

/// <summary>
/// Snapshot captures a point-in-time copy of the status information for a Helm release,
/// as managed by the controller.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseStatusHistory
{
    /// <summary>Action is the action that resulted in this snapshot being created.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>
    /// APIVersion is the API version of the Snapshot.
    /// When the calculation method of the Digest field is changed, this
    /// field will be used to distinguish between the old and new methods.
    /// </summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>AppVersion is the chart app version of the release object in storage.</summary>
    [JsonPropertyName("appVersion")]
    public string? AppVersion { get; set; }

    /// <summary>ChartName is the chart name of the release object in storage.</summary>
    [JsonPropertyName("chartName")]
    public required string ChartName { get; set; }

    /// <summary>
    /// ChartVersion is the chart version of the release object in
    /// storage.
    /// </summary>
    [JsonPropertyName("chartVersion")]
    public required string ChartVersion { get; set; }

    /// <summary>
    /// ConfigDigest is the checksum of the config (better known as
    /// &quot;values&quot;) of the release object in storage.
    /// It has the format of `&lt;algo&gt;:&lt;checksum&gt;`.
    /// </summary>
    [JsonPropertyName("configDigest")]
    public required string ConfigDigest { get; set; }

    /// <summary>Deleted is when the release was deleted.</summary>
    [JsonPropertyName("deleted")]
    public DateTime? Deleted { get; set; }

    /// <summary>
    /// Digest is the checksum of the release object in storage.
    /// It has the format of `&lt;algo&gt;:&lt;checksum&gt;`.
    /// </summary>
    [JsonPropertyName("digest")]
    public required string Digest { get; set; }

    /// <summary>FirstDeployed is when the release was first deployed.</summary>
    [JsonPropertyName("firstDeployed")]
    public required DateTime FirstDeployed { get; set; }

    /// <summary>LastDeployed is when the release was last deployed.</summary>
    [JsonPropertyName("lastDeployed")]
    public required DateTime LastDeployed { get; set; }

    /// <summary>Name is the name of the release.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace is the namespace the release is deployed to.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }

    /// <summary>OCIDigest is the digest of the OCI artifact associated with the release.</summary>
    [JsonPropertyName("ociDigest")]
    public string? OciDigest { get; set; }

    /// <summary>Status is the current state of the release.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// TestHooks is the list of test hooks for the release as observed to be
    /// run by the controller.
    /// </summary>
    [JsonPropertyName("testHooks")]
    public IDictionary<string, V2HelmReleaseStatusHistoryTestHooks>? TestHooks { get; set; }

    /// <summary>Version is the version of the release object in storage.</summary>
    [JsonPropertyName("version")]
    public required int Version { get; set; }
}

/// <summary>ResourceRef contains the information necessary to locate a resource within a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseStatusInventoryEntries
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
/// Inventory contains the list of Kubernetes resource object references
/// that have been applied for this release.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseStatusInventory
{
    /// <summary>Entries of Kubernetes resource object references.</summary>
    [JsonPropertyName("entries")]
    public required IList<V2HelmReleaseStatusInventoryEntries> Entries { get; set; }
}

/// <summary>
/// LastAttemptedReleaseAction is the last release action performed for this
/// HelmRelease. It is used to determine the active retry or remediation
/// strategy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V2HelmReleaseStatusLastAttemptedReleaseActionEnum>))]
public enum V2HelmReleaseStatusLastAttemptedReleaseActionEnum
{
    [EnumMember(Value = "install"), JsonStringEnumMemberName("install")]
    Install,
    [EnumMember(Value = "upgrade"), JsonStringEnumMemberName("upgrade")]
    Upgrade
}

/// <summary>HelmReleaseStatus defines the observed state of a HelmRelease.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V2HelmReleaseStatus
{
    /// <summary>Conditions holds the conditions for the HelmRelease.</summary>
    [JsonPropertyName("conditions")]
    public IList<V2HelmReleaseStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Failures is the reconciliation failure count against the latest desired
    /// state. It is reset after a successful reconciliation.
    /// </summary>
    [JsonPropertyName("failures")]
    public long? Failures { get; set; }

    /// <summary>
    /// HelmChart is the namespaced name of the HelmChart resource created by
    /// the controller for the HelmRelease.
    /// </summary>
    [JsonPropertyName("helmChart")]
    public string? HelmChart { get; set; }

    /// <summary>
    /// History holds the history of Helm releases performed for this HelmRelease
    /// up to the last successfully completed release.
    /// </summary>
    [JsonPropertyName("history")]
    public IList<V2HelmReleaseStatusHistory>? History { get; set; }

    /// <summary>
    /// InstallFailures is the install failure count against the latest desired
    /// state. It is reset after a successful reconciliation.
    /// </summary>
    [JsonPropertyName("installFailures")]
    public long? InstallFailures { get; set; }

    /// <summary>
    /// Inventory contains the list of Kubernetes resource object references
    /// that have been applied for this release.
    /// </summary>
    [JsonPropertyName("inventory")]
    public V2HelmReleaseStatusInventory? Inventory { get; set; }

    /// <summary>
    /// LastAttemptedConfigDigest is the digest for the config (better known as
    /// &quot;values&quot;) of the last reconciliation attempt.
    /// </summary>
    [JsonPropertyName("lastAttemptedConfigDigest")]
    public string? LastAttemptedConfigDigest { get; set; }

    /// <summary>
    /// LastAttemptedGeneration is the last generation the controller attempted
    /// to reconcile.
    /// </summary>
    [JsonPropertyName("lastAttemptedGeneration")]
    public long? LastAttemptedGeneration { get; set; }

    /// <summary>
    /// LastAttemptedReleaseAction is the last release action performed for this
    /// HelmRelease. It is used to determine the active retry or remediation
    /// strategy.
    /// </summary>
    [JsonPropertyName("lastAttemptedReleaseAction")]
    public V2HelmReleaseStatusLastAttemptedReleaseActionEnum? LastAttemptedReleaseAction { get; set; }

    /// <summary>
    /// LastAttemptedReleaseActionDuration is the duration of the last
    /// release action performed for this HelmRelease.
    /// </summary>
    [JsonPropertyName("lastAttemptedReleaseActionDuration")]
    public string? LastAttemptedReleaseActionDuration { get; set; }

    /// <summary>
    /// LastAttemptedRevision is the Source revision of the last reconciliation
    /// attempt. For OCIRepository  sources, the 12 first characters of the digest are
    /// appended to the chart version e.g. &quot;1.2.3+1234567890ab&quot;.
    /// </summary>
    [JsonPropertyName("lastAttemptedRevision")]
    public string? LastAttemptedRevision { get; set; }

    /// <summary>
    /// LastAttemptedRevisionDigest is the digest of the last reconciliation attempt.
    /// This is only set for OCIRepository sources.
    /// </summary>
    [JsonPropertyName("lastAttemptedRevisionDigest")]
    public string? LastAttemptedRevisionDigest { get; set; }

    /// <summary>
    /// LastAttemptedValuesChecksum is the SHA1 checksum for the values of the last
    /// reconciliation attempt.
    /// 
    /// Deprecated: Use LastAttemptedConfigDigest instead.
    /// </summary>
    [JsonPropertyName("lastAttemptedValuesChecksum")]
    public string? LastAttemptedValuesChecksum { get; set; }

    /// <summary>
    /// LastHandledForceAt holds the value of the most recent
    /// force request value, so a change of the annotation value
    /// can be detected.
    /// </summary>
    [JsonPropertyName("lastHandledForceAt")]
    public string? LastHandledForceAt { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile request value, so a change of the annotation value
    /// can be detected.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// LastHandledResetAt holds the value of the most recent reset request
    /// value, so a change of the annotation value can be detected.
    /// </summary>
    [JsonPropertyName("lastHandledResetAt")]
    public string? LastHandledResetAt { get; set; }

    /// <summary>
    /// LastReleaseRevision is the revision of the last successful Helm release.
    /// 
    /// Deprecated: Use History instead.
    /// </summary>
    [JsonPropertyName("lastReleaseRevision")]
    public int? LastReleaseRevision { get; set; }

    /// <summary>
    /// ObservedCommonMetadataDigest is the digest for the common metadata of
    /// the last successful reconciliation attempt.
    /// </summary>
    [JsonPropertyName("observedCommonMetadataDigest")]
    public string? ObservedCommonMetadataDigest { get; set; }

    /// <summary>ObservedGeneration is the last observed generation.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// ObservedPostRenderersDigest is the digest for the post-renderers of
    /// the last successful reconciliation attempt.
    /// </summary>
    [JsonPropertyName("observedPostRenderersDigest")]
    public string? ObservedPostRenderersDigest { get; set; }

    /// <summary>
    /// StorageNamespace is the namespace of the Helm release storage for the
    /// current release.
    /// </summary>
    [JsonPropertyName("storageNamespace")]
    public string? StorageNamespace { get; set; }

    /// <summary>
    /// UpgradeFailures is the upgrade failure count against the latest desired
    /// state. It is reset after a successful reconciliation.
    /// </summary>
    [JsonPropertyName("upgradeFailures")]
    public long? UpgradeFailures { get; set; }
}

/// <summary>HelmRelease is the Schema for the helmreleases API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V2HelmRelease : IKubernetesObject<V1ObjectMeta>, ISpec<V2HelmReleaseSpec?>, IStatus<V2HelmReleaseStatus?>
{
    public const string KubeApiVersion = "v2";
    public const string KubeKind = "HelmRelease";
    public const string KubeGroup = "helm.toolkit.fluxcd.io";
    public const string KubePluralName = "helmreleases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "helm.toolkit.fluxcd.io/v2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HelmRelease";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HelmReleaseSpec defines the desired state of a Helm release.</summary>
    [JsonPropertyName("spec")]
    public V2HelmReleaseSpec? Spec { get; set; }

    /// <summary>HelmReleaseStatus defines the observed state of a HelmRelease.</summary>
    [JsonPropertyName("status")]
    public V2HelmReleaseStatus? Status { get; set; }
}
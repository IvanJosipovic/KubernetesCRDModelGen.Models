#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.source.toolkit.fluxcd.io;
/// <summary>HelmChart is the Schema for the helmcharts API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1HelmChartList : IKubernetesObject<V1ListMeta>, IItems<V1HelmChart>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "HelmChartList";
    public const string KubeGroup = "source.toolkit.fluxcd.io";
    public const string KubePluralName = "helmcharts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "source.toolkit.fluxcd.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HelmChartList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1HelmChart objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1HelmChart> Items { get; set; }
}

/// <summary>
/// ReconcileStrategy determines what enables the creation of a new artifact.
/// Valid values are (&apos;ChartVersion&apos;, &apos;Revision&apos;).
/// See the documentation of the values for an explanation on their behavior.
/// Defaults to ChartVersion when omitted.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1HelmChartSpecReconcileStrategyEnum>))]
public enum V1HelmChartSpecReconcileStrategyEnum
{
    [EnumMember(Value = "ChartVersion"), JsonStringEnumMemberName("ChartVersion")]
    ChartVersion,
    [EnumMember(Value = "Revision"), JsonStringEnumMemberName("Revision")]
    Revision
}

/// <summary>
/// Kind of the referent, valid values are (&apos;HelmRepository&apos;, &apos;GitRepository&apos;,
/// &apos;Bucket&apos;).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1HelmChartSpecSourceRefKindEnum>))]
public enum V1HelmChartSpecSourceRefKindEnum
{
    [EnumMember(Value = "HelmRepository"), JsonStringEnumMemberName("HelmRepository")]
    HelmRepository,
    [EnumMember(Value = "GitRepository"), JsonStringEnumMemberName("GitRepository")]
    GitRepository,
    [EnumMember(Value = "Bucket"), JsonStringEnumMemberName("Bucket")]
    Bucket
}

/// <summary>SourceRef is the reference to the Source the chart is available at.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1HelmChartSpecSourceRef
{
    /// <summary>APIVersion of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>
    /// Kind of the referent, valid values are (&apos;HelmRepository&apos;, &apos;GitRepository&apos;,
    /// &apos;Bucket&apos;).
    /// </summary>
    [JsonPropertyName("kind")]
    public required V1HelmChartSpecSourceRefKindEnum Kind { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// OIDCIdentityMatch specifies options for verifying the certificate identity,
/// i.e. the issuer and the subject of the certificate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1HelmChartSpecVerifyMatchOIDCIdentity
{
    /// <summary>
    /// Issuer specifies the regex pattern to match against to verify
    /// the OIDC issuer in the Fulcio certificate. The pattern must be a
    /// valid Go regular expression.
    /// </summary>
    [JsonPropertyName("issuer")]
    public required string Issuer { get; set; }

    /// <summary>
    /// Subject specifies the regex pattern to match against to verify
    /// the identity subject in the Fulcio certificate. The pattern must
    /// be a valid Go regular expression.
    /// </summary>
    [JsonPropertyName("subject")]
    public required string Subject { get; set; }
}

/// <summary>Provider specifies the technology used to sign the OCI Artifact.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1HelmChartSpecVerifyProviderEnum>))]
public enum V1HelmChartSpecVerifyProviderEnum
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
public partial class V1HelmChartSpecVerifySecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Verify contains the secret name containing the trusted public keys
/// used to verify the signature and specifies which provider to use to check
/// whether OCI image is authentic.
/// This field is only supported when using HelmRepository source with spec.type &apos;oci&apos;.
/// Chart dependencies, which are not bundled in the umbrella chart artifact, are not verified.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1HelmChartSpecVerify
{
    /// <summary>
    /// MatchOIDCIdentity specifies the identity matching criteria to use
    /// while verifying an OCI artifact which was signed using Cosign keyless
    /// signing. The artifact&apos;s identity is deemed to be verified if any of the
    /// specified matchers match against the identity.
    /// </summary>
    [JsonPropertyName("matchOIDCIdentity")]
    public IList<V1HelmChartSpecVerifyMatchOIDCIdentity>? MatchOIDCIdentity { get; set; }

    /// <summary>Provider specifies the technology used to sign the OCI Artifact.</summary>
    [JsonPropertyName("provider")]
    public V1HelmChartSpecVerifyProviderEnum? Provider { get; set; }

    /// <summary>
    /// SecretRef specifies the Kubernetes Secret containing the
    /// trusted public keys.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1HelmChartSpecVerifySecretRef? SecretRef { get; set; }
}

/// <summary>HelmChartSpec specifies the desired state of a Helm chart.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1HelmChartSpec
{
    /// <summary>
    /// Chart is the name or path the Helm chart is available at in the
    /// SourceRef.
    /// </summary>
    [JsonPropertyName("chart")]
    public required string Chart { get; set; }

    /// <summary>
    /// IgnoreMissingValuesFiles controls whether to silently ignore missing values
    /// files rather than failing.
    /// </summary>
    [JsonPropertyName("ignoreMissingValuesFiles")]
    public bool? IgnoreMissingValuesFiles { get; set; }

    /// <summary>
    /// Interval at which the HelmChart SourceRef is checked for updates.
    /// This interval is approximate and may be subject to jitter to ensure
    /// efficient use of resources.
    /// </summary>
    [JsonPropertyName("interval")]
    public required string Interval { get; set; }

    /// <summary>
    /// ReconcileStrategy determines what enables the creation of a new artifact.
    /// Valid values are (&apos;ChartVersion&apos;, &apos;Revision&apos;).
    /// See the documentation of the values for an explanation on their behavior.
    /// Defaults to ChartVersion when omitted.
    /// </summary>
    [JsonPropertyName("reconcileStrategy")]
    public V1HelmChartSpecReconcileStrategyEnum? ReconcileStrategy { get; set; }

    /// <summary>SourceRef is the reference to the Source the chart is available at.</summary>
    [JsonPropertyName("sourceRef")]
    public required V1HelmChartSpecSourceRef SourceRef { get; set; }

    /// <summary>
    /// Suspend tells the controller to suspend the reconciliation of this
    /// source.
    /// </summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>
    /// ValuesFiles is an alternative list of values files to use as the chart
    /// values (values.yaml is not included by default), expected to be a
    /// relative path in the SourceRef.
    /// Values files are merged in the order of this list with the last file
    /// overriding the first. Ignored when omitted.
    /// </summary>
    [JsonPropertyName("valuesFiles")]
    public IList<string>? ValuesFiles { get; set; }

    /// <summary>
    /// Verify contains the secret name containing the trusted public keys
    /// used to verify the signature and specifies which provider to use to check
    /// whether OCI image is authentic.
    /// This field is only supported when using HelmRepository source with spec.type &apos;oci&apos;.
    /// Chart dependencies, which are not bundled in the umbrella chart artifact, are not verified.
    /// </summary>
    [JsonPropertyName("verify")]
    public V1HelmChartSpecVerify? Verify { get; set; }

    /// <summary>
    /// Version is the chart version semver expression, ignored for charts from
    /// GitRepository and Bucket sources. Defaults to latest when omitted.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Artifact represents the output of the last successful reconciliation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1HelmChartStatusArtifact
{
    /// <summary>Digest is the digest of the file in the form of &apos; &lt;algorithm&gt;:&lt;checksum&gt; &apos;.</summary>
    [JsonPropertyName("digest")]
    public required string Digest { get; set; }

    /// <summary>
    /// LastUpdateTime is the timestamp corresponding to the last update of the
    /// Artifact.
    /// </summary>
    [JsonPropertyName("lastUpdateTime")]
    public required DateTime LastUpdateTime { get; set; }

    /// <summary>Metadata holds upstream information such as OCI annotations.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// Path is the relative file path of the Artifact. It can be used to locate
    /// the file in the root of the Artifact storage on the local file system of
    /// the controller managing the Source.
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }

    /// <summary>
    /// Revision is a human-readable identifier traceable in the origin source
    /// system. It can be a Git commit SHA, Git tag, a Helm chart version, etc.
    /// </summary>
    [JsonPropertyName("revision")]
    public required string Revision { get; set; }

    /// <summary>Size is the number of bytes in the file.</summary>
    [JsonPropertyName("size")]
    public long? Size { get; set; }

    /// <summary>
    /// URL is the HTTP address of the Artifact as exposed by the controller
    /// managing the Source. It can be used to retrieve the Artifact for
    /// consumption, e.g. by another controller applying the Artifact contents.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1HelmChartStatusConditionsStatusEnum>))]
public enum V1HelmChartStatusConditionsStatusEnum
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
public partial class V1HelmChartStatusConditions
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
    public required V1HelmChartStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>HelmChartStatus records the observed state of the HelmChart.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1HelmChartStatus
{
    /// <summary>Artifact represents the output of the last successful reconciliation.</summary>
    [JsonPropertyName("artifact")]
    public V1HelmChartStatusArtifact? Artifact { get; set; }

    /// <summary>Conditions holds the conditions for the HelmChart.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1HelmChartStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile request value, so a change of the annotation value
    /// can be detected.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedChartName is the last observed chart name as specified by the
    /// resolved chart reference.
    /// </summary>
    [JsonPropertyName("observedChartName")]
    public string? ObservedChartName { get; set; }

    /// <summary>
    /// ObservedGeneration is the last observed generation of the HelmChart
    /// object.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// ObservedSourceArtifactRevision is the last observed Artifact.Revision
    /// of the HelmChartSpec.SourceRef.
    /// </summary>
    [JsonPropertyName("observedSourceArtifactRevision")]
    public string? ObservedSourceArtifactRevision { get; set; }

    /// <summary>
    /// ObservedValuesFiles are the observed value files of the last successful
    /// reconciliation.
    /// It matches the chart in the last successfully reconciled artifact.
    /// </summary>
    [JsonPropertyName("observedValuesFiles")]
    public IList<string>? ObservedValuesFiles { get; set; }

    /// <summary>
    /// URL is the dynamic fetch link for the latest Artifact.
    /// It is provided on a &quot;best effort&quot; basis, and using the precise
    /// BucketStatus.Artifact data is recommended.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>HelmChart is the Schema for the helmcharts API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1HelmChart : IKubernetesObject<V1ObjectMeta>, ISpec<V1HelmChartSpec?>, IStatus<V1HelmChartStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "HelmChart";
    public const string KubeGroup = "source.toolkit.fluxcd.io";
    public const string KubePluralName = "helmcharts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "source.toolkit.fluxcd.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HelmChart";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HelmChartSpec specifies the desired state of a Helm chart.</summary>
    [JsonPropertyName("spec")]
    public V1HelmChartSpec? Spec { get; set; }

    /// <summary>HelmChartStatus records the observed state of the HelmChart.</summary>
    [JsonPropertyName("status")]
    public V1HelmChartStatus? Status { get; set; }
}
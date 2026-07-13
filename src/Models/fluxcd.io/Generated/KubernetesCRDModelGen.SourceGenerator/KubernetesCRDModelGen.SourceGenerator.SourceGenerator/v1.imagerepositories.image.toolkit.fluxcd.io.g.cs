#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.image.toolkit.fluxcd.io;
/// <summary>ImageRepository is the Schema for the imagerepositories API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ImageRepositoryList : IKubernetesObject<V1ListMeta>, IItems<V1ImageRepository>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ImageRepositoryList";
    public const string KubeGroup = "image.toolkit.fluxcd.io";
    public const string KubePluralName = "imagerepositories";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "image.toolkit.fluxcd.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ImageRepositoryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1ImageRepository objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1ImageRepository> Items { get; set; }
}

/// <summary>
/// NamespaceSelector selects the namespaces to which this ACL applies.
/// An empty map of MatchLabels matches all namespaces in a cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageRepositorySpecAccessFromNamespaceSelectors
{
    /// <summary>
    /// MatchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// AccessFrom defines an ACL for allowing cross-namespace references
/// to the ImageRepository object based on the caller&apos;s namespace labels.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageRepositorySpecAccessFrom
{
    /// <summary>
    /// NamespaceSelectors is the list of namespace selectors to which this ACL applies.
    /// Items in this list are evaluated using a logical OR operation.
    /// </summary>
    [JsonPropertyName("namespaceSelectors")]
    public required IList<V1ImageRepositorySpecAccessFromNamespaceSelectors> NamespaceSelectors { get; set; }
}

/// <summary>
/// CertSecretRef can be given the name of a Secret containing
/// either or both of
/// 
/// - a PEM-encoded client certificate (`tls.crt`) and private
/// key (`tls.key`);
/// - a PEM-encoded CA certificate (`ca.crt`)
/// 
/// and whichever are supplied, will be used for connecting to the
/// registry. The client cert and key are useful if you are
/// authenticating with a certificate; the CA cert is useful if
/// you are using a self-signed server certificate. The Secret must
/// be of type `Opaque` or `kubernetes.io/tls`.
/// 
/// Note: Support for the `caFile`, `certFile` and `keyFile` keys has
/// been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageRepositorySpecCertSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// The provider used for authentication, can be &apos;aws&apos;, &apos;azure&apos;, &apos;gcp&apos; or &apos;generic&apos;.
/// When not specified, defaults to &apos;generic&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ImageRepositorySpecProviderEnum>))]
public enum V1ImageRepositorySpecProviderEnum
{
    [EnumMember(Value = "generic"), JsonStringEnumMemberName("generic")]
    Generic,
    [EnumMember(Value = "aws"), JsonStringEnumMemberName("aws")]
    Aws,
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "gcp"), JsonStringEnumMemberName("gcp")]
    Gcp
}

/// <summary>
/// ProxySecretRef specifies the Secret containing the proxy configuration
/// to use while communicating with the container registry.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageRepositorySpecProxySecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecretRef can be given the name of a secret containing
/// credentials to use for the image registry. The secret should be
/// created with `kubectl create secret docker-registry`, or the
/// equivalent.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageRepositorySpecSecretRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ImageRepositorySpec defines the parameters for scanning an image
/// repository, e.g., `fluxcd/flux`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageRepositorySpec
{
    /// <summary>
    /// AccessFrom defines an ACL for allowing cross-namespace references
    /// to the ImageRepository object based on the caller&apos;s namespace labels.
    /// </summary>
    [JsonPropertyName("accessFrom")]
    public V1ImageRepositorySpecAccessFrom? AccessFrom { get; set; }

    /// <summary>
    /// CertSecretRef can be given the name of a Secret containing
    /// either or both of
    /// 
    /// - a PEM-encoded client certificate (`tls.crt`) and private
    /// key (`tls.key`);
    /// - a PEM-encoded CA certificate (`ca.crt`)
    /// 
    /// and whichever are supplied, will be used for connecting to the
    /// registry. The client cert and key are useful if you are
    /// authenticating with a certificate; the CA cert is useful if
    /// you are using a self-signed server certificate. The Secret must
    /// be of type `Opaque` or `kubernetes.io/tls`.
    /// 
    /// Note: Support for the `caFile`, `certFile` and `keyFile` keys has
    /// been deprecated.
    /// </summary>
    [JsonPropertyName("certSecretRef")]
    public V1ImageRepositorySpecCertSecretRef? CertSecretRef { get; set; }

    /// <summary>
    /// ExclusionList is a list of regex strings used to exclude certain tags
    /// from being stored in the database.
    /// </summary>
    [JsonPropertyName("exclusionList")]
    public IList<string>? ExclusionList { get; set; }

    /// <summary>Image is the name of the image repository</summary>
    [JsonPropertyName("image")]
    public required string Image { get; set; }

    /// <summary>Insecure allows connecting to a non-TLS HTTP container registry.</summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary>
    /// Interval is the length of time to wait between
    /// scans of the image repository.
    /// </summary>
    [JsonPropertyName("interval")]
    public required string Interval { get; set; }

    /// <summary>
    /// The provider used for authentication, can be &apos;aws&apos;, &apos;azure&apos;, &apos;gcp&apos; or &apos;generic&apos;.
    /// When not specified, defaults to &apos;generic&apos;.
    /// </summary>
    [JsonPropertyName("provider")]
    public V1ImageRepositorySpecProviderEnum? Provider { get; set; }

    /// <summary>
    /// ProxySecretRef specifies the Secret containing the proxy configuration
    /// to use while communicating with the container registry.
    /// </summary>
    [JsonPropertyName("proxySecretRef")]
    public V1ImageRepositorySpecProxySecretRef? ProxySecretRef { get; set; }

    /// <summary>
    /// SecretRef can be given the name of a secret containing
    /// credentials to use for the image registry. The secret should be
    /// created with `kubectl create secret docker-registry`, or the
    /// equivalent.
    /// </summary>
    [JsonPropertyName("secretRef")]
    public V1ImageRepositorySpecSecretRef? SecretRef { get; set; }

    /// <summary>
    /// ServiceAccountName is the name of the Kubernetes ServiceAccount used to authenticate
    /// the image pull if the service account has attached pull secrets.
    /// </summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>
    /// This flag tells the controller to suspend subsequent image scans.
    /// It does not apply to already started scans. Defaults to false.
    /// </summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>
    /// Timeout for image scanning.
    /// Defaults to &apos;Interval&apos; duration.
    /// </summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ImageRepositoryStatusConditionsStatusEnum>))]
public enum V1ImageRepositoryStatusConditionsStatusEnum
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
public partial class V1ImageRepositoryStatusConditions
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
    public required V1ImageRepositoryStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>LastScanResult contains the number of fetched tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageRepositoryStatusLastScanResult
{
    /// <summary>
    /// LatestTags is a small sample of the tags found in the last scan.
    /// It&apos;s the first 10 tags when sorting all the tags in descending
    /// alphabetical order.
    /// </summary>
    [JsonPropertyName("latestTags")]
    public IList<string>? LatestTags { get; set; }

    /// <summary>Revision is a stable hash of the scanned tags.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>ScanTime is the time when the last scan was performed.</summary>
    [JsonPropertyName("scanTime")]
    public DateTime? ScanTime { get; set; }

    /// <summary>TagCount is the number of tags found in the last scan.</summary>
    [JsonPropertyName("tagCount")]
    public required int TagCount { get; set; }
}

/// <summary>ImageRepositoryStatus defines the observed state of ImageRepository</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImageRepositoryStatus
{
    /// <summary>
    /// CanonicalName is the name of the image repository with all the
    /// implied bits made explicit; e.g., `docker.io/library/alpine`
    /// rather than `alpine`.
    /// </summary>
    [JsonPropertyName("canonicalImageName")]
    public string? CanonicalImageName { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1ImageRepositoryStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile request value, so a change of the annotation value
    /// can be detected.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>LastScanResult contains the number of fetched tags.</summary>
    [JsonPropertyName("lastScanResult")]
    public V1ImageRepositoryStatusLastScanResult? LastScanResult { get; set; }

    /// <summary>
    /// ObservedExclusionList is a list of observed exclusion list. It reflects
    /// the exclusion rules used for the observed scan result in
    /// spec.lastScanResult.
    /// </summary>
    [JsonPropertyName("observedExclusionList")]
    public IList<string>? ObservedExclusionList { get; set; }

    /// <summary>ObservedGeneration is the last reconciled generation.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ImageRepository is the Schema for the imagerepositories API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ImageRepository : IKubernetesObject<V1ObjectMeta>, ISpec<V1ImageRepositorySpec?>, IStatus<V1ImageRepositoryStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ImageRepository";
    public const string KubeGroup = "image.toolkit.fluxcd.io";
    public const string KubePluralName = "imagerepositories";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "image.toolkit.fluxcd.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ImageRepository";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ImageRepositorySpec defines the parameters for scanning an image
    /// repository, e.g., `fluxcd/flux`.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1ImageRepositorySpec? Spec { get; set; }

    /// <summary>ImageRepositoryStatus defines the observed state of ImageRepository</summary>
    [JsonPropertyName("status")]
    public V1ImageRepositoryStatus? Status { get; set; }
}
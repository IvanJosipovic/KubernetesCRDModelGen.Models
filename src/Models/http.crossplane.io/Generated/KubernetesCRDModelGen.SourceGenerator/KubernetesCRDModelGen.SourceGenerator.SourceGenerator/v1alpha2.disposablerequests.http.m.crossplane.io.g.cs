#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.http.m.crossplane.io;
/// <summary>A DisposableRequest is a namespaced HTTP disposable request resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha2DisposableRequestList : IKubernetesObject<V1ListMeta>, IItems<V1alpha2DisposableRequest>
{
    public const string KubeApiVersion = "v1alpha2";
    public const string KubeKind = "DisposableRequestList";
    public const string KubeGroup = "http.m.crossplane.io";
    public const string KubePluralName = "disposablerequests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "http.m.crossplane.io/v1alpha2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DisposableRequestList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha2DisposableRequest objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha2DisposableRequest> Items { get; set; }
}

/// <summary>
/// MissingFieldStrategy determines how to handle cases where the field is missing from the response.
/// Possible values are:
/// - &quot;preserve&quot;: keeps the existing value in the secret
/// - &quot;setEmpty&quot;: sets the value to the empty string
/// - &quot;delete&quot;: removes the key from the s
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2DisposableRequestSpecForProviderSecretInjectionConfigsKeyMappingsMissingFieldStrategyEnum>))]
public enum V1alpha2DisposableRequestSpecForProviderSecretInjectionConfigsKeyMappingsMissingFieldStrategyEnum
{
    [EnumMember(Value = "preserve"), JsonStringEnumMemberName("preserve")]
    Preserve,
    [EnumMember(Value = "setEmpty"), JsonStringEnumMemberName("setEmpty")]
    SetEmpty,
    [EnumMember(Value = "delete"), JsonStringEnumMemberName("delete")]
    Delete
}

/// <summary>KeyInjection represents the configuration for injecting data into a specific key in a Kubernetes secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2DisposableRequestSpecForProviderSecretInjectionConfigsKeyMappings
{
    /// <summary>
    /// MissingFieldStrategy determines how to handle cases where the field is missing from the response.
    /// Possible values are:
    /// - &quot;preserve&quot;: keeps the existing value in the secret
    /// - &quot;setEmpty&quot;: sets the value to the empty string
    /// - &quot;delete&quot;: removes the key from the s
    /// </summary>
    [JsonPropertyName("missingFieldStrategy")]
    public V1alpha2DisposableRequestSpecForProviderSecretInjectionConfigsKeyMappingsMissingFieldStrategyEnum? MissingFieldStrategy { get; set; }

    /// <summary>ResponseJQ is a jq filter expression representing the path in the response where the secret value will be extracted from.</summary>
    [JsonPropertyName("responseJQ")]
    public required string ResponseJQ { get; set; }

    /// <summary>SecretKey is the key within the Kubernetes secret where the data will be injected.</summary>
    [JsonPropertyName("secretKey")]
    public required string SecretKey { get; set; }
}

/// <summary>Metadata contains labels and annotations to apply to the Kubernetes secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2DisposableRequestSpecForProviderSecretInjectionConfigsMetadata
{
    /// <summary>Annotations contains key-value pairs to apply as annotations to the Kubernetes secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels contains key-value pairs to apply as labels to the Kubernetes secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>SecretRef contains the name and namespace of the Kubernetes secret where the data will be injected.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2DisposableRequestSpecForProviderSecretInjectionConfigsSecretRef
{
    /// <summary>Name is the name of the Kubernetes secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace is the namespace of the Kubernetes secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SecretInjectionConfig represents the configuration for injecting secret data into a Kubernetes secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2DisposableRequestSpecForProviderSecretInjectionConfigs
{
    /// <summary>KeyMappings allows injecting data into single or multiple keys within the same Kubernetes secret.</summary>
    [JsonPropertyName("keyMappings")]
    public IList<V1alpha2DisposableRequestSpecForProviderSecretInjectionConfigsKeyMappings>? KeyMappings { get; set; }

    /// <summary>Metadata contains labels and annotations to apply to the Kubernetes secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha2DisposableRequestSpecForProviderSecretInjectionConfigsMetadata? Metadata { get; set; }

    /// <summary>
    /// ResponsePath is a jq filter expression representing the path in the response where the secret value will be extracted from.
    /// Deprecated: Use KeyMappings for injecting single or multiple keys.
    /// </summary>
    [JsonPropertyName("responsePath")]
    public string? ResponsePath { get; set; }

    /// <summary>
    /// SecretKey is the key within the Kubernetes secret where the data will be injected.
    /// Deprecated: Use KeyMappings for injecting single or multiple keys.
    /// </summary>
    [JsonPropertyName("secretKey")]
    public string? SecretKey { get; set; }

    /// <summary>SecretRef contains the name and namespace of the Kubernetes secret where the data will be injected.</summary>
    [JsonPropertyName("secretRef")]
    public required V1alpha2DisposableRequestSpecForProviderSecretInjectionConfigsSecretRef SecretRef { get; set; }

    /// <summary>SetOwnerReference determines whether to set the owner reference on the Kubernetes secret.</summary>
    [JsonPropertyName("setOwnerReference")]
    public bool? SetOwnerReference { get; set; }
}

/// <summary>
/// CACertSecretRef is a reference to a secret containing the CA certificate(s).
/// The secret must contain a key specified in the SecretKeySelector.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2DisposableRequestSpecForProviderTlsConfigCaCertSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// ClientCertSecretRef is a reference to a secret containing the client certificate.
/// The secret must contain a key specified in the SecretKeySelector.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2DisposableRequestSpecForProviderTlsConfigClientCertSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// ClientKeySecretRef is a reference to a secret containing the client private key.
/// The secret must contain a key specified in the SecretKeySelector.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2DisposableRequestSpecForProviderTlsConfigClientKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// TLSConfig allows overriding the TLS configuration from ProviderConfig for this specific request.
/// This field is mutually exclusive with InsecureSkipTLSVerify.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2DisposableRequestSpecForProviderTlsConfig
{
    /// <summary>
    /// CABundle is a PEM encoded CA bundle which will be used to validate the server certificate.
    /// If empty, system root CAs will be used.
    /// </summary>
    [JsonPropertyName("caBundle")]
    public byte[]? CaBundle { get; set; }

    /// <summary>
    /// CACertSecretRef is a reference to a secret containing the CA certificate(s).
    /// The secret must contain a key specified in the SecretKeySelector.
    /// </summary>
    [JsonPropertyName("caCertSecretRef")]
    public V1alpha2DisposableRequestSpecForProviderTlsConfigCaCertSecretRef? CaCertSecretRef { get; set; }

    /// <summary>
    /// ClientCertSecretRef is a reference to a secret containing the client certificate.
    /// The secret must contain a key specified in the SecretKeySelector.
    /// </summary>
    [JsonPropertyName("clientCertSecretRef")]
    public V1alpha2DisposableRequestSpecForProviderTlsConfigClientCertSecretRef? ClientCertSecretRef { get; set; }

    /// <summary>
    /// ClientKeySecretRef is a reference to a secret containing the client private key.
    /// The secret must contain a key specified in the SecretKeySelector.
    /// </summary>
    [JsonPropertyName("clientKeySecretRef")]
    public V1alpha2DisposableRequestSpecForProviderTlsConfigClientKeySecretRef? ClientKeySecretRef { get; set; }

    /// <summary>
    /// InsecureSkipVerify controls whether the client verifies the server&apos;s certificate chain and host name.
    /// If true, any certificate presented by the server and any host name in that certificate is accepted.
    /// </summary>
    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }
}

/// <summary>DisposableRequestParameters are the configurable fields of a DisposableRequest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2DisposableRequestSpecForProvider
{
    /// <summary>
    /// AllowedStatusCodes specifies HTTP status codes that should not be treated as errors.
    /// By default, status codes 400-599 are considered errors. This field allows users to
    /// override that behavior for specific status codes (e.g., treating 404 as valid).
    /// </summary>
    [JsonPropertyName("allowedStatusCodes")]
    public IList<int>? AllowedStatusCodes { get; set; }

    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>
    /// ExpectedResponse is a jq filter expression used to evaluate the HTTP response and determine if it matches the expected criteria.
    /// The expression should return a boolean; if true, the response is considered expected.
    /// Example: &apos;.body.job_status == &quot;success&quot; &apos;
    /// </summary>
    [JsonPropertyName("expectedResponse")]
    public string? ExpectedResponse { get; set; }

    [JsonPropertyName("headers")]
    public IDictionary<string, IList<string>>? Headers { get; set; }

    /// <summary>
    /// InsecureSkipTLSVerify, when set to true, skips TLS certificate checks for the HTTP request.
    /// This field is mutually exclusive with TLSConfig.
    /// </summary>
    [JsonPropertyName("insecureSkipTLSVerify")]
    public bool? InsecureSkipTLSVerify { get; set; }

    [JsonPropertyName("method")]
    public required string Method { get; set; }

    /// <summary>NextReconcile specifies the duration after which the next reconcile should occur.</summary>
    [JsonPropertyName("nextReconcile")]
    public string? NextReconcile { get; set; }

    /// <summary>RollbackRetriesLimit is max number of attempts to retry HTTP request by sending again the request.</summary>
    [JsonPropertyName("rollbackRetriesLimit")]
    public int? RollbackRetriesLimit { get; set; }

    /// <summary>SecretInjectionConfig specifies the secrets receiving patches from response data.</summary>
    [JsonPropertyName("secretInjectionConfigs")]
    public IList<V1alpha2DisposableRequestSpecForProviderSecretInjectionConfigs>? SecretInjectionConfigs { get; set; }

    /// <summary>ShouldLoopInfinitely specifies whether the reconciliation should loop indefinitely.</summary>
    [JsonPropertyName("shouldLoopInfinitely")]
    public bool? ShouldLoopInfinitely { get; set; }

    /// <summary>
    /// TLSConfig allows overriding the TLS configuration from ProviderConfig for this specific request.
    /// This field is mutually exclusive with InsecureSkipTLSVerify.
    /// </summary>
    [JsonPropertyName("tlsConfig")]
    public V1alpha2DisposableRequestSpecForProviderTlsConfig? TlsConfig { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>WaitTimeout specifies the maximum time duration for waiting.</summary>
    [JsonPropertyName("waitTimeout")]
    public string? WaitTimeout { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2DisposableRequestSpecManagementPoliciesEnum>))]
public enum V1alpha2DisposableRequestSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2DisposableRequestSpecProviderConfigRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2DisposableRequestSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>A DisposableRequestSpec defines the desired state of a DisposableRequest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2DisposableRequestSpec
{
    /// <summary>DisposableRequestParameters are the configurable fields of a DisposableRequest.</summary>
    [JsonPropertyName("forProvider")]
    public required V1alpha2DisposableRequestSpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha2DisposableRequestSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha2DisposableRequestSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha2DisposableRequestSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2DisposableRequestStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2DisposableRequestStatusRequestDetails
{
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    [JsonPropertyName("headers")]
    public IDictionary<string, IList<string>>? Headers { get; set; }

    [JsonPropertyName("method")]
    public required string Method { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2DisposableRequestStatusResponse
{
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    [JsonPropertyName("headers")]
    public IDictionary<string, IList<string>>? Headers { get; set; }

    [JsonPropertyName("statusCode")]
    public int? StatusCode { get; set; }
}

/// <summary>A DisposableRequestStatus represents the observed state of a DisposableRequest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2DisposableRequestStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha2DisposableRequestStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("failed")]
    public int? Failed { get; set; }

    /// <summary>LastReconcileTime records the last time the resource was reconciled.</summary>
    [JsonPropertyName("lastReconcileTime")]
    public DateTime? LastReconcileTime { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    [JsonPropertyName("requestDetails")]
    public V1alpha2DisposableRequestStatusRequestDetails? RequestDetails { get; set; }

    [JsonPropertyName("response")]
    public V1alpha2DisposableRequestStatusResponse? Response { get; set; }

    [JsonPropertyName("synced")]
    public bool? Synced { get; set; }
}

/// <summary>A DisposableRequest is a namespaced HTTP disposable request resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha2DisposableRequest : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha2DisposableRequestSpec>, IStatus<V1alpha2DisposableRequestStatus?>
{
    public const string KubeApiVersion = "v1alpha2";
    public const string KubeKind = "DisposableRequest";
    public const string KubeGroup = "http.m.crossplane.io";
    public const string KubePluralName = "disposablerequests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "http.m.crossplane.io/v1alpha2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DisposableRequest";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>A DisposableRequestSpec defines the desired state of a DisposableRequest.</summary>
    [JsonPropertyName("spec")]
    public required V1alpha2DisposableRequestSpec Spec { get; set; }

    /// <summary>A DisposableRequestStatus represents the observed state of a DisposableRequest.</summary>
    [JsonPropertyName("status")]
    public V1alpha2DisposableRequestStatus? Status { get; set; }
}
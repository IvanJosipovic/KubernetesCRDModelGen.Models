#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.http.crossplane.io;
/// <summary>A Request is an example API type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha2RequestList : IKubernetesObject<V1ListMeta>, IItems<V1alpha2Request>
{
    public const string KubeApiVersion = "v1alpha2";
    public const string KubeKind = "RequestList";
    public const string KubeGroup = "http.crossplane.io";
    public const string KubePluralName = "requests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "http.crossplane.io/v1alpha2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RequestList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha2Request objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha2Request> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2RequestSpecDeletionPolicyEnum>))]
public enum V1alpha2RequestSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Type specifies the type of the expected response check.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2RequestSpecForProviderExpectedResponseCheckTypeEnum>))]
public enum V1alpha2RequestSpecForProviderExpectedResponseCheckTypeEnum
{
    [EnumMember(Value = "DEFAULT"), JsonStringEnumMemberName("DEFAULT")]
    DEFAULT,
    [EnumMember(Value = "CUSTOM"), JsonStringEnumMemberName("CUSTOM")]
    CUSTOM
}

/// <summary>ExpectedResponseCheck specifies the mechanism to validate the OBSERVE response against expected value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestSpecForProviderExpectedResponseCheck
{
    /// <summary>Logic specifies the custom logic for the expected response check.</summary>
    [JsonPropertyName("logic")]
    public string? Logic { get; set; }

    /// <summary>Type specifies the type of the expected response check.</summary>
    [JsonPropertyName("type")]
    public V1alpha2RequestSpecForProviderExpectedResponseCheckTypeEnum? Type { get; set; }
}

/// <summary>Type specifies the type of the expected response check.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2RequestSpecForProviderIsRemovedCheckTypeEnum>))]
public enum V1alpha2RequestSpecForProviderIsRemovedCheckTypeEnum
{
    [EnumMember(Value = "DEFAULT"), JsonStringEnumMemberName("DEFAULT")]
    DEFAULT,
    [EnumMember(Value = "CUSTOM"), JsonStringEnumMemberName("CUSTOM")]
    CUSTOM
}

/// <summary>IsRemovedCheck specifies the mechanism to validate the OBSERVE response after removal against expected value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestSpecForProviderIsRemovedCheck
{
    /// <summary>Logic specifies the custom logic for the expected response check.</summary>
    [JsonPropertyName("logic")]
    public string? Logic { get; set; }

    /// <summary>Type specifies the type of the expected response check.</summary>
    [JsonPropertyName("type")]
    public V1alpha2RequestSpecForProviderIsRemovedCheckTypeEnum? Type { get; set; }
}

/// <summary>Action specifies the intended action for the request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2RequestSpecForProviderMappingsActionEnum>))]
public enum V1alpha2RequestSpecForProviderMappingsActionEnum
{
    [EnumMember(Value = "CREATE"), JsonStringEnumMemberName("CREATE")]
    CREATE,
    [EnumMember(Value = "OBSERVE"), JsonStringEnumMemberName("OBSERVE")]
    OBSERVE,
    [EnumMember(Value = "UPDATE"), JsonStringEnumMemberName("UPDATE")]
    UPDATE,
    [EnumMember(Value = "REMOVE"), JsonStringEnumMemberName("REMOVE")]
    REMOVE
}

/// <summary>Method specifies the HTTP method for the request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2RequestSpecForProviderMappingsMethodEnum>))]
public enum V1alpha2RequestSpecForProviderMappingsMethodEnum
{
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST,
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "PUT"), JsonStringEnumMemberName("PUT")]
    PUT,
    [EnumMember(Value = "DELETE"), JsonStringEnumMemberName("DELETE")]
    DELETE,
    [EnumMember(Value = "PATCH"), JsonStringEnumMemberName("PATCH")]
    PATCH,
    [EnumMember(Value = "HEAD"), JsonStringEnumMemberName("HEAD")]
    HEAD,
    [EnumMember(Value = "OPTIONS"), JsonStringEnumMemberName("OPTIONS")]
    OPTIONS
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestSpecForProviderMappings
{
    /// <summary>Action specifies the intended action for the request.</summary>
    [JsonPropertyName("action")]
    public V1alpha2RequestSpecForProviderMappingsActionEnum? Action { get; set; }

    /// <summary>Body specifies the body of the request.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Headers specifies the headers for the request.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, IList<string>>? Headers { get; set; }

    /// <summary>Method specifies the HTTP method for the request.</summary>
    [JsonPropertyName("method")]
    public V1alpha2RequestSpecForProviderMappingsMethodEnum? Method { get; set; }

    /// <summary>URL specifies the URL for the request.</summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>Payload defines the payload for the request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestSpecForProviderPayload
{
    /// <summary>BaseUrl specifies the base URL for the request.</summary>
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    /// <summary>Body specifies data to be used in the request body.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }
}

/// <summary>
/// MissingFieldStrategy determines how to handle cases where the field is missing from the response.
/// Possible values are:
/// - &quot;preserve&quot;: keeps the existing value in the secret
/// - &quot;setEmpty&quot;: sets the value to the empty string
/// - &quot;delete&quot;: removes the key from the s
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2RequestSpecForProviderSecretInjectionConfigsKeyMappingsMissingFieldStrategyEnum>))]
public enum V1alpha2RequestSpecForProviderSecretInjectionConfigsKeyMappingsMissingFieldStrategyEnum
{
    [EnumMember(Value = "preserve"), JsonStringEnumMemberName("preserve")]
    Preserve,
    [EnumMember(Value = "setEmpty"), JsonStringEnumMemberName("setEmpty")]
    SetEmpty,
    [EnumMember(Value = "delete"), JsonStringEnumMemberName("delete")]
    Delete
}

/// <summary>KeyInjection represents the configuration for injecting data into a specific key in a Kubernetes secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestSpecForProviderSecretInjectionConfigsKeyMappings
{
    /// <summary>
    /// MissingFieldStrategy determines how to handle cases where the field is missing from the response.
    /// Possible values are:
    /// - &quot;preserve&quot;: keeps the existing value in the secret
    /// - &quot;setEmpty&quot;: sets the value to the empty string
    /// - &quot;delete&quot;: removes the key from the s
    /// </summary>
    [JsonPropertyName("missingFieldStrategy")]
    public V1alpha2RequestSpecForProviderSecretInjectionConfigsKeyMappingsMissingFieldStrategyEnum? MissingFieldStrategy { get; set; }

    /// <summary>ResponseJQ is a jq filter expression representing the path in the response where the secret value will be extracted from.</summary>
    [JsonPropertyName("responseJQ")]
    public required string ResponseJQ { get; set; }

    /// <summary>SecretKey is the key within the Kubernetes secret where the data will be injected.</summary>
    [JsonPropertyName("secretKey")]
    public required string SecretKey { get; set; }
}

/// <summary>Metadata contains labels and annotations to apply to the Kubernetes secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestSpecForProviderSecretInjectionConfigsMetadata
{
    /// <summary>Annotations contains key-value pairs to apply as annotations to the Kubernetes secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels contains key-value pairs to apply as labels to the Kubernetes secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>SecretRef contains the name and namespace of the Kubernetes secret where the data will be injected.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestSpecForProviderSecretInjectionConfigsSecretRef
{
    /// <summary>Name is the name of the Kubernetes secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace is the namespace of the Kubernetes secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SecretInjectionConfig represents the configuration for injecting secret data into a Kubernetes secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestSpecForProviderSecretInjectionConfigs
{
    /// <summary>KeyMappings allows injecting data into single or multiple keys within the same Kubernetes secret.</summary>
    [JsonPropertyName("keyMappings")]
    public IList<V1alpha2RequestSpecForProviderSecretInjectionConfigsKeyMappings>? KeyMappings { get; set; }

    /// <summary>Metadata contains labels and annotations to apply to the Kubernetes secret.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha2RequestSpecForProviderSecretInjectionConfigsMetadata? Metadata { get; set; }

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
    public required V1alpha2RequestSpecForProviderSecretInjectionConfigsSecretRef SecretRef { get; set; }

    /// <summary>SetOwnerReference determines whether to set the owner reference on the Kubernetes secret.</summary>
    [JsonPropertyName("setOwnerReference")]
    public bool? SetOwnerReference { get; set; }
}

/// <summary>
/// CACertSecretRef is a reference to a secret containing the CA certificate(s).
/// The secret must contain a key specified in the SecretKeySelector.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestSpecForProviderTlsConfigCaCertSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestSpecForProviderTlsConfigClientCertSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestSpecForProviderTlsConfigClientKeySecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestSpecForProviderTlsConfig
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
    public V1alpha2RequestSpecForProviderTlsConfigCaCertSecretRef? CaCertSecretRef { get; set; }

    /// <summary>
    /// ClientCertSecretRef is a reference to a secret containing the client certificate.
    /// The secret must contain a key specified in the SecretKeySelector.
    /// </summary>
    [JsonPropertyName("clientCertSecretRef")]
    public V1alpha2RequestSpecForProviderTlsConfigClientCertSecretRef? ClientCertSecretRef { get; set; }

    /// <summary>
    /// ClientKeySecretRef is a reference to a secret containing the client private key.
    /// The secret must contain a key specified in the SecretKeySelector.
    /// </summary>
    [JsonPropertyName("clientKeySecretRef")]
    public V1alpha2RequestSpecForProviderTlsConfigClientKeySecretRef? ClientKeySecretRef { get; set; }

    /// <summary>
    /// InsecureSkipVerify controls whether the client verifies the server&apos;s certificate chain and host name.
    /// If true, any certificate presented by the server and any host name in that certificate is accepted.
    /// </summary>
    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }
}

/// <summary>RequestParameters are the configurable fields of a Request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestSpecForProvider
{
    /// <summary>
    /// AllowedStatusCodes specifies HTTP status codes that should not be treated as errors.
    /// By default, status codes 400-599 are considered errors. This field allows users to
    /// override that behavior for specific status codes (e.g., treating 404 as valid).
    /// </summary>
    [JsonPropertyName("allowedStatusCodes")]
    public IList<int>? AllowedStatusCodes { get; set; }

    /// <summary>ExpectedResponseCheck specifies the mechanism to validate the OBSERVE response against expected value.</summary>
    [JsonPropertyName("expectedResponseCheck")]
    public V1alpha2RequestSpecForProviderExpectedResponseCheck? ExpectedResponseCheck { get; set; }

    /// <summary>Headers defines default headers for each request.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, IList<string>>? Headers { get; set; }

    /// <summary>
    /// InsecureSkipTLSVerify, when set to true, skips TLS certificate checks for the HTTP request.
    /// This field is mutually exclusive with TLSConfig.
    /// </summary>
    [JsonPropertyName("insecureSkipTLSVerify")]
    public bool? InsecureSkipTLSVerify { get; set; }

    /// <summary>IsRemovedCheck specifies the mechanism to validate the OBSERVE response after removal against expected value.</summary>
    [JsonPropertyName("isRemovedCheck")]
    public V1alpha2RequestSpecForProviderIsRemovedCheck? IsRemovedCheck { get; set; }

    /// <summary>
    /// Mappings defines the HTTP mappings for different methods.
    /// Either Method or Action must be specified. If both are omitted, the mapping will not be used.
    /// </summary>
    [JsonPropertyName("mappings")]
    public required IList<V1alpha2RequestSpecForProviderMappings> Mappings { get; set; }

    /// <summary>Payload defines the payload for the request.</summary>
    [JsonPropertyName("payload")]
    public required V1alpha2RequestSpecForProviderPayload Payload { get; set; }

    /// <summary>SecretInjectionConfig specifies the secrets receiving patches for response data.</summary>
    [JsonPropertyName("secretInjectionConfigs")]
    public IList<V1alpha2RequestSpecForProviderSecretInjectionConfigs>? SecretInjectionConfigs { get; set; }

    /// <summary>
    /// TLSConfig allows overriding the TLS configuration from ProviderConfig for this specific request.
    /// This field is mutually exclusive with InsecureSkipTLSVerify.
    /// </summary>
    [JsonPropertyName("tlsConfig")]
    public V1alpha2RequestSpecForProviderTlsConfig? TlsConfig { get; set; }

    /// <summary>WaitTimeout specifies the maximum time duration for waiting.</summary>
    [JsonPropertyName("waitTimeout")]
    public string? WaitTimeout { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2RequestSpecManagementPoliciesEnum>))]
public enum V1alpha2RequestSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2RequestSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha2RequestSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2RequestSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha2RequestSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha2RequestSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha2RequestSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha2RequestSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>A RequestSpec defines the desired state of a Request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestSpec
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
    public V1alpha2RequestSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary>RequestParameters are the configurable fields of a Request.</summary>
    [JsonPropertyName("forProvider")]
    public required V1alpha2RequestSpecForProvider ForProvider { get; set; }

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
    public IList<V1alpha2RequestSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha2RequestSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha2RequestSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>RequestObservation are the observable fields of a Request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestStatusCacheResponse
{
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    [JsonPropertyName("headers")]
    public IDictionary<string, IList<string>>? Headers { get; set; }

    [JsonPropertyName("statusCode")]
    public int? StatusCode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestStatusCache
{
    [JsonPropertyName("lastUpdated")]
    public string? LastUpdated { get; set; }

    /// <summary>RequestObservation are the observable fields of a Request.</summary>
    [JsonPropertyName("response")]
    public V1alpha2RequestStatusCacheResponse? Response { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestStatusConditions
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

/// <summary>Action specifies the intended action for the request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2RequestStatusRequestDetailsActionEnum>))]
public enum V1alpha2RequestStatusRequestDetailsActionEnum
{
    [EnumMember(Value = "CREATE"), JsonStringEnumMemberName("CREATE")]
    CREATE,
    [EnumMember(Value = "OBSERVE"), JsonStringEnumMemberName("OBSERVE")]
    OBSERVE,
    [EnumMember(Value = "UPDATE"), JsonStringEnumMemberName("UPDATE")]
    UPDATE,
    [EnumMember(Value = "REMOVE"), JsonStringEnumMemberName("REMOVE")]
    REMOVE
}

/// <summary>Method specifies the HTTP method for the request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2RequestStatusRequestDetailsMethodEnum>))]
public enum V1alpha2RequestStatusRequestDetailsMethodEnum
{
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST,
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "PUT"), JsonStringEnumMemberName("PUT")]
    PUT,
    [EnumMember(Value = "DELETE"), JsonStringEnumMemberName("DELETE")]
    DELETE,
    [EnumMember(Value = "PATCH"), JsonStringEnumMemberName("PATCH")]
    PATCH,
    [EnumMember(Value = "HEAD"), JsonStringEnumMemberName("HEAD")]
    HEAD,
    [EnumMember(Value = "OPTIONS"), JsonStringEnumMemberName("OPTIONS")]
    OPTIONS
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestStatusRequestDetails
{
    /// <summary>Action specifies the intended action for the request.</summary>
    [JsonPropertyName("action")]
    public V1alpha2RequestStatusRequestDetailsActionEnum? Action { get; set; }

    /// <summary>Body specifies the body of the request.</summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>Headers specifies the headers for the request.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, IList<string>>? Headers { get; set; }

    /// <summary>Method specifies the HTTP method for the request.</summary>
    [JsonPropertyName("method")]
    public V1alpha2RequestStatusRequestDetailsMethodEnum? Method { get; set; }

    /// <summary>URL specifies the URL for the request.</summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>RequestObservation are the observable fields of a Request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestStatusResponse
{
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    [JsonPropertyName("headers")]
    public IDictionary<string, IList<string>>? Headers { get; set; }

    [JsonPropertyName("statusCode")]
    public int? StatusCode { get; set; }
}

/// <summary>A RequestStatus represents the observed state of a Request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2RequestStatus
{
    [JsonPropertyName("cache")]
    public V1alpha2RequestStatusCache? Cache { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha2RequestStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("failed")]
    public int? Failed { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    [JsonPropertyName("requestDetails")]
    public V1alpha2RequestStatusRequestDetails? RequestDetails { get; set; }

    /// <summary>RequestObservation are the observable fields of a Request.</summary>
    [JsonPropertyName("response")]
    public V1alpha2RequestStatusResponse? Response { get; set; }
}

/// <summary>A Request is an example API type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha2Request : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha2RequestSpec>, IStatus<V1alpha2RequestStatus?>
{
    public const string KubeApiVersion = "v1alpha2";
    public const string KubeKind = "Request";
    public const string KubeGroup = "http.crossplane.io";
    public const string KubePluralName = "requests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "http.crossplane.io/v1alpha2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Request";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>A RequestSpec defines the desired state of a Request.</summary>
    [JsonPropertyName("spec")]
    public required V1alpha2RequestSpec Spec { get; set; }

    /// <summary>A RequestStatus represents the observed state of a Request.</summary>
    [JsonPropertyName("status")]
    public V1alpha2RequestStatus? Status { get; set; }
}
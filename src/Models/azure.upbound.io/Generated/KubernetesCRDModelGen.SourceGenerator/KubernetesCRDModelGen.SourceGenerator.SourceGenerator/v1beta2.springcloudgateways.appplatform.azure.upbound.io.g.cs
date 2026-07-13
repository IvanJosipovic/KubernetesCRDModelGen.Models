#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appplatform.azure.upbound.io;
/// <summary>SpringCloudGateway is the Schema for the SpringCloudGateways API. Manages a Spring Cloud Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SpringCloudGatewayList : IKubernetesObject<V1ListMeta>, IItems<V1beta2SpringCloudGateway>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SpringCloudGatewayList";
    public const string KubeGroup = "appplatform.azure.upbound.io";
    public const string KubePluralName = "springcloudgateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appplatform.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpringCloudGatewayList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2SpringCloudGateway objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2SpringCloudGateway> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudGatewaySpecDeletionPolicyEnum>))]
public enum V1beta2SpringCloudGatewaySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A api_metadata block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecForProviderApiMetadata
{
    /// <summary>Detailed description of the APIs available on the Gateway instance.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Location of additional documentation for the APIs available on the Gateway instance.</summary>
    [JsonPropertyName("documentationUrl")]
    public string? DocumentationUrl { get; set; }

    /// <summary>Base URL that API consumers will use to access APIs on the Gateway instance.</summary>
    [JsonPropertyName("serverUrl")]
    public string? ServerUrl { get; set; }

    /// <summary>Specifies the title describing the context of the APIs available on the Gateway instance.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Specifies the version of APIs available on this Gateway instance.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A client_authorization block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecForProviderClientAuthorization
{
    /// <summary>Specifies the Spring Cloud Certificate IDs of the Spring Cloud Gateway.</summary>
    [JsonPropertyName("certificateIds")]
    public IList<string>? CertificateIds { get; set; }

    /// <summary>Specifies whether the client certificate verification is enabled.</summary>
    [JsonPropertyName("verificationEnabled")]
    public bool? VerificationEnabled { get; set; }
}

/// <summary>A cors block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecForProviderCors
{
    /// <summary>Allowed headers in cross-site requests. The special value * allows actual requests to send any header.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>Allowed HTTP methods on cross-site requests. The special value * allows all methods. If not set, GET and HEAD are allowed by default. Possible values are DELETE, GET, HEAD, MERGE, POST, OPTIONS and PUT.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Allowed origin patterns to make cross-site requests.</summary>
    [JsonPropertyName("allowedOriginPatterns")]
    public IList<string>? AllowedOriginPatterns { get; set; }

    /// <summary>Allowed origins to make cross-site requests. The special value * allows all domains.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>is user credentials are supported on cross-site requests?</summary>
    [JsonPropertyName("credentialsAllowed")]
    public bool? CredentialsAllowed { get; set; }

    /// <summary>HTTP response headers to expose for cross-site requests.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>How long, in seconds, the response from a pre-flight request can be cached by clients.</summary>
    [JsonPropertyName("maxAgeSeconds")]
    public double? MaxAgeSeconds { get; set; }
}

/// <summary>A local_response_cache_per_instance block as defined below. Only one of local_response_cache_per_instance or local_response_cache_per_route can be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecForProviderLocalResponseCachePerInstance
{
    /// <summary>Specifies the maximum size of cache (10MB, 900KB, 1GB...) to determine if the cache needs to evict some entries.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Specifies the time before a cached entry is expired (300s, 5m, 1h...).</summary>
    [JsonPropertyName("timeToLive")]
    public string? TimeToLive { get; set; }
}

/// <summary>A local_response_cache_per_route block as defined below. Only one of local_response_cache_per_instance or local_response_cache_per_route can be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecForProviderLocalResponseCachePerRoute
{
    /// <summary>Specifies the maximum size of cache (10MB, 900KB, 1GB...) to determine if the cache needs to evict some entries.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Specifies the time before a cached entry is expired (300s, 5m, 1h...).</summary>
    [JsonPropertyName("timeToLive")]
    public string? TimeToLive { get; set; }
}

/// <summary>A quota block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecForProviderQuota
{
    /// <summary>Specifies the required cpu of the Spring Cloud Deployment. Possible Values are 500m, 1, 2, 3 and 4. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Specifies the required memory size of the Spring Cloud Deployment. Possible Values are 512Mi, 1Gi, 2Gi, 3Gi, 4Gi, 5Gi, 6Gi, 7Gi, and 8Gi. Defaults to 2Gi if not specified.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Specifies the sensitive environment variables of the Spring Cloud Gateway as a map of key-value pairs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecForProviderSensitiveEnvironmentVariablesSecretRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdRefPolicyResolutionEnum>))]
public enum V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdRefPolicyResolveEnum>))]
public enum V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SpringCloudService in appplatform to populate springCloudServiceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdSelectorPolicyResolveEnum>))]
public enum V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SpringCloudService in appplatform to populate springCloudServiceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A sso block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecForProviderSso
{
    /// <summary>The public identifier for the application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The secret known only to the application and the authorization server.</summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary>The URI of Issuer Identifier.</summary>
    [JsonPropertyName("issuerUri")]
    public string? IssuerUri { get; set; }

    /// <summary>It defines the specific actions applications can be allowed to do on a user&apos;s behalf.</summary>
    [JsonPropertyName("scope")]
    public IList<string>? Scope { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecForProvider
{
    /// <summary>A api_metadata block as defined below.</summary>
    [JsonPropertyName("apiMetadata")]
    public V1beta2SpringCloudGatewaySpecForProviderApiMetadata? ApiMetadata { get; set; }

    /// <summary>Specifies a list of Spring Cloud Application Performance Monitoring IDs.</summary>
    [JsonPropertyName("applicationPerformanceMonitoringIds")]
    public IList<string>? ApplicationPerformanceMonitoringIds { get; set; }

    /// <summary>Specifies a list of application performance monitoring types used in the Spring Cloud Gateway. The allowed values are AppDynamics, ApplicationInsights, Dynatrace, ElasticAPM and NewRelic.</summary>
    [JsonPropertyName("applicationPerformanceMonitoringTypes")]
    public IList<string>? ApplicationPerformanceMonitoringTypes { get; set; }

    /// <summary>A client_authorization block as defined below.</summary>
    [JsonPropertyName("clientAuthorization")]
    public V1beta2SpringCloudGatewaySpecForProviderClientAuthorization? ClientAuthorization { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public V1beta2SpringCloudGatewaySpecForProviderCors? Cors { get; set; }

    /// <summary>Specifies the environment variables of the Spring Cloud Gateway as a map of key-value pairs.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>is only https is allowed?</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>Specifies the required instance count of the Spring Cloud Gateway. Possible Values are between 1 and 500. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>A local_response_cache_per_instance block as defined below. Only one of local_response_cache_per_instance or local_response_cache_per_route can be specified.</summary>
    [JsonPropertyName("localResponseCachePerInstance")]
    public V1beta2SpringCloudGatewaySpecForProviderLocalResponseCachePerInstance? LocalResponseCachePerInstance { get; set; }

    /// <summary>A local_response_cache_per_route block as defined below. Only one of local_response_cache_per_instance or local_response_cache_per_route can be specified.</summary>
    [JsonPropertyName("localResponseCachePerRoute")]
    public V1beta2SpringCloudGatewaySpecForProviderLocalResponseCachePerRoute? LocalResponseCachePerRoute { get; set; }

    /// <summary>Indicates whether the Spring Cloud Gateway exposes endpoint.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A quota block as defined below.</summary>
    [JsonPropertyName("quota")]
    public V1beta2SpringCloudGatewaySpecForProviderQuota? Quota { get; set; }

    /// <summary>Specifies the sensitive environment variables of the Spring Cloud Gateway as a map of key-value pairs.</summary>
    [JsonPropertyName("sensitiveEnvironmentVariablesSecretRef")]
    public V1beta2SpringCloudGatewaySpecForProviderSensitiveEnvironmentVariablesSecretRef? SensitiveEnvironmentVariablesSecretRef { get; set; }

    /// <summary>The ID of the Spring Cloud Service. Changing this forces a new Spring Cloud Gateway to be created.</summary>
    [JsonPropertyName("springCloudServiceId")]
    public string? SpringCloudServiceId { get; set; }

    /// <summary>Reference to a SpringCloudService in appplatform to populate springCloudServiceId.</summary>
    [JsonPropertyName("springCloudServiceIdRef")]
    public V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdRef? SpringCloudServiceIdRef { get; set; }

    /// <summary>Selector for a SpringCloudService in appplatform to populate springCloudServiceId.</summary>
    [JsonPropertyName("springCloudServiceIdSelector")]
    public V1beta2SpringCloudGatewaySpecForProviderSpringCloudServiceIdSelector? SpringCloudServiceIdSelector { get; set; }

    /// <summary>A sso block as defined below.</summary>
    [JsonPropertyName("sso")]
    public V1beta2SpringCloudGatewaySpecForProviderSso? Sso { get; set; }
}

/// <summary>A api_metadata block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecInitProviderApiMetadata
{
    /// <summary>Detailed description of the APIs available on the Gateway instance.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Location of additional documentation for the APIs available on the Gateway instance.</summary>
    [JsonPropertyName("documentationUrl")]
    public string? DocumentationUrl { get; set; }

    /// <summary>Base URL that API consumers will use to access APIs on the Gateway instance.</summary>
    [JsonPropertyName("serverUrl")]
    public string? ServerUrl { get; set; }

    /// <summary>Specifies the title describing the context of the APIs available on the Gateway instance.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Specifies the version of APIs available on this Gateway instance.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A client_authorization block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecInitProviderClientAuthorization
{
    /// <summary>Specifies the Spring Cloud Certificate IDs of the Spring Cloud Gateway.</summary>
    [JsonPropertyName("certificateIds")]
    public IList<string>? CertificateIds { get; set; }

    /// <summary>Specifies whether the client certificate verification is enabled.</summary>
    [JsonPropertyName("verificationEnabled")]
    public bool? VerificationEnabled { get; set; }
}

/// <summary>A cors block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecInitProviderCors
{
    /// <summary>Allowed headers in cross-site requests. The special value * allows actual requests to send any header.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>Allowed HTTP methods on cross-site requests. The special value * allows all methods. If not set, GET and HEAD are allowed by default. Possible values are DELETE, GET, HEAD, MERGE, POST, OPTIONS and PUT.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Allowed origin patterns to make cross-site requests.</summary>
    [JsonPropertyName("allowedOriginPatterns")]
    public IList<string>? AllowedOriginPatterns { get; set; }

    /// <summary>Allowed origins to make cross-site requests. The special value * allows all domains.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>is user credentials are supported on cross-site requests?</summary>
    [JsonPropertyName("credentialsAllowed")]
    public bool? CredentialsAllowed { get; set; }

    /// <summary>HTTP response headers to expose for cross-site requests.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>How long, in seconds, the response from a pre-flight request can be cached by clients.</summary>
    [JsonPropertyName("maxAgeSeconds")]
    public double? MaxAgeSeconds { get; set; }
}

/// <summary>A local_response_cache_per_instance block as defined below. Only one of local_response_cache_per_instance or local_response_cache_per_route can be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecInitProviderLocalResponseCachePerInstance
{
    /// <summary>Specifies the maximum size of cache (10MB, 900KB, 1GB...) to determine if the cache needs to evict some entries.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Specifies the time before a cached entry is expired (300s, 5m, 1h...).</summary>
    [JsonPropertyName("timeToLive")]
    public string? TimeToLive { get; set; }
}

/// <summary>A local_response_cache_per_route block as defined below. Only one of local_response_cache_per_instance or local_response_cache_per_route can be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecInitProviderLocalResponseCachePerRoute
{
    /// <summary>Specifies the maximum size of cache (10MB, 900KB, 1GB...) to determine if the cache needs to evict some entries.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Specifies the time before a cached entry is expired (300s, 5m, 1h...).</summary>
    [JsonPropertyName("timeToLive")]
    public string? TimeToLive { get; set; }
}

/// <summary>A quota block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecInitProviderQuota
{
    /// <summary>Specifies the required cpu of the Spring Cloud Deployment. Possible Values are 500m, 1, 2, 3 and 4. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Specifies the required memory size of the Spring Cloud Deployment. Possible Values are 512Mi, 1Gi, 2Gi, 3Gi, 4Gi, 5Gi, 6Gi, 7Gi, and 8Gi. Defaults to 2Gi if not specified.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>A sso block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecInitProviderSso
{
    /// <summary>The public identifier for the application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The secret known only to the application and the authorization server.</summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary>The URI of Issuer Identifier.</summary>
    [JsonPropertyName("issuerUri")]
    public string? IssuerUri { get; set; }

    /// <summary>It defines the specific actions applications can be allowed to do on a user&apos;s behalf.</summary>
    [JsonPropertyName("scope")]
    public IList<string>? Scope { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecInitProvider
{
    /// <summary>A api_metadata block as defined below.</summary>
    [JsonPropertyName("apiMetadata")]
    public V1beta2SpringCloudGatewaySpecInitProviderApiMetadata? ApiMetadata { get; set; }

    /// <summary>Specifies a list of Spring Cloud Application Performance Monitoring IDs.</summary>
    [JsonPropertyName("applicationPerformanceMonitoringIds")]
    public IList<string>? ApplicationPerformanceMonitoringIds { get; set; }

    /// <summary>Specifies a list of application performance monitoring types used in the Spring Cloud Gateway. The allowed values are AppDynamics, ApplicationInsights, Dynatrace, ElasticAPM and NewRelic.</summary>
    [JsonPropertyName("applicationPerformanceMonitoringTypes")]
    public IList<string>? ApplicationPerformanceMonitoringTypes { get; set; }

    /// <summary>A client_authorization block as defined below.</summary>
    [JsonPropertyName("clientAuthorization")]
    public V1beta2SpringCloudGatewaySpecInitProviderClientAuthorization? ClientAuthorization { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public V1beta2SpringCloudGatewaySpecInitProviderCors? Cors { get; set; }

    /// <summary>Specifies the environment variables of the Spring Cloud Gateway as a map of key-value pairs.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>is only https is allowed?</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>Specifies the required instance count of the Spring Cloud Gateway. Possible Values are between 1 and 500. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>A local_response_cache_per_instance block as defined below. Only one of local_response_cache_per_instance or local_response_cache_per_route can be specified.</summary>
    [JsonPropertyName("localResponseCachePerInstance")]
    public V1beta2SpringCloudGatewaySpecInitProviderLocalResponseCachePerInstance? LocalResponseCachePerInstance { get; set; }

    /// <summary>A local_response_cache_per_route block as defined below. Only one of local_response_cache_per_instance or local_response_cache_per_route can be specified.</summary>
    [JsonPropertyName("localResponseCachePerRoute")]
    public V1beta2SpringCloudGatewaySpecInitProviderLocalResponseCachePerRoute? LocalResponseCachePerRoute { get; set; }

    /// <summary>Indicates whether the Spring Cloud Gateway exposes endpoint.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A quota block as defined below.</summary>
    [JsonPropertyName("quota")]
    public V1beta2SpringCloudGatewaySpecInitProviderQuota? Quota { get; set; }

    [JsonPropertyName("sensitiveEnvironmentVariablesSecretRef")]
    public IDictionary<string, string>? SensitiveEnvironmentVariablesSecretRef { get; set; }

    /// <summary>A sso block as defined below.</summary>
    [JsonPropertyName("sso")]
    public V1beta2SpringCloudGatewaySpecInitProviderSso? Sso { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudGatewaySpecManagementPoliciesEnum>))]
public enum V1beta2SpringCloudGatewaySpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudGatewaySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2SpringCloudGatewaySpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpringCloudGatewaySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2SpringCloudGatewaySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpringCloudGatewaySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpringCloudGatewaySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpringCloudGatewaySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SpringCloudGatewaySpec defines the desired state of SpringCloudGateway</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewaySpec
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
    public V1beta2SpringCloudGatewaySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2SpringCloudGatewaySpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta2SpringCloudGatewaySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2SpringCloudGatewaySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2SpringCloudGatewaySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2SpringCloudGatewaySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A api_metadata block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewayStatusAtProviderApiMetadata
{
    /// <summary>Detailed description of the APIs available on the Gateway instance.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Location of additional documentation for the APIs available on the Gateway instance.</summary>
    [JsonPropertyName("documentationUrl")]
    public string? DocumentationUrl { get; set; }

    /// <summary>Base URL that API consumers will use to access APIs on the Gateway instance.</summary>
    [JsonPropertyName("serverUrl")]
    public string? ServerUrl { get; set; }

    /// <summary>Specifies the title describing the context of the APIs available on the Gateway instance.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>Specifies the version of APIs available on this Gateway instance.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A client_authorization block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewayStatusAtProviderClientAuthorization
{
    /// <summary>Specifies the Spring Cloud Certificate IDs of the Spring Cloud Gateway.</summary>
    [JsonPropertyName("certificateIds")]
    public IList<string>? CertificateIds { get; set; }

    /// <summary>Specifies whether the client certificate verification is enabled.</summary>
    [JsonPropertyName("verificationEnabled")]
    public bool? VerificationEnabled { get; set; }
}

/// <summary>A cors block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewayStatusAtProviderCors
{
    /// <summary>Allowed headers in cross-site requests. The special value * allows actual requests to send any header.</summary>
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    /// <summary>Allowed HTTP methods on cross-site requests. The special value * allows all methods. If not set, GET and HEAD are allowed by default. Possible values are DELETE, GET, HEAD, MERGE, POST, OPTIONS and PUT.</summary>
    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    /// <summary>Allowed origin patterns to make cross-site requests.</summary>
    [JsonPropertyName("allowedOriginPatterns")]
    public IList<string>? AllowedOriginPatterns { get; set; }

    /// <summary>Allowed origins to make cross-site requests. The special value * allows all domains.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>is user credentials are supported on cross-site requests?</summary>
    [JsonPropertyName("credentialsAllowed")]
    public bool? CredentialsAllowed { get; set; }

    /// <summary>HTTP response headers to expose for cross-site requests.</summary>
    [JsonPropertyName("exposedHeaders")]
    public IList<string>? ExposedHeaders { get; set; }

    /// <summary>How long, in seconds, the response from a pre-flight request can be cached by clients.</summary>
    [JsonPropertyName("maxAgeSeconds")]
    public double? MaxAgeSeconds { get; set; }
}

/// <summary>A local_response_cache_per_instance block as defined below. Only one of local_response_cache_per_instance or local_response_cache_per_route can be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewayStatusAtProviderLocalResponseCachePerInstance
{
    /// <summary>Specifies the maximum size of cache (10MB, 900KB, 1GB...) to determine if the cache needs to evict some entries.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Specifies the time before a cached entry is expired (300s, 5m, 1h...).</summary>
    [JsonPropertyName("timeToLive")]
    public string? TimeToLive { get; set; }
}

/// <summary>A local_response_cache_per_route block as defined below. Only one of local_response_cache_per_instance or local_response_cache_per_route can be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewayStatusAtProviderLocalResponseCachePerRoute
{
    /// <summary>Specifies the maximum size of cache (10MB, 900KB, 1GB...) to determine if the cache needs to evict some entries.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Specifies the time before a cached entry is expired (300s, 5m, 1h...).</summary>
    [JsonPropertyName("timeToLive")]
    public string? TimeToLive { get; set; }
}

/// <summary>A quota block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewayStatusAtProviderQuota
{
    /// <summary>Specifies the required cpu of the Spring Cloud Deployment. Possible Values are 500m, 1, 2, 3 and 4. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("cpu")]
    public string? Cpu { get; set; }

    /// <summary>Specifies the required memory size of the Spring Cloud Deployment. Possible Values are 512Mi, 1Gi, 2Gi, 3Gi, 4Gi, 5Gi, 6Gi, 7Gi, and 8Gi. Defaults to 2Gi if not specified.</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>A sso block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewayStatusAtProviderSso
{
    /// <summary>The public identifier for the application.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The secret known only to the application and the authorization server.</summary>
    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    /// <summary>The URI of Issuer Identifier.</summary>
    [JsonPropertyName("issuerUri")]
    public string? IssuerUri { get; set; }

    /// <summary>It defines the specific actions applications can be allowed to do on a user&apos;s behalf.</summary>
    [JsonPropertyName("scope")]
    public IList<string>? Scope { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewayStatusAtProvider
{
    /// <summary>A api_metadata block as defined below.</summary>
    [JsonPropertyName("apiMetadata")]
    public V1beta2SpringCloudGatewayStatusAtProviderApiMetadata? ApiMetadata { get; set; }

    /// <summary>Specifies a list of Spring Cloud Application Performance Monitoring IDs.</summary>
    [JsonPropertyName("applicationPerformanceMonitoringIds")]
    public IList<string>? ApplicationPerformanceMonitoringIds { get; set; }

    /// <summary>Specifies a list of application performance monitoring types used in the Spring Cloud Gateway. The allowed values are AppDynamics, ApplicationInsights, Dynatrace, ElasticAPM and NewRelic.</summary>
    [JsonPropertyName("applicationPerformanceMonitoringTypes")]
    public IList<string>? ApplicationPerformanceMonitoringTypes { get; set; }

    /// <summary>A client_authorization block as defined below.</summary>
    [JsonPropertyName("clientAuthorization")]
    public V1beta2SpringCloudGatewayStatusAtProviderClientAuthorization? ClientAuthorization { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public V1beta2SpringCloudGatewayStatusAtProviderCors? Cors { get; set; }

    /// <summary>Specifies the environment variables of the Spring Cloud Gateway as a map of key-value pairs.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>is only https is allowed?</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>The ID of the Spring Cloud Gateway.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the required instance count of the Spring Cloud Gateway. Possible Values are between 1 and 500. Defaults to 1 if not specified.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>A local_response_cache_per_instance block as defined below. Only one of local_response_cache_per_instance or local_response_cache_per_route can be specified.</summary>
    [JsonPropertyName("localResponseCachePerInstance")]
    public V1beta2SpringCloudGatewayStatusAtProviderLocalResponseCachePerInstance? LocalResponseCachePerInstance { get; set; }

    /// <summary>A local_response_cache_per_route block as defined below. Only one of local_response_cache_per_instance or local_response_cache_per_route can be specified.</summary>
    [JsonPropertyName("localResponseCachePerRoute")]
    public V1beta2SpringCloudGatewayStatusAtProviderLocalResponseCachePerRoute? LocalResponseCachePerRoute { get; set; }

    /// <summary>Indicates whether the Spring Cloud Gateway exposes endpoint.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A quota block as defined below.</summary>
    [JsonPropertyName("quota")]
    public V1beta2SpringCloudGatewayStatusAtProviderQuota? Quota { get; set; }

    /// <summary>The ID of the Spring Cloud Service. Changing this forces a new Spring Cloud Gateway to be created.</summary>
    [JsonPropertyName("springCloudServiceId")]
    public string? SpringCloudServiceId { get; set; }

    /// <summary>A sso block as defined below.</summary>
    [JsonPropertyName("sso")]
    public V1beta2SpringCloudGatewayStatusAtProviderSso? Sso { get; set; }

    /// <summary>URL of the Spring Cloud Gateway, exposed when &apos;public_network_access_enabled&apos; is true.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewayStatusConditions
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

/// <summary>SpringCloudGatewayStatus defines the observed state of SpringCloudGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpringCloudGatewayStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2SpringCloudGatewayStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2SpringCloudGatewayStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SpringCloudGateway is the Schema for the SpringCloudGateways API. Manages a Spring Cloud Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SpringCloudGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2SpringCloudGatewaySpec>, IStatus<V1beta2SpringCloudGatewayStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SpringCloudGateway";
    public const string KubeGroup = "appplatform.azure.upbound.io";
    public const string KubePluralName = "springcloudgateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appplatform.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpringCloudGateway";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpringCloudGatewaySpec defines the desired state of SpringCloudGateway</summary>
    [JsonPropertyName("spec")]
    public required V1beta2SpringCloudGatewaySpec Spec { get; set; }

    /// <summary>SpringCloudGatewayStatus defines the observed state of SpringCloudGateway.</summary>
    [JsonPropertyName("status")]
    public V1beta2SpringCloudGatewayStatus? Status { get; set; }
}
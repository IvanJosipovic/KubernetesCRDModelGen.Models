#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.m.upbound.io;
/// <summary>Backend is the Schema for the Backends API. Manages a backend within an API Management Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BackendList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Backend>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BackendList";
    public const string KubeGroup = "apimanagement.azure.m.upbound.io";
    public const string KubePluralName = "backends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackendList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Backend objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Backend> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackendSpecForProviderApiManagementNameRefPolicyResolutionEnum>))]
public enum V1beta1BackendSpecForProviderApiManagementNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackendSpecForProviderApiManagementNameRefPolicyResolveEnum>))]
public enum V1beta1BackendSpecForProviderApiManagementNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderApiManagementNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BackendSpecForProviderApiManagementNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BackendSpecForProviderApiManagementNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderApiManagementNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendSpecForProviderApiManagementNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackendSpecForProviderApiManagementNameSelectorPolicyResolutionEnum>))]
public enum V1beta1BackendSpecForProviderApiManagementNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackendSpecForProviderApiManagementNameSelectorPolicyResolveEnum>))]
public enum V1beta1BackendSpecForProviderApiManagementNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderApiManagementNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BackendSpecForProviderApiManagementNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BackendSpecForProviderApiManagementNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderApiManagementNameSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendSpecForProviderApiManagementNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderCircuitBreakerRuleFailureConditionStatusCodeRange
{
    /// <summary>Specifies the maximum HTTP status code to consider as a failure. Possible values are between 200 and 599.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Specifies the minimum HTTP status code to consider as a failure. Possible values are between 200 and 599.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>A failure_condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderCircuitBreakerRuleFailureCondition
{
    /// <summary>Specifies the number of failures within the specified interval that will trigger the circuit breaker. Possible values are between 1 and 10000.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Specifies a list of error reasons to consider as failures.</summary>
    [JsonPropertyName("errorReasons")]
    public IList<string>? ErrorReasons { get; set; }

    /// <summary>Specifies the time window over which failures are counted, in ISO 8601 format.</summary>
    [JsonPropertyName("intervalDuration")]
    public string? IntervalDuration { get; set; }

    /// <summary>Specifies the percentage of failures within the specified interval that will trigger the circuit breaker. Possible values are between 1 and 100.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }

    /// <summary>One or more status_code_range blocks as defined below.</summary>
    [JsonPropertyName("statusCodeRange")]
    public IList<V1beta1BackendSpecForProviderCircuitBreakerRuleFailureConditionStatusCodeRange>? StatusCodeRange { get; set; }
}

/// <summary>A circuit_breaker_rule block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderCircuitBreakerRule
{
    /// <summary>Specifies whether the circuit breaker should honor Retry-After requests. Defaults to false.</summary>
    [JsonPropertyName("acceptRetryAfterEnabled")]
    public bool? AcceptRetryAfterEnabled { get; set; }

    /// <summary>A failure_condition block as defined below.</summary>
    [JsonPropertyName("failureCondition")]
    public V1beta1BackendSpecForProviderCircuitBreakerRuleFailureCondition? FailureCondition { get; set; }

    /// <summary>The name of the circuit breaker rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the duration for which the circuit remains open before retrying, in ISO 8601 format.</summary>
    [JsonPropertyName("tripDuration")]
    public string? TripDuration { get; set; }
}

/// <summary>An authorization block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderCredentialsAuthorization
{
    /// <summary>The authentication Parameter value.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The authentication Scheme name.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>A credentials block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderCredentials
{
    /// <summary>An authorization block as defined below.</summary>
    [JsonPropertyName("authorization")]
    public V1beta1BackendSpecForProviderCredentialsAuthorization? Authorization { get; set; }

    /// <summary>A list of client certificate thumbprints to present to the backend host. The certificates must exist within the API Management Service.</summary>
    [JsonPropertyName("certificate")]
    public IList<string>? Certificate { get; set; }

    /// <summary>A mapping of header parameters to pass to the backend host. The keys are the header names and the values are a comma separated string of header values. This is converted to a list before being passed to the API.</summary>
    [JsonPropertyName("header")]
    public IDictionary<string, string>? Header { get; set; }

    /// <summary>A mapping of query parameters to pass to the backend host. The keys are the query names and the values are a comma separated string of query values. This is converted to a list before being passed to the API.</summary>
    [JsonPropertyName("query")]
    public IDictionary<string, string>? Query { get; set; }
}

/// <summary>The password to connect to the proxy server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderProxyPasswordSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>A proxy block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderProxy
{
    /// <summary>The password to connect to the proxy server.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1BackendSpecForProviderProxyPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The URL of the proxy server.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The username to connect to the proxy server.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackendSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta1BackendSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackendSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta1BackendSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BackendSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BackendSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackendSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta1BackendSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackendSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta1BackendSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1BackendSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1BackendSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderResourceGroupNameSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackendSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderServiceFabricClusterServerX509Name
{
    /// <summary>The thumbprint for the issuer of the certificate.</summary>
    [JsonPropertyName("issuerCertificateThumbprint")]
    public string? IssuerCertificateThumbprint { get; set; }

    /// <summary>The common name of the certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A service_fabric_cluster block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderServiceFabricCluster
{
    /// <summary>The client certificate resource id for the management endpoint.</summary>
    [JsonPropertyName("clientCertificateId")]
    public string? ClientCertificateId { get; set; }

    /// <summary>The client certificate thumbprint for the management endpoint.</summary>
    [JsonPropertyName("clientCertificateThumbprint")]
    public string? ClientCertificateThumbprint { get; set; }

    /// <summary>A list of cluster management endpoints.</summary>
    [JsonPropertyName("managementEndpoints")]
    public IList<string>? ManagementEndpoints { get; set; }

    /// <summary>The maximum number of retries when attempting resolve the partition.</summary>
    [JsonPropertyName("maxPartitionResolutionRetries")]
    public double? MaxPartitionResolutionRetries { get; set; }

    /// <summary>A list of thumbprints of the server certificates of the Service Fabric cluster.</summary>
    [JsonPropertyName("serverCertificateThumbprints")]
    public IList<string>? ServerCertificateThumbprints { get; set; }

    /// <summary>One or more server_x509_name blocks as documented below.</summary>
    [JsonPropertyName("serverX509Name")]
    public IList<V1beta1BackendSpecForProviderServiceFabricClusterServerX509Name>? ServerX509Name { get; set; }
}

/// <summary>A tls block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProviderTls
{
    /// <summary>Flag indicating whether SSL certificate chain validation should be done when using self-signed certificates for the backend host.</summary>
    [JsonPropertyName("validateCertificateChain")]
    public bool? ValidateCertificateChain { get; set; }

    /// <summary>Flag indicating whether SSL certificate name validation should be done when using self-signed certificates for the backend host.</summary>
    [JsonPropertyName("validateCertificateName")]
    public bool? ValidateCertificateName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecForProvider
{
    /// <summary>The Name of the API Management Service where this backend should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>Reference to a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameRef")]
    public V1beta1BackendSpecForProviderApiManagementNameRef? ApiManagementNameRef { get; set; }

    /// <summary>Selector for a Management in apimanagement to populate apiManagementName.</summary>
    [JsonPropertyName("apiManagementNameSelector")]
    public V1beta1BackendSpecForProviderApiManagementNameSelector? ApiManagementNameSelector { get; set; }

    /// <summary>A circuit_breaker_rule block as documented below.</summary>
    [JsonPropertyName("circuitBreakerRule")]
    public V1beta1BackendSpecForProviderCircuitBreakerRule? CircuitBreakerRule { get; set; }

    /// <summary>A credentials block as documented below.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1BackendSpecForProviderCredentials? Credentials { get; set; }

    /// <summary>The description of the backend.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The protocol used by the backend host. Possible values are http or soap.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>A proxy block as documented below.</summary>
    [JsonPropertyName("proxy")]
    public V1beta1BackendSpecForProviderProxy? Proxy { get; set; }

    /// <summary>The Name of the Resource Group where the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1BackendSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1BackendSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The management URI of the backend host in an external system. This URI can be the ARM Resource ID of Logic Apps, Function Apps or API Apps, or the management endpoint of a Service Fabric cluster.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>A service_fabric_cluster block as documented below.</summary>
    [JsonPropertyName("serviceFabricCluster")]
    public V1beta1BackendSpecForProviderServiceFabricCluster? ServiceFabricCluster { get; set; }

    /// <summary>The title of the backend.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>A tls block as documented below.</summary>
    [JsonPropertyName("tls")]
    public V1beta1BackendSpecForProviderTls? Tls { get; set; }

    /// <summary>The backend host URL should be specified in the format &quot;https://backend.com/api&quot;, avoiding trailing slashes (/) to minimize misconfiguration risks. Azure API Management instance will append the backend resource name to this URL. This URL typically serves as the base-url in the set-backend-service policy, enabling seamless transitions from frontend to backend.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecInitProviderCircuitBreakerRuleFailureConditionStatusCodeRange
{
    /// <summary>Specifies the maximum HTTP status code to consider as a failure. Possible values are between 200 and 599.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Specifies the minimum HTTP status code to consider as a failure. Possible values are between 200 and 599.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>A failure_condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecInitProviderCircuitBreakerRuleFailureCondition
{
    /// <summary>Specifies the number of failures within the specified interval that will trigger the circuit breaker. Possible values are between 1 and 10000.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Specifies a list of error reasons to consider as failures.</summary>
    [JsonPropertyName("errorReasons")]
    public IList<string>? ErrorReasons { get; set; }

    /// <summary>Specifies the time window over which failures are counted, in ISO 8601 format.</summary>
    [JsonPropertyName("intervalDuration")]
    public string? IntervalDuration { get; set; }

    /// <summary>Specifies the percentage of failures within the specified interval that will trigger the circuit breaker. Possible values are between 1 and 100.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }

    /// <summary>One or more status_code_range blocks as defined below.</summary>
    [JsonPropertyName("statusCodeRange")]
    public IList<V1beta1BackendSpecInitProviderCircuitBreakerRuleFailureConditionStatusCodeRange>? StatusCodeRange { get; set; }
}

/// <summary>A circuit_breaker_rule block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecInitProviderCircuitBreakerRule
{
    /// <summary>Specifies whether the circuit breaker should honor Retry-After requests. Defaults to false.</summary>
    [JsonPropertyName("acceptRetryAfterEnabled")]
    public bool? AcceptRetryAfterEnabled { get; set; }

    /// <summary>A failure_condition block as defined below.</summary>
    [JsonPropertyName("failureCondition")]
    public V1beta1BackendSpecInitProviderCircuitBreakerRuleFailureCondition? FailureCondition { get; set; }

    /// <summary>The name of the circuit breaker rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the duration for which the circuit remains open before retrying, in ISO 8601 format.</summary>
    [JsonPropertyName("tripDuration")]
    public string? TripDuration { get; set; }
}

/// <summary>An authorization block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecInitProviderCredentialsAuthorization
{
    /// <summary>The authentication Parameter value.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The authentication Scheme name.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>A credentials block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecInitProviderCredentials
{
    /// <summary>An authorization block as defined below.</summary>
    [JsonPropertyName("authorization")]
    public V1beta1BackendSpecInitProviderCredentialsAuthorization? Authorization { get; set; }

    /// <summary>A list of client certificate thumbprints to present to the backend host. The certificates must exist within the API Management Service.</summary>
    [JsonPropertyName("certificate")]
    public IList<string>? Certificate { get; set; }

    /// <summary>A mapping of header parameters to pass to the backend host. The keys are the header names and the values are a comma separated string of header values. This is converted to a list before being passed to the API.</summary>
    [JsonPropertyName("header")]
    public IDictionary<string, string>? Header { get; set; }

    /// <summary>A mapping of query parameters to pass to the backend host. The keys are the query names and the values are a comma separated string of query values. This is converted to a list before being passed to the API.</summary>
    [JsonPropertyName("query")]
    public IDictionary<string, string>? Query { get; set; }
}

/// <summary>The password to connect to the proxy server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecInitProviderProxyPasswordSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>A proxy block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecInitProviderProxy
{
    /// <summary>The password to connect to the proxy server.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1BackendSpecInitProviderProxyPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The URL of the proxy server.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The username to connect to the proxy server.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecInitProviderServiceFabricClusterServerX509Name
{
    /// <summary>The thumbprint for the issuer of the certificate.</summary>
    [JsonPropertyName("issuerCertificateThumbprint")]
    public string? IssuerCertificateThumbprint { get; set; }

    /// <summary>The common name of the certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A service_fabric_cluster block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecInitProviderServiceFabricCluster
{
    /// <summary>The client certificate resource id for the management endpoint.</summary>
    [JsonPropertyName("clientCertificateId")]
    public string? ClientCertificateId { get; set; }

    /// <summary>The client certificate thumbprint for the management endpoint.</summary>
    [JsonPropertyName("clientCertificateThumbprint")]
    public string? ClientCertificateThumbprint { get; set; }

    /// <summary>A list of cluster management endpoints.</summary>
    [JsonPropertyName("managementEndpoints")]
    public IList<string>? ManagementEndpoints { get; set; }

    /// <summary>The maximum number of retries when attempting resolve the partition.</summary>
    [JsonPropertyName("maxPartitionResolutionRetries")]
    public double? MaxPartitionResolutionRetries { get; set; }

    /// <summary>A list of thumbprints of the server certificates of the Service Fabric cluster.</summary>
    [JsonPropertyName("serverCertificateThumbprints")]
    public IList<string>? ServerCertificateThumbprints { get; set; }

    /// <summary>One or more server_x509_name blocks as documented below.</summary>
    [JsonPropertyName("serverX509Name")]
    public IList<V1beta1BackendSpecInitProviderServiceFabricClusterServerX509Name>? ServerX509Name { get; set; }
}

/// <summary>A tls block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecInitProviderTls
{
    /// <summary>Flag indicating whether SSL certificate chain validation should be done when using self-signed certificates for the backend host.</summary>
    [JsonPropertyName("validateCertificateChain")]
    public bool? ValidateCertificateChain { get; set; }

    /// <summary>Flag indicating whether SSL certificate name validation should be done when using self-signed certificates for the backend host.</summary>
    [JsonPropertyName("validateCertificateName")]
    public bool? ValidateCertificateName { get; set; }
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
public partial class V1beta1BackendSpecInitProvider
{
    /// <summary>A circuit_breaker_rule block as documented below.</summary>
    [JsonPropertyName("circuitBreakerRule")]
    public V1beta1BackendSpecInitProviderCircuitBreakerRule? CircuitBreakerRule { get; set; }

    /// <summary>A credentials block as documented below.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1BackendSpecInitProviderCredentials? Credentials { get; set; }

    /// <summary>The description of the backend.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The protocol used by the backend host. Possible values are http or soap.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>A proxy block as documented below.</summary>
    [JsonPropertyName("proxy")]
    public V1beta1BackendSpecInitProviderProxy? Proxy { get; set; }

    /// <summary>The management URI of the backend host in an external system. This URI can be the ARM Resource ID of Logic Apps, Function Apps or API Apps, or the management endpoint of a Service Fabric cluster.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>A service_fabric_cluster block as documented below.</summary>
    [JsonPropertyName("serviceFabricCluster")]
    public V1beta1BackendSpecInitProviderServiceFabricCluster? ServiceFabricCluster { get; set; }

    /// <summary>The title of the backend.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>A tls block as documented below.</summary>
    [JsonPropertyName("tls")]
    public V1beta1BackendSpecInitProviderTls? Tls { get; set; }

    /// <summary>The backend host URL should be specified in the format &quot;https://backend.com/api&quot;, avoiding trailing slashes (/) to minimize misconfiguration risks. Azure API Management instance will append the backend resource name to this URL. This URL typically serves as the base-url in the set-backend-service policy, enabling seamless transitions from frontend to backend.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackendSpecManagementPoliciesEnum>))]
public enum V1beta1BackendSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecProviderConfigRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>BackendSpec defines the desired state of Backend</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1BackendSpecForProvider ForProvider { get; set; }

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
    public V1beta1BackendSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1BackendSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BackendSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BackendSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusAtProviderCircuitBreakerRuleFailureConditionStatusCodeRange
{
    /// <summary>Specifies the maximum HTTP status code to consider as a failure. Possible values are between 200 and 599.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Specifies the minimum HTTP status code to consider as a failure. Possible values are between 200 and 599.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>A failure_condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusAtProviderCircuitBreakerRuleFailureCondition
{
    /// <summary>Specifies the number of failures within the specified interval that will trigger the circuit breaker. Possible values are between 1 and 10000.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Specifies a list of error reasons to consider as failures.</summary>
    [JsonPropertyName("errorReasons")]
    public IList<string>? ErrorReasons { get; set; }

    /// <summary>Specifies the time window over which failures are counted, in ISO 8601 format.</summary>
    [JsonPropertyName("intervalDuration")]
    public string? IntervalDuration { get; set; }

    /// <summary>Specifies the percentage of failures within the specified interval that will trigger the circuit breaker. Possible values are between 1 and 100.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }

    /// <summary>One or more status_code_range blocks as defined below.</summary>
    [JsonPropertyName("statusCodeRange")]
    public IList<V1beta1BackendStatusAtProviderCircuitBreakerRuleFailureConditionStatusCodeRange>? StatusCodeRange { get; set; }
}

/// <summary>A circuit_breaker_rule block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusAtProviderCircuitBreakerRule
{
    /// <summary>Specifies whether the circuit breaker should honor Retry-After requests. Defaults to false.</summary>
    [JsonPropertyName("acceptRetryAfterEnabled")]
    public bool? AcceptRetryAfterEnabled { get; set; }

    /// <summary>A failure_condition block as defined below.</summary>
    [JsonPropertyName("failureCondition")]
    public V1beta1BackendStatusAtProviderCircuitBreakerRuleFailureCondition? FailureCondition { get; set; }

    /// <summary>The name of the circuit breaker rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the duration for which the circuit remains open before retrying, in ISO 8601 format.</summary>
    [JsonPropertyName("tripDuration")]
    public string? TripDuration { get; set; }
}

/// <summary>An authorization block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusAtProviderCredentialsAuthorization
{
    /// <summary>The authentication Parameter value.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The authentication Scheme name.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>A credentials block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusAtProviderCredentials
{
    /// <summary>An authorization block as defined below.</summary>
    [JsonPropertyName("authorization")]
    public V1beta1BackendStatusAtProviderCredentialsAuthorization? Authorization { get; set; }

    /// <summary>A list of client certificate thumbprints to present to the backend host. The certificates must exist within the API Management Service.</summary>
    [JsonPropertyName("certificate")]
    public IList<string>? Certificate { get; set; }

    /// <summary>A mapping of header parameters to pass to the backend host. The keys are the header names and the values are a comma separated string of header values. This is converted to a list before being passed to the API.</summary>
    [JsonPropertyName("header")]
    public IDictionary<string, string>? Header { get; set; }

    /// <summary>A mapping of query parameters to pass to the backend host. The keys are the query names and the values are a comma separated string of query values. This is converted to a list before being passed to the API.</summary>
    [JsonPropertyName("query")]
    public IDictionary<string, string>? Query { get; set; }
}

/// <summary>A proxy block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusAtProviderProxy
{
    /// <summary>The URL of the proxy server.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The username to connect to the proxy server.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusAtProviderServiceFabricClusterServerX509Name
{
    /// <summary>The thumbprint for the issuer of the certificate.</summary>
    [JsonPropertyName("issuerCertificateThumbprint")]
    public string? IssuerCertificateThumbprint { get; set; }

    /// <summary>The common name of the certificate.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A service_fabric_cluster block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusAtProviderServiceFabricCluster
{
    /// <summary>The client certificate resource id for the management endpoint.</summary>
    [JsonPropertyName("clientCertificateId")]
    public string? ClientCertificateId { get; set; }

    /// <summary>The client certificate thumbprint for the management endpoint.</summary>
    [JsonPropertyName("clientCertificateThumbprint")]
    public string? ClientCertificateThumbprint { get; set; }

    /// <summary>A list of cluster management endpoints.</summary>
    [JsonPropertyName("managementEndpoints")]
    public IList<string>? ManagementEndpoints { get; set; }

    /// <summary>The maximum number of retries when attempting resolve the partition.</summary>
    [JsonPropertyName("maxPartitionResolutionRetries")]
    public double? MaxPartitionResolutionRetries { get; set; }

    /// <summary>A list of thumbprints of the server certificates of the Service Fabric cluster.</summary>
    [JsonPropertyName("serverCertificateThumbprints")]
    public IList<string>? ServerCertificateThumbprints { get; set; }

    /// <summary>One or more server_x509_name blocks as documented below.</summary>
    [JsonPropertyName("serverX509Name")]
    public IList<V1beta1BackendStatusAtProviderServiceFabricClusterServerX509Name>? ServerX509Name { get; set; }
}

/// <summary>A tls block as documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusAtProviderTls
{
    /// <summary>Flag indicating whether SSL certificate chain validation should be done when using self-signed certificates for the backend host.</summary>
    [JsonPropertyName("validateCertificateChain")]
    public bool? ValidateCertificateChain { get; set; }

    /// <summary>Flag indicating whether SSL certificate name validation should be done when using self-signed certificates for the backend host.</summary>
    [JsonPropertyName("validateCertificateName")]
    public bool? ValidateCertificateName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusAtProvider
{
    /// <summary>The Name of the API Management Service where this backend should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("apiManagementName")]
    public string? ApiManagementName { get; set; }

    /// <summary>A circuit_breaker_rule block as documented below.</summary>
    [JsonPropertyName("circuitBreakerRule")]
    public V1beta1BackendStatusAtProviderCircuitBreakerRule? CircuitBreakerRule { get; set; }

    /// <summary>A credentials block as documented below.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1BackendStatusAtProviderCredentials? Credentials { get; set; }

    /// <summary>The description of the backend.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the API Management API.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The protocol used by the backend host. Possible values are http or soap.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>A proxy block as documented below.</summary>
    [JsonPropertyName("proxy")]
    public V1beta1BackendStatusAtProviderProxy? Proxy { get; set; }

    /// <summary>The Name of the Resource Group where the API Management Service exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The management URI of the backend host in an external system. This URI can be the ARM Resource ID of Logic Apps, Function Apps or API Apps, or the management endpoint of a Service Fabric cluster.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>A service_fabric_cluster block as documented below.</summary>
    [JsonPropertyName("serviceFabricCluster")]
    public V1beta1BackendStatusAtProviderServiceFabricCluster? ServiceFabricCluster { get; set; }

    /// <summary>The title of the backend.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>A tls block as documented below.</summary>
    [JsonPropertyName("tls")]
    public V1beta1BackendStatusAtProviderTls? Tls { get; set; }

    /// <summary>The backend host URL should be specified in the format &quot;https://backend.com/api&quot;, avoiding trailing slashes (/) to minimize misconfiguration risks. Azure API Management instance will append the backend resource name to this URL. This URL typically serves as the base-url in the set-backend-service policy, enabling seamless transitions from frontend to backend.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatusConditions
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

/// <summary>BackendStatus defines the observed state of Backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackendStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1BackendStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BackendStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Backend is the Schema for the Backends API. Manages a backend within an API Management Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Backend : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BackendSpec>, IStatus<V1beta1BackendStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Backend";
    public const string KubeGroup = "apimanagement.azure.m.upbound.io";
    public const string KubePluralName = "backends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Backend";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackendSpec defines the desired state of Backend</summary>
    [JsonPropertyName("spec")]
    public required V1beta1BackendSpec Spec { get; set; }

    /// <summary>BackendStatus defines the observed state of Backend.</summary>
    [JsonPropertyName("status")]
    public V1beta1BackendStatus? Status { get; set; }
}
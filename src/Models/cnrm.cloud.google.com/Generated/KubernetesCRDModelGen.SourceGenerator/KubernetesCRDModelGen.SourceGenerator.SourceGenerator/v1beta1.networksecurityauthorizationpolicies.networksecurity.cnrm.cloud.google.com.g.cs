#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networksecurity.cnrm.cloud.google.com;
/// <summary>NetworkSecurityAuthorizationPolicy is the Schema for the NetworkSecurityAuthorizationPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NetworkSecurityAuthorizationPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1NetworkSecurityAuthorizationPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NetworkSecurityAuthorizationPolicyList";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecurityauthorizationpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecurityAuthorizationPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1NetworkSecurityAuthorizationPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1NetworkSecurityAuthorizationPolicy> Items { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkSecurityAuthorizationPolicySpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Match against key:value pair in http header. Provides a flexible match based on HTTP headers, for potentially advanced use cases. At least one header should match. Avoid using header matches to make authorization decisions unless there is a strong guarantee that requests arrive through a trusted client or proxy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkSecurityAuthorizationPolicySpecRulesDestinationsHttpHeaderMatch
{
    /// <summary>Required. The name of the HTTP header to match. For matching against the HTTP request&apos;s authority, use a headerMatch with the header name &quot;:authority&quot;. For matching a request&apos;s method, use the headerName &quot;:method&quot;.</summary>
    [JsonPropertyName("headerName")]
    public required string HeaderName { get; set; }

    /// <summary>Required. The value of the header must match the regular expression specified in regexMatch. For regular expression grammar, please see: en.cppreference.com/w/cpp/regex/ecmascript For matching against a port specified in the HTTP request, use a headerMatch with headerName set to Host and a regular expression that satisfies the RFC2616 Host header&apos;s port specifier.</summary>
    [JsonPropertyName("regexMatch")]
    public required string RegexMatch { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkSecurityAuthorizationPolicySpecRulesDestinations
{
    /// <summary>Required. List of host names to match. Matched against the &quot;:authority&quot; header in http requests. At least one host should match. Each host can be an exact match, or a prefix match (example &quot;mydomain.*&quot;) or a suffix match (example &quot;*.myorg.com&quot;) or a presence (any) match &quot;*&quot;.</summary>
    [JsonPropertyName("hosts")]
    public required IList<string> Hosts { get; set; }

    /// <summary>Optional. Match against key:value pair in http header. Provides a flexible match based on HTTP headers, for potentially advanced use cases. At least one header should match. Avoid using header matches to make authorization decisions unless there is a strong guarantee that requests arrive through a trusted client or proxy.</summary>
    [JsonPropertyName("httpHeaderMatch")]
    public V1beta1NetworkSecurityAuthorizationPolicySpecRulesDestinationsHttpHeaderMatch? HttpHeaderMatch { get; set; }

    /// <summary>Optional. A list of HTTP methods to match. At least one method should match. Should not be set for gRPC services.</summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary>Required. List of destination ports to match. At least one port should match.</summary>
    [JsonPropertyName("ports")]
    public required IList<int> Ports { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkSecurityAuthorizationPolicySpecRulesSources
{
    /// <summary>Optional. List of CIDR ranges to match based on source IP address. At least one IP block should match. Single IP (e.g., &quot;1.2.3.4&quot;) and CIDR (e.g., &quot;1.2.3.0/24&quot;) are supported. Authorization based on source IP alone should be avoided. The IP addresses of any load balancers or proxies should be considered untrusted.</summary>
    [JsonPropertyName("ipBlocks")]
    public IList<string>? IpBlocks { get; set; }

    /// <summary>Optional. List of peer identities to match for authorization. At least one principal should match. Each peer can be an exact match, or a prefix match (example, &quot;namespace/*&quot;) or a suffix match (example, &quot;*/service-account&quot;) or a presence match &quot;*&quot;. Authorization based on the principal name without certificate validation (configured by ServerTlsPolicy resource) is considered insecure.</summary>
    [JsonPropertyName("principals")]
    public IList<string>? Principals { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkSecurityAuthorizationPolicySpecRules
{
    /// <summary>Optional. List of attributes for the traffic destination. All of the destinations must match. A destination is a match if a request matches all the specified hosts, ports, methods and headers. If not set, the action specified in the &apos;action&apos; field will be applied without any rule checks for the destination.</summary>
    [JsonPropertyName("destinations")]
    public IList<V1beta1NetworkSecurityAuthorizationPolicySpecRulesDestinations>? Destinations { get; set; }

    /// <summary>Optional. List of attributes for the traffic source. All of the sources must match. A source is a match if both principals and ip_blocks match. If not set, the action specified in the &apos;action&apos; field will be applied without any rule checks for the source.</summary>
    [JsonPropertyName("sources")]
    public IList<V1beta1NetworkSecurityAuthorizationPolicySpecRulesSources>? Sources { get; set; }
}

/// <summary>NetworkSecurityAuthorizationPolicySpec defines the desired state of NetworkSecurityAuthorizationPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkSecurityAuthorizationPolicySpec
{
    /// <summary>Required. The action to take when a rule match is found. Possible values are &quot;ALLOW&quot; or &quot;DENY&quot;.</summary>
    [JsonPropertyName("action")]
    public required string Action { get; set; }

    /// <summary>Optional. Free-text description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1beta1NetworkSecurityAuthorizationPolicySpecProjectRef ProjectRef { get; set; }

    /// <summary>The NetworkSecurityAuthorizationPolicy name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. List of rules to match. Note that at least one of the rules must match in order for the action specified in the &apos;action&apos; field to be taken. A rule is a match if there is a matching source and destination. If left blank, the action specified in the `action` field will be applied on every request.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1NetworkSecurityAuthorizationPolicySpecRules>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkSecurityAuthorizationPolicyStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>NetworkSecurityAuthorizationPolicyStatus defines the config connector machine state of NetworkSecurityAuthorizationPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NetworkSecurityAuthorizationPolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NetworkSecurityAuthorizationPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The timestamp when the resource was created.</summary>
    [JsonPropertyName("createTime")]
    public DateTime? CreateTime { get; set; }

    /// <summary>A unique specifier for the NetworkSecurityAuthorizationPolicy resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Output only. The timestamp when the resource was updated.</summary>
    [JsonPropertyName("updateTime")]
    public DateTime? UpdateTime { get; set; }
}

/// <summary>NetworkSecurityAuthorizationPolicy is the Schema for the NetworkSecurityAuthorizationPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NetworkSecurityAuthorizationPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NetworkSecurityAuthorizationPolicySpec>, IStatus<V1beta1NetworkSecurityAuthorizationPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NetworkSecurityAuthorizationPolicy";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecurityauthorizationpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecurityAuthorizationPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkSecurityAuthorizationPolicySpec defines the desired state of NetworkSecurityAuthorizationPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta1NetworkSecurityAuthorizationPolicySpec Spec { get; set; }

    /// <summary>NetworkSecurityAuthorizationPolicyStatus defines the config connector machine state of NetworkSecurityAuthorizationPolicy</summary>
    [JsonPropertyName("status")]
    public V1beta1NetworkSecurityAuthorizationPolicyStatus? Status { get; set; }
}
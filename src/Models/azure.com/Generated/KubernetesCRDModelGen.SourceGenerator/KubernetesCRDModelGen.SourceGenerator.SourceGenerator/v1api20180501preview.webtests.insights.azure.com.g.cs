#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /applicationinsights/resource-manager/Microsoft.Insights/preview/2018-05-01-preview/webTests_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/webtests/{webTestName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20180501previewWebtestList : IKubernetesObject<V1ListMeta>, IItems<V1api20180501previewWebtest>
{
    public const string KubeApiVersion = "v1api20180501preview";
    public const string KubeKind = "WebtestList";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "webtests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20180501preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WebtestList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20180501previewWebtest objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20180501previewWebtest> Items { get; set; }
}

/// <summary>Configuration: An XML configuration specification for a WebTest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestSpecConfiguration
{
    /// <summary>WebTest: The XML specification of a WebTest to run against an application.</summary>
    [JsonPropertyName("WebTest")]
    public string? WebTest { get; set; }
}

/// <summary>Kind: The kind of web test this is, valid choices are ping, multistep, basic, and standard.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20180501previewWebtestSpecKindEnum>))]
public enum V1api20180501previewWebtestSpecKindEnum
{
    [EnumMember(Value = "basic"), JsonStringEnumMemberName("basic")]
    Basic,
    [EnumMember(Value = "multistep"), JsonStringEnumMemberName("multistep")]
    Multistep,
    [EnumMember(Value = "ping"), JsonStringEnumMemberName("ping")]
    Ping,
    [EnumMember(Value = "standard"), JsonStringEnumMemberName("standard")]
    Standard
}

/// <summary>Geo-physical location to run a WebTest from. You must specify one or more locations for the test to run from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestSpecLocations
{
    /// <summary>Id: Location ID for the WebTest to run from.</summary>
    [JsonPropertyName("Id")]
    public string? Id { get; set; }
}

/// <summary>A header to add to the WebTest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestSpecRequestHeaders
{
    /// <summary>Key: The name of the header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value: The value of the header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Request: The collection of request properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestSpecRequest
{
    /// <summary>FollowRedirects: Follow redirects for this web test.</summary>
    [JsonPropertyName("FollowRedirects")]
    public bool? FollowRedirects { get; set; }

    /// <summary>Headers: List of headers and their values to add to the WebTest call.</summary>
    [JsonPropertyName("Headers")]
    public IList<V1api20180501previewWebtestSpecRequestHeaders>? Headers { get; set; }

    /// <summary>HttpVerb: Http verb to use for this web test.</summary>
    [JsonPropertyName("HttpVerb")]
    public string? HttpVerb { get; set; }

    /// <summary>ParseDependentRequests: Parse Dependent request for this WebTest.</summary>
    [JsonPropertyName("ParseDependentRequests")]
    public bool? ParseDependentRequests { get; set; }

    /// <summary>RequestBody: Base64 encoded string body to send with this web test.</summary>
    [JsonPropertyName("RequestBody")]
    public string? RequestBody { get; set; }

    /// <summary>RequestUrl: Url location to test.</summary>
    [JsonPropertyName("RequestUrl")]
    public string? RequestUrl { get; set; }
}

/// <summary>ContentValidation: The collection of content validation properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestSpecValidationRulesContentValidation
{
    /// <summary>ContentMatch: Content to look for in the return of the WebTest.  Must not be null or empty.</summary>
    [JsonPropertyName("ContentMatch")]
    public string? ContentMatch { get; set; }

    /// <summary>IgnoreCase: When set, this value makes the ContentMatch validation case insensitive.</summary>
    [JsonPropertyName("IgnoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// PassIfTextFound: When true, validation will pass if there is a match for the ContentMatch string.  If false, validation
    /// will fail if there is a match
    /// </summary>
    [JsonPropertyName("PassIfTextFound")]
    public bool? PassIfTextFound { get; set; }
}

/// <summary>ValidationRules: The collection of validation rule properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestSpecValidationRules
{
    /// <summary>ContentValidation: The collection of content validation properties</summary>
    [JsonPropertyName("ContentValidation")]
    public V1api20180501previewWebtestSpecValidationRulesContentValidation? ContentValidation { get; set; }

    /// <summary>ExpectedHttpStatusCode: Validate that the WebTest returns the http status code provided.</summary>
    [JsonPropertyName("ExpectedHttpStatusCode")]
    public int? ExpectedHttpStatusCode { get; set; }

    /// <summary>IgnoreHttpsStatusCode: When set, validation will ignore the status code.</summary>
    [JsonPropertyName("IgnoreHttpsStatusCode")]
    public bool? IgnoreHttpsStatusCode { get; set; }

    /// <summary>
    /// SSLCertRemainingLifetimeCheck: A number of days to check still remain before the the existing SSL cert expires.  Value
    /// must be positive and the SSLCheck must be set to true.
    /// </summary>
    [JsonPropertyName("SSLCertRemainingLifetimeCheck")]
    public int? SSLCertRemainingLifetimeCheck { get; set; }

    /// <summary>SSLCheck: Checks to see if the SSL cert is still valid.</summary>
    [JsonPropertyName("SSLCheck")]
    public bool? SSLCheck { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20180501previewWebtestSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20180501previewWebtestSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestSpec
{
    /// <summary>Configuration: An XML configuration specification for a WebTest.</summary>
    [JsonPropertyName("Configuration")]
    public V1api20180501previewWebtestSpecConfiguration? Configuration { get; set; }

    /// <summary>Description: User defined description for this WebTest.</summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>Enabled: Is the test actively being monitored.</summary>
    [JsonPropertyName("Enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Frequency: Interval in seconds between test runs for this WebTest. Default value is 300.</summary>
    [JsonPropertyName("Frequency")]
    public int? Frequency { get; set; }

    /// <summary>Kind: The kind of web test this is, valid choices are ping, multistep, basic, and standard.</summary>
    [JsonPropertyName("Kind")]
    public required V1api20180501previewWebtestSpecKindEnum Kind { get; set; }

    /// <summary>
    /// Locations: A list of where to physically run the tests from to give global coverage for accessibility of your
    /// application.
    /// </summary>
    [JsonPropertyName("Locations")]
    public required IList<V1api20180501previewWebtestSpecLocations> Locations { get; set; }

    /// <summary>Name: User defined name if this WebTest.</summary>
    [JsonPropertyName("Name")]
    public required string Name { get; set; }

    /// <summary>Request: The collection of request properties</summary>
    [JsonPropertyName("Request")]
    public V1api20180501previewWebtestSpecRequest? Request { get; set; }

    /// <summary>RetryEnabled: Allow for retries should this WebTest fail.</summary>
    [JsonPropertyName("RetryEnabled")]
    public bool? RetryEnabled { get; set; }

    /// <summary>SyntheticMonitorId: Unique ID of this WebTest. This is typically the same value as the Name field.</summary>
    [JsonPropertyName("SyntheticMonitorId")]
    public required string SyntheticMonitorId { get; set; }

    /// <summary>Timeout: Seconds until this WebTest will timeout and fail. Default value is 30.</summary>
    [JsonPropertyName("Timeout")]
    public int? Timeout { get; set; }

    /// <summary>ValidationRules: The collection of validation rule properties</summary>
    [JsonPropertyName("ValidationRules")]
    public V1api20180501previewWebtestSpecValidationRules? ValidationRules { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20180501previewWebtestSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20180501previewWebtestSpecOwner Owner { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Configuration: An XML configuration specification for a WebTest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestStatusConfiguration
{
    /// <summary>WebTest: The XML specification of a WebTest to run against an application.</summary>
    [JsonPropertyName("WebTest")]
    public string? WebTest { get; set; }
}

/// <summary>Geo-physical location to run a WebTest from. You must specify one or more locations for the test to run from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestStatusLocations
{
    /// <summary>Id: Location ID for the WebTest to run from.</summary>
    [JsonPropertyName("Id")]
    public string? Id { get; set; }
}

/// <summary>A header to add to the WebTest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestStatusRequestHeaders
{
    /// <summary>Key: The name of the header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value: The value of the header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Request: The collection of request properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestStatusRequest
{
    /// <summary>FollowRedirects: Follow redirects for this web test.</summary>
    [JsonPropertyName("FollowRedirects")]
    public bool? FollowRedirects { get; set; }

    /// <summary>Headers: List of headers and their values to add to the WebTest call.</summary>
    [JsonPropertyName("Headers")]
    public IList<V1api20180501previewWebtestStatusRequestHeaders>? Headers { get; set; }

    /// <summary>HttpVerb: Http verb to use for this web test.</summary>
    [JsonPropertyName("HttpVerb")]
    public string? HttpVerb { get; set; }

    /// <summary>ParseDependentRequests: Parse Dependent request for this WebTest.</summary>
    [JsonPropertyName("ParseDependentRequests")]
    public bool? ParseDependentRequests { get; set; }

    /// <summary>RequestBody: Base64 encoded string body to send with this web test.</summary>
    [JsonPropertyName("RequestBody")]
    public string? RequestBody { get; set; }

    /// <summary>RequestUrl: Url location to test.</summary>
    [JsonPropertyName("RequestUrl")]
    public string? RequestUrl { get; set; }
}

/// <summary>ContentValidation: The collection of content validation properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestStatusValidationRulesContentValidation
{
    /// <summary>ContentMatch: Content to look for in the return of the WebTest.  Must not be null or empty.</summary>
    [JsonPropertyName("ContentMatch")]
    public string? ContentMatch { get; set; }

    /// <summary>IgnoreCase: When set, this value makes the ContentMatch validation case insensitive.</summary>
    [JsonPropertyName("IgnoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// PassIfTextFound: When true, validation will pass if there is a match for the ContentMatch string.  If false, validation
    /// will fail if there is a match
    /// </summary>
    [JsonPropertyName("PassIfTextFound")]
    public bool? PassIfTextFound { get; set; }
}

/// <summary>ValidationRules: The collection of validation rule properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestStatusValidationRules
{
    /// <summary>ContentValidation: The collection of content validation properties</summary>
    [JsonPropertyName("ContentValidation")]
    public V1api20180501previewWebtestStatusValidationRulesContentValidation? ContentValidation { get; set; }

    /// <summary>ExpectedHttpStatusCode: Validate that the WebTest returns the http status code provided.</summary>
    [JsonPropertyName("ExpectedHttpStatusCode")]
    public int? ExpectedHttpStatusCode { get; set; }

    /// <summary>IgnoreHttpsStatusCode: When set, validation will ignore the status code.</summary>
    [JsonPropertyName("IgnoreHttpsStatusCode")]
    public bool? IgnoreHttpsStatusCode { get; set; }

    /// <summary>
    /// SSLCertRemainingLifetimeCheck: A number of days to check still remain before the the existing SSL cert expires.  Value
    /// must be positive and the SSLCheck must be set to true.
    /// </summary>
    [JsonPropertyName("SSLCertRemainingLifetimeCheck")]
    public int? SSLCertRemainingLifetimeCheck { get; set; }

    /// <summary>SSLCheck: Checks to see if the SSL cert is still valid.</summary>
    [JsonPropertyName("SSLCheck")]
    public bool? SSLCheck { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20180501previewWebtestStatus
{
    /// <summary>Configuration: An XML configuration specification for a WebTest.</summary>
    [JsonPropertyName("Configuration")]
    public V1api20180501previewWebtestStatusConfiguration? Configuration { get; set; }

    /// <summary>Description: User defined description for this WebTest.</summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>Enabled: Is the test actively being monitored.</summary>
    [JsonPropertyName("Enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Frequency: Interval in seconds between test runs for this WebTest. Default value is 300.</summary>
    [JsonPropertyName("Frequency")]
    public int? Frequency { get; set; }

    /// <summary>Kind: The kind of web test this is, valid choices are ping, multistep, basic, and standard.</summary>
    [JsonPropertyName("Kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// Locations: A list of where to physically run the tests from to give global coverage for accessibility of your
    /// application.
    /// </summary>
    [JsonPropertyName("Locations")]
    public IList<V1api20180501previewWebtestStatusLocations>? Locations { get; set; }

    /// <summary>Request: The collection of request properties</summary>
    [JsonPropertyName("Request")]
    public V1api20180501previewWebtestStatusRequest? Request { get; set; }

    /// <summary>RetryEnabled: Allow for retries should this WebTest fail.</summary>
    [JsonPropertyName("RetryEnabled")]
    public bool? RetryEnabled { get; set; }

    /// <summary>SyntheticMonitorId: Unique ID of this WebTest. This is typically the same value as the Name field.</summary>
    [JsonPropertyName("SyntheticMonitorId")]
    public string? SyntheticMonitorId { get; set; }

    /// <summary>Timeout: Seconds until this WebTest will timeout and fail. Default value is 30.</summary>
    [JsonPropertyName("Timeout")]
    public int? Timeout { get; set; }

    /// <summary>ValidationRules: The collection of validation rule properties</summary>
    [JsonPropertyName("ValidationRules")]
    public V1api20180501previewWebtestStatusValidationRules? ValidationRules { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20180501previewWebtestStatusConditions>? Conditions { get; set; }

    /// <summary>Id: Azure resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Azure resource name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PropertiesName: User defined name if this WebTest.</summary>
    [JsonPropertyName("properties_name")]
    public string? PropertiesName { get; set; }

    /// <summary>
    /// ProvisioningState: Current state of this component, whether or not is has been provisioned within the resource group it
    /// is defined. Users cannot change this value but are able to read from it. Values will include Succeeded, Deploying,
    /// Canceled, and Failed.
    /// </summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Azure resource type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /applicationinsights/resource-manager/Microsoft.Insights/preview/2018-05-01-preview/webTests_API.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/webtests/{webTestName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20180501previewWebtest : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20180501previewWebtestSpec?>, IStatus<V1api20180501previewWebtestStatus?>
{
    public const string KubeApiVersion = "v1api20180501preview";
    public const string KubeKind = "Webtest";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "webtests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "insights.azure.com/v1api20180501preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Webtest";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20180501previewWebtestSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20180501previewWebtestStatus? Status { get; set; }
}
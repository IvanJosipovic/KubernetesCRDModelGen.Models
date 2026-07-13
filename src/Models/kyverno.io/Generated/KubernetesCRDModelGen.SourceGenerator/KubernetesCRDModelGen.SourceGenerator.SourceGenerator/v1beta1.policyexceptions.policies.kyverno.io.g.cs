#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.policies.kyverno.io;
/// <summary>PolicyException declares resources to be excluded from specified policies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PolicyExceptionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PolicyException>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PolicyExceptionList";
    public const string KubeGroup = "policies.kyverno.io";
    public const string KubePluralName = "policyexceptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "policies.kyverno.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PolicyExceptionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1PolicyException objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1PolicyException> Items { get; set; }
}

/// <summary>MatchCondition represents a condition which must by fulfilled for a request to be sent to a webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyExceptionSpecMatchConditions
{
    /// <summary>
    /// Expression represents the expression which will be evaluated by CEL. Must evaluate to bool.
    /// CEL expressions have access to the contents of the AdmissionRequest and Authorizer, organized into CEL variables:
    /// 
    /// &apos;object&apos; - The object from the incoming request. The value is null for DELETE requests.
    /// &apos;oldObject&apos; - The existing object. The value is null for CREATE requests.
    /// &apos;request&apos; - Attributes of the admission request(/pkg/apis/admission/types.go#AdmissionRequest).
    /// &apos;authorizer&apos; - A CEL Authorizer. May be used to perform authorization checks for the principal (user or service account) of the request.
    ///   See https://pkg.go.dev/k8s.io/apiserver/pkg/cel/library#Authz
    /// &apos;authorizer.requestResource&apos; - A CEL ResourceCheck constructed from the &apos;authorizer&apos; and configured with the
    ///   request resource.
    /// Documentation on CEL: https://kubernetes.io/docs/reference/using-api/cel/
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// Name is an identifier for this match condition, used for strategic merging of MatchConditions,
    /// as well as providing an identifier for logging purposes. A good name should be descriptive of
    /// the associated expression.
    /// Name must be a qualified name consisting of alphanumeric characters, &apos;-&apos;, &apos;_&apos; or &apos;.&apos;, and
    /// must start and end with an alphanumeric character (e.g. &apos;MyName&apos;,  or &apos;my.name&apos;,  or
    /// &apos;123-abc&apos;, regex used for validation is &apos;([A-Za-z0-9][-A-Za-z0-9_.]*)?[A-Za-z0-9]&apos;) with an
    /// optional DNS subdomain prefix and &apos;/&apos; (e.g. &apos;example.com/MyName&apos;)
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyExceptionSpecPolicyRefs
{
    /// <summary>Kind is the kind of the policy</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name is the name of the policy</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ReportResult indicates whether the policy exception should be reported in the policy report
/// as a skip result or pass result. Defaults to &quot;skip&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicyExceptionSpecReportResultEnum>))]
public enum V1beta1PolicyExceptionSpecReportResultEnum
{
    [EnumMember(Value = "skip"), JsonStringEnumMemberName("skip")]
    Skip,
    [EnumMember(Value = "pass"), JsonStringEnumMemberName("pass")]
    Pass
}

/// <summary>Spec declares policy exception behaviors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyExceptionSpec
{
    /// <summary>
    /// AllowedValues specifies values that can be used in CEL expressions to bypass policy checks.
    /// These values can be referenced in CEL expressions via `exceptions.allowedValues`.
    /// </summary>
    [JsonPropertyName("allowedValues")]
    public IList<string>? AllowedValues { get; set; }

    /// <summary>
    /// Images specifies container images to be excluded from policy evaluation.
    /// These excluded images can be referenced in CEL expressions via `exceptions.allowedImages`.
    /// </summary>
    [JsonPropertyName("images")]
    public IList<string>? Images { get; set; }

    /// <summary>MatchConditions is a list of CEL expressions that must be met for a resource to be excluded.</summary>
    [JsonPropertyName("matchConditions")]
    public IList<V1beta1PolicyExceptionSpecMatchConditions>? MatchConditions { get; set; }

    /// <summary>PolicyRefs identifies the policies to which the exception is applied.</summary>
    [JsonPropertyName("policyRefs")]
    public required IList<V1beta1PolicyExceptionSpecPolicyRefs> PolicyRefs { get; set; }

    /// <summary>
    /// ReportResult indicates whether the policy exception should be reported in the policy report
    /// as a skip result or pass result. Defaults to &quot;skip&quot;.
    /// </summary>
    [JsonPropertyName("reportResult")]
    public V1beta1PolicyExceptionSpecReportResultEnum? ReportResult { get; set; }
}

/// <summary>PolicyException declares resources to be excluded from specified policies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PolicyException : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PolicyExceptionSpec>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PolicyException";
    public const string KubeGroup = "policies.kyverno.io";
    public const string KubePluralName = "policyexceptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "policies.kyverno.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PolicyException";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec declares policy exception behaviors.</summary>
    [JsonPropertyName("spec")]
    public required V1beta1PolicyExceptionSpec Spec { get; set; }
}
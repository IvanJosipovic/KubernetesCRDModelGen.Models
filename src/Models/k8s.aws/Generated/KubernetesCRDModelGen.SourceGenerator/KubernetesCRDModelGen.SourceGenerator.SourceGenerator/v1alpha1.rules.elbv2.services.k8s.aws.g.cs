#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elbv2.services.k8s.aws;
/// <summary>Rule is the Schema for the Rules API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RuleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Rule>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RuleList";
    public const string KubeGroup = "elbv2.services.k8s.aws";
    public const string KubePluralName = "rules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elbv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Rule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Rule> Items { get; set; }
}

/// <summary>
/// Request parameters to use when integrating with Amazon Cognito to authenticate
/// users.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecActionsAuthenticateCognitoConfig
{
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    [JsonPropertyName("sessionTimeout")]
    public long? SessionTimeout { get; set; }

    [JsonPropertyName("userPoolARN")]
    public string? UserPoolARN { get; set; }

    [JsonPropertyName("userPoolClientID")]
    public string? UserPoolClientID { get; set; }

    [JsonPropertyName("userPoolDomain")]
    public string? UserPoolDomain { get; set; }
}

/// <summary>
/// Request parameters when using an identity provider (IdP) that is compliant
/// with OpenID Connect (OIDC) to authenticate users.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecActionsAuthenticateOIDCConfig
{
    [JsonPropertyName("authenticationRequestExtraParams")]
    public IDictionary<string, string>? AuthenticationRequestExtraParams { get; set; }

    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    [JsonPropertyName("clientID")]
    public string? ClientID { get; set; }

    [JsonPropertyName("clientSecret")]
    public string? ClientSecret { get; set; }

    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    [JsonPropertyName("onUnauthenticatedRequest")]
    public string? OnUnauthenticatedRequest { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    [JsonPropertyName("sessionCookieName")]
    public string? SessionCookieName { get; set; }

    [JsonPropertyName("sessionTimeout")]
    public long? SessionTimeout { get; set; }

    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    [JsonPropertyName("useExistingClientSecret")]
    public bool? UseExistingClientSecret { get; set; }

    [JsonPropertyName("userInfoEndpoint")]
    public string? UserInfoEndpoint { get; set; }
}

/// <summary>Information about an action that returns a custom HTTP response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecActionsFixedResponseConfig
{
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("messageBody")]
    public string? MessageBody { get; set; }

    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>Information about the target group stickiness for a rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecActionsForwardConfigTargetGroupStickinessConfig
{
    [JsonPropertyName("durationSeconds")]
    public long? DurationSeconds { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecActionsForwardConfigTargetGroupsTargetGroupRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for TargetGroupARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecActionsForwardConfigTargetGroupsTargetGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1RuleSpecActionsForwardConfigTargetGroupsTargetGroupRefFrom? From { get; set; }
}

/// <summary>
/// Information about how traffic will be distributed between multiple target
/// groups in a forward rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecActionsForwardConfigTargetGroups
{
    [JsonPropertyName("targetGroupARN")]
    public string? TargetGroupARN { get; set; }

    /// <summary>Reference field for TargetGroupARN</summary>
    [JsonPropertyName("targetGroupRef")]
    public V1alpha1RuleSpecActionsForwardConfigTargetGroupsTargetGroupRef? TargetGroupRef { get; set; }

    [JsonPropertyName("weight")]
    public long? Weight { get; set; }
}

/// <summary>Information about a forward action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecActionsForwardConfig
{
    /// <summary>Information about the target group stickiness for a rule.</summary>
    [JsonPropertyName("targetGroupStickinessConfig")]
    public V1alpha1RuleSpecActionsForwardConfigTargetGroupStickinessConfig? TargetGroupStickinessConfig { get; set; }

    [JsonPropertyName("targetGroups")]
    public IList<V1alpha1RuleSpecActionsForwardConfigTargetGroups>? TargetGroups { get; set; }
}

/// <summary>
/// Information about a redirect action.
/// 
/// A URI consists of the following components: protocol://hostname:port/path?query.
/// You must modify at least one of the following components to avoid a redirect
/// loop: protocol, hostname, port, or path. Any components that you do not modify
/// retain their original values.
/// 
/// You can reuse URI components using the following reserved keywords:
/// 
///    * #{protocol}
/// 
///    * #{host}
/// 
///    * #{port}
/// 
///    * #{path} (the leading &quot;/&quot; is removed)
/// 
///    * #{query}
/// 
/// For example, you can change the path to &quot;/new/#{path}&quot;, the hostname to &quot;example.#{host}&quot;,
/// or the query to &quot;#{query}&amp;value=xyz&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecActionsRedirectConfig
{
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public string? Port { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("query")]
    public string? Query { get; set; }

    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecActionsTargetGroupRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for TargetGroupARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecActionsTargetGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1RuleSpecActionsTargetGroupRefFrom? From { get; set; }
}

/// <summary>
/// Information about an action.
/// 
/// Each rule must include exactly one of the following types of actions: forward,
/// fixed-response, or redirect, and it must be the last action to be performed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecActions
{
    /// <summary>
    /// Request parameters to use when integrating with Amazon Cognito to authenticate
    /// users.
    /// </summary>
    [JsonPropertyName("authenticateCognitoConfig")]
    public V1alpha1RuleSpecActionsAuthenticateCognitoConfig? AuthenticateCognitoConfig { get; set; }

    /// <summary>
    /// Request parameters when using an identity provider (IdP) that is compliant
    /// with OpenID Connect (OIDC) to authenticate users.
    /// </summary>
    [JsonPropertyName("authenticateOIDCConfig")]
    public V1alpha1RuleSpecActionsAuthenticateOIDCConfig? AuthenticateOIDCConfig { get; set; }

    /// <summary>Information about an action that returns a custom HTTP response.</summary>
    [JsonPropertyName("fixedResponseConfig")]
    public V1alpha1RuleSpecActionsFixedResponseConfig? FixedResponseConfig { get; set; }

    /// <summary>Information about a forward action.</summary>
    [JsonPropertyName("forwardConfig")]
    public V1alpha1RuleSpecActionsForwardConfig? ForwardConfig { get; set; }

    [JsonPropertyName("order")]
    public long? Order { get; set; }

    /// <summary>
    /// Information about a redirect action.
    /// 
    /// A URI consists of the following components: protocol://hostname:port/path?query.
    /// You must modify at least one of the following components to avoid a redirect
    /// loop: protocol, hostname, port, or path. Any components that you do not modify
    /// retain their original values.
    /// 
    /// You can reuse URI components using the following reserved keywords:
    /// 
    ///    * #{protocol}
    /// 
    ///    * #{host}
    /// 
    ///    * #{port}
    /// 
    ///    * #{path} (the leading &quot;/&quot; is removed)
    /// 
    ///    * #{query}
    /// 
    /// For example, you can change the path to &quot;/new/#{path}&quot;, the hostname to &quot;example.#{host}&quot;,
    /// or the query to &quot;#{query}&amp;value=xyz&quot;.
    /// </summary>
    [JsonPropertyName("redirectConfig")]
    public V1alpha1RuleSpecActionsRedirectConfig? RedirectConfig { get; set; }

    [JsonPropertyName("targetGroupARN")]
    public string? TargetGroupARN { get; set; }

    /// <summary>Reference field for TargetGroupARN</summary>
    [JsonPropertyName("targetGroupRef")]
    public V1alpha1RuleSpecActionsTargetGroupRef? TargetGroupRef { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Information about a host header condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecConditionsHostHeaderConfig
{
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Information about an HTTP header condition.
/// 
/// There is a set of standard HTTP header fields. You can also define custom
/// HTTP header fields.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecConditionsHttpHeaderConfig
{
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Information about an HTTP method condition.
/// 
/// HTTP defines a set of request methods, also referred to as HTTP verbs. For
/// more information, see the HTTP Method Registry (https://www.iana.org/assignments/http-methods/http-methods.xhtml).
/// You can also define custom HTTP methods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecConditionsHttpRequestMethodConfig
{
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Information about a path pattern condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecConditionsPathPatternConfig
{
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Information about a key/value pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecConditionsQueryStringConfigValues
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Information about a query string condition.
/// 
/// The query string component of a URI starts after the first &apos;?&apos; character
/// and is terminated by either a &apos;#&apos; character or the end of the URI. A typical
/// query string contains key/value pairs separated by &apos; &amp; &apos; characters. The allowed
/// characters are specified by RFC 3986. Any character can be percentage encoded.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecConditionsQueryStringConfig
{
    [JsonPropertyName("values")]
    public IList<V1alpha1RuleSpecConditionsQueryStringConfigValues>? Values { get; set; }
}

/// <summary>
/// Information about a source IP condition.
/// 
/// You can use this condition to route based on the IP address of the source
/// that connects to the load balancer. If a client is behind a proxy, this is
/// the IP address of the proxy not the IP address of the client.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecConditionsSourceIPConfig
{
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Information about a condition for a rule.
/// 
/// Each rule can optionally include up to one of each of the following conditions:
/// http-request-method, host-header, path-pattern, and source-ip. Each rule
/// can also optionally include one or more of each of the following conditions:
/// http-header and query-string. Note that the value for a condition can&apos;t be
/// empty.
/// 
/// For more information, see Quotas for your Application Load Balancers (https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-limits.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecConditions
{
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>Information about a host header condition.</summary>
    [JsonPropertyName("hostHeaderConfig")]
    public V1alpha1RuleSpecConditionsHostHeaderConfig? HostHeaderConfig { get; set; }

    /// <summary>
    /// Information about an HTTP header condition.
    /// 
    /// There is a set of standard HTTP header fields. You can also define custom
    /// HTTP header fields.
    /// </summary>
    [JsonPropertyName("httpHeaderConfig")]
    public V1alpha1RuleSpecConditionsHttpHeaderConfig? HttpHeaderConfig { get; set; }

    /// <summary>
    /// Information about an HTTP method condition.
    /// 
    /// HTTP defines a set of request methods, also referred to as HTTP verbs. For
    /// more information, see the HTTP Method Registry (https://www.iana.org/assignments/http-methods/http-methods.xhtml).
    /// You can also define custom HTTP methods.
    /// </summary>
    [JsonPropertyName("httpRequestMethodConfig")]
    public V1alpha1RuleSpecConditionsHttpRequestMethodConfig? HttpRequestMethodConfig { get; set; }

    /// <summary>Information about a path pattern condition.</summary>
    [JsonPropertyName("pathPatternConfig")]
    public V1alpha1RuleSpecConditionsPathPatternConfig? PathPatternConfig { get; set; }

    /// <summary>
    /// Information about a query string condition.
    /// 
    /// The query string component of a URI starts after the first &apos;?&apos; character
    /// and is terminated by either a &apos;#&apos; character or the end of the URI. A typical
    /// query string contains key/value pairs separated by &apos; &amp; &apos; characters. The allowed
    /// characters are specified by RFC 3986. Any character can be percentage encoded.
    /// </summary>
    [JsonPropertyName("queryStringConfig")]
    public V1alpha1RuleSpecConditionsQueryStringConfig? QueryStringConfig { get; set; }

    /// <summary>
    /// Information about a source IP condition.
    /// 
    /// You can use this condition to route based on the IP address of the source
    /// that connects to the load balancer. If a client is behind a proxy, this is
    /// the IP address of the proxy not the IP address of the client.
    /// </summary>
    [JsonPropertyName("sourceIPConfig")]
    public V1alpha1RuleSpecConditionsSourceIPConfig? SourceIPConfig { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecListenerRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecListenerRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1RuleSpecListenerRefFrom? From { get; set; }
}

/// <summary>Information about a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// RuleSpec defines the desired state of Rule.
/// 
/// Information about a rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleSpec
{
    /// <summary>The actions.</summary>
    [JsonPropertyName("actions")]
    public required IList<V1alpha1RuleSpecActions> Actions { get; set; }

    /// <summary>The conditions.</summary>
    [JsonPropertyName("conditions")]
    public required IList<V1alpha1RuleSpecConditions> Conditions { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the listener.</summary>
    [JsonPropertyName("listenerARN")]
    public string? ListenerARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("listenerRef")]
    public V1alpha1RuleSpecListenerRef? ListenerRef { get; set; }

    /// <summary>The rule priority. A listener can&apos;t have multiple rules with the same priority.</summary>
    [JsonPropertyName("priority")]
    public required long Priority { get; set; }

    /// <summary>The tags to assign to the rule.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1RuleSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>RuleStatus defines the observed state of Rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1RuleStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RuleStatusConditions>? Conditions { get; set; }

    /// <summary>Indicates whether this is the default rule.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }
}

/// <summary>Rule is the Schema for the Rules API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Rule : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1RuleSpec?>, IStatus<V1alpha1RuleStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Rule";
    public const string KubeGroup = "elbv2.services.k8s.aws";
    public const string KubePluralName = "rules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elbv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Rule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// RuleSpec defines the desired state of Rule.
    /// 
    /// Information about a rule.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1RuleSpec? Spec { get; set; }

    /// <summary>RuleStatus defines the observed state of Rule</summary>
    [JsonPropertyName("status")]
    public V1alpha1RuleStatus? Status { get; set; }
}
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
/// <summary>Listener is the Schema for the Listeners API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ListenerList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Listener>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ListenerList";
    public const string KubeGroup = "elbv2.services.k8s.aws";
    public const string KubePluralName = "listeners";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elbv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ListenerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Listener objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Listener> Items { get; set; }
}

/// <summary>Information about an SSL server certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerSpecCertificates
{
    [JsonPropertyName("certificateARN")]
    public string? CertificateARN { get; set; }

    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }
}

/// <summary>
/// Request parameters to use when integrating with Amazon Cognito to authenticate
/// users.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerSpecDefaultActionsAuthenticateCognitoConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerSpecDefaultActionsAuthenticateOIDCConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerSpecDefaultActionsFixedResponseConfig
{
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("messageBody")]
    public string? MessageBody { get; set; }

    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; set; }
}

/// <summary>Information about the target group stickiness for a rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerSpecDefaultActionsForwardConfigTargetGroupStickinessConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerSpecDefaultActionsForwardConfigTargetGroupsTargetGroupRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for TargetGroupARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerSpecDefaultActionsForwardConfigTargetGroupsTargetGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ListenerSpecDefaultActionsForwardConfigTargetGroupsTargetGroupRefFrom? From { get; set; }
}

/// <summary>
/// Information about how traffic will be distributed between multiple target
/// groups in a forward rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerSpecDefaultActionsForwardConfigTargetGroups
{
    [JsonPropertyName("targetGroupARN")]
    public string? TargetGroupARN { get; set; }

    /// <summary>Reference field for TargetGroupARN</summary>
    [JsonPropertyName("targetGroupRef")]
    public V1alpha1ListenerSpecDefaultActionsForwardConfigTargetGroupsTargetGroupRef? TargetGroupRef { get; set; }

    [JsonPropertyName("weight")]
    public long? Weight { get; set; }
}

/// <summary>Information about a forward action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerSpecDefaultActionsForwardConfig
{
    /// <summary>Information about the target group stickiness for a rule.</summary>
    [JsonPropertyName("targetGroupStickinessConfig")]
    public V1alpha1ListenerSpecDefaultActionsForwardConfigTargetGroupStickinessConfig? TargetGroupStickinessConfig { get; set; }

    [JsonPropertyName("targetGroups")]
    public IList<V1alpha1ListenerSpecDefaultActionsForwardConfigTargetGroups>? TargetGroups { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerSpecDefaultActionsRedirectConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerSpecDefaultActionsTargetGroupRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for TargetGroupARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerSpecDefaultActionsTargetGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ListenerSpecDefaultActionsTargetGroupRefFrom? From { get; set; }
}

/// <summary>
/// Information about an action.
/// 
/// Each rule must include exactly one of the following types of actions: forward,
/// fixed-response, or redirect, and it must be the last action to be performed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerSpecDefaultActions
{
    /// <summary>
    /// Request parameters to use when integrating with Amazon Cognito to authenticate
    /// users.
    /// </summary>
    [JsonPropertyName("authenticateCognitoConfig")]
    public V1alpha1ListenerSpecDefaultActionsAuthenticateCognitoConfig? AuthenticateCognitoConfig { get; set; }

    /// <summary>
    /// Request parameters when using an identity provider (IdP) that is compliant
    /// with OpenID Connect (OIDC) to authenticate users.
    /// </summary>
    [JsonPropertyName("authenticateOIDCConfig")]
    public V1alpha1ListenerSpecDefaultActionsAuthenticateOIDCConfig? AuthenticateOIDCConfig { get; set; }

    /// <summary>Information about an action that returns a custom HTTP response.</summary>
    [JsonPropertyName("fixedResponseConfig")]
    public V1alpha1ListenerSpecDefaultActionsFixedResponseConfig? FixedResponseConfig { get; set; }

    /// <summary>Information about a forward action.</summary>
    [JsonPropertyName("forwardConfig")]
    public V1alpha1ListenerSpecDefaultActionsForwardConfig? ForwardConfig { get; set; }

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
    public V1alpha1ListenerSpecDefaultActionsRedirectConfig? RedirectConfig { get; set; }

    [JsonPropertyName("targetGroupARN")]
    public string? TargetGroupARN { get; set; }

    /// <summary>Reference field for TargetGroupARN</summary>
    [JsonPropertyName("targetGroupRef")]
    public V1alpha1ListenerSpecDefaultActionsTargetGroupRef? TargetGroupRef { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerSpecLoadBalancerRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerSpecLoadBalancerRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ListenerSpecLoadBalancerRefFrom? From { get; set; }
}

/// <summary>The mutual authentication configuration information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerSpecMutualAuthentication
{
    [JsonPropertyName("ignoreClientCertificateExpiry")]
    public bool? IgnoreClientCertificateExpiry { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("trustStoreARN")]
    public string? TrustStoreARN { get; set; }
}

/// <summary>Information about a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// ListenerSpec defines the desired state of Listener.
/// 
/// Information about a listener.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerSpec
{
    /// <summary>
    /// [TLS listeners] The name of the Application-Layer Protocol Negotiation (ALPN)
    /// policy. You can specify one policy name. The following are the possible values:
    /// 
    ///   - HTTP1Only
    /// 
    ///   - HTTP2Only
    /// 
    ///   - HTTP2Optional
    /// 
    ///   - HTTP2Preferred
    /// 
    ///   - None
    /// 
    /// For more information, see ALPN policies (https://docs.aws.amazon.com/elasticloadbalancing/latest/network/create-tls-listener.html#alpn-policies)
    /// in the Network Load Balancers Guide.
    /// </summary>
    [JsonPropertyName("alpnPolicy")]
    public IList<string>? AlpnPolicy { get; set; }

    /// <summary>
    /// [HTTPS and TLS listeners] The default certificate for the listener. You must
    /// provide exactly one certificate. Set CertificateArn to the certificate ARN
    /// but do not set IsDefault.
    /// </summary>
    [JsonPropertyName("certificates")]
    public IList<V1alpha1ListenerSpecCertificates>? Certificates { get; set; }

    /// <summary>The actions for the default rule.</summary>
    [JsonPropertyName("defaultActions")]
    public required IList<V1alpha1ListenerSpecDefaultActions> DefaultActions { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the load balancer.</summary>
    [JsonPropertyName("loadBalancerARN")]
    public string? LoadBalancerARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("loadBalancerRef")]
    public V1alpha1ListenerSpecLoadBalancerRef? LoadBalancerRef { get; set; }

    /// <summary>The mutual authentication configuration information.</summary>
    [JsonPropertyName("mutualAuthentication")]
    public V1alpha1ListenerSpecMutualAuthentication? MutualAuthentication { get; set; }

    /// <summary>
    /// The port on which the load balancer is listening. You can&apos;t specify a port
    /// for a Gateway Load Balancer.
    /// </summary>
    [JsonPropertyName("port")]
    public long? Port { get; set; }

    /// <summary>
    /// The protocol for connections from clients to the load balancer. For Application
    /// Load Balancers, the supported protocols are HTTP and HTTPS. For Network Load
    /// Balancers, the supported protocols are TCP, TLS, UDP, and TCP_UDP. You can’t
    /// specify the UDP or TCP_UDP protocol if dual-stack mode is enabled. You can&apos;t
    /// specify a protocol for a Gateway Load Balancer.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>
    /// [HTTPS and TLS listeners] The security policy that defines which protocols
    /// and ciphers are supported.
    /// 
    /// For more information, see Security policies (https://docs.aws.amazon.com/elasticloadbalancing/latest/application/create-https-listener.html#describe-ssl-policies)
    /// in the Application Load Balancers Guide and Security policies (https://docs.aws.amazon.com/elasticloadbalancing/latest/network/create-tls-listener.html#describe-ssl-policies)
    /// in the Network Load Balancers Guide.
    /// </summary>
    [JsonPropertyName("sslPolicy")]
    public string? SslPolicy { get; set; }

    /// <summary>The tags to assign to the listener.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ListenerSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerStatusAckResourceMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerStatusConditions
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

/// <summary>ListenerStatus defines the observed state of Listener</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ListenerStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ListenerStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ListenerStatusConditions>? Conditions { get; set; }
}

/// <summary>Listener is the Schema for the Listeners API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Listener : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ListenerSpec?>, IStatus<V1alpha1ListenerStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Listener";
    public const string KubeGroup = "elbv2.services.k8s.aws";
    public const string KubePluralName = "listeners";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elbv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Listener";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ListenerSpec defines the desired state of Listener.
    /// 
    /// Information about a listener.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ListenerSpec? Spec { get; set; }

    /// <summary>ListenerStatus defines the observed state of Listener</summary>
    [JsonPropertyName("status")]
    public V1alpha1ListenerStatus? Status { get; set; }
}
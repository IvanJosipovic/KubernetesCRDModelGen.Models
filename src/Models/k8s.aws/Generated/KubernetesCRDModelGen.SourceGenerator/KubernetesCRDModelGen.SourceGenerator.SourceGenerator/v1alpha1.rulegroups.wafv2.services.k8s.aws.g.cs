#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.wafv2.services.k8s.aws;
/// <summary>RuleGroup is the Schema for the RuleGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RuleGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1RuleGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RuleGroupList";
    public const string KubeGroup = "wafv2.services.k8s.aws";
    public const string KubePluralName = "rulegroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "wafv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RuleGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1RuleGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1RuleGroup> Items { get; set; }
}

/// <summary>
/// The response body to use in a custom response to a web request. This is referenced
/// by key from CustomResponse CustomResponseBodyKey.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecCustomResponseBodies
{
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }
}

/// <summary>
/// A custom header for custom request and response handling. This is used in
/// CustomResponse and CustomRequestHandling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesActionAllowCustomRequestHandlingInsertHeaders
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Custom request handling behavior that inserts custom headers into a web request.
/// You can add custom request handling for WAF to use when the rule action doesn&apos;t
/// block the request. For example, CaptchaAction for requests with valid t okens,
/// and AllowAction.
/// 
/// For information about customizing web requests and responses, see Customizing
/// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesActionAllowCustomRequestHandling
{
    [JsonPropertyName("insertHeaders")]
    public IList<V1alpha1RuleGroupSpecRulesActionAllowCustomRequestHandlingInsertHeaders>? InsertHeaders { get; set; }
}

/// <summary>
/// Specifies that WAF should allow the request and optionally defines additional
/// custom handling for the request.
/// 
/// This is used in the context of other settings, for example to specify values
/// for RuleAction and web ACL DefaultAction.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesActionAllow
{
    /// <summary>
    /// Custom request handling behavior that inserts custom headers into a web request.
    /// You can add custom request handling for WAF to use when the rule action doesn&apos;t
    /// block the request. For example, CaptchaAction for requests with valid t okens,
    /// and AllowAction.
    /// 
    /// For information about customizing web requests and responses, see Customizing
    /// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("customRequestHandling")]
    public V1alpha1RuleGroupSpecRulesActionAllowCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// A custom header for custom request and response handling. This is used in
/// CustomResponse and CustomRequestHandling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesActionBlockCustomResponseResponseHeaders
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// A custom response to send to the client. You can define a custom response
/// for rule actions and default web ACL actions that are set to BlockAction.
/// 
/// For information about customizing web requests and responses, see Customizing
/// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesActionBlockCustomResponse
{
    [JsonPropertyName("customResponseBodyKey")]
    public string? CustomResponseBodyKey { get; set; }

    [JsonPropertyName("responseCode")]
    public long? ResponseCode { get; set; }

    [JsonPropertyName("responseHeaders")]
    public IList<V1alpha1RuleGroupSpecRulesActionBlockCustomResponseResponseHeaders>? ResponseHeaders { get; set; }
}

/// <summary>
/// Specifies that WAF should block the request and optionally defines additional
/// custom handling for the response to the web request.
/// 
/// This is used in the context of other settings, for example to specify values
/// for RuleAction and web ACL DefaultAction.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesActionBlock
{
    /// <summary>
    /// A custom response to send to the client. You can define a custom response
    /// for rule actions and default web ACL actions that are set to BlockAction.
    /// 
    /// For information about customizing web requests and responses, see Customizing
    /// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("customResponse")]
    public V1alpha1RuleGroupSpecRulesActionBlockCustomResponse? CustomResponse { get; set; }
}

/// <summary>
/// A custom header for custom request and response handling. This is used in
/// CustomResponse and CustomRequestHandling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesActionCaptchaCustomRequestHandlingInsertHeaders
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Custom request handling behavior that inserts custom headers into a web request.
/// You can add custom request handling for WAF to use when the rule action doesn&apos;t
/// block the request. For example, CaptchaAction for requests with valid t okens,
/// and AllowAction.
/// 
/// For information about customizing web requests and responses, see Customizing
/// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesActionCaptchaCustomRequestHandling
{
    [JsonPropertyName("insertHeaders")]
    public IList<V1alpha1RuleGroupSpecRulesActionCaptchaCustomRequestHandlingInsertHeaders>? InsertHeaders { get; set; }
}

/// <summary>
/// Specifies that WAF should run a CAPTCHA check against the request:
/// 
///    * If the request includes a valid, unexpired CAPTCHA token, WAF applies
///    any custom request handling and labels that you&apos;ve configured and then
///    allows the web request inspection to proceed to the next rule, similar
///    to a CountAction.
/// 
///    * If the request doesn&apos;t include a valid, unexpired token, WAF discontinues
///    the web ACL evaluation of the request and blocks it from going to its
///    intended destination. WAF generates a response that it sends back to the
///    client, which includes the following: The header x-amzn-waf-action with
///    a value of captcha. The HTTP status code 405 Method Not Allowed. If the
///    request contains an Accept header with a value of text/html, the response
///    includes a CAPTCHA JavaScript page interstitial.
/// 
/// You can configure the expiration time in the CaptchaConfig ImmunityTimeProperty
/// setting at the rule and web ACL level. The rule setting overrides the web
/// ACL setting.
/// 
/// This action option is available for rules. It isn&apos;t available for web ACL
/// default actions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesActionCaptcha
{
    /// <summary>
    /// Custom request handling behavior that inserts custom headers into a web request.
    /// You can add custom request handling for WAF to use when the rule action doesn&apos;t
    /// block the request. For example, CaptchaAction for requests with valid t okens,
    /// and AllowAction.
    /// 
    /// For information about customizing web requests and responses, see Customizing
    /// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("customRequestHandling")]
    public V1alpha1RuleGroupSpecRulesActionCaptchaCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// A custom header for custom request and response handling. This is used in
/// CustomResponse and CustomRequestHandling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesActionChallengeCustomRequestHandlingInsertHeaders
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Custom request handling behavior that inserts custom headers into a web request.
/// You can add custom request handling for WAF to use when the rule action doesn&apos;t
/// block the request. For example, CaptchaAction for requests with valid t okens,
/// and AllowAction.
/// 
/// For information about customizing web requests and responses, see Customizing
/// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesActionChallengeCustomRequestHandling
{
    [JsonPropertyName("insertHeaders")]
    public IList<V1alpha1RuleGroupSpecRulesActionChallengeCustomRequestHandlingInsertHeaders>? InsertHeaders { get; set; }
}

/// <summary>
/// Specifies that WAF should run a Challenge check against the request to verify
/// that the request is coming from a legitimate client session:
/// 
///    * If the request includes a valid, unexpired challenge token, WAF applies
///    any custom request handling and labels that you&apos;ve configured and then
///    allows the web request inspection to proceed to the next rule, similar
///    to a CountAction.
/// 
///    * If the request doesn&apos;t include a valid, unexpired challenge token, WAF
///    discontinues the web ACL evaluation of the request and blocks it from
///    going to its intended destination. WAF then generates a challenge response
///    that it sends back to the client, which includes the following: The header
///    x-amzn-waf-action with a value of challenge. The HTTP status code 202
///    Request Accepted. If the request contains an Accept header with a value
///    of text/html, the response includes a JavaScript page interstitial with
///    a challenge script. Challenges run silent browser interrogations in the
///    background, and don&apos;t generally affect the end user experience. A challenge
///    enforces token acquisition using an interstitial JavaScript challenge
///    that inspects the client session for legitimate behavior. The challenge
///    blocks bots or at least increases the cost of operating sophisticated
///    bots. After the client session successfully responds to the challenge,
///    it receives a new token from WAF, which the challenge script uses to resubmit
///    the original request.
/// 
/// You can configure the expiration time in the ChallengeConfig ImmunityTimeProperty
/// setting at the rule and web ACL level. The rule setting overrides the web
/// ACL setting.
/// 
/// This action option is available for rules. It isn&apos;t available for web ACL
/// default actions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesActionChallenge
{
    /// <summary>
    /// Custom request handling behavior that inserts custom headers into a web request.
    /// You can add custom request handling for WAF to use when the rule action doesn&apos;t
    /// block the request. For example, CaptchaAction for requests with valid t okens,
    /// and AllowAction.
    /// 
    /// For information about customizing web requests and responses, see Customizing
    /// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("customRequestHandling")]
    public V1alpha1RuleGroupSpecRulesActionChallengeCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// A custom header for custom request and response handling. This is used in
/// CustomResponse and CustomRequestHandling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesActionCountCustomRequestHandlingInsertHeaders
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Custom request handling behavior that inserts custom headers into a web request.
/// You can add custom request handling for WAF to use when the rule action doesn&apos;t
/// block the request. For example, CaptchaAction for requests with valid t okens,
/// and AllowAction.
/// 
/// For information about customizing web requests and responses, see Customizing
/// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesActionCountCustomRequestHandling
{
    [JsonPropertyName("insertHeaders")]
    public IList<V1alpha1RuleGroupSpecRulesActionCountCustomRequestHandlingInsertHeaders>? InsertHeaders { get; set; }
}

/// <summary>
/// Specifies that WAF should count the request. Optionally defines additional
/// custom handling for the request.
/// 
/// This is used in the context of other settings, for example to specify values
/// for RuleAction and web ACL DefaultAction.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesActionCount
{
    /// <summary>
    /// Custom request handling behavior that inserts custom headers into a web request.
    /// You can add custom request handling for WAF to use when the rule action doesn&apos;t
    /// block the request. For example, CaptchaAction for requests with valid t okens,
    /// and AllowAction.
    /// 
    /// For information about customizing web requests and responses, see Customizing
    /// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("customRequestHandling")]
    public V1alpha1RuleGroupSpecRulesActionCountCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// The action that WAF should take on a web request when it matches a rule&apos;s
/// statement. Settings at the web ACL level can override the rule action setting.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesAction
{
    /// <summary>
    /// Specifies that WAF should allow the request and optionally defines additional
    /// custom handling for the request.
    /// 
    /// This is used in the context of other settings, for example to specify values
    /// for RuleAction and web ACL DefaultAction.
    /// </summary>
    [JsonPropertyName("allow")]
    public V1alpha1RuleGroupSpecRulesActionAllow? Allow { get; set; }

    /// <summary>
    /// Specifies that WAF should block the request and optionally defines additional
    /// custom handling for the response to the web request.
    /// 
    /// This is used in the context of other settings, for example to specify values
    /// for RuleAction and web ACL DefaultAction.
    /// </summary>
    [JsonPropertyName("block")]
    public V1alpha1RuleGroupSpecRulesActionBlock? Block { get; set; }

    /// <summary>
    /// Specifies that WAF should run a CAPTCHA check against the request:
    /// 
    ///    * If the request includes a valid, unexpired CAPTCHA token, WAF applies
    ///    any custom request handling and labels that you&apos;ve configured and then
    ///    allows the web request inspection to proceed to the next rule, similar
    ///    to a CountAction.
    /// 
    ///    * If the request doesn&apos;t include a valid, unexpired token, WAF discontinues
    ///    the web ACL evaluation of the request and blocks it from going to its
    ///    intended destination. WAF generates a response that it sends back to the
    ///    client, which includes the following: The header x-amzn-waf-action with
    ///    a value of captcha. The HTTP status code 405 Method Not Allowed. If the
    ///    request contains an Accept header with a value of text/html, the response
    ///    includes a CAPTCHA JavaScript page interstitial.
    /// 
    /// You can configure the expiration time in the CaptchaConfig ImmunityTimeProperty
    /// setting at the rule and web ACL level. The rule setting overrides the web
    /// ACL setting.
    /// 
    /// This action option is available for rules. It isn&apos;t available for web ACL
    /// default actions.
    /// </summary>
    [JsonPropertyName("captcha")]
    public V1alpha1RuleGroupSpecRulesActionCaptcha? Captcha { get; set; }

    /// <summary>
    /// Specifies that WAF should run a Challenge check against the request to verify
    /// that the request is coming from a legitimate client session:
    /// 
    ///    * If the request includes a valid, unexpired challenge token, WAF applies
    ///    any custom request handling and labels that you&apos;ve configured and then
    ///    allows the web request inspection to proceed to the next rule, similar
    ///    to a CountAction.
    /// 
    ///    * If the request doesn&apos;t include a valid, unexpired challenge token, WAF
    ///    discontinues the web ACL evaluation of the request and blocks it from
    ///    going to its intended destination. WAF then generates a challenge response
    ///    that it sends back to the client, which includes the following: The header
    ///    x-amzn-waf-action with a value of challenge. The HTTP status code 202
    ///    Request Accepted. If the request contains an Accept header with a value
    ///    of text/html, the response includes a JavaScript page interstitial with
    ///    a challenge script. Challenges run silent browser interrogations in the
    ///    background, and don&apos;t generally affect the end user experience. A challenge
    ///    enforces token acquisition using an interstitial JavaScript challenge
    ///    that inspects the client session for legitimate behavior. The challenge
    ///    blocks bots or at least increases the cost of operating sophisticated
    ///    bots. After the client session successfully responds to the challenge,
    ///    it receives a new token from WAF, which the challenge script uses to resubmit
    ///    the original request.
    /// 
    /// You can configure the expiration time in the ChallengeConfig ImmunityTimeProperty
    /// setting at the rule and web ACL level. The rule setting overrides the web
    /// ACL setting.
    /// 
    /// This action option is available for rules. It isn&apos;t available for web ACL
    /// default actions.
    /// </summary>
    [JsonPropertyName("challenge")]
    public V1alpha1RuleGroupSpecRulesActionChallenge? Challenge { get; set; }

    /// <summary>
    /// Specifies that WAF should count the request. Optionally defines additional
    /// custom handling for the request.
    /// 
    /// This is used in the context of other settings, for example to specify values
    /// for RuleAction and web ACL DefaultAction.
    /// </summary>
    [JsonPropertyName("count")]
    public V1alpha1RuleGroupSpecRulesActionCount? Count { get; set; }
}

/// <summary>
/// Used for CAPTCHA and challenge token settings. Determines how long a CAPTCHA
/// or challenge timestamp remains valid after WAF updates it for a successful
/// CAPTCHA or challenge response.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesCaptchaConfigImmunityTimeProperty
{
    [JsonPropertyName("immunityTime")]
    public long? ImmunityTime { get; set; }
}

/// <summary>
/// Specifies how WAF should handle CAPTCHA evaluations. This is available at
/// the web ACL level and in each rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesCaptchaConfig
{
    /// <summary>
    /// Used for CAPTCHA and challenge token settings. Determines how long a CAPTCHA
    /// or challenge timestamp remains valid after WAF updates it for a successful
    /// CAPTCHA or challenge response.
    /// </summary>
    [JsonPropertyName("immunityTimeProperty")]
    public V1alpha1RuleGroupSpecRulesCaptchaConfigImmunityTimeProperty? ImmunityTimeProperty { get; set; }
}

/// <summary>
/// Used for CAPTCHA and challenge token settings. Determines how long a CAPTCHA
/// or challenge timestamp remains valid after WAF updates it for a successful
/// CAPTCHA or challenge response.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesChallengeConfigImmunityTimeProperty
{
    [JsonPropertyName("immunityTime")]
    public long? ImmunityTime { get; set; }
}

/// <summary>
/// Specifies how WAF should handle Challenge evaluations. This is available
/// at the web ACL level and in each rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesChallengeConfig
{
    /// <summary>
    /// Used for CAPTCHA and challenge token settings. Determines how long a CAPTCHA
    /// or challenge timestamp remains valid after WAF updates it for a successful
    /// CAPTCHA or challenge response.
    /// </summary>
    [JsonPropertyName("immunityTimeProperty")]
    public V1alpha1RuleGroupSpecRulesChallengeConfigImmunityTimeProperty? ImmunityTimeProperty { get; set; }
}

/// <summary>
/// A custom header for custom request and response handling. This is used in
/// CustomResponse and CustomRequestHandling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesOverrideActionCountCustomRequestHandlingInsertHeaders
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Custom request handling behavior that inserts custom headers into a web request.
/// You can add custom request handling for WAF to use when the rule action doesn&apos;t
/// block the request. For example, CaptchaAction for requests with valid t okens,
/// and AllowAction.
/// 
/// For information about customizing web requests and responses, see Customizing
/// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesOverrideActionCountCustomRequestHandling
{
    [JsonPropertyName("insertHeaders")]
    public IList<V1alpha1RuleGroupSpecRulesOverrideActionCountCustomRequestHandlingInsertHeaders>? InsertHeaders { get; set; }
}

/// <summary>
/// Specifies that WAF should count the request. Optionally defines additional
/// custom handling for the request.
/// 
/// This is used in the context of other settings, for example to specify values
/// for RuleAction and web ACL DefaultAction.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesOverrideActionCount
{
    /// <summary>
    /// Custom request handling behavior that inserts custom headers into a web request.
    /// You can add custom request handling for WAF to use when the rule action doesn&apos;t
    /// block the request. For example, CaptchaAction for requests with valid t okens,
    /// and AllowAction.
    /// 
    /// For information about customizing web requests and responses, see Customizing
    /// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("customRequestHandling")]
    public V1alpha1RuleGroupSpecRulesOverrideActionCountCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// The action to use in the place of the action that results from the rule group
/// evaluation. Set the override action to none to leave the result of the rule
/// group alone. Set it to count to override the result to count only.
/// 
/// You can only use this for rule statements that reference a rule group, like
/// RuleGroupReferenceStatement and ManagedRuleGroupStatement.
/// 
/// This option is usually set to none. It does not affect how the rules in the
/// rule group are evaluated. If you want the rules in the rule group to only
/// count matches, do not use this and instead use the rule action override option,
/// with Count action, in your rule group reference statement settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesOverrideAction
{
    /// <summary>
    /// Specifies that WAF should count the request. Optionally defines additional
    /// custom handling for the request.
    /// 
    /// This is used in the context of other settings, for example to specify values
    /// for RuleAction and web ACL DefaultAction.
    /// </summary>
    [JsonPropertyName("count")]
    public V1alpha1RuleGroupSpecRulesOverrideActionCount? Count { get; set; }

    /// <summary>
    /// Specifies that WAF should do nothing. This is used for the OverrideAction
    /// setting on a Rule when the rule uses a rule group reference statement.
    /// 
    /// This is used in the context of other settings, for example to specify values
    /// for RuleAction and web ACL DefaultAction.
    /// 
    /// JSON specification: &quot;None&quot;: {}
    /// </summary>
    [JsonPropertyName("none")]
    public IDictionary<string, string>? None { get; set; }
}

/// <summary>
/// A single label container. This is used as an element of a label array in
/// multiple contexts, for example, in RuleLabels inside a Rule and in Labels
/// inside a SampledHTTPRequest.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesRuleLabels
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Inspect the body of the web request. The body immediately follows the request
/// headers.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchBody
{
    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// The filter to use to identify the subset of cookies to inspect in a web request.
/// 
/// You must specify exactly one setting: either All, IncludedCookies, or ExcludedCookies.
/// 
/// Example JSON: &quot;MatchPattern&quot;: { &quot;IncludedCookies&quot;: [ &quot;session-id-time&quot;, &quot;session-id&quot;
/// ] }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchCookiesMatchPattern
{
    /// <summary>
    /// Inspect all of the elements that WAF has parsed and extracted from the web
    /// request component that you&apos;ve identified in your FieldToMatch specifications.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;All&quot;: {}
    /// </summary>
    [JsonPropertyName("all")]
    public IDictionary<string, string>? All { get; set; }

    [JsonPropertyName("excludedCookies")]
    public IList<string>? ExcludedCookies { get; set; }

    [JsonPropertyName("includedCookies")]
    public IList<string>? IncludedCookies { get; set; }
}

/// <summary>
/// Inspect the cookies in the web request. You can specify the parts of the
/// cookies to inspect and you can narrow the set of cookies to inspect by including
/// or excluding specific keys.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Example JSON: &quot;Cookies&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
/// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchCookies
{
    /// <summary>
    /// The filter to use to identify the subset of cookies to inspect in a web request.
    /// 
    /// You must specify exactly one setting: either All, IncludedCookies, or ExcludedCookies.
    /// 
    /// Example JSON: &quot;MatchPattern&quot;: { &quot;IncludedCookies&quot;: [ &quot;session-id-time&quot;, &quot;session-id&quot;
    /// ] }
    /// </summary>
    [JsonPropertyName("matchPattern")]
    public V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchCookiesMatchPattern? MatchPattern { get; set; }

    [JsonPropertyName("matchScope")]
    public string? MatchScope { get; set; }

    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// Inspect a string containing the list of the request&apos;s header names, ordered
/// as they appear in the web requestthat WAF receives for inspection. WAF generates
/// the string and then uses that as the field to match component in its inspection.
/// WAF separates the header names in the string using colons and no added spaces,
/// for example host:user-agent:accept:authorization:referer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchHeaderOrder
{
    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// The filter to use to identify the subset of headers to inspect in a web request.
/// 
/// You must specify exactly one setting: either All, IncludedHeaders, or ExcludedHeaders.
/// 
/// Example JSON: &quot;MatchPattern&quot;: { &quot;ExcludedHeaders&quot;: [ &quot;KeyToExclude1&quot;, &quot;KeyToExclude2&quot;
/// ] }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchHeadersMatchPattern
{
    /// <summary>
    /// Inspect all of the elements that WAF has parsed and extracted from the web
    /// request component that you&apos;ve identified in your FieldToMatch specifications.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;All&quot;: {}
    /// </summary>
    [JsonPropertyName("all")]
    public IDictionary<string, string>? All { get; set; }

    [JsonPropertyName("excludedHeaders")]
    public IList<string>? ExcludedHeaders { get; set; }

    [JsonPropertyName("includedHeaders")]
    public IList<string>? IncludedHeaders { get; set; }
}

/// <summary>
/// Inspect all headers in the web request. You can specify the parts of the
/// headers to inspect and you can narrow the set of headers to inspect by including
/// or excluding specific keys.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// If you want to inspect just the value of a single header, use the SingleHeader
/// FieldToMatch setting instead.
/// 
/// Example JSON: &quot;Headers&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
/// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchHeaders
{
    /// <summary>
    /// The filter to use to identify the subset of headers to inspect in a web request.
    /// 
    /// You must specify exactly one setting: either All, IncludedHeaders, or ExcludedHeaders.
    /// 
    /// Example JSON: &quot;MatchPattern&quot;: { &quot;ExcludedHeaders&quot;: [ &quot;KeyToExclude1&quot;, &quot;KeyToExclude2&quot;
    /// ] }
    /// </summary>
    [JsonPropertyName("matchPattern")]
    public V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchHeadersMatchPattern? MatchPattern { get; set; }

    [JsonPropertyName("matchScope")]
    public string? MatchScope { get; set; }

    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// Available for use with Amazon CloudFront distributions and Application Load
/// Balancers. Match against the request&apos;s JA3 fingerprint. The JA3 fingerprint
/// is a 32-character hash derived from the TLS Client Hello of an incoming request.
/// This fingerprint serves as a unique identifier for the client&apos;s TLS configuration.
/// WAF calculates and logs this fingerprint for each request that has enough
/// TLS Client Hello information for the calculation. Almost all web requests
/// include this information.
/// 
/// You can use this choice only with a string match ByteMatchStatement with
/// the PositionalConstraint set to EXACTLY.
/// 
/// You can obtain the JA3 fingerprint for client requests from the web ACL logs.
/// If WAF is able to calculate the fingerprint, it includes it in the logs.
/// For information about the logging fields, see Log fields (https://docs.aws.amazon.com/waf/latest/developerguide/logging-fields.html)
/// in the WAF Developer Guide.
/// 
/// Provide the JA3 fingerprint string from the logs in your string match statement
/// specification, to match with any future requests that have the same TLS configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchJa3Fingerprint
{
    [JsonPropertyName("fallbackBehavior")]
    public string? FallbackBehavior { get; set; }
}

/// <summary>
/// The patterns to look for in the JSON body. WAF inspects the results of these
/// pattern matches against the rule inspection criteria. This is used with the
/// FieldToMatch option JsonBody.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchJsonBodyMatchPattern
{
    /// <summary>
    /// Inspect all of the elements that WAF has parsed and extracted from the web
    /// request component that you&apos;ve identified in your FieldToMatch specifications.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;All&quot;: {}
    /// </summary>
    [JsonPropertyName("all")]
    public IDictionary<string, string>? All { get; set; }

    [JsonPropertyName("includedPaths")]
    public IList<string>? IncludedPaths { get; set; }
}

/// <summary>
/// Inspect the body of the web request as JSON. The body immediately follows
/// the request headers.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Use the specifications in this object to indicate which parts of the JSON
/// body to inspect using the rule&apos;s inspection criteria. WAF inspects only the
/// parts of the JSON that result from the matches that you indicate.
/// 
/// Example JSON: &quot;JsonBody&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;:
/// &quot;ALL&quot; }
/// 
/// For additional information about this request component option, see JSON
/// body (https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-fields-list.html#waf-rule-statement-request-component-json-body)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchJsonBody
{
    [JsonPropertyName("invalidFallbackBehavior")]
    public string? InvalidFallbackBehavior { get; set; }

    /// <summary>
    /// The patterns to look for in the JSON body. WAF inspects the results of these
    /// pattern matches against the rule inspection criteria. This is used with the
    /// FieldToMatch option JsonBody.
    /// </summary>
    [JsonPropertyName("matchPattern")]
    public V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchJsonBodyMatchPattern? MatchPattern { get; set; }

    [JsonPropertyName("matchScope")]
    public string? MatchScope { get; set; }

    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// Inspect one of the headers in the web request, identified by name, for example,
/// User-Agent or Referer. The name isn&apos;t case sensitive.
/// 
/// You can filter and inspect all headers with the FieldToMatch setting Headers.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Example JSON: &quot;SingleHeader&quot;: { &quot;Name&quot;: &quot;haystack&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchSingleHeader
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Inspect one query argument in the web request, identified by name, for example
/// UserName or SalesRegion. The name isn&apos;t case sensitive.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Example JSON: &quot;SingleQueryArgument&quot;: { &quot;Name&quot;: &quot;myArgument&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchSingleQueryArgument
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Specifies a web request component to be used in a rule match statement or
/// in a logging configuration.
/// 
///    * In a rule statement, this is the part of the web request that you want
///    WAF to inspect. Include the single FieldToMatch type that you want to
///    inspect, with additional specifications as needed, according to the type.
///    You specify a single request component in FieldToMatch for each rule statement
///    that requires it. To inspect more than one component of the web request,
///    create a separate rule statement for each component. Example JSON for
///    a QueryString field to match: &quot;FieldToMatch&quot;: { &quot;QueryString&quot;: {} } Example
///    JSON for a Method field to match specification: &quot;FieldToMatch&quot;: { &quot;Method&quot;:
///    { &quot;Name&quot;: &quot;DELETE&quot; } }
/// 
///    * In a logging configuration, this is used in the RedactedFields property
///    to specify a field to redact from the logging records. For this use case,
///    note the following: Even though all FieldToMatch settings are available,
///    the only valid settings for field redaction are UriPath, QueryString,
///    SingleHeader, and Method. In this documentation, the descriptions of the
///    individual fields talk about specifying the web request component to inspect,
///    but for field redaction, you are specifying the component type to redact
///    from the logs. If you have request sampling enabled, the redacted fields
///    configuration for logging has no impact on sampling. The only way to exclude
///    fields from request sampling is by disabling sampling in the web ACL visibility
///    configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatch
{
    /// <summary>
    /// Inspect all query arguments of the web request.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;AllQueryArguments&quot;: {}
    /// </summary>
    [JsonPropertyName("allQueryArguments")]
    public IDictionary<string, string>? AllQueryArguments { get; set; }

    /// <summary>
    /// Inspect the body of the web request. The body immediately follows the request
    /// headers.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// </summary>
    [JsonPropertyName("body")]
    public V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchBody? Body { get; set; }

    /// <summary>
    /// Inspect the cookies in the web request. You can specify the parts of the
    /// cookies to inspect and you can narrow the set of cookies to inspect by including
    /// or excluding specific keys.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Example JSON: &quot;Cookies&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
    /// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
    /// </summary>
    [JsonPropertyName("cookies")]
    public V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchCookies? Cookies { get; set; }

    /// <summary>
    /// Inspect a string containing the list of the request&apos;s header names, ordered
    /// as they appear in the web requestthat WAF receives for inspection. WAF generates
    /// the string and then uses that as the field to match component in its inspection.
    /// WAF separates the header names in the string using colons and no added spaces,
    /// for example host:user-agent:accept:authorization:referer.
    /// </summary>
    [JsonPropertyName("headerOrder")]
    public V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchHeaderOrder? HeaderOrder { get; set; }

    /// <summary>
    /// Inspect all headers in the web request. You can specify the parts of the
    /// headers to inspect and you can narrow the set of headers to inspect by including
    /// or excluding specific keys.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// If you want to inspect just the value of a single header, use the SingleHeader
    /// FieldToMatch setting instead.
    /// 
    /// Example JSON: &quot;Headers&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
    /// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
    /// </summary>
    [JsonPropertyName("headers")]
    public V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchHeaders? Headers { get; set; }

    /// <summary>
    /// Available for use with Amazon CloudFront distributions and Application Load
    /// Balancers. Match against the request&apos;s JA3 fingerprint. The JA3 fingerprint
    /// is a 32-character hash derived from the TLS Client Hello of an incoming request.
    /// This fingerprint serves as a unique identifier for the client&apos;s TLS configuration.
    /// WAF calculates and logs this fingerprint for each request that has enough
    /// TLS Client Hello information for the calculation. Almost all web requests
    /// include this information.
    /// 
    /// You can use this choice only with a string match ByteMatchStatement with
    /// the PositionalConstraint set to EXACTLY.
    /// 
    /// You can obtain the JA3 fingerprint for client requests from the web ACL logs.
    /// If WAF is able to calculate the fingerprint, it includes it in the logs.
    /// For information about the logging fields, see Log fields (https://docs.aws.amazon.com/waf/latest/developerguide/logging-fields.html)
    /// in the WAF Developer Guide.
    /// 
    /// Provide the JA3 fingerprint string from the logs in your string match statement
    /// specification, to match with any future requests that have the same TLS configuration.
    /// </summary>
    [JsonPropertyName("ja3Fingerprint")]
    public V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchJa3Fingerprint? Ja3Fingerprint { get; set; }

    /// <summary>
    /// Inspect the body of the web request as JSON. The body immediately follows
    /// the request headers.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Use the specifications in this object to indicate which parts of the JSON
    /// body to inspect using the rule&apos;s inspection criteria. WAF inspects only the
    /// parts of the JSON that result from the matches that you indicate.
    /// 
    /// Example JSON: &quot;JsonBody&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;:
    /// &quot;ALL&quot; }
    /// 
    /// For additional information about this request component option, see JSON
    /// body (https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-fields-list.html#waf-rule-statement-request-component-json-body)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("jsonBody")]
    public V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchJsonBody? JsonBody { get; set; }

    /// <summary>
    /// Inspect the HTTP method of the web request. The method indicates the type
    /// of operation that the request is asking the origin to perform.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;Method&quot;: {}
    /// </summary>
    [JsonPropertyName("method")]
    public IDictionary<string, string>? Method { get; set; }

    /// <summary>
    /// Inspect the query string of the web request. This is the part of a URL that
    /// appears after a ? character, if any.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;QueryString&quot;: {}
    /// </summary>
    [JsonPropertyName("queryString")]
    public IDictionary<string, string>? QueryString { get; set; }

    /// <summary>
    /// Inspect one of the headers in the web request, identified by name, for example,
    /// User-Agent or Referer. The name isn&apos;t case sensitive.
    /// 
    /// You can filter and inspect all headers with the FieldToMatch setting Headers.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Example JSON: &quot;SingleHeader&quot;: { &quot;Name&quot;: &quot;haystack&quot; }
    /// </summary>
    [JsonPropertyName("singleHeader")]
    public V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchSingleHeader? SingleHeader { get; set; }

    /// <summary>
    /// Inspect one query argument in the web request, identified by name, for example
    /// UserName or SalesRegion. The name isn&apos;t case sensitive.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Example JSON: &quot;SingleQueryArgument&quot;: { &quot;Name&quot;: &quot;myArgument&quot; }
    /// </summary>
    [JsonPropertyName("singleQueryArgument")]
    public V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatchSingleQueryArgument? SingleQueryArgument { get; set; }

    /// <summary>
    /// Inspect the path component of the URI of the web request. This is the part
    /// of the web request that identifies a resource. For example, /images/daily-ad.jpg.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;UriPath&quot;: {}
    /// </summary>
    [JsonPropertyName("uriPath")]
    public IDictionary<string, string>? UriPath { get; set; }
}

/// <summary>
/// Text transformations eliminate some of the unusual formatting that attackers
/// use in web requests in an effort to bypass detection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementByteMatchStatementTextTransformations
{
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A rule statement that defines a string match search for WAF to apply to web
/// requests. The byte match statement provides the bytes to search for, the
/// location in requests that you want WAF to search, and other settings. The
/// bytes to search for are typically a string that corresponds with ASCII characters.
/// In the WAF console and the developer guide, this is called a string match
/// statement.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementByteMatchStatement
{
    /// <summary>
    /// Specifies a web request component to be used in a rule match statement or
    /// in a logging configuration.
    /// 
    ///    * In a rule statement, this is the part of the web request that you want
    ///    WAF to inspect. Include the single FieldToMatch type that you want to
    ///    inspect, with additional specifications as needed, according to the type.
    ///    You specify a single request component in FieldToMatch for each rule statement
    ///    that requires it. To inspect more than one component of the web request,
    ///    create a separate rule statement for each component. Example JSON for
    ///    a QueryString field to match: &quot;FieldToMatch&quot;: { &quot;QueryString&quot;: {} } Example
    ///    JSON for a Method field to match specification: &quot;FieldToMatch&quot;: { &quot;Method&quot;:
    ///    { &quot;Name&quot;: &quot;DELETE&quot; } }
    /// 
    ///    * In a logging configuration, this is used in the RedactedFields property
    ///    to specify a field to redact from the logging records. For this use case,
    ///    note the following: Even though all FieldToMatch settings are available,
    ///    the only valid settings for field redaction are UriPath, QueryString,
    ///    SingleHeader, and Method. In this documentation, the descriptions of the
    ///    individual fields talk about specifying the web request component to inspect,
    ///    but for field redaction, you are specifying the component type to redact
    ///    from the logs. If you have request sampling enabled, the redacted fields
    ///    configuration for logging has no impact on sampling. The only way to exclude
    ///    fields from request sampling is by disabling sampling in the web ACL visibility
    ///    configuration.
    /// </summary>
    [JsonPropertyName("fieldToMatch")]
    public V1alpha1RuleGroupSpecRulesStatementByteMatchStatementFieldToMatch? FieldToMatch { get; set; }

    [JsonPropertyName("positionalConstraint")]
    public string? PositionalConstraint { get; set; }

    [JsonPropertyName("searchString")]
    public byte[]? SearchString { get; set; }

    [JsonPropertyName("textTransformations")]
    public IList<V1alpha1RuleGroupSpecRulesStatementByteMatchStatementTextTransformations>? TextTransformations { get; set; }
}

/// <summary>
/// The configuration for inspecting IP addresses in an HTTP header that you
/// specify, instead of using the IP address that&apos;s reported by the web request
/// origin. Commonly, this is the X-Forwarded-For (XFF) header, but you can specify
/// any header name.
/// 
/// If the specified header isn&apos;t present in the request, WAF doesn&apos;t apply the
/// rule to the web request at all.
/// 
/// This configuration is used for GeoMatchStatement and RateBasedStatement.
/// For IPSetReferenceStatement, use IPSetForwardedIPConfig instead.
/// 
/// WAF only evaluates the first IP address found in the specified HTTP header.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementGeoMatchStatementForwardedIPConfig
{
    [JsonPropertyName("fallbackBehavior")]
    public string? FallbackBehavior { get; set; }

    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }
}

/// <summary>
/// A rule statement that labels web requests by country and region and that
/// matches against web requests based on country code. A geo match rule labels
/// every request that it inspects regardless of whether it finds a match.
/// 
///    * To manage requests only by country, you can use this statement by itself
///    and specify the countries that you want to match against in the CountryCodes
///    array.
/// 
///    * Otherwise, configure your geo match rule with Count action so that it
///    only labels requests. Then, add one or more label match rules to run after
///    the geo match rule and configure them to match against the geographic
///    labels and handle the requests as needed.
/// 
/// WAF labels requests using the alpha-2 country and region codes from the International
/// Organization for Standardization (ISO) 3166 standard. WAF determines the
/// codes using either the IP address in the web request origin or, if you specify
/// it, the address in the geo match ForwardedIPConfig.
/// 
/// If you use the web request origin, the label formats are awswaf:clientip:geo:region:-
/// and awswaf:clientip:geo:country:.
/// 
/// If you use a forwarded IP address, the label formats are awswaf:forwardedip:geo:region:-
/// and awswaf:forwardedip:geo:country:.
/// 
/// For additional details, see Geographic match rule statement (https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-type-geo-match.html)
/// in the WAF Developer Guide (https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementGeoMatchStatement
{
    [JsonPropertyName("countryCodes")]
    public IList<string>? CountryCodes { get; set; }

    /// <summary>
    /// The configuration for inspecting IP addresses in an HTTP header that you
    /// specify, instead of using the IP address that&apos;s reported by the web request
    /// origin. Commonly, this is the X-Forwarded-For (XFF) header, but you can specify
    /// any header name.
    /// 
    /// If the specified header isn&apos;t present in the request, WAF doesn&apos;t apply the
    /// rule to the web request at all.
    /// 
    /// This configuration is used for GeoMatchStatement and RateBasedStatement.
    /// For IPSetReferenceStatement, use IPSetForwardedIPConfig instead.
    /// 
    /// WAF only evaluates the first IP address found in the specified HTTP header.
    /// </summary>
    [JsonPropertyName("forwardedIPConfig")]
    public V1alpha1RuleGroupSpecRulesStatementGeoMatchStatementForwardedIPConfig? ForwardedIPConfig { get; set; }
}

/// <summary>
/// The configuration for inspecting IP addresses in an HTTP header that you
/// specify, instead of using the IP address that&apos;s reported by the web request
/// origin. Commonly, this is the X-Forwarded-For (XFF) header, but you can specify
/// any header name.
/// 
/// If the specified header isn&apos;t present in the request, WAF doesn&apos;t apply the
/// rule to the web request at all.
/// 
/// This configuration is used only for IPSetReferenceStatement. For GeoMatchStatement
/// and RateBasedStatement, use ForwardedIPConfig instead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementIpSetReferenceStatementIpSetForwardedIPConfig
{
    [JsonPropertyName("fallbackBehavior")]
    public string? FallbackBehavior { get; set; }

    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    [JsonPropertyName("position")]
    public string? Position { get; set; }
}

/// <summary>
/// A rule statement used to detect web requests coming from particular IP addresses
/// or address ranges. To use this, create an IPSet that specifies the addresses
/// you want to detect, then use the ARN of that set in this statement. To create
/// an IP set, see CreateIPSet.
/// 
/// Each IP set rule statement references an IP set. You create and maintain
/// the set independent of your rules. This allows you to use the single set
/// in multiple rules. When you update the referenced set, WAF automatically
/// updates all rules that reference it.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementIpSetReferenceStatement
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// The configuration for inspecting IP addresses in an HTTP header that you
    /// specify, instead of using the IP address that&apos;s reported by the web request
    /// origin. Commonly, this is the X-Forwarded-For (XFF) header, but you can specify
    /// any header name.
    /// 
    /// If the specified header isn&apos;t present in the request, WAF doesn&apos;t apply the
    /// rule to the web request at all.
    /// 
    /// This configuration is used only for IPSetReferenceStatement. For GeoMatchStatement
    /// and RateBasedStatement, use ForwardedIPConfig instead.
    /// </summary>
    [JsonPropertyName("ipSetForwardedIPConfig")]
    public V1alpha1RuleGroupSpecRulesStatementIpSetReferenceStatementIpSetForwardedIPConfig? IpSetForwardedIPConfig { get; set; }
}

/// <summary>
/// A rule statement to match against labels that have been added to the web
/// request by rules that have already run in the web ACL.
/// 
/// The label match statement provides the label or namespace string to search
/// for. The label string can represent a part or all of the fully qualified
/// label name that had been added to the web request. Fully qualified labels
/// have a prefix, optional namespaces, and label name. The prefix identifies
/// the rule group or web ACL context of the rule that added the label. If you
/// do not provide the fully qualified name in your label match string, WAF performs
/// the search for labels that were added in the same context as the label match
/// statement.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementLabelMatchStatement
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>
/// Specifies a single rule in a rule group whose action you want to override
/// to Count.
/// 
/// Instead of this option, use RuleActionOverrides. It accepts any valid action
/// setting, including Count.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementExcludedRules
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The name of a field in the request payload that contains part or all of your
/// customer&apos;s primary physical address.
/// 
/// This data type is used in the RequestInspectionACFP data type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetRequestInspectionAddressFields
{
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>
/// The name of the field in the request payload that contains your customer&apos;s
/// email.
/// 
/// This data type is used in the RequestInspectionACFP data type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetRequestInspectionEmailField
{
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>
/// The name of the field in the request payload that contains your customer&apos;s
/// password.
/// 
/// This data type is used in the RequestInspection and RequestInspectionACFP
/// data types.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetRequestInspectionPasswordField
{
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>
/// The name of a field in the request payload that contains part or all of your
/// customer&apos;s primary phone number.
/// 
/// This data type is used in the RequestInspectionACFP data type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetRequestInspectionPhoneNumberFields
{
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>
/// The name of the field in the request payload that contains your customer&apos;s
/// username.
/// 
/// This data type is used in the RequestInspection and RequestInspectionACFP
/// data types.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetRequestInspectionUsernameField
{
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>
/// The criteria for inspecting account creation requests, used by the ACFP rule
/// group to validate and track account creation attempts.
/// 
/// This is part of the AWSManagedRulesACFPRuleSet configuration in ManagedRuleGroupConfig.
/// 
/// In these settings, you specify how your application accepts account creation
/// attempts by providing the request payload type and the names of the fields
/// within the request body where the username, password, email, and primary
/// address and phone number fields are provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetRequestInspection
{
    [JsonPropertyName("addressFields")]
    public IList<V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetRequestInspectionAddressFields>? AddressFields { get; set; }

    /// <summary>
    /// The name of the field in the request payload that contains your customer&apos;s
    /// email.
    /// 
    /// This data type is used in the RequestInspectionACFP data type.
    /// </summary>
    [JsonPropertyName("emailField")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetRequestInspectionEmailField? EmailField { get; set; }

    /// <summary>
    /// The name of the field in the request payload that contains your customer&apos;s
    /// password.
    /// 
    /// This data type is used in the RequestInspection and RequestInspectionACFP
    /// data types.
    /// </summary>
    [JsonPropertyName("passwordField")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetRequestInspectionPasswordField? PasswordField { get; set; }

    [JsonPropertyName("payloadType")]
    public string? PayloadType { get; set; }

    [JsonPropertyName("phoneNumberFields")]
    public IList<V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetRequestInspectionPhoneNumberFields>? PhoneNumberFields { get; set; }

    /// <summary>
    /// The name of the field in the request payload that contains your customer&apos;s
    /// username.
    /// 
    /// This data type is used in the RequestInspection and RequestInspectionACFP
    /// data types.
    /// </summary>
    [JsonPropertyName("usernameField")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetRequestInspectionUsernameField? UsernameField { get; set; }
}

/// <summary>
/// Configures inspection of the response body. WAF can inspect the first 65,536
/// bytes (64 KB) of the response body. This is part of the ResponseInspection
/// configuration for AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet.
/// 
/// Response inspection is available only in web ACLs that protect Amazon CloudFront
/// distributions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetResponseInspectionBodyContains
{
    [JsonPropertyName("failureStrings")]
    public IList<string>? FailureStrings { get; set; }

    [JsonPropertyName("successStrings")]
    public IList<string>? SuccessStrings { get; set; }
}

/// <summary>
/// Configures inspection of the response header. This is part of the ResponseInspection
/// configuration for AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet.
/// 
/// Response inspection is available only in web ACLs that protect Amazon CloudFront
/// distributions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetResponseInspectionHeader
{
    [JsonPropertyName("failureValues")]
    public IList<string>? FailureValues { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("successValues")]
    public IList<string>? SuccessValues { get; set; }
}

/// <summary>
/// Configures inspection of the response JSON. WAF can inspect the first 65,536
/// bytes (64 KB) of the response JSON. This is part of the ResponseInspection
/// configuration for AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet.
/// 
/// Response inspection is available only in web ACLs that protect Amazon CloudFront
/// distributions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetResponseInspectionJson
{
    [JsonPropertyName("failureValues")]
    public IList<string>? FailureValues { get; set; }

    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    [JsonPropertyName("successValues")]
    public IList<string>? SuccessValues { get; set; }
}

/// <summary>
/// Configures inspection of the response status code. This is part of the ResponseInspection
/// configuration for AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet.
/// 
/// Response inspection is available only in web ACLs that protect Amazon CloudFront
/// distributions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetResponseInspectionStatusCode
{
    [JsonPropertyName("failureCodes")]
    public IList<long>? FailureCodes { get; set; }

    [JsonPropertyName("successCodes")]
    public IList<long>? SuccessCodes { get; set; }
}

/// <summary>
/// The criteria for inspecting responses to login requests and account creation
/// requests, used by the ATP and ACFP rule groups to track login and account
/// creation success and failure rates.
/// 
/// Response inspection is available only in web ACLs that protect Amazon CloudFront
/// distributions.
/// 
/// The rule groups evaluates the responses that your protected resources send
/// back to client login and account creation attempts, keeping count of successful
/// and failed attempts from each IP address and client session. Using this information,
/// the rule group labels and mitigates requests from client sessions and IP
/// addresses with too much suspicious activity in a short amount of time.
/// 
/// This is part of the AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet
/// configurations in ManagedRuleGroupConfig.
/// 
/// Enable response inspection by configuring exactly one component of the response
/// to inspect, for example, Header or StatusCode. You can&apos;t configure more than
/// one component for inspection. If you don&apos;t configure any of the response
/// inspection options, response inspection is disabled.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetResponseInspection
{
    /// <summary>
    /// Configures inspection of the response body. WAF can inspect the first 65,536
    /// bytes (64 KB) of the response body. This is part of the ResponseInspection
    /// configuration for AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet.
    /// 
    /// Response inspection is available only in web ACLs that protect Amazon CloudFront
    /// distributions.
    /// </summary>
    [JsonPropertyName("bodyContains")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetResponseInspectionBodyContains? BodyContains { get; set; }

    /// <summary>
    /// Configures inspection of the response header. This is part of the ResponseInspection
    /// configuration for AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet.
    /// 
    /// Response inspection is available only in web ACLs that protect Amazon CloudFront
    /// distributions.
    /// </summary>
    [JsonPropertyName("header")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetResponseInspectionHeader? Header { get; set; }

    /// <summary>
    /// Configures inspection of the response JSON. WAF can inspect the first 65,536
    /// bytes (64 KB) of the response JSON. This is part of the ResponseInspection
    /// configuration for AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet.
    /// 
    /// Response inspection is available only in web ACLs that protect Amazon CloudFront
    /// distributions.
    /// </summary>
    [JsonPropertyName("json")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetResponseInspectionJson? Json { get; set; }

    /// <summary>
    /// Configures inspection of the response status code. This is part of the ResponseInspection
    /// configuration for AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet.
    /// 
    /// Response inspection is available only in web ACLs that protect Amazon CloudFront
    /// distributions.
    /// </summary>
    [JsonPropertyName("statusCode")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetResponseInspectionStatusCode? StatusCode { get; set; }
}

/// <summary>
/// Details for your use of the account creation fraud prevention managed rule
/// group, AWSManagedRulesACFPRuleSet. This configuration is used in ManagedRuleGroupConfig.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSet
{
    [JsonPropertyName("creationPath")]
    public string? CreationPath { get; set; }

    [JsonPropertyName("enableRegexInPath")]
    public bool? EnableRegexInPath { get; set; }

    [JsonPropertyName("registrationPagePath")]
    public string? RegistrationPagePath { get; set; }

    /// <summary>
    /// The criteria for inspecting account creation requests, used by the ACFP rule
    /// group to validate and track account creation attempts.
    /// 
    /// This is part of the AWSManagedRulesACFPRuleSet configuration in ManagedRuleGroupConfig.
    /// 
    /// In these settings, you specify how your application accepts account creation
    /// attempts by providing the request payload type and the names of the fields
    /// within the request body where the username, password, email, and primary
    /// address and phone number fields are provided.
    /// </summary>
    [JsonPropertyName("requestInspection")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetRequestInspection? RequestInspection { get; set; }

    /// <summary>
    /// The criteria for inspecting responses to login requests and account creation
    /// requests, used by the ATP and ACFP rule groups to track login and account
    /// creation success and failure rates.
    /// 
    /// Response inspection is available only in web ACLs that protect Amazon CloudFront
    /// distributions.
    /// 
    /// The rule groups evaluates the responses that your protected resources send
    /// back to client login and account creation attempts, keeping count of successful
    /// and failed attempts from each IP address and client session. Using this information,
    /// the rule group labels and mitigates requests from client sessions and IP
    /// addresses with too much suspicious activity in a short amount of time.
    /// 
    /// This is part of the AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet
    /// configurations in ManagedRuleGroupConfig.
    /// 
    /// Enable response inspection by configuring exactly one component of the response
    /// to inspect, for example, Header or StatusCode. You can&apos;t configure more than
    /// one component for inspection. If you don&apos;t configure any of the response
    /// inspection options, response inspection is disabled.
    /// </summary>
    [JsonPropertyName("responseInspection")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSetResponseInspection? ResponseInspection { get; set; }
}

/// <summary>
/// The name of the field in the request payload that contains your customer&apos;s
/// password.
/// 
/// This data type is used in the RequestInspection and RequestInspectionACFP
/// data types.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesATPRuleSetRequestInspectionPasswordField
{
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>
/// The name of the field in the request payload that contains your customer&apos;s
/// username.
/// 
/// This data type is used in the RequestInspection and RequestInspectionACFP
/// data types.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesATPRuleSetRequestInspectionUsernameField
{
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>
/// The criteria for inspecting login requests, used by the ATP rule group to
/// validate credentials usage.
/// 
/// This is part of the AWSManagedRulesATPRuleSet configuration in ManagedRuleGroupConfig.
/// 
/// In these settings, you specify how your application accepts login attempts
/// by providing the request payload type and the names of the fields within
/// the request body where the username and password are provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesATPRuleSetRequestInspection
{
    /// <summary>
    /// The name of the field in the request payload that contains your customer&apos;s
    /// password.
    /// 
    /// This data type is used in the RequestInspection and RequestInspectionACFP
    /// data types.
    /// </summary>
    [JsonPropertyName("passwordField")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesATPRuleSetRequestInspectionPasswordField? PasswordField { get; set; }

    [JsonPropertyName("payloadType")]
    public string? PayloadType { get; set; }

    /// <summary>
    /// The name of the field in the request payload that contains your customer&apos;s
    /// username.
    /// 
    /// This data type is used in the RequestInspection and RequestInspectionACFP
    /// data types.
    /// </summary>
    [JsonPropertyName("usernameField")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesATPRuleSetRequestInspectionUsernameField? UsernameField { get; set; }
}

/// <summary>
/// Configures inspection of the response body. WAF can inspect the first 65,536
/// bytes (64 KB) of the response body. This is part of the ResponseInspection
/// configuration for AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet.
/// 
/// Response inspection is available only in web ACLs that protect Amazon CloudFront
/// distributions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesATPRuleSetResponseInspectionBodyContains
{
    [JsonPropertyName("failureStrings")]
    public IList<string>? FailureStrings { get; set; }

    [JsonPropertyName("successStrings")]
    public IList<string>? SuccessStrings { get; set; }
}

/// <summary>
/// Configures inspection of the response header. This is part of the ResponseInspection
/// configuration for AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet.
/// 
/// Response inspection is available only in web ACLs that protect Amazon CloudFront
/// distributions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesATPRuleSetResponseInspectionHeader
{
    [JsonPropertyName("failureValues")]
    public IList<string>? FailureValues { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("successValues")]
    public IList<string>? SuccessValues { get; set; }
}

/// <summary>
/// Configures inspection of the response JSON. WAF can inspect the first 65,536
/// bytes (64 KB) of the response JSON. This is part of the ResponseInspection
/// configuration for AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet.
/// 
/// Response inspection is available only in web ACLs that protect Amazon CloudFront
/// distributions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesATPRuleSetResponseInspectionJson
{
    [JsonPropertyName("failureValues")]
    public IList<string>? FailureValues { get; set; }

    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    [JsonPropertyName("successValues")]
    public IList<string>? SuccessValues { get; set; }
}

/// <summary>
/// Configures inspection of the response status code. This is part of the ResponseInspection
/// configuration for AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet.
/// 
/// Response inspection is available only in web ACLs that protect Amazon CloudFront
/// distributions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesATPRuleSetResponseInspectionStatusCode
{
    [JsonPropertyName("failureCodes")]
    public IList<long>? FailureCodes { get; set; }

    [JsonPropertyName("successCodes")]
    public IList<long>? SuccessCodes { get; set; }
}

/// <summary>
/// The criteria for inspecting responses to login requests and account creation
/// requests, used by the ATP and ACFP rule groups to track login and account
/// creation success and failure rates.
/// 
/// Response inspection is available only in web ACLs that protect Amazon CloudFront
/// distributions.
/// 
/// The rule groups evaluates the responses that your protected resources send
/// back to client login and account creation attempts, keeping count of successful
/// and failed attempts from each IP address and client session. Using this information,
/// the rule group labels and mitigates requests from client sessions and IP
/// addresses with too much suspicious activity in a short amount of time.
/// 
/// This is part of the AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet
/// configurations in ManagedRuleGroupConfig.
/// 
/// Enable response inspection by configuring exactly one component of the response
/// to inspect, for example, Header or StatusCode. You can&apos;t configure more than
/// one component for inspection. If you don&apos;t configure any of the response
/// inspection options, response inspection is disabled.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesATPRuleSetResponseInspection
{
    /// <summary>
    /// Configures inspection of the response body. WAF can inspect the first 65,536
    /// bytes (64 KB) of the response body. This is part of the ResponseInspection
    /// configuration for AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet.
    /// 
    /// Response inspection is available only in web ACLs that protect Amazon CloudFront
    /// distributions.
    /// </summary>
    [JsonPropertyName("bodyContains")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesATPRuleSetResponseInspectionBodyContains? BodyContains { get; set; }

    /// <summary>
    /// Configures inspection of the response header. This is part of the ResponseInspection
    /// configuration for AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet.
    /// 
    /// Response inspection is available only in web ACLs that protect Amazon CloudFront
    /// distributions.
    /// </summary>
    [JsonPropertyName("header")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesATPRuleSetResponseInspectionHeader? Header { get; set; }

    /// <summary>
    /// Configures inspection of the response JSON. WAF can inspect the first 65,536
    /// bytes (64 KB) of the response JSON. This is part of the ResponseInspection
    /// configuration for AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet.
    /// 
    /// Response inspection is available only in web ACLs that protect Amazon CloudFront
    /// distributions.
    /// </summary>
    [JsonPropertyName("json")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesATPRuleSetResponseInspectionJson? Json { get; set; }

    /// <summary>
    /// Configures inspection of the response status code. This is part of the ResponseInspection
    /// configuration for AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet.
    /// 
    /// Response inspection is available only in web ACLs that protect Amazon CloudFront
    /// distributions.
    /// </summary>
    [JsonPropertyName("statusCode")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesATPRuleSetResponseInspectionStatusCode? StatusCode { get; set; }
}

/// <summary>
/// Details for your use of the account takeover prevention managed rule group,
/// AWSManagedRulesATPRuleSet. This configuration is used in ManagedRuleGroupConfig.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesATPRuleSet
{
    [JsonPropertyName("enableRegexInPath")]
    public bool? EnableRegexInPath { get; set; }

    [JsonPropertyName("loginPath")]
    public string? LoginPath { get; set; }

    /// <summary>
    /// The criteria for inspecting login requests, used by the ATP rule group to
    /// validate credentials usage.
    /// 
    /// This is part of the AWSManagedRulesATPRuleSet configuration in ManagedRuleGroupConfig.
    /// 
    /// In these settings, you specify how your application accepts login attempts
    /// by providing the request payload type and the names of the fields within
    /// the request body where the username and password are provided.
    /// </summary>
    [JsonPropertyName("requestInspection")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesATPRuleSetRequestInspection? RequestInspection { get; set; }

    /// <summary>
    /// The criteria for inspecting responses to login requests and account creation
    /// requests, used by the ATP and ACFP rule groups to track login and account
    /// creation success and failure rates.
    /// 
    /// Response inspection is available only in web ACLs that protect Amazon CloudFront
    /// distributions.
    /// 
    /// The rule groups evaluates the responses that your protected resources send
    /// back to client login and account creation attempts, keeping count of successful
    /// and failed attempts from each IP address and client session. Using this information,
    /// the rule group labels and mitigates requests from client sessions and IP
    /// addresses with too much suspicious activity in a short amount of time.
    /// 
    /// This is part of the AWSManagedRulesATPRuleSet and AWSManagedRulesACFPRuleSet
    /// configurations in ManagedRuleGroupConfig.
    /// 
    /// Enable response inspection by configuring exactly one component of the response
    /// to inspect, for example, Header or StatusCode. You can&apos;t configure more than
    /// one component for inspection. If you don&apos;t configure any of the response
    /// inspection options, response inspection is disabled.
    /// </summary>
    [JsonPropertyName("responseInspection")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesATPRuleSetResponseInspection? ResponseInspection { get; set; }
}

/// <summary>
/// Details for your use of the Bot Control managed rule group, AWSManagedRulesBotControlRuleSet.
/// This configuration is used in ManagedRuleGroupConfig.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet
{
    [JsonPropertyName("enableMachineLearning")]
    public bool? EnableMachineLearning { get; set; }

    [JsonPropertyName("inspectionLevel")]
    public string? InspectionLevel { get; set; }
}

/// <summary>
/// The name of the field in the request payload that contains your customer&apos;s
/// password.
/// 
/// This data type is used in the RequestInspection and RequestInspectionACFP
/// data types.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsPasswordField
{
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>
/// The name of the field in the request payload that contains your customer&apos;s
/// username.
/// 
/// This data type is used in the RequestInspection and RequestInspectionACFP
/// data types.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsUsernameField
{
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>
/// Additional information that&apos;s used by a managed rule group. Many managed
/// rule groups don&apos;t require this.
/// 
/// The rule groups used for intelligent threat mitigation require additional
/// configuration:
/// 
///   - Use the AWSManagedRulesACFPRuleSet configuration object to configure
///     the account creation fraud prevention managed rule group. The configuration
///     includes the registration and sign-up pages of your application and the
///     locations in the account creation request payload of data, such as the
///     user email and phone number fields.
/// 
///   - Use the AWSManagedRulesATPRuleSet configuration object to configure
///     the account takeover prevention managed rule group. The configuration
///     includes the sign-in page of your application and the locations in the
///     login request payload of data such as the username and password.
/// 
///   - Use the AWSManagedRulesBotControlRuleSet configuration object to configure
///     the protection level that you want the Bot Control rule group to use.
/// 
/// For example specifications, see the examples section of CreateWebACL.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigs
{
    /// <summary>
    /// Details for your use of the account creation fraud prevention managed rule
    /// group, AWSManagedRulesACFPRuleSet. This configuration is used in ManagedRuleGroupConfig.
    /// </summary>
    [JsonPropertyName("awsManagedRulesACFPRuleSet")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesACFPRuleSet? AwsManagedRulesACFPRuleSet { get; set; }

    /// <summary>
    /// Details for your use of the account takeover prevention managed rule group,
    /// AWSManagedRulesATPRuleSet. This configuration is used in ManagedRuleGroupConfig.
    /// </summary>
    [JsonPropertyName("awsManagedRulesATPRuleSet")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesATPRuleSet? AwsManagedRulesATPRuleSet { get; set; }

    /// <summary>
    /// Details for your use of the Bot Control managed rule group, AWSManagedRulesBotControlRuleSet.
    /// This configuration is used in ManagedRuleGroupConfig.
    /// </summary>
    [JsonPropertyName("awsManagedRulesBotControlRuleSet")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet? AwsManagedRulesBotControlRuleSet { get; set; }

    [JsonPropertyName("loginPath")]
    public string? LoginPath { get; set; }

    /// <summary>
    /// The name of the field in the request payload that contains your customer&apos;s
    /// password.
    /// 
    /// This data type is used in the RequestInspection and RequestInspectionACFP
    /// data types.
    /// </summary>
    [JsonPropertyName("passwordField")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsPasswordField? PasswordField { get; set; }

    [JsonPropertyName("payloadType")]
    public string? PayloadType { get; set; }

    /// <summary>
    /// The name of the field in the request payload that contains your customer&apos;s
    /// username.
    /// 
    /// This data type is used in the RequestInspection and RequestInspectionACFP
    /// data types.
    /// </summary>
    [JsonPropertyName("usernameField")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigsUsernameField? UsernameField { get; set; }
}

/// <summary>
/// A custom header for custom request and response handling. This is used in
/// CustomResponse and CustomRequestHandling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseAllowCustomRequestHandlingInsertHeaders
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Custom request handling behavior that inserts custom headers into a web request.
/// You can add custom request handling for WAF to use when the rule action doesn&apos;t
/// block the request. For example, CaptchaAction for requests with valid t okens,
/// and AllowAction.
/// 
/// For information about customizing web requests and responses, see Customizing
/// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseAllowCustomRequestHandling
{
    [JsonPropertyName("insertHeaders")]
    public IList<V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseAllowCustomRequestHandlingInsertHeaders>? InsertHeaders { get; set; }
}

/// <summary>
/// Specifies that WAF should allow the request and optionally defines additional
/// custom handling for the request.
/// 
/// This is used in the context of other settings, for example to specify values
/// for RuleAction and web ACL DefaultAction.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseAllow
{
    /// <summary>
    /// Custom request handling behavior that inserts custom headers into a web request.
    /// You can add custom request handling for WAF to use when the rule action doesn&apos;t
    /// block the request. For example, CaptchaAction for requests with valid t okens,
    /// and AllowAction.
    /// 
    /// For information about customizing web requests and responses, see Customizing
    /// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("customRequestHandling")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseAllowCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// A custom header for custom request and response handling. This is used in
/// CustomResponse and CustomRequestHandling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseBlockCustomResponseResponseHeaders
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// A custom response to send to the client. You can define a custom response
/// for rule actions and default web ACL actions that are set to BlockAction.
/// 
/// For information about customizing web requests and responses, see Customizing
/// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseBlockCustomResponse
{
    [JsonPropertyName("customResponseBodyKey")]
    public string? CustomResponseBodyKey { get; set; }

    [JsonPropertyName("responseCode")]
    public long? ResponseCode { get; set; }

    [JsonPropertyName("responseHeaders")]
    public IList<V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseBlockCustomResponseResponseHeaders>? ResponseHeaders { get; set; }
}

/// <summary>
/// Specifies that WAF should block the request and optionally defines additional
/// custom handling for the response to the web request.
/// 
/// This is used in the context of other settings, for example to specify values
/// for RuleAction and web ACL DefaultAction.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseBlock
{
    /// <summary>
    /// A custom response to send to the client. You can define a custom response
    /// for rule actions and default web ACL actions that are set to BlockAction.
    /// 
    /// For information about customizing web requests and responses, see Customizing
    /// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("customResponse")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseBlockCustomResponse? CustomResponse { get; set; }
}

/// <summary>
/// A custom header for custom request and response handling. This is used in
/// CustomResponse and CustomRequestHandling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseCaptchaCustomRequestHandlingInsertHeaders
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Custom request handling behavior that inserts custom headers into a web request.
/// You can add custom request handling for WAF to use when the rule action doesn&apos;t
/// block the request. For example, CaptchaAction for requests with valid t okens,
/// and AllowAction.
/// 
/// For information about customizing web requests and responses, see Customizing
/// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseCaptchaCustomRequestHandling
{
    [JsonPropertyName("insertHeaders")]
    public IList<V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseCaptchaCustomRequestHandlingInsertHeaders>? InsertHeaders { get; set; }
}

/// <summary>
/// Specifies that WAF should run a CAPTCHA check against the request:
/// 
///    * If the request includes a valid, unexpired CAPTCHA token, WAF applies
///    any custom request handling and labels that you&apos;ve configured and then
///    allows the web request inspection to proceed to the next rule, similar
///    to a CountAction.
/// 
///    * If the request doesn&apos;t include a valid, unexpired token, WAF discontinues
///    the web ACL evaluation of the request and blocks it from going to its
///    intended destination. WAF generates a response that it sends back to the
///    client, which includes the following: The header x-amzn-waf-action with
///    a value of captcha. The HTTP status code 405 Method Not Allowed. If the
///    request contains an Accept header with a value of text/html, the response
///    includes a CAPTCHA JavaScript page interstitial.
/// 
/// You can configure the expiration time in the CaptchaConfig ImmunityTimeProperty
/// setting at the rule and web ACL level. The rule setting overrides the web
/// ACL setting.
/// 
/// This action option is available for rules. It isn&apos;t available for web ACL
/// default actions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseCaptcha
{
    /// <summary>
    /// Custom request handling behavior that inserts custom headers into a web request.
    /// You can add custom request handling for WAF to use when the rule action doesn&apos;t
    /// block the request. For example, CaptchaAction for requests with valid t okens,
    /// and AllowAction.
    /// 
    /// For information about customizing web requests and responses, see Customizing
    /// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("customRequestHandling")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseCaptchaCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// A custom header for custom request and response handling. This is used in
/// CustomResponse and CustomRequestHandling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseChallengeCustomRequestHandlingInsertHeaders
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Custom request handling behavior that inserts custom headers into a web request.
/// You can add custom request handling for WAF to use when the rule action doesn&apos;t
/// block the request. For example, CaptchaAction for requests with valid t okens,
/// and AllowAction.
/// 
/// For information about customizing web requests and responses, see Customizing
/// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseChallengeCustomRequestHandling
{
    [JsonPropertyName("insertHeaders")]
    public IList<V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseChallengeCustomRequestHandlingInsertHeaders>? InsertHeaders { get; set; }
}

/// <summary>
/// Specifies that WAF should run a Challenge check against the request to verify
/// that the request is coming from a legitimate client session:
/// 
///    * If the request includes a valid, unexpired challenge token, WAF applies
///    any custom request handling and labels that you&apos;ve configured and then
///    allows the web request inspection to proceed to the next rule, similar
///    to a CountAction.
/// 
///    * If the request doesn&apos;t include a valid, unexpired challenge token, WAF
///    discontinues the web ACL evaluation of the request and blocks it from
///    going to its intended destination. WAF then generates a challenge response
///    that it sends back to the client, which includes the following: The header
///    x-amzn-waf-action with a value of challenge. The HTTP status code 202
///    Request Accepted. If the request contains an Accept header with a value
///    of text/html, the response includes a JavaScript page interstitial with
///    a challenge script. Challenges run silent browser interrogations in the
///    background, and don&apos;t generally affect the end user experience. A challenge
///    enforces token acquisition using an interstitial JavaScript challenge
///    that inspects the client session for legitimate behavior. The challenge
///    blocks bots or at least increases the cost of operating sophisticated
///    bots. After the client session successfully responds to the challenge,
///    it receives a new token from WAF, which the challenge script uses to resubmit
///    the original request.
/// 
/// You can configure the expiration time in the ChallengeConfig ImmunityTimeProperty
/// setting at the rule and web ACL level. The rule setting overrides the web
/// ACL setting.
/// 
/// This action option is available for rules. It isn&apos;t available for web ACL
/// default actions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseChallenge
{
    /// <summary>
    /// Custom request handling behavior that inserts custom headers into a web request.
    /// You can add custom request handling for WAF to use when the rule action doesn&apos;t
    /// block the request. For example, CaptchaAction for requests with valid t okens,
    /// and AllowAction.
    /// 
    /// For information about customizing web requests and responses, see Customizing
    /// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("customRequestHandling")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseChallengeCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// A custom header for custom request and response handling. This is used in
/// CustomResponse and CustomRequestHandling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseCountCustomRequestHandlingInsertHeaders
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Custom request handling behavior that inserts custom headers into a web request.
/// You can add custom request handling for WAF to use when the rule action doesn&apos;t
/// block the request. For example, CaptchaAction for requests with valid t okens,
/// and AllowAction.
/// 
/// For information about customizing web requests and responses, see Customizing
/// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseCountCustomRequestHandling
{
    [JsonPropertyName("insertHeaders")]
    public IList<V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseCountCustomRequestHandlingInsertHeaders>? InsertHeaders { get; set; }
}

/// <summary>
/// Specifies that WAF should count the request. Optionally defines additional
/// custom handling for the request.
/// 
/// This is used in the context of other settings, for example to specify values
/// for RuleAction and web ACL DefaultAction.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseCount
{
    /// <summary>
    /// Custom request handling behavior that inserts custom headers into a web request.
    /// You can add custom request handling for WAF to use when the rule action doesn&apos;t
    /// block the request. For example, CaptchaAction for requests with valid t okens,
    /// and AllowAction.
    /// 
    /// For information about customizing web requests and responses, see Customizing
    /// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("customRequestHandling")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseCountCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// The action that WAF should take on a web request when it matches a rule&apos;s
/// statement. Settings at the web ACL level can override the rule action setting.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUse
{
    /// <summary>
    /// Specifies that WAF should allow the request and optionally defines additional
    /// custom handling for the request.
    /// 
    /// This is used in the context of other settings, for example to specify values
    /// for RuleAction and web ACL DefaultAction.
    /// </summary>
    [JsonPropertyName("allow")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseAllow? Allow { get; set; }

    /// <summary>
    /// Specifies that WAF should block the request and optionally defines additional
    /// custom handling for the response to the web request.
    /// 
    /// This is used in the context of other settings, for example to specify values
    /// for RuleAction and web ACL DefaultAction.
    /// </summary>
    [JsonPropertyName("block")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseBlock? Block { get; set; }

    /// <summary>
    /// Specifies that WAF should run a CAPTCHA check against the request:
    /// 
    ///    * If the request includes a valid, unexpired CAPTCHA token, WAF applies
    ///    any custom request handling and labels that you&apos;ve configured and then
    ///    allows the web request inspection to proceed to the next rule, similar
    ///    to a CountAction.
    /// 
    ///    * If the request doesn&apos;t include a valid, unexpired token, WAF discontinues
    ///    the web ACL evaluation of the request and blocks it from going to its
    ///    intended destination. WAF generates a response that it sends back to the
    ///    client, which includes the following: The header x-amzn-waf-action with
    ///    a value of captcha. The HTTP status code 405 Method Not Allowed. If the
    ///    request contains an Accept header with a value of text/html, the response
    ///    includes a CAPTCHA JavaScript page interstitial.
    /// 
    /// You can configure the expiration time in the CaptchaConfig ImmunityTimeProperty
    /// setting at the rule and web ACL level. The rule setting overrides the web
    /// ACL setting.
    /// 
    /// This action option is available for rules. It isn&apos;t available for web ACL
    /// default actions.
    /// </summary>
    [JsonPropertyName("captcha")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseCaptcha? Captcha { get; set; }

    /// <summary>
    /// Specifies that WAF should run a Challenge check against the request to verify
    /// that the request is coming from a legitimate client session:
    /// 
    ///    * If the request includes a valid, unexpired challenge token, WAF applies
    ///    any custom request handling and labels that you&apos;ve configured and then
    ///    allows the web request inspection to proceed to the next rule, similar
    ///    to a CountAction.
    /// 
    ///    * If the request doesn&apos;t include a valid, unexpired challenge token, WAF
    ///    discontinues the web ACL evaluation of the request and blocks it from
    ///    going to its intended destination. WAF then generates a challenge response
    ///    that it sends back to the client, which includes the following: The header
    ///    x-amzn-waf-action with a value of challenge. The HTTP status code 202
    ///    Request Accepted. If the request contains an Accept header with a value
    ///    of text/html, the response includes a JavaScript page interstitial with
    ///    a challenge script. Challenges run silent browser interrogations in the
    ///    background, and don&apos;t generally affect the end user experience. A challenge
    ///    enforces token acquisition using an interstitial JavaScript challenge
    ///    that inspects the client session for legitimate behavior. The challenge
    ///    blocks bots or at least increases the cost of operating sophisticated
    ///    bots. After the client session successfully responds to the challenge,
    ///    it receives a new token from WAF, which the challenge script uses to resubmit
    ///    the original request.
    /// 
    /// You can configure the expiration time in the ChallengeConfig ImmunityTimeProperty
    /// setting at the rule and web ACL level. The rule setting overrides the web
    /// ACL setting.
    /// 
    /// This action option is available for rules. It isn&apos;t available for web ACL
    /// default actions.
    /// </summary>
    [JsonPropertyName("challenge")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseChallenge? Challenge { get; set; }

    /// <summary>
    /// Specifies that WAF should count the request. Optionally defines additional
    /// custom handling for the request.
    /// 
    /// This is used in the context of other settings, for example to specify values
    /// for RuleAction and web ACL DefaultAction.
    /// </summary>
    [JsonPropertyName("count")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUseCount? Count { get; set; }
}

/// <summary>
/// Action setting to use in the place of a rule action that is configured inside
/// the rule group. You specify one override for each rule whose action you want
/// to change.
/// 
/// You can use overrides for testing, for example you can override all of rule
/// actions to Count and then monitor the resulting count metrics to understand
/// how the rule group would handle your web traffic. You can also permanently
/// override some or all actions, to modify how the rule group manages your web
/// traffic.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverrides
{
    /// <summary>
    /// The action that WAF should take on a web request when it matches a rule&apos;s
    /// statement. Settings at the web ACL level can override the rule action setting.
    /// </summary>
    [JsonPropertyName("actionToUse")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverridesActionToUse? ActionToUse { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A rule statement used to run the rules that are defined in a managed rule
/// group. To use this, provide the vendor name and the name of the rule group
/// in this statement. You can retrieve the required names by calling ListAvailableManagedRuleGroups.
/// 
/// You cannot nest a ManagedRuleGroupStatement, for example for use inside a
/// NotStatement or OrStatement. You cannot use a managed rule group inside another
/// rule group. You can only reference a managed rule group as a top-level statement
/// within a rule that you define in a web ACL.
/// 
/// You are charged additional fees when you use the WAF Bot Control managed
/// rule group AWSManagedRulesBotControlRuleSet, the WAF Fraud Control account
/// takeover prevention (ATP) managed rule group AWSManagedRulesATPRuleSet, or
/// the WAF Fraud Control account creation fraud prevention (ACFP) managed rule
/// group AWSManagedRulesACFPRuleSet. For more information, see WAF Pricing (http://aws.amazon.com/waf/pricing/).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatement
{
    [JsonPropertyName("excludedRules")]
    public IList<V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementExcludedRules>? ExcludedRules { get; set; }

    [JsonPropertyName("managedRuleGroupConfigs")]
    public IList<V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementManagedRuleGroupConfigs>? ManagedRuleGroupConfigs { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("ruleActionOverrides")]
    public IList<V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatementRuleActionOverrides>? RuleActionOverrides { get; set; }

    [JsonPropertyName("scopeDownStatement")]
    public string? ScopeDownStatement { get; set; }

    [JsonPropertyName("vendorName")]
    public string? VendorName { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Text transformations eliminate some of the unusual formatting that attackers
/// use in web requests in an effort to bypass detection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysCookieTextTransformations
{
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Specifies a cookie as an aggregate key for a rate-based rule. Each distinct
/// value in the cookie contributes to the aggregation instance. If you use a
/// single cookie as your custom key, then each value fully defines an aggregation
/// instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysCookie
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("textTransformations")]
    public IList<V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysCookieTextTransformations>? TextTransformations { get; set; }
}

/// <summary>
/// Text transformations eliminate some of the unusual formatting that attackers
/// use in web requests in an effort to bypass detection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysHeaderTextTransformations
{
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Specifies a header as an aggregate key for a rate-based rule. Each distinct
/// value in the header contributes to the aggregation instance. If you use a
/// single header as your custom key, then each value fully defines an aggregation
/// instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysHeader
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("textTransformations")]
    public IList<V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysHeaderTextTransformations>? TextTransformations { get; set; }
}

/// <summary>
/// Specifies a label namespace to use as an aggregate key for a rate-based rule.
/// Each distinct fully qualified label name that has the specified label namespace
/// contributes to the aggregation instance. If you use just one label namespace
/// as your custom key, then each label name fully defines an aggregation instance.
/// 
/// This uses only labels that have been added to the request by rules that are
/// evaluated before this rate-based rule in the web ACL.
/// 
/// For information about label namespaces and names, see Label syntax and naming
/// requirements (https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-label-requirements.html)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysLabelNamespace
{
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Text transformations eliminate some of the unusual formatting that attackers
/// use in web requests in an effort to bypass detection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysQueryArgumentTextTransformations
{
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Specifies a query argument in the request as an aggregate key for a rate-based
/// rule. Each distinct value for the named query argument contributes to the
/// aggregation instance. If you use a single query argument as your custom key,
/// then each value fully defines an aggregation instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysQueryArgument
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("textTransformations")]
    public IList<V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysQueryArgumentTextTransformations>? TextTransformations { get; set; }
}

/// <summary>
/// Text transformations eliminate some of the unusual formatting that attackers
/// use in web requests in an effort to bypass detection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysQueryStringTextTransformations
{
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Specifies the request&apos;s query string as an aggregate key for a rate-based
/// rule. Each distinct string contributes to the aggregation instance. If you
/// use just the query string as your custom key, then each string fully defines
/// an aggregation instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysQueryString
{
    [JsonPropertyName("textTransformations")]
    public IList<V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysQueryStringTextTransformations>? TextTransformations { get; set; }
}

/// <summary>
/// Text transformations eliminate some of the unusual formatting that attackers
/// use in web requests in an effort to bypass detection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysUriPathTextTransformations
{
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Specifies the request&apos;s URI path as an aggregate key for a rate-based rule.
/// Each distinct URI path contributes to the aggregation instance. If you use
/// just the URI path as your custom key, then each URI path fully defines an
/// aggregation instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysUriPath
{
    [JsonPropertyName("textTransformations")]
    public IList<V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysUriPathTextTransformations>? TextTransformations { get; set; }
}

/// <summary>
/// Specifies a single custom aggregate key for a rate-base rule.
/// 
/// Web requests that are missing any of the components specified in the aggregation
/// keys are omitted from the rate-based rule evaluation and handling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeys
{
    /// <summary>
    /// Specifies a cookie as an aggregate key for a rate-based rule. Each distinct
    /// value in the cookie contributes to the aggregation instance. If you use a
    /// single cookie as your custom key, then each value fully defines an aggregation
    /// instance.
    /// </summary>
    [JsonPropertyName("cookie")]
    public V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysCookie? Cookie { get; set; }

    /// <summary>
    /// Specifies the first IP address in an HTTP header as an aggregate key for
    /// a rate-based rule. Each distinct forwarded IP address contributes to the
    /// aggregation instance.
    /// 
    /// This setting is used only in the RateBasedStatementCustomKey specification
    /// of a rate-based rule statement. When you specify an IP or forwarded IP in
    /// the custom key settings, you must also specify at least one other key to
    /// use. You can aggregate on only the forwarded IP address by specifying FORWARDED_IP
    /// in your rate-based statement&apos;s AggregateKeyType.
    /// 
    /// This data type supports using the forwarded IP address in the web request
    /// aggregation for a rate-based rule, in RateBasedStatementCustomKey. The JSON
    /// specification for using the forwarded IP address doesn&apos;t explicitly use this
    /// data type.
    /// 
    /// JSON specification: &quot;ForwardedIP&quot;: {}
    /// 
    /// When you use this specification, you must also configure the forwarded IP
    /// address in the rate-based statement&apos;s ForwardedIPConfig.
    /// </summary>
    [JsonPropertyName("forwardedIP")]
    public IDictionary<string, string>? ForwardedIP { get; set; }

    /// <summary>
    /// Specifies a header as an aggregate key for a rate-based rule. Each distinct
    /// value in the header contributes to the aggregation instance. If you use a
    /// single header as your custom key, then each value fully defines an aggregation
    /// instance.
    /// </summary>
    [JsonPropertyName("header")]
    public V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysHeader? Header { get; set; }

    /// <summary>
    /// Specifies the request&apos;s HTTP method as an aggregate key for a rate-based
    /// rule. Each distinct HTTP method contributes to the aggregation instance.
    /// If you use just the HTTP method as your custom key, then each method fully
    /// defines an aggregation instance.
    /// 
    /// JSON specification: &quot;RateLimitHTTPMethod&quot;: {}
    /// </summary>
    [JsonPropertyName("httpMethod")]
    public IDictionary<string, string>? HttpMethod { get; set; }

    /// <summary>
    /// Specifies the IP address in the web request as an aggregate key for a rate-based
    /// rule. Each distinct IP address contributes to the aggregation instance.
    /// 
    /// This setting is used only in the RateBasedStatementCustomKey specification
    /// of a rate-based rule statement. To use this in the custom key settings, you
    /// must specify at least one other key to use, along with the IP address. To
    /// aggregate on only the IP address, in your rate-based statement&apos;s AggregateKeyType,
    /// specify IP.
    /// 
    /// JSON specification: &quot;RateLimitIP&quot;: {}
    /// </summary>
    [JsonPropertyName("iP")]
    public IDictionary<string, string>? IP { get; set; }

    /// <summary>
    /// Specifies a label namespace to use as an aggregate key for a rate-based rule.
    /// Each distinct fully qualified label name that has the specified label namespace
    /// contributes to the aggregation instance. If you use just one label namespace
    /// as your custom key, then each label name fully defines an aggregation instance.
    /// 
    /// This uses only labels that have been added to the request by rules that are
    /// evaluated before this rate-based rule in the web ACL.
    /// 
    /// For information about label namespaces and names, see Label syntax and naming
    /// requirements (https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-label-requirements.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("labelNamespace")]
    public V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysLabelNamespace? LabelNamespace { get; set; }

    /// <summary>
    /// Specifies a query argument in the request as an aggregate key for a rate-based
    /// rule. Each distinct value for the named query argument contributes to the
    /// aggregation instance. If you use a single query argument as your custom key,
    /// then each value fully defines an aggregation instance.
    /// </summary>
    [JsonPropertyName("queryArgument")]
    public V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysQueryArgument? QueryArgument { get; set; }

    /// <summary>
    /// Specifies the request&apos;s query string as an aggregate key for a rate-based
    /// rule. Each distinct string contributes to the aggregation instance. If you
    /// use just the query string as your custom key, then each string fully defines
    /// an aggregation instance.
    /// </summary>
    [JsonPropertyName("queryString")]
    public V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysQueryString? QueryString { get; set; }

    /// <summary>
    /// Specifies the request&apos;s URI path as an aggregate key for a rate-based rule.
    /// Each distinct URI path contributes to the aggregation instance. If you use
    /// just the URI path as your custom key, then each URI path fully defines an
    /// aggregation instance.
    /// </summary>
    [JsonPropertyName("uriPath")]
    public V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeysUriPath? UriPath { get; set; }
}

/// <summary>
/// The configuration for inspecting IP addresses in an HTTP header that you
/// specify, instead of using the IP address that&apos;s reported by the web request
/// origin. Commonly, this is the X-Forwarded-For (XFF) header, but you can specify
/// any header name.
/// 
/// If the specified header isn&apos;t present in the request, WAF doesn&apos;t apply the
/// rule to the web request at all.
/// 
/// This configuration is used for GeoMatchStatement and RateBasedStatement.
/// For IPSetReferenceStatement, use IPSetForwardedIPConfig instead.
/// 
/// WAF only evaluates the first IP address found in the specified HTTP header.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRateBasedStatementForwardedIPConfig
{
    [JsonPropertyName("fallbackBehavior")]
    public string? FallbackBehavior { get; set; }

    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }
}

/// <summary>
/// A rate-based rule counts incoming requests and rate limits requests when
/// they are coming at too fast a rate. The rule categorizes requests according
/// to your aggregation criteria, collects them into aggregation instances, and
/// counts and rate limits the requests for each instance.
/// 
/// If you change any of these settings in a rule that&apos;s currently in use, the
/// change resets the rule&apos;s rate limiting counts. This can pause the rule&apos;s
/// rate limiting activities for up to a minute.
/// 
/// You can specify individual aggregation keys, like IP address or HTTP method.
/// You can also specify aggregation key combinations, like IP address and HTTP
/// method, or HTTP method, query argument, and cookie.
/// 
/// Each unique set of values for the aggregation keys that you specify is a
/// separate aggregation instance, with the value from each key contributing
/// to the aggregation instance definition.
/// 
/// For example, assume the rule evaluates web requests with the following IP
/// address and HTTP method values:
/// 
///    * IP address 10.1.1.1, HTTP method POST
/// 
///    * IP address 10.1.1.1, HTTP method GET
/// 
///    * IP address 127.0.0.0, HTTP method POST
/// 
///    * IP address 10.1.1.1, HTTP method GET
/// 
/// The rule would create different aggregation instances according to your aggregation
/// criteria, for example:
/// 
///    * If the aggregation criteria is just the IP address, then each individual
///    address is an aggregation instance, and WAF counts requests separately
///    for each. The aggregation instances and request counts for our example
///    would be the following: IP address 10.1.1.1: count 3 IP address 127.0.0.0:
///    count 1
/// 
///    * If the aggregation criteria is HTTP method, then each individual HTTP
///    method is an aggregation instance. The aggregation instances and request
///    counts for our example would be the following: HTTP method POST: count
///    2 HTTP method GET: count 2
/// 
///    * If the aggregation criteria is IP address and HTTP method, then each
///    IP address and each HTTP method would contribute to the combined aggregation
///    instance. The aggregation instances and request counts for our example
///    would be the following: IP address 10.1.1.1, HTTP method POST: count 1
///    IP address 10.1.1.1, HTTP method GET: count 2 IP address 127.0.0.0, HTTP
///    method POST: count 1
/// 
/// For any n-tuple of aggregation keys, each unique combination of values for
/// the keys defines a separate aggregation instance, which WAF counts and rate-limits
/// individually.
/// 
/// You can optionally nest another statement inside the rate-based statement,
/// to narrow the scope of the rule so that it only counts and rate limits requests
/// that match the nested statement. You can use this nested scope-down statement
/// in conjunction with your aggregation key specifications or you can just count
/// and rate limit all requests that match the scope-down statement, without
/// additional aggregation. When you choose to just manage all requests that
/// match a scope-down statement, the aggregation instance is singular for the
/// rule.
/// 
/// You cannot nest a RateBasedStatement inside another statement, for example
/// inside a NotStatement or OrStatement. You can define a RateBasedStatement
/// inside a web ACL and inside a rule group.
/// 
/// For additional information about the options, see Rate limiting web requests
/// using rate-based rules (https://docs.aws.amazon.com/waf/latest/developerguide/waf-rate-based-rules.html)
/// in the WAF Developer Guide.
/// 
/// If you only aggregate on the individual IP address or forwarded IP address,
/// you can retrieve the list of IP addresses that WAF is currently rate limiting
/// for a rule through the API call GetRateBasedStatementManagedKeys. This option
/// is not available for other aggregation configurations.
/// 
/// WAF tracks and manages web requests separately for each instance of a rate-based
/// rule that you use. For example, if you provide the same rate-based rule settings
/// in two web ACLs, each of the two rule statements represents a separate instance
/// of the rate-based rule and gets its own tracking and management by WAF. If
/// you define a rate-based rule inside a rule group, and then use that rule
/// group in multiple places, each use creates a separate instance of the rate-based
/// rule that gets its own tracking and management by WAF.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRateBasedStatement
{
    [JsonPropertyName("aggregateKeyType")]
    public string? AggregateKeyType { get; set; }

    [JsonPropertyName("customKeys")]
    public IList<V1alpha1RuleGroupSpecRulesStatementRateBasedStatementCustomKeys>? CustomKeys { get; set; }

    [JsonPropertyName("evaluationWindowSec")]
    public long? EvaluationWindowSec { get; set; }

    /// <summary>
    /// The configuration for inspecting IP addresses in an HTTP header that you
    /// specify, instead of using the IP address that&apos;s reported by the web request
    /// origin. Commonly, this is the X-Forwarded-For (XFF) header, but you can specify
    /// any header name.
    /// 
    /// If the specified header isn&apos;t present in the request, WAF doesn&apos;t apply the
    /// rule to the web request at all.
    /// 
    /// This configuration is used for GeoMatchStatement and RateBasedStatement.
    /// For IPSetReferenceStatement, use IPSetForwardedIPConfig instead.
    /// 
    /// WAF only evaluates the first IP address found in the specified HTTP header.
    /// </summary>
    [JsonPropertyName("forwardedIPConfig")]
    public V1alpha1RuleGroupSpecRulesStatementRateBasedStatementForwardedIPConfig? ForwardedIPConfig { get; set; }

    [JsonPropertyName("limit")]
    public long? Limit { get; set; }

    [JsonPropertyName("scopeDownStatement")]
    public string? ScopeDownStatement { get; set; }
}

/// <summary>
/// Inspect the body of the web request. The body immediately follows the request
/// headers.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchBody
{
    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// The filter to use to identify the subset of cookies to inspect in a web request.
/// 
/// You must specify exactly one setting: either All, IncludedCookies, or ExcludedCookies.
/// 
/// Example JSON: &quot;MatchPattern&quot;: { &quot;IncludedCookies&quot;: [ &quot;session-id-time&quot;, &quot;session-id&quot;
/// ] }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchCookiesMatchPattern
{
    /// <summary>
    /// Inspect all of the elements that WAF has parsed and extracted from the web
    /// request component that you&apos;ve identified in your FieldToMatch specifications.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;All&quot;: {}
    /// </summary>
    [JsonPropertyName("all")]
    public IDictionary<string, string>? All { get; set; }

    [JsonPropertyName("excludedCookies")]
    public IList<string>? ExcludedCookies { get; set; }

    [JsonPropertyName("includedCookies")]
    public IList<string>? IncludedCookies { get; set; }
}

/// <summary>
/// Inspect the cookies in the web request. You can specify the parts of the
/// cookies to inspect and you can narrow the set of cookies to inspect by including
/// or excluding specific keys.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Example JSON: &quot;Cookies&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
/// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchCookies
{
    /// <summary>
    /// The filter to use to identify the subset of cookies to inspect in a web request.
    /// 
    /// You must specify exactly one setting: either All, IncludedCookies, or ExcludedCookies.
    /// 
    /// Example JSON: &quot;MatchPattern&quot;: { &quot;IncludedCookies&quot;: [ &quot;session-id-time&quot;, &quot;session-id&quot;
    /// ] }
    /// </summary>
    [JsonPropertyName("matchPattern")]
    public V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchCookiesMatchPattern? MatchPattern { get; set; }

    [JsonPropertyName("matchScope")]
    public string? MatchScope { get; set; }

    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// Inspect a string containing the list of the request&apos;s header names, ordered
/// as they appear in the web requestthat WAF receives for inspection. WAF generates
/// the string and then uses that as the field to match component in its inspection.
/// WAF separates the header names in the string using colons and no added spaces,
/// for example host:user-agent:accept:authorization:referer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchHeaderOrder
{
    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// The filter to use to identify the subset of headers to inspect in a web request.
/// 
/// You must specify exactly one setting: either All, IncludedHeaders, or ExcludedHeaders.
/// 
/// Example JSON: &quot;MatchPattern&quot;: { &quot;ExcludedHeaders&quot;: [ &quot;KeyToExclude1&quot;, &quot;KeyToExclude2&quot;
/// ] }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchHeadersMatchPattern
{
    /// <summary>
    /// Inspect all of the elements that WAF has parsed and extracted from the web
    /// request component that you&apos;ve identified in your FieldToMatch specifications.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;All&quot;: {}
    /// </summary>
    [JsonPropertyName("all")]
    public IDictionary<string, string>? All { get; set; }

    [JsonPropertyName("excludedHeaders")]
    public IList<string>? ExcludedHeaders { get; set; }

    [JsonPropertyName("includedHeaders")]
    public IList<string>? IncludedHeaders { get; set; }
}

/// <summary>
/// Inspect all headers in the web request. You can specify the parts of the
/// headers to inspect and you can narrow the set of headers to inspect by including
/// or excluding specific keys.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// If you want to inspect just the value of a single header, use the SingleHeader
/// FieldToMatch setting instead.
/// 
/// Example JSON: &quot;Headers&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
/// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchHeaders
{
    /// <summary>
    /// The filter to use to identify the subset of headers to inspect in a web request.
    /// 
    /// You must specify exactly one setting: either All, IncludedHeaders, or ExcludedHeaders.
    /// 
    /// Example JSON: &quot;MatchPattern&quot;: { &quot;ExcludedHeaders&quot;: [ &quot;KeyToExclude1&quot;, &quot;KeyToExclude2&quot;
    /// ] }
    /// </summary>
    [JsonPropertyName("matchPattern")]
    public V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchHeadersMatchPattern? MatchPattern { get; set; }

    [JsonPropertyName("matchScope")]
    public string? MatchScope { get; set; }

    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// Available for use with Amazon CloudFront distributions and Application Load
/// Balancers. Match against the request&apos;s JA3 fingerprint. The JA3 fingerprint
/// is a 32-character hash derived from the TLS Client Hello of an incoming request.
/// This fingerprint serves as a unique identifier for the client&apos;s TLS configuration.
/// WAF calculates and logs this fingerprint for each request that has enough
/// TLS Client Hello information for the calculation. Almost all web requests
/// include this information.
/// 
/// You can use this choice only with a string match ByteMatchStatement with
/// the PositionalConstraint set to EXACTLY.
/// 
/// You can obtain the JA3 fingerprint for client requests from the web ACL logs.
/// If WAF is able to calculate the fingerprint, it includes it in the logs.
/// For information about the logging fields, see Log fields (https://docs.aws.amazon.com/waf/latest/developerguide/logging-fields.html)
/// in the WAF Developer Guide.
/// 
/// Provide the JA3 fingerprint string from the logs in your string match statement
/// specification, to match with any future requests that have the same TLS configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchJa3Fingerprint
{
    [JsonPropertyName("fallbackBehavior")]
    public string? FallbackBehavior { get; set; }
}

/// <summary>
/// The patterns to look for in the JSON body. WAF inspects the results of these
/// pattern matches against the rule inspection criteria. This is used with the
/// FieldToMatch option JsonBody.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchJsonBodyMatchPattern
{
    /// <summary>
    /// Inspect all of the elements that WAF has parsed and extracted from the web
    /// request component that you&apos;ve identified in your FieldToMatch specifications.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;All&quot;: {}
    /// </summary>
    [JsonPropertyName("all")]
    public IDictionary<string, string>? All { get; set; }

    [JsonPropertyName("includedPaths")]
    public IList<string>? IncludedPaths { get; set; }
}

/// <summary>
/// Inspect the body of the web request as JSON. The body immediately follows
/// the request headers.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Use the specifications in this object to indicate which parts of the JSON
/// body to inspect using the rule&apos;s inspection criteria. WAF inspects only the
/// parts of the JSON that result from the matches that you indicate.
/// 
/// Example JSON: &quot;JsonBody&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;:
/// &quot;ALL&quot; }
/// 
/// For additional information about this request component option, see JSON
/// body (https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-fields-list.html#waf-rule-statement-request-component-json-body)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchJsonBody
{
    [JsonPropertyName("invalidFallbackBehavior")]
    public string? InvalidFallbackBehavior { get; set; }

    /// <summary>
    /// The patterns to look for in the JSON body. WAF inspects the results of these
    /// pattern matches against the rule inspection criteria. This is used with the
    /// FieldToMatch option JsonBody.
    /// </summary>
    [JsonPropertyName("matchPattern")]
    public V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchJsonBodyMatchPattern? MatchPattern { get; set; }

    [JsonPropertyName("matchScope")]
    public string? MatchScope { get; set; }

    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// Inspect one of the headers in the web request, identified by name, for example,
/// User-Agent or Referer. The name isn&apos;t case sensitive.
/// 
/// You can filter and inspect all headers with the FieldToMatch setting Headers.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Example JSON: &quot;SingleHeader&quot;: { &quot;Name&quot;: &quot;haystack&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchSingleHeader
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Inspect one query argument in the web request, identified by name, for example
/// UserName or SalesRegion. The name isn&apos;t case sensitive.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Example JSON: &quot;SingleQueryArgument&quot;: { &quot;Name&quot;: &quot;myArgument&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchSingleQueryArgument
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Specifies a web request component to be used in a rule match statement or
/// in a logging configuration.
/// 
///    * In a rule statement, this is the part of the web request that you want
///    WAF to inspect. Include the single FieldToMatch type that you want to
///    inspect, with additional specifications as needed, according to the type.
///    You specify a single request component in FieldToMatch for each rule statement
///    that requires it. To inspect more than one component of the web request,
///    create a separate rule statement for each component. Example JSON for
///    a QueryString field to match: &quot;FieldToMatch&quot;: { &quot;QueryString&quot;: {} } Example
///    JSON for a Method field to match specification: &quot;FieldToMatch&quot;: { &quot;Method&quot;:
///    { &quot;Name&quot;: &quot;DELETE&quot; } }
/// 
///    * In a logging configuration, this is used in the RedactedFields property
///    to specify a field to redact from the logging records. For this use case,
///    note the following: Even though all FieldToMatch settings are available,
///    the only valid settings for field redaction are UriPath, QueryString,
///    SingleHeader, and Method. In this documentation, the descriptions of the
///    individual fields talk about specifying the web request component to inspect,
///    but for field redaction, you are specifying the component type to redact
///    from the logs. If you have request sampling enabled, the redacted fields
///    configuration for logging has no impact on sampling. The only way to exclude
///    fields from request sampling is by disabling sampling in the web ACL visibility
///    configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatch
{
    /// <summary>
    /// Inspect all query arguments of the web request.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;AllQueryArguments&quot;: {}
    /// </summary>
    [JsonPropertyName("allQueryArguments")]
    public IDictionary<string, string>? AllQueryArguments { get; set; }

    /// <summary>
    /// Inspect the body of the web request. The body immediately follows the request
    /// headers.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// </summary>
    [JsonPropertyName("body")]
    public V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchBody? Body { get; set; }

    /// <summary>
    /// Inspect the cookies in the web request. You can specify the parts of the
    /// cookies to inspect and you can narrow the set of cookies to inspect by including
    /// or excluding specific keys.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Example JSON: &quot;Cookies&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
    /// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
    /// </summary>
    [JsonPropertyName("cookies")]
    public V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchCookies? Cookies { get; set; }

    /// <summary>
    /// Inspect a string containing the list of the request&apos;s header names, ordered
    /// as they appear in the web requestthat WAF receives for inspection. WAF generates
    /// the string and then uses that as the field to match component in its inspection.
    /// WAF separates the header names in the string using colons and no added spaces,
    /// for example host:user-agent:accept:authorization:referer.
    /// </summary>
    [JsonPropertyName("headerOrder")]
    public V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchHeaderOrder? HeaderOrder { get; set; }

    /// <summary>
    /// Inspect all headers in the web request. You can specify the parts of the
    /// headers to inspect and you can narrow the set of headers to inspect by including
    /// or excluding specific keys.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// If you want to inspect just the value of a single header, use the SingleHeader
    /// FieldToMatch setting instead.
    /// 
    /// Example JSON: &quot;Headers&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
    /// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
    /// </summary>
    [JsonPropertyName("headers")]
    public V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchHeaders? Headers { get; set; }

    /// <summary>
    /// Available for use with Amazon CloudFront distributions and Application Load
    /// Balancers. Match against the request&apos;s JA3 fingerprint. The JA3 fingerprint
    /// is a 32-character hash derived from the TLS Client Hello of an incoming request.
    /// This fingerprint serves as a unique identifier for the client&apos;s TLS configuration.
    /// WAF calculates and logs this fingerprint for each request that has enough
    /// TLS Client Hello information for the calculation. Almost all web requests
    /// include this information.
    /// 
    /// You can use this choice only with a string match ByteMatchStatement with
    /// the PositionalConstraint set to EXACTLY.
    /// 
    /// You can obtain the JA3 fingerprint for client requests from the web ACL logs.
    /// If WAF is able to calculate the fingerprint, it includes it in the logs.
    /// For information about the logging fields, see Log fields (https://docs.aws.amazon.com/waf/latest/developerguide/logging-fields.html)
    /// in the WAF Developer Guide.
    /// 
    /// Provide the JA3 fingerprint string from the logs in your string match statement
    /// specification, to match with any future requests that have the same TLS configuration.
    /// </summary>
    [JsonPropertyName("ja3Fingerprint")]
    public V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchJa3Fingerprint? Ja3Fingerprint { get; set; }

    /// <summary>
    /// Inspect the body of the web request as JSON. The body immediately follows
    /// the request headers.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Use the specifications in this object to indicate which parts of the JSON
    /// body to inspect using the rule&apos;s inspection criteria. WAF inspects only the
    /// parts of the JSON that result from the matches that you indicate.
    /// 
    /// Example JSON: &quot;JsonBody&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;:
    /// &quot;ALL&quot; }
    /// 
    /// For additional information about this request component option, see JSON
    /// body (https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-fields-list.html#waf-rule-statement-request-component-json-body)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("jsonBody")]
    public V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchJsonBody? JsonBody { get; set; }

    /// <summary>
    /// Inspect the HTTP method of the web request. The method indicates the type
    /// of operation that the request is asking the origin to perform.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;Method&quot;: {}
    /// </summary>
    [JsonPropertyName("method")]
    public IDictionary<string, string>? Method { get; set; }

    /// <summary>
    /// Inspect the query string of the web request. This is the part of a URL that
    /// appears after a ? character, if any.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;QueryString&quot;: {}
    /// </summary>
    [JsonPropertyName("queryString")]
    public IDictionary<string, string>? QueryString { get; set; }

    /// <summary>
    /// Inspect one of the headers in the web request, identified by name, for example,
    /// User-Agent or Referer. The name isn&apos;t case sensitive.
    /// 
    /// You can filter and inspect all headers with the FieldToMatch setting Headers.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Example JSON: &quot;SingleHeader&quot;: { &quot;Name&quot;: &quot;haystack&quot; }
    /// </summary>
    [JsonPropertyName("singleHeader")]
    public V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchSingleHeader? SingleHeader { get; set; }

    /// <summary>
    /// Inspect one query argument in the web request, identified by name, for example
    /// UserName or SalesRegion. The name isn&apos;t case sensitive.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Example JSON: &quot;SingleQueryArgument&quot;: { &quot;Name&quot;: &quot;myArgument&quot; }
    /// </summary>
    [JsonPropertyName("singleQueryArgument")]
    public V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatchSingleQueryArgument? SingleQueryArgument { get; set; }

    /// <summary>
    /// Inspect the path component of the URI of the web request. This is the part
    /// of the web request that identifies a resource. For example, /images/daily-ad.jpg.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;UriPath&quot;: {}
    /// </summary>
    [JsonPropertyName("uriPath")]
    public IDictionary<string, string>? UriPath { get; set; }
}

/// <summary>
/// Text transformations eliminate some of the unusual formatting that attackers
/// use in web requests in an effort to bypass detection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementTextTransformations
{
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A rule statement used to search web request components for a match against
/// a single regular expression.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexMatchStatement
{
    /// <summary>
    /// Specifies a web request component to be used in a rule match statement or
    /// in a logging configuration.
    /// 
    ///    * In a rule statement, this is the part of the web request that you want
    ///    WAF to inspect. Include the single FieldToMatch type that you want to
    ///    inspect, with additional specifications as needed, according to the type.
    ///    You specify a single request component in FieldToMatch for each rule statement
    ///    that requires it. To inspect more than one component of the web request,
    ///    create a separate rule statement for each component. Example JSON for
    ///    a QueryString field to match: &quot;FieldToMatch&quot;: { &quot;QueryString&quot;: {} } Example
    ///    JSON for a Method field to match specification: &quot;FieldToMatch&quot;: { &quot;Method&quot;:
    ///    { &quot;Name&quot;: &quot;DELETE&quot; } }
    /// 
    ///    * In a logging configuration, this is used in the RedactedFields property
    ///    to specify a field to redact from the logging records. For this use case,
    ///    note the following: Even though all FieldToMatch settings are available,
    ///    the only valid settings for field redaction are UriPath, QueryString,
    ///    SingleHeader, and Method. In this documentation, the descriptions of the
    ///    individual fields talk about specifying the web request component to inspect,
    ///    but for field redaction, you are specifying the component type to redact
    ///    from the logs. If you have request sampling enabled, the redacted fields
    ///    configuration for logging has no impact on sampling. The only way to exclude
    ///    fields from request sampling is by disabling sampling in the web ACL visibility
    ///    configuration.
    /// </summary>
    [JsonPropertyName("fieldToMatch")]
    public V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementFieldToMatch? FieldToMatch { get; set; }

    [JsonPropertyName("regexString")]
    public string? RegexString { get; set; }

    [JsonPropertyName("textTransformations")]
    public IList<V1alpha1RuleGroupSpecRulesStatementRegexMatchStatementTextTransformations>? TextTransformations { get; set; }
}

/// <summary>
/// Inspect the body of the web request. The body immediately follows the request
/// headers.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchBody
{
    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// The filter to use to identify the subset of cookies to inspect in a web request.
/// 
/// You must specify exactly one setting: either All, IncludedCookies, or ExcludedCookies.
/// 
/// Example JSON: &quot;MatchPattern&quot;: { &quot;IncludedCookies&quot;: [ &quot;session-id-time&quot;, &quot;session-id&quot;
/// ] }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchCookiesMatchPattern
{
    /// <summary>
    /// Inspect all of the elements that WAF has parsed and extracted from the web
    /// request component that you&apos;ve identified in your FieldToMatch specifications.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;All&quot;: {}
    /// </summary>
    [JsonPropertyName("all")]
    public IDictionary<string, string>? All { get; set; }

    [JsonPropertyName("excludedCookies")]
    public IList<string>? ExcludedCookies { get; set; }

    [JsonPropertyName("includedCookies")]
    public IList<string>? IncludedCookies { get; set; }
}

/// <summary>
/// Inspect the cookies in the web request. You can specify the parts of the
/// cookies to inspect and you can narrow the set of cookies to inspect by including
/// or excluding specific keys.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Example JSON: &quot;Cookies&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
/// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchCookies
{
    /// <summary>
    /// The filter to use to identify the subset of cookies to inspect in a web request.
    /// 
    /// You must specify exactly one setting: either All, IncludedCookies, or ExcludedCookies.
    /// 
    /// Example JSON: &quot;MatchPattern&quot;: { &quot;IncludedCookies&quot;: [ &quot;session-id-time&quot;, &quot;session-id&quot;
    /// ] }
    /// </summary>
    [JsonPropertyName("matchPattern")]
    public V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchCookiesMatchPattern? MatchPattern { get; set; }

    [JsonPropertyName("matchScope")]
    public string? MatchScope { get; set; }

    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// Inspect a string containing the list of the request&apos;s header names, ordered
/// as they appear in the web requestthat WAF receives for inspection. WAF generates
/// the string and then uses that as the field to match component in its inspection.
/// WAF separates the header names in the string using colons and no added spaces,
/// for example host:user-agent:accept:authorization:referer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchHeaderOrder
{
    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// The filter to use to identify the subset of headers to inspect in a web request.
/// 
/// You must specify exactly one setting: either All, IncludedHeaders, or ExcludedHeaders.
/// 
/// Example JSON: &quot;MatchPattern&quot;: { &quot;ExcludedHeaders&quot;: [ &quot;KeyToExclude1&quot;, &quot;KeyToExclude2&quot;
/// ] }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchHeadersMatchPattern
{
    /// <summary>
    /// Inspect all of the elements that WAF has parsed and extracted from the web
    /// request component that you&apos;ve identified in your FieldToMatch specifications.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;All&quot;: {}
    /// </summary>
    [JsonPropertyName("all")]
    public IDictionary<string, string>? All { get; set; }

    [JsonPropertyName("excludedHeaders")]
    public IList<string>? ExcludedHeaders { get; set; }

    [JsonPropertyName("includedHeaders")]
    public IList<string>? IncludedHeaders { get; set; }
}

/// <summary>
/// Inspect all headers in the web request. You can specify the parts of the
/// headers to inspect and you can narrow the set of headers to inspect by including
/// or excluding specific keys.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// If you want to inspect just the value of a single header, use the SingleHeader
/// FieldToMatch setting instead.
/// 
/// Example JSON: &quot;Headers&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
/// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchHeaders
{
    /// <summary>
    /// The filter to use to identify the subset of headers to inspect in a web request.
    /// 
    /// You must specify exactly one setting: either All, IncludedHeaders, or ExcludedHeaders.
    /// 
    /// Example JSON: &quot;MatchPattern&quot;: { &quot;ExcludedHeaders&quot;: [ &quot;KeyToExclude1&quot;, &quot;KeyToExclude2&quot;
    /// ] }
    /// </summary>
    [JsonPropertyName("matchPattern")]
    public V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchHeadersMatchPattern? MatchPattern { get; set; }

    [JsonPropertyName("matchScope")]
    public string? MatchScope { get; set; }

    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// Available for use with Amazon CloudFront distributions and Application Load
/// Balancers. Match against the request&apos;s JA3 fingerprint. The JA3 fingerprint
/// is a 32-character hash derived from the TLS Client Hello of an incoming request.
/// This fingerprint serves as a unique identifier for the client&apos;s TLS configuration.
/// WAF calculates and logs this fingerprint for each request that has enough
/// TLS Client Hello information for the calculation. Almost all web requests
/// include this information.
/// 
/// You can use this choice only with a string match ByteMatchStatement with
/// the PositionalConstraint set to EXACTLY.
/// 
/// You can obtain the JA3 fingerprint for client requests from the web ACL logs.
/// If WAF is able to calculate the fingerprint, it includes it in the logs.
/// For information about the logging fields, see Log fields (https://docs.aws.amazon.com/waf/latest/developerguide/logging-fields.html)
/// in the WAF Developer Guide.
/// 
/// Provide the JA3 fingerprint string from the logs in your string match statement
/// specification, to match with any future requests that have the same TLS configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchJa3Fingerprint
{
    [JsonPropertyName("fallbackBehavior")]
    public string? FallbackBehavior { get; set; }
}

/// <summary>
/// The patterns to look for in the JSON body. WAF inspects the results of these
/// pattern matches against the rule inspection criteria. This is used with the
/// FieldToMatch option JsonBody.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchJsonBodyMatchPattern
{
    /// <summary>
    /// Inspect all of the elements that WAF has parsed and extracted from the web
    /// request component that you&apos;ve identified in your FieldToMatch specifications.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;All&quot;: {}
    /// </summary>
    [JsonPropertyName("all")]
    public IDictionary<string, string>? All { get; set; }

    [JsonPropertyName("includedPaths")]
    public IList<string>? IncludedPaths { get; set; }
}

/// <summary>
/// Inspect the body of the web request as JSON. The body immediately follows
/// the request headers.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Use the specifications in this object to indicate which parts of the JSON
/// body to inspect using the rule&apos;s inspection criteria. WAF inspects only the
/// parts of the JSON that result from the matches that you indicate.
/// 
/// Example JSON: &quot;JsonBody&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;:
/// &quot;ALL&quot; }
/// 
/// For additional information about this request component option, see JSON
/// body (https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-fields-list.html#waf-rule-statement-request-component-json-body)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchJsonBody
{
    [JsonPropertyName("invalidFallbackBehavior")]
    public string? InvalidFallbackBehavior { get; set; }

    /// <summary>
    /// The patterns to look for in the JSON body. WAF inspects the results of these
    /// pattern matches against the rule inspection criteria. This is used with the
    /// FieldToMatch option JsonBody.
    /// </summary>
    [JsonPropertyName("matchPattern")]
    public V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchJsonBodyMatchPattern? MatchPattern { get; set; }

    [JsonPropertyName("matchScope")]
    public string? MatchScope { get; set; }

    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// Inspect one of the headers in the web request, identified by name, for example,
/// User-Agent or Referer. The name isn&apos;t case sensitive.
/// 
/// You can filter and inspect all headers with the FieldToMatch setting Headers.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Example JSON: &quot;SingleHeader&quot;: { &quot;Name&quot;: &quot;haystack&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Inspect one query argument in the web request, identified by name, for example
/// UserName or SalesRegion. The name isn&apos;t case sensitive.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Example JSON: &quot;SingleQueryArgument&quot;: { &quot;Name&quot;: &quot;myArgument&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchSingleQueryArgument
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Specifies a web request component to be used in a rule match statement or
/// in a logging configuration.
/// 
///    * In a rule statement, this is the part of the web request that you want
///    WAF to inspect. Include the single FieldToMatch type that you want to
///    inspect, with additional specifications as needed, according to the type.
///    You specify a single request component in FieldToMatch for each rule statement
///    that requires it. To inspect more than one component of the web request,
///    create a separate rule statement for each component. Example JSON for
///    a QueryString field to match: &quot;FieldToMatch&quot;: { &quot;QueryString&quot;: {} } Example
///    JSON for a Method field to match specification: &quot;FieldToMatch&quot;: { &quot;Method&quot;:
///    { &quot;Name&quot;: &quot;DELETE&quot; } }
/// 
///    * In a logging configuration, this is used in the RedactedFields property
///    to specify a field to redact from the logging records. For this use case,
///    note the following: Even though all FieldToMatch settings are available,
///    the only valid settings for field redaction are UriPath, QueryString,
///    SingleHeader, and Method. In this documentation, the descriptions of the
///    individual fields talk about specifying the web request component to inspect,
///    but for field redaction, you are specifying the component type to redact
///    from the logs. If you have request sampling enabled, the redacted fields
///    configuration for logging has no impact on sampling. The only way to exclude
///    fields from request sampling is by disabling sampling in the web ACL visibility
///    configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatch
{
    /// <summary>
    /// Inspect all query arguments of the web request.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;AllQueryArguments&quot;: {}
    /// </summary>
    [JsonPropertyName("allQueryArguments")]
    public IDictionary<string, string>? AllQueryArguments { get; set; }

    /// <summary>
    /// Inspect the body of the web request. The body immediately follows the request
    /// headers.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// </summary>
    [JsonPropertyName("body")]
    public V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchBody? Body { get; set; }

    /// <summary>
    /// Inspect the cookies in the web request. You can specify the parts of the
    /// cookies to inspect and you can narrow the set of cookies to inspect by including
    /// or excluding specific keys.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Example JSON: &quot;Cookies&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
    /// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
    /// </summary>
    [JsonPropertyName("cookies")]
    public V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchCookies? Cookies { get; set; }

    /// <summary>
    /// Inspect a string containing the list of the request&apos;s header names, ordered
    /// as they appear in the web requestthat WAF receives for inspection. WAF generates
    /// the string and then uses that as the field to match component in its inspection.
    /// WAF separates the header names in the string using colons and no added spaces,
    /// for example host:user-agent:accept:authorization:referer.
    /// </summary>
    [JsonPropertyName("headerOrder")]
    public V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchHeaderOrder? HeaderOrder { get; set; }

    /// <summary>
    /// Inspect all headers in the web request. You can specify the parts of the
    /// headers to inspect and you can narrow the set of headers to inspect by including
    /// or excluding specific keys.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// If you want to inspect just the value of a single header, use the SingleHeader
    /// FieldToMatch setting instead.
    /// 
    /// Example JSON: &quot;Headers&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
    /// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
    /// </summary>
    [JsonPropertyName("headers")]
    public V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchHeaders? Headers { get; set; }

    /// <summary>
    /// Available for use with Amazon CloudFront distributions and Application Load
    /// Balancers. Match against the request&apos;s JA3 fingerprint. The JA3 fingerprint
    /// is a 32-character hash derived from the TLS Client Hello of an incoming request.
    /// This fingerprint serves as a unique identifier for the client&apos;s TLS configuration.
    /// WAF calculates and logs this fingerprint for each request that has enough
    /// TLS Client Hello information for the calculation. Almost all web requests
    /// include this information.
    /// 
    /// You can use this choice only with a string match ByteMatchStatement with
    /// the PositionalConstraint set to EXACTLY.
    /// 
    /// You can obtain the JA3 fingerprint for client requests from the web ACL logs.
    /// If WAF is able to calculate the fingerprint, it includes it in the logs.
    /// For information about the logging fields, see Log fields (https://docs.aws.amazon.com/waf/latest/developerguide/logging-fields.html)
    /// in the WAF Developer Guide.
    /// 
    /// Provide the JA3 fingerprint string from the logs in your string match statement
    /// specification, to match with any future requests that have the same TLS configuration.
    /// </summary>
    [JsonPropertyName("ja3Fingerprint")]
    public V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchJa3Fingerprint? Ja3Fingerprint { get; set; }

    /// <summary>
    /// Inspect the body of the web request as JSON. The body immediately follows
    /// the request headers.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Use the specifications in this object to indicate which parts of the JSON
    /// body to inspect using the rule&apos;s inspection criteria. WAF inspects only the
    /// parts of the JSON that result from the matches that you indicate.
    /// 
    /// Example JSON: &quot;JsonBody&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;:
    /// &quot;ALL&quot; }
    /// 
    /// For additional information about this request component option, see JSON
    /// body (https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-fields-list.html#waf-rule-statement-request-component-json-body)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("jsonBody")]
    public V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchJsonBody? JsonBody { get; set; }

    /// <summary>
    /// Inspect the HTTP method of the web request. The method indicates the type
    /// of operation that the request is asking the origin to perform.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;Method&quot;: {}
    /// </summary>
    [JsonPropertyName("method")]
    public IDictionary<string, string>? Method { get; set; }

    /// <summary>
    /// Inspect the query string of the web request. This is the part of a URL that
    /// appears after a ? character, if any.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;QueryString&quot;: {}
    /// </summary>
    [JsonPropertyName("queryString")]
    public IDictionary<string, string>? QueryString { get; set; }

    /// <summary>
    /// Inspect one of the headers in the web request, identified by name, for example,
    /// User-Agent or Referer. The name isn&apos;t case sensitive.
    /// 
    /// You can filter and inspect all headers with the FieldToMatch setting Headers.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Example JSON: &quot;SingleHeader&quot;: { &quot;Name&quot;: &quot;haystack&quot; }
    /// </summary>
    [JsonPropertyName("singleHeader")]
    public V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader? SingleHeader { get; set; }

    /// <summary>
    /// Inspect one query argument in the web request, identified by name, for example
    /// UserName or SalesRegion. The name isn&apos;t case sensitive.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Example JSON: &quot;SingleQueryArgument&quot;: { &quot;Name&quot;: &quot;myArgument&quot; }
    /// </summary>
    [JsonPropertyName("singleQueryArgument")]
    public V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatchSingleQueryArgument? SingleQueryArgument { get; set; }

    /// <summary>
    /// Inspect the path component of the URI of the web request. This is the part
    /// of the web request that identifies a resource. For example, /images/daily-ad.jpg.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;UriPath&quot;: {}
    /// </summary>
    [JsonPropertyName("uriPath")]
    public IDictionary<string, string>? UriPath { get; set; }
}

/// <summary>
/// Text transformations eliminate some of the unusual formatting that attackers
/// use in web requests in an effort to bypass detection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementTextTransformations
{
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A rule statement used to search web request components for matches with regular
/// expressions. To use this, create a RegexPatternSet that specifies the expressions
/// that you want to detect, then use the ARN of that set in this statement.
/// A web request matches the pattern set rule statement if the request component
/// matches any of the patterns in the set. To create a regex pattern set, see
/// CreateRegexPatternSet.
/// 
/// Each regex pattern set rule statement references a regex pattern set. You
/// create and maintain the set independent of your rules. This allows you to
/// use the single set in multiple rules. When you update the referenced set,
/// WAF automatically updates all rules that reference it.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatement
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// Specifies a web request component to be used in a rule match statement or
    /// in a logging configuration.
    /// 
    ///    * In a rule statement, this is the part of the web request that you want
    ///    WAF to inspect. Include the single FieldToMatch type that you want to
    ///    inspect, with additional specifications as needed, according to the type.
    ///    You specify a single request component in FieldToMatch for each rule statement
    ///    that requires it. To inspect more than one component of the web request,
    ///    create a separate rule statement for each component. Example JSON for
    ///    a QueryString field to match: &quot;FieldToMatch&quot;: { &quot;QueryString&quot;: {} } Example
    ///    JSON for a Method field to match specification: &quot;FieldToMatch&quot;: { &quot;Method&quot;:
    ///    { &quot;Name&quot;: &quot;DELETE&quot; } }
    /// 
    ///    * In a logging configuration, this is used in the RedactedFields property
    ///    to specify a field to redact from the logging records. For this use case,
    ///    note the following: Even though all FieldToMatch settings are available,
    ///    the only valid settings for field redaction are UriPath, QueryString,
    ///    SingleHeader, and Method. In this documentation, the descriptions of the
    ///    individual fields talk about specifying the web request component to inspect,
    ///    but for field redaction, you are specifying the component type to redact
    ///    from the logs. If you have request sampling enabled, the redacted fields
    ///    configuration for logging has no impact on sampling. The only way to exclude
    ///    fields from request sampling is by disabling sampling in the web ACL visibility
    ///    configuration.
    /// </summary>
    [JsonPropertyName("fieldToMatch")]
    public V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementFieldToMatch? FieldToMatch { get; set; }

    [JsonPropertyName("textTransformations")]
    public IList<V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatementTextTransformations>? TextTransformations { get; set; }
}

/// <summary>
/// Specifies a single rule in a rule group whose action you want to override
/// to Count.
/// 
/// Instead of this option, use RuleActionOverrides. It accepts any valid action
/// setting, including Count.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementExcludedRules
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A custom header for custom request and response handling. This is used in
/// CustomResponse and CustomRequestHandling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseAllowCustomRequestHandlingInsertHeaders
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Custom request handling behavior that inserts custom headers into a web request.
/// You can add custom request handling for WAF to use when the rule action doesn&apos;t
/// block the request. For example, CaptchaAction for requests with valid t okens,
/// and AllowAction.
/// 
/// For information about customizing web requests and responses, see Customizing
/// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseAllowCustomRequestHandling
{
    [JsonPropertyName("insertHeaders")]
    public IList<V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseAllowCustomRequestHandlingInsertHeaders>? InsertHeaders { get; set; }
}

/// <summary>
/// Specifies that WAF should allow the request and optionally defines additional
/// custom handling for the request.
/// 
/// This is used in the context of other settings, for example to specify values
/// for RuleAction and web ACL DefaultAction.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseAllow
{
    /// <summary>
    /// Custom request handling behavior that inserts custom headers into a web request.
    /// You can add custom request handling for WAF to use when the rule action doesn&apos;t
    /// block the request. For example, CaptchaAction for requests with valid t okens,
    /// and AllowAction.
    /// 
    /// For information about customizing web requests and responses, see Customizing
    /// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("customRequestHandling")]
    public V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseAllowCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// A custom header for custom request and response handling. This is used in
/// CustomResponse and CustomRequestHandling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseBlockCustomResponseResponseHeaders
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// A custom response to send to the client. You can define a custom response
/// for rule actions and default web ACL actions that are set to BlockAction.
/// 
/// For information about customizing web requests and responses, see Customizing
/// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseBlockCustomResponse
{
    [JsonPropertyName("customResponseBodyKey")]
    public string? CustomResponseBodyKey { get; set; }

    [JsonPropertyName("responseCode")]
    public long? ResponseCode { get; set; }

    [JsonPropertyName("responseHeaders")]
    public IList<V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseBlockCustomResponseResponseHeaders>? ResponseHeaders { get; set; }
}

/// <summary>
/// Specifies that WAF should block the request and optionally defines additional
/// custom handling for the response to the web request.
/// 
/// This is used in the context of other settings, for example to specify values
/// for RuleAction and web ACL DefaultAction.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseBlock
{
    /// <summary>
    /// A custom response to send to the client. You can define a custom response
    /// for rule actions and default web ACL actions that are set to BlockAction.
    /// 
    /// For information about customizing web requests and responses, see Customizing
    /// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("customResponse")]
    public V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseBlockCustomResponse? CustomResponse { get; set; }
}

/// <summary>
/// A custom header for custom request and response handling. This is used in
/// CustomResponse and CustomRequestHandling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseCaptchaCustomRequestHandlingInsertHeaders
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Custom request handling behavior that inserts custom headers into a web request.
/// You can add custom request handling for WAF to use when the rule action doesn&apos;t
/// block the request. For example, CaptchaAction for requests with valid t okens,
/// and AllowAction.
/// 
/// For information about customizing web requests and responses, see Customizing
/// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseCaptchaCustomRequestHandling
{
    [JsonPropertyName("insertHeaders")]
    public IList<V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseCaptchaCustomRequestHandlingInsertHeaders>? InsertHeaders { get; set; }
}

/// <summary>
/// Specifies that WAF should run a CAPTCHA check against the request:
/// 
///    * If the request includes a valid, unexpired CAPTCHA token, WAF applies
///    any custom request handling and labels that you&apos;ve configured and then
///    allows the web request inspection to proceed to the next rule, similar
///    to a CountAction.
/// 
///    * If the request doesn&apos;t include a valid, unexpired token, WAF discontinues
///    the web ACL evaluation of the request and blocks it from going to its
///    intended destination. WAF generates a response that it sends back to the
///    client, which includes the following: The header x-amzn-waf-action with
///    a value of captcha. The HTTP status code 405 Method Not Allowed. If the
///    request contains an Accept header with a value of text/html, the response
///    includes a CAPTCHA JavaScript page interstitial.
/// 
/// You can configure the expiration time in the CaptchaConfig ImmunityTimeProperty
/// setting at the rule and web ACL level. The rule setting overrides the web
/// ACL setting.
/// 
/// This action option is available for rules. It isn&apos;t available for web ACL
/// default actions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseCaptcha
{
    /// <summary>
    /// Custom request handling behavior that inserts custom headers into a web request.
    /// You can add custom request handling for WAF to use when the rule action doesn&apos;t
    /// block the request. For example, CaptchaAction for requests with valid t okens,
    /// and AllowAction.
    /// 
    /// For information about customizing web requests and responses, see Customizing
    /// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("customRequestHandling")]
    public V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseCaptchaCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// A custom header for custom request and response handling. This is used in
/// CustomResponse and CustomRequestHandling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseChallengeCustomRequestHandlingInsertHeaders
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Custom request handling behavior that inserts custom headers into a web request.
/// You can add custom request handling for WAF to use when the rule action doesn&apos;t
/// block the request. For example, CaptchaAction for requests with valid t okens,
/// and AllowAction.
/// 
/// For information about customizing web requests and responses, see Customizing
/// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseChallengeCustomRequestHandling
{
    [JsonPropertyName("insertHeaders")]
    public IList<V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseChallengeCustomRequestHandlingInsertHeaders>? InsertHeaders { get; set; }
}

/// <summary>
/// Specifies that WAF should run a Challenge check against the request to verify
/// that the request is coming from a legitimate client session:
/// 
///    * If the request includes a valid, unexpired challenge token, WAF applies
///    any custom request handling and labels that you&apos;ve configured and then
///    allows the web request inspection to proceed to the next rule, similar
///    to a CountAction.
/// 
///    * If the request doesn&apos;t include a valid, unexpired challenge token, WAF
///    discontinues the web ACL evaluation of the request and blocks it from
///    going to its intended destination. WAF then generates a challenge response
///    that it sends back to the client, which includes the following: The header
///    x-amzn-waf-action with a value of challenge. The HTTP status code 202
///    Request Accepted. If the request contains an Accept header with a value
///    of text/html, the response includes a JavaScript page interstitial with
///    a challenge script. Challenges run silent browser interrogations in the
///    background, and don&apos;t generally affect the end user experience. A challenge
///    enforces token acquisition using an interstitial JavaScript challenge
///    that inspects the client session for legitimate behavior. The challenge
///    blocks bots or at least increases the cost of operating sophisticated
///    bots. After the client session successfully responds to the challenge,
///    it receives a new token from WAF, which the challenge script uses to resubmit
///    the original request.
/// 
/// You can configure the expiration time in the ChallengeConfig ImmunityTimeProperty
/// setting at the rule and web ACL level. The rule setting overrides the web
/// ACL setting.
/// 
/// This action option is available for rules. It isn&apos;t available for web ACL
/// default actions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseChallenge
{
    /// <summary>
    /// Custom request handling behavior that inserts custom headers into a web request.
    /// You can add custom request handling for WAF to use when the rule action doesn&apos;t
    /// block the request. For example, CaptchaAction for requests with valid t okens,
    /// and AllowAction.
    /// 
    /// For information about customizing web requests and responses, see Customizing
    /// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("customRequestHandling")]
    public V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseChallengeCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// A custom header for custom request and response handling. This is used in
/// CustomResponse and CustomRequestHandling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseCountCustomRequestHandlingInsertHeaders
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Custom request handling behavior that inserts custom headers into a web request.
/// You can add custom request handling for WAF to use when the rule action doesn&apos;t
/// block the request. For example, CaptchaAction for requests with valid t okens,
/// and AllowAction.
/// 
/// For information about customizing web requests and responses, see Customizing
/// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseCountCustomRequestHandling
{
    [JsonPropertyName("insertHeaders")]
    public IList<V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseCountCustomRequestHandlingInsertHeaders>? InsertHeaders { get; set; }
}

/// <summary>
/// Specifies that WAF should count the request. Optionally defines additional
/// custom handling for the request.
/// 
/// This is used in the context of other settings, for example to specify values
/// for RuleAction and web ACL DefaultAction.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseCount
{
    /// <summary>
    /// Custom request handling behavior that inserts custom headers into a web request.
    /// You can add custom request handling for WAF to use when the rule action doesn&apos;t
    /// block the request. For example, CaptchaAction for requests with valid t okens,
    /// and AllowAction.
    /// 
    /// For information about customizing web requests and responses, see Customizing
    /// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("customRequestHandling")]
    public V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseCountCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// The action that WAF should take on a web request when it matches a rule&apos;s
/// statement. Settings at the web ACL level can override the rule action setting.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUse
{
    /// <summary>
    /// Specifies that WAF should allow the request and optionally defines additional
    /// custom handling for the request.
    /// 
    /// This is used in the context of other settings, for example to specify values
    /// for RuleAction and web ACL DefaultAction.
    /// </summary>
    [JsonPropertyName("allow")]
    public V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseAllow? Allow { get; set; }

    /// <summary>
    /// Specifies that WAF should block the request and optionally defines additional
    /// custom handling for the response to the web request.
    /// 
    /// This is used in the context of other settings, for example to specify values
    /// for RuleAction and web ACL DefaultAction.
    /// </summary>
    [JsonPropertyName("block")]
    public V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseBlock? Block { get; set; }

    /// <summary>
    /// Specifies that WAF should run a CAPTCHA check against the request:
    /// 
    ///    * If the request includes a valid, unexpired CAPTCHA token, WAF applies
    ///    any custom request handling and labels that you&apos;ve configured and then
    ///    allows the web request inspection to proceed to the next rule, similar
    ///    to a CountAction.
    /// 
    ///    * If the request doesn&apos;t include a valid, unexpired token, WAF discontinues
    ///    the web ACL evaluation of the request and blocks it from going to its
    ///    intended destination. WAF generates a response that it sends back to the
    ///    client, which includes the following: The header x-amzn-waf-action with
    ///    a value of captcha. The HTTP status code 405 Method Not Allowed. If the
    ///    request contains an Accept header with a value of text/html, the response
    ///    includes a CAPTCHA JavaScript page interstitial.
    /// 
    /// You can configure the expiration time in the CaptchaConfig ImmunityTimeProperty
    /// setting at the rule and web ACL level. The rule setting overrides the web
    /// ACL setting.
    /// 
    /// This action option is available for rules. It isn&apos;t available for web ACL
    /// default actions.
    /// </summary>
    [JsonPropertyName("captcha")]
    public V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseCaptcha? Captcha { get; set; }

    /// <summary>
    /// Specifies that WAF should run a Challenge check against the request to verify
    /// that the request is coming from a legitimate client session:
    /// 
    ///    * If the request includes a valid, unexpired challenge token, WAF applies
    ///    any custom request handling and labels that you&apos;ve configured and then
    ///    allows the web request inspection to proceed to the next rule, similar
    ///    to a CountAction.
    /// 
    ///    * If the request doesn&apos;t include a valid, unexpired challenge token, WAF
    ///    discontinues the web ACL evaluation of the request and blocks it from
    ///    going to its intended destination. WAF then generates a challenge response
    ///    that it sends back to the client, which includes the following: The header
    ///    x-amzn-waf-action with a value of challenge. The HTTP status code 202
    ///    Request Accepted. If the request contains an Accept header with a value
    ///    of text/html, the response includes a JavaScript page interstitial with
    ///    a challenge script. Challenges run silent browser interrogations in the
    ///    background, and don&apos;t generally affect the end user experience. A challenge
    ///    enforces token acquisition using an interstitial JavaScript challenge
    ///    that inspects the client session for legitimate behavior. The challenge
    ///    blocks bots or at least increases the cost of operating sophisticated
    ///    bots. After the client session successfully responds to the challenge,
    ///    it receives a new token from WAF, which the challenge script uses to resubmit
    ///    the original request.
    /// 
    /// You can configure the expiration time in the ChallengeConfig ImmunityTimeProperty
    /// setting at the rule and web ACL level. The rule setting overrides the web
    /// ACL setting.
    /// 
    /// This action option is available for rules. It isn&apos;t available for web ACL
    /// default actions.
    /// </summary>
    [JsonPropertyName("challenge")]
    public V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseChallenge? Challenge { get; set; }

    /// <summary>
    /// Specifies that WAF should count the request. Optionally defines additional
    /// custom handling for the request.
    /// 
    /// This is used in the context of other settings, for example to specify values
    /// for RuleAction and web ACL DefaultAction.
    /// </summary>
    [JsonPropertyName("count")]
    public V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUseCount? Count { get; set; }
}

/// <summary>
/// Action setting to use in the place of a rule action that is configured inside
/// the rule group. You specify one override for each rule whose action you want
/// to change.
/// 
/// You can use overrides for testing, for example you can override all of rule
/// actions to Count and then monitor the resulting count metrics to understand
/// how the rule group would handle your web traffic. You can also permanently
/// override some or all actions, to modify how the rule group manages your web
/// traffic.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverrides
{
    /// <summary>
    /// The action that WAF should take on a web request when it matches a rule&apos;s
    /// statement. Settings at the web ACL level can override the rule action setting.
    /// </summary>
    [JsonPropertyName("actionToUse")]
    public V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverridesActionToUse? ActionToUse { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A rule statement used to run the rules that are defined in a RuleGroup. To
/// use this, create a rule group with your rules, then provide the ARN of the
/// rule group in this statement.
/// 
/// You cannot nest a RuleGroupReferenceStatement, for example for use inside
/// a NotStatement or OrStatement. You cannot use a rule group reference statement
/// inside another rule group. You can only reference a rule group as a top-level
/// statement within a rule that you define in a web ACL.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatement
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    [JsonPropertyName("excludedRules")]
    public IList<V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementExcludedRules>? ExcludedRules { get; set; }

    [JsonPropertyName("ruleActionOverrides")]
    public IList<V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatementRuleActionOverrides>? RuleActionOverrides { get; set; }
}

/// <summary>
/// Inspect the body of the web request. The body immediately follows the request
/// headers.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchBody
{
    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// The filter to use to identify the subset of cookies to inspect in a web request.
/// 
/// You must specify exactly one setting: either All, IncludedCookies, or ExcludedCookies.
/// 
/// Example JSON: &quot;MatchPattern&quot;: { &quot;IncludedCookies&quot;: [ &quot;session-id-time&quot;, &quot;session-id&quot;
/// ] }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchCookiesMatchPattern
{
    /// <summary>
    /// Inspect all of the elements that WAF has parsed and extracted from the web
    /// request component that you&apos;ve identified in your FieldToMatch specifications.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;All&quot;: {}
    /// </summary>
    [JsonPropertyName("all")]
    public IDictionary<string, string>? All { get; set; }

    [JsonPropertyName("excludedCookies")]
    public IList<string>? ExcludedCookies { get; set; }

    [JsonPropertyName("includedCookies")]
    public IList<string>? IncludedCookies { get; set; }
}

/// <summary>
/// Inspect the cookies in the web request. You can specify the parts of the
/// cookies to inspect and you can narrow the set of cookies to inspect by including
/// or excluding specific keys.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Example JSON: &quot;Cookies&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
/// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchCookies
{
    /// <summary>
    /// The filter to use to identify the subset of cookies to inspect in a web request.
    /// 
    /// You must specify exactly one setting: either All, IncludedCookies, or ExcludedCookies.
    /// 
    /// Example JSON: &quot;MatchPattern&quot;: { &quot;IncludedCookies&quot;: [ &quot;session-id-time&quot;, &quot;session-id&quot;
    /// ] }
    /// </summary>
    [JsonPropertyName("matchPattern")]
    public V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchCookiesMatchPattern? MatchPattern { get; set; }

    [JsonPropertyName("matchScope")]
    public string? MatchScope { get; set; }

    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// Inspect a string containing the list of the request&apos;s header names, ordered
/// as they appear in the web requestthat WAF receives for inspection. WAF generates
/// the string and then uses that as the field to match component in its inspection.
/// WAF separates the header names in the string using colons and no added spaces,
/// for example host:user-agent:accept:authorization:referer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchHeaderOrder
{
    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// The filter to use to identify the subset of headers to inspect in a web request.
/// 
/// You must specify exactly one setting: either All, IncludedHeaders, or ExcludedHeaders.
/// 
/// Example JSON: &quot;MatchPattern&quot;: { &quot;ExcludedHeaders&quot;: [ &quot;KeyToExclude1&quot;, &quot;KeyToExclude2&quot;
/// ] }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchHeadersMatchPattern
{
    /// <summary>
    /// Inspect all of the elements that WAF has parsed and extracted from the web
    /// request component that you&apos;ve identified in your FieldToMatch specifications.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;All&quot;: {}
    /// </summary>
    [JsonPropertyName("all")]
    public IDictionary<string, string>? All { get; set; }

    [JsonPropertyName("excludedHeaders")]
    public IList<string>? ExcludedHeaders { get; set; }

    [JsonPropertyName("includedHeaders")]
    public IList<string>? IncludedHeaders { get; set; }
}

/// <summary>
/// Inspect all headers in the web request. You can specify the parts of the
/// headers to inspect and you can narrow the set of headers to inspect by including
/// or excluding specific keys.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// If you want to inspect just the value of a single header, use the SingleHeader
/// FieldToMatch setting instead.
/// 
/// Example JSON: &quot;Headers&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
/// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchHeaders
{
    /// <summary>
    /// The filter to use to identify the subset of headers to inspect in a web request.
    /// 
    /// You must specify exactly one setting: either All, IncludedHeaders, or ExcludedHeaders.
    /// 
    /// Example JSON: &quot;MatchPattern&quot;: { &quot;ExcludedHeaders&quot;: [ &quot;KeyToExclude1&quot;, &quot;KeyToExclude2&quot;
    /// ] }
    /// </summary>
    [JsonPropertyName("matchPattern")]
    public V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchHeadersMatchPattern? MatchPattern { get; set; }

    [JsonPropertyName("matchScope")]
    public string? MatchScope { get; set; }

    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// Available for use with Amazon CloudFront distributions and Application Load
/// Balancers. Match against the request&apos;s JA3 fingerprint. The JA3 fingerprint
/// is a 32-character hash derived from the TLS Client Hello of an incoming request.
/// This fingerprint serves as a unique identifier for the client&apos;s TLS configuration.
/// WAF calculates and logs this fingerprint for each request that has enough
/// TLS Client Hello information for the calculation. Almost all web requests
/// include this information.
/// 
/// You can use this choice only with a string match ByteMatchStatement with
/// the PositionalConstraint set to EXACTLY.
/// 
/// You can obtain the JA3 fingerprint for client requests from the web ACL logs.
/// If WAF is able to calculate the fingerprint, it includes it in the logs.
/// For information about the logging fields, see Log fields (https://docs.aws.amazon.com/waf/latest/developerguide/logging-fields.html)
/// in the WAF Developer Guide.
/// 
/// Provide the JA3 fingerprint string from the logs in your string match statement
/// specification, to match with any future requests that have the same TLS configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchJa3Fingerprint
{
    [JsonPropertyName("fallbackBehavior")]
    public string? FallbackBehavior { get; set; }
}

/// <summary>
/// The patterns to look for in the JSON body. WAF inspects the results of these
/// pattern matches against the rule inspection criteria. This is used with the
/// FieldToMatch option JsonBody.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchJsonBodyMatchPattern
{
    /// <summary>
    /// Inspect all of the elements that WAF has parsed and extracted from the web
    /// request component that you&apos;ve identified in your FieldToMatch specifications.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;All&quot;: {}
    /// </summary>
    [JsonPropertyName("all")]
    public IDictionary<string, string>? All { get; set; }

    [JsonPropertyName("includedPaths")]
    public IList<string>? IncludedPaths { get; set; }
}

/// <summary>
/// Inspect the body of the web request as JSON. The body immediately follows
/// the request headers.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Use the specifications in this object to indicate which parts of the JSON
/// body to inspect using the rule&apos;s inspection criteria. WAF inspects only the
/// parts of the JSON that result from the matches that you indicate.
/// 
/// Example JSON: &quot;JsonBody&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;:
/// &quot;ALL&quot; }
/// 
/// For additional information about this request component option, see JSON
/// body (https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-fields-list.html#waf-rule-statement-request-component-json-body)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchJsonBody
{
    [JsonPropertyName("invalidFallbackBehavior")]
    public string? InvalidFallbackBehavior { get; set; }

    /// <summary>
    /// The patterns to look for in the JSON body. WAF inspects the results of these
    /// pattern matches against the rule inspection criteria. This is used with the
    /// FieldToMatch option JsonBody.
    /// </summary>
    [JsonPropertyName("matchPattern")]
    public V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchJsonBodyMatchPattern? MatchPattern { get; set; }

    [JsonPropertyName("matchScope")]
    public string? MatchScope { get; set; }

    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// Inspect one of the headers in the web request, identified by name, for example,
/// User-Agent or Referer. The name isn&apos;t case sensitive.
/// 
/// You can filter and inspect all headers with the FieldToMatch setting Headers.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Example JSON: &quot;SingleHeader&quot;: { &quot;Name&quot;: &quot;haystack&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchSingleHeader
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Inspect one query argument in the web request, identified by name, for example
/// UserName or SalesRegion. The name isn&apos;t case sensitive.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Example JSON: &quot;SingleQueryArgument&quot;: { &quot;Name&quot;: &quot;myArgument&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchSingleQueryArgument
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Specifies a web request component to be used in a rule match statement or
/// in a logging configuration.
/// 
///    * In a rule statement, this is the part of the web request that you want
///    WAF to inspect. Include the single FieldToMatch type that you want to
///    inspect, with additional specifications as needed, according to the type.
///    You specify a single request component in FieldToMatch for each rule statement
///    that requires it. To inspect more than one component of the web request,
///    create a separate rule statement for each component. Example JSON for
///    a QueryString field to match: &quot;FieldToMatch&quot;: { &quot;QueryString&quot;: {} } Example
///    JSON for a Method field to match specification: &quot;FieldToMatch&quot;: { &quot;Method&quot;:
///    { &quot;Name&quot;: &quot;DELETE&quot; } }
/// 
///    * In a logging configuration, this is used in the RedactedFields property
///    to specify a field to redact from the logging records. For this use case,
///    note the following: Even though all FieldToMatch settings are available,
///    the only valid settings for field redaction are UriPath, QueryString,
///    SingleHeader, and Method. In this documentation, the descriptions of the
///    individual fields talk about specifying the web request component to inspect,
///    but for field redaction, you are specifying the component type to redact
///    from the logs. If you have request sampling enabled, the redacted fields
///    configuration for logging has no impact on sampling. The only way to exclude
///    fields from request sampling is by disabling sampling in the web ACL visibility
///    configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatch
{
    /// <summary>
    /// Inspect all query arguments of the web request.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;AllQueryArguments&quot;: {}
    /// </summary>
    [JsonPropertyName("allQueryArguments")]
    public IDictionary<string, string>? AllQueryArguments { get; set; }

    /// <summary>
    /// Inspect the body of the web request. The body immediately follows the request
    /// headers.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// </summary>
    [JsonPropertyName("body")]
    public V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchBody? Body { get; set; }

    /// <summary>
    /// Inspect the cookies in the web request. You can specify the parts of the
    /// cookies to inspect and you can narrow the set of cookies to inspect by including
    /// or excluding specific keys.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Example JSON: &quot;Cookies&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
    /// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
    /// </summary>
    [JsonPropertyName("cookies")]
    public V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchCookies? Cookies { get; set; }

    /// <summary>
    /// Inspect a string containing the list of the request&apos;s header names, ordered
    /// as they appear in the web requestthat WAF receives for inspection. WAF generates
    /// the string and then uses that as the field to match component in its inspection.
    /// WAF separates the header names in the string using colons and no added spaces,
    /// for example host:user-agent:accept:authorization:referer.
    /// </summary>
    [JsonPropertyName("headerOrder")]
    public V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchHeaderOrder? HeaderOrder { get; set; }

    /// <summary>
    /// Inspect all headers in the web request. You can specify the parts of the
    /// headers to inspect and you can narrow the set of headers to inspect by including
    /// or excluding specific keys.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// If you want to inspect just the value of a single header, use the SingleHeader
    /// FieldToMatch setting instead.
    /// 
    /// Example JSON: &quot;Headers&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
    /// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
    /// </summary>
    [JsonPropertyName("headers")]
    public V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchHeaders? Headers { get; set; }

    /// <summary>
    /// Available for use with Amazon CloudFront distributions and Application Load
    /// Balancers. Match against the request&apos;s JA3 fingerprint. The JA3 fingerprint
    /// is a 32-character hash derived from the TLS Client Hello of an incoming request.
    /// This fingerprint serves as a unique identifier for the client&apos;s TLS configuration.
    /// WAF calculates and logs this fingerprint for each request that has enough
    /// TLS Client Hello information for the calculation. Almost all web requests
    /// include this information.
    /// 
    /// You can use this choice only with a string match ByteMatchStatement with
    /// the PositionalConstraint set to EXACTLY.
    /// 
    /// You can obtain the JA3 fingerprint for client requests from the web ACL logs.
    /// If WAF is able to calculate the fingerprint, it includes it in the logs.
    /// For information about the logging fields, see Log fields (https://docs.aws.amazon.com/waf/latest/developerguide/logging-fields.html)
    /// in the WAF Developer Guide.
    /// 
    /// Provide the JA3 fingerprint string from the logs in your string match statement
    /// specification, to match with any future requests that have the same TLS configuration.
    /// </summary>
    [JsonPropertyName("ja3Fingerprint")]
    public V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchJa3Fingerprint? Ja3Fingerprint { get; set; }

    /// <summary>
    /// Inspect the body of the web request as JSON. The body immediately follows
    /// the request headers.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Use the specifications in this object to indicate which parts of the JSON
    /// body to inspect using the rule&apos;s inspection criteria. WAF inspects only the
    /// parts of the JSON that result from the matches that you indicate.
    /// 
    /// Example JSON: &quot;JsonBody&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;:
    /// &quot;ALL&quot; }
    /// 
    /// For additional information about this request component option, see JSON
    /// body (https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-fields-list.html#waf-rule-statement-request-component-json-body)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("jsonBody")]
    public V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchJsonBody? JsonBody { get; set; }

    /// <summary>
    /// Inspect the HTTP method of the web request. The method indicates the type
    /// of operation that the request is asking the origin to perform.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;Method&quot;: {}
    /// </summary>
    [JsonPropertyName("method")]
    public IDictionary<string, string>? Method { get; set; }

    /// <summary>
    /// Inspect the query string of the web request. This is the part of a URL that
    /// appears after a ? character, if any.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;QueryString&quot;: {}
    /// </summary>
    [JsonPropertyName("queryString")]
    public IDictionary<string, string>? QueryString { get; set; }

    /// <summary>
    /// Inspect one of the headers in the web request, identified by name, for example,
    /// User-Agent or Referer. The name isn&apos;t case sensitive.
    /// 
    /// You can filter and inspect all headers with the FieldToMatch setting Headers.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Example JSON: &quot;SingleHeader&quot;: { &quot;Name&quot;: &quot;haystack&quot; }
    /// </summary>
    [JsonPropertyName("singleHeader")]
    public V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchSingleHeader? SingleHeader { get; set; }

    /// <summary>
    /// Inspect one query argument in the web request, identified by name, for example
    /// UserName or SalesRegion. The name isn&apos;t case sensitive.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Example JSON: &quot;SingleQueryArgument&quot;: { &quot;Name&quot;: &quot;myArgument&quot; }
    /// </summary>
    [JsonPropertyName("singleQueryArgument")]
    public V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatchSingleQueryArgument? SingleQueryArgument { get; set; }

    /// <summary>
    /// Inspect the path component of the URI of the web request. This is the part
    /// of the web request that identifies a resource. For example, /images/daily-ad.jpg.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;UriPath&quot;: {}
    /// </summary>
    [JsonPropertyName("uriPath")]
    public IDictionary<string, string>? UriPath { get; set; }
}

/// <summary>
/// Text transformations eliminate some of the unusual formatting that attackers
/// use in web requests in an effort to bypass detection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementTextTransformations
{
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatement
{
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>
    /// Specifies a web request component to be used in a rule match statement or
    /// in a logging configuration.
    /// 
    ///    * In a rule statement, this is the part of the web request that you want
    ///    WAF to inspect. Include the single FieldToMatch type that you want to
    ///    inspect, with additional specifications as needed, according to the type.
    ///    You specify a single request component in FieldToMatch for each rule statement
    ///    that requires it. To inspect more than one component of the web request,
    ///    create a separate rule statement for each component. Example JSON for
    ///    a QueryString field to match: &quot;FieldToMatch&quot;: { &quot;QueryString&quot;: {} } Example
    ///    JSON for a Method field to match specification: &quot;FieldToMatch&quot;: { &quot;Method&quot;:
    ///    { &quot;Name&quot;: &quot;DELETE&quot; } }
    /// 
    ///    * In a logging configuration, this is used in the RedactedFields property
    ///    to specify a field to redact from the logging records. For this use case,
    ///    note the following: Even though all FieldToMatch settings are available,
    ///    the only valid settings for field redaction are UriPath, QueryString,
    ///    SingleHeader, and Method. In this documentation, the descriptions of the
    ///    individual fields talk about specifying the web request component to inspect,
    ///    but for field redaction, you are specifying the component type to redact
    ///    from the logs. If you have request sampling enabled, the redacted fields
    ///    configuration for logging has no impact on sampling. The only way to exclude
    ///    fields from request sampling is by disabling sampling in the web ACL visibility
    ///    configuration.
    /// </summary>
    [JsonPropertyName("fieldToMatch")]
    public V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementFieldToMatch? FieldToMatch { get; set; }

    [JsonPropertyName("size")]
    public long? Size { get; set; }

    [JsonPropertyName("textTransformations")]
    public IList<V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatementTextTransformations>? TextTransformations { get; set; }
}

/// <summary>
/// Inspect the body of the web request. The body immediately follows the request
/// headers.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchBody
{
    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// The filter to use to identify the subset of cookies to inspect in a web request.
/// 
/// You must specify exactly one setting: either All, IncludedCookies, or ExcludedCookies.
/// 
/// Example JSON: &quot;MatchPattern&quot;: { &quot;IncludedCookies&quot;: [ &quot;session-id-time&quot;, &quot;session-id&quot;
/// ] }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchCookiesMatchPattern
{
    /// <summary>
    /// Inspect all of the elements that WAF has parsed and extracted from the web
    /// request component that you&apos;ve identified in your FieldToMatch specifications.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;All&quot;: {}
    /// </summary>
    [JsonPropertyName("all")]
    public IDictionary<string, string>? All { get; set; }

    [JsonPropertyName("excludedCookies")]
    public IList<string>? ExcludedCookies { get; set; }

    [JsonPropertyName("includedCookies")]
    public IList<string>? IncludedCookies { get; set; }
}

/// <summary>
/// Inspect the cookies in the web request. You can specify the parts of the
/// cookies to inspect and you can narrow the set of cookies to inspect by including
/// or excluding specific keys.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Example JSON: &quot;Cookies&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
/// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchCookies
{
    /// <summary>
    /// The filter to use to identify the subset of cookies to inspect in a web request.
    /// 
    /// You must specify exactly one setting: either All, IncludedCookies, or ExcludedCookies.
    /// 
    /// Example JSON: &quot;MatchPattern&quot;: { &quot;IncludedCookies&quot;: [ &quot;session-id-time&quot;, &quot;session-id&quot;
    /// ] }
    /// </summary>
    [JsonPropertyName("matchPattern")]
    public V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchCookiesMatchPattern? MatchPattern { get; set; }

    [JsonPropertyName("matchScope")]
    public string? MatchScope { get; set; }

    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// Inspect a string containing the list of the request&apos;s header names, ordered
/// as they appear in the web requestthat WAF receives for inspection. WAF generates
/// the string and then uses that as the field to match component in its inspection.
/// WAF separates the header names in the string using colons and no added spaces,
/// for example host:user-agent:accept:authorization:referer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchHeaderOrder
{
    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// The filter to use to identify the subset of headers to inspect in a web request.
/// 
/// You must specify exactly one setting: either All, IncludedHeaders, or ExcludedHeaders.
/// 
/// Example JSON: &quot;MatchPattern&quot;: { &quot;ExcludedHeaders&quot;: [ &quot;KeyToExclude1&quot;, &quot;KeyToExclude2&quot;
/// ] }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchHeadersMatchPattern
{
    /// <summary>
    /// Inspect all of the elements that WAF has parsed and extracted from the web
    /// request component that you&apos;ve identified in your FieldToMatch specifications.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;All&quot;: {}
    /// </summary>
    [JsonPropertyName("all")]
    public IDictionary<string, string>? All { get; set; }

    [JsonPropertyName("excludedHeaders")]
    public IList<string>? ExcludedHeaders { get; set; }

    [JsonPropertyName("includedHeaders")]
    public IList<string>? IncludedHeaders { get; set; }
}

/// <summary>
/// Inspect all headers in the web request. You can specify the parts of the
/// headers to inspect and you can narrow the set of headers to inspect by including
/// or excluding specific keys.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// If you want to inspect just the value of a single header, use the SingleHeader
/// FieldToMatch setting instead.
/// 
/// Example JSON: &quot;Headers&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
/// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchHeaders
{
    /// <summary>
    /// The filter to use to identify the subset of headers to inspect in a web request.
    /// 
    /// You must specify exactly one setting: either All, IncludedHeaders, or ExcludedHeaders.
    /// 
    /// Example JSON: &quot;MatchPattern&quot;: { &quot;ExcludedHeaders&quot;: [ &quot;KeyToExclude1&quot;, &quot;KeyToExclude2&quot;
    /// ] }
    /// </summary>
    [JsonPropertyName("matchPattern")]
    public V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchHeadersMatchPattern? MatchPattern { get; set; }

    [JsonPropertyName("matchScope")]
    public string? MatchScope { get; set; }

    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// Available for use with Amazon CloudFront distributions and Application Load
/// Balancers. Match against the request&apos;s JA3 fingerprint. The JA3 fingerprint
/// is a 32-character hash derived from the TLS Client Hello of an incoming request.
/// This fingerprint serves as a unique identifier for the client&apos;s TLS configuration.
/// WAF calculates and logs this fingerprint for each request that has enough
/// TLS Client Hello information for the calculation. Almost all web requests
/// include this information.
/// 
/// You can use this choice only with a string match ByteMatchStatement with
/// the PositionalConstraint set to EXACTLY.
/// 
/// You can obtain the JA3 fingerprint for client requests from the web ACL logs.
/// If WAF is able to calculate the fingerprint, it includes it in the logs.
/// For information about the logging fields, see Log fields (https://docs.aws.amazon.com/waf/latest/developerguide/logging-fields.html)
/// in the WAF Developer Guide.
/// 
/// Provide the JA3 fingerprint string from the logs in your string match statement
/// specification, to match with any future requests that have the same TLS configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchJa3Fingerprint
{
    [JsonPropertyName("fallbackBehavior")]
    public string? FallbackBehavior { get; set; }
}

/// <summary>
/// The patterns to look for in the JSON body. WAF inspects the results of these
/// pattern matches against the rule inspection criteria. This is used with the
/// FieldToMatch option JsonBody.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchJsonBodyMatchPattern
{
    /// <summary>
    /// Inspect all of the elements that WAF has parsed and extracted from the web
    /// request component that you&apos;ve identified in your FieldToMatch specifications.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;All&quot;: {}
    /// </summary>
    [JsonPropertyName("all")]
    public IDictionary<string, string>? All { get; set; }

    [JsonPropertyName("includedPaths")]
    public IList<string>? IncludedPaths { get; set; }
}

/// <summary>
/// Inspect the body of the web request as JSON. The body immediately follows
/// the request headers.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Use the specifications in this object to indicate which parts of the JSON
/// body to inspect using the rule&apos;s inspection criteria. WAF inspects only the
/// parts of the JSON that result from the matches that you indicate.
/// 
/// Example JSON: &quot;JsonBody&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;:
/// &quot;ALL&quot; }
/// 
/// For additional information about this request component option, see JSON
/// body (https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-fields-list.html#waf-rule-statement-request-component-json-body)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchJsonBody
{
    [JsonPropertyName("invalidFallbackBehavior")]
    public string? InvalidFallbackBehavior { get; set; }

    /// <summary>
    /// The patterns to look for in the JSON body. WAF inspects the results of these
    /// pattern matches against the rule inspection criteria. This is used with the
    /// FieldToMatch option JsonBody.
    /// </summary>
    [JsonPropertyName("matchPattern")]
    public V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchJsonBodyMatchPattern? MatchPattern { get; set; }

    [JsonPropertyName("matchScope")]
    public string? MatchScope { get; set; }

    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// Inspect one of the headers in the web request, identified by name, for example,
/// User-Agent or Referer. The name isn&apos;t case sensitive.
/// 
/// You can filter and inspect all headers with the FieldToMatch setting Headers.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Example JSON: &quot;SingleHeader&quot;: { &quot;Name&quot;: &quot;haystack&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchSingleHeader
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Inspect one query argument in the web request, identified by name, for example
/// UserName or SalesRegion. The name isn&apos;t case sensitive.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Example JSON: &quot;SingleQueryArgument&quot;: { &quot;Name&quot;: &quot;myArgument&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchSingleQueryArgument
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Specifies a web request component to be used in a rule match statement or
/// in a logging configuration.
/// 
///    * In a rule statement, this is the part of the web request that you want
///    WAF to inspect. Include the single FieldToMatch type that you want to
///    inspect, with additional specifications as needed, according to the type.
///    You specify a single request component in FieldToMatch for each rule statement
///    that requires it. To inspect more than one component of the web request,
///    create a separate rule statement for each component. Example JSON for
///    a QueryString field to match: &quot;FieldToMatch&quot;: { &quot;QueryString&quot;: {} } Example
///    JSON for a Method field to match specification: &quot;FieldToMatch&quot;: { &quot;Method&quot;:
///    { &quot;Name&quot;: &quot;DELETE&quot; } }
/// 
///    * In a logging configuration, this is used in the RedactedFields property
///    to specify a field to redact from the logging records. For this use case,
///    note the following: Even though all FieldToMatch settings are available,
///    the only valid settings for field redaction are UriPath, QueryString,
///    SingleHeader, and Method. In this documentation, the descriptions of the
///    individual fields talk about specifying the web request component to inspect,
///    but for field redaction, you are specifying the component type to redact
///    from the logs. If you have request sampling enabled, the redacted fields
///    configuration for logging has no impact on sampling. The only way to exclude
///    fields from request sampling is by disabling sampling in the web ACL visibility
///    configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatch
{
    /// <summary>
    /// Inspect all query arguments of the web request.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;AllQueryArguments&quot;: {}
    /// </summary>
    [JsonPropertyName("allQueryArguments")]
    public IDictionary<string, string>? AllQueryArguments { get; set; }

    /// <summary>
    /// Inspect the body of the web request. The body immediately follows the request
    /// headers.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// </summary>
    [JsonPropertyName("body")]
    public V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchBody? Body { get; set; }

    /// <summary>
    /// Inspect the cookies in the web request. You can specify the parts of the
    /// cookies to inspect and you can narrow the set of cookies to inspect by including
    /// or excluding specific keys.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Example JSON: &quot;Cookies&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
    /// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
    /// </summary>
    [JsonPropertyName("cookies")]
    public V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchCookies? Cookies { get; set; }

    /// <summary>
    /// Inspect a string containing the list of the request&apos;s header names, ordered
    /// as they appear in the web requestthat WAF receives for inspection. WAF generates
    /// the string and then uses that as the field to match component in its inspection.
    /// WAF separates the header names in the string using colons and no added spaces,
    /// for example host:user-agent:accept:authorization:referer.
    /// </summary>
    [JsonPropertyName("headerOrder")]
    public V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchHeaderOrder? HeaderOrder { get; set; }

    /// <summary>
    /// Inspect all headers in the web request. You can specify the parts of the
    /// headers to inspect and you can narrow the set of headers to inspect by including
    /// or excluding specific keys.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// If you want to inspect just the value of a single header, use the SingleHeader
    /// FieldToMatch setting instead.
    /// 
    /// Example JSON: &quot;Headers&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
    /// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
    /// </summary>
    [JsonPropertyName("headers")]
    public V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchHeaders? Headers { get; set; }

    /// <summary>
    /// Available for use with Amazon CloudFront distributions and Application Load
    /// Balancers. Match against the request&apos;s JA3 fingerprint. The JA3 fingerprint
    /// is a 32-character hash derived from the TLS Client Hello of an incoming request.
    /// This fingerprint serves as a unique identifier for the client&apos;s TLS configuration.
    /// WAF calculates and logs this fingerprint for each request that has enough
    /// TLS Client Hello information for the calculation. Almost all web requests
    /// include this information.
    /// 
    /// You can use this choice only with a string match ByteMatchStatement with
    /// the PositionalConstraint set to EXACTLY.
    /// 
    /// You can obtain the JA3 fingerprint for client requests from the web ACL logs.
    /// If WAF is able to calculate the fingerprint, it includes it in the logs.
    /// For information about the logging fields, see Log fields (https://docs.aws.amazon.com/waf/latest/developerguide/logging-fields.html)
    /// in the WAF Developer Guide.
    /// 
    /// Provide the JA3 fingerprint string from the logs in your string match statement
    /// specification, to match with any future requests that have the same TLS configuration.
    /// </summary>
    [JsonPropertyName("ja3Fingerprint")]
    public V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchJa3Fingerprint? Ja3Fingerprint { get; set; }

    /// <summary>
    /// Inspect the body of the web request as JSON. The body immediately follows
    /// the request headers.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Use the specifications in this object to indicate which parts of the JSON
    /// body to inspect using the rule&apos;s inspection criteria. WAF inspects only the
    /// parts of the JSON that result from the matches that you indicate.
    /// 
    /// Example JSON: &quot;JsonBody&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;:
    /// &quot;ALL&quot; }
    /// 
    /// For additional information about this request component option, see JSON
    /// body (https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-fields-list.html#waf-rule-statement-request-component-json-body)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("jsonBody")]
    public V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchJsonBody? JsonBody { get; set; }

    /// <summary>
    /// Inspect the HTTP method of the web request. The method indicates the type
    /// of operation that the request is asking the origin to perform.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;Method&quot;: {}
    /// </summary>
    [JsonPropertyName("method")]
    public IDictionary<string, string>? Method { get; set; }

    /// <summary>
    /// Inspect the query string of the web request. This is the part of a URL that
    /// appears after a ? character, if any.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;QueryString&quot;: {}
    /// </summary>
    [JsonPropertyName("queryString")]
    public IDictionary<string, string>? QueryString { get; set; }

    /// <summary>
    /// Inspect one of the headers in the web request, identified by name, for example,
    /// User-Agent or Referer. The name isn&apos;t case sensitive.
    /// 
    /// You can filter and inspect all headers with the FieldToMatch setting Headers.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Example JSON: &quot;SingleHeader&quot;: { &quot;Name&quot;: &quot;haystack&quot; }
    /// </summary>
    [JsonPropertyName("singleHeader")]
    public V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchSingleHeader? SingleHeader { get; set; }

    /// <summary>
    /// Inspect one query argument in the web request, identified by name, for example
    /// UserName or SalesRegion. The name isn&apos;t case sensitive.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Example JSON: &quot;SingleQueryArgument&quot;: { &quot;Name&quot;: &quot;myArgument&quot; }
    /// </summary>
    [JsonPropertyName("singleQueryArgument")]
    public V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatchSingleQueryArgument? SingleQueryArgument { get; set; }

    /// <summary>
    /// Inspect the path component of the URI of the web request. This is the part
    /// of the web request that identifies a resource. For example, /images/daily-ad.jpg.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;UriPath&quot;: {}
    /// </summary>
    [JsonPropertyName("uriPath")]
    public IDictionary<string, string>? UriPath { get; set; }
}

/// <summary>
/// Text transformations eliminate some of the unusual formatting that attackers
/// use in web requests in an effort to bypass detection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementTextTransformations
{
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A rule statement that inspects for malicious SQL code. Attackers insert malicious
/// SQL code into web requests to do things like modify your database or extract
/// data from it.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementSqliMatchStatement
{
    /// <summary>
    /// Specifies a web request component to be used in a rule match statement or
    /// in a logging configuration.
    /// 
    ///    * In a rule statement, this is the part of the web request that you want
    ///    WAF to inspect. Include the single FieldToMatch type that you want to
    ///    inspect, with additional specifications as needed, according to the type.
    ///    You specify a single request component in FieldToMatch for each rule statement
    ///    that requires it. To inspect more than one component of the web request,
    ///    create a separate rule statement for each component. Example JSON for
    ///    a QueryString field to match: &quot;FieldToMatch&quot;: { &quot;QueryString&quot;: {} } Example
    ///    JSON for a Method field to match specification: &quot;FieldToMatch&quot;: { &quot;Method&quot;:
    ///    { &quot;Name&quot;: &quot;DELETE&quot; } }
    /// 
    ///    * In a logging configuration, this is used in the RedactedFields property
    ///    to specify a field to redact from the logging records. For this use case,
    ///    note the following: Even though all FieldToMatch settings are available,
    ///    the only valid settings for field redaction are UriPath, QueryString,
    ///    SingleHeader, and Method. In this documentation, the descriptions of the
    ///    individual fields talk about specifying the web request component to inspect,
    ///    but for field redaction, you are specifying the component type to redact
    ///    from the logs. If you have request sampling enabled, the redacted fields
    ///    configuration for logging has no impact on sampling. The only way to exclude
    ///    fields from request sampling is by disabling sampling in the web ACL visibility
    ///    configuration.
    /// </summary>
    [JsonPropertyName("fieldToMatch")]
    public V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementFieldToMatch? FieldToMatch { get; set; }

    [JsonPropertyName("sensitivityLevel")]
    public string? SensitivityLevel { get; set; }

    [JsonPropertyName("textTransformations")]
    public IList<V1alpha1RuleGroupSpecRulesStatementSqliMatchStatementTextTransformations>? TextTransformations { get; set; }
}

/// <summary>
/// Inspect the body of the web request. The body immediately follows the request
/// headers.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchBody
{
    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// The filter to use to identify the subset of cookies to inspect in a web request.
/// 
/// You must specify exactly one setting: either All, IncludedCookies, or ExcludedCookies.
/// 
/// Example JSON: &quot;MatchPattern&quot;: { &quot;IncludedCookies&quot;: [ &quot;session-id-time&quot;, &quot;session-id&quot;
/// ] }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchCookiesMatchPattern
{
    /// <summary>
    /// Inspect all of the elements that WAF has parsed and extracted from the web
    /// request component that you&apos;ve identified in your FieldToMatch specifications.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;All&quot;: {}
    /// </summary>
    [JsonPropertyName("all")]
    public IDictionary<string, string>? All { get; set; }

    [JsonPropertyName("excludedCookies")]
    public IList<string>? ExcludedCookies { get; set; }

    [JsonPropertyName("includedCookies")]
    public IList<string>? IncludedCookies { get; set; }
}

/// <summary>
/// Inspect the cookies in the web request. You can specify the parts of the
/// cookies to inspect and you can narrow the set of cookies to inspect by including
/// or excluding specific keys.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Example JSON: &quot;Cookies&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
/// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchCookies
{
    /// <summary>
    /// The filter to use to identify the subset of cookies to inspect in a web request.
    /// 
    /// You must specify exactly one setting: either All, IncludedCookies, or ExcludedCookies.
    /// 
    /// Example JSON: &quot;MatchPattern&quot;: { &quot;IncludedCookies&quot;: [ &quot;session-id-time&quot;, &quot;session-id&quot;
    /// ] }
    /// </summary>
    [JsonPropertyName("matchPattern")]
    public V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchCookiesMatchPattern? MatchPattern { get; set; }

    [JsonPropertyName("matchScope")]
    public string? MatchScope { get; set; }

    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// Inspect a string containing the list of the request&apos;s header names, ordered
/// as they appear in the web requestthat WAF receives for inspection. WAF generates
/// the string and then uses that as the field to match component in its inspection.
/// WAF separates the header names in the string using colons and no added spaces,
/// for example host:user-agent:accept:authorization:referer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchHeaderOrder
{
    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// The filter to use to identify the subset of headers to inspect in a web request.
/// 
/// You must specify exactly one setting: either All, IncludedHeaders, or ExcludedHeaders.
/// 
/// Example JSON: &quot;MatchPattern&quot;: { &quot;ExcludedHeaders&quot;: [ &quot;KeyToExclude1&quot;, &quot;KeyToExclude2&quot;
/// ] }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchHeadersMatchPattern
{
    /// <summary>
    /// Inspect all of the elements that WAF has parsed and extracted from the web
    /// request component that you&apos;ve identified in your FieldToMatch specifications.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;All&quot;: {}
    /// </summary>
    [JsonPropertyName("all")]
    public IDictionary<string, string>? All { get; set; }

    [JsonPropertyName("excludedHeaders")]
    public IList<string>? ExcludedHeaders { get; set; }

    [JsonPropertyName("includedHeaders")]
    public IList<string>? IncludedHeaders { get; set; }
}

/// <summary>
/// Inspect all headers in the web request. You can specify the parts of the
/// headers to inspect and you can narrow the set of headers to inspect by including
/// or excluding specific keys.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// If you want to inspect just the value of a single header, use the SingleHeader
/// FieldToMatch setting instead.
/// 
/// Example JSON: &quot;Headers&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
/// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchHeaders
{
    /// <summary>
    /// The filter to use to identify the subset of headers to inspect in a web request.
    /// 
    /// You must specify exactly one setting: either All, IncludedHeaders, or ExcludedHeaders.
    /// 
    /// Example JSON: &quot;MatchPattern&quot;: { &quot;ExcludedHeaders&quot;: [ &quot;KeyToExclude1&quot;, &quot;KeyToExclude2&quot;
    /// ] }
    /// </summary>
    [JsonPropertyName("matchPattern")]
    public V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchHeadersMatchPattern? MatchPattern { get; set; }

    [JsonPropertyName("matchScope")]
    public string? MatchScope { get; set; }

    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// Available for use with Amazon CloudFront distributions and Application Load
/// Balancers. Match against the request&apos;s JA3 fingerprint. The JA3 fingerprint
/// is a 32-character hash derived from the TLS Client Hello of an incoming request.
/// This fingerprint serves as a unique identifier for the client&apos;s TLS configuration.
/// WAF calculates and logs this fingerprint for each request that has enough
/// TLS Client Hello information for the calculation. Almost all web requests
/// include this information.
/// 
/// You can use this choice only with a string match ByteMatchStatement with
/// the PositionalConstraint set to EXACTLY.
/// 
/// You can obtain the JA3 fingerprint for client requests from the web ACL logs.
/// If WAF is able to calculate the fingerprint, it includes it in the logs.
/// For information about the logging fields, see Log fields (https://docs.aws.amazon.com/waf/latest/developerguide/logging-fields.html)
/// in the WAF Developer Guide.
/// 
/// Provide the JA3 fingerprint string from the logs in your string match statement
/// specification, to match with any future requests that have the same TLS configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchJa3Fingerprint
{
    [JsonPropertyName("fallbackBehavior")]
    public string? FallbackBehavior { get; set; }
}

/// <summary>
/// The patterns to look for in the JSON body. WAF inspects the results of these
/// pattern matches against the rule inspection criteria. This is used with the
/// FieldToMatch option JsonBody.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchJsonBodyMatchPattern
{
    /// <summary>
    /// Inspect all of the elements that WAF has parsed and extracted from the web
    /// request component that you&apos;ve identified in your FieldToMatch specifications.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;All&quot;: {}
    /// </summary>
    [JsonPropertyName("all")]
    public IDictionary<string, string>? All { get; set; }

    [JsonPropertyName("includedPaths")]
    public IList<string>? IncludedPaths { get; set; }
}

/// <summary>
/// Inspect the body of the web request as JSON. The body immediately follows
/// the request headers.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Use the specifications in this object to indicate which parts of the JSON
/// body to inspect using the rule&apos;s inspection criteria. WAF inspects only the
/// parts of the JSON that result from the matches that you indicate.
/// 
/// Example JSON: &quot;JsonBody&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;:
/// &quot;ALL&quot; }
/// 
/// For additional information about this request component option, see JSON
/// body (https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-fields-list.html#waf-rule-statement-request-component-json-body)
/// in the WAF Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchJsonBody
{
    [JsonPropertyName("invalidFallbackBehavior")]
    public string? InvalidFallbackBehavior { get; set; }

    /// <summary>
    /// The patterns to look for in the JSON body. WAF inspects the results of these
    /// pattern matches against the rule inspection criteria. This is used with the
    /// FieldToMatch option JsonBody.
    /// </summary>
    [JsonPropertyName("matchPattern")]
    public V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchJsonBodyMatchPattern? MatchPattern { get; set; }

    [JsonPropertyName("matchScope")]
    public string? MatchScope { get; set; }

    [JsonPropertyName("oversizeHandling")]
    public string? OversizeHandling { get; set; }
}

/// <summary>
/// Inspect one of the headers in the web request, identified by name, for example,
/// User-Agent or Referer. The name isn&apos;t case sensitive.
/// 
/// You can filter and inspect all headers with the FieldToMatch setting Headers.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Example JSON: &quot;SingleHeader&quot;: { &quot;Name&quot;: &quot;haystack&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchSingleHeader
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Inspect one query argument in the web request, identified by name, for example
/// UserName or SalesRegion. The name isn&apos;t case sensitive.
/// 
/// This is used to indicate the web request component to inspect, in the FieldToMatch
/// specification.
/// 
/// Example JSON: &quot;SingleQueryArgument&quot;: { &quot;Name&quot;: &quot;myArgument&quot; }
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchSingleQueryArgument
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Specifies a web request component to be used in a rule match statement or
/// in a logging configuration.
/// 
///    * In a rule statement, this is the part of the web request that you want
///    WAF to inspect. Include the single FieldToMatch type that you want to
///    inspect, with additional specifications as needed, according to the type.
///    You specify a single request component in FieldToMatch for each rule statement
///    that requires it. To inspect more than one component of the web request,
///    create a separate rule statement for each component. Example JSON for
///    a QueryString field to match: &quot;FieldToMatch&quot;: { &quot;QueryString&quot;: {} } Example
///    JSON for a Method field to match specification: &quot;FieldToMatch&quot;: { &quot;Method&quot;:
///    { &quot;Name&quot;: &quot;DELETE&quot; } }
/// 
///    * In a logging configuration, this is used in the RedactedFields property
///    to specify a field to redact from the logging records. For this use case,
///    note the following: Even though all FieldToMatch settings are available,
///    the only valid settings for field redaction are UriPath, QueryString,
///    SingleHeader, and Method. In this documentation, the descriptions of the
///    individual fields talk about specifying the web request component to inspect,
///    but for field redaction, you are specifying the component type to redact
///    from the logs. If you have request sampling enabled, the redacted fields
///    configuration for logging has no impact on sampling. The only way to exclude
///    fields from request sampling is by disabling sampling in the web ACL visibility
///    configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatch
{
    /// <summary>
    /// Inspect all query arguments of the web request.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;AllQueryArguments&quot;: {}
    /// </summary>
    [JsonPropertyName("allQueryArguments")]
    public IDictionary<string, string>? AllQueryArguments { get; set; }

    /// <summary>
    /// Inspect the body of the web request. The body immediately follows the request
    /// headers.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// </summary>
    [JsonPropertyName("body")]
    public V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchBody? Body { get; set; }

    /// <summary>
    /// Inspect the cookies in the web request. You can specify the parts of the
    /// cookies to inspect and you can narrow the set of cookies to inspect by including
    /// or excluding specific keys.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Example JSON: &quot;Cookies&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
    /// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
    /// </summary>
    [JsonPropertyName("cookies")]
    public V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchCookies? Cookies { get; set; }

    /// <summary>
    /// Inspect a string containing the list of the request&apos;s header names, ordered
    /// as they appear in the web requestthat WAF receives for inspection. WAF generates
    /// the string and then uses that as the field to match component in its inspection.
    /// WAF separates the header names in the string using colons and no added spaces,
    /// for example host:user-agent:accept:authorization:referer.
    /// </summary>
    [JsonPropertyName("headerOrder")]
    public V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchHeaderOrder? HeaderOrder { get; set; }

    /// <summary>
    /// Inspect all headers in the web request. You can specify the parts of the
    /// headers to inspect and you can narrow the set of headers to inspect by including
    /// or excluding specific keys.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// If you want to inspect just the value of a single header, use the SingleHeader
    /// FieldToMatch setting instead.
    /// 
    /// Example JSON: &quot;Headers&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;: &quot;KEY&quot;,
    /// &quot;OversizeHandling&quot;: &quot;MATCH&quot; }
    /// </summary>
    [JsonPropertyName("headers")]
    public V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchHeaders? Headers { get; set; }

    /// <summary>
    /// Available for use with Amazon CloudFront distributions and Application Load
    /// Balancers. Match against the request&apos;s JA3 fingerprint. The JA3 fingerprint
    /// is a 32-character hash derived from the TLS Client Hello of an incoming request.
    /// This fingerprint serves as a unique identifier for the client&apos;s TLS configuration.
    /// WAF calculates and logs this fingerprint for each request that has enough
    /// TLS Client Hello information for the calculation. Almost all web requests
    /// include this information.
    /// 
    /// You can use this choice only with a string match ByteMatchStatement with
    /// the PositionalConstraint set to EXACTLY.
    /// 
    /// You can obtain the JA3 fingerprint for client requests from the web ACL logs.
    /// If WAF is able to calculate the fingerprint, it includes it in the logs.
    /// For information about the logging fields, see Log fields (https://docs.aws.amazon.com/waf/latest/developerguide/logging-fields.html)
    /// in the WAF Developer Guide.
    /// 
    /// Provide the JA3 fingerprint string from the logs in your string match statement
    /// specification, to match with any future requests that have the same TLS configuration.
    /// </summary>
    [JsonPropertyName("ja3Fingerprint")]
    public V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchJa3Fingerprint? Ja3Fingerprint { get; set; }

    /// <summary>
    /// Inspect the body of the web request as JSON. The body immediately follows
    /// the request headers.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Use the specifications in this object to indicate which parts of the JSON
    /// body to inspect using the rule&apos;s inspection criteria. WAF inspects only the
    /// parts of the JSON that result from the matches that you indicate.
    /// 
    /// Example JSON: &quot;JsonBody&quot;: { &quot;MatchPattern&quot;: { &quot;All&quot;: {} }, &quot;MatchScope&quot;:
    /// &quot;ALL&quot; }
    /// 
    /// For additional information about this request component option, see JSON
    /// body (https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-fields-list.html#waf-rule-statement-request-component-json-body)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("jsonBody")]
    public V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchJsonBody? JsonBody { get; set; }

    /// <summary>
    /// Inspect the HTTP method of the web request. The method indicates the type
    /// of operation that the request is asking the origin to perform.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;Method&quot;: {}
    /// </summary>
    [JsonPropertyName("method")]
    public IDictionary<string, string>? Method { get; set; }

    /// <summary>
    /// Inspect the query string of the web request. This is the part of a URL that
    /// appears after a ? character, if any.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;QueryString&quot;: {}
    /// </summary>
    [JsonPropertyName("queryString")]
    public IDictionary<string, string>? QueryString { get; set; }

    /// <summary>
    /// Inspect one of the headers in the web request, identified by name, for example,
    /// User-Agent or Referer. The name isn&apos;t case sensitive.
    /// 
    /// You can filter and inspect all headers with the FieldToMatch setting Headers.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Example JSON: &quot;SingleHeader&quot;: { &quot;Name&quot;: &quot;haystack&quot; }
    /// </summary>
    [JsonPropertyName("singleHeader")]
    public V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchSingleHeader? SingleHeader { get; set; }

    /// <summary>
    /// Inspect one query argument in the web request, identified by name, for example
    /// UserName or SalesRegion. The name isn&apos;t case sensitive.
    /// 
    /// This is used to indicate the web request component to inspect, in the FieldToMatch
    /// specification.
    /// 
    /// Example JSON: &quot;SingleQueryArgument&quot;: { &quot;Name&quot;: &quot;myArgument&quot; }
    /// </summary>
    [JsonPropertyName("singleQueryArgument")]
    public V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatchSingleQueryArgument? SingleQueryArgument { get; set; }

    /// <summary>
    /// Inspect the path component of the URI of the web request. This is the part
    /// of the web request that identifies a resource. For example, /images/daily-ad.jpg.
    /// 
    /// This is used in the FieldToMatch specification for some web request component
    /// types.
    /// 
    /// JSON specification: &quot;UriPath&quot;: {}
    /// </summary>
    [JsonPropertyName("uriPath")]
    public IDictionary<string, string>? UriPath { get; set; }
}

/// <summary>
/// Text transformations eliminate some of the unusual formatting that attackers
/// use in web requests in an effort to bypass detection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementXssMatchStatementTextTransformations
{
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A rule statement that inspects for cross-site scripting (XSS) attacks. In
/// XSS attacks, the attacker uses vulnerabilities in a benign website as a vehicle
/// to inject malicious client-site scripts into other legitimate web browsers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatementXssMatchStatement
{
    /// <summary>
    /// Specifies a web request component to be used in a rule match statement or
    /// in a logging configuration.
    /// 
    ///    * In a rule statement, this is the part of the web request that you want
    ///    WAF to inspect. Include the single FieldToMatch type that you want to
    ///    inspect, with additional specifications as needed, according to the type.
    ///    You specify a single request component in FieldToMatch for each rule statement
    ///    that requires it. To inspect more than one component of the web request,
    ///    create a separate rule statement for each component. Example JSON for
    ///    a QueryString field to match: &quot;FieldToMatch&quot;: { &quot;QueryString&quot;: {} } Example
    ///    JSON for a Method field to match specification: &quot;FieldToMatch&quot;: { &quot;Method&quot;:
    ///    { &quot;Name&quot;: &quot;DELETE&quot; } }
    /// 
    ///    * In a logging configuration, this is used in the RedactedFields property
    ///    to specify a field to redact from the logging records. For this use case,
    ///    note the following: Even though all FieldToMatch settings are available,
    ///    the only valid settings for field redaction are UriPath, QueryString,
    ///    SingleHeader, and Method. In this documentation, the descriptions of the
    ///    individual fields talk about specifying the web request component to inspect,
    ///    but for field redaction, you are specifying the component type to redact
    ///    from the logs. If you have request sampling enabled, the redacted fields
    ///    configuration for logging has no impact on sampling. The only way to exclude
    ///    fields from request sampling is by disabling sampling in the web ACL visibility
    ///    configuration.
    /// </summary>
    [JsonPropertyName("fieldToMatch")]
    public V1alpha1RuleGroupSpecRulesStatementXssMatchStatementFieldToMatch? FieldToMatch { get; set; }

    [JsonPropertyName("textTransformations")]
    public IList<V1alpha1RuleGroupSpecRulesStatementXssMatchStatementTextTransformations>? TextTransformations { get; set; }
}

/// <summary>
/// The processing guidance for a Rule, used by WAF to determine whether a web
/// request matches the rule.
/// 
/// For example specifications, see the examples section of CreateWebACL.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesStatement
{
    [JsonPropertyName("andStatement")]
    public string? AndStatement { get; set; }

    /// <summary>
    /// A rule statement that defines a string match search for WAF to apply to web
    /// requests. The byte match statement provides the bytes to search for, the
    /// location in requests that you want WAF to search, and other settings. The
    /// bytes to search for are typically a string that corresponds with ASCII characters.
    /// In the WAF console and the developer guide, this is called a string match
    /// statement.
    /// </summary>
    [JsonPropertyName("byteMatchStatement")]
    public V1alpha1RuleGroupSpecRulesStatementByteMatchStatement? ByteMatchStatement { get; set; }

    /// <summary>
    /// A rule statement that labels web requests by country and region and that
    /// matches against web requests based on country code. A geo match rule labels
    /// every request that it inspects regardless of whether it finds a match.
    /// 
    ///    * To manage requests only by country, you can use this statement by itself
    ///    and specify the countries that you want to match against in the CountryCodes
    ///    array.
    /// 
    ///    * Otherwise, configure your geo match rule with Count action so that it
    ///    only labels requests. Then, add one or more label match rules to run after
    ///    the geo match rule and configure them to match against the geographic
    ///    labels and handle the requests as needed.
    /// 
    /// WAF labels requests using the alpha-2 country and region codes from the International
    /// Organization for Standardization (ISO) 3166 standard. WAF determines the
    /// codes using either the IP address in the web request origin or, if you specify
    /// it, the address in the geo match ForwardedIPConfig.
    /// 
    /// If you use the web request origin, the label formats are awswaf:clientip:geo:region:-
    /// and awswaf:clientip:geo:country:.
    /// 
    /// If you use a forwarded IP address, the label formats are awswaf:forwardedip:geo:region:-
    /// and awswaf:forwardedip:geo:country:.
    /// 
    /// For additional details, see Geographic match rule statement (https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-type-geo-match.html)
    /// in the WAF Developer Guide (https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html).
    /// </summary>
    [JsonPropertyName("geoMatchStatement")]
    public V1alpha1RuleGroupSpecRulesStatementGeoMatchStatement? GeoMatchStatement { get; set; }

    /// <summary>
    /// A rule statement used to detect web requests coming from particular IP addresses
    /// or address ranges. To use this, create an IPSet that specifies the addresses
    /// you want to detect, then use the ARN of that set in this statement. To create
    /// an IP set, see CreateIPSet.
    /// 
    /// Each IP set rule statement references an IP set. You create and maintain
    /// the set independent of your rules. This allows you to use the single set
    /// in multiple rules. When you update the referenced set, WAF automatically
    /// updates all rules that reference it.
    /// </summary>
    [JsonPropertyName("ipSetReferenceStatement")]
    public V1alpha1RuleGroupSpecRulesStatementIpSetReferenceStatement? IpSetReferenceStatement { get; set; }

    /// <summary>
    /// A rule statement to match against labels that have been added to the web
    /// request by rules that have already run in the web ACL.
    /// 
    /// The label match statement provides the label or namespace string to search
    /// for. The label string can represent a part or all of the fully qualified
    /// label name that had been added to the web request. Fully qualified labels
    /// have a prefix, optional namespaces, and label name. The prefix identifies
    /// the rule group or web ACL context of the rule that added the label. If you
    /// do not provide the fully qualified name in your label match string, WAF performs
    /// the search for labels that were added in the same context as the label match
    /// statement.
    /// </summary>
    [JsonPropertyName("labelMatchStatement")]
    public V1alpha1RuleGroupSpecRulesStatementLabelMatchStatement? LabelMatchStatement { get; set; }

    /// <summary>
    /// A rule statement used to run the rules that are defined in a managed rule
    /// group. To use this, provide the vendor name and the name of the rule group
    /// in this statement. You can retrieve the required names by calling ListAvailableManagedRuleGroups.
    /// 
    /// You cannot nest a ManagedRuleGroupStatement, for example for use inside a
    /// NotStatement or OrStatement. You cannot use a managed rule group inside another
    /// rule group. You can only reference a managed rule group as a top-level statement
    /// within a rule that you define in a web ACL.
    /// 
    /// You are charged additional fees when you use the WAF Bot Control managed
    /// rule group AWSManagedRulesBotControlRuleSet, the WAF Fraud Control account
    /// takeover prevention (ATP) managed rule group AWSManagedRulesATPRuleSet, or
    /// the WAF Fraud Control account creation fraud prevention (ACFP) managed rule
    /// group AWSManagedRulesACFPRuleSet. For more information, see WAF Pricing (http://aws.amazon.com/waf/pricing/).
    /// </summary>
    [JsonPropertyName("managedRuleGroupStatement")]
    public V1alpha1RuleGroupSpecRulesStatementManagedRuleGroupStatement? ManagedRuleGroupStatement { get; set; }

    [JsonPropertyName("notStatement")]
    public string? NotStatement { get; set; }

    [JsonPropertyName("orStatement")]
    public string? OrStatement { get; set; }

    /// <summary>
    /// A rate-based rule counts incoming requests and rate limits requests when
    /// they are coming at too fast a rate. The rule categorizes requests according
    /// to your aggregation criteria, collects them into aggregation instances, and
    /// counts and rate limits the requests for each instance.
    /// 
    /// If you change any of these settings in a rule that&apos;s currently in use, the
    /// change resets the rule&apos;s rate limiting counts. This can pause the rule&apos;s
    /// rate limiting activities for up to a minute.
    /// 
    /// You can specify individual aggregation keys, like IP address or HTTP method.
    /// You can also specify aggregation key combinations, like IP address and HTTP
    /// method, or HTTP method, query argument, and cookie.
    /// 
    /// Each unique set of values for the aggregation keys that you specify is a
    /// separate aggregation instance, with the value from each key contributing
    /// to the aggregation instance definition.
    /// 
    /// For example, assume the rule evaluates web requests with the following IP
    /// address and HTTP method values:
    /// 
    ///    * IP address 10.1.1.1, HTTP method POST
    /// 
    ///    * IP address 10.1.1.1, HTTP method GET
    /// 
    ///    * IP address 127.0.0.0, HTTP method POST
    /// 
    ///    * IP address 10.1.1.1, HTTP method GET
    /// 
    /// The rule would create different aggregation instances according to your aggregation
    /// criteria, for example:
    /// 
    ///    * If the aggregation criteria is just the IP address, then each individual
    ///    address is an aggregation instance, and WAF counts requests separately
    ///    for each. The aggregation instances and request counts for our example
    ///    would be the following: IP address 10.1.1.1: count 3 IP address 127.0.0.0:
    ///    count 1
    /// 
    ///    * If the aggregation criteria is HTTP method, then each individual HTTP
    ///    method is an aggregation instance. The aggregation instances and request
    ///    counts for our example would be the following: HTTP method POST: count
    ///    2 HTTP method GET: count 2
    /// 
    ///    * If the aggregation criteria is IP address and HTTP method, then each
    ///    IP address and each HTTP method would contribute to the combined aggregation
    ///    instance. The aggregation instances and request counts for our example
    ///    would be the following: IP address 10.1.1.1, HTTP method POST: count 1
    ///    IP address 10.1.1.1, HTTP method GET: count 2 IP address 127.0.0.0, HTTP
    ///    method POST: count 1
    /// 
    /// For any n-tuple of aggregation keys, each unique combination of values for
    /// the keys defines a separate aggregation instance, which WAF counts and rate-limits
    /// individually.
    /// 
    /// You can optionally nest another statement inside the rate-based statement,
    /// to narrow the scope of the rule so that it only counts and rate limits requests
    /// that match the nested statement. You can use this nested scope-down statement
    /// in conjunction with your aggregation key specifications or you can just count
    /// and rate limit all requests that match the scope-down statement, without
    /// additional aggregation. When you choose to just manage all requests that
    /// match a scope-down statement, the aggregation instance is singular for the
    /// rule.
    /// 
    /// You cannot nest a RateBasedStatement inside another statement, for example
    /// inside a NotStatement or OrStatement. You can define a RateBasedStatement
    /// inside a web ACL and inside a rule group.
    /// 
    /// For additional information about the options, see Rate limiting web requests
    /// using rate-based rules (https://docs.aws.amazon.com/waf/latest/developerguide/waf-rate-based-rules.html)
    /// in the WAF Developer Guide.
    /// 
    /// If you only aggregate on the individual IP address or forwarded IP address,
    /// you can retrieve the list of IP addresses that WAF is currently rate limiting
    /// for a rule through the API call GetRateBasedStatementManagedKeys. This option
    /// is not available for other aggregation configurations.
    /// 
    /// WAF tracks and manages web requests separately for each instance of a rate-based
    /// rule that you use. For example, if you provide the same rate-based rule settings
    /// in two web ACLs, each of the two rule statements represents a separate instance
    /// of the rate-based rule and gets its own tracking and management by WAF. If
    /// you define a rate-based rule inside a rule group, and then use that rule
    /// group in multiple places, each use creates a separate instance of the rate-based
    /// rule that gets its own tracking and management by WAF.
    /// </summary>
    [JsonPropertyName("rateBasedStatement")]
    public V1alpha1RuleGroupSpecRulesStatementRateBasedStatement? RateBasedStatement { get; set; }

    /// <summary>
    /// A rule statement used to search web request components for a match against
    /// a single regular expression.
    /// </summary>
    [JsonPropertyName("regexMatchStatement")]
    public V1alpha1RuleGroupSpecRulesStatementRegexMatchStatement? RegexMatchStatement { get; set; }

    /// <summary>
    /// A rule statement used to search web request components for matches with regular
    /// expressions. To use this, create a RegexPatternSet that specifies the expressions
    /// that you want to detect, then use the ARN of that set in this statement.
    /// A web request matches the pattern set rule statement if the request component
    /// matches any of the patterns in the set. To create a regex pattern set, see
    /// CreateRegexPatternSet.
    /// 
    /// Each regex pattern set rule statement references a regex pattern set. You
    /// create and maintain the set independent of your rules. This allows you to
    /// use the single set in multiple rules. When you update the referenced set,
    /// WAF automatically updates all rules that reference it.
    /// </summary>
    [JsonPropertyName("regexPatternSetReferenceStatement")]
    public V1alpha1RuleGroupSpecRulesStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatement { get; set; }

    /// <summary>
    /// A rule statement used to run the rules that are defined in a RuleGroup. To
    /// use this, create a rule group with your rules, then provide the ARN of the
    /// rule group in this statement.
    /// 
    /// You cannot nest a RuleGroupReferenceStatement, for example for use inside
    /// a NotStatement or OrStatement. You cannot use a rule group reference statement
    /// inside another rule group. You can only reference a rule group as a top-level
    /// statement within a rule that you define in a web ACL.
    /// </summary>
    [JsonPropertyName("ruleGroupReferenceStatement")]
    public V1alpha1RuleGroupSpecRulesStatementRuleGroupReferenceStatement? RuleGroupReferenceStatement { get; set; }

    [JsonPropertyName("sizeConstraintStatement")]
    public V1alpha1RuleGroupSpecRulesStatementSizeConstraintStatement? SizeConstraintStatement { get; set; }

    /// <summary>
    /// A rule statement that inspects for malicious SQL code. Attackers insert malicious
    /// SQL code into web requests to do things like modify your database or extract
    /// data from it.
    /// </summary>
    [JsonPropertyName("sqliMatchStatement")]
    public V1alpha1RuleGroupSpecRulesStatementSqliMatchStatement? SqliMatchStatement { get; set; }

    /// <summary>
    /// A rule statement that inspects for cross-site scripting (XSS) attacks. In
    /// XSS attacks, the attacker uses vulnerabilities in a benign website as a vehicle
    /// to inject malicious client-site scripts into other legitimate web browsers.
    /// </summary>
    [JsonPropertyName("xssMatchStatement")]
    public V1alpha1RuleGroupSpecRulesStatementXssMatchStatement? XssMatchStatement { get; set; }
}

/// <summary>Defines and enables Amazon CloudWatch metrics and web request sample collection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRulesVisibilityConfig
{
    [JsonPropertyName("cloudWatchMetricsEnabled")]
    public bool? CloudWatchMetricsEnabled { get; set; }

    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("sampledRequestsEnabled")]
    public bool? SampledRequestsEnabled { get; set; }
}

/// <summary>
/// A single rule, which you can use in a WebACL or RuleGroup to identify web
/// requests that you want to manage in some way. Each rule includes one top-level
/// Statement that WAF uses to identify matching web requests, and parameters
/// that govern how WAF handles them.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRules
{
    /// <summary>
    /// The action that WAF should take on a web request when it matches a rule&apos;s
    /// statement. Settings at the web ACL level can override the rule action setting.
    /// </summary>
    [JsonPropertyName("action")]
    public V1alpha1RuleGroupSpecRulesAction? Action { get; set; }

    /// <summary>
    /// Specifies how WAF should handle CAPTCHA evaluations. This is available at
    /// the web ACL level and in each rule.
    /// </summary>
    [JsonPropertyName("captchaConfig")]
    public V1alpha1RuleGroupSpecRulesCaptchaConfig? CaptchaConfig { get; set; }

    /// <summary>
    /// Specifies how WAF should handle Challenge evaluations. This is available
    /// at the web ACL level and in each rule.
    /// </summary>
    [JsonPropertyName("challengeConfig")]
    public V1alpha1RuleGroupSpecRulesChallengeConfig? ChallengeConfig { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The action to use in the place of the action that results from the rule group
    /// evaluation. Set the override action to none to leave the result of the rule
    /// group alone. Set it to count to override the result to count only.
    /// 
    /// You can only use this for rule statements that reference a rule group, like
    /// RuleGroupReferenceStatement and ManagedRuleGroupStatement.
    /// 
    /// This option is usually set to none. It does not affect how the rules in the
    /// rule group are evaluated. If you want the rules in the rule group to only
    /// count matches, do not use this and instead use the rule action override option,
    /// with Count action, in your rule group reference statement settings.
    /// </summary>
    [JsonPropertyName("overrideAction")]
    public V1alpha1RuleGroupSpecRulesOverrideAction? OverrideAction { get; set; }

    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    [JsonPropertyName("ruleLabels")]
    public IList<V1alpha1RuleGroupSpecRulesRuleLabels>? RuleLabels { get; set; }

    /// <summary>
    /// The processing guidance for a Rule, used by WAF to determine whether a web
    /// request matches the rule.
    /// 
    /// For example specifications, see the examples section of CreateWebACL.
    /// </summary>
    [JsonPropertyName("statement")]
    public V1alpha1RuleGroupSpecRulesStatement? Statement { get; set; }

    /// <summary>Defines and enables Amazon CloudWatch metrics and web request sample collection.</summary>
    [JsonPropertyName("visibilityConfig")]
    public V1alpha1RuleGroupSpecRulesVisibilityConfig? VisibilityConfig { get; set; }
}

/// <summary>
/// A tag associated with an Amazon Web Services resource. Tags are key:value
/// pairs that you can use to categorize and manage your resources, for purposes
/// like billing or other management. Typically, the tag key represents a category,
/// such as &quot;environment&quot;, and the tag value represents a specific value within
/// that category, such as &quot;test,&quot; &quot;development,&quot; or &quot;production&quot;. Or you might
/// set the tag key to &quot;customer&quot; and the value to the customer name or ID. You
/// can specify one or more tags to add to each Amazon Web Services resource,
/// up to 50 tags for a resource.
/// 
/// You can tag the Amazon Web Services resources that you manage through WAF:
/// web ACLs, rule groups, IP sets, and regex pattern sets. You can&apos;t manage
/// or view tags through the WAF console.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Defines and enables Amazon CloudWatch metrics and web request sample collection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecVisibilityConfig
{
    [JsonPropertyName("cloudWatchMetricsEnabled")]
    public bool? CloudWatchMetricsEnabled { get; set; }

    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("sampledRequestsEnabled")]
    public bool? SampledRequestsEnabled { get; set; }
}

/// <summary>
/// RuleGroupSpec defines the desired state of RuleGroup.
/// 
/// A rule group defines a collection of rules to inspect and control web requests
/// that you can use in a WebACL. When you create a rule group, you define an
/// immutable capacity limit. If you update a rule group, you must stay within
/// the capacity. This allows others to reuse the rule group with confidence
/// in its capacity requirements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpec
{
    /// <summary>
    /// The web ACL capacity units (WCUs) required for this rule group.
    /// 
    /// When you create your own rule group, you define this, and you cannot change
    /// it after creation. When you add or modify the rules in a rule group, WAF
    /// enforces this limit. You can check the capacity for a set of rules using
    /// CheckCapacity.
    /// 
    /// WAF uses WCUs to calculate and control the operating resources that are used
    /// to run your rules, rule groups, and web ACLs. WAF calculates capacity differently
    /// for each rule type, to reflect the relative cost of each rule. Simple rules
    /// that cost little to run use fewer WCUs than more complex rules that use more
    /// processing power. Rule group capacity is fixed at creation, which helps users
    /// plan their web ACL WCU usage when they use a rule group. For more information,
    /// see WAF web ACL capacity units (WCU) (https://docs.aws.amazon.com/waf/latest/developerguide/aws-waf-capacity-units.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("capacity")]
    public required long Capacity { get; set; }

    /// <summary>
    /// A map of custom response keys and content bodies. When you create a rule
    /// with a block action, you can send a custom response to the web request. You
    /// define these for the rule group, and then use them in the rules that you
    /// define in the rule group.
    /// 
    /// For information about customizing web requests and responses, see Customizing
    /// web requests and responses in WAF (https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html)
    /// in the WAF Developer Guide.
    /// 
    /// For information about the limits on count and size for custom request and
    /// response settings, see WAF quotas (https://docs.aws.amazon.com/waf/latest/developerguide/limits.html)
    /// in the WAF Developer Guide.
    /// </summary>
    [JsonPropertyName("customResponseBodies")]
    public IDictionary<string, V1alpha1RuleGroupSpecCustomResponseBodies>? CustomResponseBodies { get; set; }

    /// <summary>
    /// A description of the rule group that helps with identification.
    /// 
    /// Regex Pattern: `^[\w+=:#@/\-,\.][\w+=:#@/\-,\.\s]+[\w+=:#@/\-,\.]$`
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The name of the rule group. You cannot change the name of a rule group after
    /// you create it.
    /// 
    /// Regex Pattern: `^[\w\-]+$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The Rule statements used to identify the web requests that you want to manage.
    /// Each rule includes one top-level statement that WAF uses to identify matching
    /// web requests, and parameters that govern how WAF handles them.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1RuleGroupSpecRules>? Rules { get; set; }

    /// <summary>
    /// Specifies whether this is for an Amazon CloudFront distribution or for a
    /// regional application. A regional application can be an Application Load Balancer
    /// (ALB), an Amazon API Gateway REST API, an AppSync GraphQL API, an Amazon
    /// Cognito user pool, an App Runner service, or an Amazon Web Services Verified
    /// Access instance.
    /// 
    /// To work with CloudFront, you must also specify the Region US East (N. Virginia)
    /// as follows:
    /// 
    ///   - CLI - Specify the Region when you use the CloudFront scope: --scope=CLOUDFRONT
    ///     --region=us-east-1.
    /// 
    ///   - API and SDKs - For all calls, use the Region endpoint us-east-1.
    /// </summary>
    [JsonPropertyName("scope")]
    public required string Scope { get; set; }

    /// <summary>An array of key:value pairs to associate with the resource.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1RuleGroupSpecTags>? Tags { get; set; }

    /// <summary>Defines and enables Amazon CloudWatch metrics and web request sample collection.</summary>
    [JsonPropertyName("visibilityConfig")]
    public required V1alpha1RuleGroupSpecVisibilityConfig VisibilityConfig { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupStatusAckResourceMetadata
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
public partial class V1alpha1RuleGroupStatusConditions
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

/// <summary>RuleGroupStatus defines the observed state of RuleGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1RuleGroupStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RuleGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// A unique identifier for the rule group. This ID is returned in the responses
    /// to create and list commands. You provide it to operations like update and
    /// delete.
    /// 
    /// Regex Pattern: `^[0-9a-f]{8}-(?:[0-9a-f]{4}-){3}[0-9a-f]{12}$`
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// A token used for optimistic locking. WAF returns a token to your get and
    /// list requests, to mark the state of the entity at the time of the request.
    /// To make changes to the entity associated with the token, you provide the
    /// token to operations like update and delete. WAF uses the token to ensure
    /// that no changes have been made to the entity since you last retrieved it.
    /// If a change has been made, the update fails with a WAFOptimisticLockException.
    /// If this happens, perform another get, and use the new token returned by that
    /// operation.
    /// 
    /// Regex Pattern: `^[0-9a-f]{8}-(?:[0-9a-f]{4}-){3}[0-9a-f]{12}$`
    /// </summary>
    [JsonPropertyName("lockToken")]
    public string? LockToken { get; set; }
}

/// <summary>RuleGroup is the Schema for the RuleGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RuleGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1RuleGroupSpec?>, IStatus<V1alpha1RuleGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RuleGroup";
    public const string KubeGroup = "wafv2.services.k8s.aws";
    public const string KubePluralName = "rulegroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "wafv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RuleGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// RuleGroupSpec defines the desired state of RuleGroup.
    /// 
    /// A rule group defines a collection of rules to inspect and control web requests
    /// that you can use in a WebACL. When you create a rule group, you define an
    /// immutable capacity limit. If you update a rule group, you must stay within
    /// the capacity. This allows others to reuse the rule group with confidence
    /// in its capacity requirements.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1RuleGroupSpec? Spec { get; set; }

    /// <summary>RuleGroupStatus defines the observed state of RuleGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1RuleGroupStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cognitoidp.aws.upbound.io;
/// <summary>RiskConfiguration is the Schema for the RiskConfigurations API. Provides a Cognito Risk Configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RiskConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta2RiskConfiguration>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RiskConfigurationList";
    public const string KubeGroup = "cognitoidp.aws.upbound.io";
    public const string KubePluralName = "riskconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cognitoidp.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RiskConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2RiskConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2RiskConfiguration> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RiskConfigurationSpecDeletionPolicyEnum>))]
public enum V1beta2RiskConfigurationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Action to take for a high risk. See action block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationActionsHighAction
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }

    /// <summary>Whether to send a notification.</summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; }
}

/// <summary>Action to take for a low risk. See action block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationActionsLowAction
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }

    /// <summary>Whether to send a notification.</summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; }
}

/// <summary>Action to take for a medium risk. See action block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationActionsMediumAction
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }

    /// <summary>Whether to send a notification.</summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; }
}

/// <summary>Account takeover risk configuration actions. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationActions
{
    /// <summary>Action to take for a high risk. See action block below.</summary>
    [JsonPropertyName("highAction")]
    public V1beta2RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationActionsHighAction? HighAction { get; set; }

    /// <summary>Action to take for a low risk. See action block below.</summary>
    [JsonPropertyName("lowAction")]
    public V1beta2RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationActionsLowAction? LowAction { get; set; }

    /// <summary>Action to take for a medium risk. See action block below.</summary>
    [JsonPropertyName("mediumAction")]
    public V1beta2RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationActionsMediumAction? MediumAction { get; set; }
}

/// <summary>Email template used when a detected risk event is blocked. See notify email type below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail
{
    /// <summary>The email HTML body.</summary>
    [JsonPropertyName("htmlBody")]
    public string? HtmlBody { get; set; }

    /// <summary>The email subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The email text body.</summary>
    [JsonPropertyName("textBody")]
    public string? TextBody { get; set; }
}

/// <summary>The multi-factor authentication (MFA) email template used when MFA is challenged as part of a detected risk. See notify email type below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationNotifyConfigurationMfaEmail
{
    /// <summary>The email HTML body.</summary>
    [JsonPropertyName("htmlBody")]
    public string? HtmlBody { get; set; }

    /// <summary>The email subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The email text body.</summary>
    [JsonPropertyName("textBody")]
    public string? TextBody { get; set; }
}

/// <summary>The email template used when a detected risk event is allowed. See notify email type below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail
{
    /// <summary>The email HTML body.</summary>
    [JsonPropertyName("htmlBody")]
    public string? HtmlBody { get; set; }

    /// <summary>The email subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The email text body.</summary>
    [JsonPropertyName("textBody")]
    public string? TextBody { get; set; }
}

/// <summary>The notify configuration used to construct email notifications. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationNotifyConfiguration
{
    /// <summary>Email template used when a detected risk event is blocked. See notify email type below.</summary>
    [JsonPropertyName("blockEmail")]
    public V1beta2RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail? BlockEmail { get; set; }

    /// <summary>The email address that is sending the email. The address must be either individually verified with Amazon Simple Email Service, or from a domain that has been verified with Amazon SES.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>The multi-factor authentication (MFA) email template used when MFA is challenged as part of a detected risk. See notify email type below.</summary>
    [JsonPropertyName("mfaEmail")]
    public V1beta2RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationNotifyConfigurationMfaEmail? MfaEmail { get; set; }

    /// <summary>The email template used when a detected risk event is allowed. See notify email type below.</summary>
    [JsonPropertyName("noActionEmail")]
    public V1beta2RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail? NoActionEmail { get; set; }

    /// <summary>The destination to which the receiver of an email should reply to.</summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the identity that is associated with the sending authorization policy. This identity permits Amazon Cognito to send for the email address specified in the From parameter.</summary>
    [JsonPropertyName("sourceArn")]
    public string? SourceArn { get; set; }
}

/// <summary>The account takeover risk configuration. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecForProviderAccountTakeoverRiskConfiguration
{
    /// <summary>Account takeover risk configuration actions. See details below.</summary>
    [JsonPropertyName("actions")]
    public V1beta2RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationActions? Actions { get; set; }

    /// <summary>The notify configuration used to construct email notifications. See details below.</summary>
    [JsonPropertyName("notifyConfiguration")]
    public V1beta2RiskConfigurationSpecForProviderAccountTakeoverRiskConfigurationNotifyConfiguration? NotifyConfiguration { get; set; }
}

/// <summary>The compromised credentials risk configuration actions. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecForProviderCompromisedCredentialsRiskConfigurationActions
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }
}

/// <summary>The compromised credentials risk configuration. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecForProviderCompromisedCredentialsRiskConfiguration
{
    /// <summary>The compromised credentials risk configuration actions. See details below.</summary>
    [JsonPropertyName("actions")]
    public V1beta2RiskConfigurationSpecForProviderCompromisedCredentialsRiskConfigurationActions? Actions { get; set; }

    /// <summary>Perform the action for these events. The default is to perform all events if no event filter is specified. Valid values are SIGN_IN, PASSWORD_CHANGE, and SIGN_UP.</summary>
    [JsonPropertyName("eventFilter")]
    public IList<string>? EventFilter { get; set; }
}

/// <summary>The configuration to override the risk decision. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecForProviderRiskExceptionConfiguration
{
    /// <summary>
    /// Overrides the risk decision to always block the pre-authentication requests.
    /// The IP range is in CIDR notation, a compact representation of an IP address and its routing prefix.
    /// Can contain a maximum of 200 items.
    /// </summary>
    [JsonPropertyName("blockedIpRangeList")]
    public IList<string>? BlockedIpRangeList { get; set; }

    /// <summary>
    /// Risk detection isn&apos;t performed on the IP addresses in this range list.
    /// The IP range is in CIDR notation.
    /// Can contain a maximum of 200 items.
    /// </summary>
    [JsonPropertyName("skippedIpRangeList")]
    public IList<string>? SkippedIpRangeList { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RiskConfigurationSpecForProviderUserPoolIdRefPolicyResolutionEnum>))]
public enum V1beta2RiskConfigurationSpecForProviderUserPoolIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RiskConfigurationSpecForProviderUserPoolIdRefPolicyResolveEnum>))]
public enum V1beta2RiskConfigurationSpecForProviderUserPoolIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecForProviderUserPoolIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RiskConfigurationSpecForProviderUserPoolIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RiskConfigurationSpecForProviderUserPoolIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecForProviderUserPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RiskConfigurationSpecForProviderUserPoolIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RiskConfigurationSpecForProviderUserPoolIdSelectorPolicyResolutionEnum>))]
public enum V1beta2RiskConfigurationSpecForProviderUserPoolIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RiskConfigurationSpecForProviderUserPoolIdSelectorPolicyResolveEnum>))]
public enum V1beta2RiskConfigurationSpecForProviderUserPoolIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecForProviderUserPoolIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RiskConfigurationSpecForProviderUserPoolIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RiskConfigurationSpecForProviderUserPoolIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecForProviderUserPoolIdSelector
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
    public V1beta2RiskConfigurationSpecForProviderUserPoolIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecForProvider
{
    /// <summary>The account takeover risk configuration. See details below.</summary>
    [JsonPropertyName("accountTakeoverRiskConfiguration")]
    public V1beta2RiskConfigurationSpecForProviderAccountTakeoverRiskConfiguration? AccountTakeoverRiskConfiguration { get; set; }

    /// <summary>The app client ID. When the client ID is not provided, the same risk configuration is applied to all the clients in the User Pool.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The compromised credentials risk configuration. See details below.</summary>
    [JsonPropertyName("compromisedCredentialsRiskConfiguration")]
    public V1beta2RiskConfigurationSpecForProviderCompromisedCredentialsRiskConfiguration? CompromisedCredentialsRiskConfiguration { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The configuration to override the risk decision. See details below.</summary>
    [JsonPropertyName("riskExceptionConfiguration")]
    public V1beta2RiskConfigurationSpecForProviderRiskExceptionConfiguration? RiskExceptionConfiguration { get; set; }

    /// <summary>The user pool ID.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }

    /// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdRef")]
    public V1beta2RiskConfigurationSpecForProviderUserPoolIdRef? UserPoolIdRef { get; set; }

    /// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdSelector")]
    public V1beta2RiskConfigurationSpecForProviderUserPoolIdSelector? UserPoolIdSelector { get; set; }
}

/// <summary>Action to take for a high risk. See action block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationActionsHighAction
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }

    /// <summary>Whether to send a notification.</summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; }
}

/// <summary>Action to take for a low risk. See action block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationActionsLowAction
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }

    /// <summary>Whether to send a notification.</summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; }
}

/// <summary>Action to take for a medium risk. See action block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationActionsMediumAction
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }

    /// <summary>Whether to send a notification.</summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; }
}

/// <summary>Account takeover risk configuration actions. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationActions
{
    /// <summary>Action to take for a high risk. See action block below.</summary>
    [JsonPropertyName("highAction")]
    public V1beta2RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationActionsHighAction? HighAction { get; set; }

    /// <summary>Action to take for a low risk. See action block below.</summary>
    [JsonPropertyName("lowAction")]
    public V1beta2RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationActionsLowAction? LowAction { get; set; }

    /// <summary>Action to take for a medium risk. See action block below.</summary>
    [JsonPropertyName("mediumAction")]
    public V1beta2RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationActionsMediumAction? MediumAction { get; set; }
}

/// <summary>Email template used when a detected risk event is blocked. See notify email type below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail
{
    /// <summary>The email HTML body.</summary>
    [JsonPropertyName("htmlBody")]
    public string? HtmlBody { get; set; }

    /// <summary>The email subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The email text body.</summary>
    [JsonPropertyName("textBody")]
    public string? TextBody { get; set; }
}

/// <summary>The multi-factor authentication (MFA) email template used when MFA is challenged as part of a detected risk. See notify email type below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationNotifyConfigurationMfaEmail
{
    /// <summary>The email HTML body.</summary>
    [JsonPropertyName("htmlBody")]
    public string? HtmlBody { get; set; }

    /// <summary>The email subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The email text body.</summary>
    [JsonPropertyName("textBody")]
    public string? TextBody { get; set; }
}

/// <summary>The email template used when a detected risk event is allowed. See notify email type below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail
{
    /// <summary>The email HTML body.</summary>
    [JsonPropertyName("htmlBody")]
    public string? HtmlBody { get; set; }

    /// <summary>The email subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The email text body.</summary>
    [JsonPropertyName("textBody")]
    public string? TextBody { get; set; }
}

/// <summary>The notify configuration used to construct email notifications. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationNotifyConfiguration
{
    /// <summary>Email template used when a detected risk event is blocked. See notify email type below.</summary>
    [JsonPropertyName("blockEmail")]
    public V1beta2RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail? BlockEmail { get; set; }

    /// <summary>The email address that is sending the email. The address must be either individually verified with Amazon Simple Email Service, or from a domain that has been verified with Amazon SES.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>The multi-factor authentication (MFA) email template used when MFA is challenged as part of a detected risk. See notify email type below.</summary>
    [JsonPropertyName("mfaEmail")]
    public V1beta2RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationNotifyConfigurationMfaEmail? MfaEmail { get; set; }

    /// <summary>The email template used when a detected risk event is allowed. See notify email type below.</summary>
    [JsonPropertyName("noActionEmail")]
    public V1beta2RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail? NoActionEmail { get; set; }

    /// <summary>The destination to which the receiver of an email should reply to.</summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the identity that is associated with the sending authorization policy. This identity permits Amazon Cognito to send for the email address specified in the From parameter.</summary>
    [JsonPropertyName("sourceArn")]
    public string? SourceArn { get; set; }
}

/// <summary>The account takeover risk configuration. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecInitProviderAccountTakeoverRiskConfiguration
{
    /// <summary>Account takeover risk configuration actions. See details below.</summary>
    [JsonPropertyName("actions")]
    public V1beta2RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationActions? Actions { get; set; }

    /// <summary>The notify configuration used to construct email notifications. See details below.</summary>
    [JsonPropertyName("notifyConfiguration")]
    public V1beta2RiskConfigurationSpecInitProviderAccountTakeoverRiskConfigurationNotifyConfiguration? NotifyConfiguration { get; set; }
}

/// <summary>The compromised credentials risk configuration actions. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecInitProviderCompromisedCredentialsRiskConfigurationActions
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }
}

/// <summary>The compromised credentials risk configuration. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecInitProviderCompromisedCredentialsRiskConfiguration
{
    /// <summary>The compromised credentials risk configuration actions. See details below.</summary>
    [JsonPropertyName("actions")]
    public V1beta2RiskConfigurationSpecInitProviderCompromisedCredentialsRiskConfigurationActions? Actions { get; set; }

    /// <summary>Perform the action for these events. The default is to perform all events if no event filter is specified. Valid values are SIGN_IN, PASSWORD_CHANGE, and SIGN_UP.</summary>
    [JsonPropertyName("eventFilter")]
    public IList<string>? EventFilter { get; set; }
}

/// <summary>The configuration to override the risk decision. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecInitProviderRiskExceptionConfiguration
{
    /// <summary>
    /// Overrides the risk decision to always block the pre-authentication requests.
    /// The IP range is in CIDR notation, a compact representation of an IP address and its routing prefix.
    /// Can contain a maximum of 200 items.
    /// </summary>
    [JsonPropertyName("blockedIpRangeList")]
    public IList<string>? BlockedIpRangeList { get; set; }

    /// <summary>
    /// Risk detection isn&apos;t performed on the IP addresses in this range list.
    /// The IP range is in CIDR notation.
    /// Can contain a maximum of 200 items.
    /// </summary>
    [JsonPropertyName("skippedIpRangeList")]
    public IList<string>? SkippedIpRangeList { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RiskConfigurationSpecInitProviderUserPoolIdRefPolicyResolutionEnum>))]
public enum V1beta2RiskConfigurationSpecInitProviderUserPoolIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RiskConfigurationSpecInitProviderUserPoolIdRefPolicyResolveEnum>))]
public enum V1beta2RiskConfigurationSpecInitProviderUserPoolIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecInitProviderUserPoolIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RiskConfigurationSpecInitProviderUserPoolIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RiskConfigurationSpecInitProviderUserPoolIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecInitProviderUserPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RiskConfigurationSpecInitProviderUserPoolIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RiskConfigurationSpecInitProviderUserPoolIdSelectorPolicyResolutionEnum>))]
public enum V1beta2RiskConfigurationSpecInitProviderUserPoolIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RiskConfigurationSpecInitProviderUserPoolIdSelectorPolicyResolveEnum>))]
public enum V1beta2RiskConfigurationSpecInitProviderUserPoolIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecInitProviderUserPoolIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RiskConfigurationSpecInitProviderUserPoolIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RiskConfigurationSpecInitProviderUserPoolIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecInitProviderUserPoolIdSelector
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
    public V1beta2RiskConfigurationSpecInitProviderUserPoolIdSelectorPolicy? Policy { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecInitProvider
{
    /// <summary>The account takeover risk configuration. See details below.</summary>
    [JsonPropertyName("accountTakeoverRiskConfiguration")]
    public V1beta2RiskConfigurationSpecInitProviderAccountTakeoverRiskConfiguration? AccountTakeoverRiskConfiguration { get; set; }

    /// <summary>The app client ID. When the client ID is not provided, the same risk configuration is applied to all the clients in the User Pool.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The compromised credentials risk configuration. See details below.</summary>
    [JsonPropertyName("compromisedCredentialsRiskConfiguration")]
    public V1beta2RiskConfigurationSpecInitProviderCompromisedCredentialsRiskConfiguration? CompromisedCredentialsRiskConfiguration { get; set; }

    /// <summary>The configuration to override the risk decision. See details below.</summary>
    [JsonPropertyName("riskExceptionConfiguration")]
    public V1beta2RiskConfigurationSpecInitProviderRiskExceptionConfiguration? RiskExceptionConfiguration { get; set; }

    /// <summary>The user pool ID.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }

    /// <summary>Reference to a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdRef")]
    public V1beta2RiskConfigurationSpecInitProviderUserPoolIdRef? UserPoolIdRef { get; set; }

    /// <summary>Selector for a UserPool in cognitoidp to populate userPoolId.</summary>
    [JsonPropertyName("userPoolIdSelector")]
    public V1beta2RiskConfigurationSpecInitProviderUserPoolIdSelector? UserPoolIdSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RiskConfigurationSpecManagementPoliciesEnum>))]
public enum V1beta2RiskConfigurationSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RiskConfigurationSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2RiskConfigurationSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RiskConfigurationSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2RiskConfigurationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RiskConfigurationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RiskConfigurationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RiskConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>RiskConfigurationSpec defines the desired state of RiskConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationSpec
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
    public V1beta2RiskConfigurationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2RiskConfigurationSpecForProvider ForProvider { get; set; }

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
    public V1beta2RiskConfigurationSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2RiskConfigurationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2RiskConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2RiskConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Action to take for a high risk. See action block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationActionsHighAction
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }

    /// <summary>Whether to send a notification.</summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; }
}

/// <summary>Action to take for a low risk. See action block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationActionsLowAction
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }

    /// <summary>Whether to send a notification.</summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; }
}

/// <summary>Action to take for a medium risk. See action block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationActionsMediumAction
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }

    /// <summary>Whether to send a notification.</summary>
    [JsonPropertyName("notify")]
    public bool? Notify { get; set; }
}

/// <summary>Account takeover risk configuration actions. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationActions
{
    /// <summary>Action to take for a high risk. See action block below.</summary>
    [JsonPropertyName("highAction")]
    public V1beta2RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationActionsHighAction? HighAction { get; set; }

    /// <summary>Action to take for a low risk. See action block below.</summary>
    [JsonPropertyName("lowAction")]
    public V1beta2RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationActionsLowAction? LowAction { get; set; }

    /// <summary>Action to take for a medium risk. See action block below.</summary>
    [JsonPropertyName("mediumAction")]
    public V1beta2RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationActionsMediumAction? MediumAction { get; set; }
}

/// <summary>Email template used when a detected risk event is blocked. See notify email type below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail
{
    /// <summary>The email HTML body.</summary>
    [JsonPropertyName("htmlBody")]
    public string? HtmlBody { get; set; }

    /// <summary>The email subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The email text body.</summary>
    [JsonPropertyName("textBody")]
    public string? TextBody { get; set; }
}

/// <summary>The multi-factor authentication (MFA) email template used when MFA is challenged as part of a detected risk. See notify email type below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationNotifyConfigurationMfaEmail
{
    /// <summary>The email HTML body.</summary>
    [JsonPropertyName("htmlBody")]
    public string? HtmlBody { get; set; }

    /// <summary>The email subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The email text body.</summary>
    [JsonPropertyName("textBody")]
    public string? TextBody { get; set; }
}

/// <summary>The email template used when a detected risk event is allowed. See notify email type below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail
{
    /// <summary>The email HTML body.</summary>
    [JsonPropertyName("htmlBody")]
    public string? HtmlBody { get; set; }

    /// <summary>The email subject.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>The email text body.</summary>
    [JsonPropertyName("textBody")]
    public string? TextBody { get; set; }
}

/// <summary>The notify configuration used to construct email notifications. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationNotifyConfiguration
{
    /// <summary>Email template used when a detected risk event is blocked. See notify email type below.</summary>
    [JsonPropertyName("blockEmail")]
    public V1beta2RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationNotifyConfigurationBlockEmail? BlockEmail { get; set; }

    /// <summary>The email address that is sending the email. The address must be either individually verified with Amazon Simple Email Service, or from a domain that has been verified with Amazon SES.</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>The multi-factor authentication (MFA) email template used when MFA is challenged as part of a detected risk. See notify email type below.</summary>
    [JsonPropertyName("mfaEmail")]
    public V1beta2RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationNotifyConfigurationMfaEmail? MfaEmail { get; set; }

    /// <summary>The email template used when a detected risk event is allowed. See notify email type below.</summary>
    [JsonPropertyName("noActionEmail")]
    public V1beta2RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationNotifyConfigurationNoActionEmail? NoActionEmail { get; set; }

    /// <summary>The destination to which the receiver of an email should reply to.</summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the identity that is associated with the sending authorization policy. This identity permits Amazon Cognito to send for the email address specified in the From parameter.</summary>
    [JsonPropertyName("sourceArn")]
    public string? SourceArn { get; set; }
}

/// <summary>The account takeover risk configuration. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationStatusAtProviderAccountTakeoverRiskConfiguration
{
    /// <summary>Account takeover risk configuration actions. See details below.</summary>
    [JsonPropertyName("actions")]
    public V1beta2RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationActions? Actions { get; set; }

    /// <summary>The notify configuration used to construct email notifications. See details below.</summary>
    [JsonPropertyName("notifyConfiguration")]
    public V1beta2RiskConfigurationStatusAtProviderAccountTakeoverRiskConfigurationNotifyConfiguration? NotifyConfiguration { get; set; }
}

/// <summary>The compromised credentials risk configuration actions. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationStatusAtProviderCompromisedCredentialsRiskConfigurationActions
{
    /// <summary>The action to take in response to the account takeover action. Valid values are BLOCK, MFA_IF_CONFIGURED, MFA_REQUIRED and NO_ACTION.</summary>
    [JsonPropertyName("eventAction")]
    public string? EventAction { get; set; }
}

/// <summary>The compromised credentials risk configuration. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationStatusAtProviderCompromisedCredentialsRiskConfiguration
{
    /// <summary>The compromised credentials risk configuration actions. See details below.</summary>
    [JsonPropertyName("actions")]
    public V1beta2RiskConfigurationStatusAtProviderCompromisedCredentialsRiskConfigurationActions? Actions { get; set; }

    /// <summary>Perform the action for these events. The default is to perform all events if no event filter is specified. Valid values are SIGN_IN, PASSWORD_CHANGE, and SIGN_UP.</summary>
    [JsonPropertyName("eventFilter")]
    public IList<string>? EventFilter { get; set; }
}

/// <summary>The configuration to override the risk decision. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationStatusAtProviderRiskExceptionConfiguration
{
    /// <summary>
    /// Overrides the risk decision to always block the pre-authentication requests.
    /// The IP range is in CIDR notation, a compact representation of an IP address and its routing prefix.
    /// Can contain a maximum of 200 items.
    /// </summary>
    [JsonPropertyName("blockedIpRangeList")]
    public IList<string>? BlockedIpRangeList { get; set; }

    /// <summary>
    /// Risk detection isn&apos;t performed on the IP addresses in this range list.
    /// The IP range is in CIDR notation.
    /// Can contain a maximum of 200 items.
    /// </summary>
    [JsonPropertyName("skippedIpRangeList")]
    public IList<string>? SkippedIpRangeList { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationStatusAtProvider
{
    /// <summary>The account takeover risk configuration. See details below.</summary>
    [JsonPropertyName("accountTakeoverRiskConfiguration")]
    public V1beta2RiskConfigurationStatusAtProviderAccountTakeoverRiskConfiguration? AccountTakeoverRiskConfiguration { get; set; }

    /// <summary>The app client ID. When the client ID is not provided, the same risk configuration is applied to all the clients in the User Pool.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The compromised credentials risk configuration. See details below.</summary>
    [JsonPropertyName("compromisedCredentialsRiskConfiguration")]
    public V1beta2RiskConfigurationStatusAtProviderCompromisedCredentialsRiskConfiguration? CompromisedCredentialsRiskConfiguration { get; set; }

    /// <summary>The user pool ID or the user pool ID and Client Id separated by a : if the configuration is client specific.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The configuration to override the risk decision. See details below.</summary>
    [JsonPropertyName("riskExceptionConfiguration")]
    public V1beta2RiskConfigurationStatusAtProviderRiskExceptionConfiguration? RiskExceptionConfiguration { get; set; }

    /// <summary>The user pool ID.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationStatusConditions
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

/// <summary>RiskConfigurationStatus defines the observed state of RiskConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RiskConfigurationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2RiskConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2RiskConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RiskConfiguration is the Schema for the RiskConfigurations API. Provides a Cognito Risk Configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RiskConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2RiskConfigurationSpec>, IStatus<V1beta2RiskConfigurationStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RiskConfiguration";
    public const string KubeGroup = "cognitoidp.aws.upbound.io";
    public const string KubePluralName = "riskconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cognitoidp.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RiskConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RiskConfigurationSpec defines the desired state of RiskConfiguration</summary>
    [JsonPropertyName("spec")]
    public required V1beta2RiskConfigurationSpec Spec { get; set; }

    /// <summary>RiskConfigurationStatus defines the observed state of RiskConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta2RiskConfigurationStatus? Status { get; set; }
}
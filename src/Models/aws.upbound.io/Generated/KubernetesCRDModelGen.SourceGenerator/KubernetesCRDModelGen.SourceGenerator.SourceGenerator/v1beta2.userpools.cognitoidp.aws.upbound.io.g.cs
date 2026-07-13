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
/// <summary>UserPool is the Schema for the UserPools API. Provides a Cognito User Pool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2UserPoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta2UserPool>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "UserPoolList";
    public const string KubeGroup = "cognitoidp.aws.upbound.io";
    public const string KubePluralName = "userpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cognitoidp.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "UserPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2UserPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2UserPool> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecDeletionPolicyEnum>))]
public enum V1beta2UserPoolSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderAccountRecoverySettingRecoveryMechanism
{
    /// <summary>Name of the user pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Positive integer specifying priority of a method with 1 being the highest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

/// <summary>Configuration block to define which verified available method a user can use to recover their forgotten password. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderAccountRecoverySetting
{
    /// <summary>List of Account Recovery Options of the following structure:</summary>
    [JsonPropertyName("recoveryMechanism")]
    public IList<V1beta2UserPoolSpecForProviderAccountRecoverySettingRecoveryMechanism>? RecoveryMechanism { get; set; }
}

/// <summary>Invite message template structure. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderAdminCreateUserConfigInviteMessageTemplate
{
    /// <summary>Message template for email messages. Must contain {username} and {####} placeholders, for username and temporary password, respectively.</summary>
    [JsonPropertyName("emailMessage")]
    public string? EmailMessage { get; set; }

    /// <summary>Subject line for email messages.</summary>
    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }

    /// <summary>Message template for SMS messages. Must contain {username} and {####} placeholders, for username and temporary password, respectively.</summary>
    [JsonPropertyName("smsMessage")]
    public string? SmsMessage { get; set; }
}

/// <summary>Configuration block for creating a new user profile. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderAdminCreateUserConfig
{
    /// <summary>Set to True if only the administrator is allowed to create user profiles. Set to False if users can sign themselves up via an app.</summary>
    [JsonPropertyName("allowAdminCreateUserOnly")]
    public bool? AllowAdminCreateUserOnly { get; set; }

    /// <summary>Invite message template structure. Detailed below.</summary>
    [JsonPropertyName("inviteMessageTemplate")]
    public V1beta2UserPoolSpecForProviderAdminCreateUserConfigInviteMessageTemplate? InviteMessageTemplate { get; set; }
}

/// <summary>Configuration block for the user pool&apos;s device tracking. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderDeviceConfiguration
{
    /// <summary>Whether a challenge is required on a new device. Only applicable to a new device.</summary>
    [JsonPropertyName("challengeRequiredOnNewDevice")]
    public bool? ChallengeRequiredOnNewDevice { get; set; }

    /// <summary>Whether a device is only remembered on user prompt. false equates to &quot;Always&quot; remember, true is &quot;User Opt In,&quot; and not using a device_configuration block is &quot;No.&quot;</summary>
    [JsonPropertyName("deviceOnlyRememberedOnUserPrompt")]
    public bool? DeviceOnlyRememberedOnUserPrompt { get; set; }
}

/// <summary>Configuration block for configuring email. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderEmailConfiguration
{
    /// <summary>Email configuration set name from SES.</summary>
    [JsonPropertyName("configurationSet")]
    public string? ConfigurationSet { get; set; }

    /// <summary>Email delivery method to use. COGNITO_DEFAULT for the default email functionality built into Cognito or DEVELOPER to use your Amazon SES configuration. Required to be DEVELOPER if from_email_address is set.</summary>
    [JsonPropertyName("emailSendingAccount")]
    public string? EmailSendingAccount { get; set; }

    /// <summary>Sender’s email address or sender’s display name with their email address (e.g., john@example.com, John Smith &lt;john@example.com&gt; or \&quot;John Smith Ph.D.\&quot; &lt;john@example.com&gt;). Escaped double quotes are required around display names that contain certain characters as specified in RFC 5322.</summary>
    [JsonPropertyName("fromEmailAddress")]
    public string? FromEmailAddress { get; set; }

    /// <summary>REPLY-TO email address.</summary>
    [JsonPropertyName("replyToEmailAddress")]
    public string? ReplyToEmailAddress { get; set; }

    /// <summary>ARN of the SES verified email identity to use. Required if email_sending_account is set to DEVELOPER.</summary>
    [JsonPropertyName("sourceArn")]
    public string? SourceArn { get; set; }
}

/// <summary>Configuration block for configuring email Multi-Factor Authentication (MFA); requires at least 2 account_recovery_setting entries; requires an email_configuration configuration block. Effective only when mfa_configuration is ON or OPTIONAL. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderEmailMfaConfiguration
{
    /// <summary>The template for the email messages that your user pool sends to users with codes for MFA and sign-in with email OTPs. The message must contain the {####} placeholder. In the message, Amazon Cognito replaces this placeholder with the code. If you don&apos;t provide this parameter, Amazon Cognito sends messages in the default format.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The subject of the email messages that your user pool sends to users with codes for MFA and email OTP sign-in.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate createAuthChallenge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate createAuthChallenge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelector
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
    public V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelector
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
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicy? Policy { get; set; }
}

/// <summary>A custom email sender AWS Lambda trigger. See custom_email_sender Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSender
{
    /// <summary>The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers to send email notifications to users.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSenderLambdaArnSelector? LambdaArnSelector { get; set; }

    /// <summary>The Lambda version represents the signature of the &quot;request&quot; attribute in the &quot;event&quot; information Amazon Cognito passes to your custom email Lambda function. The only supported value is V1_0.</summary>
    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate customMessage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate customMessage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageSelector
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
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelector
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
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicy? Policy { get; set; }
}

/// <summary>A custom SMS sender AWS Lambda trigger. See custom_sms_sender Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSender
{
    /// <summary>The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers to send SMS notifications to users.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSenderLambdaArnSelector? LambdaArnSelector { get; set; }

    /// <summary>The Lambda version represents the signature of the &quot;request&quot; attribute in the &quot;event&quot; information Amazon Cognito passes to your custom SMS Lambda function. The only supported value is V1_0.</summary>
    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate defineAuthChallenge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate defineAuthChallenge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelector
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
    public V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdSelector
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
    public V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate postAuthentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate postAuthentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationSelector
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
    public V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate postConfirmation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate postConfirmation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationSelector
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
    public V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate preAuthentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate preAuthentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationSelector
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
    public V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate preSignUp.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate preSignUp.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpSelector
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
    public V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpSelectorPolicy? Policy { get; set; }
}

/// <summary>Allow to customize access tokens. See pre_token_configuration_type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationConfig
{
    /// <summary>The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers to send SMS notifications to users.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>The Lambda version represents the signature of the &quot;version&quot; attribute in the &quot;event&quot; information Amazon Cognito passes to your pre Token Generation Lambda function. The supported values are V1_0, V2_0, V3_0.</summary>
    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate preTokenGeneration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate preTokenGeneration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelector
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
    public V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate userMigration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate userMigration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationSelector
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
    public V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate verifyAuthChallengeResponse.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate verifyAuthChallengeResponse.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelector
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
    public V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for the AWS Lambda triggers associated with the user pool. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderLambdaConfig
{
    /// <summary>ARN of the lambda creating an authentication challenge.</summary>
    [JsonPropertyName("createAuthChallenge")]
    public string? CreateAuthChallenge { get; set; }

    /// <summary>Reference to a Function in lambda to populate createAuthChallenge.</summary>
    [JsonPropertyName("createAuthChallengeRef")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeRef? CreateAuthChallengeRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate createAuthChallenge.</summary>
    [JsonPropertyName("createAuthChallengeSelector")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCreateAuthChallengeSelector? CreateAuthChallengeSelector { get; set; }

    /// <summary>A custom email sender AWS Lambda trigger. See custom_email_sender Below.</summary>
    [JsonPropertyName("customEmailSender")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomEmailSender? CustomEmailSender { get; set; }

    /// <summary>Custom Message AWS Lambda trigger.</summary>
    [JsonPropertyName("customMessage")]
    public string? CustomMessage { get; set; }

    /// <summary>Reference to a Function in lambda to populate customMessage.</summary>
    [JsonPropertyName("customMessageRef")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageRef? CustomMessageRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate customMessage.</summary>
    [JsonPropertyName("customMessageSelector")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomMessageSelector? CustomMessageSelector { get; set; }

    /// <summary>A custom SMS sender AWS Lambda trigger. See custom_sms_sender Below.</summary>
    [JsonPropertyName("customSmsSender")]
    public V1beta2UserPoolSpecForProviderLambdaConfigCustomSmsSender? CustomSmsSender { get; set; }

    /// <summary>Defines the authentication challenge.</summary>
    [JsonPropertyName("defineAuthChallenge")]
    public string? DefineAuthChallenge { get; set; }

    /// <summary>Reference to a Function in lambda to populate defineAuthChallenge.</summary>
    [JsonPropertyName("defineAuthChallengeRef")]
    public V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeRef? DefineAuthChallengeRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate defineAuthChallenge.</summary>
    [JsonPropertyName("defineAuthChallengeSelector")]
    public V1beta2UserPoolSpecForProviderLambdaConfigDefineAuthChallengeSelector? DefineAuthChallengeSelector { get; set; }

    /// <summary>The Amazon Resource Name of Key Management Service Customer master keys. Amazon Cognito uses the key to encrypt codes and temporary passwords sent to CustomEmailSender and CustomSMSSender.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta2UserPoolSpecForProviderLambdaConfigKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Post-authentication AWS Lambda trigger.</summary>
    [JsonPropertyName("postAuthentication")]
    public string? PostAuthentication { get; set; }

    /// <summary>Reference to a Function in lambda to populate postAuthentication.</summary>
    [JsonPropertyName("postAuthenticationRef")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationRef? PostAuthenticationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate postAuthentication.</summary>
    [JsonPropertyName("postAuthenticationSelector")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPostAuthenticationSelector? PostAuthenticationSelector { get; set; }

    /// <summary>Post-confirmation AWS Lambda trigger.</summary>
    [JsonPropertyName("postConfirmation")]
    public string? PostConfirmation { get; set; }

    /// <summary>Reference to a Function in lambda to populate postConfirmation.</summary>
    [JsonPropertyName("postConfirmationRef")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationRef? PostConfirmationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate postConfirmation.</summary>
    [JsonPropertyName("postConfirmationSelector")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPostConfirmationSelector? PostConfirmationSelector { get; set; }

    /// <summary>Pre-authentication AWS Lambda trigger.</summary>
    [JsonPropertyName("preAuthentication")]
    public string? PreAuthentication { get; set; }

    /// <summary>Reference to a Function in lambda to populate preAuthentication.</summary>
    [JsonPropertyName("preAuthenticationRef")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationRef? PreAuthenticationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate preAuthentication.</summary>
    [JsonPropertyName("preAuthenticationSelector")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreAuthenticationSelector? PreAuthenticationSelector { get; set; }

    /// <summary>Pre-registration AWS Lambda trigger.</summary>
    [JsonPropertyName("preSignUp")]
    public string? PreSignUp { get; set; }

    /// <summary>Reference to a Function in lambda to populate preSignUp.</summary>
    [JsonPropertyName("preSignUpRef")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpRef? PreSignUpRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate preSignUp.</summary>
    [JsonPropertyName("preSignUpSelector")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreSignUpSelector? PreSignUpSelector { get; set; }

    /// <summary>Allow to customize identity token claims before token generation. Set this parameter for legacy purposes; for new instances of pre token generation triggers, set the lambda_arn of pre_token_generation_config.</summary>
    [JsonPropertyName("preTokenGeneration")]
    public string? PreTokenGeneration { get; set; }

    /// <summary>Allow to customize access tokens. See pre_token_configuration_type</summary>
    [JsonPropertyName("preTokenGenerationConfig")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationConfig? PreTokenGenerationConfig { get; set; }

    /// <summary>Reference to a Function in lambda to populate preTokenGeneration.</summary>
    [JsonPropertyName("preTokenGenerationRef")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationRef? PreTokenGenerationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate preTokenGeneration.</summary>
    [JsonPropertyName("preTokenGenerationSelector")]
    public V1beta2UserPoolSpecForProviderLambdaConfigPreTokenGenerationSelector? PreTokenGenerationSelector { get; set; }

    /// <summary>User migration Lambda config type.</summary>
    [JsonPropertyName("userMigration")]
    public string? UserMigration { get; set; }

    /// <summary>Reference to a Function in lambda to populate userMigration.</summary>
    [JsonPropertyName("userMigrationRef")]
    public V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationRef? UserMigrationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate userMigration.</summary>
    [JsonPropertyName("userMigrationSelector")]
    public V1beta2UserPoolSpecForProviderLambdaConfigUserMigrationSelector? UserMigrationSelector { get; set; }

    /// <summary>Verifies the authentication challenge response.</summary>
    [JsonPropertyName("verifyAuthChallengeResponse")]
    public string? VerifyAuthChallengeResponse { get; set; }

    /// <summary>Reference to a Function in lambda to populate verifyAuthChallengeResponse.</summary>
    [JsonPropertyName("verifyAuthChallengeResponseRef")]
    public V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseRef? VerifyAuthChallengeResponseRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate verifyAuthChallengeResponse.</summary>
    [JsonPropertyName("verifyAuthChallengeResponseSelector")]
    public V1beta2UserPoolSpecForProviderLambdaConfigVerifyAuthChallengeResponseSelector? VerifyAuthChallengeResponseSelector { get; set; }
}

/// <summary>Configuration block for information about the user pool password policy. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderPasswordPolicy
{
    /// <summary>Minimum length of the password policy that you have set.</summary>
    [JsonPropertyName("minimumLength")]
    public double? MinimumLength { get; set; }

    /// <summary>Number of previous passwords that you want Amazon Cognito to restrict each user from reusing. Users can&apos;t set a password that matches any of number of previous passwords specified by this argument. A value of 0 means that password history is not enforced. Valid values are between 0 and 24.</summary>
    [JsonPropertyName("passwordHistorySize")]
    public double? PasswordHistorySize { get; set; }

    /// <summary>Whether you have required users to use at least one lowercase letter in their password.</summary>
    [JsonPropertyName("requireLowercase")]
    public bool? RequireLowercase { get; set; }

    /// <summary>Whether you have required users to use at least one number in their password.</summary>
    [JsonPropertyName("requireNumbers")]
    public bool? RequireNumbers { get; set; }

    /// <summary>Whether you have required users to use at least one symbol in their password.</summary>
    [JsonPropertyName("requireSymbols")]
    public bool? RequireSymbols { get; set; }

    /// <summary>Whether you have required users to use at least one uppercase letter in their password.</summary>
    [JsonPropertyName("requireUppercase")]
    public bool? RequireUppercase { get; set; }

    /// <summary>In the password policy you have set, refers to the number of days a temporary password is valid. If the user does not sign-in during this time, their password will need to be reset by an administrator.</summary>
    [JsonPropertyName("temporaryPasswordValidityDays")]
    public double? TemporaryPasswordValidityDays { get; set; }
}

/// <summary>Configuration block for the constraints for an attribute of the number type. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderSchemaNumberAttributeConstraints
{
    /// <summary>Maximum value of an attribute that is of the number data type.</summary>
    [JsonPropertyName("maxValue")]
    public string? MaxValue { get; set; }

    /// <summary>Minimum value of an attribute that is of the number data type.</summary>
    [JsonPropertyName("minValue")]
    public string? MinValue { get; set; }
}

/// <summary>Constraints for an attribute of the string type. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderSchemaStringAttributeConstraints
{
    /// <summary>Maximum length of an attribute value of the string type.</summary>
    [JsonPropertyName("maxLength")]
    public string? MaxLength { get; set; }

    /// <summary>Minimum length of an attribute value of the string type.</summary>
    [JsonPropertyName("minLength")]
    public string? MinLength { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderSchema
{
    /// <summary>Attribute data type. Must be one of Boolean, Number, String, DateTime.</summary>
    [JsonPropertyName("attributeDataType")]
    public string? AttributeDataType { get; set; }

    /// <summary>Whether the attribute type is developer only.</summary>
    [JsonPropertyName("developerOnlyAttribute")]
    public bool? DeveloperOnlyAttribute { get; set; }

    /// <summary>Whether the attribute can be changed once it has been created.</summary>
    [JsonPropertyName("mutable")]
    public bool? Mutable { get; set; }

    /// <summary>Name of the user pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block for the constraints for an attribute of the number type. Detailed below.</summary>
    [JsonPropertyName("numberAttributeConstraints")]
    public V1beta2UserPoolSpecForProviderSchemaNumberAttributeConstraints? NumberAttributeConstraints { get; set; }

    /// <summary>Whether a user pool attribute is required. If the attribute is required and the user does not provide a value, registration or sign-in will fail.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Constraints for an attribute of the string type. Detailed below.</summary>
    [JsonPropertyName("stringAttributeConstraints")]
    public V1beta2UserPoolSpecForProviderSchemaStringAttributeConstraints? StringAttributeConstraints { get; set; }
}

/// <summary>Configuration block for information about the user pool sign in policy. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderSignInPolicy
{
    /// <summary>The sign in methods your user pool supports as the first factor. This is a list of strings, allowed values are PASSWORD, EMAIL_OTP, SMS_OTP, and WEB_AUTHN.</summary>
    [JsonPropertyName("allowedFirstAuthFactors")]
    public IList<string>? AllowedFirstAuthFactors { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate snsCallerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate snsCallerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelector
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
    public V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for Short Message Service (SMS) settings. Detailed below. These settings apply to SMS user verification and SMS Multi-Factor Authentication (MFA). SMS MFA is activated only when mfa_configuration is set to ON or OPTIONAL along with this block. Due to Cognito API restrictions, the SMS configuration cannot be removed without recreating the Cognito User Pool. For user data safety, this resource will ignore the removal of this configuration by disabling drift detection. To force resource recreation after this configuration has been applied, see the taint command.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderSmsConfiguration
{
    /// <summary>External ID used in IAM role trust relationships. For more information about using external IDs, see How to Use an External ID When Granting Access to Your AWS Resources to a Third Party.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>ARN of the Amazon SNS caller. This is usually the IAM role that you&apos;ve given Cognito permission to assume.</summary>
    [JsonPropertyName("snsCallerArn")]
    public string? SnsCallerArn { get; set; }

    /// <summary>Reference to a Role in iam to populate snsCallerArn.</summary>
    [JsonPropertyName("snsCallerArnRef")]
    public V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnRef? SnsCallerArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate snsCallerArn.</summary>
    [JsonPropertyName("snsCallerArnSelector")]
    public V1beta2UserPoolSpecForProviderSmsConfigurationSnsCallerArnSelector? SnsCallerArnSelector { get; set; }

    /// <summary>The AWS Region to use with Amazon SNS integration. You can choose the same Region as your user pool, or a supported Legacy Amazon SNS alternate Region. Amazon Cognito resources in the Asia Pacific (Seoul) AWS Region must use your Amazon SNS configuration in the Asia Pacific (Tokyo) Region. For more information, see SMS message settings for Amazon Cognito user pools.</summary>
    [JsonPropertyName("snsRegion")]
    public string? SnsRegion { get; set; }
}

/// <summary>Configuration block for software token Mult-Factor Authentication (MFA) settings. Effective only when mfa_configuration is ON or OPTIONAL. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderSoftwareTokenMfaConfiguration
{
    /// <summary>Boolean whether to enable software token Multi-Factor (MFA) tokens, such as Time-based One-Time Password (TOTP). To disable software token MFA When sms_configuration is not present, the mfa_configuration argument must be set to OFF and the software_token_mfa_configuration configuration block must be fully removed.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration block for user attribute update settings. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderUserAttributeUpdateSettings
{
    /// <summary>A list of attributes requiring verification before update. If set, the provided value(s) must also be set in auto_verified_attributes. Valid values: email, phone_number.</summary>
    [JsonPropertyName("attributesRequireVerificationBeforeUpdate")]
    public IList<string>? AttributesRequireVerificationBeforeUpdate { get; set; }
}

/// <summary>A block to specify the threat protection configuration options for additional authentication types in your user pool, including custom authentication. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderUserPoolAddOnsAdvancedSecurityAdditionalFlows
{
    /// <summary>Mode of threat protection operation in custom authentication. Valid values are AUDIT or ENFORCED. The default value is AUDIT.</summary>
    [JsonPropertyName("customAuthMode")]
    public string? CustomAuthMode { get; set; }
}

/// <summary>Configuration block for user pool add-ons to enable user pool advanced security mode features. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderUserPoolAddOns
{
    /// <summary>A block to specify the threat protection configuration options for additional authentication types in your user pool, including custom authentication. Detailed below.</summary>
    [JsonPropertyName("advancedSecurityAdditionalFlows")]
    public V1beta2UserPoolSpecForProviderUserPoolAddOnsAdvancedSecurityAdditionalFlows? AdvancedSecurityAdditionalFlows { get; set; }

    /// <summary>Mode for advanced security, must be one of OFF, AUDIT or ENFORCED.</summary>
    [JsonPropertyName("advancedSecurityMode")]
    public string? AdvancedSecurityMode { get; set; }
}

/// <summary>Configuration block for username configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderUsernameConfiguration
{
    /// <summary>Whether username case sensitivity will be applied for all users in the user pool through Cognito APIs.</summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }
}

/// <summary>Configuration block for verification message templates. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderVerificationMessageTemplate
{
    /// <summary>Default email option. Must be either CONFIRM_WITH_CODE or CONFIRM_WITH_LINK. Defaults to CONFIRM_WITH_CODE.</summary>
    [JsonPropertyName("defaultEmailOption")]
    public string? DefaultEmailOption { get; set; }

    /// <summary>Email message template. Must contain the {####} placeholder. Conflicts with email_verification_message argument.</summary>
    [JsonPropertyName("emailMessage")]
    public string? EmailMessage { get; set; }

    /// <summary>Email message template for sending a confirmation link to the user, it must contain the {##Click Here##} placeholder.</summary>
    [JsonPropertyName("emailMessageByLink")]
    public string? EmailMessageByLink { get; set; }

    /// <summary>Subject line for the email message template. Conflicts with email_verification_subject argument.</summary>
    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }

    /// <summary>Subject line for the email message template for sending a confirmation link to the user.</summary>
    [JsonPropertyName("emailSubjectByLink")]
    public string? EmailSubjectByLink { get; set; }

    /// <summary>SMS message template. Must contain the {####} placeholder. Conflicts with sms_verification_message argument.</summary>
    [JsonPropertyName("smsMessage")]
    public string? SmsMessage { get; set; }
}

/// <summary>Configuration block for web authn configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProviderWebAuthnConfiguration
{
    /// <summary>The authentication domain that passkeys providers use as a relying party.</summary>
    [JsonPropertyName("relyingPartyId")]
    public string? RelyingPartyId { get; set; }

    /// <summary>If your user pool should require a passkey. Must be one of required or preferred.</summary>
    [JsonPropertyName("userVerification")]
    public string? UserVerification { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecForProvider
{
    /// <summary>Configuration block to define which verified available method a user can use to recover their forgotten password. Detailed below.</summary>
    [JsonPropertyName("accountRecoverySetting")]
    public V1beta2UserPoolSpecForProviderAccountRecoverySetting? AccountRecoverySetting { get; set; }

    /// <summary>Configuration block for creating a new user profile. Detailed below.</summary>
    [JsonPropertyName("adminCreateUserConfig")]
    public V1beta2UserPoolSpecForProviderAdminCreateUserConfig? AdminCreateUserConfig { get; set; }

    /// <summary>Attributes supported as an alias for this user pool. Valid values: phone_number, email, or preferred_username. Conflicts with username_attributes.</summary>
    [JsonPropertyName("aliasAttributes")]
    public IList<string>? AliasAttributes { get; set; }

    /// <summary>Attributes to be auto-verified. Valid values: email, phone_number.</summary>
    [JsonPropertyName("autoVerifiedAttributes")]
    public IList<string>? AutoVerifiedAttributes { get; set; }

    /// <summary>When active, DeletionProtection prevents accidental deletion of your user pool. Before you can delete a user pool that you have protected against deletion, you must deactivate this feature. Valid values are ACTIVE and INACTIVE, Default value is INACTIVE.</summary>
    [JsonPropertyName("deletionProtection")]
    public string? DeletionProtection { get; set; }

    /// <summary>Configuration block for the user pool&apos;s device tracking. Detailed below.</summary>
    [JsonPropertyName("deviceConfiguration")]
    public V1beta2UserPoolSpecForProviderDeviceConfiguration? DeviceConfiguration { get; set; }

    /// <summary>Configuration block for configuring email. Detailed below.</summary>
    [JsonPropertyName("emailConfiguration")]
    public V1beta2UserPoolSpecForProviderEmailConfiguration? EmailConfiguration { get; set; }

    /// <summary>Configuration block for configuring email Multi-Factor Authentication (MFA); requires at least 2 account_recovery_setting entries; requires an email_configuration configuration block. Effective only when mfa_configuration is ON or OPTIONAL. Detailed below.</summary>
    [JsonPropertyName("emailMfaConfiguration")]
    public V1beta2UserPoolSpecForProviderEmailMfaConfiguration? EmailMfaConfiguration { get; set; }

    /// <summary>String representing the email verification message. Conflicts with verification_message_template configuration block email_message argument.</summary>
    [JsonPropertyName("emailVerificationMessage")]
    public string? EmailVerificationMessage { get; set; }

    /// <summary>String representing the email verification subject. Conflicts with verification_message_template configuration block email_subject argument.</summary>
    [JsonPropertyName("emailVerificationSubject")]
    public string? EmailVerificationSubject { get; set; }

    /// <summary>Configuration block for the AWS Lambda triggers associated with the user pool. Detailed below.</summary>
    [JsonPropertyName("lambdaConfig")]
    public V1beta2UserPoolSpecForProviderLambdaConfig? LambdaConfig { get; set; }

    /// <summary>Multi-Factor Authentication (MFA) configuration for the User Pool. Defaults of OFF. Valid values are OFF (MFA Tokens are not required), ON (MFA is required for all users to sign in; requires at least one of email_mfa_configuration, sms_configuration or software_token_mfa_configuration to be configured), or OPTIONAL (MFA Will be required only for individual users who have MFA Enabled; requires at least one of email_mfa_configuration, sms_configuration or software_token_mfa_configuration to be configured).</summary>
    [JsonPropertyName("mfaConfiguration")]
    public string? MfaConfiguration { get; set; }

    /// <summary>Name of the user pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block for information about the user pool password policy. Detailed below.</summary>
    [JsonPropertyName("passwordPolicy")]
    public V1beta2UserPoolSpecForProviderPasswordPolicy? PasswordPolicy { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Configuration block for the schema attributes of a user pool. Detailed below. Schema attributes from the standard attribute set only need to be specified if they are different from the default configuration. Attributes can be added, but not modified or removed. Maximum of 50 attributes.</summary>
    [JsonPropertyName("schema")]
    public IList<V1beta2UserPoolSpecForProviderSchema>? Schema { get; set; }

    /// <summary>Configuration block for information about the user pool sign in policy. Detailed below.</summary>
    [JsonPropertyName("signInPolicy")]
    public V1beta2UserPoolSpecForProviderSignInPolicy? SignInPolicy { get; set; }

    /// <summary>String representing the SMS authentication message. The Message must contain the {####} placeholder, which will be replaced with the code.</summary>
    [JsonPropertyName("smsAuthenticationMessage")]
    public string? SmsAuthenticationMessage { get; set; }

    /// <summary>Configuration block for Short Message Service (SMS) settings. Detailed below. These settings apply to SMS user verification and SMS Multi-Factor Authentication (MFA). SMS MFA is activated only when mfa_configuration is set to ON or OPTIONAL along with this block. Due to Cognito API restrictions, the SMS configuration cannot be removed without recreating the Cognito User Pool. For user data safety, this resource will ignore the removal of this configuration by disabling drift detection. To force resource recreation after this configuration has been applied, see the taint command.</summary>
    [JsonPropertyName("smsConfiguration")]
    public V1beta2UserPoolSpecForProviderSmsConfiguration? SmsConfiguration { get; set; }

    /// <summary>String representing the SMS verification message. Conflicts with verification_message_template configuration block sms_message argument.</summary>
    [JsonPropertyName("smsVerificationMessage")]
    public string? SmsVerificationMessage { get; set; }

    /// <summary>Configuration block for software token Mult-Factor Authentication (MFA) settings. Effective only when mfa_configuration is ON or OPTIONAL. Detailed below.</summary>
    [JsonPropertyName("softwareTokenMfaConfiguration")]
    public V1beta2UserPoolSpecForProviderSoftwareTokenMfaConfiguration? SoftwareTokenMfaConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for user attribute update settings. Detailed below.</summary>
    [JsonPropertyName("userAttributeUpdateSettings")]
    public V1beta2UserPoolSpecForProviderUserAttributeUpdateSettings? UserAttributeUpdateSettings { get; set; }

    /// <summary>Configuration block for user pool add-ons to enable user pool advanced security mode features. Detailed below.</summary>
    [JsonPropertyName("userPoolAddOns")]
    public V1beta2UserPoolSpecForProviderUserPoolAddOns? UserPoolAddOns { get; set; }

    /// <summary>The user pool feature plan, or tier. Valid values: LITE, ESSENTIALS, PLUS.</summary>
    [JsonPropertyName("userPoolTier")]
    public string? UserPoolTier { get; set; }

    /// <summary>Whether email addresses or phone numbers can be specified as usernames when a user signs up. Conflicts with alias_attributes.</summary>
    [JsonPropertyName("usernameAttributes")]
    public IList<string>? UsernameAttributes { get; set; }

    /// <summary>Configuration block for username configuration. Detailed below.</summary>
    [JsonPropertyName("usernameConfiguration")]
    public V1beta2UserPoolSpecForProviderUsernameConfiguration? UsernameConfiguration { get; set; }

    /// <summary>Configuration block for verification message templates. Detailed below.</summary>
    [JsonPropertyName("verificationMessageTemplate")]
    public V1beta2UserPoolSpecForProviderVerificationMessageTemplate? VerificationMessageTemplate { get; set; }

    /// <summary>Configuration block for web authn configuration. Detailed below.</summary>
    [JsonPropertyName("webAuthnConfiguration")]
    public V1beta2UserPoolSpecForProviderWebAuthnConfiguration? WebAuthnConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderAccountRecoverySettingRecoveryMechanism
{
    /// <summary>Name of the user pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Positive integer specifying priority of a method with 1 being the highest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

/// <summary>Configuration block to define which verified available method a user can use to recover their forgotten password. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderAccountRecoverySetting
{
    /// <summary>List of Account Recovery Options of the following structure:</summary>
    [JsonPropertyName("recoveryMechanism")]
    public IList<V1beta2UserPoolSpecInitProviderAccountRecoverySettingRecoveryMechanism>? RecoveryMechanism { get; set; }
}

/// <summary>Invite message template structure. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderAdminCreateUserConfigInviteMessageTemplate
{
    /// <summary>Message template for email messages. Must contain {username} and {####} placeholders, for username and temporary password, respectively.</summary>
    [JsonPropertyName("emailMessage")]
    public string? EmailMessage { get; set; }

    /// <summary>Subject line for email messages.</summary>
    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }

    /// <summary>Message template for SMS messages. Must contain {username} and {####} placeholders, for username and temporary password, respectively.</summary>
    [JsonPropertyName("smsMessage")]
    public string? SmsMessage { get; set; }
}

/// <summary>Configuration block for creating a new user profile. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderAdminCreateUserConfig
{
    /// <summary>Set to True if only the administrator is allowed to create user profiles. Set to False if users can sign themselves up via an app.</summary>
    [JsonPropertyName("allowAdminCreateUserOnly")]
    public bool? AllowAdminCreateUserOnly { get; set; }

    /// <summary>Invite message template structure. Detailed below.</summary>
    [JsonPropertyName("inviteMessageTemplate")]
    public V1beta2UserPoolSpecInitProviderAdminCreateUserConfigInviteMessageTemplate? InviteMessageTemplate { get; set; }
}

/// <summary>Configuration block for the user pool&apos;s device tracking. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderDeviceConfiguration
{
    /// <summary>Whether a challenge is required on a new device. Only applicable to a new device.</summary>
    [JsonPropertyName("challengeRequiredOnNewDevice")]
    public bool? ChallengeRequiredOnNewDevice { get; set; }

    /// <summary>Whether a device is only remembered on user prompt. false equates to &quot;Always&quot; remember, true is &quot;User Opt In,&quot; and not using a device_configuration block is &quot;No.&quot;</summary>
    [JsonPropertyName("deviceOnlyRememberedOnUserPrompt")]
    public bool? DeviceOnlyRememberedOnUserPrompt { get; set; }
}

/// <summary>Configuration block for configuring email. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderEmailConfiguration
{
    /// <summary>Email configuration set name from SES.</summary>
    [JsonPropertyName("configurationSet")]
    public string? ConfigurationSet { get; set; }

    /// <summary>Email delivery method to use. COGNITO_DEFAULT for the default email functionality built into Cognito or DEVELOPER to use your Amazon SES configuration. Required to be DEVELOPER if from_email_address is set.</summary>
    [JsonPropertyName("emailSendingAccount")]
    public string? EmailSendingAccount { get; set; }

    /// <summary>Sender’s email address or sender’s display name with their email address (e.g., john@example.com, John Smith &lt;john@example.com&gt; or \&quot;John Smith Ph.D.\&quot; &lt;john@example.com&gt;). Escaped double quotes are required around display names that contain certain characters as specified in RFC 5322.</summary>
    [JsonPropertyName("fromEmailAddress")]
    public string? FromEmailAddress { get; set; }

    /// <summary>REPLY-TO email address.</summary>
    [JsonPropertyName("replyToEmailAddress")]
    public string? ReplyToEmailAddress { get; set; }

    /// <summary>ARN of the SES verified email identity to use. Required if email_sending_account is set to DEVELOPER.</summary>
    [JsonPropertyName("sourceArn")]
    public string? SourceArn { get; set; }
}

/// <summary>Configuration block for configuring email Multi-Factor Authentication (MFA); requires at least 2 account_recovery_setting entries; requires an email_configuration configuration block. Effective only when mfa_configuration is ON or OPTIONAL. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderEmailMfaConfiguration
{
    /// <summary>The template for the email messages that your user pool sends to users with codes for MFA and sign-in with email OTPs. The message must contain the {####} placeholder. In the message, Amazon Cognito replaces this placeholder with the code. If you don&apos;t provide this parameter, Amazon Cognito sends messages in the default format.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The subject of the email messages that your user pool sends to users with codes for MFA and email OTP sign-in.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate createAuthChallenge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate createAuthChallenge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelector
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
    public V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelector
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
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelectorPolicy? Policy { get; set; }
}

/// <summary>A custom email sender AWS Lambda trigger. See custom_email_sender Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSender
{
    /// <summary>The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers to send email notifications to users.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSenderLambdaArnSelector? LambdaArnSelector { get; set; }

    /// <summary>The Lambda version represents the signature of the &quot;request&quot; attribute in the &quot;event&quot; information Amazon Cognito passes to your custom email Lambda function. The only supported value is V1_0.</summary>
    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate customMessage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate customMessage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageSelector
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
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelector
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
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelectorPolicy? Policy { get; set; }
}

/// <summary>A custom SMS sender AWS Lambda trigger. See custom_sms_sender Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSender
{
    /// <summary>The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers to send SMS notifications to users.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>Reference to a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnRef")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnRef? LambdaArnRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate lambdaArn.</summary>
    [JsonPropertyName("lambdaArnSelector")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSenderLambdaArnSelector? LambdaArnSelector { get; set; }

    /// <summary>The Lambda version represents the signature of the &quot;request&quot; attribute in the &quot;event&quot; information Amazon Cognito passes to your custom SMS Lambda function. The only supported value is V1_0.</summary>
    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate defineAuthChallenge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate defineAuthChallenge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelector
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
    public V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelector
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
    public V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate postAuthentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate postAuthentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelector
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
    public V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate postConfirmation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate postConfirmation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationSelector
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
    public V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate preAuthentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate preAuthentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelector
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
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate preSignUp.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate preSignUp.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpSelector
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
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpSelectorPolicy? Policy { get; set; }
}

/// <summary>Allow to customize access tokens. See pre_token_configuration_type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationConfig
{
    /// <summary>The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers to send SMS notifications to users.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>The Lambda version represents the signature of the &quot;version&quot; attribute in the &quot;event&quot; information Amazon Cognito passes to your pre Token Generation Lambda function. The supported values are V1_0, V2_0, V3_0.</summary>
    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate preTokenGeneration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate preTokenGeneration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelector
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
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate userMigration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate userMigration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationSelector
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
    public V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Function in lambda to populate verifyAuthChallengeResponse.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Function in lambda to populate verifyAuthChallengeResponse.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelector
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
    public V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for the AWS Lambda triggers associated with the user pool. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderLambdaConfig
{
    /// <summary>ARN of the lambda creating an authentication challenge.</summary>
    [JsonPropertyName("createAuthChallenge")]
    public string? CreateAuthChallenge { get; set; }

    /// <summary>Reference to a Function in lambda to populate createAuthChallenge.</summary>
    [JsonPropertyName("createAuthChallengeRef")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeRef? CreateAuthChallengeRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate createAuthChallenge.</summary>
    [JsonPropertyName("createAuthChallengeSelector")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCreateAuthChallengeSelector? CreateAuthChallengeSelector { get; set; }

    /// <summary>A custom email sender AWS Lambda trigger. See custom_email_sender Below.</summary>
    [JsonPropertyName("customEmailSender")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomEmailSender? CustomEmailSender { get; set; }

    /// <summary>Custom Message AWS Lambda trigger.</summary>
    [JsonPropertyName("customMessage")]
    public string? CustomMessage { get; set; }

    /// <summary>Reference to a Function in lambda to populate customMessage.</summary>
    [JsonPropertyName("customMessageRef")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageRef? CustomMessageRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate customMessage.</summary>
    [JsonPropertyName("customMessageSelector")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomMessageSelector? CustomMessageSelector { get; set; }

    /// <summary>A custom SMS sender AWS Lambda trigger. See custom_sms_sender Below.</summary>
    [JsonPropertyName("customSmsSender")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigCustomSmsSender? CustomSmsSender { get; set; }

    /// <summary>Defines the authentication challenge.</summary>
    [JsonPropertyName("defineAuthChallenge")]
    public string? DefineAuthChallenge { get; set; }

    /// <summary>Reference to a Function in lambda to populate defineAuthChallenge.</summary>
    [JsonPropertyName("defineAuthChallengeRef")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeRef? DefineAuthChallengeRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate defineAuthChallenge.</summary>
    [JsonPropertyName("defineAuthChallengeSelector")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigDefineAuthChallengeSelector? DefineAuthChallengeSelector { get; set; }

    /// <summary>The Amazon Resource Name of Key Management Service Customer master keys. Amazon Cognito uses the key to encrypt codes and temporary passwords sent to CustomEmailSender and CustomSMSSender.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Post-authentication AWS Lambda trigger.</summary>
    [JsonPropertyName("postAuthentication")]
    public string? PostAuthentication { get; set; }

    /// <summary>Reference to a Function in lambda to populate postAuthentication.</summary>
    [JsonPropertyName("postAuthenticationRef")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationRef? PostAuthenticationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate postAuthentication.</summary>
    [JsonPropertyName("postAuthenticationSelector")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPostAuthenticationSelector? PostAuthenticationSelector { get; set; }

    /// <summary>Post-confirmation AWS Lambda trigger.</summary>
    [JsonPropertyName("postConfirmation")]
    public string? PostConfirmation { get; set; }

    /// <summary>Reference to a Function in lambda to populate postConfirmation.</summary>
    [JsonPropertyName("postConfirmationRef")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationRef? PostConfirmationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate postConfirmation.</summary>
    [JsonPropertyName("postConfirmationSelector")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPostConfirmationSelector? PostConfirmationSelector { get; set; }

    /// <summary>Pre-authentication AWS Lambda trigger.</summary>
    [JsonPropertyName("preAuthentication")]
    public string? PreAuthentication { get; set; }

    /// <summary>Reference to a Function in lambda to populate preAuthentication.</summary>
    [JsonPropertyName("preAuthenticationRef")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationRef? PreAuthenticationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate preAuthentication.</summary>
    [JsonPropertyName("preAuthenticationSelector")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreAuthenticationSelector? PreAuthenticationSelector { get; set; }

    /// <summary>Pre-registration AWS Lambda trigger.</summary>
    [JsonPropertyName("preSignUp")]
    public string? PreSignUp { get; set; }

    /// <summary>Reference to a Function in lambda to populate preSignUp.</summary>
    [JsonPropertyName("preSignUpRef")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpRef? PreSignUpRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate preSignUp.</summary>
    [JsonPropertyName("preSignUpSelector")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreSignUpSelector? PreSignUpSelector { get; set; }

    /// <summary>Allow to customize identity token claims before token generation. Set this parameter for legacy purposes; for new instances of pre token generation triggers, set the lambda_arn of pre_token_generation_config.</summary>
    [JsonPropertyName("preTokenGeneration")]
    public string? PreTokenGeneration { get; set; }

    /// <summary>Allow to customize access tokens. See pre_token_configuration_type</summary>
    [JsonPropertyName("preTokenGenerationConfig")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationConfig? PreTokenGenerationConfig { get; set; }

    /// <summary>Reference to a Function in lambda to populate preTokenGeneration.</summary>
    [JsonPropertyName("preTokenGenerationRef")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationRef? PreTokenGenerationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate preTokenGeneration.</summary>
    [JsonPropertyName("preTokenGenerationSelector")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigPreTokenGenerationSelector? PreTokenGenerationSelector { get; set; }

    /// <summary>User migration Lambda config type.</summary>
    [JsonPropertyName("userMigration")]
    public string? UserMigration { get; set; }

    /// <summary>Reference to a Function in lambda to populate userMigration.</summary>
    [JsonPropertyName("userMigrationRef")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationRef? UserMigrationRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate userMigration.</summary>
    [JsonPropertyName("userMigrationSelector")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigUserMigrationSelector? UserMigrationSelector { get; set; }

    /// <summary>Verifies the authentication challenge response.</summary>
    [JsonPropertyName("verifyAuthChallengeResponse")]
    public string? VerifyAuthChallengeResponse { get; set; }

    /// <summary>Reference to a Function in lambda to populate verifyAuthChallengeResponse.</summary>
    [JsonPropertyName("verifyAuthChallengeResponseRef")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseRef? VerifyAuthChallengeResponseRef { get; set; }

    /// <summary>Selector for a Function in lambda to populate verifyAuthChallengeResponse.</summary>
    [JsonPropertyName("verifyAuthChallengeResponseSelector")]
    public V1beta2UserPoolSpecInitProviderLambdaConfigVerifyAuthChallengeResponseSelector? VerifyAuthChallengeResponseSelector { get; set; }
}

/// <summary>Configuration block for information about the user pool password policy. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderPasswordPolicy
{
    /// <summary>Minimum length of the password policy that you have set.</summary>
    [JsonPropertyName("minimumLength")]
    public double? MinimumLength { get; set; }

    /// <summary>Number of previous passwords that you want Amazon Cognito to restrict each user from reusing. Users can&apos;t set a password that matches any of number of previous passwords specified by this argument. A value of 0 means that password history is not enforced. Valid values are between 0 and 24.</summary>
    [JsonPropertyName("passwordHistorySize")]
    public double? PasswordHistorySize { get; set; }

    /// <summary>Whether you have required users to use at least one lowercase letter in their password.</summary>
    [JsonPropertyName("requireLowercase")]
    public bool? RequireLowercase { get; set; }

    /// <summary>Whether you have required users to use at least one number in their password.</summary>
    [JsonPropertyName("requireNumbers")]
    public bool? RequireNumbers { get; set; }

    /// <summary>Whether you have required users to use at least one symbol in their password.</summary>
    [JsonPropertyName("requireSymbols")]
    public bool? RequireSymbols { get; set; }

    /// <summary>Whether you have required users to use at least one uppercase letter in their password.</summary>
    [JsonPropertyName("requireUppercase")]
    public bool? RequireUppercase { get; set; }

    /// <summary>In the password policy you have set, refers to the number of days a temporary password is valid. If the user does not sign-in during this time, their password will need to be reset by an administrator.</summary>
    [JsonPropertyName("temporaryPasswordValidityDays")]
    public double? TemporaryPasswordValidityDays { get; set; }
}

/// <summary>Configuration block for the constraints for an attribute of the number type. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderSchemaNumberAttributeConstraints
{
    /// <summary>Maximum value of an attribute that is of the number data type.</summary>
    [JsonPropertyName("maxValue")]
    public string? MaxValue { get; set; }

    /// <summary>Minimum value of an attribute that is of the number data type.</summary>
    [JsonPropertyName("minValue")]
    public string? MinValue { get; set; }
}

/// <summary>Constraints for an attribute of the string type. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderSchemaStringAttributeConstraints
{
    /// <summary>Maximum length of an attribute value of the string type.</summary>
    [JsonPropertyName("maxLength")]
    public string? MaxLength { get; set; }

    /// <summary>Minimum length of an attribute value of the string type.</summary>
    [JsonPropertyName("minLength")]
    public string? MinLength { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderSchema
{
    /// <summary>Attribute data type. Must be one of Boolean, Number, String, DateTime.</summary>
    [JsonPropertyName("attributeDataType")]
    public string? AttributeDataType { get; set; }

    /// <summary>Whether the attribute type is developer only.</summary>
    [JsonPropertyName("developerOnlyAttribute")]
    public bool? DeveloperOnlyAttribute { get; set; }

    /// <summary>Whether the attribute can be changed once it has been created.</summary>
    [JsonPropertyName("mutable")]
    public bool? Mutable { get; set; }

    /// <summary>Name of the user pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block for the constraints for an attribute of the number type. Detailed below.</summary>
    [JsonPropertyName("numberAttributeConstraints")]
    public V1beta2UserPoolSpecInitProviderSchemaNumberAttributeConstraints? NumberAttributeConstraints { get; set; }

    /// <summary>Whether a user pool attribute is required. If the attribute is required and the user does not provide a value, registration or sign-in will fail.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Constraints for an attribute of the string type. Detailed below.</summary>
    [JsonPropertyName("stringAttributeConstraints")]
    public V1beta2UserPoolSpecInitProviderSchemaStringAttributeConstraints? StringAttributeConstraints { get; set; }
}

/// <summary>Configuration block for information about the user pool sign in policy. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderSignInPolicy
{
    /// <summary>The sign in methods your user pool supports as the first factor. This is a list of strings, allowed values are PASSWORD, EMAIL_OTP, SMS_OTP, and WEB_AUTHN.</summary>
    [JsonPropertyName("allowedFirstAuthFactors")]
    public IList<string>? AllowedFirstAuthFactors { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate snsCallerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelectorPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelectorPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate snsCallerArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelector
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
    public V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for Short Message Service (SMS) settings. Detailed below. These settings apply to SMS user verification and SMS Multi-Factor Authentication (MFA). SMS MFA is activated only when mfa_configuration is set to ON or OPTIONAL along with this block. Due to Cognito API restrictions, the SMS configuration cannot be removed without recreating the Cognito User Pool. For user data safety, this resource will ignore the removal of this configuration by disabling drift detection. To force resource recreation after this configuration has been applied, see the taint command.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderSmsConfiguration
{
    /// <summary>External ID used in IAM role trust relationships. For more information about using external IDs, see How to Use an External ID When Granting Access to Your AWS Resources to a Third Party.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>ARN of the Amazon SNS caller. This is usually the IAM role that you&apos;ve given Cognito permission to assume.</summary>
    [JsonPropertyName("snsCallerArn")]
    public string? SnsCallerArn { get; set; }

    /// <summary>Reference to a Role in iam to populate snsCallerArn.</summary>
    [JsonPropertyName("snsCallerArnRef")]
    public V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnRef? SnsCallerArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate snsCallerArn.</summary>
    [JsonPropertyName("snsCallerArnSelector")]
    public V1beta2UserPoolSpecInitProviderSmsConfigurationSnsCallerArnSelector? SnsCallerArnSelector { get; set; }

    /// <summary>The AWS Region to use with Amazon SNS integration. You can choose the same Region as your user pool, or a supported Legacy Amazon SNS alternate Region. Amazon Cognito resources in the Asia Pacific (Seoul) AWS Region must use your Amazon SNS configuration in the Asia Pacific (Tokyo) Region. For more information, see SMS message settings for Amazon Cognito user pools.</summary>
    [JsonPropertyName("snsRegion")]
    public string? SnsRegion { get; set; }
}

/// <summary>Configuration block for software token Mult-Factor Authentication (MFA) settings. Effective only when mfa_configuration is ON or OPTIONAL. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderSoftwareTokenMfaConfiguration
{
    /// <summary>Boolean whether to enable software token Multi-Factor (MFA) tokens, such as Time-based One-Time Password (TOTP). To disable software token MFA When sms_configuration is not present, the mfa_configuration argument must be set to OFF and the software_token_mfa_configuration configuration block must be fully removed.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration block for user attribute update settings. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderUserAttributeUpdateSettings
{
    /// <summary>A list of attributes requiring verification before update. If set, the provided value(s) must also be set in auto_verified_attributes. Valid values: email, phone_number.</summary>
    [JsonPropertyName("attributesRequireVerificationBeforeUpdate")]
    public IList<string>? AttributesRequireVerificationBeforeUpdate { get; set; }
}

/// <summary>A block to specify the threat protection configuration options for additional authentication types in your user pool, including custom authentication. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderUserPoolAddOnsAdvancedSecurityAdditionalFlows
{
    /// <summary>Mode of threat protection operation in custom authentication. Valid values are AUDIT or ENFORCED. The default value is AUDIT.</summary>
    [JsonPropertyName("customAuthMode")]
    public string? CustomAuthMode { get; set; }
}

/// <summary>Configuration block for user pool add-ons to enable user pool advanced security mode features. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderUserPoolAddOns
{
    /// <summary>A block to specify the threat protection configuration options for additional authentication types in your user pool, including custom authentication. Detailed below.</summary>
    [JsonPropertyName("advancedSecurityAdditionalFlows")]
    public V1beta2UserPoolSpecInitProviderUserPoolAddOnsAdvancedSecurityAdditionalFlows? AdvancedSecurityAdditionalFlows { get; set; }

    /// <summary>Mode for advanced security, must be one of OFF, AUDIT or ENFORCED.</summary>
    [JsonPropertyName("advancedSecurityMode")]
    public string? AdvancedSecurityMode { get; set; }
}

/// <summary>Configuration block for username configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderUsernameConfiguration
{
    /// <summary>Whether username case sensitivity will be applied for all users in the user pool through Cognito APIs.</summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }
}

/// <summary>Configuration block for verification message templates. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderVerificationMessageTemplate
{
    /// <summary>Default email option. Must be either CONFIRM_WITH_CODE or CONFIRM_WITH_LINK. Defaults to CONFIRM_WITH_CODE.</summary>
    [JsonPropertyName("defaultEmailOption")]
    public string? DefaultEmailOption { get; set; }

    /// <summary>Email message template. Must contain the {####} placeholder. Conflicts with email_verification_message argument.</summary>
    [JsonPropertyName("emailMessage")]
    public string? EmailMessage { get; set; }

    /// <summary>Email message template for sending a confirmation link to the user, it must contain the {##Click Here##} placeholder.</summary>
    [JsonPropertyName("emailMessageByLink")]
    public string? EmailMessageByLink { get; set; }

    /// <summary>Subject line for the email message template. Conflicts with email_verification_subject argument.</summary>
    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }

    /// <summary>Subject line for the email message template for sending a confirmation link to the user.</summary>
    [JsonPropertyName("emailSubjectByLink")]
    public string? EmailSubjectByLink { get; set; }

    /// <summary>SMS message template. Must contain the {####} placeholder. Conflicts with sms_verification_message argument.</summary>
    [JsonPropertyName("smsMessage")]
    public string? SmsMessage { get; set; }
}

/// <summary>Configuration block for web authn configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecInitProviderWebAuthnConfiguration
{
    /// <summary>The authentication domain that passkeys providers use as a relying party.</summary>
    [JsonPropertyName("relyingPartyId")]
    public string? RelyingPartyId { get; set; }

    /// <summary>If your user pool should require a passkey. Must be one of required or preferred.</summary>
    [JsonPropertyName("userVerification")]
    public string? UserVerification { get; set; }
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
public partial class V1beta2UserPoolSpecInitProvider
{
    /// <summary>Configuration block to define which verified available method a user can use to recover their forgotten password. Detailed below.</summary>
    [JsonPropertyName("accountRecoverySetting")]
    public V1beta2UserPoolSpecInitProviderAccountRecoverySetting? AccountRecoverySetting { get; set; }

    /// <summary>Configuration block for creating a new user profile. Detailed below.</summary>
    [JsonPropertyName("adminCreateUserConfig")]
    public V1beta2UserPoolSpecInitProviderAdminCreateUserConfig? AdminCreateUserConfig { get; set; }

    /// <summary>Attributes supported as an alias for this user pool. Valid values: phone_number, email, or preferred_username. Conflicts with username_attributes.</summary>
    [JsonPropertyName("aliasAttributes")]
    public IList<string>? AliasAttributes { get; set; }

    /// <summary>Attributes to be auto-verified. Valid values: email, phone_number.</summary>
    [JsonPropertyName("autoVerifiedAttributes")]
    public IList<string>? AutoVerifiedAttributes { get; set; }

    /// <summary>When active, DeletionProtection prevents accidental deletion of your user pool. Before you can delete a user pool that you have protected against deletion, you must deactivate this feature. Valid values are ACTIVE and INACTIVE, Default value is INACTIVE.</summary>
    [JsonPropertyName("deletionProtection")]
    public string? DeletionProtection { get; set; }

    /// <summary>Configuration block for the user pool&apos;s device tracking. Detailed below.</summary>
    [JsonPropertyName("deviceConfiguration")]
    public V1beta2UserPoolSpecInitProviderDeviceConfiguration? DeviceConfiguration { get; set; }

    /// <summary>Configuration block for configuring email. Detailed below.</summary>
    [JsonPropertyName("emailConfiguration")]
    public V1beta2UserPoolSpecInitProviderEmailConfiguration? EmailConfiguration { get; set; }

    /// <summary>Configuration block for configuring email Multi-Factor Authentication (MFA); requires at least 2 account_recovery_setting entries; requires an email_configuration configuration block. Effective only when mfa_configuration is ON or OPTIONAL. Detailed below.</summary>
    [JsonPropertyName("emailMfaConfiguration")]
    public V1beta2UserPoolSpecInitProviderEmailMfaConfiguration? EmailMfaConfiguration { get; set; }

    /// <summary>String representing the email verification message. Conflicts with verification_message_template configuration block email_message argument.</summary>
    [JsonPropertyName("emailVerificationMessage")]
    public string? EmailVerificationMessage { get; set; }

    /// <summary>String representing the email verification subject. Conflicts with verification_message_template configuration block email_subject argument.</summary>
    [JsonPropertyName("emailVerificationSubject")]
    public string? EmailVerificationSubject { get; set; }

    /// <summary>Configuration block for the AWS Lambda triggers associated with the user pool. Detailed below.</summary>
    [JsonPropertyName("lambdaConfig")]
    public V1beta2UserPoolSpecInitProviderLambdaConfig? LambdaConfig { get; set; }

    /// <summary>Multi-Factor Authentication (MFA) configuration for the User Pool. Defaults of OFF. Valid values are OFF (MFA Tokens are not required), ON (MFA is required for all users to sign in; requires at least one of email_mfa_configuration, sms_configuration or software_token_mfa_configuration to be configured), or OPTIONAL (MFA Will be required only for individual users who have MFA Enabled; requires at least one of email_mfa_configuration, sms_configuration or software_token_mfa_configuration to be configured).</summary>
    [JsonPropertyName("mfaConfiguration")]
    public string? MfaConfiguration { get; set; }

    /// <summary>Name of the user pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block for information about the user pool password policy. Detailed below.</summary>
    [JsonPropertyName("passwordPolicy")]
    public V1beta2UserPoolSpecInitProviderPasswordPolicy? PasswordPolicy { get; set; }

    /// <summary>Configuration block for the schema attributes of a user pool. Detailed below. Schema attributes from the standard attribute set only need to be specified if they are different from the default configuration. Attributes can be added, but not modified or removed. Maximum of 50 attributes.</summary>
    [JsonPropertyName("schema")]
    public IList<V1beta2UserPoolSpecInitProviderSchema>? Schema { get; set; }

    /// <summary>Configuration block for information about the user pool sign in policy. Detailed below.</summary>
    [JsonPropertyName("signInPolicy")]
    public V1beta2UserPoolSpecInitProviderSignInPolicy? SignInPolicy { get; set; }

    /// <summary>String representing the SMS authentication message. The Message must contain the {####} placeholder, which will be replaced with the code.</summary>
    [JsonPropertyName("smsAuthenticationMessage")]
    public string? SmsAuthenticationMessage { get; set; }

    /// <summary>Configuration block for Short Message Service (SMS) settings. Detailed below. These settings apply to SMS user verification and SMS Multi-Factor Authentication (MFA). SMS MFA is activated only when mfa_configuration is set to ON or OPTIONAL along with this block. Due to Cognito API restrictions, the SMS configuration cannot be removed without recreating the Cognito User Pool. For user data safety, this resource will ignore the removal of this configuration by disabling drift detection. To force resource recreation after this configuration has been applied, see the taint command.</summary>
    [JsonPropertyName("smsConfiguration")]
    public V1beta2UserPoolSpecInitProviderSmsConfiguration? SmsConfiguration { get; set; }

    /// <summary>String representing the SMS verification message. Conflicts with verification_message_template configuration block sms_message argument.</summary>
    [JsonPropertyName("smsVerificationMessage")]
    public string? SmsVerificationMessage { get; set; }

    /// <summary>Configuration block for software token Mult-Factor Authentication (MFA) settings. Effective only when mfa_configuration is ON or OPTIONAL. Detailed below.</summary>
    [JsonPropertyName("softwareTokenMfaConfiguration")]
    public V1beta2UserPoolSpecInitProviderSoftwareTokenMfaConfiguration? SoftwareTokenMfaConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for user attribute update settings. Detailed below.</summary>
    [JsonPropertyName("userAttributeUpdateSettings")]
    public V1beta2UserPoolSpecInitProviderUserAttributeUpdateSettings? UserAttributeUpdateSettings { get; set; }

    /// <summary>Configuration block for user pool add-ons to enable user pool advanced security mode features. Detailed below.</summary>
    [JsonPropertyName("userPoolAddOns")]
    public V1beta2UserPoolSpecInitProviderUserPoolAddOns? UserPoolAddOns { get; set; }

    /// <summary>The user pool feature plan, or tier. Valid values: LITE, ESSENTIALS, PLUS.</summary>
    [JsonPropertyName("userPoolTier")]
    public string? UserPoolTier { get; set; }

    /// <summary>Whether email addresses or phone numbers can be specified as usernames when a user signs up. Conflicts with alias_attributes.</summary>
    [JsonPropertyName("usernameAttributes")]
    public IList<string>? UsernameAttributes { get; set; }

    /// <summary>Configuration block for username configuration. Detailed below.</summary>
    [JsonPropertyName("usernameConfiguration")]
    public V1beta2UserPoolSpecInitProviderUsernameConfiguration? UsernameConfiguration { get; set; }

    /// <summary>Configuration block for verification message templates. Detailed below.</summary>
    [JsonPropertyName("verificationMessageTemplate")]
    public V1beta2UserPoolSpecInitProviderVerificationMessageTemplate? VerificationMessageTemplate { get; set; }

    /// <summary>Configuration block for web authn configuration. Detailed below.</summary>
    [JsonPropertyName("webAuthnConfiguration")]
    public V1beta2UserPoolSpecInitProviderWebAuthnConfiguration? WebAuthnConfiguration { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecManagementPoliciesEnum>))]
public enum V1beta2UserPoolSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2UserPoolSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2UserPoolSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2UserPoolSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2UserPoolSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2UserPoolSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2UserPoolSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>UserPoolSpec defines the desired state of UserPool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolSpec
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
    public V1beta2UserPoolSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2UserPoolSpecForProvider ForProvider { get; set; }

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
    public V1beta2UserPoolSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2UserPoolSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2UserPoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2UserPoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderAccountRecoverySettingRecoveryMechanism
{
    /// <summary>Name of the user pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Positive integer specifying priority of a method with 1 being the highest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

/// <summary>Configuration block to define which verified available method a user can use to recover their forgotten password. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderAccountRecoverySetting
{
    /// <summary>List of Account Recovery Options of the following structure:</summary>
    [JsonPropertyName("recoveryMechanism")]
    public IList<V1beta2UserPoolStatusAtProviderAccountRecoverySettingRecoveryMechanism>? RecoveryMechanism { get; set; }
}

/// <summary>Invite message template structure. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderAdminCreateUserConfigInviteMessageTemplate
{
    /// <summary>Message template for email messages. Must contain {username} and {####} placeholders, for username and temporary password, respectively.</summary>
    [JsonPropertyName("emailMessage")]
    public string? EmailMessage { get; set; }

    /// <summary>Subject line for email messages.</summary>
    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }

    /// <summary>Message template for SMS messages. Must contain {username} and {####} placeholders, for username and temporary password, respectively.</summary>
    [JsonPropertyName("smsMessage")]
    public string? SmsMessage { get; set; }
}

/// <summary>Configuration block for creating a new user profile. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderAdminCreateUserConfig
{
    /// <summary>Set to True if only the administrator is allowed to create user profiles. Set to False if users can sign themselves up via an app.</summary>
    [JsonPropertyName("allowAdminCreateUserOnly")]
    public bool? AllowAdminCreateUserOnly { get; set; }

    /// <summary>Invite message template structure. Detailed below.</summary>
    [JsonPropertyName("inviteMessageTemplate")]
    public V1beta2UserPoolStatusAtProviderAdminCreateUserConfigInviteMessageTemplate? InviteMessageTemplate { get; set; }
}

/// <summary>Configuration block for the user pool&apos;s device tracking. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderDeviceConfiguration
{
    /// <summary>Whether a challenge is required on a new device. Only applicable to a new device.</summary>
    [JsonPropertyName("challengeRequiredOnNewDevice")]
    public bool? ChallengeRequiredOnNewDevice { get; set; }

    /// <summary>Whether a device is only remembered on user prompt. false equates to &quot;Always&quot; remember, true is &quot;User Opt In,&quot; and not using a device_configuration block is &quot;No.&quot;</summary>
    [JsonPropertyName("deviceOnlyRememberedOnUserPrompt")]
    public bool? DeviceOnlyRememberedOnUserPrompt { get; set; }
}

/// <summary>Configuration block for configuring email. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderEmailConfiguration
{
    /// <summary>Email configuration set name from SES.</summary>
    [JsonPropertyName("configurationSet")]
    public string? ConfigurationSet { get; set; }

    /// <summary>Email delivery method to use. COGNITO_DEFAULT for the default email functionality built into Cognito or DEVELOPER to use your Amazon SES configuration. Required to be DEVELOPER if from_email_address is set.</summary>
    [JsonPropertyName("emailSendingAccount")]
    public string? EmailSendingAccount { get; set; }

    /// <summary>Sender’s email address or sender’s display name with their email address (e.g., john@example.com, John Smith &lt;john@example.com&gt; or \&quot;John Smith Ph.D.\&quot; &lt;john@example.com&gt;). Escaped double quotes are required around display names that contain certain characters as specified in RFC 5322.</summary>
    [JsonPropertyName("fromEmailAddress")]
    public string? FromEmailAddress { get; set; }

    /// <summary>REPLY-TO email address.</summary>
    [JsonPropertyName("replyToEmailAddress")]
    public string? ReplyToEmailAddress { get; set; }

    /// <summary>ARN of the SES verified email identity to use. Required if email_sending_account is set to DEVELOPER.</summary>
    [JsonPropertyName("sourceArn")]
    public string? SourceArn { get; set; }
}

/// <summary>Configuration block for configuring email Multi-Factor Authentication (MFA); requires at least 2 account_recovery_setting entries; requires an email_configuration configuration block. Effective only when mfa_configuration is ON or OPTIONAL. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderEmailMfaConfiguration
{
    /// <summary>The template for the email messages that your user pool sends to users with codes for MFA and sign-in with email OTPs. The message must contain the {####} placeholder. In the message, Amazon Cognito replaces this placeholder with the code. If you don&apos;t provide this parameter, Amazon Cognito sends messages in the default format.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The subject of the email messages that your user pool sends to users with codes for MFA and email OTP sign-in.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

/// <summary>A custom email sender AWS Lambda trigger. See custom_email_sender Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderLambdaConfigCustomEmailSender
{
    /// <summary>The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers to send email notifications to users.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>The Lambda version represents the signature of the &quot;request&quot; attribute in the &quot;event&quot; information Amazon Cognito passes to your custom email Lambda function. The only supported value is V1_0.</summary>
    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

/// <summary>A custom SMS sender AWS Lambda trigger. See custom_sms_sender Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderLambdaConfigCustomSmsSender
{
    /// <summary>The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers to send SMS notifications to users.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>The Lambda version represents the signature of the &quot;request&quot; attribute in the &quot;event&quot; information Amazon Cognito passes to your custom SMS Lambda function. The only supported value is V1_0.</summary>
    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

/// <summary>Allow to customize access tokens. See pre_token_configuration_type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderLambdaConfigPreTokenGenerationConfig
{
    /// <summary>The Lambda Amazon Resource Name of the Lambda function that Amazon Cognito triggers to send SMS notifications to users.</summary>
    [JsonPropertyName("lambdaArn")]
    public string? LambdaArn { get; set; }

    /// <summary>The Lambda version represents the signature of the &quot;version&quot; attribute in the &quot;event&quot; information Amazon Cognito passes to your pre Token Generation Lambda function. The supported values are V1_0, V2_0, V3_0.</summary>
    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

/// <summary>Configuration block for the AWS Lambda triggers associated with the user pool. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderLambdaConfig
{
    /// <summary>ARN of the lambda creating an authentication challenge.</summary>
    [JsonPropertyName("createAuthChallenge")]
    public string? CreateAuthChallenge { get; set; }

    /// <summary>A custom email sender AWS Lambda trigger. See custom_email_sender Below.</summary>
    [JsonPropertyName("customEmailSender")]
    public V1beta2UserPoolStatusAtProviderLambdaConfigCustomEmailSender? CustomEmailSender { get; set; }

    /// <summary>Custom Message AWS Lambda trigger.</summary>
    [JsonPropertyName("customMessage")]
    public string? CustomMessage { get; set; }

    /// <summary>A custom SMS sender AWS Lambda trigger. See custom_sms_sender Below.</summary>
    [JsonPropertyName("customSmsSender")]
    public V1beta2UserPoolStatusAtProviderLambdaConfigCustomSmsSender? CustomSmsSender { get; set; }

    /// <summary>Defines the authentication challenge.</summary>
    [JsonPropertyName("defineAuthChallenge")]
    public string? DefineAuthChallenge { get; set; }

    /// <summary>The Amazon Resource Name of Key Management Service Customer master keys. Amazon Cognito uses the key to encrypt codes and temporary passwords sent to CustomEmailSender and CustomSMSSender.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Post-authentication AWS Lambda trigger.</summary>
    [JsonPropertyName("postAuthentication")]
    public string? PostAuthentication { get; set; }

    /// <summary>Post-confirmation AWS Lambda trigger.</summary>
    [JsonPropertyName("postConfirmation")]
    public string? PostConfirmation { get; set; }

    /// <summary>Pre-authentication AWS Lambda trigger.</summary>
    [JsonPropertyName("preAuthentication")]
    public string? PreAuthentication { get; set; }

    /// <summary>Pre-registration AWS Lambda trigger.</summary>
    [JsonPropertyName("preSignUp")]
    public string? PreSignUp { get; set; }

    /// <summary>Allow to customize identity token claims before token generation. Set this parameter for legacy purposes; for new instances of pre token generation triggers, set the lambda_arn of pre_token_generation_config.</summary>
    [JsonPropertyName("preTokenGeneration")]
    public string? PreTokenGeneration { get; set; }

    /// <summary>Allow to customize access tokens. See pre_token_configuration_type</summary>
    [JsonPropertyName("preTokenGenerationConfig")]
    public V1beta2UserPoolStatusAtProviderLambdaConfigPreTokenGenerationConfig? PreTokenGenerationConfig { get; set; }

    /// <summary>User migration Lambda config type.</summary>
    [JsonPropertyName("userMigration")]
    public string? UserMigration { get; set; }

    /// <summary>Verifies the authentication challenge response.</summary>
    [JsonPropertyName("verifyAuthChallengeResponse")]
    public string? VerifyAuthChallengeResponse { get; set; }
}

/// <summary>Configuration block for information about the user pool password policy. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderPasswordPolicy
{
    /// <summary>Minimum length of the password policy that you have set.</summary>
    [JsonPropertyName("minimumLength")]
    public double? MinimumLength { get; set; }

    /// <summary>Number of previous passwords that you want Amazon Cognito to restrict each user from reusing. Users can&apos;t set a password that matches any of number of previous passwords specified by this argument. A value of 0 means that password history is not enforced. Valid values are between 0 and 24.</summary>
    [JsonPropertyName("passwordHistorySize")]
    public double? PasswordHistorySize { get; set; }

    /// <summary>Whether you have required users to use at least one lowercase letter in their password.</summary>
    [JsonPropertyName("requireLowercase")]
    public bool? RequireLowercase { get; set; }

    /// <summary>Whether you have required users to use at least one number in their password.</summary>
    [JsonPropertyName("requireNumbers")]
    public bool? RequireNumbers { get; set; }

    /// <summary>Whether you have required users to use at least one symbol in their password.</summary>
    [JsonPropertyName("requireSymbols")]
    public bool? RequireSymbols { get; set; }

    /// <summary>Whether you have required users to use at least one uppercase letter in their password.</summary>
    [JsonPropertyName("requireUppercase")]
    public bool? RequireUppercase { get; set; }

    /// <summary>In the password policy you have set, refers to the number of days a temporary password is valid. If the user does not sign-in during this time, their password will need to be reset by an administrator.</summary>
    [JsonPropertyName("temporaryPasswordValidityDays")]
    public double? TemporaryPasswordValidityDays { get; set; }
}

/// <summary>Configuration block for the constraints for an attribute of the number type. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderSchemaNumberAttributeConstraints
{
    /// <summary>Maximum value of an attribute that is of the number data type.</summary>
    [JsonPropertyName("maxValue")]
    public string? MaxValue { get; set; }

    /// <summary>Minimum value of an attribute that is of the number data type.</summary>
    [JsonPropertyName("minValue")]
    public string? MinValue { get; set; }
}

/// <summary>Constraints for an attribute of the string type. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderSchemaStringAttributeConstraints
{
    /// <summary>Maximum length of an attribute value of the string type.</summary>
    [JsonPropertyName("maxLength")]
    public string? MaxLength { get; set; }

    /// <summary>Minimum length of an attribute value of the string type.</summary>
    [JsonPropertyName("minLength")]
    public string? MinLength { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderSchema
{
    /// <summary>Attribute data type. Must be one of Boolean, Number, String, DateTime.</summary>
    [JsonPropertyName("attributeDataType")]
    public string? AttributeDataType { get; set; }

    /// <summary>Whether the attribute type is developer only.</summary>
    [JsonPropertyName("developerOnlyAttribute")]
    public bool? DeveloperOnlyAttribute { get; set; }

    /// <summary>Whether the attribute can be changed once it has been created.</summary>
    [JsonPropertyName("mutable")]
    public bool? Mutable { get; set; }

    /// <summary>Name of the user pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block for the constraints for an attribute of the number type. Detailed below.</summary>
    [JsonPropertyName("numberAttributeConstraints")]
    public V1beta2UserPoolStatusAtProviderSchemaNumberAttributeConstraints? NumberAttributeConstraints { get; set; }

    /// <summary>Whether a user pool attribute is required. If the attribute is required and the user does not provide a value, registration or sign-in will fail.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>Constraints for an attribute of the string type. Detailed below.</summary>
    [JsonPropertyName("stringAttributeConstraints")]
    public V1beta2UserPoolStatusAtProviderSchemaStringAttributeConstraints? StringAttributeConstraints { get; set; }
}

/// <summary>Configuration block for information about the user pool sign in policy. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderSignInPolicy
{
    /// <summary>The sign in methods your user pool supports as the first factor. This is a list of strings, allowed values are PASSWORD, EMAIL_OTP, SMS_OTP, and WEB_AUTHN.</summary>
    [JsonPropertyName("allowedFirstAuthFactors")]
    public IList<string>? AllowedFirstAuthFactors { get; set; }
}

/// <summary>Configuration block for Short Message Service (SMS) settings. Detailed below. These settings apply to SMS user verification and SMS Multi-Factor Authentication (MFA). SMS MFA is activated only when mfa_configuration is set to ON or OPTIONAL along with this block. Due to Cognito API restrictions, the SMS configuration cannot be removed without recreating the Cognito User Pool. For user data safety, this resource will ignore the removal of this configuration by disabling drift detection. To force resource recreation after this configuration has been applied, see the taint command.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderSmsConfiguration
{
    /// <summary>External ID used in IAM role trust relationships. For more information about using external IDs, see How to Use an External ID When Granting Access to Your AWS Resources to a Third Party.</summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>ARN of the Amazon SNS caller. This is usually the IAM role that you&apos;ve given Cognito permission to assume.</summary>
    [JsonPropertyName("snsCallerArn")]
    public string? SnsCallerArn { get; set; }

    /// <summary>The AWS Region to use with Amazon SNS integration. You can choose the same Region as your user pool, or a supported Legacy Amazon SNS alternate Region. Amazon Cognito resources in the Asia Pacific (Seoul) AWS Region must use your Amazon SNS configuration in the Asia Pacific (Tokyo) Region. For more information, see SMS message settings for Amazon Cognito user pools.</summary>
    [JsonPropertyName("snsRegion")]
    public string? SnsRegion { get; set; }
}

/// <summary>Configuration block for software token Mult-Factor Authentication (MFA) settings. Effective only when mfa_configuration is ON or OPTIONAL. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderSoftwareTokenMfaConfiguration
{
    /// <summary>Boolean whether to enable software token Multi-Factor (MFA) tokens, such as Time-based One-Time Password (TOTP). To disable software token MFA When sms_configuration is not present, the mfa_configuration argument must be set to OFF and the software_token_mfa_configuration configuration block must be fully removed.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration block for user attribute update settings. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderUserAttributeUpdateSettings
{
    /// <summary>A list of attributes requiring verification before update. If set, the provided value(s) must also be set in auto_verified_attributes. Valid values: email, phone_number.</summary>
    [JsonPropertyName("attributesRequireVerificationBeforeUpdate")]
    public IList<string>? AttributesRequireVerificationBeforeUpdate { get; set; }
}

/// <summary>A block to specify the threat protection configuration options for additional authentication types in your user pool, including custom authentication. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderUserPoolAddOnsAdvancedSecurityAdditionalFlows
{
    /// <summary>Mode of threat protection operation in custom authentication. Valid values are AUDIT or ENFORCED. The default value is AUDIT.</summary>
    [JsonPropertyName("customAuthMode")]
    public string? CustomAuthMode { get; set; }
}

/// <summary>Configuration block for user pool add-ons to enable user pool advanced security mode features. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderUserPoolAddOns
{
    /// <summary>A block to specify the threat protection configuration options for additional authentication types in your user pool, including custom authentication. Detailed below.</summary>
    [JsonPropertyName("advancedSecurityAdditionalFlows")]
    public V1beta2UserPoolStatusAtProviderUserPoolAddOnsAdvancedSecurityAdditionalFlows? AdvancedSecurityAdditionalFlows { get; set; }

    /// <summary>Mode for advanced security, must be one of OFF, AUDIT or ENFORCED.</summary>
    [JsonPropertyName("advancedSecurityMode")]
    public string? AdvancedSecurityMode { get; set; }
}

/// <summary>Configuration block for username configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderUsernameConfiguration
{
    /// <summary>Whether username case sensitivity will be applied for all users in the user pool through Cognito APIs.</summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }
}

/// <summary>Configuration block for verification message templates. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderVerificationMessageTemplate
{
    /// <summary>Default email option. Must be either CONFIRM_WITH_CODE or CONFIRM_WITH_LINK. Defaults to CONFIRM_WITH_CODE.</summary>
    [JsonPropertyName("defaultEmailOption")]
    public string? DefaultEmailOption { get; set; }

    /// <summary>Email message template. Must contain the {####} placeholder. Conflicts with email_verification_message argument.</summary>
    [JsonPropertyName("emailMessage")]
    public string? EmailMessage { get; set; }

    /// <summary>Email message template for sending a confirmation link to the user, it must contain the {##Click Here##} placeholder.</summary>
    [JsonPropertyName("emailMessageByLink")]
    public string? EmailMessageByLink { get; set; }

    /// <summary>Subject line for the email message template. Conflicts with email_verification_subject argument.</summary>
    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }

    /// <summary>Subject line for the email message template for sending a confirmation link to the user.</summary>
    [JsonPropertyName("emailSubjectByLink")]
    public string? EmailSubjectByLink { get; set; }

    /// <summary>SMS message template. Must contain the {####} placeholder. Conflicts with sms_verification_message argument.</summary>
    [JsonPropertyName("smsMessage")]
    public string? SmsMessage { get; set; }
}

/// <summary>Configuration block for web authn configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProviderWebAuthnConfiguration
{
    /// <summary>The authentication domain that passkeys providers use as a relying party.</summary>
    [JsonPropertyName("relyingPartyId")]
    public string? RelyingPartyId { get; set; }

    /// <summary>If your user pool should require a passkey. Must be one of required or preferred.</summary>
    [JsonPropertyName("userVerification")]
    public string? UserVerification { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusAtProvider
{
    /// <summary>Configuration block to define which verified available method a user can use to recover their forgotten password. Detailed below.</summary>
    [JsonPropertyName("accountRecoverySetting")]
    public V1beta2UserPoolStatusAtProviderAccountRecoverySetting? AccountRecoverySetting { get; set; }

    /// <summary>Configuration block for creating a new user profile. Detailed below.</summary>
    [JsonPropertyName("adminCreateUserConfig")]
    public V1beta2UserPoolStatusAtProviderAdminCreateUserConfig? AdminCreateUserConfig { get; set; }

    /// <summary>Attributes supported as an alias for this user pool. Valid values: phone_number, email, or preferred_username. Conflicts with username_attributes.</summary>
    [JsonPropertyName("aliasAttributes")]
    public IList<string>? AliasAttributes { get; set; }

    /// <summary>ARN of the user pool.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Attributes to be auto-verified. Valid values: email, phone_number.</summary>
    [JsonPropertyName("autoVerifiedAttributes")]
    public IList<string>? AutoVerifiedAttributes { get; set; }

    /// <summary>Date the user pool was created.</summary>
    [JsonPropertyName("creationDate")]
    public string? CreationDate { get; set; }

    /// <summary>A custom domain name that you provide to Amazon Cognito. This parameter applies only if you use a custom domain to host the sign-up and sign-in pages for your application. For example: auth.example.com.</summary>
    [JsonPropertyName("customDomain")]
    public string? CustomDomain { get; set; }

    /// <summary>When active, DeletionProtection prevents accidental deletion of your user pool. Before you can delete a user pool that you have protected against deletion, you must deactivate this feature. Valid values are ACTIVE and INACTIVE, Default value is INACTIVE.</summary>
    [JsonPropertyName("deletionProtection")]
    public string? DeletionProtection { get; set; }

    /// <summary>Configuration block for the user pool&apos;s device tracking. Detailed below.</summary>
    [JsonPropertyName("deviceConfiguration")]
    public V1beta2UserPoolStatusAtProviderDeviceConfiguration? DeviceConfiguration { get; set; }

    /// <summary>Holds the domain prefix if the user pool has a domain associated with it.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Configuration block for configuring email. Detailed below.</summary>
    [JsonPropertyName("emailConfiguration")]
    public V1beta2UserPoolStatusAtProviderEmailConfiguration? EmailConfiguration { get; set; }

    /// <summary>Configuration block for configuring email Multi-Factor Authentication (MFA); requires at least 2 account_recovery_setting entries; requires an email_configuration configuration block. Effective only when mfa_configuration is ON or OPTIONAL. Detailed below.</summary>
    [JsonPropertyName("emailMfaConfiguration")]
    public V1beta2UserPoolStatusAtProviderEmailMfaConfiguration? EmailMfaConfiguration { get; set; }

    /// <summary>String representing the email verification message. Conflicts with verification_message_template configuration block email_message argument.</summary>
    [JsonPropertyName("emailVerificationMessage")]
    public string? EmailVerificationMessage { get; set; }

    /// <summary>String representing the email verification subject. Conflicts with verification_message_template configuration block email_subject argument.</summary>
    [JsonPropertyName("emailVerificationSubject")]
    public string? EmailVerificationSubject { get; set; }

    /// <summary>Endpoint name of the user pool. Example format: cognito-idp.REGION.amazonaws.com/xxxx_yyyyy</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>A number estimating the size of the user pool.</summary>
    [JsonPropertyName("estimatedNumberOfUsers")]
    public double? EstimatedNumberOfUsers { get; set; }

    /// <summary>ID of the user pool.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block for the AWS Lambda triggers associated with the user pool. Detailed below.</summary>
    [JsonPropertyName("lambdaConfig")]
    public V1beta2UserPoolStatusAtProviderLambdaConfig? LambdaConfig { get; set; }

    /// <summary>Date the user pool was last modified.</summary>
    [JsonPropertyName("lastModifiedDate")]
    public string? LastModifiedDate { get; set; }

    /// <summary>Multi-Factor Authentication (MFA) configuration for the User Pool. Defaults of OFF. Valid values are OFF (MFA Tokens are not required), ON (MFA is required for all users to sign in; requires at least one of email_mfa_configuration, sms_configuration or software_token_mfa_configuration to be configured), or OPTIONAL (MFA Will be required only for individual users who have MFA Enabled; requires at least one of email_mfa_configuration, sms_configuration or software_token_mfa_configuration to be configured).</summary>
    [JsonPropertyName("mfaConfiguration")]
    public string? MfaConfiguration { get; set; }

    /// <summary>Name of the user pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block for information about the user pool password policy. Detailed below.</summary>
    [JsonPropertyName("passwordPolicy")]
    public V1beta2UserPoolStatusAtProviderPasswordPolicy? PasswordPolicy { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration block for the schema attributes of a user pool. Detailed below. Schema attributes from the standard attribute set only need to be specified if they are different from the default configuration. Attributes can be added, but not modified or removed. Maximum of 50 attributes.</summary>
    [JsonPropertyName("schema")]
    public IList<V1beta2UserPoolStatusAtProviderSchema>? Schema { get; set; }

    /// <summary>Configuration block for information about the user pool sign in policy. Detailed below.</summary>
    [JsonPropertyName("signInPolicy")]
    public V1beta2UserPoolStatusAtProviderSignInPolicy? SignInPolicy { get; set; }

    /// <summary>String representing the SMS authentication message. The Message must contain the {####} placeholder, which will be replaced with the code.</summary>
    [JsonPropertyName("smsAuthenticationMessage")]
    public string? SmsAuthenticationMessage { get; set; }

    /// <summary>Configuration block for Short Message Service (SMS) settings. Detailed below. These settings apply to SMS user verification and SMS Multi-Factor Authentication (MFA). SMS MFA is activated only when mfa_configuration is set to ON or OPTIONAL along with this block. Due to Cognito API restrictions, the SMS configuration cannot be removed without recreating the Cognito User Pool. For user data safety, this resource will ignore the removal of this configuration by disabling drift detection. To force resource recreation after this configuration has been applied, see the taint command.</summary>
    [JsonPropertyName("smsConfiguration")]
    public V1beta2UserPoolStatusAtProviderSmsConfiguration? SmsConfiguration { get; set; }

    /// <summary>String representing the SMS verification message. Conflicts with verification_message_template configuration block sms_message argument.</summary>
    [JsonPropertyName("smsVerificationMessage")]
    public string? SmsVerificationMessage { get; set; }

    /// <summary>Configuration block for software token Mult-Factor Authentication (MFA) settings. Effective only when mfa_configuration is ON or OPTIONAL. Detailed below.</summary>
    [JsonPropertyName("softwareTokenMfaConfiguration")]
    public V1beta2UserPoolStatusAtProviderSoftwareTokenMfaConfiguration? SoftwareTokenMfaConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Configuration block for user attribute update settings. Detailed below.</summary>
    [JsonPropertyName("userAttributeUpdateSettings")]
    public V1beta2UserPoolStatusAtProviderUserAttributeUpdateSettings? UserAttributeUpdateSettings { get; set; }

    /// <summary>Configuration block for user pool add-ons to enable user pool advanced security mode features. Detailed below.</summary>
    [JsonPropertyName("userPoolAddOns")]
    public V1beta2UserPoolStatusAtProviderUserPoolAddOns? UserPoolAddOns { get; set; }

    /// <summary>The user pool feature plan, or tier. Valid values: LITE, ESSENTIALS, PLUS.</summary>
    [JsonPropertyName("userPoolTier")]
    public string? UserPoolTier { get; set; }

    /// <summary>Whether email addresses or phone numbers can be specified as usernames when a user signs up. Conflicts with alias_attributes.</summary>
    [JsonPropertyName("usernameAttributes")]
    public IList<string>? UsernameAttributes { get; set; }

    /// <summary>Configuration block for username configuration. Detailed below.</summary>
    [JsonPropertyName("usernameConfiguration")]
    public V1beta2UserPoolStatusAtProviderUsernameConfiguration? UsernameConfiguration { get; set; }

    /// <summary>Configuration block for verification message templates. Detailed below.</summary>
    [JsonPropertyName("verificationMessageTemplate")]
    public V1beta2UserPoolStatusAtProviderVerificationMessageTemplate? VerificationMessageTemplate { get; set; }

    /// <summary>Configuration block for web authn configuration. Detailed below.</summary>
    [JsonPropertyName("webAuthnConfiguration")]
    public V1beta2UserPoolStatusAtProviderWebAuthnConfiguration? WebAuthnConfiguration { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatusConditions
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

/// <summary>UserPoolStatus defines the observed state of UserPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2UserPoolStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2UserPoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2UserPoolStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>UserPool is the Schema for the UserPools API. Provides a Cognito User Pool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2UserPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2UserPoolSpec>, IStatus<V1beta2UserPoolStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "UserPool";
    public const string KubeGroup = "cognitoidp.aws.upbound.io";
    public const string KubePluralName = "userpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cognitoidp.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "UserPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UserPoolSpec defines the desired state of UserPool</summary>
    [JsonPropertyName("spec")]
    public required V1beta2UserPoolSpec Spec { get; set; }

    /// <summary>UserPoolStatus defines the observed state of UserPool.</summary>
    [JsonPropertyName("status")]
    public V1beta2UserPoolStatus? Status { get; set; }
}
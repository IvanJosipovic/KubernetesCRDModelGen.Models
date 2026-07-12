#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cognitoidentityprovider.services.k8s.aws;
/// <summary>UserPool is the Schema for the UserPools API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1UserPoolList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1UserPool>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "UserPoolList";
    public const string KubeGroup = "cognitoidentityprovider.services.k8s.aws";
    public const string KubePluralName = "userpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cognitoidentityprovider.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "UserPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1UserPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1UserPool> Items { get; set; }
}

/// <summary>
/// A recovery option for a user. The AccountRecoverySettingType data type is
/// an array of this object. Each RecoveryOptionType has a priority property
/// that determines whether it is a primary or secondary option.
/// 
/// For example, if verified_email has a priority of 1 and verified_phone_number
/// has a priority of 2, your user pool sends account-recovery messages to a
/// verified email address but falls back to an SMS message if the user has a
/// verified phone number. The admin_only option prevents self-service account
/// recovery.
/// 
/// This data type is a request and response parameter of CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
/// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
/// and a response parameter of DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecAccountRecoverySettingRecoveryMechanisms
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("priority")]
    public long? Priority { get; set; }
}

/// <summary>
/// The available verified method a user can use to recover their password when
/// they call ForgotPassword. You can use this setting to define a preferred
/// method when a user has more than one method available. With this setting,
/// SMS doesn&apos;t qualify for a valid password recovery mechanism if the user also
/// has SMS multi-factor authentication (MFA) activated. In the absence of this
/// setting, Amazon Cognito uses the legacy behavior to determine the recovery
/// method where SMS is preferred through email.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecAccountRecoverySetting
{
    [JsonPropertyName("recoveryMechanisms")]
    public IList<V1alpha1UserPoolSpecAccountRecoverySettingRecoveryMechanisms>? RecoveryMechanisms { get; set; }
}

/// <summary>The message template structure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecAdminCreateUserConfigInviteMessageTemplate
{
    [JsonPropertyName("emailMessage")]
    public string? EmailMessage { get; set; }

    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }

    [JsonPropertyName("sMSMessage")]
    public string? SMSMessage { get; set; }
}

/// <summary>The configuration for AdminCreateUser requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecAdminCreateUserConfig
{
    [JsonPropertyName("allowAdminCreateUserOnly")]
    public bool? AllowAdminCreateUserOnly { get; set; }

    /// <summary>The message template structure.</summary>
    [JsonPropertyName("inviteMessageTemplate")]
    public V1alpha1UserPoolSpecAdminCreateUserConfigInviteMessageTemplate? InviteMessageTemplate { get; set; }

    [JsonPropertyName("unusedAccountValidityDays")]
    public long? UnusedAccountValidityDays { get; set; }
}

/// <summary>
/// The device-remembering configuration for a user pool. A null value indicates
/// that you have deactivated device remembering in your user pool.
/// 
/// When you provide a value for any DeviceConfiguration field, you activate
/// the Amazon Cognito device-remembering feature.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecDeviceConfiguration
{
    [JsonPropertyName("challengeRequiredOnNewDevice")]
    public bool? ChallengeRequiredOnNewDevice { get; set; }

    [JsonPropertyName("deviceOnlyRememberedOnUserPrompt")]
    public bool? DeviceOnlyRememberedOnUserPrompt { get; set; }
}

/// <summary>
/// The email configuration of your user pool. The email configuration type sets
/// your preferred sending method, Amazon Web Services Region, and sender for
/// messages from your user pool.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecEmailConfiguration
{
    [JsonPropertyName("configurationSet")]
    public string? ConfigurationSet { get; set; }

    [JsonPropertyName("emailSendingAccount")]
    public string? EmailSendingAccount { get; set; }

    [JsonPropertyName("from")]
    public string? From { get; set; }

    [JsonPropertyName("replyToEmailAddress")]
    public string? ReplyToEmailAddress { get; set; }

    [JsonPropertyName("sourceARN")]
    public string? SourceARN { get; set; }
}

/// <summary>
/// The properties of a custom email sender Lambda trigger.
/// 
/// This data type is a request and response parameter of CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
/// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
/// and a response parameter of DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecLambdaConfigCustomEmailSender
{
    [JsonPropertyName("lambdaARN")]
    public string? LambdaARN { get; set; }

    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

/// <summary>
/// The properties of a custom SMS sender Lambda trigger.
/// 
/// This data type is a request and response parameter of CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
/// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
/// and a response parameter of DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecLambdaConfigCustomSMSSender
{
    [JsonPropertyName("lambdaARN")]
    public string? LambdaARN { get; set; }

    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

/// <summary>
/// The properties of a pre token generation Lambda trigger.
/// 
/// This data type is a request and response parameter of CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
/// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
/// and a response parameter of DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecLambdaConfigPreTokenGenerationConfig
{
    [JsonPropertyName("lambdaARN")]
    public string? LambdaARN { get; set; }

    [JsonPropertyName("lambdaVersion")]
    public string? LambdaVersion { get; set; }
}

/// <summary>
/// A collection of user pool Lambda triggers. Amazon Cognito invokes triggers
/// at several possible stages of authentication operations. Triggers can modify
/// the outcome of the operations that invoked them.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecLambdaConfig
{
    [JsonPropertyName("createAuthChallenge")]
    public string? CreateAuthChallenge { get; set; }

    /// <summary>
    /// The properties of a custom email sender Lambda trigger.
    /// 
    /// This data type is a request and response parameter of CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
    /// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
    /// and a response parameter of DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html).
    /// </summary>
    [JsonPropertyName("customEmailSender")]
    public V1alpha1UserPoolSpecLambdaConfigCustomEmailSender? CustomEmailSender { get; set; }

    [JsonPropertyName("customMessage")]
    public string? CustomMessage { get; set; }

    /// <summary>
    /// The properties of a custom SMS sender Lambda trigger.
    /// 
    /// This data type is a request and response parameter of CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
    /// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
    /// and a response parameter of DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html).
    /// </summary>
    [JsonPropertyName("customSMSSender")]
    public V1alpha1UserPoolSpecLambdaConfigCustomSMSSender? CustomSMSSender { get; set; }

    [JsonPropertyName("defineAuthChallenge")]
    public string? DefineAuthChallenge { get; set; }

    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    [JsonPropertyName("postAuthentication")]
    public string? PostAuthentication { get; set; }

    [JsonPropertyName("postConfirmation")]
    public string? PostConfirmation { get; set; }

    [JsonPropertyName("preAuthentication")]
    public string? PreAuthentication { get; set; }

    [JsonPropertyName("preSignUp")]
    public string? PreSignUp { get; set; }

    [JsonPropertyName("preTokenGeneration")]
    public string? PreTokenGeneration { get; set; }

    /// <summary>
    /// The properties of a pre token generation Lambda trigger.
    /// 
    /// This data type is a request and response parameter of CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
    /// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
    /// and a response parameter of DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html).
    /// </summary>
    [JsonPropertyName("preTokenGenerationConfig")]
    public V1alpha1UserPoolSpecLambdaConfigPreTokenGenerationConfig? PreTokenGenerationConfig { get; set; }

    [JsonPropertyName("userMigration")]
    public string? UserMigration { get; set; }

    [JsonPropertyName("verifyAuthChallengeResponse")]
    public string? VerifyAuthChallengeResponse { get; set; }
}

/// <summary>
/// The password policy settings for a user pool, including complexity, history,
/// and length requirements.
/// 
/// This data type is a request and response parameter of CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
/// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
/// and a response parameter of DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecPoliciesPasswordPolicy
{
    [JsonPropertyName("minimumLength")]
    public long? MinimumLength { get; set; }

    [JsonPropertyName("requireLowercase")]
    public bool? RequireLowercase { get; set; }

    [JsonPropertyName("requireNumbers")]
    public bool? RequireNumbers { get; set; }

    [JsonPropertyName("requireSymbols")]
    public bool? RequireSymbols { get; set; }

    [JsonPropertyName("requireUppercase")]
    public bool? RequireUppercase { get; set; }

    [JsonPropertyName("temporaryPasswordValidityDays")]
    public long? TemporaryPasswordValidityDays { get; set; }
}

/// <summary>The policies associated with the new user pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecPolicies
{
    /// <summary>
    /// The password policy settings for a user pool, including complexity, history,
    /// and length requirements.
    /// 
    /// This data type is a request and response parameter of CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
    /// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
    /// and a response parameter of DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html).
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public V1alpha1UserPoolSpecPoliciesPasswordPolicy? PasswordPolicy { get; set; }
}

/// <summary>
/// The minimum and maximum values of an attribute that is of the number type,
/// for example custom:age.
/// 
/// This data type is part of SchemaAttributeType (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SchemaAttributeType.html).
/// It defines the length constraints on number-type attributes that you configure
/// in CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
/// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
/// and displays the length constraints of all number-type attributes in the
/// response to DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecSchemaNumberAttributeConstraints
{
    [JsonPropertyName("maxValue")]
    public string? MaxValue { get; set; }

    [JsonPropertyName("minValue")]
    public string? MinValue { get; set; }
}

/// <summary>
/// The minimum and maximum length values of an attribute that is of the string
/// type, for example custom:department.
/// 
/// This data type is part of SchemaAttributeType (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SchemaAttributeType.html).
/// It defines the length constraints on string-type attributes that you configure
/// in CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
/// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
/// and displays the length constraints of all string-type attributes in the
/// response to DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecSchemaStringAttributeConstraints
{
    [JsonPropertyName("maxLength")]
    public string? MaxLength { get; set; }

    [JsonPropertyName("minLength")]
    public string? MinLength { get; set; }
}

/// <summary>
/// A list of the user attributes and their properties in your user pool. The
/// attribute schema contains standard attributes, custom attributes with a custom:
/// prefix, and developer attributes with a dev: prefix. For more information,
/// see User pool attributes (https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-attributes.html).
/// 
/// Developer-only dev: attributes are a legacy feature of user pools, and are
/// read-only to all app clients. You can create and update developer-only attributes
/// only with IAM-authenticated API operations. Use app client read/write permissions
/// instead.
/// 
/// This data type is a request and response parameter of CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
/// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
/// and a response parameter of DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecSchema
{
    [JsonPropertyName("attributeDataType")]
    public string? AttributeDataType { get; set; }

    [JsonPropertyName("developerOnlyAttribute")]
    public bool? DeveloperOnlyAttribute { get; set; }

    [JsonPropertyName("mutable")]
    public bool? Mutable { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The minimum and maximum values of an attribute that is of the number type,
    /// for example custom:age.
    /// 
    /// This data type is part of SchemaAttributeType (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SchemaAttributeType.html).
    /// It defines the length constraints on number-type attributes that you configure
    /// in CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
    /// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
    /// and displays the length constraints of all number-type attributes in the
    /// response to DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html)
    /// </summary>
    [JsonPropertyName("numberAttributeConstraints")]
    public V1alpha1UserPoolSpecSchemaNumberAttributeConstraints? NumberAttributeConstraints { get; set; }

    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>
    /// The minimum and maximum length values of an attribute that is of the string
    /// type, for example custom:department.
    /// 
    /// This data type is part of SchemaAttributeType (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SchemaAttributeType.html).
    /// It defines the length constraints on string-type attributes that you configure
    /// in CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
    /// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
    /// and displays the length constraints of all string-type attributes in the
    /// response to DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html)
    /// </summary>
    [JsonPropertyName("stringAttributeConstraints")]
    public V1alpha1UserPoolSpecSchemaStringAttributeConstraints? StringAttributeConstraints { get; set; }
}

/// <summary>
/// The SMS configuration with the settings that your Amazon Cognito user pool
/// must use to send an SMS message from your Amazon Web Services account through
/// Amazon Simple Notification Service. To send SMS messages with Amazon SNS
/// in the Amazon Web Services Region that you want, the Amazon Cognito user
/// pool uses an Identity and Access Management (IAM) role in your Amazon Web
/// Services account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecSmsConfiguration
{
    [JsonPropertyName("externalID")]
    public string? ExternalID { get; set; }

    [JsonPropertyName("snsCallerARN")]
    public string? SnsCallerARN { get; set; }

    [JsonPropertyName("snsRegion")]
    public string? SnsRegion { get; set; }
}

/// <summary>
/// The settings for updates to user attributes. These settings include the property
/// AttributesRequireVerificationBeforeUpdate,a user-pool setting that tells
/// Amazon Cognito how to handle changes to the value of your users&apos; email address
/// and phone number attributes. Formore information, see Verifying updates to
/// email addresses and phone numbers (https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-email-phone-verification.html#user-pool-settings-verifications-verify-attribute-updates).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecUserAttributeUpdateSettings
{
    [JsonPropertyName("attributesRequireVerificationBeforeUpdate")]
    public IList<string>? AttributesRequireVerificationBeforeUpdate { get; set; }
}

/// <summary>
/// User pool add-ons. Contains settings for activation of advanced security
/// features. To log user security information but take no action, set to AUDIT.
/// To configure automatic security responses to risky traffic to your user pool,
/// set to ENFORCED.
/// 
/// For more information, see Adding advanced security to a user pool (https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pool-settings-advanced-security.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecUserPoolAddOns
{
    [JsonPropertyName("advancedSecurityMode")]
    public string? AdvancedSecurityMode { get; set; }
}

/// <summary>
/// Case sensitivity on the username input for the selected sign-in option. When
/// case sensitivity is set to False (case insensitive), users can sign in with
/// any combination of capital and lowercase letters. For example, username,
/// USERNAME, or UserName, or for email, email@example.com or EMaiL@eXamplE.Com.
/// For most use cases, set case sensitivity to False (case insensitive) as a
/// best practice. When usernames and email addresses are case insensitive, Amazon
/// Cognito treats any variation in case as the same user, and prevents a case
/// variation from being assigned to the same attribute for a different user.
/// 
/// This configuration is immutable after you set it. For more information, see
/// UsernameConfigurationType (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UsernameConfigurationType.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecUsernameConfiguration
{
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }
}

/// <summary>
/// The template for the verification message that your user pool delivers to
/// users who set an email address or phone number attribute.
/// 
/// Set the email message type that corresponds to your DefaultEmailOption selection.
/// For CONFIRM_WITH_LINK, specify an EmailMessageByLink and leave EmailMessage
/// blank. For CONFIRM_WITH_CODE, specify an EmailMessage and leave EmailMessageByLink
/// blank. When you supply both parameters with either choice, Amazon Cognito
/// returns an error.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpecVerificationMessageTemplate
{
    [JsonPropertyName("defaultEmailOption")]
    public string? DefaultEmailOption { get; set; }

    [JsonPropertyName("emailMessage")]
    public string? EmailMessage { get; set; }

    [JsonPropertyName("emailMessageByLink")]
    public string? EmailMessageByLink { get; set; }

    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }

    [JsonPropertyName("emailSubjectByLink")]
    public string? EmailSubjectByLink { get; set; }

    [JsonPropertyName("smsMessage")]
    public string? SmsMessage { get; set; }
}

/// <summary>UserPoolSpec defines the desired state of UserPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolSpec
{
    /// <summary>
    /// The available verified method a user can use to recover their password when
    /// they call ForgotPassword. You can use this setting to define a preferred
    /// method when a user has more than one method available. With this setting,
    /// SMS doesn&apos;t qualify for a valid password recovery mechanism if the user also
    /// has SMS multi-factor authentication (MFA) activated. In the absence of this
    /// setting, Amazon Cognito uses the legacy behavior to determine the recovery
    /// method where SMS is preferred through email.
    /// </summary>
    [JsonPropertyName("accountRecoverySetting")]
    public V1alpha1UserPoolSpecAccountRecoverySetting? AccountRecoverySetting { get; set; }

    /// <summary>The configuration for AdminCreateUser requests.</summary>
    [JsonPropertyName("adminCreateUserConfig")]
    public V1alpha1UserPoolSpecAdminCreateUserConfig? AdminCreateUserConfig { get; set; }

    /// <summary>
    /// Attributes supported as an alias for this user pool. Possible values: phone_number,
    /// email, or preferred_username.
    /// </summary>
    [JsonPropertyName("aliasAttributes")]
    public IList<string>? AliasAttributes { get; set; }

    /// <summary>The attributes to be auto-verified. Possible values: email, phone_number.</summary>
    [JsonPropertyName("autoVerifiedAttributes")]
    public IList<string>? AutoVerifiedAttributes { get; set; }

    /// <summary>
    /// When active, DeletionProtection prevents accidental deletion of your userpool.
    /// Before you can delete a user pool that you have protected against deletion,
    /// youmust deactivate this feature.
    /// 
    /// When you try to delete a protected user pool in a DeleteUserPool API request,
    /// Amazon Cognito returns an InvalidParameterException error. To delete a protected
    /// user pool, send a new DeleteUserPool request after you deactivate deletion
    /// protection in an UpdateUserPool API request.
    /// </summary>
    [JsonPropertyName("deletionProtection")]
    public string? DeletionProtection { get; set; }

    /// <summary>
    /// The device-remembering configuration for a user pool. A null value indicates
    /// that you have deactivated device remembering in your user pool.
    /// 
    /// When you provide a value for any DeviceConfiguration field, you activate
    /// the Amazon Cognito device-remembering feature.
    /// </summary>
    [JsonPropertyName("deviceConfiguration")]
    public V1alpha1UserPoolSpecDeviceConfiguration? DeviceConfiguration { get; set; }

    /// <summary>
    /// The email configuration of your user pool. The email configuration type sets
    /// your preferred sending method, Amazon Web Services Region, and sender for
    /// messages from your user pool.
    /// </summary>
    [JsonPropertyName("emailConfiguration")]
    public V1alpha1UserPoolSpecEmailConfiguration? EmailConfiguration { get; set; }

    /// <summary>
    /// This parameter is no longer used. See VerificationMessageTemplateType (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_VerificationMessageTemplateType.html).
    /// 
    /// Regex Pattern: `^[\p{L}\p{M}\p{S}\p{N}\p{P}\s*]*\{####\}[\p{L}\p{M}\p{S}\p{N}\p{P}\s*]*$`
    /// </summary>
    [JsonPropertyName("emailVerificationMessage")]
    public string? EmailVerificationMessage { get; set; }

    /// <summary>
    /// This parameter is no longer used. See VerificationMessageTemplateType (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_VerificationMessageTemplateType.html).
    /// 
    /// Regex Pattern: `^[\p{L}\p{M}\p{S}\p{N}\p{P}\s]+$`
    /// </summary>
    [JsonPropertyName("emailVerificationSubject")]
    public string? EmailVerificationSubject { get; set; }

    /// <summary>
    /// A collection of user pool Lambda triggers. Amazon Cognito invokes triggers
    /// at several possible stages of authentication operations. Triggers can modify
    /// the outcome of the operations that invoked them.
    /// </summary>
    [JsonPropertyName("lambdaConfig")]
    public V1alpha1UserPoolSpecLambdaConfig? LambdaConfig { get; set; }

    /// <summary>Specifies MFA configuration details.</summary>
    [JsonPropertyName("mfaConfiguration")]
    public string? MfaConfiguration { get; set; }

    /// <summary>
    /// A string used to name the user pool.
    /// 
    /// Regex Pattern: `^[\w\s+=,.@-]+$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>The policies associated with the new user pool.</summary>
    [JsonPropertyName("policies")]
    public V1alpha1UserPoolSpecPolicies? Policies { get; set; }

    /// <summary>
    /// An array of schema attributes for the new user pool. These attributes can
    /// be standard or custom attributes.
    /// </summary>
    [JsonPropertyName("schema")]
    public IList<V1alpha1UserPoolSpecSchema>? Schema { get; set; }

    /// <summary>
    /// A string representing the SMS authentication message.
    /// 
    /// Regex Pattern: `\{####\}`
    /// </summary>
    [JsonPropertyName("smsAuthenticationMessage")]
    public string? SmsAuthenticationMessage { get; set; }

    /// <summary>
    /// The SMS configuration with the settings that your Amazon Cognito user pool
    /// must use to send an SMS message from your Amazon Web Services account through
    /// Amazon Simple Notification Service. To send SMS messages with Amazon SNS
    /// in the Amazon Web Services Region that you want, the Amazon Cognito user
    /// pool uses an Identity and Access Management (IAM) role in your Amazon Web
    /// Services account.
    /// </summary>
    [JsonPropertyName("smsConfiguration")]
    public V1alpha1UserPoolSpecSmsConfiguration? SmsConfiguration { get; set; }

    /// <summary>
    /// This parameter is no longer used. See VerificationMessageTemplateType (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_VerificationMessageTemplateType.html).
    /// 
    /// Regex Pattern: `\{####\}`
    /// </summary>
    [JsonPropertyName("smsVerificationMessage")]
    public string? SmsVerificationMessage { get; set; }

    /// <summary>The tags to assign to the user pool.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The settings for updates to user attributes. These settings include the property
    /// AttributesRequireVerificationBeforeUpdate,a user-pool setting that tells
    /// Amazon Cognito how to handle changes to the value of your users&apos; email address
    /// and phone number attributes. Formore information, see Verifying updates to
    /// email addresses and phone numbers (https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-email-phone-verification.html#user-pool-settings-verifications-verify-attribute-updates).
    /// </summary>
    [JsonPropertyName("userAttributeUpdateSettings")]
    public V1alpha1UserPoolSpecUserAttributeUpdateSettings? UserAttributeUpdateSettings { get; set; }

    /// <summary>
    /// User pool add-ons. Contains settings for activation of advanced security
    /// features. To log user security information but take no action, set to AUDIT.
    /// To configure automatic security responses to risky traffic to your user pool,
    /// set to ENFORCED.
    /// 
    /// For more information, see Adding advanced security to a user pool (https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pool-settings-advanced-security.html).
    /// </summary>
    [JsonPropertyName("userPoolAddOns")]
    public V1alpha1UserPoolSpecUserPoolAddOns? UserPoolAddOns { get; set; }

    /// <summary>
    /// The tag keys and values to assign to the user pool. A tag is a label that
    /// you can use to categorize and manage user pools in different ways, such as
    /// by purpose, owner, environment, or other criteria.
    /// </summary>
    [JsonPropertyName("userPoolTags")]
    public IDictionary<string, string>? UserPoolTags { get; set; }

    /// <summary>
    /// Specifies whether a user can use an email address or phone number as a username
    /// when they sign up.
    /// </summary>
    [JsonPropertyName("usernameAttributes")]
    public IList<string>? UsernameAttributes { get; set; }

    /// <summary>
    /// Case sensitivity on the username input for the selected sign-in option. When
    /// case sensitivity is set to False (case insensitive), users can sign in with
    /// any combination of capital and lowercase letters. For example, username,
    /// USERNAME, or UserName, or for email, email@example.com or EMaiL@eXamplE.Com.
    /// For most use cases, set case sensitivity to False (case insensitive) as a
    /// best practice. When usernames and email addresses are case insensitive, Amazon
    /// Cognito treats any variation in case as the same user, and prevents a case
    /// variation from being assigned to the same attribute for a different user.
    /// 
    /// This configuration is immutable after you set it. For more information, see
    /// UsernameConfigurationType (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UsernameConfigurationType.html).
    /// </summary>
    [JsonPropertyName("usernameConfiguration")]
    public V1alpha1UserPoolSpecUsernameConfiguration? UsernameConfiguration { get; set; }

    /// <summary>
    /// The template for the verification message that your user pool delivers to
    /// users who set an email address or phone number attribute.
    /// 
    /// Set the email message type that corresponds to your DefaultEmailOption selection.
    /// For CONFIRM_WITH_LINK, specify an EmailMessageByLink and leave EmailMessage
    /// blank. For CONFIRM_WITH_CODE, specify an EmailMessage and leave EmailMessageByLink
    /// blank. When you supply both parameters with either choice, Amazon Cognito
    /// returns an error.
    /// </summary>
    [JsonPropertyName("verificationMessageTemplate")]
    public V1alpha1UserPoolSpecVerificationMessageTemplate? VerificationMessageTemplate { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolStatusAckResourceMetadata
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
public partial class V1alpha1UserPoolStatusConditions
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

/// <summary>
/// The minimum and maximum values of an attribute that is of the number type,
/// for example custom:age.
/// 
/// This data type is part of SchemaAttributeType (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SchemaAttributeType.html).
/// It defines the length constraints on number-type attributes that you configure
/// in CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
/// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
/// and displays the length constraints of all number-type attributes in the
/// response to DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolStatusSchemaAttributesNumberAttributeConstraints
{
    [JsonPropertyName("maxValue")]
    public string? MaxValue { get; set; }

    [JsonPropertyName("minValue")]
    public string? MinValue { get; set; }
}

/// <summary>
/// The minimum and maximum length values of an attribute that is of the string
/// type, for example custom:department.
/// 
/// This data type is part of SchemaAttributeType (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SchemaAttributeType.html).
/// It defines the length constraints on string-type attributes that you configure
/// in CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
/// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
/// and displays the length constraints of all string-type attributes in the
/// response to DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolStatusSchemaAttributesStringAttributeConstraints
{
    [JsonPropertyName("maxLength")]
    public string? MaxLength { get; set; }

    [JsonPropertyName("minLength")]
    public string? MinLength { get; set; }
}

/// <summary>
/// A list of the user attributes and their properties in your user pool. The
/// attribute schema contains standard attributes, custom attributes with a custom:
/// prefix, and developer attributes with a dev: prefix. For more information,
/// see User pool attributes (https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-attributes.html).
/// 
/// Developer-only dev: attributes are a legacy feature of user pools, and are
/// read-only to all app clients. You can create and update developer-only attributes
/// only with IAM-authenticated API operations. Use app client read/write permissions
/// instead.
/// 
/// This data type is a request and response parameter of CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
/// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
/// and a response parameter of DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolStatusSchemaAttributes
{
    [JsonPropertyName("attributeDataType")]
    public string? AttributeDataType { get; set; }

    [JsonPropertyName("developerOnlyAttribute")]
    public bool? DeveloperOnlyAttribute { get; set; }

    [JsonPropertyName("mutable")]
    public bool? Mutable { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The minimum and maximum values of an attribute that is of the number type,
    /// for example custom:age.
    /// 
    /// This data type is part of SchemaAttributeType (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SchemaAttributeType.html).
    /// It defines the length constraints on number-type attributes that you configure
    /// in CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
    /// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
    /// and displays the length constraints of all number-type attributes in the
    /// response to DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html)
    /// </summary>
    [JsonPropertyName("numberAttributeConstraints")]
    public V1alpha1UserPoolStatusSchemaAttributesNumberAttributeConstraints? NumberAttributeConstraints { get; set; }

    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>
    /// The minimum and maximum length values of an attribute that is of the string
    /// type, for example custom:department.
    /// 
    /// This data type is part of SchemaAttributeType (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SchemaAttributeType.html).
    /// It defines the length constraints on string-type attributes that you configure
    /// in CreateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateUserPool.html)
    /// and UpdateUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_UpdateUserPool.html),
    /// and displays the length constraints of all string-type attributes in the
    /// response to DescribeUserPool (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPool.html)
    /// </summary>
    [JsonPropertyName("stringAttributeConstraints")]
    public V1alpha1UserPoolStatusSchemaAttributesStringAttributeConstraints? StringAttributeConstraints { get; set; }
}

/// <summary>UserPoolStatus defines the observed state of UserPool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UserPoolStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1UserPoolStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1UserPoolStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The date and time when the item was created. Amazon Cognito returns this
    /// timestamp in UNIX epoch time format. Your SDK might render the output in
    /// a human-readable format like ISO 8601 or a Java Date object.
    /// </summary>
    [JsonPropertyName("creationDate")]
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// A custom domain name that you provide to Amazon Cognito. This parameter applies
    /// only if you use a custom domain to host the sign-up and sign-in pages for
    /// your application. An example of a custom domain name might be auth.example.com.
    /// 
    /// For more information about adding a custom domain to your user pool, see
    /// Using Your Own Domain for the Hosted UI (https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-add-custom-domain.html).
    /// 
    /// Regex Pattern: `^[a-z0-9](?:[a-z0-9\-]{0,61}[a-z0-9])?$`
    /// </summary>
    [JsonPropertyName("customDomain")]
    public string? CustomDomain { get; set; }

    /// <summary>
    /// The domain prefix, if the user pool has a domain associated with it.
    /// 
    /// Regex Pattern: `^[a-z0-9](?:[a-z0-9\-]{0,61}[a-z0-9])?$`
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>
    /// Deprecated. Review error codes from API requests with EventSource:cognito-idp.amazonaws.com
    /// in CloudTrail for information about problems with user pool email configuration.
    /// </summary>
    [JsonPropertyName("emailConfigurationFailure")]
    public string? EmailConfigurationFailure { get; set; }

    /// <summary>A number estimating the size of the user pool.</summary>
    [JsonPropertyName("estimatedNumberOfUsers")]
    public long? EstimatedNumberOfUsers { get; set; }

    /// <summary>
    /// The ID of the user pool.
    /// 
    /// Regex Pattern: `^[\w-]+_[0-9a-zA-Z]+$`
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The date and time when the item was modified. Amazon Cognito returns this
    /// timestamp in UNIX epoch time format. Your SDK might render the output in
    /// a human-readable format like ISO 8601 or a Java Date object.
    /// </summary>
    [JsonPropertyName("lastModifiedDate")]
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// A list of the user attributes and their properties in your user pool. The
    /// attribute schema contains standard attributes, custom attributes with a custom:
    /// prefix, and developer attributes with a dev: prefix. For more information,
    /// see User pool attributes (https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-attributes.html).
    /// 
    /// Developer-only attributes are a legacy feature of user pools, and are read-only
    /// to all app clients. You can create and update developer-only attributes only
    /// with IAM-authenticated API operations. Use app client read/write permissions
    /// instead.
    /// </summary>
    [JsonPropertyName("schemaAttributes")]
    public IList<V1alpha1UserPoolStatusSchemaAttributes>? SchemaAttributes { get; set; }

    /// <summary>
    /// The reason why the SMS configuration can&apos;t send the messages to your users.
    /// 
    /// This message might include comma-separated values to describe why your SMS
    /// configuration can&apos;t send messages to user pool end users.
    /// 
    /// InvalidSmsRoleAccessPolicyException
    /// 
    /// The Identity and Access Management role that Amazon Cognito uses to send
    /// SMS messages isn&apos;t properly configured. For more information, see SmsConfigurationType
    /// (https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_SmsConfigurationType.html).
    /// 
    /// SNSSandbox
    /// 
    /// The Amazon Web Services account is in the SNS SMS Sandbox and messages will
    /// only reach verified end users. This parameter won’t get populated with
    /// SNSSandbox if the user creating the user pool doesn’t have SNS permissions.
    /// To learn how to move your Amazon Web Services account out of the sandbox,
    /// see Moving out of the SMS sandbox (https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox-moving-to-production.html).
    /// </summary>
    [JsonPropertyName("smsConfigurationFailure")]
    public string? SmsConfigurationFailure { get; set; }

    /// <summary>This parameter is no longer used.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>UserPool is the Schema for the UserPools API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1UserPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1UserPoolSpec?>, IStatus<V1alpha1UserPoolStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "UserPool";
    public const string KubeGroup = "cognitoidentityprovider.services.k8s.aws";
    public const string KubePluralName = "userpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cognitoidentityprovider.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "UserPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UserPoolSpec defines the desired state of UserPool.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1UserPoolSpec? Spec { get; set; }

    /// <summary>UserPoolStatus defines the observed state of UserPool</summary>
    [JsonPropertyName("status")]
    public V1alpha1UserPoolStatus? Status { get; set; }
}
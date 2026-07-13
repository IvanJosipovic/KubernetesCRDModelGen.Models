#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.wafv2.aws.upbound.io;
/// <summary>WebACLRuleGroupAssociation is the Schema for the WebACLRuleGroupAssociations API. Associates a WAFv2 Rule Group with a Web ACL by adding a rule that references the Rule Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebACLRuleGroupAssociationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1WebACLRuleGroupAssociation>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebACLRuleGroupAssociationList";
    public const string KubeGroup = "wafv2.aws.upbound.io";
    public const string KubePluralName = "webaclrulegroupassociations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "wafv2.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WebACLRuleGroupAssociationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1WebACLRuleGroupAssociation objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1WebACLRuleGroupAssociation> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecDeletionPolicyEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Names of the fields in the request payload that contain your customer&apos;s primary physical address. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionAddressFields
{
    /// <summary>
    /// Names of the phone number fields.
    /// Identifiers of the address fields
    /// </summary>
    [JsonPropertyName("identifiers")]
    public IList<string>? Identifiers { get; set; }
}

/// <summary>Name of the field in the request payload that contains your customer&apos;s email. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionEmailField
{
    /// <summary>
    /// Name of the username field.
    /// Identifier of the email field
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>Details about your login page password field. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPasswordField
{
    /// <summary>
    /// Name of the username field.
    /// Identifier of the password field
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>Names of the fields in the request payload that contain your customer&apos;s primary phone number. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPhoneNumberFields
{
    /// <summary>
    /// Names of the phone number fields.
    /// Identifiers of the phone number fields
    /// </summary>
    [JsonPropertyName("identifiers")]
    public IList<string>? Identifiers { get; set; }
}

/// <summary>Details about your login page username field. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionUsernameField
{
    /// <summary>
    /// Name of the username field.
    /// Identifier of the username field
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>Criteria for inspecting login requests, used by the ATP rule group to validate credentials usage. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection
{
    /// <summary>Names of the fields in the request payload that contain your customer&apos;s primary physical address. See below.</summary>
    [JsonPropertyName("addressFields")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionAddressFields? AddressFields { get; set; }

    /// <summary>Name of the field in the request payload that contains your customer&apos;s email. See below.</summary>
    [JsonPropertyName("emailField")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionEmailField? EmailField { get; set; }

    /// <summary>Details about your login page password field. See below.</summary>
    [JsonPropertyName("passwordField")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPasswordField? PasswordField { get; set; }

    /// <summary>
    /// Payload type for your login endpoint, either JSON or form encoded.
    /// Payload type for inspection, either JSON or FORM_ENCODED.
    /// </summary>
    [JsonPropertyName("payloadType")]
    public string? PayloadType { get; set; }

    /// <summary>Names of the fields in the request payload that contain your customer&apos;s primary phone number. See below.</summary>
    [JsonPropertyName("phoneNumberFields")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPhoneNumberFields? PhoneNumberFields { get; set; }

    /// <summary>Details about your login page username field. See below.</summary>
    [JsonPropertyName("usernameField")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionUsernameField? UsernameField { get; set; }
}

/// <summary>Configures inspection of the response body. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionBodyContains
{
    /// <summary>
    /// Strings in the body of the response that indicate a failed login attempt.
    /// Strings that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureStrings")]
    public IList<string>? FailureStrings { get; set; }

    /// <summary>
    /// Strings in the body of the response that indicate a successful login attempt.
    /// Strings that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successStrings")]
    public IList<string>? SuccessStrings { get; set; }
}

/// <summary>Configures inspection of the response header. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionHeader
{
    /// <summary>
    /// Values in the response header with the specified name that indicate a failed login attempt.
    /// Strings that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureValues")]
    public IList<string>? FailureValues { get; set; }

    /// <summary>
    /// Name of the header to match against. The name must be an exact match, including case.
    /// Name of the HTTP header to inspect
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Values in the response header with the specified name that indicate a successful login attempt.
    /// Strings that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successValues")]
    public IList<string>? SuccessValues { get; set; }
}

/// <summary>Configures inspection of the response JSON. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionJson
{
    /// <summary>
    /// Values in the response header with the specified name that indicate a failed login attempt.
    /// Strings that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureValues")]
    public IList<string>? FailureValues { get; set; }

    /// <summary>
    /// Identifier for the value to match against in the JSON.
    /// Identifier of the JSON field to inspect
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    /// <summary>
    /// Values in the response header with the specified name that indicate a successful login attempt.
    /// Strings that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successValues")]
    public IList<string>? SuccessValues { get; set; }
}

/// <summary>Configures inspection of the response status code. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionStatusCode
{
    /// <summary>
    /// Status codes in the response that indicate a failed login attempt.
    /// Status codes that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureCodes")]
    public IList<double>? FailureCodes { get; set; }

    /// <summary>
    /// Status codes in the response that indicate a successful login attempt.
    /// Status codes that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successCodes")]
    public IList<double>? SuccessCodes { get; set; }
}

/// <summary>Criteria for inspecting responses to login requests, used by the ATP rule group to track login failure rates. Note that Response Inspection is available only on web ACLs that protect CloudFront distributions. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspection
{
    /// <summary>Configures inspection of the response body. See below.</summary>
    [JsonPropertyName("bodyContains")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionBodyContains? BodyContains { get; set; }

    /// <summary>Configures inspection of the response header. See below.</summary>
    [JsonPropertyName("header")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionHeader? Header { get; set; }

    /// <summary>Configures inspection of the response JSON. See below.</summary>
    [JsonPropertyName("json")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionJson? Json { get; set; }

    /// <summary>Configures inspection of the response status code. See below.</summary>
    [JsonPropertyName("statusCode")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionStatusCode? StatusCode { get; set; }
}

/// <summary>Additional configuration for using the Account Creation Fraud Prevention managed rule group. Use this to specify information such as the registration page of your application and the type of content to accept or reject from the client. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSet
{
    /// <summary>
    /// Path of the account creation endpoint for your application. This is the page on your website that accepts the completed registration form for a new user. This page must accept POST requests.
    /// Path to the account creation endpoint on the protected website
    /// </summary>
    [JsonPropertyName("creationPath")]
    public string? CreationPath { get; set; }

    /// <summary>Whether or not to allow the use of regular expressions in the login page path.</summary>
    [JsonPropertyName("enableRegexInPath")]
    public bool? EnableRegexInPath { get; set; }

    /// <summary>Path of the account registration endpoint for your application. This is the page on your website that presents the registration form to new users. This page must accept GET text/html requests.</summary>
    [JsonPropertyName("registrationPagePath")]
    public string? RegistrationPagePath { get; set; }

    /// <summary>Criteria for inspecting login requests, used by the ATP rule group to validate credentials usage. See below.</summary>
    [JsonPropertyName("requestInspection")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection? RequestInspection { get; set; }

    /// <summary>Criteria for inspecting responses to login requests, used by the ATP rule group to track login failure rates. Note that Response Inspection is available only on web ACLs that protect CloudFront distributions. See below.</summary>
    [JsonPropertyName("responseInspection")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspection? ResponseInspection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfigChallengeExemptUriRegularExpression
{
    /// <summary>Regular expression string.</summary>
    [JsonPropertyName("regexString")]
    public string? RegexString { get; set; }
}

/// <summary>Configuration for the use of the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfigChallenge
{
    /// <summary>Block for the list of the regular expressions to match against the web request URI, used to identify requests that can&apos;t handle a silent browser challenge. See below.</summary>
    [JsonPropertyName("exemptUriRegularExpression")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfigChallengeExemptUriRegularExpression>? ExemptUriRegularExpression { get; set; }

    /// <summary>Sensitivity that the rule group rule ChallengeDDoSRequests uses when matching against the DDoS suspicion labeling on a request. Valid values are LOW, MEDIUM and HIGH (Default).</summary>
    [JsonPropertyName("sensitivity")]
    public string? Sensitivity { get; set; }

    /// <summary>Configuration whether to use the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests in the rule group evaluation. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("usageOfAction")]
    public string? UsageOfAction { get; set; }
}

/// <summary>Configuration for the request handling that&apos;s applied by the managed rule group rules ChallengeAllDuringEvent and ChallengeDDoSRequests during a distributed denial of service (DDoS) attack. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfig
{
    /// <summary>Configuration for the use of the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests. See below.</summary>
    [JsonPropertyName("challenge")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfigChallenge? Challenge { get; set; }
}

/// <summary>Configuration for using the anti-DDoS managed rule group. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet
{
    /// <summary>Configuration for the request handling that&apos;s applied by the managed rule group rules ChallengeAllDuringEvent and ChallengeDDoSRequests during a distributed denial of service (DDoS) attack. See below.</summary>
    [JsonPropertyName("clientSideActionConfig")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfig? ClientSideActionConfig { get; set; }

    /// <summary>Sensitivity that the rule group rule DDoSRequests uses when matching against the DDoS suspicion labeling on a request. Valid values are LOW (Default), MEDIUM, and HIGH.</summary>
    [JsonPropertyName("sensitivityToBlock")]
    public string? SensitivityToBlock { get; set; }
}

/// <summary>Details about your login page password field. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetRequestInspectionPasswordField
{
    /// <summary>
    /// Name of the username field.
    /// Identifier of the password field
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>Details about your login page username field. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetRequestInspectionUsernameField
{
    /// <summary>
    /// Name of the username field.
    /// Identifier of the username field
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>Criteria for inspecting login requests, used by the ATP rule group to validate credentials usage. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetRequestInspection
{
    /// <summary>Details about your login page password field. See below.</summary>
    [JsonPropertyName("passwordField")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetRequestInspectionPasswordField? PasswordField { get; set; }

    /// <summary>
    /// Payload type for your login endpoint, either JSON or form encoded.
    /// Payload type for inspection, either JSON or FORM_ENCODED.
    /// </summary>
    [JsonPropertyName("payloadType")]
    public string? PayloadType { get; set; }

    /// <summary>Details about your login page username field. See below.</summary>
    [JsonPropertyName("usernameField")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetRequestInspectionUsernameField? UsernameField { get; set; }
}

/// <summary>Configures inspection of the response body. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionBodyContains
{
    /// <summary>
    /// Strings in the body of the response that indicate a failed login attempt.
    /// Strings that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureStrings")]
    public IList<string>? FailureStrings { get; set; }

    /// <summary>
    /// Strings in the body of the response that indicate a successful login attempt.
    /// Strings that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successStrings")]
    public IList<string>? SuccessStrings { get; set; }
}

/// <summary>Configures inspection of the response header. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionHeader
{
    /// <summary>
    /// Values in the response header with the specified name that indicate a failed login attempt.
    /// Strings that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureValues")]
    public IList<string>? FailureValues { get; set; }

    /// <summary>
    /// Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.
    /// Name of the HTTP header to inspect
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Values in the response header with the specified name that indicate a successful login attempt.
    /// Strings that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successValues")]
    public IList<string>? SuccessValues { get; set; }
}

/// <summary>Configures inspection of the response JSON. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionJson
{
    /// <summary>
    /// Values in the response header with the specified name that indicate a failed login attempt.
    /// Strings that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureValues")]
    public IList<string>? FailureValues { get; set; }

    /// <summary>
    /// Name of the username field.
    /// Identifier of the JSON field to inspect
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    /// <summary>
    /// Values in the response header with the specified name that indicate a successful login attempt.
    /// Strings that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successValues")]
    public IList<string>? SuccessValues { get; set; }
}

/// <summary>Configures inspection of the response status code. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionStatusCode
{
    /// <summary>
    /// Status codes in the response that indicate a failed login attempt.
    /// Status codes that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureCodes")]
    public IList<double>? FailureCodes { get; set; }

    /// <summary>
    /// Status codes in the response that indicate a successful login attempt.
    /// Status codes that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successCodes")]
    public IList<double>? SuccessCodes { get; set; }
}

/// <summary>Criteria for inspecting responses to login requests, used by the ATP rule group to track login failure rates. Note that Response Inspection is available only on web ACLs that protect CloudFront distributions. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspection
{
    /// <summary>Configures inspection of the response body. See below.</summary>
    [JsonPropertyName("bodyContains")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionBodyContains? BodyContains { get; set; }

    /// <summary>Configures inspection of the response header. See below.</summary>
    [JsonPropertyName("header")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionHeader? Header { get; set; }

    /// <summary>Configures inspection of the response JSON. See below.</summary>
    [JsonPropertyName("json")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionJson? Json { get; set; }

    /// <summary>Configures inspection of the response status code. See below.</summary>
    [JsonPropertyName("statusCode")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionStatusCode? StatusCode { get; set; }
}

/// <summary>Additional configuration for using the Account Takeover Protection managed rule group. Use this to specify information such as the sign-in page of your application and the type of content to accept or reject from the client. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSet
{
    /// <summary>Whether or not to allow the use of regular expressions in the login page path.</summary>
    [JsonPropertyName("enableRegexInPath")]
    public bool? EnableRegexInPath { get; set; }

    /// <summary>Path of the login endpoint for your application.</summary>
    [JsonPropertyName("loginPath")]
    public string? LoginPath { get; set; }

    /// <summary>Criteria for inspecting login requests, used by the ATP rule group to validate credentials usage. See below.</summary>
    [JsonPropertyName("requestInspection")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetRequestInspection? RequestInspection { get; set; }

    /// <summary>Criteria for inspecting responses to login requests, used by the ATP rule group to track login failure rates. Note that Response Inspection is available only on web ACLs that protect CloudFront distributions. See below.</summary>
    [JsonPropertyName("responseInspection")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspection? ResponseInspection { get; set; }
}

/// <summary>Additional configuration for using the Bot Control managed rule group. Use this to specify the inspection level that you want to use. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet
{
    /// <summary>Applies only to the targeted inspection level. Determines whether to use machine learning (ML) to analyze your web traffic for bot-related activity. Defaults to false.</summary>
    [JsonPropertyName("enableMachineLearning")]
    public bool? EnableMachineLearning { get; set; }

    /// <summary>Inspection level to use for the Bot Control rule group.</summary>
    [JsonPropertyName("inspectionLevel")]
    public string? InspectionLevel { get; set; }
}

/// <summary>Additional information that&apos;s used by a managed rule group. Only one rule attribute is allowed in each config. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigs
{
    /// <summary>Additional configuration for using the Account Creation Fraud Prevention managed rule group. Use this to specify information such as the registration page of your application and the type of content to accept or reject from the client. See below.</summary>
    [JsonPropertyName("awsManagedRulesAcfpRuleSet")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSet? AwsManagedRulesAcfpRuleSet { get; set; }

    /// <summary>Configuration for using the anti-DDoS managed rule group. See below.</summary>
    [JsonPropertyName("awsManagedRulesAntiDdosRuleSet")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet? AwsManagedRulesAntiDdosRuleSet { get; set; }

    /// <summary>Additional configuration for using the Account Takeover Protection managed rule group. Use this to specify information such as the sign-in page of your application and the type of content to accept or reject from the client. See below.</summary>
    [JsonPropertyName("awsManagedRulesAtpRuleSet")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSet? AwsManagedRulesAtpRuleSet { get; set; }

    /// <summary>Additional configuration for using the Bot Control managed rule group. Use this to specify the inspection level that you want to use. See below.</summary>
    [JsonPropertyName("awsManagedRulesBotControlRuleSet")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet? AwsManagedRulesBotControlRuleSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseAllowCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseAllowCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseAllowCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Allow the request. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseAllow
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseAllowCustomRequestHandling? CustomRequestHandling { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseBlockCustomResponseResponseHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom response for blocked requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseBlockCustomResponse
{
    /// <summary>Key of a custom response body to use.</summary>
    [JsonPropertyName("customResponseBodyKey")]
    public string? CustomResponseBodyKey { get; set; }

    /// <summary>HTTP response code to return (200-599).</summary>
    [JsonPropertyName("responseCode")]
    public double? ResponseCode { get; set; }

    /// <summary>Headers to include in the response. See below.</summary>
    [JsonPropertyName("responseHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseBlockCustomResponseResponseHeader>? ResponseHeader { get; set; }
}

/// <summary>Block the request. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseBlock
{
    /// <summary>Custom response for blocked requests. See below.</summary>
    [JsonPropertyName("customResponse")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseBlockCustomResponse? CustomResponse { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseCaptchaCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseCaptchaCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseCaptchaCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Require CAPTCHA verification. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseCaptcha
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseCaptchaCustomRequestHandling? CustomRequestHandling { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseChallengeCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseChallengeCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseChallengeCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Configuration for the use of the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseChallenge
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseChallengeCustomRequestHandling? CustomRequestHandling { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseCountCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseCountCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseCountCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Count the request without taking action. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseCount
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseCountCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// Action to use instead of the rule&apos;s original action. See below.
/// Action to use in place of the rule action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUse
{
    /// <summary>Allow the request. See below.</summary>
    [JsonPropertyName("allow")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseAllow? Allow { get; set; }

    /// <summary>Block the request. See below.</summary>
    [JsonPropertyName("block")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseBlock? Block { get; set; }

    /// <summary>Require CAPTCHA verification. See below.</summary>
    [JsonPropertyName("captcha")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseCaptcha? Captcha { get; set; }

    /// <summary>Configuration for the use of the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests. See below.</summary>
    [JsonPropertyName("challenge")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseChallenge? Challenge { get; set; }

    /// <summary>Count the request without taking action. See below.</summary>
    [JsonPropertyName("count")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUseCount? Count { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverride
{
    /// <summary>
    /// Action to use instead of the rule&apos;s original action. See below.
    /// Action to use in place of the rule action.
    /// </summary>
    [JsonPropertyName("actionToUse")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverrideActionToUse? ActionToUse { get; set; }

    /// <summary>
    /// Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.
    /// Name of the rule to override.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Managed Rule Group configuration. One of rule_group_reference or managed_rule_group is required. Conflicts with rule_group_reference. See below.
/// Managed rule group configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroup
{
    /// <summary>Additional information that&apos;s used by a managed rule group. Only one rule attribute is allowed in each config. See below.</summary>
    [JsonPropertyName("managedRuleGroupConfigs")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupManagedRuleGroupConfigs? ManagedRuleGroupConfigs { get; set; }

    /// <summary>
    /// Name of the managed rule group.
    /// Name of the managed rule group.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Override actions for specific rules within the rule group. See below.
    /// Action settings to use in place of rule actions configured inside the rule group. You can specify up to 100 overrides.
    /// </summary>
    [JsonPropertyName("ruleActionOverride")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroupRuleActionOverride>? RuleActionOverride { get; set; }

    /// <summary>
    /// Name of the managed rule group vendor. For AWS managed rule groups, this is AWS.
    /// Name of the managed rule group vendor.
    /// </summary>
    [JsonPropertyName("vendorName")]
    public string? VendorName { get; set; }

    /// <summary>
    /// Version of the managed rule group. If not specified, the default version is used.
    /// Version of the managed rule group. Omit this to use the default version.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnRefPolicyResolutionEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnRefPolicyResolveEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RuleGroup in wafv2 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnSelectorPolicyResolutionEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnSelectorPolicyResolveEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RuleGroup in wafv2 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnSelector
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
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseAllowCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseAllowCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseAllowCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Allow the request. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseAllow
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseAllowCustomRequestHandling? CustomRequestHandling { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponseResponseHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom response for blocked requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponse
{
    /// <summary>Key of a custom response body to use.</summary>
    [JsonPropertyName("customResponseBodyKey")]
    public string? CustomResponseBodyKey { get; set; }

    /// <summary>HTTP response code to return (200-599).</summary>
    [JsonPropertyName("responseCode")]
    public double? ResponseCode { get; set; }

    /// <summary>Headers to include in the response. See below.</summary>
    [JsonPropertyName("responseHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponseResponseHeader>? ResponseHeader { get; set; }
}

/// <summary>Block the request. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseBlock
{
    /// <summary>Custom response for blocked requests. See below.</summary>
    [JsonPropertyName("customResponse")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponse? CustomResponse { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseCaptchaCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseCaptchaCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseCaptchaCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Require CAPTCHA verification. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseCaptcha
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseCaptchaCustomRequestHandling? CustomRequestHandling { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseChallengeCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseChallengeCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseChallengeCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Configuration for the use of the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseChallenge
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseChallengeCustomRequestHandling? CustomRequestHandling { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseCountCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseCountCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseCountCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Count the request without taking action. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseCount
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseCountCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// Action to use instead of the rule&apos;s original action. See below.
/// Action to use in place of the rule action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUse
{
    /// <summary>Allow the request. See below.</summary>
    [JsonPropertyName("allow")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseAllow? Allow { get; set; }

    /// <summary>Block the request. See below.</summary>
    [JsonPropertyName("block")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseBlock? Block { get; set; }

    /// <summary>Require CAPTCHA verification. See below.</summary>
    [JsonPropertyName("captcha")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseCaptcha? Captcha { get; set; }

    /// <summary>Configuration for the use of the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests. See below.</summary>
    [JsonPropertyName("challenge")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseChallenge? Challenge { get; set; }

    /// <summary>Count the request without taking action. See below.</summary>
    [JsonPropertyName("count")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUseCount? Count { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverride
{
    /// <summary>
    /// Action to use instead of the rule&apos;s original action. See below.
    /// Action to use in place of the rule action.
    /// </summary>
    [JsonPropertyName("actionToUse")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverrideActionToUse? ActionToUse { get; set; }

    /// <summary>
    /// Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.
    /// Name of the rule to override.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Custom Rule Group reference configuration. One of rule_group_reference or managed_rule_group is required. Conflicts with managed_rule_group. See below.
/// Rule Group reference configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReference
{
    /// <summary>
    /// ARN of the Rule Group to associate with the Web ACL.
    /// ARN of the Rule Group to associate with the Web ACL.
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a RuleGroup in wafv2 to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnRef? ArnRef { get; set; }

    /// <summary>Selector for a RuleGroup in wafv2 to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceArnSelector? ArnSelector { get; set; }

    /// <summary>
    /// Override actions for specific rules within the rule group. See below.
    /// Action settings to use in place of rule actions configured inside the rule group. You can specify up to 100 overrides.
    /// </summary>
    [JsonPropertyName("ruleActionOverride")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReferenceRuleActionOverride>? RuleActionOverride { get; set; }
}

/// <summary>
/// Defines and enables Amazon CloudWatch metrics and web request sample collection. See below.
/// Visibility configuration for the rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderVisibilityConfig
{
    /// <summary>
    /// Whether the associated resource sends metrics to CloudWatch. For the list of available metrics, see AWS WAF Metrics.
    /// Indicates whether the rule is available for use in the metrics for the web ACL.
    /// </summary>
    [JsonPropertyName("cloudwatchMetricsEnabled")]
    public bool? CloudwatchMetricsEnabled { get; set; }

    /// <summary>
    /// Friendly name of the CloudWatch metric. The name can contain only alphanumeric characters (A-Z, a-z, 0-9) hyphen(-) and underscore (_), with length from one to 128 characters. It can&apos;t contain whitespace or metric names reserved for AWS WAF, for example All and Default_Action.
    /// A name for the metrics for this rule.
    /// </summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>
    /// Whether AWS WAF should store a sampling of the web requests that match the rules. You can view the sampled requests through the AWS WAF console.
    /// Indicates whether to store a sampling of the web requests that match the rule.
    /// </summary>
    [JsonPropertyName("sampledRequestsEnabled")]
    public bool? SampledRequestsEnabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnRefPolicyResolutionEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnRefPolicyResolveEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a WebACL in wafv2 to populate webAclArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnSelectorPolicyResolutionEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnSelectorPolicyResolveEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a WebACL in wafv2 to populate webAclArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnSelector
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
    public V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecForProvider
{
    /// <summary>
    /// Managed Rule Group configuration. One of rule_group_reference or managed_rule_group is required. Conflicts with rule_group_reference. See below.
    /// Managed rule group configuration.
    /// </summary>
    [JsonPropertyName("managedRuleGroup")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderManagedRuleGroup? ManagedRuleGroup { get; set; }

    /// <summary>
    /// Override action for the rule group. Valid values are none and count. Defaults to none. When set to count, the actions defined in the rule group rules are overridden to count matches instead of blocking or allowing requests.
    /// Override action for the rule group. Valid values are &apos;none&apos; and &apos;count&apos;. Defaults to &apos;none&apos;.
    /// </summary>
    [JsonPropertyName("overrideAction")]
    public string? OverrideAction { get; set; }

    /// <summary>
    /// Priority of the rule within the Web ACL. Rules are evaluated in order of priority, with lower numbers evaluated first.
    /// Priority of the rule within the Web ACL.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// Custom Rule Group reference configuration. One of rule_group_reference or managed_rule_group is required. Conflicts with managed_rule_group. See below.
    /// Rule Group reference configuration.
    /// </summary>
    [JsonPropertyName("ruleGroupReference")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderRuleGroupReference? RuleGroupReference { get; set; }

    /// <summary>
    /// Name of the rule to create in the Web ACL that references the rule group. Must be between 1 and 128 characters.
    /// Name of the rule to create in the Web ACL that references the rule group.
    /// </summary>
    [JsonPropertyName("ruleName")]
    public string? RuleName { get; set; }

    /// <summary>
    /// Defines and enables Amazon CloudWatch metrics and web request sample collection. See below.
    /// Visibility configuration for the rule.
    /// </summary>
    [JsonPropertyName("visibilityConfig")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderVisibilityConfig? VisibilityConfig { get; set; }

    /// <summary>
    /// ARN of the Web ACL to associate the Rule Group with.
    /// ARN of the Web ACL to associate the Rule Group with.
    /// </summary>
    [JsonPropertyName("webAclArn")]
    public string? WebAclArn { get; set; }

    /// <summary>Reference to a WebACL in wafv2 to populate webAclArn.</summary>
    [JsonPropertyName("webAclArnRef")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnRef? WebAclArnRef { get; set; }

    /// <summary>Selector for a WebACL in wafv2 to populate webAclArn.</summary>
    [JsonPropertyName("webAclArnSelector")]
    public V1beta1WebACLRuleGroupAssociationSpecForProviderWebAclArnSelector? WebAclArnSelector { get; set; }
}

/// <summary>Names of the fields in the request payload that contain your customer&apos;s primary physical address. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionAddressFields
{
    /// <summary>
    /// Names of the phone number fields.
    /// Identifiers of the address fields
    /// </summary>
    [JsonPropertyName("identifiers")]
    public IList<string>? Identifiers { get; set; }
}

/// <summary>Name of the field in the request payload that contains your customer&apos;s email. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionEmailField
{
    /// <summary>
    /// Name of the username field.
    /// Identifier of the email field
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>Details about your login page password field. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPasswordField
{
    /// <summary>
    /// Name of the username field.
    /// Identifier of the password field
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>Names of the fields in the request payload that contain your customer&apos;s primary phone number. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPhoneNumberFields
{
    /// <summary>
    /// Names of the phone number fields.
    /// Identifiers of the phone number fields
    /// </summary>
    [JsonPropertyName("identifiers")]
    public IList<string>? Identifiers { get; set; }
}

/// <summary>Details about your login page username field. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionUsernameField
{
    /// <summary>
    /// Name of the username field.
    /// Identifier of the username field
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>Criteria for inspecting login requests, used by the ATP rule group to validate credentials usage. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection
{
    /// <summary>Names of the fields in the request payload that contain your customer&apos;s primary physical address. See below.</summary>
    [JsonPropertyName("addressFields")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionAddressFields? AddressFields { get; set; }

    /// <summary>Name of the field in the request payload that contains your customer&apos;s email. See below.</summary>
    [JsonPropertyName("emailField")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionEmailField? EmailField { get; set; }

    /// <summary>Details about your login page password field. See below.</summary>
    [JsonPropertyName("passwordField")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPasswordField? PasswordField { get; set; }

    /// <summary>
    /// Payload type for your login endpoint, either JSON or form encoded.
    /// Payload type for inspection, either JSON or FORM_ENCODED.
    /// </summary>
    [JsonPropertyName("payloadType")]
    public string? PayloadType { get; set; }

    /// <summary>Names of the fields in the request payload that contain your customer&apos;s primary phone number. See below.</summary>
    [JsonPropertyName("phoneNumberFields")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPhoneNumberFields? PhoneNumberFields { get; set; }

    /// <summary>Details about your login page username field. See below.</summary>
    [JsonPropertyName("usernameField")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionUsernameField? UsernameField { get; set; }
}

/// <summary>Configures inspection of the response body. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionBodyContains
{
    /// <summary>
    /// Strings in the body of the response that indicate a failed login attempt.
    /// Strings that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureStrings")]
    public IList<string>? FailureStrings { get; set; }

    /// <summary>
    /// Strings in the body of the response that indicate a successful login attempt.
    /// Strings that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successStrings")]
    public IList<string>? SuccessStrings { get; set; }
}

/// <summary>Configures inspection of the response header. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionHeader
{
    /// <summary>
    /// Values in the response header with the specified name that indicate a failed login attempt.
    /// Strings that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureValues")]
    public IList<string>? FailureValues { get; set; }

    /// <summary>
    /// Name of the header to match against. The name must be an exact match, including case.
    /// Name of the HTTP header to inspect
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Values in the response header with the specified name that indicate a successful login attempt.
    /// Strings that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successValues")]
    public IList<string>? SuccessValues { get; set; }
}

/// <summary>Configures inspection of the response JSON. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionJson
{
    /// <summary>
    /// Values in the response header with the specified name that indicate a failed login attempt.
    /// Strings that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureValues")]
    public IList<string>? FailureValues { get; set; }

    /// <summary>
    /// Identifier for the value to match against in the JSON.
    /// Identifier of the JSON field to inspect
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    /// <summary>
    /// Values in the response header with the specified name that indicate a successful login attempt.
    /// Strings that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successValues")]
    public IList<string>? SuccessValues { get; set; }
}

/// <summary>Configures inspection of the response status code. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionStatusCode
{
    /// <summary>
    /// Status codes in the response that indicate a failed login attempt.
    /// Status codes that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureCodes")]
    public IList<double>? FailureCodes { get; set; }

    /// <summary>
    /// Status codes in the response that indicate a successful login attempt.
    /// Status codes that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successCodes")]
    public IList<double>? SuccessCodes { get; set; }
}

/// <summary>Criteria for inspecting responses to login requests, used by the ATP rule group to track login failure rates. Note that Response Inspection is available only on web ACLs that protect CloudFront distributions. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspection
{
    /// <summary>Configures inspection of the response body. See below.</summary>
    [JsonPropertyName("bodyContains")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionBodyContains? BodyContains { get; set; }

    /// <summary>Configures inspection of the response header. See below.</summary>
    [JsonPropertyName("header")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionHeader? Header { get; set; }

    /// <summary>Configures inspection of the response JSON. See below.</summary>
    [JsonPropertyName("json")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionJson? Json { get; set; }

    /// <summary>Configures inspection of the response status code. See below.</summary>
    [JsonPropertyName("statusCode")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionStatusCode? StatusCode { get; set; }
}

/// <summary>Additional configuration for using the Account Creation Fraud Prevention managed rule group. Use this to specify information such as the registration page of your application and the type of content to accept or reject from the client. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSet
{
    /// <summary>
    /// Path of the account creation endpoint for your application. This is the page on your website that accepts the completed registration form for a new user. This page must accept POST requests.
    /// Path to the account creation endpoint on the protected website
    /// </summary>
    [JsonPropertyName("creationPath")]
    public string? CreationPath { get; set; }

    /// <summary>Whether or not to allow the use of regular expressions in the login page path.</summary>
    [JsonPropertyName("enableRegexInPath")]
    public bool? EnableRegexInPath { get; set; }

    /// <summary>Path of the account registration endpoint for your application. This is the page on your website that presents the registration form to new users. This page must accept GET text/html requests.</summary>
    [JsonPropertyName("registrationPagePath")]
    public string? RegistrationPagePath { get; set; }

    /// <summary>Criteria for inspecting login requests, used by the ATP rule group to validate credentials usage. See below.</summary>
    [JsonPropertyName("requestInspection")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection? RequestInspection { get; set; }

    /// <summary>Criteria for inspecting responses to login requests, used by the ATP rule group to track login failure rates. Note that Response Inspection is available only on web ACLs that protect CloudFront distributions. See below.</summary>
    [JsonPropertyName("responseInspection")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspection? ResponseInspection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfigChallengeExemptUriRegularExpression
{
    /// <summary>Regular expression string.</summary>
    [JsonPropertyName("regexString")]
    public string? RegexString { get; set; }
}

/// <summary>Configuration for the use of the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfigChallenge
{
    /// <summary>Block for the list of the regular expressions to match against the web request URI, used to identify requests that can&apos;t handle a silent browser challenge. See below.</summary>
    [JsonPropertyName("exemptUriRegularExpression")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfigChallengeExemptUriRegularExpression>? ExemptUriRegularExpression { get; set; }

    /// <summary>Sensitivity that the rule group rule ChallengeDDoSRequests uses when matching against the DDoS suspicion labeling on a request. Valid values are LOW, MEDIUM and HIGH (Default).</summary>
    [JsonPropertyName("sensitivity")]
    public string? Sensitivity { get; set; }

    /// <summary>Configuration whether to use the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests in the rule group evaluation. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("usageOfAction")]
    public string? UsageOfAction { get; set; }
}

/// <summary>Configuration for the request handling that&apos;s applied by the managed rule group rules ChallengeAllDuringEvent and ChallengeDDoSRequests during a distributed denial of service (DDoS) attack. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfig
{
    /// <summary>Configuration for the use of the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests. See below.</summary>
    [JsonPropertyName("challenge")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfigChallenge? Challenge { get; set; }
}

/// <summary>Configuration for using the anti-DDoS managed rule group. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet
{
    /// <summary>Configuration for the request handling that&apos;s applied by the managed rule group rules ChallengeAllDuringEvent and ChallengeDDoSRequests during a distributed denial of service (DDoS) attack. See below.</summary>
    [JsonPropertyName("clientSideActionConfig")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfig? ClientSideActionConfig { get; set; }

    /// <summary>Sensitivity that the rule group rule DDoSRequests uses when matching against the DDoS suspicion labeling on a request. Valid values are LOW (Default), MEDIUM, and HIGH.</summary>
    [JsonPropertyName("sensitivityToBlock")]
    public string? SensitivityToBlock { get; set; }
}

/// <summary>Details about your login page password field. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetRequestInspectionPasswordField
{
    /// <summary>
    /// Name of the username field.
    /// Identifier of the password field
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>Details about your login page username field. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetRequestInspectionUsernameField
{
    /// <summary>
    /// Name of the username field.
    /// Identifier of the username field
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>Criteria for inspecting login requests, used by the ATP rule group to validate credentials usage. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetRequestInspection
{
    /// <summary>Details about your login page password field. See below.</summary>
    [JsonPropertyName("passwordField")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetRequestInspectionPasswordField? PasswordField { get; set; }

    /// <summary>
    /// Payload type for your login endpoint, either JSON or form encoded.
    /// Payload type for inspection, either JSON or FORM_ENCODED.
    /// </summary>
    [JsonPropertyName("payloadType")]
    public string? PayloadType { get; set; }

    /// <summary>Details about your login page username field. See below.</summary>
    [JsonPropertyName("usernameField")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetRequestInspectionUsernameField? UsernameField { get; set; }
}

/// <summary>Configures inspection of the response body. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionBodyContains
{
    /// <summary>
    /// Strings in the body of the response that indicate a failed login attempt.
    /// Strings that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureStrings")]
    public IList<string>? FailureStrings { get; set; }

    /// <summary>
    /// Strings in the body of the response that indicate a successful login attempt.
    /// Strings that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successStrings")]
    public IList<string>? SuccessStrings { get; set; }
}

/// <summary>Configures inspection of the response header. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionHeader
{
    /// <summary>
    /// Values in the response header with the specified name that indicate a failed login attempt.
    /// Strings that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureValues")]
    public IList<string>? FailureValues { get; set; }

    /// <summary>
    /// Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.
    /// Name of the HTTP header to inspect
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Values in the response header with the specified name that indicate a successful login attempt.
    /// Strings that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successValues")]
    public IList<string>? SuccessValues { get; set; }
}

/// <summary>Configures inspection of the response JSON. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionJson
{
    /// <summary>
    /// Values in the response header with the specified name that indicate a failed login attempt.
    /// Strings that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureValues")]
    public IList<string>? FailureValues { get; set; }

    /// <summary>
    /// Name of the username field.
    /// Identifier of the JSON field to inspect
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    /// <summary>
    /// Values in the response header with the specified name that indicate a successful login attempt.
    /// Strings that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successValues")]
    public IList<string>? SuccessValues { get; set; }
}

/// <summary>Configures inspection of the response status code. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionStatusCode
{
    /// <summary>
    /// Status codes in the response that indicate a failed login attempt.
    /// Status codes that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureCodes")]
    public IList<double>? FailureCodes { get; set; }

    /// <summary>
    /// Status codes in the response that indicate a successful login attempt.
    /// Status codes that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successCodes")]
    public IList<double>? SuccessCodes { get; set; }
}

/// <summary>Criteria for inspecting responses to login requests, used by the ATP rule group to track login failure rates. Note that Response Inspection is available only on web ACLs that protect CloudFront distributions. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspection
{
    /// <summary>Configures inspection of the response body. See below.</summary>
    [JsonPropertyName("bodyContains")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionBodyContains? BodyContains { get; set; }

    /// <summary>Configures inspection of the response header. See below.</summary>
    [JsonPropertyName("header")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionHeader? Header { get; set; }

    /// <summary>Configures inspection of the response JSON. See below.</summary>
    [JsonPropertyName("json")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionJson? Json { get; set; }

    /// <summary>Configures inspection of the response status code. See below.</summary>
    [JsonPropertyName("statusCode")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionStatusCode? StatusCode { get; set; }
}

/// <summary>Additional configuration for using the Account Takeover Protection managed rule group. Use this to specify information such as the sign-in page of your application and the type of content to accept or reject from the client. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSet
{
    /// <summary>Whether or not to allow the use of regular expressions in the login page path.</summary>
    [JsonPropertyName("enableRegexInPath")]
    public bool? EnableRegexInPath { get; set; }

    /// <summary>Path of the login endpoint for your application.</summary>
    [JsonPropertyName("loginPath")]
    public string? LoginPath { get; set; }

    /// <summary>Criteria for inspecting login requests, used by the ATP rule group to validate credentials usage. See below.</summary>
    [JsonPropertyName("requestInspection")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetRequestInspection? RequestInspection { get; set; }

    /// <summary>Criteria for inspecting responses to login requests, used by the ATP rule group to track login failure rates. Note that Response Inspection is available only on web ACLs that protect CloudFront distributions. See below.</summary>
    [JsonPropertyName("responseInspection")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspection? ResponseInspection { get; set; }
}

/// <summary>Additional configuration for using the Bot Control managed rule group. Use this to specify the inspection level that you want to use. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet
{
    /// <summary>Applies only to the targeted inspection level. Determines whether to use machine learning (ML) to analyze your web traffic for bot-related activity. Defaults to false.</summary>
    [JsonPropertyName("enableMachineLearning")]
    public bool? EnableMachineLearning { get; set; }

    /// <summary>Inspection level to use for the Bot Control rule group.</summary>
    [JsonPropertyName("inspectionLevel")]
    public string? InspectionLevel { get; set; }
}

/// <summary>Additional information that&apos;s used by a managed rule group. Only one rule attribute is allowed in each config. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigs
{
    /// <summary>Additional configuration for using the Account Creation Fraud Prevention managed rule group. Use this to specify information such as the registration page of your application and the type of content to accept or reject from the client. See below.</summary>
    [JsonPropertyName("awsManagedRulesAcfpRuleSet")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSet? AwsManagedRulesAcfpRuleSet { get; set; }

    /// <summary>Configuration for using the anti-DDoS managed rule group. See below.</summary>
    [JsonPropertyName("awsManagedRulesAntiDdosRuleSet")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet? AwsManagedRulesAntiDdosRuleSet { get; set; }

    /// <summary>Additional configuration for using the Account Takeover Protection managed rule group. Use this to specify information such as the sign-in page of your application and the type of content to accept or reject from the client. See below.</summary>
    [JsonPropertyName("awsManagedRulesAtpRuleSet")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSet? AwsManagedRulesAtpRuleSet { get; set; }

    /// <summary>Additional configuration for using the Bot Control managed rule group. Use this to specify the inspection level that you want to use. See below.</summary>
    [JsonPropertyName("awsManagedRulesBotControlRuleSet")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet? AwsManagedRulesBotControlRuleSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseAllowCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseAllowCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseAllowCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Allow the request. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseAllow
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseAllowCustomRequestHandling? CustomRequestHandling { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseBlockCustomResponseResponseHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom response for blocked requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseBlockCustomResponse
{
    /// <summary>Key of a custom response body to use.</summary>
    [JsonPropertyName("customResponseBodyKey")]
    public string? CustomResponseBodyKey { get; set; }

    /// <summary>HTTP response code to return (200-599).</summary>
    [JsonPropertyName("responseCode")]
    public double? ResponseCode { get; set; }

    /// <summary>Headers to include in the response. See below.</summary>
    [JsonPropertyName("responseHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseBlockCustomResponseResponseHeader>? ResponseHeader { get; set; }
}

/// <summary>Block the request. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseBlock
{
    /// <summary>Custom response for blocked requests. See below.</summary>
    [JsonPropertyName("customResponse")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseBlockCustomResponse? CustomResponse { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseCaptchaCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseCaptchaCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseCaptchaCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Require CAPTCHA verification. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseCaptcha
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseCaptchaCustomRequestHandling? CustomRequestHandling { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseChallengeCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseChallengeCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseChallengeCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Configuration for the use of the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseChallenge
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseChallengeCustomRequestHandling? CustomRequestHandling { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseCountCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseCountCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseCountCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Count the request without taking action. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseCount
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseCountCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// Action to use instead of the rule&apos;s original action. See below.
/// Action to use in place of the rule action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUse
{
    /// <summary>Allow the request. See below.</summary>
    [JsonPropertyName("allow")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseAllow? Allow { get; set; }

    /// <summary>Block the request. See below.</summary>
    [JsonPropertyName("block")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseBlock? Block { get; set; }

    /// <summary>Require CAPTCHA verification. See below.</summary>
    [JsonPropertyName("captcha")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseCaptcha? Captcha { get; set; }

    /// <summary>Configuration for the use of the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests. See below.</summary>
    [JsonPropertyName("challenge")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseChallenge? Challenge { get; set; }

    /// <summary>Count the request without taking action. See below.</summary>
    [JsonPropertyName("count")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUseCount? Count { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverride
{
    /// <summary>
    /// Action to use instead of the rule&apos;s original action. See below.
    /// Action to use in place of the rule action.
    /// </summary>
    [JsonPropertyName("actionToUse")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverrideActionToUse? ActionToUse { get; set; }

    /// <summary>
    /// Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.
    /// Name of the rule to override.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Managed Rule Group configuration. One of rule_group_reference or managed_rule_group is required. Conflicts with rule_group_reference. See below.
/// Managed rule group configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroup
{
    /// <summary>Additional information that&apos;s used by a managed rule group. Only one rule attribute is allowed in each config. See below.</summary>
    [JsonPropertyName("managedRuleGroupConfigs")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupManagedRuleGroupConfigs? ManagedRuleGroupConfigs { get; set; }

    /// <summary>
    /// Name of the managed rule group.
    /// Name of the managed rule group.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Override actions for specific rules within the rule group. See below.
    /// Action settings to use in place of rule actions configured inside the rule group. You can specify up to 100 overrides.
    /// </summary>
    [JsonPropertyName("ruleActionOverride")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroupRuleActionOverride>? RuleActionOverride { get; set; }

    /// <summary>
    /// Name of the managed rule group vendor. For AWS managed rule groups, this is AWS.
    /// Name of the managed rule group vendor.
    /// </summary>
    [JsonPropertyName("vendorName")]
    public string? VendorName { get; set; }

    /// <summary>
    /// Version of the managed rule group. If not specified, the default version is used.
    /// Version of the managed rule group. Omit this to use the default version.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnRefPolicyResolutionEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnRefPolicyResolveEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RuleGroup in wafv2 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnSelectorPolicyResolutionEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnSelectorPolicyResolveEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RuleGroup in wafv2 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnSelector
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
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseAllowCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseAllowCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseAllowCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Allow the request. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseAllow
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseAllowCustomRequestHandling? CustomRequestHandling { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponseResponseHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom response for blocked requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponse
{
    /// <summary>Key of a custom response body to use.</summary>
    [JsonPropertyName("customResponseBodyKey")]
    public string? CustomResponseBodyKey { get; set; }

    /// <summary>HTTP response code to return (200-599).</summary>
    [JsonPropertyName("responseCode")]
    public double? ResponseCode { get; set; }

    /// <summary>Headers to include in the response. See below.</summary>
    [JsonPropertyName("responseHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponseResponseHeader>? ResponseHeader { get; set; }
}

/// <summary>Block the request. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseBlock
{
    /// <summary>Custom response for blocked requests. See below.</summary>
    [JsonPropertyName("customResponse")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponse? CustomResponse { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseCaptchaCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseCaptchaCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseCaptchaCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Require CAPTCHA verification. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseCaptcha
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseCaptchaCustomRequestHandling? CustomRequestHandling { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseChallengeCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseChallengeCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseChallengeCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Configuration for the use of the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseChallenge
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseChallengeCustomRequestHandling? CustomRequestHandling { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseCountCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseCountCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseCountCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Count the request without taking action. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseCount
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseCountCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// Action to use instead of the rule&apos;s original action. See below.
/// Action to use in place of the rule action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUse
{
    /// <summary>Allow the request. See below.</summary>
    [JsonPropertyName("allow")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseAllow? Allow { get; set; }

    /// <summary>Block the request. See below.</summary>
    [JsonPropertyName("block")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseBlock? Block { get; set; }

    /// <summary>Require CAPTCHA verification. See below.</summary>
    [JsonPropertyName("captcha")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseCaptcha? Captcha { get; set; }

    /// <summary>Configuration for the use of the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests. See below.</summary>
    [JsonPropertyName("challenge")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseChallenge? Challenge { get; set; }

    /// <summary>Count the request without taking action. See below.</summary>
    [JsonPropertyName("count")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUseCount? Count { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverride
{
    /// <summary>
    /// Action to use instead of the rule&apos;s original action. See below.
    /// Action to use in place of the rule action.
    /// </summary>
    [JsonPropertyName("actionToUse")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverrideActionToUse? ActionToUse { get; set; }

    /// <summary>
    /// Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.
    /// Name of the rule to override.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Custom Rule Group reference configuration. One of rule_group_reference or managed_rule_group is required. Conflicts with managed_rule_group. See below.
/// Rule Group reference configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReference
{
    /// <summary>
    /// ARN of the Rule Group to associate with the Web ACL.
    /// ARN of the Rule Group to associate with the Web ACL.
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a RuleGroup in wafv2 to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnRef? ArnRef { get; set; }

    /// <summary>Selector for a RuleGroup in wafv2 to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceArnSelector? ArnSelector { get; set; }

    /// <summary>
    /// Override actions for specific rules within the rule group. See below.
    /// Action settings to use in place of rule actions configured inside the rule group. You can specify up to 100 overrides.
    /// </summary>
    [JsonPropertyName("ruleActionOverride")]
    public IList<V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReferenceRuleActionOverride>? RuleActionOverride { get; set; }
}

/// <summary>
/// Defines and enables Amazon CloudWatch metrics and web request sample collection. See below.
/// Visibility configuration for the rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderVisibilityConfig
{
    /// <summary>
    /// Whether the associated resource sends metrics to CloudWatch. For the list of available metrics, see AWS WAF Metrics.
    /// Indicates whether the rule is available for use in the metrics for the web ACL.
    /// </summary>
    [JsonPropertyName("cloudwatchMetricsEnabled")]
    public bool? CloudwatchMetricsEnabled { get; set; }

    /// <summary>
    /// Friendly name of the CloudWatch metric. The name can contain only alphanumeric characters (A-Z, a-z, 0-9) hyphen(-) and underscore (_), with length from one to 128 characters. It can&apos;t contain whitespace or metric names reserved for AWS WAF, for example All and Default_Action.
    /// A name for the metrics for this rule.
    /// </summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>
    /// Whether AWS WAF should store a sampling of the web requests that match the rules. You can view the sampled requests through the AWS WAF console.
    /// Indicates whether to store a sampling of the web requests that match the rule.
    /// </summary>
    [JsonPropertyName("sampledRequestsEnabled")]
    public bool? SampledRequestsEnabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnRefPolicyResolutionEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnRefPolicyResolveEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a WebACL in wafv2 to populate webAclArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnSelectorPolicyResolutionEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnSelectorPolicyResolveEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a WebACL in wafv2 to populate webAclArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnSelector
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
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1WebACLRuleGroupAssociationSpecInitProvider
{
    /// <summary>
    /// Managed Rule Group configuration. One of rule_group_reference or managed_rule_group is required. Conflicts with rule_group_reference. See below.
    /// Managed rule group configuration.
    /// </summary>
    [JsonPropertyName("managedRuleGroup")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderManagedRuleGroup? ManagedRuleGroup { get; set; }

    /// <summary>
    /// Override action for the rule group. Valid values are none and count. Defaults to none. When set to count, the actions defined in the rule group rules are overridden to count matches instead of blocking or allowing requests.
    /// Override action for the rule group. Valid values are &apos;none&apos; and &apos;count&apos;. Defaults to &apos;none&apos;.
    /// </summary>
    [JsonPropertyName("overrideAction")]
    public string? OverrideAction { get; set; }

    /// <summary>
    /// Priority of the rule within the Web ACL. Rules are evaluated in order of priority, with lower numbers evaluated first.
    /// Priority of the rule within the Web ACL.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// Custom Rule Group reference configuration. One of rule_group_reference or managed_rule_group is required. Conflicts with managed_rule_group. See below.
    /// Rule Group reference configuration.
    /// </summary>
    [JsonPropertyName("ruleGroupReference")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderRuleGroupReference? RuleGroupReference { get; set; }

    /// <summary>
    /// Name of the rule to create in the Web ACL that references the rule group. Must be between 1 and 128 characters.
    /// Name of the rule to create in the Web ACL that references the rule group.
    /// </summary>
    [JsonPropertyName("ruleName")]
    public string? RuleName { get; set; }

    /// <summary>
    /// Defines and enables Amazon CloudWatch metrics and web request sample collection. See below.
    /// Visibility configuration for the rule.
    /// </summary>
    [JsonPropertyName("visibilityConfig")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderVisibilityConfig? VisibilityConfig { get; set; }

    /// <summary>
    /// ARN of the Web ACL to associate the Rule Group with.
    /// ARN of the Web ACL to associate the Rule Group with.
    /// </summary>
    [JsonPropertyName("webAclArn")]
    public string? WebAclArn { get; set; }

    /// <summary>Reference to a WebACL in wafv2 to populate webAclArn.</summary>
    [JsonPropertyName("webAclArnRef")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnRef? WebAclArnRef { get; set; }

    /// <summary>Selector for a WebACL in wafv2 to populate webAclArn.</summary>
    [JsonPropertyName("webAclArnSelector")]
    public V1beta1WebACLRuleGroupAssociationSpecInitProviderWebAclArnSelector? WebAclArnSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecManagementPoliciesEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLRuleGroupAssociationSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1WebACLRuleGroupAssociationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebACLRuleGroupAssociationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebACLRuleGroupAssociationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLRuleGroupAssociationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>WebACLRuleGroupAssociationSpec defines the desired state of WebACLRuleGroupAssociation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationSpec
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
    public V1beta1WebACLRuleGroupAssociationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1WebACLRuleGroupAssociationSpecForProvider ForProvider { get; set; }

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
    public V1beta1WebACLRuleGroupAssociationSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1WebACLRuleGroupAssociationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WebACLRuleGroupAssociationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WebACLRuleGroupAssociationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Names of the fields in the request payload that contain your customer&apos;s primary physical address. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionAddressFields
{
    /// <summary>
    /// Names of the phone number fields.
    /// Identifiers of the address fields
    /// </summary>
    [JsonPropertyName("identifiers")]
    public IList<string>? Identifiers { get; set; }
}

/// <summary>Name of the field in the request payload that contains your customer&apos;s email. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionEmailField
{
    /// <summary>
    /// Name of the username field.
    /// Identifier of the email field
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>Details about your login page password field. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPasswordField
{
    /// <summary>
    /// Name of the username field.
    /// Identifier of the password field
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>Names of the fields in the request payload that contain your customer&apos;s primary phone number. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPhoneNumberFields
{
    /// <summary>
    /// Names of the phone number fields.
    /// Identifiers of the phone number fields
    /// </summary>
    [JsonPropertyName("identifiers")]
    public IList<string>? Identifiers { get; set; }
}

/// <summary>Details about your login page username field. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionUsernameField
{
    /// <summary>
    /// Name of the username field.
    /// Identifier of the username field
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>Criteria for inspecting login requests, used by the ATP rule group to validate credentials usage. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection
{
    /// <summary>Names of the fields in the request payload that contain your customer&apos;s primary physical address. See below.</summary>
    [JsonPropertyName("addressFields")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionAddressFields? AddressFields { get; set; }

    /// <summary>Name of the field in the request payload that contains your customer&apos;s email. See below.</summary>
    [JsonPropertyName("emailField")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionEmailField? EmailField { get; set; }

    /// <summary>Details about your login page password field. See below.</summary>
    [JsonPropertyName("passwordField")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPasswordField? PasswordField { get; set; }

    /// <summary>
    /// Payload type for your login endpoint, either JSON or form encoded.
    /// Payload type for inspection, either JSON or FORM_ENCODED.
    /// </summary>
    [JsonPropertyName("payloadType")]
    public string? PayloadType { get; set; }

    /// <summary>Names of the fields in the request payload that contain your customer&apos;s primary phone number. See below.</summary>
    [JsonPropertyName("phoneNumberFields")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionPhoneNumberFields? PhoneNumberFields { get; set; }

    /// <summary>Details about your login page username field. See below.</summary>
    [JsonPropertyName("usernameField")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspectionUsernameField? UsernameField { get; set; }
}

/// <summary>Configures inspection of the response body. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionBodyContains
{
    /// <summary>
    /// Strings in the body of the response that indicate a failed login attempt.
    /// Strings that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureStrings")]
    public IList<string>? FailureStrings { get; set; }

    /// <summary>
    /// Strings in the body of the response that indicate a successful login attempt.
    /// Strings that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successStrings")]
    public IList<string>? SuccessStrings { get; set; }
}

/// <summary>Configures inspection of the response header. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionHeader
{
    /// <summary>
    /// Values in the response header with the specified name that indicate a failed login attempt.
    /// Strings that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureValues")]
    public IList<string>? FailureValues { get; set; }

    /// <summary>
    /// Name of the header to match against. The name must be an exact match, including case.
    /// Name of the HTTP header to inspect
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Values in the response header with the specified name that indicate a successful login attempt.
    /// Strings that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successValues")]
    public IList<string>? SuccessValues { get; set; }
}

/// <summary>Configures inspection of the response JSON. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionJson
{
    /// <summary>
    /// Values in the response header with the specified name that indicate a failed login attempt.
    /// Strings that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureValues")]
    public IList<string>? FailureValues { get; set; }

    /// <summary>
    /// Identifier for the value to match against in the JSON.
    /// Identifier of the JSON field to inspect
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    /// <summary>
    /// Values in the response header with the specified name that indicate a successful login attempt.
    /// Strings that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successValues")]
    public IList<string>? SuccessValues { get; set; }
}

/// <summary>Configures inspection of the response status code. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionStatusCode
{
    /// <summary>
    /// Status codes in the response that indicate a failed login attempt.
    /// Status codes that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureCodes")]
    public IList<double>? FailureCodes { get; set; }

    /// <summary>
    /// Status codes in the response that indicate a successful login attempt.
    /// Status codes that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successCodes")]
    public IList<double>? SuccessCodes { get; set; }
}

/// <summary>Criteria for inspecting responses to login requests, used by the ATP rule group to track login failure rates. Note that Response Inspection is available only on web ACLs that protect CloudFront distributions. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspection
{
    /// <summary>Configures inspection of the response body. See below.</summary>
    [JsonPropertyName("bodyContains")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionBodyContains? BodyContains { get; set; }

    /// <summary>Configures inspection of the response header. See below.</summary>
    [JsonPropertyName("header")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionHeader? Header { get; set; }

    /// <summary>Configures inspection of the response JSON. See below.</summary>
    [JsonPropertyName("json")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionJson? Json { get; set; }

    /// <summary>Configures inspection of the response status code. See below.</summary>
    [JsonPropertyName("statusCode")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspectionStatusCode? StatusCode { get; set; }
}

/// <summary>Additional configuration for using the Account Creation Fraud Prevention managed rule group. Use this to specify information such as the registration page of your application and the type of content to accept or reject from the client. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSet
{
    /// <summary>
    /// Path of the account creation endpoint for your application. This is the page on your website that accepts the completed registration form for a new user. This page must accept POST requests.
    /// Path to the account creation endpoint on the protected website
    /// </summary>
    [JsonPropertyName("creationPath")]
    public string? CreationPath { get; set; }

    /// <summary>Whether or not to allow the use of regular expressions in the login page path.</summary>
    [JsonPropertyName("enableRegexInPath")]
    public bool? EnableRegexInPath { get; set; }

    /// <summary>Path of the account registration endpoint for your application. This is the page on your website that presents the registration form to new users. This page must accept GET text/html requests.</summary>
    [JsonPropertyName("registrationPagePath")]
    public string? RegistrationPagePath { get; set; }

    /// <summary>Criteria for inspecting login requests, used by the ATP rule group to validate credentials usage. See below.</summary>
    [JsonPropertyName("requestInspection")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetRequestInspection? RequestInspection { get; set; }

    /// <summary>Criteria for inspecting responses to login requests, used by the ATP rule group to track login failure rates. Note that Response Inspection is available only on web ACLs that protect CloudFront distributions. See below.</summary>
    [JsonPropertyName("responseInspection")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSetResponseInspection? ResponseInspection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfigChallengeExemptUriRegularExpression
{
    /// <summary>Regular expression string.</summary>
    [JsonPropertyName("regexString")]
    public string? RegexString { get; set; }
}

/// <summary>Configuration for the use of the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfigChallenge
{
    /// <summary>Block for the list of the regular expressions to match against the web request URI, used to identify requests that can&apos;t handle a silent browser challenge. See below.</summary>
    [JsonPropertyName("exemptUriRegularExpression")]
    public IList<V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfigChallengeExemptUriRegularExpression>? ExemptUriRegularExpression { get; set; }

    /// <summary>Sensitivity that the rule group rule ChallengeDDoSRequests uses when matching against the DDoS suspicion labeling on a request. Valid values are LOW, MEDIUM and HIGH (Default).</summary>
    [JsonPropertyName("sensitivity")]
    public string? Sensitivity { get; set; }

    /// <summary>Configuration whether to use the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests in the rule group evaluation. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("usageOfAction")]
    public string? UsageOfAction { get; set; }
}

/// <summary>Configuration for the request handling that&apos;s applied by the managed rule group rules ChallengeAllDuringEvent and ChallengeDDoSRequests during a distributed denial of service (DDoS) attack. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfig
{
    /// <summary>Configuration for the use of the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests. See below.</summary>
    [JsonPropertyName("challenge")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfigChallenge? Challenge { get; set; }
}

/// <summary>Configuration for using the anti-DDoS managed rule group. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet
{
    /// <summary>Configuration for the request handling that&apos;s applied by the managed rule group rules ChallengeAllDuringEvent and ChallengeDDoSRequests during a distributed denial of service (DDoS) attack. See below.</summary>
    [JsonPropertyName("clientSideActionConfig")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSetClientSideActionConfig? ClientSideActionConfig { get; set; }

    /// <summary>Sensitivity that the rule group rule DDoSRequests uses when matching against the DDoS suspicion labeling on a request. Valid values are LOW (Default), MEDIUM, and HIGH.</summary>
    [JsonPropertyName("sensitivityToBlock")]
    public string? SensitivityToBlock { get; set; }
}

/// <summary>Details about your login page password field. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetRequestInspectionPasswordField
{
    /// <summary>
    /// Name of the username field.
    /// Identifier of the password field
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>Details about your login page username field. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetRequestInspectionUsernameField
{
    /// <summary>
    /// Name of the username field.
    /// Identifier of the username field
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }
}

/// <summary>Criteria for inspecting login requests, used by the ATP rule group to validate credentials usage. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetRequestInspection
{
    /// <summary>Details about your login page password field. See below.</summary>
    [JsonPropertyName("passwordField")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetRequestInspectionPasswordField? PasswordField { get; set; }

    /// <summary>
    /// Payload type for your login endpoint, either JSON or form encoded.
    /// Payload type for inspection, either JSON or FORM_ENCODED.
    /// </summary>
    [JsonPropertyName("payloadType")]
    public string? PayloadType { get; set; }

    /// <summary>Details about your login page username field. See below.</summary>
    [JsonPropertyName("usernameField")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetRequestInspectionUsernameField? UsernameField { get; set; }
}

/// <summary>Configures inspection of the response body. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionBodyContains
{
    /// <summary>
    /// Strings in the body of the response that indicate a failed login attempt.
    /// Strings that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureStrings")]
    public IList<string>? FailureStrings { get; set; }

    /// <summary>
    /// Strings in the body of the response that indicate a successful login attempt.
    /// Strings that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successStrings")]
    public IList<string>? SuccessStrings { get; set; }
}

/// <summary>Configures inspection of the response header. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionHeader
{
    /// <summary>
    /// Values in the response header with the specified name that indicate a failed login attempt.
    /// Strings that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureValues")]
    public IList<string>? FailureValues { get; set; }

    /// <summary>
    /// Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.
    /// Name of the HTTP header to inspect
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Values in the response header with the specified name that indicate a successful login attempt.
    /// Strings that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successValues")]
    public IList<string>? SuccessValues { get; set; }
}

/// <summary>Configures inspection of the response JSON. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionJson
{
    /// <summary>
    /// Values in the response header with the specified name that indicate a failed login attempt.
    /// Strings that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureValues")]
    public IList<string>? FailureValues { get; set; }

    /// <summary>
    /// Name of the username field.
    /// Identifier of the JSON field to inspect
    /// </summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    /// <summary>
    /// Values in the response header with the specified name that indicate a successful login attempt.
    /// Strings that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successValues")]
    public IList<string>? SuccessValues { get; set; }
}

/// <summary>Configures inspection of the response status code. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionStatusCode
{
    /// <summary>
    /// Status codes in the response that indicate a failed login attempt.
    /// Status codes that indicate a failed login or account creation attempt
    /// </summary>
    [JsonPropertyName("failureCodes")]
    public IList<double>? FailureCodes { get; set; }

    /// <summary>
    /// Status codes in the response that indicate a successful login attempt.
    /// Status codes that indicate a successful login or account creation attempt
    /// </summary>
    [JsonPropertyName("successCodes")]
    public IList<double>? SuccessCodes { get; set; }
}

/// <summary>Criteria for inspecting responses to login requests, used by the ATP rule group to track login failure rates. Note that Response Inspection is available only on web ACLs that protect CloudFront distributions. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspection
{
    /// <summary>Configures inspection of the response body. See below.</summary>
    [JsonPropertyName("bodyContains")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionBodyContains? BodyContains { get; set; }

    /// <summary>Configures inspection of the response header. See below.</summary>
    [JsonPropertyName("header")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionHeader? Header { get; set; }

    /// <summary>Configures inspection of the response JSON. See below.</summary>
    [JsonPropertyName("json")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionJson? Json { get; set; }

    /// <summary>Configures inspection of the response status code. See below.</summary>
    [JsonPropertyName("statusCode")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspectionStatusCode? StatusCode { get; set; }
}

/// <summary>Additional configuration for using the Account Takeover Protection managed rule group. Use this to specify information such as the sign-in page of your application and the type of content to accept or reject from the client. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSet
{
    /// <summary>Whether or not to allow the use of regular expressions in the login page path.</summary>
    [JsonPropertyName("enableRegexInPath")]
    public bool? EnableRegexInPath { get; set; }

    /// <summary>Path of the login endpoint for your application.</summary>
    [JsonPropertyName("loginPath")]
    public string? LoginPath { get; set; }

    /// <summary>Criteria for inspecting login requests, used by the ATP rule group to validate credentials usage. See below.</summary>
    [JsonPropertyName("requestInspection")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetRequestInspection? RequestInspection { get; set; }

    /// <summary>Criteria for inspecting responses to login requests, used by the ATP rule group to track login failure rates. Note that Response Inspection is available only on web ACLs that protect CloudFront distributions. See below.</summary>
    [JsonPropertyName("responseInspection")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSetResponseInspection? ResponseInspection { get; set; }
}

/// <summary>Additional configuration for using the Bot Control managed rule group. Use this to specify the inspection level that you want to use. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet
{
    /// <summary>Applies only to the targeted inspection level. Determines whether to use machine learning (ML) to analyze your web traffic for bot-related activity. Defaults to false.</summary>
    [JsonPropertyName("enableMachineLearning")]
    public bool? EnableMachineLearning { get; set; }

    /// <summary>Inspection level to use for the Bot Control rule group.</summary>
    [JsonPropertyName("inspectionLevel")]
    public string? InspectionLevel { get; set; }
}

/// <summary>Additional information that&apos;s used by a managed rule group. Only one rule attribute is allowed in each config. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigs
{
    /// <summary>Additional configuration for using the Account Creation Fraud Prevention managed rule group. Use this to specify information such as the registration page of your application and the type of content to accept or reject from the client. See below.</summary>
    [JsonPropertyName("awsManagedRulesAcfpRuleSet")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAcfpRuleSet? AwsManagedRulesAcfpRuleSet { get; set; }

    /// <summary>Configuration for using the anti-DDoS managed rule group. See below.</summary>
    [JsonPropertyName("awsManagedRulesAntiDdosRuleSet")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAntiDdosRuleSet? AwsManagedRulesAntiDdosRuleSet { get; set; }

    /// <summary>Additional configuration for using the Account Takeover Protection managed rule group. Use this to specify information such as the sign-in page of your application and the type of content to accept or reject from the client. See below.</summary>
    [JsonPropertyName("awsManagedRulesAtpRuleSet")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesAtpRuleSet? AwsManagedRulesAtpRuleSet { get; set; }

    /// <summary>Additional configuration for using the Bot Control managed rule group. Use this to specify the inspection level that you want to use. See below.</summary>
    [JsonPropertyName("awsManagedRulesBotControlRuleSet")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigsAwsManagedRulesBotControlRuleSet? AwsManagedRulesBotControlRuleSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseAllowCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseAllowCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseAllowCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Allow the request. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseAllow
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseAllowCustomRequestHandling? CustomRequestHandling { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseBlockCustomResponseResponseHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom response for blocked requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseBlockCustomResponse
{
    /// <summary>Key of a custom response body to use.</summary>
    [JsonPropertyName("customResponseBodyKey")]
    public string? CustomResponseBodyKey { get; set; }

    /// <summary>HTTP response code to return (200-599).</summary>
    [JsonPropertyName("responseCode")]
    public double? ResponseCode { get; set; }

    /// <summary>Headers to include in the response. See below.</summary>
    [JsonPropertyName("responseHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseBlockCustomResponseResponseHeader>? ResponseHeader { get; set; }
}

/// <summary>Block the request. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseBlock
{
    /// <summary>Custom response for blocked requests. See below.</summary>
    [JsonPropertyName("customResponse")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseBlockCustomResponse? CustomResponse { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseCaptchaCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseCaptchaCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseCaptchaCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Require CAPTCHA verification. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseCaptcha
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseCaptchaCustomRequestHandling? CustomRequestHandling { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseChallengeCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseChallengeCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseChallengeCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Configuration for the use of the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseChallenge
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseChallengeCustomRequestHandling? CustomRequestHandling { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseCountCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseCountCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseCountCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Count the request without taking action. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseCount
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseCountCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// Action to use instead of the rule&apos;s original action. See below.
/// Action to use in place of the rule action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUse
{
    /// <summary>Allow the request. See below.</summary>
    [JsonPropertyName("allow")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseAllow? Allow { get; set; }

    /// <summary>Block the request. See below.</summary>
    [JsonPropertyName("block")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseBlock? Block { get; set; }

    /// <summary>Require CAPTCHA verification. See below.</summary>
    [JsonPropertyName("captcha")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseCaptcha? Captcha { get; set; }

    /// <summary>Configuration for the use of the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests. See below.</summary>
    [JsonPropertyName("challenge")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseChallenge? Challenge { get; set; }

    /// <summary>Count the request without taking action. See below.</summary>
    [JsonPropertyName("count")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUseCount? Count { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverride
{
    /// <summary>
    /// Action to use instead of the rule&apos;s original action. See below.
    /// Action to use in place of the rule action.
    /// </summary>
    [JsonPropertyName("actionToUse")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverrideActionToUse? ActionToUse { get; set; }

    /// <summary>
    /// Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.
    /// Name of the rule to override.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Managed Rule Group configuration. One of rule_group_reference or managed_rule_group is required. Conflicts with rule_group_reference. See below.
/// Managed rule group configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroup
{
    /// <summary>Additional information that&apos;s used by a managed rule group. Only one rule attribute is allowed in each config. See below.</summary>
    [JsonPropertyName("managedRuleGroupConfigs")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupManagedRuleGroupConfigs? ManagedRuleGroupConfigs { get; set; }

    /// <summary>
    /// Name of the managed rule group.
    /// Name of the managed rule group.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Override actions for specific rules within the rule group. See below.
    /// Action settings to use in place of rule actions configured inside the rule group. You can specify up to 100 overrides.
    /// </summary>
    [JsonPropertyName("ruleActionOverride")]
    public IList<V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroupRuleActionOverride>? RuleActionOverride { get; set; }

    /// <summary>
    /// Name of the managed rule group vendor. For AWS managed rule groups, this is AWS.
    /// Name of the managed rule group vendor.
    /// </summary>
    [JsonPropertyName("vendorName")]
    public string? VendorName { get; set; }

    /// <summary>
    /// Version of the managed rule group. If not specified, the default version is used.
    /// Version of the managed rule group. Omit this to use the default version.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseAllowCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseAllowCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseAllowCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Allow the request. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseAllow
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseAllowCustomRequestHandling? CustomRequestHandling { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponseResponseHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom response for blocked requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponse
{
    /// <summary>Key of a custom response body to use.</summary>
    [JsonPropertyName("customResponseBodyKey")]
    public string? CustomResponseBodyKey { get; set; }

    /// <summary>HTTP response code to return (200-599).</summary>
    [JsonPropertyName("responseCode")]
    public double? ResponseCode { get; set; }

    /// <summary>Headers to include in the response. See below.</summary>
    [JsonPropertyName("responseHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponseResponseHeader>? ResponseHeader { get; set; }
}

/// <summary>Block the request. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseBlock
{
    /// <summary>Custom response for blocked requests. See below.</summary>
    [JsonPropertyName("customResponse")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseBlockCustomResponse? CustomResponse { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseCaptchaCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseCaptchaCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseCaptchaCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Require CAPTCHA verification. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseCaptcha
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseCaptchaCustomRequestHandling? CustomRequestHandling { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseChallengeCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseChallengeCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseChallengeCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Configuration for the use of the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseChallenge
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseChallengeCustomRequestHandling? CustomRequestHandling { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseCountCustomRequestHandlingInsertHeader
{
    /// <summary>Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the response header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Custom handling for counted requests. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseCountCustomRequestHandling
{
    /// <summary>Headers to insert into the request. See below.</summary>
    [JsonPropertyName("insertHeader")]
    public IList<V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseCountCustomRequestHandlingInsertHeader>? InsertHeader { get; set; }
}

/// <summary>Count the request without taking action. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseCount
{
    /// <summary>Custom handling for counted requests. See below.</summary>
    [JsonPropertyName("customRequestHandling")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseCountCustomRequestHandling? CustomRequestHandling { get; set; }
}

/// <summary>
/// Action to use instead of the rule&apos;s original action. See below.
/// Action to use in place of the rule action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUse
{
    /// <summary>Allow the request. See below.</summary>
    [JsonPropertyName("allow")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseAllow? Allow { get; set; }

    /// <summary>Block the request. See below.</summary>
    [JsonPropertyName("block")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseBlock? Block { get; set; }

    /// <summary>Require CAPTCHA verification. See below.</summary>
    [JsonPropertyName("captcha")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseCaptcha? Captcha { get; set; }

    /// <summary>Configuration for the use of the AWSManagedRulesAntiDDoSRuleSet rules ChallengeAllDuringEvent and ChallengeDDoSRequests. See below.</summary>
    [JsonPropertyName("challenge")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseChallenge? Challenge { get; set; }

    /// <summary>Count the request without taking action. See below.</summary>
    [JsonPropertyName("count")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUseCount? Count { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverride
{
    /// <summary>
    /// Action to use instead of the rule&apos;s original action. See below.
    /// Action to use in place of the rule action.
    /// </summary>
    [JsonPropertyName("actionToUse")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverrideActionToUse? ActionToUse { get; set; }

    /// <summary>
    /// Name of the rule to override within the rule group. Verify the name carefully. With managed rule groups, WAF silently ignores any override that uses an invalid rule name. With customer-owned rule groups, invalid rule names in your overrides will cause web ACL updates to fail. An invalid rule name is any name that doesn&apos;t exactly match the case-sensitive name of an existing rule in the rule group.
    /// Name of the rule to override.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Custom Rule Group reference configuration. One of rule_group_reference or managed_rule_group is required. Conflicts with managed_rule_group. See below.
/// Rule Group reference configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReference
{
    /// <summary>
    /// ARN of the Rule Group to associate with the Web ACL.
    /// ARN of the Rule Group to associate with the Web ACL.
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// Override actions for specific rules within the rule group. See below.
    /// Action settings to use in place of rule actions configured inside the rule group. You can specify up to 100 overrides.
    /// </summary>
    [JsonPropertyName("ruleActionOverride")]
    public IList<V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReferenceRuleActionOverride>? RuleActionOverride { get; set; }
}

/// <summary>
/// Defines and enables Amazon CloudWatch metrics and web request sample collection. See below.
/// Visibility configuration for the rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProviderVisibilityConfig
{
    /// <summary>
    /// Whether the associated resource sends metrics to CloudWatch. For the list of available metrics, see AWS WAF Metrics.
    /// Indicates whether the rule is available for use in the metrics for the web ACL.
    /// </summary>
    [JsonPropertyName("cloudwatchMetricsEnabled")]
    public bool? CloudwatchMetricsEnabled { get; set; }

    /// <summary>
    /// Friendly name of the CloudWatch metric. The name can contain only alphanumeric characters (A-Z, a-z, 0-9) hyphen(-) and underscore (_), with length from one to 128 characters. It can&apos;t contain whitespace or metric names reserved for AWS WAF, for example All and Default_Action.
    /// A name for the metrics for this rule.
    /// </summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>
    /// Whether AWS WAF should store a sampling of the web requests that match the rules. You can view the sampled requests through the AWS WAF console.
    /// Indicates whether to store a sampling of the web requests that match the rule.
    /// </summary>
    [JsonPropertyName("sampledRequestsEnabled")]
    public bool? SampledRequestsEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusAtProvider
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Managed Rule Group configuration. One of rule_group_reference or managed_rule_group is required. Conflicts with rule_group_reference. See below.
    /// Managed rule group configuration.
    /// </summary>
    [JsonPropertyName("managedRuleGroup")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderManagedRuleGroup? ManagedRuleGroup { get; set; }

    /// <summary>
    /// Override action for the rule group. Valid values are none and count. Defaults to none. When set to count, the actions defined in the rule group rules are overridden to count matches instead of blocking or allowing requests.
    /// Override action for the rule group. Valid values are &apos;none&apos; and &apos;count&apos;. Defaults to &apos;none&apos;.
    /// </summary>
    [JsonPropertyName("overrideAction")]
    public string? OverrideAction { get; set; }

    /// <summary>
    /// Priority of the rule within the Web ACL. Rules are evaluated in order of priority, with lower numbers evaluated first.
    /// Priority of the rule within the Web ACL.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Custom Rule Group reference configuration. One of rule_group_reference or managed_rule_group is required. Conflicts with managed_rule_group. See below.
    /// Rule Group reference configuration.
    /// </summary>
    [JsonPropertyName("ruleGroupReference")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderRuleGroupReference? RuleGroupReference { get; set; }

    /// <summary>
    /// Name of the rule to create in the Web ACL that references the rule group. Must be between 1 and 128 characters.
    /// Name of the rule to create in the Web ACL that references the rule group.
    /// </summary>
    [JsonPropertyName("ruleName")]
    public string? RuleName { get; set; }

    /// <summary>
    /// Defines and enables Amazon CloudWatch metrics and web request sample collection. See below.
    /// Visibility configuration for the rule.
    /// </summary>
    [JsonPropertyName("visibilityConfig")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProviderVisibilityConfig? VisibilityConfig { get; set; }

    /// <summary>
    /// ARN of the Web ACL to associate the Rule Group with.
    /// ARN of the Web ACL to associate the Rule Group with.
    /// </summary>
    [JsonPropertyName("webAclArn")]
    public string? WebAclArn { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatusConditions
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

/// <summary>WebACLRuleGroupAssociationStatus defines the observed state of WebACLRuleGroupAssociation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLRuleGroupAssociationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1WebACLRuleGroupAssociationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WebACLRuleGroupAssociationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>WebACLRuleGroupAssociation is the Schema for the WebACLRuleGroupAssociations API. Associates a WAFv2 Rule Group with a Web ACL by adding a rule that references the Rule Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebACLRuleGroupAssociation : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WebACLRuleGroupAssociationSpec>, IStatus<V1beta1WebACLRuleGroupAssociationStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebACLRuleGroupAssociation";
    public const string KubeGroup = "wafv2.aws.upbound.io";
    public const string KubePluralName = "webaclrulegroupassociations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "wafv2.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WebACLRuleGroupAssociation";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WebACLRuleGroupAssociationSpec defines the desired state of WebACLRuleGroupAssociation</summary>
    [JsonPropertyName("spec")]
    public required V1beta1WebACLRuleGroupAssociationSpec Spec { get; set; }

    /// <summary>WebACLRuleGroupAssociationStatus defines the observed state of WebACLRuleGroupAssociation.</summary>
    [JsonPropertyName("status")]
    public V1beta1WebACLRuleGroupAssociationStatus? Status { get; set; }
}
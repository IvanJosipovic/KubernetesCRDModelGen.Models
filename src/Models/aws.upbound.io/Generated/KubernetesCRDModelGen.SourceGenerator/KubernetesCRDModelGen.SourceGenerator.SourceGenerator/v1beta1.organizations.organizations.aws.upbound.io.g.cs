#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.organizations.aws.upbound.io;
/// <summary>Organization is the Schema for the Organizations API. Provides a resource to create an organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OrganizationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Organization>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OrganizationList";
    public const string KubeGroup = "organizations.aws.upbound.io";
    public const string KubePluralName = "organizations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "organizations.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OrganizationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Organization objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Organization> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrganizationSpecDeletionPolicyEnum>))]
public enum V1beta1OrganizationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecForProvider
{
    /// <summary>List of AWS service principal names for which you want to enable integration with your organization. This is typically in the form of a URL, such as service-abbreviation.amazonaws.com. Organization must have feature_set set to ALL. Some services do not support enablement via this endpoint, see warning in aws docs.</summary>
    [JsonPropertyName("awsServiceAccessPrincipals")]
    public IList<string>? AwsServiceAccessPrincipals { get; set; }

    /// <summary>List of Organizations policy types to enable in the Organization Root. Organization must have feature_set set to ALL. For additional information about valid policy types (e.g., AISERVICES_OPT_OUT_POLICY, BACKUP_POLICY, BEDROCK_POLICY, CHATBOT_POLICY, DECLARATIVE_POLICY_EC2, INSPECTOR_POLICY, RESOURCE_CONTROL_POLICY, S3_POLICY, SECURITYHUB_POLICY, SERVICE_CONTROL_POLICY, TAG_POLICY and UPGRADE_ROLLOUT_POLICY), see the AWS Organizations API Reference. To enable INSPECTOR_POLICY, aws_service_access_principals must include inspector2.amazonaws.com. To enable SECURITYHUB_POLICY, aws_service_access_principals must include securityhub.amazonaws.com.</summary>
    [JsonPropertyName("enabledPolicyTypes")]
    public IList<string>? EnabledPolicyTypes { get; set; }

    /// <summary>Specify ALL (default) or CONSOLIDATED_BILLING.</summary>
    [JsonPropertyName("featureSet")]
    public string? FeatureSet { get; set; }

    /// <summary>Return (as attributes) only the results of the DescribeOrganization API to avoid API limits. When configured to true only the arn, feature_set, master_account_arn, master_account_email and master_account_id attributes will be returned. All others will be empty. Default: false.</summary>
    [JsonPropertyName("returnOrganizationOnly")]
    public bool? ReturnOrganizationOnly { get; set; }
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
public partial class V1beta1OrganizationSpecInitProvider
{
    /// <summary>List of AWS service principal names for which you want to enable integration with your organization. This is typically in the form of a URL, such as service-abbreviation.amazonaws.com. Organization must have feature_set set to ALL. Some services do not support enablement via this endpoint, see warning in aws docs.</summary>
    [JsonPropertyName("awsServiceAccessPrincipals")]
    public IList<string>? AwsServiceAccessPrincipals { get; set; }

    /// <summary>List of Organizations policy types to enable in the Organization Root. Organization must have feature_set set to ALL. For additional information about valid policy types (e.g., AISERVICES_OPT_OUT_POLICY, BACKUP_POLICY, BEDROCK_POLICY, CHATBOT_POLICY, DECLARATIVE_POLICY_EC2, INSPECTOR_POLICY, RESOURCE_CONTROL_POLICY, S3_POLICY, SECURITYHUB_POLICY, SERVICE_CONTROL_POLICY, TAG_POLICY and UPGRADE_ROLLOUT_POLICY), see the AWS Organizations API Reference. To enable INSPECTOR_POLICY, aws_service_access_principals must include inspector2.amazonaws.com. To enable SECURITYHUB_POLICY, aws_service_access_principals must include securityhub.amazonaws.com.</summary>
    [JsonPropertyName("enabledPolicyTypes")]
    public IList<string>? EnabledPolicyTypes { get; set; }

    /// <summary>Specify ALL (default) or CONSOLIDATED_BILLING.</summary>
    [JsonPropertyName("featureSet")]
    public string? FeatureSet { get; set; }

    /// <summary>Return (as attributes) only the results of the DescribeOrganization API to avoid API limits. When configured to true only the arn, feature_set, master_account_arn, master_account_email and master_account_id attributes will be returned. All others will be empty. Default: false.</summary>
    [JsonPropertyName("returnOrganizationOnly")]
    public bool? ReturnOrganizationOnly { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrganizationSpecManagementPoliciesEnum>))]
public enum V1beta1OrganizationSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrganizationSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1OrganizationSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrganizationSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1OrganizationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1OrganizationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1OrganizationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OrganizationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>OrganizationSpec defines the desired state of Organization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationSpec
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
    public V1beta1OrganizationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1OrganizationSpecForProvider ForProvider { get; set; }

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
    public V1beta1OrganizationSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1OrganizationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1OrganizationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1OrganizationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationStatusAtProviderAccounts
{
    /// <summary>ARN of the account.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Email of the account.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Identifier of the account.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Method by which the account joined the organization.</summary>
    [JsonPropertyName("joinedMethod")]
    public string? JoinedMethod { get; set; }

    /// <summary>Date the account became a part of the organization.</summary>
    [JsonPropertyName("joinedTimestamp")]
    public string? JoinedTimestamp { get; set; }

    /// <summary>Name of the account.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>State of the account.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>(Deprecated use state instead) Status of the account.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationStatusAtProviderNonMasterAccounts
{
    /// <summary>ARN of the account.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Email of the account.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Identifier of the account.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Method by which the account joined the organization.</summary>
    [JsonPropertyName("joinedMethod")]
    public string? JoinedMethod { get; set; }

    /// <summary>Date the account became a part of the organization.</summary>
    [JsonPropertyName("joinedTimestamp")]
    public string? JoinedTimestamp { get; set; }

    /// <summary>Name of the account.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>State of the account.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>(Deprecated use state instead) Status of the account.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationStatusAtProviderRootsPolicyTypes
{
    /// <summary>(Deprecated use state instead) Status of the account.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationStatusAtProviderRoots
{
    /// <summary>ARN of the account.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Identifier of the account.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the account.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>List of policy types enabled for this root. All elements have these attributes:</summary>
    [JsonPropertyName("policyTypes")]
    public IList<V1beta1OrganizationStatusAtProviderRootsPolicyTypes>? PolicyTypes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationStatusAtProvider
{
    /// <summary>List of organization accounts including the master account. For a list excluding the master account, see the non_master_accounts attribute. All elements have these attributes:</summary>
    [JsonPropertyName("accounts")]
    public IList<V1beta1OrganizationStatusAtProviderAccounts>? Accounts { get; set; }

    /// <summary>ARN of the account.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>List of AWS service principal names for which you want to enable integration with your organization. This is typically in the form of a URL, such as service-abbreviation.amazonaws.com. Organization must have feature_set set to ALL. Some services do not support enablement via this endpoint, see warning in aws docs.</summary>
    [JsonPropertyName("awsServiceAccessPrincipals")]
    public IList<string>? AwsServiceAccessPrincipals { get; set; }

    /// <summary>List of Organizations policy types to enable in the Organization Root. Organization must have feature_set set to ALL. For additional information about valid policy types (e.g., AISERVICES_OPT_OUT_POLICY, BACKUP_POLICY, BEDROCK_POLICY, CHATBOT_POLICY, DECLARATIVE_POLICY_EC2, INSPECTOR_POLICY, RESOURCE_CONTROL_POLICY, S3_POLICY, SECURITYHUB_POLICY, SERVICE_CONTROL_POLICY, TAG_POLICY and UPGRADE_ROLLOUT_POLICY), see the AWS Organizations API Reference. To enable INSPECTOR_POLICY, aws_service_access_principals must include inspector2.amazonaws.com. To enable SECURITYHUB_POLICY, aws_service_access_principals must include securityhub.amazonaws.com.</summary>
    [JsonPropertyName("enabledPolicyTypes")]
    public IList<string>? EnabledPolicyTypes { get; set; }

    /// <summary>Specify ALL (default) or CONSOLIDATED_BILLING.</summary>
    [JsonPropertyName("featureSet")]
    public string? FeatureSet { get; set; }

    /// <summary>Identifier of the account.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN of the master account.</summary>
    [JsonPropertyName("masterAccountArn")]
    public string? MasterAccountArn { get; set; }

    /// <summary>Email address of the master account.</summary>
    [JsonPropertyName("masterAccountEmail")]
    public string? MasterAccountEmail { get; set; }

    /// <summary>Identifier of the master account.</summary>
    [JsonPropertyName("masterAccountId")]
    public string? MasterAccountId { get; set; }

    /// <summary>Name of the master account.</summary>
    [JsonPropertyName("masterAccountName")]
    public string? MasterAccountName { get; set; }

    /// <summary>List of organization accounts excluding the master account. For a list including the master account, see the accounts attribute. All elements have these attributes:</summary>
    [JsonPropertyName("nonMasterAccounts")]
    public IList<V1beta1OrganizationStatusAtProviderNonMasterAccounts>? NonMasterAccounts { get; set; }

    /// <summary>Return (as attributes) only the results of the DescribeOrganization API to avoid API limits. When configured to true only the arn, feature_set, master_account_arn, master_account_email and master_account_id attributes will be returned. All others will be empty. Default: false.</summary>
    [JsonPropertyName("returnOrganizationOnly")]
    public bool? ReturnOrganizationOnly { get; set; }

    /// <summary>List of organization roots. All elements have these attributes:</summary>
    [JsonPropertyName("roots")]
    public IList<V1beta1OrganizationStatusAtProviderRoots>? Roots { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationStatusConditions
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

/// <summary>OrganizationStatus defines the observed state of Organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrganizationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1OrganizationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1OrganizationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Organization is the Schema for the Organizations API. Provides a resource to create an organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Organization : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1OrganizationSpec>, IStatus<V1beta1OrganizationStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Organization";
    public const string KubeGroup = "organizations.aws.upbound.io";
    public const string KubePluralName = "organizations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "organizations.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Organization";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OrganizationSpec defines the desired state of Organization</summary>
    [JsonPropertyName("spec")]
    public required V1beta1OrganizationSpec Spec { get; set; }

    /// <summary>OrganizationStatus defines the observed state of Organization.</summary>
    [JsonPropertyName("status")]
    public V1beta1OrganizationStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.settings.databricks.crossplane.io;
/// <summary>AccountNetworkPolicy is the Schema for the AccountNetworkPolicys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccountNetworkPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AccountNetworkPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccountNetworkPolicyList";
    public const string KubeGroup = "settings.databricks.crossplane.io";
    public const string KubePluralName = "accountnetworkpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "settings.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccountNetworkPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1AccountNetworkPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1AccountNetworkPolicy> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccountNetworkPolicySpecDeletionPolicyEnum>))]
public enum V1beta1AccountNetworkPolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderEgressNetworkAccessAllowedDatabricksDestinations
{
    /// <summary>(list of integer, optional)</summary>
    [JsonPropertyName("workspaceIds")]
    public IList<double>? WorkspaceIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderEgressNetworkAccessAllowedInternetDestinations
{
    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>The type of internet destination. Currently only DNS_NAME is supported. Possible values are: DNS_NAME</summary>
    [JsonPropertyName("internetDestinationType")]
    public string? InternetDestinationType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderEgressNetworkAccessAllowedStorageDestinations
{
    /// <summary>The Azure storage account name</summary>
    [JsonPropertyName("azureStorageAccount")]
    public string? AzureStorageAccount { get; set; }

    /// <summary>The Azure storage service type (blob, dfs, etc.)</summary>
    [JsonPropertyName("azureStorageService")]
    public string? AzureStorageService { get; set; }

    /// <summary>(string, optional)</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>(string, optional)</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The type of storage destination. Possible values are: AWS_S3, AZURE_STORAGE, GOOGLE_CLOUD_STORAGE</summary>
    [JsonPropertyName("storageDestinationType")]
    public string? StorageDestinationType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderEgressNetworkAccessBlockedInternetDestinations
{
    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>The type of internet destination. Currently only DNS_NAME is supported. Possible values are: DNS_NAME</summary>
    [JsonPropertyName("internetDestinationType")]
    public string? InternetDestinationType { get; set; }
}

/// <summary>Optional. When policy_enforcement is not provided, we default to ENFORCE_MODE_ALL_SERVICES</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderEgressNetworkAccessPolicyEnforcement
{
    /// <summary>
    /// When empty, it means dry run for all products.
    /// When non-empty, it means dry run for specific products and for the other products, they will run in enforced mode
    /// </summary>
    [JsonPropertyName("dryRunModeProductFilter")]
    public IList<string>? DryRunModeProductFilter { get; set; }

    /// <summary>
    /// The mode of policy enforcement. ENFORCED blocks traffic that violates policy,
    /// while DRY_RUN only logs violations without blocking. When not specified,
    /// defaults to ENFORCED. Possible values are: DRY_RUN, ENFORCED
    /// </summary>
    [JsonPropertyName("enforcementMode")]
    public string? EnforcementMode { get; set; }
}

/// <summary>The access policy enforced for egress traffic to the internet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderEgressNetworkAccess
{
    /// <summary>
    /// List of Databricks workspace destinations that serverless workloads are
    /// allowed to access when in RESTRICTED_ACCESS mode
    /// </summary>
    [JsonPropertyName("allowedDatabricksDestinations")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderEgressNetworkAccessAllowedDatabricksDestinations>? AllowedDatabricksDestinations { get; set; }

    /// <summary>List of internet destinations that serverless workloads are allowed to access when in RESTRICTED_ACCESS mode</summary>
    [JsonPropertyName("allowedInternetDestinations")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderEgressNetworkAccessAllowedInternetDestinations>? AllowedInternetDestinations { get; set; }

    /// <summary>List of storage destinations that serverless workloads are allowed to access when in RESTRICTED_ACCESS mode</summary>
    [JsonPropertyName("allowedStorageDestinations")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderEgressNetworkAccessAllowedStorageDestinations>? AllowedStorageDestinations { get; set; }

    /// <summary>
    /// List of internet destinations that serverless workloads are blocked from accessing.
    /// These destinations are enforced when restriction mode is RESTRICTED_ACCESS or DRY_RUN.
    /// Currently supports DNS_NAME type only; IP_RANGE support is planned
    /// </summary>
    [JsonPropertyName("blockedInternetDestinations")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderEgressNetworkAccessBlockedInternetDestinations>? BlockedInternetDestinations { get; set; }

    /// <summary>Optional. When policy_enforcement is not provided, we default to ENFORCE_MODE_ALL_SERVICES</summary>
    [JsonPropertyName("policyEnforcement")]
    public V1beta1AccountNetworkPolicySpecForProviderEgressNetworkAccessPolicyEnforcement? PolicyEnforcement { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

/// <summary>The network policies applying for egress traffic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderEgress
{
    /// <summary>The access policy enforced for egress traffic to the internet</summary>
    [JsonPropertyName("networkAccess")]
    public V1beta1AccountNetworkPolicySpecForProviderEgressNetworkAccess? NetworkAccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Specific source workspace IDs to match</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesOriginSelectedWorkspaces
{
    /// <summary>(list of integer, optional)</summary>
    [JsonPropertyName("workspaceIds")]
    public IList<double>? WorkspaceIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesOrigin
{
    /// <summary>Matches all source workspaces</summary>
    [JsonPropertyName("allSourceWorkspaces")]
    public bool? AllSourceWorkspaces { get; set; }

    /// <summary>Specific source workspace IDs to match</summary>
    [JsonPropertyName("selectedWorkspaces")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesOriginSelectedWorkspaces? SelectedWorkspaces { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRulesOrigin? Origin { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Specific source workspace IDs to match</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesOriginSelectedWorkspaces
{
    /// <summary>(list of integer, optional)</summary>
    [JsonPropertyName("workspaceIds")]
    public IList<double>? WorkspaceIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesOrigin
{
    /// <summary>Matches all source workspaces</summary>
    [JsonPropertyName("allSourceWorkspaces")]
    public bool? AllSourceWorkspaces { get; set; }

    /// <summary>Specific source workspace IDs to match</summary>
    [JsonPropertyName("selectedWorkspaces")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesOriginSelectedWorkspaces? SelectedWorkspaces { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRulesOrigin? Origin { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceAccess, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccess
{
    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("allowRules")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessAllowRules>? AllowRules { get; set; }

    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("denyRules")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccessDenyRules>? DenyRules { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesOriginEndpoints
{
    /// <summary>The IDs of the registered endpoints. Must contain at least one endpoint ID</summary>
    [JsonPropertyName("endpointIds")]
    public IList<string>? EndpointIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesOrigin
{
    /// <summary>
    /// Matches requests arriving over any private connectivity, including registered
    /// endpoints and the workspace&apos;s Azure Private Link (ui-api) endpoints.
    /// Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allPrivateAccess")]
    public bool? AllPrivateAccess { get; set; }

    /// <summary>
    /// Matches requests arriving through any endpoint registered to the account.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allRegisteredEndpoints")]
    public bool? AllRegisteredEndpoints { get; set; }

    /// <summary>
    /// Matches requests arriving through the workspace&apos;s Azure Private Link (ui-api)
    /// endpoints. Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("azureWorkspacePrivateLink")]
    public bool? AzureWorkspacePrivateLink { get; set; }

    /// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
    [JsonPropertyName("endpoints")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesOriginEndpoints? Endpoints { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRulesOrigin? Origin { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesOriginEndpoints
{
    /// <summary>The IDs of the registered endpoints. Must contain at least one endpoint ID</summary>
    [JsonPropertyName("endpointIds")]
    public IList<string>? EndpointIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesOrigin
{
    /// <summary>
    /// Matches requests arriving over any private connectivity, including registered
    /// endpoints and the workspace&apos;s Azure Private Link (ui-api) endpoints.
    /// Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allPrivateAccess")]
    public bool? AllPrivateAccess { get; set; }

    /// <summary>
    /// Matches requests arriving through any endpoint registered to the account.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allRegisteredEndpoints")]
    public bool? AllRegisteredEndpoints { get; set; }

    /// <summary>
    /// Matches requests arriving through the workspace&apos;s Azure Private Link (ui-api)
    /// endpoints. Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("azureWorkspacePrivateLink")]
    public bool? AzureWorkspacePrivateLink { get; set; }

    /// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
    [JsonPropertyName("endpoints")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesOriginEndpoints? Endpoints { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRulesOrigin? Origin { get; set; }
}

/// <summary>
/// The network policy restrictions for private access.
/// Configures how requests arriving over private connectivity are governed
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccess
{
    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("allowRules")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessAllowRules>? AllowRules { get; set; }

    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("denyRules")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccessDenyRules>? DenyRules { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Excluded means: all public IP ranges except this one</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesOriginExcludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>Will not allow IP ranges with private IPs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesOriginIncludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesOrigin
{
    /// <summary>Matches all IPv4 and IPv6 ranges (both public and private)</summary>
    [JsonPropertyName("allIpRanges")]
    public bool? AllIpRanges { get; set; }

    /// <summary>Excluded means: all public IP ranges except this one</summary>
    [JsonPropertyName("excludedIpRanges")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesOriginExcludedIpRanges? ExcludedIpRanges { get; set; }

    /// <summary>Will not allow IP ranges with private IPs</summary>
    [JsonPropertyName("includedIpRanges")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesOriginIncludedIpRanges? IncludedIpRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRulesOrigin? Origin { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Excluded means: all public IP ranges except this one</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesOriginExcludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>Will not allow IP ranges with private IPs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesOriginIncludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesOrigin
{
    /// <summary>Matches all IPv4 and IPv6 ranges (both public and private)</summary>
    [JsonPropertyName("allIpRanges")]
    public bool? AllIpRanges { get; set; }

    /// <summary>Excluded means: all public IP ranges except this one</summary>
    [JsonPropertyName("excludedIpRanges")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesOriginExcludedIpRanges? ExcludedIpRanges { get; set; }

    /// <summary>Will not allow IP ranges with private IPs</summary>
    [JsonPropertyName("includedIpRanges")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesOriginIncludedIpRanges? IncludedIpRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRulesOrigin? Origin { get; set; }
}

/// <summary>
/// The network policy restrictions for public access to the workspace.
/// Configures how public internet traffic is allowed or denied access
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccess
{
    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("allowRules")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessAllowRules>? AllowRules { get; set; }

    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("denyRules")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccessDenyRules>? DenyRules { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

/// <summary>The network policies applying for ingress traffic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngress
{
    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceAccess, optional)</summary>
    [JsonPropertyName("crossWorkspaceAccess")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressCrossWorkspaceAccess? CrossWorkspaceAccess { get; set; }

    /// <summary>
    /// The network policy restrictions for private access.
    /// Configures how requests arriving over private connectivity are governed
    /// </summary>
    [JsonPropertyName("privateAccess")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPrivateAccess? PrivateAccess { get; set; }

    /// <summary>
    /// The network policy restrictions for public access to the workspace.
    /// Configures how public internet traffic is allowed or denied access
    /// </summary>
    [JsonPropertyName("publicAccess")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressPublicAccess? PublicAccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Specific source workspace IDs to match</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesOriginSelectedWorkspaces
{
    /// <summary>(list of integer, optional)</summary>
    [JsonPropertyName("workspaceIds")]
    public IList<double>? WorkspaceIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesOrigin
{
    /// <summary>Matches all source workspaces</summary>
    [JsonPropertyName("allSourceWorkspaces")]
    public bool? AllSourceWorkspaces { get; set; }

    /// <summary>Specific source workspace IDs to match</summary>
    [JsonPropertyName("selectedWorkspaces")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesOriginSelectedWorkspaces? SelectedWorkspaces { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRulesOrigin? Origin { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Specific source workspace IDs to match</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesOriginSelectedWorkspaces
{
    /// <summary>(list of integer, optional)</summary>
    [JsonPropertyName("workspaceIds")]
    public IList<double>? WorkspaceIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesOrigin
{
    /// <summary>Matches all source workspaces</summary>
    [JsonPropertyName("allSourceWorkspaces")]
    public bool? AllSourceWorkspaces { get; set; }

    /// <summary>Specific source workspace IDs to match</summary>
    [JsonPropertyName("selectedWorkspaces")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesOriginSelectedWorkspaces? SelectedWorkspaces { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRulesOrigin? Origin { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceAccess, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccess
{
    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("allowRules")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessAllowRules>? AllowRules { get; set; }

    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("denyRules")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccessDenyRules>? DenyRules { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesOriginEndpoints
{
    /// <summary>The IDs of the registered endpoints. Must contain at least one endpoint ID</summary>
    [JsonPropertyName("endpointIds")]
    public IList<string>? EndpointIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesOrigin
{
    /// <summary>
    /// Matches requests arriving over any private connectivity, including registered
    /// endpoints and the workspace&apos;s Azure Private Link (ui-api) endpoints.
    /// Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allPrivateAccess")]
    public bool? AllPrivateAccess { get; set; }

    /// <summary>
    /// Matches requests arriving through any endpoint registered to the account.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allRegisteredEndpoints")]
    public bool? AllRegisteredEndpoints { get; set; }

    /// <summary>
    /// Matches requests arriving through the workspace&apos;s Azure Private Link (ui-api)
    /// endpoints. Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("azureWorkspacePrivateLink")]
    public bool? AzureWorkspacePrivateLink { get; set; }

    /// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
    [JsonPropertyName("endpoints")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesOriginEndpoints? Endpoints { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRulesOrigin? Origin { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesOriginEndpoints
{
    /// <summary>The IDs of the registered endpoints. Must contain at least one endpoint ID</summary>
    [JsonPropertyName("endpointIds")]
    public IList<string>? EndpointIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesOrigin
{
    /// <summary>
    /// Matches requests arriving over any private connectivity, including registered
    /// endpoints and the workspace&apos;s Azure Private Link (ui-api) endpoints.
    /// Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allPrivateAccess")]
    public bool? AllPrivateAccess { get; set; }

    /// <summary>
    /// Matches requests arriving through any endpoint registered to the account.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allRegisteredEndpoints")]
    public bool? AllRegisteredEndpoints { get; set; }

    /// <summary>
    /// Matches requests arriving through the workspace&apos;s Azure Private Link (ui-api)
    /// endpoints. Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("azureWorkspacePrivateLink")]
    public bool? AzureWorkspacePrivateLink { get; set; }

    /// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
    [JsonPropertyName("endpoints")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesOriginEndpoints? Endpoints { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRulesOrigin? Origin { get; set; }
}

/// <summary>
/// The network policy restrictions for private access.
/// Configures how requests arriving over private connectivity are governed
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccess
{
    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("allowRules")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessAllowRules>? AllowRules { get; set; }

    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("denyRules")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccessDenyRules>? DenyRules { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Excluded means: all public IP ranges except this one</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesOriginExcludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>Will not allow IP ranges with private IPs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesOriginIncludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesOrigin
{
    /// <summary>Matches all IPv4 and IPv6 ranges (both public and private)</summary>
    [JsonPropertyName("allIpRanges")]
    public bool? AllIpRanges { get; set; }

    /// <summary>Excluded means: all public IP ranges except this one</summary>
    [JsonPropertyName("excludedIpRanges")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesOriginExcludedIpRanges? ExcludedIpRanges { get; set; }

    /// <summary>Will not allow IP ranges with private IPs</summary>
    [JsonPropertyName("includedIpRanges")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesOriginIncludedIpRanges? IncludedIpRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRulesOrigin? Origin { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Excluded means: all public IP ranges except this one</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesOriginExcludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>Will not allow IP ranges with private IPs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesOriginIncludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesOrigin
{
    /// <summary>Matches all IPv4 and IPv6 ranges (both public and private)</summary>
    [JsonPropertyName("allIpRanges")]
    public bool? AllIpRanges { get; set; }

    /// <summary>Excluded means: all public IP ranges except this one</summary>
    [JsonPropertyName("excludedIpRanges")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesOriginExcludedIpRanges? ExcludedIpRanges { get; set; }

    /// <summary>Will not allow IP ranges with private IPs</summary>
    [JsonPropertyName("includedIpRanges")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesOriginIncludedIpRanges? IncludedIpRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRulesOrigin? Origin { get; set; }
}

/// <summary>
/// The network policy restrictions for public access to the workspace.
/// Configures how public internet traffic is allowed or denied access
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccess
{
    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("allowRules")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessAllowRules>? AllowRules { get; set; }

    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("denyRules")]
    public IList<V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccessDenyRules>? DenyRules { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

/// <summary>
/// The ingress policy for dry run mode. Dry run will always run even if the request
/// is allowed by the ingress policy. When this field is set, the policy will be evaluated
/// and emit logs only without blocking requests
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProviderIngressDryRun
{
    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceAccess, optional)</summary>
    [JsonPropertyName("crossWorkspaceAccess")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunCrossWorkspaceAccess? CrossWorkspaceAccess { get; set; }

    /// <summary>
    /// The network policy restrictions for private access.
    /// Configures how requests arriving over private connectivity are governed
    /// </summary>
    [JsonPropertyName("privateAccess")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPrivateAccess? PrivateAccess { get; set; }

    /// <summary>
    /// The network policy restrictions for public access to the workspace.
    /// Configures how public internet traffic is allowed or denied access
    /// </summary>
    [JsonPropertyName("publicAccess")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRunPublicAccess? PublicAccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecForProvider
{
    /// <summary>The associated account ID for this Network Policy object</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The network policies applying for egress traffic</summary>
    [JsonPropertyName("egress")]
    public V1beta1AccountNetworkPolicySpecForProviderEgress? Egress { get; set; }

    /// <summary>The network policies applying for ingress traffic</summary>
    [JsonPropertyName("ingress")]
    public V1beta1AccountNetworkPolicySpecForProviderIngress? Ingress { get; set; }

    /// <summary>
    /// The ingress policy for dry run mode. Dry run will always run even if the request
    /// is allowed by the ingress policy. When this field is set, the policy will be evaluated
    /// and emit logs only without blocking requests
    /// </summary>
    [JsonPropertyName("ingressDryRun")]
    public V1beta1AccountNetworkPolicySpecForProviderIngressDryRun? IngressDryRun { get; set; }

    /// <summary>The unique identifier for the network policy</summary>
    [JsonPropertyName("networkPolicyId")]
    public string? NetworkPolicyId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderEgressNetworkAccessAllowedDatabricksDestinations
{
    /// <summary>(list of integer, optional)</summary>
    [JsonPropertyName("workspaceIds")]
    public IList<double>? WorkspaceIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderEgressNetworkAccessAllowedInternetDestinations
{
    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>The type of internet destination. Currently only DNS_NAME is supported. Possible values are: DNS_NAME</summary>
    [JsonPropertyName("internetDestinationType")]
    public string? InternetDestinationType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderEgressNetworkAccessAllowedStorageDestinations
{
    /// <summary>The Azure storage account name</summary>
    [JsonPropertyName("azureStorageAccount")]
    public string? AzureStorageAccount { get; set; }

    /// <summary>The Azure storage service type (blob, dfs, etc.)</summary>
    [JsonPropertyName("azureStorageService")]
    public string? AzureStorageService { get; set; }

    /// <summary>(string, optional)</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>(string, optional)</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The type of storage destination. Possible values are: AWS_S3, AZURE_STORAGE, GOOGLE_CLOUD_STORAGE</summary>
    [JsonPropertyName("storageDestinationType")]
    public string? StorageDestinationType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderEgressNetworkAccessBlockedInternetDestinations
{
    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>The type of internet destination. Currently only DNS_NAME is supported. Possible values are: DNS_NAME</summary>
    [JsonPropertyName("internetDestinationType")]
    public string? InternetDestinationType { get; set; }
}

/// <summary>Optional. When policy_enforcement is not provided, we default to ENFORCE_MODE_ALL_SERVICES</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderEgressNetworkAccessPolicyEnforcement
{
    /// <summary>
    /// When empty, it means dry run for all products.
    /// When non-empty, it means dry run for specific products and for the other products, they will run in enforced mode
    /// </summary>
    [JsonPropertyName("dryRunModeProductFilter")]
    public IList<string>? DryRunModeProductFilter { get; set; }

    /// <summary>
    /// The mode of policy enforcement. ENFORCED blocks traffic that violates policy,
    /// while DRY_RUN only logs violations without blocking. When not specified,
    /// defaults to ENFORCED. Possible values are: DRY_RUN, ENFORCED
    /// </summary>
    [JsonPropertyName("enforcementMode")]
    public string? EnforcementMode { get; set; }
}

/// <summary>The access policy enforced for egress traffic to the internet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderEgressNetworkAccess
{
    /// <summary>
    /// List of Databricks workspace destinations that serverless workloads are
    /// allowed to access when in RESTRICTED_ACCESS mode
    /// </summary>
    [JsonPropertyName("allowedDatabricksDestinations")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderEgressNetworkAccessAllowedDatabricksDestinations>? AllowedDatabricksDestinations { get; set; }

    /// <summary>List of internet destinations that serverless workloads are allowed to access when in RESTRICTED_ACCESS mode</summary>
    [JsonPropertyName("allowedInternetDestinations")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderEgressNetworkAccessAllowedInternetDestinations>? AllowedInternetDestinations { get; set; }

    /// <summary>List of storage destinations that serverless workloads are allowed to access when in RESTRICTED_ACCESS mode</summary>
    [JsonPropertyName("allowedStorageDestinations")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderEgressNetworkAccessAllowedStorageDestinations>? AllowedStorageDestinations { get; set; }

    /// <summary>
    /// List of internet destinations that serverless workloads are blocked from accessing.
    /// These destinations are enforced when restriction mode is RESTRICTED_ACCESS or DRY_RUN.
    /// Currently supports DNS_NAME type only; IP_RANGE support is planned
    /// </summary>
    [JsonPropertyName("blockedInternetDestinations")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderEgressNetworkAccessBlockedInternetDestinations>? BlockedInternetDestinations { get; set; }

    /// <summary>Optional. When policy_enforcement is not provided, we default to ENFORCE_MODE_ALL_SERVICES</summary>
    [JsonPropertyName("policyEnforcement")]
    public V1beta1AccountNetworkPolicySpecInitProviderEgressNetworkAccessPolicyEnforcement? PolicyEnforcement { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

/// <summary>The network policies applying for egress traffic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderEgress
{
    /// <summary>The access policy enforced for egress traffic to the internet</summary>
    [JsonPropertyName("networkAccess")]
    public V1beta1AccountNetworkPolicySpecInitProviderEgressNetworkAccess? NetworkAccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Specific source workspace IDs to match</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesOriginSelectedWorkspaces
{
    /// <summary>(list of integer, optional)</summary>
    [JsonPropertyName("workspaceIds")]
    public IList<double>? WorkspaceIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesOrigin
{
    /// <summary>Matches all source workspaces</summary>
    [JsonPropertyName("allSourceWorkspaces")]
    public bool? AllSourceWorkspaces { get; set; }

    /// <summary>Specific source workspace IDs to match</summary>
    [JsonPropertyName("selectedWorkspaces")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesOriginSelectedWorkspaces? SelectedWorkspaces { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRulesOrigin? Origin { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Specific source workspace IDs to match</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesOriginSelectedWorkspaces
{
    /// <summary>(list of integer, optional)</summary>
    [JsonPropertyName("workspaceIds")]
    public IList<double>? WorkspaceIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesOrigin
{
    /// <summary>Matches all source workspaces</summary>
    [JsonPropertyName("allSourceWorkspaces")]
    public bool? AllSourceWorkspaces { get; set; }

    /// <summary>Specific source workspace IDs to match</summary>
    [JsonPropertyName("selectedWorkspaces")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesOriginSelectedWorkspaces? SelectedWorkspaces { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRulesOrigin? Origin { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceAccess, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccess
{
    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("allowRules")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessAllowRules>? AllowRules { get; set; }

    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("denyRules")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccessDenyRules>? DenyRules { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesOriginEndpoints
{
    /// <summary>The IDs of the registered endpoints. Must contain at least one endpoint ID</summary>
    [JsonPropertyName("endpointIds")]
    public IList<string>? EndpointIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesOrigin
{
    /// <summary>
    /// Matches requests arriving over any private connectivity, including registered
    /// endpoints and the workspace&apos;s Azure Private Link (ui-api) endpoints.
    /// Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allPrivateAccess")]
    public bool? AllPrivateAccess { get; set; }

    /// <summary>
    /// Matches requests arriving through any endpoint registered to the account.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allRegisteredEndpoints")]
    public bool? AllRegisteredEndpoints { get; set; }

    /// <summary>
    /// Matches requests arriving through the workspace&apos;s Azure Private Link (ui-api)
    /// endpoints. Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("azureWorkspacePrivateLink")]
    public bool? AzureWorkspacePrivateLink { get; set; }

    /// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
    [JsonPropertyName("endpoints")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesOriginEndpoints? Endpoints { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRulesOrigin? Origin { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesOriginEndpoints
{
    /// <summary>The IDs of the registered endpoints. Must contain at least one endpoint ID</summary>
    [JsonPropertyName("endpointIds")]
    public IList<string>? EndpointIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesOrigin
{
    /// <summary>
    /// Matches requests arriving over any private connectivity, including registered
    /// endpoints and the workspace&apos;s Azure Private Link (ui-api) endpoints.
    /// Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allPrivateAccess")]
    public bool? AllPrivateAccess { get; set; }

    /// <summary>
    /// Matches requests arriving through any endpoint registered to the account.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allRegisteredEndpoints")]
    public bool? AllRegisteredEndpoints { get; set; }

    /// <summary>
    /// Matches requests arriving through the workspace&apos;s Azure Private Link (ui-api)
    /// endpoints. Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("azureWorkspacePrivateLink")]
    public bool? AzureWorkspacePrivateLink { get; set; }

    /// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
    [JsonPropertyName("endpoints")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesOriginEndpoints? Endpoints { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRulesOrigin? Origin { get; set; }
}

/// <summary>
/// The network policy restrictions for private access.
/// Configures how requests arriving over private connectivity are governed
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccess
{
    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("allowRules")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessAllowRules>? AllowRules { get; set; }

    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("denyRules")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccessDenyRules>? DenyRules { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Excluded means: all public IP ranges except this one</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesOriginExcludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>Will not allow IP ranges with private IPs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesOriginIncludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesOrigin
{
    /// <summary>Matches all IPv4 and IPv6 ranges (both public and private)</summary>
    [JsonPropertyName("allIpRanges")]
    public bool? AllIpRanges { get; set; }

    /// <summary>Excluded means: all public IP ranges except this one</summary>
    [JsonPropertyName("excludedIpRanges")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesOriginExcludedIpRanges? ExcludedIpRanges { get; set; }

    /// <summary>Will not allow IP ranges with private IPs</summary>
    [JsonPropertyName("includedIpRanges")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesOriginIncludedIpRanges? IncludedIpRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRulesOrigin? Origin { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Excluded means: all public IP ranges except this one</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesOriginExcludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>Will not allow IP ranges with private IPs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesOriginIncludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesOrigin
{
    /// <summary>Matches all IPv4 and IPv6 ranges (both public and private)</summary>
    [JsonPropertyName("allIpRanges")]
    public bool? AllIpRanges { get; set; }

    /// <summary>Excluded means: all public IP ranges except this one</summary>
    [JsonPropertyName("excludedIpRanges")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesOriginExcludedIpRanges? ExcludedIpRanges { get; set; }

    /// <summary>Will not allow IP ranges with private IPs</summary>
    [JsonPropertyName("includedIpRanges")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesOriginIncludedIpRanges? IncludedIpRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRulesOrigin? Origin { get; set; }
}

/// <summary>
/// The network policy restrictions for public access to the workspace.
/// Configures how public internet traffic is allowed or denied access
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccess
{
    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("allowRules")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessAllowRules>? AllowRules { get; set; }

    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("denyRules")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccessDenyRules>? DenyRules { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

/// <summary>The network policies applying for ingress traffic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngress
{
    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceAccess, optional)</summary>
    [JsonPropertyName("crossWorkspaceAccess")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressCrossWorkspaceAccess? CrossWorkspaceAccess { get; set; }

    /// <summary>
    /// The network policy restrictions for private access.
    /// Configures how requests arriving over private connectivity are governed
    /// </summary>
    [JsonPropertyName("privateAccess")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPrivateAccess? PrivateAccess { get; set; }

    /// <summary>
    /// The network policy restrictions for public access to the workspace.
    /// Configures how public internet traffic is allowed or denied access
    /// </summary>
    [JsonPropertyName("publicAccess")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressPublicAccess? PublicAccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Specific source workspace IDs to match</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesOriginSelectedWorkspaces
{
    /// <summary>(list of integer, optional)</summary>
    [JsonPropertyName("workspaceIds")]
    public IList<double>? WorkspaceIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesOrigin
{
    /// <summary>Matches all source workspaces</summary>
    [JsonPropertyName("allSourceWorkspaces")]
    public bool? AllSourceWorkspaces { get; set; }

    /// <summary>Specific source workspace IDs to match</summary>
    [JsonPropertyName("selectedWorkspaces")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesOriginSelectedWorkspaces? SelectedWorkspaces { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRulesOrigin? Origin { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Specific source workspace IDs to match</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesOriginSelectedWorkspaces
{
    /// <summary>(list of integer, optional)</summary>
    [JsonPropertyName("workspaceIds")]
    public IList<double>? WorkspaceIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesOrigin
{
    /// <summary>Matches all source workspaces</summary>
    [JsonPropertyName("allSourceWorkspaces")]
    public bool? AllSourceWorkspaces { get; set; }

    /// <summary>Specific source workspace IDs to match</summary>
    [JsonPropertyName("selectedWorkspaces")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesOriginSelectedWorkspaces? SelectedWorkspaces { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRulesOrigin? Origin { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceAccess, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccess
{
    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("allowRules")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessAllowRules>? AllowRules { get; set; }

    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("denyRules")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccessDenyRules>? DenyRules { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesOriginEndpoints
{
    /// <summary>The IDs of the registered endpoints. Must contain at least one endpoint ID</summary>
    [JsonPropertyName("endpointIds")]
    public IList<string>? EndpointIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesOrigin
{
    /// <summary>
    /// Matches requests arriving over any private connectivity, including registered
    /// endpoints and the workspace&apos;s Azure Private Link (ui-api) endpoints.
    /// Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allPrivateAccess")]
    public bool? AllPrivateAccess { get; set; }

    /// <summary>
    /// Matches requests arriving through any endpoint registered to the account.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allRegisteredEndpoints")]
    public bool? AllRegisteredEndpoints { get; set; }

    /// <summary>
    /// Matches requests arriving through the workspace&apos;s Azure Private Link (ui-api)
    /// endpoints. Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("azureWorkspacePrivateLink")]
    public bool? AzureWorkspacePrivateLink { get; set; }

    /// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
    [JsonPropertyName("endpoints")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesOriginEndpoints? Endpoints { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRulesOrigin? Origin { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesOriginEndpoints
{
    /// <summary>The IDs of the registered endpoints. Must contain at least one endpoint ID</summary>
    [JsonPropertyName("endpointIds")]
    public IList<string>? EndpointIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesOrigin
{
    /// <summary>
    /// Matches requests arriving over any private connectivity, including registered
    /// endpoints and the workspace&apos;s Azure Private Link (ui-api) endpoints.
    /// Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allPrivateAccess")]
    public bool? AllPrivateAccess { get; set; }

    /// <summary>
    /// Matches requests arriving through any endpoint registered to the account.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allRegisteredEndpoints")]
    public bool? AllRegisteredEndpoints { get; set; }

    /// <summary>
    /// Matches requests arriving through the workspace&apos;s Azure Private Link (ui-api)
    /// endpoints. Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("azureWorkspacePrivateLink")]
    public bool? AzureWorkspacePrivateLink { get; set; }

    /// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
    [JsonPropertyName("endpoints")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesOriginEndpoints? Endpoints { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRulesOrigin? Origin { get; set; }
}

/// <summary>
/// The network policy restrictions for private access.
/// Configures how requests arriving over private connectivity are governed
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccess
{
    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("allowRules")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessAllowRules>? AllowRules { get; set; }

    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("denyRules")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccessDenyRules>? DenyRules { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Excluded means: all public IP ranges except this one</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesOriginExcludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>Will not allow IP ranges with private IPs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesOriginIncludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesOrigin
{
    /// <summary>Matches all IPv4 and IPv6 ranges (both public and private)</summary>
    [JsonPropertyName("allIpRanges")]
    public bool? AllIpRanges { get; set; }

    /// <summary>Excluded means: all public IP ranges except this one</summary>
    [JsonPropertyName("excludedIpRanges")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesOriginExcludedIpRanges? ExcludedIpRanges { get; set; }

    /// <summary>Will not allow IP ranges with private IPs</summary>
    [JsonPropertyName("includedIpRanges")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesOriginIncludedIpRanges? IncludedIpRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRulesOrigin? Origin { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Excluded means: all public IP ranges except this one</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesOriginExcludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>Will not allow IP ranges with private IPs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesOriginIncludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesOrigin
{
    /// <summary>Matches all IPv4 and IPv6 ranges (both public and private)</summary>
    [JsonPropertyName("allIpRanges")]
    public bool? AllIpRanges { get; set; }

    /// <summary>Excluded means: all public IP ranges except this one</summary>
    [JsonPropertyName("excludedIpRanges")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesOriginExcludedIpRanges? ExcludedIpRanges { get; set; }

    /// <summary>Will not allow IP ranges with private IPs</summary>
    [JsonPropertyName("includedIpRanges")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesOriginIncludedIpRanges? IncludedIpRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRulesOrigin? Origin { get; set; }
}

/// <summary>
/// The network policy restrictions for public access to the workspace.
/// Configures how public internet traffic is allowed or denied access
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccess
{
    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("allowRules")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessAllowRules>? AllowRules { get; set; }

    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("denyRules")]
    public IList<V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccessDenyRules>? DenyRules { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

/// <summary>
/// The ingress policy for dry run mode. Dry run will always run even if the request
/// is allowed by the ingress policy. When this field is set, the policy will be evaluated
/// and emit logs only without blocking requests
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProviderIngressDryRun
{
    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceAccess, optional)</summary>
    [JsonPropertyName("crossWorkspaceAccess")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunCrossWorkspaceAccess? CrossWorkspaceAccess { get; set; }

    /// <summary>
    /// The network policy restrictions for private access.
    /// Configures how requests arriving over private connectivity are governed
    /// </summary>
    [JsonPropertyName("privateAccess")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPrivateAccess? PrivateAccess { get; set; }

    /// <summary>
    /// The network policy restrictions for public access to the workspace.
    /// Configures how public internet traffic is allowed or denied access
    /// </summary>
    [JsonPropertyName("publicAccess")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRunPublicAccess? PublicAccess { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecInitProvider
{
    /// <summary>The associated account ID for this Network Policy object</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The network policies applying for egress traffic</summary>
    [JsonPropertyName("egress")]
    public V1beta1AccountNetworkPolicySpecInitProviderEgress? Egress { get; set; }

    /// <summary>The network policies applying for ingress traffic</summary>
    [JsonPropertyName("ingress")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngress? Ingress { get; set; }

    /// <summary>
    /// The ingress policy for dry run mode. Dry run will always run even if the request
    /// is allowed by the ingress policy. When this field is set, the policy will be evaluated
    /// and emit logs only without blocking requests
    /// </summary>
    [JsonPropertyName("ingressDryRun")]
    public V1beta1AccountNetworkPolicySpecInitProviderIngressDryRun? IngressDryRun { get; set; }

    /// <summary>The unique identifier for the network policy</summary>
    [JsonPropertyName("networkPolicyId")]
    public string? NetworkPolicyId { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccountNetworkPolicySpecManagementPoliciesEnum>))]
public enum V1beta1AccountNetworkPolicySpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccountNetworkPolicySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1AccountNetworkPolicySpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AccountNetworkPolicySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1AccountNetworkPolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AccountNetworkPolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AccountNetworkPolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AccountNetworkPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AccountNetworkPolicySpec defines the desired state of AccountNetworkPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicySpec
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
    public V1beta1AccountNetworkPolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1AccountNetworkPolicySpecForProvider ForProvider { get; set; }

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
    public V1beta1AccountNetworkPolicySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1AccountNetworkPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AccountNetworkPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AccountNetworkPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderEgressNetworkAccessAllowedDatabricksDestinations
{
    /// <summary>(list of integer, optional)</summary>
    [JsonPropertyName("workspaceIds")]
    public IList<double>? WorkspaceIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderEgressNetworkAccessAllowedInternetDestinations
{
    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>The type of internet destination. Currently only DNS_NAME is supported. Possible values are: DNS_NAME</summary>
    [JsonPropertyName("internetDestinationType")]
    public string? InternetDestinationType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderEgressNetworkAccessAllowedStorageDestinations
{
    /// <summary>The Azure storage account name</summary>
    [JsonPropertyName("azureStorageAccount")]
    public string? AzureStorageAccount { get; set; }

    /// <summary>The Azure storage service type (blob, dfs, etc.)</summary>
    [JsonPropertyName("azureStorageService")]
    public string? AzureStorageService { get; set; }

    /// <summary>(string, optional)</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>(string, optional)</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The type of storage destination. Possible values are: AWS_S3, AZURE_STORAGE, GOOGLE_CLOUD_STORAGE</summary>
    [JsonPropertyName("storageDestinationType")]
    public string? StorageDestinationType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderEgressNetworkAccessBlockedInternetDestinations
{
    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>The type of internet destination. Currently only DNS_NAME is supported. Possible values are: DNS_NAME</summary>
    [JsonPropertyName("internetDestinationType")]
    public string? InternetDestinationType { get; set; }
}

/// <summary>Optional. When policy_enforcement is not provided, we default to ENFORCE_MODE_ALL_SERVICES</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderEgressNetworkAccessPolicyEnforcement
{
    /// <summary>
    /// When empty, it means dry run for all products.
    /// When non-empty, it means dry run for specific products and for the other products, they will run in enforced mode
    /// </summary>
    [JsonPropertyName("dryRunModeProductFilter")]
    public IList<string>? DryRunModeProductFilter { get; set; }

    /// <summary>
    /// The mode of policy enforcement. ENFORCED blocks traffic that violates policy,
    /// while DRY_RUN only logs violations without blocking. When not specified,
    /// defaults to ENFORCED. Possible values are: DRY_RUN, ENFORCED
    /// </summary>
    [JsonPropertyName("enforcementMode")]
    public string? EnforcementMode { get; set; }
}

/// <summary>The access policy enforced for egress traffic to the internet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderEgressNetworkAccess
{
    /// <summary>
    /// List of Databricks workspace destinations that serverless workloads are
    /// allowed to access when in RESTRICTED_ACCESS mode
    /// </summary>
    [JsonPropertyName("allowedDatabricksDestinations")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderEgressNetworkAccessAllowedDatabricksDestinations>? AllowedDatabricksDestinations { get; set; }

    /// <summary>List of internet destinations that serverless workloads are allowed to access when in RESTRICTED_ACCESS mode</summary>
    [JsonPropertyName("allowedInternetDestinations")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderEgressNetworkAccessAllowedInternetDestinations>? AllowedInternetDestinations { get; set; }

    /// <summary>List of storage destinations that serverless workloads are allowed to access when in RESTRICTED_ACCESS mode</summary>
    [JsonPropertyName("allowedStorageDestinations")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderEgressNetworkAccessAllowedStorageDestinations>? AllowedStorageDestinations { get; set; }

    /// <summary>
    /// List of internet destinations that serverless workloads are blocked from accessing.
    /// These destinations are enforced when restriction mode is RESTRICTED_ACCESS or DRY_RUN.
    /// Currently supports DNS_NAME type only; IP_RANGE support is planned
    /// </summary>
    [JsonPropertyName("blockedInternetDestinations")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderEgressNetworkAccessBlockedInternetDestinations>? BlockedInternetDestinations { get; set; }

    /// <summary>Optional. When policy_enforcement is not provided, we default to ENFORCE_MODE_ALL_SERVICES</summary>
    [JsonPropertyName("policyEnforcement")]
    public V1beta1AccountNetworkPolicyStatusAtProviderEgressNetworkAccessPolicyEnforcement? PolicyEnforcement { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

/// <summary>The network policies applying for egress traffic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderEgress
{
    /// <summary>The access policy enforced for egress traffic to the internet</summary>
    [JsonPropertyName("networkAccess")]
    public V1beta1AccountNetworkPolicyStatusAtProviderEgressNetworkAccess? NetworkAccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Specific source workspace IDs to match</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesOriginSelectedWorkspaces
{
    /// <summary>(list of integer, optional)</summary>
    [JsonPropertyName("workspaceIds")]
    public IList<double>? WorkspaceIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesOrigin
{
    /// <summary>Matches all source workspaces</summary>
    [JsonPropertyName("allSourceWorkspaces")]
    public bool? AllSourceWorkspaces { get; set; }

    /// <summary>Specific source workspace IDs to match</summary>
    [JsonPropertyName("selectedWorkspaces")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesOriginSelectedWorkspaces? SelectedWorkspaces { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRulesOrigin? Origin { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Specific source workspace IDs to match</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesOriginSelectedWorkspaces
{
    /// <summary>(list of integer, optional)</summary>
    [JsonPropertyName("workspaceIds")]
    public IList<double>? WorkspaceIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesOrigin
{
    /// <summary>Matches all source workspaces</summary>
    [JsonPropertyName("allSourceWorkspaces")]
    public bool? AllSourceWorkspaces { get; set; }

    /// <summary>Specific source workspace IDs to match</summary>
    [JsonPropertyName("selectedWorkspaces")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesOriginSelectedWorkspaces? SelectedWorkspaces { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRulesOrigin? Origin { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceAccess, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccess
{
    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("allowRules")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessAllowRules>? AllowRules { get; set; }

    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("denyRules")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccessDenyRules>? DenyRules { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesOriginEndpoints
{
    /// <summary>The IDs of the registered endpoints. Must contain at least one endpoint ID</summary>
    [JsonPropertyName("endpointIds")]
    public IList<string>? EndpointIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesOrigin
{
    /// <summary>
    /// Matches requests arriving over any private connectivity, including registered
    /// endpoints and the workspace&apos;s Azure Private Link (ui-api) endpoints.
    /// Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allPrivateAccess")]
    public bool? AllPrivateAccess { get; set; }

    /// <summary>
    /// Matches requests arriving through any endpoint registered to the account.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allRegisteredEndpoints")]
    public bool? AllRegisteredEndpoints { get; set; }

    /// <summary>
    /// Matches requests arriving through the workspace&apos;s Azure Private Link (ui-api)
    /// endpoints. Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("azureWorkspacePrivateLink")]
    public bool? AzureWorkspacePrivateLink { get; set; }

    /// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
    [JsonPropertyName("endpoints")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesOriginEndpoints? Endpoints { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRulesOrigin? Origin { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesOriginEndpoints
{
    /// <summary>The IDs of the registered endpoints. Must contain at least one endpoint ID</summary>
    [JsonPropertyName("endpointIds")]
    public IList<string>? EndpointIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesOrigin
{
    /// <summary>
    /// Matches requests arriving over any private connectivity, including registered
    /// endpoints and the workspace&apos;s Azure Private Link (ui-api) endpoints.
    /// Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allPrivateAccess")]
    public bool? AllPrivateAccess { get; set; }

    /// <summary>
    /// Matches requests arriving through any endpoint registered to the account.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allRegisteredEndpoints")]
    public bool? AllRegisteredEndpoints { get; set; }

    /// <summary>
    /// Matches requests arriving through the workspace&apos;s Azure Private Link (ui-api)
    /// endpoints. Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("azureWorkspacePrivateLink")]
    public bool? AzureWorkspacePrivateLink { get; set; }

    /// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
    [JsonPropertyName("endpoints")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesOriginEndpoints? Endpoints { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRulesOrigin? Origin { get; set; }
}

/// <summary>
/// The network policy restrictions for private access.
/// Configures how requests arriving over private connectivity are governed
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccess
{
    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("allowRules")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessAllowRules>? AllowRules { get; set; }

    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("denyRules")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccessDenyRules>? DenyRules { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Excluded means: all public IP ranges except this one</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesOriginExcludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>Will not allow IP ranges with private IPs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesOriginIncludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesOrigin
{
    /// <summary>Matches all IPv4 and IPv6 ranges (both public and private)</summary>
    [JsonPropertyName("allIpRanges")]
    public bool? AllIpRanges { get; set; }

    /// <summary>Excluded means: all public IP ranges except this one</summary>
    [JsonPropertyName("excludedIpRanges")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesOriginExcludedIpRanges? ExcludedIpRanges { get; set; }

    /// <summary>Will not allow IP ranges with private IPs</summary>
    [JsonPropertyName("includedIpRanges")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesOriginIncludedIpRanges? IncludedIpRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRulesOrigin? Origin { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Excluded means: all public IP ranges except this one</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesOriginExcludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>Will not allow IP ranges with private IPs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesOriginIncludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesOrigin
{
    /// <summary>Matches all IPv4 and IPv6 ranges (both public and private)</summary>
    [JsonPropertyName("allIpRanges")]
    public bool? AllIpRanges { get; set; }

    /// <summary>Excluded means: all public IP ranges except this one</summary>
    [JsonPropertyName("excludedIpRanges")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesOriginExcludedIpRanges? ExcludedIpRanges { get; set; }

    /// <summary>Will not allow IP ranges with private IPs</summary>
    [JsonPropertyName("includedIpRanges")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesOriginIncludedIpRanges? IncludedIpRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRulesOrigin? Origin { get; set; }
}

/// <summary>
/// The network policy restrictions for public access to the workspace.
/// Configures how public internet traffic is allowed or denied access
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccess
{
    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("allowRules")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessAllowRules>? AllowRules { get; set; }

    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("denyRules")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccessDenyRules>? DenyRules { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

/// <summary>The network policies applying for ingress traffic</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngress
{
    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceAccess, optional)</summary>
    [JsonPropertyName("crossWorkspaceAccess")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressCrossWorkspaceAccess? CrossWorkspaceAccess { get; set; }

    /// <summary>
    /// The network policy restrictions for private access.
    /// Configures how requests arriving over private connectivity are governed
    /// </summary>
    [JsonPropertyName("privateAccess")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPrivateAccess? PrivateAccess { get; set; }

    /// <summary>
    /// The network policy restrictions for public access to the workspace.
    /// Configures how public internet traffic is allowed or denied access
    /// </summary>
    [JsonPropertyName("publicAccess")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressPublicAccess? PublicAccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Specific source workspace IDs to match</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesOriginSelectedWorkspaces
{
    /// <summary>(list of integer, optional)</summary>
    [JsonPropertyName("workspaceIds")]
    public IList<double>? WorkspaceIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesOrigin
{
    /// <summary>Matches all source workspaces</summary>
    [JsonPropertyName("allSourceWorkspaces")]
    public bool? AllSourceWorkspaces { get; set; }

    /// <summary>Specific source workspace IDs to match</summary>
    [JsonPropertyName("selectedWorkspaces")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesOriginSelectedWorkspaces? SelectedWorkspaces { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRulesOrigin? Origin { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Specific source workspace IDs to match</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesOriginSelectedWorkspaces
{
    /// <summary>(list of integer, optional)</summary>
    [JsonPropertyName("workspaceIds")]
    public IList<double>? WorkspaceIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesOrigin
{
    /// <summary>Matches all source workspaces</summary>
    [JsonPropertyName("allSourceWorkspaces")]
    public bool? AllSourceWorkspaces { get; set; }

    /// <summary>Specific source workspace IDs to match</summary>
    [JsonPropertyName("selectedWorkspaces")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesOriginSelectedWorkspaces? SelectedWorkspaces { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRulesOrigin? Origin { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceAccess, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccess
{
    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("allowRules")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessAllowRules>? AllowRules { get; set; }

    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("denyRules")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccessDenyRules>? DenyRules { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesOriginEndpoints
{
    /// <summary>The IDs of the registered endpoints. Must contain at least one endpoint ID</summary>
    [JsonPropertyName("endpointIds")]
    public IList<string>? EndpointIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesOrigin
{
    /// <summary>
    /// Matches requests arriving over any private connectivity, including registered
    /// endpoints and the workspace&apos;s Azure Private Link (ui-api) endpoints.
    /// Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allPrivateAccess")]
    public bool? AllPrivateAccess { get; set; }

    /// <summary>
    /// Matches requests arriving through any endpoint registered to the account.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allRegisteredEndpoints")]
    public bool? AllRegisteredEndpoints { get; set; }

    /// <summary>
    /// Matches requests arriving through the workspace&apos;s Azure Private Link (ui-api)
    /// endpoints. Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("azureWorkspacePrivateLink")]
    public bool? AzureWorkspacePrivateLink { get; set; }

    /// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
    [JsonPropertyName("endpoints")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesOriginEndpoints? Endpoints { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRulesOrigin? Origin { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesOriginEndpoints
{
    /// <summary>The IDs of the registered endpoints. Must contain at least one endpoint ID</summary>
    [JsonPropertyName("endpointIds")]
    public IList<string>? EndpointIds { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesOrigin
{
    /// <summary>
    /// Matches requests arriving over any private connectivity, including registered
    /// endpoints and the workspace&apos;s Azure Private Link (ui-api) endpoints.
    /// Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allPrivateAccess")]
    public bool? AllPrivateAccess { get; set; }

    /// <summary>
    /// Matches requests arriving through any endpoint registered to the account.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("allRegisteredEndpoints")]
    public bool? AllRegisteredEndpoints { get; set; }

    /// <summary>
    /// Matches requests arriving through the workspace&apos;s Azure Private Link (ui-api)
    /// endpoints. Can only be used in deny rules of workspace-level network policies.
    /// Must be set to true when specified
    /// </summary>
    [JsonPropertyName("azureWorkspacePrivateLink")]
    public bool? AzureWorkspacePrivateLink { get; set; }

    /// <summary>Matches requests arriving through any of the specified registered endpoints</summary>
    [JsonPropertyName("endpoints")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesOriginEndpoints? Endpoints { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRulesOrigin? Origin { get; set; }
}

/// <summary>
/// The network policy restrictions for private access.
/// Configures how requests arriving over private connectivity are governed
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccess
{
    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("allowRules")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessAllowRules>? AllowRules { get; set; }

    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("denyRules")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccessDenyRules>? DenyRules { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Excluded means: all public IP ranges except this one</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesOriginExcludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>Will not allow IP ranges with private IPs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesOriginIncludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesOrigin
{
    /// <summary>Matches all IPv4 and IPv6 ranges (both public and private)</summary>
    [JsonPropertyName("allIpRanges")]
    public bool? AllIpRanges { get; set; }

    /// <summary>Excluded means: all public IP ranges except this one</summary>
    [JsonPropertyName("excludedIpRanges")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesOriginExcludedIpRanges? ExcludedIpRanges { get; set; }

    /// <summary>Will not allow IP ranges with private IPs</summary>
    [JsonPropertyName("includedIpRanges")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesOriginIncludedIpRanges? IncludedIpRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRulesOrigin? Origin { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesAuthenticationIdentities
{
    /// <summary>(integer, optional)</summary>
    [JsonPropertyName("principalId")]
    public double? PrincipalId { get; set; }

    /// <summary>Possible values are: PRINCIPAL_TYPE_SERVICE_PRINCIPAL, PRINCIPAL_TYPE_USER</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesAuthentication
{
    /// <summary>Valid only when IdentityType is IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identities")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesAuthenticationIdentities>? Identities { get; set; }

    /// <summary>Possible values are: IDENTITY_TYPE_ALL_SERVICE_PRINCIPALS, IDENTITY_TYPE_ALL_USERS, IDENTITY_TYPE_SELECTED_IDENTITIES</summary>
    [JsonPropertyName("identityType")]
    public string? IdentityType { get; set; }
}

/// <summary>
/// Matches requests to account-level APIs.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesDestinationAccountApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>Account DatabricksOne destination is not supported</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesDestinationAccountDatabricksOne
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>
/// Matches requests to the account console UI.
/// Can only be used in the account-level network policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesDestinationAccountUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesDestinationAppsRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesDestinationLakebaseRuntime
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesDestinationWorkspaceApi
{
    /// <summary>Qualifies the breadth of API access for the listed scopes. See ApiScopeQualifier. Possible values are: API_SCOPE_QUALIFIER_ALL, API_SCOPE_QUALIFIER_READ</summary>
    [JsonPropertyName("scopeQualifier")]
    public string? ScopeQualifier { get; set; }

    /// <summary>The API scopes to match. Use &quot;all-apis&quot; to match any account-level API</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesDestinationWorkspaceUi
{
    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesDestination
{
    /// <summary>
    /// Matches requests to account-level APIs.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesDestinationAccountApi? AccountApi { get; set; }

    /// <summary>Account DatabricksOne destination is not supported</summary>
    [JsonPropertyName("accountDatabricksOne")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesDestinationAccountDatabricksOne? AccountDatabricksOne { get; set; }

    /// <summary>
    /// Matches requests to the account console UI.
    /// Can only be used in the account-level network policy
    /// </summary>
    [JsonPropertyName("accountUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesDestinationAccountUi? AccountUi { get; set; }

    /// <summary>Must be set to true</summary>
    [JsonPropertyName("allDestinations")]
    public bool? AllDestinations { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyAppsRuntimeDestination, optional)</summary>
    [JsonPropertyName("appsRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesDestinationAppsRuntime? AppsRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyLakebaseRuntimeDestination, optional)</summary>
    [JsonPropertyName("lakebaseRuntime")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesDestinationLakebaseRuntime? LakebaseRuntime { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceApiDestination, optional)</summary>
    [JsonPropertyName("workspaceApi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesDestinationWorkspaceApi? WorkspaceApi { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyWorkspaceUiDestination, optional)</summary>
    [JsonPropertyName("workspaceUi")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesDestinationWorkspaceUi? WorkspaceUi { get; set; }
}

/// <summary>Excluded means: all public IP ranges except this one</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesOriginExcludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>Will not allow IP ranges with private IPs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesOriginIncludedIpRanges
{
    /// <summary>We only support IPv4 and IPv4 CIDR notation for now</summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }
}

/// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesOrigin
{
    /// <summary>Matches all IPv4 and IPv6 ranges (both public and private)</summary>
    [JsonPropertyName("allIpRanges")]
    public bool? AllIpRanges { get; set; }

    /// <summary>Excluded means: all public IP ranges except this one</summary>
    [JsonPropertyName("excludedIpRanges")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesOriginExcludedIpRanges? ExcludedIpRanges { get; set; }

    /// <summary>Will not allow IP ranges with private IPs</summary>
    [JsonPropertyName("includedIpRanges")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesOriginIncludedIpRanges? IncludedIpRanges { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRules
{
    /// <summary>(CustomerFacingIngressNetworkPolicyAuthentication, optional)</summary>
    [JsonPropertyName("authentication")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesAuthentication? Authentication { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyRequestDestination, optional)</summary>
    [JsonPropertyName("destination")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesDestination? Destination { get; set; }

    /// <summary>The label for this ingress rule</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceRequestOrigin, optional)</summary>
    [JsonPropertyName("origin")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRulesOrigin? Origin { get; set; }
}

/// <summary>
/// The network policy restrictions for public access to the workspace.
/// Configures how public internet traffic is allowed or denied access
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccess
{
    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("allowRules")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessAllowRules>? AllowRules { get; set; }

    /// <summary>(list of CustomerFacingIngressNetworkPolicyCrossWorkspaceIngressRule, optional)</summary>
    [JsonPropertyName("denyRules")]
    public IList<V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccessDenyRules>? DenyRules { get; set; }

    /// <summary>Possible values are: FULL_ACCESS, RESTRICTED_ACCESS</summary>
    [JsonPropertyName("restrictionMode")]
    public string? RestrictionMode { get; set; }
}

/// <summary>
/// The ingress policy for dry run mode. Dry run will always run even if the request
/// is allowed by the ingress policy. When this field is set, the policy will be evaluated
/// and emit logs only without blocking requests
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRun
{
    /// <summary>(CustomerFacingIngressNetworkPolicyCrossWorkspaceAccess, optional)</summary>
    [JsonPropertyName("crossWorkspaceAccess")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunCrossWorkspaceAccess? CrossWorkspaceAccess { get; set; }

    /// <summary>
    /// The network policy restrictions for private access.
    /// Configures how requests arriving over private connectivity are governed
    /// </summary>
    [JsonPropertyName("privateAccess")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPrivateAccess? PrivateAccess { get; set; }

    /// <summary>
    /// The network policy restrictions for public access to the workspace.
    /// Configures how public internet traffic is allowed or denied access
    /// </summary>
    [JsonPropertyName("publicAccess")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRunPublicAccess? PublicAccess { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusAtProvider
{
    /// <summary>The associated account ID for this Network Policy object</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The network policies applying for egress traffic</summary>
    [JsonPropertyName("egress")]
    public V1beta1AccountNetworkPolicyStatusAtProviderEgress? Egress { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The network policies applying for ingress traffic</summary>
    [JsonPropertyName("ingress")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngress? Ingress { get; set; }

    /// <summary>
    /// The ingress policy for dry run mode. Dry run will always run even if the request
    /// is allowed by the ingress policy. When this field is set, the policy will be evaluated
    /// and emit logs only without blocking requests
    /// </summary>
    [JsonPropertyName("ingressDryRun")]
    public V1beta1AccountNetworkPolicyStatusAtProviderIngressDryRun? IngressDryRun { get; set; }

    /// <summary>The unique identifier for the network policy</summary>
    [JsonPropertyName("networkPolicyId")]
    public string? NetworkPolicyId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatusConditions
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

/// <summary>AccountNetworkPolicyStatus defines the observed state of AccountNetworkPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccountNetworkPolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1AccountNetworkPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccountNetworkPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile-requested-at annotation token that the controller has
    /// processed. Users can compare this to the annotation to determine
    /// whether a reconcile request has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AccountNetworkPolicy is the Schema for the AccountNetworkPolicys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccountNetworkPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AccountNetworkPolicySpec>, IStatus<V1beta1AccountNetworkPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccountNetworkPolicy";
    public const string KubeGroup = "settings.databricks.crossplane.io";
    public const string KubePluralName = "accountnetworkpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "settings.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccountNetworkPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AccountNetworkPolicySpec defines the desired state of AccountNetworkPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta1AccountNetworkPolicySpec Spec { get; set; }

    /// <summary>AccountNetworkPolicyStatus defines the observed state of AccountNetworkPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1AccountNetworkPolicyStatus? Status { get; set; }
}
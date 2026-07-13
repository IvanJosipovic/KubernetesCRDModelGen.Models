#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.azure.vault.upbound.io;
/// <summary>AuthBackendConfig is the Schema for the AuthBackendConfigs API. Configures the Azure Auth Backend in Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AuthBackendConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AuthBackendConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AuthBackendConfigList";
    public const string KubeGroup = "azure.vault.upbound.io";
    public const string KubePluralName = "authbackendconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "azure.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AuthBackendConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1AuthBackendConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1AuthBackendConfig> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendConfigSpecDeletionPolicyEnum>))]
public enum V1alpha1AuthBackendConfigSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendConfigSpecForProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1AuthBackendConfigSpecForProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendConfigSpecForProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1AuthBackendConfigSpecForProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecForProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1AuthBackendConfigSpecForProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1AuthBackendConfigSpecForProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Backend in auth to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecForProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1AuthBackendConfigSpecForProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendConfigSpecForProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1AuthBackendConfigSpecForProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendConfigSpecForProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1AuthBackendConfigSpecForProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecForProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1AuthBackendConfigSpecForProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1AuthBackendConfigSpecForProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Backend in auth to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecForProviderBackendSelector
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
    public V1alpha1AuthBackendConfigSpecForProviderBackendSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The client id for credentials to query the Azure APIs.
/// Currently read permissions to query compute resources are required.
/// The client id for credentials to query the Azure APIs. Currently read permissions to query compute resources are required.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecForProviderClientIdSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// The client secret for credentials to query the
/// Azure APIs. Mutually exclusive with client_secret_wo. Consider using client_secret_wo instead for enhanced security.
/// The client secret for credentials to query the Azure APIs. Mutually exclusive with &apos;client_secret_wo&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecForProviderClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// The client secret for credentials to query the Azure APIs,
/// provided as a write-only field.
/// Mutually exclusive with client_secret. Must be used with client_secret_wo_version.
/// To rotate the secret, update the value and increment client_secret_wo_version.
/// The client secret for credentials to query the Azure APIs. This field is write-only and will never be stored in state. Mutually exclusive with &apos;client_secret&apos;. Requires &apos;client_secret_wo_version&apos; to trigger updates.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecForProviderClientSecretWoSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// The tenant id for the Azure Active Directory
/// organization.
/// The tenant id for the Azure Active Directory organization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecForProviderTenantIdSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecForProvider
{
    /// <summary>
    /// The path the Azure auth backend being configured was
    /// mounted at.  Defaults to azure.
    /// Unique name of the auth backend to configure.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Backend in auth to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1AuthBackendConfigSpecForProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Backend in auth to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1AuthBackendConfigSpecForProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// The client id for credentials to query the Azure APIs.
    /// Currently read permissions to query compute resources are required.
    /// The client id for credentials to query the Azure APIs. Currently read permissions to query compute resources are required.
    /// </summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1alpha1AuthBackendConfigSpecForProviderClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>
    /// The client secret for credentials to query the
    /// Azure APIs. Mutually exclusive with client_secret_wo. Consider using client_secret_wo instead for enhanced security.
    /// The client secret for credentials to query the Azure APIs. Mutually exclusive with &apos;client_secret_wo&apos;.
    /// </summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1alpha1AuthBackendConfigSpecForProviderClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>
    /// The client secret for credentials to query the Azure APIs,
    /// provided as a write-only field.
    /// Mutually exclusive with client_secret. Must be used with client_secret_wo_version.
    /// To rotate the secret, update the value and increment client_secret_wo_version.
    /// The client secret for credentials to query the Azure APIs. This field is write-only and will never be stored in state. Mutually exclusive with &apos;client_secret&apos;. Requires &apos;client_secret_wo_version&apos; to trigger updates.
    /// </summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1alpha1AuthBackendConfigSpecForProviderClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }

    /// <summary>
    /// Version counter for the write-only client secret.
    /// Increment this value to trigger an update of the client secret in Vault.
    /// Required when using client_secret_wo.
    /// Version counter for the write-only client secret. Increment this value to trigger rotation of the client secret. Required when using &apos;client_secret_wo&apos;.
    /// </summary>
    [JsonPropertyName("clientSecretWoVersion")]
    public double? ClientSecretWoVersion { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Available only for Vault Enterprise
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The Azure cloud environment. Valid values:
    /// AzurePublicCloud, AzureUSGovernmentCloud, AzureChinaCloud,
    /// AzureGermanCloud.  Defaults to AzurePublicCloud.
    /// The Azure cloud environment. Valid values: AzurePublicCloud, AzureUSGovernmentCloud, AzureChinaCloud, AzureGermanCloud.
    /// </summary>
    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    /// <summary>
    /// The audience claim value for plugin identity tokens. Requires Vault 1.17+.
    /// Available only for Vault Enterprise
    /// The audience claim value.
    /// </summary>
    [JsonPropertyName("identityTokenAudience")]
    public string? IdentityTokenAudience { get; set; }

    /// <summary>
    /// The TTL of generated identity tokens in seconds.
    /// Defaults to 1 hour. Uses duration format strings.
    /// Requires Vault 1.17+. Available only for Vault Enterprise
    /// The TTL of generated identity tokens in seconds.
    /// </summary>
    [JsonPropertyName("identityTokenTtl")]
    public double? IdentityTokenTtl { get; set; }

    /// <summary>
    /// Maximum number of retries for Azure API requests.
    /// Defaults to 3.
    /// Maximum number of retries for Azure API requests. Defaults to 3.
    /// </summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>
    /// The maximum delay in seconds between retries for Azure API requests.
    /// Defaults to 60.
    /// The maximum delay in seconds between retries for Azure API requests. Defaults to 60.
    /// </summary>
    [JsonPropertyName("maxRetryDelay")]
    public double? MaxRetryDelay { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// The configured URL for the application registered in
    /// Azure Active Directory.
    /// The configured URL for the application registered in Azure Active Directory.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>
    /// The initial delay in seconds between retries for Azure API requests.
    /// Defaults to 4.
    /// The initial delay in seconds between retries for Azure API requests. Defaults to 4.
    /// </summary>
    [JsonPropertyName("retryDelay")]
    public double? RetryDelay { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// Available only for Vault Enterprise
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// Available only for Vault Enterprise
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// Available only for Vault Enterprise
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// The tenant id for the Azure Active Directory
    /// organization.
    /// The tenant id for the Azure Active Directory organization.
    /// </summary>
    [JsonPropertyName("tenantIdSecretRef")]
    public V1alpha1AuthBackendConfigSpecForProviderTenantIdSecretRef? TenantIdSecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendConfigSpecInitProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1AuthBackendConfigSpecInitProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendConfigSpecInitProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1AuthBackendConfigSpecInitProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecInitProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1AuthBackendConfigSpecInitProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1AuthBackendConfigSpecInitProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Backend in auth to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecInitProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1AuthBackendConfigSpecInitProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendConfigSpecInitProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1AuthBackendConfigSpecInitProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendConfigSpecInitProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1AuthBackendConfigSpecInitProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecInitProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1AuthBackendConfigSpecInitProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1AuthBackendConfigSpecInitProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Backend in auth to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecInitProviderBackendSelector
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
    public V1alpha1AuthBackendConfigSpecInitProviderBackendSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The client id for credentials to query the Azure APIs.
/// Currently read permissions to query compute resources are required.
/// The client id for credentials to query the Azure APIs. Currently read permissions to query compute resources are required.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecInitProviderClientIdSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// The client secret for credentials to query the
/// Azure APIs. Mutually exclusive with client_secret_wo. Consider using client_secret_wo instead for enhanced security.
/// The client secret for credentials to query the Azure APIs. Mutually exclusive with &apos;client_secret_wo&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecInitProviderClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// The client secret for credentials to query the Azure APIs,
/// provided as a write-only field.
/// Mutually exclusive with client_secret. Must be used with client_secret_wo_version.
/// To rotate the secret, update the value and increment client_secret_wo_version.
/// The client secret for credentials to query the Azure APIs. This field is write-only and will never be stored in state. Mutually exclusive with &apos;client_secret&apos;. Requires &apos;client_secret_wo_version&apos; to trigger updates.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecInitProviderClientSecretWoSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// The tenant id for the Azure Active Directory
/// organization.
/// The tenant id for the Azure Active Directory organization.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecInitProviderTenantIdSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
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
public partial class V1alpha1AuthBackendConfigSpecInitProvider
{
    /// <summary>
    /// The path the Azure auth backend being configured was
    /// mounted at.  Defaults to azure.
    /// Unique name of the auth backend to configure.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Backend in auth to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1AuthBackendConfigSpecInitProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Backend in auth to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1AuthBackendConfigSpecInitProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// The client id for credentials to query the Azure APIs.
    /// Currently read permissions to query compute resources are required.
    /// The client id for credentials to query the Azure APIs. Currently read permissions to query compute resources are required.
    /// </summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1alpha1AuthBackendConfigSpecInitProviderClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>
    /// The client secret for credentials to query the
    /// Azure APIs. Mutually exclusive with client_secret_wo. Consider using client_secret_wo instead for enhanced security.
    /// The client secret for credentials to query the Azure APIs. Mutually exclusive with &apos;client_secret_wo&apos;.
    /// </summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1alpha1AuthBackendConfigSpecInitProviderClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>
    /// The client secret for credentials to query the Azure APIs,
    /// provided as a write-only field.
    /// Mutually exclusive with client_secret. Must be used with client_secret_wo_version.
    /// To rotate the secret, update the value and increment client_secret_wo_version.
    /// The client secret for credentials to query the Azure APIs. This field is write-only and will never be stored in state. Mutually exclusive with &apos;client_secret&apos;. Requires &apos;client_secret_wo_version&apos; to trigger updates.
    /// </summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1alpha1AuthBackendConfigSpecInitProviderClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }

    /// <summary>
    /// Version counter for the write-only client secret.
    /// Increment this value to trigger an update of the client secret in Vault.
    /// Required when using client_secret_wo.
    /// Version counter for the write-only client secret. Increment this value to trigger rotation of the client secret. Required when using &apos;client_secret_wo&apos;.
    /// </summary>
    [JsonPropertyName("clientSecretWoVersion")]
    public double? ClientSecretWoVersion { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Available only for Vault Enterprise
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The Azure cloud environment. Valid values:
    /// AzurePublicCloud, AzureUSGovernmentCloud, AzureChinaCloud,
    /// AzureGermanCloud.  Defaults to AzurePublicCloud.
    /// The Azure cloud environment. Valid values: AzurePublicCloud, AzureUSGovernmentCloud, AzureChinaCloud, AzureGermanCloud.
    /// </summary>
    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    /// <summary>
    /// The audience claim value for plugin identity tokens. Requires Vault 1.17+.
    /// Available only for Vault Enterprise
    /// The audience claim value.
    /// </summary>
    [JsonPropertyName("identityTokenAudience")]
    public string? IdentityTokenAudience { get; set; }

    /// <summary>
    /// The TTL of generated identity tokens in seconds.
    /// Defaults to 1 hour. Uses duration format strings.
    /// Requires Vault 1.17+. Available only for Vault Enterprise
    /// The TTL of generated identity tokens in seconds.
    /// </summary>
    [JsonPropertyName("identityTokenTtl")]
    public double? IdentityTokenTtl { get; set; }

    /// <summary>
    /// Maximum number of retries for Azure API requests.
    /// Defaults to 3.
    /// Maximum number of retries for Azure API requests. Defaults to 3.
    /// </summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>
    /// The maximum delay in seconds between retries for Azure API requests.
    /// Defaults to 60.
    /// The maximum delay in seconds between retries for Azure API requests. Defaults to 60.
    /// </summary>
    [JsonPropertyName("maxRetryDelay")]
    public double? MaxRetryDelay { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// The configured URL for the application registered in
    /// Azure Active Directory.
    /// The configured URL for the application registered in Azure Active Directory.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>
    /// The initial delay in seconds between retries for Azure API requests.
    /// Defaults to 4.
    /// The initial delay in seconds between retries for Azure API requests. Defaults to 4.
    /// </summary>
    [JsonPropertyName("retryDelay")]
    public double? RetryDelay { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// Available only for Vault Enterprise
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// Available only for Vault Enterprise
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// Available only for Vault Enterprise
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// The tenant id for the Azure Active Directory
    /// organization.
    /// The tenant id for the Azure Active Directory organization.
    /// </summary>
    [JsonPropertyName("tenantIdSecretRef")]
    public required V1alpha1AuthBackendConfigSpecInitProviderTenantIdSecretRef TenantIdSecretRef { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendConfigSpecManagementPoliciesEnum>))]
public enum V1alpha1AuthBackendConfigSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendConfigSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha1AuthBackendConfigSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendConfigSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha1AuthBackendConfigSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1AuthBackendConfigSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1AuthBackendConfigSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1AuthBackendConfigSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AuthBackendConfigSpec defines the desired state of AuthBackendConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigSpec
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
    public V1alpha1AuthBackendConfigSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1AuthBackendConfigSpecForProvider ForProvider { get; set; }

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
    public V1alpha1AuthBackendConfigSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1AuthBackendConfigSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1AuthBackendConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1AuthBackendConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigStatusAtProvider
{
    /// <summary>
    /// The path the Azure auth backend being configured was
    /// mounted at.  Defaults to azure.
    /// Unique name of the auth backend to configure.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>
    /// Version counter for the write-only client secret.
    /// Increment this value to trigger an update of the client secret in Vault.
    /// Required when using client_secret_wo.
    /// Version counter for the write-only client secret. Increment this value to trigger rotation of the client secret. Required when using &apos;client_secret_wo&apos;.
    /// </summary>
    [JsonPropertyName("clientSecretWoVersion")]
    public double? ClientSecretWoVersion { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Available only for Vault Enterprise
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The Azure cloud environment. Valid values:
    /// AzurePublicCloud, AzureUSGovernmentCloud, AzureChinaCloud,
    /// AzureGermanCloud.  Defaults to AzurePublicCloud.
    /// The Azure cloud environment. Valid values: AzurePublicCloud, AzureUSGovernmentCloud, AzureChinaCloud, AzureGermanCloud.
    /// </summary>
    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The audience claim value for plugin identity tokens. Requires Vault 1.17+.
    /// Available only for Vault Enterprise
    /// The audience claim value.
    /// </summary>
    [JsonPropertyName("identityTokenAudience")]
    public string? IdentityTokenAudience { get; set; }

    /// <summary>
    /// The TTL of generated identity tokens in seconds.
    /// Defaults to 1 hour. Uses duration format strings.
    /// Requires Vault 1.17+. Available only for Vault Enterprise
    /// The TTL of generated identity tokens in seconds.
    /// </summary>
    [JsonPropertyName("identityTokenTtl")]
    public double? IdentityTokenTtl { get; set; }

    /// <summary>
    /// Maximum number of retries for Azure API requests.
    /// Defaults to 3.
    /// Maximum number of retries for Azure API requests. Defaults to 3.
    /// </summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>
    /// The maximum delay in seconds between retries for Azure API requests.
    /// Defaults to 60.
    /// The maximum delay in seconds between retries for Azure API requests. Defaults to 60.
    /// </summary>
    [JsonPropertyName("maxRetryDelay")]
    public double? MaxRetryDelay { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// The configured URL for the application registered in
    /// Azure Active Directory.
    /// The configured URL for the application registered in Azure Active Directory.
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>
    /// The initial delay in seconds between retries for Azure API requests.
    /// Defaults to 4.
    /// The initial delay in seconds between retries for Azure API requests. Defaults to 4.
    /// </summary>
    [JsonPropertyName("retryDelay")]
    public double? RetryDelay { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// Available only for Vault Enterprise
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// Available only for Vault Enterprise
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// Available only for Vault Enterprise
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigStatusConditions
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

/// <summary>AuthBackendConfigStatus defines the observed state of AuthBackendConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendConfigStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1AuthBackendConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AuthBackendConfigStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AuthBackendConfig is the Schema for the AuthBackendConfigs API. Configures the Azure Auth Backend in Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AuthBackendConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AuthBackendConfigSpec>, IStatus<V1alpha1AuthBackendConfigStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AuthBackendConfig";
    public const string KubeGroup = "azure.vault.upbound.io";
    public const string KubePluralName = "authbackendconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "azure.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AuthBackendConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AuthBackendConfigSpec defines the desired state of AuthBackendConfig</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1AuthBackendConfigSpec Spec { get; set; }

    /// <summary>AuthBackendConfigStatus defines the observed state of AuthBackendConfig.</summary>
    [JsonPropertyName("status")]
    public V1alpha1AuthBackendConfigStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.aws.vault.upbound.io;
/// <summary>AuthBackendClient is the Schema for the AuthBackendClients API. Configures the client used by an AWS Auth Backend in Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AuthBackendClientList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AuthBackendClient>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AuthBackendClientList";
    public const string KubeGroup = "aws.vault.upbound.io";
    public const string KubePluralName = "authbackendclients";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "aws.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AuthBackendClientList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1AuthBackendClient objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1AuthBackendClient> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendClientSpecDeletionPolicyEnum>))]
public enum V1alpha1AuthBackendClientSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// The AWS access key that Vault should use for the
/// auth backend. Mutually exclusive with identity_token_audience.
/// AWS Access key with permissions to query AWS APIs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientSpecForProviderAccessKeySecretRef
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
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendClientSpecForProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1AuthBackendClientSpecForProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendClientSpecForProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1AuthBackendClientSpecForProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientSpecForProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1AuthBackendClientSpecForProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1AuthBackendClientSpecForProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Backend in auth to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientSpecForProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1AuthBackendClientSpecForProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendClientSpecForProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1AuthBackendClientSpecForProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendClientSpecForProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1AuthBackendClientSpecForProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientSpecForProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1AuthBackendClientSpecForProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1AuthBackendClientSpecForProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Backend in auth to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientSpecForProviderBackendSelector
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
    public V1alpha1AuthBackendClientSpecForProviderBackendSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The AWS secret key that Vault should use for the
/// auth backend. Mutually exclusive with secret_key_wo.
/// Consider using secret_key_wo instead for enhanced security.
/// AWS Secret key with permissions to query AWS APIs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientSpecForProviderSecretKeySecretRef
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
/// Write-only AWS secret key that Vault should use for the
/// auth backend. Mutually exclusive with secret_key.
/// Must be used together with secret_key_wo_version.
/// Note: This property is write-only and will not be read from the API.
/// Write-only AWS Secret key with permissions to query AWS APIs. This field is recommended over secret_key for enhanced security.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientSpecForProviderSecretKeyWoSecretRef
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
public partial class V1alpha1AuthBackendClientSpecForProvider
{
    /// <summary>
    /// The AWS access key that Vault should use for the
    /// auth backend. Mutually exclusive with identity_token_audience.
    /// AWS Access key with permissions to query AWS APIs.
    /// </summary>
    [JsonPropertyName("accessKeySecretRef")]
    public V1alpha1AuthBackendClientSpecForProviderAccessKeySecretRef? AccessKeySecretRef { get; set; }

    /// <summary>
    /// List of additional headers that are allowed to be in STS request headers.
    /// The headers are automatically canonicalized (e.g., content-type becomes Content-Type). Duplicate values are automatically
    /// removed. This can be useful when you need to allow specific headers in STS requests for IAM-based authentication.
    /// List of additional headers that are allowed to be in STS request headers.
    /// </summary>
    [JsonPropertyName("allowedStsHeaderValues")]
    public IList<string>? AllowedStsHeaderValues { get; set; }

    /// <summary>
    /// The path the AWS auth backend being configured was
    /// mounted at.  Defaults to aws.
    /// Unique name of the auth backend to configure.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Backend in auth to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1AuthBackendClientSpecForProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Backend in auth to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1AuthBackendClientSpecForProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// Override the URL Vault uses when making EC2 API
    /// calls.
    /// URL to override the default generated endpoint for making AWS EC2 API calls.
    /// </summary>
    [JsonPropertyName("ec2Endpoint")]
    public string? Ec2Endpoint { get; set; }

    /// <summary>
    /// Override the URL Vault uses when making IAM API
    /// calls.
    /// URL to override the default generated endpoint for making AWS IAM API calls.
    /// </summary>
    [JsonPropertyName("iamEndpoint")]
    public string? IamEndpoint { get; set; }

    /// <summary>
    /// The value to require in the
    /// X-Vault-AWS-IAM-Server-ID header as part of GetCallerIdentity requests
    /// that are used in the IAM auth method.
    /// The value to require in the X-Vault-AWS-IAM-Server-ID header as part of GetCallerIdentity requests that are used in the iam auth method.
    /// </summary>
    [JsonPropertyName("iamServerIdHeaderValue")]
    public string? IamServerIdHeaderValue { get; set; }

    /// <summary>
    /// The audience claim value. Mutually exclusive with access_key.
    /// Requires Vault 1.17+. Available only for Vault Enterprise
    /// The audience claim value.
    /// </summary>
    [JsonPropertyName("identityTokenAudience")]
    public string? IdentityTokenAudience { get; set; }

    /// <summary>
    /// The TTL of generated identity tokens in seconds. Requires Vault 1.17+.
    /// Available only for Vault Enterprise
    /// The TTL of generated identity tokens in seconds.
    /// </summary>
    [JsonPropertyName("identityTokenTtl")]
    public double? IdentityTokenTtl { get; set; }

    /// <summary>
    /// Number of max retries the client should use for recoverable errors.
    /// The default -1 falls back to the AWS SDK&apos;s default behavior.
    /// Number of max retries the client should use for recoverable errors.
    /// </summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

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
    /// Role ARN to assume for plugin identity token federation. Requires Vault 1.17+.
    /// Available only for Vault Enterprise
    /// Role ARN to assume for plugin identity token federation.
    /// </summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// The AWS secret key that Vault should use for the
    /// auth backend. Mutually exclusive with secret_key_wo.
    /// Consider using secret_key_wo instead for enhanced security.
    /// AWS Secret key with permissions to query AWS APIs.
    /// </summary>
    [JsonPropertyName("secretKeySecretRef")]
    public V1alpha1AuthBackendClientSpecForProviderSecretKeySecretRef? SecretKeySecretRef { get; set; }

    /// <summary>
    /// Write-only AWS secret key that Vault should use for the
    /// auth backend. Mutually exclusive with secret_key.
    /// Must be used together with secret_key_wo_version.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only AWS Secret key with permissions to query AWS APIs. This field is recommended over secret_key for enhanced security.
    /// </summary>
    [JsonPropertyName("secretKeyWoSecretRef")]
    public V1alpha1AuthBackendClientSpecForProviderSecretKeyWoSecretRef? SecretKeyWoSecretRef { get; set; }

    /// <summary>
    /// Version counter for the write-only secret_key_wo field.
    /// Increment this value to rotate the secret key. Required when secret_key_wo is set.
    /// Version counter for write-only secret_key field. Increment this value to force update of the secret.
    /// </summary>
    [JsonPropertyName("secretKeyWoVersion")]
    public double? SecretKeyWoVersion { get; set; }

    /// <summary>
    /// Override the URL Vault uses when making STS API
    /// calls.
    /// URL to override the default generated endpoint for making AWS STS API calls.
    /// </summary>
    [JsonPropertyName("stsEndpoint")]
    public string? StsEndpoint { get; set; }

    /// <summary>
    /// Override the default region when making STS API
    /// calls. The sts_endpoint argument must be set when using sts_region.
    /// Region to override the default region for making AWS STS API calls.
    /// </summary>
    [JsonPropertyName("stsRegion")]
    public string? StsRegion { get; set; }

    /// <summary>
    /// Available in Vault v1.15+. If set,
    /// overrides both sts_endpoint and sts_region to instead use the region
    /// specified in the client request headers for IAM-based authentication.
    /// This can be useful when you have client requests coming from different
    /// regions and want flexibility in which regional STS API is used.
    /// If set, will override sts_region and use the region from the client request&apos;s header
    /// </summary>
    [JsonPropertyName("useStsRegionFromClient")]
    public bool? UseStsRegionFromClient { get; set; }
}

/// <summary>
/// The AWS access key that Vault should use for the
/// auth backend. Mutually exclusive with identity_token_audience.
/// AWS Access key with permissions to query AWS APIs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientSpecInitProviderAccessKeySecretRef
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
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendClientSpecInitProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1AuthBackendClientSpecInitProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendClientSpecInitProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1AuthBackendClientSpecInitProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientSpecInitProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1AuthBackendClientSpecInitProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1AuthBackendClientSpecInitProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Backend in auth to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientSpecInitProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1AuthBackendClientSpecInitProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendClientSpecInitProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1AuthBackendClientSpecInitProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendClientSpecInitProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1AuthBackendClientSpecInitProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientSpecInitProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1AuthBackendClientSpecInitProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1AuthBackendClientSpecInitProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Backend in auth to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientSpecInitProviderBackendSelector
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
    public V1alpha1AuthBackendClientSpecInitProviderBackendSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The AWS secret key that Vault should use for the
/// auth backend. Mutually exclusive with secret_key_wo.
/// Consider using secret_key_wo instead for enhanced security.
/// AWS Secret key with permissions to query AWS APIs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientSpecInitProviderSecretKeySecretRef
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
/// Write-only AWS secret key that Vault should use for the
/// auth backend. Mutually exclusive with secret_key.
/// Must be used together with secret_key_wo_version.
/// Note: This property is write-only and will not be read from the API.
/// Write-only AWS Secret key with permissions to query AWS APIs. This field is recommended over secret_key for enhanced security.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientSpecInitProviderSecretKeyWoSecretRef
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
public partial class V1alpha1AuthBackendClientSpecInitProvider
{
    /// <summary>
    /// The AWS access key that Vault should use for the
    /// auth backend. Mutually exclusive with identity_token_audience.
    /// AWS Access key with permissions to query AWS APIs.
    /// </summary>
    [JsonPropertyName("accessKeySecretRef")]
    public V1alpha1AuthBackendClientSpecInitProviderAccessKeySecretRef? AccessKeySecretRef { get; set; }

    /// <summary>
    /// List of additional headers that are allowed to be in STS request headers.
    /// The headers are automatically canonicalized (e.g., content-type becomes Content-Type). Duplicate values are automatically
    /// removed. This can be useful when you need to allow specific headers in STS requests for IAM-based authentication.
    /// List of additional headers that are allowed to be in STS request headers.
    /// </summary>
    [JsonPropertyName("allowedStsHeaderValues")]
    public IList<string>? AllowedStsHeaderValues { get; set; }

    /// <summary>
    /// The path the AWS auth backend being configured was
    /// mounted at.  Defaults to aws.
    /// Unique name of the auth backend to configure.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Backend in auth to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1AuthBackendClientSpecInitProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Backend in auth to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1AuthBackendClientSpecInitProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// Override the URL Vault uses when making EC2 API
    /// calls.
    /// URL to override the default generated endpoint for making AWS EC2 API calls.
    /// </summary>
    [JsonPropertyName("ec2Endpoint")]
    public string? Ec2Endpoint { get; set; }

    /// <summary>
    /// Override the URL Vault uses when making IAM API
    /// calls.
    /// URL to override the default generated endpoint for making AWS IAM API calls.
    /// </summary>
    [JsonPropertyName("iamEndpoint")]
    public string? IamEndpoint { get; set; }

    /// <summary>
    /// The value to require in the
    /// X-Vault-AWS-IAM-Server-ID header as part of GetCallerIdentity requests
    /// that are used in the IAM auth method.
    /// The value to require in the X-Vault-AWS-IAM-Server-ID header as part of GetCallerIdentity requests that are used in the iam auth method.
    /// </summary>
    [JsonPropertyName("iamServerIdHeaderValue")]
    public string? IamServerIdHeaderValue { get; set; }

    /// <summary>
    /// The audience claim value. Mutually exclusive with access_key.
    /// Requires Vault 1.17+. Available only for Vault Enterprise
    /// The audience claim value.
    /// </summary>
    [JsonPropertyName("identityTokenAudience")]
    public string? IdentityTokenAudience { get; set; }

    /// <summary>
    /// The TTL of generated identity tokens in seconds. Requires Vault 1.17+.
    /// Available only for Vault Enterprise
    /// The TTL of generated identity tokens in seconds.
    /// </summary>
    [JsonPropertyName("identityTokenTtl")]
    public double? IdentityTokenTtl { get; set; }

    /// <summary>
    /// Number of max retries the client should use for recoverable errors.
    /// The default -1 falls back to the AWS SDK&apos;s default behavior.
    /// Number of max retries the client should use for recoverable errors.
    /// </summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

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
    /// Role ARN to assume for plugin identity token federation. Requires Vault 1.17+.
    /// Available only for Vault Enterprise
    /// Role ARN to assume for plugin identity token federation.
    /// </summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// The AWS secret key that Vault should use for the
    /// auth backend. Mutually exclusive with secret_key_wo.
    /// Consider using secret_key_wo instead for enhanced security.
    /// AWS Secret key with permissions to query AWS APIs.
    /// </summary>
    [JsonPropertyName("secretKeySecretRef")]
    public V1alpha1AuthBackendClientSpecInitProviderSecretKeySecretRef? SecretKeySecretRef { get; set; }

    /// <summary>
    /// Write-only AWS secret key that Vault should use for the
    /// auth backend. Mutually exclusive with secret_key.
    /// Must be used together with secret_key_wo_version.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only AWS Secret key with permissions to query AWS APIs. This field is recommended over secret_key for enhanced security.
    /// </summary>
    [JsonPropertyName("secretKeyWoSecretRef")]
    public V1alpha1AuthBackendClientSpecInitProviderSecretKeyWoSecretRef? SecretKeyWoSecretRef { get; set; }

    /// <summary>
    /// Version counter for the write-only secret_key_wo field.
    /// Increment this value to rotate the secret key. Required when secret_key_wo is set.
    /// Version counter for write-only secret_key field. Increment this value to force update of the secret.
    /// </summary>
    [JsonPropertyName("secretKeyWoVersion")]
    public double? SecretKeyWoVersion { get; set; }

    /// <summary>
    /// Override the URL Vault uses when making STS API
    /// calls.
    /// URL to override the default generated endpoint for making AWS STS API calls.
    /// </summary>
    [JsonPropertyName("stsEndpoint")]
    public string? StsEndpoint { get; set; }

    /// <summary>
    /// Override the default region when making STS API
    /// calls. The sts_endpoint argument must be set when using sts_region.
    /// Region to override the default region for making AWS STS API calls.
    /// </summary>
    [JsonPropertyName("stsRegion")]
    public string? StsRegion { get; set; }

    /// <summary>
    /// Available in Vault v1.15+. If set,
    /// overrides both sts_endpoint and sts_region to instead use the region
    /// specified in the client request headers for IAM-based authentication.
    /// This can be useful when you have client requests coming from different
    /// regions and want flexibility in which regional STS API is used.
    /// If set, will override sts_region and use the region from the client request&apos;s header
    /// </summary>
    [JsonPropertyName("useStsRegionFromClient")]
    public bool? UseStsRegionFromClient { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendClientSpecManagementPoliciesEnum>))]
public enum V1alpha1AuthBackendClientSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendClientSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha1AuthBackendClientSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendClientSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha1AuthBackendClientSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1AuthBackendClientSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1AuthBackendClientSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1AuthBackendClientSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AuthBackendClientSpec defines the desired state of AuthBackendClient</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientSpec
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
    public V1alpha1AuthBackendClientSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1AuthBackendClientSpecForProvider ForProvider { get; set; }

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
    public V1alpha1AuthBackendClientSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1AuthBackendClientSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1AuthBackendClientSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1AuthBackendClientSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientStatusAtProvider
{
    /// <summary>
    /// List of additional headers that are allowed to be in STS request headers.
    /// The headers are automatically canonicalized (e.g., content-type becomes Content-Type). Duplicate values are automatically
    /// removed. This can be useful when you need to allow specific headers in STS requests for IAM-based authentication.
    /// List of additional headers that are allowed to be in STS request headers.
    /// </summary>
    [JsonPropertyName("allowedStsHeaderValues")]
    public IList<string>? AllowedStsHeaderValues { get; set; }

    /// <summary>
    /// The path the AWS auth backend being configured was
    /// mounted at.  Defaults to aws.
    /// Unique name of the auth backend to configure.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// Override the URL Vault uses when making EC2 API
    /// calls.
    /// URL to override the default generated endpoint for making AWS EC2 API calls.
    /// </summary>
    [JsonPropertyName("ec2Endpoint")]
    public string? Ec2Endpoint { get; set; }

    /// <summary>
    /// Override the URL Vault uses when making IAM API
    /// calls.
    /// URL to override the default generated endpoint for making AWS IAM API calls.
    /// </summary>
    [JsonPropertyName("iamEndpoint")]
    public string? IamEndpoint { get; set; }

    /// <summary>
    /// The value to require in the
    /// X-Vault-AWS-IAM-Server-ID header as part of GetCallerIdentity requests
    /// that are used in the IAM auth method.
    /// The value to require in the X-Vault-AWS-IAM-Server-ID header as part of GetCallerIdentity requests that are used in the iam auth method.
    /// </summary>
    [JsonPropertyName("iamServerIdHeaderValue")]
    public string? IamServerIdHeaderValue { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The audience claim value. Mutually exclusive with access_key.
    /// Requires Vault 1.17+. Available only for Vault Enterprise
    /// The audience claim value.
    /// </summary>
    [JsonPropertyName("identityTokenAudience")]
    public string? IdentityTokenAudience { get; set; }

    /// <summary>
    /// The TTL of generated identity tokens in seconds. Requires Vault 1.17+.
    /// Available only for Vault Enterprise
    /// The TTL of generated identity tokens in seconds.
    /// </summary>
    [JsonPropertyName("identityTokenTtl")]
    public double? IdentityTokenTtl { get; set; }

    /// <summary>
    /// Number of max retries the client should use for recoverable errors.
    /// The default -1 falls back to the AWS SDK&apos;s default behavior.
    /// Number of max retries the client should use for recoverable errors.
    /// </summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

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
    /// Role ARN to assume for plugin identity token federation. Requires Vault 1.17+.
    /// Available only for Vault Enterprise
    /// Role ARN to assume for plugin identity token federation.
    /// </summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Version counter for the write-only secret_key_wo field.
    /// Increment this value to rotate the secret key. Required when secret_key_wo is set.
    /// Version counter for write-only secret_key field. Increment this value to force update of the secret.
    /// </summary>
    [JsonPropertyName("secretKeyWoVersion")]
    public double? SecretKeyWoVersion { get; set; }

    /// <summary>
    /// Override the URL Vault uses when making STS API
    /// calls.
    /// URL to override the default generated endpoint for making AWS STS API calls.
    /// </summary>
    [JsonPropertyName("stsEndpoint")]
    public string? StsEndpoint { get; set; }

    /// <summary>
    /// Override the default region when making STS API
    /// calls. The sts_endpoint argument must be set when using sts_region.
    /// Region to override the default region for making AWS STS API calls.
    /// </summary>
    [JsonPropertyName("stsRegion")]
    public string? StsRegion { get; set; }

    /// <summary>
    /// Available in Vault v1.15+. If set,
    /// overrides both sts_endpoint and sts_region to instead use the region
    /// specified in the client request headers for IAM-based authentication.
    /// This can be useful when you have client requests coming from different
    /// regions and want flexibility in which regional STS API is used.
    /// If set, will override sts_region and use the region from the client request&apos;s header
    /// </summary>
    [JsonPropertyName("useStsRegionFromClient")]
    public bool? UseStsRegionFromClient { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientStatusConditions
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

/// <summary>AuthBackendClientStatus defines the observed state of AuthBackendClient.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendClientStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1AuthBackendClientStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AuthBackendClientStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AuthBackendClient is the Schema for the AuthBackendClients API. Configures the client used by an AWS Auth Backend in Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AuthBackendClient : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AuthBackendClientSpec>, IStatus<V1alpha1AuthBackendClientStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AuthBackendClient";
    public const string KubeGroup = "aws.vault.upbound.io";
    public const string KubePluralName = "authbackendclients";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "aws.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AuthBackendClient";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AuthBackendClientSpec defines the desired state of AuthBackendClient</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1AuthBackendClientSpec Spec { get; set; }

    /// <summary>AuthBackendClientStatus defines the observed state of AuthBackendClient.</summary>
    [JsonPropertyName("status")]
    public V1alpha1AuthBackendClientStatus? Status { get; set; }
}
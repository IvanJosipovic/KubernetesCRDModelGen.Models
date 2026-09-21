#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bedrockagentcore.aws.m.upbound.io;
/// <summary>Oauth2CredentialProvider is the Schema for the Oauth2CredentialProviders API. Manages an AWS Bedrock AgentCore OAuth2 Credential Provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Oauth2CredentialProviderList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Oauth2CredentialProvider>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Oauth2CredentialProviderList";
    public const string KubeGroup = "bedrockagentcore.aws.m.upbound.io";
    public const string KubePluralName = "oauth2credentialproviders";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagentcore.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Oauth2CredentialProviderList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Oauth2CredentialProvider objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Oauth2CredentialProvider> Items { get; set; }
}

/// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRef? SecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdSelector")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelector? SecretIdSelector { get; set; }
}

/// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Atlassian OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRef? SecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdSelector")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelector? SecretIdSelector { get; set; }
}

/// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>List of authentication methods supported by the token endpoint. Must contain one or two values matching client_secret_post or client_secret_basic.</summary>
    [JsonPropertyName("tokenEndpointAuthMethods")]
    public IList<string>? TokenEndpointAuthMethods { get; set; }
}

/// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Configuration specific to the TOKEN_EXCHANGE grant type (RFC 8693). See token_exchange_grant_type_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfigTokenExchangeGrantTypeConfig
{
    /// <summary>Content type for the actor token in the token exchange. Valid values: NONE, M2M, AWS_IAM_ID_TOKEN_JWT.</summary>
    [JsonPropertyName("actorTokenContent")]
    public string? ActorTokenContent { get; set; }

    /// <summary>Set of scopes for the actor token. Only valid when actor_token_content is M2M.</summary>
    [JsonPropertyName("actorTokenScopes")]
    public IList<string>? ActorTokenScopes { get; set; }
}

/// <summary>On-behalf-of token exchange configuration, enabling RFC 8693 token exchange or RFC 7523 JWT authorization grant flows. See on_behalf_of_token_exchange_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfig
{
    /// <summary>Grant type for the on-behalf-of token exchange. Valid values: TOKEN_EXCHANGE, JWT_AUTHORIZATION_GRANT.</summary>
    [JsonPropertyName("grantType")]
    public string? GrantType { get; set; }

    /// <summary>Configuration specific to the TOKEN_EXCHANGE grant type (RFC 8693). See token_exchange_grant_type_config below.</summary>
    [JsonPropertyName("tokenExchangeGrantTypeConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfigTokenExchangeGrantTypeConfig? TokenExchangeGrantTypeConfig { get; set; }
}

/// <summary>Service-managed VPC resource configuration. See managed_vpc_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointManagedVpcResource
{
    /// <summary>IP address type for the endpoint. Valid values: IPV4, DUALSTACK.</summary>
    [JsonPropertyName("endpointIpAddressType")]
    public string? EndpointIpAddressType { get; set; }

    /// <summary>Routing domain for the managed VPC resource.</summary>
    [JsonPropertyName("routingDomain")]
    public string? RoutingDomain { get; set; }

    /// <summary>Set of up to 5 security group IDs for the managed VPC resource.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Set of subnet IDs for the managed VPC resource.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Identifier of the VPC.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

/// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint configuration for the domain. See private_endpoint above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpoint
{
    /// <summary>Service-managed VPC resource configuration. See managed_vpc_resource below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

/// <summary>Service-managed VPC resource configuration. See managed_vpc_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpointManagedVpcResource
{
    /// <summary>IP address type for the endpoint. Valid values: IPV4, DUALSTACK.</summary>
    [JsonPropertyName("endpointIpAddressType")]
    public string? EndpointIpAddressType { get; set; }

    /// <summary>Routing domain for the managed VPC resource.</summary>
    [JsonPropertyName("routingDomain")]
    public string? RoutingDomain { get; set; }

    /// <summary>Set of up to 5 security group IDs for the managed VPC resource.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Set of subnet IDs for the managed VPC resource.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Identifier of the VPC.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

/// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint configuration for the domain. See private_endpoint above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpoint
{
    /// <summary>Service-managed VPC resource configuration. See managed_vpc_resource below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverride
{
    /// <summary>Domain the private endpoint override applies to.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Private endpoint configuration for the domain. See private_endpoint above.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpoint? PrivateEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateKeyJwtConfigPrivateKeySourceKmsKeySource
{
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateKeyJwtConfigPrivateKeySource
{
    [JsonPropertyName("kmsKeySource")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateKeyJwtConfigPrivateKeySourceKmsKeySource? KmsKeySource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateKeyJwtConfig
{
    [JsonPropertyName("additionalHeaderClaims")]
    public IDictionary<string, string>? AdditionalHeaderClaims { get; set; }

    [JsonPropertyName("additionalPayloadClaims")]
    public IDictionary<string, string>? AdditionalPayloadClaims { get; set; }

    [JsonPropertyName("privateKeySource")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateKeyJwtConfigPrivateKeySource? PrivateKeySource { get; set; }

    [JsonPropertyName("signingAlgorithm")]
    public string? SigningAlgorithm { get; set; }
}

/// <summary>Custom OAuth2 provider configuration. See custom below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfig
{
    /// <summary>Client authentication method used with the token endpoint. Valid values: CLIENT_SECRET_BASIC, CLIENT_SECRET_POST, AWS_IAM_ID_TOKEN_JWT.</summary>
    [JsonPropertyName("clientAuthenticationMethod")]
    public string? ClientAuthenticationMethod { get; set; }

    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscovery? OauthDiscovery { get; set; }

    /// <summary>On-behalf-of token exchange configuration, enabling RFC 8693 token exchange or RFC 7523 JWT authorization grant flows. See on_behalf_of_token_exchange_config below.</summary>
    [JsonPropertyName("onBehalfOfTokenExchangeConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfig? OnBehalfOfTokenExchangeConfig { get; set; }

    /// <summary>Private endpoint configuration for the domain. See private_endpoint above.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>Private endpoint overrides for the custom OAuth2 provider configuration. See private_endpoint_override below.</summary>
    [JsonPropertyName("privateEndpointOverride")]
    public IList<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverride>? PrivateEndpointOverride { get; set; }

    [JsonPropertyName("privateKeyJwtConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateKeyJwtConfig? PrivateKeyJwtConfig { get; set; }
}

/// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRef? SecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdSelector")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelector? SecretIdSelector { get; set; }
}

/// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>GitHub OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRef? SecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdSelector")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelector? SecretIdSelector { get; set; }
}

/// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Google OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRef? SecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdSelector")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelector? SecretIdSelector { get; set; }
}

/// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Configuration for an included (vendor-supported) OAuth2 provider, used for the additional supported vendors. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfig
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

/// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRef? SecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdSelector")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelector? SecretIdSelector { get; set; }
}

/// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>LinkedIn OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRef? SecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdSelector")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelector? SecretIdSelector { get; set; }
}

/// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Microsoft Entra (Azure AD) tenant ID. Cannot be used with tenant_id_wo.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigTenantIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only Microsoft Entra (Azure AD) tenant ID. Cannot be used with tenant_id. Must be used together with tenant_id_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigTenantIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Microsoft OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }

    /// <summary>Microsoft Entra (Azure AD) tenant ID. Cannot be used with tenant_id_wo.</summary>
    [JsonPropertyName("tenantIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigTenantIdSecretRef? TenantIdSecretRef { get; set; }

    /// <summary>Write-only Microsoft Entra (Azure AD) tenant ID. Cannot be used with tenant_id. Must be used together with tenant_id_wo_version.</summary>
    [JsonPropertyName("tenantIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigTenantIdWoSecretRef? TenantIdWoSecretRef { get; set; }

    /// <summary>Used together with write-only tenant ID to trigger an update. Increment this value when an update to tenant_id_wo is required.</summary>
    [JsonPropertyName("tenantIdWoVersion")]
    public double? TenantIdWoVersion { get; set; }
}

/// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRef? SecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdSelector")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelector? SecretIdSelector { get; set; }
}

/// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Salesforce OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRef? SecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdSelector")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelector? SecretIdSelector { get; set; }
}

/// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Slack OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 provider configuration. Must contain exactly one provider type. See oauth2_provider_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfig
{
    /// <summary>Atlassian OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("atlassianOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigAtlassianOauth2ProviderConfig? AtlassianOauth2ProviderConfig { get; set; }

    /// <summary>Custom OAuth2 provider configuration. See custom below.</summary>
    [JsonPropertyName("customOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigCustomOauth2ProviderConfig? CustomOauth2ProviderConfig { get; set; }

    /// <summary>GitHub OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("githubOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGithubOauth2ProviderConfig? GithubOauth2ProviderConfig { get; set; }

    /// <summary>Google OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("googleOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigGoogleOauth2ProviderConfig? GoogleOauth2ProviderConfig { get; set; }

    /// <summary>Configuration for an included (vendor-supported) OAuth2 provider, used for the additional supported vendors. See predefined providers below.</summary>
    [JsonPropertyName("includedOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigIncludedOauth2ProviderConfig? IncludedOauth2ProviderConfig { get; set; }

    /// <summary>LinkedIn OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("linkedinOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigLinkedinOauth2ProviderConfig? LinkedinOauth2ProviderConfig { get; set; }

    /// <summary>Microsoft OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("microsoftOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig? MicrosoftOauth2ProviderConfig { get; set; }

    /// <summary>Salesforce OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("salesforceOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig? SalesforceOauth2ProviderConfig { get; set; }

    /// <summary>Slack OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("slackOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfigSlackOauth2ProviderConfig? SlackOauth2ProviderConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecForProvider
{
    /// <summary>Vendor of the OAuth2 credential provider. Valid values include CustomOauth2, GithubOauth2, GoogleOauth2, MicrosoftOauth2, SalesforceOauth2, SlackOauth2, AtlassianOauth2, LinkedinOauth2, and a number of additional supported vendors (e.g. XOauth2, FacebookOauth2, SpotifyOauth2) configured via included_oauth2_provider_config. Refer to the AWS API for the full, current list. See the note under included_oauth2_provider_config for vendors that are not yet supported.</summary>
    [JsonPropertyName("credentialProviderVendor")]
    public string? CredentialProviderVendor { get; set; }

    /// <summary>OAuth2 provider configuration. Must contain exactly one provider type. See oauth2_provider_config below.</summary>
    [JsonPropertyName("oauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecForProviderOauth2ProviderConfig? Oauth2ProviderConfig { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdRef? SecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdSelector")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfigSecretIdSelector? SecretIdSelector { get; set; }
}

/// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Atlassian OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdRef? SecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdSelector")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfigSecretIdSelector? SecretIdSelector { get; set; }
}

/// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>List of authentication methods supported by the token endpoint. Must contain one or two values matching client_secret_post or client_secret_basic.</summary>
    [JsonPropertyName("tokenEndpointAuthMethods")]
    public IList<string>? TokenEndpointAuthMethods { get; set; }
}

/// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Configuration specific to the TOKEN_EXCHANGE grant type (RFC 8693). See token_exchange_grant_type_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfigTokenExchangeGrantTypeConfig
{
    /// <summary>Content type for the actor token in the token exchange. Valid values: NONE, M2M, AWS_IAM_ID_TOKEN_JWT.</summary>
    [JsonPropertyName("actorTokenContent")]
    public string? ActorTokenContent { get; set; }

    /// <summary>Set of scopes for the actor token. Only valid when actor_token_content is M2M.</summary>
    [JsonPropertyName("actorTokenScopes")]
    public IList<string>? ActorTokenScopes { get; set; }
}

/// <summary>On-behalf-of token exchange configuration, enabling RFC 8693 token exchange or RFC 7523 JWT authorization grant flows. See on_behalf_of_token_exchange_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfig
{
    /// <summary>Grant type for the on-behalf-of token exchange. Valid values: TOKEN_EXCHANGE, JWT_AUTHORIZATION_GRANT.</summary>
    [JsonPropertyName("grantType")]
    public string? GrantType { get; set; }

    /// <summary>Configuration specific to the TOKEN_EXCHANGE grant type (RFC 8693). See token_exchange_grant_type_config below.</summary>
    [JsonPropertyName("tokenExchangeGrantTypeConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfigTokenExchangeGrantTypeConfig? TokenExchangeGrantTypeConfig { get; set; }
}

/// <summary>Service-managed VPC resource configuration. See managed_vpc_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointManagedVpcResource
{
    /// <summary>IP address type for the endpoint. Valid values: IPV4, DUALSTACK.</summary>
    [JsonPropertyName("endpointIpAddressType")]
    public string? EndpointIpAddressType { get; set; }

    /// <summary>Routing domain for the managed VPC resource.</summary>
    [JsonPropertyName("routingDomain")]
    public string? RoutingDomain { get; set; }

    /// <summary>Set of up to 5 security group IDs for the managed VPC resource.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Set of subnet IDs for the managed VPC resource.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Identifier of the VPC.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

/// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint configuration for the domain. See private_endpoint above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpoint
{
    /// <summary>Service-managed VPC resource configuration. See managed_vpc_resource below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

/// <summary>Service-managed VPC resource configuration. See managed_vpc_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpointManagedVpcResource
{
    /// <summary>IP address type for the endpoint. Valid values: IPV4, DUALSTACK.</summary>
    [JsonPropertyName("endpointIpAddressType")]
    public string? EndpointIpAddressType { get; set; }

    /// <summary>Routing domain for the managed VPC resource.</summary>
    [JsonPropertyName("routingDomain")]
    public string? RoutingDomain { get; set; }

    /// <summary>Set of up to 5 security group IDs for the managed VPC resource.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Set of subnet IDs for the managed VPC resource.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Identifier of the VPC.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

/// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint configuration for the domain. See private_endpoint above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpoint
{
    /// <summary>Service-managed VPC resource configuration. See managed_vpc_resource below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverride
{
    /// <summary>Domain the private endpoint override applies to.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Private endpoint configuration for the domain. See private_endpoint above.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpoint? PrivateEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateKeyJwtConfigPrivateKeySourceKmsKeySource
{
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateKeyJwtConfigPrivateKeySource
{
    [JsonPropertyName("kmsKeySource")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateKeyJwtConfigPrivateKeySourceKmsKeySource? KmsKeySource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateKeyJwtConfig
{
    [JsonPropertyName("additionalHeaderClaims")]
    public IDictionary<string, string>? AdditionalHeaderClaims { get; set; }

    [JsonPropertyName("additionalPayloadClaims")]
    public IDictionary<string, string>? AdditionalPayloadClaims { get; set; }

    [JsonPropertyName("privateKeySource")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateKeyJwtConfigPrivateKeySource? PrivateKeySource { get; set; }

    [JsonPropertyName("signingAlgorithm")]
    public string? SigningAlgorithm { get; set; }
}

/// <summary>Custom OAuth2 provider configuration. See custom below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfig
{
    /// <summary>Client authentication method used with the token endpoint. Valid values: CLIENT_SECRET_BASIC, CLIENT_SECRET_POST, AWS_IAM_ID_TOKEN_JWT.</summary>
    [JsonPropertyName("clientAuthenticationMethod")]
    public string? ClientAuthenticationMethod { get; set; }

    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscovery? OauthDiscovery { get; set; }

    /// <summary>On-behalf-of token exchange configuration, enabling RFC 8693 token exchange or RFC 7523 JWT authorization grant flows. See on_behalf_of_token_exchange_config below.</summary>
    [JsonPropertyName("onBehalfOfTokenExchangeConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfig? OnBehalfOfTokenExchangeConfig { get; set; }

    /// <summary>Private endpoint configuration for the domain. See private_endpoint above.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>Private endpoint overrides for the custom OAuth2 provider configuration. See private_endpoint_override below.</summary>
    [JsonPropertyName("privateEndpointOverride")]
    public IList<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverride>? PrivateEndpointOverride { get; set; }

    [JsonPropertyName("privateKeyJwtConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateKeyJwtConfig? PrivateKeyJwtConfig { get; set; }
}

/// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdRef? SecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdSelector")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfigSecretIdSelector? SecretIdSelector { get; set; }
}

/// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>GitHub OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdRef? SecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdSelector")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfigSecretIdSelector? SecretIdSelector { get; set; }
}

/// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Google OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdRef? SecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdSelector")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfigSecretIdSelector? SecretIdSelector { get; set; }
}

/// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Configuration for an included (vendor-supported) OAuth2 provider, used for the additional supported vendors. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfig
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

/// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdRef? SecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdSelector")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfigSecretIdSelector? SecretIdSelector { get; set; }
}

/// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>LinkedIn OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdRef? SecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdSelector")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfigSecretIdSelector? SecretIdSelector { get; set; }
}

/// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Microsoft Entra (Azure AD) tenant ID. Cannot be used with tenant_id_wo.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigTenantIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only Microsoft Entra (Azure AD) tenant ID. Cannot be used with tenant_id. Must be used together with tenant_id_wo_version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigTenantIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Microsoft OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }

    /// <summary>Microsoft Entra (Azure AD) tenant ID. Cannot be used with tenant_id_wo.</summary>
    [JsonPropertyName("tenantIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigTenantIdSecretRef? TenantIdSecretRef { get; set; }

    /// <summary>Write-only Microsoft Entra (Azure AD) tenant ID. Cannot be used with tenant_id. Must be used together with tenant_id_wo_version.</summary>
    [JsonPropertyName("tenantIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigTenantIdWoSecretRef? TenantIdWoSecretRef { get; set; }

    /// <summary>Used together with write-only tenant ID to trigger an update. Increment this value when an update to tenant_id_wo is required.</summary>
    [JsonPropertyName("tenantIdWoVersion")]
    public double? TenantIdWoVersion { get; set; }
}

/// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdRef? SecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdSelector")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfigSecretIdSelector? SecretIdSelector { get; set; }
}

/// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Salesforce OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientIdWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdRef? SecretIdRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate secretId.</summary>
    [JsonPropertyName("secretIdSelector")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfigSecretIdSelector? SecretIdSelector { get; set; }
}

/// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Slack OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>OAuth2 client ID. Conflicts with client_id_wo. Must be used together with client_secret.</summary>
    [JsonPropertyName("clientIdSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientIdSecretRef? ClientIdSecretRef { get; set; }

    /// <summary>Write-only OAuth2 client ID. Conflicts with client_id. If set, requires client_secret_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientIdWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientIdWoSecretRef? ClientIdWoSecretRef { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>OAuth2 client secret. Conflicts with client_secret_wo. Must be used together with client_id.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>Write-only OAuth2 client secret. Conflicts with client_secret. If set, requires client_id_wo and client_credentials_wo_version to be set.</summary>
    [JsonPropertyName("clientSecretWoSecretRef")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretWoSecretRef? ClientSecretWoSecretRef { get; set; }
}

/// <summary>OAuth2 provider configuration. Must contain exactly one provider type. See oauth2_provider_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfig
{
    /// <summary>Atlassian OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("atlassianOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigAtlassianOauth2ProviderConfig? AtlassianOauth2ProviderConfig { get; set; }

    /// <summary>Custom OAuth2 provider configuration. See custom below.</summary>
    [JsonPropertyName("customOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigCustomOauth2ProviderConfig? CustomOauth2ProviderConfig { get; set; }

    /// <summary>GitHub OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("githubOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGithubOauth2ProviderConfig? GithubOauth2ProviderConfig { get; set; }

    /// <summary>Google OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("googleOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigGoogleOauth2ProviderConfig? GoogleOauth2ProviderConfig { get; set; }

    /// <summary>Configuration for an included (vendor-supported) OAuth2 provider, used for the additional supported vendors. See predefined providers below.</summary>
    [JsonPropertyName("includedOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigIncludedOauth2ProviderConfig? IncludedOauth2ProviderConfig { get; set; }

    /// <summary>LinkedIn OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("linkedinOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigLinkedinOauth2ProviderConfig? LinkedinOauth2ProviderConfig { get; set; }

    /// <summary>Microsoft OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("microsoftOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig? MicrosoftOauth2ProviderConfig { get; set; }

    /// <summary>Salesforce OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("salesforceOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig? SalesforceOauth2ProviderConfig { get; set; }

    /// <summary>Slack OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("slackOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfigSlackOauth2ProviderConfig? SlackOauth2ProviderConfig { get; set; }
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
public partial class V1beta1Oauth2CredentialProviderSpecInitProvider
{
    /// <summary>Vendor of the OAuth2 credential provider. Valid values include CustomOauth2, GithubOauth2, GoogleOauth2, MicrosoftOauth2, SalesforceOauth2, SlackOauth2, AtlassianOauth2, LinkedinOauth2, and a number of additional supported vendors (e.g. XOauth2, FacebookOauth2, SpotifyOauth2) configured via included_oauth2_provider_config. Refer to the AWS API for the full, current list. See the note under included_oauth2_provider_config for vendors that are not yet supported.</summary>
    [JsonPropertyName("credentialProviderVendor")]
    public string? CredentialProviderVendor { get; set; }

    /// <summary>OAuth2 provider configuration. Must contain exactly one provider type. See oauth2_provider_config below.</summary>
    [JsonPropertyName("oauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderSpecInitProviderOauth2ProviderConfig? Oauth2ProviderConfig { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1Oauth2CredentialProviderSpecManagementPoliciesEnum>))]
public enum V1beta1Oauth2CredentialProviderSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Oauth2CredentialProviderSpec defines the desired state of Oauth2CredentialProvider</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1Oauth2CredentialProviderSpecForProvider ForProvider { get; set; }

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
    public V1beta1Oauth2CredentialProviderSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1Oauth2CredentialProviderSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1Oauth2CredentialProviderSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1Oauth2CredentialProviderSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderClientSecretArn
{
    /// <summary>ARN of the secret in AWS Secrets Manager.</summary>
    [JsonPropertyName("secretArn")]
    public string? SecretArn { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>List of authentication methods supported by the token endpoint. Must contain one or two values matching client_secret_post or client_secret_basic.</summary>
    [JsonPropertyName("tokenEndpointAuthMethods")]
    public IList<string>? TokenEndpointAuthMethods { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata>? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Atlassian OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigAtlassianOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigAtlassianOauth2ProviderConfigOauthDiscovery>? OauthDiscovery { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }
}

/// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>List of authentication methods supported by the token endpoint. Must contain one or two values matching client_secret_post or client_secret_basic.</summary>
    [JsonPropertyName("tokenEndpointAuthMethods")]
    public IList<string>? TokenEndpointAuthMethods { get; set; }
}

/// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Configuration specific to the TOKEN_EXCHANGE grant type (RFC 8693). See token_exchange_grant_type_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfigTokenExchangeGrantTypeConfig
{
    /// <summary>Content type for the actor token in the token exchange. Valid values: NONE, M2M, AWS_IAM_ID_TOKEN_JWT.</summary>
    [JsonPropertyName("actorTokenContent")]
    public string? ActorTokenContent { get; set; }

    /// <summary>Set of scopes for the actor token. Only valid when actor_token_content is M2M.</summary>
    [JsonPropertyName("actorTokenScopes")]
    public IList<string>? ActorTokenScopes { get; set; }
}

/// <summary>On-behalf-of token exchange configuration, enabling RFC 8693 token exchange or RFC 7523 JWT authorization grant flows. See on_behalf_of_token_exchange_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfig
{
    /// <summary>Grant type for the on-behalf-of token exchange. Valid values: TOKEN_EXCHANGE, JWT_AUTHORIZATION_GRANT.</summary>
    [JsonPropertyName("grantType")]
    public string? GrantType { get; set; }

    /// <summary>Configuration specific to the TOKEN_EXCHANGE grant type (RFC 8693). See token_exchange_grant_type_config below.</summary>
    [JsonPropertyName("tokenExchangeGrantTypeConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfigTokenExchangeGrantTypeConfig? TokenExchangeGrantTypeConfig { get; set; }
}

/// <summary>Service-managed VPC resource configuration. See managed_vpc_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointManagedVpcResource
{
    /// <summary>IP address type for the endpoint. Valid values: IPV4, DUALSTACK.</summary>
    [JsonPropertyName("endpointIpAddressType")]
    public string? EndpointIpAddressType { get; set; }

    /// <summary>Routing domain for the managed VPC resource.</summary>
    [JsonPropertyName("routingDomain")]
    public string? RoutingDomain { get; set; }

    /// <summary>Set of up to 5 security group IDs for the managed VPC resource.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Set of subnet IDs for the managed VPC resource.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Identifier of the VPC.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

/// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint configuration for the domain. See private_endpoint above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpoint
{
    /// <summary>Service-managed VPC resource configuration. See managed_vpc_resource below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

/// <summary>Service-managed VPC resource configuration. See managed_vpc_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpointManagedVpcResource
{
    /// <summary>IP address type for the endpoint. Valid values: IPV4, DUALSTACK.</summary>
    [JsonPropertyName("endpointIpAddressType")]
    public string? EndpointIpAddressType { get; set; }

    /// <summary>Routing domain for the managed VPC resource.</summary>
    [JsonPropertyName("routingDomain")]
    public string? RoutingDomain { get; set; }

    /// <summary>Set of up to 5 security group IDs for the managed VPC resource.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>Set of subnet IDs for the managed VPC resource.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Identifier of the VPC.</summary>
    [JsonPropertyName("vpcIdentifier")]
    public string? VpcIdentifier { get; set; }
}

/// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpointSelfManagedLatticeResource
{
    /// <summary>Identifier of the VPC Lattice resource configuration.</summary>
    [JsonPropertyName("resourceConfigurationIdentifier")]
    public string? ResourceConfigurationIdentifier { get; set; }
}

/// <summary>Private endpoint configuration for the domain. See private_endpoint above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpoint
{
    /// <summary>Service-managed VPC resource configuration. See managed_vpc_resource below.</summary>
    [JsonPropertyName("managedVpcResource")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpointManagedVpcResource? ManagedVpcResource { get; set; }

    /// <summary>Self-managed VPC Lattice resource configuration. See self_managed_lattice_resource below.</summary>
    [JsonPropertyName("selfManagedLatticeResource")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpointSelfManagedLatticeResource? SelfManagedLatticeResource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverride
{
    /// <summary>Domain the private endpoint override applies to.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Private endpoint configuration for the domain. See private_endpoint above.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverridePrivateEndpoint? PrivateEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateKeyJwtConfigPrivateKeySourceKmsKeySource
{
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateKeyJwtConfigPrivateKeySource
{
    [JsonPropertyName("kmsKeySource")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateKeyJwtConfigPrivateKeySourceKmsKeySource? KmsKeySource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateKeyJwtConfig
{
    [JsonPropertyName("additionalHeaderClaims")]
    public IDictionary<string, string>? AdditionalHeaderClaims { get; set; }

    [JsonPropertyName("additionalPayloadClaims")]
    public IDictionary<string, string>? AdditionalPayloadClaims { get; set; }

    [JsonPropertyName("privateKeySource")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateKeyJwtConfigPrivateKeySource? PrivateKeySource { get; set; }

    [JsonPropertyName("signingAlgorithm")]
    public string? SigningAlgorithm { get; set; }
}

/// <summary>Custom OAuth2 provider configuration. See custom below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfig
{
    /// <summary>Client authentication method used with the token endpoint. Valid values: CLIENT_SECRET_BASIC, CLIENT_SECRET_POST, AWS_IAM_ID_TOKEN_JWT.</summary>
    [JsonPropertyName("clientAuthenticationMethod")]
    public string? ClientAuthenticationMethod { get; set; }

    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigOauthDiscovery? OauthDiscovery { get; set; }

    /// <summary>On-behalf-of token exchange configuration, enabling RFC 8693 token exchange or RFC 7523 JWT authorization grant flows. See on_behalf_of_token_exchange_config below.</summary>
    [JsonPropertyName("onBehalfOfTokenExchangeConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigOnBehalfOfTokenExchangeConfig? OnBehalfOfTokenExchangeConfig { get; set; }

    /// <summary>Private endpoint configuration for the domain. See private_endpoint above.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>Private endpoint overrides for the custom OAuth2 provider configuration. See private_endpoint_override below.</summary>
    [JsonPropertyName("privateEndpointOverride")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateEndpointOverride>? PrivateEndpointOverride { get; set; }

    [JsonPropertyName("privateKeyJwtConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfigPrivateKeyJwtConfig? PrivateKeyJwtConfig { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGithubOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>List of authentication methods supported by the token endpoint. Must contain one or two values matching client_secret_post or client_secret_basic.</summary>
    [JsonPropertyName("tokenEndpointAuthMethods")]
    public IList<string>? TokenEndpointAuthMethods { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGithubOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGithubOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata>? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>GitHub OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGithubOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGithubOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGithubOauth2ProviderConfigOauthDiscovery>? OauthDiscovery { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGoogleOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>List of authentication methods supported by the token endpoint. Must contain one or two values matching client_secret_post or client_secret_basic.</summary>
    [JsonPropertyName("tokenEndpointAuthMethods")]
    public IList<string>? TokenEndpointAuthMethods { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGoogleOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGoogleOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata>? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Google OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGoogleOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGoogleOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGoogleOauth2ProviderConfigOauthDiscovery>? OauthDiscovery { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigIncludedOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>List of authentication methods supported by the token endpoint. Must contain one or two values matching client_secret_post or client_secret_basic.</summary>
    [JsonPropertyName("tokenEndpointAuthMethods")]
    public IList<string>? TokenEndpointAuthMethods { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigIncludedOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigIncludedOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata>? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Configuration for an included (vendor-supported) OAuth2 provider, used for the additional supported vendors. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigIncludedOauth2ProviderConfig
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigIncludedOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigIncludedOauth2ProviderConfigOauthDiscovery>? OauthDiscovery { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>List of authentication methods supported by the token endpoint. Must contain one or two values matching client_secret_post or client_secret_basic.</summary>
    [JsonPropertyName("tokenEndpointAuthMethods")]
    public IList<string>? TokenEndpointAuthMethods { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata>? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>LinkedIn OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigLinkedinOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigLinkedinOauth2ProviderConfigOauthDiscovery>? OauthDiscovery { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>List of authentication methods supported by the token endpoint. Must contain one or two values matching client_secret_post or client_secret_basic.</summary>
    [JsonPropertyName("tokenEndpointAuthMethods")]
    public IList<string>? TokenEndpointAuthMethods { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata>? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Microsoft OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfigOauthDiscovery>? OauthDiscovery { get; set; }

    /// <summary>Used together with write-only tenant ID to trigger an update. Increment this value when an update to tenant_id_wo is required.</summary>
    [JsonPropertyName("tenantIdWoVersion")]
    public double? TenantIdWoVersion { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>List of authentication methods supported by the token endpoint. Must contain one or two values matching client_secret_post or client_secret_basic.</summary>
    [JsonPropertyName("tokenEndpointAuthMethods")]
    public IList<string>? TokenEndpointAuthMethods { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata>? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Salesforce OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSalesforceOauth2ProviderConfigOauthDiscovery>? OauthDiscovery { get; set; }
}

/// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfig
{
    /// <summary>JSON key used to extract the client secret value from the Secrets Manager secret.</summary>
    [JsonPropertyName("jsonKey")]
    public string? JsonKey { get; set; }

    /// <summary>ID of the AWS Secrets Manager secret that stores the client secret value.</summary>
    [JsonPropertyName("secretId")]
    public string? SecretId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSlackOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata
{
    /// <summary>OAuth2 authorization endpoint URL.</summary>
    [JsonPropertyName("authorizationEndpoint")]
    public string? AuthorizationEndpoint { get; set; }

    /// <summary>OAuth2 authorization server issuer identifier.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Set of OAuth2 response types supported by the authorization server.</summary>
    [JsonPropertyName("responseTypes")]
    public IList<string>? ResponseTypes { get; set; }

    /// <summary>OAuth2 token endpoint URL.</summary>
    [JsonPropertyName("tokenEndpoint")]
    public string? TokenEndpoint { get; set; }

    /// <summary>List of authentication methods supported by the token endpoint. Must contain one or two values matching client_secret_post or client_secret_basic.</summary>
    [JsonPropertyName("tokenEndpointAuthMethods")]
    public IList<string>? TokenEndpointAuthMethods { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSlackOauth2ProviderConfigOauthDiscovery
{
    /// <summary>Manual OAuth2 authorization server metadata configuration. Cannot be used together with discovery_url. See authorization_server_metadata below.</summary>
    [JsonPropertyName("authorizationServerMetadata")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSlackOauth2ProviderConfigOauthDiscoveryAuthorizationServerMetadata>? AuthorizationServerMetadata { get; set; }

    /// <summary>OpenID Connect discovery URL (e.g., https://provider.com/.well-known/openid-configuration). Cannot be used together with authorization_server_metadata.</summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }
}

/// <summary>Slack OAuth provider configuration. See predefined providers below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSlackOauth2ProviderConfig
{
    /// <summary>Required when client_id_wo and client_secret_wo are set. Changing this value triggers an update to client_id_wo and client_secret_wo.</summary>
    [JsonPropertyName("clientCredentialsWoVersion")]
    public double? ClientCredentialsWoVersion { get; set; }

    /// <summary>Reference to an AWS Secrets Manager secret that stores the client secret. Required when client_secret_source is EXTERNAL. See client_secret_config below.</summary>
    [JsonPropertyName("clientSecretConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSlackOauth2ProviderConfigClientSecretConfig? ClientSecretConfig { get; set; }

    /// <summary>Source type of the client secret. Valid values: MANAGED (the service manages the secret) or EXTERNAL (you manage the secret in AWS Secrets Manager). Use EXTERNAL together with client_secret_config.</summary>
    [JsonPropertyName("clientSecretSource")]
    public string? ClientSecretSource { get; set; }

    /// <summary>OAuth discovery configuration. See oauth_discovery below.</summary>
    [JsonPropertyName("oauthDiscovery")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSlackOauth2ProviderConfigOauthDiscovery>? OauthDiscovery { get; set; }
}

/// <summary>OAuth2 provider configuration. Must contain exactly one provider type. See oauth2_provider_config below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfig
{
    /// <summary>Atlassian OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("atlassianOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigAtlassianOauth2ProviderConfig? AtlassianOauth2ProviderConfig { get; set; }

    /// <summary>Custom OAuth2 provider configuration. See custom below.</summary>
    [JsonPropertyName("customOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigCustomOauth2ProviderConfig? CustomOauth2ProviderConfig { get; set; }

    /// <summary>GitHub OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("githubOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGithubOauth2ProviderConfig? GithubOauth2ProviderConfig { get; set; }

    /// <summary>Google OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("googleOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigGoogleOauth2ProviderConfig? GoogleOauth2ProviderConfig { get; set; }

    /// <summary>Configuration for an included (vendor-supported) OAuth2 provider, used for the additional supported vendors. See predefined providers below.</summary>
    [JsonPropertyName("includedOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigIncludedOauth2ProviderConfig? IncludedOauth2ProviderConfig { get; set; }

    /// <summary>LinkedIn OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("linkedinOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigLinkedinOauth2ProviderConfig? LinkedinOauth2ProviderConfig { get; set; }

    /// <summary>Microsoft OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("microsoftOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigMicrosoftOauth2ProviderConfig? MicrosoftOauth2ProviderConfig { get; set; }

    /// <summary>Salesforce OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("salesforceOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSalesforceOauth2ProviderConfig? SalesforceOauth2ProviderConfig { get; set; }

    /// <summary>Slack OAuth provider configuration. See predefined providers below.</summary>
    [JsonPropertyName("slackOauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfigSlackOauth2ProviderConfig? SlackOauth2ProviderConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusAtProvider
{
    /// <summary>Callback URL to register on the OAuth2 credential provider as an allowed callback URL. This URL is where the OAuth2 authorization server redirects users after they complete the authorization flow.</summary>
    [JsonPropertyName("callbackUrl")]
    public string? CallbackUrl { get; set; }

    /// <summary>ARN of the AWS Secrets Manager secret containing the client secret.</summary>
    [JsonPropertyName("clientSecretArn")]
    public IList<V1beta1Oauth2CredentialProviderStatusAtProviderClientSecretArn>? ClientSecretArn { get; set; }

    /// <summary>ARN of the OAuth2 credential provider.</summary>
    [JsonPropertyName("credentialProviderArn")]
    public string? CredentialProviderArn { get; set; }

    /// <summary>Vendor of the OAuth2 credential provider. Valid values include CustomOauth2, GithubOauth2, GoogleOauth2, MicrosoftOauth2, SalesforceOauth2, SlackOauth2, AtlassianOauth2, LinkedinOauth2, and a number of additional supported vendors (e.g. XOauth2, FacebookOauth2, SpotifyOauth2) configured via included_oauth2_provider_config. Refer to the AWS API for the full, current list. See the note under included_oauth2_provider_config for vendors that are not yet supported.</summary>
    [JsonPropertyName("credentialProviderVendor")]
    public string? CredentialProviderVendor { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the OAuth2 credential provider.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OAuth2 provider configuration. Must contain exactly one provider type. See oauth2_provider_config below.</summary>
    [JsonPropertyName("oauth2ProviderConfig")]
    public V1beta1Oauth2CredentialProviderStatusAtProviderOauth2ProviderConfig? Oauth2ProviderConfig { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatusConditions
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

/// <summary>Oauth2CredentialProviderStatus defines the observed state of Oauth2CredentialProvider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1Oauth2CredentialProviderStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1Oauth2CredentialProviderStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1Oauth2CredentialProviderStatusConditions>? Conditions { get; set; }

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

/// <summary>Oauth2CredentialProvider is the Schema for the Oauth2CredentialProviders API. Manages an AWS Bedrock AgentCore OAuth2 Credential Provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Oauth2CredentialProvider : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1Oauth2CredentialProviderSpec>, IStatus<V1beta1Oauth2CredentialProviderStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Oauth2CredentialProvider";
    public const string KubeGroup = "bedrockagentcore.aws.m.upbound.io";
    public const string KubePluralName = "oauth2credentialproviders";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bedrockagentcore.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Oauth2CredentialProvider";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Oauth2CredentialProviderSpec defines the desired state of Oauth2CredentialProvider</summary>
    [JsonPropertyName("spec")]
    public required V1beta1Oauth2CredentialProviderSpec Spec { get; set; }

    /// <summary>Oauth2CredentialProviderStatus defines the observed state of Oauth2CredentialProvider.</summary>
    [JsonPropertyName("status")]
    public V1beta1Oauth2CredentialProviderStatus? Status { get; set; }
}
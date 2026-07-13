#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.web.azure.m.upbound.io;
/// <summary>FunctionAppSlot is the Schema for the FunctionAppSlots API. Manages a Function App Deployment Slot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FunctionAppSlotList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FunctionAppSlot>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FunctionAppSlotList";
    public const string KubeGroup = "web.azure.m.upbound.io";
    public const string KubePluralName = "functionappslots";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "web.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FunctionAppSlotList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1FunctionAppSlot objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1FunctionAppSlot> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdRefPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdRefPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AppServicePlan in web to populate appServicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdSelectorPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdSelectorPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AppServicePlan in web to populate appServicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdSelector
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
    public V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderAuthSettingsActiveDirectoryClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>An active_directory block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderAuthSettingsActiveDirectory
{
    /// <summary>Allowed audience values to consider when validating JWTs issued by Azure Active Directory.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1FunctionAppSlotSpecForProviderAuthSettingsActiveDirectoryClientSecretSecretRef? ClientSecretSecretRef { get; set; }
}

/// <summary>The App Secret of the Facebook app used for Facebook login.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderAuthSettingsFacebookAppSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>A facebook block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderAuthSettingsFacebook
{
    /// <summary>The App ID of the Facebook app used for login</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The App Secret of the Facebook app used for Facebook login.</summary>
    [JsonPropertyName("appSecretSecretRef")]
    public V1beta1FunctionAppSlotSpecForProviderAuthSettingsFacebookAppSecretSecretRef? AppSecretSecretRef { get; set; }

    /// <summary>The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderAuthSettingsGoogleClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>A google block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderAuthSettingsGoogle
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1FunctionAppSlotSpecForProviderAuthSettingsGoogleClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderAuthSettingsMicrosoftClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>A microsoft block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderAuthSettingsMicrosoft
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1FunctionAppSlotSpecForProviderAuthSettingsMicrosoftClientSecretSecretRef? ClientSecretSecretRef { get; set; }

    /// <summary>The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderAuthSettingsTwitterConsumerSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>A twitter block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderAuthSettingsTwitter
{
    /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerSecretSecretRef")]
    public V1beta1FunctionAppSlotSpecForProviderAuthSettingsTwitterConsumerSecretSecretRef? ConsumerSecretSecretRef { get; set; }
}

/// <summary>An auth_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderAuthSettings
{
    /// <summary>An active_directory block as defined below.</summary>
    [JsonPropertyName("activeDirectory")]
    public V1beta1FunctionAppSlotSpecForProviderAuthSettingsActiveDirectory? ActiveDirectory { get; set; }

    /// <summary>login parameters to send to the OpenID Connect authorization endpoint when a user logs in. Each parameter must be in the form &quot;key=value&quot;.</summary>
    [JsonPropertyName("additionalLoginParams")]
    public IDictionary<string, string>? AdditionalLoginParams { get; set; }

    /// <summary>External URLs that can be redirected to as part of logging in or logging out of the app.</summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>The default provider to use when multiple providers have been set up. Possible values are AzureActiveDirectory, Facebook, Google, MicrosoftAccount and Twitter.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>Is Authentication enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A facebook block as defined below.</summary>
    [JsonPropertyName("facebook")]
    public V1beta1FunctionAppSlotSpecForProviderAuthSettingsFacebook? Facebook { get; set; }

    /// <summary>A google block as defined below.</summary>
    [JsonPropertyName("google")]
    public V1beta1FunctionAppSlotSpecForProviderAuthSettingsGoogle? Google { get; set; }

    /// <summary>Issuer URI. When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>A microsoft block as defined below.</summary>
    [JsonPropertyName("microsoft")]
    public V1beta1FunctionAppSlotSpecForProviderAuthSettingsMicrosoft? Microsoft { get; set; }

    /// <summary>The runtime version of the Authentication/Authorization module.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72.</summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }

    /// <summary>If enabled the module will durably store platform-specific security tokens that are obtained during login flows. Defaults to false.</summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>A twitter block as defined below.</summary>
    [JsonPropertyName("twitter")]
    public V1beta1FunctionAppSlotSpecForProviderAuthSettingsTwitter? Twitter { get; set; }

    /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values are AllowAnonymous and RedirectToLoginPage.</summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary>The value for the Connection String.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderConnectionStringValueSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderConnectionString
{
    /// <summary>The name of the Connection String.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of the Connection String. Possible values are APIHub, Custom, DocDb, EventHub, MySQL, NotificationHub, PostgreSQL, RedisCache, ServiceBus, SQLAzure and SQLServer.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value for the Connection String.</summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1FunctionAppSlotSpecForProviderConnectionStringValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderFunctionAppNameRefPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderFunctionAppNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderFunctionAppNameRefPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderFunctionAppNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderFunctionAppNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecForProviderFunctionAppNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecForProviderFunctionAppNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FunctionApp in web to populate functionAppName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderFunctionAppNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSlotSpecForProviderFunctionAppNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderFunctionAppNameSelectorPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderFunctionAppNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderFunctionAppNameSelectorPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderFunctionAppNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderFunctionAppNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecForProviderFunctionAppNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecForProviderFunctionAppNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FunctionApp in web to populate functionAppName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderFunctionAppNameSelector
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
    public V1beta1FunctionAppSlotSpecForProviderFunctionAppNameSelectorPolicy? Policy { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderIdentity
{
    /// <summary>Specifies a list of user managed identity ids to be assigned. Required if type is UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the identity type of the Function App. Possible values are SystemAssigned (where Azure will generate a Service Principal for you), UserAssigned where you can specify the Service Principal IDs in the identity_ids field, and SystemAssigned, UserAssigned which assigns both a system managed identity as well as the specified user assigned identities.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSlotSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderResourceGroupNameSelector
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
    public V1beta1FunctionAppSlotSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A cors block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderSiteConfigCors
{
    /// <summary>A list of origins which should be able to make cross-origin calls. * can be used to allow all calls.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Are credentials supported?</summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary>The headers block for this specific scm_ip_restriction as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionHeaders
{
    /// <summary>A list of allowed Azure FrontDoor IDs in UUID notation with a maximum of 8.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>A list to allow the Azure FrontDoor health probe header. Only allowed value is &quot;1&quot;.</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>A list of allowed &apos;X-Forwarded-For&apos; IPs in CIDR notation with a maximum of 8</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>A list of allowed &apos;X-Forwarded-Host&apos; domains with a maximum of 8.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector
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
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestriction
{
    /// <summary>Allow or Deny access for this IP range. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The headers block for this specific scm_ip_restriction as defined below.</summary>
    [JsonPropertyName("headers")]
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionHeaders? Headers { get; set; }

    /// <summary>The IP Address used for this IP Restriction in CIDR notation.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name for this IP Restriction.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority for this IP Restriction. Restrictions are enforced in priority order. By default, priority is set to 65000 if not specified.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Service Tag used for this IP Restriction.</summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary>The headers block for this specific scm_ip_restriction as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionHeaders
{
    /// <summary>A list of allowed Azure FrontDoor IDs in UUID notation with a maximum of 8.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>A list to allow the Azure FrontDoor health probe header. Only allowed value is &quot;1&quot;.</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>A list of allowed &apos;X-Forwarded-For&apos; IPs in CIDR notation with a maximum of 8</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>A list of allowed &apos;X-Forwarded-Host&apos; domains with a maximum of 8.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector
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
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestriction
{
    /// <summary>Allow or Deny access for this IP range. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The headers block for this specific scm_ip_restriction as defined below.</summary>
    [JsonPropertyName("headers")]
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionHeaders? Headers { get; set; }

    /// <summary>The IP Address used for this IP Restriction in CIDR notation.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name for this IP Restriction.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority for this IP Restriction. Restrictions are enforced in priority order. By default, priority is set to 65000 if not specified.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Service Tag used for this IP Restriction.</summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary>A site_config object as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderSiteConfig
{
    /// <summary>Should the Function App be loaded at all times? Defaults to false.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.</summary>
    [JsonPropertyName("appScaleLimit")]
    public double? AppScaleLimit { get; set; }

    /// <summary>The name of the slot to automatically swap to during deployment</summary>
    [JsonPropertyName("autoSwapSlotName")]
    public string? AutoSwapSlotName { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public V1beta1FunctionAppSlotSpecForProviderSiteConfigCors? Cors { get; set; }

    /// <summary>The version of the .NET framework&apos;s CLR used in this function app. Possible values are v4.0 (including .NET Core 2.1 and 3.1), v5.0 and v6.0. For more information on which .NET Framework version to use based on the runtime version you&apos;re targeting - please see this table. Defaults to v4.0.</summary>
    [JsonPropertyName("dotnetFrameworkVersion")]
    public string? DotnetFrameworkVersion { get; set; }

    /// <summary>The number of minimum instances for this function app. Only applicable to apps on the Premium plan.</summary>
    [JsonPropertyName("elasticInstanceMinimum")]
    public double? ElasticInstanceMinimum { get; set; }

    /// <summary>State of FTP / FTPS service for this function app. Possible values include: AllAllowed, FtpsOnly and Disabled.</summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>Path which will be checked for this function app health.</summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>Specifies whether or not the HTTP2 protocol should be enabled. Defaults to false.</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }

    /// <summary>A list of ip_restriction objects representing IP restrictions as defined below.</summary>
    [JsonPropertyName("ipRestriction")]
    public IList<V1beta1FunctionAppSlotSpecForProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>Java version hosted by the function app in Azure. Possible values are 1.8, 11 &amp; 17 (In-Preview).</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>Linux App Framework and version for the AppService, e.g. DOCKER|(golang:latest).</summary>
    [JsonPropertyName("linuxFxVersion")]
    public string? LinuxFxVersion { get; set; }

    /// <summary>The minimum supported TLS version for the function app. Possible values are 1.0, 1.1, and 1.2. Defaults to 1.2 for new function apps.</summary>
    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    /// <summary>The number of pre-warmed instances for this function app. Only affects apps on the Premium plan.</summary>
    [JsonPropertyName("preWarmedInstanceCount")]
    public double? PreWarmedInstanceCount { get; set; }

    /// <summary>Should Runtime Scale Monitoring be enabled?. Only applicable to apps on the Premium plan. Defaults to false.</summary>
    [JsonPropertyName("runtimeScaleMonitoringEnabled")]
    public bool? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>A list of scm_ip_restriction objects representing IP restrictions as defined below.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta1FunctionAppSlotSpecForProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The type of Source Control used by this function App. Valid values include: BitBucketGit, BitBucketHg, CodePlexGit, CodePlexHg, Dropbox, ExternalGit, ExternalHg, GitHub, LocalGit, None (default), OneDrive, Tfs, VSO, and VSTSRM.</summary>
    [JsonPropertyName("scmType")]
    public string? ScmType { get; set; }

    /// <summary>IP security restrictions for scm to use main. Defaults to false.</summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>Should the Function App run in 32 bit mode, rather than 64 bit mode? Defaults to true.</summary>
    [JsonPropertyName("use32BitWorkerProcess")]
    public bool? Use32BitWorkerProcess { get; set; }

    /// <summary>Is the Function App enabled? Defaults to true.</summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>Should WebSockets be enabled?</summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }
}

/// <summary>The access key which will be used to access the backend storage account for the Function App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderStorageAccountAccessKeySecretRef
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderStorageAccountNameRefPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderStorageAccountNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderStorageAccountNameRefPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderStorageAccountNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderStorageAccountNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecForProviderStorageAccountNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecForProviderStorageAccountNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderStorageAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSlotSpecForProviderStorageAccountNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderStorageAccountNameSelectorPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderStorageAccountNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecForProviderStorageAccountNameSelectorPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecForProviderStorageAccountNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderStorageAccountNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecForProviderStorageAccountNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecForProviderStorageAccountNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProviderStorageAccountNameSelector
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
    public V1beta1FunctionAppSlotSpecForProviderStorageAccountNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecForProvider
{
    /// <summary>The ID of the App Service Plan within which to create this Function App Slot. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("appServicePlanId")]
    public string? AppServicePlanId { get; set; }

    /// <summary>Reference to a AppServicePlan in web to populate appServicePlanId.</summary>
    [JsonPropertyName("appServicePlanIdRef")]
    public V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdRef? AppServicePlanIdRef { get; set; }

    /// <summary>Selector for a AppServicePlan in web to populate appServicePlanId.</summary>
    [JsonPropertyName("appServicePlanIdSelector")]
    public V1beta1FunctionAppSlotSpecForProviderAppServicePlanIdSelector? AppServicePlanIdSelector { get; set; }

    /// <summary>A key-value pair of App Settings.</summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>An auth_settings block as defined below.</summary>
    [JsonPropertyName("authSettings")]
    public V1beta1FunctionAppSlotSpecForProviderAuthSettings? AuthSettings { get; set; }

    /// <summary>A connection_string block as defined below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta1FunctionAppSlotSpecForProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps under the consumption plan.</summary>
    [JsonPropertyName("dailyMemoryTimeQuota")]
    public double? DailyMemoryTimeQuota { get; set; }

    /// <summary>Should the built-in logging of the Function App be enabled? Defaults to true.</summary>
    [JsonPropertyName("enableBuiltinLogging")]
    public bool? EnableBuiltinLogging { get; set; }

    /// <summary>Is the Function App enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the Function App within which to create the Function App Slot. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("functionAppName")]
    public string? FunctionAppName { get; set; }

    /// <summary>Reference to a FunctionApp in web to populate functionAppName.</summary>
    [JsonPropertyName("functionAppNameRef")]
    public V1beta1FunctionAppSlotSpecForProviderFunctionAppNameRef? FunctionAppNameRef { get; set; }

    /// <summary>Selector for a FunctionApp in web to populate functionAppName.</summary>
    [JsonPropertyName("functionAppNameSelector")]
    public V1beta1FunctionAppSlotSpecForProviderFunctionAppNameSelector? FunctionAppNameSelector { get; set; }

    /// <summary>Can the Function App only be accessed via HTTPS? Defaults to false.</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1FunctionAppSlotSpecForProviderIdentity? Identity { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A string indicating the Operating System type for this function app. The only possible value is linux. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>The name of the resource group in which to create the Function App Slot. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1FunctionAppSlotSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1FunctionAppSlotSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A site_config object as defined below.</summary>
    [JsonPropertyName("siteConfig")]
    public V1beta1FunctionAppSlotSpecForProviderSiteConfig? SiteConfig { get; set; }

    /// <summary>The access key which will be used to access the backend storage account for the Function App.</summary>
    [JsonPropertyName("storageAccountAccessKeySecretRef")]
    public V1beta1FunctionAppSlotSpecForProviderStorageAccountAccessKeySecretRef? StorageAccountAccessKeySecretRef { get; set; }

    /// <summary>The backend storage account name which will be used by the Function App (such as the dashboard, logs). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountName.</summary>
    [JsonPropertyName("storageAccountNameRef")]
    public V1beta1FunctionAppSlotSpecForProviderStorageAccountNameRef? StorageAccountNameRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountName.</summary>
    [JsonPropertyName("storageAccountNameSelector")]
    public V1beta1FunctionAppSlotSpecForProviderStorageAccountNameSelector? StorageAccountNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The runtime version associated with the Function App. Defaults to ~1.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdRefPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdRefPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AppServicePlan in web to populate appServicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdSelectorPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdSelectorPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AppServicePlan in web to populate appServicePlanId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdSelector
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
    public V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderAuthSettingsActiveDirectoryClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>An active_directory block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderAuthSettingsActiveDirectory
{
    /// <summary>Allowed audience values to consider when validating JWTs issued by Azure Active Directory.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1FunctionAppSlotSpecInitProviderAuthSettingsActiveDirectoryClientSecretSecretRef? ClientSecretSecretRef { get; set; }
}

/// <summary>The App Secret of the Facebook app used for Facebook login.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderAuthSettingsFacebookAppSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>A facebook block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderAuthSettingsFacebook
{
    /// <summary>The App ID of the Facebook app used for login</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The App Secret of the Facebook app used for Facebook login.</summary>
    [JsonPropertyName("appSecretSecretRef")]
    public required V1beta1FunctionAppSlotSpecInitProviderAuthSettingsFacebookAppSecretSecretRef AppSecretSecretRef { get; set; }

    /// <summary>The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderAuthSettingsGoogleClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>A google block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderAuthSettingsGoogle
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public required V1beta1FunctionAppSlotSpecInitProviderAuthSettingsGoogleClientSecretSecretRef ClientSecretSecretRef { get; set; }

    /// <summary>The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 2.0 client secret that was created for the app used for authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderAuthSettingsMicrosoftClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>A microsoft block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderAuthSettingsMicrosoft
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 client secret that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public required V1beta1FunctionAppSlotSpecInitProviderAuthSettingsMicrosoftClientSecretSecretRef ClientSecretSecretRef { get; set; }

    /// <summary>The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderAuthSettingsTwitterConsumerSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>A twitter block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderAuthSettingsTwitter
{
    /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }

    /// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerSecretSecretRef")]
    public required V1beta1FunctionAppSlotSpecInitProviderAuthSettingsTwitterConsumerSecretSecretRef ConsumerSecretSecretRef { get; set; }
}

/// <summary>An auth_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderAuthSettings
{
    /// <summary>An active_directory block as defined below.</summary>
    [JsonPropertyName("activeDirectory")]
    public V1beta1FunctionAppSlotSpecInitProviderAuthSettingsActiveDirectory? ActiveDirectory { get; set; }

    /// <summary>login parameters to send to the OpenID Connect authorization endpoint when a user logs in. Each parameter must be in the form &quot;key=value&quot;.</summary>
    [JsonPropertyName("additionalLoginParams")]
    public IDictionary<string, string>? AdditionalLoginParams { get; set; }

    /// <summary>External URLs that can be redirected to as part of logging in or logging out of the app.</summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>The default provider to use when multiple providers have been set up. Possible values are AzureActiveDirectory, Facebook, Google, MicrosoftAccount and Twitter.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>Is Authentication enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A facebook block as defined below.</summary>
    [JsonPropertyName("facebook")]
    public V1beta1FunctionAppSlotSpecInitProviderAuthSettingsFacebook? Facebook { get; set; }

    /// <summary>A google block as defined below.</summary>
    [JsonPropertyName("google")]
    public V1beta1FunctionAppSlotSpecInitProviderAuthSettingsGoogle? Google { get; set; }

    /// <summary>Issuer URI. When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>A microsoft block as defined below.</summary>
    [JsonPropertyName("microsoft")]
    public V1beta1FunctionAppSlotSpecInitProviderAuthSettingsMicrosoft? Microsoft { get; set; }

    /// <summary>The runtime version of the Authentication/Authorization module.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72.</summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }

    /// <summary>If enabled the module will durably store platform-specific security tokens that are obtained during login flows. Defaults to false.</summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>A twitter block as defined below.</summary>
    [JsonPropertyName("twitter")]
    public V1beta1FunctionAppSlotSpecInitProviderAuthSettingsTwitter? Twitter { get; set; }

    /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values are AllowAnonymous and RedirectToLoginPage.</summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

/// <summary>The value for the Connection String.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderConnectionStringValueSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderConnectionString
{
    /// <summary>The name of the Connection String.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of the Connection String. Possible values are APIHub, Custom, DocDb, EventHub, MySQL, NotificationHub, PostgreSQL, RedisCache, ServiceBus, SQLAzure and SQLServer.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value for the Connection String.</summary>
    [JsonPropertyName("valueSecretRef")]
    public required V1beta1FunctionAppSlotSpecInitProviderConnectionStringValueSecretRef ValueSecretRef { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderIdentity
{
    /// <summary>Specifies a list of user managed identity ids to be assigned. Required if type is UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the identity type of the Function App. Possible values are SystemAssigned (where Azure will generate a Service Principal for you), UserAssigned where you can specify the Service Principal IDs in the identity_ids field, and SystemAssigned, UserAssigned which assigns both a system managed identity as well as the specified user assigned identities.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A cors block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderSiteConfigCors
{
    /// <summary>A list of origins which should be able to make cross-origin calls. * can be used to allow all calls.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Are credentials supported?</summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary>The headers block for this specific scm_ip_restriction as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionHeaders
{
    /// <summary>A list of allowed Azure FrontDoor IDs in UUID notation with a maximum of 8.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>A list to allow the Azure FrontDoor health probe header. Only allowed value is &quot;1&quot;.</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>A list of allowed &apos;X-Forwarded-For&apos; IPs in CIDR notation with a maximum of 8</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>A list of allowed &apos;X-Forwarded-Host&apos; domains with a maximum of 8.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector
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
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestriction
{
    /// <summary>Allow or Deny access for this IP range. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The headers block for this specific scm_ip_restriction as defined below.</summary>
    [JsonPropertyName("headers")]
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionHeaders? Headers { get; set; }

    /// <summary>The IP Address used for this IP Restriction in CIDR notation.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name for this IP Restriction.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority for this IP Restriction. Restrictions are enforced in priority order. By default, priority is set to 65000 if not specified.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Service Tag used for this IP Restriction.</summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary>The headers block for this specific scm_ip_restriction as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionHeaders
{
    /// <summary>A list of allowed Azure FrontDoor IDs in UUID notation with a maximum of 8.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>A list to allow the Azure FrontDoor health probe header. Only allowed value is &quot;1&quot;.</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>A list of allowed &apos;X-Forwarded-For&apos; IPs in CIDR notation with a maximum of 8</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>A list of allowed &apos;X-Forwarded-Host&apos; domains with a maximum of 8.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector
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
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestriction
{
    /// <summary>Allow or Deny access for this IP range. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The headers block for this specific scm_ip_restriction as defined below.</summary>
    [JsonPropertyName("headers")]
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionHeaders? Headers { get; set; }

    /// <summary>The IP Address used for this IP Restriction in CIDR notation.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name for this IP Restriction.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority for this IP Restriction. Restrictions are enforced in priority order. By default, priority is set to 65000 if not specified.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Service Tag used for this IP Restriction.</summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdRef")]
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdRef? VirtualNetworkSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate virtualNetworkSubnetId.</summary>
    [JsonPropertyName("virtualNetworkSubnetIdSelector")]
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestrictionVirtualNetworkSubnetIdSelector? VirtualNetworkSubnetIdSelector { get; set; }
}

/// <summary>A site_config object as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderSiteConfig
{
    /// <summary>Should the Function App be loaded at all times? Defaults to false.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.</summary>
    [JsonPropertyName("appScaleLimit")]
    public double? AppScaleLimit { get; set; }

    /// <summary>The name of the slot to automatically swap to during deployment</summary>
    [JsonPropertyName("autoSwapSlotName")]
    public string? AutoSwapSlotName { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfigCors? Cors { get; set; }

    /// <summary>The version of the .NET framework&apos;s CLR used in this function app. Possible values are v4.0 (including .NET Core 2.1 and 3.1), v5.0 and v6.0. For more information on which .NET Framework version to use based on the runtime version you&apos;re targeting - please see this table. Defaults to v4.0.</summary>
    [JsonPropertyName("dotnetFrameworkVersion")]
    public string? DotnetFrameworkVersion { get; set; }

    /// <summary>The number of minimum instances for this function app. Only applicable to apps on the Premium plan.</summary>
    [JsonPropertyName("elasticInstanceMinimum")]
    public double? ElasticInstanceMinimum { get; set; }

    /// <summary>State of FTP / FTPS service for this function app. Possible values include: AllAllowed, FtpsOnly and Disabled.</summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>Path which will be checked for this function app health.</summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>Specifies whether or not the HTTP2 protocol should be enabled. Defaults to false.</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }

    /// <summary>A list of ip_restriction objects representing IP restrictions as defined below.</summary>
    [JsonPropertyName("ipRestriction")]
    public IList<V1beta1FunctionAppSlotSpecInitProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>Java version hosted by the function app in Azure. Possible values are 1.8, 11 &amp; 17 (In-Preview).</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>Linux App Framework and version for the AppService, e.g. DOCKER|(golang:latest).</summary>
    [JsonPropertyName("linuxFxVersion")]
    public string? LinuxFxVersion { get; set; }

    /// <summary>The minimum supported TLS version for the function app. Possible values are 1.0, 1.1, and 1.2. Defaults to 1.2 for new function apps.</summary>
    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    /// <summary>The number of pre-warmed instances for this function app. Only affects apps on the Premium plan.</summary>
    [JsonPropertyName("preWarmedInstanceCount")]
    public double? PreWarmedInstanceCount { get; set; }

    /// <summary>Should Runtime Scale Monitoring be enabled?. Only applicable to apps on the Premium plan. Defaults to false.</summary>
    [JsonPropertyName("runtimeScaleMonitoringEnabled")]
    public bool? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>A list of scm_ip_restriction objects representing IP restrictions as defined below.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta1FunctionAppSlotSpecInitProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The type of Source Control used by this function App. Valid values include: BitBucketGit, BitBucketHg, CodePlexGit, CodePlexHg, Dropbox, ExternalGit, ExternalHg, GitHub, LocalGit, None (default), OneDrive, Tfs, VSO, and VSTSRM.</summary>
    [JsonPropertyName("scmType")]
    public string? ScmType { get; set; }

    /// <summary>IP security restrictions for scm to use main. Defaults to false.</summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>Should the Function App run in 32 bit mode, rather than 64 bit mode? Defaults to true.</summary>
    [JsonPropertyName("use32BitWorkerProcess")]
    public bool? Use32BitWorkerProcess { get; set; }

    /// <summary>Is the Function App enabled? Defaults to true.</summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>Should WebSockets be enabled?</summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }
}

/// <summary>The access key which will be used to access the backend storage account for the Function App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderStorageAccountAccessKeySecretRef
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameRefPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameRefPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate storageAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameSelectorPolicyResolutionEnum>))]
public enum V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameSelectorPolicyResolveEnum>))]
public enum V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate storageAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameSelector
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
    public V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1FunctionAppSlotSpecInitProvider
{
    /// <summary>The ID of the App Service Plan within which to create this Function App Slot. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("appServicePlanId")]
    public string? AppServicePlanId { get; set; }

    /// <summary>Reference to a AppServicePlan in web to populate appServicePlanId.</summary>
    [JsonPropertyName("appServicePlanIdRef")]
    public V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdRef? AppServicePlanIdRef { get; set; }

    /// <summary>Selector for a AppServicePlan in web to populate appServicePlanId.</summary>
    [JsonPropertyName("appServicePlanIdSelector")]
    public V1beta1FunctionAppSlotSpecInitProviderAppServicePlanIdSelector? AppServicePlanIdSelector { get; set; }

    /// <summary>A key-value pair of App Settings.</summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>An auth_settings block as defined below.</summary>
    [JsonPropertyName("authSettings")]
    public V1beta1FunctionAppSlotSpecInitProviderAuthSettings? AuthSettings { get; set; }

    /// <summary>A connection_string block as defined below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta1FunctionAppSlotSpecInitProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps under the consumption plan.</summary>
    [JsonPropertyName("dailyMemoryTimeQuota")]
    public double? DailyMemoryTimeQuota { get; set; }

    /// <summary>Should the built-in logging of the Function App be enabled? Defaults to true.</summary>
    [JsonPropertyName("enableBuiltinLogging")]
    public bool? EnableBuiltinLogging { get; set; }

    /// <summary>Is the Function App enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Can the Function App only be accessed via HTTPS? Defaults to false.</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1FunctionAppSlotSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A string indicating the Operating System type for this function app. The only possible value is linux. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>A site_config object as defined below.</summary>
    [JsonPropertyName("siteConfig")]
    public V1beta1FunctionAppSlotSpecInitProviderSiteConfig? SiteConfig { get; set; }

    /// <summary>The access key which will be used to access the backend storage account for the Function App.</summary>
    [JsonPropertyName("storageAccountAccessKeySecretRef")]
    public required V1beta1FunctionAppSlotSpecInitProviderStorageAccountAccessKeySecretRef StorageAccountAccessKeySecretRef { get; set; }

    /// <summary>The backend storage account name which will be used by the Function App (such as the dashboard, logs). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>Reference to a Account in storage to populate storageAccountName.</summary>
    [JsonPropertyName("storageAccountNameRef")]
    public V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameRef? StorageAccountNameRef { get; set; }

    /// <summary>Selector for a Account in storage to populate storageAccountName.</summary>
    [JsonPropertyName("storageAccountNameSelector")]
    public V1beta1FunctionAppSlotSpecInitProviderStorageAccountNameSelector? StorageAccountNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The runtime version associated with the Function App. Defaults to ~1.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1FunctionAppSlotSpecManagementPoliciesEnum>))]
public enum V1beta1FunctionAppSlotSpecManagementPoliciesEnum
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
public partial class V1beta1FunctionAppSlotSpecProviderConfigRef
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
public partial class V1beta1FunctionAppSlotSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>FunctionAppSlotSpec defines the desired state of FunctionAppSlot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1FunctionAppSlotSpecForProvider ForProvider { get; set; }

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
    public V1beta1FunctionAppSlotSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1FunctionAppSlotSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FunctionAppSlotSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FunctionAppSlotSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An active_directory block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotStatusAtProviderAuthSettingsActiveDirectory
{
    /// <summary>Allowed audience values to consider when validating JWTs issued by Azure Active Directory.</summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary>A facebook block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotStatusAtProviderAuthSettingsFacebook
{
    /// <summary>The App ID of the Facebook app used for login</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>A google block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotStatusAtProviderAuthSettingsGoogle
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>A microsoft block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotStatusAtProviderAuthSettingsMicrosoft
{
    /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }
}

/// <summary>A twitter block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotStatusAtProviderAuthSettingsTwitter
{
    /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
    [JsonPropertyName("consumerKey")]
    public string? ConsumerKey { get; set; }
}

/// <summary>An auth_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotStatusAtProviderAuthSettings
{
    /// <summary>An active_directory block as defined below.</summary>
    [JsonPropertyName("activeDirectory")]
    public V1beta1FunctionAppSlotStatusAtProviderAuthSettingsActiveDirectory? ActiveDirectory { get; set; }

    /// <summary>login parameters to send to the OpenID Connect authorization endpoint when a user logs in. Each parameter must be in the form &quot;key=value&quot;.</summary>
    [JsonPropertyName("additionalLoginParams")]
    public IDictionary<string, string>? AdditionalLoginParams { get; set; }

    /// <summary>External URLs that can be redirected to as part of logging in or logging out of the app.</summary>
    [JsonPropertyName("allowedExternalRedirectUrls")]
    public IList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>The default provider to use when multiple providers have been set up. Possible values are AzureActiveDirectory, Facebook, Google, MicrosoftAccount and Twitter.</summary>
    [JsonPropertyName("defaultProvider")]
    public string? DefaultProvider { get; set; }

    /// <summary>Is Authentication enabled?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A facebook block as defined below.</summary>
    [JsonPropertyName("facebook")]
    public V1beta1FunctionAppSlotStatusAtProviderAuthSettingsFacebook? Facebook { get; set; }

    /// <summary>A google block as defined below.</summary>
    [JsonPropertyName("google")]
    public V1beta1FunctionAppSlotStatusAtProviderAuthSettingsGoogle? Google { get; set; }

    /// <summary>Issuer URI. When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>A microsoft block as defined below.</summary>
    [JsonPropertyName("microsoft")]
    public V1beta1FunctionAppSlotStatusAtProviderAuthSettingsMicrosoft? Microsoft { get; set; }

    /// <summary>The runtime version of the Authentication/Authorization module.</summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }

    /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72.</summary>
    [JsonPropertyName("tokenRefreshExtensionHours")]
    public double? TokenRefreshExtensionHours { get; set; }

    /// <summary>If enabled the module will durably store platform-specific security tokens that are obtained during login flows. Defaults to false.</summary>
    [JsonPropertyName("tokenStoreEnabled")]
    public bool? TokenStoreEnabled { get; set; }

    /// <summary>A twitter block as defined below.</summary>
    [JsonPropertyName("twitter")]
    public V1beta1FunctionAppSlotStatusAtProviderAuthSettingsTwitter? Twitter { get; set; }

    /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values are AllowAnonymous and RedirectToLoginPage.</summary>
    [JsonPropertyName("unauthenticatedClientAction")]
    public string? UnauthenticatedClientAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotStatusAtProviderConnectionString
{
    /// <summary>The name of the Connection String.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The type of the Connection String. Possible values are APIHub, Custom, DocDb, EventHub, MySQL, NotificationHub, PostgreSQL, RedisCache, ServiceBus, SQLAzure and SQLServer.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotStatusAtProviderIdentity
{
    /// <summary>Specifies a list of user managed identity ids to be assigned. Required if type is UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID for the Service Principal associated with the Managed Service Identity of this App Service.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID for the Service Principal associated with the Managed Service Identity of this App Service.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the identity type of the Function App. Possible values are SystemAssigned (where Azure will generate a Service Principal for you), UserAssigned where you can specify the Service Principal IDs in the identity_ids field, and SystemAssigned, UserAssigned which assigns both a system managed identity as well as the specified user assigned identities.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A cors block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotStatusAtProviderSiteConfigCors
{
    /// <summary>A list of origins which should be able to make cross-origin calls. * can be used to allow all calls.</summary>
    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    /// <summary>Are credentials supported?</summary>
    [JsonPropertyName("supportCredentials")]
    public bool? SupportCredentials { get; set; }
}

/// <summary>The headers block for this specific scm_ip_restriction as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotStatusAtProviderSiteConfigIpRestrictionHeaders
{
    /// <summary>A list of allowed Azure FrontDoor IDs in UUID notation with a maximum of 8.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>A list to allow the Azure FrontDoor health probe header. Only allowed value is &quot;1&quot;.</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>A list of allowed &apos;X-Forwarded-For&apos; IPs in CIDR notation with a maximum of 8</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>A list of allowed &apos;X-Forwarded-Host&apos; domains with a maximum of 8.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotStatusAtProviderSiteConfigIpRestriction
{
    /// <summary>Allow or Deny access for this IP range. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The headers block for this specific scm_ip_restriction as defined below.</summary>
    [JsonPropertyName("headers")]
    public V1beta1FunctionAppSlotStatusAtProviderSiteConfigIpRestrictionHeaders? Headers { get; set; }

    /// <summary>The IP Address used for this IP Restriction in CIDR notation.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name for this IP Restriction.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority for this IP Restriction. Restrictions are enforced in priority order. By default, priority is set to 65000 if not specified.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Service Tag used for this IP Restriction.</summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }
}

/// <summary>The headers block for this specific scm_ip_restriction as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotStatusAtProviderSiteConfigScmIpRestrictionHeaders
{
    /// <summary>A list of allowed Azure FrontDoor IDs in UUID notation with a maximum of 8.</summary>
    [JsonPropertyName("xAzureFdid")]
    public IList<string>? XAzureFdid { get; set; }

    /// <summary>A list to allow the Azure FrontDoor health probe header. Only allowed value is &quot;1&quot;.</summary>
    [JsonPropertyName("xFdHealthProbe")]
    public IList<string>? XFdHealthProbe { get; set; }

    /// <summary>A list of allowed &apos;X-Forwarded-For&apos; IPs in CIDR notation with a maximum of 8</summary>
    [JsonPropertyName("xForwardedFor")]
    public IList<string>? XForwardedFor { get; set; }

    /// <summary>A list of allowed &apos;X-Forwarded-Host&apos; domains with a maximum of 8.</summary>
    [JsonPropertyName("xForwardedHost")]
    public IList<string>? XForwardedHost { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotStatusAtProviderSiteConfigScmIpRestriction
{
    /// <summary>Allow or Deny access for this IP range. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The headers block for this specific scm_ip_restriction as defined below.</summary>
    [JsonPropertyName("headers")]
    public V1beta1FunctionAppSlotStatusAtProviderSiteConfigScmIpRestrictionHeaders? Headers { get; set; }

    /// <summary>The IP Address used for this IP Restriction in CIDR notation.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name for this IP Restriction.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The priority for this IP Restriction. Restrictions are enforced in priority order. By default, priority is set to 65000 if not specified.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Service Tag used for this IP Restriction.</summary>
    [JsonPropertyName("serviceTag")]
    public string? ServiceTag { get; set; }

    /// <summary>The Virtual Network Subnet ID used for this IP Restriction.</summary>
    [JsonPropertyName("virtualNetworkSubnetId")]
    public string? VirtualNetworkSubnetId { get; set; }
}

/// <summary>A site_config object as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotStatusAtProviderSiteConfig
{
    /// <summary>Should the Function App be loaded at all times? Defaults to false.</summary>
    [JsonPropertyName("alwaysOn")]
    public bool? AlwaysOn { get; set; }

    /// <summary>The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.</summary>
    [JsonPropertyName("appScaleLimit")]
    public double? AppScaleLimit { get; set; }

    /// <summary>The name of the slot to automatically swap to during deployment</summary>
    [JsonPropertyName("autoSwapSlotName")]
    public string? AutoSwapSlotName { get; set; }

    /// <summary>A cors block as defined below.</summary>
    [JsonPropertyName("cors")]
    public V1beta1FunctionAppSlotStatusAtProviderSiteConfigCors? Cors { get; set; }

    /// <summary>The version of the .NET framework&apos;s CLR used in this function app. Possible values are v4.0 (including .NET Core 2.1 and 3.1), v5.0 and v6.0. For more information on which .NET Framework version to use based on the runtime version you&apos;re targeting - please see this table. Defaults to v4.0.</summary>
    [JsonPropertyName("dotnetFrameworkVersion")]
    public string? DotnetFrameworkVersion { get; set; }

    /// <summary>The number of minimum instances for this function app. Only applicable to apps on the Premium plan.</summary>
    [JsonPropertyName("elasticInstanceMinimum")]
    public double? ElasticInstanceMinimum { get; set; }

    /// <summary>State of FTP / FTPS service for this function app. Possible values include: AllAllowed, FtpsOnly and Disabled.</summary>
    [JsonPropertyName("ftpsState")]
    public string? FtpsState { get; set; }

    /// <summary>Path which will be checked for this function app health.</summary>
    [JsonPropertyName("healthCheckPath")]
    public string? HealthCheckPath { get; set; }

    /// <summary>Specifies whether or not the HTTP2 protocol should be enabled. Defaults to false.</summary>
    [JsonPropertyName("http2Enabled")]
    public bool? Http2Enabled { get; set; }

    /// <summary>A list of ip_restriction objects representing IP restrictions as defined below.</summary>
    [JsonPropertyName("ipRestriction")]
    public IList<V1beta1FunctionAppSlotStatusAtProviderSiteConfigIpRestriction>? IpRestriction { get; set; }

    /// <summary>Java version hosted by the function app in Azure. Possible values are 1.8, 11 &amp; 17 (In-Preview).</summary>
    [JsonPropertyName("javaVersion")]
    public string? JavaVersion { get; set; }

    /// <summary>Linux App Framework and version for the AppService, e.g. DOCKER|(golang:latest).</summary>
    [JsonPropertyName("linuxFxVersion")]
    public string? LinuxFxVersion { get; set; }

    /// <summary>The minimum supported TLS version for the function app. Possible values are 1.0, 1.1, and 1.2. Defaults to 1.2 for new function apps.</summary>
    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    /// <summary>The number of pre-warmed instances for this function app. Only affects apps on the Premium plan.</summary>
    [JsonPropertyName("preWarmedInstanceCount")]
    public double? PreWarmedInstanceCount { get; set; }

    /// <summary>Should Runtime Scale Monitoring be enabled?. Only applicable to apps on the Premium plan. Defaults to false.</summary>
    [JsonPropertyName("runtimeScaleMonitoringEnabled")]
    public bool? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>A list of scm_ip_restriction objects representing IP restrictions as defined below.</summary>
    [JsonPropertyName("scmIpRestriction")]
    public IList<V1beta1FunctionAppSlotStatusAtProviderSiteConfigScmIpRestriction>? ScmIpRestriction { get; set; }

    /// <summary>The type of Source Control used by this function App. Valid values include: BitBucketGit, BitBucketHg, CodePlexGit, CodePlexHg, Dropbox, ExternalGit, ExternalHg, GitHub, LocalGit, None (default), OneDrive, Tfs, VSO, and VSTSRM.</summary>
    [JsonPropertyName("scmType")]
    public string? ScmType { get; set; }

    /// <summary>IP security restrictions for scm to use main. Defaults to false.</summary>
    [JsonPropertyName("scmUseMainIpRestriction")]
    public bool? ScmUseMainIpRestriction { get; set; }

    /// <summary>Should the Function App run in 32 bit mode, rather than 64 bit mode? Defaults to true.</summary>
    [JsonPropertyName("use32BitWorkerProcess")]
    public bool? Use32BitWorkerProcess { get; set; }

    /// <summary>Is the Function App enabled? Defaults to true.</summary>
    [JsonPropertyName("vnetRouteAllEnabled")]
    public bool? VnetRouteAllEnabled { get; set; }

    /// <summary>Should WebSockets be enabled?</summary>
    [JsonPropertyName("websocketsEnabled")]
    public bool? WebsocketsEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotStatusAtProviderSiteCredential
{
    /// <summary>The password associated with the username, which can be used to publish to this App Service.</summary>
    [JsonPropertyName("password")]
    public string? Password { get; set; }

    /// <summary>The username which can be used to publish to this App Service</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotStatusAtProvider
{
    /// <summary>The ID of the App Service Plan within which to create this Function App Slot. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("appServicePlanId")]
    public string? AppServicePlanId { get; set; }

    /// <summary>A key-value pair of App Settings.</summary>
    [JsonPropertyName("appSettings")]
    public IDictionary<string, string>? AppSettings { get; set; }

    /// <summary>An auth_settings block as defined below.</summary>
    [JsonPropertyName("authSettings")]
    public V1beta1FunctionAppSlotStatusAtProviderAuthSettings? AuthSettings { get; set; }

    /// <summary>A connection_string block as defined below.</summary>
    [JsonPropertyName("connectionString")]
    public IList<V1beta1FunctionAppSlotStatusAtProviderConnectionString>? ConnectionString { get; set; }

    /// <summary>The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps under the consumption plan.</summary>
    [JsonPropertyName("dailyMemoryTimeQuota")]
    public double? DailyMemoryTimeQuota { get; set; }

    /// <summary>The default hostname associated with the Function App - such as mysite.azurewebsites.net</summary>
    [JsonPropertyName("defaultHostname")]
    public string? DefaultHostname { get; set; }

    /// <summary>Should the built-in logging of the Function App be enabled? Defaults to true.</summary>
    [JsonPropertyName("enableBuiltinLogging")]
    public bool? EnableBuiltinLogging { get; set; }

    /// <summary>Is the Function App enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the Function App within which to create the Function App Slot. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("functionAppName")]
    public string? FunctionAppName { get; set; }

    /// <summary>Can the Function App only be accessed via HTTPS? Defaults to false.</summary>
    [JsonPropertyName("httpsOnly")]
    public bool? HttpsOnly { get; set; }

    /// <summary>The ID of the Function App Slot</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1FunctionAppSlotStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>The Function App kind - such as functionapp,linux,container</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A string indicating the Operating System type for this function app. The only possible value is linux. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>A comma separated list of outbound IP addresses - such as 52.23.25.3,52.143.43.12</summary>
    [JsonPropertyName("outboundIpAddresses")]
    public string? OutboundIpAddresses { get; set; }

    /// <summary>A comma separated list of outbound IP addresses - such as 52.23.25.3,52.143.43.12,52.143.43.17 - not all of which are necessarily in use. Superset of outbound_ip_addresses.</summary>
    [JsonPropertyName("possibleOutboundIpAddresses")]
    public string? PossibleOutboundIpAddresses { get; set; }

    /// <summary>The name of the resource group in which to create the Function App Slot. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A site_config object as defined below.</summary>
    [JsonPropertyName("siteConfig")]
    public V1beta1FunctionAppSlotStatusAtProviderSiteConfig? SiteConfig { get; set; }

    /// <summary>A site_credential block as defined below, which contains the site-level credentials used to publish to this Function App Slot.</summary>
    [JsonPropertyName("siteCredential")]
    public IList<V1beta1FunctionAppSlotStatusAtProviderSiteCredential>? SiteCredential { get; set; }

    /// <summary>The backend storage account name which will be used by the Function App (such as the dashboard, logs). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The runtime version associated with the Function App. Defaults to ~1.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotStatusConditions
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

/// <summary>FunctionAppSlotStatus defines the observed state of FunctionAppSlot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FunctionAppSlotStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1FunctionAppSlotStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FunctionAppSlotStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FunctionAppSlot is the Schema for the FunctionAppSlots API. Manages a Function App Deployment Slot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FunctionAppSlot : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FunctionAppSlotSpec>, IStatus<V1beta1FunctionAppSlotStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FunctionAppSlot";
    public const string KubeGroup = "web.azure.m.upbound.io";
    public const string KubePluralName = "functionappslots";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "web.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FunctionAppSlot";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FunctionAppSlotSpec defines the desired state of FunctionAppSlot</summary>
    [JsonPropertyName("spec")]
    public required V1beta1FunctionAppSlotSpec Spec { get; set; }

    /// <summary>FunctionAppSlotStatus defines the observed state of FunctionAppSlot.</summary>
    [JsonPropertyName("status")]
    public V1beta1FunctionAppSlotStatus? Status { get; set; }
}
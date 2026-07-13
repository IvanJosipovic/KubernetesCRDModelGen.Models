#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appengine.gcp.m.upbound.io;
/// <summary>Application is the Schema for the Applications API. Allows management of an App Engine application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ApplicationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Application>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ApplicationList";
    public const string KubeGroup = "appengine.gcp.m.upbound.io";
    public const string KubePluralName = "applications";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appengine.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ApplicationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Application objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Application> Items { get; set; }
}

/// <summary>A block of optional settings to configure specific App Engine features:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderFeatureSettings
{
    /// <summary>
    /// Set to false to use the legacy health check instead of the readiness
    /// and liveness checks.
    /// </summary>
    [JsonPropertyName("splitHealthChecks")]
    public bool? SplitHealthChecks { get; set; }
}

/// <summary>
/// OAuth2 client secret to use for the authentication flow.
/// The SHA-256 hash of the value is returned in the oauth2ClientSecretSha256 field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderIapOauth2ClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Settings for enabling Cloud Identity Aware Proxy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderIap
{
    /// <summary>
    /// Whether the serving infrastructure will authenticate and authorize all incoming requests.
    /// (default is false)
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>OAuth2 client ID to use for the authentication flow.</summary>
    [JsonPropertyName("oauth2ClientId")]
    public string? Oauth2ClientId { get; set; }

    /// <summary>
    /// OAuth2 client secret to use for the authentication flow.
    /// The SHA-256 hash of the value is returned in the oauth2ClientSecretSha256 field.
    /// </summary>
    [JsonPropertyName("oauth2ClientSecretSecretRef")]
    public V1beta1ApplicationSpecForProviderIapOauth2ClientSecretSecretRef? Oauth2ClientSecretSecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderProjectRefPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderProjectRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderProjectRefPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderProjectRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderProjectRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderProjectRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderProjectRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderProjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecForProviderProjectRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderProjectSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecForProviderProjectSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecForProviderProjectSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecForProviderProjectSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderProjectSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecForProviderProjectSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecForProviderProjectSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProviderProjectSelector
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
    public V1beta1ApplicationSpecForProviderProjectSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecForProvider
{
    /// <summary>The domain to authenticate users with when using App Engine&apos;s User API.</summary>
    [JsonPropertyName("authDomain")]
    public string? AuthDomain { get; set; }

    /// <summary>
    /// The type of the Cloud Firestore or Cloud Datastore database associated with this application.
    /// Can be CLOUD_FIRESTORE or CLOUD_DATASTORE_COMPATIBILITY for new
    /// instances.  To support old instances, the value CLOUD_DATASTORE is accepted by the provider, but will be rejected by the API.
    /// To create a Cloud Firestore database without creating an App Engine application, use the
    /// google_firestore_database
    /// resource instead.
    /// </summary>
    [JsonPropertyName("databaseType")]
    public string? DatabaseType { get; set; }

    /// <summary>A block of optional settings to configure specific App Engine features:</summary>
    [JsonPropertyName("featureSettings")]
    public V1beta1ApplicationSpecForProviderFeatureSettings? FeatureSettings { get; set; }

    /// <summary>Settings for enabling Cloud Identity Aware Proxy</summary>
    [JsonPropertyName("iap")]
    public V1beta1ApplicationSpecForProviderIap? Iap { get; set; }

    /// <summary>
    /// The location
    /// to serve the app from.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    /// <summary>
    /// The project ID to create the application under.
    /// ~&gt;NOTE: GCP only accepts project ID, not project number. If you are using number,
    /// you may get a &quot;Permission denied&quot; error.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1ApplicationSpecForProviderProjectRef? ProjectRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectSelector")]
    public V1beta1ApplicationSpecForProviderProjectSelector? ProjectSelector { get; set; }

    /// <summary>The serving status of the app.</summary>
    [JsonPropertyName("servingStatus")]
    public string? ServingStatus { get; set; }
}

/// <summary>A block of optional settings to configure specific App Engine features:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderFeatureSettings
{
    /// <summary>
    /// Set to false to use the legacy health check instead of the readiness
    /// and liveness checks.
    /// </summary>
    [JsonPropertyName("splitHealthChecks")]
    public bool? SplitHealthChecks { get; set; }
}

/// <summary>
/// OAuth2 client secret to use for the authentication flow.
/// The SHA-256 hash of the value is returned in the oauth2ClientSecretSha256 field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderIapOauth2ClientSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Settings for enabling Cloud Identity Aware Proxy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderIap
{
    /// <summary>
    /// Whether the serving infrastructure will authenticate and authorize all incoming requests.
    /// (default is false)
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>OAuth2 client ID to use for the authentication flow.</summary>
    [JsonPropertyName("oauth2ClientId")]
    public string? Oauth2ClientId { get; set; }

    /// <summary>
    /// OAuth2 client secret to use for the authentication flow.
    /// The SHA-256 hash of the value is returned in the oauth2ClientSecretSha256 field.
    /// </summary>
    [JsonPropertyName("oauth2ClientSecretSecretRef")]
    public required V1beta1ApplicationSpecInitProviderIapOauth2ClientSecretSecretRef Oauth2ClientSecretSecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderProjectRefPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderProjectRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderProjectRefPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderProjectRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderProjectRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderProjectRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderProjectRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderProjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ApplicationSpecInitProviderProjectRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderProjectSelectorPolicyResolutionEnum>))]
public enum V1beta1ApplicationSpecInitProviderProjectSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecInitProviderProjectSelectorPolicyResolveEnum>))]
public enum V1beta1ApplicationSpecInitProviderProjectSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderProjectSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ApplicationSpecInitProviderProjectSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ApplicationSpecInitProviderProjectSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecInitProviderProjectSelector
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
    public V1beta1ApplicationSpecInitProviderProjectSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1ApplicationSpecInitProvider
{
    /// <summary>The domain to authenticate users with when using App Engine&apos;s User API.</summary>
    [JsonPropertyName("authDomain")]
    public string? AuthDomain { get; set; }

    /// <summary>
    /// The type of the Cloud Firestore or Cloud Datastore database associated with this application.
    /// Can be CLOUD_FIRESTORE or CLOUD_DATASTORE_COMPATIBILITY for new
    /// instances.  To support old instances, the value CLOUD_DATASTORE is accepted by the provider, but will be rejected by the API.
    /// To create a Cloud Firestore database without creating an App Engine application, use the
    /// google_firestore_database
    /// resource instead.
    /// </summary>
    [JsonPropertyName("databaseType")]
    public string? DatabaseType { get; set; }

    /// <summary>A block of optional settings to configure specific App Engine features:</summary>
    [JsonPropertyName("featureSettings")]
    public V1beta1ApplicationSpecInitProviderFeatureSettings? FeatureSettings { get; set; }

    /// <summary>Settings for enabling Cloud Identity Aware Proxy</summary>
    [JsonPropertyName("iap")]
    public V1beta1ApplicationSpecInitProviderIap? Iap { get; set; }

    /// <summary>
    /// The location
    /// to serve the app from.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    /// <summary>
    /// The project ID to create the application under.
    /// ~&gt;NOTE: GCP only accepts project ID, not project number. If you are using number,
    /// you may get a &quot;Permission denied&quot; error.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1ApplicationSpecInitProviderProjectRef? ProjectRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectSelector")]
    public V1beta1ApplicationSpecInitProviderProjectSelector? ProjectSelector { get; set; }

    /// <summary>The serving status of the app.</summary>
    [JsonPropertyName("servingStatus")]
    public string? ServingStatus { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ApplicationSpecManagementPoliciesEnum>))]
public enum V1beta1ApplicationSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecProviderConfigRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ApplicationSpec defines the desired state of Application</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1ApplicationSpecForProvider ForProvider { get; set; }

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
    public V1beta1ApplicationSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ApplicationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ApplicationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ApplicationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A block of optional settings to configure specific App Engine features:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderFeatureSettings
{
    /// <summary>
    /// Set to false to use the legacy health check instead of the readiness
    /// and liveness checks.
    /// </summary>
    [JsonPropertyName("splitHealthChecks")]
    public bool? SplitHealthChecks { get; set; }
}

/// <summary>Settings for enabling Cloud Identity Aware Proxy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderIap
{
    /// <summary>
    /// Whether the serving infrastructure will authenticate and authorize all incoming requests.
    /// (default is false)
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>OAuth2 client ID to use for the authentication flow.</summary>
    [JsonPropertyName("oauth2ClientId")]
    public string? Oauth2ClientId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProviderUrlDispatchRule
{
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusAtProvider
{
    /// <summary>Identifier of the app, usually {PROJECT_ID}</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>The domain to authenticate users with when using App Engine&apos;s User API.</summary>
    [JsonPropertyName("authDomain")]
    public string? AuthDomain { get; set; }

    /// <summary>The GCS bucket code is being stored in for this app.</summary>
    [JsonPropertyName("codeBucket")]
    public string? CodeBucket { get; set; }

    /// <summary>
    /// The type of the Cloud Firestore or Cloud Datastore database associated with this application.
    /// Can be CLOUD_FIRESTORE or CLOUD_DATASTORE_COMPATIBILITY for new
    /// instances.  To support old instances, the value CLOUD_DATASTORE is accepted by the provider, but will be rejected by the API.
    /// To create a Cloud Firestore database without creating an App Engine application, use the
    /// google_firestore_database
    /// resource instead.
    /// </summary>
    [JsonPropertyName("databaseType")]
    public string? DatabaseType { get; set; }

    /// <summary>The GCS bucket content is being stored in for this app.</summary>
    [JsonPropertyName("defaultBucket")]
    public string? DefaultBucket { get; set; }

    /// <summary>The default hostname for this app.</summary>
    [JsonPropertyName("defaultHostname")]
    public string? DefaultHostname { get; set; }

    /// <summary>A block of optional settings to configure specific App Engine features:</summary>
    [JsonPropertyName("featureSettings")]
    public V1beta1ApplicationStatusAtProviderFeatureSettings? FeatureSettings { get; set; }

    /// <summary>The GCR domain used for storing managed Docker images for this app.</summary>
    [JsonPropertyName("gcrDomain")]
    public string? GcrDomain { get; set; }

    /// <summary>Settings for enabling Cloud Identity Aware Proxy</summary>
    [JsonPropertyName("iap")]
    public V1beta1ApplicationStatusAtProviderIap? Iap { get; set; }

    /// <summary>an identifier for the resource with format {{project}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The location
    /// to serve the app from.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    /// <summary>Unique name of the app, usually apps/{PROJECT_ID}</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The project ID to create the application under.
    /// ~&gt;NOTE: GCP only accepts project ID, not project number. If you are using number,
    /// you may get a &quot;Permission denied&quot; error.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The serving status of the app.</summary>
    [JsonPropertyName("servingStatus")]
    public string? ServingStatus { get; set; }

    /// <summary>A list of dispatch rule blocks. Each block has a domain, path, and service field.</summary>
    [JsonPropertyName("urlDispatchRule")]
    public IList<V1beta1ApplicationStatusAtProviderUrlDispatchRule>? UrlDispatchRule { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatusConditions
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

/// <summary>ApplicationStatus defines the observed state of Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ApplicationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ApplicationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ApplicationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Application is the Schema for the Applications API. Allows management of an App Engine application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Application : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ApplicationSpec>, IStatus<V1beta1ApplicationStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Application";
    public const string KubeGroup = "appengine.gcp.m.upbound.io";
    public const string KubePluralName = "applications";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appengine.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Application";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ApplicationSpec defines the desired state of Application</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ApplicationSpec Spec { get; set; }

    /// <summary>ApplicationStatus defines the observed state of Application.</summary>
    [JsonPropertyName("status")]
    public V1beta1ApplicationStatus? Status { get; set; }
}
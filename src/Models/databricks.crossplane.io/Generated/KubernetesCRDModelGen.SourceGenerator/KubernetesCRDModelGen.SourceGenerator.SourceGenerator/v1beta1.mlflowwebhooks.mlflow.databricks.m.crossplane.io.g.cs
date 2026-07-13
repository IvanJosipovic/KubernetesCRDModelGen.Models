#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.mlflow.databricks.m.crossplane.io;
/// <summary>MlflowWebhook is the Schema for the MlflowWebhooks API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MlflowWebhookList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MlflowWebhook>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MlflowWebhookList";
    public const string KubeGroup = "mlflow.databricks.m.crossplane.io";
    public const string KubePluralName = "mlflowwebhooks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "mlflow.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MlflowWebhookList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1MlflowWebhook objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1MlflowWebhook> Items { get; set; }
}

/// <summary>Shared secret required for HMAC encoding payload. The HMAC-encoded payload will be sent in the header as X-Databricks-Signature: encoded_payload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecForProviderHttpUrlSpecSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecForProviderHttpUrlSpec
{
    /// <summary>Value of the authorization header that should be sent in the request sent by the wehbook.  It should be of the form &lt;auth type&gt; &lt;credentials&gt;, e.g. Bearer &lt;access_token&gt;. If set to an empty string, no authorization header will be included in the request.</summary>
    [JsonPropertyName("authorization")]
    public string? Authorization { get; set; }

    /// <summary>Enable/disable SSL certificate validation. Default is true. For self-signed certificates, this field must be false AND the destination server must disable certificate validation as well. For security purposes, it is encouraged to perform secret validation with the HMAC-encoded portion of the payload and acknowledge the risk associated with disabling hostname validation whereby it becomes more likely that requests can be maliciously routed to an unintended host.</summary>
    [JsonPropertyName("enableSslVerification")]
    public bool? EnableSslVerification { get; set; }

    /// <summary>Shared secret required for HMAC encoding payload. The HMAC-encoded payload will be sent in the header as X-Databricks-Signature: encoded_payload.</summary>
    [JsonPropertyName("secretSecretRef")]
    public V1beta1MlflowWebhookSpecForProviderHttpUrlSpecSecretSecretRef? SecretSecretRef { get; set; }

    /// <summary>External HTTPS URL called on event trigger (by using a POST request). Structure of payload depends on the event type, refer to documentation for more details.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>The personal access token used to authorize webhook&apos;s job runs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecForProviderJobSpecAccessTokenSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MlflowWebhookSpecForProviderJobSpecJobIdRefPolicyResolutionEnum>))]
public enum V1beta1MlflowWebhookSpecForProviderJobSpecJobIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MlflowWebhookSpecForProviderJobSpecJobIdRefPolicyResolveEnum>))]
public enum V1beta1MlflowWebhookSpecForProviderJobSpecJobIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecForProviderJobSpecJobIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MlflowWebhookSpecForProviderJobSpecJobIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MlflowWebhookSpecForProviderJobSpecJobIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Job in compute to populate jobId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecForProviderJobSpecJobIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MlflowWebhookSpecForProviderJobSpecJobIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MlflowWebhookSpecForProviderJobSpecJobIdSelectorPolicyResolutionEnum>))]
public enum V1beta1MlflowWebhookSpecForProviderJobSpecJobIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MlflowWebhookSpecForProviderJobSpecJobIdSelectorPolicyResolveEnum>))]
public enum V1beta1MlflowWebhookSpecForProviderJobSpecJobIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecForProviderJobSpecJobIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MlflowWebhookSpecForProviderJobSpecJobIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MlflowWebhookSpecForProviderJobSpecJobIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Job in compute to populate jobId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecForProviderJobSpecJobIdSelector
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
    public V1beta1MlflowWebhookSpecForProviderJobSpecJobIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecForProviderJobSpec
{
    /// <summary>The personal access token used to authorize webhook&apos;s job runs.</summary>
    [JsonPropertyName("accessTokenSecretRef")]
    public V1beta1MlflowWebhookSpecForProviderJobSpecAccessTokenSecretRef? AccessTokenSecretRef { get; set; }

    /// <summary>ID of the Databricks job that the webhook runs.</summary>
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    /// <summary>Reference to a Job in compute to populate jobId.</summary>
    [JsonPropertyName("jobIdRef")]
    public V1beta1MlflowWebhookSpecForProviderJobSpecJobIdRef? JobIdRef { get; set; }

    /// <summary>Selector for a Job in compute to populate jobId.</summary>
    [JsonPropertyName("jobIdSelector")]
    public V1beta1MlflowWebhookSpecForProviderJobSpecJobIdSelector? JobIdSelector { get; set; }

    /// <summary>URL of the workspace containing the job that this webhook runs. If not specified, the job’s workspace URL is assumed to be the same as the workspace where the webhook is created.</summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecForProvider
{
    /// <summary>Optional description of the MLflow webhook.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The list of events that will trigger execution of Databricks job or POSTing to an URL, for example, MODEL_VERSION_CREATED, MODEL_VERSION_TRANSITIONED_STAGE, TRANSITION_REQUEST_CREATED, etc.  Refer to the Webhooks API documentation for a full list of supported events.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    [JsonPropertyName("httpUrlSpec")]
    public V1beta1MlflowWebhookSpecForProviderHttpUrlSpec? HttpUrlSpec { get; set; }

    [JsonPropertyName("jobSpec")]
    public V1beta1MlflowWebhookSpecForProviderJobSpec? JobSpec { get; set; }

    /// <summary>Name of MLflow model for which webhook will be created. If the model name is not specified, a registry-wide webhook is created that listens for the specified events across all versions of all registered models.</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1MlflowWebhookSpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Optional status of webhook. Possible values are ACTIVE, TEST_MODE, DISABLED. Default is ACTIVE.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Shared secret required for HMAC encoding payload. The HMAC-encoded payload will be sent in the header as X-Databricks-Signature: encoded_payload.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecInitProviderHttpUrlSpecSecretSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecInitProviderHttpUrlSpec
{
    /// <summary>Value of the authorization header that should be sent in the request sent by the wehbook.  It should be of the form &lt;auth type&gt; &lt;credentials&gt;, e.g. Bearer &lt;access_token&gt;. If set to an empty string, no authorization header will be included in the request.</summary>
    [JsonPropertyName("authorization")]
    public string? Authorization { get; set; }

    /// <summary>Enable/disable SSL certificate validation. Default is true. For self-signed certificates, this field must be false AND the destination server must disable certificate validation as well. For security purposes, it is encouraged to perform secret validation with the HMAC-encoded portion of the payload and acknowledge the risk associated with disabling hostname validation whereby it becomes more likely that requests can be maliciously routed to an unintended host.</summary>
    [JsonPropertyName("enableSslVerification")]
    public bool? EnableSslVerification { get; set; }

    /// <summary>Shared secret required for HMAC encoding payload. The HMAC-encoded payload will be sent in the header as X-Databricks-Signature: encoded_payload.</summary>
    [JsonPropertyName("secretSecretRef")]
    public V1beta1MlflowWebhookSpecInitProviderHttpUrlSpecSecretSecretRef? SecretSecretRef { get; set; }

    /// <summary>External HTTPS URL called on event trigger (by using a POST request). Structure of payload depends on the event type, refer to documentation for more details.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>The personal access token used to authorize webhook&apos;s job runs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecInitProviderJobSpecAccessTokenSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdRefPolicyResolutionEnum>))]
public enum V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdRefPolicyResolveEnum>))]
public enum V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Job in compute to populate jobId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdSelectorPolicyResolutionEnum>))]
public enum V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdSelectorPolicyResolveEnum>))]
public enum V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Job in compute to populate jobId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdSelector
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
    public V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecInitProviderJobSpec
{
    /// <summary>The personal access token used to authorize webhook&apos;s job runs.</summary>
    [JsonPropertyName("accessTokenSecretRef")]
    public required V1beta1MlflowWebhookSpecInitProviderJobSpecAccessTokenSecretRef AccessTokenSecretRef { get; set; }

    /// <summary>ID of the Databricks job that the webhook runs.</summary>
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    /// <summary>Reference to a Job in compute to populate jobId.</summary>
    [JsonPropertyName("jobIdRef")]
    public V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdRef? JobIdRef { get; set; }

    /// <summary>Selector for a Job in compute to populate jobId.</summary>
    [JsonPropertyName("jobIdSelector")]
    public V1beta1MlflowWebhookSpecInitProviderJobSpecJobIdSelector? JobIdSelector { get; set; }

    /// <summary>URL of the workspace containing the job that this webhook runs. If not specified, the job’s workspace URL is assumed to be the same as the workspace where the webhook is created.</summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
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
public partial class V1beta1MlflowWebhookSpecInitProvider
{
    /// <summary>Optional description of the MLflow webhook.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The list of events that will trigger execution of Databricks job or POSTing to an URL, for example, MODEL_VERSION_CREATED, MODEL_VERSION_TRANSITIONED_STAGE, TRANSITION_REQUEST_CREATED, etc.  Refer to the Webhooks API documentation for a full list of supported events.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    [JsonPropertyName("httpUrlSpec")]
    public V1beta1MlflowWebhookSpecInitProviderHttpUrlSpec? HttpUrlSpec { get; set; }

    [JsonPropertyName("jobSpec")]
    public V1beta1MlflowWebhookSpecInitProviderJobSpec? JobSpec { get; set; }

    /// <summary>Name of MLflow model for which webhook will be created. If the model name is not specified, a registry-wide webhook is created that listens for the specified events across all versions of all registered models.</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1MlflowWebhookSpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Optional status of webhook. Possible values are ACTIVE, TEST_MODE, DISABLED. Default is ACTIVE.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MlflowWebhookSpecManagementPoliciesEnum>))]
public enum V1beta1MlflowWebhookSpecManagementPoliciesEnum
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
public partial class V1beta1MlflowWebhookSpecProviderConfigRef
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
public partial class V1beta1MlflowWebhookSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>MlflowWebhookSpec defines the desired state of MlflowWebhook</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1MlflowWebhookSpecForProvider ForProvider { get; set; }

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
    public V1beta1MlflowWebhookSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1MlflowWebhookSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MlflowWebhookSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MlflowWebhookSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookStatusAtProviderHttpUrlSpec
{
    /// <summary>Value of the authorization header that should be sent in the request sent by the wehbook.  It should be of the form &lt;auth type&gt; &lt;credentials&gt;, e.g. Bearer &lt;access_token&gt;. If set to an empty string, no authorization header will be included in the request.</summary>
    [JsonPropertyName("authorization")]
    public string? Authorization { get; set; }

    /// <summary>Enable/disable SSL certificate validation. Default is true. For self-signed certificates, this field must be false AND the destination server must disable certificate validation as well. For security purposes, it is encouraged to perform secret validation with the HMAC-encoded portion of the payload and acknowledge the risk associated with disabling hostname validation whereby it becomes more likely that requests can be maliciously routed to an unintended host.</summary>
    [JsonPropertyName("enableSslVerification")]
    public bool? EnableSslVerification { get; set; }

    /// <summary>External HTTPS URL called on event trigger (by using a POST request). Structure of payload depends on the event type, refer to documentation for more details.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookStatusAtProviderJobSpec
{
    /// <summary>ID of the Databricks job that the webhook runs.</summary>
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    /// <summary>URL of the workspace containing the job that this webhook runs. If not specified, the job’s workspace URL is assumed to be the same as the workspace where the webhook is created.</summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookStatusAtProvider
{
    /// <summary>Optional description of the MLflow webhook.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The list of events that will trigger execution of Databricks job or POSTing to an URL, for example, MODEL_VERSION_CREATED, MODEL_VERSION_TRANSITIONED_STAGE, TRANSITION_REQUEST_CREATED, etc.  Refer to the Webhooks API documentation for a full list of supported events.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    [JsonPropertyName("httpUrlSpec")]
    public V1beta1MlflowWebhookStatusAtProviderHttpUrlSpec? HttpUrlSpec { get; set; }

    /// <summary>Unique ID of the MLflow Webhook.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("jobSpec")]
    public V1beta1MlflowWebhookStatusAtProviderJobSpec? JobSpec { get; set; }

    /// <summary>Name of MLflow model for which webhook will be created. If the model name is not specified, a registry-wide webhook is created that listens for the specified events across all versions of all registered models.</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1MlflowWebhookStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Optional status of webhook. Possible values are ACTIVE, TEST_MODE, DISABLED. Default is ACTIVE.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookStatusConditions
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

/// <summary>MlflowWebhookStatus defines the observed state of MlflowWebhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MlflowWebhookStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1MlflowWebhookStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MlflowWebhookStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MlflowWebhook is the Schema for the MlflowWebhooks API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MlflowWebhook : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MlflowWebhookSpec>, IStatus<V1beta1MlflowWebhookStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MlflowWebhook";
    public const string KubeGroup = "mlflow.databricks.m.crossplane.io";
    public const string KubePluralName = "mlflowwebhooks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "mlflow.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MlflowWebhook";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MlflowWebhookSpec defines the desired state of MlflowWebhook</summary>
    [JsonPropertyName("spec")]
    public required V1beta1MlflowWebhookSpec Spec { get; set; }

    /// <summary>MlflowWebhookStatus defines the observed state of MlflowWebhook.</summary>
    [JsonPropertyName("status")]
    public V1beta1MlflowWebhookStatus? Status { get; set; }
}
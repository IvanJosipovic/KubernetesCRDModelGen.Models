#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.log.databricks.m.crossplane.io;
/// <summary>MwsLogDelivery is the Schema for the MwsLogDeliverys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MwsLogDeliveryList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MwsLogDelivery>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MwsLogDeliveryList";
    public const string KubeGroup = "log.databricks.m.crossplane.io";
    public const string KubePluralName = "mwslogdeliveries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "log.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MwsLogDeliveryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1MwsLogDelivery objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1MwsLogDelivery> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsLogDeliverySpecForProviderCredentialsIdRefPolicyResolutionEnum>))]
public enum V1beta1MwsLogDeliverySpecForProviderCredentialsIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsLogDeliverySpecForProviderCredentialsIdRefPolicyResolveEnum>))]
public enum V1beta1MwsLogDeliverySpecForProviderCredentialsIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliverySpecForProviderCredentialsIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MwsLogDeliverySpecForProviderCredentialsIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MwsLogDeliverySpecForProviderCredentialsIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MwsCredentials in deployment to populate credentialsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliverySpecForProviderCredentialsIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MwsLogDeliverySpecForProviderCredentialsIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsLogDeliverySpecForProviderCredentialsIdSelectorPolicyResolutionEnum>))]
public enum V1beta1MwsLogDeliverySpecForProviderCredentialsIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsLogDeliverySpecForProviderCredentialsIdSelectorPolicyResolveEnum>))]
public enum V1beta1MwsLogDeliverySpecForProviderCredentialsIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliverySpecForProviderCredentialsIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MwsLogDeliverySpecForProviderCredentialsIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MwsLogDeliverySpecForProviderCredentialsIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MwsCredentials in deployment to populate credentialsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliverySpecForProviderCredentialsIdSelector
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
    public V1beta1MwsLogDeliverySpecForProviderCredentialsIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdRefPolicyResolutionEnum>))]
public enum V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdRefPolicyResolveEnum>))]
public enum V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MwsStorageConfigurations in deployment to populate storageConfigurationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdSelectorPolicyResolutionEnum>))]
public enum V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdSelectorPolicyResolveEnum>))]
public enum V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MwsStorageConfigurations in deployment to populate storageConfigurationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdSelector
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
    public V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliverySpecForProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Databricks log delivery configuration ID.</summary>
    [JsonPropertyName("configId")]
    public string? ConfigId { get; set; }

    /// <summary>The optional human-readable name of the log delivery configuration. Defaults to empty.</summary>
    [JsonPropertyName("configName")]
    public string? ConfigName { get; set; }

    /// <summary>The ID for a Databricks credential configuration that represents the AWS IAM role with policy and trust relationship as described in the main billable usage documentation page.</summary>
    [JsonPropertyName("credentialsId")]
    public string? CredentialsId { get; set; }

    /// <summary>Reference to a MwsCredentials in deployment to populate credentialsId.</summary>
    [JsonPropertyName("credentialsIdRef")]
    public V1beta1MwsLogDeliverySpecForProviderCredentialsIdRef? CredentialsIdRef { get; set; }

    /// <summary>Selector for a MwsCredentials in deployment to populate credentialsId.</summary>
    [JsonPropertyName("credentialsIdSelector")]
    public V1beta1MwsLogDeliverySpecForProviderCredentialsIdSelector? CredentialsIdSelector { get; set; }

    /// <summary>Defaults to empty, which means that logs are delivered to the root of the bucket. The value must be a valid S3 object key. It must not start or end with a slash character.</summary>
    [JsonPropertyName("deliveryPathPrefix")]
    public string? DeliveryPathPrefix { get; set; }

    /// <summary>The optional start month and year for delivery, specified in YYYY-MM format. Defaults to current year and month. Usage is not available before 2019-03.</summary>
    [JsonPropertyName("deliveryStartTime")]
    public string? DeliveryStartTime { get; set; }

    /// <summary>The type of log delivery. BILLABLE_USAGE and AUDIT_LOGS are supported.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }

    /// <summary>The file type of log delivery. Currently CSV (for BILLABLE_USAGE) and JSON (for AUDIT_LOGS) are supported.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>Status of log delivery configuration. Set to ENABLED or DISABLED. Defaults to ENABLED. This is the only field you can update.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The ID for a Databricks storage configuration that represents the S3 bucket with bucket policy as described in the main billable usage documentation page.</summary>
    [JsonPropertyName("storageConfigurationId")]
    public string? StorageConfigurationId { get; set; }

    /// <summary>Reference to a MwsStorageConfigurations in deployment to populate storageConfigurationId.</summary>
    [JsonPropertyName("storageConfigurationIdRef")]
    public V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdRef? StorageConfigurationIdRef { get; set; }

    /// <summary>Selector for a MwsStorageConfigurations in deployment to populate storageConfigurationId.</summary>
    [JsonPropertyName("storageConfigurationIdSelector")]
    public V1beta1MwsLogDeliverySpecForProviderStorageConfigurationIdSelector? StorageConfigurationIdSelector { get; set; }

    /// <summary>By default, this log configuration applies to all workspaces associated with your account ID. If your account is on the multitenant version of the platform or on a select custom plan that allows multiple workspaces per account, you may have multiple workspaces associated with your account ID. You can optionally set the field as mentioned earlier to an array of workspace IDs. If you plan to use different log delivery configurations for several workspaces, set this explicitly rather than leaving it blank. If you leave this blank and your account ID gets additional workspaces in the future, this configuration will also apply to the new workspaces.</summary>
    [JsonPropertyName("workspaceIdsFilter")]
    public IList<double>? WorkspaceIdsFilter { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsLogDeliverySpecInitProviderCredentialsIdRefPolicyResolutionEnum>))]
public enum V1beta1MwsLogDeliverySpecInitProviderCredentialsIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsLogDeliverySpecInitProviderCredentialsIdRefPolicyResolveEnum>))]
public enum V1beta1MwsLogDeliverySpecInitProviderCredentialsIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliverySpecInitProviderCredentialsIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MwsLogDeliverySpecInitProviderCredentialsIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MwsLogDeliverySpecInitProviderCredentialsIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MwsCredentials in deployment to populate credentialsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliverySpecInitProviderCredentialsIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MwsLogDeliverySpecInitProviderCredentialsIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsLogDeliverySpecInitProviderCredentialsIdSelectorPolicyResolutionEnum>))]
public enum V1beta1MwsLogDeliverySpecInitProviderCredentialsIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsLogDeliverySpecInitProviderCredentialsIdSelectorPolicyResolveEnum>))]
public enum V1beta1MwsLogDeliverySpecInitProviderCredentialsIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliverySpecInitProviderCredentialsIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MwsLogDeliverySpecInitProviderCredentialsIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MwsLogDeliverySpecInitProviderCredentialsIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MwsCredentials in deployment to populate credentialsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliverySpecInitProviderCredentialsIdSelector
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
    public V1beta1MwsLogDeliverySpecInitProviderCredentialsIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdRefPolicyResolutionEnum>))]
public enum V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdRefPolicyResolveEnum>))]
public enum V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MwsStorageConfigurations in deployment to populate storageConfigurationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdSelectorPolicyResolutionEnum>))]
public enum V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdSelectorPolicyResolveEnum>))]
public enum V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MwsStorageConfigurations in deployment to populate storageConfigurationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdSelector
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
    public V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1MwsLogDeliverySpecInitProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Databricks log delivery configuration ID.</summary>
    [JsonPropertyName("configId")]
    public string? ConfigId { get; set; }

    /// <summary>The optional human-readable name of the log delivery configuration. Defaults to empty.</summary>
    [JsonPropertyName("configName")]
    public string? ConfigName { get; set; }

    /// <summary>The ID for a Databricks credential configuration that represents the AWS IAM role with policy and trust relationship as described in the main billable usage documentation page.</summary>
    [JsonPropertyName("credentialsId")]
    public string? CredentialsId { get; set; }

    /// <summary>Reference to a MwsCredentials in deployment to populate credentialsId.</summary>
    [JsonPropertyName("credentialsIdRef")]
    public V1beta1MwsLogDeliverySpecInitProviderCredentialsIdRef? CredentialsIdRef { get; set; }

    /// <summary>Selector for a MwsCredentials in deployment to populate credentialsId.</summary>
    [JsonPropertyName("credentialsIdSelector")]
    public V1beta1MwsLogDeliverySpecInitProviderCredentialsIdSelector? CredentialsIdSelector { get; set; }

    /// <summary>Defaults to empty, which means that logs are delivered to the root of the bucket. The value must be a valid S3 object key. It must not start or end with a slash character.</summary>
    [JsonPropertyName("deliveryPathPrefix")]
    public string? DeliveryPathPrefix { get; set; }

    /// <summary>The optional start month and year for delivery, specified in YYYY-MM format. Defaults to current year and month. Usage is not available before 2019-03.</summary>
    [JsonPropertyName("deliveryStartTime")]
    public string? DeliveryStartTime { get; set; }

    /// <summary>The type of log delivery. BILLABLE_USAGE and AUDIT_LOGS are supported.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }

    /// <summary>The file type of log delivery. Currently CSV (for BILLABLE_USAGE) and JSON (for AUDIT_LOGS) are supported.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>Status of log delivery configuration. Set to ENABLED or DISABLED. Defaults to ENABLED. This is the only field you can update.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The ID for a Databricks storage configuration that represents the S3 bucket with bucket policy as described in the main billable usage documentation page.</summary>
    [JsonPropertyName("storageConfigurationId")]
    public string? StorageConfigurationId { get; set; }

    /// <summary>Reference to a MwsStorageConfigurations in deployment to populate storageConfigurationId.</summary>
    [JsonPropertyName("storageConfigurationIdRef")]
    public V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdRef? StorageConfigurationIdRef { get; set; }

    /// <summary>Selector for a MwsStorageConfigurations in deployment to populate storageConfigurationId.</summary>
    [JsonPropertyName("storageConfigurationIdSelector")]
    public V1beta1MwsLogDeliverySpecInitProviderStorageConfigurationIdSelector? StorageConfigurationIdSelector { get; set; }

    /// <summary>By default, this log configuration applies to all workspaces associated with your account ID. If your account is on the multitenant version of the platform or on a select custom plan that allows multiple workspaces per account, you may have multiple workspaces associated with your account ID. You can optionally set the field as mentioned earlier to an array of workspace IDs. If you plan to use different log delivery configurations for several workspaces, set this explicitly rather than leaving it blank. If you leave this blank and your account ID gets additional workspaces in the future, this configuration will also apply to the new workspaces.</summary>
    [JsonPropertyName("workspaceIdsFilter")]
    public IList<double>? WorkspaceIdsFilter { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MwsLogDeliverySpecManagementPoliciesEnum>))]
public enum V1beta1MwsLogDeliverySpecManagementPoliciesEnum
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
public partial class V1beta1MwsLogDeliverySpecProviderConfigRef
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
public partial class V1beta1MwsLogDeliverySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>MwsLogDeliverySpec defines the desired state of MwsLogDelivery</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliverySpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1MwsLogDeliverySpecForProvider ForProvider { get; set; }

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
    public V1beta1MwsLogDeliverySpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1MwsLogDeliverySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MwsLogDeliverySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MwsLogDeliverySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliveryStatusAtProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Databricks log delivery configuration ID.</summary>
    [JsonPropertyName("configId")]
    public string? ConfigId { get; set; }

    /// <summary>The optional human-readable name of the log delivery configuration. Defaults to empty.</summary>
    [JsonPropertyName("configName")]
    public string? ConfigName { get; set; }

    /// <summary>The ID for a Databricks credential configuration that represents the AWS IAM role with policy and trust relationship as described in the main billable usage documentation page.</summary>
    [JsonPropertyName("credentialsId")]
    public string? CredentialsId { get; set; }

    /// <summary>Defaults to empty, which means that logs are delivered to the root of the bucket. The value must be a valid S3 object key. It must not start or end with a slash character.</summary>
    [JsonPropertyName("deliveryPathPrefix")]
    public string? DeliveryPathPrefix { get; set; }

    /// <summary>The optional start month and year for delivery, specified in YYYY-MM format. Defaults to current year and month. Usage is not available before 2019-03.</summary>
    [JsonPropertyName("deliveryStartTime")]
    public string? DeliveryStartTime { get; set; }

    /// <summary>the ID of log delivery configuration in form of account_id|config_id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The type of log delivery. BILLABLE_USAGE and AUDIT_LOGS are supported.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }

    /// <summary>The file type of log delivery. Currently CSV (for BILLABLE_USAGE) and JSON (for AUDIT_LOGS) are supported.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    /// <summary>Status of log delivery configuration. Set to ENABLED or DISABLED. Defaults to ENABLED. This is the only field you can update.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The ID for a Databricks storage configuration that represents the S3 bucket with bucket policy as described in the main billable usage documentation page.</summary>
    [JsonPropertyName("storageConfigurationId")]
    public string? StorageConfigurationId { get; set; }

    /// <summary>By default, this log configuration applies to all workspaces associated with your account ID. If your account is on the multitenant version of the platform or on a select custom plan that allows multiple workspaces per account, you may have multiple workspaces associated with your account ID. You can optionally set the field as mentioned earlier to an array of workspace IDs. If you plan to use different log delivery configurations for several workspaces, set this explicitly rather than leaving it blank. If you leave this blank and your account ID gets additional workspaces in the future, this configuration will also apply to the new workspaces.</summary>
    [JsonPropertyName("workspaceIdsFilter")]
    public IList<double>? WorkspaceIdsFilter { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliveryStatusConditions
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

/// <summary>MwsLogDeliveryStatus defines the observed state of MwsLogDelivery.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MwsLogDeliveryStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1MwsLogDeliveryStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MwsLogDeliveryStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MwsLogDelivery is the Schema for the MwsLogDeliverys API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MwsLogDelivery : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MwsLogDeliverySpec>, IStatus<V1beta1MwsLogDeliveryStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MwsLogDelivery";
    public const string KubeGroup = "log.databricks.m.crossplane.io";
    public const string KubePluralName = "mwslogdeliveries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "log.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MwsLogDelivery";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MwsLogDeliverySpec defines the desired state of MwsLogDelivery</summary>
    [JsonPropertyName("spec")]
    public required V1beta1MwsLogDeliverySpec Spec { get; set; }

    /// <summary>MwsLogDeliveryStatus defines the observed state of MwsLogDelivery.</summary>
    [JsonPropertyName("status")]
    public V1beta1MwsLogDeliveryStatus? Status { get; set; }
}
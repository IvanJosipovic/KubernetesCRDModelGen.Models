#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudquotas.gcp.upbound.io;
/// <summary>QuotaPreference is the Schema for the QuotaPreferences API. QuotaPreference represents the preferred quota configuration specified for a project, folder or organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1QuotaPreferenceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1QuotaPreference>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "QuotaPreferenceList";
    public const string KubeGroup = "cloudquotas.gcp.upbound.io";
    public const string KubePluralName = "quotapreferences";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudquotas.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "QuotaPreferenceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1QuotaPreference objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1QuotaPreference> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuotaPreferenceSpecDeletionPolicyEnum>))]
public enum V1beta1QuotaPreferenceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// The preferred quota configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuotaPreferenceSpecForProviderQuotaConfig
{
    /// <summary>
    /// The annotations map for clients to store small amounts of arbitrary data. Do not put PII or other sensitive information here. See https://google.aip.dev/128#annotations.
    /// An object containing a list of &quot;key: value&quot; pairs. Example: { &quot;name&quot;: &quot;wrench&quot;, &quot;mass&quot;: &quot;1.3kg&quot;, &quot;count&quot;: &quot;3&quot; }.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>The preferred value. Must be greater than or equal to -1. If set to -1, it means the value is &quot;unlimited&quot;.</summary>
    [JsonPropertyName("preferredValue")]
    public string? PreferredValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuotaPreferenceSpecForProvider
{
    /// <summary>
    /// An email address that can be used for quota related communication between the Google Cloud and the user in case the Google Cloud needs further information to make a decision on whether the user preferred quota can be granted.
    /// The Google account for the email address must have quota update permission for the project, folder or organization this quota preference is for.
    /// </summary>
    [JsonPropertyName("contactEmail")]
    public string? ContactEmail { get; set; }

    /// <summary>
    /// The dimensions that this quota preference applies to. The key of the map entry is the name of a dimension, such as &quot;region&quot;, &quot;zone&quot;, &quot;network_id&quot;, and the value of the map entry is the dimension value. If a dimension is missing from the map of dimensions, the quota preference applies to all the dimension values except for those that have other quota preferences configured for the specific value.
    /// NOTE: QuotaPreferences can only be applied across all values of &quot;user&quot; and &quot;resource&quot; dimension. Do not set values for &quot;user&quot; or &quot;resource&quot; in the dimension map.
    /// Example: {&quot;provider&quot;: &quot;Foo Inc&quot;} where &quot;provider&quot; is a service specific dimension.
    /// </summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>
    /// The list of quota safety checks to be ignored.
    /// Default value is QUOTA_SAFETY_CHECK_UNSPECIFIED.
    /// Possible values are: QUOTA_SAFETY_CHECK_UNSPECIFIED, QUOTA_DECREASE_BELOW_USAGE, QUOTA_DECREASE_PERCENTAGE_TOO_HIGH.
    /// </summary>
    [JsonPropertyName("ignoreSafetyChecks")]
    public string? IgnoreSafetyChecks { get; set; }

    /// <summary>The reason / justification for this quota preference.</summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>The parent of the quota preference. Allowed parents are &quot;projects/[project-id / number]&quot; or &quot;folders/[folder-id / number]&quot; or &quot;organizations/[org-id / number]&quot;.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// The preferred quota configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("quotaConfig")]
    public V1beta1QuotaPreferenceSpecForProviderQuotaConfig? QuotaConfig { get; set; }

    /// <summary>
    /// The id of the quota to which the quota preference is applied. A quota id is unique in the service.
    /// Example: CPUS-per-project-region.
    /// </summary>
    [JsonPropertyName("quotaId")]
    public string? QuotaId { get; set; }

    /// <summary>The name of the service to which the quota preference is applied.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>
/// The preferred quota configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuotaPreferenceSpecInitProviderQuotaConfig
{
    /// <summary>
    /// The annotations map for clients to store small amounts of arbitrary data. Do not put PII or other sensitive information here. See https://google.aip.dev/128#annotations.
    /// An object containing a list of &quot;key: value&quot; pairs. Example: { &quot;name&quot;: &quot;wrench&quot;, &quot;mass&quot;: &quot;1.3kg&quot;, &quot;count&quot;: &quot;3&quot; }.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>The preferred value. Must be greater than or equal to -1. If set to -1, it means the value is &quot;unlimited&quot;.</summary>
    [JsonPropertyName("preferredValue")]
    public string? PreferredValue { get; set; }
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
public partial class V1beta1QuotaPreferenceSpecInitProvider
{
    /// <summary>
    /// An email address that can be used for quota related communication between the Google Cloud and the user in case the Google Cloud needs further information to make a decision on whether the user preferred quota can be granted.
    /// The Google account for the email address must have quota update permission for the project, folder or organization this quota preference is for.
    /// </summary>
    [JsonPropertyName("contactEmail")]
    public string? ContactEmail { get; set; }

    /// <summary>
    /// The dimensions that this quota preference applies to. The key of the map entry is the name of a dimension, such as &quot;region&quot;, &quot;zone&quot;, &quot;network_id&quot;, and the value of the map entry is the dimension value. If a dimension is missing from the map of dimensions, the quota preference applies to all the dimension values except for those that have other quota preferences configured for the specific value.
    /// NOTE: QuotaPreferences can only be applied across all values of &quot;user&quot; and &quot;resource&quot; dimension. Do not set values for &quot;user&quot; or &quot;resource&quot; in the dimension map.
    /// Example: {&quot;provider&quot;: &quot;Foo Inc&quot;} where &quot;provider&quot; is a service specific dimension.
    /// </summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>
    /// The list of quota safety checks to be ignored.
    /// Default value is QUOTA_SAFETY_CHECK_UNSPECIFIED.
    /// Possible values are: QUOTA_SAFETY_CHECK_UNSPECIFIED, QUOTA_DECREASE_BELOW_USAGE, QUOTA_DECREASE_PERCENTAGE_TOO_HIGH.
    /// </summary>
    [JsonPropertyName("ignoreSafetyChecks")]
    public string? IgnoreSafetyChecks { get; set; }

    /// <summary>The reason / justification for this quota preference.</summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>
    /// The preferred quota configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("quotaConfig")]
    public V1beta1QuotaPreferenceSpecInitProviderQuotaConfig? QuotaConfig { get; set; }

    /// <summary>
    /// The id of the quota to which the quota preference is applied. A quota id is unique in the service.
    /// Example: CPUS-per-project-region.
    /// </summary>
    [JsonPropertyName("quotaId")]
    public string? QuotaId { get; set; }

    /// <summary>The name of the service to which the quota preference is applied.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuotaPreferenceSpecManagementPoliciesEnum>))]
public enum V1beta1QuotaPreferenceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuotaPreferenceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1QuotaPreferenceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1QuotaPreferenceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1QuotaPreferenceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuotaPreferenceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1QuotaPreferenceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1QuotaPreferenceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuotaPreferenceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1QuotaPreferenceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuotaPreferenceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>QuotaPreferenceSpec defines the desired state of QuotaPreference</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuotaPreferenceSpec
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
    public V1beta1QuotaPreferenceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1QuotaPreferenceSpecForProvider ForProvider { get; set; }

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
    public V1beta1QuotaPreferenceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1QuotaPreferenceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1QuotaPreferenceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1QuotaPreferenceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// The preferred quota configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuotaPreferenceStatusAtProviderQuotaConfig
{
    /// <summary>
    /// The annotations map for clients to store small amounts of arbitrary data. Do not put PII or other sensitive information here. See https://google.aip.dev/128#annotations.
    /// An object containing a list of &quot;key: value&quot; pairs. Example: { &quot;name&quot;: &quot;wrench&quot;, &quot;mass&quot;: &quot;1.3kg&quot;, &quot;count&quot;: &quot;3&quot; }.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// (Output)
    /// Granted quota value.
    /// </summary>
    [JsonPropertyName("grantedValue")]
    public string? GrantedValue { get; set; }

    /// <summary>The preferred value. Must be greater than or equal to -1. If set to -1, it means the value is &quot;unlimited&quot;.</summary>
    [JsonPropertyName("preferredValue")]
    public string? PreferredValue { get; set; }

    /// <summary>
    /// (Output)
    /// The origin of the quota preference request.
    /// </summary>
    [JsonPropertyName("requestOrigin")]
    public string? RequestOrigin { get; set; }

    /// <summary>
    /// (Output)
    /// Optional details about the state of this quota preference.
    /// </summary>
    [JsonPropertyName("stateDetail")]
    public string? StateDetail { get; set; }

    /// <summary>
    /// (Output)
    /// The trace id that the Google Cloud uses to provision the requested quota. This trace id may be used by the client to contact Cloud support to track the state of a quota preference request. The trace id is only produced for increase requests and is unique for each request. The quota decrease requests do not have a trace id.
    /// </summary>
    [JsonPropertyName("traceId")]
    public string? TraceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuotaPreferenceStatusAtProvider
{
    /// <summary>
    /// An email address that can be used for quota related communication between the Google Cloud and the user in case the Google Cloud needs further information to make a decision on whether the user preferred quota can be granted.
    /// The Google account for the email address must have quota update permission for the project, folder or organization this quota preference is for.
    /// </summary>
    [JsonPropertyName("contactEmail")]
    public string? ContactEmail { get; set; }

    /// <summary>
    /// Create time stamp.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: 2014-10-02T15:01:23Z and 2014-10-02T15:01:23.045123456Z.
    /// </summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// The dimensions that this quota preference applies to. The key of the map entry is the name of a dimension, such as &quot;region&quot;, &quot;zone&quot;, &quot;network_id&quot;, and the value of the map entry is the dimension value. If a dimension is missing from the map of dimensions, the quota preference applies to all the dimension values except for those that have other quota preferences configured for the specific value.
    /// NOTE: QuotaPreferences can only be applied across all values of &quot;user&quot; and &quot;resource&quot; dimension. Do not set values for &quot;user&quot; or &quot;resource&quot; in the dimension map.
    /// Example: {&quot;provider&quot;: &quot;Foo Inc&quot;} where &quot;provider&quot; is a service specific dimension.
    /// </summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>The current etag of the quota preference. If an etag is provided on update and does not match the current server&apos;s etag of the quota preference, the request will be blocked and an ABORTED error will be returned. See https://google.aip.dev/134#etags for more details on etags.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>an identifier for the resource with format {{parent}}/locations/global/quotaPreferences/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The list of quota safety checks to be ignored.
    /// Default value is QUOTA_SAFETY_CHECK_UNSPECIFIED.
    /// Possible values are: QUOTA_SAFETY_CHECK_UNSPECIFIED, QUOTA_DECREASE_BELOW_USAGE, QUOTA_DECREASE_PERCENTAGE_TOO_HIGH.
    /// </summary>
    [JsonPropertyName("ignoreSafetyChecks")]
    public string? IgnoreSafetyChecks { get; set; }

    /// <summary>The reason / justification for this quota preference.</summary>
    [JsonPropertyName("justification")]
    public string? Justification { get; set; }

    /// <summary>The parent of the quota preference. Allowed parents are &quot;projects/[project-id / number]&quot; or &quot;folders/[folder-id / number]&quot; or &quot;organizations/[org-id / number]&quot;.</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// The preferred quota configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("quotaConfig")]
    public V1beta1QuotaPreferenceStatusAtProviderQuotaConfig? QuotaConfig { get; set; }

    /// <summary>
    /// The id of the quota to which the quota preference is applied. A quota id is unique in the service.
    /// Example: CPUS-per-project-region.
    /// </summary>
    [JsonPropertyName("quotaId")]
    public string? QuotaId { get; set; }

    /// <summary>Is the quota preference pending Google Cloud approval and fulfillment.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>The name of the service to which the quota preference is applied.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>
    /// Update time stamp.
    /// A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: 2014-10-02T15:01:23Z and 2014-10-02T15:01:23.045123456Z.
    /// </summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuotaPreferenceStatusConditions
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

/// <summary>QuotaPreferenceStatus defines the observed state of QuotaPreference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QuotaPreferenceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1QuotaPreferenceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1QuotaPreferenceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>QuotaPreference is the Schema for the QuotaPreferences API. QuotaPreference represents the preferred quota configuration specified for a project, folder or organization.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1QuotaPreference : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1QuotaPreferenceSpec>, IStatus<V1beta1QuotaPreferenceStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "QuotaPreference";
    public const string KubeGroup = "cloudquotas.gcp.upbound.io";
    public const string KubePluralName = "quotapreferences";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudquotas.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "QuotaPreference";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>QuotaPreferenceSpec defines the desired state of QuotaPreference</summary>
    [JsonPropertyName("spec")]
    public required V1beta1QuotaPreferenceSpec Spec { get; set; }

    /// <summary>QuotaPreferenceStatus defines the observed state of QuotaPreference.</summary>
    [JsonPropertyName("status")]
    public V1beta1QuotaPreferenceStatus? Status { get; set; }
}
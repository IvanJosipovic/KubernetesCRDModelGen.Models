#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sesv2.aws.upbound.io;
/// <summary>ConfigurationSet is the Schema for the ConfigurationSets API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ConfigurationSetList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ConfigurationSet>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ConfigurationSetList";
    public const string KubeGroup = "sesv2.aws.upbound.io";
    public const string KubePluralName = "configurationsets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sesv2.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ConfigurationSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ConfigurationSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ConfigurationSet> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetSpecDeletionPolicyEnum>))]
public enum V1beta2ConfigurationSetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>An object that defines the dedicated IP pool that is used to send emails that you send using the configuration set. See delivery_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecForProviderDeliveryOptions
{
    /// <summary>The maximum amount of time, in seconds, that Amazon SES API v2 will attempt delivery of email. If specified, the value must greater than or equal to 300 seconds (5 minutes) and less than or equal to 50400 seconds (840 minutes).</summary>
    [JsonPropertyName("maxDeliverySeconds")]
    public double? MaxDeliverySeconds { get; set; }

    /// <summary>The name of the dedicated IP pool to associate with the configuration set.</summary>
    [JsonPropertyName("sendingPoolName")]
    public string? SendingPoolName { get; set; }

    /// <summary>Specifies whether messages that use the configuration set are required to use Transport Layer Security (TLS). Valid values: REQUIRE, OPTIONAL.</summary>
    [JsonPropertyName("tlsPolicy")]
    public string? TlsPolicy { get; set; }
}

/// <summary>An object that defines whether or not Amazon SES collects reputation metrics for the emails that you send that use the configuration set. See reputation_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecForProviderReputationOptions
{
    /// <summary>If true, tracking of reputation metrics is enabled for the configuration set. If false, tracking of reputation metrics is disabled for the configuration set.</summary>
    [JsonPropertyName("reputationMetricsEnabled")]
    public bool? ReputationMetricsEnabled { get; set; }
}

/// <summary>An object that defines whether or not Amazon SES can send email that you send using the configuration set. See sending_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecForProviderSendingOptions
{
    /// <summary>If true, email sending is enabled for the configuration set. If false, email sending is disabled for the configuration set.</summary>
    [JsonPropertyName("sendingEnabled")]
    public bool? SendingEnabled { get; set; }
}

/// <summary>An object that contains information about the suppression list preferences for your account. See suppression_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecForProviderSuppressionOptions
{
    /// <summary>A list that contains the reasons that email addresses are automatically added to the suppression list for your account. Valid values: BOUNCE, COMPLAINT.</summary>
    [JsonPropertyName("suppressedReasons")]
    public IList<string>? SuppressedReasons { get; set; }
}

/// <summary>An object that defines the open and click tracking options for emails that you send using the configuration set. See tracking_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecForProviderTrackingOptions
{
    /// <summary>The domain to use for tracking open and click events.</summary>
    [JsonPropertyName("customRedirectDomain")]
    public string? CustomRedirectDomain { get; set; }

    /// <summary>: The https policy to use for tracking open and click events. Valid values are REQUIRE, REQUIRE_OPEN_ONLY or OPTIONAL.</summary>
    [JsonPropertyName("httpsPolicy")]
    public string? HttpsPolicy { get; set; }
}

/// <summary>Specifies additional settings for your VDM configuration as applicable to the Dashboard. See dashboard_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecForProviderVdmOptionsDashboardOptions
{
    /// <summary>Specifies the status of your VDM engagement metrics collection. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("engagementMetrics")]
    public string? EngagementMetrics { get; set; }
}

/// <summary>Specifies additional settings for your VDM configuration as applicable to the Guardian. See guardian_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecForProviderVdmOptionsGuardianOptions
{
    /// <summary>Specifies the status of your VDM optimized shared delivery. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("optimizedSharedDelivery")]
    public string? OptimizedSharedDelivery { get; set; }
}

/// <summary>An object that defines the VDM settings that apply to emails that you send using the configuration set. See vdm_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecForProviderVdmOptions
{
    /// <summary>Specifies additional settings for your VDM configuration as applicable to the Dashboard. See dashboard_options Block for details.</summary>
    [JsonPropertyName("dashboardOptions")]
    public V1beta2ConfigurationSetSpecForProviderVdmOptionsDashboardOptions? DashboardOptions { get; set; }

    /// <summary>Specifies additional settings for your VDM configuration as applicable to the Guardian. See guardian_options Block for details.</summary>
    [JsonPropertyName("guardianOptions")]
    public V1beta2ConfigurationSetSpecForProviderVdmOptionsGuardianOptions? GuardianOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecForProvider
{
    /// <summary>An object that defines the dedicated IP pool that is used to send emails that you send using the configuration set. See delivery_options Block for details.</summary>
    [JsonPropertyName("deliveryOptions")]
    public V1beta2ConfigurationSetSpecForProviderDeliveryOptions? DeliveryOptions { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>An object that defines whether or not Amazon SES collects reputation metrics for the emails that you send that use the configuration set. See reputation_options Block for details.</summary>
    [JsonPropertyName("reputationOptions")]
    public V1beta2ConfigurationSetSpecForProviderReputationOptions? ReputationOptions { get; set; }

    /// <summary>An object that defines whether or not Amazon SES can send email that you send using the configuration set. See sending_options Block for details.</summary>
    [JsonPropertyName("sendingOptions")]
    public V1beta2ConfigurationSetSpecForProviderSendingOptions? SendingOptions { get; set; }

    /// <summary>An object that contains information about the suppression list preferences for your account. See suppression_options Block for details.</summary>
    [JsonPropertyName("suppressionOptions")]
    public V1beta2ConfigurationSetSpecForProviderSuppressionOptions? SuppressionOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>An object that defines the open and click tracking options for emails that you send using the configuration set. See tracking_options Block for details.</summary>
    [JsonPropertyName("trackingOptions")]
    public V1beta2ConfigurationSetSpecForProviderTrackingOptions? TrackingOptions { get; set; }

    /// <summary>An object that defines the VDM settings that apply to emails that you send using the configuration set. See vdm_options Block for details.</summary>
    [JsonPropertyName("vdmOptions")]
    public V1beta2ConfigurationSetSpecForProviderVdmOptions? VdmOptions { get; set; }
}

/// <summary>An object that defines the dedicated IP pool that is used to send emails that you send using the configuration set. See delivery_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecInitProviderDeliveryOptions
{
    /// <summary>The maximum amount of time, in seconds, that Amazon SES API v2 will attempt delivery of email. If specified, the value must greater than or equal to 300 seconds (5 minutes) and less than or equal to 50400 seconds (840 minutes).</summary>
    [JsonPropertyName("maxDeliverySeconds")]
    public double? MaxDeliverySeconds { get; set; }

    /// <summary>The name of the dedicated IP pool to associate with the configuration set.</summary>
    [JsonPropertyName("sendingPoolName")]
    public string? SendingPoolName { get; set; }

    /// <summary>Specifies whether messages that use the configuration set are required to use Transport Layer Security (TLS). Valid values: REQUIRE, OPTIONAL.</summary>
    [JsonPropertyName("tlsPolicy")]
    public string? TlsPolicy { get; set; }
}

/// <summary>An object that defines whether or not Amazon SES collects reputation metrics for the emails that you send that use the configuration set. See reputation_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecInitProviderReputationOptions
{
    /// <summary>If true, tracking of reputation metrics is enabled for the configuration set. If false, tracking of reputation metrics is disabled for the configuration set.</summary>
    [JsonPropertyName("reputationMetricsEnabled")]
    public bool? ReputationMetricsEnabled { get; set; }
}

/// <summary>An object that defines whether or not Amazon SES can send email that you send using the configuration set. See sending_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecInitProviderSendingOptions
{
    /// <summary>If true, email sending is enabled for the configuration set. If false, email sending is disabled for the configuration set.</summary>
    [JsonPropertyName("sendingEnabled")]
    public bool? SendingEnabled { get; set; }
}

/// <summary>An object that contains information about the suppression list preferences for your account. See suppression_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecInitProviderSuppressionOptions
{
    /// <summary>A list that contains the reasons that email addresses are automatically added to the suppression list for your account. Valid values: BOUNCE, COMPLAINT.</summary>
    [JsonPropertyName("suppressedReasons")]
    public IList<string>? SuppressedReasons { get; set; }
}

/// <summary>An object that defines the open and click tracking options for emails that you send using the configuration set. See tracking_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecInitProviderTrackingOptions
{
    /// <summary>The domain to use for tracking open and click events.</summary>
    [JsonPropertyName("customRedirectDomain")]
    public string? CustomRedirectDomain { get; set; }

    /// <summary>: The https policy to use for tracking open and click events. Valid values are REQUIRE, REQUIRE_OPEN_ONLY or OPTIONAL.</summary>
    [JsonPropertyName("httpsPolicy")]
    public string? HttpsPolicy { get; set; }
}

/// <summary>Specifies additional settings for your VDM configuration as applicable to the Dashboard. See dashboard_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecInitProviderVdmOptionsDashboardOptions
{
    /// <summary>Specifies the status of your VDM engagement metrics collection. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("engagementMetrics")]
    public string? EngagementMetrics { get; set; }
}

/// <summary>Specifies additional settings for your VDM configuration as applicable to the Guardian. See guardian_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecInitProviderVdmOptionsGuardianOptions
{
    /// <summary>Specifies the status of your VDM optimized shared delivery. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("optimizedSharedDelivery")]
    public string? OptimizedSharedDelivery { get; set; }
}

/// <summary>An object that defines the VDM settings that apply to emails that you send using the configuration set. See vdm_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecInitProviderVdmOptions
{
    /// <summary>Specifies additional settings for your VDM configuration as applicable to the Dashboard. See dashboard_options Block for details.</summary>
    [JsonPropertyName("dashboardOptions")]
    public V1beta2ConfigurationSetSpecInitProviderVdmOptionsDashboardOptions? DashboardOptions { get; set; }

    /// <summary>Specifies additional settings for your VDM configuration as applicable to the Guardian. See guardian_options Block for details.</summary>
    [JsonPropertyName("guardianOptions")]
    public V1beta2ConfigurationSetSpecInitProviderVdmOptionsGuardianOptions? GuardianOptions { get; set; }
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
public partial class V1beta2ConfigurationSetSpecInitProvider
{
    /// <summary>An object that defines the dedicated IP pool that is used to send emails that you send using the configuration set. See delivery_options Block for details.</summary>
    [JsonPropertyName("deliveryOptions")]
    public V1beta2ConfigurationSetSpecInitProviderDeliveryOptions? DeliveryOptions { get; set; }

    /// <summary>An object that defines whether or not Amazon SES collects reputation metrics for the emails that you send that use the configuration set. See reputation_options Block for details.</summary>
    [JsonPropertyName("reputationOptions")]
    public V1beta2ConfigurationSetSpecInitProviderReputationOptions? ReputationOptions { get; set; }

    /// <summary>An object that defines whether or not Amazon SES can send email that you send using the configuration set. See sending_options Block for details.</summary>
    [JsonPropertyName("sendingOptions")]
    public V1beta2ConfigurationSetSpecInitProviderSendingOptions? SendingOptions { get; set; }

    /// <summary>An object that contains information about the suppression list preferences for your account. See suppression_options Block for details.</summary>
    [JsonPropertyName("suppressionOptions")]
    public V1beta2ConfigurationSetSpecInitProviderSuppressionOptions? SuppressionOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>An object that defines the open and click tracking options for emails that you send using the configuration set. See tracking_options Block for details.</summary>
    [JsonPropertyName("trackingOptions")]
    public V1beta2ConfigurationSetSpecInitProviderTrackingOptions? TrackingOptions { get; set; }

    /// <summary>An object that defines the VDM settings that apply to emails that you send using the configuration set. See vdm_options Block for details.</summary>
    [JsonPropertyName("vdmOptions")]
    public V1beta2ConfigurationSetSpecInitProviderVdmOptions? VdmOptions { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetSpecManagementPoliciesEnum>))]
public enum V1beta2ConfigurationSetSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConfigurationSetSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ConfigurationSetSpec defines the desired state of ConfigurationSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetSpec
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
    public V1beta2ConfigurationSetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ConfigurationSetSpecForProvider ForProvider { get; set; }

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
    public V1beta2ConfigurationSetSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ConfigurationSetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ConfigurationSetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ConfigurationSetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An object that defines the dedicated IP pool that is used to send emails that you send using the configuration set. See delivery_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetStatusAtProviderDeliveryOptions
{
    /// <summary>The maximum amount of time, in seconds, that Amazon SES API v2 will attempt delivery of email. If specified, the value must greater than or equal to 300 seconds (5 minutes) and less than or equal to 50400 seconds (840 minutes).</summary>
    [JsonPropertyName("maxDeliverySeconds")]
    public double? MaxDeliverySeconds { get; set; }

    /// <summary>The name of the dedicated IP pool to associate with the configuration set.</summary>
    [JsonPropertyName("sendingPoolName")]
    public string? SendingPoolName { get; set; }

    /// <summary>Specifies whether messages that use the configuration set are required to use Transport Layer Security (TLS). Valid values: REQUIRE, OPTIONAL.</summary>
    [JsonPropertyName("tlsPolicy")]
    public string? TlsPolicy { get; set; }
}

/// <summary>An object that defines whether or not Amazon SES collects reputation metrics for the emails that you send that use the configuration set. See reputation_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetStatusAtProviderReputationOptions
{
    /// <summary>The date and time (in Unix time) when the reputation metrics were last given a fresh start. When your account is given a fresh start, your reputation metrics are calculated starting from the date of the fresh start.</summary>
    [JsonPropertyName("lastFreshStart")]
    public string? LastFreshStart { get; set; }

    /// <summary>If true, tracking of reputation metrics is enabled for the configuration set. If false, tracking of reputation metrics is disabled for the configuration set.</summary>
    [JsonPropertyName("reputationMetricsEnabled")]
    public bool? ReputationMetricsEnabled { get; set; }
}

/// <summary>An object that defines whether or not Amazon SES can send email that you send using the configuration set. See sending_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetStatusAtProviderSendingOptions
{
    /// <summary>If true, email sending is enabled for the configuration set. If false, email sending is disabled for the configuration set.</summary>
    [JsonPropertyName("sendingEnabled")]
    public bool? SendingEnabled { get; set; }
}

/// <summary>An object that contains information about the suppression list preferences for your account. See suppression_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetStatusAtProviderSuppressionOptions
{
    /// <summary>A list that contains the reasons that email addresses are automatically added to the suppression list for your account. Valid values: BOUNCE, COMPLAINT.</summary>
    [JsonPropertyName("suppressedReasons")]
    public IList<string>? SuppressedReasons { get; set; }
}

/// <summary>An object that defines the open and click tracking options for emails that you send using the configuration set. See tracking_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetStatusAtProviderTrackingOptions
{
    /// <summary>The domain to use for tracking open and click events.</summary>
    [JsonPropertyName("customRedirectDomain")]
    public string? CustomRedirectDomain { get; set; }

    /// <summary>: The https policy to use for tracking open and click events. Valid values are REQUIRE, REQUIRE_OPEN_ONLY or OPTIONAL.</summary>
    [JsonPropertyName("httpsPolicy")]
    public string? HttpsPolicy { get; set; }
}

/// <summary>Specifies additional settings for your VDM configuration as applicable to the Dashboard. See dashboard_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetStatusAtProviderVdmOptionsDashboardOptions
{
    /// <summary>Specifies the status of your VDM engagement metrics collection. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("engagementMetrics")]
    public string? EngagementMetrics { get; set; }
}

/// <summary>Specifies additional settings for your VDM configuration as applicable to the Guardian. See guardian_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetStatusAtProviderVdmOptionsGuardianOptions
{
    /// <summary>Specifies the status of your VDM optimized shared delivery. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("optimizedSharedDelivery")]
    public string? OptimizedSharedDelivery { get; set; }
}

/// <summary>An object that defines the VDM settings that apply to emails that you send using the configuration set. See vdm_options Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetStatusAtProviderVdmOptions
{
    /// <summary>Specifies additional settings for your VDM configuration as applicable to the Dashboard. See dashboard_options Block for details.</summary>
    [JsonPropertyName("dashboardOptions")]
    public V1beta2ConfigurationSetStatusAtProviderVdmOptionsDashboardOptions? DashboardOptions { get; set; }

    /// <summary>Specifies additional settings for your VDM configuration as applicable to the Guardian. See guardian_options Block for details.</summary>
    [JsonPropertyName("guardianOptions")]
    public V1beta2ConfigurationSetStatusAtProviderVdmOptionsGuardianOptions? GuardianOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetStatusAtProvider
{
    /// <summary>ARN of the Configuration Set.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>An object that defines the dedicated IP pool that is used to send emails that you send using the configuration set. See delivery_options Block for details.</summary>
    [JsonPropertyName("deliveryOptions")]
    public V1beta2ConfigurationSetStatusAtProviderDeliveryOptions? DeliveryOptions { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>An object that defines whether or not Amazon SES collects reputation metrics for the emails that you send that use the configuration set. See reputation_options Block for details.</summary>
    [JsonPropertyName("reputationOptions")]
    public V1beta2ConfigurationSetStatusAtProviderReputationOptions? ReputationOptions { get; set; }

    /// <summary>An object that defines whether or not Amazon SES can send email that you send using the configuration set. See sending_options Block for details.</summary>
    [JsonPropertyName("sendingOptions")]
    public V1beta2ConfigurationSetStatusAtProviderSendingOptions? SendingOptions { get; set; }

    /// <summary>An object that contains information about the suppression list preferences for your account. See suppression_options Block for details.</summary>
    [JsonPropertyName("suppressionOptions")]
    public V1beta2ConfigurationSetStatusAtProviderSuppressionOptions? SuppressionOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>An object that defines the open and click tracking options for emails that you send using the configuration set. See tracking_options Block for details.</summary>
    [JsonPropertyName("trackingOptions")]
    public V1beta2ConfigurationSetStatusAtProviderTrackingOptions? TrackingOptions { get; set; }

    /// <summary>An object that defines the VDM settings that apply to emails that you send using the configuration set. See vdm_options Block for details.</summary>
    [JsonPropertyName("vdmOptions")]
    public V1beta2ConfigurationSetStatusAtProviderVdmOptions? VdmOptions { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetStatusConditions
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

/// <summary>ConfigurationSetStatus defines the observed state of ConfigurationSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ConfigurationSetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ConfigurationSetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ConfigurationSet is the Schema for the ConfigurationSets API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ConfigurationSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ConfigurationSetSpec>, IStatus<V1beta2ConfigurationSetStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ConfigurationSet";
    public const string KubeGroup = "sesv2.aws.upbound.io";
    public const string KubePluralName = "configurationsets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sesv2.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ConfigurationSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConfigurationSetSpec defines the desired state of ConfigurationSet</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ConfigurationSetSpec Spec { get; set; }

    /// <summary>ConfigurationSetStatus defines the observed state of ConfigurationSet.</summary>
    [JsonPropertyName("status")]
    public V1beta2ConfigurationSetStatus? Status { get; set; }
}
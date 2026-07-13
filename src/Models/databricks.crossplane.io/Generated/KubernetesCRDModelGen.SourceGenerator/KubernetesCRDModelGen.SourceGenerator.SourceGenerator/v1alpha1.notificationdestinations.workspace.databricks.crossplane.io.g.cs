#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.workspace.databricks.crossplane.io;
/// <summary>
/// NotificationDestination is the Schema for the NotificationDestinations API.
/// Deprecated: This API version (v1alpha1) has been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NotificationDestinationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NotificationDestination>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NotificationDestinationList";
    public const string KubeGroup = "workspace.databricks.crossplane.io";
    public const string KubePluralName = "notificationdestinations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "workspace.databricks.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NotificationDestinationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1NotificationDestination objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1NotificationDestination> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1NotificationDestinationSpecDeletionPolicyEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1NotificationDestinationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigEmail
{
    /// <summary>The list of email addresses to send notifications to.</summary>
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }
}

/// <summary>The password for basic authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigGenericWebhookPasswordSecretRef
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

/// <summary>The Slack webhook URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigGenericWebhookUrlSecretRef
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

/// <summary>The username for basic authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigGenericWebhookUsernameSecretRef
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigGenericWebhook
{
    /// <summary>The password for basic authentication.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1NotificationDestinationSpecForProviderConfigGenericWebhookPasswordSecretRef? PasswordSecretRef { get; set; }

    [JsonPropertyName("passwordSet")]
    public bool? PasswordSet { get; set; }

    /// <summary>The Slack webhook URL.</summary>
    [JsonPropertyName("urlSecretRef")]
    public V1alpha1NotificationDestinationSpecForProviderConfigGenericWebhookUrlSecretRef? UrlSecretRef { get; set; }

    [JsonPropertyName("urlSet")]
    public bool? UrlSet { get; set; }

    /// <summary>The username for basic authentication.</summary>
    [JsonPropertyName("usernameSecretRef")]
    public V1alpha1NotificationDestinationSpecForProviderConfigGenericWebhookUsernameSecretRef? UsernameSecretRef { get; set; }

    [JsonPropertyName("usernameSet")]
    public bool? UsernameSet { get; set; }
}

/// <summary>App ID for Microsoft Teams App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigMicrosoftTeamsAppIdSecretRef
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

/// <summary>Secret for Microsoft Teams App authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigMicrosoftTeamsAuthSecretSecretRef
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

/// <summary>Channel URL for Microsoft Teams App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigMicrosoftTeamsChannelUrlSecretRef
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

/// <summary>Tenant ID for Microsoft Teams App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigMicrosoftTeamsTenantIdSecretRef
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

/// <summary>The Slack webhook URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigMicrosoftTeamsUrlSecretRef
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigMicrosoftTeams
{
    /// <summary>App ID for Microsoft Teams App.</summary>
    [JsonPropertyName("appIdSecretRef")]
    public V1alpha1NotificationDestinationSpecForProviderConfigMicrosoftTeamsAppIdSecretRef? AppIdSecretRef { get; set; }

    [JsonPropertyName("appIdSet")]
    public bool? AppIdSet { get; set; }

    /// <summary>Secret for Microsoft Teams App authentication.</summary>
    [JsonPropertyName("authSecretSecretRef")]
    public V1alpha1NotificationDestinationSpecForProviderConfigMicrosoftTeamsAuthSecretSecretRef? AuthSecretSecretRef { get; set; }

    [JsonPropertyName("authSecretSet")]
    public bool? AuthSecretSet { get; set; }

    /// <summary>Channel URL for Microsoft Teams App.</summary>
    [JsonPropertyName("channelUrlSecretRef")]
    public V1alpha1NotificationDestinationSpecForProviderConfigMicrosoftTeamsChannelUrlSecretRef? ChannelUrlSecretRef { get; set; }

    [JsonPropertyName("channelUrlSet")]
    public bool? ChannelUrlSet { get; set; }

    /// <summary>Tenant ID for Microsoft Teams App.</summary>
    [JsonPropertyName("tenantIdSecretRef")]
    public V1alpha1NotificationDestinationSpecForProviderConfigMicrosoftTeamsTenantIdSecretRef? TenantIdSecretRef { get; set; }

    [JsonPropertyName("tenantIdSet")]
    public bool? TenantIdSet { get; set; }

    /// <summary>The Slack webhook URL.</summary>
    [JsonPropertyName("urlSecretRef")]
    public V1alpha1NotificationDestinationSpecForProviderConfigMicrosoftTeamsUrlSecretRef? UrlSecretRef { get; set; }

    [JsonPropertyName("urlSet")]
    public bool? UrlSet { get; set; }
}

/// <summary>The PagerDuty integration key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigPagerdutyIntegrationKeySecretRef
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigPagerduty
{
    /// <summary>The PagerDuty integration key.</summary>
    [JsonPropertyName("integrationKeySecretRef")]
    public V1alpha1NotificationDestinationSpecForProviderConfigPagerdutyIntegrationKeySecretRef? IntegrationKeySecretRef { get; set; }

    [JsonPropertyName("integrationKeySet")]
    public bool? IntegrationKeySet { get; set; }
}

/// <summary>Slack channel ID for notifications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigSlackChannelIdSecretRef
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

/// <summary>OAuth token for Slack authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigSlackOauthTokenSecretRef
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

/// <summary>The Slack webhook URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigSlackUrlSecretRef
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderConfigSlack
{
    /// <summary>Slack channel ID for notifications.</summary>
    [JsonPropertyName("channelIdSecretRef")]
    public V1alpha1NotificationDestinationSpecForProviderConfigSlackChannelIdSecretRef? ChannelIdSecretRef { get; set; }

    [JsonPropertyName("channelIdSet")]
    public bool? ChannelIdSet { get; set; }

    /// <summary>OAuth token for Slack authentication.</summary>
    [JsonPropertyName("oauthTokenSecretRef")]
    public V1alpha1NotificationDestinationSpecForProviderConfigSlackOauthTokenSecretRef? OauthTokenSecretRef { get; set; }

    [JsonPropertyName("oauthTokenSet")]
    public bool? OauthTokenSet { get; set; }

    /// <summary>The Slack webhook URL.</summary>
    [JsonPropertyName("urlSecretRef")]
    public V1alpha1NotificationDestinationSpecForProviderConfigSlackUrlSecretRef? UrlSecretRef { get; set; }

    [JsonPropertyName("urlSet")]
    public bool? UrlSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderConfig
{
    /// <summary>The email configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("email")]
    public IList<V1alpha1NotificationDestinationSpecForProviderConfigEmail>? Email { get; set; }

    /// <summary>The Generic Webhook configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("genericWebhook")]
    public IList<V1alpha1NotificationDestinationSpecForProviderConfigGenericWebhook>? GenericWebhook { get; set; }

    /// <summary>The Microsoft Teams configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("microsoftTeams")]
    public IList<V1alpha1NotificationDestinationSpecForProviderConfigMicrosoftTeams>? MicrosoftTeams { get; set; }

    /// <summary>The PagerDuty configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("pagerduty")]
    public IList<V1alpha1NotificationDestinationSpecForProviderConfigPagerduty>? Pagerduty { get; set; }

    /// <summary>The Slack configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("slack")]
    public IList<V1alpha1NotificationDestinationSpecForProviderConfigSlack>? Slack { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecForProvider
{
    /// <summary>The configuration of the Notification Destination. It must contain exactly one of the following blocks:</summary>
    [JsonPropertyName("config")]
    public IList<V1alpha1NotificationDestinationSpecForProviderConfig>? Config { get; set; }

    /// <summary>the type of Notification Destination.</summary>
    [JsonPropertyName("destinationType")]
    public string? DestinationType { get; set; }

    /// <summary>The display name of the Notification Destination.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public IList<V1alpha1NotificationDestinationSpecForProviderProviderConfig>? ProviderConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigEmail
{
    /// <summary>The list of email addresses to send notifications to.</summary>
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }
}

/// <summary>The password for basic authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigGenericWebhookPasswordSecretRef
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

/// <summary>The Slack webhook URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigGenericWebhookUrlSecretRef
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

/// <summary>The username for basic authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigGenericWebhookUsernameSecretRef
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigGenericWebhook
{
    /// <summary>The password for basic authentication.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1NotificationDestinationSpecInitProviderConfigGenericWebhookPasswordSecretRef? PasswordSecretRef { get; set; }

    [JsonPropertyName("passwordSet")]
    public bool? PasswordSet { get; set; }

    /// <summary>The Slack webhook URL.</summary>
    [JsonPropertyName("urlSecretRef")]
    public V1alpha1NotificationDestinationSpecInitProviderConfigGenericWebhookUrlSecretRef? UrlSecretRef { get; set; }

    [JsonPropertyName("urlSet")]
    public bool? UrlSet { get; set; }

    /// <summary>The username for basic authentication.</summary>
    [JsonPropertyName("usernameSecretRef")]
    public V1alpha1NotificationDestinationSpecInitProviderConfigGenericWebhookUsernameSecretRef? UsernameSecretRef { get; set; }

    [JsonPropertyName("usernameSet")]
    public bool? UsernameSet { get; set; }
}

/// <summary>App ID for Microsoft Teams App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigMicrosoftTeamsAppIdSecretRef
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

/// <summary>Secret for Microsoft Teams App authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigMicrosoftTeamsAuthSecretSecretRef
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

/// <summary>Channel URL for Microsoft Teams App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigMicrosoftTeamsChannelUrlSecretRef
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

/// <summary>Tenant ID for Microsoft Teams App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigMicrosoftTeamsTenantIdSecretRef
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

/// <summary>The Slack webhook URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigMicrosoftTeamsUrlSecretRef
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigMicrosoftTeams
{
    /// <summary>App ID for Microsoft Teams App.</summary>
    [JsonPropertyName("appIdSecretRef")]
    public V1alpha1NotificationDestinationSpecInitProviderConfigMicrosoftTeamsAppIdSecretRef? AppIdSecretRef { get; set; }

    [JsonPropertyName("appIdSet")]
    public bool? AppIdSet { get; set; }

    /// <summary>Secret for Microsoft Teams App authentication.</summary>
    [JsonPropertyName("authSecretSecretRef")]
    public V1alpha1NotificationDestinationSpecInitProviderConfigMicrosoftTeamsAuthSecretSecretRef? AuthSecretSecretRef { get; set; }

    [JsonPropertyName("authSecretSet")]
    public bool? AuthSecretSet { get; set; }

    /// <summary>Channel URL for Microsoft Teams App.</summary>
    [JsonPropertyName("channelUrlSecretRef")]
    public V1alpha1NotificationDestinationSpecInitProviderConfigMicrosoftTeamsChannelUrlSecretRef? ChannelUrlSecretRef { get; set; }

    [JsonPropertyName("channelUrlSet")]
    public bool? ChannelUrlSet { get; set; }

    /// <summary>Tenant ID for Microsoft Teams App.</summary>
    [JsonPropertyName("tenantIdSecretRef")]
    public V1alpha1NotificationDestinationSpecInitProviderConfigMicrosoftTeamsTenantIdSecretRef? TenantIdSecretRef { get; set; }

    [JsonPropertyName("tenantIdSet")]
    public bool? TenantIdSet { get; set; }

    /// <summary>The Slack webhook URL.</summary>
    [JsonPropertyName("urlSecretRef")]
    public V1alpha1NotificationDestinationSpecInitProviderConfigMicrosoftTeamsUrlSecretRef? UrlSecretRef { get; set; }

    [JsonPropertyName("urlSet")]
    public bool? UrlSet { get; set; }
}

/// <summary>The PagerDuty integration key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigPagerdutyIntegrationKeySecretRef
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigPagerduty
{
    /// <summary>The PagerDuty integration key.</summary>
    [JsonPropertyName("integrationKeySecretRef")]
    public V1alpha1NotificationDestinationSpecInitProviderConfigPagerdutyIntegrationKeySecretRef? IntegrationKeySecretRef { get; set; }

    [JsonPropertyName("integrationKeySet")]
    public bool? IntegrationKeySet { get; set; }
}

/// <summary>Slack channel ID for notifications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigSlackChannelIdSecretRef
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

/// <summary>OAuth token for Slack authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigSlackOauthTokenSecretRef
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

/// <summary>The Slack webhook URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigSlackUrlSecretRef
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfigSlack
{
    /// <summary>Slack channel ID for notifications.</summary>
    [JsonPropertyName("channelIdSecretRef")]
    public V1alpha1NotificationDestinationSpecInitProviderConfigSlackChannelIdSecretRef? ChannelIdSecretRef { get; set; }

    [JsonPropertyName("channelIdSet")]
    public bool? ChannelIdSet { get; set; }

    /// <summary>OAuth token for Slack authentication.</summary>
    [JsonPropertyName("oauthTokenSecretRef")]
    public V1alpha1NotificationDestinationSpecInitProviderConfigSlackOauthTokenSecretRef? OauthTokenSecretRef { get; set; }

    [JsonPropertyName("oauthTokenSet")]
    public bool? OauthTokenSet { get; set; }

    /// <summary>The Slack webhook URL.</summary>
    [JsonPropertyName("urlSecretRef")]
    public V1alpha1NotificationDestinationSpecInitProviderConfigSlackUrlSecretRef? UrlSecretRef { get; set; }

    [JsonPropertyName("urlSet")]
    public bool? UrlSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderConfig
{
    /// <summary>The email configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("email")]
    public IList<V1alpha1NotificationDestinationSpecInitProviderConfigEmail>? Email { get; set; }

    /// <summary>The Generic Webhook configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("genericWebhook")]
    public IList<V1alpha1NotificationDestinationSpecInitProviderConfigGenericWebhook>? GenericWebhook { get; set; }

    /// <summary>The Microsoft Teams configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("microsoftTeams")]
    public IList<V1alpha1NotificationDestinationSpecInitProviderConfigMicrosoftTeams>? MicrosoftTeams { get; set; }

    /// <summary>The PagerDuty configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("pagerduty")]
    public IList<V1alpha1NotificationDestinationSpecInitProviderConfigPagerduty>? Pagerduty { get; set; }

    /// <summary>The Slack configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("slack")]
    public IList<V1alpha1NotificationDestinationSpecInitProviderConfigSlack>? Slack { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProviderProviderConfig
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecInitProvider
{
    /// <summary>The configuration of the Notification Destination. It must contain exactly one of the following blocks:</summary>
    [JsonPropertyName("config")]
    public IList<V1alpha1NotificationDestinationSpecInitProviderConfig>? Config { get; set; }

    /// <summary>the type of Notification Destination.</summary>
    [JsonPropertyName("destinationType")]
    public string? DestinationType { get; set; }

    /// <summary>The display name of the Notification Destination.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public IList<V1alpha1NotificationDestinationSpecInitProviderProviderConfig>? ProviderConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1NotificationDestinationSpecManagementPoliciesEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1NotificationDestinationSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1NotificationDestinationSpecProviderConfigRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1NotificationDestinationSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1NotificationDestinationSpecProviderConfigRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1NotificationDestinationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1NotificationDestinationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1NotificationDestinationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1NotificationDestinationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>NotificationDestinationSpec defines the desired state of NotificationDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationSpec
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
    public V1alpha1NotificationDestinationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1NotificationDestinationSpecForProvider ForProvider { get; set; }

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
    public V1alpha1NotificationDestinationSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1NotificationDestinationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1NotificationDestinationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1NotificationDestinationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationStatusAtProviderConfigEmail
{
    /// <summary>The list of email addresses to send notifications to.</summary>
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationStatusAtProviderConfigGenericWebhook
{
    [JsonPropertyName("passwordSet")]
    public bool? PasswordSet { get; set; }

    [JsonPropertyName("urlSet")]
    public bool? UrlSet { get; set; }

    [JsonPropertyName("usernameSet")]
    public bool? UsernameSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationStatusAtProviderConfigMicrosoftTeams
{
    [JsonPropertyName("appIdSet")]
    public bool? AppIdSet { get; set; }

    [JsonPropertyName("authSecretSet")]
    public bool? AuthSecretSet { get; set; }

    [JsonPropertyName("channelUrlSet")]
    public bool? ChannelUrlSet { get; set; }

    [JsonPropertyName("tenantIdSet")]
    public bool? TenantIdSet { get; set; }

    [JsonPropertyName("urlSet")]
    public bool? UrlSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationStatusAtProviderConfigPagerduty
{
    [JsonPropertyName("integrationKeySet")]
    public bool? IntegrationKeySet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationStatusAtProviderConfigSlack
{
    [JsonPropertyName("channelIdSet")]
    public bool? ChannelIdSet { get; set; }

    [JsonPropertyName("oauthTokenSet")]
    public bool? OauthTokenSet { get; set; }

    [JsonPropertyName("urlSet")]
    public bool? UrlSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationStatusAtProviderConfig
{
    /// <summary>The email configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("email")]
    public IList<V1alpha1NotificationDestinationStatusAtProviderConfigEmail>? Email { get; set; }

    /// <summary>The Generic Webhook configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("genericWebhook")]
    public IList<V1alpha1NotificationDestinationStatusAtProviderConfigGenericWebhook>? GenericWebhook { get; set; }

    /// <summary>The Microsoft Teams configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("microsoftTeams")]
    public IList<V1alpha1NotificationDestinationStatusAtProviderConfigMicrosoftTeams>? MicrosoftTeams { get; set; }

    /// <summary>The PagerDuty configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("pagerduty")]
    public IList<V1alpha1NotificationDestinationStatusAtProviderConfigPagerduty>? Pagerduty { get; set; }

    /// <summary>The Slack configuration of the Notification Destination. It must contain the following:</summary>
    [JsonPropertyName("slack")]
    public IList<V1alpha1NotificationDestinationStatusAtProviderConfigSlack>? Slack { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationStatusAtProvider
{
    /// <summary>The configuration of the Notification Destination. It must contain exactly one of the following blocks:</summary>
    [JsonPropertyName("config")]
    public IList<V1alpha1NotificationDestinationStatusAtProviderConfig>? Config { get; set; }

    /// <summary>the type of Notification Destination.</summary>
    [JsonPropertyName("destinationType")]
    public string? DestinationType { get; set; }

    /// <summary>The display name of the Notification Destination.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The unique ID of the Notification Destination.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public IList<V1alpha1NotificationDestinationStatusAtProviderProviderConfig>? ProviderConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationStatusConditions
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

/// <summary>NotificationDestinationStatus defines the observed state of NotificationDestination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1NotificationDestinationStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1NotificationDestinationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NotificationDestinationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// NotificationDestination is the Schema for the NotificationDestinations API.
/// Deprecated: This API version (v1alpha1) has been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NotificationDestination : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NotificationDestinationSpec>, IStatus<V1alpha1NotificationDestinationStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NotificationDestination";
    public const string KubeGroup = "workspace.databricks.crossplane.io";
    public const string KubePluralName = "notificationdestinations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "workspace.databricks.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NotificationDestination";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NotificationDestinationSpec defines the desired state of NotificationDestination</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1NotificationDestinationSpec Spec { get; set; }

    /// <summary>NotificationDestinationStatus defines the observed state of NotificationDestination.</summary>
    [JsonPropertyName("status")]
    public V1alpha1NotificationDestinationStatus? Status { get; set; }
}
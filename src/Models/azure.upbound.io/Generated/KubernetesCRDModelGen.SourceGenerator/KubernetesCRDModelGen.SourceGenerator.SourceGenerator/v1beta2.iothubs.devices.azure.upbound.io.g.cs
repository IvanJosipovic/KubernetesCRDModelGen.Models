#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.devices.azure.upbound.io;
/// <summary>IOTHub is the Schema for the IOTHubs API. Manages an IotHub</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2IOTHubList : IKubernetesObject<V1ListMeta>, IItems<V1beta2IOTHub>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "IOTHubList";
    public const string KubeGroup = "devices.azure.upbound.io";
    public const string KubePluralName = "iothubs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "devices.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IOTHubList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2IOTHub objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2IOTHub> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IOTHubSpecDeletionPolicyEnum>))]
public enum V1beta2IOTHubSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecForProviderCloudToDeviceFeedback
{
    /// <summary>The lock duration for the file upload notifications queue, specified as an ISO 8601 timespan duration. This value must be between 5 and 300 seconds. Defaults to PT1M.</summary>
    [JsonPropertyName("lockDuration")]
    public string? LockDuration { get; set; }

    /// <summary>The number of times the IoT Hub attempts to deliver a file upload notification message. Defaults to 10.</summary>
    [JsonPropertyName("maxDeliveryCount")]
    public double? MaxDeliveryCount { get; set; }

    /// <summary>The retention time for service-bound feedback messages, specified as an ISO 8601 timespan duration. This value must be between 1 minute and 48 hours. Defaults to PT1H.</summary>
    [JsonPropertyName("timeToLive")]
    public string? TimeToLive { get; set; }
}

/// <summary>A cloud_to_device block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecForProviderCloudToDevice
{
    /// <summary>The default time to live for cloud-to-device messages, specified as an ISO 8601 timespan duration. This value must be between 1 minute and 48 hours. Defaults to PT1H.</summary>
    [JsonPropertyName("defaultTtl")]
    public string? DefaultTtl { get; set; }

    /// <summary>A feedback block as defined below.</summary>
    [JsonPropertyName("feedback")]
    public IList<V1beta2IOTHubSpecForProviderCloudToDeviceFeedback>? Feedback { get; set; }

    /// <summary>The maximum delivery count for cloud-to-device per-device queues. This value must be between 1 and 100. Defaults to 10.</summary>
    [JsonPropertyName("maxDeliveryCount")]
    public double? MaxDeliveryCount { get; set; }
}

/// <summary>The connection string for the Azure Storage account to which files are uploaded.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecForProviderFileUploadConnectionStringSecretRef
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

/// <summary>A file_upload block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecForProviderFileUpload
{
    /// <summary>The type used to authenticate against the storage account. Possible values are keyBased and identityBased. Defaults to keyBased.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>The connection string for the Azure Storage account to which files are uploaded.</summary>
    [JsonPropertyName("connectionStringSecretRef")]
    public V1beta2IOTHubSpecForProviderFileUploadConnectionStringSecretRef? ConnectionStringSecretRef { get; set; }

    /// <summary>The name of the root container where the files should be uploaded to. The container need not exist but should be creatable using the connection_string specified.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>The period of time for which a file upload notification message is available to consume before it expires, specified as an ISO 8601 timespan duration. This value must be between 1 minute and 48 hours. Defaults to PT1H.</summary>
    [JsonPropertyName("defaultTtl")]
    public string? DefaultTtl { get; set; }

    /// <summary>The ID of the User Managed Identity used to authenticate against the storage account.</summary>
    [JsonPropertyName("identityId")]
    public string? IdentityId { get; set; }

    /// <summary>The lock duration for the file upload notifications queue, specified as an ISO 8601 timespan duration. This value must be between 5 and 300 seconds. Defaults to PT1M.</summary>
    [JsonPropertyName("lockDuration")]
    public string? LockDuration { get; set; }

    /// <summary>The number of times the IoT Hub attempts to deliver a file upload notification message. Defaults to 10.</summary>
    [JsonPropertyName("maxDeliveryCount")]
    public double? MaxDeliveryCount { get; set; }

    /// <summary>Used to specify whether file notifications are sent to IoT Hub on upload. Defaults to false.</summary>
    [JsonPropertyName("notifications")]
    public bool? Notifications { get; set; }

    /// <summary>The period of time for which the SAS URI generated by IoT Hub for file upload is valid, specified as an ISO 8601 timespan duration. This value must be between 1 minute and 24 hours. Defaults to PT1H.</summary>
    [JsonPropertyName("sasTtl")]
    public string? SasTtl { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this IoT Hub.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this IoT Hub. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecForProviderNetworkRuleSetIpRule
{
    /// <summary>The desired action for requests captured by this rule. Possible values are Allow. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP address range in CIDR notation for the IP rule.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }

    /// <summary>The name of the sku. Possible values are B1, B2, B3, F1, S1, S2, and S3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecForProviderNetworkRuleSet
{
    /// <summary>Determines if Network Rule Set is also applied to the BuiltIn EventHub EndPoint of the IotHub. Defaults to false.</summary>
    [JsonPropertyName("applyToBuiltinEventhubEndpoint")]
    public bool? ApplyToBuiltinEventhubEndpoint { get; set; }

    /// <summary>Default Action for Network Rule Set. Possible values are Deny, Allow. Defaults to Deny.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>One or more ip_rule blocks as defined below.</summary>
    [JsonPropertyName("ipRule")]
    public IList<V1beta2IOTHubSpecForProviderNetworkRuleSetIpRule>? IpRule { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IOTHubSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2IOTHubSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IOTHubSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2IOTHubSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IOTHubSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IOTHubSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2IOTHubSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IOTHubSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2IOTHubSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IOTHubSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2IOTHubSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IOTHubSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IOTHubSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecForProviderResourceGroupNameSelector
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
    public V1beta2IOTHubSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A sku block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecForProviderSku
{
    /// <summary>The number of provisioned IoT Hub units.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The name of the sku. Possible values are B1, B2, B3, F1, S1, S2, and S3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecForProvider
{
    /// <summary>A cloud_to_device block as defined below.</summary>
    [JsonPropertyName("cloudToDevice")]
    public V1beta2IOTHubSpecForProviderCloudToDevice? CloudToDevice { get; set; }

    /// <summary>The number of device-to-cloud partitions used by backing event hubs. Must be between 2 and 128. Defaults to 4.</summary>
    [JsonPropertyName("eventHubPartitionCount")]
    public double? EventHubPartitionCount { get; set; }

    /// <summary>The event hub retention to use in days. Must be between 1 and 7. Defaults to 1.</summary>
    [JsonPropertyName("eventHubRetentionInDays")]
    public double? EventHubRetentionInDays { get; set; }

    /// <summary>A file_upload block as defined below.</summary>
    [JsonPropertyName("fileUpload")]
    public V1beta2IOTHubSpecForProviderFileUpload? FileUpload { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2IOTHubSpecForProviderIdentity? Identity { get; set; }

    /// <summary>If false, SAS tokens with Iot hub scoped SAS keys cannot be used for authentication. Defaults to true.</summary>
    [JsonPropertyName("localAuthenticationEnabled")]
    public bool? LocalAuthenticationEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the minimum TLS version to support for this hub. The only valid value is 1.2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    /// <summary>A network_rule_set block as defined below.</summary>
    [JsonPropertyName("networkRuleSet")]
    public IList<V1beta2IOTHubSpecForProviderNetworkRuleSet>? NetworkRuleSet { get; set; }

    /// <summary>Is the IotHub resource accessible from a public network?</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group under which the IotHub resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2IOTHubSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2IOTHubSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public V1beta2IOTHubSpecForProviderSku? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecInitProviderCloudToDeviceFeedback
{
    /// <summary>The lock duration for the file upload notifications queue, specified as an ISO 8601 timespan duration. This value must be between 5 and 300 seconds. Defaults to PT1M.</summary>
    [JsonPropertyName("lockDuration")]
    public string? LockDuration { get; set; }

    /// <summary>The number of times the IoT Hub attempts to deliver a file upload notification message. Defaults to 10.</summary>
    [JsonPropertyName("maxDeliveryCount")]
    public double? MaxDeliveryCount { get; set; }

    /// <summary>The retention time for service-bound feedback messages, specified as an ISO 8601 timespan duration. This value must be between 1 minute and 48 hours. Defaults to PT1H.</summary>
    [JsonPropertyName("timeToLive")]
    public string? TimeToLive { get; set; }
}

/// <summary>A cloud_to_device block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecInitProviderCloudToDevice
{
    /// <summary>The default time to live for cloud-to-device messages, specified as an ISO 8601 timespan duration. This value must be between 1 minute and 48 hours. Defaults to PT1H.</summary>
    [JsonPropertyName("defaultTtl")]
    public string? DefaultTtl { get; set; }

    /// <summary>A feedback block as defined below.</summary>
    [JsonPropertyName("feedback")]
    public IList<V1beta2IOTHubSpecInitProviderCloudToDeviceFeedback>? Feedback { get; set; }

    /// <summary>The maximum delivery count for cloud-to-device per-device queues. This value must be between 1 and 100. Defaults to 10.</summary>
    [JsonPropertyName("maxDeliveryCount")]
    public double? MaxDeliveryCount { get; set; }
}

/// <summary>The connection string for the Azure Storage account to which files are uploaded.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecInitProviderFileUploadConnectionStringSecretRef
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

/// <summary>A file_upload block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecInitProviderFileUpload
{
    /// <summary>The type used to authenticate against the storage account. Possible values are keyBased and identityBased. Defaults to keyBased.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>The connection string for the Azure Storage account to which files are uploaded.</summary>
    [JsonPropertyName("connectionStringSecretRef")]
    public required V1beta2IOTHubSpecInitProviderFileUploadConnectionStringSecretRef ConnectionStringSecretRef { get; set; }

    /// <summary>The name of the root container where the files should be uploaded to. The container need not exist but should be creatable using the connection_string specified.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>The period of time for which a file upload notification message is available to consume before it expires, specified as an ISO 8601 timespan duration. This value must be between 1 minute and 48 hours. Defaults to PT1H.</summary>
    [JsonPropertyName("defaultTtl")]
    public string? DefaultTtl { get; set; }

    /// <summary>The ID of the User Managed Identity used to authenticate against the storage account.</summary>
    [JsonPropertyName("identityId")]
    public string? IdentityId { get; set; }

    /// <summary>The lock duration for the file upload notifications queue, specified as an ISO 8601 timespan duration. This value must be between 5 and 300 seconds. Defaults to PT1M.</summary>
    [JsonPropertyName("lockDuration")]
    public string? LockDuration { get; set; }

    /// <summary>The number of times the IoT Hub attempts to deliver a file upload notification message. Defaults to 10.</summary>
    [JsonPropertyName("maxDeliveryCount")]
    public double? MaxDeliveryCount { get; set; }

    /// <summary>Used to specify whether file notifications are sent to IoT Hub on upload. Defaults to false.</summary>
    [JsonPropertyName("notifications")]
    public bool? Notifications { get; set; }

    /// <summary>The period of time for which the SAS URI generated by IoT Hub for file upload is valid, specified as an ISO 8601 timespan duration. This value must be between 1 minute and 24 hours. Defaults to PT1H.</summary>
    [JsonPropertyName("sasTtl")]
    public string? SasTtl { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this IoT Hub.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this IoT Hub. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecInitProviderNetworkRuleSetIpRule
{
    /// <summary>The desired action for requests captured by this rule. Possible values are Allow. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP address range in CIDR notation for the IP rule.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }

    /// <summary>The name of the sku. Possible values are B1, B2, B3, F1, S1, S2, and S3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecInitProviderNetworkRuleSet
{
    /// <summary>Determines if Network Rule Set is also applied to the BuiltIn EventHub EndPoint of the IotHub. Defaults to false.</summary>
    [JsonPropertyName("applyToBuiltinEventhubEndpoint")]
    public bool? ApplyToBuiltinEventhubEndpoint { get; set; }

    /// <summary>Default Action for Network Rule Set. Possible values are Deny, Allow. Defaults to Deny.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>One or more ip_rule blocks as defined below.</summary>
    [JsonPropertyName("ipRule")]
    public IList<V1beta2IOTHubSpecInitProviderNetworkRuleSetIpRule>? IpRule { get; set; }
}

/// <summary>A sku block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecInitProviderSku
{
    /// <summary>The number of provisioned IoT Hub units.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The name of the sku. Possible values are B1, B2, B3, F1, S1, S2, and S3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
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
public partial class V1beta2IOTHubSpecInitProvider
{
    /// <summary>A cloud_to_device block as defined below.</summary>
    [JsonPropertyName("cloudToDevice")]
    public V1beta2IOTHubSpecInitProviderCloudToDevice? CloudToDevice { get; set; }

    /// <summary>The number of device-to-cloud partitions used by backing event hubs. Must be between 2 and 128. Defaults to 4.</summary>
    [JsonPropertyName("eventHubPartitionCount")]
    public double? EventHubPartitionCount { get; set; }

    /// <summary>The event hub retention to use in days. Must be between 1 and 7. Defaults to 1.</summary>
    [JsonPropertyName("eventHubRetentionInDays")]
    public double? EventHubRetentionInDays { get; set; }

    /// <summary>A file_upload block as defined below.</summary>
    [JsonPropertyName("fileUpload")]
    public V1beta2IOTHubSpecInitProviderFileUpload? FileUpload { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2IOTHubSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>If false, SAS tokens with Iot hub scoped SAS keys cannot be used for authentication. Defaults to true.</summary>
    [JsonPropertyName("localAuthenticationEnabled")]
    public bool? LocalAuthenticationEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the minimum TLS version to support for this hub. The only valid value is 1.2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    /// <summary>A network_rule_set block as defined below.</summary>
    [JsonPropertyName("networkRuleSet")]
    public IList<V1beta2IOTHubSpecInitProviderNetworkRuleSet>? NetworkRuleSet { get; set; }

    /// <summary>Is the IotHub resource accessible from a public network?</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public V1beta2IOTHubSpecInitProviderSku? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IOTHubSpecManagementPoliciesEnum>))]
public enum V1beta2IOTHubSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IOTHubSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2IOTHubSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IOTHubSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2IOTHubSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IOTHubSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IOTHubSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2IOTHubSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>IOTHubSpec defines the desired state of IOTHub</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubSpec
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
    public V1beta2IOTHubSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2IOTHubSpecForProvider ForProvider { get; set; }

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
    public V1beta2IOTHubSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2IOTHubSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2IOTHubSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2IOTHubSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubStatusAtProviderCloudToDeviceFeedback
{
    /// <summary>The lock duration for the file upload notifications queue, specified as an ISO 8601 timespan duration. This value must be between 5 and 300 seconds. Defaults to PT1M.</summary>
    [JsonPropertyName("lockDuration")]
    public string? LockDuration { get; set; }

    /// <summary>The number of times the IoT Hub attempts to deliver a file upload notification message. Defaults to 10.</summary>
    [JsonPropertyName("maxDeliveryCount")]
    public double? MaxDeliveryCount { get; set; }

    /// <summary>The retention time for service-bound feedback messages, specified as an ISO 8601 timespan duration. This value must be between 1 minute and 48 hours. Defaults to PT1H.</summary>
    [JsonPropertyName("timeToLive")]
    public string? TimeToLive { get; set; }
}

/// <summary>A cloud_to_device block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubStatusAtProviderCloudToDevice
{
    /// <summary>The default time to live for cloud-to-device messages, specified as an ISO 8601 timespan duration. This value must be between 1 minute and 48 hours. Defaults to PT1H.</summary>
    [JsonPropertyName("defaultTtl")]
    public string? DefaultTtl { get; set; }

    /// <summary>A feedback block as defined below.</summary>
    [JsonPropertyName("feedback")]
    public IList<V1beta2IOTHubStatusAtProviderCloudToDeviceFeedback>? Feedback { get; set; }

    /// <summary>The maximum delivery count for cloud-to-device per-device queues. This value must be between 1 and 100. Defaults to 10.</summary>
    [JsonPropertyName("maxDeliveryCount")]
    public double? MaxDeliveryCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubStatusAtProviderEndpoint
{
    /// <summary>The type used to authenticate against the endpoint. Possible values are keyBased and identityBased. Defaults to keyBased.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>Time interval at which blobs are written to storage. Value should be between 60 and 720 seconds. Default value is 300 seconds. This attribute is applicable for endpoint type AzureIotHub.StorageContainer.</summary>
    [JsonPropertyName("batchFrequencyInSeconds")]
    public double? BatchFrequencyInSeconds { get; set; }

    /// <summary>The name of storage container in the storage account. This attribute is mandatory for endpoint type AzureIotHub.StorageContainer.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Encoding that is used to serialize messages to blobs. Supported values are Avro, AvroDeflate and JSON. Default value is Avro. This attribute is applicable for endpoint type AzureIotHub.StorageContainer. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>URI of the Service Bus or Event Hubs Namespace endpoint. This attribute can only be specified and is mandatory when authentication_type is identityBased for endpoint type AzureIotHub.ServiceBusQueue, AzureIotHub.ServiceBusTopic or AzureIotHub.EventHub.</summary>
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    /// <summary>Name of the Service Bus Queue/Topic or Event Hub. This attribute can only be specified and is mandatory when authentication_type is identityBased for endpoint type AzureIotHub.ServiceBusQueue, AzureIotHub.ServiceBusTopic or AzureIotHub.EventHub.</summary>
    [JsonPropertyName("entityPath")]
    public string? EntityPath { get; set; }

    /// <summary>File name format for the blob. All parameters are mandatory but can be reordered. This attribute is applicable for endpoint type AzureIotHub.StorageContainer. Defaults to {iothub}/{partition}/{YYYY}/{MM}/{DD}/{HH}/{mm}.</summary>
    [JsonPropertyName("fileNameFormat")]
    public string? FileNameFormat { get; set; }

    /// <summary>The ID of the User Managed Identity used to authenticate against the endpoint.</summary>
    [JsonPropertyName("identityId")]
    public string? IdentityId { get; set; }

    /// <summary>Maximum number of bytes for each blob written to storage. Value should be between 10485760(10MB) and 524288000(500MB). Default value is 314572800(300MB). This attribute is applicable for endpoint type AzureIotHub.StorageContainer.</summary>
    [JsonPropertyName("maxChunkSizeInBytes")]
    public double? MaxChunkSizeInBytes { get; set; }

    /// <summary>The name of the endpoint. The name must be unique across endpoint types. The following names are reserved: events, operationsMonitoringEvents, fileNotifications and $default.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource group in which the endpoint will be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The subscription ID for the endpoint.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The type of the endpoint. Possible values are AzureIotHub.StorageContainer, AzureIotHub.ServiceBusQueue, AzureIotHub.ServiceBusTopic or AzureIotHub.EventHub.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubStatusAtProviderEnrichment
{
    /// <summary>The list of endpoints which will be enriched.</summary>
    [JsonPropertyName("endpointNames")]
    public IList<string>? EndpointNames { get; set; }

    /// <summary>The key of the enrichment.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The value of the enrichment. Value can be any static string, the name of the IoT Hub sending the message (use $iothubname) or information from the device twin (ex: $twin.tags.latitude)</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A fallback_route block as defined below. If the fallback route is enabled, messages that don&apos;t match any of the supplied routes are automatically sent to this route. Defaults to messages/events.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubStatusAtProviderFallbackRoute
{
    /// <summary>The condition that is evaluated to apply the routing rule. Defaults to true. For grammar, see: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>Used to specify whether the fallback route is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The endpoints to which messages that satisfy the condition are routed. Currently only 1 endpoint is allowed.</summary>
    [JsonPropertyName("endpointNames")]
    public IList<string>? EndpointNames { get; set; }

    /// <summary>The source that the routing rule is to be applied to, such as DeviceMessages. Possible values include: Invalid, DeviceMessages, TwinChangeEvents, DeviceLifecycleEvents, DeviceConnectionStateEvents, DeviceJobLifecycleEvents and DigitalTwinChangeEvents. Defaults to DeviceMessages.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>A file_upload block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubStatusAtProviderFileUpload
{
    /// <summary>The type used to authenticate against the storage account. Possible values are keyBased and identityBased. Defaults to keyBased.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>The name of the root container where the files should be uploaded to. The container need not exist but should be creatable using the connection_string specified.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>The period of time for which a file upload notification message is available to consume before it expires, specified as an ISO 8601 timespan duration. This value must be between 1 minute and 48 hours. Defaults to PT1H.</summary>
    [JsonPropertyName("defaultTtl")]
    public string? DefaultTtl { get; set; }

    /// <summary>The ID of the User Managed Identity used to authenticate against the storage account.</summary>
    [JsonPropertyName("identityId")]
    public string? IdentityId { get; set; }

    /// <summary>The lock duration for the file upload notifications queue, specified as an ISO 8601 timespan duration. This value must be between 5 and 300 seconds. Defaults to PT1M.</summary>
    [JsonPropertyName("lockDuration")]
    public string? LockDuration { get; set; }

    /// <summary>The number of times the IoT Hub attempts to deliver a file upload notification message. Defaults to 10.</summary>
    [JsonPropertyName("maxDeliveryCount")]
    public double? MaxDeliveryCount { get; set; }

    /// <summary>Used to specify whether file notifications are sent to IoT Hub on upload. Defaults to false.</summary>
    [JsonPropertyName("notifications")]
    public bool? Notifications { get; set; }

    /// <summary>The period of time for which the SAS URI generated by IoT Hub for file upload is valid, specified as an ISO 8601 timespan duration. This value must be between 1 minute and 24 hours. Defaults to PT1H.</summary>
    [JsonPropertyName("sasTtl")]
    public string? SasTtl { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this IoT Hub.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this IoT Hub. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubStatusAtProviderNetworkRuleSetIpRule
{
    /// <summary>The desired action for requests captured by this rule. Possible values are Allow. Defaults to Allow.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The IP address range in CIDR notation for the IP rule.</summary>
    [JsonPropertyName("ipMask")]
    public string? IpMask { get; set; }

    /// <summary>The name of the sku. Possible values are B1, B2, B3, F1, S1, S2, and S3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubStatusAtProviderNetworkRuleSet
{
    /// <summary>Determines if Network Rule Set is also applied to the BuiltIn EventHub EndPoint of the IotHub. Defaults to false.</summary>
    [JsonPropertyName("applyToBuiltinEventhubEndpoint")]
    public bool? ApplyToBuiltinEventhubEndpoint { get; set; }

    /// <summary>Default Action for Network Rule Set. Possible values are Deny, Allow. Defaults to Deny.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>One or more ip_rule blocks as defined below.</summary>
    [JsonPropertyName("ipRule")]
    public IList<V1beta2IOTHubStatusAtProviderNetworkRuleSetIpRule>? IpRule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubStatusAtProviderRoute
{
    /// <summary>The condition that is evaluated to apply the routing rule. Defaults to true. For grammar, see: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>Used to specify whether a route is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The list of endpoints to which messages that satisfy the condition are routed.</summary>
    [JsonPropertyName("endpointNames")]
    public IList<string>? EndpointNames { get; set; }

    /// <summary>The name of the route.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The source that the routing rule is to be applied to, such as DeviceMessages. Possible values include: Invalid, DeviceMessages, TwinChangeEvents, DeviceLifecycleEvents, DeviceConnectionStateEvents, DeviceJobLifecycleEvents and DigitalTwinChangeEvents.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubStatusAtProviderSharedAccessPolicy
{
    /// <summary>The name of the shared access policy.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>The permissions assigned to the shared access policy.</summary>
    [JsonPropertyName("permissions")]
    public string? Permissions { get; set; }
}

/// <summary>A sku block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubStatusAtProviderSku
{
    /// <summary>The number of provisioned IoT Hub units.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>The name of the sku. Possible values are B1, B2, B3, F1, S1, S2, and S3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubStatusAtProvider
{
    /// <summary>A cloud_to_device block as defined below.</summary>
    [JsonPropertyName("cloudToDevice")]
    public V1beta2IOTHubStatusAtProviderCloudToDevice? CloudToDevice { get; set; }

    /// <summary>An endpoint block as defined below.</summary>
    [JsonPropertyName("endpoint")]
    public IList<V1beta2IOTHubStatusAtProviderEndpoint>? Endpoint { get; set; }

    /// <summary>A enrichment block as defined below.</summary>
    [JsonPropertyName("enrichment")]
    public IList<V1beta2IOTHubStatusAtProviderEnrichment>? Enrichment { get; set; }

    /// <summary>The EventHub compatible endpoint for events data</summary>
    [JsonPropertyName("eventHubEventsEndpoint")]
    public string? EventHubEventsEndpoint { get; set; }

    /// <summary>The EventHub namespace for events data</summary>
    [JsonPropertyName("eventHubEventsNamespace")]
    public string? EventHubEventsNamespace { get; set; }

    /// <summary>The EventHub compatible path for events data</summary>
    [JsonPropertyName("eventHubEventsPath")]
    public string? EventHubEventsPath { get; set; }

    /// <summary>The EventHub compatible endpoint for operational data</summary>
    [JsonPropertyName("eventHubOperationsEndpoint")]
    public string? EventHubOperationsEndpoint { get; set; }

    /// <summary>The EventHub compatible path for operational data</summary>
    [JsonPropertyName("eventHubOperationsPath")]
    public string? EventHubOperationsPath { get; set; }

    /// <summary>The number of device-to-cloud partitions used by backing event hubs. Must be between 2 and 128. Defaults to 4.</summary>
    [JsonPropertyName("eventHubPartitionCount")]
    public double? EventHubPartitionCount { get; set; }

    /// <summary>The event hub retention to use in days. Must be between 1 and 7. Defaults to 1.</summary>
    [JsonPropertyName("eventHubRetentionInDays")]
    public double? EventHubRetentionInDays { get; set; }

    /// <summary>A fallback_route block as defined below. If the fallback route is enabled, messages that don&apos;t match any of the supplied routes are automatically sent to this route. Defaults to messages/events.</summary>
    [JsonPropertyName("fallbackRoute")]
    public V1beta2IOTHubStatusAtProviderFallbackRoute? FallbackRoute { get; set; }

    /// <summary>A file_upload block as defined below.</summary>
    [JsonPropertyName("fileUpload")]
    public V1beta2IOTHubStatusAtProviderFileUpload? FileUpload { get; set; }

    /// <summary>The hostname of the IotHub Resource.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>The ID of the IoTHub.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta2IOTHubStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>If false, SAS tokens with Iot hub scoped SAS keys cannot be used for authentication. Defaults to true.</summary>
    [JsonPropertyName("localAuthenticationEnabled")]
    public bool? LocalAuthenticationEnabled { get; set; }

    /// <summary>Specifies the supported Azure location where the resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the minimum TLS version to support for this hub. The only valid value is 1.2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("minTlsVersion")]
    public string? MinTlsVersion { get; set; }

    /// <summary>A network_rule_set block as defined below.</summary>
    [JsonPropertyName("networkRuleSet")]
    public IList<V1beta2IOTHubStatusAtProviderNetworkRuleSet>? NetworkRuleSet { get; set; }

    /// <summary>Is the IotHub resource accessible from a public network?</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group under which the IotHub resource has to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A route block as defined below.</summary>
    [JsonPropertyName("route")]
    public IList<V1beta2IOTHubStatusAtProviderRoute>? Route { get; set; }

    /// <summary>One or more shared_access_policy blocks as defined below.</summary>
    [JsonPropertyName("sharedAccessPolicy")]
    public IList<V1beta2IOTHubStatusAtProviderSharedAccessPolicy>? SharedAccessPolicy { get; set; }

    /// <summary>A sku block as defined below.</summary>
    [JsonPropertyName("sku")]
    public V1beta2IOTHubStatusAtProviderSku? Sku { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this IoT Hub. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubStatusConditions
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

/// <summary>IOTHubStatus defines the observed state of IOTHub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IOTHubStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2IOTHubStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2IOTHubStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>IOTHub is the Schema for the IOTHubs API. Manages an IotHub</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2IOTHub : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2IOTHubSpec>, IStatus<V1beta2IOTHubStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "IOTHub";
    public const string KubeGroup = "devices.azure.upbound.io";
    public const string KubePluralName = "iothubs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "devices.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IOTHub";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IOTHubSpec defines the desired state of IOTHub</summary>
    [JsonPropertyName("spec")]
    public required V1beta2IOTHubSpec Spec { get; set; }

    /// <summary>IOTHubStatus defines the observed state of IOTHub.</summary>
    [JsonPropertyName("status")]
    public V1beta2IOTHubStatus? Status { get; set; }
}
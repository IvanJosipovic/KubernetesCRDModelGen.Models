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
/// <summary>ConfigurationSetEventDestination is the Schema for the ConfigurationSetEventDestinations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ConfigurationSetEventDestinationList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ConfigurationSetEventDestination>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ConfigurationSetEventDestinationList";
    public const string KubeGroup = "sesv2.aws.upbound.io";
    public const string KubePluralName = "configurationseteventdestinations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sesv2.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ConfigurationSetEventDestinationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ConfigurationSetEventDestination objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ConfigurationSetEventDestination> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecDeletionPolicyEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameRefPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameRefPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ConfigurationSet in sesv2 to populate configurationSetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameSelectorPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ConfigurationSet in sesv2 to populate configurationSetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameSelector
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
    public V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationCloudWatchDestinationDimensionConfiguration
{
    /// <summary>The default value of the dimension that is published to Amazon CloudWatch if you don&apos;t provide the value of the dimension when you send an email.</summary>
    [JsonPropertyName("defaultDimensionValue")]
    public string? DefaultDimensionValue { get; set; }

    /// <summary>The name of an Amazon CloudWatch dimension associated with an email sending metric.</summary>
    [JsonPropertyName("dimensionName")]
    public string? DimensionName { get; set; }

    /// <summary>The location where the Amazon SES API v2 finds the value of a dimension to publish to Amazon CloudWatch. Valid values: MESSAGE_TAG, EMAIL_HEADER, LINK_TAG.</summary>
    [JsonPropertyName("dimensionValueSource")]
    public string? DimensionValueSource { get; set; }
}

/// <summary>An object that defines an Amazon CloudWatch destination for email events. See cloud_watch_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationCloudWatchDestination
{
    /// <summary>An array of objects that define the dimensions to use when you send email events to Amazon CloudWatch. See dimension_configuration Block for details.</summary>
    [JsonPropertyName("dimensionConfiguration")]
    public IList<V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationCloudWatchDestinationDimensionConfiguration>? DimensionConfiguration { get; set; }
}

/// <summary>An object that defines an Amazon EventBridge destination for email events. You can use Amazon EventBridge to send notifications when certain email events occur. See event_bridge_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationEventBridgeDestination
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon EventBridge bus to publish email events to. Only the default bus is supported.</summary>
    [JsonPropertyName("eventBusArn")]
    public string? EventBusArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate deliveryStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate deliveryStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelector
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
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate iamRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate iamRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelector
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
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>An object that defines an Amazon Kinesis Data Firehose destination for email events. See kinesis_firehose_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestination
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon Kinesis Data Firehose stream that the Amazon SES API v2 sends email events to.</summary>
    [JsonPropertyName("deliveryStreamArn")]
    public string? DeliveryStreamArn { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate deliveryStreamArn.</summary>
    [JsonPropertyName("deliveryStreamArnRef")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRef? DeliveryStreamArnRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate deliveryStreamArn.</summary>
    [JsonPropertyName("deliveryStreamArnSelector")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelector? DeliveryStreamArnSelector { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role that the Amazon SES API v2 uses to send email events to the Amazon Kinesis Data Firehose stream.</summary>
    [JsonPropertyName("iamRoleArn")]
    public string? IamRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate iamRoleArn.</summary>
    [JsonPropertyName("iamRoleArnRef")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRef? IamRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate iamRoleArn.</summary>
    [JsonPropertyName("iamRoleArnSelector")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelector? IamRoleArnSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnRefPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnRefPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a App in pinpoint to populate applicationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a App in pinpoint to populate applicationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnSelector
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
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>An object that defines an Amazon Pinpoint project destination for email events. See pinpoint_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestination
{
    [JsonPropertyName("applicationArn")]
    public string? ApplicationArn { get; set; }

    /// <summary>Reference to a App in pinpoint to populate applicationArn.</summary>
    [JsonPropertyName("applicationArnRef")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnRef? ApplicationArnRef { get; set; }

    /// <summary>Selector for a App in pinpoint to populate applicationArn.</summary>
    [JsonPropertyName("applicationArnSelector")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestinationApplicationArnSelector? ApplicationArnSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnRefPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnRefPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate topicArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnSelectorPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate topicArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnSelector
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
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnSelectorPolicy? Policy { get; set; }
}

/// <summary>An object that defines an Amazon SNS destination for email events. See sns_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestination
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon SNS topic to publish email events to.</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate topicArn.</summary>
    [JsonPropertyName("topicArnRef")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnRef? TopicArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate topicArn.</summary>
    [JsonPropertyName("topicArnSelector")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestinationTopicArnSelector? TopicArnSelector { get; set; }
}

/// <summary>A name that identifies the event destination within the configuration set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestination
{
    /// <summary>An object that defines an Amazon CloudWatch destination for email events. See cloud_watch_destination Block for details.</summary>
    [JsonPropertyName("cloudWatchDestination")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationCloudWatchDestination? CloudWatchDestination { get; set; }

    /// <summary>When the event destination is enabled, the specified event types are sent to the destinations. Default: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>An object that defines an Amazon EventBridge destination for email events. You can use Amazon EventBridge to send notifications when certain email events occur. See event_bridge_destination Block for details.</summary>
    [JsonPropertyName("eventBridgeDestination")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationEventBridgeDestination? EventBridgeDestination { get; set; }

    /// <summary>An object that defines an Amazon Kinesis Data Firehose destination for email events. See kinesis_firehose_destination Block for details.</summary>
    [JsonPropertyName("kinesisFirehoseDestination")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationKinesisFirehoseDestination? KinesisFirehoseDestination { get; set; }

    /// <summary>- An array that specifies which events the Amazon SES API v2 should send to the destinations. Valid values: SEND, REJECT, BOUNCE, COMPLAINT, DELIVERY, OPEN, CLICK, RENDERING_FAILURE, DELIVERY_DELAY, SUBSCRIPTION.</summary>
    [JsonPropertyName("matchingEventTypes")]
    public IList<string>? MatchingEventTypes { get; set; }

    /// <summary>An object that defines an Amazon Pinpoint project destination for email events. See pinpoint_destination Block for details.</summary>
    [JsonPropertyName("pinpointDestination")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationPinpointDestination? PinpointDestination { get; set; }

    /// <summary>An object that defines an Amazon SNS destination for email events. See sns_destination Block for details.</summary>
    [JsonPropertyName("snsDestination")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestinationSnsDestination? SnsDestination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecForProvider
{
    /// <summary>The name of the configuration set.</summary>
    [JsonPropertyName("configurationSetName")]
    public string? ConfigurationSetName { get; set; }

    /// <summary>Reference to a ConfigurationSet in sesv2 to populate configurationSetName.</summary>
    [JsonPropertyName("configurationSetNameRef")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameRef? ConfigurationSetNameRef { get; set; }

    /// <summary>Selector for a ConfigurationSet in sesv2 to populate configurationSetName.</summary>
    [JsonPropertyName("configurationSetNameSelector")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderConfigurationSetNameSelector? ConfigurationSetNameSelector { get; set; }

    /// <summary>A name that identifies the event destination within the configuration set.</summary>
    [JsonPropertyName("eventDestination")]
    public V1beta2ConfigurationSetEventDestinationSpecForProviderEventDestination? EventDestination { get; set; }

    /// <summary>An object that defines the event destination. See event_destination Block for details.</summary>
    [JsonPropertyName("eventDestinationName")]
    public string? EventDestinationName { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameRefPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameRefPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ConfigurationSet in sesv2 to populate configurationSetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameSelectorPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ConfigurationSet in sesv2 to populate configurationSetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameSelector
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
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationCloudWatchDestinationDimensionConfiguration
{
    /// <summary>The default value of the dimension that is published to Amazon CloudWatch if you don&apos;t provide the value of the dimension when you send an email.</summary>
    [JsonPropertyName("defaultDimensionValue")]
    public string? DefaultDimensionValue { get; set; }

    /// <summary>The name of an Amazon CloudWatch dimension associated with an email sending metric.</summary>
    [JsonPropertyName("dimensionName")]
    public string? DimensionName { get; set; }

    /// <summary>The location where the Amazon SES API v2 finds the value of a dimension to publish to Amazon CloudWatch. Valid values: MESSAGE_TAG, EMAIL_HEADER, LINK_TAG.</summary>
    [JsonPropertyName("dimensionValueSource")]
    public string? DimensionValueSource { get; set; }
}

/// <summary>An object that defines an Amazon CloudWatch destination for email events. See cloud_watch_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationCloudWatchDestination
{
    /// <summary>An array of objects that define the dimensions to use when you send email events to Amazon CloudWatch. See dimension_configuration Block for details.</summary>
    [JsonPropertyName("dimensionConfiguration")]
    public IList<V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationCloudWatchDestinationDimensionConfiguration>? DimensionConfiguration { get; set; }
}

/// <summary>An object that defines an Amazon EventBridge destination for email events. You can use Amazon EventBridge to send notifications when certain email events occur. See event_bridge_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationEventBridgeDestination
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon EventBridge bus to publish email events to. Only the default bus is supported.</summary>
    [JsonPropertyName("eventBusArn")]
    public string? EventBusArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate deliveryStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate deliveryStreamArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelector
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
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate iamRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate iamRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelector
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
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>An object that defines an Amazon Kinesis Data Firehose destination for email events. See kinesis_firehose_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestination
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon Kinesis Data Firehose stream that the Amazon SES API v2 sends email events to.</summary>
    [JsonPropertyName("deliveryStreamArn")]
    public string? DeliveryStreamArn { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate deliveryStreamArn.</summary>
    [JsonPropertyName("deliveryStreamArnRef")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnRef? DeliveryStreamArnRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate deliveryStreamArn.</summary>
    [JsonPropertyName("deliveryStreamArnSelector")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationDeliveryStreamArnSelector? DeliveryStreamArnSelector { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role that the Amazon SES API v2 uses to send email events to the Amazon Kinesis Data Firehose stream.</summary>
    [JsonPropertyName("iamRoleArn")]
    public string? IamRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate iamRoleArn.</summary>
    [JsonPropertyName("iamRoleArnRef")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnRef? IamRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate iamRoleArn.</summary>
    [JsonPropertyName("iamRoleArnSelector")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestinationIamRoleArnSelector? IamRoleArnSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnRefPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnRefPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a App in pinpoint to populate applicationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a App in pinpoint to populate applicationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnSelector
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
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>An object that defines an Amazon Pinpoint project destination for email events. See pinpoint_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestination
{
    [JsonPropertyName("applicationArn")]
    public string? ApplicationArn { get; set; }

    /// <summary>Reference to a App in pinpoint to populate applicationArn.</summary>
    [JsonPropertyName("applicationArnRef")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnRef? ApplicationArnRef { get; set; }

    /// <summary>Selector for a App in pinpoint to populate applicationArn.</summary>
    [JsonPropertyName("applicationArnSelector")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestinationApplicationArnSelector? ApplicationArnSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnRefPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnRefPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate topicArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnSelectorPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate topicArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnSelector
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
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnSelectorPolicy? Policy { get; set; }
}

/// <summary>An object that defines an Amazon SNS destination for email events. See sns_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestination
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon SNS topic to publish email events to.</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate topicArn.</summary>
    [JsonPropertyName("topicArnRef")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnRef? TopicArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate topicArn.</summary>
    [JsonPropertyName("topicArnSelector")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestinationTopicArnSelector? TopicArnSelector { get; set; }
}

/// <summary>A name that identifies the event destination within the configuration set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestination
{
    /// <summary>An object that defines an Amazon CloudWatch destination for email events. See cloud_watch_destination Block for details.</summary>
    [JsonPropertyName("cloudWatchDestination")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationCloudWatchDestination? CloudWatchDestination { get; set; }

    /// <summary>When the event destination is enabled, the specified event types are sent to the destinations. Default: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>An object that defines an Amazon EventBridge destination for email events. You can use Amazon EventBridge to send notifications when certain email events occur. See event_bridge_destination Block for details.</summary>
    [JsonPropertyName("eventBridgeDestination")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationEventBridgeDestination? EventBridgeDestination { get; set; }

    /// <summary>An object that defines an Amazon Kinesis Data Firehose destination for email events. See kinesis_firehose_destination Block for details.</summary>
    [JsonPropertyName("kinesisFirehoseDestination")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationKinesisFirehoseDestination? KinesisFirehoseDestination { get; set; }

    /// <summary>- An array that specifies which events the Amazon SES API v2 should send to the destinations. Valid values: SEND, REJECT, BOUNCE, COMPLAINT, DELIVERY, OPEN, CLICK, RENDERING_FAILURE, DELIVERY_DELAY, SUBSCRIPTION.</summary>
    [JsonPropertyName("matchingEventTypes")]
    public IList<string>? MatchingEventTypes { get; set; }

    /// <summary>An object that defines an Amazon Pinpoint project destination for email events. See pinpoint_destination Block for details.</summary>
    [JsonPropertyName("pinpointDestination")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationPinpointDestination? PinpointDestination { get; set; }

    /// <summary>An object that defines an Amazon SNS destination for email events. See sns_destination Block for details.</summary>
    [JsonPropertyName("snsDestination")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestinationSnsDestination? SnsDestination { get; set; }
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
public partial class V1beta2ConfigurationSetEventDestinationSpecInitProvider
{
    /// <summary>The name of the configuration set.</summary>
    [JsonPropertyName("configurationSetName")]
    public string? ConfigurationSetName { get; set; }

    /// <summary>Reference to a ConfigurationSet in sesv2 to populate configurationSetName.</summary>
    [JsonPropertyName("configurationSetNameRef")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameRef? ConfigurationSetNameRef { get; set; }

    /// <summary>Selector for a ConfigurationSet in sesv2 to populate configurationSetName.</summary>
    [JsonPropertyName("configurationSetNameSelector")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderConfigurationSetNameSelector? ConfigurationSetNameSelector { get; set; }

    /// <summary>A name that identifies the event destination within the configuration set.</summary>
    [JsonPropertyName("eventDestination")]
    public V1beta2ConfigurationSetEventDestinationSpecInitProviderEventDestination? EventDestination { get; set; }

    /// <summary>An object that defines the event destination. See event_destination Block for details.</summary>
    [JsonPropertyName("eventDestinationName")]
    public string? EventDestinationName { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecManagementPoliciesEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ConfigurationSetEventDestinationSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ConfigurationSetEventDestinationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ConfigurationSetEventDestinationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ConfigurationSetEventDestinationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ConfigurationSetEventDestinationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ConfigurationSetEventDestinationSpec defines the desired state of ConfigurationSetEventDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationSpec
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
    public V1beta2ConfigurationSetEventDestinationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ConfigurationSetEventDestinationSpecForProvider ForProvider { get; set; }

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
    public V1beta2ConfigurationSetEventDestinationSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ConfigurationSetEventDestinationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ConfigurationSetEventDestinationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ConfigurationSetEventDestinationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationStatusAtProviderEventDestinationCloudWatchDestinationDimensionConfiguration
{
    /// <summary>The default value of the dimension that is published to Amazon CloudWatch if you don&apos;t provide the value of the dimension when you send an email.</summary>
    [JsonPropertyName("defaultDimensionValue")]
    public string? DefaultDimensionValue { get; set; }

    /// <summary>The name of an Amazon CloudWatch dimension associated with an email sending metric.</summary>
    [JsonPropertyName("dimensionName")]
    public string? DimensionName { get; set; }

    /// <summary>The location where the Amazon SES API v2 finds the value of a dimension to publish to Amazon CloudWatch. Valid values: MESSAGE_TAG, EMAIL_HEADER, LINK_TAG.</summary>
    [JsonPropertyName("dimensionValueSource")]
    public string? DimensionValueSource { get; set; }
}

/// <summary>An object that defines an Amazon CloudWatch destination for email events. See cloud_watch_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationStatusAtProviderEventDestinationCloudWatchDestination
{
    /// <summary>An array of objects that define the dimensions to use when you send email events to Amazon CloudWatch. See dimension_configuration Block for details.</summary>
    [JsonPropertyName("dimensionConfiguration")]
    public IList<V1beta2ConfigurationSetEventDestinationStatusAtProviderEventDestinationCloudWatchDestinationDimensionConfiguration>? DimensionConfiguration { get; set; }
}

/// <summary>An object that defines an Amazon EventBridge destination for email events. You can use Amazon EventBridge to send notifications when certain email events occur. See event_bridge_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationStatusAtProviderEventDestinationEventBridgeDestination
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon EventBridge bus to publish email events to. Only the default bus is supported.</summary>
    [JsonPropertyName("eventBusArn")]
    public string? EventBusArn { get; set; }
}

/// <summary>An object that defines an Amazon Kinesis Data Firehose destination for email events. See kinesis_firehose_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationStatusAtProviderEventDestinationKinesisFirehoseDestination
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon Kinesis Data Firehose stream that the Amazon SES API v2 sends email events to.</summary>
    [JsonPropertyName("deliveryStreamArn")]
    public string? DeliveryStreamArn { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM role that the Amazon SES API v2 uses to send email events to the Amazon Kinesis Data Firehose stream.</summary>
    [JsonPropertyName("iamRoleArn")]
    public string? IamRoleArn { get; set; }
}

/// <summary>An object that defines an Amazon Pinpoint project destination for email events. See pinpoint_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationStatusAtProviderEventDestinationPinpointDestination
{
    [JsonPropertyName("applicationArn")]
    public string? ApplicationArn { get; set; }
}

/// <summary>An object that defines an Amazon SNS destination for email events. See sns_destination Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationStatusAtProviderEventDestinationSnsDestination
{
    /// <summary>The Amazon Resource Name (ARN) of the Amazon SNS topic to publish email events to.</summary>
    [JsonPropertyName("topicArn")]
    public string? TopicArn { get; set; }
}

/// <summary>A name that identifies the event destination within the configuration set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationStatusAtProviderEventDestination
{
    /// <summary>An object that defines an Amazon CloudWatch destination for email events. See cloud_watch_destination Block for details.</summary>
    [JsonPropertyName("cloudWatchDestination")]
    public V1beta2ConfigurationSetEventDestinationStatusAtProviderEventDestinationCloudWatchDestination? CloudWatchDestination { get; set; }

    /// <summary>When the event destination is enabled, the specified event types are sent to the destinations. Default: false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>An object that defines an Amazon EventBridge destination for email events. You can use Amazon EventBridge to send notifications when certain email events occur. See event_bridge_destination Block for details.</summary>
    [JsonPropertyName("eventBridgeDestination")]
    public V1beta2ConfigurationSetEventDestinationStatusAtProviderEventDestinationEventBridgeDestination? EventBridgeDestination { get; set; }

    /// <summary>An object that defines an Amazon Kinesis Data Firehose destination for email events. See kinesis_firehose_destination Block for details.</summary>
    [JsonPropertyName("kinesisFirehoseDestination")]
    public V1beta2ConfigurationSetEventDestinationStatusAtProviderEventDestinationKinesisFirehoseDestination? KinesisFirehoseDestination { get; set; }

    /// <summary>- An array that specifies which events the Amazon SES API v2 should send to the destinations. Valid values: SEND, REJECT, BOUNCE, COMPLAINT, DELIVERY, OPEN, CLICK, RENDERING_FAILURE, DELIVERY_DELAY, SUBSCRIPTION.</summary>
    [JsonPropertyName("matchingEventTypes")]
    public IList<string>? MatchingEventTypes { get; set; }

    /// <summary>An object that defines an Amazon Pinpoint project destination for email events. See pinpoint_destination Block for details.</summary>
    [JsonPropertyName("pinpointDestination")]
    public V1beta2ConfigurationSetEventDestinationStatusAtProviderEventDestinationPinpointDestination? PinpointDestination { get; set; }

    /// <summary>An object that defines an Amazon SNS destination for email events. See sns_destination Block for details.</summary>
    [JsonPropertyName("snsDestination")]
    public V1beta2ConfigurationSetEventDestinationStatusAtProviderEventDestinationSnsDestination? SnsDestination { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationStatusAtProvider
{
    /// <summary>The name of the configuration set.</summary>
    [JsonPropertyName("configurationSetName")]
    public string? ConfigurationSetName { get; set; }

    /// <summary>A name that identifies the event destination within the configuration set.</summary>
    [JsonPropertyName("eventDestination")]
    public V1beta2ConfigurationSetEventDestinationStatusAtProviderEventDestination? EventDestination { get; set; }

    /// <summary>An object that defines the event destination. See event_destination Block for details.</summary>
    [JsonPropertyName("eventDestinationName")]
    public string? EventDestinationName { get; set; }

    /// <summary>A pipe-delimited string combining configuration_set_name and event_destination_name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationStatusConditions
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

/// <summary>ConfigurationSetEventDestinationStatus defines the observed state of ConfigurationSetEventDestination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ConfigurationSetEventDestinationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ConfigurationSetEventDestinationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ConfigurationSetEventDestinationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ConfigurationSetEventDestination is the Schema for the ConfigurationSetEventDestinations API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ConfigurationSetEventDestination : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ConfigurationSetEventDestinationSpec>, IStatus<V1beta2ConfigurationSetEventDestinationStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ConfigurationSetEventDestination";
    public const string KubeGroup = "sesv2.aws.upbound.io";
    public const string KubePluralName = "configurationseteventdestinations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sesv2.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ConfigurationSetEventDestination";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConfigurationSetEventDestinationSpec defines the desired state of ConfigurationSetEventDestination</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ConfigurationSetEventDestinationSpec Spec { get; set; }

    /// <summary>ConfigurationSetEventDestinationStatus defines the observed state of ConfigurationSetEventDestination.</summary>
    [JsonPropertyName("status")]
    public V1beta2ConfigurationSetEventDestinationStatus? Status { get; set; }
}
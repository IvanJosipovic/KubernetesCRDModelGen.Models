#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicebus.azure.upbound.io;
/// <summary>SubscriptionRule is the Schema for the SubscriptionRules API. Manages a ServiceBus Subscription Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SubscriptionRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta2SubscriptionRule>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SubscriptionRuleList";
    public const string KubeGroup = "servicebus.azure.upbound.io";
    public const string KubePluralName = "subscriptionrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicebus.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SubscriptionRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2SubscriptionRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2SubscriptionRule> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionRuleSpecDeletionPolicyEnum>))]
public enum V1beta2SubscriptionRuleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A correlation_filter block as documented below to be evaluated against a BrokeredMessage. Required when filter_type is set to CorrelationFilter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionRuleSpecForProviderCorrelationFilter
{
    /// <summary>Content type of the message.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifier of the correlation.</summary>
    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }

    /// <summary>Application specific label.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Identifier of the message.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>A list of user defined properties to be included in the filter. Specified as a map of name/value pairs.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Address of the queue to reply to.</summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>Session identifier to reply to.</summary>
    [JsonPropertyName("replyToSessionId")]
    public string? ReplyToSessionId { get; set; }

    /// <summary>Session identifier.</summary>
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    /// <summary>Address to send to.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionRuleSpecForProviderSubscriptionIdRefPolicyResolutionEnum>))]
public enum V1beta2SubscriptionRuleSpecForProviderSubscriptionIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionRuleSpecForProviderSubscriptionIdRefPolicyResolveEnum>))]
public enum V1beta2SubscriptionRuleSpecForProviderSubscriptionIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionRuleSpecForProviderSubscriptionIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionRuleSpecForProviderSubscriptionIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionRuleSpecForProviderSubscriptionIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subscription in servicebus to populate subscriptionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionRuleSpecForProviderSubscriptionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SubscriptionRuleSpecForProviderSubscriptionIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionRuleSpecForProviderSubscriptionIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SubscriptionRuleSpecForProviderSubscriptionIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionRuleSpecForProviderSubscriptionIdSelectorPolicyResolveEnum>))]
public enum V1beta2SubscriptionRuleSpecForProviderSubscriptionIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionRuleSpecForProviderSubscriptionIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionRuleSpecForProviderSubscriptionIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionRuleSpecForProviderSubscriptionIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subscription in servicebus to populate subscriptionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionRuleSpecForProviderSubscriptionIdSelector
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
    public V1beta2SubscriptionRuleSpecForProviderSubscriptionIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionRuleSpecForProvider
{
    /// <summary>Represents set of actions written in SQL language-based syntax that is performed against a BrokeredMessage.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A correlation_filter block as documented below to be evaluated against a BrokeredMessage. Required when filter_type is set to CorrelationFilter.</summary>
    [JsonPropertyName("correlationFilter")]
    public V1beta2SubscriptionRuleSpecForProviderCorrelationFilter? CorrelationFilter { get; set; }

    /// <summary>Type of filter to be applied to a BrokeredMessage. Possible values are SqlFilter and CorrelationFilter.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>Represents a filter written in SQL language-based syntax that to be evaluated against a BrokeredMessage. Required when filter_type is set to SqlFilter.</summary>
    [JsonPropertyName("sqlFilter")]
    public string? SqlFilter { get; set; }

    /// <summary>The ID of the ServiceBus Subscription in which this Rule should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>Reference to a Subscription in servicebus to populate subscriptionId.</summary>
    [JsonPropertyName("subscriptionIdRef")]
    public V1beta2SubscriptionRuleSpecForProviderSubscriptionIdRef? SubscriptionIdRef { get; set; }

    /// <summary>Selector for a Subscription in servicebus to populate subscriptionId.</summary>
    [JsonPropertyName("subscriptionIdSelector")]
    public V1beta2SubscriptionRuleSpecForProviderSubscriptionIdSelector? SubscriptionIdSelector { get; set; }
}

/// <summary>A correlation_filter block as documented below to be evaluated against a BrokeredMessage. Required when filter_type is set to CorrelationFilter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionRuleSpecInitProviderCorrelationFilter
{
    /// <summary>Content type of the message.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifier of the correlation.</summary>
    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }

    /// <summary>Application specific label.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Identifier of the message.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>A list of user defined properties to be included in the filter. Specified as a map of name/value pairs.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Address of the queue to reply to.</summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>Session identifier to reply to.</summary>
    [JsonPropertyName("replyToSessionId")]
    public string? ReplyToSessionId { get; set; }

    /// <summary>Session identifier.</summary>
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    /// <summary>Address to send to.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
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
public partial class V1beta2SubscriptionRuleSpecInitProvider
{
    /// <summary>Represents set of actions written in SQL language-based syntax that is performed against a BrokeredMessage.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A correlation_filter block as documented below to be evaluated against a BrokeredMessage. Required when filter_type is set to CorrelationFilter.</summary>
    [JsonPropertyName("correlationFilter")]
    public V1beta2SubscriptionRuleSpecInitProviderCorrelationFilter? CorrelationFilter { get; set; }

    /// <summary>Type of filter to be applied to a BrokeredMessage. Possible values are SqlFilter and CorrelationFilter.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>Represents a filter written in SQL language-based syntax that to be evaluated against a BrokeredMessage. Required when filter_type is set to SqlFilter.</summary>
    [JsonPropertyName("sqlFilter")]
    public string? SqlFilter { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionRuleSpecManagementPoliciesEnum>))]
public enum V1beta2SubscriptionRuleSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionRuleSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2SubscriptionRuleSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SubscriptionRuleSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2SubscriptionRuleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionRuleSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SubscriptionRuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SubscriptionRuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SubscriptionRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SubscriptionRuleSpec defines the desired state of SubscriptionRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionRuleSpec
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
    public V1beta2SubscriptionRuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2SubscriptionRuleSpecForProvider ForProvider { get; set; }

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
    public V1beta2SubscriptionRuleSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2SubscriptionRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2SubscriptionRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2SubscriptionRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A correlation_filter block as documented below to be evaluated against a BrokeredMessage. Required when filter_type is set to CorrelationFilter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionRuleStatusAtProviderCorrelationFilter
{
    /// <summary>Content type of the message.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Identifier of the correlation.</summary>
    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }

    /// <summary>Application specific label.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Identifier of the message.</summary>
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }

    /// <summary>A list of user defined properties to be included in the filter. Specified as a map of name/value pairs.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>Address of the queue to reply to.</summary>
    [JsonPropertyName("replyTo")]
    public string? ReplyTo { get; set; }

    /// <summary>Session identifier to reply to.</summary>
    [JsonPropertyName("replyToSessionId")]
    public string? ReplyToSessionId { get; set; }

    /// <summary>Session identifier.</summary>
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    /// <summary>Address to send to.</summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionRuleStatusAtProvider
{
    /// <summary>Represents set of actions written in SQL language-based syntax that is performed against a BrokeredMessage.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A correlation_filter block as documented below to be evaluated against a BrokeredMessage. Required when filter_type is set to CorrelationFilter.</summary>
    [JsonPropertyName("correlationFilter")]
    public V1beta2SubscriptionRuleStatusAtProviderCorrelationFilter? CorrelationFilter { get; set; }

    /// <summary>Type of filter to be applied to a BrokeredMessage. Possible values are SqlFilter and CorrelationFilter.</summary>
    [JsonPropertyName("filterType")]
    public string? FilterType { get; set; }

    /// <summary>The ServiceBus Subscription Rule ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Represents a filter written in SQL language-based syntax that to be evaluated against a BrokeredMessage. Required when filter_type is set to SqlFilter.</summary>
    [JsonPropertyName("sqlFilter")]
    public string? SqlFilter { get; set; }

    [JsonPropertyName("sqlFilterCompatibilityLevel")]
    public double? SqlFilterCompatibilityLevel { get; set; }

    /// <summary>The ID of the ServiceBus Subscription in which this Rule should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionRuleStatusConditions
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

/// <summary>SubscriptionRuleStatus defines the observed state of SubscriptionRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SubscriptionRuleStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2SubscriptionRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2SubscriptionRuleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SubscriptionRule is the Schema for the SubscriptionRules API. Manages a ServiceBus Subscription Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SubscriptionRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2SubscriptionRuleSpec>, IStatus<V1beta2SubscriptionRuleStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SubscriptionRule";
    public const string KubeGroup = "servicebus.azure.upbound.io";
    public const string KubePluralName = "subscriptionrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicebus.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SubscriptionRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SubscriptionRuleSpec defines the desired state of SubscriptionRule</summary>
    [JsonPropertyName("spec")]
    public required V1beta2SubscriptionRuleSpec Spec { get; set; }

    /// <summary>SubscriptionRuleStatus defines the observed state of SubscriptionRule.</summary>
    [JsonPropertyName("status")]
    public V1beta2SubscriptionRuleStatus? Status { get; set; }
}
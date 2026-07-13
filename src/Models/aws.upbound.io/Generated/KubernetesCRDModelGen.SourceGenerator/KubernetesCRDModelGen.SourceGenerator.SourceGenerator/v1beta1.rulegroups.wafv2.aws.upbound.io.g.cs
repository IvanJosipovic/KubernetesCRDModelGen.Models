#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.wafv2.aws.upbound.io;
/// <summary>RuleGroup is the Schema for the RuleGroups API. Creates a WAFv2 rule group resource. The &apos;rule&apos; field is not supported due to Kubernetes CRD size limitations with deeply nested fields. Please use the &apos;ruleJson&apos; field to define rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RuleGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RuleGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RuleGroupList";
    public const string KubeGroup = "wafv2.aws.upbound.io";
    public const string KubePluralName = "rulegroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "wafv2.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RuleGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1RuleGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1RuleGroup> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RuleGroupSpecDeletionPolicyEnum>))]
public enum V1beta1RuleGroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderCustomResponseBody
{
    /// <summary>The payload of the custom response.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The type of content in the payload that you are defining in the content argument. Valid values are TEXT_PLAIN, TEXT_HTML, or APPLICATION_JSON.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>A unique key identifying the custom response body. This is referenced by the custom_response_body_key argument in the Custom Response block.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Defines and enables Amazon CloudWatch metrics and web request sample collection. See Visibility Configuration below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProviderVisibilityConfig
{
    /// <summary>A boolean indicating whether the associated resource sends metrics to CloudWatch. For the list of available metrics, see AWS WAF Metrics.</summary>
    [JsonPropertyName("cloudwatchMetricsEnabled")]
    public bool? CloudwatchMetricsEnabled { get; set; }

    /// <summary>A friendly name of the CloudWatch metric. The name can contain only alphanumeric characters (A-Z, a-z, 0-9) hyphen(-) and underscore (_), with length from one to 128 characters. It can&apos;t contain whitespace or metric names reserved for AWS WAF, for example All and Default_Action.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>A boolean indicating whether AWS WAF should store a sampling of the web requests that match the rules. You can view the sampled requests through the AWS WAF console.</summary>
    [JsonPropertyName("sampledRequestsEnabled")]
    public bool? SampledRequestsEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecForProvider
{
    /// <summary>The web ACL capacity units (WCUs) required for this rule group. See here for general information and here for capacity specific information.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>Defines custom response bodies that can be referenced by custom_response actions. See Custom Response Body below for details.</summary>
    [JsonPropertyName("customResponseBody")]
    public IList<V1beta1RuleGroupSpecForProviderCustomResponseBody>? CustomResponseBody { get; set; }

    /// <summary>A friendly description of the rule group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A friendly name of the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>A raw JSON string used to define the rules for allowing, blocking, or counting web requests. When this field is used, Crossplane cannot observe changes in the configuration through the AWS API; therefore, drift detection cannot be performed. Refer to the AWS documentation for the expected JSON structure: https://docs.aws.amazon.com/waf/latest/APIReference/API_CreateRuleGroup.html</summary>
    [JsonPropertyName("ruleJson")]
    public string? RuleJson { get; set; }

    /// <summary>Specifies whether this is for an AWS CloudFront distribution or for a regional application. Valid values are CLOUDFRONT or REGIONAL. To work with CloudFront, you must also specify the region us-east-1 (N. Virginia) on the AWS provider.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Defines and enables Amazon CloudWatch metrics and web request sample collection. See Visibility Configuration below for details.</summary>
    [JsonPropertyName("visibilityConfig")]
    public V1beta1RuleGroupSpecForProviderVisibilityConfig? VisibilityConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderCustomResponseBody
{
    /// <summary>The payload of the custom response.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The type of content in the payload that you are defining in the content argument. Valid values are TEXT_PLAIN, TEXT_HTML, or APPLICATION_JSON.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>A unique key identifying the custom response body. This is referenced by the custom_response_body_key argument in the Custom Response block.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Defines and enables Amazon CloudWatch metrics and web request sample collection. See Visibility Configuration below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecInitProviderVisibilityConfig
{
    /// <summary>A boolean indicating whether the associated resource sends metrics to CloudWatch. For the list of available metrics, see AWS WAF Metrics.</summary>
    [JsonPropertyName("cloudwatchMetricsEnabled")]
    public bool? CloudwatchMetricsEnabled { get; set; }

    /// <summary>A friendly name of the CloudWatch metric. The name can contain only alphanumeric characters (A-Z, a-z, 0-9) hyphen(-) and underscore (_), with length from one to 128 characters. It can&apos;t contain whitespace or metric names reserved for AWS WAF, for example All and Default_Action.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>A boolean indicating whether AWS WAF should store a sampling of the web requests that match the rules. You can view the sampled requests through the AWS WAF console.</summary>
    [JsonPropertyName("sampledRequestsEnabled")]
    public bool? SampledRequestsEnabled { get; set; }
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
public partial class V1beta1RuleGroupSpecInitProvider
{
    /// <summary>The web ACL capacity units (WCUs) required for this rule group. See here for general information and here for capacity specific information.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>Defines custom response bodies that can be referenced by custom_response actions. See Custom Response Body below for details.</summary>
    [JsonPropertyName("customResponseBody")]
    public IList<V1beta1RuleGroupSpecInitProviderCustomResponseBody>? CustomResponseBody { get; set; }

    /// <summary>A friendly description of the rule group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A friendly name of the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A raw JSON string used to define the rules for allowing, blocking, or counting web requests. When this field is used, Crossplane cannot observe changes in the configuration through the AWS API; therefore, drift detection cannot be performed. Refer to the AWS documentation for the expected JSON structure: https://docs.aws.amazon.com/waf/latest/APIReference/API_CreateRuleGroup.html</summary>
    [JsonPropertyName("ruleJson")]
    public string? RuleJson { get; set; }

    /// <summary>Specifies whether this is for an AWS CloudFront distribution or for a regional application. Valid values are CLOUDFRONT or REGIONAL. To work with CloudFront, you must also specify the region us-east-1 (N. Virginia) on the AWS provider.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Defines and enables Amazon CloudWatch metrics and web request sample collection. See Visibility Configuration below for details.</summary>
    [JsonPropertyName("visibilityConfig")]
    public V1beta1RuleGroupSpecInitProviderVisibilityConfig? VisibilityConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RuleGroupSpecManagementPoliciesEnum>))]
public enum V1beta1RuleGroupSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RuleGroupSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1RuleGroupSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RuleGroupSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1RuleGroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1RuleGroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1RuleGroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RuleGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>RuleGroupSpec defines the desired state of RuleGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupSpec
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
    public V1beta1RuleGroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1RuleGroupSpecForProvider ForProvider { get; set; }

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
    public V1beta1RuleGroupSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1RuleGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RuleGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RuleGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderCustomResponseBody
{
    /// <summary>The payload of the custom response.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The type of content in the payload that you are defining in the content argument. Valid values are TEXT_PLAIN, TEXT_HTML, or APPLICATION_JSON.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>A unique key identifying the custom response body. This is referenced by the custom_response_body_key argument in the Custom Response block.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Defines and enables Amazon CloudWatch metrics and web request sample collection. See Visibility Configuration below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProviderVisibilityConfig
{
    /// <summary>A boolean indicating whether the associated resource sends metrics to CloudWatch. For the list of available metrics, see AWS WAF Metrics.</summary>
    [JsonPropertyName("cloudwatchMetricsEnabled")]
    public bool? CloudwatchMetricsEnabled { get; set; }

    /// <summary>A friendly name of the CloudWatch metric. The name can contain only alphanumeric characters (A-Z, a-z, 0-9) hyphen(-) and underscore (_), with length from one to 128 characters. It can&apos;t contain whitespace or metric names reserved for AWS WAF, for example All and Default_Action.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>A boolean indicating whether AWS WAF should store a sampling of the web requests that match the rules. You can view the sampled requests through the AWS WAF console.</summary>
    [JsonPropertyName("sampledRequestsEnabled")]
    public bool? SampledRequestsEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusAtProvider
{
    /// <summary>The ARN of the WAF rule group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The web ACL capacity units (WCUs) required for this rule group. See here for general information and here for capacity specific information.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>Defines custom response bodies that can be referenced by custom_response actions. See Custom Response Body below for details.</summary>
    [JsonPropertyName("customResponseBody")]
    public IList<V1beta1RuleGroupStatusAtProviderCustomResponseBody>? CustomResponseBody { get; set; }

    /// <summary>A friendly description of the rule group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the WAF rule group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("lockToken")]
    public string? LockToken { get; set; }

    /// <summary>A friendly name of the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A raw JSON string used to define the rules for allowing, blocking, or counting web requests. When this field is used, Crossplane cannot observe changes in the configuration through the AWS API; therefore, drift detection cannot be performed. Refer to the AWS documentation for the expected JSON structure: https://docs.aws.amazon.com/waf/latest/APIReference/API_CreateRuleGroup.html</summary>
    [JsonPropertyName("ruleJson")]
    public string? RuleJson { get; set; }

    /// <summary>Specifies whether this is for an AWS CloudFront distribution or for a regional application. Valid values are CLOUDFRONT or REGIONAL. To work with CloudFront, you must also specify the region us-east-1 (N. Virginia) on the AWS provider.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Defines and enables Amazon CloudWatch metrics and web request sample collection. See Visibility Configuration below for details.</summary>
    [JsonPropertyName("visibilityConfig")]
    public V1beta1RuleGroupStatusAtProviderVisibilityConfig? VisibilityConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatusConditions
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

/// <summary>RuleGroupStatus defines the observed state of RuleGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RuleGroupStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1RuleGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RuleGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RuleGroup is the Schema for the RuleGroups API. Creates a WAFv2 rule group resource. The &apos;rule&apos; field is not supported due to Kubernetes CRD size limitations with deeply nested fields. Please use the &apos;ruleJson&apos; field to define rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RuleGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RuleGroupSpec>, IStatus<V1beta1RuleGroupStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RuleGroup";
    public const string KubeGroup = "wafv2.aws.upbound.io";
    public const string KubePluralName = "rulegroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "wafv2.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RuleGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RuleGroupSpec defines the desired state of RuleGroup</summary>
    [JsonPropertyName("spec")]
    public required V1beta1RuleGroupSpec Spec { get; set; }

    /// <summary>RuleGroupStatus defines the observed state of RuleGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1RuleGroupStatus? Status { get; set; }
}
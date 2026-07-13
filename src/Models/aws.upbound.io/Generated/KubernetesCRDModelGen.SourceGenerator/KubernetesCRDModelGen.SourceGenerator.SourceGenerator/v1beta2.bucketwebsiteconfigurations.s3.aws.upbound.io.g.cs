#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.s3.aws.upbound.io;
/// <summary>BucketWebsiteConfiguration is the Schema for the BucketWebsiteConfigurations API. Provides an S3 bucket website configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BucketWebsiteConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta2BucketWebsiteConfiguration>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BucketWebsiteConfigurationList";
    public const string KubeGroup = "s3.aws.upbound.io";
    public const string KubePluralName = "bucketwebsiteconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "s3.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BucketWebsiteConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2BucketWebsiteConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2BucketWebsiteConfiguration> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketWebsiteConfigurationSpecDeletionPolicyEnum>))]
public enum V1beta2BucketWebsiteConfigurationSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketWebsiteConfigurationSpecForProviderBucketRefPolicyResolutionEnum>))]
public enum V1beta2BucketWebsiteConfigurationSpecForProviderBucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketWebsiteConfigurationSpecForProviderBucketRefPolicyResolveEnum>))]
public enum V1beta2BucketWebsiteConfigurationSpecForProviderBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecForProviderBucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketWebsiteConfigurationSpecForProviderBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketWebsiteConfigurationSpecForProviderBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecForProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BucketWebsiteConfigurationSpecForProviderBucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketWebsiteConfigurationSpecForProviderBucketSelectorPolicyResolutionEnum>))]
public enum V1beta2BucketWebsiteConfigurationSpecForProviderBucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketWebsiteConfigurationSpecForProviderBucketSelectorPolicyResolveEnum>))]
public enum V1beta2BucketWebsiteConfigurationSpecForProviderBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecForProviderBucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketWebsiteConfigurationSpecForProviderBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketWebsiteConfigurationSpecForProviderBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecForProviderBucketSelector
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
    public V1beta2BucketWebsiteConfigurationSpecForProviderBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>Name of the error document for the website. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecForProviderErrorDocument
{
    /// <summary>Object key name to use when a 4XX class error occurs.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Name of the index document for the website. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecForProviderIndexDocument
{
    /// <summary>
    /// Suffix that is appended to a request that is for a directory on the website endpoint.
    /// For example, if the suffix is index.html and you make a request to samplebucket/images/, the data that is returned will be for the object with the key name images/index.html.
    /// The suffix must not be empty and must not include a slash character.
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Redirect behavior for every request to this bucket&apos;s website endpoint. See below. Conflicts with error_document, index_document, and routing_rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecForProviderRedirectAllRequestsTo
{
    /// <summary>Name of the host where requests are redirected.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>Protocol to use when redirecting requests. The default is the protocol that is used in the original request. Valid values: http, https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Configuration block for describing a condition that must be met for the specified redirect to apply. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecForProviderRoutingRuleCondition
{
    /// <summary>HTTP error code when the redirect is applied. If specified with key_prefix_equals, then both must be true for the redirect to be applied.</summary>
    [JsonPropertyName("httpErrorCodeReturnedEquals")]
    public string? HttpErrorCodeReturnedEquals { get; set; }

    /// <summary>Object key name prefix when the redirect is applied. If specified with http_error_code_returned_equals, then both must be true for the redirect to be applied.</summary>
    [JsonPropertyName("keyPrefixEquals")]
    public string? KeyPrefixEquals { get; set; }
}

/// <summary>Configuration block for redirect information. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecForProviderRoutingRuleRedirect
{
    /// <summary>Name of the host where requests are redirected.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>HTTP redirect code to use on the response.</summary>
    [JsonPropertyName("httpRedirectCode")]
    public string? HttpRedirectCode { get; set; }

    /// <summary>Protocol to use when redirecting requests. The default is the protocol that is used in the original request. Valid values: http, https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Object key prefix to use in the redirect request. For example, to redirect requests for all pages with prefix docs/ (objects in the docs/ folder) to documents/, you can set a condition block with key_prefix_equals set to docs/ and in the redirect set replace_key_prefix_with to /documents.</summary>
    [JsonPropertyName("replaceKeyPrefixWith")]
    public string? ReplaceKeyPrefixWith { get; set; }

    /// <summary>Specific object key to use in the redirect request. For example, redirect request to error.html.</summary>
    [JsonPropertyName("replaceKeyWith")]
    public string? ReplaceKeyWith { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecForProviderRoutingRule
{
    /// <summary>Configuration block for describing a condition that must be met for the specified redirect to apply. See below.</summary>
    [JsonPropertyName("condition")]
    public V1beta2BucketWebsiteConfigurationSpecForProviderRoutingRuleCondition? Condition { get; set; }

    /// <summary>Configuration block for redirect information. See below.</summary>
    [JsonPropertyName("redirect")]
    public V1beta2BucketWebsiteConfigurationSpecForProviderRoutingRuleRedirect? Redirect { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecForProvider
{
    /// <summary>Name of the bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta2BucketWebsiteConfigurationSpecForProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta2BucketWebsiteConfigurationSpecForProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>Name of the error document for the website. See below.</summary>
    [JsonPropertyName("errorDocument")]
    public V1beta2BucketWebsiteConfigurationSpecForProviderErrorDocument? ErrorDocument { get; set; }

    /// <summary>Account ID of the expected bucket owner.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>Name of the index document for the website. See below.</summary>
    [JsonPropertyName("indexDocument")]
    public V1beta2BucketWebsiteConfigurationSpecForProviderIndexDocument? IndexDocument { get; set; }

    /// <summary>Redirect behavior for every request to this bucket&apos;s website endpoint. See below. Conflicts with error_document, index_document, and routing_rule.</summary>
    [JsonPropertyName("redirectAllRequestsTo")]
    public V1beta2BucketWebsiteConfigurationSpecForProviderRedirectAllRequestsTo? RedirectAllRequestsTo { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>List of rules that define when a redirect is applied and the redirect behavior. See below.</summary>
    [JsonPropertyName("routingRule")]
    public IList<V1beta2BucketWebsiteConfigurationSpecForProviderRoutingRule>? RoutingRule { get; set; }

    /// <summary>
    /// JSON array containing routing rules
    /// describing redirect behavior and when redirects are applied. Use this parameter when your routing rules contain empty String values (&quot; &quot;) as seen in the example above.
    /// </summary>
    [JsonPropertyName("routingRules")]
    public string? RoutingRules { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketWebsiteConfigurationSpecInitProviderBucketRefPolicyResolutionEnum>))]
public enum V1beta2BucketWebsiteConfigurationSpecInitProviderBucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketWebsiteConfigurationSpecInitProviderBucketRefPolicyResolveEnum>))]
public enum V1beta2BucketWebsiteConfigurationSpecInitProviderBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecInitProviderBucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketWebsiteConfigurationSpecInitProviderBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketWebsiteConfigurationSpecInitProviderBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecInitProviderBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BucketWebsiteConfigurationSpecInitProviderBucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketWebsiteConfigurationSpecInitProviderBucketSelectorPolicyResolutionEnum>))]
public enum V1beta2BucketWebsiteConfigurationSpecInitProviderBucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketWebsiteConfigurationSpecInitProviderBucketSelectorPolicyResolveEnum>))]
public enum V1beta2BucketWebsiteConfigurationSpecInitProviderBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecInitProviderBucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketWebsiteConfigurationSpecInitProviderBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketWebsiteConfigurationSpecInitProviderBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecInitProviderBucketSelector
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
    public V1beta2BucketWebsiteConfigurationSpecInitProviderBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>Name of the error document for the website. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecInitProviderErrorDocument
{
    /// <summary>Object key name to use when a 4XX class error occurs.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Name of the index document for the website. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecInitProviderIndexDocument
{
    /// <summary>
    /// Suffix that is appended to a request that is for a directory on the website endpoint.
    /// For example, if the suffix is index.html and you make a request to samplebucket/images/, the data that is returned will be for the object with the key name images/index.html.
    /// The suffix must not be empty and must not include a slash character.
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Redirect behavior for every request to this bucket&apos;s website endpoint. See below. Conflicts with error_document, index_document, and routing_rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecInitProviderRedirectAllRequestsTo
{
    /// <summary>Name of the host where requests are redirected.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>Protocol to use when redirecting requests. The default is the protocol that is used in the original request. Valid values: http, https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Configuration block for describing a condition that must be met for the specified redirect to apply. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecInitProviderRoutingRuleCondition
{
    /// <summary>HTTP error code when the redirect is applied. If specified with key_prefix_equals, then both must be true for the redirect to be applied.</summary>
    [JsonPropertyName("httpErrorCodeReturnedEquals")]
    public string? HttpErrorCodeReturnedEquals { get; set; }

    /// <summary>Object key name prefix when the redirect is applied. If specified with http_error_code_returned_equals, then both must be true for the redirect to be applied.</summary>
    [JsonPropertyName("keyPrefixEquals")]
    public string? KeyPrefixEquals { get; set; }
}

/// <summary>Configuration block for redirect information. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecInitProviderRoutingRuleRedirect
{
    /// <summary>Name of the host where requests are redirected.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>HTTP redirect code to use on the response.</summary>
    [JsonPropertyName("httpRedirectCode")]
    public string? HttpRedirectCode { get; set; }

    /// <summary>Protocol to use when redirecting requests. The default is the protocol that is used in the original request. Valid values: http, https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Object key prefix to use in the redirect request. For example, to redirect requests for all pages with prefix docs/ (objects in the docs/ folder) to documents/, you can set a condition block with key_prefix_equals set to docs/ and in the redirect set replace_key_prefix_with to /documents.</summary>
    [JsonPropertyName("replaceKeyPrefixWith")]
    public string? ReplaceKeyPrefixWith { get; set; }

    /// <summary>Specific object key to use in the redirect request. For example, redirect request to error.html.</summary>
    [JsonPropertyName("replaceKeyWith")]
    public string? ReplaceKeyWith { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecInitProviderRoutingRule
{
    /// <summary>Configuration block for describing a condition that must be met for the specified redirect to apply. See below.</summary>
    [JsonPropertyName("condition")]
    public V1beta2BucketWebsiteConfigurationSpecInitProviderRoutingRuleCondition? Condition { get; set; }

    /// <summary>Configuration block for redirect information. See below.</summary>
    [JsonPropertyName("redirect")]
    public V1beta2BucketWebsiteConfigurationSpecInitProviderRoutingRuleRedirect? Redirect { get; set; }
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
public partial class V1beta2BucketWebsiteConfigurationSpecInitProvider
{
    /// <summary>Name of the bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta2BucketWebsiteConfigurationSpecInitProviderBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta2BucketWebsiteConfigurationSpecInitProviderBucketSelector? BucketSelector { get; set; }

    /// <summary>Name of the error document for the website. See below.</summary>
    [JsonPropertyName("errorDocument")]
    public V1beta2BucketWebsiteConfigurationSpecInitProviderErrorDocument? ErrorDocument { get; set; }

    /// <summary>Account ID of the expected bucket owner.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>Name of the index document for the website. See below.</summary>
    [JsonPropertyName("indexDocument")]
    public V1beta2BucketWebsiteConfigurationSpecInitProviderIndexDocument? IndexDocument { get; set; }

    /// <summary>Redirect behavior for every request to this bucket&apos;s website endpoint. See below. Conflicts with error_document, index_document, and routing_rule.</summary>
    [JsonPropertyName("redirectAllRequestsTo")]
    public V1beta2BucketWebsiteConfigurationSpecInitProviderRedirectAllRequestsTo? RedirectAllRequestsTo { get; set; }

    /// <summary>List of rules that define when a redirect is applied and the redirect behavior. See below.</summary>
    [JsonPropertyName("routingRule")]
    public IList<V1beta2BucketWebsiteConfigurationSpecInitProviderRoutingRule>? RoutingRule { get; set; }

    /// <summary>
    /// JSON array containing routing rules
    /// describing redirect behavior and when redirects are applied. Use this parameter when your routing rules contain empty String values (&quot; &quot;) as seen in the example above.
    /// </summary>
    [JsonPropertyName("routingRules")]
    public string? RoutingRules { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketWebsiteConfigurationSpecManagementPoliciesEnum>))]
public enum V1beta2BucketWebsiteConfigurationSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketWebsiteConfigurationSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2BucketWebsiteConfigurationSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BucketWebsiteConfigurationSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2BucketWebsiteConfigurationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BucketWebsiteConfigurationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BucketWebsiteConfigurationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BucketWebsiteConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>BucketWebsiteConfigurationSpec defines the desired state of BucketWebsiteConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationSpec
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
    public V1beta2BucketWebsiteConfigurationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2BucketWebsiteConfigurationSpecForProvider ForProvider { get; set; }

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
    public V1beta2BucketWebsiteConfigurationSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2BucketWebsiteConfigurationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2BucketWebsiteConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2BucketWebsiteConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Name of the error document for the website. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationStatusAtProviderErrorDocument
{
    /// <summary>Object key name to use when a 4XX class error occurs.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Name of the index document for the website. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationStatusAtProviderIndexDocument
{
    /// <summary>
    /// Suffix that is appended to a request that is for a directory on the website endpoint.
    /// For example, if the suffix is index.html and you make a request to samplebucket/images/, the data that is returned will be for the object with the key name images/index.html.
    /// The suffix must not be empty and must not include a slash character.
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Redirect behavior for every request to this bucket&apos;s website endpoint. See below. Conflicts with error_document, index_document, and routing_rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationStatusAtProviderRedirectAllRequestsTo
{
    /// <summary>Name of the host where requests are redirected.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>Protocol to use when redirecting requests. The default is the protocol that is used in the original request. Valid values: http, https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Configuration block for describing a condition that must be met for the specified redirect to apply. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationStatusAtProviderRoutingRuleCondition
{
    /// <summary>HTTP error code when the redirect is applied. If specified with key_prefix_equals, then both must be true for the redirect to be applied.</summary>
    [JsonPropertyName("httpErrorCodeReturnedEquals")]
    public string? HttpErrorCodeReturnedEquals { get; set; }

    /// <summary>Object key name prefix when the redirect is applied. If specified with http_error_code_returned_equals, then both must be true for the redirect to be applied.</summary>
    [JsonPropertyName("keyPrefixEquals")]
    public string? KeyPrefixEquals { get; set; }
}

/// <summary>Configuration block for redirect information. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationStatusAtProviderRoutingRuleRedirect
{
    /// <summary>Name of the host where requests are redirected.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>HTTP redirect code to use on the response.</summary>
    [JsonPropertyName("httpRedirectCode")]
    public string? HttpRedirectCode { get; set; }

    /// <summary>Protocol to use when redirecting requests. The default is the protocol that is used in the original request. Valid values: http, https.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Object key prefix to use in the redirect request. For example, to redirect requests for all pages with prefix docs/ (objects in the docs/ folder) to documents/, you can set a condition block with key_prefix_equals set to docs/ and in the redirect set replace_key_prefix_with to /documents.</summary>
    [JsonPropertyName("replaceKeyPrefixWith")]
    public string? ReplaceKeyPrefixWith { get; set; }

    /// <summary>Specific object key to use in the redirect request. For example, redirect request to error.html.</summary>
    [JsonPropertyName("replaceKeyWith")]
    public string? ReplaceKeyWith { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationStatusAtProviderRoutingRule
{
    /// <summary>Configuration block for describing a condition that must be met for the specified redirect to apply. See below.</summary>
    [JsonPropertyName("condition")]
    public V1beta2BucketWebsiteConfigurationStatusAtProviderRoutingRuleCondition? Condition { get; set; }

    /// <summary>Configuration block for redirect information. See below.</summary>
    [JsonPropertyName("redirect")]
    public V1beta2BucketWebsiteConfigurationStatusAtProviderRoutingRuleRedirect? Redirect { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationStatusAtProvider
{
    /// <summary>Name of the bucket.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Name of the error document for the website. See below.</summary>
    [JsonPropertyName("errorDocument")]
    public V1beta2BucketWebsiteConfigurationStatusAtProviderErrorDocument? ErrorDocument { get; set; }

    /// <summary>Account ID of the expected bucket owner.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>The bucket or bucket and expected_bucket_owner separated by a comma (,) if the latter is provided.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the index document for the website. See below.</summary>
    [JsonPropertyName("indexDocument")]
    public V1beta2BucketWebsiteConfigurationStatusAtProviderIndexDocument? IndexDocument { get; set; }

    /// <summary>Redirect behavior for every request to this bucket&apos;s website endpoint. See below. Conflicts with error_document, index_document, and routing_rule.</summary>
    [JsonPropertyName("redirectAllRequestsTo")]
    public V1beta2BucketWebsiteConfigurationStatusAtProviderRedirectAllRequestsTo? RedirectAllRequestsTo { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>List of rules that define when a redirect is applied and the redirect behavior. See below.</summary>
    [JsonPropertyName("routingRule")]
    public IList<V1beta2BucketWebsiteConfigurationStatusAtProviderRoutingRule>? RoutingRule { get; set; }

    /// <summary>
    /// JSON array containing routing rules
    /// describing redirect behavior and when redirects are applied. Use this parameter when your routing rules contain empty String values (&quot; &quot;) as seen in the example above.
    /// </summary>
    [JsonPropertyName("routingRules")]
    public string? RoutingRules { get; set; }

    /// <summary>Domain of the website endpoint. This is used to create Route 53 alias records.</summary>
    [JsonPropertyName("websiteDomain")]
    public string? WebsiteDomain { get; set; }

    /// <summary>Website endpoint.</summary>
    [JsonPropertyName("websiteEndpoint")]
    public string? WebsiteEndpoint { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationStatusConditions
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

/// <summary>BucketWebsiteConfigurationStatus defines the observed state of BucketWebsiteConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BucketWebsiteConfigurationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2BucketWebsiteConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2BucketWebsiteConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BucketWebsiteConfiguration is the Schema for the BucketWebsiteConfigurations API. Provides an S3 bucket website configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BucketWebsiteConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2BucketWebsiteConfigurationSpec>, IStatus<V1beta2BucketWebsiteConfigurationStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BucketWebsiteConfiguration";
    public const string KubeGroup = "s3.aws.upbound.io";
    public const string KubePluralName = "bucketwebsiteconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "s3.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BucketWebsiteConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BucketWebsiteConfigurationSpec defines the desired state of BucketWebsiteConfiguration</summary>
    [JsonPropertyName("spec")]
    public required V1beta2BucketWebsiteConfigurationSpec Spec { get; set; }

    /// <summary>BucketWebsiteConfigurationStatus defines the observed state of BucketWebsiteConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta2BucketWebsiteConfigurationStatus? Status { get; set; }
}
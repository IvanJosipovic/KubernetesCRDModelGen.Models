#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.route53recoveryreadiness.aws.m.upbound.io;
/// <summary>ResourceSet is the Schema for the ResourceSets API. Provides an AWS Route 53 Recovery Readiness Resource Set</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ResourceSetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ResourceSet>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ResourceSetList";
    public const string KubeGroup = "route53recoveryreadiness.aws.m.upbound.io";
    public const string KubePluralName = "resourcesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "route53recoveryreadiness.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourceSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ResourceSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ResourceSet> Items { get; set; }
}

/// <summary>NLB resource a DNS Target Resource points to. Required if r53_resource is not set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecForProviderResourcesDnsTargetResourceTargetResourceNlbResource
{
    /// <summary>NLB resource ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>Route53 resource a DNS Target Resource record points to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecForProviderResourcesDnsTargetResourceTargetResourceR53Resource
{
    /// <summary>Domain name that is targeted.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Resource record set ID that is targeted.</summary>
    [JsonPropertyName("recordSetId")]
    public string? RecordSetId { get; set; }
}

/// <summary>Target resource the R53 record specified with the above params points to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecForProviderResourcesDnsTargetResourceTargetResource
{
    /// <summary>NLB resource a DNS Target Resource points to. Required if r53_resource is not set.</summary>
    [JsonPropertyName("nlbResource")]
    public V1beta1ResourceSetSpecForProviderResourcesDnsTargetResourceTargetResourceNlbResource? NlbResource { get; set; }

    /// <summary>Route53 resource a DNS Target Resource record points to.</summary>
    [JsonPropertyName("r53Resource")]
    public V1beta1ResourceSetSpecForProviderResourcesDnsTargetResourceTargetResourceR53Resource? R53Resource { get; set; }
}

/// <summary>Component for DNS/Routing Control Readiness Checks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecForProviderResourcesDnsTargetResource
{
    /// <summary>DNS Name that acts as the ingress point to a portion of application.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Hosted Zone ARN that contains the DNS record with the provided name of target resource.</summary>
    [JsonPropertyName("hostedZoneArn")]
    public string? HostedZoneArn { get; set; }

    /// <summary>Route53 record set id to uniquely identify a record given a domain_name and a record_type.</summary>
    [JsonPropertyName("recordSetId")]
    public string? RecordSetId { get; set; }

    /// <summary>Type of DNS Record of target resource.</summary>
    [JsonPropertyName("recordType")]
    public string? RecordType { get; set; }

    /// <summary>Target resource the R53 record specified with the above params points to.</summary>
    [JsonPropertyName("targetResource")]
    public V1beta1ResourceSetSpecForProviderResourcesDnsTargetResourceTargetResource? TargetResource { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceSetSpecForProviderResourcesResourceArnRefPolicyResolutionEnum>))]
public enum V1beta1ResourceSetSpecForProviderResourcesResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceSetSpecForProviderResourcesResourceArnRefPolicyResolveEnum>))]
public enum V1beta1ResourceSetSpecForProviderResourcesResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecForProviderResourcesResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ResourceSetSpecForProviderResourcesResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ResourceSetSpecForProviderResourcesResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MetricAlarm in cloudwatch to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecForProviderResourcesResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceSetSpecForProviderResourcesResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceSetSpecForProviderResourcesResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ResourceSetSpecForProviderResourcesResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceSetSpecForProviderResourcesResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta1ResourceSetSpecForProviderResourcesResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecForProviderResourcesResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ResourceSetSpecForProviderResourcesResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ResourceSetSpecForProviderResourcesResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MetricAlarm in cloudwatch to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecForProviderResourcesResourceArnSelector
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
    public V1beta1ResourceSetSpecForProviderResourcesResourceArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecForProviderResources
{
    /// <summary>Component for DNS/Routing Control Readiness Checks.</summary>
    [JsonPropertyName("dnsTargetResource")]
    public V1beta1ResourceSetSpecForProviderResourcesDnsTargetResource? DnsTargetResource { get; set; }

    /// <summary>Recovery group ARN or cell ARN that contains this resource set.</summary>
    [JsonPropertyName("readinessScopes")]
    public IList<string>? ReadinessScopes { get; set; }

    /// <summary>ARN of the resource.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a MetricAlarm in cloudwatch to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1ResourceSetSpecForProviderResourcesResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a MetricAlarm in cloudwatch to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1ResourceSetSpecForProviderResourcesResourceArnSelector? ResourceArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecForProvider
{
    /// <summary>Type of the resources in the resource set.</summary>
    [JsonPropertyName("resourceSetType")]
    public string? ResourceSetType { get; set; }

    /// <summary>List of resources to add to this resource set. See below.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1ResourceSetSpecForProviderResources>? Resources { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>NLB resource a DNS Target Resource points to. Required if r53_resource is not set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecInitProviderResourcesDnsTargetResourceTargetResourceNlbResource
{
    /// <summary>NLB resource ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>Route53 resource a DNS Target Resource record points to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecInitProviderResourcesDnsTargetResourceTargetResourceR53Resource
{
    /// <summary>Domain name that is targeted.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Resource record set ID that is targeted.</summary>
    [JsonPropertyName("recordSetId")]
    public string? RecordSetId { get; set; }
}

/// <summary>Target resource the R53 record specified with the above params points to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecInitProviderResourcesDnsTargetResourceTargetResource
{
    /// <summary>NLB resource a DNS Target Resource points to. Required if r53_resource is not set.</summary>
    [JsonPropertyName("nlbResource")]
    public V1beta1ResourceSetSpecInitProviderResourcesDnsTargetResourceTargetResourceNlbResource? NlbResource { get; set; }

    /// <summary>Route53 resource a DNS Target Resource record points to.</summary>
    [JsonPropertyName("r53Resource")]
    public V1beta1ResourceSetSpecInitProviderResourcesDnsTargetResourceTargetResourceR53Resource? R53Resource { get; set; }
}

/// <summary>Component for DNS/Routing Control Readiness Checks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecInitProviderResourcesDnsTargetResource
{
    /// <summary>DNS Name that acts as the ingress point to a portion of application.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Hosted Zone ARN that contains the DNS record with the provided name of target resource.</summary>
    [JsonPropertyName("hostedZoneArn")]
    public string? HostedZoneArn { get; set; }

    /// <summary>Route53 record set id to uniquely identify a record given a domain_name and a record_type.</summary>
    [JsonPropertyName("recordSetId")]
    public string? RecordSetId { get; set; }

    /// <summary>Type of DNS Record of target resource.</summary>
    [JsonPropertyName("recordType")]
    public string? RecordType { get; set; }

    /// <summary>Target resource the R53 record specified with the above params points to.</summary>
    [JsonPropertyName("targetResource")]
    public V1beta1ResourceSetSpecInitProviderResourcesDnsTargetResourceTargetResource? TargetResource { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceSetSpecInitProviderResourcesResourceArnRefPolicyResolutionEnum>))]
public enum V1beta1ResourceSetSpecInitProviderResourcesResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceSetSpecInitProviderResourcesResourceArnRefPolicyResolveEnum>))]
public enum V1beta1ResourceSetSpecInitProviderResourcesResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecInitProviderResourcesResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ResourceSetSpecInitProviderResourcesResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ResourceSetSpecInitProviderResourcesResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MetricAlarm in cloudwatch to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecInitProviderResourcesResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourceSetSpecInitProviderResourcesResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceSetSpecInitProviderResourcesResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ResourceSetSpecInitProviderResourcesResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceSetSpecInitProviderResourcesResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta1ResourceSetSpecInitProviderResourcesResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecInitProviderResourcesResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ResourceSetSpecInitProviderResourcesResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ResourceSetSpecInitProviderResourcesResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MetricAlarm in cloudwatch to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecInitProviderResourcesResourceArnSelector
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
    public V1beta1ResourceSetSpecInitProviderResourcesResourceArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpecInitProviderResources
{
    /// <summary>Component for DNS/Routing Control Readiness Checks.</summary>
    [JsonPropertyName("dnsTargetResource")]
    public V1beta1ResourceSetSpecInitProviderResourcesDnsTargetResource? DnsTargetResource { get; set; }

    /// <summary>Recovery group ARN or cell ARN that contains this resource set.</summary>
    [JsonPropertyName("readinessScopes")]
    public IList<string>? ReadinessScopes { get; set; }

    /// <summary>ARN of the resource.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a MetricAlarm in cloudwatch to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta1ResourceSetSpecInitProviderResourcesResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a MetricAlarm in cloudwatch to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta1ResourceSetSpecInitProviderResourcesResourceArnSelector? ResourceArnSelector { get; set; }
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
public partial class V1beta1ResourceSetSpecInitProvider
{
    /// <summary>Type of the resources in the resource set.</summary>
    [JsonPropertyName("resourceSetType")]
    public string? ResourceSetType { get; set; }

    /// <summary>List of resources to add to this resource set. See below.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1ResourceSetSpecInitProviderResources>? Resources { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ResourceSetSpecManagementPoliciesEnum>))]
public enum V1beta1ResourceSetSpecManagementPoliciesEnum
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
public partial class V1beta1ResourceSetSpecProviderConfigRef
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
public partial class V1beta1ResourceSetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ResourceSetSpec defines the desired state of ResourceSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1ResourceSetSpecForProvider ForProvider { get; set; }

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
    public V1beta1ResourceSetSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ResourceSetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ResourceSetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ResourceSetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>NLB resource a DNS Target Resource points to. Required if r53_resource is not set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetStatusAtProviderResourcesDnsTargetResourceTargetResourceNlbResource
{
    /// <summary>NLB resource ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>Route53 resource a DNS Target Resource record points to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetStatusAtProviderResourcesDnsTargetResourceTargetResourceR53Resource
{
    /// <summary>Domain name that is targeted.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Resource record set ID that is targeted.</summary>
    [JsonPropertyName("recordSetId")]
    public string? RecordSetId { get; set; }
}

/// <summary>Target resource the R53 record specified with the above params points to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetStatusAtProviderResourcesDnsTargetResourceTargetResource
{
    /// <summary>NLB resource a DNS Target Resource points to. Required if r53_resource is not set.</summary>
    [JsonPropertyName("nlbResource")]
    public V1beta1ResourceSetStatusAtProviderResourcesDnsTargetResourceTargetResourceNlbResource? NlbResource { get; set; }

    /// <summary>Route53 resource a DNS Target Resource record points to.</summary>
    [JsonPropertyName("r53Resource")]
    public V1beta1ResourceSetStatusAtProviderResourcesDnsTargetResourceTargetResourceR53Resource? R53Resource { get; set; }
}

/// <summary>Component for DNS/Routing Control Readiness Checks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetStatusAtProviderResourcesDnsTargetResource
{
    /// <summary>DNS Name that acts as the ingress point to a portion of application.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Hosted Zone ARN that contains the DNS record with the provided name of target resource.</summary>
    [JsonPropertyName("hostedZoneArn")]
    public string? HostedZoneArn { get; set; }

    /// <summary>Route53 record set id to uniquely identify a record given a domain_name and a record_type.</summary>
    [JsonPropertyName("recordSetId")]
    public string? RecordSetId { get; set; }

    /// <summary>Type of DNS Record of target resource.</summary>
    [JsonPropertyName("recordType")]
    public string? RecordType { get; set; }

    /// <summary>Target resource the R53 record specified with the above params points to.</summary>
    [JsonPropertyName("targetResource")]
    public V1beta1ResourceSetStatusAtProviderResourcesDnsTargetResourceTargetResource? TargetResource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetStatusAtProviderResources
{
    /// <summary>Unique identified for DNS Target Resources, use for readiness checks.</summary>
    [JsonPropertyName("componentId")]
    public string? ComponentId { get; set; }

    /// <summary>Component for DNS/Routing Control Readiness Checks.</summary>
    [JsonPropertyName("dnsTargetResource")]
    public V1beta1ResourceSetStatusAtProviderResourcesDnsTargetResource? DnsTargetResource { get; set; }

    /// <summary>Recovery group ARN or cell ARN that contains this resource set.</summary>
    [JsonPropertyName("readinessScopes")]
    public IList<string>? ReadinessScopes { get; set; }

    /// <summary>ARN of the resource.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetStatusAtProvider
{
    /// <summary>ARN of the resource set</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Type of the resources in the resource set.</summary>
    [JsonPropertyName("resourceSetType")]
    public string? ResourceSetType { get; set; }

    /// <summary>List of resources to add to this resource set. See below.</summary>
    [JsonPropertyName("resources")]
    public IList<V1beta1ResourceSetStatusAtProviderResources>? Resources { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetStatusConditions
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

/// <summary>ResourceSetStatus defines the observed state of ResourceSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourceSetStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ResourceSetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ResourceSetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ResourceSet is the Schema for the ResourceSets API. Provides an AWS Route 53 Recovery Readiness Resource Set</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ResourceSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ResourceSetSpec>, IStatus<V1beta1ResourceSetStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ResourceSet";
    public const string KubeGroup = "route53recoveryreadiness.aws.m.upbound.io";
    public const string KubePluralName = "resourcesets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "route53recoveryreadiness.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourceSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ResourceSetSpec defines the desired state of ResourceSet</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ResourceSetSpec Spec { get; set; }

    /// <summary>ResourceSetStatus defines the observed state of ResourceSet.</summary>
    [JsonPropertyName("status")]
    public V1beta1ResourceSetStatus? Status { get; set; }
}
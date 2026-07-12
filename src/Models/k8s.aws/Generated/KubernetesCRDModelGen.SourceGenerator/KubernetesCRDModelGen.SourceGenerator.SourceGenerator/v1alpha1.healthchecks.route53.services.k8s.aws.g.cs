#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.route53.services.k8s.aws;
/// <summary>HealthCheck is the Schema for the HealthChecks API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1HealthCheckList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1HealthCheck>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "HealthCheckList";
    public const string KubeGroup = "route53.services.k8s.aws";
    public const string KubePluralName = "healthchecks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "route53.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HealthCheckList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1HealthCheck objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1HealthCheck> Items { get; set; }
}

/// <summary>
/// A complex type that identifies the CloudWatch alarm that you want Amazon
/// Route 53 health checkers to use to determine whether the specified health
/// check is healthy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthCheckSpecHealthCheckConfigAlarmIdentifier
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>A complex type that contains settings for a new health check.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthCheckSpecHealthCheckConfig
{
    /// <summary>
    /// A complex type that identifies the CloudWatch alarm that you want Amazon
    /// Route 53 health checkers to use to determine whether the specified health
    /// check is healthy.
    /// </summary>
    [JsonPropertyName("alarmIdentifier")]
    public V1alpha1HealthCheckSpecHealthCheckConfigAlarmIdentifier? AlarmIdentifier { get; set; }

    [JsonPropertyName("childHealthChecks")]
    public IList<string>? ChildHealthChecks { get; set; }

    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    [JsonPropertyName("enableSNI")]
    public bool? EnableSNI { get; set; }

    [JsonPropertyName("failureThreshold")]
    public long? FailureThreshold { get; set; }

    [JsonPropertyName("fullyQualifiedDomainName")]
    public string? FullyQualifiedDomainName { get; set; }

    [JsonPropertyName("healthThreshold")]
    public long? HealthThreshold { get; set; }

    [JsonPropertyName("insufficientDataHealthStatus")]
    public string? InsufficientDataHealthStatus { get; set; }

    [JsonPropertyName("inverted")]
    public bool? Inverted { get; set; }

    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    [JsonPropertyName("measureLatency")]
    public bool? MeasureLatency { get; set; }

    [JsonPropertyName("port")]
    public long? Port { get; set; }

    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }

    [JsonPropertyName("requestInterval")]
    public long? RequestInterval { get; set; }

    [JsonPropertyName("resourcePath")]
    public string? ResourcePath { get; set; }

    [JsonPropertyName("routingControlARN")]
    public string? RoutingControlARN { get; set; }

    [JsonPropertyName("searchString")]
    public string? SearchString { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A complex type that contains information about a tag that you want to add
/// or edit for the specified health check or hosted zone.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthCheckSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// HealthCheckSpec defines the desired state of HealthCheck.
/// 
/// A complex type that contains information about one health check that is associated
/// with the current Amazon Web Services account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthCheckSpec
{
    /// <summary>A complex type that contains settings for a new health check.</summary>
    [JsonPropertyName("healthCheckConfig")]
    public required V1alpha1HealthCheckSpecHealthCheckConfig HealthCheckConfig { get; set; }

    /// <summary>
    /// A complex type that contains a list of the tags that you want to add to the
    /// specified health check or hosted zone and/or the tags that you want to edit
    /// Value for.
    /// 
    /// You can add a maximum of 10 tags to a health check or a hosted zone.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1HealthCheckSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthCheckStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// For the metric that the CloudWatch alarm is associated with, a complex type
/// that contains information about one dimension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthCheckStatusCloudWatchAlarmConfigurationDimensions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// A complex type that contains information about the CloudWatch alarm that
/// Amazon Route 53 is monitoring for this health check.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthCheckStatusCloudWatchAlarmConfiguration
{
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    [JsonPropertyName("dimensions")]
    public IList<V1alpha1HealthCheckStatusCloudWatchAlarmConfigurationDimensions>? Dimensions { get; set; }

    [JsonPropertyName("evaluationPeriods")]
    public long? EvaluationPeriods { get; set; }

    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("period")]
    public long? Period { get; set; }

    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthCheckStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// If the health check was created by another service, the service that created
/// the health check. When a health check is created by another service, you
/// can&apos;t edit or delete it using Amazon Route 53.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthCheckStatusLinkedService
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("servicePrincipal")]
    public string? ServicePrincipal { get; set; }
}

/// <summary>HealthCheckStatus defines the observed state of HealthCheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthCheckStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1HealthCheckStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>A unique string that you specified when you created the health check.</summary>
    [JsonPropertyName("callerReference")]
    public string? CallerReference { get; set; }

    /// <summary>
    /// A complex type that contains information about the CloudWatch alarm that
    /// Amazon Route 53 is monitoring for this health check.
    /// </summary>
    [JsonPropertyName("cloudWatchAlarmConfiguration")]
    public V1alpha1HealthCheckStatusCloudWatchAlarmConfiguration? CloudWatchAlarmConfiguration { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1HealthCheckStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The version of the health check. You can optionally pass this value in a
    /// call to UpdateHealthCheck to prevent overwriting another change to the health
    /// check.
    /// </summary>
    [JsonPropertyName("healthCheckVersion")]
    public long? HealthCheckVersion { get; set; }

    /// <summary>
    /// The identifier that Amazon Route 53 assigned to the health check when you
    /// created it. When you add or update a resource record set, you use this value
    /// to specify which health check to use. The value can be up to 64 characters
    /// long.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// If the health check was created by another service, the service that created
    /// the health check. When a health check is created by another service, you
    /// can&apos;t edit or delete it using Amazon Route 53.
    /// </summary>
    [JsonPropertyName("linkedService")]
    public V1alpha1HealthCheckStatusLinkedService? LinkedService { get; set; }
}

/// <summary>HealthCheck is the Schema for the HealthChecks API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1HealthCheck : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1HealthCheckSpec?>, IStatus<V1alpha1HealthCheckStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "HealthCheck";
    public const string KubeGroup = "route53.services.k8s.aws";
    public const string KubePluralName = "healthchecks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "route53.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HealthCheck";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// HealthCheckSpec defines the desired state of HealthCheck.
    /// 
    /// A complex type that contains information about one health check that is associated
    /// with the current Amazon Web Services account.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1HealthCheckSpec? Spec { get; set; }

    /// <summary>HealthCheckStatus defines the observed state of HealthCheck</summary>
    [JsonPropertyName("status")]
    public V1alpha1HealthCheckStatus? Status { get; set; }
}
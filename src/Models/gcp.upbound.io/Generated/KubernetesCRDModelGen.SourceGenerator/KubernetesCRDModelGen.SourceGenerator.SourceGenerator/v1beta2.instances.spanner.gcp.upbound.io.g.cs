#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.spanner.gcp.upbound.io;
/// <summary>Instance is the Schema for the Instances API. An isolated set of Cloud Spanner resources on which databases can be hosted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2InstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Instance>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "InstanceList";
    public const string KubeGroup = "spanner.gcp.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "spanner.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Instance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Instance> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecDeletionPolicyEnum>))]
public enum V1beta2InstanceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderAutoscalingConfigAsymmetricAutoscalingOptionsOverridesAutoscalingLimits
{
    /// <summary>The maximum number of nodes for this specific replica.</summary>
    [JsonPropertyName("maxNodes")]
    public double? MaxNodes { get; set; }

    /// <summary>The minimum number of nodes for this specific replica.</summary>
    [JsonPropertyName("minNodes")]
    public double? MinNodes { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderAutoscalingConfigAsymmetricAutoscalingOptionsOverrides
{
    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscalingLimits")]
    public V1beta2InstanceSpecForProviderAutoscalingConfigAsymmetricAutoscalingOptionsOverridesAutoscalingLimits? AutoscalingLimits { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderAutoscalingConfigAsymmetricAutoscalingOptionsReplicaSelection
{
    /// <summary>The location of the replica to apply asymmetric autoscaling options.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderAutoscalingConfigAsymmetricAutoscalingOptions
{
    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("overrides")]
    public V1beta2InstanceSpecForProviderAutoscalingConfigAsymmetricAutoscalingOptionsOverrides? Overrides { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replicaSelection")]
    public V1beta2InstanceSpecForProviderAutoscalingConfigAsymmetricAutoscalingOptionsReplicaSelection? ReplicaSelection { get; set; }
}

/// <summary>
/// Defines scale in controls to reduce the risk of response latency
/// and outages due to abrupt scale-in events. Users can define the minimum and
/// maximum compute capacity allocated to the instance, and the autoscaler will
/// only scale within that range. Users can either use nodes or processing
/// units to specify the limits, but should use the same unit to set both the
/// min_limit and max_limit.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderAutoscalingConfigAutoscalingLimits
{
    /// <summary>The maximum number of nodes for this specific replica.</summary>
    [JsonPropertyName("maxNodes")]
    public double? MaxNodes { get; set; }

    /// <summary>
    /// Specifies maximum number of processing units allocated to the instance.
    /// If set, this number should be multiples of 1000 and be greater than or equal to
    /// min_processing_units.
    /// </summary>
    [JsonPropertyName("maxProcessingUnits")]
    public double? MaxProcessingUnits { get; set; }

    /// <summary>The minimum number of nodes for this specific replica.</summary>
    [JsonPropertyName("minNodes")]
    public double? MinNodes { get; set; }

    /// <summary>
    /// Specifies minimum number of processing units allocated to the instance.
    /// If set, this number should be multiples of 1000.
    /// </summary>
    [JsonPropertyName("minProcessingUnits")]
    public double? MinProcessingUnits { get; set; }
}

/// <summary>
/// Defines scale in controls to reduce the risk of response latency
/// and outages due to abrupt scale-in events
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderAutoscalingConfigAutoscalingTargets
{
    /// <summary>
    /// Specifies the target high priority cpu utilization percentage that the autoscaler
    /// should be trying to achieve for the instance.
    /// This number is on a scale from 0 (no utilization) to 100 (full utilization)..
    /// </summary>
    [JsonPropertyName("highPriorityCpuUtilizationPercent")]
    public double? HighPriorityCpuUtilizationPercent { get; set; }

    /// <summary>
    /// Specifies the target storage utilization percentage that the autoscaler
    /// should be trying to achieve for the instance.
    /// This number is on a scale from 0 (no utilization) to 100 (full utilization).
    /// </summary>
    [JsonPropertyName("storageUtilizationPercent")]
    public double? StorageUtilizationPercent { get; set; }
}

/// <summary>
/// The autoscaling configuration. Autoscaling is enabled if this field is set.
/// When autoscaling is enabled, num_nodes and processing_units are treated as,
/// OUTPUT_ONLY fields and reflect the current compute capacity allocated to
/// the instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderAutoscalingConfig
{
    /// <summary>
    /// Asymmetric autoscaling options for specific replicas.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("asymmetricAutoscalingOptions")]
    public IList<V1beta2InstanceSpecForProviderAutoscalingConfigAsymmetricAutoscalingOptions>? AsymmetricAutoscalingOptions { get; set; }

    /// <summary>
    /// Defines scale in controls to reduce the risk of response latency
    /// and outages due to abrupt scale-in events. Users can define the minimum and
    /// maximum compute capacity allocated to the instance, and the autoscaler will
    /// only scale within that range. Users can either use nodes or processing
    /// units to specify the limits, but should use the same unit to set both the
    /// min_limit and max_limit.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscalingLimits")]
    public V1beta2InstanceSpecForProviderAutoscalingConfigAutoscalingLimits? AutoscalingLimits { get; set; }

    /// <summary>
    /// Defines scale in controls to reduce the risk of response latency
    /// and outages due to abrupt scale-in events
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscalingTargets")]
    public V1beta2InstanceSpecForProviderAutoscalingConfigAutoscalingTargets? AutoscalingTargets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProvider
{
    /// <summary>
    /// The autoscaling configuration. Autoscaling is enabled if this field is set.
    /// When autoscaling is enabled, num_nodes and processing_units are treated as,
    /// OUTPUT_ONLY fields and reflect the current compute capacity allocated to
    /// the instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscalingConfig")]
    public V1beta2InstanceSpecForProviderAutoscalingConfig? AutoscalingConfig { get; set; }

    /// <summary>
    /// The name of the instance&apos;s configuration (similar but not
    /// quite the same as a region) which defines the geographic placement and
    /// replication of your databases in this instance. It determines where your data
    /// is stored. Values are typically of the form regional-europe-west1 , us-central etc.
    /// In order to obtain a valid list please consult the
    /// Configuration section of the docs.
    /// </summary>
    [JsonPropertyName("config")]
    public string? Config { get; set; }

    /// <summary>
    /// Controls the default backup behavior for new databases within the instance.
    /// Note that AUTOMATIC is not permitted for free instances, as backups and backup schedules are not allowed for free instances.
    /// if unset or NONE, no default backup schedule will be created for new databases within the instance.
    /// Possible values are: NONE, AUTOMATIC.
    /// </summary>
    [JsonPropertyName("defaultBackupScheduleType")]
    public string? DefaultBackupScheduleType { get; set; }

    /// <summary>
    /// The descriptive name for this instance as it appears in UIs. Must be
    /// unique per project and between 4 and 30 characters in length.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// The edition selected for this instance. Different editions provide different capabilities at different price points.
    /// Possible values are: EDITION_UNSPECIFIED, STANDARD, ENTERPRISE, ENTERPRISE_PLUS.
    /// </summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>
    /// When deleting a spanner instance, this boolean option will delete all backups of this instance.
    /// This must be set to true if you created a backup manually in the console.
    /// </summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>
    /// The type of this instance. The type can be used to distinguish product variants, that can affect aspects like:
    /// usage restrictions, quotas and billing. Currently this is used to distinguish FREE_INSTANCE vs PROVISIONED instances.
    /// When configured as FREE_INSTANCE, the field edition should not be configured.
    /// Possible values are: PROVISIONED, FREE_INSTANCE.
    /// </summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>
    /// An object containing a list of &quot;key&quot;: value pairs.
    /// Example: { &quot;name&quot;: &quot;wrench&quot;, &quot;mass&quot;: &quot;1.3kg&quot;, &quot;count&quot;: &quot;3&quot; }.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The number of nodes allocated to this instance.</summary>
    [JsonPropertyName("numNodes")]
    public double? NumNodes { get; set; }

    /// <summary>The number of processing units allocated to this instance.</summary>
    [JsonPropertyName("processingUnits")]
    public double? ProcessingUnits { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderAutoscalingConfigAsymmetricAutoscalingOptionsOverridesAutoscalingLimits
{
    /// <summary>The maximum number of nodes for this specific replica.</summary>
    [JsonPropertyName("maxNodes")]
    public double? MaxNodes { get; set; }

    /// <summary>The minimum number of nodes for this specific replica.</summary>
    [JsonPropertyName("minNodes")]
    public double? MinNodes { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderAutoscalingConfigAsymmetricAutoscalingOptionsOverrides
{
    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscalingLimits")]
    public V1beta2InstanceSpecInitProviderAutoscalingConfigAsymmetricAutoscalingOptionsOverridesAutoscalingLimits? AutoscalingLimits { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderAutoscalingConfigAsymmetricAutoscalingOptionsReplicaSelection
{
    /// <summary>The location of the replica to apply asymmetric autoscaling options.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderAutoscalingConfigAsymmetricAutoscalingOptions
{
    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("overrides")]
    public V1beta2InstanceSpecInitProviderAutoscalingConfigAsymmetricAutoscalingOptionsOverrides? Overrides { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replicaSelection")]
    public V1beta2InstanceSpecInitProviderAutoscalingConfigAsymmetricAutoscalingOptionsReplicaSelection? ReplicaSelection { get; set; }
}

/// <summary>
/// Defines scale in controls to reduce the risk of response latency
/// and outages due to abrupt scale-in events. Users can define the minimum and
/// maximum compute capacity allocated to the instance, and the autoscaler will
/// only scale within that range. Users can either use nodes or processing
/// units to specify the limits, but should use the same unit to set both the
/// min_limit and max_limit.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderAutoscalingConfigAutoscalingLimits
{
    /// <summary>The maximum number of nodes for this specific replica.</summary>
    [JsonPropertyName("maxNodes")]
    public double? MaxNodes { get; set; }

    /// <summary>
    /// Specifies maximum number of processing units allocated to the instance.
    /// If set, this number should be multiples of 1000 and be greater than or equal to
    /// min_processing_units.
    /// </summary>
    [JsonPropertyName("maxProcessingUnits")]
    public double? MaxProcessingUnits { get; set; }

    /// <summary>The minimum number of nodes for this specific replica.</summary>
    [JsonPropertyName("minNodes")]
    public double? MinNodes { get; set; }

    /// <summary>
    /// Specifies minimum number of processing units allocated to the instance.
    /// If set, this number should be multiples of 1000.
    /// </summary>
    [JsonPropertyName("minProcessingUnits")]
    public double? MinProcessingUnits { get; set; }
}

/// <summary>
/// Defines scale in controls to reduce the risk of response latency
/// and outages due to abrupt scale-in events
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderAutoscalingConfigAutoscalingTargets
{
    /// <summary>
    /// Specifies the target high priority cpu utilization percentage that the autoscaler
    /// should be trying to achieve for the instance.
    /// This number is on a scale from 0 (no utilization) to 100 (full utilization)..
    /// </summary>
    [JsonPropertyName("highPriorityCpuUtilizationPercent")]
    public double? HighPriorityCpuUtilizationPercent { get; set; }

    /// <summary>
    /// Specifies the target storage utilization percentage that the autoscaler
    /// should be trying to achieve for the instance.
    /// This number is on a scale from 0 (no utilization) to 100 (full utilization).
    /// </summary>
    [JsonPropertyName("storageUtilizationPercent")]
    public double? StorageUtilizationPercent { get; set; }
}

/// <summary>
/// The autoscaling configuration. Autoscaling is enabled if this field is set.
/// When autoscaling is enabled, num_nodes and processing_units are treated as,
/// OUTPUT_ONLY fields and reflect the current compute capacity allocated to
/// the instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderAutoscalingConfig
{
    /// <summary>
    /// Asymmetric autoscaling options for specific replicas.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("asymmetricAutoscalingOptions")]
    public IList<V1beta2InstanceSpecInitProviderAutoscalingConfigAsymmetricAutoscalingOptions>? AsymmetricAutoscalingOptions { get; set; }

    /// <summary>
    /// Defines scale in controls to reduce the risk of response latency
    /// and outages due to abrupt scale-in events. Users can define the minimum and
    /// maximum compute capacity allocated to the instance, and the autoscaler will
    /// only scale within that range. Users can either use nodes or processing
    /// units to specify the limits, but should use the same unit to set both the
    /// min_limit and max_limit.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscalingLimits")]
    public V1beta2InstanceSpecInitProviderAutoscalingConfigAutoscalingLimits? AutoscalingLimits { get; set; }

    /// <summary>
    /// Defines scale in controls to reduce the risk of response latency
    /// and outages due to abrupt scale-in events
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscalingTargets")]
    public V1beta2InstanceSpecInitProviderAutoscalingConfigAutoscalingTargets? AutoscalingTargets { get; set; }
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
public partial class V1beta2InstanceSpecInitProvider
{
    /// <summary>
    /// The autoscaling configuration. Autoscaling is enabled if this field is set.
    /// When autoscaling is enabled, num_nodes and processing_units are treated as,
    /// OUTPUT_ONLY fields and reflect the current compute capacity allocated to
    /// the instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscalingConfig")]
    public V1beta2InstanceSpecInitProviderAutoscalingConfig? AutoscalingConfig { get; set; }

    /// <summary>
    /// The name of the instance&apos;s configuration (similar but not
    /// quite the same as a region) which defines the geographic placement and
    /// replication of your databases in this instance. It determines where your data
    /// is stored. Values are typically of the form regional-europe-west1 , us-central etc.
    /// In order to obtain a valid list please consult the
    /// Configuration section of the docs.
    /// </summary>
    [JsonPropertyName("config")]
    public string? Config { get; set; }

    /// <summary>
    /// Controls the default backup behavior for new databases within the instance.
    /// Note that AUTOMATIC is not permitted for free instances, as backups and backup schedules are not allowed for free instances.
    /// if unset or NONE, no default backup schedule will be created for new databases within the instance.
    /// Possible values are: NONE, AUTOMATIC.
    /// </summary>
    [JsonPropertyName("defaultBackupScheduleType")]
    public string? DefaultBackupScheduleType { get; set; }

    /// <summary>
    /// The descriptive name for this instance as it appears in UIs. Must be
    /// unique per project and between 4 and 30 characters in length.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// The edition selected for this instance. Different editions provide different capabilities at different price points.
    /// Possible values are: EDITION_UNSPECIFIED, STANDARD, ENTERPRISE, ENTERPRISE_PLUS.
    /// </summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>
    /// When deleting a spanner instance, this boolean option will delete all backups of this instance.
    /// This must be set to true if you created a backup manually in the console.
    /// </summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>
    /// The type of this instance. The type can be used to distinguish product variants, that can affect aspects like:
    /// usage restrictions, quotas and billing. Currently this is used to distinguish FREE_INSTANCE vs PROVISIONED instances.
    /// When configured as FREE_INSTANCE, the field edition should not be configured.
    /// Possible values are: PROVISIONED, FREE_INSTANCE.
    /// </summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>
    /// An object containing a list of &quot;key&quot;: value pairs.
    /// Example: { &quot;name&quot;: &quot;wrench&quot;, &quot;mass&quot;: &quot;1.3kg&quot;, &quot;count&quot;: &quot;3&quot; }.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The number of nodes allocated to this instance.</summary>
    [JsonPropertyName("numNodes")]
    public double? NumNodes { get; set; }

    /// <summary>The number of processing units allocated to this instance.</summary>
    [JsonPropertyName("processingUnits")]
    public double? ProcessingUnits { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecManagementPoliciesEnum>))]
public enum V1beta2InstanceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>InstanceSpec defines the desired state of Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpec
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
    public V1beta2InstanceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2InstanceSpecForProvider ForProvider { get; set; }

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
    public V1beta2InstanceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2InstanceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2InstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2InstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderAutoscalingConfigAsymmetricAutoscalingOptionsOverridesAutoscalingLimits
{
    /// <summary>The maximum number of nodes for this specific replica.</summary>
    [JsonPropertyName("maxNodes")]
    public double? MaxNodes { get; set; }

    /// <summary>The minimum number of nodes for this specific replica.</summary>
    [JsonPropertyName("minNodes")]
    public double? MinNodes { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderAutoscalingConfigAsymmetricAutoscalingOptionsOverrides
{
    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscalingLimits")]
    public V1beta2InstanceStatusAtProviderAutoscalingConfigAsymmetricAutoscalingOptionsOverridesAutoscalingLimits? AutoscalingLimits { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderAutoscalingConfigAsymmetricAutoscalingOptionsReplicaSelection
{
    /// <summary>The location of the replica to apply asymmetric autoscaling options.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderAutoscalingConfigAsymmetricAutoscalingOptions
{
    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("overrides")]
    public V1beta2InstanceStatusAtProviderAutoscalingConfigAsymmetricAutoscalingOptionsOverrides? Overrides { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replicaSelection")]
    public V1beta2InstanceStatusAtProviderAutoscalingConfigAsymmetricAutoscalingOptionsReplicaSelection? ReplicaSelection { get; set; }
}

/// <summary>
/// Defines scale in controls to reduce the risk of response latency
/// and outages due to abrupt scale-in events. Users can define the minimum and
/// maximum compute capacity allocated to the instance, and the autoscaler will
/// only scale within that range. Users can either use nodes or processing
/// units to specify the limits, but should use the same unit to set both the
/// min_limit and max_limit.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderAutoscalingConfigAutoscalingLimits
{
    /// <summary>The maximum number of nodes for this specific replica.</summary>
    [JsonPropertyName("maxNodes")]
    public double? MaxNodes { get; set; }

    /// <summary>
    /// Specifies maximum number of processing units allocated to the instance.
    /// If set, this number should be multiples of 1000 and be greater than or equal to
    /// min_processing_units.
    /// </summary>
    [JsonPropertyName("maxProcessingUnits")]
    public double? MaxProcessingUnits { get; set; }

    /// <summary>The minimum number of nodes for this specific replica.</summary>
    [JsonPropertyName("minNodes")]
    public double? MinNodes { get; set; }

    /// <summary>
    /// Specifies minimum number of processing units allocated to the instance.
    /// If set, this number should be multiples of 1000.
    /// </summary>
    [JsonPropertyName("minProcessingUnits")]
    public double? MinProcessingUnits { get; set; }
}

/// <summary>
/// Defines scale in controls to reduce the risk of response latency
/// and outages due to abrupt scale-in events
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderAutoscalingConfigAutoscalingTargets
{
    /// <summary>
    /// Specifies the target high priority cpu utilization percentage that the autoscaler
    /// should be trying to achieve for the instance.
    /// This number is on a scale from 0 (no utilization) to 100 (full utilization)..
    /// </summary>
    [JsonPropertyName("highPriorityCpuUtilizationPercent")]
    public double? HighPriorityCpuUtilizationPercent { get; set; }

    /// <summary>
    /// Specifies the target storage utilization percentage that the autoscaler
    /// should be trying to achieve for the instance.
    /// This number is on a scale from 0 (no utilization) to 100 (full utilization).
    /// </summary>
    [JsonPropertyName("storageUtilizationPercent")]
    public double? StorageUtilizationPercent { get; set; }
}

/// <summary>
/// The autoscaling configuration. Autoscaling is enabled if this field is set.
/// When autoscaling is enabled, num_nodes and processing_units are treated as,
/// OUTPUT_ONLY fields and reflect the current compute capacity allocated to
/// the instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderAutoscalingConfig
{
    /// <summary>
    /// Asymmetric autoscaling options for specific replicas.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("asymmetricAutoscalingOptions")]
    public IList<V1beta2InstanceStatusAtProviderAutoscalingConfigAsymmetricAutoscalingOptions>? AsymmetricAutoscalingOptions { get; set; }

    /// <summary>
    /// Defines scale in controls to reduce the risk of response latency
    /// and outages due to abrupt scale-in events. Users can define the minimum and
    /// maximum compute capacity allocated to the instance, and the autoscaler will
    /// only scale within that range. Users can either use nodes or processing
    /// units to specify the limits, but should use the same unit to set both the
    /// min_limit and max_limit.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscalingLimits")]
    public V1beta2InstanceStatusAtProviderAutoscalingConfigAutoscalingLimits? AutoscalingLimits { get; set; }

    /// <summary>
    /// Defines scale in controls to reduce the risk of response latency
    /// and outages due to abrupt scale-in events
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscalingTargets")]
    public V1beta2InstanceStatusAtProviderAutoscalingConfigAutoscalingTargets? AutoscalingTargets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProvider
{
    /// <summary>
    /// The autoscaling configuration. Autoscaling is enabled if this field is set.
    /// When autoscaling is enabled, num_nodes and processing_units are treated as,
    /// OUTPUT_ONLY fields and reflect the current compute capacity allocated to
    /// the instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscalingConfig")]
    public V1beta2InstanceStatusAtProviderAutoscalingConfig? AutoscalingConfig { get; set; }

    /// <summary>
    /// The name of the instance&apos;s configuration (similar but not
    /// quite the same as a region) which defines the geographic placement and
    /// replication of your databases in this instance. It determines where your data
    /// is stored. Values are typically of the form regional-europe-west1 , us-central etc.
    /// In order to obtain a valid list please consult the
    /// Configuration section of the docs.
    /// </summary>
    [JsonPropertyName("config")]
    public string? Config { get; set; }

    /// <summary>
    /// Controls the default backup behavior for new databases within the instance.
    /// Note that AUTOMATIC is not permitted for free instances, as backups and backup schedules are not allowed for free instances.
    /// if unset or NONE, no default backup schedule will be created for new databases within the instance.
    /// Possible values are: NONE, AUTOMATIC.
    /// </summary>
    [JsonPropertyName("defaultBackupScheduleType")]
    public string? DefaultBackupScheduleType { get; set; }

    /// <summary>
    /// The descriptive name for this instance as it appears in UIs. Must be
    /// unique per project and between 4 and 30 characters in length.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// The edition selected for this instance. Different editions provide different capabilities at different price points.
    /// Possible values are: EDITION_UNSPECIFIED, STANDARD, ENTERPRISE, ENTERPRISE_PLUS.
    /// </summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>
    /// When deleting a spanner instance, this boolean option will delete all backups of this instance.
    /// This must be set to true if you created a backup manually in the console.
    /// </summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>an identifier for the resource with format {{project}}/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The type of this instance. The type can be used to distinguish product variants, that can affect aspects like:
    /// usage restrictions, quotas and billing. Currently this is used to distinguish FREE_INSTANCE vs PROVISIONED instances.
    /// When configured as FREE_INSTANCE, the field edition should not be configured.
    /// Possible values are: PROVISIONED, FREE_INSTANCE.
    /// </summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>
    /// An object containing a list of &quot;key&quot;: value pairs.
    /// Example: { &quot;name&quot;: &quot;wrench&quot;, &quot;mass&quot;: &quot;1.3kg&quot;, &quot;count&quot;: &quot;3&quot; }.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The number of nodes allocated to this instance.</summary>
    [JsonPropertyName("numNodes")]
    public double? NumNodes { get; set; }

    /// <summary>The number of processing units allocated to this instance.</summary>
    [JsonPropertyName("processingUnits")]
    public double? ProcessingUnits { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Instance status: CREATING or READY.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusConditions
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

/// <summary>InstanceStatus defines the observed state of Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2InstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2InstanceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Instance is the Schema for the Instances API. An isolated set of Cloud Spanner resources on which databases can be hosted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Instance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2InstanceSpec>, IStatus<V1beta2InstanceStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Instance";
    public const string KubeGroup = "spanner.gcp.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "spanner.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Instance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceSpec defines the desired state of Instance</summary>
    [JsonPropertyName("spec")]
    public required V1beta2InstanceSpec Spec { get; set; }

    /// <summary>InstanceStatus defines the observed state of Instance.</summary>
    [JsonPropertyName("status")]
    public V1beta2InstanceStatus? Status { get; set; }
}
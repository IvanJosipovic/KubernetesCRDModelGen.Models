#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.spanner.cnrm.cloud.google.com;
/// <summary>SpannerInstanceConfig is the Schema for the SpannerInstanceConfig API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SpannerInstanceConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SpannerInstanceConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SpannerInstanceConfigList";
    public const string KubeGroup = "spanner.cnrm.cloud.google.com";
    public const string KubePluralName = "spannerinstanceconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "spanner.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpannerInstanceConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SpannerInstanceConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SpannerInstanceConfig> Items { get; set; }
}

/// <summary>Base configuration name, e.g. projects/&lt;project_name&gt;/instanceConfigs/nam3, based on which this configuration is created. Only set for user-managed configurations. `base_config` must refer to a configuration of type `GOOGLE_MANAGED` in the same project as this configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerInstanceConfigSpecBaseConfigRef
{
    /// <summary>A reference to an externally managed SpannerInstanceConfig resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/instanceconfigs/{{instanceconfigID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SpannerInstanceConfig resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SpannerInstanceConfig resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerInstanceConfigSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerInstanceConfigSpecReplicas
{
    /// <summary>If true, this location is designated as the default leader location where leader replicas are placed. See the [region types documentation](https://cloud.google.com/spanner/docs/instances#region_types) for more details.</summary>
    [JsonPropertyName("defaultLeaderLocation")]
    public bool? DefaultLeaderLocation { get; set; }

    /// <summary>The location of the serving resources, e.g., &quot;us-central1&quot;.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The type of replica.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>SpannerInstanceConfigSpec defines the desired state of SpannerInstanceConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerInstanceConfigSpec
{
    /// <summary>Base configuration name, e.g. projects/&lt;project_name&gt;/instanceConfigs/nam3, based on which this configuration is created. Only set for user-managed configurations. `base_config` must refer to a configuration of type `GOOGLE_MANAGED` in the same project as this configuration.</summary>
    [JsonPropertyName("baseConfigRef")]
    public V1alpha1SpannerInstanceConfigSpecBaseConfigRef? BaseConfigRef { get; set; }

    /// <summary>The name of this instance configuration as it appears in UIs.</summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>
    /// Cloud Labels are a flexible and lightweight mechanism for organizing cloud
    ///  resources into groups that reflect a customer&apos;s organizational needs and
    ///  deployment strategies. Cloud Labels can be used to filter collections of
    ///  resources. They can be used to control how resource metrics are aggregated.
    ///  And they can be used as arguments to policy management rules (e.g. route,
    ///  firewall, load balancing, etc.).
    /// 
    ///   * Label keys must be between 1 and 63 characters long and must conform to
    ///     the following regular expression: `[a-z][a-z0-9_-]{0,62}`.
    ///   * Label values must be between 0 and 63 characters long and must conform
    ///     to the regular expression: `[a-z0-9_-]{0,63}`.
    ///   * No more than 64 labels can be associated with a given resource.
    /// 
    ///  See https://goo.gl/xmQnxf for more information on and examples of labels.
    /// 
    ///  If you plan to use labels in your own code, please note that additional
    ///  characters may be allowed in the future. Therefore, you are advised to use
    ///  an internal label representation, such as JSON, which doesn&apos;t rely upon
    ///  specific characters being disallowed.  For example, representing labels
    ///  as the string:  name + &quot;_&quot; + value  would prove problematic if we were to
    ///  allow &quot;_&quot; in a future release.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Allowed values of the &quot;default_leader&quot; schema option for databases in instances that use this instance configuration.</summary>
    [JsonPropertyName("leaderOptions")]
    public IList<string>? LeaderOptions { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1SpannerInstanceConfigSpecProjectRef ProjectRef { get; set; }

    /// <summary>
    /// The geographic placement of nodes in this instance configuration and their
    ///  replication properties.
    /// 
    ///  To create user-managed configurations, input
    ///  `replicas` must include all replicas in `replicas` of the `base_config`
    ///  and include one or more replicas in the `optional_replicas` of the
    ///  `base_config`.
    /// </summary>
    [JsonPropertyName("replicas")]
    public required IList<V1alpha1SpannerInstanceConfigSpecReplicas> Replicas { get; set; }

    /// <summary>The SpannerInstanceConfig name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerInstanceConfigStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerInstanceConfigStatusObservedStateOptionalReplicas
{
    /// <summary>If true, this location is designated as the default leader location where leader replicas are placed. See the [region types documentation](https://cloud.google.com/spanner/docs/instances#region_types) for more details.</summary>
    [JsonPropertyName("defaultLeaderLocation")]
    public bool? DefaultLeaderLocation { get; set; }

    /// <summary>The location of the serving resources, e.g., &quot;us-central1&quot;.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The type of replica.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerInstanceConfigStatusObservedState
{
    /// <summary>Output only. Whether this instance configuration is a Google-managed or user-managed configuration.</summary>
    [JsonPropertyName("configType")]
    public string? ConfigType { get; set; }

    /// <summary>Output only. Describes whether free instances are available to be created in this instance configuration.</summary>
    [JsonPropertyName("freeInstanceAvailability")]
    public string? FreeInstanceAvailability { get; set; }

    /// <summary>Output only. The available optional replicas to choose from for user-managed configurations. Populated for Google-managed configurations.</summary>
    [JsonPropertyName("optionalReplicas")]
    public IList<V1alpha1SpannerInstanceConfigStatusObservedStateOptionalReplicas>? OptionalReplicas { get; set; }

    /// <summary>Output only. The `QuorumType` of the instance configuration.</summary>
    [JsonPropertyName("quorumType")]
    public string? QuorumType { get; set; }

    /// <summary>Output only. If true, the instance configuration is being created or updated. If false, there are no ongoing operations for the instance configuration.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>Output only. The current instance configuration state. Applicable only for `USER_MANAGED` configurations.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The storage limit in bytes per processing unit.</summary>
    [JsonPropertyName("storageLimitPerProcessingUnit")]
    public long? StorageLimitPerProcessingUnit { get; set; }
}

/// <summary>SpannerInstanceConfigStatus defines the config connector machine state of SpannerInstanceConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerInstanceConfigStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SpannerInstanceConfigStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the SpannerInstanceConfig resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1SpannerInstanceConfigStatusObservedState? ObservedState { get; set; }
}

/// <summary>SpannerInstanceConfig is the Schema for the SpannerInstanceConfig API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SpannerInstanceConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SpannerInstanceConfigSpec>, IStatus<V1alpha1SpannerInstanceConfigStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SpannerInstanceConfig";
    public const string KubeGroup = "spanner.cnrm.cloud.google.com";
    public const string KubePluralName = "spannerinstanceconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "spanner.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpannerInstanceConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpannerInstanceConfigSpec defines the desired state of SpannerInstanceConfig</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SpannerInstanceConfigSpec Spec { get; set; }

    /// <summary>SpannerInstanceConfigStatus defines the config connector machine state of SpannerInstanceConfig</summary>
    [JsonPropertyName("status")]
    public V1alpha1SpannerInstanceConfigStatus? Status { get; set; }
}
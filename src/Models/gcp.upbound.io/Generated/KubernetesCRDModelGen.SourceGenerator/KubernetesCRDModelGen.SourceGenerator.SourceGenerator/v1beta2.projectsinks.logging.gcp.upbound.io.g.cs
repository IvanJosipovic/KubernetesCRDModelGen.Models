#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.logging.gcp.upbound.io;
/// <summary>ProjectSink is the Schema for the ProjectSinks API. Manages a project-level logging sink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ProjectSinkList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ProjectSink>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ProjectSinkList";
    public const string KubeGroup = "logging.gcp.upbound.io";
    public const string KubePluralName = "projectsinks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "logging.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ProjectSinkList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ProjectSink objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ProjectSink> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ProjectSinkSpecDeletionPolicyEnum>))]
public enum V1beta2ProjectSinkSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Options that affect sinks exporting data to BigQuery. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkSpecForProviderBigqueryOptions
{
    /// <summary>
    /// Whether to use BigQuery&apos;s partition tables.
    /// By default, Logging creates dated tables based on the log entries&apos; timestamps, e.g. syslog_20170523. With partitioned
    /// tables the date suffix is no longer present and special query syntax
    /// has to be used instead. In both cases, tables are sharded based on UTC timezone.
    /// </summary>
    [JsonPropertyName("usePartitionedTables")]
    public bool? UsePartitionedTables { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ProjectSinkSpecForProviderCustomWriterIdentityRefPolicyResolutionEnum>))]
public enum V1beta2ProjectSinkSpecForProviderCustomWriterIdentityRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ProjectSinkSpecForProviderCustomWriterIdentityRefPolicyResolveEnum>))]
public enum V1beta2ProjectSinkSpecForProviderCustomWriterIdentityRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkSpecForProviderCustomWriterIdentityRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ProjectSinkSpecForProviderCustomWriterIdentityRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ProjectSinkSpecForProviderCustomWriterIdentityRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate customWriterIdentity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkSpecForProviderCustomWriterIdentityRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ProjectSinkSpecForProviderCustomWriterIdentityRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ProjectSinkSpecForProviderCustomWriterIdentitySelectorPolicyResolutionEnum>))]
public enum V1beta2ProjectSinkSpecForProviderCustomWriterIdentitySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ProjectSinkSpecForProviderCustomWriterIdentitySelectorPolicyResolveEnum>))]
public enum V1beta2ProjectSinkSpecForProviderCustomWriterIdentitySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkSpecForProviderCustomWriterIdentitySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ProjectSinkSpecForProviderCustomWriterIdentitySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ProjectSinkSpecForProviderCustomWriterIdentitySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate customWriterIdentity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkSpecForProviderCustomWriterIdentitySelector
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
    public V1beta2ProjectSinkSpecForProviderCustomWriterIdentitySelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkSpecForProviderExclusions
{
    /// <summary>A description of this exclusion.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If set to True, then this exclusion is disabled and it does not exclude any log entries.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// An advanced logs filter that matches the log entries to be excluded. By using the sample function, you can exclude less than 100% of the matching log entries. See Advanced Log Filters for information on how to
    /// write a filter.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>A client-assigned identifier, such as load-balancer-exclusion. Identifiers are limited to 100 characters and can include only letters, digits, underscores, hyphens, and periods. First character has to be alphanumeric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkSpecForProvider
{
    /// <summary>Options that affect sinks exporting data to BigQuery. Structure documented below.</summary>
    [JsonPropertyName("bigqueryOptions")]
    public V1beta2ProjectSinkSpecForProviderBigqueryOptions? BigqueryOptions { get; set; }

    /// <summary>
    /// A user managed service account that will be used to write
    /// the log entries. The format must be serviceAccount:some@email. This field can only be specified if you are
    /// routing logs to a destination outside this sink&apos;s project. If not specified, a Logging service account
    /// will automatically be generated.
    /// </summary>
    [JsonPropertyName("customWriterIdentity")]
    public string? CustomWriterIdentity { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate customWriterIdentity.</summary>
    [JsonPropertyName("customWriterIdentityRef")]
    public V1beta2ProjectSinkSpecForProviderCustomWriterIdentityRef? CustomWriterIdentityRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate customWriterIdentity.</summary>
    [JsonPropertyName("customWriterIdentitySelector")]
    public V1beta2ProjectSinkSpecForProviderCustomWriterIdentitySelector? CustomWriterIdentitySelector { get; set; }

    /// <summary>A description of this sink. The maximum length of the description is 8000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The destination of the sink (or, in other words, where logs are written to). Can be a Cloud Storage bucket, a PubSub topic, a BigQuery dataset, a Cloud Logging bucket, or a Google Cloud project. Examples:</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>If set to True, then this sink is disabled and it does not export any log entries.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Log entries that match any of the exclusion filters will not be exported. If a log entry is matched by both filter and one of exclusions.filter, it will not be exported.  Can be repeated multiple times for multiple exclusions. Structure is documented below.</summary>
    [JsonPropertyName("exclusions")]
    public IList<V1beta2ProjectSinkSpecForProviderExclusions>? Exclusions { get; set; }

    /// <summary>
    /// The filter to apply when exporting logs. Only log entries that match the filter are exported.
    /// See Advanced Log Filters for information on how to
    /// write a filter.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>
    /// The ID of the project to create the sink in. If omitted, the project associated with the provider is
    /// used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Whether or not to create a unique identity associated with this sink. If false, then the writer_identity used is serviceAccount:cloud-logs@system.gserviceaccount.com. If true (the default),
    /// then a unique service account is created and used for this sink. If you wish to publish logs across projects or utilize
    /// bigquery_options, you must set unique_writer_identity to true.
    /// </summary>
    [JsonPropertyName("uniqueWriterIdentity")]
    public bool? UniqueWriterIdentity { get; set; }
}

/// <summary>Options that affect sinks exporting data to BigQuery. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkSpecInitProviderBigqueryOptions
{
    /// <summary>
    /// Whether to use BigQuery&apos;s partition tables.
    /// By default, Logging creates dated tables based on the log entries&apos; timestamps, e.g. syslog_20170523. With partitioned
    /// tables the date suffix is no longer present and special query syntax
    /// has to be used instead. In both cases, tables are sharded based on UTC timezone.
    /// </summary>
    [JsonPropertyName("usePartitionedTables")]
    public bool? UsePartitionedTables { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ProjectSinkSpecInitProviderCustomWriterIdentityRefPolicyResolutionEnum>))]
public enum V1beta2ProjectSinkSpecInitProviderCustomWriterIdentityRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ProjectSinkSpecInitProviderCustomWriterIdentityRefPolicyResolveEnum>))]
public enum V1beta2ProjectSinkSpecInitProviderCustomWriterIdentityRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkSpecInitProviderCustomWriterIdentityRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ProjectSinkSpecInitProviderCustomWriterIdentityRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ProjectSinkSpecInitProviderCustomWriterIdentityRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate customWriterIdentity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkSpecInitProviderCustomWriterIdentityRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ProjectSinkSpecInitProviderCustomWriterIdentityRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ProjectSinkSpecInitProviderCustomWriterIdentitySelectorPolicyResolutionEnum>))]
public enum V1beta2ProjectSinkSpecInitProviderCustomWriterIdentitySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ProjectSinkSpecInitProviderCustomWriterIdentitySelectorPolicyResolveEnum>))]
public enum V1beta2ProjectSinkSpecInitProviderCustomWriterIdentitySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkSpecInitProviderCustomWriterIdentitySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ProjectSinkSpecInitProviderCustomWriterIdentitySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ProjectSinkSpecInitProviderCustomWriterIdentitySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate customWriterIdentity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkSpecInitProviderCustomWriterIdentitySelector
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
    public V1beta2ProjectSinkSpecInitProviderCustomWriterIdentitySelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkSpecInitProviderExclusions
{
    /// <summary>A description of this exclusion.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If set to True, then this exclusion is disabled and it does not exclude any log entries.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// An advanced logs filter that matches the log entries to be excluded. By using the sample function, you can exclude less than 100% of the matching log entries. See Advanced Log Filters for information on how to
    /// write a filter.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>A client-assigned identifier, such as load-balancer-exclusion. Identifiers are limited to 100 characters and can include only letters, digits, underscores, hyphens, and periods. First character has to be alphanumeric.</summary>
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
public partial class V1beta2ProjectSinkSpecInitProvider
{
    /// <summary>Options that affect sinks exporting data to BigQuery. Structure documented below.</summary>
    [JsonPropertyName("bigqueryOptions")]
    public V1beta2ProjectSinkSpecInitProviderBigqueryOptions? BigqueryOptions { get; set; }

    /// <summary>
    /// A user managed service account that will be used to write
    /// the log entries. The format must be serviceAccount:some@email. This field can only be specified if you are
    /// routing logs to a destination outside this sink&apos;s project. If not specified, a Logging service account
    /// will automatically be generated.
    /// </summary>
    [JsonPropertyName("customWriterIdentity")]
    public string? CustomWriterIdentity { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate customWriterIdentity.</summary>
    [JsonPropertyName("customWriterIdentityRef")]
    public V1beta2ProjectSinkSpecInitProviderCustomWriterIdentityRef? CustomWriterIdentityRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate customWriterIdentity.</summary>
    [JsonPropertyName("customWriterIdentitySelector")]
    public V1beta2ProjectSinkSpecInitProviderCustomWriterIdentitySelector? CustomWriterIdentitySelector { get; set; }

    /// <summary>A description of this sink. The maximum length of the description is 8000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The destination of the sink (or, in other words, where logs are written to). Can be a Cloud Storage bucket, a PubSub topic, a BigQuery dataset, a Cloud Logging bucket, or a Google Cloud project. Examples:</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>If set to True, then this sink is disabled and it does not export any log entries.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Log entries that match any of the exclusion filters will not be exported. If a log entry is matched by both filter and one of exclusions.filter, it will not be exported.  Can be repeated multiple times for multiple exclusions. Structure is documented below.</summary>
    [JsonPropertyName("exclusions")]
    public IList<V1beta2ProjectSinkSpecInitProviderExclusions>? Exclusions { get; set; }

    /// <summary>
    /// The filter to apply when exporting logs. Only log entries that match the filter are exported.
    /// See Advanced Log Filters for information on how to
    /// write a filter.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>
    /// The ID of the project to create the sink in. If omitted, the project associated with the provider is
    /// used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Whether or not to create a unique identity associated with this sink. If false, then the writer_identity used is serviceAccount:cloud-logs@system.gserviceaccount.com. If true (the default),
    /// then a unique service account is created and used for this sink. If you wish to publish logs across projects or utilize
    /// bigquery_options, you must set unique_writer_identity to true.
    /// </summary>
    [JsonPropertyName("uniqueWriterIdentity")]
    public bool? UniqueWriterIdentity { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ProjectSinkSpecManagementPoliciesEnum>))]
public enum V1beta2ProjectSinkSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ProjectSinkSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ProjectSinkSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ProjectSinkSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ProjectSinkSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ProjectSinkSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ProjectSinkSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ProjectSinkSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ProjectSinkSpec defines the desired state of ProjectSink</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkSpec
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
    public V1beta2ProjectSinkSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ProjectSinkSpecForProvider ForProvider { get; set; }

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
    public V1beta2ProjectSinkSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ProjectSinkSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ProjectSinkSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ProjectSinkSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Options that affect sinks exporting data to BigQuery. Structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkStatusAtProviderBigqueryOptions
{
    /// <summary>
    /// Whether to use BigQuery&apos;s partition tables.
    /// By default, Logging creates dated tables based on the log entries&apos; timestamps, e.g. syslog_20170523. With partitioned
    /// tables the date suffix is no longer present and special query syntax
    /// has to be used instead. In both cases, tables are sharded based on UTC timezone.
    /// </summary>
    [JsonPropertyName("usePartitionedTables")]
    public bool? UsePartitionedTables { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkStatusAtProviderExclusions
{
    /// <summary>A description of this exclusion.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If set to True, then this exclusion is disabled and it does not exclude any log entries.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// An advanced logs filter that matches the log entries to be excluded. By using the sample function, you can exclude less than 100% of the matching log entries. See Advanced Log Filters for information on how to
    /// write a filter.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>A client-assigned identifier, such as load-balancer-exclusion. Identifiers are limited to 100 characters and can include only letters, digits, underscores, hyphens, and periods. First character has to be alphanumeric.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkStatusAtProvider
{
    /// <summary>Options that affect sinks exporting data to BigQuery. Structure documented below.</summary>
    [JsonPropertyName("bigqueryOptions")]
    public V1beta2ProjectSinkStatusAtProviderBigqueryOptions? BigqueryOptions { get; set; }

    /// <summary>
    /// A user managed service account that will be used to write
    /// the log entries. The format must be serviceAccount:some@email. This field can only be specified if you are
    /// routing logs to a destination outside this sink&apos;s project. If not specified, a Logging service account
    /// will automatically be generated.
    /// </summary>
    [JsonPropertyName("customWriterIdentity")]
    public string? CustomWriterIdentity { get; set; }

    /// <summary>A description of this sink. The maximum length of the description is 8000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The destination of the sink (or, in other words, where logs are written to). Can be a Cloud Storage bucket, a PubSub topic, a BigQuery dataset, a Cloud Logging bucket, or a Google Cloud project. Examples:</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>If set to True, then this sink is disabled and it does not export any log entries.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Log entries that match any of the exclusion filters will not be exported. If a log entry is matched by both filter and one of exclusions.filter, it will not be exported.  Can be repeated multiple times for multiple exclusions. Structure is documented below.</summary>
    [JsonPropertyName("exclusions")]
    public IList<V1beta2ProjectSinkStatusAtProviderExclusions>? Exclusions { get; set; }

    /// <summary>
    /// The filter to apply when exporting logs. Only log entries that match the filter are exported.
    /// See Advanced Log Filters for information on how to
    /// write a filter.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/sinks/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The ID of the project to create the sink in. If omitted, the project associated with the provider is
    /// used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Whether or not to create a unique identity associated with this sink. If false, then the writer_identity used is serviceAccount:cloud-logs@system.gserviceaccount.com. If true (the default),
    /// then a unique service account is created and used for this sink. If you wish to publish logs across projects or utilize
    /// bigquery_options, you must set unique_writer_identity to true.
    /// </summary>
    [JsonPropertyName("uniqueWriterIdentity")]
    public bool? UniqueWriterIdentity { get; set; }

    /// <summary>
    /// The identity associated with this sink. This identity must be granted write access to the
    /// configured destination.
    /// </summary>
    [JsonPropertyName("writerIdentity")]
    public string? WriterIdentity { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkStatusConditions
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

/// <summary>ProjectSinkStatus defines the observed state of ProjectSink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ProjectSinkStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ProjectSinkStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ProjectSinkStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ProjectSink is the Schema for the ProjectSinks API. Manages a project-level logging sink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ProjectSink : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ProjectSinkSpec>, IStatus<V1beta2ProjectSinkStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ProjectSink";
    public const string KubeGroup = "logging.gcp.upbound.io";
    public const string KubePluralName = "projectsinks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "logging.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ProjectSink";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ProjectSinkSpec defines the desired state of ProjectSink</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ProjectSinkSpec Spec { get; set; }

    /// <summary>ProjectSinkStatus defines the observed state of ProjectSink.</summary>
    [JsonPropertyName("status")]
    public V1beta2ProjectSinkStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iot.aws.upbound.io;
/// <summary>IndexingConfiguration is the Schema for the IndexingConfigurations API. Managing IoT Thing indexing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2IndexingConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta2IndexingConfiguration>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "IndexingConfigurationList";
    public const string KubeGroup = "iot.aws.upbound.io";
    public const string KubePluralName = "indexingconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iot.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IndexingConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2IndexingConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2IndexingConfiguration> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IndexingConfigurationSpecDeletionPolicyEnum>))]
public enum V1beta2IndexingConfigurationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpecForProviderThingGroupIndexingConfigurationCustomField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpecForProviderThingGroupIndexingConfigurationManagedField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Thing group indexing configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpecForProviderThingGroupIndexingConfiguration
{
    /// <summary>A list of thing group fields to index. This list cannot contain any managed fields. See below.</summary>
    [JsonPropertyName("customField")]
    public IList<V1beta2IndexingConfigurationSpecForProviderThingGroupIndexingConfigurationCustomField>? CustomField { get; set; }

    /// <summary>Contains fields that are indexed and whose types are already known by the Fleet Indexing service. See below.</summary>
    [JsonPropertyName("managedField")]
    public IList<V1beta2IndexingConfigurationSpecForProviderThingGroupIndexingConfigurationManagedField>? ManagedField { get; set; }

    /// <summary>Thing group indexing mode. Valid values: OFF, ON.</summary>
    [JsonPropertyName("thingGroupIndexingMode")]
    public string? ThingGroupIndexingMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpecForProviderThingIndexingConfigurationCustomField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Required if named_shadow_indexing_mode is ON. Enables to add named shadows filtered by filter to fleet indexing configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpecForProviderThingIndexingConfigurationFilter
{
    /// <summary>List of shadow names that you select to index.</summary>
    [JsonPropertyName("namedShadowNames")]
    public IList<string>? NamedShadowNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpecForProviderThingIndexingConfigurationManagedField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Thing indexing configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpecForProviderThingIndexingConfiguration
{
    /// <summary>Contains custom field names and their data type. See below.</summary>
    [JsonPropertyName("customField")]
    public IList<V1beta2IndexingConfigurationSpecForProviderThingIndexingConfigurationCustomField>? CustomField { get; set; }

    /// <summary>Device Defender indexing mode. Valid values: VIOLATIONS, OFF. Default: OFF.</summary>
    [JsonPropertyName("deviceDefenderIndexingMode")]
    public string? DeviceDefenderIndexingMode { get; set; }

    /// <summary>Required if named_shadow_indexing_mode is ON. Enables to add named shadows filtered by filter to fleet indexing configuration.</summary>
    [JsonPropertyName("filter")]
    public V1beta2IndexingConfigurationSpecForProviderThingIndexingConfigurationFilter? Filter { get; set; }

    /// <summary>Contains fields that are indexed and whose types are already known by the Fleet Indexing service. See below.</summary>
    [JsonPropertyName("managedField")]
    public IList<V1beta2IndexingConfigurationSpecForProviderThingIndexingConfigurationManagedField>? ManagedField { get; set; }

    /// <summary>Named shadow indexing mode. Valid values: ON, OFF. Default: OFF.</summary>
    [JsonPropertyName("namedShadowIndexingMode")]
    public string? NamedShadowIndexingMode { get; set; }

    /// <summary>Thing connectivity indexing mode. Valid values: STATUS, OFF. Default: OFF.</summary>
    [JsonPropertyName("thingConnectivityIndexingMode")]
    public string? ThingConnectivityIndexingMode { get; set; }

    /// <summary>Thing indexing mode. Valid values: REGISTRY, REGISTRY_AND_SHADOW, OFF.</summary>
    [JsonPropertyName("thingIndexingMode")]
    public string? ThingIndexingMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpecForProvider
{
    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Thing group indexing configuration. See below.</summary>
    [JsonPropertyName("thingGroupIndexingConfiguration")]
    public V1beta2IndexingConfigurationSpecForProviderThingGroupIndexingConfiguration? ThingGroupIndexingConfiguration { get; set; }

    /// <summary>Thing indexing configuration. See below.</summary>
    [JsonPropertyName("thingIndexingConfiguration")]
    public V1beta2IndexingConfigurationSpecForProviderThingIndexingConfiguration? ThingIndexingConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpecInitProviderThingGroupIndexingConfigurationCustomField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpecInitProviderThingGroupIndexingConfigurationManagedField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Thing group indexing configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpecInitProviderThingGroupIndexingConfiguration
{
    /// <summary>A list of thing group fields to index. This list cannot contain any managed fields. See below.</summary>
    [JsonPropertyName("customField")]
    public IList<V1beta2IndexingConfigurationSpecInitProviderThingGroupIndexingConfigurationCustomField>? CustomField { get; set; }

    /// <summary>Contains fields that are indexed and whose types are already known by the Fleet Indexing service. See below.</summary>
    [JsonPropertyName("managedField")]
    public IList<V1beta2IndexingConfigurationSpecInitProviderThingGroupIndexingConfigurationManagedField>? ManagedField { get; set; }

    /// <summary>Thing group indexing mode. Valid values: OFF, ON.</summary>
    [JsonPropertyName("thingGroupIndexingMode")]
    public string? ThingGroupIndexingMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpecInitProviderThingIndexingConfigurationCustomField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Required if named_shadow_indexing_mode is ON. Enables to add named shadows filtered by filter to fleet indexing configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpecInitProviderThingIndexingConfigurationFilter
{
    /// <summary>List of shadow names that you select to index.</summary>
    [JsonPropertyName("namedShadowNames")]
    public IList<string>? NamedShadowNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpecInitProviderThingIndexingConfigurationManagedField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Thing indexing configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpecInitProviderThingIndexingConfiguration
{
    /// <summary>Contains custom field names and their data type. See below.</summary>
    [JsonPropertyName("customField")]
    public IList<V1beta2IndexingConfigurationSpecInitProviderThingIndexingConfigurationCustomField>? CustomField { get; set; }

    /// <summary>Device Defender indexing mode. Valid values: VIOLATIONS, OFF. Default: OFF.</summary>
    [JsonPropertyName("deviceDefenderIndexingMode")]
    public string? DeviceDefenderIndexingMode { get; set; }

    /// <summary>Required if named_shadow_indexing_mode is ON. Enables to add named shadows filtered by filter to fleet indexing configuration.</summary>
    [JsonPropertyName("filter")]
    public V1beta2IndexingConfigurationSpecInitProviderThingIndexingConfigurationFilter? Filter { get; set; }

    /// <summary>Contains fields that are indexed and whose types are already known by the Fleet Indexing service. See below.</summary>
    [JsonPropertyName("managedField")]
    public IList<V1beta2IndexingConfigurationSpecInitProviderThingIndexingConfigurationManagedField>? ManagedField { get; set; }

    /// <summary>Named shadow indexing mode. Valid values: ON, OFF. Default: OFF.</summary>
    [JsonPropertyName("namedShadowIndexingMode")]
    public string? NamedShadowIndexingMode { get; set; }

    /// <summary>Thing connectivity indexing mode. Valid values: STATUS, OFF. Default: OFF.</summary>
    [JsonPropertyName("thingConnectivityIndexingMode")]
    public string? ThingConnectivityIndexingMode { get; set; }

    /// <summary>Thing indexing mode. Valid values: REGISTRY, REGISTRY_AND_SHADOW, OFF.</summary>
    [JsonPropertyName("thingIndexingMode")]
    public string? ThingIndexingMode { get; set; }
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
public partial class V1beta2IndexingConfigurationSpecInitProvider
{
    /// <summary>Thing group indexing configuration. See below.</summary>
    [JsonPropertyName("thingGroupIndexingConfiguration")]
    public V1beta2IndexingConfigurationSpecInitProviderThingGroupIndexingConfiguration? ThingGroupIndexingConfiguration { get; set; }

    /// <summary>Thing indexing configuration. See below.</summary>
    [JsonPropertyName("thingIndexingConfiguration")]
    public V1beta2IndexingConfigurationSpecInitProviderThingIndexingConfiguration? ThingIndexingConfiguration { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IndexingConfigurationSpecManagementPoliciesEnum>))]
public enum V1beta2IndexingConfigurationSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IndexingConfigurationSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2IndexingConfigurationSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2IndexingConfigurationSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2IndexingConfigurationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2IndexingConfigurationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2IndexingConfigurationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2IndexingConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>IndexingConfigurationSpec defines the desired state of IndexingConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationSpec
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
    public V1beta2IndexingConfigurationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2IndexingConfigurationSpecForProvider ForProvider { get; set; }

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
    public V1beta2IndexingConfigurationSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2IndexingConfigurationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2IndexingConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2IndexingConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationStatusAtProviderThingGroupIndexingConfigurationCustomField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationStatusAtProviderThingGroupIndexingConfigurationManagedField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Thing group indexing configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationStatusAtProviderThingGroupIndexingConfiguration
{
    /// <summary>A list of thing group fields to index. This list cannot contain any managed fields. See below.</summary>
    [JsonPropertyName("customField")]
    public IList<V1beta2IndexingConfigurationStatusAtProviderThingGroupIndexingConfigurationCustomField>? CustomField { get; set; }

    /// <summary>Contains fields that are indexed and whose types are already known by the Fleet Indexing service. See below.</summary>
    [JsonPropertyName("managedField")]
    public IList<V1beta2IndexingConfigurationStatusAtProviderThingGroupIndexingConfigurationManagedField>? ManagedField { get; set; }

    /// <summary>Thing group indexing mode. Valid values: OFF, ON.</summary>
    [JsonPropertyName("thingGroupIndexingMode")]
    public string? ThingGroupIndexingMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationStatusAtProviderThingIndexingConfigurationCustomField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Required if named_shadow_indexing_mode is ON. Enables to add named shadows filtered by filter to fleet indexing configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationStatusAtProviderThingIndexingConfigurationFilter
{
    /// <summary>List of shadow names that you select to index.</summary>
    [JsonPropertyName("namedShadowNames")]
    public IList<string>? NamedShadowNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationStatusAtProviderThingIndexingConfigurationManagedField
{
    /// <summary>The name of the field.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The data type of the field. Valid values: Number, String, Boolean.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Thing indexing configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationStatusAtProviderThingIndexingConfiguration
{
    /// <summary>Contains custom field names and their data type. See below.</summary>
    [JsonPropertyName("customField")]
    public IList<V1beta2IndexingConfigurationStatusAtProviderThingIndexingConfigurationCustomField>? CustomField { get; set; }

    /// <summary>Device Defender indexing mode. Valid values: VIOLATIONS, OFF. Default: OFF.</summary>
    [JsonPropertyName("deviceDefenderIndexingMode")]
    public string? DeviceDefenderIndexingMode { get; set; }

    /// <summary>Required if named_shadow_indexing_mode is ON. Enables to add named shadows filtered by filter to fleet indexing configuration.</summary>
    [JsonPropertyName("filter")]
    public V1beta2IndexingConfigurationStatusAtProviderThingIndexingConfigurationFilter? Filter { get; set; }

    /// <summary>Contains fields that are indexed and whose types are already known by the Fleet Indexing service. See below.</summary>
    [JsonPropertyName("managedField")]
    public IList<V1beta2IndexingConfigurationStatusAtProviderThingIndexingConfigurationManagedField>? ManagedField { get; set; }

    /// <summary>Named shadow indexing mode. Valid values: ON, OFF. Default: OFF.</summary>
    [JsonPropertyName("namedShadowIndexingMode")]
    public string? NamedShadowIndexingMode { get; set; }

    /// <summary>Thing connectivity indexing mode. Valid values: STATUS, OFF. Default: OFF.</summary>
    [JsonPropertyName("thingConnectivityIndexingMode")]
    public string? ThingConnectivityIndexingMode { get; set; }

    /// <summary>Thing indexing mode. Valid values: REGISTRY, REGISTRY_AND_SHADOW, OFF.</summary>
    [JsonPropertyName("thingIndexingMode")]
    public string? ThingIndexingMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationStatusAtProvider
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Thing group indexing configuration. See below.</summary>
    [JsonPropertyName("thingGroupIndexingConfiguration")]
    public V1beta2IndexingConfigurationStatusAtProviderThingGroupIndexingConfiguration? ThingGroupIndexingConfiguration { get; set; }

    /// <summary>Thing indexing configuration. See below.</summary>
    [JsonPropertyName("thingIndexingConfiguration")]
    public V1beta2IndexingConfigurationStatusAtProviderThingIndexingConfiguration? ThingIndexingConfiguration { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationStatusConditions
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

/// <summary>IndexingConfigurationStatus defines the observed state of IndexingConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2IndexingConfigurationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2IndexingConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2IndexingConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>IndexingConfiguration is the Schema for the IndexingConfigurations API. Managing IoT Thing indexing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2IndexingConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2IndexingConfigurationSpec>, IStatus<V1beta2IndexingConfigurationStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "IndexingConfiguration";
    public const string KubeGroup = "iot.aws.upbound.io";
    public const string KubePluralName = "indexingconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iot.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IndexingConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IndexingConfigurationSpec defines the desired state of IndexingConfiguration</summary>
    [JsonPropertyName("spec")]
    public required V1beta2IndexingConfigurationSpec Spec { get; set; }

    /// <summary>IndexingConfigurationStatus defines the observed state of IndexingConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta2IndexingConfigurationStatus? Status { get; set; }
}
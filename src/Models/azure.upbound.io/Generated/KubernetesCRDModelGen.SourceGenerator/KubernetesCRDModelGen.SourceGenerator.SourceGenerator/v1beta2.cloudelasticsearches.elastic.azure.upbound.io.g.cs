#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elastic.azure.upbound.io;
/// <summary>CloudElasticsearch is the Schema for the CloudElasticsearchs API. Manages an Elasticsearch cluster in Elastic Cloud.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2CloudElasticsearchList : IKubernetesObject<V1ListMeta>, IItems<V1beta2CloudElasticsearch>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "CloudElasticsearchList";
    public const string KubeGroup = "elastic.azure.upbound.io";
    public const string KubePluralName = "cloudelasticsearches";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elastic.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudElasticsearchList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2CloudElasticsearch objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2CloudElasticsearch> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CloudElasticsearchSpecDeletionPolicyEnum>))]
public enum V1beta2CloudElasticsearchSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CloudElasticsearchSpecForProviderLogsFilteringTag
{
    /// <summary>Specifies the type of action which should be taken when the Tag matches the name and value. Possible values are Exclude and Include.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name which should be used for this Elasticsearch resource. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the value of the Tag which should be filtered.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A logs block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CloudElasticsearchSpecForProviderLogs
{
    /// <summary>A list of filtering_tag blocks as defined above.</summary>
    [JsonPropertyName("filteringTag")]
    public IList<V1beta2CloudElasticsearchSpecForProviderLogsFilteringTag>? FilteringTag { get; set; }

    /// <summary>Specifies if the Azure Activity Logs should be sent to the Elasticsearch cluster. Defaults to false.</summary>
    [JsonPropertyName("sendActivityLogs")]
    public bool? SendActivityLogs { get; set; }

    /// <summary>Specifies if the AzureAD Logs should be sent to the Elasticsearch cluster. Defaults to false.</summary>
    [JsonPropertyName("sendAzureadLogs")]
    public bool? SendAzureadLogs { get; set; }

    /// <summary>Specifies if the Azure Subscription Logs should be sent to the Elasticsearch cluster. Defaults to false.</summary>
    [JsonPropertyName("sendSubscriptionLogs")]
    public bool? SendSubscriptionLogs { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CloudElasticsearchSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2CloudElasticsearchSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CloudElasticsearchSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2CloudElasticsearchSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CloudElasticsearchSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CloudElasticsearchSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CloudElasticsearchSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CloudElasticsearchSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CloudElasticsearchSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CloudElasticsearchSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2CloudElasticsearchSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CloudElasticsearchSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2CloudElasticsearchSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CloudElasticsearchSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CloudElasticsearchSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CloudElasticsearchSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CloudElasticsearchSpecForProviderResourceGroupNameSelector
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
    public V1beta2CloudElasticsearchSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CloudElasticsearchSpecForProvider
{
    /// <summary>Specifies the Email Address which should be associated with this Elasticsearch account. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("elasticCloudEmailAddress")]
    public string? ElasticCloudEmailAddress { get; set; }

    /// <summary>The Azure Region where the Elasticsearch resource should exist. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A logs block as defined below.</summary>
    [JsonPropertyName("logs")]
    public V1beta2CloudElasticsearchSpecForProviderLogs? Logs { get; set; }

    /// <summary>Specifies if the Elasticsearch should have monitoring configured? Defaults to true. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("monitoringEnabled")]
    public bool? MonitoringEnabled { get; set; }

    /// <summary>The name of the Resource Group where the Elasticsearch resource should exist. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2CloudElasticsearchSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2CloudElasticsearchSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Specifies the name of the SKU for this Elasticsearch. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Elasticsearch resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CloudElasticsearchSpecInitProviderLogsFilteringTag
{
    /// <summary>Specifies the type of action which should be taken when the Tag matches the name and value. Possible values are Exclude and Include.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name which should be used for this Elasticsearch resource. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the value of the Tag which should be filtered.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A logs block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CloudElasticsearchSpecInitProviderLogs
{
    /// <summary>A list of filtering_tag blocks as defined above.</summary>
    [JsonPropertyName("filteringTag")]
    public IList<V1beta2CloudElasticsearchSpecInitProviderLogsFilteringTag>? FilteringTag { get; set; }

    /// <summary>Specifies if the Azure Activity Logs should be sent to the Elasticsearch cluster. Defaults to false.</summary>
    [JsonPropertyName("sendActivityLogs")]
    public bool? SendActivityLogs { get; set; }

    /// <summary>Specifies if the AzureAD Logs should be sent to the Elasticsearch cluster. Defaults to false.</summary>
    [JsonPropertyName("sendAzureadLogs")]
    public bool? SendAzureadLogs { get; set; }

    /// <summary>Specifies if the Azure Subscription Logs should be sent to the Elasticsearch cluster. Defaults to false.</summary>
    [JsonPropertyName("sendSubscriptionLogs")]
    public bool? SendSubscriptionLogs { get; set; }
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
public partial class V1beta2CloudElasticsearchSpecInitProvider
{
    /// <summary>Specifies the Email Address which should be associated with this Elasticsearch account. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("elasticCloudEmailAddress")]
    public string? ElasticCloudEmailAddress { get; set; }

    /// <summary>The Azure Region where the Elasticsearch resource should exist. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A logs block as defined below.</summary>
    [JsonPropertyName("logs")]
    public V1beta2CloudElasticsearchSpecInitProviderLogs? Logs { get; set; }

    /// <summary>Specifies if the Elasticsearch should have monitoring configured? Defaults to true. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("monitoringEnabled")]
    public bool? MonitoringEnabled { get; set; }

    /// <summary>Specifies the name of the SKU for this Elasticsearch. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Elasticsearch resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CloudElasticsearchSpecManagementPoliciesEnum>))]
public enum V1beta2CloudElasticsearchSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CloudElasticsearchSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2CloudElasticsearchSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CloudElasticsearchSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2CloudElasticsearchSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CloudElasticsearchSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CloudElasticsearchSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CloudElasticsearchSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CloudElasticsearchSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CloudElasticsearchSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CloudElasticsearchSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>CloudElasticsearchSpec defines the desired state of CloudElasticsearch</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CloudElasticsearchSpec
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
    public V1beta2CloudElasticsearchSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2CloudElasticsearchSpecForProvider ForProvider { get; set; }

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
    public V1beta2CloudElasticsearchSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2CloudElasticsearchSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2CloudElasticsearchSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2CloudElasticsearchSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CloudElasticsearchStatusAtProviderLogsFilteringTag
{
    /// <summary>Specifies the type of action which should be taken when the Tag matches the name and value. Possible values are Exclude and Include.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The name which should be used for this Elasticsearch resource. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the value of the Tag which should be filtered.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A logs block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CloudElasticsearchStatusAtProviderLogs
{
    /// <summary>A list of filtering_tag blocks as defined above.</summary>
    [JsonPropertyName("filteringTag")]
    public IList<V1beta2CloudElasticsearchStatusAtProviderLogsFilteringTag>? FilteringTag { get; set; }

    /// <summary>Specifies if the Azure Activity Logs should be sent to the Elasticsearch cluster. Defaults to false.</summary>
    [JsonPropertyName("sendActivityLogs")]
    public bool? SendActivityLogs { get; set; }

    /// <summary>Specifies if the AzureAD Logs should be sent to the Elasticsearch cluster. Defaults to false.</summary>
    [JsonPropertyName("sendAzureadLogs")]
    public bool? SendAzureadLogs { get; set; }

    /// <summary>Specifies if the Azure Subscription Logs should be sent to the Elasticsearch cluster. Defaults to false.</summary>
    [JsonPropertyName("sendSubscriptionLogs")]
    public bool? SendSubscriptionLogs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CloudElasticsearchStatusAtProvider
{
    /// <summary>The ID of the Deployment within Elastic Cloud.</summary>
    [JsonPropertyName("elasticCloudDeploymentId")]
    public string? ElasticCloudDeploymentId { get; set; }

    /// <summary>Specifies the Email Address which should be associated with this Elasticsearch account. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("elasticCloudEmailAddress")]
    public string? ElasticCloudEmailAddress { get; set; }

    /// <summary>The Default URL used for Single Sign On (SSO) to Elastic Cloud.</summary>
    [JsonPropertyName("elasticCloudSsoDefaultUrl")]
    public string? ElasticCloudSsoDefaultUrl { get; set; }

    /// <summary>The ID of the User Account within Elastic Cloud.</summary>
    [JsonPropertyName("elasticCloudUserId")]
    public string? ElasticCloudUserId { get; set; }

    /// <summary>The URL to the Elasticsearch Service associated with this Elasticsearch.</summary>
    [JsonPropertyName("elasticsearchServiceUrl")]
    public string? ElasticsearchServiceUrl { get; set; }

    /// <summary>The ID of the Elasticsearch.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The URL to the Kibana Dashboard associated with this Elasticsearch.</summary>
    [JsonPropertyName("kibanaServiceUrl")]
    public string? KibanaServiceUrl { get; set; }

    /// <summary>The URI used for SSO to the Kibana Dashboard associated with this Elasticsearch.</summary>
    [JsonPropertyName("kibanaSsoUri")]
    public string? KibanaSsoUri { get; set; }

    /// <summary>The Azure Region where the Elasticsearch resource should exist. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A logs block as defined below.</summary>
    [JsonPropertyName("logs")]
    public V1beta2CloudElasticsearchStatusAtProviderLogs? Logs { get; set; }

    /// <summary>Specifies if the Elasticsearch should have monitoring configured? Defaults to true. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("monitoringEnabled")]
    public bool? MonitoringEnabled { get; set; }

    /// <summary>The name of the Resource Group where the Elasticsearch resource should exist. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Specifies the name of the SKU for this Elasticsearch. Changing this forces a new Elasticsearch to be created.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Elasticsearch resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CloudElasticsearchStatusConditions
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

/// <summary>CloudElasticsearchStatus defines the observed state of CloudElasticsearch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CloudElasticsearchStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2CloudElasticsearchStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2CloudElasticsearchStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CloudElasticsearch is the Schema for the CloudElasticsearchs API. Manages an Elasticsearch cluster in Elastic Cloud.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2CloudElasticsearch : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2CloudElasticsearchSpec>, IStatus<V1beta2CloudElasticsearchStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "CloudElasticsearch";
    public const string KubeGroup = "elastic.azure.upbound.io";
    public const string KubePluralName = "cloudelasticsearches";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elastic.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudElasticsearch";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudElasticsearchSpec defines the desired state of CloudElasticsearch</summary>
    [JsonPropertyName("spec")]
    public required V1beta2CloudElasticsearchSpec Spec { get; set; }

    /// <summary>CloudElasticsearchStatus defines the observed state of CloudElasticsearch.</summary>
    [JsonPropertyName("status")]
    public V1beta2CloudElasticsearchStatus? Status { get; set; }
}
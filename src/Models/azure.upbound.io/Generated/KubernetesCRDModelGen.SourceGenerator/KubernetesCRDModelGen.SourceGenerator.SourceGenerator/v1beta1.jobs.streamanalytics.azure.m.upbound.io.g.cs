#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.streamanalytics.azure.m.upbound.io;
/// <summary>Job is the Schema for the Jobs API. Manages a Stream Analytics Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1JobList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Job>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "JobList";
    public const string KubeGroup = "streamanalytics.azure.m.upbound.io";
    public const string KubePluralName = "jobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "streamanalytics.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "JobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Job objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Job> Items { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderIdentity
{
    /// <summary>The identity id of the user assigned identity to use when type is UserAssigned</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Stream Analytics Job. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The account key for the Azure storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobStorageAccountAccountKeySecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>The details of the job storage account. A job_storage_account block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderJobStorageAccount
{
    /// <summary>The account key for the Azure storage account.</summary>
    [JsonPropertyName("accountKeySecretRef")]
    public V1beta1JobSpecForProviderJobStorageAccountAccountKeySecretRef? AccountKeySecretRef { get; set; }

    /// <summary>The name of the Azure storage account.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>The authentication mode of the storage account. Possible values are ConnectionString and Msi. Defaults to ConnectionString.</summary>
    [JsonPropertyName("authenticationMode")]
    public string? AuthenticationMode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta1JobSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta1JobSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1JobSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta1JobSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta1JobSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1JobSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1JobSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProviderResourceGroupNameSelector
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
    public V1beta1JobSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecForProvider
{
    /// <summary>Specifies the compatibility level for this job - which controls certain runtime behaviours of the streaming job. Possible values are 1.0, 1.1 and 1.2.</summary>
    [JsonPropertyName("compatibilityLevel")]
    public string? CompatibilityLevel { get; set; }

    /// <summary>The policy for storing stream analytics content. Possible values are JobStorageAccount, SystemAccount. Defaults to SystemAccount.</summary>
    [JsonPropertyName("contentStoragePolicy")]
    public string? ContentStoragePolicy { get; set; }

    /// <summary>Specifies the Data Locale of the Job, which should be a supported .NET Culture. Defaults to en-US.</summary>
    [JsonPropertyName("dataLocale")]
    public string? DataLocale { get; set; }

    /// <summary>Specifies the maximum tolerable delay in seconds where events arriving late could be included. Supported range is -1 (indefinite) to 1814399 (20d 23h 59m 59s). Default is 5.</summary>
    [JsonPropertyName("eventsLateArrivalMaxDelayInSeconds")]
    public double? EventsLateArrivalMaxDelayInSeconds { get; set; }

    /// <summary>Specifies the maximum tolerable delay in seconds where out-of-order events can be adjusted to be back in order. Supported range is 0 to 599 (9m 59s). Default is 0.</summary>
    [JsonPropertyName("eventsOutOfOrderMaxDelayInSeconds")]
    public double? EventsOutOfOrderMaxDelayInSeconds { get; set; }

    /// <summary>Specifies the policy which should be applied to events which arrive out of order in the input event stream. Possible values are Adjust and Drop. Default is Adjust.</summary>
    [JsonPropertyName("eventsOutOfOrderPolicy")]
    public string? EventsOutOfOrderPolicy { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1JobSpecForProviderIdentity? Identity { get; set; }

    /// <summary>The details of the job storage account. A job_storage_account block as defined below.</summary>
    [JsonPropertyName("jobStorageAccount")]
    public V1beta1JobSpecForProviderJobStorageAccount? JobStorageAccount { get; set; }

    /// <summary>The Azure Region in which the Resource Group exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the policy which should be applied to events which arrive at the output and cannot be written to the external storage due to being malformed (such as missing column values, column values of wrong type or size). Possible values are Drop and Stop. Default is Drop.</summary>
    [JsonPropertyName("outputErrorPolicy")]
    public string? OutputErrorPolicy { get; set; }

    /// <summary>The name of the Resource Group where the Stream Analytics Job should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1JobSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1JobSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The SKU Name to use for the Stream Analytics Job. Possible values are Standard, StandardV2. Defaults to Standard.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The ID of an existing Stream Analytics Cluster where the Stream Analytics Job should run.</summary>
    [JsonPropertyName("streamAnalyticsClusterId")]
    public string? StreamAnalyticsClusterId { get; set; }

    /// <summary>Specifies the number of streaming units that the streaming job uses. Supported values are 1, 3, 6 and multiples of 6 up to 120. A conversion table for V2 streaming units can be found here</summary>
    [JsonPropertyName("streamingUnits")]
    public double? StreamingUnits { get; set; }

    /// <summary>A mapping of tags assigned to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the query that will be run in the streaming job, written in Stream Analytics Query Language (SAQL).</summary>
    [JsonPropertyName("transformationQuery")]
    public string? TransformationQuery { get; set; }

    /// <summary>The type of the Stream Analytics Job. Possible values are Cloud and Edge. Defaults to Cloud. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderIdentity
{
    /// <summary>The identity id of the user assigned identity to use when type is UserAssigned</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Stream Analytics Job. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The account key for the Azure storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobStorageAccountAccountKeySecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>The details of the job storage account. A job_storage_account block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpecInitProviderJobStorageAccount
{
    /// <summary>The account key for the Azure storage account.</summary>
    [JsonPropertyName("accountKeySecretRef")]
    public V1beta1JobSpecInitProviderJobStorageAccountAccountKeySecretRef? AccountKeySecretRef { get; set; }

    /// <summary>The name of the Azure storage account.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>The authentication mode of the storage account. Possible values are ConnectionString and Msi. Defaults to ConnectionString.</summary>
    [JsonPropertyName("authenticationMode")]
    public string? AuthenticationMode { get; set; }
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
public partial class V1beta1JobSpecInitProvider
{
    /// <summary>Specifies the compatibility level for this job - which controls certain runtime behaviours of the streaming job. Possible values are 1.0, 1.1 and 1.2.</summary>
    [JsonPropertyName("compatibilityLevel")]
    public string? CompatibilityLevel { get; set; }

    /// <summary>The policy for storing stream analytics content. Possible values are JobStorageAccount, SystemAccount. Defaults to SystemAccount.</summary>
    [JsonPropertyName("contentStoragePolicy")]
    public string? ContentStoragePolicy { get; set; }

    /// <summary>Specifies the Data Locale of the Job, which should be a supported .NET Culture. Defaults to en-US.</summary>
    [JsonPropertyName("dataLocale")]
    public string? DataLocale { get; set; }

    /// <summary>Specifies the maximum tolerable delay in seconds where events arriving late could be included. Supported range is -1 (indefinite) to 1814399 (20d 23h 59m 59s). Default is 5.</summary>
    [JsonPropertyName("eventsLateArrivalMaxDelayInSeconds")]
    public double? EventsLateArrivalMaxDelayInSeconds { get; set; }

    /// <summary>Specifies the maximum tolerable delay in seconds where out-of-order events can be adjusted to be back in order. Supported range is 0 to 599 (9m 59s). Default is 0.</summary>
    [JsonPropertyName("eventsOutOfOrderMaxDelayInSeconds")]
    public double? EventsOutOfOrderMaxDelayInSeconds { get; set; }

    /// <summary>Specifies the policy which should be applied to events which arrive out of order in the input event stream. Possible values are Adjust and Drop. Default is Adjust.</summary>
    [JsonPropertyName("eventsOutOfOrderPolicy")]
    public string? EventsOutOfOrderPolicy { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1JobSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>The details of the job storage account. A job_storage_account block as defined below.</summary>
    [JsonPropertyName("jobStorageAccount")]
    public V1beta1JobSpecInitProviderJobStorageAccount? JobStorageAccount { get; set; }

    /// <summary>The Azure Region in which the Resource Group exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the policy which should be applied to events which arrive at the output and cannot be written to the external storage due to being malformed (such as missing column values, column values of wrong type or size). Possible values are Drop and Stop. Default is Drop.</summary>
    [JsonPropertyName("outputErrorPolicy")]
    public string? OutputErrorPolicy { get; set; }

    /// <summary>The SKU Name to use for the Stream Analytics Job. Possible values are Standard, StandardV2. Defaults to Standard.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The ID of an existing Stream Analytics Cluster where the Stream Analytics Job should run.</summary>
    [JsonPropertyName("streamAnalyticsClusterId")]
    public string? StreamAnalyticsClusterId { get; set; }

    /// <summary>Specifies the number of streaming units that the streaming job uses. Supported values are 1, 3, 6 and multiples of 6 up to 120. A conversion table for V2 streaming units can be found here</summary>
    [JsonPropertyName("streamingUnits")]
    public double? StreamingUnits { get; set; }

    /// <summary>A mapping of tags assigned to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the query that will be run in the streaming job, written in Stream Analytics Query Language (SAQL).</summary>
    [JsonPropertyName("transformationQuery")]
    public string? TransformationQuery { get; set; }

    /// <summary>The type of the Stream Analytics Job. Possible values are Cloud and Edge. Defaults to Cloud. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1JobSpecManagementPoliciesEnum>))]
public enum V1beta1JobSpecManagementPoliciesEnum
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
public partial class V1beta1JobSpecProviderConfigRef
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
public partial class V1beta1JobSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>JobSpec defines the desired state of Job</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1JobSpecForProvider ForProvider { get; set; }

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
    public V1beta1JobSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1JobSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1JobSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1JobSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderIdentity
{
    /// <summary>The identity id of the user assigned identity to use when type is UserAssigned</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Stream Analytics Job. Possible values are SystemAssigned and UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The details of the job storage account. A job_storage_account block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProviderJobStorageAccount
{
    /// <summary>The name of the Azure storage account.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>The authentication mode of the storage account. Possible values are ConnectionString and Msi. Defaults to ConnectionString.</summary>
    [JsonPropertyName("authenticationMode")]
    public string? AuthenticationMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusAtProvider
{
    /// <summary>Specifies the compatibility level for this job - which controls certain runtime behaviours of the streaming job. Possible values are 1.0, 1.1 and 1.2.</summary>
    [JsonPropertyName("compatibilityLevel")]
    public string? CompatibilityLevel { get; set; }

    /// <summary>The policy for storing stream analytics content. Possible values are JobStorageAccount, SystemAccount. Defaults to SystemAccount.</summary>
    [JsonPropertyName("contentStoragePolicy")]
    public string? ContentStoragePolicy { get; set; }

    /// <summary>Specifies the Data Locale of the Job, which should be a supported .NET Culture. Defaults to en-US.</summary>
    [JsonPropertyName("dataLocale")]
    public string? DataLocale { get; set; }

    /// <summary>Specifies the maximum tolerable delay in seconds where events arriving late could be included. Supported range is -1 (indefinite) to 1814399 (20d 23h 59m 59s). Default is 5.</summary>
    [JsonPropertyName("eventsLateArrivalMaxDelayInSeconds")]
    public double? EventsLateArrivalMaxDelayInSeconds { get; set; }

    /// <summary>Specifies the maximum tolerable delay in seconds where out-of-order events can be adjusted to be back in order. Supported range is 0 to 599 (9m 59s). Default is 0.</summary>
    [JsonPropertyName("eventsOutOfOrderMaxDelayInSeconds")]
    public double? EventsOutOfOrderMaxDelayInSeconds { get; set; }

    /// <summary>Specifies the policy which should be applied to events which arrive out of order in the input event stream. Possible values are Adjust and Drop. Default is Adjust.</summary>
    [JsonPropertyName("eventsOutOfOrderPolicy")]
    public string? EventsOutOfOrderPolicy { get; set; }

    /// <summary>The ID of the Stream Analytics Job.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1JobStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>The Job ID assigned by the Stream Analytics Job.</summary>
    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    /// <summary>The details of the job storage account. A job_storage_account block as defined below.</summary>
    [JsonPropertyName("jobStorageAccount")]
    public V1beta1JobStatusAtProviderJobStorageAccount? JobStorageAccount { get; set; }

    /// <summary>The Azure Region in which the Resource Group exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies the policy which should be applied to events which arrive at the output and cannot be written to the external storage due to being malformed (such as missing column values, column values of wrong type or size). Possible values are Drop and Stop. Default is Drop.</summary>
    [JsonPropertyName("outputErrorPolicy")]
    public string? OutputErrorPolicy { get; set; }

    /// <summary>The name of the Resource Group where the Stream Analytics Job should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The SKU Name to use for the Stream Analytics Job. Possible values are Standard, StandardV2. Defaults to Standard.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The ID of an existing Stream Analytics Cluster where the Stream Analytics Job should run.</summary>
    [JsonPropertyName("streamAnalyticsClusterId")]
    public string? StreamAnalyticsClusterId { get; set; }

    /// <summary>Specifies the number of streaming units that the streaming job uses. Supported values are 1, 3, 6 and multiples of 6 up to 120. A conversion table for V2 streaming units can be found here</summary>
    [JsonPropertyName("streamingUnits")]
    public double? StreamingUnits { get; set; }

    /// <summary>A mapping of tags assigned to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the query that will be run in the streaming job, written in Stream Analytics Query Language (SAQL).</summary>
    [JsonPropertyName("transformationQuery")]
    public string? TransformationQuery { get; set; }

    /// <summary>The type of the Stream Analytics Job. Possible values are Cloud and Edge. Defaults to Cloud. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatusConditions
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

/// <summary>JobStatus defines the observed state of Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1JobStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1JobStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1JobStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Job is the Schema for the Jobs API. Manages a Stream Analytics Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Job : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1JobSpec>, IStatus<V1beta1JobStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Job";
    public const string KubeGroup = "streamanalytics.azure.m.upbound.io";
    public const string KubePluralName = "jobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "streamanalytics.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Job";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>JobSpec defines the desired state of Job</summary>
    [JsonPropertyName("spec")]
    public required V1beta1JobSpec Spec { get; set; }

    /// <summary>JobStatus defines the observed state of Job.</summary>
    [JsonPropertyName("status")]
    public V1beta1JobStatus? Status { get; set; }
}
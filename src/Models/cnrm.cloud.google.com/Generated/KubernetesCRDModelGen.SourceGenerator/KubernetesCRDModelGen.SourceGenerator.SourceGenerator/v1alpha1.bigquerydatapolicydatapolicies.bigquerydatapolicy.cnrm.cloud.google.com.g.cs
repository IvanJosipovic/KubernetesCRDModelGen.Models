#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquerydatapolicy.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigQueryDataPolicyDataPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BigQueryDataPolicyDataPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryDataPolicyDataPolicyList";
    public const string KubeGroup = "bigquerydatapolicy.cnrm.cloud.google.com";
    public const string KubePluralName = "bigquerydatapolicydatapolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquerydatapolicy.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BigQueryDataPolicyDataPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1BigQueryDataPolicyDataPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1BigQueryDataPolicyDataPolicy> Items { get; set; }
}

/// <summary>The data masking policy that specifies the data masking rule to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataPolicyDataPolicySpecDataMaskingPolicy
{
    /// <summary>The available masking rules. Learn more here: https://cloud.google.com/bigquery/docs/column-data-masking-intro#masking_options. Possible values: [&quot;SHA256&quot;, &quot;ALWAYS_NULL&quot;, &quot;DEFAULT_MASKING_VALUE&quot;, &quot;LAST_FOUR_CHARACTERS&quot;, &quot;FIRST_FOUR_CHARACTERS&quot;, &quot;EMAIL_MASK&quot;, &quot;DATE_YEAR_MASK&quot;].</summary>
    [JsonPropertyName("predefinedExpression")]
    public required string PredefinedExpression { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataPolicyDataPolicySpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataPolicyDataPolicySpec
{
    /// <summary>The data masking policy that specifies the data masking rule to use.</summary>
    [JsonPropertyName("dataMaskingPolicy")]
    public V1alpha1BigQueryDataPolicyDataPolicySpecDataMaskingPolicy? DataMaskingPolicy { get; set; }

    /// <summary>The enrollment level of the service. Possible values: [&quot;COLUMN_LEVEL_SECURITY_POLICY&quot;, &quot;DATA_MASKING_POLICY&quot;].</summary>
    [JsonPropertyName("dataPolicyType")]
    public required string DataPolicyType { get; set; }

    /// <summary>Immutable. The name of the location of the data policy.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Policy tag resource name, in the format of projects/{project_number}/locations/{locationId}/taxonomies/{taxonomyId}/policyTags/{policyTag_id}.</summary>
    [JsonPropertyName("policyTag")]
    public required string PolicyTag { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1BigQueryDataPolicyDataPolicySpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The dataPolicyId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataPolicyDataPolicyStatusConditions
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
public partial class V1alpha1BigQueryDataPolicyDataPolicyStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigQueryDataPolicyDataPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>Resource name of this data policy, in the format of projects/{project_number}/locations/{locationId}/dataPolicies/{dataPolicyId}.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigQueryDataPolicyDataPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigQueryDataPolicyDataPolicySpec>, IStatus<V1alpha1BigQueryDataPolicyDataPolicyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryDataPolicyDataPolicy";
    public const string KubeGroup = "bigquerydatapolicy.cnrm.cloud.google.com";
    public const string KubePluralName = "bigquerydatapolicydatapolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquerydatapolicy.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BigQueryDataPolicyDataPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1BigQueryDataPolicyDataPolicySpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1BigQueryDataPolicyDataPolicyStatus? Status { get; set; }
}
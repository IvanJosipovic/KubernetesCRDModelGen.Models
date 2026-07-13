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
/// <summary>BigQueryDataPolicy is the Schema for the BigQueryDataPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigQueryDataPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BigQueryDataPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryDataPolicyList";
    public const string KubeGroup = "bigquerydatapolicy.cnrm.cloud.google.com";
    public const string KubePluralName = "bigquerydatapolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquerydatapolicy.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BigQueryDataPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1BigQueryDataPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1BigQueryDataPolicy> Items { get; set; }
}

/// <summary>The data masking policy that specifies the data masking rule to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataPolicySpecDataMaskingPolicy
{
    /// <summary>A predefined masking expression.</summary>
    [JsonPropertyName("predefinedExpression")]
    public string? PredefinedExpression { get; set; }
}

/// <summary>Reference to a Data Catalog Policy Tag resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataPolicySpecPolicyTagRef
{
    /// <summary>A reference to an externally managed DataCatalogPolicyTag resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/taxonomies/{{taxonomyID}}/policyTags/{{policytagID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a DataCatalogPolicyTag resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a DataCatalogPolicyTag resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. The host project of the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataPolicySpecProjectRef
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

/// <summary>BigQueryDataPolicySpec defines the desired state of BigQueryDataPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataPolicySpec
{
    /// <summary>The data masking policy that specifies the data masking rule to use.</summary>
    [JsonPropertyName("dataMaskingPolicy")]
    public V1alpha1BigQueryDataPolicySpecDataMaskingPolicy? DataMaskingPolicy { get; set; }

    /// <summary>User-assigned (human readable) ID of the data policy that needs to be unique within a project. Used as {data_policy_id} in part of the resource name.</summary>
    [JsonPropertyName("dataPolicyID")]
    public string? DataPolicyID { get; set; }

    /// <summary>Type of data policy.</summary>
    [JsonPropertyName("dataPolicyType")]
    public string? DataPolicyType { get; set; }

    /// <summary>Required. The location of the application.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Reference to a Data Catalog Policy Tag resource.</summary>
    [JsonPropertyName("policyTagRef")]
    public V1alpha1BigQueryDataPolicySpecPolicyTagRef? PolicyTagRef { get; set; }

    /// <summary>Required. The host project of the application.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1BigQueryDataPolicySpecProjectRef ProjectRef { get; set; }

    /// <summary>The BigQueryDataPolicy name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataPolicyStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataPolicyStatusObservedState
{
}

/// <summary>BigQueryDataPolicyStatus defines the config connector machine state of BigQueryDataPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataPolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigQueryDataPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BigQueryDataPolicy resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BigQueryDataPolicyStatusObservedState? ObservedState { get; set; }
}

/// <summary>BigQueryDataPolicy is the Schema for the BigQueryDataPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigQueryDataPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigQueryDataPolicySpec>, IStatus<V1alpha1BigQueryDataPolicyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryDataPolicy";
    public const string KubeGroup = "bigquerydatapolicy.cnrm.cloud.google.com";
    public const string KubePluralName = "bigquerydatapolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "bigquerydatapolicy.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BigQueryDataPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigQueryDataPolicySpec defines the desired state of BigQueryDataPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1BigQueryDataPolicySpec Spec { get; set; }

    /// <summary>BigQueryDataPolicyStatus defines the config connector machine state of BigQueryDataPolicy</summary>
    [JsonPropertyName("status")]
    public V1alpha1BigQueryDataPolicyStatus? Status { get; set; }
}
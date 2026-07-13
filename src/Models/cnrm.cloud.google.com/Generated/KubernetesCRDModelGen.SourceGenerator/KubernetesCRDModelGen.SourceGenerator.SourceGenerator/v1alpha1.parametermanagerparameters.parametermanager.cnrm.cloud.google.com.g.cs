#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.parametermanager.cnrm.cloud.google.com;
/// <summary>ParameterManagerParameter is the Schema for the ParameterManagerParameter API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ParameterManagerParameterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ParameterManagerParameter>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ParameterManagerParameterList";
    public const string KubeGroup = "parametermanager.cnrm.cloud.google.com";
    public const string KubePluralName = "parametermanagerparameters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "parametermanager.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ParameterManagerParameterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ParameterManagerParameter objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ParameterManagerParameter> Items { get; set; }
}

/// <summary>Optional. Customer managed encryption key (CMEK) to use for encrypting the Parameter Versions. If not set, the default Google-managed encryption key will be used. Cloud KMS CryptoKeys must reside in the same location as the Parameter. The expected format is `projects/*/locations/*/keyRings/*/cryptoKeys/*`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterManagerParameterSpecKmsKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterManagerParameterSpecProjectRef
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

/// <summary>ParameterManagerParameterSpec defines the desired state of ParameterManagerParameter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterManagerParameterSpec
{
    /// <summary>Optional. Specifies the format of a Parameter.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Optional. Customer managed encryption key (CMEK) to use for encrypting the Parameter Versions. If not set, the default Google-managed encryption key will be used. Cloud KMS CryptoKeys must reside in the same location as the Parameter. The expected format is `projects/*/locations/*/keyRings/*/cryptoKeys/*`.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1ParameterManagerParameterSpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>The location that this resource belongs to.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1ParameterManagerParameterSpecProjectRef ProjectRef { get; set; }

    /// <summary>The ParameterManagerParameter name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterManagerParameterStatusConditions
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

/// <summary>Output only. [Output-only] policy member strings of a Google Cloud resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterManagerParameterStatusObservedStatePolicyMember
{
    /// <summary>
    /// IAM policy binding member referring to a Google Cloud resource by
    ///  user-assigned name (https://google.aip.dev/122). If a resource is deleted
    ///  and recreated with the same name, the binding will be applicable to the new
    ///  resource.
    /// 
    ///  Example:
    ///  `principal://parametermanager.googleapis.com/projects/12345/name/locations/us-central1-a/parameters/my-parameter`
    /// </summary>
    [JsonPropertyName("iamPolicyNamePrincipal")]
    public string? IamPolicyNamePrincipal { get; set; }

    /// <summary>
    /// IAM policy binding member referring to a Google Cloud resource by
    ///  system-assigned unique identifier (https://google.aip.dev/148#uid). If a
    ///  resource is deleted and recreated with the same name, the binding will not
    ///  be applicable to the new resource
    /// 
    ///  Example:
    ///  `principal://parametermanager.googleapis.com/projects/12345/uid/locations/us-central1-a/parameters/a918fed5`
    /// </summary>
    [JsonPropertyName("iamPolicyUidPrincipal")]
    public string? IamPolicyUidPrincipal { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterManagerParameterStatusObservedState
{
    /// <summary>Output only. [Output only] Create time stamp</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Identifier. [Output only] The resource name of the Parameter in the format `projects/*/locations/*/parameters/*`</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. [Output-only] policy member strings of a Google Cloud resource.</summary>
    [JsonPropertyName("policyMember")]
    public V1alpha1ParameterManagerParameterStatusObservedStatePolicyMember? PolicyMember { get; set; }

    /// <summary>Output only. [Output only] Update time stamp</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>ParameterManagerParameterStatus defines the config connector machine state of ParameterManagerParameter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterManagerParameterStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ParameterManagerParameterStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ParameterManagerParameter resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ParameterManagerParameterStatusObservedState? ObservedState { get; set; }
}

/// <summary>ParameterManagerParameter is the Schema for the ParameterManagerParameter API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ParameterManagerParameter : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ParameterManagerParameterSpec>, IStatus<V1alpha1ParameterManagerParameterStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ParameterManagerParameter";
    public const string KubeGroup = "parametermanager.cnrm.cloud.google.com";
    public const string KubePluralName = "parametermanagerparameters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "parametermanager.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ParameterManagerParameter";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ParameterManagerParameterSpec defines the desired state of ParameterManagerParameter</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ParameterManagerParameterSpec Spec { get; set; }

    /// <summary>ParameterManagerParameterStatus defines the config connector machine state of ParameterManagerParameter</summary>
    [JsonPropertyName("status")]
    public V1alpha1ParameterManagerParameterStatus? Status { get; set; }
}
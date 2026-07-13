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
/// <summary>ParameterManagerParameterVersion is the Schema for the ParameterManagerParameterVersion API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ParameterManagerParameterVersionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ParameterManagerParameterVersion>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ParameterManagerParameterVersionList";
    public const string KubeGroup = "parametermanager.cnrm.cloud.google.com";
    public const string KubePluralName = "parametermanagerparameterversions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "parametermanager.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ParameterManagerParameterVersionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ParameterManagerParameterVersion objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ParameterManagerParameterVersion> Items { get; set; }
}

/// <summary>The resource name of the [Parameter][google.cloud.parametermanager.v1.Parameter] to create a [ParameterVersion][google.cloud.parametermanager.v1.ParameterVersion] for.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterManagerParameterVersionSpecParameterRef
{
    /// <summary>A reference to an externally managed ParameterManagerParameter resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/parameters/{{parameterID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ParameterManagerParameter resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ParameterManagerParameter resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Immutable. Payload content of a ParameterVersion resource.  This is only returned when the request provides the View value of FULL (default for GET request).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterManagerParameterVersionSpecPayload
{
    /// <summary>Required. bytes data for storing payload. Provide base64-encoded value</summary>
    [JsonPropertyName("data")]
    public required byte[] Data { get; set; }
}

/// <summary>ParameterManagerParameterVersionSpec defines the desired state of ParameterManagerParameterVersion</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterManagerParameterVersionSpec
{
    /// <summary>Optional. Disabled boolean to determine if a ParameterVersion acts as a metadata only resource (payload is never returned if disabled is true). If true any calls will always default to BASIC view even if the user explicitly passes FULL view as part of the request. A render call on a disabled resource fails with an error. Default value is False.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The resource name of the [Parameter][google.cloud.parametermanager.v1.Parameter] to create a [ParameterVersion][google.cloud.parametermanager.v1.ParameterVersion] for.</summary>
    [JsonPropertyName("parameterRef")]
    public required V1alpha1ParameterManagerParameterVersionSpecParameterRef ParameterRef { get; set; }

    /// <summary>Required. Immutable. Payload content of a ParameterVersion resource.  This is only returned when the request provides the View value of FULL (default for GET request).</summary>
    [JsonPropertyName("payload")]
    public required V1alpha1ParameterManagerParameterVersionSpecPayload Payload { get; set; }

    /// <summary>The ParameterManagerParameterVersion name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterManagerParameterVersionStatusConditions
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
public partial class V1alpha1ParameterManagerParameterVersionStatusObservedState
{
    /// <summary>Output only. [Output only] Create time stamp</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Optional. Output only. [Output only] The resource name of the KMS key version used to encrypt the ParameterVersion payload. This field is populated only if the Parameter resource has customer managed encryption key (CMEK) configured.</summary>
    [JsonPropertyName("kmsKeyVersion")]
    public string? KmsKeyVersion { get; set; }

    /// <summary>Output only. [Output only] Update time stamp</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>ParameterManagerParameterVersionStatus defines the config connector machine state of ParameterManagerParameterVersion</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ParameterManagerParameterVersionStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ParameterManagerParameterVersionStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ParameterManagerParameterVersion resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ParameterManagerParameterVersionStatusObservedState? ObservedState { get; set; }
}

/// <summary>ParameterManagerParameterVersion is the Schema for the ParameterManagerParameterVersion API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ParameterManagerParameterVersion : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ParameterManagerParameterVersionSpec>, IStatus<V1alpha1ParameterManagerParameterVersionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ParameterManagerParameterVersion";
    public const string KubeGroup = "parametermanager.cnrm.cloud.google.com";
    public const string KubePluralName = "parametermanagerparameterversions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "parametermanager.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ParameterManagerParameterVersion";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ParameterManagerParameterVersionSpec defines the desired state of ParameterManagerParameterVersion</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ParameterManagerParameterVersionSpec Spec { get; set; }

    /// <summary>ParameterManagerParameterVersionStatus defines the config connector machine state of ParameterManagerParameterVersion</summary>
    [JsonPropertyName("status")]
    public V1alpha1ParameterManagerParameterVersionStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.securesourcemanager.cnrm.cloud.google.com;
/// <summary>SecureSourceManagerInstance is the Schema for the SecureSourceManagerInstance API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SecureSourceManagerInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SecureSourceManagerInstance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SecureSourceManagerInstanceList";
    public const string KubeGroup = "securesourcemanager.cnrm.cloud.google.com";
    public const string KubePluralName = "securesourcemanagerinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "securesourcemanager.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecureSourceManagerInstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1SecureSourceManagerInstance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1SecureSourceManagerInstance> Items { get; set; }
}

/// <summary>Optional. Immutable. Customer-managed encryption key name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecureSourceManagerInstanceSpecKmsKeyRef
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

/// <summary>Required. Immutable. CA pool resource, resource must in the format of `projects/{project}/locations/{location}/caPools/{ca_pool}`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecureSourceManagerInstanceSpecPrivateConfigCaPoolRef
{
    /// <summary>A reference to an externally managed PrivateCACAPool. Should be in the format `projects/{project_id}/locations/{region}/caPools/{caPool}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `PrivateCACAPool` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `PrivateCACAPool` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. PrivateConfig includes settings for private instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecureSourceManagerInstanceSpecPrivateConfig
{
    /// <summary>Required. Immutable. CA pool resource, resource must in the format of `projects/{project}/locations/{location}/caPools/{ca_pool}`.</summary>
    [JsonPropertyName("caPoolRef")]
    public V1beta1SecureSourceManagerInstanceSpecPrivateConfigCaPoolRef? CaPoolRef { get; set; }

    /// <summary>Required. Immutable. Indicate if it&apos;s private instance.</summary>
    [JsonPropertyName("isPrivate")]
    public bool? IsPrivate { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecureSourceManagerInstanceSpecProjectRef
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

/// <summary>SecureSourceManagerInstanceSpec defines the desired state of SecureSourceManagerInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecureSourceManagerInstanceSpec
{
    /// <summary>Optional. Immutable. Customer-managed encryption key name.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1SecureSourceManagerInstanceSpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Optional. Labels as key value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable. Location of the instance.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Optional. PrivateConfig includes settings for private instance.</summary>
    [JsonPropertyName("privateConfig")]
    public V1beta1SecureSourceManagerInstanceSpecPrivateConfig? PrivateConfig { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1beta1SecureSourceManagerInstanceSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecureSourceManagerInstanceStatusConditions
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

/// <summary>Output only. A list of hostnames for this instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecureSourceManagerInstanceStatusObservedStateHostConfig
{
    /// <summary>Output only. API hostname.</summary>
    [JsonPropertyName("api")]
    public string? Api { get; set; }

    /// <summary>Output only. Git HTTP hostname.</summary>
    [JsonPropertyName("gitHTTP")]
    public string? GitHTTP { get; set; }

    /// <summary>Output only. Git SSH hostname.</summary>
    [JsonPropertyName("gitSSH")]
    public string? GitSSH { get; set; }

    /// <summary>Output only. HTML hostname.</summary>
    [JsonPropertyName("html")]
    public string? Html { get; set; }
}

/// <summary>Optional. PrivateConfig includes settings for private instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecureSourceManagerInstanceStatusObservedStatePrivateConfig
{
    /// <summary>Output only. Service Attachment for HTTP, resource is in the format of `projects/{project}/regions/{region}/serviceAttachments/{service_attachment}`.</summary>
    [JsonPropertyName("httpServiceAttachment")]
    public string? HttpServiceAttachment { get; set; }

    /// <summary>Output only. Service Attachment for SSH, resource is in the format of `projects/{project}/regions/{region}/serviceAttachments/{service_attachment}`.</summary>
    [JsonPropertyName("sshServiceAttachment")]
    public string? SshServiceAttachment { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecureSourceManagerInstanceStatusObservedState
{
    /// <summary>Output only. Create timestamp.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. A list of hostnames for this instance.</summary>
    [JsonPropertyName("hostConfig")]
    public V1beta1SecureSourceManagerInstanceStatusObservedStateHostConfig? HostConfig { get; set; }

    /// <summary>Optional. PrivateConfig includes settings for private instance.</summary>
    [JsonPropertyName("privateConfig")]
    public V1beta1SecureSourceManagerInstanceStatusObservedStatePrivateConfig? PrivateConfig { get; set; }

    /// <summary>Output only. Current state of the instance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. An optional field providing information about the current instance state.</summary>
    [JsonPropertyName("stateNote")]
    public string? StateNote { get; set; }

    /// <summary>Output only. Update timestamp.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>SecureSourceManagerInstanceStatus defines the config connector machine state of SecureSourceManagerInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecureSourceManagerInstanceStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SecureSourceManagerInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the SecureSourceManagerInstance resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1SecureSourceManagerInstanceStatusObservedState? ObservedState { get; set; }
}

/// <summary>SecureSourceManagerInstance is the Schema for the SecureSourceManagerInstance API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SecureSourceManagerInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SecureSourceManagerInstanceSpec?>, IStatus<V1beta1SecureSourceManagerInstanceStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SecureSourceManagerInstance";
    public const string KubeGroup = "securesourcemanager.cnrm.cloud.google.com";
    public const string KubePluralName = "securesourcemanagerinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "securesourcemanager.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecureSourceManagerInstance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecureSourceManagerInstanceSpec defines the desired state of SecureSourceManagerInstance</summary>
    [JsonPropertyName("spec")]
    public V1beta1SecureSourceManagerInstanceSpec? Spec { get; set; }

    /// <summary>SecureSourceManagerInstanceStatus defines the config connector machine state of SecureSourceManagerInstance</summary>
    [JsonPropertyName("status")]
    public V1beta1SecureSourceManagerInstanceStatus? Status { get; set; }
}
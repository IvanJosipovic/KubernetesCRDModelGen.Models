#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.gkehub.cnrm.cloud.google.com;
/// <summary>GKEHubMembershipBinding is the Schema for the gkehub API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1GKEHubMembershipBindingList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1GKEHubMembershipBinding>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "GKEHubMembershipBindingList";
    public const string KubeGroup = "gkehub.cnrm.cloud.google.com";
    public const string KubePluralName = "gkehubmembershipbindings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gkehub.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GKEHubMembershipBindingList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1GKEHubMembershipBinding objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1GKEHubMembershipBinding> Items { get; set; }
}

/// <summary>Immutable. The membership that this binding belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEHubMembershipBindingSpecMembershipRef
{
    /// <summary>The name of the membership. Allowed value: The Google Cloud resource name of a `GKEHubMembership` resource (format: `projects/{{project}}/locations/{{location}}/memberships/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The scope that this binding is bound to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEHubMembershipBindingSpecScopeRef
{
    /// <summary>The name of the scope. Allowed value: The Google Cloud resource name of a `GKEHubScope` resource (format: `projects/{{project}}/locations/{{location}}/scopes/{{name}}`).</summary>
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
public partial class V1alpha1GKEHubMembershipBindingSpec
{
    /// <summary>Optional. Labels for this MembershipBinding.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable. The membership that this binding belongs to.</summary>
    [JsonPropertyName("membershipRef")]
    public required V1alpha1GKEHubMembershipBindingSpecMembershipRef MembershipRef { get; set; }

    /// <summary>Immutable. Optional. The resourceID of the resource; if not provided, the name of the resource will be used as the resourceID.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. The scope that this binding is bound to.</summary>
    [JsonPropertyName("scopeRef")]
    public required V1alpha1GKEHubMembershipBindingSpecScopeRef ScopeRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEHubMembershipBindingStatusConditions
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

/// <summary>Output only. Code describes the state of a MembershipBinding resource. Possible values: CODE_UNSPECIFIED, CREATING, READY, DELETING, UPDATING</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1GKEHubMembershipBindingStatusObservedStateStateCodeEnum>))]
public enum V1alpha1GKEHubMembershipBindingStatusObservedStateStateCodeEnum
{
    [EnumMember(Value = "CODE_UNSPECIFIED"), JsonStringEnumMemberName("CODE_UNSPECIFIED")]
    CODEUNSPECIFIED,
    [EnumMember(Value = "CREATING"), JsonStringEnumMemberName("CREATING")]
    CREATING,
    [EnumMember(Value = "READY"), JsonStringEnumMemberName("READY")]
    READY,
    [EnumMember(Value = "DELETING"), JsonStringEnumMemberName("DELETING")]
    DELETING,
    [EnumMember(Value = "UPDATING"), JsonStringEnumMemberName("UPDATING")]
    UPDATING
}

/// <summary>Output only. State of the membershipbinding resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEHubMembershipBindingStatusObservedStateState
{
    /// <summary>Output only. Code describes the state of a MembershipBinding resource. Possible values: CODE_UNSPECIFIED, CREATING, READY, DELETING, UPDATING</summary>
    [JsonPropertyName("code")]
    public V1alpha1GKEHubMembershipBindingStatusObservedStateStateCodeEnum? Code { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEHubMembershipBindingStatusObservedState
{
    /// <summary>Output only. The time at which this binding was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The time at which this binding was deleted.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>Output only. State of the membershipbinding resource.</summary>
    [JsonPropertyName("state")]
    public V1alpha1GKEHubMembershipBindingStatusObservedStateState? State { get; set; }

    /// <summary>Output only. Google-generated UUID for this resource. This is unique across all membershipbinding resources. If a membershipbinding resource is deleted and another with the same name is created, it will have a different uid.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The time at which this binding was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEHubMembershipBindingStatus
{
    /// <summary>Conditions represent the latest available observations of the GKEHubMembershipBinding&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1GKEHubMembershipBindingStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the GKEHubMembershipBinding resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1GKEHubMembershipBindingStatusObservedState? ObservedState { get; set; }
}

/// <summary>GKEHubMembershipBinding is the Schema for the gkehub API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1GKEHubMembershipBinding : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1GKEHubMembershipBindingSpec>, IStatus<V1alpha1GKEHubMembershipBindingStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "GKEHubMembershipBinding";
    public const string KubeGroup = "gkehub.cnrm.cloud.google.com";
    public const string KubePluralName = "gkehubmembershipbindings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gkehub.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GKEHubMembershipBinding";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1GKEHubMembershipBindingSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1GKEHubMembershipBindingStatus? Status { get; set; }
}
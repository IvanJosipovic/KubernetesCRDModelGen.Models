#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.accesscontextmanager.cnrm.cloud.google.com;
/// <summary>AccessContextManagerAccessPolicy is the Schema for the AccessContextManagerAccessPolicy API As per https://cloud.google.com/config-connector/docs/reference/resource-docs/accesscontextmanager/accesscontextmanageraccesspolicy#annotations the parent is organization which is stored in the cnrm.cloud.google.com/organization-id annotation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccessContextManagerAccessPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AccessContextManagerAccessPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccessContextManagerAccessPolicyList";
    public const string KubeGroup = "accesscontextmanager.cnrm.cloud.google.com";
    public const string KubePluralName = "accesscontextmanageraccesspolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "accesscontextmanager.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccessContextManagerAccessPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1AccessContextManagerAccessPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1AccessContextManagerAccessPolicy> Items { get; set; }
}

/// <summary>AccessContextManagerAccessPolicySpec defines the desired state of AccessContextManagerAccessPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerAccessPolicySpec
{
    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Human readable title. Does not affect behavior.</summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerAccessPolicyStatusConditions
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

/// <summary>AccessContextManagerAccessPolicyStatus defines the config connector machine state of AccessContextManagerAccessPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AccessContextManagerAccessPolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AccessContextManagerAccessPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. Time the AccessPolicy was created in UTC.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Resource name of the AccessPolicy. Format: {policy_id}.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Output only. Time the AccessPolicy was updated in UTC.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>AccessContextManagerAccessPolicy is the Schema for the AccessContextManagerAccessPolicy API As per https://cloud.google.com/config-connector/docs/reference/resource-docs/accesscontextmanager/accesscontextmanageraccesspolicy#annotations the parent is organization which is stored in the cnrm.cloud.google.com/organization-id annotation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AccessContextManagerAccessPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AccessContextManagerAccessPolicySpec>, IStatus<V1beta1AccessContextManagerAccessPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AccessContextManagerAccessPolicy";
    public const string KubeGroup = "accesscontextmanager.cnrm.cloud.google.com";
    public const string KubePluralName = "accesscontextmanageraccesspolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "accesscontextmanager.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AccessContextManagerAccessPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AccessContextManagerAccessPolicySpec defines the desired state of AccessContextManagerAccessPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta1AccessContextManagerAccessPolicySpec Spec { get; set; }

    /// <summary>AccessContextManagerAccessPolicyStatus defines the config connector machine state of AccessContextManagerAccessPolicy</summary>
    [JsonPropertyName("status")]
    public V1beta1AccessContextManagerAccessPolicyStatus? Status { get; set; }
}
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
/// <summary>GKEHubScopeRBACRoleBinding is the Schema for the gkehub API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1GKEHubScopeRBACRoleBindingList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1GKEHubScopeRBACRoleBinding>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "GKEHubScopeRBACRoleBindingList";
    public const string KubeGroup = "gkehub.cnrm.cloud.google.com";
    public const string KubePluralName = "gkehubscoperbacrolebindings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gkehub.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GKEHubScopeRBACRoleBindingList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1GKEHubScopeRBACRoleBinding objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1GKEHubScopeRBACRoleBinding> Items { get; set; }
}

/// <summary>predefined_role is the Kubernetes default role to use. Possible values: UNKNOWN, ADMIN, EDIT, VIEW, ANTHOS_SUPPORT</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1GKEHubScopeRBACRoleBindingSpecRolePredefinedRoleEnum>))]
public enum V1alpha1GKEHubScopeRBACRoleBindingSpecRolePredefinedRoleEnum
{
    [EnumMember(Value = "UNKNOWN"), JsonStringEnumMemberName("UNKNOWN")]
    UNKNOWN,
    [EnumMember(Value = "ADMIN"), JsonStringEnumMemberName("ADMIN")]
    ADMIN,
    [EnumMember(Value = "EDIT"), JsonStringEnumMemberName("EDIT")]
    EDIT,
    [EnumMember(Value = "VIEW"), JsonStringEnumMemberName("VIEW")]
    VIEW,
    [EnumMember(Value = "ANTHOS_SUPPORT"), JsonStringEnumMemberName("ANTHOS_SUPPORT")]
    ANTHOSSUPPORT
}

/// <summary>Required. Role to bind to the principal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEHubScopeRBACRoleBindingSpecRole
{
    /// <summary>Optional. custom_role is the name of a custom KubernetesClusterRole to use.</summary>
    [JsonPropertyName("customRole")]
    public string? CustomRole { get; set; }

    /// <summary>predefined_role is the Kubernetes default role to use. Possible values: UNKNOWN, ADMIN, EDIT, VIEW, ANTHOS_SUPPORT</summary>
    [JsonPropertyName("predefinedRole")]
    public V1alpha1GKEHubScopeRBACRoleBindingSpecRolePredefinedRoleEnum? PredefinedRole { get; set; }
}

/// <summary>Immutable. The scope that this rbac role binding belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEHubScopeRBACRoleBindingSpecScopeRef
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
public partial class V1alpha1GKEHubScopeRBACRoleBindingSpec
{
    /// <summary>Immutable. group is the group, as seen by the kubernetes cluster. One of &apos;user&apos; or &apos;group&apos; must be specified.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Optional. Labels for this RBACRoleBinding.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable. Optional. The rbacRoleBindingID of the resource; if not provided, the name of the resource will be used as the rbacRoleBindingID.</summary>
    [JsonPropertyName("rbacRoleBindingID")]
    public string? RbacRoleBindingID { get; set; }

    /// <summary>Required. Role to bind to the principal.</summary>
    [JsonPropertyName("role")]
    public required V1alpha1GKEHubScopeRBACRoleBindingSpecRole Role { get; set; }

    /// <summary>Immutable. The scope that this rbac role binding belongs to.</summary>
    [JsonPropertyName("scopeRef")]
    public required V1alpha1GKEHubScopeRBACRoleBindingSpecScopeRef ScopeRef { get; set; }

    /// <summary>Immutable. user is the name of the user as seen by the kubernetes cluster, example &quot;alice&quot; or &quot;alice@domain.tld&quot;. One of &apos;user&apos; or &apos;group&apos; must be specified.</summary>
    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEHubScopeRBACRoleBindingStatusConditions
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

/// <summary>Output only. Code describes the state of a RBACRoleBinding resource. Possible values: CODE_UNSPECIFIED, CREATING, READY, DELETING, UPDATING</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1GKEHubScopeRBACRoleBindingStatusObservedStateStateCodeEnum>))]
public enum V1alpha1GKEHubScopeRBACRoleBindingStatusObservedStateStateCodeEnum
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

/// <summary>Output only. State of the rbac role binding resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEHubScopeRBACRoleBindingStatusObservedStateState
{
    /// <summary>Output only. Code describes the state of a RBACRoleBinding resource. Possible values: CODE_UNSPECIFIED, CREATING, READY, DELETING, UPDATING</summary>
    [JsonPropertyName("code")]
    public V1alpha1GKEHubScopeRBACRoleBindingStatusObservedStateStateCodeEnum? Code { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEHubScopeRBACRoleBindingStatusObservedState
{
    /// <summary>Output only. The time at which this rbac role binding was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The time at which this rbac role binding was deleted.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>Output only. State of the rbac role binding resource.</summary>
    [JsonPropertyName("state")]
    public V1alpha1GKEHubScopeRBACRoleBindingStatusObservedStateState? State { get; set; }

    /// <summary>Output only. Google-generated UUID for this resource. This is unique across all rbac role binding resources. If a rbac role binding resource is deleted and another with the same name is created, it will have a different uid.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The time at which this rbac role binding was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GKEHubScopeRBACRoleBindingStatus
{
    /// <summary>Conditions represent the latest available observations of the GKEHubScopeRBACRoleBinding&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1GKEHubScopeRBACRoleBindingStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the GKEHubScopeRBACRoleBinding resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1GKEHubScopeRBACRoleBindingStatusObservedState? ObservedState { get; set; }
}

/// <summary>GKEHubScopeRBACRoleBinding is the Schema for the gkehub API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1GKEHubScopeRBACRoleBinding : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1GKEHubScopeRBACRoleBindingSpec>, IStatus<V1alpha1GKEHubScopeRBACRoleBindingStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "GKEHubScopeRBACRoleBinding";
    public const string KubeGroup = "gkehub.cnrm.cloud.google.com";
    public const string KubePluralName = "gkehubscoperbacrolebindings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gkehub.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GKEHubScopeRBACRoleBinding";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1GKEHubScopeRBACRoleBindingSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1GKEHubScopeRBACRoleBindingStatus? Status { get; set; }
}
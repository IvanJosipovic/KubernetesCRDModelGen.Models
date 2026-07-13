#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.securitycenter.cnrm.cloud.google.com;
/// <summary>SecurityCenterMuteConfig is the Schema for the SecurityCenterMuteConfig API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecurityCenterMuteConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecurityCenterMuteConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecurityCenterMuteConfigList";
    public const string KubeGroup = "securitycenter.cnrm.cloud.google.com";
    public const string KubePluralName = "securitycentermuteconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "securitycenter.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecurityCenterMuteConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SecurityCenterMuteConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SecurityCenterMuteConfig> Items { get; set; }
}

/// <summary>The organization that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityCenterMuteConfigSpecOrganizationRef
{
    /// <summary>The &apos;name&apos; field of an organization, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public required string External { get; set; }
}

/// <summary>Optional. The type of the mute config, which determines what type of mute state the config affects. The static mute state takes precedence over the dynamic mute state. Immutable after creation. STATIC by default if not set during creation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecurityCenterMuteConfigSpecTypeEnum>))]
public enum V1alpha1SecurityCenterMuteConfigSpecTypeEnum
{
    [EnumMember(Value = "MUTE_CONFIG_TYPE_UNSPECIFIED"), JsonStringEnumMemberName("MUTE_CONFIG_TYPE_UNSPECIFIED")]
    MUTECONFIGTYPEUNSPECIFIED,
    [EnumMember(Value = "STATIC"), JsonStringEnumMemberName("STATIC")]
    STATIC,
    [EnumMember(Value = "DYNAMIC"), JsonStringEnumMemberName("DYNAMIC")]
    DYNAMIC
}

/// <summary>SecurityCenterMuteConfigSpec defines the desired state of SecurityCenterMuteConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityCenterMuteConfigSpec
{
    /// <summary>A description of the mute config.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. The expiry of the mute config. Only applicable for dynamic configs. If the expiry is set, when the config expires, it is removed from all findings.</summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary>Required. An expression that defines the filter to apply across create/update events of findings. While creating a filter string, be mindful of the scope in which the mute configuration is being created. E.g., If a filter contains project = X but is created under the project = Y scope, it might not match any findings.</summary>
    [JsonPropertyName("filter")]
    public required string Filter { get; set; }

    /// <summary>The organization that this resource belongs to.</summary>
    [JsonPropertyName("organizationRef")]
    public required V1alpha1SecurityCenterMuteConfigSpecOrganizationRef OrganizationRef { get; set; }

    /// <summary>The SecurityCenterMuteConfig name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. The type of the mute config, which determines what type of mute state the config affects. The static mute state takes precedence over the dynamic mute state. Immutable after creation. STATIC by default if not set during creation.</summary>
    [JsonPropertyName("type")]
    public V1alpha1SecurityCenterMuteConfigSpecTypeEnum? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityCenterMuteConfigStatusConditions
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
public partial class V1alpha1SecurityCenterMuteConfigStatusObservedState
{
    /// <summary>Output only. The time at which the mute config was created. This field is set by the server and will be ignored if provided on config creation.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Email address of the user who last edited the mute config. This field is set by the server and will be ignored if provided on config creation or update.</summary>
    [JsonPropertyName("mostRecentEditor")]
    public string? MostRecentEditor { get; set; }

    /// <summary>Output only. The most recent time at which the mute config was updated. This field is set by the server and will be ignored if provided on config creation or update.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>SecurityCenterMuteConfigStatus defines the config connector machine state of SecurityCenterMuteConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityCenterMuteConfigStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SecurityCenterMuteConfigStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the SecurityCenterMuteConfig resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1SecurityCenterMuteConfigStatusObservedState? ObservedState { get; set; }
}

/// <summary>SecurityCenterMuteConfig is the Schema for the SecurityCenterMuteConfig API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecurityCenterMuteConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecurityCenterMuteConfigSpec>, IStatus<V1alpha1SecurityCenterMuteConfigStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecurityCenterMuteConfig";
    public const string KubeGroup = "securitycenter.cnrm.cloud.google.com";
    public const string KubePluralName = "securitycentermuteconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "securitycenter.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecurityCenterMuteConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecurityCenterMuteConfigSpec defines the desired state of SecurityCenterMuteConfig</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SecurityCenterMuteConfigSpec Spec { get; set; }

    /// <summary>SecurityCenterMuteConfigStatus defines the config connector machine state of SecurityCenterMuteConfig</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecurityCenterMuteConfigStatus? Status { get; set; }
}
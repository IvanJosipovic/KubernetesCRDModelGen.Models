#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iam.cnrm.cloud.google.com;
/// <summary>IAMAuditConfig is the schema for the IAM audit logging API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IAMAuditConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1IAMAuditConfig>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IAMAuditConfigList";
    public const string KubeGroup = "iam.cnrm.cloud.google.com";
    public const string KubePluralName = "iamauditconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IAMAuditConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1IAMAuditConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1IAMAuditConfig> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMAuditConfigSpecAuditLogConfigs
{
    /// <summary>Identities that do not cause logging for this type of permission. The format is the same as that for &apos;members&apos; in IAMPolicy/IAMPolicyMember.</summary>
    [JsonPropertyName("exemptedMembers")]
    public IList<string>? ExemptedMembers { get; set; }

    /// <summary>Permission type for which logging is to be configured. Must be one of &apos;DATA_READ&apos;, &apos;DATA_WRITE&apos;, or &apos;ADMIN_READ&apos;.</summary>
    [JsonPropertyName("logType")]
    public required string LogType { get; set; }
}

/// <summary>Immutable. Required. The GCP resource to set the IAMAuditConfig on (e.g. project).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMAuditConfigSpecResourceRef
{
    /// <summary>APIVersion of the referenced resource</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>The external name of the referenced resource</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Kind of the referenced resource</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>IAMAuditConfigSpec defines the desired state of IAMAuditConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMAuditConfigSpec
{
    /// <summary>Required. The configuration for logging of each type of permission.</summary>
    [JsonPropertyName("auditLogConfigs")]
    public required IList<V1beta1IAMAuditConfigSpecAuditLogConfigs> AuditLogConfigs { get; set; }

    /// <summary>Immutable. Required. The GCP resource to set the IAMAuditConfig on (e.g. project).</summary>
    [JsonPropertyName("resourceRef")]
    public required V1beta1IAMAuditConfigSpecResourceRef ResourceRef { get; set; }

    /// <summary>Immutable. Required. The service for which to enable Data Access audit logs. The special value &apos;allServices&apos; covers all services. Note that if there are audit configs covering both &apos;allServices&apos; and a specific service, then the union of the two audit configs is used for that service: the &apos;logTypes&apos; specified in each &apos;auditLogConfig&apos; are enabled, and the &apos;exemptedMembers&apos; in each &apos;auditLogConfig&apos; are exempted.</summary>
    [JsonPropertyName("service")]
    public required string Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMAuditConfigStatusConditions
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

/// <summary>IAMAuditConfigStatus defines the observed state of IAMAuditConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IAMAuditConfigStatus
{
    /// <summary>Conditions represent the latest available observations of the IAMAuditConfig&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IAMAuditConfigStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>IAMAuditConfig is the schema for the IAM audit logging API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IAMAuditConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IAMAuditConfigSpec?>, IStatus<V1beta1IAMAuditConfigStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IAMAuditConfig";
    public const string KubeGroup = "iam.cnrm.cloud.google.com";
    public const string KubePluralName = "iamauditconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IAMAuditConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IAMAuditConfigSpec defines the desired state of IAMAuditConfig.</summary>
    [JsonPropertyName("spec")]
    public V1beta1IAMAuditConfigSpec? Spec { get; set; }

    /// <summary>IAMAuditConfigStatus defines the observed state of IAMAuditConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1IAMAuditConfigStatus? Status { get; set; }
}
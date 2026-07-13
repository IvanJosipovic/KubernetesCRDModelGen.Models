#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.services.k8s.aws;
/// <summary>FieldExport is the schema for the FieldExport API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FieldExportList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1FieldExport>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FieldExportList";
    public const string KubeGroup = "services.k8s.aws";
    public const string KubePluralName = "fieldexports";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FieldExportList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1FieldExport objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1FieldExport> Items { get; set; }
}

/// <summary>
/// NamespacedResource provides all the values necessary to identify an ACK
/// resource of a given type (within the same namespace as the custom resource
/// containing this type).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FieldExportSpecFromResource
{
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ResourceFieldSelector provides the values necessary to identify an individual
/// field on an individual K8s resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FieldExportSpecFrom
{
    [JsonPropertyName("path")]
    public required string Path { get; set; }

    /// <summary>
    /// NamespacedResource provides all the values necessary to identify an ACK
    /// resource of a given type (within the same namespace as the custom resource
    /// containing this type).
    /// </summary>
    [JsonPropertyName("resource")]
    public required V1alpha1FieldExportSpecFromResource Resource { get; set; }
}

/// <summary>
/// FieldExportOutputType represents all types that can be produced by a field
/// export operation
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1FieldExportSpecToKindEnum>))]
public enum V1alpha1FieldExportSpecToKindEnum
{
    [EnumMember(Value = "configmap"), JsonStringEnumMemberName("configmap")]
    Configmap,
    [EnumMember(Value = "secret"), JsonStringEnumMemberName("secret")]
    Secret
}

/// <summary>
/// FieldExportTarget provides the values necessary to identify the
/// output path for a field export.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FieldExportSpecTo
{
    /// <summary>Key overrides the default value (`&lt;namespace&gt;.&lt;FieldExport-resource-name&gt;`) for the FieldExport target</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// FieldExportOutputType represents all types that can be produced by a field
    /// export operation
    /// </summary>
    [JsonPropertyName("kind")]
    public required V1alpha1FieldExportSpecToKindEnum Kind { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace is marked as optional, so we cannot compose `NamespacedName`</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>FieldExportSpec defines the desired state of the FieldExport.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FieldExportSpec
{
    /// <summary>
    /// ResourceFieldSelector provides the values necessary to identify an individual
    /// field on an individual K8s resource.
    /// </summary>
    [JsonPropertyName("from")]
    public required V1alpha1FieldExportSpecFrom From { get; set; }

    /// <summary>
    /// FieldExportTarget provides the values necessary to identify the
    /// output path for a field export.
    /// </summary>
    [JsonPropertyName("to")]
    public required V1alpha1FieldExportSpecTo To { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FieldExportStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>FieldExportStatus defines the observed status of the FieldExport.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FieldExportStatus
{
    /// <summary>
    /// A collection of `ackv1alpha1.Condition` objects that describe the various
    /// recoverable states of the field CR
    /// </summary>
    [JsonPropertyName("conditions")]
    public required IList<V1alpha1FieldExportStatusConditions> Conditions { get; set; }
}

/// <summary>FieldExport is the schema for the FieldExport API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FieldExport : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1FieldExportSpec?>, IStatus<V1alpha1FieldExportStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FieldExport";
    public const string KubeGroup = "services.k8s.aws";
    public const string KubePluralName = "fieldexports";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FieldExport";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FieldExportSpec defines the desired state of the FieldExport.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1FieldExportSpec? Spec { get; set; }

    /// <summary>FieldExportStatus defines the observed status of the FieldExport.</summary>
    [JsonPropertyName("status")]
    public V1alpha1FieldExportStatus? Status { get; set; }
}
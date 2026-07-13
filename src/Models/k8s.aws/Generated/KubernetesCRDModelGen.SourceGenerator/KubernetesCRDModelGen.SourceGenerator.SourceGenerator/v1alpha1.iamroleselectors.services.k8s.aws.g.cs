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
/// <summary>IAMRoleSelector is the schema for the IAMRoleSelector API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IAMRoleSelectorList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1IAMRoleSelector>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IAMRoleSelectorList";
    public const string KubeGroup = "services.k8s.aws";
    public const string KubePluralName = "iamroleselectors";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IAMRoleSelectorList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1IAMRoleSelector objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1IAMRoleSelector> Items { get; set; }
}

/// <summary>LabelSelector is a label query over a set of resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAMRoleSelectorSpecNamespaceSelectorLabelSelector
{
    [JsonPropertyName("matchLabels")]
    public required IDictionary<string, string> MatchLabels { get; set; }
}

/// <summary>IAMRoleSelectorSpec defines the desired state of IAMRoleSelector</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAMRoleSelectorSpecNamespaceSelector
{
    /// <summary>LabelSelector is a label query over a set of resources.</summary>
    [JsonPropertyName("labelSelector")]
    public V1alpha1IAMRoleSelectorSpecNamespaceSelectorLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("names")]
    public required IList<string> Names { get; set; }
}

/// <summary>LabelSelector is a label query over a set of resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAMRoleSelectorSpecResourceLabelSelector
{
    [JsonPropertyName("matchLabels")]
    public required IDictionary<string, string> MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAMRoleSelectorSpecResourceTypeSelector
{
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAMRoleSelectorSpec
{
    [JsonPropertyName("arn")]
    public required string Arn { get; set; }

    /// <summary>IAMRoleSelectorSpec defines the desired state of IAMRoleSelector</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha1IAMRoleSelectorSpecNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>LabelSelector is a label query over a set of resources.</summary>
    [JsonPropertyName("resourceLabelSelector")]
    public V1alpha1IAMRoleSelectorSpecResourceLabelSelector? ResourceLabelSelector { get; set; }

    [JsonPropertyName("resourceTypeSelector")]
    public IList<V1alpha1IAMRoleSelectorSpecResourceTypeSelector>? ResourceTypeSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IAMRoleSelectorStatus
{
}

/// <summary>IAMRoleSelector is the schema for the IAMRoleSelector API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IAMRoleSelector : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1IAMRoleSelectorSpec?>, IStatus<V1alpha1IAMRoleSelectorStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IAMRoleSelector";
    public const string KubeGroup = "services.k8s.aws";
    public const string KubePluralName = "iamroleselectors";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IAMRoleSelector";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1alpha1IAMRoleSelectorSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1IAMRoleSelectorStatus? Status { get; set; }
}
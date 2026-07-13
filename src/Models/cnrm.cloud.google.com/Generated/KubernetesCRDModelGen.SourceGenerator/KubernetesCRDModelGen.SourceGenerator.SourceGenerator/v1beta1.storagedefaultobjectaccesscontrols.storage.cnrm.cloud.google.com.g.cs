#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StorageDefaultObjectAccessControlList : IKubernetesObject<V1ListMeta>, IItems<V1beta1StorageDefaultObjectAccessControl>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StorageDefaultObjectAccessControlList";
    public const string KubeGroup = "storage.cnrm.cloud.google.com";
    public const string KubePluralName = "storagedefaultobjectaccesscontrols";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageDefaultObjectAccessControlList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1StorageDefaultObjectAccessControl objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1StorageDefaultObjectAccessControl> Items { get; set; }
}

/// <summary>Reference to the bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageDefaultObjectAccessControlSpecBucketRef
{
    /// <summary>Allowed value: The `name` field of a `StorageBucket` resource.</summary>
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
public partial class V1beta1StorageDefaultObjectAccessControlSpec
{
    /// <summary>Reference to the bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public required V1beta1StorageDefaultObjectAccessControlSpecBucketRef BucketRef { get; set; }

    /// <summary>
    /// The entity holding the permission, in one of the following forms:
    ///   * user-{{userId}}
    ///   * user-{{email}} (such as &quot;user-liz@example.com&quot;)
    ///   * group-{{groupId}}
    ///   * group-{{email}} (such as &quot;group-example@googlegroups.com&quot;)
    ///   * domain-{{domain}} (such as &quot;domain-example.com&quot;)
    ///   * project-team-{{projectId}}
    ///   * allUsers
    ///   * allAuthenticatedUsers.
    /// </summary>
    [JsonPropertyName("entity")]
    public required string Entity { get; set; }

    /// <summary>The name of the object, if applied to an object.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>The access permission for the entity. Possible values: [&quot;OWNER&quot;, &quot;READER&quot;].</summary>
    [JsonPropertyName("role")]
    public required string Role { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageDefaultObjectAccessControlStatusConditions
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

/// <summary>The project team associated with the entity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageDefaultObjectAccessControlStatusProjectTeam
{
    /// <summary>The project team associated with the entity.</summary>
    [JsonPropertyName("projectNumber")]
    public string? ProjectNumber { get; set; }

    /// <summary>The team. Possible values: [&quot;editors&quot;, &quot;owners&quot;, &quot;viewers&quot;].</summary>
    [JsonPropertyName("team")]
    public string? Team { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageDefaultObjectAccessControlStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StorageDefaultObjectAccessControlStatusConditions>? Conditions { get; set; }

    /// <summary>The domain associated with the entity.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>The email address associated with the entity.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>The ID for the entity.</summary>
    [JsonPropertyName("entityId")]
    public string? EntityId { get; set; }

    /// <summary>The content generation of the object, if applied to an object.</summary>
    [JsonPropertyName("generation")]
    public int? Generation { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The project team associated with the entity.</summary>
    [JsonPropertyName("projectTeam")]
    public V1beta1StorageDefaultObjectAccessControlStatusProjectTeam? ProjectTeam { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StorageDefaultObjectAccessControl : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StorageDefaultObjectAccessControlSpec>, IStatus<V1beta1StorageDefaultObjectAccessControlStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StorageDefaultObjectAccessControl";
    public const string KubeGroup = "storage.cnrm.cloud.google.com";
    public const string KubePluralName = "storagedefaultobjectaccesscontrols";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageDefaultObjectAccessControl";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1beta1StorageDefaultObjectAccessControlSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta1StorageDefaultObjectAccessControlStatus? Status { get; set; }
}
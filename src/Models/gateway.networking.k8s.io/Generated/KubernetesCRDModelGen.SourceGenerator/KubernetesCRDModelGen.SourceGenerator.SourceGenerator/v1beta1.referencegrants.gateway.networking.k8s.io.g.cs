#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.gateway.networking.k8s.io;
/// <summary>
/// ReferenceGrant identifies kinds of resources in other namespaces that are
/// trusted to reference the specified kinds of resources in the same namespace
/// as the policy.
/// 
/// Each ReferenceGrant can be used to represent a unique trust relationship.
/// Additional Reference Grants can be used to add to the set of trusted
/// sources of inbound references for the namespace they are defined within.
/// 
/// All cross-namespace references in Gateway API (with the exception of cross-namespace
/// Gateway-route attachment) require a ReferenceGrant.
/// 
/// ReferenceGrant is a form of runtime verification allowing users to assert
/// which cross-namespace object references are permitted. Implementations that
/// support ReferenceGrant MUST NOT permit cross-namespace references which have
/// no grant, and MUST respond to the removal of a grant by revoking the access
/// that the grant allowed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ReferenceGrantList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ReferenceGrant>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReferenceGrantList";
    public const string KubeGroup = "gateway.networking.k8s.io";
    public const string KubePluralName = "referencegrants";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gateway.networking.k8s.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ReferenceGrantList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ReferenceGrant objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ReferenceGrant> Items { get; set; }
}

/// <summary>ReferenceGrantFrom describes trusted namespaces and kinds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReferenceGrantSpecFrom
{
    /// <summary>
    /// Group is the group of the referent.
    /// When empty, the Kubernetes core API group is inferred.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    /// <summary>
    /// Kind is the kind of the referent. Although implementations may support
    /// additional resources, the following types are part of the &quot;Core&quot;
    /// support level for this field.
    /// 
    /// When used to permit a SecretObjectReference:
    /// 
    /// * Gateway
    /// 
    /// When used to permit a BackendObjectReference:
    /// 
    /// * GRPCRoute
    /// * HTTPRoute
    /// * TCPRoute
    /// * TLSRoute
    /// * UDPRoute
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>
    /// Namespace is the namespace of the referent.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// ReferenceGrantTo describes what Kinds are allowed as targets of the
/// references.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReferenceGrantSpecTo
{
    /// <summary>
    /// Group is the group of the referent.
    /// When empty, the Kubernetes core API group is inferred.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    /// <summary>
    /// Kind is the kind of the referent. Although implementations may support
    /// additional resources, the following types are part of the &quot;Core&quot;
    /// support level for this field:
    /// 
    /// * Secret when used to permit a SecretObjectReference
    /// * Service when used to permit a BackendObjectReference
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>
    /// Name is the name of the referent. When unspecified, this policy
    /// refers to all resources of the specified Group and Kind in the local
    /// namespace.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Spec defines the desired state of ReferenceGrant.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ReferenceGrantSpec
{
    /// <summary>
    /// From describes the trusted namespaces and kinds that can reference the
    /// resources described in &quot;To&quot;. Each entry in this list MUST be considered
    /// to be an additional place that references can be valid from, or to put
    /// this another way, entries MUST be combined using OR.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("from")]
    public required IList<V1beta1ReferenceGrantSpecFrom> From { get; set; }

    /// <summary>
    /// To describes the resources that may be referenced by the resources
    /// described in &quot;From&quot;. Each entry in this list MUST be considered to be an
    /// additional place that references can be valid to, or to put this another
    /// way, entries MUST be combined using OR.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("to")]
    public required IList<V1beta1ReferenceGrantSpecTo> To { get; set; }
}

/// <summary>
/// ReferenceGrant identifies kinds of resources in other namespaces that are
/// trusted to reference the specified kinds of resources in the same namespace
/// as the policy.
/// 
/// Each ReferenceGrant can be used to represent a unique trust relationship.
/// Additional Reference Grants can be used to add to the set of trusted
/// sources of inbound references for the namespace they are defined within.
/// 
/// All cross-namespace references in Gateway API (with the exception of cross-namespace
/// Gateway-route attachment) require a ReferenceGrant.
/// 
/// ReferenceGrant is a form of runtime verification allowing users to assert
/// which cross-namespace object references are permitted. Implementations that
/// support ReferenceGrant MUST NOT permit cross-namespace references which have
/// no grant, and MUST respond to the removal of a grant by revoking the access
/// that the grant allowed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ReferenceGrant : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ReferenceGrantSpec>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ReferenceGrant";
    public const string KubeGroup = "gateway.networking.k8s.io";
    public const string KubePluralName = "referencegrants";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gateway.networking.k8s.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ReferenceGrant";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of ReferenceGrant.</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ReferenceGrantSpec Spec { get; set; }
}
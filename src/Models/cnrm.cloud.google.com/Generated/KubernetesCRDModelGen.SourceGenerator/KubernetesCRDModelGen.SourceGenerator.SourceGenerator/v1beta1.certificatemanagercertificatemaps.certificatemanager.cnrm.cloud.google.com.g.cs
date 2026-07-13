#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.certificatemanager.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CertificateManagerCertificateMapList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CertificateManagerCertificateMap>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CertificateManagerCertificateMapList";
    public const string KubeGroup = "certificatemanager.cnrm.cloud.google.com";
    public const string KubePluralName = "certificatemanagercertificatemaps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "certificatemanager.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CertificateManagerCertificateMapList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1CertificateManagerCertificateMap objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1CertificateManagerCertificateMap> Items { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateMapSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
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
public partial class V1beta1CertificateManagerCertificateMapSpec
{
    /// <summary>A human-readable description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1beta1CertificateManagerCertificateMapSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateMapStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateMapStatusGclbTargetsIpConfigs
{
    /// <summary>An external IP address.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>A list of ports.</summary>
    [JsonPropertyName("ports")]
    public IList<int>? Ports { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateMapStatusGclbTargets
{
    /// <summary>An IP configuration where this Certificate Map is serving.</summary>
    [JsonPropertyName("ipConfigs")]
    public IList<V1beta1CertificateManagerCertificateMapStatusGclbTargetsIpConfigs>? IpConfigs { get; set; }

    /// <summary>
    /// Proxy name must be in the format projects/*/locations/*/targetHttpsProxies/*.
    /// This field is part of a union field &apos;target_proxy&apos;: Only one of &apos;targetHttpsProxy&apos; or
    /// &apos;targetSslProxy&apos; may be set.
    /// </summary>
    [JsonPropertyName("targetHttpsProxy")]
    public string? TargetHttpsProxy { get; set; }

    /// <summary>
    /// Proxy name must be in the format projects/*/locations/*/targetSslProxies/*.
    /// This field is part of a union field &apos;target_proxy&apos;: Only one of &apos;targetHttpsProxy&apos; or
    /// &apos;targetSslProxy&apos; may be set.
    /// </summary>
    [JsonPropertyName("targetSslProxy")]
    public string? TargetSslProxy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateManagerCertificateMapStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CertificateManagerCertificateMapStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Creation timestamp of a Certificate Map. Timestamp is in RFC3339 UTC &quot;Zulu&quot; format,
    /// accurate to nanoseconds with up to nine fractional digits.
    /// Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>A list of target proxies that use this Certificate Map.</summary>
    [JsonPropertyName("gclbTargets")]
    public IList<V1beta1CertificateManagerCertificateMapStatusGclbTargets>? GclbTargets { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>
    /// Update timestamp of a Certificate Map. Timestamp is in RFC3339 UTC &quot;Zulu&quot; format,
    /// accurate to nanoseconds with up to nine fractional digits.
    /// Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.
    /// </summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CertificateManagerCertificateMap : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CertificateManagerCertificateMapSpec>, IStatus<V1beta1CertificateManagerCertificateMapStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CertificateManagerCertificateMap";
    public const string KubeGroup = "certificatemanager.cnrm.cloud.google.com";
    public const string KubePluralName = "certificatemanagercertificatemaps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "certificatemanager.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CertificateManagerCertificateMap";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1beta1CertificateManagerCertificateMapSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta1CertificateManagerCertificateMapStatus? Status { get; set; }
}
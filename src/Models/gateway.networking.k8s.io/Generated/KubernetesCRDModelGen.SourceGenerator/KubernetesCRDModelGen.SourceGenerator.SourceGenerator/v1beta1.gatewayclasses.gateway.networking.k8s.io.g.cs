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
/// GatewayClass describes a class of Gateways available to the user for creating
/// Gateway resources.
/// 
/// It is recommended that this resource be used as a template for Gateways. This
/// means that a Gateway is based on the state of the GatewayClass at the time it
/// was created and changes to the GatewayClass or associated parameters are not
/// propagated down to existing Gateways. This recommendation is intended to
/// limit the blast radius of changes to GatewayClass or associated parameters.
/// If implementations choose to propagate GatewayClass changes to existing
/// Gateways, that MUST be clearly documented by the implementation.
/// 
/// Whenever one or more Gateways are using a GatewayClass, implementations SHOULD
/// add the `gateway-exists-finalizer.gateway.networking.k8s.io` finalizer on the
/// associated GatewayClass. This ensures that a GatewayClass associated with a
/// Gateway is not deleted while in use.
/// 
/// GatewayClass is a Cluster level resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GatewayClassList : IKubernetesObject<V1ListMeta>, IItems<V1beta1GatewayClass>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GatewayClassList";
    public const string KubeGroup = "gateway.networking.k8s.io";
    public const string KubePluralName = "gatewayclasses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gateway.networking.k8s.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GatewayClassList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1GatewayClass objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1GatewayClass> Items { get; set; }
}

/// <summary>
/// ParametersRef is a reference to a resource that contains the configuration
/// parameters corresponding to the GatewayClass. This is optional if the
/// controller does not require any additional configuration.
/// 
/// ParametersRef can reference a standard Kubernetes resource, i.e. ConfigMap,
/// or an implementation-specific custom resource. The resource can be
/// cluster-scoped or namespace-scoped.
/// 
/// If the referent cannot be found, refers to an unsupported kind, or when
/// the data within that resource is malformed, the GatewayClass SHOULD be
/// rejected with the &quot;Accepted&quot; status condition set to &quot;False&quot; and an
/// &quot;InvalidParameters&quot; reason.
/// 
/// A Gateway for this GatewayClass may provide its own `parametersRef`. When both are specified,
/// the merging behavior is implementation specific.
/// It is generally recommended that GatewayClass provides defaults that can be overridden by a Gateway.
/// 
/// Support: Implementation-specific
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayClassSpecParametersRef
{
    /// <summary>Group is the group of the referent.</summary>
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    /// <summary>Kind is kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name is the name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace is the namespace of the referent.
    /// This field is required when referring to a Namespace-scoped resource and
    /// MUST be unset when referring to a Cluster-scoped resource.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Spec defines the desired state of GatewayClass.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayClassSpec
{
    /// <summary>
    /// ControllerName is the name of the controller that is managing Gateways of
    /// this class. The value of this field MUST be a domain prefixed path.
    /// 
    /// Example: &quot;example.net/gateway-controller&quot;.
    /// 
    /// This field is not mutable and cannot be empty.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("controllerName")]
    public required string ControllerName { get; set; }

    /// <summary>Description helps describe a GatewayClass with more details.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// ParametersRef is a reference to a resource that contains the configuration
    /// parameters corresponding to the GatewayClass. This is optional if the
    /// controller does not require any additional configuration.
    /// 
    /// ParametersRef can reference a standard Kubernetes resource, i.e. ConfigMap,
    /// or an implementation-specific custom resource. The resource can be
    /// cluster-scoped or namespace-scoped.
    /// 
    /// If the referent cannot be found, refers to an unsupported kind, or when
    /// the data within that resource is malformed, the GatewayClass SHOULD be
    /// rejected with the &quot;Accepted&quot; status condition set to &quot;False&quot; and an
    /// &quot;InvalidParameters&quot; reason.
    /// 
    /// A Gateway for this GatewayClass may provide its own `parametersRef`. When both are specified,
    /// the merging behavior is implementation specific.
    /// It is generally recommended that GatewayClass provides defaults that can be overridden by a Gateway.
    /// 
    /// Support: Implementation-specific
    /// </summary>
    [JsonPropertyName("parametersRef")]
    public V1beta1GatewayClassSpecParametersRef? ParametersRef { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GatewayClassStatusConditionsStatusEnum>))]
public enum V1beta1GatewayClassStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayClassStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1beta1GatewayClassStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayClassStatusSupportedFeatures
{
    /// <summary>
    /// FeatureName is used to describe distinct features that are covered by
    /// conformance tests.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Status defines the current state of GatewayClass.
/// 
/// Implementations MUST populate status on all GatewayClass resources which
/// specify their controller name.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayClassStatus
{
    /// <summary>
    /// Conditions is the current status from the controller for
    /// this GatewayClass.
    /// 
    /// Controllers should prefer to publish conditions using values
    /// of GatewayClassConditionType for the type of each Condition.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1GatewayClassStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// SupportedFeatures is the set of features the GatewayClass support.
    /// It MUST be sorted in ascending alphabetical order by the Name key.
    /// </summary>
    [JsonPropertyName("supportedFeatures")]
    public IList<V1beta1GatewayClassStatusSupportedFeatures>? SupportedFeatures { get; set; }
}

/// <summary>
/// GatewayClass describes a class of Gateways available to the user for creating
/// Gateway resources.
/// 
/// It is recommended that this resource be used as a template for Gateways. This
/// means that a Gateway is based on the state of the GatewayClass at the time it
/// was created and changes to the GatewayClass or associated parameters are not
/// propagated down to existing Gateways. This recommendation is intended to
/// limit the blast radius of changes to GatewayClass or associated parameters.
/// If implementations choose to propagate GatewayClass changes to existing
/// Gateways, that MUST be clearly documented by the implementation.
/// 
/// Whenever one or more Gateways are using a GatewayClass, implementations SHOULD
/// add the `gateway-exists-finalizer.gateway.networking.k8s.io` finalizer on the
/// associated GatewayClass. This ensures that a GatewayClass associated with a
/// Gateway is not deleted while in use.
/// 
/// GatewayClass is a Cluster level resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GatewayClass : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1GatewayClassSpec>, IStatus<V1beta1GatewayClassStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GatewayClass";
    public const string KubeGroup = "gateway.networking.k8s.io";
    public const string KubePluralName = "gatewayclasses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gateway.networking.k8s.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GatewayClass";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of GatewayClass.</summary>
    [JsonPropertyName("spec")]
    public required V1beta1GatewayClassSpec Spec { get; set; }

    /// <summary>
    /// Status defines the current state of GatewayClass.
    /// 
    /// Implementations MUST populate status on all GatewayClass resources which
    /// specify their controller name.
    /// </summary>
    [JsonPropertyName("status")]
    public V1beta1GatewayClassStatus? Status { get; set; }
}
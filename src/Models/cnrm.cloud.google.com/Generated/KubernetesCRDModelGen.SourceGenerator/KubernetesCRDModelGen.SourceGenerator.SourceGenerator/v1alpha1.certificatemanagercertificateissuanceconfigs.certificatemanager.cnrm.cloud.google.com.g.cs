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
/// <summary>CertificateManagerCertificateIssuanceConfig is the Schema for the CertificateManagerCertificateIssuanceConfig API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CertificateManagerCertificateIssuanceConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CertificateManagerCertificateIssuanceConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CertificateManagerCertificateIssuanceConfigList";
    public const string KubeGroup = "certificatemanager.cnrm.cloud.google.com";
    public const string KubePluralName = "certificatemanagercertificateissuanceconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "certificatemanager.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CertificateManagerCertificateIssuanceConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CertificateManagerCertificateIssuanceConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CertificateManagerCertificateIssuanceConfig> Items { get; set; }
}

/// <summary>Required. A CA pool resource used to issue a certificate. The CA pool string has a relative resource path following the form &quot;projects/{project}/locations/{location}/caPools/{ca_pool}&quot;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateManagerCertificateIssuanceConfigSpecCertificateAuthorityConfigCertificateAuthorityServiceConfigCaPoolRef
{
    /// <summary>A reference to an externally managed PrivateCACAPool. Should be in the format `projects/{project_id}/locations/{region}/caPools/{caPool}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `PrivateCACAPool` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `PrivateCACAPool` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Defines a CertificateAuthorityServiceConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateManagerCertificateIssuanceConfigSpecCertificateAuthorityConfigCertificateAuthorityServiceConfig
{
    /// <summary>Required. A CA pool resource used to issue a certificate. The CA pool string has a relative resource path following the form &quot;projects/{project}/locations/{location}/caPools/{ca_pool}&quot;.</summary>
    [JsonPropertyName("caPoolRef")]
    public V1alpha1CertificateManagerCertificateIssuanceConfigSpecCertificateAuthorityConfigCertificateAuthorityServiceConfigCaPoolRef? CaPoolRef { get; set; }
}

/// <summary>Required. The CA that issues the workload certificate. It includes the CA address, type, authentication to CA service, etc.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateManagerCertificateIssuanceConfigSpecCertificateAuthorityConfig
{
    /// <summary>Defines a CertificateAuthorityServiceConfig.</summary>
    [JsonPropertyName("certificateAuthorityServiceConfig")]
    public V1alpha1CertificateManagerCertificateIssuanceConfigSpecCertificateAuthorityConfigCertificateAuthorityServiceConfig? CertificateAuthorityServiceConfig { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateManagerCertificateIssuanceConfigSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>CertificateManagerCertificateIssuanceConfigSpec defines the desired state of CertificateManagerCertificateIssuanceConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateManagerCertificateIssuanceConfigSpec
{
    /// <summary>Required. The CA that issues the workload certificate. It includes the CA address, type, authentication to CA service, etc.</summary>
    [JsonPropertyName("certificateAuthorityConfig")]
    public V1alpha1CertificateManagerCertificateIssuanceConfigSpecCertificateAuthorityConfig? CertificateAuthorityConfig { get; set; }

    /// <summary>One or more paragraphs of text description of a CertificateIssuanceConfig.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The key algorithm to use when generating the private key.</summary>
    [JsonPropertyName("keyAlgorithm")]
    public string? KeyAlgorithm { get; set; }

    /// <summary>Required. Workload certificate lifetime requested.</summary>
    [JsonPropertyName("lifetime")]
    public string? Lifetime { get; set; }

    /// <summary>The location that this resource belongs to.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1CertificateManagerCertificateIssuanceConfigSpecProjectRef ProjectRef { get; set; }

    /// <summary>The CertificateManagerCertificateIssuanceConfig name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Specifies the percentage of elapsed time of the certificate lifetime to wait before renewing the certificate. Must be a number between 1-99, inclusive.</summary>
    [JsonPropertyName("rotationWindowPercentage")]
    public int? RotationWindowPercentage { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateManagerCertificateIssuanceConfigStatusConditions
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
public partial class V1alpha1CertificateManagerCertificateIssuanceConfigStatusObservedState
{
    /// <summary>Output only. The creation timestamp of a CertificateIssuanceConfig.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The last update timestamp of a CertificateIssuanceConfig.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>CertificateManagerCertificateIssuanceConfigStatus defines the config connector machine state of CertificateManagerCertificateIssuanceConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateManagerCertificateIssuanceConfigStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CertificateManagerCertificateIssuanceConfigStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the CertificateManagerCertificateIssuanceConfig resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CertificateManagerCertificateIssuanceConfigStatusObservedState? ObservedState { get; set; }
}

/// <summary>CertificateManagerCertificateIssuanceConfig is the Schema for the CertificateManagerCertificateIssuanceConfig API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CertificateManagerCertificateIssuanceConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CertificateManagerCertificateIssuanceConfigSpec>, IStatus<V1alpha1CertificateManagerCertificateIssuanceConfigStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CertificateManagerCertificateIssuanceConfig";
    public const string KubeGroup = "certificatemanager.cnrm.cloud.google.com";
    public const string KubePluralName = "certificatemanagercertificateissuanceconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "certificatemanager.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CertificateManagerCertificateIssuanceConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CertificateManagerCertificateIssuanceConfigSpec defines the desired state of CertificateManagerCertificateIssuanceConfig</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1CertificateManagerCertificateIssuanceConfigSpec Spec { get; set; }

    /// <summary>CertificateManagerCertificateIssuanceConfigStatus defines the config connector machine state of CertificateManagerCertificateIssuanceConfig</summary>
    [JsonPropertyName("status")]
    public V1alpha1CertificateManagerCertificateIssuanceConfigStatus? Status { get; set; }
}
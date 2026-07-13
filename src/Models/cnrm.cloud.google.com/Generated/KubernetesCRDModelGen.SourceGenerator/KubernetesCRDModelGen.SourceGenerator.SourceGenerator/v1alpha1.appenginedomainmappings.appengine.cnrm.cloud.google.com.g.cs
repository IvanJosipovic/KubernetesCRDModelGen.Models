#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appengine.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AppEngineDomainMappingList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AppEngineDomainMapping>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AppEngineDomainMappingList";
    public const string KubeGroup = "appengine.cnrm.cloud.google.com";
    public const string KubePluralName = "appenginedomainmappings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appengine.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AppEngineDomainMappingList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1AppEngineDomainMapping objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1AppEngineDomainMapping> Items { get; set; }
}

/// <summary>SSL configuration for this domain. If unconfigured, this domain will not serve with SSL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppEngineDomainMappingSpecSslSettings
{
    /// <summary>
    /// ID of the AuthorizedCertificate resource configuring SSL for the application. Clearing this field will
    /// remove SSL support.
    /// By default, a managed certificate is automatically created for every domain mapping. To omit SSL support
    /// or to configure SSL manually, specify &apos;SslManagementType.MANUAL&apos; on a &apos;CREATE&apos; or &apos;UPDATE&apos; request. You must be
    /// authorized to administer the &apos;AuthorizedCertificate&apos; resource to manually map it to a DomainMapping resource.
    /// Example: 12345.
    /// </summary>
    [JsonPropertyName("certificateId")]
    public string? CertificateId { get; set; }

    /// <summary>
    /// ID of the managed &apos;AuthorizedCertificate&apos; resource currently being provisioned, if applicable. Until the new
    /// managed certificate has been successfully provisioned, the previous SSL state will be preserved. Once the
    /// provisioning process completes, the &apos;certificateId&apos; field will reflect the new managed certificate and this
    /// field will be left empty. To remove SSL support while there is still a pending managed certificate, clear the
    /// &apos;certificateId&apos; field with an update request.
    /// </summary>
    [JsonPropertyName("pendingManagedCertificateId")]
    public string? PendingManagedCertificateId { get; set; }

    /// <summary>
    /// SSL management type for this domain. If &apos;AUTOMATIC&apos;, a managed certificate is automatically provisioned.
    /// If &apos;MANUAL&apos;, &apos;certificateId&apos; must be manually specified in order to configure SSL for this domain. Possible values: [&quot;AUTOMATIC&quot;, &quot;MANUAL&quot;].
    /// </summary>
    [JsonPropertyName("sslManagementType")]
    public required string SslManagementType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppEngineDomainMappingSpec
{
    /// <summary>
    /// Whether the domain creation should override any existing mappings for this domain.
    /// By default, overrides are rejected. Default value: &quot;STRICT&quot; Possible values: [&quot;STRICT&quot;, &quot;OVERRIDE&quot;].
    /// </summary>
    [JsonPropertyName("overrideStrategy")]
    public string? OverrideStrategy { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Immutable. Optional. The domainName of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>SSL configuration for this domain. If unconfigured, this domain will not serve with SSL.</summary>
    [JsonPropertyName("sslSettings")]
    public V1alpha1AppEngineDomainMappingSpecSslSettings? SslSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppEngineDomainMappingStatusConditions
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
public partial class V1alpha1AppEngineDomainMappingStatusResourceRecords
{
    /// <summary>Relative name of the object affected by this record. Only applicable for CNAME records. Example: &apos;www&apos;.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Data for this record. Values vary by record type, as defined in RFC 1035 (section 5) and RFC 1034 (section 3.6.1).</summary>
    [JsonPropertyName("rrdata")]
    public string? Rrdata { get; set; }

    /// <summary>Resource record type. Example: &apos;AAAA&apos;. Possible values: [&quot;A&quot;, &quot;AAAA&quot;, &quot;CNAME&quot;].</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AppEngineDomainMappingStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AppEngineDomainMappingStatusConditions>? Conditions { get; set; }

    /// <summary>Full path to the DomainMapping resource in the API. Example: apps/myapp/domainMapping/example.com.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>
    /// The resource records required to configure this domain mapping. These records must be added to the domain&apos;s DNS
    /// configuration in order to serve the application via this domain mapping.
    /// </summary>
    [JsonPropertyName("resourceRecords")]
    public IList<V1alpha1AppEngineDomainMappingStatusResourceRecords>? ResourceRecords { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AppEngineDomainMapping : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AppEngineDomainMappingSpec?>, IStatus<V1alpha1AppEngineDomainMappingStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AppEngineDomainMapping";
    public const string KubeGroup = "appengine.cnrm.cloud.google.com";
    public const string KubePluralName = "appenginedomainmappings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appengine.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AppEngineDomainMapping";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1alpha1AppEngineDomainMappingSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1AppEngineDomainMappingStatus? Status { get; set; }
}
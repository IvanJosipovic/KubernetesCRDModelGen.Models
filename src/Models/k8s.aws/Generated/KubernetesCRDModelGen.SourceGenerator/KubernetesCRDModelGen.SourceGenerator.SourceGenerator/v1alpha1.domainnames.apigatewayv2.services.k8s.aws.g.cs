#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigatewayv2.services.k8s.aws;
/// <summary>DomainName is the Schema for the DomainNames API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DomainNameList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DomainName>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DomainNameList";
    public const string KubeGroup = "apigatewayv2.services.k8s.aws";
    public const string KubePluralName = "domainnames";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigatewayv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DomainNameList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DomainName objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DomainName> Items { get; set; }
}

/// <summary>The domain name configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainNameSpecDomainNameConfigurations
{
    /// <summary>Represents an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("certificateARN")]
    public string? CertificateARN { get; set; }

    /// <summary>A string with a length between [1-128].</summary>
    [JsonPropertyName("certificateName")]
    public string? CertificateName { get; set; }

    /// <summary>Represents an endpoint type.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>Represents an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("ownershipVerificationCertificateARN")]
    public string? OwnershipVerificationCertificateARN { get; set; }

    /// <summary>
    /// The Transport Layer Security (TLS) version of the security policy for this
    /// domain name. The valid values are TLS_1_0 and TLS_1_2.
    /// </summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }
}

/// <summary>The mutual TLS authentication configuration for a custom domain name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainNameSpecMutualTLSAuthentication
{
    /// <summary>A string representation of a URI with a length between [1-2048].</summary>
    [JsonPropertyName("truststoreURI")]
    public string? TruststoreURI { get; set; }

    /// <summary>A string with a length between [1-64].</summary>
    [JsonPropertyName("truststoreVersion")]
    public string? TruststoreVersion { get; set; }
}

/// <summary>
/// DomainNameSpec defines the desired state of DomainName.
/// 
/// Represents a domain name.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainNameSpec
{
    /// <summary>The domain name.</summary>
    [JsonPropertyName("domainName")]
    public required string DomainName { get; set; }

    /// <summary>The domain name configurations.</summary>
    [JsonPropertyName("domainNameConfigurations")]
    public IList<V1alpha1DomainNameSpecDomainNameConfigurations>? DomainNameConfigurations { get; set; }

    /// <summary>The mutual TLS authentication configuration for a custom domain name.</summary>
    [JsonPropertyName("mutualTLSAuthentication")]
    public V1alpha1DomainNameSpecMutualTLSAuthentication? MutualTLSAuthentication { get; set; }

    /// <summary>The collection of tags associated with a domain name.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainNameStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainNameStatusConditions
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

/// <summary>DomainNameStatus defines the observed state of DomainName</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainNameStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DomainNameStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>The API mapping selection expression.</summary>
    [JsonPropertyName("apiMappingSelectionExpression")]
    public string? ApiMappingSelectionExpression { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DomainNameStatusConditions>? Conditions { get; set; }
}

/// <summary>DomainName is the Schema for the DomainNames API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DomainName : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DomainNameSpec?>, IStatus<V1alpha1DomainNameStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DomainName";
    public const string KubeGroup = "apigatewayv2.services.k8s.aws";
    public const string KubePluralName = "domainnames";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigatewayv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DomainName";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// DomainNameSpec defines the desired state of DomainName.
    /// 
    /// Represents a domain name.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1DomainNameSpec? Spec { get; set; }

    /// <summary>DomainNameStatus defines the observed state of DomainName</summary>
    [JsonPropertyName("status")]
    public V1alpha1DomainNameStatus? Status { get; set; }
}
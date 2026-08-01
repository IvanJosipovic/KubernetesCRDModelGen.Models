#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.acm.services.k8s.aws;
/// <summary>AcmeDomainValidation is the Schema for the AcmeDomainValidations API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AcmeDomainValidationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AcmeDomainValidation>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AcmeDomainValidationList";
    public const string KubeGroup = "acm.services.k8s.aws";
    public const string KubePluralName = "acmedomainvalidations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "acm.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AcmeDomainValidationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1AcmeDomainValidation objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1AcmeDomainValidation> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeDomainValidationSpecAcmeEndpointRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeDomainValidationSpecAcmeEndpointRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1AcmeDomainValidationSpecAcmeEndpointRefFrom? From { get; set; }
}

/// <summary>Specifies the scope of domain validation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeDomainValidationSpecPrevalidationOptionsDnsPrevalidationDomainScope
{
    [JsonPropertyName("exactDomain")]
    public string? ExactDomain { get; set; }

    [JsonPropertyName("subdomains")]
    public string? Subdomains { get; set; }

    [JsonPropertyName("wildcards")]
    public string? Wildcards { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeDomainValidationSpecPrevalidationOptionsDnsPrevalidationHostedZoneRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for HostedZoneID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeDomainValidationSpecPrevalidationOptionsDnsPrevalidationHostedZoneRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1AcmeDomainValidationSpecPrevalidationOptionsDnsPrevalidationHostedZoneRefFrom? From { get; set; }
}

/// <summary>DNS prevalidation options for domain validation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeDomainValidationSpecPrevalidationOptionsDnsPrevalidation
{
    /// <summary>Specifies the scope of domain validation.</summary>
    [JsonPropertyName("domainScope")]
    public V1alpha1AcmeDomainValidationSpecPrevalidationOptionsDnsPrevalidationDomainScope? DomainScope { get; set; }

    [JsonPropertyName("hostedZoneID")]
    public string? HostedZoneID { get; set; }

    /// <summary>Reference field for HostedZoneID</summary>
    [JsonPropertyName("hostedZoneRef")]
    public V1alpha1AcmeDomainValidationSpecPrevalidationOptionsDnsPrevalidationHostedZoneRef? HostedZoneRef { get; set; }
}

/// <summary>
/// Configuration for domain prevalidation. Specify DnsPrevalidation with a
/// Route 53 HostedZoneId and optional DomainScope (ExactDomain, Subdomains,
/// Wildcards — each ENABLED or DISABLED).
/// 
/// The prevalidation options for the domain.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeDomainValidationSpecPrevalidationOptions
{
    /// <summary>DNS prevalidation options for domain validation.</summary>
    [JsonPropertyName("dnsPrevalidation")]
    public V1alpha1AcmeDomainValidationSpecPrevalidationOptionsDnsPrevalidation? DnsPrevalidation { get; set; }
}

/// <summary>A key-value pair that identifies or specifies metadata about an ACM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeDomainValidationSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// AcmeDomainValidationSpec defines the desired state of AcmeDomainValidation.
/// 
/// Contains detailed information about an ACME domain validation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeDomainValidationSpec
{
    /// <summary>
    /// The Amazon Resource Name (ARN) of the ACME endpoint.
    /// 
    /// Regex Pattern: `^arn:aws[a-z-]*:acm:[a-z0-9-]+:[0-9]{12}:acme-endpoint/[a-zA-Z0-9-]+$`
    /// </summary>
    [JsonPropertyName("acmeEndpointARN")]
    public string? AcmeEndpointARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("acmeEndpointRef")]
    public V1alpha1AcmeDomainValidationSpecAcmeEndpointRef? AcmeEndpointRef { get; set; }

    /// <summary>
    /// The domain name to validate. Use DomainScope within PrevalidationOptions
    /// to control whether validation applies to the exact domain, subdomains,
    /// and/or wildcards.
    /// 
    /// The domain name to validate.
    /// 
    /// Regex Pattern: `^([a-z0-9]([a-z0-9-]*[a-z0-9])?\.)*[a-z0-9]([a-z0-9-]*[a-z0-9])?$`
    /// </summary>
    [JsonPropertyName("domainName")]
    public required string DomainName { get; set; }

    /// <summary>
    /// Configuration for domain prevalidation. Specify DnsPrevalidation with a
    /// Route 53 HostedZoneId and optional DomainScope (ExactDomain, Subdomains,
    /// Wildcards — each ENABLED or DISABLED).
    /// 
    /// The prevalidation options for the domain.
    /// </summary>
    [JsonPropertyName("prevalidationOptions")]
    public required V1alpha1AcmeDomainValidationSpecPrevalidationOptions PrevalidationOptions { get; set; }

    /// <summary>One or more tags to associate with the domain validation.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1AcmeDomainValidationSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeDomainValidationStatusAckResourceMetadata
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
public partial class V1alpha1AcmeDomainValidationStatusConditions
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

/// <summary>Details about the failure, if the validation failed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeDomainValidationStatusFailureDetails
{
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary>Specifies the scope of domain validation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeDomainValidationStatusPrevalidationDetailsDnsPrevalidationDomainScope
{
    [JsonPropertyName("exactDomain")]
    public string? ExactDomain { get; set; }

    [JsonPropertyName("subdomains")]
    public string? Subdomains { get; set; }

    [JsonPropertyName("wildcards")]
    public string? Wildcards { get; set; }
}

/// <summary>
/// Contains a DNS record value that you can use to validate ownership or control
/// of a domain. This is used by the DescribeCertificate action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeDomainValidationStatusPrevalidationDetailsDnsPrevalidationResourceRecord
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DNS prevalidation details including the resource record for validation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeDomainValidationStatusPrevalidationDetailsDnsPrevalidation
{
    /// <summary>Specifies the scope of domain validation.</summary>
    [JsonPropertyName("domainScope")]
    public V1alpha1AcmeDomainValidationStatusPrevalidationDetailsDnsPrevalidationDomainScope? DomainScope { get; set; }

    [JsonPropertyName("hostedZoneID")]
    public string? HostedZoneID { get; set; }

    /// <summary>
    /// Contains a DNS record value that you can use to validate ownership or control
    /// of a domain. This is used by the DescribeCertificate action.
    /// </summary>
    [JsonPropertyName("resourceRecord")]
    public V1alpha1AcmeDomainValidationStatusPrevalidationDetailsDnsPrevalidationResourceRecord? ResourceRecord { get; set; }
}

/// <summary>Details about the prevalidation configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeDomainValidationStatusPrevalidationDetails
{
    /// <summary>DNS prevalidation details including the resource record for validation.</summary>
    [JsonPropertyName("dnsPrevalidation")]
    public V1alpha1AcmeDomainValidationStatusPrevalidationDetailsDnsPrevalidation? DnsPrevalidation { get; set; }
}

/// <summary>AcmeDomainValidationStatus defines the observed state of AcmeDomainValidation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AcmeDomainValidationStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1AcmeDomainValidationStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AcmeDomainValidationStatusConditions>? Conditions { get; set; }

    /// <summary>The time at which the domain validation was created.</summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>Details about the failure, if the validation failed.</summary>
    [JsonPropertyName("failureDetails")]
    public V1alpha1AcmeDomainValidationStatusFailureDetails? FailureDetails { get; set; }

    /// <summary>Details about the prevalidation configuration.</summary>
    [JsonPropertyName("prevalidationDetails")]
    public V1alpha1AcmeDomainValidationStatusPrevalidationDetails? PrevalidationDetails { get; set; }

    /// <summary>The type of prevalidation used.</summary>
    [JsonPropertyName("prevalidationType")]
    public string? PrevalidationType { get; set; }

    /// <summary>The status of the domain validation.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The time at which the domain validation was last updated.</summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
}

/// <summary>AcmeDomainValidation is the Schema for the AcmeDomainValidations API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AcmeDomainValidation : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AcmeDomainValidationSpec?>, IStatus<V1alpha1AcmeDomainValidationStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AcmeDomainValidation";
    public const string KubeGroup = "acm.services.k8s.aws";
    public const string KubePluralName = "acmedomainvalidations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "acm.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AcmeDomainValidation";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// AcmeDomainValidationSpec defines the desired state of AcmeDomainValidation.
    /// 
    /// Contains detailed information about an ACME domain validation.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1AcmeDomainValidationSpec? Spec { get; set; }

    /// <summary>AcmeDomainValidationStatus defines the observed state of AcmeDomainValidation</summary>
    [JsonPropertyName("status")]
    public V1alpha1AcmeDomainValidationStatus? Status { get; set; }
}
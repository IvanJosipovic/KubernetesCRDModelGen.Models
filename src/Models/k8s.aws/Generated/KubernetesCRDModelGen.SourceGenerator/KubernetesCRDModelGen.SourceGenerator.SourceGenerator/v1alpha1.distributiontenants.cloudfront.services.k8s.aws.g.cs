#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudfront.services.k8s.aws;
/// <summary>DistributionTenant is the Schema for the DistributionTenants API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DistributionTenantList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DistributionTenant>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DistributionTenantList";
    public const string KubeGroup = "cloudfront.services.k8s.aws";
    public const string KubePluralName = "distributiontenants";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DistributionTenantList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DistributionTenant objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DistributionTenant> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionTenantSpecConnectionGroupRefFrom
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
public partial class V1alpha1DistributionTenantSpecConnectionGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DistributionTenantSpecConnectionGroupRefFrom? From { get; set; }
}

/// <summary>The Certificate Manager (ACM) certificate associated with your distribution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionTenantSpecCustomizationsCertificate
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>
/// The customizations that you specified for the distribution tenant for geographic
/// restrictions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionTenantSpecCustomizationsGeoRestrictions
{
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    [JsonPropertyName("restrictionType")]
    public string? RestrictionType { get; set; }
}

/// <summary>The WAF web ACL customization specified for the distribution tenant.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionTenantSpecCustomizationsWebACL
{
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>
/// Customizations for the distribution tenant. For each distribution tenant,
/// you can specify the geographic restrictions, and the Amazon Resource Names
/// (ARNs) for the ACM certificate and WAF web ACL. These are specific values
/// that you can override or disable from the multi-tenant distribution that
/// was used to create the distribution tenant.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionTenantSpecCustomizations
{
    /// <summary>The Certificate Manager (ACM) certificate associated with your distribution.</summary>
    [JsonPropertyName("certificate")]
    public V1alpha1DistributionTenantSpecCustomizationsCertificate? Certificate { get; set; }

    /// <summary>
    /// The customizations that you specified for the distribution tenant for geographic
    /// restrictions.
    /// </summary>
    [JsonPropertyName("geoRestrictions")]
    public V1alpha1DistributionTenantSpecCustomizationsGeoRestrictions? GeoRestrictions { get; set; }

    /// <summary>The WAF web ACL customization specified for the distribution tenant.</summary>
    [JsonPropertyName("webACL")]
    public V1alpha1DistributionTenantSpecCustomizationsWebACL? WebACL { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionTenantSpecDistributionRefFrom
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
public partial class V1alpha1DistributionTenantSpecDistributionRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DistributionTenantSpecDistributionRefFrom? From { get; set; }
}

/// <summary>The domain for the specified distribution tenant.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionTenantSpecDomains
{
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
}

/// <summary>The configuration for the CloudFront managed ACM certificate request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionTenantSpecManagedCertificateRequest
{
    [JsonPropertyName("certificateTransparencyLoggingPreference")]
    public string? CertificateTransparencyLoggingPreference { get; set; }

    [JsonPropertyName("primaryDomainName")]
    public string? PrimaryDomainName { get; set; }

    [JsonPropertyName("validationTokenHost")]
    public string? ValidationTokenHost { get; set; }
}

/// <summary>
/// A list of parameter values to add to the resource. A parameter is specified
/// as a key-value pair. A valid parameter value must exist for any parameter
/// that is marked as required in the multi-tenant distribution.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionTenantSpecParameters
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A complex type that contains Tag key and Tag value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionTenantSpecTags
{
    /// <summary>
    /// A string that contains Tag key.
    /// 
    /// The string length should be between 1 and 128 characters. Valid characters
    /// include a-z, A-Z, 0-9, space, and the special characters _ - . : / = + @.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// DistributionTenantSpec defines the desired state of DistributionTenant.
/// 
/// The distribution tenant.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionTenantSpec
{
    /// <summary>The ID of the connection group to associate with the distribution tenant.</summary>
    [JsonPropertyName("connectionGroupID")]
    public string? ConnectionGroupID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("connectionGroupRef")]
    public V1alpha1DistributionTenantSpecConnectionGroupRef? ConnectionGroupRef { get; set; }

    /// <summary>
    /// Customizations for the distribution tenant. For each distribution tenant,
    /// you can specify the geographic restrictions, and the Amazon Resource Names
    /// (ARNs) for the ACM certificate and WAF web ACL. These are specific values
    /// that you can override or disable from the multi-tenant distribution that
    /// was used to create the distribution tenant.
    /// </summary>
    [JsonPropertyName("customizations")]
    public V1alpha1DistributionTenantSpecCustomizations? Customizations { get; set; }

    /// <summary>
    /// The ID of the multi-tenant distribution to use for creating the distribution
    /// tenant.
    /// </summary>
    [JsonPropertyName("distributionID")]
    public string? DistributionID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("distributionRef")]
    public V1alpha1DistributionTenantSpecDistributionRef? DistributionRef { get; set; }

    /// <summary>
    /// The domains associated with the distribution tenant. You must specify at
    /// least one domain in the request.
    /// </summary>
    [JsonPropertyName("domains")]
    public required IList<V1alpha1DistributionTenantSpecDomains> Domains { get; set; }

    /// <summary>
    /// Indicates whether the distribution tenant should be enabled when created.
    /// If the distribution tenant is disabled, the distribution tenant won&apos;t serve
    /// traffic.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The configuration for the CloudFront managed ACM certificate request.</summary>
    [JsonPropertyName("managedCertificateRequest")]
    public V1alpha1DistributionTenantSpecManagedCertificateRequest? ManagedCertificateRequest { get; set; }

    /// <summary>
    /// The name of the distribution tenant. Enter a friendly identifier that is
    /// unique within your Amazon Web Services account. This name can&apos;t be updated
    /// after you create the distribution tenant.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// A list of parameter values to add to the resource. A parameter is specified
    /// as a key-value pair. A valid parameter value must exist for any parameter
    /// that is marked as required in the multi-tenant distribution.
    /// </summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1DistributionTenantSpecParameters>? Parameters { get; set; }

    /// <summary>A complex type that contains Tag elements.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1DistributionTenantSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionTenantStatusAckResourceMetadata
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
public partial class V1alpha1DistributionTenantStatusConditions
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

/// <summary>DistributionTenantStatus defines the observed state of DistributionTenant</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DistributionTenantStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DistributionTenantStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DistributionTenantStatusConditions>? Conditions { get; set; }

    /// <summary>The date and time when the distribution tenant was created.</summary>
    [JsonPropertyName("createdTime")]
    public DateTime? CreatedTime { get; set; }

    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>The ID of the distribution tenant.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The date and time when the distribution tenant was updated.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    /// <summary>The status of the distribution tenant.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>DistributionTenant is the Schema for the DistributionTenants API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DistributionTenant : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DistributionTenantSpec?>, IStatus<V1alpha1DistributionTenantStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DistributionTenant";
    public const string KubeGroup = "cloudfront.services.k8s.aws";
    public const string KubePluralName = "distributiontenants";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DistributionTenant";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// DistributionTenantSpec defines the desired state of DistributionTenant.
    /// 
    /// The distribution tenant.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1DistributionTenantSpec? Spec { get; set; }

    /// <summary>DistributionTenantStatus defines the observed state of DistributionTenant</summary>
    [JsonPropertyName("status")]
    public V1alpha1DistributionTenantStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigatewayv2.aws.m.upbound.io;
/// <summary>DomainName is the Schema for the DomainNames API. Manages an Amazon API Gateway Version 2 domain name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DomainNameList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DomainName>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DomainNameList";
    public const string KubeGroup = "apigatewayv2.aws.m.upbound.io";
    public const string KubePluralName = "domainnames";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigatewayv2.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DomainNameList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1DomainName objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1DomainName> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnRefPolicyResolutionEnum>))]
public enum V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnRefPolicyResolveEnum>))]
public enum V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Certificate in acm to populate certificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnSelectorPolicyResolutionEnum>))]
public enum V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnSelectorPolicyResolveEnum>))]
public enum V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Certificate in acm to populate certificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Domain name configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProviderDomainNameConfiguration
{
    /// <summary>ARN of an AWS-managed certificate that will be used by the endpoint for the domain name. AWS Certificate Manager is the only supported source. Use the aws_acm_certificate resource to configure an ACM certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Reference to a Certificate in acm to populate certificateArn.</summary>
    [JsonPropertyName("certificateArnRef")]
    public V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnRef? CertificateArnRef { get; set; }

    /// <summary>Selector for a Certificate in acm to populate certificateArn.</summary>
    [JsonPropertyName("certificateArnSelector")]
    public V1beta1DomainNameSpecForProviderDomainNameConfigurationCertificateArnSelector? CertificateArnSelector { get; set; }

    /// <summary>Endpoint type. Valid values: REGIONAL.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>The IP address types that can invoke the domain name. Valid values: ipv4, dualstack. Use ipv4 to allow only IPv4 addresses to invoke your domain name, or use dualstack to allow both IPv4 and IPv6 addresses to invoke your domain name. Defaults to ipv4.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>ARN of the AWS-issued certificate used to validate custom domain ownership (when certificate_arn is issued via an ACM Private CA or mutual_tls_authentication is configured with an ACM-imported certificate.)</summary>
    [JsonPropertyName("ownershipVerificationCertificateArn")]
    public string? OwnershipVerificationCertificateArn { get; set; }

    /// <summary>Transport Layer Security (TLS) version of the security policy for the domain name. Valid values: TLS_1_2.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }
}

/// <summary>Mutual TLS authentication configuration for the domain name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProviderMutualTlsAuthentication
{
    /// <summary>Amazon S3 URL that specifies the truststore for mutual TLS authentication, for example, s3://bucket-name/key-name. The truststore can contain certificates from public or private certificate authorities. To update the truststore, upload a new version to S3, and then update your custom domain name to use the new version.</summary>
    [JsonPropertyName("truststoreUri")]
    public string? TruststoreUri { get; set; }

    /// <summary>Version of the S3 object that contains the truststore. To specify a version, you must have versioning enabled for the S3 bucket.</summary>
    [JsonPropertyName("truststoreVersion")]
    public string? TruststoreVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecForProvider
{
    /// <summary>Domain name configuration. See below.</summary>
    [JsonPropertyName("domainNameConfiguration")]
    public V1beta1DomainNameSpecForProviderDomainNameConfiguration? DomainNameConfiguration { get; set; }

    /// <summary>Mutual TLS authentication configuration for the domain name.</summary>
    [JsonPropertyName("mutualTlsAuthentication")]
    public V1beta1DomainNameSpecForProviderMutualTlsAuthentication? MutualTlsAuthentication { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Mode to route traffic for the domain name. Valid values: API_MAPPING_ONLY, ROUTING_RULE_ONLY, ROUTING_RULE_THEN_API_MAPPING.</summary>
    [JsonPropertyName("routingMode")]
    public string? RoutingMode { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnRefPolicyResolutionEnum>))]
public enum V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnRefPolicyResolveEnum>))]
public enum V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Certificate in acm to populate certificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnSelectorPolicyResolutionEnum>))]
public enum V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnSelectorPolicyResolveEnum>))]
public enum V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Certificate in acm to populate certificateArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Domain name configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProviderDomainNameConfiguration
{
    /// <summary>ARN of an AWS-managed certificate that will be used by the endpoint for the domain name. AWS Certificate Manager is the only supported source. Use the aws_acm_certificate resource to configure an ACM certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Reference to a Certificate in acm to populate certificateArn.</summary>
    [JsonPropertyName("certificateArnRef")]
    public V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnRef? CertificateArnRef { get; set; }

    /// <summary>Selector for a Certificate in acm to populate certificateArn.</summary>
    [JsonPropertyName("certificateArnSelector")]
    public V1beta1DomainNameSpecInitProviderDomainNameConfigurationCertificateArnSelector? CertificateArnSelector { get; set; }

    /// <summary>Endpoint type. Valid values: REGIONAL.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>The IP address types that can invoke the domain name. Valid values: ipv4, dualstack. Use ipv4 to allow only IPv4 addresses to invoke your domain name, or use dualstack to allow both IPv4 and IPv6 addresses to invoke your domain name. Defaults to ipv4.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>ARN of the AWS-issued certificate used to validate custom domain ownership (when certificate_arn is issued via an ACM Private CA or mutual_tls_authentication is configured with an ACM-imported certificate.)</summary>
    [JsonPropertyName("ownershipVerificationCertificateArn")]
    public string? OwnershipVerificationCertificateArn { get; set; }

    /// <summary>Transport Layer Security (TLS) version of the security policy for the domain name. Valid values: TLS_1_2.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }
}

/// <summary>Mutual TLS authentication configuration for the domain name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProviderMutualTlsAuthentication
{
    /// <summary>Amazon S3 URL that specifies the truststore for mutual TLS authentication, for example, s3://bucket-name/key-name. The truststore can contain certificates from public or private certificate authorities. To update the truststore, upload a new version to S3, and then update your custom domain name to use the new version.</summary>
    [JsonPropertyName("truststoreUri")]
    public string? TruststoreUri { get; set; }

    /// <summary>Version of the S3 object that contains the truststore. To specify a version, you must have versioning enabled for the S3 bucket.</summary>
    [JsonPropertyName("truststoreVersion")]
    public string? TruststoreVersion { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecInitProvider
{
    /// <summary>Domain name configuration. See below.</summary>
    [JsonPropertyName("domainNameConfiguration")]
    public V1beta1DomainNameSpecInitProviderDomainNameConfiguration? DomainNameConfiguration { get; set; }

    /// <summary>Mutual TLS authentication configuration for the domain name.</summary>
    [JsonPropertyName("mutualTlsAuthentication")]
    public V1beta1DomainNameSpecInitProviderMutualTlsAuthentication? MutualTlsAuthentication { get; set; }

    /// <summary>Mode to route traffic for the domain name. Valid values: API_MAPPING_ONLY, ROUTING_RULE_ONLY, ROUTING_RULE_THEN_API_MAPPING.</summary>
    [JsonPropertyName("routingMode")]
    public string? RoutingMode { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DomainNameSpecManagementPoliciesEnum>))]
public enum V1beta1DomainNameSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>DomainNameSpec defines the desired state of DomainName</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1DomainNameSpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DomainNameSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DomainNameSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DomainNameSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DomainNameSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Domain name configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameStatusAtProviderDomainNameConfiguration
{
    /// <summary>ARN of an AWS-managed certificate that will be used by the endpoint for the domain name. AWS Certificate Manager is the only supported source. Use the aws_acm_certificate resource to configure an ACM certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Endpoint type. Valid values: REGIONAL.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>(Computed) Amazon Route 53 Hosted Zone ID of the endpoint.</summary>
    [JsonPropertyName("hostedZoneId")]
    public string? HostedZoneId { get; set; }

    /// <summary>The IP address types that can invoke the domain name. Valid values: ipv4, dualstack. Use ipv4 to allow only IPv4 addresses to invoke your domain name, or use dualstack to allow both IPv4 and IPv6 addresses to invoke your domain name. Defaults to ipv4.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>ARN of the AWS-issued certificate used to validate custom domain ownership (when certificate_arn is issued via an ACM Private CA or mutual_tls_authentication is configured with an ACM-imported certificate.)</summary>
    [JsonPropertyName("ownershipVerificationCertificateArn")]
    public string? OwnershipVerificationCertificateArn { get; set; }

    /// <summary>Transport Layer Security (TLS) version of the security policy for the domain name. Valid values: TLS_1_2.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }

    /// <summary>(Computed) Target domain name.</summary>
    [JsonPropertyName("targetDomainName")]
    public string? TargetDomainName { get; set; }
}

/// <summary>Mutual TLS authentication configuration for the domain name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameStatusAtProviderMutualTlsAuthentication
{
    /// <summary>Amazon S3 URL that specifies the truststore for mutual TLS authentication, for example, s3://bucket-name/key-name. The truststore can contain certificates from public or private certificate authorities. To update the truststore, upload a new version to S3, and then update your custom domain name to use the new version.</summary>
    [JsonPropertyName("truststoreUri")]
    public string? TruststoreUri { get; set; }

    /// <summary>Version of the S3 object that contains the truststore. To specify a version, you must have versioning enabled for the S3 bucket.</summary>
    [JsonPropertyName("truststoreVersion")]
    public string? TruststoreVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameStatusAtProvider
{
    /// <summary>API mapping selection expression for the domain name.</summary>
    [JsonPropertyName("apiMappingSelectionExpression")]
    public string? ApiMappingSelectionExpression { get; set; }

    /// <summary>ARN of the domain name.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Domain name configuration. See below.</summary>
    [JsonPropertyName("domainNameConfiguration")]
    public V1beta1DomainNameStatusAtProviderDomainNameConfiguration? DomainNameConfiguration { get; set; }

    /// <summary>Domain name identifier.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Mutual TLS authentication configuration for the domain name.</summary>
    [JsonPropertyName("mutualTlsAuthentication")]
    public V1beta1DomainNameStatusAtProviderMutualTlsAuthentication? MutualTlsAuthentication { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Mode to route traffic for the domain name. Valid values: API_MAPPING_ONLY, ROUTING_RULE_ONLY, ROUTING_RULE_THEN_API_MAPPING.</summary>
    [JsonPropertyName("routingMode")]
    public string? RoutingMode { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>DomainNameStatus defines the observed state of DomainName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DomainNameStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1DomainNameStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DomainNameStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DomainName is the Schema for the DomainNames API. Manages an Amazon API Gateway Version 2 domain name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DomainName : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DomainNameSpec>, IStatus<V1beta1DomainNameStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DomainName";
    public const string KubeGroup = "apigatewayv2.aws.m.upbound.io";
    public const string KubePluralName = "domainnames";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigatewayv2.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DomainName";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DomainNameSpec defines the desired state of DomainName</summary>
    [JsonPropertyName("spec")]
    public required V1beta1DomainNameSpec Spec { get; set; }

    /// <summary>DomainNameStatus defines the observed state of DomainName.</summary>
    [JsonPropertyName("status")]
    public V1beta1DomainNameStatus? Status { get; set; }
}
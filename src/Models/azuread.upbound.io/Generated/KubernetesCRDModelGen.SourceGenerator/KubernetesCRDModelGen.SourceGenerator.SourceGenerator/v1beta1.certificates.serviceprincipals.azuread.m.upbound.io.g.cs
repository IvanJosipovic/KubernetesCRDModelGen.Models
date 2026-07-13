#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.serviceprincipals.azuread.m.upbound.io;
/// <summary>Certificate is the Schema for the Certificates API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CertificateList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Certificate>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CertificateList";
    public const string KubeGroup = "serviceprincipals.azuread.m.upbound.io";
    public const string KubePluralName = "certificates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "serviceprincipals.azuread.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CertificateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Certificate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Certificate> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateSpecForProviderServicePrincipalIdRefPolicyResolutionEnum>))]
public enum V1beta1CertificateSpecForProviderServicePrincipalIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateSpecForProviderServicePrincipalIdRefPolicyResolveEnum>))]
public enum V1beta1CertificateSpecForProviderServicePrincipalIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderServicePrincipalIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CertificateSpecForProviderServicePrincipalIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CertificateSpecForProviderServicePrincipalIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Principal in serviceprincipals to populate servicePrincipalId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderServicePrincipalIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateSpecForProviderServicePrincipalIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateSpecForProviderServicePrincipalIdSelectorPolicyResolutionEnum>))]
public enum V1beta1CertificateSpecForProviderServicePrincipalIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateSpecForProviderServicePrincipalIdSelectorPolicyResolveEnum>))]
public enum V1beta1CertificateSpecForProviderServicePrincipalIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderServicePrincipalIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CertificateSpecForProviderServicePrincipalIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CertificateSpecForProviderServicePrincipalIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Principal in serviceprincipals to populate servicePrincipalId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderServicePrincipalIdSelector
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
    public V1beta1CertificateSpecForProviderServicePrincipalIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The certificate data, which can be PEM encoded, base64 encoded DER or hexadecimal encoded DER. See also the encoding argument.
/// The certificate data, which can be PEM encoded, base64 encoded DER or hexadecimal encoded DER
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProviderValueSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecForProvider
{
    /// <summary>
    /// Specifies the encoding used for the supplied certificate data. Must be one of pem, base64 or hex. Defaults to pem.
    /// Specifies the encoding used for the supplied certificate data
    /// </summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>
    /// The end date until which the certificate is valid, formatted as an RFC3339 date string (e.g. 2018-01-01T01:02:03Z). Changing this field forces a new resource to be created.
    /// The end date until which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`)
    /// </summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>
    /// A relative duration for which the certificate is valid until, for example 240h (10 days) or 2400h30m. Valid time units are &quot;ns&quot;, &quot;us&quot; (or &quot;µs&quot;), &quot;ms&quot;, &quot;s&quot;, &quot;m&quot;, &quot;h&quot;. Changing this field forces a new resource to be created.
    /// A relative duration for which the certificate is valid until, for example `240h` (10 days) or `2400h30m`. Valid time units are &quot;ns&quot;, &quot;us&quot; (or &quot;µs&quot;), &quot;ms&quot;, &quot;s&quot;, &quot;m&quot;, &quot;h&quot;
    /// </summary>
    [JsonPropertyName("endDateRelative")]
    public string? EndDateRelative { get; set; }

    /// <summary>
    /// A UUID used to uniquely identify this certificate. If not specified a UUID will be automatically generated. Changing this field forces a new resource to be created.
    /// A UUID used to uniquely identify this certificate. If not specified a UUID will be automatically generated
    /// </summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>
    /// The ID of the service principal for which this certificate should be created. Changing this field forces a new resource to be created.
    /// The object ID of the service principal for which this certificate should be created
    /// </summary>
    [JsonPropertyName("servicePrincipalId")]
    public string? ServicePrincipalId { get; set; }

    /// <summary>Reference to a Principal in serviceprincipals to populate servicePrincipalId.</summary>
    [JsonPropertyName("servicePrincipalIdRef")]
    public V1beta1CertificateSpecForProviderServicePrincipalIdRef? ServicePrincipalIdRef { get; set; }

    /// <summary>Selector for a Principal in serviceprincipals to populate servicePrincipalId.</summary>
    [JsonPropertyName("servicePrincipalIdSelector")]
    public V1beta1CertificateSpecForProviderServicePrincipalIdSelector? ServicePrincipalIdSelector { get; set; }

    /// <summary>
    /// The start date from which the certificate is valid, formatted as an RFC3339 date string (e.g. 2018-01-01T01:02:03Z). If this isn&apos;t specified, the value is determined by Azure Active Directory and is usually the start date of the certificate for asymmetric keys, or the current timestamp for symmetric keys. Changing this field forces a new resource to be created.
    /// The start date from which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn&apos;t specified, the current date is used
    /// </summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>
    /// The type of key/certificate. Must be one of AsymmetricX509Cert or Symmetric. Changing this fields forces a new resource to be created.
    /// The type of key/certificate
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// The certificate data, which can be PEM encoded, base64 encoded DER or hexadecimal encoded DER. See also the encoding argument.
    /// The certificate data, which can be PEM encoded, base64 encoded DER or hexadecimal encoded DER
    /// </summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1CertificateSpecForProviderValueSecretRef? ValueSecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateSpecInitProviderServicePrincipalIdRefPolicyResolutionEnum>))]
public enum V1beta1CertificateSpecInitProviderServicePrincipalIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateSpecInitProviderServicePrincipalIdRefPolicyResolveEnum>))]
public enum V1beta1CertificateSpecInitProviderServicePrincipalIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderServicePrincipalIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CertificateSpecInitProviderServicePrincipalIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CertificateSpecInitProviderServicePrincipalIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Principal in serviceprincipals to populate servicePrincipalId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderServicePrincipalIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CertificateSpecInitProviderServicePrincipalIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateSpecInitProviderServicePrincipalIdSelectorPolicyResolutionEnum>))]
public enum V1beta1CertificateSpecInitProviderServicePrincipalIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateSpecInitProviderServicePrincipalIdSelectorPolicyResolveEnum>))]
public enum V1beta1CertificateSpecInitProviderServicePrincipalIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderServicePrincipalIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CertificateSpecInitProviderServicePrincipalIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CertificateSpecInitProviderServicePrincipalIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Principal in serviceprincipals to populate servicePrincipalId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderServicePrincipalIdSelector
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
    public V1beta1CertificateSpecInitProviderServicePrincipalIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The certificate data, which can be PEM encoded, base64 encoded DER or hexadecimal encoded DER. See also the encoding argument.
/// The certificate data, which can be PEM encoded, base64 encoded DER or hexadecimal encoded DER
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpecInitProviderValueSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
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
public partial class V1beta1CertificateSpecInitProvider
{
    /// <summary>
    /// Specifies the encoding used for the supplied certificate data. Must be one of pem, base64 or hex. Defaults to pem.
    /// Specifies the encoding used for the supplied certificate data
    /// </summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>
    /// The end date until which the certificate is valid, formatted as an RFC3339 date string (e.g. 2018-01-01T01:02:03Z). Changing this field forces a new resource to be created.
    /// The end date until which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`)
    /// </summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>
    /// A relative duration for which the certificate is valid until, for example 240h (10 days) or 2400h30m. Valid time units are &quot;ns&quot;, &quot;us&quot; (or &quot;µs&quot;), &quot;ms&quot;, &quot;s&quot;, &quot;m&quot;, &quot;h&quot;. Changing this field forces a new resource to be created.
    /// A relative duration for which the certificate is valid until, for example `240h` (10 days) or `2400h30m`. Valid time units are &quot;ns&quot;, &quot;us&quot; (or &quot;µs&quot;), &quot;ms&quot;, &quot;s&quot;, &quot;m&quot;, &quot;h&quot;
    /// </summary>
    [JsonPropertyName("endDateRelative")]
    public string? EndDateRelative { get; set; }

    /// <summary>
    /// A UUID used to uniquely identify this certificate. If not specified a UUID will be automatically generated. Changing this field forces a new resource to be created.
    /// A UUID used to uniquely identify this certificate. If not specified a UUID will be automatically generated
    /// </summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>
    /// The ID of the service principal for which this certificate should be created. Changing this field forces a new resource to be created.
    /// The object ID of the service principal for which this certificate should be created
    /// </summary>
    [JsonPropertyName("servicePrincipalId")]
    public string? ServicePrincipalId { get; set; }

    /// <summary>Reference to a Principal in serviceprincipals to populate servicePrincipalId.</summary>
    [JsonPropertyName("servicePrincipalIdRef")]
    public V1beta1CertificateSpecInitProviderServicePrincipalIdRef? ServicePrincipalIdRef { get; set; }

    /// <summary>Selector for a Principal in serviceprincipals to populate servicePrincipalId.</summary>
    [JsonPropertyName("servicePrincipalIdSelector")]
    public V1beta1CertificateSpecInitProviderServicePrincipalIdSelector? ServicePrincipalIdSelector { get; set; }

    /// <summary>
    /// The start date from which the certificate is valid, formatted as an RFC3339 date string (e.g. 2018-01-01T01:02:03Z). If this isn&apos;t specified, the value is determined by Azure Active Directory and is usually the start date of the certificate for asymmetric keys, or the current timestamp for symmetric keys. Changing this field forces a new resource to be created.
    /// The start date from which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn&apos;t specified, the current date is used
    /// </summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>
    /// The type of key/certificate. Must be one of AsymmetricX509Cert or Symmetric. Changing this fields forces a new resource to be created.
    /// The type of key/certificate
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// The certificate data, which can be PEM encoded, base64 encoded DER or hexadecimal encoded DER. See also the encoding argument.
    /// The certificate data, which can be PEM encoded, base64 encoded DER or hexadecimal encoded DER
    /// </summary>
    [JsonPropertyName("valueSecretRef")]
    public required V1beta1CertificateSpecInitProviderValueSecretRef ValueSecretRef { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CertificateSpecManagementPoliciesEnum>))]
public enum V1beta1CertificateSpecManagementPoliciesEnum
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
public partial class V1beta1CertificateSpecProviderConfigRef
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
public partial class V1beta1CertificateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>CertificateSpec defines the desired state of Certificate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1CertificateSpecForProvider ForProvider { get; set; }

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
    public V1beta1CertificateSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1CertificateSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CertificateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CertificateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusAtProvider
{
    /// <summary>
    /// Specifies the encoding used for the supplied certificate data. Must be one of pem, base64 or hex. Defaults to pem.
    /// Specifies the encoding used for the supplied certificate data
    /// </summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>
    /// The end date until which the certificate is valid, formatted as an RFC3339 date string (e.g. 2018-01-01T01:02:03Z). Changing this field forces a new resource to be created.
    /// The end date until which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`)
    /// </summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>
    /// A relative duration for which the certificate is valid until, for example 240h (10 days) or 2400h30m. Valid time units are &quot;ns&quot;, &quot;us&quot; (or &quot;µs&quot;), &quot;ms&quot;, &quot;s&quot;, &quot;m&quot;, &quot;h&quot;. Changing this field forces a new resource to be created.
    /// A relative duration for which the certificate is valid until, for example `240h` (10 days) or `2400h30m`. Valid time units are &quot;ns&quot;, &quot;us&quot; (or &quot;µs&quot;), &quot;ms&quot;, &quot;s&quot;, &quot;m&quot;, &quot;h&quot;
    /// </summary>
    [JsonPropertyName("endDateRelative")]
    public string? EndDateRelative { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// A UUID used to uniquely identify this certificate. If not specified a UUID will be automatically generated. Changing this field forces a new resource to be created.
    /// A UUID used to uniquely identify this certificate. If not specified a UUID will be automatically generated
    /// </summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>
    /// The ID of the service principal for which this certificate should be created. Changing this field forces a new resource to be created.
    /// The object ID of the service principal for which this certificate should be created
    /// </summary>
    [JsonPropertyName("servicePrincipalId")]
    public string? ServicePrincipalId { get; set; }

    /// <summary>
    /// The start date from which the certificate is valid, formatted as an RFC3339 date string (e.g. 2018-01-01T01:02:03Z). If this isn&apos;t specified, the value is determined by Azure Active Directory and is usually the start date of the certificate for asymmetric keys, or the current timestamp for symmetric keys. Changing this field forces a new resource to be created.
    /// The start date from which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn&apos;t specified, the current date is used
    /// </summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>
    /// The type of key/certificate. Must be one of AsymmetricX509Cert or Symmetric. Changing this fields forces a new resource to be created.
    /// The type of key/certificate
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatusConditions
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

/// <summary>CertificateStatus defines the observed state of Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CertificateStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1CertificateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CertificateStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Certificate is the Schema for the Certificates API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Certificate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CertificateSpec>, IStatus<V1beta1CertificateStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Certificate";
    public const string KubeGroup = "serviceprincipals.azuread.m.upbound.io";
    public const string KubePluralName = "certificates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "serviceprincipals.azuread.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Certificate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CertificateSpec defines the desired state of Certificate</summary>
    [JsonPropertyName("spec")]
    public required V1beta1CertificateSpec Spec { get; set; }

    /// <summary>CertificateStatus defines the observed state of Certificate.</summary>
    [JsonPropertyName("status")]
    public V1beta1CertificateStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apigee.gcp.m.upbound.io;
/// <summary>KeystoresAliasesKeyCertFile is the Schema for the KeystoresAliasesKeyCertFiles API. &lt;no value&gt;</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1KeystoresAliasesKeyCertFileList : IKubernetesObject<V1ListMeta>, IItems<V1beta1KeystoresAliasesKeyCertFile>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "KeystoresAliasesKeyCertFileList";
    public const string KubeGroup = "apigee.gcp.m.upbound.io";
    public const string KubePluralName = "keystoresaliaseskeycertfiles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigee.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KeystoresAliasesKeyCertFileList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1KeystoresAliasesKeyCertFile objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1KeystoresAliasesKeyCertFile> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileSpecForProviderCertsInfoCertInfo
{
    [JsonPropertyName("basicConstraints")]
    public string? BasicConstraints { get; set; }

    [JsonPropertyName("expiryDate")]
    public string? ExpiryDate { get; set; }

    [JsonPropertyName("isValid")]
    public string? IsValid { get; set; }

    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    [JsonPropertyName("sigAlgName")]
    public string? SigAlgName { get; set; }

    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    [JsonPropertyName("subjectAlternativeNames")]
    public IList<string>? SubjectAlternativeNames { get; set; }

    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    [JsonPropertyName("version")]
    public double? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileSpecForProviderCertsInfo
{
    [JsonPropertyName("certInfo")]
    public IList<V1beta1KeystoresAliasesKeyCertFileSpecForProviderCertsInfoCertInfo>? CertInfo { get; set; }
}

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileSpecForProviderKeySecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdRefPolicyResolutionEnum>))]
public enum V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdRefPolicyResolveEnum>))]
public enum V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Organization in apigee to populate orgId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdSelectorPolicyResolutionEnum>))]
public enum V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdSelectorPolicyResolveEnum>))]
public enum V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Organization in apigee to populate orgId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdSelector
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
    public V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileSpecForProviderPasswordSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileSpecForProvider
{
    [JsonPropertyName("cert")]
    public string? Cert { get; set; }

    [JsonPropertyName("certsInfo")]
    public V1beta1KeystoresAliasesKeyCertFileSpecForProviderCertsInfo? CertsInfo { get; set; }

    [JsonPropertyName("environment")]
    public required string Environment { get; set; }

    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta1KeystoresAliasesKeyCertFileSpecForProviderKeySecretRef? KeySecretRef { get; set; }

    [JsonPropertyName("keystore")]
    public required string Keystore { get; set; }

    [JsonPropertyName("orgId")]
    public string? OrgId { get; set; }

    /// <summary>Reference to a Organization in apigee to populate orgId.</summary>
    [JsonPropertyName("orgIdRef")]
    public V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdRef? OrgIdRef { get; set; }

    /// <summary>Selector for a Organization in apigee to populate orgId.</summary>
    [JsonPropertyName("orgIdSelector")]
    public V1beta1KeystoresAliasesKeyCertFileSpecForProviderOrgIdSelector? OrgIdSelector { get; set; }

    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1KeystoresAliasesKeyCertFileSpecForProviderPasswordSecretRef? PasswordSecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileSpecInitProviderCertsInfoCertInfo
{
    [JsonPropertyName("basicConstraints")]
    public string? BasicConstraints { get; set; }

    [JsonPropertyName("expiryDate")]
    public string? ExpiryDate { get; set; }

    [JsonPropertyName("isValid")]
    public string? IsValid { get; set; }

    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    [JsonPropertyName("sigAlgName")]
    public string? SigAlgName { get; set; }

    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    [JsonPropertyName("subjectAlternativeNames")]
    public IList<string>? SubjectAlternativeNames { get; set; }

    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    [JsonPropertyName("version")]
    public double? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileSpecInitProviderCertsInfo
{
    [JsonPropertyName("certInfo")]
    public IList<V1beta1KeystoresAliasesKeyCertFileSpecInitProviderCertsInfoCertInfo>? CertInfo { get; set; }
}

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileSpecInitProviderKeySecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileSpecInitProviderPasswordSecretRef
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
public partial class V1beta1KeystoresAliasesKeyCertFileSpecInitProvider
{
    [JsonPropertyName("cert")]
    public string? Cert { get; set; }

    [JsonPropertyName("certsInfo")]
    public V1beta1KeystoresAliasesKeyCertFileSpecInitProviderCertsInfo? CertsInfo { get; set; }

    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta1KeystoresAliasesKeyCertFileSpecInitProviderKeySecretRef? KeySecretRef { get; set; }

    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1KeystoresAliasesKeyCertFileSpecInitProviderPasswordSecretRef? PasswordSecretRef { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1KeystoresAliasesKeyCertFileSpecManagementPoliciesEnum>))]
public enum V1beta1KeystoresAliasesKeyCertFileSpecManagementPoliciesEnum
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
public partial class V1beta1KeystoresAliasesKeyCertFileSpecProviderConfigRef
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
public partial class V1beta1KeystoresAliasesKeyCertFileSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>KeystoresAliasesKeyCertFileSpec defines the desired state of KeystoresAliasesKeyCertFile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1KeystoresAliasesKeyCertFileSpecForProvider ForProvider { get; set; }

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
    public V1beta1KeystoresAliasesKeyCertFileSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1KeystoresAliasesKeyCertFileSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1KeystoresAliasesKeyCertFileSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1KeystoresAliasesKeyCertFileSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileStatusAtProviderCertsInfoCertInfo
{
    [JsonPropertyName("basicConstraints")]
    public string? BasicConstraints { get; set; }

    [JsonPropertyName("expiryDate")]
    public string? ExpiryDate { get; set; }

    [JsonPropertyName("isValid")]
    public string? IsValid { get; set; }

    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    [JsonPropertyName("sigAlgName")]
    public string? SigAlgName { get; set; }

    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    [JsonPropertyName("subjectAlternativeNames")]
    public IList<string>? SubjectAlternativeNames { get; set; }

    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    [JsonPropertyName("version")]
    public double? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileStatusAtProviderCertsInfo
{
    [JsonPropertyName("certInfo")]
    public IList<V1beta1KeystoresAliasesKeyCertFileStatusAtProviderCertsInfoCertInfo>? CertInfo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileStatusAtProvider
{
    [JsonPropertyName("cert")]
    public string? Cert { get; set; }

    [JsonPropertyName("certsInfo")]
    public V1beta1KeystoresAliasesKeyCertFileStatusAtProviderCertsInfo? CertsInfo { get; set; }

    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("keystore")]
    public string? Keystore { get; set; }

    [JsonPropertyName("orgId")]
    public string? OrgId { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileStatusConditions
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

/// <summary>KeystoresAliasesKeyCertFileStatus defines the observed state of KeystoresAliasesKeyCertFile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeystoresAliasesKeyCertFileStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1KeystoresAliasesKeyCertFileStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1KeystoresAliasesKeyCertFileStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>KeystoresAliasesKeyCertFile is the Schema for the KeystoresAliasesKeyCertFiles API. &lt;no value&gt;</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1KeystoresAliasesKeyCertFile : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1KeystoresAliasesKeyCertFileSpec>, IStatus<V1beta1KeystoresAliasesKeyCertFileStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "KeystoresAliasesKeyCertFile";
    public const string KubeGroup = "apigee.gcp.m.upbound.io";
    public const string KubePluralName = "keystoresaliaseskeycertfiles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apigee.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KeystoresAliasesKeyCertFile";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>KeystoresAliasesKeyCertFileSpec defines the desired state of KeystoresAliasesKeyCertFile</summary>
    [JsonPropertyName("spec")]
    public required V1beta1KeystoresAliasesKeyCertFileSpec Spec { get; set; }

    /// <summary>KeystoresAliasesKeyCertFileStatus defines the observed state of KeystoresAliasesKeyCertFile.</summary>
    [JsonPropertyName("status")]
    public V1beta1KeystoresAliasesKeyCertFileStatus? Status { get; set; }
}
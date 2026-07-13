#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.workspaces.aws.m.upbound.io;
/// <summary>Directory is the Schema for the Directorys API. Provides a WorkSpaces directory in AWS WorkSpaces Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DirectoryList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Directory>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DirectoryList";
    public const string KubeGroup = "workspaces.aws.m.upbound.io";
    public const string KubePluralName = "directories";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "workspaces.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DirectoryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Directory objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Directory> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnRefPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnRefPolicyResolveEnum>))]
public enum V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate serviceAccountSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnSelectorPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnSelectorPolicyResolveEnum>))]
public enum V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate serviceAccountSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnSelector
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
    public V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration for Active Directory integration when workspace_type is set to POOLS. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderActiveDirectoryConfig
{
    /// <summary>Fully qualified domain name of the AWS Directory Service directory.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>ARN of the Secrets Manager secret that contains the credentials for the service account. For more information, see Service Account Details.</summary>
    [JsonPropertyName("serviceAccountSecretArn")]
    public string? ServiceAccountSecretArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate serviceAccountSecretArn.</summary>
    [JsonPropertyName("serviceAccountSecretArnRef")]
    public V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnRef? ServiceAccountSecretArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate serviceAccountSecretArn.</summary>
    [JsonPropertyName("serviceAccountSecretArnSelector")]
    public V1beta1DirectorySpecForProviderActiveDirectoryConfigServiceAccountSecretArnSelector? ServiceAccountSecretArnSelector { get; set; }
}

/// <summary>Configuration of certificate-based authentication (CBA) integration. Requires SAML authentication to be enabled. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderCertificateBasedAuthProperties
{
    /// <summary>The Amazon Resource Name (ARN) of the certificate manager private certificate authority (ACM-PCA) that is used for certificate-based authentication.</summary>
    [JsonPropertyName("certificateAuthorityArn")]
    public string? CertificateAuthorityArn { get; set; }

    /// <summary>Status of certificate-based authentication. Default DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderDirectoryIdRefPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecForProviderDirectoryIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderDirectoryIdRefPolicyResolveEnum>))]
public enum V1beta1DirectorySpecForProviderDirectoryIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderDirectoryIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecForProviderDirectoryIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecForProviderDirectoryIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Directory in ds to populate directoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderDirectoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DirectorySpecForProviderDirectoryIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderDirectoryIdSelectorPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecForProviderDirectoryIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderDirectoryIdSelectorPolicyResolveEnum>))]
public enum V1beta1DirectorySpecForProviderDirectoryIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderDirectoryIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecForProviderDirectoryIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecForProviderDirectoryIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Directory in ds to populate directoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderDirectoryIdSelector
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
    public V1beta1DirectorySpecForProviderDirectoryIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderIpGroupIdsRefsPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecForProviderIpGroupIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderIpGroupIdsRefsPolicyResolveEnum>))]
public enum V1beta1DirectorySpecForProviderIpGroupIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderIpGroupIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecForProviderIpGroupIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecForProviderIpGroupIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderIpGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DirectorySpecForProviderIpGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderIpGroupIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecForProviderIpGroupIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderIpGroupIdsSelectorPolicyResolveEnum>))]
public enum V1beta1DirectorySpecForProviderIpGroupIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderIpGroupIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecForProviderIpGroupIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecForProviderIpGroupIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of IPGroup in workspaces to populate ipGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderIpGroupIdsSelector
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
    public V1beta1DirectorySpecForProviderIpGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration of SAML authentication integration. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderSamlProperties
{
    /// <summary>The relay state parameter name supported by the SAML 2.0 identity provider (IdP). Default RelayState.</summary>
    [JsonPropertyName("relayStateParameterName")]
    public string? RelayStateParameterName { get; set; }

    /// <summary>Status of SAML 2.0 authentication. Default DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The SAML 2.0 identity provider (IdP) user access URL.</summary>
    [JsonPropertyName("userAccessUrl")]
    public string? UserAccessUrl { get; set; }
}

/// <summary>Permissions to enable or disable self-service capabilities when workspace_type is set to PERSONAL.. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderSelfServicePermissions
{
    /// <summary>Whether WorkSpaces directory users can change the compute type (bundle) for their workspace. Default false.</summary>
    [JsonPropertyName("changeComputeType")]
    public bool? ChangeComputeType { get; set; }

    /// <summary>Whether WorkSpaces directory users can increase the volume size of the drives on their workspace. Default false.</summary>
    [JsonPropertyName("increaseVolumeSize")]
    public bool? IncreaseVolumeSize { get; set; }

    /// <summary>Whether WorkSpaces directory users can rebuild the operating system of a workspace to its original state. Default false.</summary>
    [JsonPropertyName("rebuildWorkspace")]
    public bool? RebuildWorkspace { get; set; }

    /// <summary>Whether WorkSpaces directory users can restart their workspace. Default true.</summary>
    [JsonPropertyName("restartWorkspace")]
    public bool? RestartWorkspace { get; set; }

    /// <summary>Whether WorkSpaces directory users can switch the running mode of their workspace. Default false.</summary>
    [JsonPropertyName("switchRunningMode")]
    public bool? SwitchRunningMode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderSubnetIdRefsPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecForProviderSubnetIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderSubnetIdRefsPolicyResolveEnum>))]
public enum V1beta1DirectorySpecForProviderSubnetIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderSubnetIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecForProviderSubnetIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecForProviderSubnetIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DirectorySpecForProviderSubnetIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecForProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1DirectorySpecForProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderSubnetIdSelector
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
    public V1beta1DirectorySpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies which devices and operating systems users can use to access their WorkSpaces. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderWorkspaceAccessProperties
{
    /// <summary>Indicates whether users can use Android devices to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeAndroid")]
    public string? DeviceTypeAndroid { get; set; }

    /// <summary>Indicates whether users can use Chromebooks to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeChromeos")]
    public string? DeviceTypeChromeos { get; set; }

    /// <summary>Indicates whether users can use iOS devices to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeIos")]
    public string? DeviceTypeIos { get; set; }

    /// <summary>Indicates whether users can use Linux clients to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeLinux")]
    public string? DeviceTypeLinux { get; set; }

    /// <summary>Indicates whether users can use macOS clients to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeOsx")]
    public string? DeviceTypeOsx { get; set; }

    /// <summary>Indicates whether users can access their WorkSpaces through a web browser.</summary>
    [JsonPropertyName("deviceTypeWeb")]
    public string? DeviceTypeWeb { get; set; }

    /// <summary>Indicates whether users can use Windows clients to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeWindows")]
    public string? DeviceTypeWindows { get; set; }

    /// <summary>Indicates whether users can use zero client devices to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeZeroclient")]
    public string? DeviceTypeZeroclient { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRefPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRefPolicyResolveEnum>))]
public enum V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecurityGroup in ec2 to populate customSecurityGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecurityGroup in ec2 to populate customSecurityGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelector
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
    public V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Default properties that are used for creating WorkSpaces. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProviderWorkspaceCreationProperties
{
    /// <summary>The identifier of your custom security group. Should relate to the same VPC, where workspaces reside in.</summary>
    [JsonPropertyName("customSecurityGroupId")]
    public string? CustomSecurityGroupId { get; set; }

    /// <summary>Reference to a SecurityGroup in ec2 to populate customSecurityGroupId.</summary>
    [JsonPropertyName("customSecurityGroupIdRef")]
    public V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRef? CustomSecurityGroupIdRef { get; set; }

    /// <summary>Selector for a SecurityGroup in ec2 to populate customSecurityGroupId.</summary>
    [JsonPropertyName("customSecurityGroupIdSelector")]
    public V1beta1DirectorySpecForProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelector? CustomSecurityGroupIdSelector { get; set; }

    /// <summary>The default organizational unit (OU) for your WorkSpace directories. Should conform &quot;OU=&lt;value&gt;,DC=&lt;value&gt;,...,DC=&lt;value&gt; &quot; pattern.</summary>
    [JsonPropertyName("defaultOu")]
    public string? DefaultOu { get; set; }

    /// <summary>Indicates whether internet access is enabled for your WorkSpaces.</summary>
    [JsonPropertyName("enableInternetAccess")]
    public bool? EnableInternetAccess { get; set; }

    /// <summary>Indicates whether maintenance mode is enabled for your WorkSpaces. Valid only if workspace_type is set to PERSONAL.</summary>
    [JsonPropertyName("enableMaintenanceMode")]
    public bool? EnableMaintenanceMode { get; set; }

    /// <summary>Indicates whether users are local administrators of their WorkSpaces. Valid only if workspace_type is set to PERSONAL.</summary>
    [JsonPropertyName("userEnabledAsLocalAdministrator")]
    public bool? UserEnabledAsLocalAdministrator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecForProvider
{
    /// <summary>Configuration for Active Directory integration when workspace_type is set to POOLS. Defined below.</summary>
    [JsonPropertyName("activeDirectoryConfig")]
    public V1beta1DirectorySpecForProviderActiveDirectoryConfig? ActiveDirectoryConfig { get; set; }

    /// <summary>Configuration of certificate-based authentication (CBA) integration. Requires SAML authentication to be enabled. Defined below.</summary>
    [JsonPropertyName("certificateBasedAuthProperties")]
    public V1beta1DirectorySpecForProviderCertificateBasedAuthProperties? CertificateBasedAuthProperties { get; set; }

    /// <summary>The directory identifier for registration in WorkSpaces service.</summary>
    [JsonPropertyName("directoryId")]
    public string? DirectoryId { get; set; }

    /// <summary>Reference to a Directory in ds to populate directoryId.</summary>
    [JsonPropertyName("directoryIdRef")]
    public V1beta1DirectorySpecForProviderDirectoryIdRef? DirectoryIdRef { get; set; }

    /// <summary>Selector for a Directory in ds to populate directoryId.</summary>
    [JsonPropertyName("directoryIdSelector")]
    public V1beta1DirectorySpecForProviderDirectoryIdSelector? DirectoryIdSelector { get; set; }

    /// <summary>The identifiers of the IP access control groups associated with the directory.</summary>
    [JsonPropertyName("ipGroupIds")]
    public IList<string>? IpGroupIds { get; set; }

    /// <summary>References to IPGroup in workspaces to populate ipGroupIds.</summary>
    [JsonPropertyName("ipGroupIdsRefs")]
    public IList<V1beta1DirectorySpecForProviderIpGroupIdsRefs>? IpGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of IPGroup in workspaces to populate ipGroupIds.</summary>
    [JsonPropertyName("ipGroupIdsSelector")]
    public V1beta1DirectorySpecForProviderIpGroupIdsSelector? IpGroupIdsSelector { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Configuration of SAML authentication integration. Defined below.</summary>
    [JsonPropertyName("samlProperties")]
    public V1beta1DirectorySpecForProviderSamlProperties? SamlProperties { get; set; }

    /// <summary>Permissions to enable or disable self-service capabilities when workspace_type is set to PERSONAL.. Defined below.</summary>
    [JsonPropertyName("selfServicePermissions")]
    public V1beta1DirectorySpecForProviderSelfServicePermissions? SelfServicePermissions { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1DirectorySpecForProviderSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1DirectorySpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The identifiers of the subnets where the directory resides.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Tenancy of the WorkSpaces directory. Valid values are DEDICATED or SHARED.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }

    /// <summary>Specifies the user identity type for the WorkSpaces directory. Valid values are CUSTOMER_MANAGED, AWS_DIRECTORY_SERVICE, AWS_IAM_IDENTITY_CENTER.</summary>
    [JsonPropertyName("userIdentityType")]
    public string? UserIdentityType { get; set; }

    /// <summary>Specifies which devices and operating systems users can use to access their WorkSpaces. Defined below.</summary>
    [JsonPropertyName("workspaceAccessProperties")]
    public V1beta1DirectorySpecForProviderWorkspaceAccessProperties? WorkspaceAccessProperties { get; set; }

    /// <summary>Default properties that are used for creating WorkSpaces. Defined below.</summary>
    [JsonPropertyName("workspaceCreationProperties")]
    public V1beta1DirectorySpecForProviderWorkspaceCreationProperties? WorkspaceCreationProperties { get; set; }

    /// <summary>The description of the WorkSpaces directory when workspace_type is set to POOLS.</summary>
    [JsonPropertyName("workspaceDirectoryDescription")]
    public string? WorkspaceDirectoryDescription { get; set; }

    /// <summary>The name of the WorkSpaces directory when workspace_type is set to POOLS.</summary>
    [JsonPropertyName("workspaceDirectoryName")]
    public string? WorkspaceDirectoryName { get; set; }

    /// <summary>Specifies the type of WorkSpaces directory. Valid values are PERSONAL and POOLS. Default is PERSONAL.</summary>
    [JsonPropertyName("workspaceType")]
    public string? WorkspaceType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnRefPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnRefPolicyResolveEnum>))]
public enum V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretsmanager to populate serviceAccountSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnSelectorPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnSelectorPolicyResolveEnum>))]
public enum V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretsmanager to populate serviceAccountSecretArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnSelector
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
    public V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration for Active Directory integration when workspace_type is set to POOLS. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderActiveDirectoryConfig
{
    /// <summary>Fully qualified domain name of the AWS Directory Service directory.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>ARN of the Secrets Manager secret that contains the credentials for the service account. For more information, see Service Account Details.</summary>
    [JsonPropertyName("serviceAccountSecretArn")]
    public string? ServiceAccountSecretArn { get; set; }

    /// <summary>Reference to a Secret in secretsmanager to populate serviceAccountSecretArn.</summary>
    [JsonPropertyName("serviceAccountSecretArnRef")]
    public V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnRef? ServiceAccountSecretArnRef { get; set; }

    /// <summary>Selector for a Secret in secretsmanager to populate serviceAccountSecretArn.</summary>
    [JsonPropertyName("serviceAccountSecretArnSelector")]
    public V1beta1DirectorySpecInitProviderActiveDirectoryConfigServiceAccountSecretArnSelector? ServiceAccountSecretArnSelector { get; set; }
}

/// <summary>Configuration of certificate-based authentication (CBA) integration. Requires SAML authentication to be enabled. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderCertificateBasedAuthProperties
{
    /// <summary>The Amazon Resource Name (ARN) of the certificate manager private certificate authority (ACM-PCA) that is used for certificate-based authentication.</summary>
    [JsonPropertyName("certificateAuthorityArn")]
    public string? CertificateAuthorityArn { get; set; }

    /// <summary>Status of certificate-based authentication. Default DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderDirectoryIdRefPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecInitProviderDirectoryIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderDirectoryIdRefPolicyResolveEnum>))]
public enum V1beta1DirectorySpecInitProviderDirectoryIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderDirectoryIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecInitProviderDirectoryIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecInitProviderDirectoryIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Directory in ds to populate directoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderDirectoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DirectorySpecInitProviderDirectoryIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderDirectoryIdSelectorPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecInitProviderDirectoryIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderDirectoryIdSelectorPolicyResolveEnum>))]
public enum V1beta1DirectorySpecInitProviderDirectoryIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderDirectoryIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecInitProviderDirectoryIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecInitProviderDirectoryIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Directory in ds to populate directoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderDirectoryIdSelector
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
    public V1beta1DirectorySpecInitProviderDirectoryIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderIpGroupIdsRefsPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecInitProviderIpGroupIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderIpGroupIdsRefsPolicyResolveEnum>))]
public enum V1beta1DirectorySpecInitProviderIpGroupIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderIpGroupIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecInitProviderIpGroupIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecInitProviderIpGroupIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderIpGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DirectorySpecInitProviderIpGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderIpGroupIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecInitProviderIpGroupIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderIpGroupIdsSelectorPolicyResolveEnum>))]
public enum V1beta1DirectorySpecInitProviderIpGroupIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderIpGroupIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecInitProviderIpGroupIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecInitProviderIpGroupIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of IPGroup in workspaces to populate ipGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderIpGroupIdsSelector
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
    public V1beta1DirectorySpecInitProviderIpGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration of SAML authentication integration. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderSamlProperties
{
    /// <summary>The relay state parameter name supported by the SAML 2.0 identity provider (IdP). Default RelayState.</summary>
    [JsonPropertyName("relayStateParameterName")]
    public string? RelayStateParameterName { get; set; }

    /// <summary>Status of SAML 2.0 authentication. Default DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The SAML 2.0 identity provider (IdP) user access URL.</summary>
    [JsonPropertyName("userAccessUrl")]
    public string? UserAccessUrl { get; set; }
}

/// <summary>Permissions to enable or disable self-service capabilities when workspace_type is set to PERSONAL.. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderSelfServicePermissions
{
    /// <summary>Whether WorkSpaces directory users can change the compute type (bundle) for their workspace. Default false.</summary>
    [JsonPropertyName("changeComputeType")]
    public bool? ChangeComputeType { get; set; }

    /// <summary>Whether WorkSpaces directory users can increase the volume size of the drives on their workspace. Default false.</summary>
    [JsonPropertyName("increaseVolumeSize")]
    public bool? IncreaseVolumeSize { get; set; }

    /// <summary>Whether WorkSpaces directory users can rebuild the operating system of a workspace to its original state. Default false.</summary>
    [JsonPropertyName("rebuildWorkspace")]
    public bool? RebuildWorkspace { get; set; }

    /// <summary>Whether WorkSpaces directory users can restart their workspace. Default true.</summary>
    [JsonPropertyName("restartWorkspace")]
    public bool? RestartWorkspace { get; set; }

    /// <summary>Whether WorkSpaces directory users can switch the running mode of their workspace. Default false.</summary>
    [JsonPropertyName("switchRunningMode")]
    public bool? SwitchRunningMode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderSubnetIdRefsPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecInitProviderSubnetIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderSubnetIdRefsPolicyResolveEnum>))]
public enum V1beta1DirectorySpecInitProviderSubnetIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderSubnetIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecInitProviderSubnetIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecInitProviderSubnetIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DirectorySpecInitProviderSubnetIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecInitProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1DirectorySpecInitProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderSubnetIdSelector
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
    public V1beta1DirectorySpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies which devices and operating systems users can use to access their WorkSpaces. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderWorkspaceAccessProperties
{
    /// <summary>Indicates whether users can use Android devices to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeAndroid")]
    public string? DeviceTypeAndroid { get; set; }

    /// <summary>Indicates whether users can use Chromebooks to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeChromeos")]
    public string? DeviceTypeChromeos { get; set; }

    /// <summary>Indicates whether users can use iOS devices to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeIos")]
    public string? DeviceTypeIos { get; set; }

    /// <summary>Indicates whether users can use Linux clients to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeLinux")]
    public string? DeviceTypeLinux { get; set; }

    /// <summary>Indicates whether users can use macOS clients to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeOsx")]
    public string? DeviceTypeOsx { get; set; }

    /// <summary>Indicates whether users can access their WorkSpaces through a web browser.</summary>
    [JsonPropertyName("deviceTypeWeb")]
    public string? DeviceTypeWeb { get; set; }

    /// <summary>Indicates whether users can use Windows clients to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeWindows")]
    public string? DeviceTypeWindows { get; set; }

    /// <summary>Indicates whether users can use zero client devices to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeZeroclient")]
    public string? DeviceTypeZeroclient { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRefPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRefPolicyResolveEnum>))]
public enum V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecurityGroup in ec2 to populate customSecurityGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecurityGroup in ec2 to populate customSecurityGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelector
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
    public V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Default properties that are used for creating WorkSpaces. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpecInitProviderWorkspaceCreationProperties
{
    /// <summary>The identifier of your custom security group. Should relate to the same VPC, where workspaces reside in.</summary>
    [JsonPropertyName("customSecurityGroupId")]
    public string? CustomSecurityGroupId { get; set; }

    /// <summary>Reference to a SecurityGroup in ec2 to populate customSecurityGroupId.</summary>
    [JsonPropertyName("customSecurityGroupIdRef")]
    public V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdRef? CustomSecurityGroupIdRef { get; set; }

    /// <summary>Selector for a SecurityGroup in ec2 to populate customSecurityGroupId.</summary>
    [JsonPropertyName("customSecurityGroupIdSelector")]
    public V1beta1DirectorySpecInitProviderWorkspaceCreationPropertiesCustomSecurityGroupIdSelector? CustomSecurityGroupIdSelector { get; set; }

    /// <summary>The default organizational unit (OU) for your WorkSpace directories. Should conform &quot;OU=&lt;value&gt;,DC=&lt;value&gt;,...,DC=&lt;value&gt; &quot; pattern.</summary>
    [JsonPropertyName("defaultOu")]
    public string? DefaultOu { get; set; }

    /// <summary>Indicates whether internet access is enabled for your WorkSpaces.</summary>
    [JsonPropertyName("enableInternetAccess")]
    public bool? EnableInternetAccess { get; set; }

    /// <summary>Indicates whether maintenance mode is enabled for your WorkSpaces. Valid only if workspace_type is set to PERSONAL.</summary>
    [JsonPropertyName("enableMaintenanceMode")]
    public bool? EnableMaintenanceMode { get; set; }

    /// <summary>Indicates whether users are local administrators of their WorkSpaces. Valid only if workspace_type is set to PERSONAL.</summary>
    [JsonPropertyName("userEnabledAsLocalAdministrator")]
    public bool? UserEnabledAsLocalAdministrator { get; set; }
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
public partial class V1beta1DirectorySpecInitProvider
{
    /// <summary>Configuration for Active Directory integration when workspace_type is set to POOLS. Defined below.</summary>
    [JsonPropertyName("activeDirectoryConfig")]
    public V1beta1DirectorySpecInitProviderActiveDirectoryConfig? ActiveDirectoryConfig { get; set; }

    /// <summary>Configuration of certificate-based authentication (CBA) integration. Requires SAML authentication to be enabled. Defined below.</summary>
    [JsonPropertyName("certificateBasedAuthProperties")]
    public V1beta1DirectorySpecInitProviderCertificateBasedAuthProperties? CertificateBasedAuthProperties { get; set; }

    /// <summary>The directory identifier for registration in WorkSpaces service.</summary>
    [JsonPropertyName("directoryId")]
    public string? DirectoryId { get; set; }

    /// <summary>Reference to a Directory in ds to populate directoryId.</summary>
    [JsonPropertyName("directoryIdRef")]
    public V1beta1DirectorySpecInitProviderDirectoryIdRef? DirectoryIdRef { get; set; }

    /// <summary>Selector for a Directory in ds to populate directoryId.</summary>
    [JsonPropertyName("directoryIdSelector")]
    public V1beta1DirectorySpecInitProviderDirectoryIdSelector? DirectoryIdSelector { get; set; }

    /// <summary>The identifiers of the IP access control groups associated with the directory.</summary>
    [JsonPropertyName("ipGroupIds")]
    public IList<string>? IpGroupIds { get; set; }

    /// <summary>References to IPGroup in workspaces to populate ipGroupIds.</summary>
    [JsonPropertyName("ipGroupIdsRefs")]
    public IList<V1beta1DirectorySpecInitProviderIpGroupIdsRefs>? IpGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of IPGroup in workspaces to populate ipGroupIds.</summary>
    [JsonPropertyName("ipGroupIdsSelector")]
    public V1beta1DirectorySpecInitProviderIpGroupIdsSelector? IpGroupIdsSelector { get; set; }

    /// <summary>Configuration of SAML authentication integration. Defined below.</summary>
    [JsonPropertyName("samlProperties")]
    public V1beta1DirectorySpecInitProviderSamlProperties? SamlProperties { get; set; }

    /// <summary>Permissions to enable or disable self-service capabilities when workspace_type is set to PERSONAL.. Defined below.</summary>
    [JsonPropertyName("selfServicePermissions")]
    public V1beta1DirectorySpecInitProviderSelfServicePermissions? SelfServicePermissions { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta1DirectorySpecInitProviderSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1DirectorySpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>The identifiers of the subnets where the directory resides.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Tenancy of the WorkSpaces directory. Valid values are DEDICATED or SHARED.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }

    /// <summary>Specifies the user identity type for the WorkSpaces directory. Valid values are CUSTOMER_MANAGED, AWS_DIRECTORY_SERVICE, AWS_IAM_IDENTITY_CENTER.</summary>
    [JsonPropertyName("userIdentityType")]
    public string? UserIdentityType { get; set; }

    /// <summary>Specifies which devices and operating systems users can use to access their WorkSpaces. Defined below.</summary>
    [JsonPropertyName("workspaceAccessProperties")]
    public V1beta1DirectorySpecInitProviderWorkspaceAccessProperties? WorkspaceAccessProperties { get; set; }

    /// <summary>Default properties that are used for creating WorkSpaces. Defined below.</summary>
    [JsonPropertyName("workspaceCreationProperties")]
    public V1beta1DirectorySpecInitProviderWorkspaceCreationProperties? WorkspaceCreationProperties { get; set; }

    /// <summary>The description of the WorkSpaces directory when workspace_type is set to POOLS.</summary>
    [JsonPropertyName("workspaceDirectoryDescription")]
    public string? WorkspaceDirectoryDescription { get; set; }

    /// <summary>The name of the WorkSpaces directory when workspace_type is set to POOLS.</summary>
    [JsonPropertyName("workspaceDirectoryName")]
    public string? WorkspaceDirectoryName { get; set; }

    /// <summary>Specifies the type of WorkSpaces directory. Valid values are PERSONAL and POOLS. Default is PERSONAL.</summary>
    [JsonPropertyName("workspaceType")]
    public string? WorkspaceType { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DirectorySpecManagementPoliciesEnum>))]
public enum V1beta1DirectorySpecManagementPoliciesEnum
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
public partial class V1beta1DirectorySpecProviderConfigRef
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
public partial class V1beta1DirectorySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>DirectorySpec defines the desired state of Directory</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectorySpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1DirectorySpecForProvider ForProvider { get; set; }

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
    public V1beta1DirectorySpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1DirectorySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DirectorySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DirectorySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration for Active Directory integration when workspace_type is set to POOLS. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryStatusAtProviderActiveDirectoryConfig
{
    /// <summary>Fully qualified domain name of the AWS Directory Service directory.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>ARN of the Secrets Manager secret that contains the credentials for the service account. For more information, see Service Account Details.</summary>
    [JsonPropertyName("serviceAccountSecretArn")]
    public string? ServiceAccountSecretArn { get; set; }
}

/// <summary>Configuration of certificate-based authentication (CBA) integration. Requires SAML authentication to be enabled. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryStatusAtProviderCertificateBasedAuthProperties
{
    /// <summary>The Amazon Resource Name (ARN) of the certificate manager private certificate authority (ACM-PCA) that is used for certificate-based authentication.</summary>
    [JsonPropertyName("certificateAuthorityArn")]
    public string? CertificateAuthorityArn { get; set; }

    /// <summary>Status of certificate-based authentication. Default DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Configuration of SAML authentication integration. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryStatusAtProviderSamlProperties
{
    /// <summary>The relay state parameter name supported by the SAML 2.0 identity provider (IdP). Default RelayState.</summary>
    [JsonPropertyName("relayStateParameterName")]
    public string? RelayStateParameterName { get; set; }

    /// <summary>Status of SAML 2.0 authentication. Default DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The SAML 2.0 identity provider (IdP) user access URL.</summary>
    [JsonPropertyName("userAccessUrl")]
    public string? UserAccessUrl { get; set; }
}

/// <summary>Permissions to enable or disable self-service capabilities when workspace_type is set to PERSONAL.. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryStatusAtProviderSelfServicePermissions
{
    /// <summary>Whether WorkSpaces directory users can change the compute type (bundle) for their workspace. Default false.</summary>
    [JsonPropertyName("changeComputeType")]
    public bool? ChangeComputeType { get; set; }

    /// <summary>Whether WorkSpaces directory users can increase the volume size of the drives on their workspace. Default false.</summary>
    [JsonPropertyName("increaseVolumeSize")]
    public bool? IncreaseVolumeSize { get; set; }

    /// <summary>Whether WorkSpaces directory users can rebuild the operating system of a workspace to its original state. Default false.</summary>
    [JsonPropertyName("rebuildWorkspace")]
    public bool? RebuildWorkspace { get; set; }

    /// <summary>Whether WorkSpaces directory users can restart their workspace. Default true.</summary>
    [JsonPropertyName("restartWorkspace")]
    public bool? RestartWorkspace { get; set; }

    /// <summary>Whether WorkSpaces directory users can switch the running mode of their workspace. Default false.</summary>
    [JsonPropertyName("switchRunningMode")]
    public bool? SwitchRunningMode { get; set; }
}

/// <summary>Specifies which devices and operating systems users can use to access their WorkSpaces. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryStatusAtProviderWorkspaceAccessProperties
{
    /// <summary>Indicates whether users can use Android devices to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeAndroid")]
    public string? DeviceTypeAndroid { get; set; }

    /// <summary>Indicates whether users can use Chromebooks to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeChromeos")]
    public string? DeviceTypeChromeos { get; set; }

    /// <summary>Indicates whether users can use iOS devices to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeIos")]
    public string? DeviceTypeIos { get; set; }

    /// <summary>Indicates whether users can use Linux clients to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeLinux")]
    public string? DeviceTypeLinux { get; set; }

    /// <summary>Indicates whether users can use macOS clients to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeOsx")]
    public string? DeviceTypeOsx { get; set; }

    /// <summary>Indicates whether users can access their WorkSpaces through a web browser.</summary>
    [JsonPropertyName("deviceTypeWeb")]
    public string? DeviceTypeWeb { get; set; }

    /// <summary>Indicates whether users can use Windows clients to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeWindows")]
    public string? DeviceTypeWindows { get; set; }

    /// <summary>Indicates whether users can use zero client devices to access their WorkSpaces.</summary>
    [JsonPropertyName("deviceTypeZeroclient")]
    public string? DeviceTypeZeroclient { get; set; }
}

/// <summary>Default properties that are used for creating WorkSpaces. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryStatusAtProviderWorkspaceCreationProperties
{
    /// <summary>The identifier of your custom security group. Should relate to the same VPC, where workspaces reside in.</summary>
    [JsonPropertyName("customSecurityGroupId")]
    public string? CustomSecurityGroupId { get; set; }

    /// <summary>The default organizational unit (OU) for your WorkSpace directories. Should conform &quot;OU=&lt;value&gt;,DC=&lt;value&gt;,...,DC=&lt;value&gt; &quot; pattern.</summary>
    [JsonPropertyName("defaultOu")]
    public string? DefaultOu { get; set; }

    /// <summary>Indicates whether internet access is enabled for your WorkSpaces.</summary>
    [JsonPropertyName("enableInternetAccess")]
    public bool? EnableInternetAccess { get; set; }

    /// <summary>Indicates whether maintenance mode is enabled for your WorkSpaces. Valid only if workspace_type is set to PERSONAL.</summary>
    [JsonPropertyName("enableMaintenanceMode")]
    public bool? EnableMaintenanceMode { get; set; }

    /// <summary>Indicates whether users are local administrators of their WorkSpaces. Valid only if workspace_type is set to PERSONAL.</summary>
    [JsonPropertyName("userEnabledAsLocalAdministrator")]
    public bool? UserEnabledAsLocalAdministrator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryStatusAtProvider
{
    /// <summary>Configuration for Active Directory integration when workspace_type is set to POOLS. Defined below.</summary>
    [JsonPropertyName("activeDirectoryConfig")]
    public V1beta1DirectoryStatusAtProviderActiveDirectoryConfig? ActiveDirectoryConfig { get; set; }

    /// <summary>The directory alias.</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>Configuration of certificate-based authentication (CBA) integration. Requires SAML authentication to be enabled. Defined below.</summary>
    [JsonPropertyName("certificateBasedAuthProperties")]
    public V1beta1DirectoryStatusAtProviderCertificateBasedAuthProperties? CertificateBasedAuthProperties { get; set; }

    /// <summary>The user name for the service account.</summary>
    [JsonPropertyName("customerUserName")]
    public string? CustomerUserName { get; set; }

    /// <summary>The directory identifier for registration in WorkSpaces service.</summary>
    [JsonPropertyName("directoryId")]
    public string? DirectoryId { get; set; }

    /// <summary>The name of the directory.</summary>
    [JsonPropertyName("directoryName")]
    public string? DirectoryName { get; set; }

    /// <summary>The directory type.</summary>
    [JsonPropertyName("directoryType")]
    public string? DirectoryType { get; set; }

    /// <summary>The IP addresses of the DNS servers for the directory.</summary>
    [JsonPropertyName("dnsIpAddresses")]
    public IList<string>? DnsIpAddresses { get; set; }

    /// <summary>The identifier of the IAM role. This is the role that allows Amazon WorkSpaces to make calls to other services, such as Amazon EC2, on your behalf.</summary>
    [JsonPropertyName("iamRoleId")]
    public string? IamRoleId { get; set; }

    /// <summary>The WorkSpaces directory identifier.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The identifiers of the IP access control groups associated with the directory.</summary>
    [JsonPropertyName("ipGroupIds")]
    public IList<string>? IpGroupIds { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The registration code for the directory. This is the code that users enter in their Amazon WorkSpaces client application to connect to the directory.</summary>
    [JsonPropertyName("registrationCode")]
    public string? RegistrationCode { get; set; }

    /// <summary>Configuration of SAML authentication integration. Defined below.</summary>
    [JsonPropertyName("samlProperties")]
    public V1beta1DirectoryStatusAtProviderSamlProperties? SamlProperties { get; set; }

    /// <summary>Permissions to enable or disable self-service capabilities when workspace_type is set to PERSONAL.. Defined below.</summary>
    [JsonPropertyName("selfServicePermissions")]
    public V1beta1DirectoryStatusAtProviderSelfServicePermissions? SelfServicePermissions { get; set; }

    /// <summary>The identifiers of the subnets where the directory resides.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Tenancy of the WorkSpaces directory. Valid values are DEDICATED or SHARED.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }

    /// <summary>Specifies the user identity type for the WorkSpaces directory. Valid values are CUSTOMER_MANAGED, AWS_DIRECTORY_SERVICE, AWS_IAM_IDENTITY_CENTER.</summary>
    [JsonPropertyName("userIdentityType")]
    public string? UserIdentityType { get; set; }

    /// <summary>Specifies which devices and operating systems users can use to access their WorkSpaces. Defined below.</summary>
    [JsonPropertyName("workspaceAccessProperties")]
    public V1beta1DirectoryStatusAtProviderWorkspaceAccessProperties? WorkspaceAccessProperties { get; set; }

    /// <summary>Default properties that are used for creating WorkSpaces. Defined below.</summary>
    [JsonPropertyName("workspaceCreationProperties")]
    public V1beta1DirectoryStatusAtProviderWorkspaceCreationProperties? WorkspaceCreationProperties { get; set; }

    /// <summary>The description of the WorkSpaces directory when workspace_type is set to POOLS.</summary>
    [JsonPropertyName("workspaceDirectoryDescription")]
    public string? WorkspaceDirectoryDescription { get; set; }

    /// <summary>The name of the WorkSpaces directory when workspace_type is set to POOLS.</summary>
    [JsonPropertyName("workspaceDirectoryName")]
    public string? WorkspaceDirectoryName { get; set; }

    /// <summary>The identifier of the security group that is assigned to new WorkSpaces.</summary>
    [JsonPropertyName("workspaceSecurityGroupId")]
    public string? WorkspaceSecurityGroupId { get; set; }

    /// <summary>Specifies the type of WorkSpaces directory. Valid values are PERSONAL and POOLS. Default is PERSONAL.</summary>
    [JsonPropertyName("workspaceType")]
    public string? WorkspaceType { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryStatusConditions
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

/// <summary>DirectoryStatus defines the observed state of Directory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DirectoryStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1DirectoryStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DirectoryStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Directory is the Schema for the Directorys API. Provides a WorkSpaces directory in AWS WorkSpaces Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Directory : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DirectorySpec>, IStatus<V1beta1DirectoryStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Directory";
    public const string KubeGroup = "workspaces.aws.m.upbound.io";
    public const string KubePluralName = "directories";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "workspaces.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Directory";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DirectorySpec defines the desired state of Directory</summary>
    [JsonPropertyName("spec")]
    public required V1beta1DirectorySpec Spec { get; set; }

    /// <summary>DirectoryStatus defines the observed state of Directory.</summary>
    [JsonPropertyName("status")]
    public V1beta1DirectoryStatus? Status { get; set; }
}
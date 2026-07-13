#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.deployment.databricks.m.crossplane.io;
/// <summary>
/// MwsWorkspaces is the Schema for the MwsWorkspacess API.
/// Deprecated: This API version (v1alpha1) has been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MwsWorkspacesList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MwsWorkspaces>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MwsWorkspacesList";
    public const string KubeGroup = "deployment.databricks.m.crossplane.io";
    public const string KubePluralName = "mwsworkspaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "deployment.databricks.m.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MwsWorkspacesList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1MwsWorkspaces objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1MwsWorkspaces> Items { get; set; }
}

/// <summary>Account Id that could be found in the top right corner of Accounts Console.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderAccountIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderCloudResourceContainerGcp
{
    /// <summary>The Google Cloud project ID, which the workspace uses to instantiate cloud resources for your workspace.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderCloudResourceContainer
{
    /// <summary>A block that consists of the following field:</summary>
    [JsonPropertyName("gcp")]
    public IList<V1alpha1MwsWorkspacesSpecForProviderCloudResourceContainerGcp>? Gcp { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecForProviderCredentialsIdRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecForProviderCredentialsIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecForProviderCredentialsIdRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecForProviderCredentialsIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderCredentialsIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1MwsWorkspacesSpecForProviderCredentialsIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1MwsWorkspacesSpecForProviderCredentialsIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MwsCredentials in deployment to populate credentialsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderCredentialsIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MwsWorkspacesSpecForProviderCredentialsIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecForProviderCredentialsIdSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecForProviderCredentialsIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecForProviderCredentialsIdSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecForProviderCredentialsIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderCredentialsIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1MwsWorkspacesSpecForProviderCredentialsIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1MwsWorkspacesSpecForProviderCredentialsIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MwsCredentials in deployment to populate credentialsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderCredentialsIdSelector
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
    public V1alpha1MwsWorkspacesSpecForProviderCredentialsIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderExternalCustomerInfo
{
    [JsonPropertyName("authoritativeUserEmail")]
    public string? AuthoritativeUserEmail { get; set; }

    [JsonPropertyName("authoritativeUserFullName")]
    public string? AuthoritativeUserFullName { get; set; }

    [JsonPropertyName("customerName")]
    public string? CustomerName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderGcpManagedNetworkConfig
{
    [JsonPropertyName("gkeClusterPodIpRange")]
    public string? GkeClusterPodIpRange { get; set; }

    [JsonPropertyName("gkeClusterServiceIpRange")]
    public string? GkeClusterServiceIpRange { get; set; }

    [JsonPropertyName("subnetCidr")]
    public string? SubnetCidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderGkeConfig
{
    [JsonPropertyName("connectivityType")]
    public string? ConnectivityType { get; set; }

    [JsonPropertyName("masterIpRange")]
    public string? MasterIpRange { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecForProviderNetworkIdRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecForProviderNetworkIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecForProviderNetworkIdRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecForProviderNetworkIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderNetworkIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1MwsWorkspacesSpecForProviderNetworkIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1MwsWorkspacesSpecForProviderNetworkIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MwsNetworks in deployment to populate networkId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderNetworkIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MwsWorkspacesSpecForProviderNetworkIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecForProviderNetworkIdSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecForProviderNetworkIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecForProviderNetworkIdSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecForProviderNetworkIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderNetworkIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1MwsWorkspacesSpecForProviderNetworkIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1MwsWorkspacesSpecForProviderNetworkIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MwsNetworks in deployment to populate networkId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderNetworkIdSelector
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
    public V1alpha1MwsWorkspacesSpecForProviderNetworkIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MwsStorageConfigurations in deployment to populate storageConfigurationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MwsStorageConfigurations in deployment to populate storageConfigurationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdSelector
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
    public V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderTokenTokenValueSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProviderToken
{
    /// <summary>Comment, that will appear in &quot;User Settings / Access Tokens&quot; page on Workspace UI.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Token expiry lifetime. By default its 2592000 (30 days).</summary>
    [JsonPropertyName("lifetimeSeconds")]
    public double? LifetimeSeconds { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("tokenId")]
    public string? TokenId { get; set; }

    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("tokenValueSecretRef")]
    public V1alpha1MwsWorkspacesSpecForProviderTokenTokenValueSecretRef? TokenValueSecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecForProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console.</summary>
    [JsonPropertyName("accountIdSecretRef")]
    public V1alpha1MwsWorkspacesSpecForProviderAccountIdSecretRef? AccountIdSecretRef { get; set; }

    /// <summary>(AWS only) region of VPC.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    [JsonPropertyName("cloud")]
    public string? Cloud { get; set; }

    /// <summary>(GCP only) A block that specifies GCP workspace configurations, consisting of following blocks:</summary>
    [JsonPropertyName("cloudResourceContainer")]
    public IList<V1alpha1MwsWorkspacesSpecForProviderCloudResourceContainer>? CloudResourceContainer { get; set; }

    /// <summary>- The compute mode for the workspace. When unset, a classic workspace is created, and both credentials_id and storage_configuration_id must be specified. When set to SERVERLESS, the resulting workspace is a serverless workspace, and credentials_id and storage_configuration_id must not be set. The only allowed value for this is SERVERLESS. Changing this field requires recreation of the workspace.</summary>
    [JsonPropertyName("computeMode")]
    public string? ComputeMode { get; set; }

    /// <summary>(Integer) time when workspace was created</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>(AWS only, Optional) credentials_id from credentials. This must not be specified when compute_mode is set to SERVERLESS.</summary>
    [JsonPropertyName("credentialsId")]
    public string? CredentialsId { get; set; }

    /// <summary>Reference to a MwsCredentials in deployment to populate credentialsId.</summary>
    [JsonPropertyName("credentialsIdRef")]
    public V1alpha1MwsWorkspacesSpecForProviderCredentialsIdRef? CredentialsIdRef { get; set; }

    /// <summary>Selector for a MwsCredentials in deployment to populate credentialsId.</summary>
    [JsonPropertyName("credentialsIdSelector")]
    public V1alpha1MwsWorkspacesSpecForProviderCredentialsIdSelector? CredentialsIdSelector { get; set; }

    /// <summary>- The custom tags key-value pairing that is attached to this workspace. These tags will be applied to clusters automatically in addition to any default_tags or custom_tags on a cluster level. Please note it can take up to an hour for custom_tags to be set due to scheduling on Control Plane. After custom tags are applied, they can be modified however they can never be completely removed.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("customerManagedKeyId")]
    public string? CustomerManagedKeyId { get; set; }

    /// <summary>part of URL as in https://&lt;prefix&gt;-&lt;deployment-name&gt;.cloud.databricks.com. Deployment name cannot be used until a deployment name prefix is defined. Please contact your Databricks representative. Once a new deployment prefix is added/updated, it only will affect the new workspaces created.</summary>
    [JsonPropertyName("deploymentName")]
    public string? DeploymentName { get; set; }

    /// <summary>- The expected status of the workspace. When unset, it defaults to RUNNING. When set to PROVISIONING, workspace provisioning will pause and not enter RUNNING status. The only allowed values for this is RUNNING and PROVISIONING.</summary>
    [JsonPropertyName("expectedWorkspaceStatus")]
    public string? ExpectedWorkspaceStatus { get; set; }

    [JsonPropertyName("externalCustomerInfo")]
    public IList<V1alpha1MwsWorkspacesSpecForProviderExternalCustomerInfo>? ExternalCustomerInfo { get; set; }

    [JsonPropertyName("gcpManagedNetworkConfig")]
    public IList<V1alpha1MwsWorkspacesSpecForProviderGcpManagedNetworkConfig>? GcpManagedNetworkConfig { get; set; }

    [JsonPropertyName("gkeConfig")]
    public IList<V1alpha1MwsWorkspacesSpecForProviderGkeConfig>? GkeConfig { get; set; }

    [JsonPropertyName("isNoPublicIpEnabled")]
    public bool? IsNoPublicIpEnabled { get; set; }

    /// <summary>(GCP only) region of the subnet.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>customer_managed_key_id from customer managed keys with use_cases set to MANAGED_SERVICES. This is used to encrypt the workspace&apos;s notebook and secret data in the control plane.</summary>
    [JsonPropertyName("managedServicesCustomerManagedKeyId")]
    public string? ManagedServicesCustomerManagedKeyId { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary>network_id from networks.</summary>
    [JsonPropertyName("networkId")]
    public string? NetworkId { get; set; }

    /// <summary>Reference to a MwsNetworks in deployment to populate networkId.</summary>
    [JsonPropertyName("networkIdRef")]
    public V1alpha1MwsWorkspacesSpecForProviderNetworkIdRef? NetworkIdRef { get; set; }

    /// <summary>Selector for a MwsNetworks in deployment to populate networkId.</summary>
    [JsonPropertyName("networkIdSelector")]
    public V1alpha1MwsWorkspacesSpecForProviderNetworkIdSelector? NetworkIdSelector { get; set; }

    /// <summary>- The pricing tier of the workspace.</summary>
    [JsonPropertyName("pricingTier")]
    public string? PricingTier { get; set; }

    /// <summary>Canonical unique identifier of databricks_mws_private_access_settings in Databricks Account.</summary>
    [JsonPropertyName("privateAccessSettingsId")]
    public string? PrivateAccessSettingsId { get; set; }

    /// <summary>(AWS only, Optional) storage_configuration_id from storage configuration. This must not be specified when compute_mode is set to SERVERLESS.</summary>
    [JsonPropertyName("storageConfigurationId")]
    public string? StorageConfigurationId { get; set; }

    /// <summary>Reference to a MwsStorageConfigurations in deployment to populate storageConfigurationId.</summary>
    [JsonPropertyName("storageConfigurationIdRef")]
    public V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdRef? StorageConfigurationIdRef { get; set; }

    /// <summary>Selector for a MwsStorageConfigurations in deployment to populate storageConfigurationId.</summary>
    [JsonPropertyName("storageConfigurationIdSelector")]
    public V1alpha1MwsWorkspacesSpecForProviderStorageConfigurationIdSelector? StorageConfigurationIdSelector { get; set; }

    /// <summary>customer_managed_key_id from customer managed keys with use_cases set to STORAGE. This is used to encrypt the DBFS Storage &amp; Cluster Volumes.</summary>
    [JsonPropertyName("storageCustomerManagedKeyId")]
    public string? StorageCustomerManagedKeyId { get; set; }

    [JsonPropertyName("token")]
    public IList<V1alpha1MwsWorkspacesSpecForProviderToken>? Token { get; set; }

    /// <summary>(String) workspace id</summary>
    [JsonPropertyName("workspaceId")]
    public double? WorkspaceId { get; set; }

    /// <summary>name of the workspace, will appear on UI.</summary>
    [JsonPropertyName("workspaceName")]
    public string? WorkspaceName { get; set; }

    /// <summary>(String) workspace status</summary>
    [JsonPropertyName("workspaceStatus")]
    public string? WorkspaceStatus { get; set; }

    /// <summary>(String) updates on workspace status</summary>
    [JsonPropertyName("workspaceStatusMessage")]
    public string? WorkspaceStatusMessage { get; set; }

    /// <summary>(String) URL of the workspace</summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}

/// <summary>Account Id that could be found in the top right corner of Accounts Console.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderAccountIdSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderCloudResourceContainerGcp
{
    /// <summary>The Google Cloud project ID, which the workspace uses to instantiate cloud resources for your workspace.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderCloudResourceContainer
{
    /// <summary>A block that consists of the following field:</summary>
    [JsonPropertyName("gcp")]
    public IList<V1alpha1MwsWorkspacesSpecInitProviderCloudResourceContainerGcp>? Gcp { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MwsCredentials in deployment to populate credentialsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MwsCredentials in deployment to populate credentialsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdSelector
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
    public V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderExternalCustomerInfo
{
    [JsonPropertyName("authoritativeUserEmail")]
    public string? AuthoritativeUserEmail { get; set; }

    [JsonPropertyName("authoritativeUserFullName")]
    public string? AuthoritativeUserFullName { get; set; }

    [JsonPropertyName("customerName")]
    public string? CustomerName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderGcpManagedNetworkConfig
{
    [JsonPropertyName("gkeClusterPodIpRange")]
    public string? GkeClusterPodIpRange { get; set; }

    [JsonPropertyName("gkeClusterServiceIpRange")]
    public string? GkeClusterServiceIpRange { get; set; }

    [JsonPropertyName("subnetCidr")]
    public string? SubnetCidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderGkeConfig
{
    [JsonPropertyName("connectivityType")]
    public string? ConnectivityType { get; set; }

    [JsonPropertyName("masterIpRange")]
    public string? MasterIpRange { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecInitProviderNetworkIdRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecInitProviderNetworkIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecInitProviderNetworkIdRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecInitProviderNetworkIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderNetworkIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1MwsWorkspacesSpecInitProviderNetworkIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1MwsWorkspacesSpecInitProviderNetworkIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MwsNetworks in deployment to populate networkId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderNetworkIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MwsWorkspacesSpecInitProviderNetworkIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecInitProviderNetworkIdSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecInitProviderNetworkIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecInitProviderNetworkIdSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecInitProviderNetworkIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderNetworkIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1MwsWorkspacesSpecInitProviderNetworkIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1MwsWorkspacesSpecInitProviderNetworkIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MwsNetworks in deployment to populate networkId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderNetworkIdSelector
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
    public V1alpha1MwsWorkspacesSpecInitProviderNetworkIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MwsStorageConfigurations in deployment to populate storageConfigurationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MwsStorageConfigurations in deployment to populate storageConfigurationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdSelector
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
    public V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A LocalSecretKeySelector is a reference to a secret key
/// in the same namespace with the referencing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderTokenTokenValueSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProviderToken
{
    /// <summary>Comment, that will appear in &quot;User Settings / Access Tokens&quot; page on Workspace UI.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Token expiry lifetime. By default its 2592000 (30 days).</summary>
    [JsonPropertyName("lifetimeSeconds")]
    public double? LifetimeSeconds { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("tokenId")]
    public string? TokenId { get; set; }

    /// <summary>
    /// A LocalSecretKeySelector is a reference to a secret key
    /// in the same namespace with the referencing object.
    /// </summary>
    [JsonPropertyName("tokenValueSecretRef")]
    public V1alpha1MwsWorkspacesSpecInitProviderTokenTokenValueSecretRef? TokenValueSecretRef { get; set; }
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecInitProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console.</summary>
    [JsonPropertyName("accountIdSecretRef")]
    public required V1alpha1MwsWorkspacesSpecInitProviderAccountIdSecretRef AccountIdSecretRef { get; set; }

    /// <summary>(AWS only) region of VPC.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    [JsonPropertyName("cloud")]
    public string? Cloud { get; set; }

    /// <summary>(GCP only) A block that specifies GCP workspace configurations, consisting of following blocks:</summary>
    [JsonPropertyName("cloudResourceContainer")]
    public IList<V1alpha1MwsWorkspacesSpecInitProviderCloudResourceContainer>? CloudResourceContainer { get; set; }

    /// <summary>- The compute mode for the workspace. When unset, a classic workspace is created, and both credentials_id and storage_configuration_id must be specified. When set to SERVERLESS, the resulting workspace is a serverless workspace, and credentials_id and storage_configuration_id must not be set. The only allowed value for this is SERVERLESS. Changing this field requires recreation of the workspace.</summary>
    [JsonPropertyName("computeMode")]
    public string? ComputeMode { get; set; }

    /// <summary>(Integer) time when workspace was created</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>(AWS only, Optional) credentials_id from credentials. This must not be specified when compute_mode is set to SERVERLESS.</summary>
    [JsonPropertyName("credentialsId")]
    public string? CredentialsId { get; set; }

    /// <summary>Reference to a MwsCredentials in deployment to populate credentialsId.</summary>
    [JsonPropertyName("credentialsIdRef")]
    public V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdRef? CredentialsIdRef { get; set; }

    /// <summary>Selector for a MwsCredentials in deployment to populate credentialsId.</summary>
    [JsonPropertyName("credentialsIdSelector")]
    public V1alpha1MwsWorkspacesSpecInitProviderCredentialsIdSelector? CredentialsIdSelector { get; set; }

    /// <summary>- The custom tags key-value pairing that is attached to this workspace. These tags will be applied to clusters automatically in addition to any default_tags or custom_tags on a cluster level. Please note it can take up to an hour for custom_tags to be set due to scheduling on Control Plane. After custom tags are applied, they can be modified however they can never be completely removed.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("customerManagedKeyId")]
    public string? CustomerManagedKeyId { get; set; }

    /// <summary>part of URL as in https://&lt;prefix&gt;-&lt;deployment-name&gt;.cloud.databricks.com. Deployment name cannot be used until a deployment name prefix is defined. Please contact your Databricks representative. Once a new deployment prefix is added/updated, it only will affect the new workspaces created.</summary>
    [JsonPropertyName("deploymentName")]
    public string? DeploymentName { get; set; }

    /// <summary>- The expected status of the workspace. When unset, it defaults to RUNNING. When set to PROVISIONING, workspace provisioning will pause and not enter RUNNING status. The only allowed values for this is RUNNING and PROVISIONING.</summary>
    [JsonPropertyName("expectedWorkspaceStatus")]
    public string? ExpectedWorkspaceStatus { get; set; }

    [JsonPropertyName("externalCustomerInfo")]
    public IList<V1alpha1MwsWorkspacesSpecInitProviderExternalCustomerInfo>? ExternalCustomerInfo { get; set; }

    [JsonPropertyName("gcpManagedNetworkConfig")]
    public IList<V1alpha1MwsWorkspacesSpecInitProviderGcpManagedNetworkConfig>? GcpManagedNetworkConfig { get; set; }

    [JsonPropertyName("gkeConfig")]
    public IList<V1alpha1MwsWorkspacesSpecInitProviderGkeConfig>? GkeConfig { get; set; }

    [JsonPropertyName("isNoPublicIpEnabled")]
    public bool? IsNoPublicIpEnabled { get; set; }

    /// <summary>(GCP only) region of the subnet.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>customer_managed_key_id from customer managed keys with use_cases set to MANAGED_SERVICES. This is used to encrypt the workspace&apos;s notebook and secret data in the control plane.</summary>
    [JsonPropertyName("managedServicesCustomerManagedKeyId")]
    public string? ManagedServicesCustomerManagedKeyId { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary>network_id from networks.</summary>
    [JsonPropertyName("networkId")]
    public string? NetworkId { get; set; }

    /// <summary>Reference to a MwsNetworks in deployment to populate networkId.</summary>
    [JsonPropertyName("networkIdRef")]
    public V1alpha1MwsWorkspacesSpecInitProviderNetworkIdRef? NetworkIdRef { get; set; }

    /// <summary>Selector for a MwsNetworks in deployment to populate networkId.</summary>
    [JsonPropertyName("networkIdSelector")]
    public V1alpha1MwsWorkspacesSpecInitProviderNetworkIdSelector? NetworkIdSelector { get; set; }

    /// <summary>- The pricing tier of the workspace.</summary>
    [JsonPropertyName("pricingTier")]
    public string? PricingTier { get; set; }

    /// <summary>Canonical unique identifier of databricks_mws_private_access_settings in Databricks Account.</summary>
    [JsonPropertyName("privateAccessSettingsId")]
    public string? PrivateAccessSettingsId { get; set; }

    /// <summary>(AWS only, Optional) storage_configuration_id from storage configuration. This must not be specified when compute_mode is set to SERVERLESS.</summary>
    [JsonPropertyName("storageConfigurationId")]
    public string? StorageConfigurationId { get; set; }

    /// <summary>Reference to a MwsStorageConfigurations in deployment to populate storageConfigurationId.</summary>
    [JsonPropertyName("storageConfigurationIdRef")]
    public V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdRef? StorageConfigurationIdRef { get; set; }

    /// <summary>Selector for a MwsStorageConfigurations in deployment to populate storageConfigurationId.</summary>
    [JsonPropertyName("storageConfigurationIdSelector")]
    public V1alpha1MwsWorkspacesSpecInitProviderStorageConfigurationIdSelector? StorageConfigurationIdSelector { get; set; }

    /// <summary>customer_managed_key_id from customer managed keys with use_cases set to STORAGE. This is used to encrypt the DBFS Storage &amp; Cluster Volumes.</summary>
    [JsonPropertyName("storageCustomerManagedKeyId")]
    public string? StorageCustomerManagedKeyId { get; set; }

    [JsonPropertyName("token")]
    public IList<V1alpha1MwsWorkspacesSpecInitProviderToken>? Token { get; set; }

    /// <summary>(String) workspace id</summary>
    [JsonPropertyName("workspaceId")]
    public double? WorkspaceId { get; set; }

    /// <summary>name of the workspace, will appear on UI.</summary>
    [JsonPropertyName("workspaceName")]
    public string? WorkspaceName { get; set; }

    /// <summary>(String) workspace status</summary>
    [JsonPropertyName("workspaceStatus")]
    public string? WorkspaceStatus { get; set; }

    /// <summary>(String) updates on workspace status</summary>
    [JsonPropertyName("workspaceStatusMessage")]
    public string? WorkspaceStatusMessage { get; set; }

    /// <summary>(String) URL of the workspace</summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1MwsWorkspacesSpecManagementPoliciesEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1MwsWorkspacesSpecManagementPoliciesEnum
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecProviderConfigRef
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
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>MwsWorkspacesSpec defines the desired state of MwsWorkspaces</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesSpec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1MwsWorkspacesSpecForProvider ForProvider { get; set; }

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
    public V1alpha1MwsWorkspacesSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1MwsWorkspacesSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1MwsWorkspacesSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1MwsWorkspacesSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesStatusAtProviderCloudResourceContainerGcp
{
    /// <summary>The Google Cloud project ID, which the workspace uses to instantiate cloud resources for your workspace.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesStatusAtProviderCloudResourceContainer
{
    /// <summary>A block that consists of the following field:</summary>
    [JsonPropertyName("gcp")]
    public IList<V1alpha1MwsWorkspacesStatusAtProviderCloudResourceContainerGcp>? Gcp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesStatusAtProviderExternalCustomerInfo
{
    [JsonPropertyName("authoritativeUserEmail")]
    public string? AuthoritativeUserEmail { get; set; }

    [JsonPropertyName("authoritativeUserFullName")]
    public string? AuthoritativeUserFullName { get; set; }

    [JsonPropertyName("customerName")]
    public string? CustomerName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesStatusAtProviderGcpManagedNetworkConfig
{
    [JsonPropertyName("gkeClusterPodIpRange")]
    public string? GkeClusterPodIpRange { get; set; }

    [JsonPropertyName("gkeClusterServiceIpRange")]
    public string? GkeClusterServiceIpRange { get; set; }

    [JsonPropertyName("subnetCidr")]
    public string? SubnetCidr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesStatusAtProviderGkeConfig
{
    [JsonPropertyName("connectivityType")]
    public string? ConnectivityType { get; set; }

    [JsonPropertyName("masterIpRange")]
    public string? MasterIpRange { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesStatusAtProviderToken
{
    /// <summary>Comment, that will appear in &quot;User Settings / Access Tokens&quot; page on Workspace UI.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Token expiry lifetime. By default its 2592000 (30 days).</summary>
    [JsonPropertyName("lifetimeSeconds")]
    public double? LifetimeSeconds { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("tokenId")]
    public string? TokenId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesStatusAtProvider
{
    /// <summary>(AWS only) region of VPC.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    [JsonPropertyName("cloud")]
    public string? Cloud { get; set; }

    /// <summary>(GCP only) A block that specifies GCP workspace configurations, consisting of following blocks:</summary>
    [JsonPropertyName("cloudResourceContainer")]
    public IList<V1alpha1MwsWorkspacesStatusAtProviderCloudResourceContainer>? CloudResourceContainer { get; set; }

    /// <summary>- The compute mode for the workspace. When unset, a classic workspace is created, and both credentials_id and storage_configuration_id must be specified. When set to SERVERLESS, the resulting workspace is a serverless workspace, and credentials_id and storage_configuration_id must not be set. The only allowed value for this is SERVERLESS. Changing this field requires recreation of the workspace.</summary>
    [JsonPropertyName("computeMode")]
    public string? ComputeMode { get; set; }

    /// <summary>(Integer) time when workspace was created</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>(AWS only, Optional) credentials_id from credentials. This must not be specified when compute_mode is set to SERVERLESS.</summary>
    [JsonPropertyName("credentialsId")]
    public string? CredentialsId { get; set; }

    /// <summary>- The custom tags key-value pairing that is attached to this workspace. These tags will be applied to clusters automatically in addition to any default_tags or custom_tags on a cluster level. Please note it can take up to an hour for custom_tags to be set due to scheduling on Control Plane. After custom tags are applied, they can be modified however they can never be completely removed.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("customerManagedKeyId")]
    public string? CustomerManagedKeyId { get; set; }

    /// <summary>part of URL as in https://&lt;prefix&gt;-&lt;deployment-name&gt;.cloud.databricks.com. Deployment name cannot be used until a deployment name prefix is defined. Please contact your Databricks representative. Once a new deployment prefix is added/updated, it only will affect the new workspaces created.</summary>
    [JsonPropertyName("deploymentName")]
    public string? DeploymentName { get; set; }

    /// <summary>(String) The effective compute mode for the workspace. This is either SERVERLESS for serverless workspaces or HYBRID for classic workspaces.</summary>
    [JsonPropertyName("effectiveComputeMode")]
    public string? EffectiveComputeMode { get; set; }

    /// <summary>- The expected status of the workspace. When unset, it defaults to RUNNING. When set to PROVISIONING, workspace provisioning will pause and not enter RUNNING status. The only allowed values for this is RUNNING and PROVISIONING.</summary>
    [JsonPropertyName("expectedWorkspaceStatus")]
    public string? ExpectedWorkspaceStatus { get; set; }

    [JsonPropertyName("externalCustomerInfo")]
    public IList<V1alpha1MwsWorkspacesStatusAtProviderExternalCustomerInfo>? ExternalCustomerInfo { get; set; }

    [JsonPropertyName("gcpManagedNetworkConfig")]
    public IList<V1alpha1MwsWorkspacesStatusAtProviderGcpManagedNetworkConfig>? GcpManagedNetworkConfig { get; set; }

    /// <summary>(String, GCP only) identifier of a service account created for the workspace in form of db-&lt;workspace-id&gt;@prod-gcp-&lt;region&gt;.iam.gserviceaccount.com</summary>
    [JsonPropertyName("gcpWorkspaceSa")]
    public string? GcpWorkspaceSa { get; set; }

    [JsonPropertyName("gkeConfig")]
    public IList<V1alpha1MwsWorkspacesStatusAtProviderGkeConfig>? GkeConfig { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isNoPublicIpEnabled")]
    public bool? IsNoPublicIpEnabled { get; set; }

    /// <summary>(GCP only) region of the subnet.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>customer_managed_key_id from customer managed keys with use_cases set to MANAGED_SERVICES. This is used to encrypt the workspace&apos;s notebook and secret data in the control plane.</summary>
    [JsonPropertyName("managedServicesCustomerManagedKeyId")]
    public string? ManagedServicesCustomerManagedKeyId { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("networkConnectivityConfigId")]
    public string? NetworkConnectivityConfigId { get; set; }

    /// <summary>network_id from networks.</summary>
    [JsonPropertyName("networkId")]
    public string? NetworkId { get; set; }

    /// <summary>- The pricing tier of the workspace.</summary>
    [JsonPropertyName("pricingTier")]
    public string? PricingTier { get; set; }

    /// <summary>Canonical unique identifier of databricks_mws_private_access_settings in Databricks Account.</summary>
    [JsonPropertyName("privateAccessSettingsId")]
    public string? PrivateAccessSettingsId { get; set; }

    /// <summary>(AWS only, Optional) storage_configuration_id from storage configuration. This must not be specified when compute_mode is set to SERVERLESS.</summary>
    [JsonPropertyName("storageConfigurationId")]
    public string? StorageConfigurationId { get; set; }

    /// <summary>customer_managed_key_id from customer managed keys with use_cases set to STORAGE. This is used to encrypt the DBFS Storage &amp; Cluster Volumes.</summary>
    [JsonPropertyName("storageCustomerManagedKeyId")]
    public string? StorageCustomerManagedKeyId { get; set; }

    [JsonPropertyName("token")]
    public IList<V1alpha1MwsWorkspacesStatusAtProviderToken>? Token { get; set; }

    /// <summary>(String) workspace id</summary>
    [JsonPropertyName("workspaceId")]
    public double? WorkspaceId { get; set; }

    /// <summary>name of the workspace, will appear on UI.</summary>
    [JsonPropertyName("workspaceName")]
    public string? WorkspaceName { get; set; }

    /// <summary>(String) workspace status</summary>
    [JsonPropertyName("workspaceStatus")]
    public string? WorkspaceStatus { get; set; }

    /// <summary>(String) updates on workspace status</summary>
    [JsonPropertyName("workspaceStatusMessage")]
    public string? WorkspaceStatusMessage { get; set; }

    /// <summary>(String) URL of the workspace</summary>
    [JsonPropertyName("workspaceUrl")]
    public string? WorkspaceUrl { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesStatusConditions
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

/// <summary>MwsWorkspacesStatus defines the observed state of MwsWorkspaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1MwsWorkspacesStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1MwsWorkspacesStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MwsWorkspacesStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// MwsWorkspaces is the Schema for the MwsWorkspacess API.
/// Deprecated: This API version (v1alpha1) has been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MwsWorkspaces : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MwsWorkspacesSpec>, IStatus<V1alpha1MwsWorkspacesStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MwsWorkspaces";
    public const string KubeGroup = "deployment.databricks.m.crossplane.io";
    public const string KubePluralName = "mwsworkspaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "deployment.databricks.m.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MwsWorkspaces";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MwsWorkspacesSpec defines the desired state of MwsWorkspaces</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1MwsWorkspacesSpec Spec { get; set; }

    /// <summary>MwsWorkspacesStatus defines the observed state of MwsWorkspaces.</summary>
    [JsonPropertyName("status")]
    public V1alpha1MwsWorkspacesStatus? Status { get; set; }
}
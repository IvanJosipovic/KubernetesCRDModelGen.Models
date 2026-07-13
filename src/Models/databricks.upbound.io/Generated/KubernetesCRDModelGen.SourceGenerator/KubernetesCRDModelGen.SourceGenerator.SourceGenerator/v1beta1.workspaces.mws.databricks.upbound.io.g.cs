#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.mws.databricks.upbound.io;
/// <summary>Workspaces is the Schema for the Workspacess API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WorkspacesList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Workspaces>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WorkspacesList";
    public const string KubeGroup = "mws.databricks.upbound.io";
    public const string KubePluralName = "workspaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "mws.databricks.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkspacesList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Workspaces objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Workspaces> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecDeletionPolicyEnum>))]
public enum V1beta1WorkspacesSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A block that consists of the following field:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProviderCloudResourceContainerGcp
{
    /// <summary>The Google Cloud project ID, which the workspace uses to instantiate cloud resources for your workspace.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>(GCP only) A block that specifies GCP workspace configurations, consisting of following blocks:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProviderCloudResourceContainer
{
    /// <summary>A block that consists of the following field:</summary>
    [JsonPropertyName("gcp")]
    public V1beta1WorkspacesSpecForProviderCloudResourceContainerGcp? Gcp { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecForProviderCredentialsIdRefPolicyResolutionEnum>))]
public enum V1beta1WorkspacesSpecForProviderCredentialsIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecForProviderCredentialsIdRefPolicyResolveEnum>))]
public enum V1beta1WorkspacesSpecForProviderCredentialsIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProviderCredentialsIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkspacesSpecForProviderCredentialsIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkspacesSpecForProviderCredentialsIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Credentials in mws to populate credentialsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProviderCredentialsIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspacesSpecForProviderCredentialsIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecForProviderCredentialsIdSelectorPolicyResolutionEnum>))]
public enum V1beta1WorkspacesSpecForProviderCredentialsIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecForProviderCredentialsIdSelectorPolicyResolveEnum>))]
public enum V1beta1WorkspacesSpecForProviderCredentialsIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProviderCredentialsIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkspacesSpecForProviderCredentialsIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkspacesSpecForProviderCredentialsIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Credentials in mws to populate credentialsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProviderCredentialsIdSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspacesSpecForProviderCredentialsIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProviderExternalCustomerInfo
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
public partial class V1beta1WorkspacesSpecForProviderGcpManagedNetworkConfig
{
    [JsonPropertyName("gkeClusterPodIpRange")]
    public string? GkeClusterPodIpRange { get; set; }

    [JsonPropertyName("gkeClusterServiceIpRange")]
    public string? GkeClusterServiceIpRange { get; set; }

    [JsonPropertyName("subnetCidr")]
    public string? SubnetCidr { get; set; }
}

/// <summary>(GCP only) A block that specifies GKE configuration for the Databricks workspace:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProviderGkeConfig
{
    /// <summary>: Specifies the network connectivity types for the GKE nodes and the GKE master network. Possible values are: PRIVATE_NODE_PUBLIC_MASTER, PUBLIC_NODE_PUBLIC_MASTER.</summary>
    [JsonPropertyName("connectivityType")]
    public string? ConnectivityType { get; set; }

    /// <summary>: The IP range from which to allocate GKE cluster master resources. This field will be ignored if GKE private cluster is not enabled. It must be exactly as big as /28.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecForProviderNetworkIdRefPolicyResolutionEnum>))]
public enum V1beta1WorkspacesSpecForProviderNetworkIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecForProviderNetworkIdRefPolicyResolveEnum>))]
public enum V1beta1WorkspacesSpecForProviderNetworkIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProviderNetworkIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkspacesSpecForProviderNetworkIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkspacesSpecForProviderNetworkIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Networks in mws to populate networkId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProviderNetworkIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspacesSpecForProviderNetworkIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecForProviderNetworkIdSelectorPolicyResolutionEnum>))]
public enum V1beta1WorkspacesSpecForProviderNetworkIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecForProviderNetworkIdSelectorPolicyResolveEnum>))]
public enum V1beta1WorkspacesSpecForProviderNetworkIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProviderNetworkIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkspacesSpecForProviderNetworkIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkspacesSpecForProviderNetworkIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Networks in mws to populate networkId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProviderNetworkIdSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspacesSpecForProviderNetworkIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecForProviderStorageConfigurationIdRefPolicyResolutionEnum>))]
public enum V1beta1WorkspacesSpecForProviderStorageConfigurationIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecForProviderStorageConfigurationIdRefPolicyResolveEnum>))]
public enum V1beta1WorkspacesSpecForProviderStorageConfigurationIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProviderStorageConfigurationIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkspacesSpecForProviderStorageConfigurationIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkspacesSpecForProviderStorageConfigurationIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a StorageConfigurations in mws to populate storageConfigurationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProviderStorageConfigurationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspacesSpecForProviderStorageConfigurationIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecForProviderStorageConfigurationIdSelectorPolicyResolutionEnum>))]
public enum V1beta1WorkspacesSpecForProviderStorageConfigurationIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecForProviderStorageConfigurationIdSelectorPolicyResolveEnum>))]
public enum V1beta1WorkspacesSpecForProviderStorageConfigurationIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProviderStorageConfigurationIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkspacesSpecForProviderStorageConfigurationIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkspacesSpecForProviderStorageConfigurationIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a StorageConfigurations in mws to populate storageConfigurationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProviderStorageConfigurationIdSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspacesSpecForProviderStorageConfigurationIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProviderTokenTokenValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProviderToken
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

    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("tokenValueSecretRef")]
    public V1beta1WorkspacesSpecForProviderTokenTokenValueSecretRef? TokenValueSecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecForProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>(AWS only) region of VPC.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    [JsonPropertyName("cloud")]
    public string? Cloud { get; set; }

    /// <summary>(GCP only) A block that specifies GCP workspace configurations, consisting of following blocks:</summary>
    [JsonPropertyName("cloudResourceContainer")]
    public V1beta1WorkspacesSpecForProviderCloudResourceContainer? CloudResourceContainer { get; set; }

    /// <summary>(Integer) time when workspace was created</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("credentialsId")]
    public string? CredentialsId { get; set; }

    /// <summary>Reference to a Credentials in mws to populate credentialsId.</summary>
    [JsonPropertyName("credentialsIdRef")]
    public V1beta1WorkspacesSpecForProviderCredentialsIdRef? CredentialsIdRef { get; set; }

    /// <summary>Selector for a Credentials in mws to populate credentialsId.</summary>
    [JsonPropertyName("credentialsIdSelector")]
    public V1beta1WorkspacesSpecForProviderCredentialsIdSelector? CredentialsIdSelector { get; set; }

    /// <summary>- The custom tags key-value pairing that is attached to this workspace. These tags will be applied to clusters automatically in addition to any default_tags or custom_tags on a cluster level. Please note it can take up to an hour for custom_tags to be set due to scheduling on Control Plane. After custom tags are applied, they can be modified however they can never be completely removed.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("customerManagedKeyId")]
    public string? CustomerManagedKeyId { get; set; }

    /// <summary>part of URL as in https://&lt;prefix&gt;-&lt;deployment-name&gt;.cloud.databricks.com. Deployment name cannot be used until a deployment name prefix is defined. Please contact your Databricks representative. Once a new deployment prefix is added/updated, it only will affect the new workspaces created.</summary>
    [JsonPropertyName("deploymentName")]
    public string? DeploymentName { get; set; }

    [JsonPropertyName("externalCustomerInfo")]
    public V1beta1WorkspacesSpecForProviderExternalCustomerInfo? ExternalCustomerInfo { get; set; }

    [JsonPropertyName("gcpManagedNetworkConfig")]
    public V1beta1WorkspacesSpecForProviderGcpManagedNetworkConfig? GcpManagedNetworkConfig { get; set; }

    /// <summary>(GCP only) A block that specifies GKE configuration for the Databricks workspace:</summary>
    [JsonPropertyName("gkeConfig")]
    public V1beta1WorkspacesSpecForProviderGkeConfig? GkeConfig { get; set; }

    [JsonPropertyName("isNoPublicIpEnabled")]
    public bool? IsNoPublicIpEnabled { get; set; }

    /// <summary>(GCP only) region of the subnet.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>customer_managed_key_id from customer managed keys with use_cases set to MANAGED_SERVICES. This is used to encrypt the workspace&apos;s notebook and secret data in the control plane.</summary>
    [JsonPropertyName("managedServicesCustomerManagedKeyId")]
    public string? ManagedServicesCustomerManagedKeyId { get; set; }

    /// <summary>network_id from networks.</summary>
    [JsonPropertyName("networkId")]
    public string? NetworkId { get; set; }

    /// <summary>Reference to a Networks in mws to populate networkId.</summary>
    [JsonPropertyName("networkIdRef")]
    public V1beta1WorkspacesSpecForProviderNetworkIdRef? NetworkIdRef { get; set; }

    /// <summary>Selector for a Networks in mws to populate networkId.</summary>
    [JsonPropertyName("networkIdSelector")]
    public V1beta1WorkspacesSpecForProviderNetworkIdSelector? NetworkIdSelector { get; set; }

    /// <summary>- The pricing tier of the workspace.</summary>
    [JsonPropertyName("pricingTier")]
    public string? PricingTier { get; set; }

    /// <summary>Canonical unique identifier of databricks_mws_private_access_settings in Databricks Account.</summary>
    [JsonPropertyName("privateAccessSettingsId")]
    public string? PrivateAccessSettingsId { get; set; }

    /// <summary>(AWS only)storage_configuration_id from storage configuration.</summary>
    [JsonPropertyName("storageConfigurationId")]
    public string? StorageConfigurationId { get; set; }

    /// <summary>Reference to a StorageConfigurations in mws to populate storageConfigurationId.</summary>
    [JsonPropertyName("storageConfigurationIdRef")]
    public V1beta1WorkspacesSpecForProviderStorageConfigurationIdRef? StorageConfigurationIdRef { get; set; }

    /// <summary>Selector for a StorageConfigurations in mws to populate storageConfigurationId.</summary>
    [JsonPropertyName("storageConfigurationIdSelector")]
    public V1beta1WorkspacesSpecForProviderStorageConfigurationIdSelector? StorageConfigurationIdSelector { get; set; }

    /// <summary>customer_managed_key_id from customer managed keys with use_cases set to STORAGE. This is used to encrypt the DBFS Storage &amp; Cluster Volumes.</summary>
    [JsonPropertyName("storageCustomerManagedKeyId")]
    public string? StorageCustomerManagedKeyId { get; set; }

    [JsonPropertyName("token")]
    public V1beta1WorkspacesSpecForProviderToken? Token { get; set; }

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

/// <summary>A block that consists of the following field:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecInitProviderCloudResourceContainerGcp
{
    /// <summary>The Google Cloud project ID, which the workspace uses to instantiate cloud resources for your workspace.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>(GCP only) A block that specifies GCP workspace configurations, consisting of following blocks:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecInitProviderCloudResourceContainer
{
    /// <summary>A block that consists of the following field:</summary>
    [JsonPropertyName("gcp")]
    public V1beta1WorkspacesSpecInitProviderCloudResourceContainerGcp? Gcp { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecInitProviderCredentialsIdRefPolicyResolutionEnum>))]
public enum V1beta1WorkspacesSpecInitProviderCredentialsIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecInitProviderCredentialsIdRefPolicyResolveEnum>))]
public enum V1beta1WorkspacesSpecInitProviderCredentialsIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecInitProviderCredentialsIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkspacesSpecInitProviderCredentialsIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkspacesSpecInitProviderCredentialsIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Credentials in mws to populate credentialsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecInitProviderCredentialsIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspacesSpecInitProviderCredentialsIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecInitProviderCredentialsIdSelectorPolicyResolutionEnum>))]
public enum V1beta1WorkspacesSpecInitProviderCredentialsIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecInitProviderCredentialsIdSelectorPolicyResolveEnum>))]
public enum V1beta1WorkspacesSpecInitProviderCredentialsIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecInitProviderCredentialsIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkspacesSpecInitProviderCredentialsIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkspacesSpecInitProviderCredentialsIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Credentials in mws to populate credentialsId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecInitProviderCredentialsIdSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspacesSpecInitProviderCredentialsIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecInitProviderExternalCustomerInfo
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
public partial class V1beta1WorkspacesSpecInitProviderGcpManagedNetworkConfig
{
    [JsonPropertyName("gkeClusterPodIpRange")]
    public string? GkeClusterPodIpRange { get; set; }

    [JsonPropertyName("gkeClusterServiceIpRange")]
    public string? GkeClusterServiceIpRange { get; set; }

    [JsonPropertyName("subnetCidr")]
    public string? SubnetCidr { get; set; }
}

/// <summary>(GCP only) A block that specifies GKE configuration for the Databricks workspace:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecInitProviderGkeConfig
{
    /// <summary>: Specifies the network connectivity types for the GKE nodes and the GKE master network. Possible values are: PRIVATE_NODE_PUBLIC_MASTER, PUBLIC_NODE_PUBLIC_MASTER.</summary>
    [JsonPropertyName("connectivityType")]
    public string? ConnectivityType { get; set; }

    /// <summary>: The IP range from which to allocate GKE cluster master resources. This field will be ignored if GKE private cluster is not enabled. It must be exactly as big as /28.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecInitProviderNetworkIdRefPolicyResolutionEnum>))]
public enum V1beta1WorkspacesSpecInitProviderNetworkIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecInitProviderNetworkIdRefPolicyResolveEnum>))]
public enum V1beta1WorkspacesSpecInitProviderNetworkIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecInitProviderNetworkIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkspacesSpecInitProviderNetworkIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkspacesSpecInitProviderNetworkIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Networks in mws to populate networkId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecInitProviderNetworkIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspacesSpecInitProviderNetworkIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecInitProviderNetworkIdSelectorPolicyResolutionEnum>))]
public enum V1beta1WorkspacesSpecInitProviderNetworkIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecInitProviderNetworkIdSelectorPolicyResolveEnum>))]
public enum V1beta1WorkspacesSpecInitProviderNetworkIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecInitProviderNetworkIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkspacesSpecInitProviderNetworkIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkspacesSpecInitProviderNetworkIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Networks in mws to populate networkId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecInitProviderNetworkIdSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspacesSpecInitProviderNetworkIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecInitProviderStorageConfigurationIdRefPolicyResolutionEnum>))]
public enum V1beta1WorkspacesSpecInitProviderStorageConfigurationIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecInitProviderStorageConfigurationIdRefPolicyResolveEnum>))]
public enum V1beta1WorkspacesSpecInitProviderStorageConfigurationIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecInitProviderStorageConfigurationIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkspacesSpecInitProviderStorageConfigurationIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkspacesSpecInitProviderStorageConfigurationIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a StorageConfigurations in mws to populate storageConfigurationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecInitProviderStorageConfigurationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspacesSpecInitProviderStorageConfigurationIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecInitProviderStorageConfigurationIdSelectorPolicyResolutionEnum>))]
public enum V1beta1WorkspacesSpecInitProviderStorageConfigurationIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecInitProviderStorageConfigurationIdSelectorPolicyResolveEnum>))]
public enum V1beta1WorkspacesSpecInitProviderStorageConfigurationIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecInitProviderStorageConfigurationIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkspacesSpecInitProviderStorageConfigurationIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkspacesSpecInitProviderStorageConfigurationIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a StorageConfigurations in mws to populate storageConfigurationId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecInitProviderStorageConfigurationIdSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspacesSpecInitProviderStorageConfigurationIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecInitProviderTokenTokenValueSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecInitProviderToken
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

    /// <summary>A SecretKeySelector is a reference to a secret key in an arbitrary namespace.</summary>
    [JsonPropertyName("tokenValueSecretRef")]
    public V1beta1WorkspacesSpecInitProviderTokenTokenValueSecretRef? TokenValueSecretRef { get; set; }
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
public partial class V1beta1WorkspacesSpecInitProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>(AWS only) region of VPC.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    [JsonPropertyName("cloud")]
    public string? Cloud { get; set; }

    /// <summary>(GCP only) A block that specifies GCP workspace configurations, consisting of following blocks:</summary>
    [JsonPropertyName("cloudResourceContainer")]
    public V1beta1WorkspacesSpecInitProviderCloudResourceContainer? CloudResourceContainer { get; set; }

    /// <summary>(Integer) time when workspace was created</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("credentialsId")]
    public string? CredentialsId { get; set; }

    /// <summary>Reference to a Credentials in mws to populate credentialsId.</summary>
    [JsonPropertyName("credentialsIdRef")]
    public V1beta1WorkspacesSpecInitProviderCredentialsIdRef? CredentialsIdRef { get; set; }

    /// <summary>Selector for a Credentials in mws to populate credentialsId.</summary>
    [JsonPropertyName("credentialsIdSelector")]
    public V1beta1WorkspacesSpecInitProviderCredentialsIdSelector? CredentialsIdSelector { get; set; }

    /// <summary>- The custom tags key-value pairing that is attached to this workspace. These tags will be applied to clusters automatically in addition to any default_tags or custom_tags on a cluster level. Please note it can take up to an hour for custom_tags to be set due to scheduling on Control Plane. After custom tags are applied, they can be modified however they can never be completely removed.</summary>
    [JsonPropertyName("customTags")]
    public IDictionary<string, string>? CustomTags { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
    [JsonPropertyName("customerManagedKeyId")]
    public string? CustomerManagedKeyId { get; set; }

    /// <summary>part of URL as in https://&lt;prefix&gt;-&lt;deployment-name&gt;.cloud.databricks.com. Deployment name cannot be used until a deployment name prefix is defined. Please contact your Databricks representative. Once a new deployment prefix is added/updated, it only will affect the new workspaces created.</summary>
    [JsonPropertyName("deploymentName")]
    public string? DeploymentName { get; set; }

    [JsonPropertyName("externalCustomerInfo")]
    public V1beta1WorkspacesSpecInitProviderExternalCustomerInfo? ExternalCustomerInfo { get; set; }

    [JsonPropertyName("gcpManagedNetworkConfig")]
    public V1beta1WorkspacesSpecInitProviderGcpManagedNetworkConfig? GcpManagedNetworkConfig { get; set; }

    /// <summary>(GCP only) A block that specifies GKE configuration for the Databricks workspace:</summary>
    [JsonPropertyName("gkeConfig")]
    public V1beta1WorkspacesSpecInitProviderGkeConfig? GkeConfig { get; set; }

    [JsonPropertyName("isNoPublicIpEnabled")]
    public bool? IsNoPublicIpEnabled { get; set; }

    /// <summary>(GCP only) region of the subnet.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>customer_managed_key_id from customer managed keys with use_cases set to MANAGED_SERVICES. This is used to encrypt the workspace&apos;s notebook and secret data in the control plane.</summary>
    [JsonPropertyName("managedServicesCustomerManagedKeyId")]
    public string? ManagedServicesCustomerManagedKeyId { get; set; }

    /// <summary>network_id from networks.</summary>
    [JsonPropertyName("networkId")]
    public string? NetworkId { get; set; }

    /// <summary>Reference to a Networks in mws to populate networkId.</summary>
    [JsonPropertyName("networkIdRef")]
    public V1beta1WorkspacesSpecInitProviderNetworkIdRef? NetworkIdRef { get; set; }

    /// <summary>Selector for a Networks in mws to populate networkId.</summary>
    [JsonPropertyName("networkIdSelector")]
    public V1beta1WorkspacesSpecInitProviderNetworkIdSelector? NetworkIdSelector { get; set; }

    /// <summary>- The pricing tier of the workspace.</summary>
    [JsonPropertyName("pricingTier")]
    public string? PricingTier { get; set; }

    /// <summary>Canonical unique identifier of databricks_mws_private_access_settings in Databricks Account.</summary>
    [JsonPropertyName("privateAccessSettingsId")]
    public string? PrivateAccessSettingsId { get; set; }

    /// <summary>(AWS only)storage_configuration_id from storage configuration.</summary>
    [JsonPropertyName("storageConfigurationId")]
    public string? StorageConfigurationId { get; set; }

    /// <summary>Reference to a StorageConfigurations in mws to populate storageConfigurationId.</summary>
    [JsonPropertyName("storageConfigurationIdRef")]
    public V1beta1WorkspacesSpecInitProviderStorageConfigurationIdRef? StorageConfigurationIdRef { get; set; }

    /// <summary>Selector for a StorageConfigurations in mws to populate storageConfigurationId.</summary>
    [JsonPropertyName("storageConfigurationIdSelector")]
    public V1beta1WorkspacesSpecInitProviderStorageConfigurationIdSelector? StorageConfigurationIdSelector { get; set; }

    /// <summary>customer_managed_key_id from customer managed keys with use_cases set to STORAGE. This is used to encrypt the DBFS Storage &amp; Cluster Volumes.</summary>
    [JsonPropertyName("storageCustomerManagedKeyId")]
    public string? StorageCustomerManagedKeyId { get; set; }

    [JsonPropertyName("token")]
    public V1beta1WorkspacesSpecInitProviderToken? Token { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecManagementPoliciesEnum>))]
public enum V1beta1WorkspacesSpecManagementPoliciesEnum
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
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1WorkspacesSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspacesSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1WorkspacesSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkspacesSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkspacesSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspacesSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>WorkspacesSpec defines the desired state of Workspaces</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesSpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta1WorkspacesSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1WorkspacesSpecForProvider ForProvider { get; set; }

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
    public V1beta1WorkspacesSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1WorkspacesSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WorkspacesSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WorkspacesSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A block that consists of the following field:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesStatusAtProviderCloudResourceContainerGcp
{
    /// <summary>The Google Cloud project ID, which the workspace uses to instantiate cloud resources for your workspace.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary>(GCP only) A block that specifies GCP workspace configurations, consisting of following blocks:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesStatusAtProviderCloudResourceContainer
{
    /// <summary>A block that consists of the following field:</summary>
    [JsonPropertyName("gcp")]
    public V1beta1WorkspacesStatusAtProviderCloudResourceContainerGcp? Gcp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesStatusAtProviderExternalCustomerInfo
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
public partial class V1beta1WorkspacesStatusAtProviderGcpManagedNetworkConfig
{
    [JsonPropertyName("gkeClusterPodIpRange")]
    public string? GkeClusterPodIpRange { get; set; }

    [JsonPropertyName("gkeClusterServiceIpRange")]
    public string? GkeClusterServiceIpRange { get; set; }

    [JsonPropertyName("subnetCidr")]
    public string? SubnetCidr { get; set; }
}

/// <summary>(GCP only) A block that specifies GKE configuration for the Databricks workspace:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesStatusAtProviderGkeConfig
{
    /// <summary>: Specifies the network connectivity types for the GKE nodes and the GKE master network. Possible values are: PRIVATE_NODE_PUBLIC_MASTER, PUBLIC_NODE_PUBLIC_MASTER.</summary>
    [JsonPropertyName("connectivityType")]
    public string? ConnectivityType { get; set; }

    /// <summary>: The IP range from which to allocate GKE cluster master resources. This field will be ignored if GKE private cluster is not enabled. It must be exactly as big as /28.</summary>
    [JsonPropertyName("masterIpRange")]
    public string? MasterIpRange { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesStatusAtProviderToken
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
public partial class V1beta1WorkspacesStatusAtProvider
{
    /// <summary>Account Id that could be found in the top right corner of Accounts Console.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>(AWS only) region of VPC.</summary>
    [JsonPropertyName("awsRegion")]
    public string? AwsRegion { get; set; }

    [JsonPropertyName("cloud")]
    public string? Cloud { get; set; }

    /// <summary>(GCP only) A block that specifies GCP workspace configurations, consisting of following blocks:</summary>
    [JsonPropertyName("cloudResourceContainer")]
    public V1beta1WorkspacesStatusAtProviderCloudResourceContainer? CloudResourceContainer { get; set; }

    /// <summary>(Integer) time when workspace was created</summary>
    [JsonPropertyName("creationTime")]
    public double? CreationTime { get; set; }

    /// <summary>(String) Canonical unique identifier for the workspace, of the format &lt;account-id&gt;/&lt;workspace-id&gt;</summary>
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

    [JsonPropertyName("externalCustomerInfo")]
    public V1beta1WorkspacesStatusAtProviderExternalCustomerInfo? ExternalCustomerInfo { get; set; }

    [JsonPropertyName("gcpManagedNetworkConfig")]
    public V1beta1WorkspacesStatusAtProviderGcpManagedNetworkConfig? GcpManagedNetworkConfig { get; set; }

    /// <summary>(String, GCP only) identifier of a service account created for the workspace in form of db-&lt;workspace-id&gt;@prod-gcp-&lt;region&gt;.iam.gserviceaccount.com</summary>
    [JsonPropertyName("gcpWorkspaceSa")]
    public string? GcpWorkspaceSa { get; set; }

    /// <summary>(GCP only) A block that specifies GKE configuration for the Databricks workspace:</summary>
    [JsonPropertyName("gkeConfig")]
    public V1beta1WorkspacesStatusAtProviderGkeConfig? GkeConfig { get; set; }

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

    /// <summary>network_id from networks.</summary>
    [JsonPropertyName("networkId")]
    public string? NetworkId { get; set; }

    /// <summary>- The pricing tier of the workspace.</summary>
    [JsonPropertyName("pricingTier")]
    public string? PricingTier { get; set; }

    /// <summary>Canonical unique identifier of databricks_mws_private_access_settings in Databricks Account.</summary>
    [JsonPropertyName("privateAccessSettingsId")]
    public string? PrivateAccessSettingsId { get; set; }

    /// <summary>(AWS only)storage_configuration_id from storage configuration.</summary>
    [JsonPropertyName("storageConfigurationId")]
    public string? StorageConfigurationId { get; set; }

    /// <summary>customer_managed_key_id from customer managed keys with use_cases set to STORAGE. This is used to encrypt the DBFS Storage &amp; Cluster Volumes.</summary>
    [JsonPropertyName("storageCustomerManagedKeyId")]
    public string? StorageCustomerManagedKeyId { get; set; }

    [JsonPropertyName("token")]
    public V1beta1WorkspacesStatusAtProviderToken? Token { get; set; }

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
public partial class V1beta1WorkspacesStatusConditions
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

/// <summary>WorkspacesStatus defines the observed state of Workspaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspacesStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1WorkspacesStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WorkspacesStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Workspaces is the Schema for the Workspacess API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Workspaces : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WorkspacesSpec>, IStatus<V1beta1WorkspacesStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Workspaces";
    public const string KubeGroup = "mws.databricks.upbound.io";
    public const string KubePluralName = "workspaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "mws.databricks.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Workspaces";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkspacesSpec defines the desired state of Workspaces</summary>
    [JsonPropertyName("spec")]
    public required V1beta1WorkspacesSpec Spec { get; set; }

    /// <summary>WorkspacesStatus defines the observed state of Workspaces.</summary>
    [JsonPropertyName("status")]
    public V1beta1WorkspacesStatus? Status { get; set; }
}
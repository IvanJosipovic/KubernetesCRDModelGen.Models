#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.oracle.azure.upbound.io;
/// <summary>AutonomousDatabaseCloneFromBackup is the Schema for the AutonomousDatabaseCloneFromBackups API. Manages an autonomous database clone from backup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AutonomousDatabaseCloneFromBackupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AutonomousDatabaseCloneFromBackup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AutonomousDatabaseCloneFromBackupList";
    public const string KubeGroup = "oracle.azure.upbound.io";
    public const string KubePluralName = "autonomousdatabaseclonefrombackups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "oracle.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AutonomousDatabaseCloneFromBackupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1AutonomousDatabaseCloneFromBackup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1AutonomousDatabaseCloneFromBackup> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecDeletionPolicyEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>The password for the SYS, SYSTEM, and PDB Admin users. The password must be at least 12 characters long, and contain at least 1 uppercase, 1 lowercase, and 1 numeric character. It cannot contain the double quote symbol (&quot;) or the username &quot;admin,&quot; regardless of casing. Changing this forces a new Autonomous Database Clone to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderAdminPasswordSecretRef
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

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameSelector
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
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdRefPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdRefPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AutonomousDatabase in oracle to populate sourceAutonomousDatabaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdSelectorPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdSelectorPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AutonomousDatabase in oracle to populate sourceAutonomousDatabaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdSelector
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
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdRefPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdSelector
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
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecForProvider
{
    /// <summary>The password for the SYS, SYSTEM, and PDB Admin users. The password must be at least 12 characters long, and contain at least 1 uppercase, 1 lowercase, and 1 numeric character. It cannot contain the double quote symbol (&quot;) or the username &quot;admin,&quot; regardless of casing. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("adminPasswordSecretRef")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderAdminPasswordSecretRef? AdminPasswordSecretRef { get; set; }

    /// <summary>Defines the network access type for the Autonomous Database. If the property is explicitly set to an empty list, it allows secure public access to the database from any IP address. If specific ACL (Access Control List) values are provided, access will be restricted to only the specified IP addresses. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("allowedIpAddresses")]
    public IList<string>? AllowedIpAddresses { get; set; }

    /// <summary>Indicates if auto-scaling is enabled for the Autonomous Database CPU core count. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("autoScalingEnabled")]
    public bool? AutoScalingEnabled { get; set; }

    /// <summary>Indicates if auto-scaling is enabled for the Autonomous Database storage. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("autoScalingForStorageEnabled")]
    public bool? AutoScalingForStorageEnabled { get; set; }

    /// <summary>Retention period, in days, for backups. Possible values range between 1 and 60. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("backupRetentionPeriodInDays")]
    public double? BackupRetentionPeriodInDays { get; set; }

    /// <summary>The autonomous database backup time stamp to be used for a cloning autonomous database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("backupTimestamp")]
    public string? BackupTimestamp { get; set; }

    /// <summary>The character set for the autonomous database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("characterSet")]
    public string? CharacterSet { get; set; }

    /// <summary>The type of clone to create. Possible values are Full and Metadata. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("cloneType")]
    public string? CloneType { get; set; }

    /// <summary>The compute amount (CPUs) available to the database. Possible values range between 2.0 and 512.0. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("computeCount")]
    public double? ComputeCount { get; set; }

    /// <summary>The compute model of the Autonomous Database. Possible values are ECPU and OCPU. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("computeModel")]
    public string? ComputeModel { get; set; }

    /// <summary>Specifies a list of customer contact email addresses. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("customerContacts")]
    public IList<string>? CustomerContacts { get; set; }

    /// <summary>The maximum storage that can be allocated for the database, in terabytes. Possible values range between 1 and 384. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("dataStorageSizeInTb")]
    public double? DataStorageSizeInTb { get; set; }

    /// <summary>A valid Oracle Database version for Autonomous Database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("databaseVersion")]
    public string? DatabaseVersion { get; set; }

    /// <summary>The Autonomous Database workload type. Possible values are OLTP, DW, APEX, and AJD. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("databaseWorkload")]
    public string? DatabaseWorkload { get; set; }

    /// <summary>The user-friendly name for the Autonomous Database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The Oracle license model that applies to the Oracle Autonomous Database. Possible values are LicenseIncluded and BringYourOwnLicense. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("licenseModel")]
    public string? LicenseModel { get; set; }

    /// <summary>The Azure Region where the autonomous database clone from backup should exist. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies if the Autonomous Database requires mTLS connections. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("mtlsConnectionRequired")]
    public bool? MtlsConnectionRequired { get; set; }

    /// <summary>The national character set for the autonomous database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("nationalCharacterSet")]
    public string? NationalCharacterSet { get; set; }

    /// <summary>The name of the Resource Group where the autonomous database clone from backup should exist. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The ID of the source Autonomous Database to clone from. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("sourceAutonomousDatabaseId")]
    public string? SourceAutonomousDatabaseId { get; set; }

    /// <summary>Reference to a AutonomousDatabase in oracle to populate sourceAutonomousDatabaseId.</summary>
    [JsonPropertyName("sourceAutonomousDatabaseIdRef")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdRef? SourceAutonomousDatabaseIdRef { get; set; }

    /// <summary>Selector for a AutonomousDatabase in oracle to populate sourceAutonomousDatabaseId.</summary>
    [JsonPropertyName("sourceAutonomousDatabaseIdSelector")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSourceAutonomousDatabaseIdSelector? SourceAutonomousDatabaseIdSelector { get; set; }

    /// <summary>The ID of the subnet the resource is associated with. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the autonomous database clone from backup. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Virtual Network this Autonomous Database Clone should be created in. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }
}

/// <summary>The password for the SYS, SYSTEM, and PDB Admin users. The password must be at least 12 characters long, and contain at least 1 uppercase, 1 lowercase, and 1 numeric character. It cannot contain the double quote symbol (&quot;) or the username &quot;admin,&quot; regardless of casing. Changing this forces a new Autonomous Database Clone to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderAdminPasswordSecretRef
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

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdRefPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdRefPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AutonomousDatabase in oracle to populate sourceAutonomousDatabaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdSelectorPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdSelectorPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AutonomousDatabase in oracle to populate sourceAutonomousDatabaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdSelector
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
    public V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdRefPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdSelector
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
    public V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecInitProvider
{
    /// <summary>The password for the SYS, SYSTEM, and PDB Admin users. The password must be at least 12 characters long, and contain at least 1 uppercase, 1 lowercase, and 1 numeric character. It cannot contain the double quote symbol (&quot;) or the username &quot;admin,&quot; regardless of casing. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("adminPasswordSecretRef")]
    public required V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderAdminPasswordSecretRef AdminPasswordSecretRef { get; set; }

    /// <summary>Defines the network access type for the Autonomous Database. If the property is explicitly set to an empty list, it allows secure public access to the database from any IP address. If specific ACL (Access Control List) values are provided, access will be restricted to only the specified IP addresses. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("allowedIpAddresses")]
    public IList<string>? AllowedIpAddresses { get; set; }

    /// <summary>Indicates if auto-scaling is enabled for the Autonomous Database CPU core count. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("autoScalingEnabled")]
    public bool? AutoScalingEnabled { get; set; }

    /// <summary>Indicates if auto-scaling is enabled for the Autonomous Database storage. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("autoScalingForStorageEnabled")]
    public bool? AutoScalingForStorageEnabled { get; set; }

    /// <summary>Retention period, in days, for backups. Possible values range between 1 and 60. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("backupRetentionPeriodInDays")]
    public double? BackupRetentionPeriodInDays { get; set; }

    /// <summary>The autonomous database backup time stamp to be used for a cloning autonomous database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("backupTimestamp")]
    public string? BackupTimestamp { get; set; }

    /// <summary>The character set for the autonomous database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("characterSet")]
    public string? CharacterSet { get; set; }

    /// <summary>The type of clone to create. Possible values are Full and Metadata. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("cloneType")]
    public string? CloneType { get; set; }

    /// <summary>The compute amount (CPUs) available to the database. Possible values range between 2.0 and 512.0. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("computeCount")]
    public double? ComputeCount { get; set; }

    /// <summary>The compute model of the Autonomous Database. Possible values are ECPU and OCPU. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("computeModel")]
    public string? ComputeModel { get; set; }

    /// <summary>Specifies a list of customer contact email addresses. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("customerContacts")]
    public IList<string>? CustomerContacts { get; set; }

    /// <summary>The maximum storage that can be allocated for the database, in terabytes. Possible values range between 1 and 384. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("dataStorageSizeInTb")]
    public double? DataStorageSizeInTb { get; set; }

    /// <summary>A valid Oracle Database version for Autonomous Database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("databaseVersion")]
    public string? DatabaseVersion { get; set; }

    /// <summary>The Autonomous Database workload type. Possible values are OLTP, DW, APEX, and AJD. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("databaseWorkload")]
    public string? DatabaseWorkload { get; set; }

    /// <summary>The user-friendly name for the Autonomous Database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The Oracle license model that applies to the Oracle Autonomous Database. Possible values are LicenseIncluded and BringYourOwnLicense. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("licenseModel")]
    public string? LicenseModel { get; set; }

    /// <summary>The Azure Region where the autonomous database clone from backup should exist. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies if the Autonomous Database requires mTLS connections. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("mtlsConnectionRequired")]
    public bool? MtlsConnectionRequired { get; set; }

    /// <summary>The national character set for the autonomous database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("nationalCharacterSet")]
    public string? NationalCharacterSet { get; set; }

    /// <summary>The ID of the source Autonomous Database to clone from. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("sourceAutonomousDatabaseId")]
    public string? SourceAutonomousDatabaseId { get; set; }

    /// <summary>Reference to a AutonomousDatabase in oracle to populate sourceAutonomousDatabaseId.</summary>
    [JsonPropertyName("sourceAutonomousDatabaseIdRef")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdRef? SourceAutonomousDatabaseIdRef { get; set; }

    /// <summary>Selector for a AutonomousDatabase in oracle to populate sourceAutonomousDatabaseId.</summary>
    [JsonPropertyName("sourceAutonomousDatabaseIdSelector")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSourceAutonomousDatabaseIdSelector? SourceAutonomousDatabaseIdSelector { get; set; }

    /// <summary>The ID of the subnet the resource is associated with. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the autonomous database clone from backup. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Virtual Network this Autonomous Database Clone should be created in. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecManagementPoliciesEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromBackupSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromBackupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AutonomousDatabaseCloneFromBackupSpec defines the desired state of AutonomousDatabaseCloneFromBackup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupSpec
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
    public V1beta1AutonomousDatabaseCloneFromBackupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1AutonomousDatabaseCloneFromBackupSpecForProvider ForProvider { get; set; }

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
    public V1beta1AutonomousDatabaseCloneFromBackupSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1AutonomousDatabaseCloneFromBackupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AutonomousDatabaseCloneFromBackupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupStatusAtProvider
{
    /// <summary>Defines the network access type for the Autonomous Database. If the property is explicitly set to an empty list, it allows secure public access to the database from any IP address. If specific ACL (Access Control List) values are provided, access will be restricted to only the specified IP addresses. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("allowedIpAddresses")]
    public IList<string>? AllowedIpAddresses { get; set; }

    /// <summary>Indicates if auto-scaling is enabled for the Autonomous Database CPU core count. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("autoScalingEnabled")]
    public bool? AutoScalingEnabled { get; set; }

    /// <summary>Indicates if auto-scaling is enabled for the Autonomous Database storage. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("autoScalingForStorageEnabled")]
    public bool? AutoScalingForStorageEnabled { get; set; }

    /// <summary>Retention period, in days, for backups. Possible values range between 1 and 60. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("backupRetentionPeriodInDays")]
    public double? BackupRetentionPeriodInDays { get; set; }

    /// <summary>The autonomous database backup time stamp to be used for a cloning autonomous database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("backupTimestamp")]
    public string? BackupTimestamp { get; set; }

    /// <summary>The character set for the autonomous database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("characterSet")]
    public string? CharacterSet { get; set; }

    /// <summary>The type of clone to create. Possible values are Full and Metadata. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("cloneType")]
    public string? CloneType { get; set; }

    /// <summary>The compute amount (CPUs) available to the database. Possible values range between 2.0 and 512.0. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("computeCount")]
    public double? ComputeCount { get; set; }

    /// <summary>The compute model of the Autonomous Database. Possible values are ECPU and OCPU. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("computeModel")]
    public string? ComputeModel { get; set; }

    /// <summary>Specifies a list of customer contact email addresses. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("customerContacts")]
    public IList<string>? CustomerContacts { get; set; }

    /// <summary>The maximum storage that can be allocated for the database, in terabytes. Possible values range between 1 and 384. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("dataStorageSizeInTb")]
    public double? DataStorageSizeInTb { get; set; }

    /// <summary>A valid Oracle Database version for Autonomous Database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("databaseVersion")]
    public string? DatabaseVersion { get; set; }

    /// <summary>The Autonomous Database workload type. Possible values are OLTP, DW, APEX, and AJD. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("databaseWorkload")]
    public string? DatabaseWorkload { get; set; }

    /// <summary>The user-friendly name for the Autonomous Database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The ID of the autonomous database clone from backup.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Oracle license model that applies to the Oracle Autonomous Database. Possible values are LicenseIncluded and BringYourOwnLicense. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("licenseModel")]
    public string? LicenseModel { get; set; }

    /// <summary>The Azure Region where the autonomous database clone from backup should exist. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies if the Autonomous Database requires mTLS connections. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("mtlsConnectionRequired")]
    public bool? MtlsConnectionRequired { get; set; }

    /// <summary>The national character set for the autonomous database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("nationalCharacterSet")]
    public string? NationalCharacterSet { get; set; }

    /// <summary>The name of the Resource Group where the autonomous database clone from backup should exist. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The ID of the source Autonomous Database to clone from. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("sourceAutonomousDatabaseId")]
    public string? SourceAutonomousDatabaseId { get; set; }

    /// <summary>The ID of the subnet the resource is associated with. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>A mapping of tags which should be assigned to the autonomous database clone from backup. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Virtual Network this Autonomous Database Clone should be created in. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupStatusConditions
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

/// <summary>AutonomousDatabaseCloneFromBackupStatus defines the observed state of AutonomousDatabaseCloneFromBackup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromBackupStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1AutonomousDatabaseCloneFromBackupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AutonomousDatabaseCloneFromBackupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AutonomousDatabaseCloneFromBackup is the Schema for the AutonomousDatabaseCloneFromBackups API. Manages an autonomous database clone from backup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AutonomousDatabaseCloneFromBackup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AutonomousDatabaseCloneFromBackupSpec>, IStatus<V1beta1AutonomousDatabaseCloneFromBackupStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AutonomousDatabaseCloneFromBackup";
    public const string KubeGroup = "oracle.azure.upbound.io";
    public const string KubePluralName = "autonomousdatabaseclonefrombackups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "oracle.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AutonomousDatabaseCloneFromBackup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AutonomousDatabaseCloneFromBackupSpec defines the desired state of AutonomousDatabaseCloneFromBackup</summary>
    [JsonPropertyName("spec")]
    public required V1beta1AutonomousDatabaseCloneFromBackupSpec Spec { get; set; }

    /// <summary>AutonomousDatabaseCloneFromBackupStatus defines the observed state of AutonomousDatabaseCloneFromBackup.</summary>
    [JsonPropertyName("status")]
    public V1beta1AutonomousDatabaseCloneFromBackupStatus? Status { get; set; }
}
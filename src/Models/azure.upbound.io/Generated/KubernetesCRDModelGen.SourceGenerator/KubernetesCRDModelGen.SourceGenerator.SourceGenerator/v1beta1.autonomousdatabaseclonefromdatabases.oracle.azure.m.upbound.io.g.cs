#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.oracle.azure.m.upbound.io;
/// <summary>AutonomousDatabaseCloneFromDatabase is the Schema for the AutonomousDatabaseCloneFromDatabases API. Manages an autonomous database clone from database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AutonomousDatabaseCloneFromDatabase>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AutonomousDatabaseCloneFromDatabaseList";
    public const string KubeGroup = "oracle.azure.m.upbound.io";
    public const string KubePluralName = "autonomousdatabaseclonefromdatabases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "oracle.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AutonomousDatabaseCloneFromDatabaseList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1AutonomousDatabaseCloneFromDatabase objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1AutonomousDatabaseCloneFromDatabase> Items { get; set; }
}

/// <summary>The password for the SYS, SYSTEM, and PDB Admin users. The password must be at least 12 characters long, and contain at least 1 uppercase, 1 lowercase, and 1 numeric character. It cannot contain the double quote symbol (&quot;) or the username &quot;admin&quot;, regardless of casing. Changing this forces a new Autonomous Database Clone to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderAdminPasswordSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameSelector
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
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdRefPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdRefPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AutonomousDatabase in oracle to populate sourceAutonomousDatabaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdSelectorPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdSelectorPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AutonomousDatabase in oracle to populate sourceAutonomousDatabaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdSelector
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
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdRefPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdSelector
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
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProvider
{
    /// <summary>The password for the SYS, SYSTEM, and PDB Admin users. The password must be at least 12 characters long, and contain at least 1 uppercase, 1 lowercase, and 1 numeric character. It cannot contain the double quote symbol (&quot;) or the username &quot;admin&quot;, regardless of casing. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("adminPasswordSecretRef")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderAdminPasswordSecretRef? AdminPasswordSecretRef { get; set; }

    /// <summary>Defines the network access type for the Autonomous Database. If the property is explicitly set to an empty list, it allows secure public access to the database from any IP address. If specific ACL (Access Control List) values are provided, access will be restricted to only the specified IP addresses. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("allowedIpAddresses")]
    public IList<string>? AllowedIpAddresses { get; set; }

    /// <summary>Indicates if auto scaling is enabled for the Autonomous Database CPU core count. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("autoScalingEnabled")]
    public bool? AutoScalingEnabled { get; set; }

    /// <summary>Indicates if auto scaling is enabled for the Autonomous Database storage. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("autoScalingForStorageEnabled")]
    public bool? AutoScalingForStorageEnabled { get; set; }

    /// <summary>Retention period, in days, for backups. Possible values range between 1 and 60. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("backupRetentionPeriodInDays")]
    public double? BackupRetentionPeriodInDays { get; set; }

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

    /// <summary>Specifies a list of customer contacts as email addresses. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("customerContacts")]
    public IList<string>? CustomerContacts { get; set; }

    /// <summary>The maximum storage that can be allocated for the database, in terabytes. Possible values range between 1 and 384. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("dataStorageSizeInTb")]
    public double? DataStorageSizeInTb { get; set; }

    /// <summary>A valid Oracle Database version for Autonomous Database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("databaseVersion")]
    public string? DatabaseVersion { get; set; }

    /// <summary>The Autonomous Database workload type. Possible values are OLTP and DW, APEX, AJD. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("databaseWorkload")]
    public string? DatabaseWorkload { get; set; }

    /// <summary>The user-friendly name for the Autonomous Database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The Oracle license model that applies to the Oracle Autonomous Database. Possible values are LicenseIncluded and BringYourOwnLicense. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("licenseModel")]
    public string? LicenseModel { get; set; }

    /// <summary>The Azure Region where the Autonomous Database should exist. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies if the Autonomous Database requires mTLS connections. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("mtlsConnectionRequired")]
    public bool? MtlsConnectionRequired { get; set; }

    /// <summary>The national character set for the autonomous database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("nationalCharacterSet")]
    public string? NationalCharacterSet { get; set; }

    /// <summary>The refreshable model for the clone. Possible values are Automatic and Manual. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("refreshableModel")]
    public string? RefreshableModel { get; set; }

    /// <summary>The name of the Resource Group where the autonomous database clone from database should exist. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The ID of the source Autonomous Database to clone from. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("sourceAutonomousDatabaseId")]
    public string? SourceAutonomousDatabaseId { get; set; }

    /// <summary>Reference to a AutonomousDatabase in oracle to populate sourceAutonomousDatabaseId.</summary>
    [JsonPropertyName("sourceAutonomousDatabaseIdRef")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdRef? SourceAutonomousDatabaseIdRef { get; set; }

    /// <summary>Selector for a AutonomousDatabase in oracle to populate sourceAutonomousDatabaseId.</summary>
    [JsonPropertyName("sourceAutonomousDatabaseIdSelector")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSourceAutonomousDatabaseIdSelector? SourceAutonomousDatabaseIdSelector { get; set; }

    /// <summary>The ID of the subnet the resource is associated with. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A mapping of tags to assign to the Autonomous Database Clone. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Virtual Network this Autonomous Database Clone should be created in. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }
}

/// <summary>The password for the SYS, SYSTEM, and PDB Admin users. The password must be at least 12 characters long, and contain at least 1 uppercase, 1 lowercase, and 1 numeric character. It cannot contain the double quote symbol (&quot;) or the username &quot;admin&quot;, regardless of casing. Changing this forces a new Autonomous Database Clone to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderAdminPasswordSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdRefPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdRefPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AutonomousDatabase in oracle to populate sourceAutonomousDatabaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdSelectorPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdSelectorPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AutonomousDatabase in oracle to populate sourceAutonomousDatabaseId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdSelector
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
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdRefPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdSelector
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
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProvider
{
    /// <summary>The password for the SYS, SYSTEM, and PDB Admin users. The password must be at least 12 characters long, and contain at least 1 uppercase, 1 lowercase, and 1 numeric character. It cannot contain the double quote symbol (&quot;) or the username &quot;admin&quot;, regardless of casing. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("adminPasswordSecretRef")]
    public required V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderAdminPasswordSecretRef AdminPasswordSecretRef { get; set; }

    /// <summary>Defines the network access type for the Autonomous Database. If the property is explicitly set to an empty list, it allows secure public access to the database from any IP address. If specific ACL (Access Control List) values are provided, access will be restricted to only the specified IP addresses. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("allowedIpAddresses")]
    public IList<string>? AllowedIpAddresses { get; set; }

    /// <summary>Indicates if auto scaling is enabled for the Autonomous Database CPU core count. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("autoScalingEnabled")]
    public bool? AutoScalingEnabled { get; set; }

    /// <summary>Indicates if auto scaling is enabled for the Autonomous Database storage. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("autoScalingForStorageEnabled")]
    public bool? AutoScalingForStorageEnabled { get; set; }

    /// <summary>Retention period, in days, for backups. Possible values range between 1 and 60. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("backupRetentionPeriodInDays")]
    public double? BackupRetentionPeriodInDays { get; set; }

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

    /// <summary>Specifies a list of customer contacts as email addresses. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("customerContacts")]
    public IList<string>? CustomerContacts { get; set; }

    /// <summary>The maximum storage that can be allocated for the database, in terabytes. Possible values range between 1 and 384. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("dataStorageSizeInTb")]
    public double? DataStorageSizeInTb { get; set; }

    /// <summary>A valid Oracle Database version for Autonomous Database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("databaseVersion")]
    public string? DatabaseVersion { get; set; }

    /// <summary>The Autonomous Database workload type. Possible values are OLTP and DW, APEX, AJD. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("databaseWorkload")]
    public string? DatabaseWorkload { get; set; }

    /// <summary>The user-friendly name for the Autonomous Database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The Oracle license model that applies to the Oracle Autonomous Database. Possible values are LicenseIncluded and BringYourOwnLicense. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("licenseModel")]
    public string? LicenseModel { get; set; }

    /// <summary>The Azure Region where the Autonomous Database should exist. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies if the Autonomous Database requires mTLS connections. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("mtlsConnectionRequired")]
    public bool? MtlsConnectionRequired { get; set; }

    /// <summary>The national character set for the autonomous database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("nationalCharacterSet")]
    public string? NationalCharacterSet { get; set; }

    /// <summary>The refreshable model for the clone. Possible values are Automatic and Manual. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("refreshableModel")]
    public string? RefreshableModel { get; set; }

    /// <summary>The ID of the source Autonomous Database to clone from. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("sourceAutonomousDatabaseId")]
    public string? SourceAutonomousDatabaseId { get; set; }

    /// <summary>Reference to a AutonomousDatabase in oracle to populate sourceAutonomousDatabaseId.</summary>
    [JsonPropertyName("sourceAutonomousDatabaseIdRef")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdRef? SourceAutonomousDatabaseIdRef { get; set; }

    /// <summary>Selector for a AutonomousDatabase in oracle to populate sourceAutonomousDatabaseId.</summary>
    [JsonPropertyName("sourceAutonomousDatabaseIdSelector")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSourceAutonomousDatabaseIdSelector? SourceAutonomousDatabaseIdSelector { get; set; }

    /// <summary>The ID of the subnet the resource is associated with. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A mapping of tags to assign to the Autonomous Database Clone. Changing this forces a new Autonomous Database Clone to be created.</summary>
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutonomousDatabaseCloneFromDatabaseSpecManagementPoliciesEnum>))]
public enum V1beta1AutonomousDatabaseCloneFromDatabaseSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecProviderConfigRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>AutonomousDatabaseCloneFromDatabaseSpec defines the desired state of AutonomousDatabaseCloneFromDatabase</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1AutonomousDatabaseCloneFromDatabaseSpecForProvider ForProvider { get; set; }

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
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1AutonomousDatabaseCloneFromDatabaseSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseStatusAtProvider
{
    /// <summary>Defines the network access type for the Autonomous Database. If the property is explicitly set to an empty list, it allows secure public access to the database from any IP address. If specific ACL (Access Control List) values are provided, access will be restricted to only the specified IP addresses. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("allowedIpAddresses")]
    public IList<string>? AllowedIpAddresses { get; set; }

    /// <summary>Indicates if auto scaling is enabled for the Autonomous Database CPU core count. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("autoScalingEnabled")]
    public bool? AutoScalingEnabled { get; set; }

    /// <summary>Indicates if auto scaling is enabled for the Autonomous Database storage. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("autoScalingForStorageEnabled")]
    public bool? AutoScalingForStorageEnabled { get; set; }

    /// <summary>Retention period, in days, for backups. Possible values range between 1 and 60. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("backupRetentionPeriodInDays")]
    public double? BackupRetentionPeriodInDays { get; set; }

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

    /// <summary>Specifies a list of customer contacts as email addresses. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("customerContacts")]
    public IList<string>? CustomerContacts { get; set; }

    /// <summary>The maximum storage that can be allocated for the database, in terabytes. Possible values range between 1 and 384. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("dataStorageSizeInTb")]
    public double? DataStorageSizeInTb { get; set; }

    /// <summary>A valid Oracle Database version for Autonomous Database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("databaseVersion")]
    public string? DatabaseVersion { get; set; }

    /// <summary>The Autonomous Database workload type. Possible values are OLTP and DW, APEX, AJD. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("databaseWorkload")]
    public string? DatabaseWorkload { get; set; }

    /// <summary>The user-friendly name for the Autonomous Database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The ID of the autonomous database cloned from a database.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Oracle license model that applies to the Oracle Autonomous Database. Possible values are LicenseIncluded and BringYourOwnLicense. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("licenseModel")]
    public string? LicenseModel { get; set; }

    /// <summary>The Azure Region where the Autonomous Database should exist. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Specifies if the Autonomous Database requires mTLS connections. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("mtlsConnectionRequired")]
    public bool? MtlsConnectionRequired { get; set; }

    /// <summary>The national character set for the autonomous database. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("nationalCharacterSet")]
    public string? NationalCharacterSet { get; set; }

    /// <summary>The refreshable model for the clone. Possible values are Automatic and Manual. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("refreshableModel")]
    public string? RefreshableModel { get; set; }

    /// <summary>The name of the Resource Group where the autonomous database clone from database should exist. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The ID of the source Autonomous Database to clone from. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("sourceAutonomousDatabaseId")]
    public string? SourceAutonomousDatabaseId { get; set; }

    /// <summary>The ID of the subnet the resource is associated with. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>A mapping of tags to assign to the Autonomous Database Clone. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Virtual Network this Autonomous Database Clone should be created in. Changing this forces a new Autonomous Database Clone to be created.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseStatusConditions
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

/// <summary>AutonomousDatabaseCloneFromDatabaseStatus defines the observed state of AutonomousDatabaseCloneFromDatabase.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutonomousDatabaseCloneFromDatabaseStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AutonomousDatabaseCloneFromDatabaseStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AutonomousDatabaseCloneFromDatabase is the Schema for the AutonomousDatabaseCloneFromDatabases API. Manages an autonomous database clone from database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AutonomousDatabaseCloneFromDatabase : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AutonomousDatabaseCloneFromDatabaseSpec>, IStatus<V1beta1AutonomousDatabaseCloneFromDatabaseStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AutonomousDatabaseCloneFromDatabase";
    public const string KubeGroup = "oracle.azure.m.upbound.io";
    public const string KubePluralName = "autonomousdatabaseclonefromdatabases";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "oracle.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AutonomousDatabaseCloneFromDatabase";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AutonomousDatabaseCloneFromDatabaseSpec defines the desired state of AutonomousDatabaseCloneFromDatabase</summary>
    [JsonPropertyName("spec")]
    public required V1beta1AutonomousDatabaseCloneFromDatabaseSpec Spec { get; set; }

    /// <summary>AutonomousDatabaseCloneFromDatabaseStatus defines the observed state of AutonomousDatabaseCloneFromDatabase.</summary>
    [JsonPropertyName("status")]
    public V1beta1AutonomousDatabaseCloneFromDatabaseStatus? Status { get; set; }
}
#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.machinelearningservices.azure.m.upbound.io;
/// <summary>ComputeCluster is the Schema for the ComputeClusters API. Manages a Machine Learning Compute Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeCluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeClusterList";
    public const string KubeGroup = "machinelearningservices.azure.m.upbound.io";
    public const string KubePluralName = "computeclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "machinelearningservices.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ComputeCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ComputeCluster> Items { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Machine Learning Compute Cluster.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Machine Learning Compute Cluster. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdRefPolicyResolutionEnum>))]
public enum V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdRefPolicyResolveEnum>))]
public enum V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Workspace in machinelearningservices to populate machineLearningWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdSelectorPolicyResolutionEnum>))]
public enum V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdSelectorPolicyResolveEnum>))]
public enum V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Workspace in machinelearningservices to populate machineLearningWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdSelector
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
    public V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A scale_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecForProviderScaleSettings
{
    /// <summary>Maximum node count.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>Minimal node count.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }

    /// <summary>Node Idle Time Before Scale Down: defines the time until the compute is shutdown when it has gone into Idle state. Is defined according to W3C XML schema standard for duration.</summary>
    [JsonPropertyName("scaleDownNodesAfterIdleDuration")]
    public string? ScaleDownNodesAfterIdleDuration { get; set; }
}

/// <summary>Credentials for an administrator user account that will be created on each compute node. A ssh block as defined below. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecForProviderSsh
{
    /// <summary>Password of the administrator user account. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("adminPassword")]
    public string? AdminPassword { get; set; }

    /// <summary>Name of the administrator user account which can be used to SSH to nodes. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>SSH public key of the administrator user account. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("keyValue")]
    public string? KeyValue { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ComputeClusterSpecForProviderSubnetResourceIdRefPolicyResolutionEnum>))]
public enum V1beta1ComputeClusterSpecForProviderSubnetResourceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ComputeClusterSpecForProviderSubnetResourceIdRefPolicyResolveEnum>))]
public enum V1beta1ComputeClusterSpecForProviderSubnetResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecForProviderSubnetResourceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ComputeClusterSpecForProviderSubnetResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ComputeClusterSpecForProviderSubnetResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecForProviderSubnetResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeClusterSpecForProviderSubnetResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ComputeClusterSpecForProviderSubnetResourceIdSelectorPolicyResolutionEnum>))]
public enum V1beta1ComputeClusterSpecForProviderSubnetResourceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ComputeClusterSpecForProviderSubnetResourceIdSelectorPolicyResolveEnum>))]
public enum V1beta1ComputeClusterSpecForProviderSubnetResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecForProviderSubnetResourceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ComputeClusterSpecForProviderSubnetResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ComputeClusterSpecForProviderSubnetResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecForProviderSubnetResourceIdSelector
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
    public V1beta1ComputeClusterSpecForProviderSubnetResourceIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecForProvider
{
    /// <summary>The description of the Machine Learning compute. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ComputeClusterSpecForProviderIdentity? Identity { get; set; }

    /// <summary>Whether local authentication methods is enabled. Defaults to true. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("localAuthEnabled")]
    public bool? LocalAuthEnabled { get; set; }

    /// <summary>The Azure Region where the Machine Learning Compute Cluster should exist. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the Machine Learning Workspace. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("machineLearningWorkspaceId")]
    public string? MachineLearningWorkspaceId { get; set; }

    /// <summary>Reference to a Workspace in machinelearningservices to populate machineLearningWorkspaceId.</summary>
    [JsonPropertyName("machineLearningWorkspaceIdRef")]
    public V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdRef? MachineLearningWorkspaceIdRef { get; set; }

    /// <summary>Selector for a Workspace in machinelearningservices to populate machineLearningWorkspaceId.</summary>
    [JsonPropertyName("machineLearningWorkspaceIdSelector")]
    public V1beta1ComputeClusterSpecForProviderMachineLearningWorkspaceIdSelector? MachineLearningWorkspaceIdSelector { get; set; }

    /// <summary>The name which should be used for this Machine Learning Compute Cluster. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether the compute cluster will have a public ip. Defaults to true. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("nodePublicIpEnabled")]
    public bool? NodePublicIpEnabled { get; set; }

    /// <summary>A scale_settings block as defined below.</summary>
    [JsonPropertyName("scaleSettings")]
    public V1beta1ComputeClusterSpecForProviderScaleSettings? ScaleSettings { get; set; }

    /// <summary>Credentials for an administrator user account that will be created on each compute node. A ssh block as defined below. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("ssh")]
    public V1beta1ComputeClusterSpecForProviderSsh? Ssh { get; set; }

    /// <summary>A boolean value indicating whether enable the public SSH port. Defaults to false. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("sshPublicAccessEnabled")]
    public bool? SshPublicAccessEnabled { get; set; }

    /// <summary>The ID of the Subnet that the Compute Cluster should reside in. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("subnetResourceId")]
    public string? SubnetResourceId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetResourceId.</summary>
    [JsonPropertyName("subnetResourceIdRef")]
    public V1beta1ComputeClusterSpecForProviderSubnetResourceIdRef? SubnetResourceIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetResourceId.</summary>
    [JsonPropertyName("subnetResourceIdSelector")]
    public V1beta1ComputeClusterSpecForProviderSubnetResourceIdSelector? SubnetResourceIdSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Machine Learning Compute Cluster.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The priority of the VM. Changing this forces a new Machine Learning Compute Cluster to be created. Accepted values are Dedicated and LowPriority.</summary>
    [JsonPropertyName("vmPriority")]
    public string? VmPriority { get; set; }

    /// <summary>The size of the VM. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Machine Learning Compute Cluster.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Machine Learning Compute Cluster. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdRefPolicyResolutionEnum>))]
public enum V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdRefPolicyResolveEnum>))]
public enum V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Workspace in machinelearningservices to populate machineLearningWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdSelectorPolicyResolutionEnum>))]
public enum V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdSelectorPolicyResolveEnum>))]
public enum V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Workspace in machinelearningservices to populate machineLearningWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdSelector
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
    public V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A scale_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecInitProviderScaleSettings
{
    /// <summary>Maximum node count.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>Minimal node count.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }

    /// <summary>Node Idle Time Before Scale Down: defines the time until the compute is shutdown when it has gone into Idle state. Is defined according to W3C XML schema standard for duration.</summary>
    [JsonPropertyName("scaleDownNodesAfterIdleDuration")]
    public string? ScaleDownNodesAfterIdleDuration { get; set; }
}

/// <summary>Credentials for an administrator user account that will be created on each compute node. A ssh block as defined below. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecInitProviderSsh
{
    /// <summary>Password of the administrator user account. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("adminPassword")]
    public string? AdminPassword { get; set; }

    /// <summary>Name of the administrator user account which can be used to SSH to nodes. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>SSH public key of the administrator user account. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("keyValue")]
    public string? KeyValue { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ComputeClusterSpecInitProviderSubnetResourceIdRefPolicyResolutionEnum>))]
public enum V1beta1ComputeClusterSpecInitProviderSubnetResourceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ComputeClusterSpecInitProviderSubnetResourceIdRefPolicyResolveEnum>))]
public enum V1beta1ComputeClusterSpecInitProviderSubnetResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecInitProviderSubnetResourceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ComputeClusterSpecInitProviderSubnetResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ComputeClusterSpecInitProviderSubnetResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecInitProviderSubnetResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ComputeClusterSpecInitProviderSubnetResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ComputeClusterSpecInitProviderSubnetResourceIdSelectorPolicyResolutionEnum>))]
public enum V1beta1ComputeClusterSpecInitProviderSubnetResourceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ComputeClusterSpecInitProviderSubnetResourceIdSelectorPolicyResolveEnum>))]
public enum V1beta1ComputeClusterSpecInitProviderSubnetResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecInitProviderSubnetResourceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ComputeClusterSpecInitProviderSubnetResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ComputeClusterSpecInitProviderSubnetResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpecInitProviderSubnetResourceIdSelector
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
    public V1beta1ComputeClusterSpecInitProviderSubnetResourceIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1ComputeClusterSpecInitProvider
{
    /// <summary>The description of the Machine Learning compute. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ComputeClusterSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>Whether local authentication methods is enabled. Defaults to true. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("localAuthEnabled")]
    public bool? LocalAuthEnabled { get; set; }

    /// <summary>The Azure Region where the Machine Learning Compute Cluster should exist. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the Machine Learning Workspace. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("machineLearningWorkspaceId")]
    public string? MachineLearningWorkspaceId { get; set; }

    /// <summary>Reference to a Workspace in machinelearningservices to populate machineLearningWorkspaceId.</summary>
    [JsonPropertyName("machineLearningWorkspaceIdRef")]
    public V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdRef? MachineLearningWorkspaceIdRef { get; set; }

    /// <summary>Selector for a Workspace in machinelearningservices to populate machineLearningWorkspaceId.</summary>
    [JsonPropertyName("machineLearningWorkspaceIdSelector")]
    public V1beta1ComputeClusterSpecInitProviderMachineLearningWorkspaceIdSelector? MachineLearningWorkspaceIdSelector { get; set; }

    /// <summary>The name which should be used for this Machine Learning Compute Cluster. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether the compute cluster will have a public ip. Defaults to true. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("nodePublicIpEnabled")]
    public bool? NodePublicIpEnabled { get; set; }

    /// <summary>A scale_settings block as defined below.</summary>
    [JsonPropertyName("scaleSettings")]
    public V1beta1ComputeClusterSpecInitProviderScaleSettings? ScaleSettings { get; set; }

    /// <summary>Credentials for an administrator user account that will be created on each compute node. A ssh block as defined below. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("ssh")]
    public V1beta1ComputeClusterSpecInitProviderSsh? Ssh { get; set; }

    /// <summary>A boolean value indicating whether enable the public SSH port. Defaults to false. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("sshPublicAccessEnabled")]
    public bool? SshPublicAccessEnabled { get; set; }

    /// <summary>The ID of the Subnet that the Compute Cluster should reside in. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("subnetResourceId")]
    public string? SubnetResourceId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetResourceId.</summary>
    [JsonPropertyName("subnetResourceIdRef")]
    public V1beta1ComputeClusterSpecInitProviderSubnetResourceIdRef? SubnetResourceIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetResourceId.</summary>
    [JsonPropertyName("subnetResourceIdSelector")]
    public V1beta1ComputeClusterSpecInitProviderSubnetResourceIdSelector? SubnetResourceIdSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Machine Learning Compute Cluster.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The priority of the VM. Changing this forces a new Machine Learning Compute Cluster to be created. Accepted values are Dedicated and LowPriority.</summary>
    [JsonPropertyName("vmPriority")]
    public string? VmPriority { get; set; }

    /// <summary>The size of the VM. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ComputeClusterSpecManagementPoliciesEnum>))]
public enum V1beta1ComputeClusterSpecManagementPoliciesEnum
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
public partial class V1beta1ComputeClusterSpecProviderConfigRef
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
public partial class V1beta1ComputeClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ComputeClusterSpec defines the desired state of ComputeCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1ComputeClusterSpecForProvider ForProvider { get; set; }

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
    public V1beta1ComputeClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ComputeClusterSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ComputeClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ComputeClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Machine Learning Compute Cluster.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID for the Service Principal associated with the Managed Service Identity of this Machine Learning Compute Cluster.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID for the Service Principal associated with the Managed Service Identity of this Machine Learning Compute Cluster.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Machine Learning Compute Cluster. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A scale_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterStatusAtProviderScaleSettings
{
    /// <summary>Maximum node count.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>Minimal node count.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }

    /// <summary>Node Idle Time Before Scale Down: defines the time until the compute is shutdown when it has gone into Idle state. Is defined according to W3C XML schema standard for duration.</summary>
    [JsonPropertyName("scaleDownNodesAfterIdleDuration")]
    public string? ScaleDownNodesAfterIdleDuration { get; set; }
}

/// <summary>Credentials for an administrator user account that will be created on each compute node. A ssh block as defined below. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterStatusAtProviderSsh
{
    /// <summary>Password of the administrator user account. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("adminPassword")]
    public string? AdminPassword { get; set; }

    /// <summary>Name of the administrator user account which can be used to SSH to nodes. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>SSH public key of the administrator user account. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("keyValue")]
    public string? KeyValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterStatusAtProvider
{
    /// <summary>The description of the Machine Learning compute. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the Machine Learning Compute Cluster.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ComputeClusterStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>Whether local authentication methods is enabled. Defaults to true. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("localAuthEnabled")]
    public bool? LocalAuthEnabled { get; set; }

    /// <summary>The Azure Region where the Machine Learning Compute Cluster should exist. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the Machine Learning Workspace. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("machineLearningWorkspaceId")]
    public string? MachineLearningWorkspaceId { get; set; }

    /// <summary>The name which should be used for this Machine Learning Compute Cluster. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether the compute cluster will have a public ip. Defaults to true. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("nodePublicIpEnabled")]
    public bool? NodePublicIpEnabled { get; set; }

    /// <summary>A scale_settings block as defined below.</summary>
    [JsonPropertyName("scaleSettings")]
    public V1beta1ComputeClusterStatusAtProviderScaleSettings? ScaleSettings { get; set; }

    /// <summary>Credentials for an administrator user account that will be created on each compute node. A ssh block as defined below. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("ssh")]
    public V1beta1ComputeClusterStatusAtProviderSsh? Ssh { get; set; }

    /// <summary>A boolean value indicating whether enable the public SSH port. Defaults to false. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("sshPublicAccessEnabled")]
    public bool? SshPublicAccessEnabled { get; set; }

    /// <summary>The ID of the Subnet that the Compute Cluster should reside in. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("subnetResourceId")]
    public string? SubnetResourceId { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Machine Learning Compute Cluster.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The priority of the VM. Changing this forces a new Machine Learning Compute Cluster to be created. Accepted values are Dedicated and LowPriority.</summary>
    [JsonPropertyName("vmPriority")]
    public string? VmPriority { get; set; }

    /// <summary>The size of the VM. Changing this forces a new Machine Learning Compute Cluster to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterStatusConditions
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

/// <summary>ComputeClusterStatus defines the observed state of ComputeCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeClusterStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ComputeClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ComputeCluster is the Schema for the ComputeClusters API. Manages a Machine Learning Compute Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeClusterSpec>, IStatus<V1beta1ComputeClusterStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeCluster";
    public const string KubeGroup = "machinelearningservices.azure.m.upbound.io";
    public const string KubePluralName = "computeclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "machinelearningservices.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ComputeClusterSpec defines the desired state of ComputeCluster</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ComputeClusterSpec Spec { get; set; }

    /// <summary>ComputeClusterStatus defines the observed state of ComputeCluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeClusterStatus? Status { get; set; }
}
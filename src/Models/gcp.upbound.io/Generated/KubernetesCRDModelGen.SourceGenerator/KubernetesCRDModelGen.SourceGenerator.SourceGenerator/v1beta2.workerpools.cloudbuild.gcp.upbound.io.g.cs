#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudbuild.gcp.upbound.io;
/// <summary>WorkerPool is the Schema for the WorkerPools API. Configuration for custom WorkerPool to run builds</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2WorkerPoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta2WorkerPool>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "WorkerPoolList";
    public const string KubeGroup = "cloudbuild.gcp.upbound.io";
    public const string KubePluralName = "workerpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudbuild.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkerPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2WorkerPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2WorkerPool> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkerPoolSpecDeletionPolicyEnum>))]
public enum V1beta2WorkerPoolSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkRefPolicyResolutionEnum>))]
public enum V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkRefPolicyResolveEnum>))]
public enum V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate peeredNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkSelectorPolicyResolveEnum>))]
public enum V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate peeredNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkSelector
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
    public V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>Network configuration for the WorkerPool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpecForProviderNetworkConfig
{
    /// <summary>Immutable. The network definition that the workers are peered to. If this section is left empty, the workers will be peered to WorkerPool.project_id on the service producer network. Must be in the format projects/{project}/global/networks/{network}, where {project} is a project number, such as 12345, and {network} is the name of a VPC network in the project. See (https://cloud.google.com/cloud-build/docs/custom-workers/set-up-custom-worker-pool-environment#understanding_the_network_configuration_options)</summary>
    [JsonPropertyName("peeredNetwork")]
    public string? PeeredNetwork { get; set; }

    /// <summary>Immutable. Subnet IP range within the peered network. This is specified in CIDR notation with a slash and the subnet prefix size. You can optionally specify an IP address before the subnet prefix value. e.g. 192.168.0.0/29 would specify an IP range starting at 192.168.0.0 with a prefix size of 29 bits. /16 would specify a prefix size of 16 bits, with an automatically determined IP within the peered VPC. If unspecified, a value of /24 will be used.</summary>
    [JsonPropertyName("peeredNetworkIpRange")]
    public string? PeeredNetworkIpRange { get; set; }

    /// <summary>Reference to a Network in compute to populate peeredNetwork.</summary>
    [JsonPropertyName("peeredNetworkRef")]
    public V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkRef? PeeredNetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate peeredNetwork.</summary>
    [JsonPropertyName("peeredNetworkSelector")]
    public V1beta2WorkerPoolSpecForProviderNetworkConfigPeeredNetworkSelector? PeeredNetworkSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpecForProviderPrivateServiceConnect
{
    [JsonPropertyName("networkAttachment")]
    public string? NetworkAttachment { get; set; }

    [JsonPropertyName("routeAllTraffic")]
    public bool? RouteAllTraffic { get; set; }
}

/// <summary>Configuration to be used for a creating workers in the WorkerPool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpecForProviderWorkerConfig
{
    /// <summary>Size of the disk attached to the worker, in GB. See diskSizeGb. Specify a value of up to 1000. If 0 is specified, Cloud Build will use a standard disk size.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Machine type of a worker, such as n1-standard-1. See machineType. If left blank, Cloud Build will use n1-standard-1.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>If true, workers are created without any public address, which prevents network egress to public IPs.</summary>
    [JsonPropertyName("noExternalIp")]
    public bool? NoExternalIp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpecForProvider
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>User-defined name of the WorkerPool.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Network configuration for the WorkerPool. Structure is documented below.</summary>
    [JsonPropertyName("networkConfig")]
    public V1beta2WorkerPoolSpecForProviderNetworkConfig? NetworkConfig { get; set; }

    [JsonPropertyName("privateServiceConnect")]
    public V1beta2WorkerPoolSpecForProviderPrivateServiceConnect? PrivateServiceConnect { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Configuration to be used for a creating workers in the WorkerPool. Structure is documented below.</summary>
    [JsonPropertyName("workerConfig")]
    public V1beta2WorkerPoolSpecForProviderWorkerConfig? WorkerConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkRefPolicyResolutionEnum>))]
public enum V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkRefPolicyResolveEnum>))]
public enum V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate peeredNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkSelectorPolicyResolveEnum>))]
public enum V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate peeredNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkSelector
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
    public V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>Network configuration for the WorkerPool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpecInitProviderNetworkConfig
{
    /// <summary>Immutable. The network definition that the workers are peered to. If this section is left empty, the workers will be peered to WorkerPool.project_id on the service producer network. Must be in the format projects/{project}/global/networks/{network}, where {project} is a project number, such as 12345, and {network} is the name of a VPC network in the project. See (https://cloud.google.com/cloud-build/docs/custom-workers/set-up-custom-worker-pool-environment#understanding_the_network_configuration_options)</summary>
    [JsonPropertyName("peeredNetwork")]
    public string? PeeredNetwork { get; set; }

    /// <summary>Immutable. Subnet IP range within the peered network. This is specified in CIDR notation with a slash and the subnet prefix size. You can optionally specify an IP address before the subnet prefix value. e.g. 192.168.0.0/29 would specify an IP range starting at 192.168.0.0 with a prefix size of 29 bits. /16 would specify a prefix size of 16 bits, with an automatically determined IP within the peered VPC. If unspecified, a value of /24 will be used.</summary>
    [JsonPropertyName("peeredNetworkIpRange")]
    public string? PeeredNetworkIpRange { get; set; }

    /// <summary>Reference to a Network in compute to populate peeredNetwork.</summary>
    [JsonPropertyName("peeredNetworkRef")]
    public V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkRef? PeeredNetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate peeredNetwork.</summary>
    [JsonPropertyName("peeredNetworkSelector")]
    public V1beta2WorkerPoolSpecInitProviderNetworkConfigPeeredNetworkSelector? PeeredNetworkSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpecInitProviderPrivateServiceConnect
{
    [JsonPropertyName("networkAttachment")]
    public string? NetworkAttachment { get; set; }

    [JsonPropertyName("routeAllTraffic")]
    public bool? RouteAllTraffic { get; set; }
}

/// <summary>Configuration to be used for a creating workers in the WorkerPool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpecInitProviderWorkerConfig
{
    /// <summary>Size of the disk attached to the worker, in GB. See diskSizeGb. Specify a value of up to 1000. If 0 is specified, Cloud Build will use a standard disk size.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Machine type of a worker, such as n1-standard-1. See machineType. If left blank, Cloud Build will use n1-standard-1.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>If true, workers are created without any public address, which prevents network egress to public IPs.</summary>
    [JsonPropertyName("noExternalIp")]
    public bool? NoExternalIp { get; set; }
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
public partial class V1beta2WorkerPoolSpecInitProvider
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>User-defined name of the WorkerPool.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Network configuration for the WorkerPool. Structure is documented below.</summary>
    [JsonPropertyName("networkConfig")]
    public V1beta2WorkerPoolSpecInitProviderNetworkConfig? NetworkConfig { get; set; }

    [JsonPropertyName("privateServiceConnect")]
    public V1beta2WorkerPoolSpecInitProviderPrivateServiceConnect? PrivateServiceConnect { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Configuration to be used for a creating workers in the WorkerPool. Structure is documented below.</summary>
    [JsonPropertyName("workerConfig")]
    public V1beta2WorkerPoolSpecInitProviderWorkerConfig? WorkerConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkerPoolSpecManagementPoliciesEnum>))]
public enum V1beta2WorkerPoolSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkerPoolSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2WorkerPoolSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkerPoolSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2WorkerPoolSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkerPoolSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkerPoolSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkerPoolSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>WorkerPoolSpec defines the desired state of WorkerPool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolSpec
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
    public V1beta2WorkerPoolSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2WorkerPoolSpecForProvider ForProvider { get; set; }

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
    public V1beta2WorkerPoolSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2WorkerPoolSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2WorkerPoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2WorkerPoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Network configuration for the WorkerPool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolStatusAtProviderNetworkConfig
{
    /// <summary>Immutable. The network definition that the workers are peered to. If this section is left empty, the workers will be peered to WorkerPool.project_id on the service producer network. Must be in the format projects/{project}/global/networks/{network}, where {project} is a project number, such as 12345, and {network} is the name of a VPC network in the project. See (https://cloud.google.com/cloud-build/docs/custom-workers/set-up-custom-worker-pool-environment#understanding_the_network_configuration_options)</summary>
    [JsonPropertyName("peeredNetwork")]
    public string? PeeredNetwork { get; set; }

    /// <summary>Immutable. Subnet IP range within the peered network. This is specified in CIDR notation with a slash and the subnet prefix size. You can optionally specify an IP address before the subnet prefix value. e.g. 192.168.0.0/29 would specify an IP range starting at 192.168.0.0 with a prefix size of 29 bits. /16 would specify a prefix size of 16 bits, with an automatically determined IP within the peered VPC. If unspecified, a value of /24 will be used.</summary>
    [JsonPropertyName("peeredNetworkIpRange")]
    public string? PeeredNetworkIpRange { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolStatusAtProviderPrivateServiceConnect
{
    [JsonPropertyName("networkAttachment")]
    public string? NetworkAttachment { get; set; }

    [JsonPropertyName("routeAllTraffic")]
    public bool? RouteAllTraffic { get; set; }
}

/// <summary>Configuration to be used for a creating workers in the WorkerPool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolStatusAtProviderWorkerConfig
{
    /// <summary>Size of the disk attached to the worker, in GB. See diskSizeGb. Specify a value of up to 1000. If 0 is specified, Cloud Build will use a standard disk size.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Machine type of a worker, such as n1-standard-1. See machineType. If left blank, Cloud Build will use n1-standard-1.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>If true, workers are created without any public address, which prevents network egress to public IPs.</summary>
    [JsonPropertyName("noExternalIp")]
    public bool? NoExternalIp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolStatusAtProvider
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Output only. Time at which the request to create the WorkerPool was received.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Time at which the request to delete the WorkerPool was received.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>User-defined name of the WorkerPool.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("effectiveAnnotations")]
    public IDictionary<string, string>? EffectiveAnnotations { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/workerPools/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Network configuration for the WorkerPool. Structure is documented below.</summary>
    [JsonPropertyName("networkConfig")]
    public V1beta2WorkerPoolStatusAtProviderNetworkConfig? NetworkConfig { get; set; }

    [JsonPropertyName("privateServiceConnect")]
    public V1beta2WorkerPoolStatusAtProviderPrivateServiceConnect? PrivateServiceConnect { get; set; }

    /// <summary>The project for the resource</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Output only. WorkerPool state. Possible values: STATE_UNSPECIFIED, PENDING, APPROVED, REJECTED, CANCELLED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/workerPools/{{name}}</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. Time at which the request to update the WorkerPool was received.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Configuration to be used for a creating workers in the WorkerPool. Structure is documented below.</summary>
    [JsonPropertyName("workerConfig")]
    public V1beta2WorkerPoolStatusAtProviderWorkerConfig? WorkerConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolStatusConditions
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

/// <summary>WorkerPoolStatus defines the observed state of WorkerPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkerPoolStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2WorkerPoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2WorkerPoolStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>WorkerPool is the Schema for the WorkerPools API. Configuration for custom WorkerPool to run builds</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2WorkerPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2WorkerPoolSpec>, IStatus<V1beta2WorkerPoolStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "WorkerPool";
    public const string KubeGroup = "cloudbuild.gcp.upbound.io";
    public const string KubePluralName = "workerpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudbuild.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkerPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkerPoolSpec defines the desired state of WorkerPool</summary>
    [JsonPropertyName("spec")]
    public required V1beta2WorkerPoolSpec Spec { get; set; }

    /// <summary>WorkerPoolStatus defines the observed state of WorkerPool.</summary>
    [JsonPropertyName("status")]
    public V1beta2WorkerPoolStatus? Status { get; set; }
}